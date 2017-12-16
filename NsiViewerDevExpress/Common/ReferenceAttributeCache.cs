using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using NsiViewerDevExpress.Model;

namespace NsiViewerDevExpress.Common
{
    public static class ReferenceAttributeCache
    {
        private static Dictionary<string, Dictionary<string, GM_NSIReferenceAttribute>> _attributeByReferenceDictionary;
        private static Dictionary<long, GM_NSIReferenceAttribute> _attributeByRecIdDictionary;

        public static IQueryable<GM_NSIReference> GM_NSIReference { get; set; }

        private static Dictionary<string, Dictionary<string, GM_NSIReferenceAttribute>> AttributeByReferenceDictionary
        {
            get
            {
                if (_attributeByReferenceDictionary == null)
                {
                    _attributeByReferenceDictionary = ((ObjectQuery<GM_NSIReference>) GM_NSIReference).Include("GM_NSIReferenceAttribute")
                                                                                                        .ToDictionary(x => x.ReferenceId,
                                                                                                                        x =>
                                                                                                                        x.GM_NSIReferenceAttribute.ToDictionary(
                                                                                                                            a => a.ReferenceAttributeId, a => a,
                                                                                                                            StringComparer.OrdinalIgnoreCase),
                                                                                                                        StringComparer.OrdinalIgnoreCase);
                }
                return _attributeByReferenceDictionary;
            }
        }

        private static Dictionary<long, GM_NSIReferenceAttribute> AttributeByRecIdDictionary
        {
            get
            {
                return _attributeByRecIdDictionary ??
                       (_attributeByRecIdDictionary =
                           AttributeByReferenceDictionary.SelectMany(x => x.Value.Values).ToDictionary(x => x.RecId));
            }
        }

        private static GM_NSIReferenceAttribute GetAttribute(string referenceId, string attributeId)
        {
            if (!AttributeByReferenceDictionary.ContainsKey(referenceId))
                throw new InvalidOperationException("Не найдены атрибуты справочника " + referenceId);
            if (!AttributeByReferenceDictionary[referenceId].ContainsKey(attributeId))
                throw new InvalidOperationException(string.Format("Не найдены атрибут {0} справочника {1}", attributeId, referenceId));
            return AttributeByReferenceDictionary[referenceId][attributeId];
        }

        public static GM_NSIReferenceAttribute GetAttribute(long referenceAttributeRecId)
        {
            if (!AttributeByRecIdDictionary.ContainsKey(referenceAttributeRecId))
                throw new InvalidOperationException("Не найден атрибут с идентификатором " + referenceAttributeRecId);
            return AttributeByRecIdDictionary[referenceAttributeRecId];
        }

        public static GM_NSIReferenceAttribute GetAttributeOrNull(long referenceAttributeRecId)
        {
            if (!AttributeByRecIdDictionary.ContainsKey(referenceAttributeRecId))
                return null;
            return AttributeByRecIdDictionary[referenceAttributeRecId];
        }

        public static NSIAttributeInfo GetAttributeInfo(string referenceId, string attributeId)
        {
            if (QueryAttributeInfo != null)
            {
                var ea = new NSIAttributeEventArgs();
                ea.ReferenceID = referenceId;
                ea.AttributeID = attributeId;
                QueryAttributeInfo(null, ea);
                if (ea.NSIAttributeInfo != null && ea.NSIAttributeInfo.RecID!= 0)
                    return ea.NSIAttributeInfo;
            }
            throw new InvalidOperationException(string.Format("В справочнике {0} нет атрибута {1}", referenceId, attributeId));
        }

        public static event EventHandler<NSIAttributeEventArgs> QueryAttributeInfo;

        public static void ReferenceAttributeCache_QueryAttributeInfo(object sender, NSIAttributeEventArgs e)
        {
            GM_NSIReferenceAttribute attribute = GetAttribute(e.ReferenceID, e.AttributeID);
            e.NSIAttributeInfo = new NSIAttributeInfo(attribute.RecId, attribute.ReferenceAttributeType, attribute.RefReferenceId);
        }

        public static void Clear()
        {
            _attributeByRecIdDictionary = null;
            _attributeByReferenceDictionary = null;
        }
    }

    public class NSIAttributeEventArgs : EventArgs
    {
        public NSIAttributeInfo NSIAttributeInfo { get; set; }

        public string ReferenceID { get; set; }

        public string AttributeID { get; set; }
    }

    public class NSIAttributeInfo
    {
        private readonly int _dataType;
        private readonly string _refReferenceId;
        private readonly long _recId;

        public NSIAttributeInfo(long recID, int dataType, string refReferenceID)
        {
            _recId = recID;
            _dataType = dataType;
            _refReferenceId = refReferenceID;
        }

        public long RecID
        {
            get { return _recId; }
        }

        public NSIDataTypes DataType
        {
            get { return (NSIDataTypes) _dataType; }
        }

        public string RefReferenceID
        {
            get { return _refReferenceId; }
        }
    }
}