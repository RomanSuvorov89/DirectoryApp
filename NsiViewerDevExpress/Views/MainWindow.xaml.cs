using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NsiViewerDevExpress.ViewModels;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Grid;

namespace NsiViewerDevExpress.Views
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnColumnsGenerated(object sender, RoutedEventArgs e)
        {
            foreach (GridColumn column in ReferenceRecordGrid.Columns)
            {
                switch (column.FieldName)
                {
                    #region test
                    //case "NsiName":
                    //    column.CellTemplate = Application.Current.MainWindow.Resources["NsiNameTemplate"] as DataTemplate;
                    //    column.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                    //    break; 
                    #endregion
                    case "Column":
                        column.Visible = false;
                        return;
                }
            }
        }

        private void ReferenceRecordView_OnCellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            TableView view = sender as TableView;
            if (view == null)
                return;
            MainViewModel mainViewModel = view.DataContext as MainViewModel;
            if (!mainViewModel.isExcel)
            {
                mainViewModel.gridChanged = true;
                mainViewModel.ExportSQL = true;
            }
        }
    }
}
