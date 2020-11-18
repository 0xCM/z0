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

    partial class WfShell
    {
        [Op]
        public static IWfShell create(string[] args, bool verbose = false)
        {
            var control = controller();
            var controlId = control.Id();
            var configured = list<string>();

            var logRoot = EnvVars.Common.DbRoot + FS.folder("logs") + FS.folder("apps");
            var api = WfShell.parts(control, args);
            var partList = api.Api.PartIdentities;
            var partCount = partList.Length;
            var logConfig = WfShell.logConfig(controlId, logRoot);

            IWfPaths _paths = new WfPaths(logConfig);
            var ctx = new WfContext();
            ctx.ApiParts = api;
            ctx.Args = args;
            ctx.Paths = _paths;
            ctx.Settings = JsonSettings.Load(_paths.AppConfigPath);
            ctx.WfSettings = new WfSettings(ctx.Settings);
            ctx.TestLogPaths = TestLogPaths.define(logRoot);
            ctx.Controller = control;

            var init = new WfInit(ctx, logConfig, partList);
            IWfShell wf = new WfShell(init);

            wf.Router.Enlist(WfShell.reactors(wf,api.Components));

            configured.Add(string.Format("{0}:{1}", "control", controlId));
            configured.Add(string.Format("{0}:{1}", "args", delimit(args)));
            configured.Add(string.Format("{0}:{1}", "logs.root", logRoot));
            configured.Add(string.Format("{0}:{1}", "PartCount", partCount));
            configured.Add(string.Format("{0}:{1}", "PartList", delimit(partList)));
            configured.Add(string.Format("{0}:{1}", nameof(WfLogConfig), logConfig.Format()));
            configured.Add(string.Format("{0}:{1}", "wf.init", init.ControlId));
            configured.Add(string.Format("{0}:{1}", "wf", wf.AppName));

            if(verbose)
                wf.Status(configured.FormatList(FieldDelimiter));
            return wf;
        }
    }
}