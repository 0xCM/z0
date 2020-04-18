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
        static IApiContext CreateApiContext()
        {
            var parts = PartSelection.Selected;
            var resolved = ApiComposition.Assemble(parts.Where(r => r.Id != 0));
            var random = Polyrand.Pcg64(PolySeed64.Seed05);                
            var settings = AppSettings.Load(AppPaths.AppConfigPath);
            var exchange = AppMessages.exchange();
            return ApiContext.Create(resolved, random, settings, exchange);
        }
        
        public App()
            : base(CreateApiContext())
        {
        }

        IAsmContext CreateAsmContext()
            => AsmContext.Create(Context.Settings, Context.Messaging, KnownParts.ToArray());

        ICaptureHost CreateCaptureHost()
            => CaptureHost.Create(CreateAsmContext(), AppPaths.CaptureDataPath);

        void SurveyArchive()
        {
            var archive = CaptureArchive.Define(AppPaths.CaptureDataPath);

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
            CreateCaptureHost().Execute();            
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
        }

        public static void Main(params string[] args)
            => Launch(args);
    }
}