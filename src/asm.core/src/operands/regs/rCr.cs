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
    using G = AsmOpTypes.rCr;
    using K = AsmRegCodes.DebugReg;
    using api = AsmRegs;

    partial struct AsmOpTypes
    {
        public readonly struct rCr : IRegOp64<rCr>
        {
            public RegIndex Index {get;}

            [MethodImpl(Inline)]
            public rCr(RegIndex index)
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
                get => RegClass.Control;
            }

            [MethodImpl(Inline)]
            public static implicit operator RegOp(G src)
                => asm.reg(src.Width, src.RegClass, src.Index);

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

        public readonly struct cr0 : IRegOp64<cr0>
        {
            public I Index => I.r0;

            [MethodImpl(Inline)]
            public static implicit operator G(cr0 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(cr0 src)
                => (K)src.Index;
        }

        public readonly struct cr1 : IRegOp64<cr1>
        {
            public I Index => I.r1;

            [MethodImpl(Inline)]
            public static implicit operator G(cr1 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(cr1 src)
                => (K)src.Index;
        }

        public readonly struct cr2 : IRegOp64<cr2>
        {
            public I Index => I.r2;

            [MethodImpl(Inline)]
            public static implicit operator G(cr2 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(cr2 src)
                => (K)src.Index;
        }

        public readonly struct cr3 : IRegOp64<cr3>
        {
            public I Index => I.r3;

            [MethodImpl(Inline)]
            public static implicit operator G(cr3 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(cr3 src)
                => (K)src.Index;
        }

    }
}