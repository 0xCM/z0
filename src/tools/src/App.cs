//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

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
                create().Run(wf);
            }
            catch(Exception e)
            {
                term.error(e);
            }
        }

        protected override void Execute(IWfShell wf)
        {
            using var runner = new AppRunner(wf, this);
            runner.Run();
        }
    }


    public static partial class XTend
    {

    }
}