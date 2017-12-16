using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NsiViewerDevExpress.Model
{
    public class GM_NSIREFERENCEATTRIBUTEINDEXMap : EntityTypeConfiguration<GM_NSIREFERENCEATTRIBUTEINDEX>
    {
        public GM_NSIREFERENCEATTRIBUTEINDEXMap()
        {
            // Primary Key
            HasKey(t => new { t.DATAAREAID, t.ATTRIBUTERECID });

            // Properties
            Property(t => t.DATAAREAID)
                .IsRequired()
                .HasMaxLength(4);

            Property(t => t.ATTRIBUTERECID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("GM_NSIREFERENCEATTRIBUTEINDEX");
            Property(t => t.DATAAREAID).HasColumnName("DATAAREAID");
            Property(t => t.RECID).HasColumnName("RECID");
            Property(t => t.ATTRIBUTERECID).HasColumnName("ATTRIBUTERECID");
        }
    }
}