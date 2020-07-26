//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;


    class App : AppShell<App,IAppContext>
    {                
        public App()
            : base(ContextFactory.CreateAppContext())
        {

        }

        
        public override void RunShell(params string[] args)
        {            
            var config = PartFileArchives.configure(Context,args);
            term.print(config);

            var parts = PartIdParser.parse(args);
            if(parts.Length != 0)
                term.magenta($"Capturing {parts.Describe()}");            
            else
                term.magenta($"Capturing the known knowns"); 

            var context = ContextFactory.CreateAsmContext(Context);
            using var host = new CaptureHost(context, config);
            host.Consolidate(parts);
        }

        public static void Main(params string[] args)
            => Launch(args);
    }

    public static partial class XTend { }
}