using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace NsiViewerDevExpress.Views
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            DevExpress.Xpf.Core.ApplicationThemeHelper.ApplicationThemeName =
                DevExpress.Xpf.Core.Theme.Office2007BlueFullName;
            base.OnStartup(e);
        }
        private void OnApplicationStartup(object sender, StartupEventArgs e)
        {
            Current.DispatcherUnhandledException += AppDispatcherUnhandledException;

            //List<string> list = SqlServerHelper.GetAllSqlServerList();
            //foreach (string s in list)
            //{

            //}

            //List<string> list = SqlServerHelper.GetDatabaseList(Environment.MachineName);
            //foreach (string s in list)
            //{

            //}
        }

        private void AppDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            //#if DEBUG // In debug mode do not custom-handle the exception, let Visual Studio handle it
            //    e.Handled = false;
            //#else
            ShowUnhandledException(e);
            //#endif
        }

        private void ShowUnhandledException(DispatcherUnhandledExceptionEventArgs e)
        {
            e.Handled = true;

            string errorMessage = string.Format(
                "Ошибка приложения:\n {0}",
                e.Exception.Message + (e.Exception.InnerException != null ? "\n" + e.Exception.InnerException.Message : null));

            if (MessageBox.Show(errorMessage, "Application Error", MessageBoxButton.OK, MessageBoxImage.Error) == MessageBoxResult.OK)
            {
                Current.Shutdown();
            }
        }
    
    }
}
