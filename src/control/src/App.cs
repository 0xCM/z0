//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Z0.Asm;

    using static Seed;
    using static Memories;

    class App : ApiShell<App,IApiContext>
    {
        static FolderName CaptureFolder => FolderName.Define("capture");

        static string AppName => Parts.Control.Resolved.Id.Format();

        static RelativeLocation AppSrcLocation => RelativeLocation.Define($"src/{AppName}");

        static RelativeLocation AppDataLocation => RelativeLocation.Define($"apps/{AppName}");

        static FolderPath AppSrc => Env.Current.DevDir + AppSrcLocation;

        static FilePath AppConfig => AppSrc + FileName.Define("config.json");

        static FolderPath AppData => Env.Current.LogDir + AppDataLocation;

        static FolderPath CaptureData => AppData + CaptureFolder;
        
        static IApiContext CreateApiContext()
        {
            var parts = PartSelection.Selected;
            var resolved = ApiComposition.Assemble(parts.Where(r => r.Id != 0));
            var random = Polyrand.Pcg64(PolySeed64.Seed05);                
            var settings = AppSettings.Load(AppConfig);
            return ApiContext.Create(resolved, random, settings);
        }
        
        public App()
            : base(CreateApiContext())
        {
        }
    
        void SurveyArchive()
        {
            var archive = CaptureArchive.Define(CaptureData);

            Print($"Examining capture archive rooted at {archive.RootDir}");

            Control.iter(archive.AsmFiles, file => Print(file));            
            Control.iter(archive.HexFiles, file => Print(file));  
            Control.iter(archive.ExtractFiles, file => Print(file));  
            Control.iter(archive.ParseFiles, file => Print(file));              
            Control.iter(archive.ImmAsmFiles, file => Print(file));  
            Control.iter(archive.ImmHexFiles, file => Print(file));  
        }

        void RunCapture()
        {
            var context = AsmContext.Create(Context.Settings, Part.Known.ToArray());
            var host =  CaptureHost.Create(context,CaptureData);
            host.Execute();            
        }

        void DescribeControl()
        {
            Print("I assemble parts:");
            iter(Context.Parts, part => Print(part));

            Print("I know parts:");
            iter(Part.known(), part => Print(part));

            Print("I am configured with:");
            iter(Context.Settings, setting => Print(setting));

        }

        public override void RunShell(params string[] args)
        {
            RunCapture();            
            SurveyArchive();
        }

        public static void Main(params string[] args)
            => Launch(args);
    }
}