using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using NsiViewerDevExpress.Model;

namespace NsiViewerDevExpress.Common
{
    public class DynamicListItem : DynamicObject
    {
        private Dictionary<string, object> _valueDictionary = new Dictionary<string, object>();
        public event PropertyChangedEventHandler PropertyChanged;

        public Dictionary<string, object> /*object*/ ValueDictionary
        {
            get { return _valueDictionary; }
            set { _valueDictionary = value; }
        }
        //public object Content { get; set; }

        public DynamicListItem()
        {
            //ContolCollectionTestLoad();
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            try
            {
                if (_valueDictionary.ContainsKey(binder.Name))
                {
                    var propertyValue = _valueDictionary[binder.Name];
                    result = propertyValue;
                    return true;
                }
                result = null;
                return false;
            }
            catch (Exception)
            {
                result = null;
                return false;
            }
        }

        public object GetMemberContent(string memberName)
        {
            return _valueDictionary[memberName];
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            if (_valueDictionary.ContainsKey(binder.Name))
            {
                _valueDictionary[binder.Name] = value;
            }
            else
            {
                _valueDictionary.Add(binder.Name, value);
            }
            return true;
        }

        public override IEnumerable<string> GetDynamicMemberNames()
        {
            return _valueDictionary.Keys.ToList();
        }

        public void SetMemberSource(string name, object dynamicPropertyModel)
        {
            if (_valueDictionary.ContainsKey(name))
            {
                _valueDictionary[name] = dynamicPropertyModel;
            }
            else
            {
                _valueDictionary.Add(name, dynamicPropertyModel);
            }
        }

        //public ObservableCollection<TestDataItem> ContolCollection
        //{
        //    get;
        //    set;
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

        #region INotifyPropertyChanged

        [DebuggerStepThrough]
        protected void SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(storage, value))
                return;
            storage = value;
            RaisePropertyChanged(propertyName);
        }

        [SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Justification = "Method used to raise an event")]
        protected virtual void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}