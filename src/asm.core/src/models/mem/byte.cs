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
        public readonly struct @byte
        {
            public AsmAddress Target {get;}

            public AsmSizeKind Kind => AsmSizeKind.@byte;

            [MethodImpl(Inline)]
            public @byte(AsmAddress dst)
            {
                Target = dst;
            }

            [MethodImpl(Inline)]
            public static implicit operator @byte(AsmAddress dst)
                => new @byte(dst);
        }

        public readonly struct m8 : IMemOp8<m8>
        {
            public AsmAddress Address {get;}

            public AsmSizeKind Qualifier
            {
                [MethodImpl(Inline)]
                get => AsmSizeKind.@byte;
            }

            [MethodImpl(Inline)]
            public m8(AsmAddress address)
            {
                Address = address;
            }

            [MethodImpl(Inline)]
            public static implicit operator m8(AsmAddress src)
                => new m8(src);
        }
    }
}