//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    partial class WfShell
    {
        [Op]
        public static IWfShell create(ApiPartSet parts, string[] args, bool verbose = true)
        {

            var status = new WfInitStatus();
            status.StartTS = root.now();

            var msg = $"[{status.StartTS}] | Creating shell and associated dependencies";
            if(verbose)
                term.inform(msg);

            var clock = Time.counter(true);
            var control = controller();
            var controlId = control.Id();
            var dbRoot = WfEnv.dbRoot();
            var partIdList = parts.Api.PartIdentities;
            var appLogConfig = Loggers.configure(controlId, dbRoot);
            IWfAppPaths _paths = new WfPaths(dbRoot);
            status.PathConfigTime = clock.Elapsed;

            msg = $"[{clock.Elapsed}] | Initialized paths";
            clock.Restart();
            if(verbose)
                term.inform(msg);

            var ctx = new WfContext();
            ctx.ApiParts = parts;
            ctx.Args = args;
            ctx.Paths = _paths;
            ctx.Settings = JsonSettings.Load(_paths.AppConfigPath);
            ctx.Controller = control;
            status.InitConfigTime = clock.Elapsed;
            msg = $"[{clock.Elapsed}] | Created context";

            clock.Restart();

            if(verbose)
                term.inform(msg);

            IWfShell wf = new WfShell(new WfInit(dbRoot, ctx, appLogConfig, partIdList));

            msg = $"[{clock.Elapsed}] | Created shell";
            if(verbose)
                term.inform(msg);

            var reactors = WfShell.reactors(wf);
            if(reactors.IsNonEmpty)
                wf.Router.Enlist(reactors);

            msg =  $"[{clock.Elapsed}] | Enlisted {reactors.Count} routers";
            if(verbose)
                term.inform(msg);

            status.ShellCreateTime = clock.Elapsed;
            status.FinishTS = now();
            status.Args = args;
            status.Controller = controlId;
            status.LogConfig = appLogConfig;
            status.Parts = partIdList;
            status.AppConfigPath = _paths.AppConfigPath;

            return wf;
        }

        [Op]
        public static IWfShell create(string[] args, bool verbose = true)
        {

            var status = new WfInitStatus();
            status.StartTS = now();

            var msg = $"[{status.StartTS}] | Initiating shell creation steps";
            if(verbose)
                term.inform(msg);

            var clock = Time.counter(true);
            var control = controller();
            var parts = WfShell.parts(control, args);

            msg = $"[{clock.Elapsed}] | Created partset with {parts.PartComponents.Length} components";

            if(verbose)
                term.inform(msg);

            return create(parts, args, verbose);
        }
    }
}