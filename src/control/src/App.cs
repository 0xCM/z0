//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using Z0.Asm;

    using static Seed;
    using static Memories;

    class App : AppShell<App,IAppContext>
    {        
        static IAppContext CreateApiContext()
        {
            var parts = PartSelection.Selected;
            var resolved = ApiComposition.Assemble(parts.Where(r => r.Id != 0));
            var random = Polyrand.Pcg64(PolySeed64.Seed05);                
            var settings = AppSettings.Load(AppPaths.AppConfigPath);
            var exchange = AppMsgExchange.Create();
            return AppContext.Create(resolved, random, settings, exchange);
        }
        
        public App()
            : base(CreateApiContext())
        {
        }


        IApiComposition Api 
            => ApiComposition.Assemble(KnownParts.Where(r => r.Id != 0));

        FolderPath CaptureRoot => AppPaths.AppCapturePath;

        IAsmContext CreateAsmContext()
            => AsmContext.Create(Context.Settings, Context.Messaging, Api, CaptureRoot);

        ICaptureHost CreateCaptureHost()
            => CaptureHost.Create(CreateAsmContext(), CaptureRoot);

        void SurveyArchive()
        {
            var archive = CaptureArchive.Create(CaptureRoot);

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
            using var host = CreateCaptureHost();
            host.Execute();
        }

        void DescribeControl()
        {
            Print("I assemble parts:");
            iter(Context.Parts, part => Print(part));

            Print("I know parts:");
            iter(KnownParts, part => Print(part));

            Print("I am configured with:");
            iter(Context.Settings, setting => Print(setting));
        }

        public override void RunShell(params string[] args)
        {
            RunCapture();   
            //DescribeControl();         
        }

        public static void Main(params string[] args)
            => Launch(args);
    }
}