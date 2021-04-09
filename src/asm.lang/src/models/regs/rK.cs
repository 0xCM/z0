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
    using G = AsmOps.rK;
    using K = AsmLang.KReg;

    partial struct AsmOps
    {
        public readonly struct rK : IRegOp64<rK>
        {
            public RegIndex Index {get;}

            [MethodImpl(Inline)]
            public rK(RegIndex index)
            {
                Index = index;
            }

            [MethodImpl(Inline)]
            public static implicit operator RegOp(G src)
                => new RegOp(RegWidth.W64, RegClass.Mask, src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(G src)
                => (K)src.Index;

            [MethodImpl(Inline)]
            public static implicit operator G(K src)
                => new G((I)src);
        }

        public readonly struct k0 : IRegOp64<k0>
        {
            public I Index => I.r0;

            [MethodImpl(Inline)]
            public static implicit operator G(k0 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(k0 src)
                => (K)src.Index;
        }

        public readonly struct k1 : IRegOp64<k1>
        {
            public I Index => I.r1;

            [MethodImpl(Inline)]
            public static implicit operator G(k1 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(k1 src)
                => (K)src.Index;
        }

        public readonly struct k2 : IRegOp64<k2>
        {
            public I Index => I.r2;

            [MethodImpl(Inline)]
            public static implicit operator G(k2 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(k2 src)
                => (K)src.Index;
        }

        public readonly struct k3 : IRegOp64<k3>
        {
            public I Index => I.r2;

            [MethodImpl(Inline)]
            public static implicit operator G(k3 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(k3 src)
                => (K)src.Index;
        }

    }
}