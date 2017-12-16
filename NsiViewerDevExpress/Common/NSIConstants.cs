using System;

namespace NsiViewerDevExpress.Common
{
    public static class NSIConstants
    {
        public static class PayServices
        {
            public const string ReferenceID = "PayServices";

            public static class Attributes
            {
                public const string ServiceId = "ServiceId";
                public const string ServiceName = "ServiceName";
                public const string PayVendorsRefId = "PayVendorsRefId";
                public const string PluginId = "PluginId";
                public const string PayServiceKindRefId = "PayServiceKindRefId";
            }
        }

        public static class PayVendors
        {
            public const string ReferenceID = "PayVendors";

            public static class Attributes
            {
                public const string INN = "INN";
                public const string KPP = "KPP";
                public const string Name = "Name";
                public const string Adress = "Address";
                public const string Telephone = "Phone";
                public const string PluginId = "PluginId";
            }
        }

        public static class PayServiceKind
        {
            public const string ReferenceID = "PayServiceKind";

            public static class Attributes
            {
                public const string KindId = "0002";
                public const string KindName = "0001";
            }
        }

        /// <summary>
        /// Справочник рискованных операций
        /// </summary>
        public static class RiskyOperations
        {
            public static class Attributes
            {
                /// <summary>
                /// Блокировать ли операцию (не класть в корзину)
                /// </summary>
                public const string Block = "Block";
            }
        }
        /// <summary>
        /// Справочник контактной информации ОПС (адреса, телефоны, график работы)
        /// </summary>
        public static class DepartmentDetails
        {
            public const string ReferenceID = "KontaktOPS";
            public static class Attributes
            {
                /// <summary>
                /// Адрес
                /// </summary>
                public const string Address = "Address";

                /// <summary>
                /// Телефон опс
                /// </summary>
                public const string Phone = "Tel";

                /// <summary>
                /// Телефон для вызова курьера
                /// </summary>
                public const string CourierPhone = "Tel2";

                /// <summary>
                /// График работы
                /// </summary>
                public const string Shedule = "Schedule";
            }
        }

        /// <summary>
        /// справочник типов накладных
        /// </summary>
        public static class WaybillType
        {
            public const string ReferenceID = "WaybillType";

            /// <summary>
            /// Ф.16
            /// </summary>
            public const string Bill16 = "01";

            /// <summary>
            /// Ф.16-ПТ
            /// </summary>
            public const string Bill16PT = "02";

            /// <summary>
            /// Ф.16-А
            /// </summary>
            public const string Bill16A = "03";

            /// <summary>
            /// Ф.23
            /// </summary>
            public const string Bill23 = "04";

            /// <summary>
            /// Ф.23-А
            /// </summary>
            public const string Bill23A = "05";

            /// <summary>
            /// Ф.16-Б
            /// </summary>
            public const string Bill16B = "06";

            /// <summary>
            /// Ф.16-В
            /// </summary>
            public const string Bill16V = "07";

            /// <summary>
            /// Ф.16-С
            /// </summary>
            public const string Bill16S = "08";

            /// <summary>
            /// Ф.17-E
            /// </summary>
            public const string Bill17E = "09";

            /// <summary>
            /// ф.23 на емкость
            /// </summary>
            public const string Bill23Capacity = "10";

            /// <summary>
            /// Выплата на кассе
            /// </summary>
            public const string ShiftPayments = "14";

            /// <summary>
            /// Журнал изъятия РПО из АПМ
            /// </summary>
            public const string RemoveRPOFromAPM = "15";

            /// <summary>
            /// Журнал переадресации РПО в АПМ
            /// </summary>
            public const string RedirectRPOtoAPM = "16";
        }

        /// <summary>
        /// справочник типов операций над накладными
        /// </summary>
        public static class WayBillOperType
        {
            public const string ReferenceID = "WaybillOperType";

            /// <summary> Расформирование </summary>
            public const string Disbanding = "1";
            /// <summary> Приписка </summary>
            public const string Codicil = "2";
            /// <summary> Отправка </summary>
            public const string Sending = "3";
            /// <summary> Регистрация </summary>
            public const string Registration = "4";
            /// <summary> Формирование </summary>
            public const string Creation = "5";
        }

        /// <summary>
        /// справочник типов операций над емкостями
        /// </summary>
        public static class ContainerOperType
        {
            public const string ReferenceID = "ContainerOperType";

            /// <summary> Расформирование </summary>
            public const string Disbanding = "1";
            /// <summary> Приписка </summary>
            public const string Codicil = "2";
            /// <summary> Отправка </summary>
            public const string Sending = "3";
            /// <summary> Вскрытие </summary>
            public const string Opening = "4";
            /// <summary> Регистрация </summary>
            public const string Registration = "5";
            /// <summary> Формирование </summary>
            public const string Creation = "6";
        }

        /// <summary>
        /// справочник типа адреса клиента
        /// </summary>
        public static class ClientAdressType
        {
            public const string ReferenceID = "ClientAdressType";

            /// <summary>
            /// а/я
            /// </summary>
            public const string SubscriberAddress = "01";

            /// <summary>
            /// До востребования
            /// </summary>
            public const string OnDemand = "02";

            /// <summary>
            /// Гостиница
            /// </summary>
            public const string Hotel = "03";

            /// <summary>
            /// Войсковая часть
            /// </summary>
            public const string MilitaryUnit = "04";

            /// <summary>
            /// Полевая почта
            /// </summary>
            public const string FieldPost = "05";

            /// <summary>
            /// Стандартный адрес
            /// </summary>
            public const string StandardAddress = "06";

            public class ClientAdressTypeAttributes
            {
                public const string ASURPOCode = "ASURPOCode";

                public const string AdressFormat = "AdressFormat";
            }
        }

        /// <summary>
        /// справочник категорий отправлений
        /// </summary>
        public static class ContainerCategory
        {
            public const string ReferenceID = "ContainerCategory";

            /// <summary>
            /// Правительственное
            /// </summary>
            public const string Governmental = "04";

            /// <summary>
            /// Простая
            /// </summary>
            public const string Simple = "01";

            /// <summary>
            /// Заказная
            /// </summary>
            public const string Registered = "02";

            /// <summary>
            /// Страховая
            /// </summary>
            public const string Insurance = "03";

            /// <summary>
            /// С порожней тарой
            /// </summary>
            public const string WithEmpties = "05";

            /// <summary>
            /// 1 класс
            /// </summary>
            public const string FirstClass = "06";

            /// <summary>
            /// EMS
            /// </summary>
            public const string EMS = "07";

            /// <summary>
            /// С печатью
            /// </summary>
            public const string WithStamp = "08";

            public class Attributes
            {
                /// <summary>
                /// Код для ДШК согласно РТМ 0025
                /// </summary>
                public const string RTM25Code = "RTM25Code";
            }
        }

        /// <summary>
        /// справочник классов отправления
        /// </summary>
        public static class DispatchClass
        {
            public const string ReferenceID = "DispatchClass";

            /// <summary>
            /// Внутренняя
            /// </summary>
            public const string Internal = "01";

            /// <summary>
            /// Международная
            /// </summary>
            public const string International = "02";

            public class DispatchClassAttributes
            {
                public const string ASURPOCode = "ASURPOCode";

                public const string ShortName = "ShortNameClass";
            }
        }

        public static class ContainerMark
        {
            public const string ReferenceID = "ContainerMark";

            /// <summary>
            /// Первый класс
            /// </summary>
            public const string FirstClass = "02";

            /// <summary>
            /// Правительственные
            /// </summary>
            public const string Government = "06";

            /// <summary>
            /// Международная
            /// </summary>
            public const string International = "07";

            /// <summary>
            /// Авиа
            /// </summary>
            public const string Avia = "01";

            /// <summary>
            /// С международными отправлениями
            /// </summary>
            public const string InternationalDispatch = "14";

            public class Attributes
            {
                /// <summary>
                /// Код для ДШК согласно РТМ 0025
                /// </summary>
                public const string RTM25Code = "RTM25Code";

                /// <summary>
                /// Приоритет отметки
                /// </summary>
                public const string Priority = "Priority";
            }
        }

        public static class ContainerClass
        {
            public const string ReferenceID = "ContainerRank";

            /// <summary>
            /// Внутреннее
            /// </summary>
            public const string Internal = "01";

            /// <summary>
            /// Международное
            /// </summary>
            public const string International = "03";

            /// <summary>
            /// Смешанное
            /// </summary>
            public const string Mixed = "02";
        }

        public static class ContainerType
        {
            // public const string ReferenceID = "ContainerRank";
            public const string ReferenceID = "ContainerKind";

            /// <summary>
            /// Контейнер
            /// </summary>
            public const string Container = "00";

            /// <summary>
            /// Мешок
            /// </summary>
            public const string Sack = "01";

            /// <summary>
            /// Ящик
            /// </summary>
            public const string Chest = "02";

            /// <summary>
            /// Постпакет
            /// </summary>
            public const string Postpaket = "03";

            /// <summary>
            /// Группа РПО
            /// </summary>
            public const string RPOgroup = "04";

            /// <summary>
            /// Паллета
            /// </summary>
            public const string Pallet = "21";

            /// <summary>
            /// Мешок "М"
            /// </summary>
            public const string SackM = "06";

            /// <summary>
            /// Коробка
            /// </summary>
            public const string Box = "07";

            /// <summary>
            /// Открытая международная посылка
            /// </summary>
            public const string OpenInternationalSending = "08";

            /// <summary>
            /// Группа - Открыто
            /// </summary>
            public const string OpenGroup = "09";

            /// <summary>
            /// На поддоне
            /// </summary>
            public const string OnThePallet = "10";

            public class ContainerTypeAttributes
            {
                /// <summary>
                /// Код из ДШК
                /// </summary>
                public const string CodeBC = "CodeBC";

                /// <summary>
                /// Код АСУ РПО
                /// </summary>
                public const string ASURPOCode = "ASURPOCode";

                /// <summary>
                /// Код для ДШК согласно РТМ 0025
                /// </summary>
                public const string RTM25Code = "RTM25Code";
            }
        }

        public static class DispatchRank
        {
            public const string ReferenceID = "DispatchRank";

            /// <summary>
            /// Судебное
            /// </summary>
            public const string Justice = "04";

            public class DispatchRankAttributes
            {
                /// <summary>
                /// ASURPOCode
                /// </summary>
                public const string ASURPOCode = "ASURPOCode";
            }
        }

        public static class DispatchKind
        {
            public const string ReferenceID = "DispatchKind";

            /// <summary>Бланк Почтового перевода</summary>
            public const string MailTransfer = "01";

            /// <summary>Письмо</summary>
            public const string Letter = "02";

            /// <summary>Бандероль</summary>
            public const string Printed = "03";

            /// <summary>Посылка</summary>
            public const string Sending = "04";

            /// <summary>Почтовая карточка</summary>
            public const string PostCard = "06";

            /// <summary>Отправление EMS</summary>
            public const string EMS = "07";

            /// <summary>Секограмма</summary>
            public const string Secograms = "08";

            /// <summary>Письмо 1 класса</summary>
            public const string Letter1StClass = "15";

            /// <summary>Бандероль первого класса</summary>
            public const string Printed1StClass = "16";

