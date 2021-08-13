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
        public readonly struct qword
        {
            public AsmAddress Target {get;}

            public AsmSizeKind Kind => AsmSizeKind.qword;

            [MethodImpl(Inline)]
            public qword(AsmAddress dst)
            {
                Target = dst;
            }

            [MethodImpl(Inline)]
            public static implicit operator qword(AsmAddress dst)
                => new qword(dst);
        }

        public readonly struct m64 : IMemOp64<m64>
        {
            public AsmAddress Address {get;}

            public AsmSizeKind Qualifier
            {
                [MethodImpl(Inline)]
                get => AsmSizeKind.qword;
            }

            [MethodImpl(Inline)]
            public m64(AsmAddress address)
            {
                Address = address;
            }

            [MethodImpl(Inline)]
            public static implicit operator m64(AsmAddress src)
                => new m64(src);
        }
    }
}