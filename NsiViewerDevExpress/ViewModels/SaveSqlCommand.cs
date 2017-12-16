using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Threading;
using DevExpress.CodeParser;
using DevExpress.Xpf.Grid;
using DevExpress.XtraSplashScreen;
using NsiViewerDevExpress.Model;
using NsiViewerDevExpress.Common;
using NsiViewerDevExpress.Views;
using MessageBox = System.Windows.MessageBox;

namespace NsiViewerDevExpress.ViewModels
{
    interface ISqlSave
    {
        void Execute(object parametr);
    }

    class SaveSqlCommand : ICommand, ISqlSave
    {
        private MainViewModel mainViewModel;
        
        public bool CanExecute(object parameter)
        {
            return true;
        }


        private void SaveToSql()
        {
            SplashScreenManager.ShowForm(typeof(frmWaitForm),true,true);
            SplashScreenManager.Default.SetWaitFormCaption("Обновление данных");
            string ReferenceId = mainViewModel.SelectedNsi.ReferenceId;
            var db = mainViewModel.NsiModel;
            List< string > incorrectList = new List<string>();
            bool isIncorrect = false;
            int rowIndex = 1;
            
            try
            {
                foreach (var record in mainViewModel.Records)
                {
                  SplashScreenManager.Default.SetWaitFormDescription(String.Format("Идёт сохранение в базу данных..." +
                                                                                   "\nОбработка строки:{0} из {1}" +
                                                                                   "\nНайдено {2} ошибок", rowIndex, mainViewModel.Records.Count, incorrectList.Count));
                    
                    long recordId = Convert.ToInt64(record.ValueDictionary.FirstOrDefault(x => x.Key == "RecId").Value);
                    //Update GM_NSIReferenceRecord
                    db.GM_NSIReferenceRecordSet.FirstOrDefault(x => x.RecId == recordId).RecordId = record.ValueDictionary.FirstOrDefault(x => x.Key == "Id").Value.ToString();
                    db.GM_NSIReferenceRecordSet.FirstOrDefault(x => x.RecId == recordId).RecordName = record.ValueDictionary.FirstOrDefault(x => x.Key == "Name").Value.ToString();
                    //Update GM_NSIReferenceRecordAttribute
                    foreach (var key in record.ValueDictionary.Keys)
                    {
                        if (key != "RecId" && key != "Id" && key != "Name")
                        {
                            long RecId = db.GM_NSIReferenceAttributeSet.FirstOrDefault(x => x.ReferenceAttributeName == key && x.ReferenceId == ReferenceId).RecId;
                            switch ((NSIDataTypes)db.GM_NSIReferenceAttributeSet.FirstOrDefault(x => x.RecId == RecId).ReferenceAttributeType)
                            {
                                case NSIDataTypes.String:
                                    db.GM_NSIReferenceRecordAttributeSet.FirstOrDefault(x => x.ReferenceAttributeRecId == RecId && x.ReferenceRecordRecId == recordId).ValueString = record.ValueDictionary.FirstOrDefault(x => x.Key == key).Value.ToString();
                                    break;
                                case NSIDataTypes.Integer:
                                    db.GM_NSIReferenceRecordAttributeSet.FirstOrDefault(x => x.ReferenceAttributeRecId == RecId && x.ReferenceRecordRecId == recordId).ValueInteger = Convert.ToInt64(record.ValueDictionary.FirstOrDefault(x => x.Key == key).Value);
                                    break;
                                case NSIDataTypes.Real:
                                    db.GM_NSIReferenceRecordAttributeSet.FirstOrDefault(x => x.ReferenceAttributeRecId == RecId && x.ReferenceRecordRecId == recordId).ValueReal = Convert.ToDecimal(record.ValueDictionary.FirstOrDefault(x => x.Key == key).Value.ToString());
                                    break;
                                case NSIDataTypes.DateTime:
                                    db.GM_NSIReferenceRecordAttributeSet.FirstOrDefault(x => x.ReferenceAttributeRecId == RecId && x.ReferenceRecordRecId == recordId).ValueDate = Convert.ToDateTime(record.ValueDictionary.FirstOrDefault(x => x.Key == key).Value.ToString());
                                    break;
                                case NSIDataTypes.ReferenceRecord:
                                    if (record.ValueDictionary.FirstOrDefault(x => x.Key == key).Value == null)
                                    {
                                        db.GM_NSIReferenceRecordAttributeSet
                                            .FirstOrDefault(
                                                x => x.ReferenceAttributeRecId == RecId &&
                                                     x.ReferenceRecordRecId == recordId).ValueRecordRecId = 0;
                                    }
                                    else
                                    {
                                        string referenceRecordRecordId = record.ValueDictionary.FirstOrDefault(x => x.Key == key).Value.ToString();
                                        var result = db.GM_NSIReferenceRecordSet.FirstOrDefault(x => x.RecordId == referenceRecordRecordId);
                                        if (result != null)
                                        {
                                            long referenceRecordRecId = db.GM_NSIReferenceRecordSet.FirstOrDefault(x => x.RecordId == referenceRecordRecordId).RecId;
                                            db.GM_NSIReferenceRecordAttributeSet
                                                .FirstOrDefault(
                                                    x => x.ReferenceAttributeRecId == RecId &&
                                                         x.ReferenceRecordRecId == recordId).ValueRecordRecId = referenceRecordRecId;
                                        }
                                        else
                                        {
                                            isIncorrect = true;
                                            var incorrectRecordId = String.Format("\nВ сохраняемых данных пристутствует некорректный элемент, проверьте строку номер {0}, значение {1}!",
                                                record.ValueDictionary.FirstOrDefault(x => x.Key == "Id").Value,
                                                referenceRecordRecordId);
                                            incorrectList.Add(incorrectRecordId);
                                        }
                                    }
                                    break;
                            }
                        }
                    }
                    rowIndex++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что пошло не так!:" + ex);
            }
            finally
            {
                SplashScreenManager.CloseForm();
                if (!isIncorrect)
                {
                    db.SaveChanges();
                    mainViewModel.ExportSQL = false;
                    mainViewModel.gridChanged = false;
                }
                else
                {
                    string resultToBox = String.Join("\n", incorrectList);
                    MessageBox.Show("Список ошибок:"+ resultToBox);
                }
            }
        }
        public void Execute(object parameter)
        {
            TableView view = parameter as TableView;
            if (view == null) { return;}
            mainViewModel = view.DataContext as MainViewModel;
            var th = new Thread(SaveToSql);
            th.Start();

        }

        public event EventHandler CanExecuteChanged;
    }
}