            /// <summary>ОВПО</summary>
            public const string OVPO = "19";

            /// <summary>Мультиконверт</summary>
            public const string Multikonvert = "20";

            /// <summary>Мелкий пакет</summary>
            public const string SmallPackage = "21";

            /// <summary>Мешок М</summary>
            public const string BagM = "22";

            /// <summary>Прямой Контейнер</summary>
            public const string DirectContainer = "23";

            /// <summary>Отправление электронной почты</summary>
            public const string Email = "24";

            /// <summary>Бланк уведомления</summary>
            public const string NotificationForm = "25";

            /// <summary>Газетная пачка</summary>
            public const string NewspaperPack = "26";

            /// <summary>Сгруппированные отправления "Консигнация"</summary>
            public const string GroupedDeparture = "27";

            /// <summary>Бланк уведомления 1-го класса</summary>
            public const string NotificationForm1StClass = "28";

            /// <summary>Сумка страховая</summary>
            public const string BagInsurance = "29";

            /// <summary>МКПО</summary>
            public const string MKPO = "30";

            /// <summary>карточка ОВПО</summary>
            public const string OvpoCard = "31";
            /// <summary>Посылка Курьер</summary>
            public const string SendingCourier = "34";
            /// <summary>Посылка Стандарт</summary>
            public const string SendingStandard = "35";
            /// <summary>Посылка Экспресс</summary>
            public const string SendingExpress = "36";

            /// <summary>Письмо 2.0</summary>
            public const string Letter2 = "37";
            /// <summary>Письмо Экспресс</summary>
            public const string LetterExpress = "38";
            /// <summary>Письмо Курьеское</summary>
            public const string LetterCourier = "39";

            /// <summary>Посылка нестандартная</summary>
            public const string SendingNotStandard = "45";
            /// <summary>Посылка нестандартная негабаритная</summary>
            public const string SendingNotOverall = "46";

            public class DispatchKindAttributes
            {
                /// <summary>ASURPOCode</summary>
                public const string ASURPOCode = "ASURPOCode";

                public const string ShortName = "ShortNameKind";
            }
        }

        public static class DispatchCategory
        {
            public const string ReferenceID = "DispatchCategory";

            /// <summary>Простое</summary>
            public const string Simple = "00";

            /// <summary>Заказное</summary>
            public const string Registered = "01";

            /// <summary>С объявленной ценностью</summary>
            public const string WithDeclaredValue = "02";

            /// <summary>Обыкновенное</summary>
            public const string Ordinary = "03";

            /// <summary>С объявленной ценностью и наложенным платежом</summary>
            public const string WithDeclaredValueAndCashOnDelivery = "04";

            /// <summary>Не определена</summary>
            public const string NotDefined = "05";

            /// <summary>С объявленной ценностью и обязательным платежом</summary>
            public const string WithDeclaredValueAndMandatoryPayment = "06";

            public class DispatchCategoryAttributes
            {
                /// <summary>
                /// ASURPOCode
                /// </summary>
                public const string ASURPOCode = "ASURPOCode";

                public const string ShortName = "ShortNameCategory";
            }
        }

        /// <summary>Тип операции над РПО</summary>
        public static class DispatchOperType
        {
            public const string ReferenceID = "DispatchOperType";

            /// <summary>Прием</summary>
            public const string Receipt = "01";

            /// <summary>Вручение</summary>
            public const string Delivery = "02";

            /// <summary>Возврат</summary>
            public const string Return = "03";

            /// <summary>Досылка</summary>
            public const string ReSend = "04";

            /// <summary>Невручение</summary>
            public const string FailureToHand = "05";

            /// <summary>Временное хранение</summary>
            public const string TempStorage = "07";

            /// <summary>Обработка</summary>
            public const string Processing = "08";

            /// <summary>Неудачная попытка вручения</summary>
            public const string FailedAttempt = "12";

            /// <summary>Регистрация отправки</summary>
            public const string RegistrationSend = "13";

            /// <summary>Уничтожение</summary>
            public const string Destroyed = "16";

            /// <summary>Прибыло в ОПС вручения</summary>
            public const string Arrived = "17";

            /// <summary>Выслано первичное извещение</summary>
            public const string FirstNotificationSent = "18";

            /// <summary>Выслано вторичное извещение</summary>
            public const string SecondNotificationSent = "19";

            /// <summary>Вторичное извещение вручено под подпись</summary>
            public const string SecondNotificationDelivered = "20";

            /// <summary>Вторичное извещение опущено в ящик</summary>
            public const string SecondNotificationPosted = "21";

            /// <summary>Регистрация ураты</summary>
            public const string RegisterMissing = "22";

            /// <summary>Отмена</summary>
            public const string Cancel = "33";

            /// <summary>Передача на временное хранение</summary>
            public const string TransferToTemporaryStorage = "15";

            /// <summary>Отправка SRM</summary>
            public const string TransferSRM = "35";
        }

        public static class DispatchTransferMethod
        {
            public const string ReferenceID = "DispatchTransferMethod";

            public class DispatchTransferMethodAttributes
            {
                /// <summary>
                /// ASURPOCode
                /// </summary>
                public const string ASURPOCode = "ASURPOCode";
            }
        }

        /// <summary>
        /// Короткие и сокращенные наименования почтовых отправлений
        /// </summary>
        public static class DispatchShortNames
        {
            public const string ReferenceID = "DispatchShortNames";

            public class Attributes
            {
                /// <summary>
                /// Краткое наименование
                /// </summary>
                public const string ShortName = "ShortName";

                /// <summary>
                /// Сокращенное наименование
                /// </summary>
                public const string AbbrName = "AbbrName";

                /// <summary>
                /// Класс почтового отправления
                /// </summary>
                public const string DispatchClass = "DispatchClass";

                /// <summary>
                /// Категория почтового отправления
                /// </summary>
                public const string DispatchCategory = "DispatchCategory";

                /// <summary>
                /// Вид почтового отправления
                /// </summary>
                public const string DispatchKind = "DispatchKind";
            }
        }

        /// <summary>
        /// Способы доставки РПО
        /// </summary>
        public static class DispatchDeliveryType
        {
            public const string ReferenceID = "DispatchDeliveryType";

            /// <summary>
            /// Доставка Почтальоном
            /// </summary>
            public const string PostmanDelivery = "2";
            /// <summary>
            /// Доставка Курьером
            /// </summary>
            public const string CourierDelivery = "3";
            /// <summary>
            /// Переадресация в почтомат
            /// </summary>
            public const string RedirectToAPS = "4";
        }

        /// <summary>
        /// Статусы РПО
        /// </summary>
        public static class DispatchBatchMarks
        {
            public const string ReferenceID = "DispatchBatchMarks";

            /// <summary>Переопределен индекс</summary>
            public const string OverriddenIndex = "01";

            /// <summary>Текст адреса не найден в ЦХДПА</summary>
            public const string AddressNotFound = "02";

            /// <summary>Способ пересылки некорректен</summary>
            public const string IncorrectShippingMethod  = "03";

            /// <summary>Отклонение от подавательского веса</summary>
            public const string WeightDeviation  = "04";

            /// <summary>Несоответствие тарифу</summary>
            public const string TariffMismatch = "05";

            /// <summary>Неверный индекс</summary>
            public const string InvalidIndex  = "06";

            /// <summary>Отсутствует в списке</summary>
            public const string NoListed  = "07";

            public class DispatchBatchMarksAttributes
            {
                /// <summary>IsForDelete</summary>
                public const string IsForDelete = "IsForDelete";
            }
        }

        /// <summary>
        /// справочник периодов 
        /// </summary>
        public static class Period
        {
            public const string ReferenceID = "Period";

            /// <summary>
            /// атрибуты
            /// </summary>
            public class Attributes
            {
                /// <summary>
                /// Начало периода
                /// </summary>
                public const string BeginnigOfPeriod = "BeginnigOfPeriod";

                /// <summary>
                /// Окончание периода
                /// </summary>
                public const string EndOfPeriod = "EndOfPeriod";
            }
        }

        /// <summary>
        /// справочник статусов
        /// </summary>
        public static class Status
        {
            public const string ReferenceID = "Status";

            /// <summary>создан</summary>
            public const string Created = "1";

            /// <summary>сохранен</summary>
            public const string Saved = "2";

            /// <summary>подтвержден</summary>
            public const string Confirmed = "3";

            /// <summary> Разнесен </summary>
            public const string Delivered = "5";

            /// <summary>
            /// Аннулирован
            /// </summary>
            public const string Annulled = "6";
        }

        /// <summary>
        /// справочник почтовых отметок
        /// </summary>
        public static class PostMark
        {
            public const string ReferenceID = "PostMark";

            /// <summary>
            /// Без отметки
            /// </summary>
            public const string WithoutMark = "01";
            /// <summary>
            /// С простым уведомлением
            /// </summary>
            public const string WithASimpleNotification = "02";
            /// <summary>
            /// С заказным уведомлением
            /// </summary>
            public const string WithARegisteredNotice = "03";
            /// <summary>
            /// Осторожно (Хрупкая)
            /// </summary>
            public const string Caution = "05";
            /// <summary>
            /// С миграционным уведомлением
            /// </summary>
            public const string MigrationNotice = "16";
            /// <summary>
            /// Возврату не подлежит
            /// </summary>
            public const string NoReturn = "12";

            /// <summary>
            /// ASURPOCode
            /// </summary>
            public class PostMarkAttributes
            {
                /// <summary>
                /// ASURPOCode
                /// </summary>
                public const string ASURPOCode = "ASURPOCode";

                /// <summary>
                /// Краткое наименование
                /// </summary>
                public const string ShortName = "ShortName";

            }
        }

        /// <summary>
        /// Причины и  операции
        /// </summary>
        public static class DispatchOperReason
        {
            public const string ReferenceID = "DispatchOperReason";

            /// <summary>Выдано получателю через почтомат</summary>
            public const string DeliveredToReceiverByOPS = "05";

            /// <summary>Выдано отправителю через почтомат</summary>
            public const string DeliveredToSenderByOPS = "06";

            /// <summary> По заявлению пользователя</summary>
            public const string ByCustomerRequest = "21";

            /// <summary> Покинуло место приёма</summary>
            public const string LeftReceiveLocation = "33";

            /// <summary> Прибыло в почтомат</summary>
            public const string ArrivedToOPS = "41";

            /// <summary>Переадресовано в почтомат</summary>
            public const string ForwardedToPochtomat = "43";

            /// <summary>Изъято из почтомата</summary>
            public const string RemovedFromOPS = "44";

            /// <summary>Помещение в кладовую хранения</summary>
            public const string PlacedInStorage = "64";
        }

        /// <summary>Причина операции</summary>
        public static class DispatchReasonType
        {
            public const string ReferenceID = "OperReason";

            public class DispatchReasonTypeAttributes
            {
                public const string OperationID = "DispatchOperType";

                public const string ASURPOCode = "ASURPOCode";
            }

            /// <summary>Единичный</summary>
            public const string Single = "01";

            /// <summary>Партионный</summary>
            public const string Batch = "02";

            /// <summary>Вручено адресату</summary>
            public const string Delivered = "03";

            /// <summary>Вручение отправителю</summary>
            public const string DeliveredToSender = "04";

