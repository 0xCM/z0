//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    class App
    {

        public static void run(IWfRuntime wf)
            => AgentRunner.run(wf.Signal(typeof(AgentRunner)), wf.Args);

        static void Main(params string[] args)
            => run(Apps.runtime(args));
    }
}