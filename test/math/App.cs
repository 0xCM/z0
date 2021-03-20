//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public class MathTestApp : TestApp<MathTestApp>
    {
        static PartId[] Parts => root.array(PartId.MathSvc, PartId.Math, PartId.GMath);

        // static void Run(IWfShell wf)
        // {
        //     var flow = wf.Running();

        //     wf.Ran(flow);
        // }

        // static void Main(params string[] args)
        //     => Run(Parts, Run);

        static void Main(params string[] args)
            => Run(Parts, args);
    }
}
