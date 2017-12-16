using System.ComponentModel;

namespace NsiViewerDevExpress.ViewModels
{
    public class PrintHelper : INotifyPropertyChanged
    {
        static PrintHelper _instance;

        public static PrintHelper Instance
        {
            get { return _instance ?? (_instance = new PrintHelper()); }
        }

        public PrintCommand PrintCommand { get; set; }

        public ImportCommand ImportCommand { get; set; }

        private string _header;

        public string Header
        {
            get { return _header; }
            set
            {
                _header = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Header"));
            }
        }

        public PrintHelper()
        {
            PrintCommand = new PrintCommand();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}