//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static TextRules;

    partial class WfShell
    {
        [Op]
        public static IWfShell create(IApiParts parts, string[] args, bool verbose = true)
        {
            var status = new WfInitStatus();
            status.Args = args;
            status.StartTS = root.now();

            var control = root.controller();
            var controlId = control.Id();
            status.Controller = controlId;

            if(verbose)
                term.inform(AppMsg.status("Creating shell"));

            var clock = Time.counter(true);
            var dbRoot = Env.create().Db.Value;

            if(verbose)
                term.inform(AppMsg.status(text.prop("DbRoot", dbRoot)));

            var jsonConfigPath = dbRoot + FS.folder("settings") + FS.file(controlId.Format(), FS.Extensions.JsonConfig);
            status.AppConfigPath = jsonConfigPath;


            var partIdList = parts.ApiCatalog.PartIdentities;
            status.Parts = partIdList;

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

            var loggers = Loggers.configure(controlId, dbRoot);
            var init = new WfInit(ctx, loggers, partIdList);

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

            return wf;
        }
    }
}