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
        [MethodImpl(Inline), Op]
        public static IWfContext<C> inject<C>(IWfContext src, C data)
            => new WfContext<C>(src, data);

        [Op]
        public static IWfShell create(string[] args, bool verbose = false)
        {
            var status = new WfInitStatus();
            status.StartTS = now();
            var clock = Time.counter(true);
            var control = controller();
            var controlId = control.Id();
            var dbRoot = WfEnv.dbRoot();
            var parts = WfShell.parts(control, args);
            var partIdList = parts.Api.PartIdentities;
            var appLogConfig = WfLogs.configure(controlId, dbRoot);
            IWfAppPaths _paths = new WfPaths(dbRoot);
            status.PathConfigTime = clock.Elapsed;
            clock.Restart();

            var ctx = new WfContext();
            ctx.ApiParts = parts;
            ctx.Args = args;
            ctx.Paths = _paths;
            ctx.Settings = JsonSettings.Load(_paths.AppConfigPath);
            ctx.Controller = control;
            status.InitConfigTime = clock.Elapsed;
            clock.Restart();

            IWfShell wf = new WfShell(new WfInit(dbRoot, ctx, appLogConfig, partIdList));
            wf.Router.Enlist(WfShell.reactors(wf));

            status.ShellCreateTime = clock.Elapsed;
            status.FinishTS = now();
            status.Args = args;
            status.Controller = controlId;
            status.LogConfig = appLogConfig;
            status.Parts = partIdList;
            status.AppConfigPath = _paths.AppConfigPath;

            if(verbose)
            {
                var dst = Buffers.text();
                render(status, dst);
                wf.Status(dst.Emit());
            }

            return wf;
        }
    }
}