            /// <summary>Утрачено</summary>
            public const string Lost = "07";

            /// <summary>Изъято</summary>
            public const string Withdraw = "08";

            /// <summary>Прибыло в ОПС вручения</summary>
            public const string ArrivedToDeliveryOPS = "17";

            /// <summary>Покинуло место приема</summary>
            public const string LeftReceptionPlace = "33";

            /// <summary>Прибыло в место вручения</summary>
            public const string ArrivedToDeliveryPlace = "34";

            /// <summary>Прибыло в место международного обмена)</summary>
            public const string ArrivedInternationalExchangePlace = "37";

            /// <summary>Покинуло место международного обмена</summary>
            public const string LeftInternationalExchangePlace = "38";

            /// <summary>Прибыло в место транзита</summary>
            public const string ArrivedToTransitPlace = "39";

            /// <summary>Покинуло место транзита</summary>
            public const string LeftTransitPlace = "40";
            
            /// <summary>Переадресовано в почтомат</summary>
            public const string ForwardedToPochtomat = "43";

            /// <summary>Изъято из почтомата</summary>
            public const string WithdrawnFromPochtomat = "44";

            /// <summary>Временное отсутствие адресата</summary>
            public const string TemporaryAbsenceOfAddressee = "47";

            /// <summary>Аннулировано</summary>
            public const string Annulled = "59";

            /// <summary>Вручено на кассе</summary>
            public const string DeliveredOnPOS = "60";

            /// <summary>Вручено почтальоном</summary>
            public const string DeliveredByPostman = "61";

            /// <summary>Передача в кладовую хранения</summary>
            public const string TransferedToStorage = "62";

            /// <summary>Прибыло на территорию РФ</summary>
            public const string ArrivedToRussia = "72";

            /// <summary>Покинуло место возврата/досылки</summary>
            public const string LeftReturnPlace = "78";

            /// <summary> Передача на временное хранение </summary>
            public const string TransferToTemporaryStorage = "86";
        }

        public static class TareType
        {
            public const string ReferenceID = "TareType";

            /// <summary>
            /// Без тары
            /// </summary>
            public const string WithoutTare = "01";
            
            /// <summary>
            /// Ящики
            /// </summary>
            public const string Box = "02";
            
            /// <summary>
            /// Мешки
            /// </summary>
            public const string Bag = "03";

            /// <summary>
            /// Паллеты
            /// </summary>
            public const string Pallette = "04";

            /// <summary>
            /// Контейнер (КПС-5)
            /// </summary>
            public const string ContainerBig = "05";

            /// <summary>
            /// Ящик флэт
            /// </summary>
            public const string BoxFlat = "06";

            /// <summary>
            /// Мешки авиа
            /// </summary>
            public const string BagAvia = "07";

            /// <summary>
            /// Резерв
            /// </summary>
            public const string Reserve = "08";

            /// <summary>
            /// Контейнер малый КПС-6	
            /// </summary>
            public const string ContainerSmall = "09";

            /// <summary>
            /// Контейнер пластиковый КСРП-П
            /// </summary>
            public const string ContainerPlastic = "10";

            /// <summary>
            /// Мешки обменные (не номерные)
            /// </summary>
            public const string BagWithoutNumber = "11";

            /// <summary>
            /// Мешки номерные
            /// </summary>
            public const string BagWithNumber = "12";

            /// <summary>
            /// Мешки одноразовые
            /// </summary>
            public const string BagDispousable = "13";

            /// <summary>
            /// Мешки иностранные
            /// </summary>
            public const string BagForeign = "14";

            /// <summary>
            /// Ящики авиа
            /// </summary>
            public const string BoxAvia = "15";

            public class Attributes
            {
                /// <summary>
                /// Код для ДШК согласно РТМ 0025
                /// </summary>
                public const string RTM25Code = "RTM25Code";
            }
        }

        public static class Department
        {
            public const string ReferenceID = "IndexEtalon";

            public class DepartmentAttributes
            {
                /// <summary>Полное наименование объекта почтовой связи</summary>
                public const string FullName = "FullName";

                /// <summary>Краткое наименование объекта почтовой связи</summary>
                public const string ShortName = "ShortName";

                /// <summary> ИД Региона </summary>
                public const string RegionId = "RegionId";

                /// <summary> Населенный пункт</summary>
                public const string CITY = "CITY";

                /// <summary> Вышестоящий ОПС </summary>
                public const string OPSSUBM = "OPSSUBM";

                /// <summary> Тип ОПС </summary>
                public const string OPSTYPE = "OPSTYPE";
            }
        }

        public static class Currency
        {
            public const string ReferenceID = "Currency";

            /// <summary>руб</summary>
            public const string Rub = "001";

            public class CurrencyAttributes
            {
                /// <summary>Код валюты для ПОС (RUR, USD и т.д.)</summary>
                public const string CurrencyCode = "CurrencyCode";

                public const string WUCode = "WUCode";
            }
        }

        public static class DispatchAddService
        {
            public const string ReferenceID = "DopUslugi";

            /// <summary>Хранение</summary>
            public const string Storage = "006";

            /// <summary>Досылка</summary>
            public const string ReSend = "005";

            /// <summary>Возврат</summary>
            public const string Return = "004";

            /// <summary>Наложенный платеж</summary>
            public const string PaymentForward = "007";

            /// <summary>Таможенная пошлина</summary>
            public const string PaymentCustom = "008";

            /// <summary>Простое уведомление о вручении внутреннего РПО</summary>
            public const string SimpleNotificationOfReceiptInternal = "01";

            /// <summary>Простое уведомление о получении международного РПО</summary>
            public const string SimpleNotificationOfReceiptInternational = "02";

            /// <summary>Заказное уведомление о вручении внутреннего РПО</summary>
            public const string RegisteredNotificationOfReceiptInternal = "03";

            /// <summary>SMS-уведомление к внутренним почтовым отправлениям отправителя (уведомление о вручении)</summary>
            public const string SMSNotificationSenderOfReceipt = "04";

            /// <summary>SMS-уведомление к внутренним почтовым отправлениям получателя (уведомление о поступлении в ОПС вручения)</summary>
            public const string SMSNotificationReceiptOfDelivery = "05";

            /// <summary>SMS-уведомление к внутренним почтовым отправлениям отправителя (уведомление о поступлении в ОПС вручения)</summary>
            public const string SMSNotificationSenderOfDelivery = "06";

            /// <summary>Простое уведомление о вручении внутреннего РПО(Оплата марками)</summary>
            public const string SimpleNotificationOfReceiptInternal_PayMarks = "39";

            /// <summary>Заказное уведомление о вручении внутреннего РПО (Оплата марками)</summary>
            public const string RegisteredNotificationOfReceiptInternal_PayMarks = "40";

            /// <summary> Электронное уведомление о вручении </summary>
            public const string EmailNotificationOfReceipt = "30";

            /// <summary> Простое уведомление о вручении 1 класс </summary>
            public const string SimpleNotificationOfReceiptFirstClass = "41";

            /// <summary> Заказное уведомление о вручении 1 класс </summary>
            public const string RegisteredNotificationOfReceiptFirstClass = "42";

            /// <summary>Доставка почтальоном по месту нахождения клиента</summary>
            public const string DeliveryByPostmanAtThePlaceOfLocationOfTheClient = "142";

            /// <summary>Составление описи вложения (ф. 107)</summary>
            public const string CreatingListOfAttachments = "09";

            /// <summary>
            /// Переадресация РПО в почтомат
            /// </summary>
            public const string RedirectToAPS = "89";

            public static class Attributes
            {
                public const string PostMark = "PostMark";

                /// <summary>
                /// Номенклатура
                /// </summary>
                public const string ItemId = "ItemId";

                /// <summary>
                /// Стоимость услуги
                /// </summary>
                public const string Stoimost = "Stoimost";
            }


            /// <summary>
            /// Доп услуги, связанные с отправкой СМС
            /// </summary>
            public static string[] SmsAddServices =
            {
                //  04
                SMSNotificationSenderOfReceipt,

                //  05
                SMSNotificationReceiptOfDelivery
            };
        }

        /// <summary>
        /// Виды дефектов в актах
        /// </summary>
        public static class ActDefects
        {
            /// <summary>
            /// ID справочника
            /// </summary>
            public const string ReferenceID = "ActDefects";

            /// <summary>
            /// Разница в весе
            /// </summary>
            public const string WeightDifference = "20";

            public static class Attributes
            {
                /// <summary>
                /// Дефект на РПО
                /// </summary>
                public const string _51d = "51d";
                /// <summary>
                /// Дефект на емкость
                /// </summary>
                public const string _51ve = "_51ve";
            }
        }

        /// <summary>
        /// Поля дефектов в актах
        /// </summary>
        public static class ActDefectFields
        {
            /// <summary>
            /// ID справочника
            /// </summary>
            public const string ReferenceID = "ActDefectFields";

            /// <summary>
            /// Вес фактический
            /// </summary>
            public const string ActualWeight = "01";

            /// <summary>
            /// Разрез оболочки значение
            /// </summary>
            public const string Cutting = "02";

            /// <summary>
            /// Иное текст
            /// </summary>
            public const string Other = "03";

            /// <summary>
            /// Скрытый дефект текст
            /// </summary>
            public const string HiddenDefect = "04";

            /// <summary>
            /// Фактический № ярлыка
            /// </summary>
            public const string ActualLabelNumber = "05";

            public static class Attributes
            {
                /// <summary>
                /// Дефект из ActDefects
                /// </summary>
                public const string ActDefects = "ActDefects";
                /// <summary>
                /// Порядковый номер вывода
                /// </summary>
                public const string LineNum = "LineNum";
            }
        }

        /// <summary>
        /// Виды дефектности
        /// </summary>
        public static class DefectKind
        {
            /// <summary>
            /// ID справочника
            /// </summary>
            public const string ReferenceID = "DispatchDefects";

            /// <summary>
            /// Расхождение по весу
            /// </summary>
            public const string WeightDifference = "01";
            /// <summary>
            /// Некорректное оформление
            /// </summary>
            public const string IncorrectClearance = "02";
            /// <summary>
            /// Повреждение упаковки
            /// </summary>
            public const string PackageDamage = "03";
            /// <summary>
            /// Повреждение пломб
            /// </summary>
            public const string SealsDamage = "04";
            /// <summary>
            /// Отсутствие вложения
            /// </summary>
            public const string AttachmentMissing = "05";
            /// <summary>
            /// Отсутствие сопроводительных документов
            /// </summary>
            public const string DocumentsMissing = "06";
            /// <summary>
            /// Поступление емкости без приписки к сопроводительным документам
            /// </summary>
            public const string ContainerWithoutSigning = "07";
            /// <summary>
            /// Поступление РПО без приписки
            /// </summary>
            public const string DispatchWithoutSigning = "08";
            /// <summary>
            /// Нарушен план направления
            /// </summary>
            public const string WrongDirectionPlan = "09";
            /// <summary>
            /// Нечитаемые ШПИ, ДШК
            /// </summary>
            public const string UnreadableBarcode = "10";
            /// <summary>
            /// Засыл РПО или емкости
            /// </summary>
            public const string ResendDispatchOrWaybill = "11";
            /// <summary>
            /// Непоступление РПО, приписанного к сопроводительным документам
            /// </summary>
            public const string DispatchNonArrival = "12";

