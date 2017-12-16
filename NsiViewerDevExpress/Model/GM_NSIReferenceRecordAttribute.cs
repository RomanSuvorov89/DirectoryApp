using System;

namespace NsiViewerDevExpress.Model
{
    /// <summary>
    /// Атрибуты записей справочников НСИ.
    /// </summary>
    public class GM_NSIReferenceRecordAttribute
    {
	    public GM_NSIReferenceRecordAttribute()
        {			
            //TODO
			//if (ApplicationSettings.Database != null) DataAreaId = ApplicationSettings.Database.DATAAREAID;
		}

        /// <summary>
        /// Ссылка на GM_NSIReferenceAttribute.RecId.
        /// </summary>
        public long ReferenceAttributeRecId { get; set; }

        /// <summary>
        /// Ссылка на GM_NSIReferenceRecord.RecId.
        /// </summary>
        public long ReferenceRecordRecId { get; set; }

        /// <summary>
        /// Целочисленное значение атрибута. Заполняется для атрибутов с типом Integer.
        /// </summary>
        public long ValueInteger { get; set; }

        /// <summary>
        /// Строковое значение атрибута. Заполняется для атрибутов с типом String.
        /// </summary>
        public string ValueString { get; set; }

        /// <summary>
        /// Числовое (с плавающей запятой) значение атрибута. Заполняется для атрибутов с типом Real.
        /// </summary>
        public decimal ValueReal { get; set; }

        /// <summary>
        /// Значение атрибута Дата/Время. Заполняется для атрибутов с типом DateTime.
        /// </summary>
        public DateTime ValueDate { get; set; }

        /// <summary>
        /// Значение атрибута типа ссылка на запись другого справочника НСИ. Заполняется для атрибутов с типом RecordRecId.
        /// </summary>
        public Nullable<long> ValueRecordRecId { get; set; }

        /// <summary>
        /// Код компании в DAX.
        /// </summary>
        public string DataAreaId { get; set; }

        /// <summary>
        /// Код записи в DAX.
        /// </summary>
        public long RecId { get; set; }

        public virtual GM_NSIReferenceAttribute GM_NSIReferenceAttribute { get; set; }
        public virtual GM_NSIReferenceRecord GM_NSIReferenceRecord { get; set; }
        public virtual GM_NSIReferenceRecord ValueRecord { get; set; }
    }
}