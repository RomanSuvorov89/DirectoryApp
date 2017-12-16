using System.Windows;
using System.Windows.Data;
using DevExpress.Xpf.Grid;

namespace NsiViewerDevExpress.Common
{
    public static class BindingHelper
    {
        public static DependencyProperty PathProperty =
            DependencyProperty.RegisterAttached("Path", typeof(string), typeof(BindingHelper),
                new PropertyMetadata(null, (d, e) =>
                {
                    ((GridColumn)d).Binding = new Binding(e.NewValue as string ) { Mode = BindingMode.TwoWay };
                }));

        public static string GetPath(DependencyObject obj)
        {
            return (string)obj.GetValue(PathProperty);
        }

        public static void SetPath(DependencyObject obj, string value)
        {
            obj.SetValue(PathProperty, value);
        }
    }
}
