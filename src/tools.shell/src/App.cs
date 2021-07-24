//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    sealed class ToolShell : AppService<ToolShell>
    {
        public void Run()
        {

        }
    }

    class App
    {
        public static void run(string[] args)
            => app(shell(args)).Run();

        static App app(IWfRuntime wf)
            => new App(wf);

        static IWfRuntime shell(string[] args)
            => WfAppLoader.load(args).WithSource(Rng.@default());

        IWfRuntime Wf;

        App(IWfRuntime wf)
        {
            Wf = wf;
        }

        void Run()
        {
            try
            {
                using var shell = ToolShell.create(Wf);
                shell.Run();

            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
        }

        public static void Main(params string[] args)
            => run(args);
    }

    public static partial class XTend {}
}