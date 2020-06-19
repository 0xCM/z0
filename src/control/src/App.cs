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
    using static Memories;

    public static partial class XTend
    {

    }

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
            => new CaptureHost(CreateAsmContext(), CaptureRoot);

        void SurveyArchive()
        {
            var archive = Archives.Services.CaptureArchive(CaptureRoot);

            Print($"Examining capture archive rooted at {archive.ArchiveRoot}");

            Control.iter(archive.AsmFiles, file => Print(file));            
            Control.iter(archive.HexFiles, file => Print(file));  
            Control.iter(archive.ExtractFiles, file => Print(file));  
            Control.iter(archive.ParseFiles, file => Print(file));              
            // Control.iter(archive.AsmImmFiles, file => Print(file));  
            // Control.iter(archive.HexImmFiles, file => Print(file));  
        }

        void RunCapture(params PartId[] parts)
        {
            using var host = CreateCaptureHost();
            host.Execute(parts);
        }

        void DescribeControl(params string[] args)
        {
            var parts = ParseParts(args);    
            iter(parts, part => Print($"The {part} part was supplied via command-line"));        

            void Detail()
            {
                Print("I assemble parts:");
                iter(Context.Parts, part => Print(part));

                Print("I know parts:");
                iter(KnownParts, part => Print(part));

                Print("I am configured with:");                
                iter(Context.Settings, setting => Print(setting));
            }
        }

        static PartId[] ParseParts(params string[] args)
            => args.Map(arg => Enums.Parse<PartId>(arg).ValueOrDefault()).WhereSome();
        
        public override void RunShell(params string[] args)
        {            
            var parts = PartParser.Service.ParseValid(args);
            if(parts.Length != 0)
            {
                var describe = parts.Map(p => p.Format()).Concat(Chars.Comma);
                Context.NotifyConsole($"Constraining capture workflow to: {describe}");
            }
            
            RunCapture(parts);   
        }

        public static void Main(params string[] args)
            => Launch(args);
    }
}