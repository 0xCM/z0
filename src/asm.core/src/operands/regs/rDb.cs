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
    using G = AsmOps.rDb;
    using K = AsmRegCodes.DebugReg;
    using api = AsmRegs;

    partial struct AsmOps
    {
        public readonly struct rDb : IRegOp64<rDb>
        {
            public RegIndex Index {get;}

            [MethodImpl(Inline)]
            public rDb(RegIndex index)
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
                get => RegClass.Debug;
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

        public readonly struct db0 : IRegOp64<db0>
        {
            public I Index => I.r0;

            [MethodImpl(Inline)]
            public static implicit operator G(db0 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(db0 src)
                => (K)src.Index;
        }

        public readonly struct db1 : IRegOp64<db1>
        {
            public I Index => I.r1;

            [MethodImpl(Inline)]
            public static implicit operator G(db1 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(db1 src)
                => (K)src.Index;
        }

        public readonly struct db2 : IRegOp64<db2>
        {
            public I Index => I.r2;

            [MethodImpl(Inline)]
            public static implicit operator G(db2 src)
                => new G(src.Index);

            [MethodImpl(Inline)]
            public static implicit operator K(db2 src)
                => (K)src.Index;
        }
    }
}