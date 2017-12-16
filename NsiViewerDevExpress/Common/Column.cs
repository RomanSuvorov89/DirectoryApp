namespace NsiViewerDevExpress.Common
{
    public class Column
    {
        public Column()
        {
        }

        public Column(string header, string fieldName, SettingsType settings)
        {
            Header = header;
            FieldName = fieldName;
            Settings = settings;
        }

        public string Value { get; set; }

        public string Header { get; set; }
        // Specifies the name of a data source field to which the column is bound. 
        public string FieldName { get; set; }
        // Specifies the type of an in-place editor used to edit column values. 
        public SettingsType Settings { get; set; }
    }

    public enum SettingsType { Default, Combo }

    public class ColumnEx : BindableBase
    {
        public string CellSource { get; set; }
        public ColumnType Type { get; set; }
        public string Header{get; set; }
    }

    public enum ColumnType { Regular, Dynamic }
}