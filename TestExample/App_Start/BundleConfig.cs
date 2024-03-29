﻿using System.Web;
using System.Web.Optimization;

namespace TestExample
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Mycss").Include(
                    "~/Content/Css/easy-responsive-tabs.css",
                    "~/Content/Css/global.css",
                    "~/Content/Css/slider.css",
                    "~/Content/Css/style.css"
                ));
            bundles.Add(new ScriptBundle("~/MyJs").Include(
                    "~/Scripts/js/easing.js",
                    "~/Scripts/js/easyResponsiveTabs.js",
                    "~/Scripts/js/jquery-1.7.2.min.js",
                    "~/Scripts/js/jquery.accordion.js",
                    "~/Scripts/js/jquery.easing.js",
                    "~/Scripts/js/move-top.js",
                    "~/Scripts/js/script.js",
                    "~/Scripts/js/slides.min.jquery.js",
                    "~/Scripts/js/startstop-slider.js"
                ));

        }
    }
}
