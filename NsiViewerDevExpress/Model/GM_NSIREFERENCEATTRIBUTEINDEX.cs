namespace NsiViewerDevExpress.Model
{
    public class GM_NSIREFERENCEATTRIBUTEINDEX
    {
	    public GM_NSIREFERENCEATTRIBUTEINDEX()
        {
            //TODO
            //if (ApplicationSettings.Database != null) DataAreaId = ApplicationSettings.Database.DATAAREAID;			
        }

        public string DATAAREAID { get; set; }
        public long RECID { get; set; }
        public long ATTRIBUTERECID { get; set; }
    }
}