            /// <summary>
            /// Атрибуты справочника "Виды дефектности"
            /// </summary>
            public class DefectKindAttributes
            {
                /// <summary>
                /// Вид документа Емкость
                /// </summary>
                public const string ActKindPackage = "ActKindPackage";
                /// <summary>
                /// Вид  документа РПО
                /// </summary>
                public const string ActKindRPO = "ActKindRPO";
                /// <summary>
                /// Код АСУ РПО
                /// </summary>
                public const string ASURPOCode = "ASURPOCode";
            }
        }

        /// <summary>
        /// Виды дефектности в актах
        /// </summary>
        public static class ActDefectKind
        {
            /// <summary>
            /// ID справочника
            /// </summary>
            public const string ReferenceID = "ActDefects";

            /// <summary>
            /// В подмоченном состоянии
            /// </summary>
            public const string Defect_01 = "01";

            /// <summary>
            /// В промасленном состоянии
            /// </summary>
            public const string Defect_02 = "02";

            /// <summary>
            /// Ёмкость поступила без накладной ф.16
            /// </summary>
            public const string Defect_03 = "03";

            /// <summary>
            /// Ёмкость поступила без накладной ф.23
            /// </summary>
            public const string Defect_04 = "04";

            /// <summary>
            /// Ёмкость поступила в дефектном состоянии при акте
            /// </summary>
            public const string Defect_05 = "05";

            /// <summary>
            /// Замена пломбы
            /// </summary>
            public const string Defect_06 = "06";

            /// <summary>
            /// Имеется дополнительное нанесение клеевой ленты
            /// </summary>
            public const string Defect_07 = "07";

            /// <summary>
            /// Имеется дополнительное нанесение ленты с другим логотипом
            /// </summary>
            public const string Defect_08 = "08";

            /// <summary>
            /// Имеется дополнительное нанесение прозрачной ленты
            /// </summary>
            public const string Defect_09 = "09";

            /// <summary>
            /// Имеется доступ к вложению
            /// </summary>
            public const string Defect_10 = "10";

            /// <summary>
            /// Иное
            /// </summary>
            public const string Defect_11 = "11";

            /// <summary>
            /// Нарушена клеевая лента с логотипом
            /// </summary>
            public const string Defect_12 = "12";

            /// <summary>
            /// Нарушена оболочка без доступа к вложению
            /// </summary>
            public const string Defect_13 = "13";

            /// <summary>
            /// Нарушена пломба
            /// </summary>
            public const string Defect_14 = "14";

            /// <summary>
            /// Нарушено запорное устройство
            /// </summary>
            public const string Defect_15 = "15";

            /// <summary>
            /// Отсутствует адресный ярлык
            /// </summary>
            public const string Defect_16 = "16";

            /// <summary>
            /// Отсутствует специальный шнур (кедера)
            /// </summary>
            public const string Defect_17 = "17";

            /// <summary>
            /// Пломба (печать) нарушена
            /// </summary>
            public const string Defect_18 = "18";

            /// <summary>
            /// Пломба отсутствует
            /// </summary>
            public const string Defect_19 = "19";

            /// <summary>
            /// Разница в весе
            /// </summary>
            public const string Defect_20 = "20";

            /// <summary>
            /// Разрыв (разрез) оболочки
            /// </summary>
            public const string Defect_21 = "21";

            /// <summary>
            /// Скрытый дефект емкости
            /// </summary>
            public const string Defect_22 = "22";

            /// <summary>
            /// Слабая затяжка пломбы
            /// </summary>
            public const string Defect_23 = "23";

            /// <summary>
            /// Некорректное оформление
            /// </summary>
            public const string Defect_24 = "24";

            /// <summary>
            /// Отсутствие сопроводительных документов
            /// </summary>
            public const string Defect_25 = "25";

            /// <summary>
            /// Нарушен план направлений
            /// </summary>
            public const string Defect_26 = "26";

            /// <summary>
            /// Нечитаемые ШПИ, ДШК
            /// </summary>
            public const string Defect_27 = "27";

            /// <summary>
            /// Засыл РПО или емкости
            /// </summary>
            public const string Defect_28 = "28";
        }


        public static class PostCellStatus
        {
            public const string ReferenceID = "PostCellStatus";

            /// <summary>Свободна</summary>
            public const string Free = "01";

            /// <summary>Оформляется</summary>
            public const string Processing = "02";

            /// <summary>Ожидает оплаты</summary>
            public const string ExpectPayment = "03";

            /// <summary>Ждет освобождения</summary>
            public const string WaitForRelease = "04";

            /// <summary>Занята</summary>
            public const string Busy = "05";

            /// <summary>Ремонт </summary>
            public const string Repair = "06";
        }

        public static class PostCellSize
        {
            public const string ReferenceID = "PostCellSize";
            public class PostCellSizeAttributes
            {
                /// <summary>цена аренды ячейки данного размера за месяц</summary>
                public const string PostCellPrice = "PostCellPrice";
            }
        }

        public static class DirectionCode
        {
            public const string ReferenceID = "DirectionCode";
            public class DirectionCodeAttributes
            {
                /// <summary>
                /// код способа пересылки
                /// </summary>
                public const string ContainerTransferMethod = "ContainerTransferMethod";
            }
        }

        public static class ContainerTransferMethod
        {
            public const string ReferenceID = "ContainerTransferMethod";

            /// <summary>Авиа</summary>
            public const string Avia = "01";

            /// <summary>Наземный</summary>
            public const string Land = "02";

            /// <summary>Ускоренный</summary>
            public const string Accelerated = "05";

            public class Attributes
            {
                /// <summary>
                /// Код для ДШК согласно РТМ 0025
                /// </summary>
                public const string RTM25Code = "RTM25Code";
            }
        }

        /// <summary>Операции с адресными электронными переводами</summary>
        public static class TransferAEOperType
        {
            public const string ReferenceID = "TAE_OperType";

            /// <summary>К оплате</summary>
            public const string ForPay = "01";

            /// <summary>К возврату</summary>
            public const string ForReturn = "02";

            /// <summary>Выплата получателю</summary>
            public const string PaymReceiver = "03";

            /// <summary>Принят</summary>
            public const string Received = "04";

            /// <summary>Актирован</summary>
            public const string Canceled = "05";

            /// <summary>Запрос состояния отправлен</summary>
            public const string StateRequestSent = "06";

            /// <summary>Запрос состояния получен</summary>
            public const string StateRequestReceived = "07";

            /// <summary>Запрос на возврат отправлен</summary>
            public const string RefundRequestSent = "08";

            /// <summary>Запрос на возврат получен</summary>
            public const string RefundRequestReceived = "09";

            /// <summary>Досыл</summary>
            public const string Dosyl = "10";

            /// <summary>Возврат отправителю</summary>
            public const string PaymSender= "11";

            /// <summary>Уведомление оплаты</summary>
            public const string PaymNotification= "12";

            /// <summary>Перевод в доставку</summary>
            public const string TransferDelivery = "13";

            /// <summary>Регистрация доставки</summary>
            public const string RegisterDelivery = "14";

            /// <summary>Переадресация</summary>
            public const string Forwarding = "15";

            /// <summary>Возврат на пункт приема</summary>
            public const string ReturnToReceivePoint = "16";

            /// <summary>Депонирование</summary>
            public const string Deposition = "17";
        }

        public static class CommonConstants
        {
            /// <summary>Константа обозначает значение типа оплаты марками в ini-файле для партионной почты</summary>
            public const string paytype_gzpo = "16";
        }

        /// <summary>
        /// Идентификаторы процессов
        /// </summary>
        //#warning В будущем желательно отказаться от использования констант-идентификаторов процессов
        
        public static class ProcessConstants
        {
            public const string MigrationNoticeProcessId = "RPКП000000005";

            public const string BatchTableDispatchValidationProcessId = "RPКП000000077";

            /// <summary>Редактирование накладной в форме сверки</summary>
            public const string WayBillCheckingEditWayBillProcessId = "RPКП000000019";

            /// <summary>Редактирование РПО в форме сверки</summary>
            public const string WayBillCheckingEditDispatchProcessId = "RPКП000000020";

            /// <summary>Регистрация уведомления о вручении</summary>
            public const string RegisterNotificationOfDeliveryProcessId = "RPКП000000089";

            /// <summary>Сверка операциями (сверка исходящих)</summary>
            public const string CompareWithOperationsProcessId = "RPКП000000138";

            /// <summary>Сверка без действий (сверка 16-с)</summary>
            public const string CompareWithoutActions = "RPКП000000137";            
            

            #region Подписка

            /// <summary> Создание подписки </summary>
            public const string CreateSubscriptionProcessId = "RPКП000000200";

            /// <summary> Продление подписки </summary>
            public const string ProlongateSubscriptionProcessId = "RPКП000000235";

            /// <summary> Переадресация подписки </summary>
            public const string RedirectSubscriptionProcessId = "RPКП000000242";

            /// <summary> Аннулирование подписки </summary>
            public const string AnnulSubscriptionProcessId = "RPКП000000243";

            /// <summary> Доплата по подписке </summary>
            public const string MakeAdditionalPaymentSubscriptionProcessId = "RPКП000000244";

            /// <summary> Партионная подписка </summary>
            public const string CreateBatchSubscriptionId = "RPКП000000593";

            #endregion
            
            /// <summary>Форма поиска ТМЦ в режиме поиска и добавления в корзину</summary>
            public const string SearchInventItemsForm_SearchMode = "SearchInventItems01";

            /// <summary>Форма поиска ТМЦ в режиме выбора номенклатур (выбор остатков)</summary>
            public const string SearchInventItemsForm_SelectRemainsMode = "SearchInventItems02";


            #region Настройка открытия форм F2APJournalInputDataForm

            /// <summary>F2APJournalForm  форма для создания</summary>
            public const string F2APJournalInputDataFormAdd = "F2APJrnlDataFrmAdd";

            /// <summary>F2APJournalForm форма для редактирования</summary>
            public const string F2APJournalInputDataFormEdit = "F2APJrnlDataFrmEdit";

            #endregion
        }

        /// <summary>Страны</summary>
        public static class Strana
        {
            public const string ReferenceID = "Strana";

            /// <summary>
            /// Россия RUS
            /// </summary>
            public const string Russia = "001";

            public class StranaAttributes
            {
                /// <summary>Цифровой ISO 3166-1</summary>
                public const string AlphaNum = "AlphaNum";

                /// <summary>Alpha-2 ISO 3166-1/// </summary>
                public const string Alpha2 = "Alpha2";

                /// <summary>Alpha-3 ISO 3166-1</summary>
                public const string Alpha3 = "Alpha3";

                // Наименование страны Кириллица
                public const string Strana = "Strana";

                public const string WUPOSName = "WUPOSName";
            }
        }

        /// <summary>
        /// Классификатор использования рабочего времени
        /// </summary>
        public static class VariablesLaborHoursUsingСlassifier
        {
            public const string ReferenceID = "VariablesLaborHoursUsingСlassifier";

            /// <summary>
            /// Продолжительность работы в дневное время
            /// </summary>
            public const string WorkedTime = "01";

