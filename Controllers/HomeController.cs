using ReactDemo.Classes;
using ReactDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReactDemo.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet(), Route("~/Home/Signup"), Route("~/", Name = "default")]
        public ActionResult Signup()
        {
            var model = new FormPageModel()
            {
                JSXControlName = "Components.SignUp",
                JSXControlProps = new
                {
                    initialData = new SignUpInfo()
                    {
                        UserName = "frank",
                        Email = "frank@test.com"
                    },
                    postbackURL = "/Home/Signup"
                }
            };

            return View("~/Views/Forms/SingleColumn.cshtml", model);
        }

        [HttpPost(), Route("~/Home/Signup")]
        public ActionResult Signup(SignUpInfo formData)
        {
            var model = new FormPageModel()
            {
                JSXControlName = "Components.SignUp",
                JSXControlProps = new
                {
                    initialData = formData,
                    postbackURL = "/Home/Signup"
                }
            };

            return View("~/Views/Forms/SingleColumn.cshtml", model);
        }

    }
}