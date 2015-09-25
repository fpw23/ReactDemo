using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReactDemo.Classes
{
    public class SignUpInfo
    {

        #region UserName
        private string _UserName;
        public string UserName
        {
            get
            {
                return this._UserName;
            }
            set
            {
                this._UserName = value;
            }
        }
        #endregion

        #region Email
        private string _Email;
        public string Email
        {
            get
            {
                return this._Email;
            }
            set
            {
                this._Email = value;
            }
        }
        #endregion

        #region Password
        private string _Password;
        public string Password
        {
            get
            {
                return this._Password;
            }
            set
            {
                this._Password = value;
            }
        }
        #endregion

        #region AcceptTerms
        private bool _AcceptTerms;
        public bool AcceptTerms
        {
            get
            {
                return this._AcceptTerms;
            }
            set
            {
                this._AcceptTerms = value;
            }
        }
        #endregion
    }
}