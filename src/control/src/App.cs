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

        }


        void RunCapture(params PartId[] parts)
        {
            using var host = new CaptureHost(ContextFactory.CreateAsmContext(Context), Context.AppPaths.CaptureRoot);
            host.Execute(parts);
        }

        void RunCapture2(params PartId[] parts)
        {
            using var host = new CaptureHost(ContextFactory.CreateAsmContext(Context), Context.AppPaths.CaptureRoot);
            host.Execute2(parts);
        }

        public override void RunShell(params string[] args)
        {            
            var parts = PartIdParser.parse(args);
            term.magenta($"Capturing {parts.Describe()}");            
            //RunCapture(parts);   
            RunCapture2(parts);
        }

        public static void Main(params string[] args)
            => Launch(args);
    }
}