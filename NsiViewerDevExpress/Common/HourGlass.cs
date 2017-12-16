using System;
using System.Windows.Input;

namespace NsiViewerDevExpress.Common
{
    /// <summary>
    /// Класс HourGlass.
    /// Показать/скрыть курсор ожидания.
    /// </summary>
    public class HourGlass : IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            Enable = false;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool Enable
        {
            set { Mouse.OverrideCursor = value ? Cursors.Wait : null; }
            get { return Mouse.OverrideCursor == Cursors.Wait; }
        }
    }
}