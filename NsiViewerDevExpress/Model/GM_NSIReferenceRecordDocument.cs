using System;

namespace NsiViewerDevExpress.Model
{
    /// <summary>
    /// ��������� � ��� ���������.
    /// </summary>
    public class GM_NSIReferenceRecordDocument
    {
	    public GM_NSIReferenceRecordDocument()
        {			
            //TODO
			//if (ApplicationSettings.Database != null) DataAreaId = ApplicationSettings.Database.DATAAREAID;
		}

        /// <summary>
        /// ��� ���������� ���������.
        /// </summary>
        public string DocumentId { get; set; }

        /// <summary>
        /// ������������ ���������.
        /// </summary>
        public string DocumentNum { get; set; }

        /// <summary>
        /// ���� ���������.
        /// </summary>
        public Nullable<DateTime> DocumentDate { get; set; }

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