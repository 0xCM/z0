//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using I = RegIndexCode;
    using G = AsmOperands.xCr;
    using K = RegTokens.XControlReg;
    using api = AsmRegs;

    partial struct AsmOperands
    {
        public readonly struct xCr : IRegOp64<xCr>
        {
            public RegIndexCode Index {get;}

            [MethodImpl(Inline)]
            public xCr(I index)
            {
                Index = index;
            }

            public string Format()
                => ((K)Index).ToString();

            public override string ToString()
                => Format();

            public RegWidthCode Width
            {
                [MethodImpl(Inline)]
                get => RegWidthCode.W64;
            }

            public RegClassCode RegClass
            {
                [MethodImpl(Inline)]
                get => RegClassCode.XCR;
            }

            [MethodImpl(Inline)]
            public static implicit operator RegOp(G src)
                => api.reg(src.Width, src.RegClass, src.Index);

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
        }
    }
}