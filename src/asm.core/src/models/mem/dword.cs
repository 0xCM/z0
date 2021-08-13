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
        public readonly struct dword
        {
            public AsmAddress Target {get;}

            public AsmSizeKind Kind => AsmSizeKind.dword;

            [MethodImpl(Inline)]
            public dword(AsmAddress dst)
            {
                Target = dst;
            }

            [MethodImpl(Inline)]
            public static implicit operator dword(AsmAddress reg)
                => new dword(reg);
        }

        public readonly struct m32 : IMemOp32<m32>
        {
            public AsmAddress Address {get;}

            public AsmSizeKind Qualifier
            {
                [MethodImpl(Inline)]
                get => AsmSizeKind.dword;
            }

            [MethodImpl(Inline)]
            public m32(AsmAddress address)
            {
                Address = address;
            }

            [MethodImpl(Inline)]
            public static implicit operator m32(AsmAddress src)
                => new m32(src);
        }
    }
}