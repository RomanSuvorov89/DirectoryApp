using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NsiViewerDevExpress.Model
{
    public class GM_NSIReferenceRecordAttributeMap : EntityTypeConfiguration<GM_NSIReferenceRecordAttribute>
    {
        public GM_NSIReferenceRecordAttributeMap()
        {
            // Primary Key
            HasKey(t => new { t.DataAreaId, t.ReferenceRecordRecId, t.ReferenceAttributeRecId });

            // Properties
            Property(t => t.ReferenceAttributeRecId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.ReferenceRecordRecId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.ValueString)
                .IsRequired()
                .HasMaxLength(255);

            Property(t => t.DataAreaId)
                .IsRequired()
                .HasMaxLength(4);

            // Table & Column Mappings
            ToTable("GM_NSIReferenceRecordAttribute");
            Property(t => t.ReferenceAttributeRecId).HasColumnName("ReferenceAttributeRecId");
            Property(t => t.ReferenceRecordRecId).HasColumnName("ReferenceRecordRecId");
            Property(t => t.ValueInteger).HasColumnName("ValueInteger");
            Property(t => t.ValueString).HasColumnName("ValueString");
            Property(t => t.ValueReal).HasColumnName("ValueReal");
            Property(t => t.ValueDate).HasColumnName("ValueDate");
            Property(t => t.ValueRecordRecId).HasColumnName("ValueRecordRecId");
            Property(t => t.DataAreaId).HasColumnName("DataAreaId");
            Property(t => t.RecId).HasColumnName("RecId");

            // Relationships
            HasRequired(t => t.GM_NSIReferenceAttribute)
                .WithMany(t => t.GM_NSIReferenceRecordAttribute)
                .HasForeignKey(d => new { d.DataAreaId, d.ReferenceAttributeRecId });
            HasRequired(t => t.GM_NSIReferenceRecord)
                .WithMany(t => t.GM_NSIReferenceRecordAttribute)
                .HasForeignKey(d => new { d.DataAreaId, d.ReferenceRecordRecId });
            HasOptional(t => t.ValueRecord)
                .WithMany(t => t.GM_NSIReferenceRecordAttribute1)
                .HasForeignKey(d => new { d.DataAreaId, d.ValueRecordRecId });
        }
    }
}
