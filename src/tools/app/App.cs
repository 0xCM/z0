//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static z;

    sealed class App : WfHost<App>
    {
        public App()
        {

        }

        public static void Main(params string[] args)
        {
            try
            {
                using var wf = WfShell.create(args);
                using var runner = new AppRunner(wf, App.create());
                runner.Run();
            }
            catch(Exception e)
            {
                term.error(e);
            }
        }
    }

    ref struct AppRunner
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        public AppRunner(IWfShell wf, WfHost host)
        {
            Host = host;
            Wf = wf;
        }

        public void Run()
        {
            var steps = Wf.Steps();
            steps.Run(typeof(EmitRenderPatterns));

            var resources = @readonly(Resources.describe(Wf.Controller));
            var count = resources.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var res = ref skip(resources,i);
                Wf.Row(res);
            }
        }


        public void Dispose()
        {

        }
    }

    public static partial class XTend { }
}