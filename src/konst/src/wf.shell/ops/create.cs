//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static TextRules;

    partial class WfShell
    {
        [Op]
        public static IWfShell create(string[] args, bool verbose = true)
            => create(ApiCatalogs.parts(root.controller(), args), args, verbose);

        [Op]
        public static IWfShell create(IApiParts parts, string[] args, bool verbose = true)
        {
            var status = new WfInitStatus();
            status.StartTS = root.now();

            if(verbose)
                term.inform(AppMsg.status("Creating shell"));

            var clock = Time.counter(true);
            var control = root.controller();
            var controlId = control.Id();
            var dbRoot = Env.create().Db.Value;

            var jsonConfigPath = dbRoot + FS.folder("settings") + FS.file(controlId.Format(), FS.Extensions.JsonConfig);

            if(verbose)
                term.inform(AppMsg.status(text.prop("DbRoot", dbRoot)));

            var partIdList = parts.ApiCatalog.PartIdentities;
            if(verbose)
            {
                var fence = text.fence(Chars.LBrace, Chars.RBrace);
                var enclosed = Rules.enclose(text.join(RP.CommaJoin, partIdList), fence);
                var content = Format.format(enclosed);
                var prop = text.prop("Parts", content);
                var msg = AppMsg.status(prop);
                term.inform(msg);
            }

            IAppPaths _paths = new AppPaths(dbRoot);
            status.PathConfigTime = clock.Elapsed;

            clock.Restart();

            if(verbose)
                term.inform(AppMsg.status("Initialized paths"));

            var ctx = new WfContext();
            ctx.ApiParts = parts;
            ctx.Args = args;
            ctx.Paths = _paths;
            ctx.Settings = JsonSettings.Load(jsonConfigPath);
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
            status.AppConfigPath = jsonConfigPath;

            return wf;
        }
    }
}