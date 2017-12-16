using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using DevExpress.Mvvm;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Grid.GroupRowLayout;
using DevExpress.XtraSplashScreen;
using NsiViewerDevExpress.Common;
using NsiViewerDevExpress.Model;
using NsiViewerDevExpress.Views;


namespace NsiViewerDevExpress.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            MainViewTitle = "Справочники НСИ.          Компьютер: " + Environment.MachineName;

            List<string> list = SqlServerHelper.GetDatabaseList(Environment.MachineName);
            List<DbServerModel> listDbServerModel = new List<DbServerModel>();
            foreach (string s in list)
            {
                listDbServerModel.Add(new DbServerModel(s));
            }
            DbCollection = new ObservableCollection<DbServerModel>(listDbServerModel);

            if (DbCollection.Count > 4)
            {
                SelectedDb = DbCollection[3];
            }
            else if (DbCollection.Count > 0)
            {
                SelectedDb = DbCollection[0];
            }

            //Кнопка "Экспорт в Excel" недоступна
            RunExportButtonEnabled = false;
            //Кнопка "Сохранить в БД" недоступна
            ExportSQL = false;

        }
        public bool isExcel
        {
            get { return GetProperty(() => isExcel); }
            set { SetProperty(() => isExcel, value); }
        }

        protected IDocumentManagerService DocumentManagerService { get { return GetService<IDocumentManagerService>(); } }

        public void CreateDocument(object arg)
        {
            IDocument doc = DocumentManagerService.FindDocument(arg);
            if (doc == null)
            {
                doc = DocumentManagerService.CreateDocument("EditView", arg, this, false);
                doc.Id = DocumentManagerService.Documents.Count<IDocument>();
            }
            doc.Show();


            //IDocument doc = DocumentManagerService.CreateDocument("TabView", ViewModelSource.Create(() => new TabViewModel()));
            //doc.Id = String.Format("DocId_{0}", DocumentManagerService.Documents.Count<IDocument>());
            //doc.Title = String.Format("Item {0}", DocumentManagerService.Documents.Count<IDocument>());
            //doc.Show();
        }

        public void CloseDocument()
        {
            DocumentManagerService.ActiveDocument.Close();
        }

        public NsiModel NsiModel { get; set; }

        /// <summary>
        /// Заголовок формы.
        /// </summary>
        public string MainViewTitle
        {
            get { return GetProperty(() => MainViewTitle); }
            set { SetProperty(() => MainViewTitle, value); }
        }

        /// <summary>
        /// Коллекция баз данных данного компьютера.
        /// </summary>
        public ObservableCollection<DbServerModel> DbCollection
        {
            get
            {
                if (DesignerProperties.GetIsInDesignMode(new DependencyObject()))
                    return new ObservableCollection<DbServerModel>();

                return GetProperty(() => DbCollection);
            }
            set { SetProperty(() => DbCollection, value); }
        }

        /// <summary>
        /// Выбранная база данных.
        /// </summary>
        public DbServerModel SelectedDb
        {
            get { return GetProperty(() => SelectedDb); }
            set
            {
                ClearAll();
                SetProperty(() => SelectedDb, value);
                //Обновить настройки справочников для выбоанной БД
                UpdateNsiCollection();
            }
        }

        /// <summary>
        /// Коллекция настроек справочников НСИ.
        /// </summary>
        public ObservableCollection<GM_NSIReference> NsiCollection
        {
            get
            {
                if (DesignerProperties.GetIsInDesignMode(new DependencyObject()))
                    return new ObservableCollection<GM_NSIReference>();

                return GetProperty(() => NsiCollection);
            }
            set { SetProperty(() => NsiCollection, value); }
        }

        /// <summary>
        /// Коллекция настроек атрибутов справочников НСИ.
        /// </summary>
        public ObservableCollection<GM_NSIReferenceAttribute> ReferenceAttributeCollection
        {
            get
            {
              //  if (DesignerProperties.GetIsInDesignMode(new DependencyObject()))
              //      return new ObservableCollection<GM_NSIReferenceAttribute>();

                return GetProperty(() => ReferenceAttributeCollection);
            }
            set { SetProperty(() => ReferenceAttributeCollection, value); }
        }


        public bool ignoreNsiUpdate { get; set; }

        public bool gridChanged { get; set; }

        /// <summary>
        /// Выбранная настройка справочника НСИ.
        /// </summary>
        public GM_NSIReference SelectedNsi
        {
            get { return GetProperty(() => SelectedNsi); }
            set
            {
                //не сохраненные изменения в программе вызывает предупреждение
                if (gridChanged)
                {
                    
                    string MessageBoxTitle = "Подтвердите изменения!";
                    string MessageBoxContent = "Справочник был изменён, сохранить изменения?";
                    MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButton.YesNoCancel);
                    if (messageBoxResult == MessageBoxResult.Yes)
                    {
                        ISqlSave sqlSave = new SaveSqlCommand();
                        TableView tv = new TableView();
                        tv.DataContext = this;
                        sqlSave.Execute(tv);
                    }
                    else if(messageBoxResult == MessageBoxResult.Cancel)
                    {
                        return;
                    }
                }
                SetProperty(() => SelectedNsi, value);
                gridChanged = false;
                ExportSQL = false;
                if (!ignoreNsiUpdate)
                {
                    //excel мод выключен
                    isExcel = false;
                    //Очистить
                    Clear();
                    //Обновить настройки атрибутов
                    UpdateAttributeCollection();
                    //Обновить значения атрибутов
                    UpdateNsiAttributeCollection();
                }

            }
        }

        /// <summary>
        /// Обновить настройки справочников для выбранной БД.
        /// </summary>
        private void UpdateNsiCollection()
        {
            try
            {
                if(SelectedDb == null)
                    return;

                HourGlass.Enable = true;

                NsiModel = null;

                string connectionString = DbConnectionHelper.BuildConnection(SelectedDb.DbName);

                NsiModel = new NsiModel(connectionString);

                NsiModel.GM_NSIReferenceSet.Load();
                //Все справочники
                NsiCollection = NsiModel.GM_NSIReferenceSet.Local;
            }
            catch (Exception)
            {
                //TODO log
            }
            finally
            {
                HourGlass.Enable = false;
            }
        }

        /// <summary>
        /// Обновить настройки атрибутов.
        /// </summary>
        private void UpdateAttributeCollection()
        {
            try
            {
                if(SelectedNsi == null)
                    return;

                if (NsiModel == null)
                    return;

                HourGlass.Enable = true;
                
                NsiModel.Configuration.AutoDetectChangesEnabled = false;
                //Все настройки атрибутов для выбранного справочника
                var attr = NsiModel.GM_NSIReferenceAttributeSet.Where(x => x.ReferenceId == SelectedNsi.ReferenceId);

                ReferenceAttributeCollection = attr.Any()
                    ? new ObservableCollection<GM_NSIReferenceAttribute>(attr)
                    : new ObservableCollection<GM_NSIReferenceAttribute>();
            }
            catch (Exception)
            {
                //TODO log
            }
            finally
            {
                if(NsiModel != null)
                    NsiModel.Configuration.AutoDetectChangesEnabled = true;
                HourGlass.Enable = false;
            }
        }

        /// <summary>
        /// Обновить значения атрибутов.
        /// </summary>
        private void UpdateNsiAttributeCollection()
        {
            SplashScreenManager.ShowForm(typeof(frmWaitForm), true, true);
            try
            {
                SplashScreenManager.Default.SetWaitFormCaption("Импортирую...");
                SplashScreenManager.Default.SetWaitFormDescription("Поиск аттрибутов");
                if (SelectedNsi == null)
                    return;

                if (NsiModel == null)
                    return;

                HourGlass.Enable = true;

                NsiModel.Configuration.AutoDetectChangesEnabled = false;
                //Все настройки атрибутов для выбранного справочника
                var attr = NsiModel.GM_NSIReferenceAttributeSet.Where(x => x.ReferenceId == SelectedNsi.ReferenceId);

                List<GM_NSIReferenceRecord> referenceRecordList = NsiModel.GM_NSIReferenceRecordSet.OrderBy(y => y.RecordId)
                        .Where(x => x.ReferenceId.Equals(SelectedNsi.ReferenceId)
                                    && x.GM_NSIReferenceRecordAttribute.Any(
                                        a => a.GM_NSIReferenceAttribute.ReferenceAttributeId.Equals(attr.FirstOrDefault().ReferenceAttributeId))).ToList();

                if (ReferenceAttributeCollection == null || ReferenceAttributeCollection.Count < 1)
                {

                    //var attributes = NsiModel.GM_NSIReferenceRecordSet.Where(x => x.ReferenceId == SelectedNsi.ReferenceId);
                    //foreach (var attribute in attributes)
                    //{
                    //    GM_NSIReferenceAttribute gm_nsiRA = new GM_NSIReferenceAttribute();
                    //    gm_nsiRA.DataAreaId = attribute.DataAreaId;
                    //    gm_nsiRA.RecId = attribute.RecId;
                    //    gm_nsiRA.ReferenceAttributeName = attribute.RecordName;
                    //    gm_nsiRA.ReferenceAttributeType = Convert.ToInt32(attribute.RecordId);
                    //    ReferenceAttributeCollection.Add(gm_nsiRA);
                    //}
                    referenceRecordList = NsiModel.GM_NSIReferenceRecordSet.OrderBy(y => y.RecordId).Where(x => x.ReferenceId.Equals(SelectedNsi.ReferenceId)).ToList();
                    RunExportButtonEnabled = false;
                 //   return;
                    
                }

                #region Добавление колонок
                List<ColumnEx> columns = new List<ColumnEx>();
                columns.Add(new ColumnEx() { CellSource = "Id", Header = "Бизнес - ИД записи(RecordId)" });
                columns.Add(new ColumnEx() { CellSource = "Name", Header = "Описание записи справочника(RecordName)" });
                foreach (GM_NSIReferenceAttribute referenceAttribute in ReferenceAttributeCollection.ToList())
                {
                    if (referenceAttribute == null)
                        continue;

                    string raName = PointReplace(referenceAttribute.ReferenceAttributeName);

                    switch ((NSIDataTypes)referenceAttribute.ReferenceAttributeType)
                    {
                        case NSIDataTypes.String:
                            columns.Add(new ColumnEx() { CellSource = raName, Header = referenceAttribute.ReferenceAttributeName });
                            break;
                        case NSIDataTypes.Integer:
                            columns.Add(new ColumnEx() { CellSource = raName, Header = referenceAttribute.ReferenceAttributeName});
                            break;
                        case NSIDataTypes.Real:
                            columns.Add(new ColumnEx() { CellSource = raName, Header = referenceAttribute.ReferenceAttributeName });
                            break;
                        case NSIDataTypes.DateTime:
                            columns.Add(new ColumnEx() { CellSource = raName, Header = referenceAttribute.ReferenceAttributeName });
                            break;
                        case NSIDataTypes.ReferenceRecord:
                            columns.Add(new ColumnEx() { CellSource = raName, Header = referenceAttribute.ReferenceAttributeName});
                            //TODO ???
                            //columns.Add(new ColumnEx() { CellSource = raName + ".ReferenceRecordValue" });
                            break;
                    }
                }
                Columns = new ObservableCollection<ColumnEx>(columns);
                #endregion

                #region Добавление значений атрибутов
                List<DynamicListItem> records = new List<DynamicListItem>();
                int nsiReferenceRow = 1;
                foreach (GM_NSIReferenceRecord nsiReferenceRecord in referenceRecordList)
                {
                    SplashScreenManager.Default.SetWaitFormDescription(String.Format("Загружаю запись {0} из {1}",
                        nsiReferenceRow, referenceRecordList.Count));
                    dynamic rec = new DynamicListItem();
                    rec.SetMemberSource("RecId", nsiReferenceRecord.RecId);
                    rec.SetMemberSource("Id", nsiReferenceRecord.RecordId );
                    rec.SetMemberSource("Name", nsiReferenceRecord.RecordName);

                    if (nsiReferenceRecord.GM_NSIReferenceRecordAttribute != null && nsiReferenceRecord.GM_NSIReferenceRecordAttribute.Count > 0)
                    {
                        foreach (GM_NSIReferenceRecordAttribute itemRra in nsiReferenceRecord.GM_NSIReferenceRecordAttribute)
                        {
                            if (itemRra.GM_NSIReferenceAttribute == null)
                                continue;

                            string raName = itemRra.GM_NSIReferenceAttribute.ReferenceAttributeName;

                            switch ((NSIDataTypes)itemRra.GM_NSIReferenceAttribute.ReferenceAttributeType)
                            {
                                case NSIDataTypes.String:
                                    rec.SetMemberSource(raName,itemRra.ValueString);
                                    break;
                                case NSIDataTypes.Integer:
                                    rec.SetMemberSource(raName,itemRra.ValueInteger);
                                    break;
                                case NSIDataTypes.Real:
                                    rec.SetMemberSource(raName,itemRra.ValueReal);
                                    break;
                                case NSIDataTypes.DateTime:
                                    rec.SetMemberSource(raName,itemRra.ValueDate);
                                    break;
                                case NSIDataTypes.ReferenceRecord:
                                    if (itemRra.ValueRecordRecId != null && itemRra.ValueRecord != null)
                                    {
                                        rec.SetMemberSource(raName,itemRra.ValueRecord.RecordId);
                                    }
                                    break;
                            }
                        }
                    }
                    records.Add(rec);
                    nsiReferenceRow++;
                }
                Records = new ObservableCollection<DynamicListItem>(records);

                RunExportButtonEnabled = Records.Count > 0;

                #endregion

                #region Добавление значений атрибутов (DynamicListItemEx)
                //List<DynamicListItemEx> records = new List<DynamicListItemEx>();

                //foreach (GM_NSIReferenceRecord nsiReferenceRecord in referenceRecordList)
                //{
                //    dynamic rec = new DynamicListItemEx();

                //    rec.SetMemberSource(new DynamicItemEx()
                //    {
                //        Key = "Id",
                //        Value = new DynamicReferenceTypeProperty() { StringValue = nsiReferenceRecord.RecordId },
                //        Obj = null
                //    });
                //    rec.SetMemberSource(new DynamicItemEx()
                //    {
                //        Key = "Name",
                //        Value = new DynamicReferenceTypeProperty() { StringValue = nsiReferenceRecord.RecordName },
                //        Obj = null
                //    });

                //    if (nsiReferenceRecord.GM_NSIReferenceRecordAttribute != null && nsiReferenceRecord.GM_NSIReferenceRecordAttribute.Count > 0)
                //    {
                //        foreach (GM_NSIReferenceRecordAttribute itemRra in nsiReferenceRecord.GM_NSIReferenceRecordAttribute)
                //        {
                //            if (itemRra.GM_NSIReferenceAttribute == null)
                //                continue;

                //            string raName = PointReplace(itemRra.GM_NSIReferenceAttribute.ReferenceAttributeName);

                //            switch ((NSIDataTypes)itemRra.GM_NSIReferenceAttribute.ReferenceAttributeType)
                //            {
                //                case NSIDataTypes.String:
                //                    rec.SetMemberSource(new DynamicItemEx()
                //                    {
                //                        Key = raName,
                //                        Value = new DynamicReferenceTypeProperty() { StringValue = itemRra.ValueString },
                //                        Obj = null
                //                    });
                //                    break;
                //                case NSIDataTypes.Integer:
                //                    rec.SetMemberSource(new DynamicItemEx()
                //                    {
                //                        Key = raName,
                //                        Value = new DynamicReferenceTypeProperty() { IntegerValue = itemRra.ValueInteger },
                //                        Obj = null
                //                    });
                //                    break;
                //                case NSIDataTypes.Real:
                //                    rec.SetMemberSource(new DynamicItemEx()
                //                    {
                //                        Key = raName,
                //                        Value = new DynamicReferenceTypeProperty() { RealValue = itemRra.ValueReal },
                //                        Obj = null
                //                    });
                //                    break;
                //                case NSIDataTypes.DateTime:
                //                    rec.SetMemberSource(new DynamicItemEx()
                //                    {
                //                        Key = raName,
                //                        Value = new DynamicReferenceTypeProperty() { DateTimeValue = itemRra.ValueDate },
                //                        Obj = null
                //                    });
                //                    break;
                //                case NSIDataTypes.ReferenceRecord:
                //                    if (itemRra.ValueRecordRecId != null && itemRra.ValueRecord != null)
                //                    {
                //                        rec.SetMemberSource(new DynamicItemEx()
                //                        {
                //                            Key = raName,
                //                            Value = new DynamicReferenceTypeProperty() { StringValue = itemRra.ValueRecord.RecordId },
                //                            Obj = null
                //                        });
                //                    }
                //                    break;
                //            }
                //        }
                //    }
                //    records.Add(rec);
                //}
                //Records = new ObservableCollection<DynamicListItemEx>(records);

                //RunExportButtonEnabled = Records.Count > 0;

                #endregion

                #region Добавление значений атрибутов (копия)
                //List<DynamicListItem> records = new List<DynamicListItem>();

                //foreach (GM_NSIReferenceRecord nsiReferenceRecord in referenceRecordList)
                //{
                //    dynamic rec = new DynamicListItem();
                //    rec.SetMemberSource("Id", new DynamicReferenceTypeProperty() { StringValue = nsiReferenceRecord.RecordId });
                //    rec.SetMemberSource("Name", new DynamicReferenceTypeProperty() { StringValue = nsiReferenceRecord.RecordName });

                //    if (nsiReferenceRecord.GM_NSIReferenceRecordAttribute != null && nsiReferenceRecord.GM_NSIReferenceRecordAttribute.Count > 0)
                //    {
                //        foreach (GM_NSIReferenceRecordAttribute itemRra in nsiReferenceRecord.GM_NSIReferenceRecordAttribute)
                //        {
                //            if (itemRra.GM_NSIReferenceAttribute == null)
                //                continue;

                //            string raName = PointReplace(itemRra.GM_NSIReferenceAttribute.ReferenceAttributeName);

                //            switch ((NSIDataTypes) itemRra.GM_NSIReferenceAttribute.ReferenceAttributeType)
                //            {
                //                case NSIDataTypes.String:
                //                    rec.SetMemberSource(
                //                        raName,
                //                        new DynamicReferenceTypeProperty()
                //                        {
                //                            StringValue = itemRra.ValueString
                //                        });
                //                    break;
                //                case NSIDataTypes.Integer:
                //                    rec.SetMemberSource(
                //                        raName,
                //                        new DynamicReferenceTypeProperty()
                //                        {
                //                            IntegerValue = itemRra.ValueInteger
                //                        });
                //                    break;
                //                case NSIDataTypes.Real:
                //                    rec.SetMemberSource(
                //                        raName,
                //                        new DynamicReferenceTypeProperty() {RealValue = itemRra.ValueReal});
                //                    break;
                //                case NSIDataTypes.DateTime:
                //                    rec.SetMemberSource(
                //                        raName,
                //                        new DynamicReferenceTypeProperty()
                //                        {
                //                            DateTimeValue = itemRra.ValueDate
                //                        });
                //                    break;
                //                case NSIDataTypes.ReferenceRecord:
                //                    if (itemRra.ValueRecordRecId != null && itemRra.ValueRecord != null)
                //                    {
                //                        rec.SetMemberSource(
                //                            raName,
                //                            new DynamicReferenceTypeProperty()
                //                            {
                //                                StringValue = itemRra.ValueRecord.RecordId
                //                            });
                //                    }
                //                    break;
                //            }
                //        }
                //    }
                //    records.Add(rec);
                //}
                //Records = new ObservableCollection<DynamicListItem>(records);

                //RunExportButtonEnabled = Records.Count > 0;

                #endregion
            }
            catch (Exception ex)
            {
                //TODO log
            }
            finally
            {
                if (NsiModel != null)
                    NsiModel.Configuration.AutoDetectChangesEnabled = true;
                SplashScreenManager.CloseForm();
                HourGlass.Enable = false;
            }
        }

        private string PointReplace(string text)
        {
            return text.Replace('.', '-');
        }
        /// <summary>
        /// Очистить всё.
        /// </summary>
        private void ClearAll()
        {
            Clear();

            if (NsiCollection != null)
                NsiCollection = null;
            if (SelectedNsi != null)
                SelectedNsi = null;
        }

        /// <summary>
        /// Очистить.
        /// </summary>
        private void Clear()
        {
            if (ReferenceAttributeCollection != null)
                ReferenceAttributeCollection = null;
            if (Records != null)
                Records = null;
            if (Columns != null)
                Columns = null;
            if (SelectedAttributeValue != null)
                SelectedAttributeValue = null;
        }

        /// <summary>
        /// Коллекция атрибутов.
        /// </summary>
        public ObservableCollection<DynamicListItem> Records 
        {
            get
            {
              //  if (DesignerProperties.GetIsInDesignMode(new DependencyObject()))
                //    return new ObservableCollection<DynamicListItem>();

                return GetProperty(() => Records);
            }
            set { SetProperty(() => Records, value); }
        }

        /// <summary>
        /// Коллекция столбцов атрибутов.
        /// </summary>
        public ObservableCollection<ColumnEx> Columns
        {
            get
            {
                //if (DesignerProperties.GetIsInDesignMode(new DependencyObject()))
                //    return new ObservableCollection<ColumnEx>();

                return GetProperty(() => Columns);
            }
            set { SetProperty(() => Columns, value); }
        }

        #region RowDoubleClick команда (отключено)
        ////<!--<dxmvvm:EventToCommand Command="{Binding RowDoubleClickCommand}" EventName="RowDoubleClick" />-->
        //public ICommand RowDoubleClickCommand { get; private set; }

        //private void RunRowDoubleClickCommand()
        //{
        //    MessageBox.Show("Row double click");
        //} 
        #endregion

        /// <summary>
        /// Выбранный атрибут.
        /// </summary>
        public DynamicListItem SelectedAttributeValue
        {
            get { return GetProperty(() => SelectedAttributeValue); }
            set { SetProperty(() => SelectedAttributeValue, value); }
        }

        public bool RunExportButtonEnabled
        {
            get { return GetProperty(() => RunExportButtonEnabled); }
            set { SetProperty(() => RunExportButtonEnabled, value); }
        }

        public bool ExportSQL
        {
            get { return GetProperty(() => ExportSQL); }
            set { SetProperty(() => ExportSQL, value); }
        }

        public decimal UsablePageWidth
        {
            get { return GetProperty(() => UsablePageWidth); }
            set { SetProperty(() => UsablePageWidth, value); }
        }

        public DelegateCommand SaveSqlCommand { get; set; }
    }
}