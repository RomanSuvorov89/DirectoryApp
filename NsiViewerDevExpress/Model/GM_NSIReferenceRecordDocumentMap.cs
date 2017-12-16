using System.Data.Entity.ModelConfiguration;

namespace NsiViewerDevExpress.Model
{
    public class GM_NSIReferenceRecordDocumentMap : EntityTypeConfiguration<GM_NSIReferenceRecordDocument>
    {
        public GM_NSIReferenceRecordDocumentMap()
        {
            // Primary Key
            HasKey(t => new { t.DocumentId, t.DataAreaId });

            // Properties
            Property(t => t.DocumentId).IsRequired().HasMaxLength(60);
            Property(t => t.DocumentNum).IsRequired().HasMaxLength(60);
            Property(t => t.DataAreaId).IsRequired().HasMaxLength(4);

            // Table & Column Mappings
            ToTable("GM_NSIReferenceRecordDocument");
            Property(t => t.DocumentId).HasColumnName("DocumentId");
            Property(t => t.DocumentNum).HasColumnName("DocumentNum");
            Property(t => t.DocumentDate).HasColumnName("DocumentDate");
            Property(t => t.DataAreaId).HasColumnName("DataAreaId");
            Property(t => t.RecId).HasColumnName("RecId");
        }
    }
}