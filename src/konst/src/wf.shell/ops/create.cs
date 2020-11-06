//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

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

            configured.Add(string.Format("{0}:{1}", "control", controlId));
            configured.Add(string.Format("{0}:{1}", "args", delimit(args)));
            configured.Add(string.Format("{0}:{1}", "logs.root", logRoot));

            var api = parts(control, args);
            var partList = api.Api.PartIdentities;
            var partCount = partList.Length;
            configured.Add(string.Format("{0}:{1}", "PartCount", partCount));
            configured.Add(string.Format("{0}:{1}", "PartList", delimit(partList)));

            var logConfig = WfShell.logConfig(controlId, logRoot);
            configured.Add(string.Format("{0}:{1}", nameof(WfLogConfig), logConfig.Format()));

            IWfPaths _paths = new WfPaths(logConfig);
            var ctx = new WfContext();
            ctx.ApiParts = api;
            ctx.Args = args;
            ctx.Paths = _paths;
            ctx.Settings = JsonSettings.Load(_paths.AppConfigPath);
            ctx.WfSettings = new WfSettings(ctx.Settings);
            ctx.TestLogPaths = new TestLogPaths(logRoot);
            ctx.Controller = control;

            var init = new WfInit(ctx, logConfig, partList);
            configured.Add(string.Format("{0}:{1}", "wf.init", init.ControlId));

            IWfShell wf = new WfShell(init);
            configured.Add(string.Format("{0}:{1}", "wf", wf.AppName));

            if(verbose)
                wf.Status(configured.FormatList(FieldDelimiter));
            return wf;
        }
    }
}