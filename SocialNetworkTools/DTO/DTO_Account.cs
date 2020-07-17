using System;
using DevExpress.XtraEditors.Controls;

namespace SocialNetworkTools
{
    public class DTO_Account
    {
        private int _IDGroup;
        private ComboBoxItem _IDGroupItem;
        private int _IDDevice;
        private ComboBoxItem _IDDeviceItem;
        private int _IDAccount;
        private string _PrivateKey;
        private string _NameAccount;
        private string _Token;
        private string _Cookie;
        private int _Running;
        private string _UID;
        private string _Password;
        private string _Package;
        private string _Action;
        private string _Logged;
        private string _Friends;
        private string _Groups;
        private string _Note;
        private string _Status;
        private string _Proxy;
        private string _IsStop;
        private string _I;
        private string[] _St;
        public int IDGroup
        {
            get
            {
                int iDGroup;
                try { iDGroup = this._IDGroup; }
                catch (Exception) { throw; }
                return iDGroup;
            }
            set
            {
                try { this._IDGroup = value; }
                catch (Exception) { throw; }
            }
        }
        public ComboBoxItem IDGroupItem
        {
            get
            {
                ComboBoxItem iDGroupItem;
                try { iDGroupItem = this._IDGroupItem; }
                catch (Exception) { throw; }
                return iDGroupItem;
            }
            set
            {
                try { this._IDGroupItem = value; }
                catch (Exception) { throw; }
            }
        }
        public int IDDevice
        {
            get
            {
                int iDDevice;
                try { iDDevice = this._IDDevice; }
                catch (Exception) { throw; }
                return iDDevice;
            }
            set
            {
                try { this._IDDevice = value; }
                catch (Exception) { throw; }
            }
        }
        public ComboBoxItem IDDeviceItem
        {
            get
            {
                ComboBoxItem iDDeviceItem;
                try { iDDeviceItem = this._IDDeviceItem; }
                catch (Exception) { throw; }
                return iDDeviceItem;
            }
            set
            {
                try { this._IDDeviceItem = value; }
                catch (Exception) { throw; }
            }
        }
        public int IDAccount
        {
            get
            {
                int iDAccount;
                try { iDAccount = this._IDAccount; }
                catch (Exception) { throw; }
                return iDAccount;
            }
            set
            {
                try { this._IDAccount = value; }
                catch (Exception) { throw; }
            }
        }
        public string PrivateKey
        {
            get
            {
                string privateKey;
                try { privateKey = this._PrivateKey; }
                catch (Exception) { throw; }
                return privateKey;
            }
            set
            {
                try { this._PrivateKey = value; }
                catch (Exception) { throw; }
            }
        }
        public string NameAccount
        {
            get
            {
                string nameAccount;
                try { nameAccount = this._NameAccount; }
                catch (Exception) { throw; }
                return nameAccount;
            }
            set
            {
                try { this._NameAccount = value; }
                catch (Exception) { throw; }
            }
        }
        public string Token
        {
            get
            {
                string token;
                try { token = this._Token; }
                catch (Exception) { throw; }
                return token;
            }
            set
            {
                try { this._Token = value; }
                catch (Exception) { throw; }
            }
        }
        public string Cookie
        {
            get
            {
                string cookie;
                try { cookie = this._Cookie; }
                catch (Exception) { throw; }
                return cookie;
            }
            set
            {
                try { this._Cookie = value; }
                catch (Exception) { throw; }
            }
        }
        public int Running
        {
            get
            {
                int running;
                try { running = this._Running; }
                catch (Exception) { throw; }
                return running;
            }
            set
            {
                try { this._Running = value; }
                catch (Exception) { throw; }
            }
        }
        public string UID
        {
            get
            {
                string uID;
                try { uID = this._UID; }
                catch (Exception) { throw; }
                return uID;
            }
            set
            {
                try
                {
                    this._UID = value;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public string Password
        {
            get
            {
                string password;
                try { password = this._Password; }
                catch (Exception) { throw; }
                return password;
            }
            set
            {
                try { this._Password = value; }
                catch (Exception) { throw; }
            }
        }
        public string Package
        {
            get
            {
                string package;
                try { package = this._Package; }
                catch (Exception) { throw; }
                return package;
            }
            set
            {
                try { this._Package = value; }
                catch (Exception) { throw; }
            }
        }
        public string Action
        {
            get
            {
                string action;
                try { action = this._Action; }
                catch (Exception) { throw; }
                return action;
            }
            set
            {
                try { this._Action = value; }
                catch (Exception) { throw; }
            }
        }
        public string Logged
        {
            get
            {
                string logged;
                try { logged = this._Logged; }
                catch (Exception) { throw; }
                return logged;
            }
            set
            {
                try { this._Logged = value; }
                catch (Exception) { throw; }
            }
        }
        public string Friends
        {
            get
            {
                string friends;
                try { friends = this._Friends; }
                catch (Exception) { throw; }
                return friends;
            }
            set
            {
                try { this._Friends = value; }
                catch (Exception) { throw; }
            }
        }
        public string Groups
        {
            get
            {
                string groups;
                try { groups = this._Groups; }
                catch (Exception) { throw; }
                return groups;
            }
            set
            {
                try { this._Groups = value; }
                catch (Exception) { throw; }
            }
        }
        public string Note
        {
            get
            {
                string note;
                try { note = this._Note; }
                catch (Exception) { throw; }
                return note;
            }
            set
            {
                try { this._Note = value; }
                catch (Exception) { throw; }
            }
        }
        public string Status
        {
            get
            {
                string status;
                try { status = this._Status; }
                catch (Exception) { throw; }
                return status;
            }
            set
            {
                try { this._Status = value; }
                catch (Exception) { throw; }
            }
        }
        public string Proxy
        {
            get
            {
                string proxy;
                try { proxy = this._Proxy; }
                catch (Exception) { throw; }
                return proxy;
            }
            set
            {
                try { this._Proxy = value; }
                catch (Exception) { throw; }
            }
        }
        public string IsStop
        {
            get
            {
                string isStop;
                try { isStop = this._IsStop; }
                catch (Exception) { throw; }
                return isStop;
            }
            set
            {
                try { this._IsStop = value; }
                catch (Exception) { throw; }
            }
        }
        public string I
        {
            get
            {
                string i;
                try { i = this._I; }
                catch (Exception) { throw; }
                return i;
            }
            set
            {
                try { this._I = value; }
                catch (Exception) { throw; }
            }
        }
        public string[] St
        {
            get
            {
                string[] st;
                try { st = this._St; }
                catch (Exception) { throw; }
                return st;
            }
            set
            {
                try { this._St = value; }
                catch (Exception) { throw; }
            }
        }
    }
}
