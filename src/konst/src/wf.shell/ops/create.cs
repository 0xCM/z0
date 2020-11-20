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
        [MethodImpl(Inline)]
        public static WfTokenizer tokenizer()
            => new WfTokenizer();

        [Op]
        public static IWfShell create(string[] args, bool verbose = false)
        {
            var control = controller();
            var controlId = control.Id();

            var dbRoot = WfEnv.dbRoot();
            var db = Z0.Db.create(new FileDbPaths(dbRoot));
            var parts = WfShell.parts(control, args);
            var partIdList = parts.Api.PartIdentities;
            var appLogConfig = WfLogs.configure(controlId, dbRoot);

            IWfPaths _paths = new WfPaths(appLogConfig);
            var ctx = new WfContext();
            ctx.ApiParts = parts;
            ctx.Args = args;
            ctx.Paths = _paths;
            ctx.Settings = JsonSettings.Load(_paths.AppConfigPath);
            ctx.Controller = control;

            IWfShell wf = new WfShell(new WfInit(db, ctx, appLogConfig, partIdList));
            wf.Router.Enlist(WfShell.reactors(wf,parts.Components));


            if(verbose)
            {
                var ci = new WfConfigInfo();
                ci.Args = args;
                ci.Controller = controlId;
                ci.LogConfig = appLogConfig;
                ci.Parts = partIdList;
                ci.AppConfigPath = _paths.AppConfigPath;

                var dst = Buffers.text();
                render(ci,dst);
                wf.Status(dst.Emit());
            }
            return wf;
        }
    }
}