            /// <summary>
            /// Продолжительность работы в выходные и нерабочие праздничные дни
            /// </summary>
            /// 
            public const string WeekendWork = "03";

            /// <summary>
            /// Продолжительность сверхурочной работы
            /// </summary>
            /// 
            public const string ExtraWork = "04";

            /// <summary>
            /// Выходные дни(еженедельный отпуск) и нерабочие праздничные дни
            /// </summary>
            public const string Weekend = "26";

            /// <summary>
            /// Продолжительность работы в ночное время
            /// </summary>
            public const string NightWork = "02";

            /// <summary>
            /// Прогулы(отсутствие на рабочем месте без уважительных причин в течение времени установленного законодательством)
            /// </summary>
            public const string Walks = "24";

            /// <summary>
            /// Ежегодный основной оплачиваемый отпуск
            /// </summary>
            public const string Vacation = "09";

            public class Attributes
            {
                /// <summary>Буквенный код</summary>
                public const string LetterCode = "LetterCode";

                /// <summary>Отметка о явке</summary>
                public const string AppearCode = "AppearCode";
            }
        }

        /// <summary>
        /// Наименования организаций (OVPO)
        /// </summary>
        public static class OVPO
        {
            public const string ReferenceID = "OVPO";
            public class Attributes
            {
                /// <summary>
                /// Название организации
                /// </summary>
                public const string OrgName = "OrgName";
                /// <summary>
                /// Номер OVPO
                /// </summary>
                public const string OVPOnum = "OVPO";
                /// <summary>
                /// Дата окончания
                /// </summary>
                public const string ValidTo = "EndDate";
            }
        }

        /// <summary>
        /// Суммарные статьи акта ф.130
        /// </summary>
        public static class F130ParentSetup
        {
            public const string ReferenceID = "F130ParentSetup";

            public class Attributes
            {
                /// <summary>
                /// Номер строки
                /// </summary>
                public const string LineID = "lineId";
            }
        }

        /// <summary>
        /// Конечные статьи акта ф.130
        /// </summary>
        public static class F130Setup
        {
            public const string ReferenceID = "F130Setup";

            public class Attributes
            {
                /// <summary>
                /// Формула суммы
                /// </summary>
                public const string FormulaAmount = "FormulaAmount";
                /// <summary>
                /// Формула количества
                /// </summary>
                public const string FormulaQty = "FormulaQty";
                /// <summary>
                /// Номер строки
                /// </summary>
                public const string LineID = "lineId";
                /// <summary>
                /// Тип оплаты
                /// </summary>
                public const string PayСode = "PayСode";
            }
        }

        /// <summary>
        /// Связи между конечными и суммарными статьями акта ф.130
        /// </summary>
        public static class F130CrossSetup
        {
            public const string ReferenceID = "F130CrossSetup";

            public class Attributes
            {
                /// <summary>
                /// Родительская суммарная статья
                /// </summary>
                public const string ParName = "ParName";
                /// <summary>
                /// Конечная статья
                /// </summary>
                public const string RecordNames = "RecordNames";
            }
        }

        /// <summary>
        /// Показатели 2а-п
        /// </summary>
        public static class F2APSetup
        {
            public const string ReferenceID = "F2APSetup";

            public class Attributes
            {
                /// <summary>
                /// Активно
                /// </summary>
                public const string IsActive = "isActive";
                /// <summary>
                /// Код статьи
                /// </summary>
                public const string ArticleId = "ArticleId";
                /// <summary>
                /// Уровень вложенности статьи
                /// </summary>
                public const string ArticleLvl = "ArticleLvl";
                /// <summary>
                /// Формула количество
                /// </summary>
                public const string FormulaQty = "FormulaQty";
                /// <summary>
                /// Формула вес
                /// </summary>
                public const string FormulaWeight = "FormulaWeight";
                /// <summary>
                /// Простая корреспонденция
                /// </summary>
                public const string OrdinaryMail = "OrdinaryMail";
                /// <summary>
                /// Заголовок
                /// </summary>
                public const string Title = "Title";
            }
        }

        /// <summary>
        /// Сопоставление дневника Ф130 с другими системами
        /// </summary>
        public static class Map130
        {
            public const string ReferenceID = "Map130";
            public class Attributes
            {
                /// <summary>
                /// Код сбсофт
                /// </summary>
                public const string KodId = "KodId";
            }

        }

        /// <summary>
        /// Справочник видов актов
        /// </summary>
        public static class ActKind
        {
            public const string ReferenceID = "ActKind";

            /// <summary>
            /// Акт ф.30
            /// </summary>
            public const string F30 = "01";

            /// <summary>
            /// Акт ф.51
            /// </summary>
            public const string F51 = "02";

            /// <summary>
            /// Акт ф.51д
            /// </summary>
            public const string F51D = "03";

            /// <summary>
            /// Акт ф.51-ве
            /// </summary>
            public const string F51Ve = "04";
        }

        public static class Ms42
        {
            public const string ReferenceID = "ms42";
            /// <summary>
            /// Внесение денег сумма
            /// </summary>
            public const string FundingOperationSum = "0001";
            /// <summary>
            /// Внсение денег количество операций
            /// </summary>
            public const string FundingOperationAmount = "0002";
            /// <summary>
            /// Сдача денег сумма
            /// </summary>
            public const string OddSum = "0003";
            /// <summary>
            /// Сдача денег количество операций
            /// </summary>
            public const string OddOperationsAmount = "0004";
            /// <summary>
            /// Актирование денег сумма
            /// </summary>
            public const string ActSum = "0005";
            /// <summary>
            /// Актирование денег количество операций
            /// </summary>
            public const string ActOparationsAmount = "0006";
            /// <summary>
            /// Подлежит сдаче сумма
            /// </summary>
            public const string ForDepositeSum = "0007";
            /// <summary>
            /// Подлежит сдаче количество операций
            /// </summary>
            public const string ForDepositeAmount = "0008";
            /// <summary>
            /// Возврат прихода сумма
            /// </summary>
            public const string ReturnIncomeSum = "0201";
            /// <summary>
            /// Возврат прихода количество
            /// </summary>
            public const string ReturnIncomeAmount = "0202";
            /// <summary>
            /// Возврат расхода сумма
            /// </summary>
            public const string ReturnExpenditureSum = "0203";
            /// <summary>
            /// Возврат расхода количество
            /// </summary>
            public const string ReturnExpenditureAmount = "0204";


            public class Attributes
            {
                /// <summary>
                /// Формула безналичные сумма
                /// </summary>
                public const string FormulaAmount = "FormulaAmount";
                /// <summary>
                /// Формула по банк.карте сумма
                /// </summary>
                public const string FormulaCardAmount = "FormulaCardAmount";
                /// <summary>
                /// Формула по банк.карте кол-во
                /// </summary>
                public const string FormulaCardQty = "FormulaCardQty";
                /// <summary>
                /// Формула наличные сумма
                /// </summary>
                public const string FormulaCashAmount = "FormulaCashAmount";
                /// <summary>
                /// Формула наличные кол-во
                /// </summary>
                public const string FormulaCashQty = "FormulaCashQty";
                /// <summary>
                /// Формула в счет аванса сумма
                /// </summary>
                public const string FormulaPrepayAmount = "FormulaPrepayAmount";
                /// <summary>
                /// Формула в счет аванса кол-во
                /// </summary>
                public const string FormulaPrepayQty = "FormulaPrepayQty";
                /// <summary>
                /// Формула безналичные кол-во
                /// </summary>
                public const string FormulaQty = "FormulaQty";
                /// <summary>
                /// Наименование операции
                /// </summary>
                public const string OperName = "OperName";
                /// <summary>
                /// Раздел МС-42
                /// </summary>
                public const string Section = "Section";
                /// <summary>
                /// Тип клиента
                /// </summary>
                public const string TypeClient = "TypeClient";
            }
        }

        public static class Ms42M
        {
            public const string ReferenceID = "ms42m";
            /// <summary>
            /// Внесение денег сумма
            /// </summary>
            public const string FundingOperationSum = "0001";
            /// <summary>
            /// Внсение денег количество операций
            /// </summary>
            public const string FundingOperationAmount = "0002";
            /// <summary>
            /// Сдача денег сумма
            /// </summary>
            public const string OddSum = "0003";
            /// <summary>
            /// Сдача денег количество операций
            /// </summary>
            public const string OddOperationsAmount = "0004";
            /// <summary>
            /// Актирование денег сумма
            /// </summary>
            public const string ActSum = "0005";
            /// <summary>
            /// Актирование денег количество операций
            /// </summary>
            public const string ActOparationsAmount = "0006";
            /// <summary>
            /// Подлежит сдаче сумма
            /// </summary>
            public const string ForDepositeSum = "0007";
            /// <summary>
            /// Подлежит сдаче количество операций
            /// </summary>
            public const string ForDepositeAmount = "0008";

            public class Attributes
            {
                /// <summary>
                /// Формула безналичные сумма
                /// </summary>
                public const string FormulaAmount = "FormulaAmount";
                /// <summary>
                /// Формула по банк.карте сумма
                /// </summary>
                public const string FormulaCardAmount = "FormulaCardAmount";
                /// <summary>
                /// Формула по банк.карте кол-во
                /// </summary>
                public const string FormulaCardQty = "FormulaCardQty";
                /// <summary>
                /// Формула наличные сумма
                /// </summary>
                public const string FormulaCashAmount = "FormulaCashAmount";
                /// <summary>
                /// Формула наличные кол-во
                /// </summary>
                public const string FormulaCashQty = "FormulaCashQty";
                /// <summary>
                /// Формула в счет аванса сумма
                /// </summary>
                public const string FormulaPrepayAmount = "FormulaPrepayAmount";
                /// <summary>
                /// Формула в счет аванса кол-во
                /// </summary>
                public const string FormulaPrepayQty = "FormulaPrepayQty";
                /// <summary>
                /// Формула безналичные кол-во
                /// </summary>
                public const string FormulaQty = "FormulaQty";
                /// <summary>
                /// Наименование операции
                /// </summary>
                public const string OperName = "OperName";
                /// <summary>
                /// Раздел МС-42
                /// </summary>
                public const string Section = "Section";
                /// <summary>
                /// Тип клиента
                /// </summary>
                public const string TypeClient = "TypeClient";
            }
        }

        public static class AnalyticsMS42
        {
            public const string ReferenceID = "AnalyticsMS42";
            /// <summary>
            /// Внесение денег сумма
            /// </summary>
            public const string FundingOperationSum = "0001";
            /// <summary>
            /// Внсение денег количество операций
            /// </summary>
            public const string FundingOperationAmount = "0002";
            /// <summary>
            /// Сдача денег сумма
            /// </summary>
            public const string OddSum = "0003";
            /// <summary>
            /// Сдача денег количество операций
            /// </summary>
            public const string OddOperationsAmount = "0004";
            /// <summary>
            /// Актирование денег сумма
            /// </summary>
            public const string ActSum = "0005";
            /// <summary>
            /// Актирование денег количество операций
            /// </summary>
            public const string ActOparationsAmount = "0006";
            /// <summary>
            /// Подлежит сдаче сумма
            /// </summary>
            public const string ForDepositeSum = "0007";
            /// <summary>
            /// Подлежит сдаче количество операций
            /// </summary>
            public const string ForDepositeAmount = "0008";
            /// <summary>
            /// Возврат прихода сумма
            /// </summary>
            public const string ReturnIncomeSum = "0201";
            /// <summary>
            /// Возврат прихода количество
            /// </summary>
            public const string ReturnIncomeAmount = "0202";
            /// <summary>
            /// Возврат расхода сумма
            /// </summary>
            public const string ReturnExpenditureSum = "0203";
            /// <summary>
            /// Возврат расхода количество
            /// </summary>
            public const string ReturnExpenditureAmount = "0204";

