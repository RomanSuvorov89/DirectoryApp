using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NsiViewerDevExpress.Model
{
    public class GM_NSIReferenceAttributeMap : EntityTypeConfiguration<GM_NSIReferenceAttribute>
    {
        public GM_NSIReferenceAttributeMap()
        {
            // Primary Key
            HasKey(t => new { t.DataAreaId, t.RecId });

            // Properties
            Property(t => t.ReferenceAttributeId).IsRequired().HasMaxLength(60);
            Property(t => t.ReferenceId).IsRequired().HasMaxLength(60);
            Property(t => t.ReferenceAttributeName).IsRequired().HasMaxLength(120);
            Property(t => t.DataAreaId).IsRequired().HasMaxLength(4);
            Property(t => t.RecId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(t => t.RefReferenceId).IsRequired().HasMaxLength(60);

            // Table & Column Mappings
            ToTable("GM_NSIReferenceAttribute");
            Property(t => t.ReferenceAttributeId).HasColumnName("ReferenceAttributeId");
            Property(t => t.ReferenceId).HasColumnName("ReferenceId");
            Property(t => t.ReferenceAttributeType).HasColumnName("ReferenceAttributeType");
            Property(t => t.ReferenceAttributeName).HasColumnName("ReferenceAttributeName");
            Property(t => t.DataAreaId).HasColumnName("DataAreaId");
            Property(t => t.RecId).HasColumnName("RecId");
            Property(t => t.RefReferenceId).HasColumnName("RefReferenceId");

            // Relationships
            HasRequired(t => t.GM_NSIReference)
                .WithMany(t => t.GM_NSIReferenceAttribute)
                .HasForeignKey(d => new { d.DataAreaId, d.ReferenceId });
            HasRequired(t => t.RefReference)
                .WithMany(t => t.GM_NSIReferenceAttribute1)
                .HasForeignKey(d => new { d.DataAreaId, d.RefReferenceId });
        }
    }
}