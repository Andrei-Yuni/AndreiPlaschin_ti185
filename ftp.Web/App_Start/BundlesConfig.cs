using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace ftp.Web.App_Start
{
     static public class BundlesConfig
     {
          static public void RegisterBundles(BundleCollection bundles)
          {
               bundles.Add(new StyleBundle("~/bundles/css")
                         .Include("~/Content/bootstrap.min.css")
                         .Include("~/Content/mdb.min.css")
                         .Include("~/Content/style.css"));
               bundles.Add(new ScriptBundle("~/bundles/js")
                            .Include("~/Scripts/jquery.min.js")
                            .Include("~/Scripts/popper.min.js")
                            .Include("~/Scripts/bootstrap.min.js")
                            .Include("~/Scripts/mdb.min.js"));
          }
     }
}