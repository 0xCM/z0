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
            var rawArchive = RawArchive.Create(rawroot);
            var parseArchive = ParsedArchive.Create(parsedRoot);
            term.print($"There are {rawArchive.FileCount} files in the archive");
            
            var inxsFiles = rawArchive.InstructionFiles.ToArray();
            term.print($"There are {inxsFiles.Length} instruction files in the archive");
            
            foreach(var f in inxsFiles)
            {
                var parsed = parser.ParseInstructions(f);
                term.print($"Parsed {parsed.Length} instructions from {f}");

                parseArchive.Deposit(parsed, f.FileName);

            }
            //Control.iter(archive.Files, Parse);
                        
        }

        public static void Main(params string[] args)
            => Launch(args);
    }



}