﻿using System.Web;
using System.Web.Optimization;

namespace GlucoForm
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/DataTables/jquery.dataTables.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/DataTables/dataTables.bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap-journal.css",
                      "~/Content/site.css",
                      "~/Content/DataTables/css/dataTables.bootstrap.css"));

            //js
            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                "~/Scripts/jquery-ui-{version}.js"));
            //css  
            bundles.Add(new StyleBundle("~/Content/cssjqryUi").Include(
                   "~/Content/themes/base/jquery-ui.css"));

            //timepicker
            bundles.Add(new StyleBundle("~/Content/cssTimePicker").Include(
                   "~/Content/jquery.timepicker.css"));

            //timepicker js
            bundles.Add(new ScriptBundle("~/bundles/jsTimePicker").Include(
                "~/Scripts/jquery.timepicker.js"));
        }
    }
}