            public class Attributes
            {
                /// <summary>
                /// Формула безналичные сумма
                /// </summary>
                public const string FormulaAmount = "FormulaAmount";
                /// <summary>
                /// Формула по банк.карте сумма
                /// </summary>
                public const string FormulaCardAmount = "FormulaCardAmount";
                /// <summary>
                /// Формула по банк.карте кол-во
                /// </summary>
                public const string FormulaCardQty = "FormulaCardQty";
                /// <summary>
                /// Формула наличные сумма
                /// </summary>
                public const string FormulaCashAmount = "FormulaCashAmount";
                /// <summary>
                /// Формула наличные кол-во
                /// </summary>
                public const string FormulaCashQty = "FormulaCashQty";
                /// <summary>
                /// Формула в счет аванса сумма
                /// </summary>
                public const string FormulaPrepayAmount = "FormulaPrepayAmount";
                /// <summary>
                /// Формула в счет аванса кол-во
                /// </summary>
                public const string FormulaPrepayQty = "FormulaPrepayQty";
                /// <summary>
                /// Формула безналичные кол-во
                /// </summary>
                public const string FormulaQty = "FormulaQty";
                /// <summary>
                /// Наименование операции
                /// </summary>
                public const string OperName = "OperName";
                /// <summary>
                /// Раздел МС-42
                /// </summary>
                public const string Section = "Section";
                /// <summary>
                /// Тип клиента
                /// </summary>
                public const string TypeClient = "TypeClient";
            }
        }

        /// <summary>
        /// Справочник производственные операции 
        /// </summary>
        public static class ManOperType
        {
            public const string ReferenceID = "ManOperType";

            public class Attributes
            {
                /// <summary>
                /// Формула
                /// </summary>
                public const string Formula = "Formula";
                /// <summary>
                /// Единица измерения
                /// </summary>
                public const string Unit = "Unit";
            }

        }

        /// <summary>
        /// Типы журналов ТМЦ
        /// </summary>
        public static class InventTransType
        {
            public const string ReferenceId= "InventTransType";
            /// <summary>
            /// Накладная (заказ)
            /// </summary>
            public const string Order = "00";
            /// <summary>
            /// Приход
            /// </summary>
            public const string Parish = "01";
            /// <summary>
            /// Списание
            /// </summary>
            public const string WritingOff = "02";
            /// <summary>
            /// Перемещение
            /// </summary>
            public const string Transfer = "03";
            /// <summary>
            /// Инвентаризация
            /// </summary>
            public const string Inventory = "04";
            /// <summary>
            /// Инвентаризация ГЗПО
            /// </summary>
            public const string InventoryGzpo = "05";

        }

        /// <summary>
        /// Тарифы ОВПО
        /// </summary>
        public static class TarifOVPO
        {
            public const string ReferenceId = "TarifOVPO";

            public class TarifOVPOAttributes
            {
               
                public const string Xdo = "Xdo";

                public const string T0 = "T0";

                public const string T1 = "T1";

                public const string DispatchCategory = "DispatchCategory";

                public const string DispatchKind = "DispatchKind";
            }
        }

        /// <summary>
        /// Cтатусы операций по подписке
        /// </summary>
        public static class SubscriptionStatus
        {
            public const string ReferenceID = "SubscriptionStatus";

            /// <summary>
            /// Не проведён
            /// </summary>
            public const string NotPassed = "1";

            /// <summary>
            /// Оплачено
            /// </summary>
            public const string Paid = "2";

            /// <summary>
            /// Оплачено\Продлено
            /// </summary>
            public const string Prolongated = "3";

            /// <summary>
            /// Оплачено\Переадресован
            /// </summary>
            public const string Redirected = "4";

            /// <summary>
            /// Аннулировано
            /// </summary>
            public const string Annuled = "5";

            /// <summary>
            /// Доплата проведена
            /// </summary>
            public const string AdditionalPaymentMade = "8";
        }

        /// <summary>
        /// Типы периодических изданий
        /// </summary>
        public static class SubscriptionKindEdition
        {
            public const string ReferenceID = "SubscriptionKindEdition";

            /// <summary>
            /// Газета
            /// </summary>
            public const string Newspaper = "0";

            /// <summary>
            /// Журнал
            /// </summary>
            public const string Magazine = "2";
        }

        /// <summary>
        /// Виды оплаты
        /// </summary>
        public static class DispatchPayType
        {
            public const string ReferenceID = "DispatchPayType";

            /// <summary>
            /// Наличная/ Пластиковая карта
            /// </summary>
            public const string CashOrCard = "00";

            /// <summary>
            /// Наличная
            /// </summary>
            public const string Cash = "01";

            /// <summary>
            /// Безналичная
            /// </summary>
            public const string Noncash = "02";

            /// <summary>
            /// Пластиковая карта
            /// </summary>
            public const string Card = "04";

            /// <summary>
            /// Марки
            /// </summary>
            public const string Mark = "05";

            public class DispatchPayTypeAttributes
            {
                /// <summary>
                /// Код АСУ РПО
                /// </summary>
                public const string ASURPOCode = "ASURPOCode";
            }
        }

        /// <summary>
        /// справочник статусов БСО
        /// </summary>
        public static class SRFormStatus
        {
            public const string ReferenceID = "SRFormStatus";

            /// <summary>В наличии</summary>
            public const string Available = "01";

            /// <summary>Списано</summary>
            public const string WrittenOff = "02";

            /// <summary>Реализовано</summary>
            public const string Sold = "03";
        }

        /// <summary>
        /// Операции регистрации
        /// </summary>
        public static class RegistrationOperations
        {
            public const string ReferenceID = "PAP_RegistrationOperations";

            /// <summary>
            /// Выплата получателю почтальоном
            /// </summary>
            public const string PaymentToRecipient = "001";

            /// <summary>
            /// Выплата дов. лицу почтальоном
            /// </summary>
            public const string PaymentToTrustee = "002";

            /// <summary>
            /// Приостановка выплаты почтальоном
            /// </summary>
            public const string SuspensionPayment = "003";

            /// <summary>
            /// Передача в кассу ОПС
            /// </summary>
            public const string TransferToCashDepartment = "004";

            /// <summary>
            /// Выплата получателю на кассе
            /// </summary>
            public const string PaymentToRecipientOnCashDepartment = "005";

            /// <summary>
            /// Выплата дов. лицу на кассе
            /// </summary>
            public const string PaymentToTrusteeOnCashDepartment = "006";

            /// <summary>
            /// Приостановка выплаты на кассе
            /// </summary>
            public const string SuspensionPaymentOnCashDepartment = "007";

            /// <summary>
            /// Остаток на кассе
            /// </summary>
            public const string TheResidueOnCashDepartment = "008";

            /// <summary>
            /// Приостановка выплаты на кассе
            /// </summary>
            public const string TransferToPostmanOnCashDepartment = "009";

            /// <summary>
            /// Выплата пособия на погребение
            /// </summary>
            public const string PaymentOfFuneral = "010";

            /// <summary>
            /// Выплата почтальоном
            /// </summary>
            public const string PostmenPayment = "011";
        }

        /// <summary>
        /// Таблица взаимосвязи участков доставки и индексов ОПС
        /// </summary>
        public static class DeliveryDistrictsIndexes
        {
            public const string ReferenceID = "PAP_DeliveryDistrictsIndexes";

            public class DeliveryDistrictsIndexesAttributes
            {
                /// <summary>
                /// Участок доставки
                /// </summary>
                public const string DeliveryDistrictID = "DeliveryDistrictID";

                /// <summary>
                /// Индекс ОПС
                /// </summary>
                public const string IndexID = "IndexID";
            }
        }

        /// <summary>
        /// Таблица взаимосвязи участков доставки и индексов ОПС
        /// </summary>
        public static class DeliveryDistricts
        {
            public const string ReferenceID = "PAP_DeliveryDistricts";

            public class DeliveryDistrictsAttributes
            {
                /// <summary>
                /// Название района, к которому относится участок доставки
                /// </summary>
                public const string AreaName = "AreaName";

                /// <summary>
                /// Принадлежность участка к организации поручителю
                /// </summary>
                public const string BelongTo = "BelongTo";
            }
        }

        /// <summary>
        /// Справочник участков рассылки
        /// </summary>
        public static class DistributionDistricts
        {
            public const string ReferenceID = "PAP_DistributionDistricts";

            /// <summary>
            /// Участок рассылки ПФР «Пенсии и пособия на погребение»
            /// </summary>
            public const string PFR = "001";

            /// <summary>
            /// Участок рассылки СЗН «ЕДВ и ЕДК»
            /// </summary>
            public const string SZN = "002";

            public class DistributionDistrictsAttributes
            {
                /// <summary>
                /// Предназначение участка рассылки
                /// </summary>
                public const string Appropriation = "Appropriation";

                /// <summary>
                /// Принадлежность участка к организации поручителю
                /// </summary>
                public const string BelongTo = "BelongTo";

                /// <summary>
                /// Код профиля выгрузки
                /// </summary>
                public const string ExportProfileId = "ExportProfileId";
            }
        }
        /// <summary>
        /// Организации-поручители социальных выплат
        /// </summary>
        public static class PensionAndAllowancePayoutOrganizations
        {
            public const string ReferenceId = "PAP_PensionAndAllowancePayoutOrganizations";
            /// <summary>
            /// ТО ПФР РФ
            /// </summary>
            public const string PFR = "001";
            /// <summary>
            /// ТО СЗН
            /// </summary>
            public const string SZN = "002";
            /// <summary>
            /// ТО ПФР по Калужской области
            /// </summary>
            public const string PFRKalugaRegion = "003";
            /// <summary>
            /// ТО ПФР по Тульской области
            /// </summary>
            public const string PFRTylaRegion = "003";

            public class PensionAndAllowancePayoutOrganizationsAttributes
            {
                /// <summary>
                /// Полное название организации
                /// </summary>
                public const string FullCompanyName = "FullCompanyName";

                /// <summary>
                /// Тип организации
                /// </summary>
                public const string OrganizationTypeId = "OrganizationTypeId";

                /// <summary>
                /// Регион
                /// </summary>
                public const string RegionId = "RegionId";
            }


        }

        public static class DistributionDistrictsDocumentTypes
        {
            public const string ReferenceId = "PAP_DistributionDistrictsDocumentTypes";

            public class DistibutionDistrictDocumentTypesAttributes
            {
                /// <summary>
                /// Участок рассылки
                /// </summary>
                public const string DistributionDistrictID = "DistributionDistrictID";

                /// <summary>
                /// Тип выплатного документа
                /// </summary>
                public const string PayoutDocumentTypeID = "PayoutDocumentTypeID";
            }
        }

