//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    
    using Z0.Asm;

    using static Konst;

    using P = Z0.Parts;
    
    class App : AppShell<App,IAppContext>
    {                
        static IAppContext CreateAppContext()
        {
            var resolved = ApiComposition.Assemble(z.seq(P.Imagine.Resolved));
            var random = Polyrand.Pcg64(PolySeed64.Seed05);                
            var settings = AppSettings.Load(AppPaths.AppConfigPath);
            var exchange = AppMsgExchange.Create();
            return Apps.context(resolved, random, settings, exchange);
        }


        public App()
            : base(CreateAppContext())
        {
        }

        void RunApp(params PartId[] src)
        {

            var list = IntrinsicsList.read();
            var export = Context.AppPaths.ExportRoot;
            var alg = (export + FolderName.Define("algorithms")) +FileName.Define("intel.pas");
            using var writer = alg.Writer();
            for(var i=0; i< list.Length; i++)
            {
                ref readonly var current = ref list[i];
                writer.WriteLine($"# {current.name}");
                writer.WriteLine(text.PageBreak);
                writer.WriteLine(current.operation.Content);
            }
            //z.iter(list.Take(20), x => term.print(x.Format()));
         
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