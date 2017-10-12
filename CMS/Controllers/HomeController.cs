using CMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CaptchaMvc.HtmlHelpers;
using System.Xml.Linq;
using System.IO;

namespace CMS.Controllers
{
    public class HomeController : Controller
    {
        //[OutputCache(Duration = 60, VaryByParam = "none")]
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }
        //[OutputCache(Duration = 60, VaryByParam = "none")]
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    
        public ActionResult pagenotfound()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult Contact(ContactModel model)
        {
            try
            {
            if (this.IsCaptchaValid("Captcha is not valid"))
            {
                var MailHelper = new MailHelper
                {
                    Sender = model.Email, //email.Sender,
                    Recipient = "seawebtech@gmail.com",
                    RecipientCC = null,
                    Subject = model.Subject,
                    Body = model.Message + "<br/> Thanks <br/>" + model.Name + "<br/>" + model.Email
                };

                if (MailHelper.Send())
                {
                    ViewBag.ErrMessage = "Thanks for contact us, we will reply you ASAP.";
                    return View(new ContactModel());
                }
                else {
                   
                    ViewBag.ErrMessage = "System not working yet, please mail on seawebtech@gmail.com";
                    return View(model);
                }

            }
            else
            {
             
                ViewBag.ErrMessage = "Error: captcha is not valid.";
                return View(model);
            }
            }
            catch (Exception ex)
            {

              
                ViewBag.ErrMessage = ex.Message;
                return View(model);
            }
          //
           
        }

        public ActionResult RequestAQuote()
        {
            List<SelectListItem> ProjectType = new List<SelectListItem>()
            {
                new SelectListItem { Text = "WEBSITE", Value = "WEBSITE" },
                new SelectListItem { Text = "WORDPRESS WEBSITE", Value = "WORDPRESS WEBSITE" },
                new SelectListItem { Text = "MOBILE APP", Value = "MOBILE APP" },
                new SelectListItem { Text = "DIGITAL MARKETIN", Value = "DIGITAL MARKETIN" },
                 new SelectListItem { Text = "MOBILE & WEB APP", Value = "MOBILE & WEB APP" },
                new SelectListItem { Text = "SEARCH ENGINE OPTIMIZATION", Value = "SEARCH ENGINE OPTIMIZATION" },
                new SelectListItem { Text = "Other", Value = "Other" },
            };

            ViewBag.ProjectType = ProjectType;

            return View();
        }
        [HttpPost]
        public ActionResult RequestAQuote(RequestAQuoteModel model, HttpPostedFileBase file)
        {
            List<SelectListItem> ProjectType = new List<SelectListItem>()
            {
                new SelectListItem { Text = "WEBSITE", Value = "WEBSITE" },
                new SelectListItem { Text = "WORDPRESS WEBSITE", Value = "WORDPRESS WEBSITE" },
                new SelectListItem { Text = "MOBILE APP", Value = "MOBILE APP" },
                new SelectListItem { Text = "DIGITAL MARKETIN", Value = "DIGITAL MARKETIN" },
                 new SelectListItem { Text = "MOBILE & WEB APP", Value = "MOBILE & WEB APP" },
                new SelectListItem { Text = "SEARCH ENGINE OPTIMIZATION", Value = "SEARCH ENGINE OPTIMIZATION" },
                new SelectListItem { Text = "Other", Value = "Other" },
            };

            ViewBag.ProjectType = ProjectType;

           
            try
            {
                string _allowExtention = ".txt,.xlsx,.xls,.docx,.doc,.ppt,.pptx,.pdf";
                if(file!=null)
                { 
                    if (!_allowExtention.Contains(Path.GetExtension(file.FileName)))
                    {
                        ViewBag.ErrMessage = "You can upload only "+ _allowExtention +" file";
                        return View(model);
                    }
                    if (file.ContentLength > 20728650)
                    {
                        ViewBag.ErrMessage = "File size exceeds maximum limit 20 MB.";
                        return View(model); 
                    }
                }
                if (this.IsCaptchaValid("Captcha is not valid"))
                {
                    string _ImagePath = string.Empty;
                    uploadFile(file, out _ImagePath);
                    if(_ImagePath!=null || _ImagePath==string.Empty)
                    {
                        _ImagePath = "<a href='"+ "http://www.seawebtech.com/" + _ImagePath + "' target='_blank'>"+ file.FileName + "</a>";
                    }
                    string ddProjectType = Request.Form["ddProjectType"].ToString();
                    var MailHelper = new MailHelper
                    {
                        Sender = model.Email, //email.Sender,
                        Recipient = "seawebtech@gmail.com",
                        RecipientCC = null,
                        Subject = "Project Quote Request :" + model.Subject,
                      //  AttachmentFile = "http://www.seawebtech.com/" + _ImagePath,
                        Body = "Project Name : "+model.Subject+ "<br/>" + model.Message + "<br/>Projct Type : " + ddProjectType + "<br/>Project Budget : " + model.ProjectBudget + "<br/><br/> Thanks, <br/>Name : " + model.Name + "<br/>Email : " + model.Email + "<br/> Phone Number :" + model.PhoneNumber+"<br/>"+ _ImagePath
                    };

                    if (MailHelper.Send())
                    {
                        ViewBag.ErrMessage = "Thanks for contact us, we will reply you ASAP.";
                        return View(new RequestAQuoteModel());
                    }
                    else
                    {

                        ViewBag.ErrMessage = "System not working yet, please mail on seawebtech@gmail.com";
                        return View(model);
                    }


                }
                else
                {

                    ViewBag.ErrMessage = "Error: captcha is not valid.";
                    return View(model);
                }
            }
            catch (Exception ex)
            {


                ViewBag.ErrMessage = ex.Message;
                return View(model);
            }
        }
        private void uploadFile(HttpPostedFileBase file, out string imagePath)
        {
            try
            {



                //HttpPostedFileBase file = files[0];
                string _fileName;

                _fileName = Path.GetFileName(file.FileName);

                string _fileExtension = Path.GetExtension(_fileName);

                string subPath = "~/Content/emailFiles/" + DateTime.Now.Year.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString(); // your code goes here
                                                                                                                                                                   // string thumbnail = subPath + "/thumbnail/";
                bool isExists = System.IO.Directory.Exists(Server.MapPath(subPath));

                if (!isExists)
                    System.IO.Directory.CreateDirectory(Server.MapPath(subPath));



                string path = Path.Combine(Server.MapPath(subPath), _fileName);
                file.SaveAs(path);
                // Returns message that successfully uploaded  
                imagePath = subPath.Replace("~", "") + "/" + file.FileName;
            }
            catch (Exception ex)
            {
                imagePath = null;
            }
        }
        //[OutputCache(Duration = 60, VaryByParam = "none")]
        public ActionResult Portfolio()
        {
            return View();
        }
        public ActionResult Services(string id)
        {
            return View(id);
           
            
        }

        public ActionResult Search(string SearchText)
        {
            ViewBag.SearchText = SearchText;
            return View();
        }
        
    }
   
}
