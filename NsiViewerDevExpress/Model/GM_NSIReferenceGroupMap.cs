using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NsiViewerDevExpress.Model
{
    public class GM_NSIReferenceGroupMap : EntityTypeConfiguration<GM_NSIReferenceGroup>
    {
        public GM_NSIReferenceGroupMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ReferenceGroupId, t.DataAreaId });

            // Properties
            this.Property(t => t.ReferenceGroupId)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.ReferenceGroupName)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.DataAreaId)
                .IsRequired()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("GM_NSIReferenceGroup");
            this.Property(t => t.ReferenceGroupId).HasColumnName("ReferenceGroupId");
            this.Property(t => t.ReferenceGroupName).HasColumnName("ReferenceGroupName");
            this.Property(t => t.DataAreaId).HasColumnName("DataAreaId");
            this.Property(t => t.RecId).HasColumnName("RecId");
        }
    }
}