        /// <summary>
        /// Таблица взаимосвязи типов выплатных документов с участками доставки
        /// </summary>
        public static class PayoutDocumentTypesDeliveryDistricts
        {
            public const string ReferenceID = "PAP_PayoutDocumentTypesDeliveryDistricts";

            public class PayoutDocumentTypesDeliveryDistrictsAttributes
            {
                /// <summary>
                /// Тип выплатного документа
                /// </summary>
                public const string PayoutDocumentTypeID = "PayoutDocumentTypeID";

                /// <summary>
                /// Участок доставки
                /// </summary>
                public const string DeliveryDistrictID = "DeliveryDistrictID";
            }
        }

        public static class PayoutDocumentTypes
        {
            public const string ReferenceID = "PAP_PayoutDocumentTypes";

            public class PayoutDocumentTypesAttributes
            {
                /// <summary>
                /// Полное название типа
                /// </summary>
                public const string TypeFullName = "TypeFullName";

                /// <summary>
                /// Участок рассылки
                /// </summary>
                public const string DistributionDistrictID = "DistributionDistrictID";

                /// <summary>
                /// Не включать в отчеты
                /// </summary>
                public const string DoNotIncludeInReports = "DoNotIncludeInReports";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static class DocTypeCashFlow
        {
            public const string ReferenceID = "DocTypeCashFlow";

            /// <summary>
            /// Расписка о сдаче ДС
            /// </summary>
            public const string DepositCash = "1";

            /// <summary>
            /// Расписка в получении ДС
            /// </summary>
            public const string ReceiptCash = "2";

            /// <summary>
            /// Приём денежных средств в ОПС
            /// </summary>
            public const string ReceiptCashOPS = "3";

            /// <summary>
            /// Инкасация денежных средств из ОПС
            /// </summary>
            public const string CollectionCash = "4";

            /// <summary>
            /// Приходный кассовый ордер
            /// </summary>
            public const string SenderPKO = "6";

            /// <summary>
            /// Расходный кассовый ордер
            /// </summary>
            public const string ReciptRKO = "5";
        }

        /// <summary>
        /// 
        /// </summary>
        public static class AISSBPTransType
        {
            public const string ReferenceID = "AISSBPTransType";

            /// <summary>
            /// Прием перевода
            /// </summary>
            public const string CreateTransfer = "CreateTransfer";

            /// <summary>
            /// Выплата перевода
            /// </summary>
            public const string DispenceTransfer = "DispenceTransfer";

            /// <summary>
            /// Возврат перевода
            /// </summary>
            public const string RefundTransfer = "RefundTransfer";

            /// <summary>
            /// Возврат перевода с тарифом
            /// </summary>
            public const string RefundFullTransfer = "RefundFullTransfer";
        }

        public static class DefActBatchPost
        {
            public const string ReferenceId = "DefActBatchPost";

            /// <summary> Вес не соответствует виду РПО </summary>
            public const string WeightNotFitsKind = "06";

            /// <summary> Вес РПО не соответствует данным в списке </summary>
            public const string WeightNotFitsList = "05";
        }

	    /// <summary>
		/// Коды операций по банковским картам
	    /// </summary>
		public static class CardOpCodes
	    {
			public const string ReferenceID = "CardOpCodes";

			/// <summary>
			/// Продажа
			/// </summary>
			public const string Sale = "01";

			/// <summary>
			/// Снятие наличных
			/// </summary>
			public const string Withdrawals = "02";

			/// <summary>
			/// Зачисление наличных
			/// </summary>
			public const string Debit = "03";

			/// <summary>
			/// Запрос баланса
			/// </summary>
			public const string Balance = "04";

			public class CardOpCodesAttributes
			{
				/// <summary>
				/// Код операции по SA
				/// </summary>
				public const string OperationCodeSA = "OperationCodeSA";
			}
	    }

        /// <summary>
        /// Доп услуги для адресных электронных переводов
        /// </summary>
        public static class TransferAEAddService
        {
            public const string ReferenceID = "TAE_AddService";

            /// <summary>
            /// Доставка почтальоном
            /// </summary>
            public const string PostmanDelivery = "01";

            /// <summary>
            /// Уведомление
            /// </summary>
            public const string Notification = "02";

            /// <summary>
            /// SMS о выплате перевода
            /// </summary>
            public const string SMSOnPaymentTransfer = "03";

            /// <summary>
            /// SMS о возможности выплаты перевода
            /// </summary>
            public const string SMSOnPaymentTransferePossibility = "04";
        }

        public static class TransferAEDestType
        {
            public const string ReferenceId = "TAE_DestType";

            /// <summary>
            /// Внутренний
            /// </summary>
            public const string Inner = "01";

            /// <summary>
            /// Международный
            /// </summary>
            public const string Global = "02";

        }

        public static class TransferAEDestKind
        {
            public const string ReferenceId = "TAE_DestKind";

            /// <summary>
            /// На адрес получателя
            /// </summary>
            public const string ToTheReceiver = "01";

            /// <summary>
            /// На абонентский ящик
            /// </summary>
            public const string ToThePostOfficeBox = "02";

            /// <summary>
            /// На расчетный счет
            /// </summary>
            public const string ToTheAccount = "05";
        }

        public static class TransferAESign
        {
            public const string ReferenceId = "TAE_Sign";

            /// <summary>
            /// Простой 
            /// </summary>
            public const string Simple = "01";

            /// <summary>
            /// Наложенный платеж
            /// </summary>
            public const string CashOnDelivery = "02";
        }

        public static class TransferAESenderType
        {
            public const string ReferenceId = "TAE_SenderType";

            /// <summary>
            /// Физическое лицо
            /// </summary>
            public const string Individual = "01";

            /// <summary>
            /// Юридическое лицо (Локальный клиент)
            /// </summary>
            public const string LegalLocal = "02";

            /// <summary>
            /// Юридическое лицо (Региональный клиент)
            /// </summary>
            public const string LegalRegional = "03";

            /// <summary>
            /// Юридическое лицо (Федеральный клиент)
            /// </summary>
            public const string LegalFederal = "04";
        }

        public static class TransferAePaymentMethod
        {
            public const string ReferenceId = "TAE_PaymMethod";

            /// <summary>
            /// Наличный
            /// </summary>
            public const string Cash = "01";

            /// <summary>
            /// Безналичный
            /// </summary>
            public const string Cashless = "02";
        }

        public static class TransferAEReceiverType
        {
            public const string ReferenceId = "TAE_ReceiverType";

            /// <summary>
            /// Физическое лицо
            /// </summary>
            public const string Individual = "01";

            /// <summary>
            /// Юридическое лицо (Локальный клиент)
            /// </summary>
            public const string LegalLocal = "03";

            /// <summary>
            /// Юридическое лицо (Региональный клиент)
            /// </summary>
            public const string LegalRegional = "05";

            /// <summary>
            /// Юридическое лицо (Федеральный клиент)
            /// </summary>
            public const string LegalFederal = "04";
        }

        public static class TransferAeReceiverPaymMethod
        {
            public const string ReferenceId = "TAE_ReceiverPaymMethod";

            /// <summary>
            /// Наличный
            /// </summary>
            public const string Cash = "01";

            /// <summary>
            /// Наличные с доставкой на адрес
            /// </summary>
            public const string CashAddress = "04";

            /// <summary>
            /// Безнал отметка из файла DBF
            /// </summary>
            public const string CashlessDBF = "02";

            /// <summary>
            /// Безнал отметка вручную
            /// </summary>
            public const string CashlessManual = "03";

            /// <summary>
            /// Оплата с посылкой бланков на подч. П/О ЗПБТ
            /// </summary>
            public const string Blank = "05";
        }

        public static class AISSBPType
        {
            public const string ReferenceId = "AISSBPType";

            /// <summary>
            /// Внутренний перевод
            /// </summary>
            public const string LocalTransfer = "LocalTransfer";

            /// <summary>
            /// Внутренний перевод АРФУ
            /// </summary>
            public const string LocalTransferARFU = "LocalTransferARFU";

            /// <summary>
            /// Международный перевод QSG (зарезервировано)
            /// </summary>
            public const string QSG = "QSG";

            /// <summary>
            /// Международный перевод STEFI (зарезервировано)
            /// </summary>
            public const string STEFI = "STEFI";
        }

        public static class AISSBPStatus
        {
            public const string ReferenceId = "AISSBPStatus";

            /// <summary>
            /// Принят
            /// </summary>
            public const string RECEIVED = "RECEIVED";

            /// <summary>
            /// Выплачен
            /// </summary>
            public const string PAID = "PAID";

            /// <summary>
            /// Возвращен
            /// </summary>
            public const string PAID_SNDR = "PAID_SNDR";

            /// <summary>
            /// Возвращен с тарифом
            /// </summary>
            public const string PAID_SNDR_FULL = "PAID_SNDR_FULL";

            /// <summary>
            /// Зарегистрирован
            /// </summary>
            public const string REGISTERED = "REGISTERED";

            /// <summary>
            /// Актирован
            /// </summary>
            public const string ACTRETURN = "ACTRETURN";
        }

        public static class AISSBPService
        {
            public const string ReferenceId = "AISSBPService";

            /// <summary>
            /// Сумма комиссии за перевод
            /// </summary>
            public const string PaymentSum = "50PaymentSum";
        }

        public static class SBPTransferPaymentStatus
        {
            public const string COMMITFAILURE = "COMMITFAILURE";
        }

        /// <summary>
        /// Статус сеансов работы почтальона
        /// </summary>
        public static class PAP_Status
        {
            public const string ReferenceId = "PAP_Status";

            /// <summary>
            /// Открыт
            /// </summary>
            public const string Opened = "01";

            /// <summary>
            /// Закрыт
            /// </summary>
            public const string Closed = "02";
        }

        /// <summary>
        /// Бюджетная статья
        /// </summary>
        public static class BudgetArticle
        {

            public const string ReferenceId = "BudgetArticle";

            public class BudgetArticleAttributes
            {
                /// <summary>
                /// Статья по-умолчанию
                /// </summary>
                public const string IsDefaultArticle = "IsDefaultArticle";
            }
        }

        public static class CashManualTransStatus
        {
            public const string ReferenceId = "CashManualTransStatus";

            public const string Created = "001";
            public const string Posted = "002";
        }

        public static class CashManualTransDirection
        {
            public const string ReferenceId = "CashManualTransDirection";
            /// <summary>
            /// Приход
            /// </summary>
            public const string Income = "001";
            /// <summary>
            /// Расход
            /// </summary>
            public const string Outgo = "002";
        }

        /// <summary>Тип идентификационной карты</summary>
        public static class IdentityCardType
        {
            public const string ReferenceID = "IdentityCardType";

            public class IdentityCardTypeAttributes
            {
                public const string WUPOSCode = "WUPOSCode";
            }
        }

        public static class DispatchDeliveryJIRAFieldMap
        {
            public const string ReferenceID = "DispatchDeliveryJIRAFieldMap";

            public const string Barcode = "Barcode";

            public const string DispatchDeliveryType = "DispatchDeliveryType";

            public class Attributes
            {
                public const string JIRANum = "JIRANum";
            }
        }

