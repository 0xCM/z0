//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static Seed;
    using static Memories;

    class App : ApiShell<App,IApiContext>
    {
        static FolderPath AppDir => Env.Current.DevDir + RelativeLocation.Define("src/control");

        static FolderPath CaptureDir => Env.Current.LogDir + RelativeLocation.Define("test/data/ValidationHost");

        static IApiContext CreateContext()
        {
            var src = AppDir + FileName.Define("config.json");        
            var parts = PartSelection.Selected;
            var resolved = ApiComposition.Assemble(parts.Where(r => r.Id != 0));
            var random = Polyrand.Pcg64(PolySeed64.Seed05);                
            var settings = AppSettings.Load(src);
            return ApiContext.Create(resolved, random, settings);
        }
        
        public App()
            : base(CreateContext())
        {
            Archive = CaptureArchive.Define(CaptureDir);
        }

        
        readonly ICaptureArchive Archive;

        bool Verbose => false;


        void SurveyArchive()
        {
            Print($"Examining capture archive rooted at {Archive.RootDir}");

            Control.iter(Archive.AsmFiles, file => Print(file));            
            Control.iter(Archive.HexFiles, file => Print(file));  
            Control.iter(Archive.ExtractFiles, file => Print(file));  
            Control.iter(Archive.ParseFiles, file => Print(file));              
            Control.iter(Archive.ImmAsmFiles, file => Print(file));  
            Control.iter(Archive.ImmHexFiles, file => Print(file));  
        }

        public override void RunShell(params string[] args)
        {
            Print("Executing control");

            SurveyArchive();            

            if(Verbose)
            {
                Print("I assemble parts:");
                iter(Context.Parts, part => Print(part));

                Print("I know parts:");
                iter(Part.known(), part => Print(part));

                Print("I am configured with:");
                iter(Context.Settings, setting => Print(setting));
            }
        }

        public static void Main(params string[] args)
            => Launch(args);
    }
}