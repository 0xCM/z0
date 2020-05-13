//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using Z0.Xed;
    
    using static Seed;
    using static Memories;
    using static Xed.Res;

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
            var data = FileParser.Service.ReadResFile(src);
            if(data.IsNonEmpty)
                term.print($"Parsed {data.Rows.Length} rows from {src}");
            else
                term.warn($"No content was parsed from {src}");
        }

        public override void RunShell(params string[] args)
        {            
            var parts = PartParser.Service.ParseValid(args);  

            var parser = FileParser.Service;
            var dataroot = AppPaths.AppSrcPath + FolderName.Define("data"); 
            var rawroot = dataroot + FolderName.Define("raw");
            var parsedRoot = dataroot + FolderName.Define("parsed");
            var src = RawArchive.Create(rawroot);
            var dst = ParsedArchive.Create(parsedRoot);
            term.print($"There are {src.FileCount} files in the archive");
            
            var inxsFiles = src.InstructionFiles.ToArray();
            term.print($"There are {inxsFiles.Length} instruction files in the source archive");
            
            var patterns = list<PatternOps>();
            foreach(var f in inxsFiles)
            {
                var parsed = parser.ParseInstructions(f);
                var count = parsed.Sum(x => x.Patterns.Length);
                Control.iter(parsed, p => patterns.AddRange(p.Patterns));
                term.print($"Parsed {parsed.Length} instructions from {f} that define {count} instruction patterns");

                dst.Deposit(parsed, f.FileName);
            }

            const string delimit = " | ";
            var sorted = patterns.OrderBy(x => x.Class).ThenBy(x => x.Category).ThenBy(x => x.Extension).ThenBy(x => x.IsaSet).ToArray();
            using var writer = (parsedRoot + FileName.Define("patterns", FileExtensions.Csv)).Writer();
            for(var i=0; i<sorted.Length; i++)
            {
                var p = sorted[i];
                var linear = text.concat(
                    p.Class.PadRight(20), delimit, 
                    p.Category.PadRight(14), delimit, 
                    p.Extension.PadRight(14), delimit, 
                    p.IsaSet.PadRight(14), delimit, 
                    p.PatternText.PadRight(80), delimit, 
                    p.OperandText);
                writer.WriteLine(linear);                
            }
                                    
        }

        public static void Main(params string[] args)
            => Launch(args);
    }



}