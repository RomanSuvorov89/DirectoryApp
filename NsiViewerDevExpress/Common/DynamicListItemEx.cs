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
using NsiViewer.Model;

namespace NsiViewerDevExpress.Common
{
    public class DynamicListItemEx : DynamicObject
    {
        private ObservableCollection<DynamicItemEx> _valueDictionary = new ObservableCollection<DynamicItemEx>();

        //private readonly Dictionary<string, object> _valueDictionary = new Dictionary<string, object>();
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<DynamicItemEx> ValueDictionary { get { return _valueDictionary; } }
        //public object Content { get; set; }

        public DynamicListItemEx()
        {
            //_valueDictionary = new ObservableCollection<DynamicItemEx>();
            //ContolCollectionTestLoad();
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            try
            {
                if (_valueDictionary.Any(p => p.Key == binder.Name))
                {
                    var propertyValue = _valueDictionary.FirstOrDefault(p => p.Key == binder.Name);
                    result = propertyValue;
                    return true;
                }

                //if (_valueDictionary.ContainsKey(binder.Name))
                //{
                //    var propertyValue = _valueDictionary[binder.Name];
                //    result = propertyValue;
                //    return true;
                //}
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
            return _valueDictionary.FirstOrDefault(p => p.Key == memberName);
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            _valueDictionary.Add(new DynamicItemEx() {Key = binder.Name, Value = value, Obj = null});
            return true;
        }

        public override IEnumerable<string> GetDynamicMemberNames()
        {
            if (_valueDictionary.Any())
            {
                return _valueDictionary.Select(i => i.Key);
            }
            return new List<string>();
            //return _valueDictionary.Keys.ToList();
        }

        public void SetMemberSource(string name, DynamicReferenceTypeProperty dynamicPropertyModel)
        {
            if (_valueDictionary.Any(p => p.Key == name))
            {
                _valueDictionary.First(p => p.Key == name).Value = dynamicPropertyModel;
                _valueDictionary.First(p => p.Key == name).Obj = null;
            }
            else
            {
                _valueDictionary.Add(new DynamicItemEx() { Key = name, Value = dynamicPropertyModel, Obj = null });
            }
        }

        public void SetMemberSource(DynamicItemEx dynamicItemEx)
        {
            if (_valueDictionary.Any(p => p.Key == dynamicItemEx.Key))
            {
                _valueDictionary.First(p => p.Key == dynamicItemEx.Key).Value = dynamicItemEx.Value;
                _valueDictionary.First(p => p.Key == dynamicItemEx.Key).Obj = dynamicItemEx.Obj;
            }
            else
            {
                _valueDictionary.Add(dynamicItemEx);
            }
        }

        //=======================================================================

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