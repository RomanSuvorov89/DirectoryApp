using System.Collections.Generic;

namespace NsiViewerDevExpress.Model
{
    /// <summary>
    /// Настройки атрибутов справочников НСИ.
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
        /// Код атрибута справочника НСИ.
        /// </summary>
        public string ReferenceAttributeId { get; set; }

        /// <summary>
        /// Код справочника НСИ. Ссылка на GM_NSIReference.ReferenceID.
        /// </summary>
        public string ReferenceId { get; set; }

        /// <summary>
        /// Тип атрибута. Принимает значения String, Integer, Real, DateTime, RecordRecId (ссылка на запись другого НСИ).
        /// </summary>
        public int ReferenceAttributeType { get; set; }

        /// <summary>
        /// Наименование атрибута.
        /// </summary>
        public string ReferenceAttributeName { get; set; }

        /// <summary>
        /// Код компании в DAX.
        /// </summary>
        public string DataAreaId { get; set; }

        /// <summary>
        /// Код записи в DAX.
        /// </summary>
        public long RecId { get; set; }

        /// <summary>
        /// Ссылка на справочник.
        /// Код связанного справочника НСИ для атрибута с типом RecordRecId. Ссылка на GM_NSIReference.ReferenceId.
        /// </summary>
        public string RefReferenceId { get; set; }

        public virtual GM_NSIReference GM_NSIReference { get; set; }
        public virtual GM_NSIReference RefReference { get; set; }
        public virtual ICollection<GM_NSIReferenceRecordAttribute> GM_NSIReferenceRecordAttribute { get; set; }
    }
}