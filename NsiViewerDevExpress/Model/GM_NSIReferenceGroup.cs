namespace NsiViewerDevExpress.Model
{
    public class GM_NSIReferenceGroup
    {
        /// <summary>
        /// ������ ������������ ���.
        /// </summary>
	    public GM_NSIReferenceGroup()
        {			
            //TODO
			//if (ApplicationSettings.Database != null) DataAreaId = ApplicationSettings.Database.DATAAREAID;
		}

        /// <summary>
        /// ��� ������ ������������ ���.
        /// </summary>
        public string ReferenceGroupId { get; set; }

        /// <summary>
        /// ������������ ������ ������������ ���.
        /// </summary>
        public string ReferenceGroupName { get; set; }

        /// <summary>
        /// ��� �������� � DAX.
        /// </summary>
        public string DataAreaId { get; set; }

        /// <summary>
        /// ��� ������ � DAX.
        /// </summary>
        public long RecId { get; set; }
    }
}