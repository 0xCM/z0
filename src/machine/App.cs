//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using Z0.Asm;

    using static z;

    using P = Z0.Parts;
        
    class App : AppShell<App,IAppContext>
    {                
        static IAppContext CreateAppContext()
        {
            var resolved = ApiComposition.Assemble(stream(P.GMath.Resolved));
            var random = Polyrand.Pcg64(PolySeed64.Seed05);                
            var settings = AppSettings.Load(AppPaths.AppConfigPath);
            var exchange = AppMsgExchange.Create();
            return AppContext.Create(resolved, random, settings, exchange);
        }
        
        public App()
            : base(ContextFactory.app())
        {
        }
        
        void ReadRes()
        {
            var map = MemoryFile.resbytes();
            var @base = map.BaseAddress;
            var data = map.Read(@base, 16);
            var info = map.FileInfo;
            term.print(info.Length);

            term.print(@base);
            term.print(data.Length);
            term.print(new BinaryCode(data.ToArray()));
        }
        
        public override void RunShell(params string[] args)
        {
            var ct = CorrelationToken.define(1);
            using var control = Control.create(Context, ct, args);
            control.Run();
        }

        public static void Main(params string[] args)
            => Launch(args);
    }

    public static partial class XTend
    {

    }
}