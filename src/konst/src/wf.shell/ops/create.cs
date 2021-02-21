//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;
    using static memory;

    partial class WfShell
    {
        [Op]
        public static IWfShell create(ApiPartSet parts, string[] args, bool verbose = true)
        {

            var status = new WfInitStatus();
            status.StartTS = root.now();

            if(verbose)
                term.inform(AppMsg.status("Creating shell"));

            var clock = Time.counter(true);
            var control = controller();
            var controlId = control.Id();
            var dbRoot = Environs.dbRoot();

            if(verbose)
                term.inform(AppMsg.status(text.prop("DbRoot", dbRoot)));

            var partIdList = parts.ApiGlobal.PartIdentities;
            if(verbose)
                term.inform(AppMsg.status(text.prop("Parts", text.join(", ", partIdList))));

            IAppPaths _paths = new AppPaths(dbRoot);
            status.PathConfigTime = clock.Elapsed;

            clock.Restart();

            if(verbose)
                term.inform(AppMsg.status("Initialized paths"));

            var ctx = new WfContext();
            ctx.ApiParts = parts;
            ctx.Args = args;
            ctx.Paths = _paths;
            ctx.Settings = JsonSettings.Load(_paths.AppConfigPath);
            ctx.Controller = control;
            status.InitConfigTime = clock.Elapsed;

            clock.Restart();

            if(verbose)
                term.inform(AppMsg.status("Created context"));

            var init = new WfInit(dbRoot, ctx, Loggers.configure(controlId, dbRoot), partIdList);

            if(verbose)
                term.inform(AppMsg.status("Creating shell"));

            IWfShell wf = new WfShell(init);

            if(verbose)
                term.inform(AppMsg.status("Created shell"));

            var reactors = WfShell.reactors(wf);
            if(reactors.IsNonEmpty)
                wf.Router.Enlist(reactors);

            if(verbose)
                term.inform(AppMsg.status($"Enlisted {reactors.Count} routers"));

            status.ShellCreateTime = clock.Elapsed;
            status.FinishTS = root.now();
            status.Args = args;
            status.Controller = controlId;
            status.Parts = partIdList;
            status.AppConfigPath = _paths.AppConfigPath;

            return wf;
        }

        [Op]
        public static IWfShell create(string[] args, bool verbose = true)
        {
            var status = new WfInitStatus();
            status.StartTS = root.now();

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