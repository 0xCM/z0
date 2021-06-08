//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using I = RegIndex;
    using G = AsmOps.rCr;
    using K = AsmRegCodes.DebugReg;
    using api = AsmRegs;

    partial struct AsmOps
    {
        public readonly struct rCr : IRegOp64<rCr>
        {
            public RegIndex Index {get;}

            [MethodImpl(Inline)]
            public rCr(RegIndex index)
            {
                Index = index;
            }

            public override string ToString()
                => ((K)Index).ToString();

            public RegWidth Width
            {
                [MethodImpl(Inline)]
                get => RegWidth.W64;
            }

            public RegClass RegClass
            {
                [MethodImpl(Inline)]
                get => RegClass.Control;
            }

            [MethodImpl(Inline)]
            public static implicit operator RegOp(G src)
                => AsmOp.reg(src.Width, src.RegClass, src.Index);

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