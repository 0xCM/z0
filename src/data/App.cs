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
            var resolved = ApiComposition.Assemble(z.stream(P.Imagine.Resolved));
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
            InstrinsicsEmitter.create(Context).Emit();            
            term.print(text.concat("ContentForm".PadRight(20), SpacePipe, "Kind".PadRight(12), SpacePipe,  "Name".PadRight(60), SpacePipe, "Count"));
            z.iter(Tables.Content, Describe);       
            z.iter(Tables.Structured, Describe);     
        }

        void Describe(Paired<StructureKind,AppResourceDoc> src)
        {
            (var k, var doc) = src;
            var info = new ContentLibEntry((ContentKind)k, k, (uint)doc.RowCount, doc.Name);
            term.print(info.Format());

        }

        void Describe(Paired<ContentKind,AppResource> src)
        {
            (var k, var doc) = src;
            var info = new ContentLibEntry(k, StructureKind.None, (uint)doc.Content.Length, doc.Name);
            term.print(info.Format());
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