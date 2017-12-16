using System.Collections.Generic;

namespace NsiViewerDevExpress.Model
{
    /// <summary>
    /// ��������� ��������� ������������ ���.
    /// </summary>
    public class GM_NSIReferenceAttribute
    {
	    public GM_NSIReferenceAttribute()
        {			
            GM_NSIReferenceRecordAttribute = new List<GM_NSIReferenceRecordAttribute>();

            //TODO
            //if (ApplicationSettings.Database != null) DataAreaId = ApplicationSettings.Database.DATAAREAID;
        }

        /// <summary>
        /// ��� �������� ����������� ���.
        /// </summary>
        public string ReferenceAttributeId { get; set; }

        /// <summary>
        /// ��� ����������� ���. ������ �� GM_NSIReference.ReferenceID.
        /// </summary>
        public string ReferenceId { get; set; }

        /// <summary>
        /// ��� ��������. ��������� �������� String, Integer, Real, DateTime, RecordRecId (������ �� ������ ������� ���).
        /// </summary>
        public int ReferenceAttributeType { get; set; }

        /// <summary>
        /// ������������ ��������.
        /// </summary>
        public string ReferenceAttributeName { get; set; }

        /// <summary>
        /// ��� �������� � DAX.
        /// </summary>
        public string DataAreaId { get; set; }

        /// <summary>
        /// ��� ������ � DAX.
        /// </summary>
        public long RecId { get; set; }

        /// <summary>
        /// ������ �� ����������.
        /// ��� ���������� ����������� ��� ��� �������� � ����� RecordRecId. ������ �� GM_NSIReference.ReferenceId.
        /// </summary>
        public string RefReferenceId { get; set; }

        public virtual GM_NSIReference GM_NSIReference { get; set; }
        public virtual GM_NSIReference RefReference { get; set; }
        public virtual ICollection<GM_NSIReferenceRecordAttribute> GM_NSIReferenceRecordAttribute { get; set; }
    }
}