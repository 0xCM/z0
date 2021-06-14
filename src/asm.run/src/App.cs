//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    struct Machine
    {
        public static void run(string[] args)
            => app(shell(args)).Run();

        static Machine app(IWfRuntime wf)
            => new Machine(wf);

        static IWfRuntime shell(string[] args)
            => WfAppLoader.load(args).WithSource(Rng.@default());

        IWfRuntime Wf;

        Machine(IWfRuntime wf)
        {
            Wf = wf;
        }

        void Run()
        {
            try
            {

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