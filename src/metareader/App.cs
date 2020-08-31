//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using P = Z0.Parts;

    class App : AppShell<App,IAppContext>
    {
        static IAppContext CreateAppContext()
        {
            var resolved = ApiQuery.apipart(z.stream(P.Imagine.Resolved));
            var random = Polyrand.Pcg64(PolySeed64.Seed05);
            var settings = SettingValues.Load(AppPaths.AppConfigPath);
            var exchange = AppMsgExchange.Create();
            return Apps.context(resolved, random, settings, exchange);
        }

        public App()
            : base(CreateAppContext())
        {
        }

        void RunApp(params PartId[] src)
        {
            var id = ClrQueries.@event(8) ;
            term.print(ClrQueries.format(id));
        }

        public override void RunShell(params string[] args)
        {
            var parts = PartIdParser.Service.ParseValid(args);
            RunApp(parts);
        }

        public static void Main(params string[] args)
            => Launch(args);
    }

    public static partial class XTend
    {

    }
}