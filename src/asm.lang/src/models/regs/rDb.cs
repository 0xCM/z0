//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmLang;

    using I = RegIndex;
    using G = AsmRegOps.rDb;
    using K = AsmLang.Gp64;

    partial struct AsmRegOps
    {
        public readonly struct rDb : IRegOp64<r64>
        {
            public RegIndex Index {get;}

            [MethodImpl(Inline)]
            public rDb(RegIndex index)
            {
                Index = index;
            }

            [MethodImpl(Inline)]
            public static implicit operator RegOp(G src)
                => new RegOp(RegWidth.W64, RegClass.Debug, src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(G src)
                => (K)src.Index;

            [MethodImpl(Inline)]
            public static implicit operator G(K src)
                => new G((I)src);
        }

    }
}