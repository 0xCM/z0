//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    sealed class App : WfHost<App>
    {
        public App()
        {

        }

        public static void Main(params string[] args)
        {
            try
            {
                using var wf = Polyrand.install(WfShell.create(args));
                using var runner = new Runner(wf);
                runner.Run();
            }
            catch(Exception e)
            {
                term.error(e);
            }
        }
    }

    public static partial class XTend { }
}