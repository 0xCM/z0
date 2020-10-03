//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using I = PrimalBitFieldSpec.SegId;
    using M = PrimalBitFieldSpec.SegMask;
    using P = PrimalBitFieldSpec.SegPos;
    using W = PrimalBitFieldSpec.SegWidth;
    using S = System.Byte;
    using T = System.Byte;

    sealed class Dispatcher : WfHost<Dispatcher>
    {
        protected override void Execute(IWfShell wf)
        {
            var k1 = PrimalKind.I64;
            var description = PrimalKinds.describe(k1);
            var bf = new PrimalBitField<I,P,T,S,W>((byte)k1);
            var id = (PrimalTypeCode)bf[I.KindId];
            var sign = (SignKind)bf[I.Sign];

            var info = $"{id}x{sign}";
            wf.Status(this, info);
        }
    }
}