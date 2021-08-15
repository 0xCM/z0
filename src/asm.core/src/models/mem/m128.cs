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
        public readonly struct m128 : IMemOp128<m128>
        {
            public AsmAddress Address {get;}

            public AsmSizeKind SizeKind
                => AsmSizeKind.xmmword;

            [MethodImpl(Inline)]
            public m128(AsmAddress address)
            {
                Address = address;
            }

            [MethodImpl(Inline)]
            public static implicit operator m128(AsmAddress src)
                => new m128(src);
        }
    }
}