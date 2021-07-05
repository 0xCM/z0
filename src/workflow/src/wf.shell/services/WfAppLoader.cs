//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;


    using static core;

    public readonly struct WfAppLoader
    {

        [Op]
        public static Index<ICmdReactor> reactors(IWfRuntime wf)
        {
            var types = wf.Components.Types();
            var reactors = types.Concrete().Tagged<CmdReactorAttribute>().Select(t => (ICmdReactor)Activator.CreateInstance(t));
            core.iter(reactors, r => r.Init(wf));
            return reactors;
        }

        public static IWfRuntime load()
            => create(ApiRuntimeLoader.parts(core.controller()), array<string>());

        public static IWfRuntime load(string[] args)
            => create(ApiRuntimeLoader.parts(core.controller(), args), args);

        public static IWfRuntime load(PartId[] parts, string[] args)
            => create(ApiRuntimeLoader.parts(parts), args);

        public static IWfRuntime load(IApiParts parts, string[] args)
            => create(parts, args);

        public static IWfRuntime load(IApiParts parts)
            => create(parts, System.Environment.GetCommandLineArgs());

        static WfContext context(Assembly control, IApiParts parts, string[] args)
        {
            var ctx = new WfContext();
            ctx.Controller = control;
            ctx.ApiParts = parts;
            ctx.Args = args;
            ctx.ControlId = control.Id();
            ctx.Paths = AppPaths.create();
            ctx.Settings = JsonSettings.Load(ctx.Paths.Root + FS.folder("settings") + FS.file(ctx.ControlId.Format(), FS.JsonConfig));
            ctx.PartIdentities = ctx.ApiParts.Catalog.PartIdentities;
            return ctx;
        }

        static IWfRuntime runtime(WfContext ctx)
            => new WfRuntime(new WfInit(ctx, Loggers.configure(ctx.ControlId, ctx.Paths.Root), ctx.PartIdentities));

        static IWfRuntime create(IApiParts parts, string[] args)
        {
            term.inform(AppMsg.status($"Beginning runtime initialization at {now()}"));

            var clock = Time.counter(true);
            var verbose = true;
            var control = controller();
            var ctx = context(control, parts, args);
            if(verbose)
            {
                var enclosed = Rules.enclose(text.join(RP.CommaJoin, ctx.PartIdentities), TextRules.fence(Chars.LBrace, Chars.RBrace));
                var prop = TextProp.define("Parts", Rules.format(enclosed));
                term.inform(AppMsg.status(prop));
            }

            var wf = runtime(ctx);
            var react = reactors(wf);
            if(react.IsNonEmpty)
                wf.Router.Enlist(react);

            term.inform(AppMsg.status($"Finished runtime intialization at {now()} in {clock.Elapsed()}"));

            return wf;
        }
    }
}