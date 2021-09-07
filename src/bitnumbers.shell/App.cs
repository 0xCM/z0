//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    class BitNumbersShell : WfApp<BitNumbersShell>
    {
        public static void Main(params string[] args)
            => run(args, PartId.BitNumbers, PartId.BitNumbersShell);

        protected override void Run()
        {
            var flow = Wf.Running();

            Wf.Ran(flow);
        }
    }
}