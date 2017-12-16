namespace NsiViewerDevExpress.Model
{
    public class GM_NSIReferenceGroup
    {
        /// <summary>
        /// Группа справочников НСИ.
        /// </summary>
	    public GM_NSIReferenceGroup()
        {			
            //TODO
			//if (ApplicationSettings.Database != null) DataAreaId = ApplicationSettings.Database.DATAAREAID;
		}

        /// <summary>
        /// Код группы справочников НСИ.
        /// </summary>
        public string ReferenceGroupId { get; set; }

        /// <summary>
        /// Наименование группы справочников НСИ.
        /// </summary>
        public string ReferenceGroupName { get; set; }

        /// <summary>
        /// Код компании в DAX.
        /// </summary>
        public string DataAreaId { get; set; }

        /// <summary>
        /// Код записи в DAX.
        /// </summary>
        public long RecId { get; set; }
    }
}