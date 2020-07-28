//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
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
            z.iter(ZDat.Structured, Describe);     
            z.iter(ZDat.Content, Describe);       
        }

        void Describe(Paired<StructuredKind,AppResourceDoc> src)
        {
            const string Form = "Structured";
            var res = src.Right;
            var count = res.Rows.Length;
            term.print($"{Form.PadRight(20)} | {src.Left.Format().PadRight(12)} | {src.Right.Name.PadRight(60)} | {count} ");
        }

        void Describe(Paired<ContentKind,AppResource> src)
        {
            const string Form = "Unstructured";
            var res = src.Right;
            var length = res.Content.Length;
            term.print($"{Form.PadRight(20)} | {src.Left.Format().PadRight(12)} | {src.Right.Name.PadRight(60)} | {length} ");                        
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