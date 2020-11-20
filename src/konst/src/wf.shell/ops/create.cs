//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    public struct WfConfigInfo
    {
        public PartId Controller;

        public string[] Args;

        public FS.FilePath AppConfigPath;

        public PartId[] Parts;

        public WfLogConfig LogConfig;
    }

    partial class WfShell
    {
        [Op]
        public static IWfShell create(string[] args, bool verbose = false)
        {
            var control = controller();
            var controlId = control.Id();

            var appLogRoot = WfLogs.root("apps");
            var testLogRoot = WfLogs.root("test");
            var dbRoot = WfEnv.dbRoot();
            var parts = WfShell.parts(control, args);
            var partIdList = parts.Api.PartIdentities;
            var appLogConfig = WfLogs.configure(controlId, dbRoot, appLogRoot);

            IWfPaths _paths = new WfPaths(appLogConfig);
            var ctx = new WfContext();
            ctx.ApiParts = parts;
            ctx.Args = args;
            ctx.Paths = _paths;
            ctx.Settings = JsonSettings.Load(_paths.AppConfigPath);
            ctx.WfSettings = new WfSettings(ctx.Settings);
            ctx.TestLogPaths = TestLogPaths.define(appLogRoot);
            ctx.Controller = control;

            var ci = new WfConfigInfo();
            ci.Args = args;
            ci.Controller = controlId;
            ci.LogConfig = appLogConfig;
            ci.Parts = partIdList;
            ci.AppConfigPath = _paths.AppConfigPath;

            IWfShell wf = new WfShell(new WfInit(ctx, appLogConfig, partIdList));
            wf.Router.Enlist(WfShell.reactors(wf,parts.Components));

            if(verbose)
            {
                var dst = Buffers.text();
                render(ci,dst);
                wf.Status(dst.Emit());
            }
            return wf;
        }
    }
}