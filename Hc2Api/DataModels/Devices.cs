using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Hc2Api.DataModels
{

    [DataContract]
    public class Device
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "roomID")]
        public int RoomId { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "properties")]
        public Property[] Properties { get; set; }

        [DataMember(Name = "actions")]
        public Action[] Actions { get; set; }

        [DataMember(Name = "created")]
        public string Created { get; set; }

        [DataMember(Name = "modified")]
        public string Modified { get; set; }

        [DataMember(Name = "sortOrder")]
        public string SortOrder { get; set; }
    }

    [DataContract]
    public class Property
    {
        #region unknown_device
        [DataMember(Name = "UIMessageSendTime")]
        public string UIMessageSendTime { get; set; }

        [DataMember(Name = "autoConfig")]
        public string AutoConfig { get; set; }

        [DataMember(Name = "date")]
        public string Date { get; set; }

        [DataMember(Name = "dead")]
        public string Dead { get; set; }
        
        [DataMember(Name = "disabled")]
        public string Disabled { get; set; }

        [DataMember(Name = "endPoint")]
        public string Endpoint { get; set; }

        [DataMember(Name = "log")]
        public string Log { get; set; }

        [DataMember(Name = "logTemp")]
        public string LogTemp { get; set; }

        [DataMember(Name = "nodeID")]
        public string NodeId { get; set; }

        [DataMember(Name = "pollingDeadDevice")]
        public string PollingDeadDevice { get; set; }

        [DataMember(Name = "pollingTime")]
        public string PollingTime { get; set; }

        [DataMember(Name = "pollingTimeNext")]
        public string PollingTimeNext { get; set; }

        [DataMember(Name = "pollingTimeSec")]
        public string PollingTimeSec { get; set; }

        [DataMember(Name = "productInfo")]
        public string ProductInfo { get; set; }

        [DataMember(Name = "pushNotificationID")]
        public string PushNotificationId { get; set; }

        [DataMember(Name = "requestNodeNeighborStat")]
        public string RequestNodeNeighborStat { get; set; }

        [DataMember(Name = "requestNodeNeighborStatTimeStemp")]
        public string RequestNodeNeighborStatTimeStamp { get; set; }

        [DataMember(Name = "requestNodeNeighborState")]
        public string RequestNodeNeighborState { get; set; }

        [DataMember(Name = "requestNodeNeighborStateTimeStemp")]
        public string RequestNodeNeighborStateTimeStemp { get; set; }

        [DataMember(Name = "saveLogs")]
        public string SaveLogs { get; set; }

        [DataMember(Name = "showChildren")]
        public string ShowChildren { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "sunriseHour")]
        public string SunriseHour { get; set; }

        [DataMember(Name = "sunsetHour")]
        public string SunsetHour { get; set; }

        [DataMember(Name = "value")]
        public string Value { get; set; }

        [DataMember(Name = "zwaveCompany")]
        public string ZWaveCompany { get; set; }

        [DataMember(Name = "zwaveInfo")]
        public string ZWaveInfo { get; set; }

        [DataMember(Name = "zwaveVersion")]
        public string ZWaveVersion { get; set; }
        #endregion unknown_device
        #region HC_user
        [DataMember(Name = "Email")]
        public string Email { get; set; }

        [DataMember(Name = "HotelModeRoom")]
        public string HotelModeRoom { get; set; }

        [DataMember(Name = "Latitude")]
        public string Latitude{ get; set; }

        [DataMember(Name = "Location")]
        public string Location { get; set; }

        [DataMember(Name = "LocationTime")]
        public string LocationTime { get; set; }

        [DataMember(Name = "LocationTimestamp")]
        public string LocationTimeStamp { get; set; }

        [DataMember(Name = "Longitude")]
        public string Longitude { get; set; }

        [DataMember(Name = "PreviousLatitude")]
        public string PreviousLatitude { get; set; }

        [DataMember(Name = "PreviousLocation")]
        public string PreviousLocation{ get; set; }

        [DataMember(Name = "PreviousLocationTime")]
        public string PreviousLocationTime { get; set; }

        [DataMember(Name = "PreviousLocationTimestamp")]
        public string PreviousLocationTimeStamp { get; set; }

        [DataMember(Name = "PreviousLongitude")]
        public string PreviousLongitude { get; set; }

        [DataMember(Name = "SendNotifications")]
        public string SendNotification { get; set; }

        [DataMember(Name = "TrackUser")]
        public string TrackUser { get; set; }

        [DataMember(Name = "UserType")]
        public string UserType { get; set; }

        // Already exists above
        //[DataMember(Name = "saveLogs")]
        //public string SaveLogs { get; set; }

        [DataMember(Name = "sipDisplayName")]
        public string SipDisplayName{ get; set; }

        [DataMember(Name = "sipUserID")]
        public string SipUserID { get; set; }

        [DataMember(Name = "sipUserPassword")]
        public string SipUserPassword { get; set; }

        [DataMember(Name = "useOptionalArmPin")]
        public string UseOptionalArmPin { get; set; }

        [DataMember(Name = "usePin")]
        public string UsePin { get; set; }

        #endregion HC_user
        #region weather
        [DataMember(Name = "ConditionCode")]
        public string ConditionCode { get; set; }
        [DataMember(Name = "Humidity")]
        public string Humidity { get; set; }
        [DataMember(Name = "PreviousConditionCode")]
        public string PreviousConditionCode { get; set; }
        [DataMember(Name = "PreviousHumidity")]
        public string PreviousHumidity { get; set; }
        [DataMember(Name = "PreviousTemperature")]
        public string PreviousTemperature { get; set; }
        [DataMember(Name = "PreviousWeatherConditionConverted")]
        public string PreviousWeatherConditionConverted { get; set; }
        [DataMember(Name = "PreviousWind")]
        public string PreviousWind { get; set; }
        [DataMember(Name = "Temperature")]
        public string Temperature { get; set; }
        [DataMember(Name = "WeatherCondition")]
        public string WeatherCondition { get; set; }
        [DataMember(Name = "WeatherConditionConverted")]
        public string WeatherConditionConverted { get; set; }
        [DataMember(Name = "Wind")]
        public string Wind { get; set; }
        // Already defined
        //[DataMember(Name = "saveLogs")]
        //public string SaveLogs { get; set; }
        #endregion weather
        #region dimmable_light
        //[DataMember(Name = "UIMessageSendTime")]
        //public string UIMessageSendTime { get; set; }
        [DataMember(Name = "classConfigure")]
        public string ClassConfigure { get; set; }
        [DataMember(Name = "classGeneric")]
        public string ClassGeneric { get; set; }
        [DataMember(Name = "classSupport")]
        public string ClassSupport { get; set; }
        [DataMember(Name = "classVersion")]
        public string ClassVersion { get; set; }
        //[DataMember(Name = "dead")]
        //public string Dead { get; set; }
        [DataMember(Name = "deviceControlType")]
        public string DeviceControlType { get; set; }
        [DataMember(Name = "deviceIcon")]
        public string DeviceIcon { get; set; }
        //[DataMember(Name = "disabled")]
        //public string Disabled { get; set; }
        [DataMember(Name = "emailNotificationID")]
        public string EmailNotificationId { get; set; }
        [DataMember(Name = "emailNotificationType")]
        public string EmailNotificationType { get; set; }
        //[DataMember(Name = "endPoint")]
        //public string Endpoint { get; set; }
        [DataMember(Name = "isBatteryOperated")]
        public string IsBatteryOperated { get; set; }
        [DataMember(Name = "isLight")]
        public string IsLight { get; set; }
        [DataMember(Name = "liliOffCommand")]
        public string LiliOffCommand { get; set; }
        [DataMember(Name = "liliOnCommand")]
        public string LiliOnCommand { get; set; }
        //[DataMember(Name = "log")]
        //public string Log { get; set; }
        //[DataMember(Name = "logTemp")]
        //public string LogTemp { get; set; }
        [DataMember(Name = "needConfigure")]
        public string NeedConfigure { get; set; }
        //[DataMember(Name = "nodeID")]
        //public string NodeId { get; set; }
        [DataMember(Name = "parametersTemplate")]
        public string ParametersTemplate { get; set; }
        [DataMember(Name = "parentID")]
        public string ParentId { get; set; }
        [DataMember(Name = "pollingRetryError")]
        public string PollingRetryError { get; set; }
        //[DataMember(Name = "pollingTime")]
        //public string PollingTime { get; set; }
        //[DataMember(Name = "pollingTimeNext")]
        //public string PollingTimeNext { get; set; }
        //[DataMember(Name = "pollingTimeSec")]
        //public string PollingTimeSec { get; set; }
        [DataMember(Name = "powerConsumption")]
        public string PowerConsumption { get; set; }
        //[DataMember(Name = "productInfo")]
        //public string ProductInfo { get; set; }
        //[DataMember(Name = "pushNotificationID")]
        //public string PushNotificationId { get; set; }
        [DataMember(Name = "pushNotificationType")]
        public string PushNotificationType { get; set; }
        //[DataMember(Name = "requestNodeNeighborState")]
        //public string RequestNodeNeighborState { get; set; }
        //[DataMember(Name = "requestNodeNeighborStateTimeStemp")]
        //public string RequestNodeNeighborStateTimeStemp { get; set; }
        //[DataMember(Name = "saveLogs")]
        //public string SaveLogs { get; set; }
        [DataMember(Name = "sceneActivation")]
        public string SceneActivation { get; set; }
        [DataMember(Name = "sceneDimingDuration")]
        public string SceneDimingDuration { get; set; }
        //[DataMember(Name = "showChildren")]
        //public string ShowChildren { get; set; }
        [DataMember(Name = "showEnergy")]
        public string ShowEnergy { get; set; }
        [DataMember(Name = "smsNotificationID")]
        public string SmsNotificationId { get; set; }
        [DataMember(Name = "smsNotificationType")]
        public string SmsNotificationType { get; set; }
        [DataMember(Name = "sortOrder")]
        public string SortOrder { get; set; }
        [DataMember(Name = "unit")]
        public string Unit { get; set; }
        [DataMember(Name = "unitSensor")]
        public string UnitSensor { get; set; }
        [DataMember(Name = "useTemplate")]
        public string UseTemplate { get; set; }
        [DataMember(Name = "userDescription")]
        public string UserDescription { get; set; }
        //[DataMember(Name = "value")]
        //public string Value { get; set; }
        [DataMember(Name = "valueSensor")]
        public string ValueSensor { get; set; }
        //[DataMember(Name = "zwaveCompany")]
        //public string ZWaveCompany { get; set; }
        //[DataMember(Name = "zwaveInfo")]
        //public string ZWaveInfo { get; set; }
        //[DataMember(Name = "zwaveVersion")]
        //public string ZWaveVersion { get; set; }
        #endregion dimmable_light
        #region binary_light
        //[DataMember(Name="UIMessageSendTime")]
        //[DataMember(Name="classConfigure")]
        //[DataMember(Name="classGeneric")]
        //[DataMember(Name="classSupport")]
        //[DataMember(Name="classVersion")]
        //[DataMember(Name="dead")]
        //[DataMember(Name="deviceControlType")]
        //[DataMember(Name="deviceIcon")]
        //[DataMember(Name="disabled")]
        //[DataMember(Name="emailNotificationID")]
        //[DataMember(Name="emailNotificationType")]
        //[DataMember(Name="endPoint")]
        //[DataMember(Name="isBatteryOperated")]
        //[DataMember(Name="isLight")]
        //[DataMember(Name="liliOffCommand")]
        //[DataMember(Name="liliOnCommand")]
        //[DataMember(Name="log")]
        //[DataMember(Name="logTemp")]
        //[DataMember(Name="needConfigure")]
        //[DataMember(Name="nodeID")]
        //[DataMember(Name="parametersTemplate")]
        //[DataMember(Name="parentID")]
        //[DataMember(Name="pollingRetryError")]
        //[DataMember(Name="pollingTime")]
        //[DataMember(Name="pollingTimeNext")]
        //[DataMember(Name="pollingTimeSec")]
        //[DataMember(Name="productInfo")]
        //[DataMember(Name="pushNotificationID")]
        //[DataMember(Name="pushNotificationType")]
        //[DataMember(Name="requestNodeNeighborState")]
        //[DataMember(Name="requestNodeNeighborStateTimeStemp")]
        //[DataMember(Name="saveLogs")]
        //[DataMember(Name="showChildren")]
        //[DataMember(Name="smsNotificationID")]
        //[DataMember(Name="smsNotificationType")]
        //[DataMember(Name="sortOrder")]
        //[DataMember(Name="unit")]
        //[DataMember(Name="useTemplate")]
        //[DataMember(Name="userDescription")]
        //[DataMember(Name="value")]
        //[DataMember(Name="zwaveCompany")]
        //[DataMember(Name="zwaveInfo")]
        //[DataMember(Name="zwaveVersion")]
        #endregion binary_light
        #region rgb_driver
        //[DataMember(Name="UIMessageSendTime")]
        [DataMember(Name = "associationMode")]
        public string AssociationMode { get; set; }
        [DataMember(Name = "bScaler")]
        public string BScalar { get; set; }
        [DataMember(Name = "buttonType")]
        public string ButtonType { get; set; }
        //[DataMember(Name="classConfigure")]
        //[DataMember(Name="classGeneric")]
        //[DataMember(Name="classSupport")]
        //[DataMember(Name="classVersion")]
        [DataMember(Name = "color")]
        public string Color { get; set; }
        [DataMember(Name = "currentProgram")]
        public string CurrentProgram { get; set; }
        [DataMember(Name = "currentProgramID")]
        public string CurrentProgramId { get; set; }
        //[DataMember(Name="dead")]
        //[DataMember(Name="deviceControlType")]
        //[DataMember(Name="deviceIcon")]
        //[DataMember(Name="disabled")]
        //[DataMember(Name="emailNotificationID")]
        //[DataMember(Name="emailNotificationType")]
        //[DataMember(Name="endPoint")]
        [DataMember(Name = "favoriteProgram")]
        public string FavoriteProgram { get; set; }
        [DataMember(Name = "gScaler")]
        public string GScaler { get; set; }
        //[DataMember(Name="isBatteryOperated")]
        //[DataMember(Name="isLight")]
        [DataMember(Name = "lastColorSet")]
        public string LastColorSet { get; set; }
        [DataMember(Name = "lastUsedPrograms")]
        public string LastUsedPrograms { get; set; }
        //[DataMember(Name="liliOffCommand")]
        //[DataMember(Name="liliOnCommand")]
        //[DataMember(Name="log")]
        //[DataMember(Name="logTemp")]
        [DataMember(Name = "meterSupport")]
        public string MeterSupport { get; set; }
        [DataMember(Name = "mode")]
        public string Mode { get; set; }
        //[DataMember(Name="needConfigure")]
        //[DataMember(Name="nodeID")]
        //[DataMember(Name="parametersTemplate")]
        //[DataMember(Name="parentID")]
        //[DataMember(Name="pollingRetryError")]
        //[DataMember(Name="pollingTime")]
        //[DataMember(Name="pollingTimeNext")]
        //[DataMember(Name="pollingTimeSec")]
        //[DataMember(Name="productInfo")]
        //[DataMember(Name="programsSortOrder")]
        //[DataMember(Name="pushNotificationID")]
        //[DataMember(Name="pushNotificationType")]
        [DataMember(Name = "rScaler")]
        public string RScaler { get; set; }
        [DataMember(Name = "rememberColor")]
        public string RememberColor { get; set; }
        //[DataMember(Name="requestNodeNeighborState")]
        //[DataMember(Name="requestNodeNeighborStateTimeStemp")]
        //[DataMember(Name="saveLogs")]
        //[DataMember(Name="sensorSupport")]
        //[DataMember(Name="showChildren")]
        //[DataMember(Name="showEnergy")]
        //[DataMember(Name="smsNotificationID")]
        //[DataMember(Name="smsNotificationType")]
        //[DataMember(Name="sortOrder")]
        //[DataMember(Name="unit")]
        //[DataMember(Name="unitMeter")]
        //[DataMember(Name="unitSensor")]
        //[DataMember(Name="useTemplate")]
        //[DataMember(Name="userDescription")]
        //[DataMember(Name="value")]
        //[DataMember(Name="valueMeter")]
        //[DataMember(Name="valueSensor")]
        //[DataMember(Name="zwaveCompany")]
        //[DataMember(Name="zwaveInfo")]
        //[DataMember(Name="zwaveVersion")]
        #endregion rgb_driver
        #region iOS_device
        [DataMember(Name = "DeviceToken")]
        public string DeviceToken { get; set; }
        [DataMember(Name = "DeviceUID")]
        public string DeviceUID { get; set; }
        [DataMember(Name = "Push")]
        public string Push { get; set; }
        //[DataMember(Name = "saveLogs")]
        #endregion iOS_device
        #region water_sensor
        //[DataMember(Name="UIMessageSendTime")]
        [DataMember(Name = "alarmDelay")]
        public string AlarmDelay { get; set; }
        [DataMember(Name = "alarmExclude")]
        public string AlarmExclude { get; set; }
        [DataMember(Name = "alarmTimeTimestamp")]
        public string AlarmTimeTimestamp { get; set; }
        [DataMember(Name = "armConditions")]
        public string ArmConditions { get; set; }
        [DataMember(Name = "armConfig")]
        public string ArmConfig { get; set; }
        [DataMember(Name = "armDelay")]
        public string ArmDelay { get; set; }
        [DataMember(Name = "armError")]
        public string ArmError { get; set; }
        [DataMember(Name = "armTimeTimestamp")]
        public string ArmTimeTimestamp { get; set; }
        [DataMember(Name = "armed")]
        public string ArmArmed { get; set; }
        [DataMember(Name = "batteryLevel")]
        public string BatteryLevel { get; set; }
        [DataMember(Name = "batteryLowNotification")]
        public string BatteryLowNotification { get; set; }
        //[DataMember(Name = "classConfigure")]
        //[DataMember(Name = "classGeneric")]
        //[DataMember(Name = "classSupport")]
        //[DataMember(Name = "classVersion")]
        //[DataMember(Name = "dead")]
        //[DataMember(Name = "deviceControlType")]
        //[DataMember(Name = "deviceIcon")]
        //[DataMember(Name = "disabled")]
        //[DataMember(Name = "emailNotificationID")]
        //[DataMember(Name = "emailNotificationType")]
        //[DataMember(Name = "endPoint")]
        [DataMember(Name = "fibaroAlarm")]
        public string FibaroAlarm { get; set; }
        //[DataMember(Name = "isBatteryOperated")]
        [DataMember(Name = "lastBreached")]
        public string LastBreached { get; set; }
        //[DataMember(Name = "log")]
        //[DataMember(Name = "logTemp")]
        //[DataMember(Name = "needConfigure")]
        //[DataMember(Name = "nodeID")]
        //[DataMember(Name = "parametersTemplate")]
        //[DataMember(Name = "parentID")]
        //[DataMember(Name = "pollingRetryError")]
        //[DataMember(Name = "pollingTime")]
        //[DataMember(Name = "pollingTimeNext")]
        //[DataMember(Name = "pollingTimeSec")]
        //[DataMember(Name = "productInfo")]
        //[DataMember(Name = "pushNotificationID")]
        //[DataMember(Name = "pushNotificationType")]
        //[DataMember(Name = "requestNodeNeighborState")]
        //[DataMember(Name = "requestNodeNeighborStateTimeStemp")]
        //[DataMember(Name = "saveLogs")]
        //[DataMember(Name = "showChildren")]
        //[DataMember(Name = "smsNotificationID")]
        //[DataMember(Name = "smsNotificationType")]
        //[DataMember(Name = "sortOrder")]
        [DataMember(Name = "tamperAlarm")]
        public string TamperAlarm { get; set; }
        [DataMember(Name = "tamperNotificationID")]
        public string TamperNotificationId { get; set; }
        [DataMember(Name = "tamperNotificationType")]
        public string TamperNotificationType { get; set; }
        [DataMember(Name = "tamperState")]
        public string TamperState { get; set; }
        [DataMember(Name = "tamperTimestamp")]
        public string TamperTimestamp { get; set; }
        //[DataMember(Name = "unit")]
        //[DataMember(Name = "useTemplate")]
        //[DataMember(Name = "userDescription")]
        //[DataMember(Name = "value")]
        [DataMember(Name = "wakeUpTime")]
        public string WakeUpTime { get; set; }
        //[DataMember(Name = "zwaveCompany")]
        //[DataMember(Name = "zwaveInfo")]
        //[DataMember(Name = "zwaveVersion")]


        #endregion water_sensor
    }

    [DataContract]
    public class Actions
    {
        #region unkown_device
        [DataMember(Name = "pollingDeadDevice")]
        public string PollingDeadDevice { get; set; }

        [DataMember(Name = "pollingTimerSec")]
        public string PollingTimerSec { get; set; }

        [DataMember(Name = "requestNodeNeighborUpdate")]
        public string RequestNodeNeighborUpdate { get; set; }

        [DataMember(Name = "turnOff")]
        public string TurnOff { get; set; }

        [DataMember(Name = "turnOn")]
        public string TurnOn { get; set; }
        #endregion unkown_device
        #region HC_user
        [DataMember(Name = "sendEmail")]
        public int SendEmail { get; set; }
        [DataMember(Name = "sendPush")]
        public int SendPush { get; set; }
        [DataMember(Name = "setSipDisplayName")]
        public int SetSipDisplayName { get; set; }
        [DataMember(Name = "setSipUserID")]
        public int SetSipUserID { get; set; }
        [DataMember(Name = "setSipUserPassword")]
        public int SetSipUserPassword { get; set; }

        #endregion HC_user
        #region dimmable_light
        [DataMember(Name = "firmwareUpdate")]
        public int FirmwareUpdate { get; set; }
        [DataMember(Name = "pollingTimeSec")]
        public int PollingTimeSec { get; set; }
        //[DataMember(Name = "requestNodeNeighborUpdate")]
        //public int RequestNodeNeighborUpdate { get; set; }
        [DataMember(Name = "setValue")]
        public int SetValue { get; set; }
        //[DataMember(Name = "turnOff")]
        //public int TurnOff { get; set; }
        //[DataMember(Name = "turnOn")]
        //public int TurnOn { get; set; }

        #endregion dimmable_light
        #region rgb_driver
        //[DataMember(Name="firmwareUpdate")]
        //[DataMember(Name="pollingTimeSec")]
        //[DataMember(Name="requestNodeNeighborUpdate")]
        [DataMember(Name = "resetMeter")]
        public int ResetMeter { get; set; }
        [DataMember(Name = "setB")]
        public int SetB { get; set; }
        [DataMember(Name = "setColor")]
        public int SetColor { get; set; }
        [DataMember(Name = "setG")]
        public int SetG { get; set; }
        [DataMember(Name = "setR")]
        public int SetR { get; set; }
        //[DataMember(Name = "setValue")]
        //public int SetValue { get; set; }
        [DataMember(Name = "setW")]
        public int SetW { get; set; }
        [DataMember(Name = "startProgram")]
        public int StartProgram { get; set; }
        //[DataMember(Name="turnOff")]
        //[DataMember(Name="turnOn")]

        #endregion rgb_driver
        #region iOS_device
        [DataMember(Name = "sendDefinedPushNotification")]
        public int SendDefinedPushNotification { get; set; }
        //[DataMember(Name = "sendPush")]
        //public int SendPush { get; set; }
        #endregion iOS_device
        #region water_sensor
      	[DataMember(Name = "armed")]
        public int Armed { get; set; }
	    //[DataMember(Name="firmwareUpdate")]
	    //[DataMember(Name="pollingTimeSec")]
	    //[DataMember(Name="requestNodeNeighborUpdate")]
	    [DataMember(Name="wakeUpTime")]
        public int WakeUpTime { get; set; }
        #endregion water_sensor
    }
}
