//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct AsmSigTokens
    {
        public readonly struct AddressingMode
        {
            public AddressingModeKind Kind {get;}

            [MethodImpl(Inline)]
            public AddressingMode(AddressingModeKind kind)
            {
                Kind = kind;
            }

            [MethodImpl(Inline)]
            public static implicit operator AddressingMode(AddressingModeKind src)
                => new AddressingMode(src);

            [MethodImpl(Inline)]
            public static implicit operator AddressingModeKind(AddressingMode src)
                => src.Kind;

            [MethodImpl(Inline)]
            public static implicit operator byte(AddressingMode src)
                => (byte)src.Kind;
        }
    }
}