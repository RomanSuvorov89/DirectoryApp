using System.Collections.Generic;

namespace NsiViewerDevExpress.Model
{
    /// <summary>
    /// Записи справочников НСИ.
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
        /// Код справочника НСИ. Ссылка на GM_NSIReference.ReferenceID.
        /// </summary>
        public string ReferenceId { get; set; }

        /// <summary>
        /// Код записи в DAX.
        /// </summary>
        public long RecId { get; set; }

        /// <summary>
        /// Бизнес-ИД записи.
        /// Бизнес-идентификатор записи справочника НСИ. Уникален в пределах справочника.
        /// </summary>
        public string RecordId { get; set; }

        /// <summary>
        /// Описание записи справочника.
        /// Описание записи справочника НСИ.
        /// </summary>
        public string RecordName { get; set; }

        /// <summary>
        /// Признак "Запись федерального справочника". Зарезервировано для использования в будущем.
        /// </summary>
        public int isFederal { get; set; }

        /// <summary>
        /// Код компании в DAX.
        /// </summary>
        public string DataAreaId { get; set; }

        /// <summary>
        /// Дата начала действия записи справочника НСИ.
        /// </summary>
        public System.DateTime ValidFrom { get; set; }

        /// <summary>
        /// Дата окончания действия записи справочника НСИ.
        /// </summary>
        public System.DateTime ValidTo { get; set; }

        public virtual GM_NSIReference GM_NSIReference { get; set; }
        public virtual ICollection<GM_NSIReferenceRecordAttribute> GM_NSIReferenceRecordAttribute { get; set; }
        public virtual ICollection<GM_NSIReferenceRecordAttribute> GM_NSIReferenceRecordAttribute1 { get; set; }
    }
}