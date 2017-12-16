using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NsiViewerDevExpress.Model
{
    public class GM_NSIReferenceMap : EntityTypeConfiguration<GM_NSIReference>
    {
        public GM_NSIReferenceMap()
        {
            // Primary Key
			HasKey(t => new { t.DataAreaId, t.ReferenceId });

            // Properties
            Property(t => t.ReferenceId)
                .IsRequired()
                .HasMaxLength(60);

            Property(t => t.ReferenceGroupId)
                .IsRequired()
                .HasMaxLength(60);

            Property(t => t.ReferenceName)
                .IsRequired()
                .HasMaxLength(120);

            Property(t => t.UserGroupId)
                .IsRequired()
                .HasMaxLength(10);

            Property(t => t.DataAreaId)
                .IsRequired()
                .HasMaxLength(4);

            // Table & Column Mappings
            ToTable("GM_NSIReference");
            Property(t => t.ReferenceId).HasColumnName("ReferenceId");
            Property(t => t.ReferenceGroupId).HasColumnName("ReferenceGroupId");
            Property(t => t.ReferenceName).HasColumnName("ReferenceName");
            Property(t => t.UserGroupId).HasColumnName("UserGroupId");
            Property(t => t.DataAreaId).HasColumnName("DataAreaId");
            Property(t => t.RecId).HasColumnName("RecId");
            Property(t => t.ReferenceType).HasColumnName("ReferenceType");
        }
    }
}