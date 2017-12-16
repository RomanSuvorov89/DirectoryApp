using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NsiViewerDevExpress.Model
{
    public class GM_NSIReferenceRecordMap : EntityTypeConfiguration<GM_NSIReferenceRecord>
    {
        public GM_NSIReferenceRecordMap()
        {
            // Primary Key
			HasKey(t => new { t.DataAreaId, t.RecId });

            // Properties
            Property(t => t.ReferenceId).IsRequired().HasMaxLength(60);
            Property(t => t.RecId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(t => t.RecordId).IsRequired().HasMaxLength(60);
            Property(t => t.RecordName).IsRequired().HasMaxLength(120);
            Property(t => t.DataAreaId).IsRequired().HasMaxLength(4);

            // Table & Column Mappings
            ToTable("GM_NSIReferenceRecord");
            Property(t => t.ReferenceId).HasColumnName("ReferenceId");
            Property(t => t.RecId).HasColumnName("RecId");
            Property(t => t.RecordId).HasColumnName("RecordId");
            Property(t => t.RecordName).HasColumnName("RecordName");
            Property(t => t.isFederal).HasColumnName("isFederal");
            Property(t => t.DataAreaId).HasColumnName("DataAreaId");
            Property(t => t.ValidFrom).HasColumnName("ValidFrom");
            Property(t => t.ValidTo).HasColumnName("ValidTo");

            HasRequired(t => t.GM_NSIReference)
                .WithMany(t => t.GM_NSIReferenceRecord)
                .HasForeignKey(d => new { d.DataAreaId, d.ReferenceId });
        }
    }
}