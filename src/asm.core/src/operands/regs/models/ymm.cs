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
    using G = AsmOpTypes.ymm;
    using K = AsmCodes.YmmReg;
    using api = AsmRegs;

    partial struct AsmOpTypes
    {
        public readonly struct ymm : IRegOp256<ymm>
        {
            public RegIndex Index {get;}

            [MethodImpl(Inline)]
            public ymm(RegIndex index)
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
                get => RegWidth.W256;
            }

            public RegClass RegClass
            {
                [MethodImpl(Inline)]
                get => RegClass.YMM;
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