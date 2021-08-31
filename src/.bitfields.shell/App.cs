//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    class BitFieldsShell : WfApp<BitFieldsShell>
    {
        public static void Main(params string[] args)
            => run(args, PartId.BitFields, PartId.BitFieldsShell);

        protected override void Run()
        {
            var flow = Wf.Running();
            Wf.Ran(flow);
        }
    }
}