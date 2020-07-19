//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.IO;
    
    using static Konst;

    using P = Z0.Parts;

    using M = IntrinsicsDocument;
    
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


        static string FunctionLabel(M.intrinsic src)
            => src.name.StartsWith("_mm512") ? "_mm512"  : 
               src.name.StartsWith("_mm256") ? "_mm256" : 
               (src.name.StartsWith("_mm_") || src.name.StartsWith("_MM_")) ? "_mm" : 
               src.name.StartsWith("_bnd") ? "_bnd" : 
               src.name.StartsWith("_cast") ? "_cast" : 
               src.name.StartsWith("_cvt") ? "_cvt" : 
               "_unknown";

        void RunApp(params PartId[] src)
        {
            var list = IntrinsicsList.read();
            var export = Context.AppPaths.ExportRoot;
            var dir = export + FolderName.Define("algorithms");
            dir.Clear();

            var writers = z.dict<string,StreamWriter>();
            for(var i=0; i< list.Length; i++)
            {
                ref readonly var current = ref list[i];
                var inxcount = current.instructions.Count;
                var instruction = current.instructions.ToArray().TryGetFirst().ValueOrDefault(M.instruction.Empty);
                var identifier = text.ifblank(instruction.name, current.name);
                var label = text.concat("# ", 
                    current.instructions.Count != 0 
                  ? text.concat(identifier, Space, Chars.Dash, Space, current.name) 
                  : identifier);
                  
                var filename = 
                    current.instructions.Count != 0 
                    ? FileName.Define($"{identifier[0]}", "pas") 
                    : FileName.Define(FunctionLabel(current), "pas");

                var writer = default(StreamWriter);
                if(!writers.TryGetValue(filename.Name, out writer))
                {   
                    writer = (dir + filename).Writer();
                    writers.Add(filename.Name, writer);
                }
                
                writer.WriteLine(label);
                writer.WriteLine(text.PageBreak);
                var content = (current.operation.Content ?? EmptyString).Trim();
                writer.WriteLine(content);
                writer.WriteLine(text.PageBreak);
            }
            z.iter(writers.Values, w => w.Dispose());         
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