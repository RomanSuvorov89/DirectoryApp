using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;

namespace NsiViewerDevExpress.Common
{
    public class DynamicItemEx : ViewModelBase
    {
        public string Key
        {
            get { return GetProperty(() => Key); }
            set { SetProperty(() => Key, value); }
        }

        public object Value
        {
            get { return GetProperty(() => Value); }
            set { SetProperty(() => Value, value); }
        }

        public object Obj
        {
            get { return GetProperty(() => Obj); }
            set { SetProperty(() => Obj, value); }
        }
    }
}