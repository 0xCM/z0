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
        public readonly struct zmmword
        {
            public AsmAddress Target {get;}

            public AsmSizeKind Kind
                => AsmSizeKind.zmmword;

            [MethodImpl(Inline)]
            public zmmword(AsmAddress dst)
            {
                Target = dst;
            }

            [MethodImpl(Inline)]
            public static implicit operator zmmword(AsmAddress dst)
                => new zmmword(dst);
        }

        public readonly struct m512 : IMemOp512<m512>
        {
            public AsmAddress Address {get;}

            public AsmSizeKind Qualifier
            {
                [MethodImpl(Inline)]
                get => AsmSizeKind.zmmword;
            }

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