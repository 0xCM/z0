//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static core;
    partial class WfRuntime
    {
        public static IWfRuntime create(IApiParts parts)
            => create(parts, array<string>());

        public static IWfRuntime create(string[] args)
            => create(ApiRuntimeLoader.parts(core.controller()), args);

        public static IWfRuntime create()
            => create(ApiRuntimeLoader.parts(core.controller()), array<string>());

        [Op]
        public static IWfRuntime create(IApiParts parts, string[] args, bool verbose = true)
        {
            var status = new WfInitStatus();
            status.Args = args;
            status.StartTS = now();

            var control = controller();
            var controlId = control.Id();
            status.Controller = controlId;

            if(verbose)
                term.inform(AppMsg.status("Creating shell"));

            var clock = Time.counter(true);
            var dbRoot = Z0.Env.load().Db.Value;

            if(verbose)
                term.inform(AppMsg.status(text.prop("DbRoot", dbRoot)));

            var jsonConfigPath = dbRoot + FS.folder("settings") + FS.file(controlId.Format(), FS.JsonConfig);
            status.AppConfigPath = jsonConfigPath;


            var partIdList = parts.RuntimeCatalog.PartIdentities;
            status.Parts = partIdList;

            if(verbose)
            {
                var fence = text.fence(Chars.LBrace, Chars.RBrace);
                var enclosed = Rules.fenced(text.join(RP.CommaJoin, partIdList), fence);
                var content = Rules.format(enclosed);
                var prop = text.prop("Parts", content);
                var msg = AppMsg.status(prop);
                term.inform(msg);
            }

            IAppPaths _paths = new AppPaths(dbRoot);
            status.PathConfigTime = clock.Elapsed();

            clock.Restart();

            if(verbose)
                term.inform(AppMsg.status("Initialized paths"));

            var ctx = new WfContext();
            ctx.ApiParts = parts;
            ctx.Args = args;
            ctx.Paths = _paths;
            ctx.Settings = JsonSettings.Load(jsonConfigPath);
            ctx.Controller = control;
            status.InitConfigTime = clock.Elapsed();

            clock.Restart();

            if(verbose)
                term.inform(AppMsg.status("Created context"));

            var loggers = Loggers.configure(controlId, dbRoot);
            var init = new WfInit(ctx, loggers, partIdList);

            if(verbose)
                term.inform(AppMsg.status("Creating shell"));

            IWfRuntime wf = new WfRuntime(init);

            if(verbose)
                term.inform(AppMsg.status("Created shell"));

            var reactors = WfRuntime.reactors(wf);
            if(reactors.IsNonEmpty)
                wf.Router.Enlist(reactors);

            if(verbose)
                term.inform(AppMsg.status($"Enlisted {reactors.Count} routers"));

            status.ShellCreateTime = clock.Elapsed();
            status.FinishTS = root.now();

            return wf;
        }
    }
}