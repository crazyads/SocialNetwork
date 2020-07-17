using System;

namespace SocialNetworkTools
{
    public class DTO_Devices
    {
        private int _IsRun;
        private string _IDDevice;
        private string _Name;
        private string _IsStop;
        public int IsRun
        {
            get
            {
                int isRun;
                try { isRun = this._IsRun; }
                catch (Exception) { throw; }
                return isRun;
            }
            set
            {
                try { this._IsRun = value; }
                catch (Exception) { throw; }
            }
        }
        public string IDDevice
        {
            get
            {
                string iDDevice;
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
        public string Name
        {
            get
            {
                string name;
                try { name = this._Name; }
                catch (Exception) { throw; }
                return name;
            }
            set
            {
                try { this._Name = value; }
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
    }
}