        /// <summary>
        /// Формулы расчетов для РПО 
        /// </summary>
        public static class DispatchFormulas
        {
            public const string ReferenceID = "DispatchFormulas";

            public class Attributes
            {
                /// <summary>
                /// Формула расчета стоимости услуги переадресации в АПС
                /// </summary>
                public const string FormulaRedirectCost = "FormulaRedirectCost";
                /// <summary>
                /// Формула расчета процента налога на услугу переадресации в АПС
                /// </summary>
                public const string FormulaRedirectTax = "FormulaRedirectTax";
            }
        }

        /// <summary>
        /// Размер ячейки АПС
        /// </summary>
        public static class APSCellSize
        {
            public const string ReferenceID = "APSCellSize";

            public class Attributes
            {
                public const string APSSizeId = "APSSizeId";
                public const string Length = "Length";
                public const string Width = "Width";
                public const string Height = "Height";
            }
        }

        /// <summary>
        /// Ячейки АПС
        /// </summary>
        public static class APSCell
        {
            public const string ReferenceID = "APSCells";

            public class Attributes
            {
                public const string APSCellSize = "APSCellSize";
                public const string StoreId = "StoreId";
            }
        }

        /// <summary>
        /// Тип заказа РПО
        /// </summary>
        public static class OrderType
        {
            public const string ReferenceID = "OrderType";

            /// <summary>
            /// Прием
            /// </summary>
            public const string Receiving = "01";

            /// <summary>
            /// Выдача
            /// </summary>
            public const string Delivery = "02";
        }


        /// <summary>
        /// Статус заказа РПО
        /// </summary>
        public static class OrderStatus
        {
            public const string ReferenceID = "OrderStatus";

            /// <summary>
            /// Создан
            /// </summary>
            public const string Created = "01";

            /// <summary>
            /// Принят
            /// </summary>
            public const string Received = "02";

            /// <summary>
            /// Отменен
            /// </summary>
            public const string Canceled = "03";

            /// <summary>
            /// Собирается
            /// </summary>
            public const string Assembling = "04";

            /// <summary>
            /// Передан на окно
            /// </summary>
            public const string TransferredToTerminal = "05";

            /// <summary>
            /// Выдан
            /// </summary>
            public const string Issued = "06";
        }

        /// <summary>
        /// Статус строки заказа РПО
        /// </summary>
        public static class OrderLineStatus
        {
            public const string ReferenceID = "OrderLineStatus";

            /// <summary>
            /// Принята
            /// </summary>
            public const string Received = "01";

            /// <summary>
            /// Оплачена
            /// </summary>
            public const string Paid = "02";

            /// <summary>
            /// Проверена
            /// </summary>
            public const string Checked = "03";

            /// <summary>
            /// Готова к выдаче
            /// </summary>
            public const string ReadyToIssue = "04";

            /// <summary>
            /// Не найдена
            /// </summary>
            public const string NotFound = "05";

            /// <summary>
            /// Оплачена и проверена
            /// </summary>
            public const string PaidAndVerified = "06";

            /// <summary>
            /// Возвращена
            /// </summary>
            public const string Returned = "07";
        }

        /// <summary>
        /// Статус корзины
        /// </summary>
        public static class CartStatus
        {
            public const string ReferenceID = "CartStatus";

        }

        /// <summary>
        /// Статус оплаты
        /// </summary>
        public static class PayStatus
        {
            public const string ReferenceID = "PayStatus";

            /// <summary>
            /// Оплатить на терминале
            /// </summary>
            public const string PayAtTheTerminal = "01";
        }

        public static class DispatchCustomNotice
        {
            public const string ReferenceID = "DispatchCustomNotice";

            /// <summary> Отсутствует </summary>
            public const string Missing = "1";

            /// <summary> Направлено с таможенным уведомлением </summary>
            public const string SentWithCustomsNotification = "2";

            /// <summary> Направлено с обязательной уплатой таможенных платежей </summary>
            public const string SentWithTheObligatoryPaymentOfCustomsDuties = "3";
        }

        public static class DispatchTransferAviaAlt
        {
            public const string ReferenceID = "DispatchTransferAviaAlt";

            /// <summary> Направить наземным транспортом </summary>
            public const string SendBySurfaceTransport = "01";

            /// <summary> Вернуть по обратному адресу </summary>
            public const string ReturnToTheReturnAddress = "02";
        }

        /// <summary>
        /// Маппинг номенклатуры с операциями почтоматов
        /// </summary>
        public static class APSInventItemMapping
        {
            public const string ReferenceID = "APSInventItemMapping";

            public class Attributes
            {
                /// <summary>
                /// Код номенклатуры
                /// </summary>
                public const string ItemId = "ItemId";
            }
        }


        public static class AddServiceType
        {
            public const string ReferenceID = "AddServiceType";

            /// <summary>
            /// Возврат адресного электронного перевода
            /// </summary>
            public const string ReturnElectronicTransfer = "01";

            /// <summary>
            /// Доставка адресного электронного перевода по заявке
            /// </summary>
            public const string ShippingElectronicTransfer = "02";
        }

        /// <summary>
        /// Справочник категорий отправителей
        /// </summary>
        public static class DispatchSentCategory
        {
            public const string ReferenceID = "DispatchSendCategory";

            public class DispatchSentCategoryAttributes
            {
                /// <summary>
                /// ASURPOCode
                /// </summary>
                public const string ASURPOCode = "ASURPOCode";
            }
        }

        /// <summary>
        /// Справочник видов вложений емкости
        /// </summary>
        public static class AttachmentKind
        {
            public const string ReferenceID = "AttachmentKind";

            /// <summary>
            /// Письменная корреспонденция
            /// </summary>
            public const string WrittenCorrespondence = "01";

            /// <summary>
            /// Порожняя тара
            /// </summary>
            public const string Empty = "02";

            /// <summary>
            /// 1-ый класс
            /// </summary>
            public const string FirstClass = "03";

            /// <summary>
            /// Страховая
            /// </summary>
            public const string Insurance = "04";

            /// <summary>
            /// EMS
            /// </summary>
            public const string EMS = "05";

            public class Attributes
            {
                /// <summary>
                /// Код для ДШК согласно РТМ 0025
                /// </summary>
                public const string RTM25Code = "RTM25Code";
            }
        }

        /// <summary>
        /// Справочник свойств тары
        /// </summary>
        public static class TareAttribute
        {
            public const string ReferenceID = "TareAttribute";

            /// <summary>
            /// Большой (КПС-5)
            /// </summary>
            public const string Large = "1";

            /// <summary>
            /// Малый (КПС-6)
            /// </summary>
            public const string Small = "2";

            /// <summary>
            /// Брезентовый
            /// </summary>
            public const string Canvas = "3";

            /// <summary>
            /// Флэт
            /// </summary>
            public const string Flat = "4";

            /// <summary>
            /// Стандартный
            /// </summary>
            public const string Standart = "5";

            /// <summary>
            /// Пластиковый
            /// </summary>
            public const string Plastic = "6";

            /// <summary>
            /// Авиа
            /// </summary>
            public const string Avia = "7";

            public class Attributes
            {
                /// <summary>
                /// Код для ДШК согласно РТМ 0025
                /// </summary>
                public const string RTM25Code = "RTM25Code";
            }
        }

        /// <summary>
        /// Комплект накладных для отправки емкостей
        /// </summary>
        public static class WaybillSet
        {
            public const string ReferenceID = "WaybillSet";

            /// <summary> Накладная ф. 23А и накладные ф. 23 </summary>
            public const string F23_F23A = "01";

            /// <summary> Накладные ф. 23 </summary>
            public const string F23 = "02";

            /// <summary> Накладная ф. 16В, накладные ф. 16б и накладные ф. 16а </summary>
            public const string F16V_F16B_F16A = "03";

            /// <summary> Накладная ф. 16Б и накладные ф. 16а </summary>
            public const string F16B_F16A = "04";
        }

        public static class DispatchMovementReportLineType
        {
            public const string ReferenceID = "DispatchMovementReportLineType";

            public class Attributes
            {
                /// <summary>Для входящих РПО</summary>
                public const string IsIngoing = "IsIngoing";

                /// <summary>Группа</summary>
                public const string Group = "Group";

                /// <summary>Порядок вывода в группе</summary>
                public const string Order = "Order";
            }
        }
        /// <summary>
        /// Тип получателя.
        /// </summary>
        public static class SubjectOfLaw_LA
        {
            /// <summary>
            /// Физическое лицо.
            /// </summary>
            public const int Individual = 0;

            /// <summary>
            /// Юридическое лицо.
            /// </summary>
            public const int Legal = 1;
        }

        /// <summary>
        /// Ранг РПО.
        /// </summary>
        public static class RankRPO_LA
        {
            /// <summary>
            /// Без разряда.
            /// </summary>
            public const string WithoutCategory = "00";

            /// <summary>
            /// Правительственное.
            /// </summary>
            public const string Government = "01";

            /// <summary>
            /// Воинское.
            /// </summary>
            public const string Military = "02";

            /// <summary>
            /// Служебное.
            /// </summary>
            public const string Service = "03";

            /// <summary>
            /// Судебное.
            /// </summary>
            public const string Judicial = "04";

            /// <summary>
            /// Президентское.
            /// </summary>
            public const string Presidential = "05";

            /// <summary>
            /// Кредитное.
            /// </summary>
            public const string Credit = "06";
        }

        /// <summary>
        /// справочник Категорий отправлений
        /// </summary>
        public static class CustomsMark_LA
        {
            public const string ReferenceID = "CustomsMark_LA";

            /// <summary>
            /// Подарок
            /// </summary>
            public const string Gift = "01";
            /// <summary>
            /// Документ
            /// </summary>
            public const string Document = "02";
            /// <summary>
            /// Коммерческий образец
            /// </summary>
            public const string CommercialSample = "03";
            /// <summary>
            /// Возврат товара
            /// </summary>
            public const string PurchaseReturns = "04";
            /// <summary>
            ///Прочее
            /// </summary>
            public const string Other = "05";

            /// <summary>
            /// ASURPOCode
            /// </summary>
            public class PostMarkAttributes
            {
                /// <summary>
                /// ISKPCode
                /// </summary>
                public const string ISKPCode = "ISKPCode";


            }
        }
        
        public static class SenderPrecept_LA
        {
            /// <summary>
            /// Возвратить сразу же отправителю
            /// </summary>
            public const string ReturnToRecepientNow = "1";
            /// <summary>
            /// Обработать отказ
            /// </summary>
            public const string ProcessFailure = "2";
            /// <summary>
            /// Возвратить отправителю по истечении указанного кол-ва дней
            /// </summary>
            public const string ReturnToRecepientOnDays = "3";
            /// <summary>
            /// Дослать по адресу
            /// </summary>
            public const string ReSendOnAddress = "4";

        }

        public static class SenderPreceptDelivery_LA
        {
            /// <summary>
            /// Наземный путь
            /// </summary>
            public const string LandTransport = "01";
            /// <summary>
            /// Авиа
            /// </summary>
            public const string AviaTransport = "02";
        }

        public static class AccountingAttribute
        {
            public const string ReferenceID = "AccountingAttribute";

            public class Attributes
            {
                public const string Value = "Value";
            }
        }
    }
}