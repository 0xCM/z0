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
        public readonly struct m512 : IMemOp512<m512>
        {
            public AsmAddress Address {get;}

            public AsmSizeKind SizeKind
                => AsmSizeKind.zmmword;

            [MethodImpl(Inline)]
            public m512(AsmAddress address)
            {
                Address = address;
            }

            [MethodImpl(Inline)]
            public static implicit operator m512(AsmAddress src)
                => new m512(src);
        }
    }
}