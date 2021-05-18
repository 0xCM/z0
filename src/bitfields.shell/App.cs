//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    class BitFieldsShell : WfApp<BitFieldsShell>
    {
        public static void Main(params string[] args)
            => run(args, PartId.BitFields, PartId.BitFieldsShell);

        protected override void Run()
        {
            var flow = Wf.Running();
            //CheckCredits.create(Wf).Run();
            var buffer = text.buffer();
            BitMaskChecker.create(Wf).Run(Rng.@default());
            Wf.Ran(flow);
        }
    }
}