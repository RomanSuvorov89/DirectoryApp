using System.ComponentModel;

namespace NsiViewerDevExpress.ViewModels
{
    public class ImportHelper : INotifyPropertyChanged
    {
        static ImportHelper _instance;

        public static ImportHelper Instance
        {
            get { return _instance ?? (_instance = new ImportHelper()); }
        }

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

        public ImportHelper()
        {
            ImportCommand = new ImportCommand();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}