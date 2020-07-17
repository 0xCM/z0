//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;

    using Z0.Xed;
    
    using static Memories;
 
    using P = Z0.Parts;
    
    class App : AppShell<App,IAppContext>
    {                
        static IAppContext CreateAppContext()
        {
            var resolved = ApiComposition.Assemble(seq(P.GMath.Resolved));
            var random = Polyrand.Pcg64(PolySeed64.Seed05);                
            var settings = AppSettings.Load(AppPaths.AppConfigPath);
            var exchange = AppMsgExchange.Create();
            return AppContext.Create(resolved, random, settings, exchange);
        }
        
        public App()
            : base(CreateAppContext())
        {
        }

        void Parse(FilePath src)
        {
            var data = XedSourceParser.Service.LoadSource(src);
            if(data.IsNonEmpty)
                term.print($"Parsed {data.Rows.Length} rows from {src}");
            else
                term.warn($"No content was parsed from {src}");
        }

        void TestCases()
        {
            
            var  index = Enums.index(Assembly.GetExecutingAssembly());
            using var writer = Context.AppPaths.AppStandardOutPath.Writer();
            for(var i=0; i<index.Length; i++)
            {
                var literal = index[i];
                writer.WriteLine($"{literal.Position} {literal.TypeHandle}  {literal.Id}  {literal.Name} {literal.Value}");
            }

        }
        public override void RunShell(params string[] args)
        {            
              TestCases();        

            //XedEtlWorkflow.Service(Context).Run();
                                    
        }

        public static void Main(params string[] args)
            => Launch(args);
    }
}