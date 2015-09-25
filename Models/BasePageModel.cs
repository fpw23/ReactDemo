using CestnoSoftware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReactDemo.Models
{
    public class BasePageModel
    {
        #region Messages
        private List<FunctionResultMessage> _Messages = new List<FunctionResultMessage>();
        public List<FunctionResultMessage> Messages
        {
            get
            {
                return this._Messages;
            }
            set
            {
                this._Messages = value;
            }
        }
        #endregion

        #region HasMessages
        public bool HasMessages
        {
            get
            {
                return this._Messages.Count > 0;
            }
        }
        #endregion
    }
}