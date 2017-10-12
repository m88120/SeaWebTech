using CMS.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMS.Controllers
{
    public class PluginsController : Controller
    {
        //
        // GET: /Plugins/
        public ActionResult Plugins()
        {

            return View();
        }
        public ActionResult keywordcount()
        {
            return View();
        }
        [HttpPost]
        public ActionResult keywordcount(KeywordCountModel model)
        {
            try
            {
                getAllPagesLink(model.Url);
                return View();
            }
            catch (Exception ex)
            {
                ViewBag.Title = ex.Message;
                return View();
            }
        }
        private void getAllPagesLink(string url)
        {
            //Scanner _objScanner = new Scanner();
            //List<string> links = _objScanner.getInnerUrls(url, true);

            //FetchDataFromHtml _objFetchDataFromHtml = new FetchDataFromHtml();
            
            //List<MetaList> _data =    _objFetchDataFromHtml.fetchKeywordAndMeta(links.Distinct().Take(20).ToList());
            //ListToCsv _objListToCsv = new ListToCsv();
            //  // TODO add items to list :)
            //  var csv = _objListToCsv.GetCsv(_data);
            //Response.Clear();
            //Response.ClearHeaders();

            //Response.AddHeader("Content-Length", csv.Length.ToString());
            //Response.ContentType = "text/csv";
            //Response.AppendHeader("content-disposition", "attachment;filename=\"meta_report" + DateTime.Now.ToString() + ".csv\"");

            //Response.Write(csv);
            //Response.End();
        }

    }
}
