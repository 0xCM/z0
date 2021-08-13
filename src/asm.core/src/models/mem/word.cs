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
        public readonly struct word
        {
            public AsmAddress Target {get;}

            public AsmSizeKind Kind
                => AsmSizeKind.word;

            [MethodImpl(Inline)]
            public word(AsmAddress reg)
            {
                Target = reg;
            }

            [MethodImpl(Inline)]
            public static implicit operator word(AsmAddress reg)
                => new word(reg);
        }

        public readonly struct m16 : IMemOp16<m16>
        {
            public AsmAddress Address {get;}

            public AsmSizeKind Qualifier
            {
                [MethodImpl(Inline)]
                get => AsmSizeKind.word;
            }

            [MethodImpl(Inline)]
            public m16(AsmAddress address)
            {
                Address = address;
            }

            [MethodImpl(Inline)]
            public static implicit operator m16(AsmAddress src)
                => new m16(src);
        }
    }
}