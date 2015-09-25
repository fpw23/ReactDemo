using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CestnoSoftware;

namespace ReactDemo.Models
{
    public class FormPageModel : BasePageModel
    {
        #region JSXControlName
        private string _JSXControlName;
        public string JSXControlName
        {
            get
            {
                return this._JSXControlName;
            }
            set
            {
                this._JSXControlName = value;
            }
        }
        #endregion

        #region JSXControlProps
        private object _JSXControlProps;
        public object JSXControlProps
        {
            get
            {
                return this._JSXControlProps;
            }
            set
            {
                this._JSXControlProps = value;
            }
        }
        #endregion
    }
}