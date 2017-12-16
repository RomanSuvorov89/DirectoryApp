using System;

namespace NsiViewerDevExpress.Model
{
    /// <summary>
    /// �������� ������� ������������ ���.
    /// </summary>
    public class GM_NSIReferenceRecordAttribute
    {
	    public GM_NSIReferenceRecordAttribute()
        {			
            //TODO
			//if (ApplicationSettings.Database != null) DataAreaId = ApplicationSettings.Database.DATAAREAID;
		}

        /// <summary>
        /// ������ �� GM_NSIReferenceAttribute.RecId.
        /// </summary>
        public long ReferenceAttributeRecId { get; set; }

        /// <summary>
        /// ������ �� GM_NSIReferenceRecord.RecId.
        /// </summary>
        public long ReferenceRecordRecId { get; set; }

        /// <summary>
        /// ������������� �������� ��������. ����������� ��� ��������� � ����� Integer.
        /// </summary>
        public long ValueInteger { get; set; }

        /// <summary>
        /// ��������� �������� ��������. ����������� ��� ��������� � ����� String.
        /// </summary>
        public string ValueString { get; set; }

        /// <summary>
        /// �������� (� ��������� �������) �������� ��������. ����������� ��� ��������� � ����� Real.
        /// </summary>
        public decimal ValueReal { get; set; }

        /// <summary>
        /// �������� �������� ����/�����. ����������� ��� ��������� � ����� DateTime.
        /// </summary>
        public DateTime ValueDate { get; set; }

        /// <summary>
        /// �������� �������� ���� ������ �� ������ ������� ����������� ���. ����������� ��� ��������� � ����� RecordRecId.
        /// </summary>
        public Nullable<long> ValueRecordRecId { get; set; }

        /// <summary>
        /// ��� �������� � DAX.
        /// </summary>
        public string DataAreaId { get; set; }

        /// <summary>
        /// ��� ������ � DAX.
        /// </summary>
        public long RecId { get; set; }

        public virtual GM_NSIReferenceAttribute GM_NSIReferenceAttribute { get; set; }
        public virtual GM_NSIReferenceRecord GM_NSIReferenceRecord { get; set; }
        public virtual GM_NSIReferenceRecord ValueRecord { get; set; }
    }
}