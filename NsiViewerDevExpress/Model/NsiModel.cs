using System.Data.Entity;

namespace NsiViewerDevExpress.Model
{
    public partial class NsiModel : DbContext
    {
        public NsiModel()
            : base("name=NsiModelCs")
        {
        }

        public NsiModel(string connectionString)
            : base(connectionString)
        {
        }

        public virtual DbSet<GM_NSIReference> GM_NSIReferenceSet { get; set; }
        public virtual DbSet<GM_NSIReferenceAttribute> GM_NSIReferenceAttributeSet { get; set; }
        //public virtual DbSet<GM_NSIREFERENCEATTRIBUTEINDEX> GM_NSIREFERENCEATTRIBUTEINDEXSet { get; set; }
        public virtual DbSet<GM_NSIReferenceGroup> GM_NSIReferenceGroupSet { get; set; }
        public virtual DbSet<GM_NSIReferenceRecord> GM_NSIReferenceRecordSet { get; set; }
        public virtual DbSet<GM_NSIReferenceRecordAttribute> GM_NSIReferenceRecordAttributeSet { get; set; }
        //public virtual DbSet<GM_NSIReferenceRecordDocument> GM_NSIReferenceRecordDocumentSet { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new GM_NSIReferenceMap());
            modelBuilder.Configurations.Add(new GM_NSIReferenceAttributeMap());
            //modelBuilder.Configurations.Add(new GM_NSIREFERENCEATTRIBUTEINDEXMap());
            modelBuilder.Configurations.Add(new GM_NSIReferenceGroupMap());
            modelBuilder.Configurations.Add(new GM_NSIReferenceRecordMap());
            modelBuilder.Configurations.Add(new GM_NSIReferenceRecordAttributeMap());
            //modelBuilder.Configurations.Add(new GM_NSIReferenceRecordDocumentMap());
        }
    }
}