using System;

namespace NsiViewerDevExpress.Common
{
    public class DynamicReferenceTypeProperty
    {
        public string StringValue { get; set; }

        public long IntegerValue { get; set; }

        public decimal RealValue { get; set; }

        public DateTime DateTimeValue { get; set; }

        public long ReferenceRecordValue { get; set; }
    }
}