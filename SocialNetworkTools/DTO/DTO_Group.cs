using System;

namespace SocialNetworkTools
{
    public class DTO_Group
    {
        private int _IsRun;
        private int _IDGroup;
        private string _Name;
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
    }
}
