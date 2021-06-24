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
    using G = AsmOpTypes.rK;
    using K = AsmCodes.KReg;
    using api = AsmRegs;

    partial struct AsmOpTypes
    {
        public readonly struct rK : IRegOp64<rK>
        {
            public RegIndex Index {get;}

            [MethodImpl(Inline)]
            public rK(RegIndex index)
            {
                Index = index;
            }

            public string Format()
                => ((K)Index).ToString();

            public override string ToString()
                => Format();

            public RegWidth Width
            {
                [MethodImpl(Inline)]
                get => RegWidth.W64;
            }

            public RegClass RegClass
            {
                [MethodImpl(Inline)]
                get => RegClass.MASK;
            }

            [MethodImpl(Inline)]
            public static implicit operator RegOp(G src)
                => AsmOps.reg(src.Width, src.RegClass, src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(G src)
                => (K)src.Index;

            [MethodImpl(Inline)]
            public static implicit operator G(K src)
                => new G((I)src);

            [MethodImpl(Inline)]
            public static implicit operator G(uint4 src)
                => new G((I)(byte)src);

            [MethodImpl(Inline)]
            public static implicit operator G(I src)
                => new G(src);

            [MethodImpl(Inline)]
            public static explicit operator byte(G src)
                => (byte)src.Index;

            [MethodImpl(Inline)]
            public static implicit operator G(Sym<K> src)
                => new G((I)src.Kind);

            [MethodImpl(Inline)]
            public static G operator ++(G src)
                => api.next(src);

            [MethodImpl(Inline)]
            public static G operator --(G src)
                => api.prior(src);
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