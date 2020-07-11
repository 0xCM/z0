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

        public override void RunShell(params string[] args)
        {            
            var parts = PartIdParser.parse(args);
            if(parts.Length != 0)
                term.magenta($"Capturing {parts.Describe()}");            
            else
                term.magenta($"Capturing the known knowns"); 

            var context = ContextFactory.CreateAsmContext(Context);
            using var host = new CaptureHost(context, context.AppPaths.CaptureRoot);
            host.Consolidate(parts);
        }

        public static void Main(params string[] args)
            => Launch(args);
    }
}