//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using I = RegIndex;
    using G = AsmOps.rDb;
    using K = AsmRegCodes.DebugReg;


    partial struct AsmOps
    {
        public readonly struct rDb : IRegOp64<r64>
        {
            public RegIndex Index {get;}

            [MethodImpl(Inline)]
            public rDb(RegIndex index)
            {
                Index = index;
            }

            public override string ToString()
                => ((K)Index).ToString();

            [MethodImpl(Inline)]
            public static implicit operator RegOp(G src)
                => new RegOp(RegWidth.W64, RegClass.Debug, src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(G src)
                => (K)src.Index;

            [MethodImpl(Inline)]
            public static implicit operator G(K src)
                => new G((I)src);

            [MethodImpl(Inline)]
            public static implicit operator G(Sym<K> src)
                => new G((I)src.Kind);
        }

    }
}