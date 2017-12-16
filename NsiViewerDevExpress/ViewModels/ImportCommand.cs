using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using DevExpress.Data.Browsing;
using DevExpress.Xpf.Grid;
using DevExpress.XtraSplashScreen;
using Microsoft.Office.Interop.Excel;
using Microsoft.Win32;
using NsiViewerDevExpress.Common;
using NsiViewerDevExpress.Model;
using NsiViewerDevExpress.Views;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace NsiViewerDevExpress.ViewModels
{
    public class ImportCommand : ICommand
    {
        private _Worksheet worksheet = null;
        public ImportCommand()
        {
            
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public string GetValueExcel(int rowIndex, int columnIndex)
        {
            if ((worksheet.Cells[rowIndex, columnIndex] as Range).Value != null)
            {
                return (worksheet.Cells[rowIndex, columnIndex] as Range).Value.ToString();
            }
            else return "";
        }

        public int Convertation(string attributeType)
        {
            if (attributeType == "String")
                return 0;
            if (attributeType == "Integer")
                return 1;
            if (attributeType == "Real")
                return 2;
            if (attributeType == "DateTime")
                return 3;
            else 
            {
                return 4;
            }  
        }

        public void Execute(object parameter)
        {
            HourGlass.Enable = true;
            TableView view = parameter as TableView;
            if (view == null)
                return;

            MainViewModel mainViewModel = view.DataContext as MainViewModel;
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                DefaultExt = ".xlsx",
                InitialDirectory = @"C:\",
                Filter = "excel file (*.xlsx)|*.xlsx"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                SplashScreenManager.ShowForm(typeof(frmWaitForm), true, true);
                SplashScreenManager.Default.SetWaitFormCaption("Импортирую...");
                var excelApp = new Application();
                var workbook = excelApp.Workbooks.Open(openFileDialog.FileName);
                worksheet = (Worksheet)excelApp.ActiveSheet;
                try
                {

                    //last row,column excel
                    SplashScreenManager.Default.SetWaitFormDescription("Определение данных в таблице");
                    var lastRow = excelApp.Cells.SpecialCells(XlCellType.xlCellTypeLastCell).Row;
                    var lastColumn = excelApp.Cells.SpecialCells(XlCellType.xlCellTypeLastCell).Column;
                    for (int i = lastColumn; i >= 1 ; i-- )
                    {
                        if (GetValueExcel(7, i) == "")
                        {
                            lastColumn--;
                        }
                        else
                        {
                            break;
                        }
                    }

                    // блок атрибутов справочника
                    ObservableCollection<GM_NSIReferenceAttribute> listAttributes = new ObservableCollection<GM_NSIReferenceAttribute>();
                    
                    for (int i = 3; i <= lastColumn; i++)
                    {
                        GM_NSIReferenceAttribute attribute = new GM_NSIReferenceAttribute();
                        attribute.ReferenceAttributeId = GetValueExcel(6, i);
                        attribute.ReferenceAttributeName = GetValueExcel(7, i);
                        attribute.ReferenceAttributeType = Convertation(GetValueExcel(8, i));
                        if (Convertation(GetValueExcel(8, i)) == 4) attribute.RefReferenceId = GetValueExcel(6, i);
                        listAttributes.Add(attribute);
                    }
                    

                    //Таблица с данными
                    SplashScreenManager.Default.SetWaitFormDescription("Импорт таблицы");
                    ObservableCollection<DynamicListItem> Records = new ObservableCollection<DynamicListItem>();
                    for (int i = 9; i <= lastRow; i++)
                    {
                        DynamicListItem rowItem = new DynamicListItem();
                        for (int j = 1; j <= lastColumn; j++)
                        {
                                rowItem.ValueDictionary.Add(GetValueExcel(7, j), GetValueExcel(i, j));
                        }
                        Records.Add(rowItem);
                    }
                    SplashScreenManager.Default.SetWaitFormDescription("Настраиваю вьюху");
                    ObservableCollection<ColumnEx> Columns = new ObservableCollection<ColumnEx>();
                    for (int j = 1; j <= lastColumn; j++)
                    {
                        ColumnEx CE = new ColumnEx();
                        CE.CellSource = GetValueExcel(7, j);
                        CE.Header = GetValueExcel(7, j);
                        CE.Type = 0;
                        Columns.Add(CE);

                    }
                    GM_NSIReference selectedNsi = new GM_NSIReference();

                    selectedNsi.ReferenceId = GetValueExcel(1, 2);
                    selectedNsi.ReferenceName = GetValueExcel(2, 2);
                    selectedNsi.ReferenceGroupId = GetValueExcel(3, 2);
                    selectedNsi.UserGroupId = GetValueExcel(4, 2);

                    mainViewModel.isExcel = true;
                    mainViewModel.ignoreNsiUpdate = true;
                    mainViewModel.SelectedNsi = selectedNsi;
                    mainViewModel.ReferenceAttributeCollection = listAttributes;
                    mainViewModel.Columns = Columns;
                    mainViewModel.Records = Records;
                    mainViewModel.RunExportButtonEnabled = true;
                    mainViewModel.ExportSQL = false;

                    //    view.DataContext = mainViewModel;

                }
                catch (Exception e)
                {
                    MessageBox.Show("ЧТо то пошло не так!" + e);
                }
                finally
                {
                    SplashScreenManager.CloseForm();
                    mainViewModel.ignoreNsiUpdate = false;
                    HourGlass.Enable = false;
                    workbook.Close();
                    excelApp.Quit();
                }



            }
        }

        public event EventHandler CanExecuteChanged;
    }
}
