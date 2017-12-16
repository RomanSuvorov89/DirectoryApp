using System.Collections.Generic;

namespace NsiViewerDevExpress.Model
{
    /// <summary>
    /// ������ ������������ ���.
    /// </summary>
    public class GM_NSIReferenceRecord
    {
	    public GM_NSIReferenceRecord()
        {
            GM_NSIReferenceRecordAttribute = new List<GM_NSIReferenceRecordAttribute>();			
            GM_NSIReferenceRecordAttribute1 = new List<GM_NSIReferenceRecordAttribute>();

            //TODO
			//if (ApplicationSettings.Database != null) DataAreaId = ApplicationSettings.Database.DATAAREAID;
		}

        /// <summary>
        /// ��� ����������� ���. ������ �� GM_NSIReference.ReferenceID.
        /// </summary>
        public string ReferenceId { get; set; }

        /// <summary>
        /// ��� ������ � DAX.
        /// </summary>
        public long RecId { get; set; }

        /// <summary>
        /// ������-�� ������.
        /// ������-������������� ������ ����������� ���. �������� � �������� �����������.
        /// </summary>
        public string RecordId { get; set; }

        /// <summary>
        /// �������� ������ �����������.
        /// �������� ������ ����������� ���.
        /// </summary>
        public string RecordName { get; set; }

        /// <summary>
        /// ������� "������ ������������ �����������". ��������������� ��� ������������� � �������.
        /// </summary>
        public int isFederal { get; set; }

        /// <summary>
        /// ��� �������� � DAX.
        /// </summary>
        public string DataAreaId { get; set; }

        /// <summary>
        /// ���� ������ �������� ������ ����������� ���.
        /// </summary>
        public System.DateTime ValidFrom { get; set; }

        /// <summary>
        /// ���� ��������� �������� ������ ����������� ���.
        /// </summary>
        public System.DateTime ValidTo { get; set; }

        public virtual GM_NSIReference GM_NSIReference { get; set; }
        public virtual ICollection<GM_NSIReferenceRecordAttribute> GM_NSIReferenceRecordAttribute { get; set; }
        public virtual ICollection<GM_NSIReferenceRecordAttribute> GM_NSIReferenceRecordAttribute1 { get; set; }
    }
}