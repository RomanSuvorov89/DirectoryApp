using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DevExpress.Mvvm;
using DevExpress.Utils.IoC;
using NsiViewerDevExpress.Common;
using NsiViewerDevExpress.Model;

namespace NsiViewerDevExpress.ViewModels
{
    public class EditViewModel : ViewModelBase, IDocumentContent
    {
        public EditViewModel()
        {
            //ContolCollectionTestLoad();
        }

        public virtual IDocument Document 
        {
            get;
            set;
        }

        //IDocument
        //object Content { get; }
        //bool DestroyOnClose { get; set; }
        //object Id { get; set; }
        //object Title { get; set; }

        //void Close(bool force = true);
        //void Hide();
        //void Show();

        //public virtual int Id { get; set; }
        //public virtual string NickName { get; set; }
        //public virtual DateTime Registration { get; set; }
        //public virtual Decimal Rating { get; set; }
        //public virtual ObservableCollection<ActionsPerMonth> GlobalUserActivity { get; set; }
        //public virtual ObservableCollection<ActionsPerMonth> LocalUserActivity { get; set; }

        public void Close()
        {
            DocumentOwner.Close(this, false);
        }

        #region IDocumentContent

        public IDocumentOwner DocumentOwner { get; set; }

        public void OnClose(CancelEventArgs e) { }

        public void OnDestroy() { }

        public object Title
        {
            get { return string.Format("{0} ({1})", "Test ", "1"); /*ID, NickName, Registration.ToShortDateString()*/ }
        }
        #endregion

        //============================================

        //ValueDictionary

        //public ObservableCollection<TestDataItem> ContolCollection
        //{
        //    get
        //    {
        //        if (DesignerProperties.GetIsInDesignMode(new DependencyObject()))
        //            return new ObservableCollection<TestDataItem>();

        //        return GetProperty(() => ContolCollection);
        //    }
        //    set { SetProperty(() => ContolCollection, value); }
        //}

        //private void ContolCollectionTestLoad()
        //{
        //    ContolCollection = new ObservableCollection<TestDataItem>();
        //    TestDataItem item = new TestDataItem();
        //    item.ID = 0;
        //    item.Value = String.Empty;
        //    ContolCollection.Add(item);
        //    item = new TestDataItem();
        //    item.ID = 1;
        //    item.Value = String.Empty;
        //    ContolCollection.Add(item);
        //}

        //public class TestDataList : ObservableCollection<TestDataItem>
        //{
        //    public static TestDataList Create()
        //    {
        //        TestDataList res = new TestDataList();
        //        TestDataItem item = new TestDataItem();
        //        item.Id = 0;
        //        res.Add(item);
        //        item = new TestDataItem();
        //        item.Id = 1;
        //        res.Add(item);
        //        return res;
        //    }
        //}

    }
}