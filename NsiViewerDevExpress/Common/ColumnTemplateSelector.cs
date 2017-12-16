using System.Windows.Controls;
using System.Windows;

namespace NsiViewerDevExpress.Common
{
    public class ColumnTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DefaultDataTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var column = item as ColumnEx;
            if (column == null)
                return DefaultDataTemplate;
            var template = (DataTemplate)((Control)container).FindResource(column.Type + "ColumnTemplate");
          return template ?? DefaultDataTemplate;
        }


    }

    public class ColumnNameBindingHelper
    {
        /// <summary>
        /// Using a DependencyProperty as the backing store for BindingPath.  This enables animation, styling, binding, etc...
        /// </summary>
        public static readonly DependencyProperty BindingPathNameProperty
            = DependencyProperty.RegisterAttached("BindingPathName",
                                                  typeof(System.String),
                                                  typeof(ColumnNameBindingHelper),
                                                  new PropertyMetadata(null, OnBindingPathNameChanged));


        public static System.String GetBindingPathName(DependencyObject _dp)
        {
            return (System.String)_dp.GetValue(BindingPathNameProperty);
        }


        public static void SetBindingPathName(DependencyObject _dp, System.String _value)
        {
            _dp.SetValue(BindingPathNameProperty, _value);
        }

 
        private static void OnBindingPathNameChanged(DependencyObject _sender, DependencyPropertyChangedEventArgs _evtArgs)
        {
            var gridColumn = _sender as DevExpress.Xpf.Grid.GridColumn;
            if (gridColumn != null && _evtArgs.NewValue != null)
            {
                gridColumn.Binding = new System.Windows.Data.Binding(_evtArgs.NewValue.ToString()) { Mode = System.Windows.Data.BindingMode.TwoWay };
            }
        }
    }
}