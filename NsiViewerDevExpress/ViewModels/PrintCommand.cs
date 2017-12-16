using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using DevExpress.DataAccess.Excel;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Printing;
using DevExpress.XtraSplashScreen;
using Microsoft.Win32;
using NsiViewerDevExpress.Common;
using NsiViewerDevExpress.Model;
using NsiViewerDevExpress.Views;
using Excel = Microsoft.Office.Interop.Excel ;

namespace NsiViewerDevExpress.ViewModels
{
    public class PrintCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public object GetValue(GM_NSIReferenceRecordAttribute attribute)
        {
            if (attribute.GM_NSIReferenceAttribute.ReferenceAttributeType == 0)
                return attribute.ValueString;
            if (attribute.GM_NSIReferenceAttribute.ReferenceAttributeType == 3)
                return attribute.ValueDate;
            if (attribute.GM_NSIReferenceAttribute.ReferenceAttributeType == 1)
                return attribute.ValueInteger;
            if (attribute.GM_NSIReferenceAttribute.ReferenceAttributeType == 2)
                return attribute.ValueReal;
            if (attribute.GM_NSIReferenceAttribute.ReferenceAttributeType == 4)
            {
                if (attribute.ValueRecord != null)
                {
                    return attribute.ValueRecord.RecordId;
                }
                else return "";
            }
            else return null;
        }

        public string GetValue(DynamicReferenceTypeProperty attribute)
        {
            return attribute.StringValue;
        }
        public string GetValue(string attribute)
        {
            return attribute;
        }

        public string Convertation(int attributeType, string referenceName)
        {
            if (attributeType == 0)
                return "String";
            if (attributeType == 1)
                return "Integer";
            if (attributeType == 2)
                return "Real";
            if (attributeType == 3)
                return "DateTime";
            if (attributeType == 4)
                return "RecordRecId:"+referenceName;
            else return "?";
        }

        public void Execute(object parameter)
        {
            
            HourGlass.Enable = true;
            TableView view = parameter as TableView;
            if (view == null)
                return;

            MainViewModel mainViewModel = view.DataContext as MainViewModel;
            PrintHelper.Instance.Header = mainViewModel != null
                ? string.Format("Код справочника НСИ: {0}\r\nНаименование справочника НСИ: {1}\r\nКод группы справочников НСИ: {2}\r\nГруппа: {3}",
                mainViewModel.SelectedNsi.ReferenceId ?? string.Empty,
                mainViewModel.SelectedNsi.ReferenceName ?? string.Empty,
                mainViewModel.SelectedNsi.ReferenceGroupId ?? string.Empty,
                mainViewModel.SelectedNsi.UserGroupId ?? string.Empty)
                : "Справочник";

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                DefaultExt = ".xlsx",
                InitialDirectory = @"C:\",
                Filter = "excel file (*.xlsx)|*.xlsx"
            };
            if (saveFileDialog.ShowDialog() == true)
            {
                SplashScreenManager.ShowForm(typeof(frmWaitForm), true, true);
                SplashScreenManager.Default.SetWaitFormCaption("Экспортирую...");
                var pathToSave = saveFileDialog.FileName;
                var excelApp = new Excel.Application();
                Excel.Workbook excelBook = excelApp.Workbooks.Add(true);
                Excel.Worksheet worksheet = (Excel.Worksheet)excelBook.ActiveSheet;
                Excel.Range cells = excelBook.Worksheets[1].Cells;
                cells.NumberFormat = "@";
                try
                {
                    SplashScreenManager.Default.SetWaitFormDescription("Экспорт Бизнес записей");
                    worksheet.Cells[1, 1] = "Код справочника НСИ";
                    worksheet.Cells[1, 2] = mainViewModel.SelectedNsi.ReferenceId ?? string.Empty;
                    worksheet.Cells[2, 1] = "Наименование справочника НСИ";
                    worksheet.Cells[2, 2] = mainViewModel.SelectedNsi.ReferenceName ?? string.Empty;
                    worksheet.Cells[3, 1] = "Код группы справочников НСИ";
                    worksheet.Cells[3, 2] = mainViewModel.SelectedNsi.ReferenceGroupId ?? string.Empty;
                    worksheet.Cells[4, 1] = "Группа";
                    worksheet.Cells[4, 2] = mainViewModel.SelectedNsi.UserGroupId ?? string.Empty;

                    worksheet.Cells[6, 1] = "RecordId";
                    worksheet.Cells[6, 2] = "RecordName";
                    worksheet.Cells[7, 1] = "Бизнес-ИД записи";
                    worksheet.Cells[7, 2] = "Описание записи справочника";
                    worksheet.Cells[8, 1] = "String";
                    worksheet.Cells[8, 2] = "String";
                    int columnIndex = 1;
                    int RowIndex = 9;
                    foreach (var record in mainViewModel.Records)
                    {
                        if (!mainViewModel.isExcel)
                        {
                            worksheet.Cells[RowIndex, columnIndex] = record.ValueDictionary.Values.ElementAtOrDefault(1);
                            worksheet.Cells[RowIndex, columnIndex + 1] = record.ValueDictionary.Values.ElementAtOrDefault(2);
                        }
                        else
                        {
                            worksheet.Cells[RowIndex, columnIndex] = record.ValueDictionary.Values.ElementAtOrDefault(0);
                            worksheet.Cells[RowIndex, columnIndex + 1] = record.ValueDictionary.Values.ElementAtOrDefault(1);
                        }
                        RowIndex++;
                    }
                    SplashScreenManager.Default.SetWaitFormDescription("Экспорт таблицы");
                    columnIndex = 3;
                    foreach (var MVM in mainViewModel.ReferenceAttributeCollection)
                    {
                        worksheet.Cells[6, columnIndex] = MVM.ReferenceAttributeId;
                        worksheet.Cells[7, columnIndex] = MVM.ReferenceAttributeName;
                        worksheet.Cells[8, columnIndex] = Convertation(MVM.ReferenceAttributeType, MVM.RefReferenceId);
                        RowIndex = 9;
                        foreach (var record in mainViewModel.Records)
                        {
                            foreach (var pair in record.ValueDictionary)
                            {
                                if (pair.Key == MVM.ReferenceAttributeName)
                                {
                                    worksheet.Cells[RowIndex, columnIndex] = pair.Value;
                                    RowIndex++;
                                    break;
                                }
                            }
                        }
                        columnIndex++;
                    }
                    
                    
                    worksheet.Columns.AutoFit();
                    excelBook.SaveAs(pathToSave);
                }
                catch(Exception e)
                {
                    MessageBox.Show("Что-то пошло не так :( " +e);
                }
                finally
                {
                    HourGlass.Enable = false;
                    SplashScreenManager.CloseForm();
                    excelBook.Close(0);
                    excelApp.Quit();
                } 
            }
        }
    }
}