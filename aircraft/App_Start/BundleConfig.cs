﻿using System.Web;
using System.Web.Optimization;

namespace Aircraft
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new StyleBundle("~/content/smartadmin").IncludeDirectory("~/content/css", "*.css"));

            bundles.Add(new ScriptBundle("~/scripts/smartadmin").Include(
                                        "~/scripts/app.config.seed.js",
                                        "~/scripts/bootstrap/bootstrap.min.js",
                                        "~/scripts/app.seed.min.js"));

            BundleTable.EnableOptimizations = true;

        }
    }
}
