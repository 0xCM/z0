//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static Konst;
    using P = Z0.Parts;

    class App : AppShell<App,IAppContext>
    {
        static IAppContext CreateAppContext()
        {
            var resolved = ApiQuery.combine(P.Imagine.Resolved);
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