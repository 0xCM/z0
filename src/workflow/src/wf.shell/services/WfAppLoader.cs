//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static core;
    using System.Reflection;

    public readonly struct WfAppLoader
    {
        public static IWfRuntime load()
            => create(ApiRuntimeLoader.parts(core.controller()), array<string>());

        public static IWfRuntime load(string[] args)
            => create(ApiRuntimeLoader.parts(core.controller(), args), args);

        public static IWfRuntime load(PartId[] parts, string[] args)
            => create(ApiRuntimeLoader.parts(parts), args);

        public static IWfRuntime load(IApiParts parts, string[] args)
            => create(parts, args);

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
                var enclosed = Rules.fenced(text.join(RP.CommaJoin, ctx.PartIdentities), TextRules.fence(Chars.LBrace, Chars.RBrace));
                var prop = TextProp.define("Parts", Rules.format(enclosed));
                term.inform(AppMsg.status(prop));
            }

            var wf = runtime(ctx);
            var reactors = WfRuntime.reactors(wf);
            if(reactors.IsNonEmpty)
                wf.Router.Enlist(reactors);

            term.inform(AppMsg.status($"Finished runtime intialization at {now()} in {clock.Elapsed()}"));

            return wf;
        }
    }
}