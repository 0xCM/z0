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
    using G = AsmOps.zmm;
    using K = AsmRegCodes.ZmmReg;
    using api = AsmRegs;

    partial struct AsmOps
    {
        public readonly struct zmm : IRegOp256<zmm>
        {
            public RegIndex Index {get;}

            [MethodImpl(Inline)]
            public zmm(RegIndex index)
            {
                Index = index;
            }

            public override string ToString()
                => ((K)Index).ToString();

            public RegWidth Width
            {
                [MethodImpl(Inline)]
                get => RegWidth.W512;
            }

            public RegClass RegClass
            {
                [MethodImpl(Inline)]
                get => RegClass.ZMM;
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
            public static implicit operator G(I src)
                => new G(src);

            [MethodImpl(Inline)]
            public static G operator ++(G src)
                => api.next(src);

            [MethodImpl(Inline)]
            public static G operator --(G src)
                => api.prior(src);
        }
    }
}