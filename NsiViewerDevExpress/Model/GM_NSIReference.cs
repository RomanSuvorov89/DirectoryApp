using System.Collections.Generic;

namespace NsiViewerDevExpress.Model
{
    /// <summary>
    /// ��������� ������������ ���.
    /// </summary>
    public class GM_NSIReference
    {
	    public GM_NSIReference()
        {			
            GM_NSIReferenceAttribute = new List<GM_NSIReferenceAttribute>();			
            GM_NSIReferenceAttribute1 = new List<GM_NSIReferenceAttribute>();			
            GM_NSIReferenceRecord = new List<GM_NSIReferenceRecord>();

            //TODO
            //if (ApplicationSettings.Database != null) DataAreaId = ApplicationSettings.Database.DATAAREAID;	
        }

        /// <summary>
        /// ��� ����������� ���.
        /// </summary>
        public string ReferenceId { get; set; }

        /// <summary>
        /// ������ ������������ ���, � ������� ��������� ����������. ������ �� GM_NSIReferenceGroup.ReferenceGroupId.
        /// </summary>
        public string ReferenceGroupId { get; set; }

        /// <summary>
        /// ������������ ����������� ���.
        /// </summary>
        public string ReferenceName { get; set; }

        /// <summary>
        /// ������ �������������, ������������� �� ������� ����������� ���.
        /// </summary>
        public string UserGroupId { get; set; }

        /// <summary>
        /// ��� �������� � DAX.
        /// </summary>
        public string DataAreaId { get; set; }

        /// <summary>
        /// ��� ������ � DAX.
        /// </summary>
        public long RecId { get; set; }

        /// <summary>
        /// ��� ����������� ��� (������� ���� �����-���).
        /// </summary>
        public int ReferenceType { get; set; }

        public virtual ICollection<GM_NSIReferenceAttribute> GM_NSIReferenceAttribute { get; set; }
        public virtual ICollection<GM_NSIReferenceAttribute> GM_NSIReferenceAttribute1 { get; set; }

        /// <summary>
        /// ������ ������������ ���.
        /// </summary>
        public virtual ICollection<GM_NSIReferenceRecord> GM_NSIReferenceRecord { get; set; }
    }
}