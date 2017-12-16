using System.Collections.Generic;

namespace NsiViewerDevExpress.Model
{
    /// <summary>
    /// Настройки справочников НСИ.
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
        /// Код справочника НСИ.
        /// </summary>
        public string ReferenceId { get; set; }

        /// <summary>
        /// Группа справочников НСИ, к которой относится справочник. Ссылка на GM_NSIReferenceGroup.ReferenceGroupId.
        /// </summary>
        public string ReferenceGroupId { get; set; }

        /// <summary>
        /// Наименование справочника НСИ.
        /// </summary>
        public string ReferenceName { get; set; }

        /// <summary>
        /// Группа пользователей, ответственная за ведение справочника НСИ.
        /// </summary>
        public string UserGroupId { get; set; }

        /// <summary>
        /// Код компании в DAX.
        /// </summary>
        public string DataAreaId { get; set; }

        /// <summary>
        /// Код записи в DAX.
        /// </summary>
        public long RecId { get; set; }

        /// <summary>
        /// Тип справочника НСИ (обычный либо кросс-НСИ).
        /// </summary>
        public int ReferenceType { get; set; }

        public virtual ICollection<GM_NSIReferenceAttribute> GM_NSIReferenceAttribute { get; set; }
        public virtual ICollection<GM_NSIReferenceAttribute> GM_NSIReferenceAttribute1 { get; set; }

        /// <summary>
        /// Записи справочников НСИ.
        /// </summary>
        public virtual ICollection<GM_NSIReferenceRecord> GM_NSIReferenceRecord { get; set; }
    }
}