//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct AsmOperands
    {
        public readonly struct ymmword
        {
            public AsmAddress Target {get;}

            public AsmSizeKind Kind
                => AsmSizeKind.ymmword;

            [MethodImpl(Inline)]
            public ymmword(AsmAddress reg)
            {
                Target = reg;
            }

            [MethodImpl(Inline)]
            public static implicit operator ymmword(AsmAddress src)
                => new ymmword(src);
        }

        public readonly struct m256 : IMemOp256<m256>
        {
            public AsmAddress Address {get;}

            public AsmSizeKind Qualifier
            {
                [MethodImpl(Inline)]
                get => AsmSizeKind.ymmword;
            }

            [MethodImpl(Inline)]
            public m256(AsmAddress address)
            {
                Address = address;
            }

            [MethodImpl(Inline)]
            public static implicit operator m256(AsmAddress src)
                => new m256(src);
        }
    }
}