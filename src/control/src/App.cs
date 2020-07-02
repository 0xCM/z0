//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public static partial class XTend
    {

    }

    class App : AppShell<App,IAppContext>
    {                
        public App()
            : base(ContextFactory.CreateAppContext())
        {
        }

        void SurveyArchive()
        {
            var archive = Archives.Services.CaptureArchive(Context.AppPaths.CaptureRoot);

            Print($"Examining capture archive rooted at {archive.ArchiveRoot}");

            Root.iter(archive.AsmFiles, file => Print(file));            
            Root.iter(archive.HexFiles, file => Print(file));  
            Root.iter(archive.ExtractFiles, file => Print(file));  
            Root.iter(archive.ParseFiles, file => Print(file));              
        }

        void RunCapture(params PartId[] parts)
        {
            using var host = new CaptureHost(ContextFactory.CreateAsmContext(Context), Context.AppPaths.CaptureRoot);
            host.Execute(parts);
        }

        static PartId[] ParseParts(params string[] args)
            => args.Map(arg => Enums.Parse<PartId>(arg).ValueOrDefault()).WhereSome();
        
        public override void RunShell(params string[] args)
        {            
            var parts = PartIdParser.Service.ParseValid(args);
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