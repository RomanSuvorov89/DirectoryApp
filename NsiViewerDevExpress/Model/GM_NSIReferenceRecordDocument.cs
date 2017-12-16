using System;

namespace NsiViewerDevExpress.Model
{
    /// <summary>
    /// Связанные с НСИ документы.
    /// </summary>
    public class GM_NSIReferenceRecordDocument
    {
	    public GM_NSIReferenceRecordDocument()
        {			
            //TODO
			//if (ApplicationSettings.Database != null) DataAreaId = ApplicationSettings.Database.DATAAREAID;
		}

        /// <summary>
        /// Код связанного документа.
        /// </summary>
        public string DocumentId { get; set; }

        /// <summary>
        /// Наименование документа.
        /// </summary>
        public string DocumentNum { get; set; }

        /// <summary>
        /// Дата документа.
        /// </summary>
        public Nullable<DateTime> DocumentDate { get; set; }

        /// <summary>
        /// Код компании в DAX.
        /// </summary>
        public string DataAreaId { get; set; }

        /// <summary>
        /// Код записи в DAX.
        /// </summary>
        public long RecId { get; set; }
    }
}