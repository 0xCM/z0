//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    public static partial class XTend
    {

    }

    class App : AppShell<App,IAppContext>
    {                
        public App()
            : base(ContextFactory.CreateAppContext())
        {


            var svc = Z0.KnownParts.Service;
            term.print($"Part location: {svc.SearchLocation}");
            term.print($"Part Count: {svc.Parts(svc.ComponentPaths).Length}");

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