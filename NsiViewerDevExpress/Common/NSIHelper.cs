using System;
using System.Collections.Generic;
using System.Linq;
using NsiViewerDevExpress.Model;

namespace NsiViewerDevExpress.Common
{
    public static class NSIHelper
    {
        public static object GetAttributeValue(this GM_NSIReferenceRecordAttribute attribute)
        {
            switch ((NSIDataTypes)ReferenceAttributeCache.GetAttribute(attribute.ReferenceAttributeRecId).ReferenceAttributeType)
            {
                case NSIDataTypes.String:
                    return attribute.ValueString;
                case NSIDataTypes.Integer:
                    return attribute.ValueInteger;
                case NSIDataTypes.Real:
                    return attribute.ValueReal;
                case NSIDataTypes.DateTime:
                    return attribute.ValueDate;
                case NSIDataTypes.ReferenceRecord:
                    return attribute.ValueRecord;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static Type GetAttributeType(this GM_NSIReferenceAttribute attributeType)
        {
            switch ((NSIDataTypes) attributeType.ReferenceAttributeType)
            {
                case NSIDataTypes.String:
                    return typeof (string);
                case NSIDataTypes.Integer:
                    return typeof (int);
                case NSIDataTypes.Real:
                    return typeof (decimal);
                case NSIDataTypes.DateTime:
                    return typeof (DateTime);
                case NSIDataTypes.ReferenceRecord:
                    return typeof (GM_NSIReferenceRecord);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static object GetAttributeValue(this GM_NSIReferenceRecord record, string attributeId)
        {
            if (record == null)
                return null;
            var attribute = record.GM_NSIReferenceRecordAttribute.FirstOrDefault(
                    x =>
                    ReferenceAttributeCache.GetAttribute(x.ReferenceAttributeRecId).ReferenceAttributeId.Equals(attributeId, StringComparison.InvariantCultureIgnoreCase));
            if (attribute == null)
                throw new ApplicationException(string.Format("не найден НСИ атрибут {0} у записи {1}({2}) справочника {3}", attributeId, record.RecordId,
                                                             record.RecordName, record.ReferenceId));
            return GetAttributeValue(attribute);
        }

        public static object GetAttributeValueOrNull(this GM_NSIReferenceRecord record, string attributeId)
        {
            if (record == null)
                return null;
            var attribute =
                record.GM_NSIReferenceRecordAttribute.FirstOrDefault(
                    x => ReferenceAttributeCache.GetAttributeOrNull(x.ReferenceAttributeRecId) != null &&
                         ReferenceAttributeCache.GetAttributeOrNull(x.ReferenceAttributeRecId)
                             .ReferenceAttributeId.Equals(attributeId, StringComparison.InvariantCultureIgnoreCase));
            if (attribute == null)
                return null;

            return GetAttributeValue(attribute);
        }

        /// <summary>
        /// Получить запись указанного справочника NSI по указанному RecordID
        /// </summary>
        /// <param name="referenceId">ID справочника (задается через <see cref="NSIConstants"/>)</param>
        /// <param name="recordId">ID записи справочника (задается через <see cref="NSIConstants"/>)</param>
        /// <param name="context">Контекст, используемый для поиска</param>
        /// <returns>Возвращает запись справочника типа <see cref="GM_NSIReferenceRecord"/> либо Null</returns>
        public static GM_NSIReferenceRecord GetNSIReferenceRecordNullable(string referenceId, string recordId, NsiModel context = null)
        {
            if (context != null)
                return GetNSIReferenceRecord(context, referenceId, recordId);

            using (context = new NsiModel())
            {
                return GetNSIReferenceRecord(context, referenceId, recordId);
            }
        }
        
        public static GM_NSIReferenceRecord GetNSIReferenceRecord(long recId, NsiModel context = null)
        {
            if (context != null)
                return context.GM_NSIReferenceRecordSet.FirstOrDefault(x => x.RecId == recId);

            using (context = new NsiModel())
            {
                return context.GM_NSIReferenceRecordSet.FirstOrDefault(x => x.RecId == recId);
            }
        }

        /// <summary>
        /// Получить запись указанного справочника NSI по указанному RecordID
        /// </summary>
        /// <param name="referenceId">ID справочника (задается через <see cref="NSIConstants"/>)</param>
        /// <param name="recordId">ID записи справочника (задается через <see cref="NSIConstants"/>)</param>
        /// <param name="context">Контекст, используемый для поиска</param>
        /// <returns>Возвращает запись справочника типа <see cref="GM_NSIReferenceRecord"/> либо пустую заглушку</returns>
        public static GM_NSIReferenceRecord GetNSIReferenceRecord(string referenceId, string recordId, NsiModel context = null)
        {
            return GetNSIReferenceRecordNullable(referenceId, recordId, context);
        }

        private static GM_NSIReferenceRecord GetNSIReferenceRecord(NsiModel context, string referenceId, string recordId)
        {
            return context.GM_NSIReferenceRecordSet.FirstOrDefault(x =>
                x.ReferenceId.Equals(referenceId) &&
                x.RecordId.Equals(recordId));
        }

        /// <summary>
        /// Получить запись указанного справочника NSI по указанному значению атрибута
        /// </summary>
        /// <param name="referenceId">ID справочника (задается через <see cref="NSIConstants"/>)</param>
        /// <param name="atrId">ID атрибута (задается через <see cref="NSIConstants"/>)</param>
        /// /// <param name="atrVal">значение указанного атрибута</param>
        /// <param name="context">Контекст, используемый для поиска</param>
        /// <returns>Возвращает запись справочника типа <see cref="GM_NSIReferenceRecord"/> либо null</returns>
        public static GM_NSIReferenceRecord GetNSIReferenceRecordByAttribute(string referenceId, string atrId, object atrVal, NsiModel context = null)
        {
            if (String.IsNullOrWhiteSpace(referenceId) ||
                String.IsNullOrWhiteSpace(atrId) ||
                (atrVal is String ? String.IsNullOrWhiteSpace(atrVal as String) : atrVal == null))
                return null;

            List<GM_NSIReferenceRecord> records;
            if (context != null)
            {
                records = context.GM_NSIReferenceRecordSet
                    .Where(x => x.ReferenceId.Equals(referenceId)
                                && x.GM_NSIReferenceRecordAttribute.Any(
                                    a => a.GM_NSIReferenceAttribute.ReferenceAttributeId.Equals(atrId))).ToList();
                return records.FirstOrDefault(x =>
                {
                    var val = x.GetAttributeValue(atrId);
                    // Если атрибут является строковым - нужно искомое значение атрибута привести к строке, даже если в качестве значения передана не строка!
                    return val is String
                        ? String.Equals((val as String), atrVal.ToString(), StringComparison.OrdinalIgnoreCase)
                        : val == atrVal;
                });
            }

            using (context = new NsiModel())
            {
                records = context.GM_NSIReferenceRecordSet
                    .Where(x => x.ReferenceId.Equals(referenceId)
                                && x.GM_NSIReferenceRecordAttribute.Any(
                                    a => a.GM_NSIReferenceAttribute.ReferenceAttributeId.Equals(atrId))).ToList();
                return records.FirstOrDefault(x =>
                {
                    var val = x.GetAttributeValue(atrId);
                    return val is String
                        ? String.Equals((val as String), atrVal.ToString(), StringComparison.OrdinalIgnoreCase)
                        : val == atrVal;
                });
            }
        }

        public static GM_NSIReferenceRecord GetNSIReferenceRecordByAttributeSafe(string referenceId, string atrId, object atrVal, NsiModel context = null)
        {
            var record = GetNSIReferenceRecordByAttribute(referenceId, atrId, atrVal, context);

            return record ?? new GM_NSIReferenceRecord
            {
                RecId = 0,
                RecordId = string.Empty,
                RecordName = string.Empty
            };
        }

        /// <summary>
        /// Сравнение значений аттрибута у двух записей НСИ справочника (записи одного типа) применимо для аттрибутов типа Integer. Real, DateTime.
        /// </summary>
        /// <param name="rec1">Первая запись справочника НСИ</param>
        /// <param name="rec2">Вторая запись справочника НСИ</param>
        /// <param name="attributeID">Идентификатов аттрибута</param>
        /// <returns>true - если аттрибут первой записи больше или равен аттрибуту второй записис, иначе false</returns>
        public static bool FirstNSIAttributeGreaterOrEqual(GM_NSIReferenceRecord rec1, GM_NSIReferenceRecord rec2, string attributeID)
        {
            // Проверка переданы ли записи справочника
            if (rec1 == null || rec2 == null)
                throw new ApplicationException("FirstNSIAttributeGreaterOrEqual : Попытка сравнить аттрибуты пустой записи справочника");
            // Получение аттрибутов
            var attribute1 =
               rec1.GM_NSIReferenceRecordAttribute.FirstOrDefault(
                   x =>
                   ReferenceAttributeCache.GetAttribute(x.ReferenceAttributeRecId).ReferenceAttributeId.Equals(attributeID, StringComparison.InvariantCultureIgnoreCase));
            var attribute2 =
               rec2.GM_NSIReferenceRecordAttribute.FirstOrDefault(
                   x =>
                   ReferenceAttributeCache.GetAttribute(x.ReferenceAttributeRecId).ReferenceAttributeId.Equals(attributeID, StringComparison.InvariantCultureIgnoreCase));
            // Проверка существоания аттрибутов
            if (attribute1 == null)
                throw new ApplicationException(string.Format("не найден НСИ атрибут {0} у записи {1}({2}) справочника {3}", attributeID, rec1.RecordId,
                                                             rec1.RecordName, rec1.ReferenceId));
            if (attribute2 == null)
                throw new ApplicationException(string.Format("не найден НСИ атрибут {0} у записи {1}({2}) справочника {3}", attributeID, rec2.RecordId,
                                                             rec2.RecordName, rec2.ReferenceId));
            // Сравнение аттрибутов
            switch ((NSIDataTypes)ReferenceAttributeCache.GetAttribute(attribute1.ReferenceAttributeRecId).ReferenceAttributeType)
            {
                case NSIDataTypes.Integer:
                    return attribute1.ValueInteger >= attribute2.ValueInteger;
                case NSIDataTypes.Real:
                    return attribute1.ValueReal >= attribute2.ValueReal;
                case NSIDataTypes.DateTime:
                    return attribute1.ValueDate >= attribute2.ValueDate;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Значение заданного атрибута для заданной строки НСИ справочника
        /// </summary>
        /// <param name="referenceId">Ссылка на НСИ справочник</param>
        /// <param name="recordId">ИД строки НСИ справочника</param>
        /// <param name="attributeId">ИД атрибута НСИ справочника</param>
        /// <returns>Значение атрибута</returns>
        public static object GetNSIReferenceRecordAttributeValue(string referenceId, string recordId, string attributeId)
        {
            using (var entities = new NsiModel())
            {
                return GetNSIReferenceRecordAttributeValue(entities, referenceId, recordId, attributeId);
            }
        }

        /// <summary>
        /// Значение заданного атрибута для заданной строки НСИ справочника
        /// </summary>
        /// <param name="context">Контекст доступа к БД</param>
        /// <param name="referenceId">Ссылка на НСИ справочник</param>
        /// <param name="recordId">ИД строки НСИ справочника</param>
        /// <param name="attributeId">ИД атрибута НСИ справочника</param>
        /// <returns>Значение атрибута, либо null</returns>
        public static object GetNSIReferenceRecordAttributeValue(NsiModel context, string referenceId, string recordId, string attributeId)
        {
            // Чтобы не плодить лишние перекрестные вызовы прочих методов и не плодить лишние запросы к БД,
            // данный метод включает некоторый копипаст прочих методов, но является самодостаточным

            if(context == null)
                throw new ArgumentNullException("Не задан контекст доступа к данным");
            if(String.IsNullOrEmpty(referenceId) || String.IsNullOrEmpty(recordId) || String.IsNullOrEmpty(attributeId))
                throw new ArgumentNullException("Заданы не все параметры для поиска значения атрибута записи НСИ справочника");

            var nsiRecord = context.GM_NSIReferenceRecordSet.FirstOrDefault(x => x.ReferenceId == referenceId && x.RecordId == recordId);
            var nsiAttribute = context.GM_NSIReferenceAttributeSet.FirstOrDefault(x => x.ReferenceId == referenceId && x.ReferenceAttributeId == attributeId);
            if (nsiRecord != null && nsiAttribute != null)
            {
                var nsiRecordAttribute = nsiRecord.GM_NSIReferenceRecordAttribute.FirstOrDefault(x => x.ReferenceAttributeRecId == nsiAttribute.RecId);

                if (nsiRecordAttribute != null)
                {
                    switch ((NSIDataTypes)nsiAttribute.ReferenceAttributeType) {
                        case NSIDataTypes.String:
                            return nsiRecordAttribute.ValueString;
                        case NSIDataTypes.Integer:
                            return nsiRecordAttribute.ValueInteger;
                        case NSIDataTypes.Real:
                            return nsiRecordAttribute.ValueReal;
                        case NSIDataTypes.DateTime:
                            return nsiRecordAttribute.ValueDate;
                        case NSIDataTypes.ReferenceRecord:
                            return nsiRecordAttribute.ValueRecord;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
            }
            return null;
        }
    }
}