using System.Runtime.Serialization;

namespace Custom.DataContracts
{
    [DataContract]
    public class SystemInfo
    {
        #region VARIABLES

        [DataMember(Name = "Username", IsRequired = true, Order = 1)]
        private string _username;

        [DataMember(Name = "MachineName", IsRequired = true, Order = 2)]
        private string _machineName;

        [DataMember(Name = "MAC_Address", IsRequired = true, Order = 2)]
        private string _macAddress;

        [DataMember(Name = "Application", IsRequired = true, Order = 3)]
        private string _application;

        [DataMember(Name = "Version", IsRequired = true, Order = 4)]
        private Version _version;

        #endregion

        #region PROPERTIES

        public string Username
        {
            get { return _username; }
        }

        public string MachineName
        {
            get { return _machineName; }
        }

        public string MAC_Address
        {
            get { return _machineName; }
        }

        public string Application
        {
            get { return _application; }
        }

        public Version Version
        {
            get { return _version; }
        }

        #endregion

        #region CONSTRUCTOR

        public SystemInfo(string username, string machineName, string macAddress, string application, Version version)
        {
            _username = username;
            _machineName = machineName;
            _macAddress = macAddress;
            _application = application;
            _version = version;
        }

        #endregion
    }
}
