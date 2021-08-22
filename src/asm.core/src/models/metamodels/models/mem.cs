//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class AsmMetamodels
    {
        public readonly struct mem : IMemOp<mem>
        {
            public AsmOpClass OpClass => AsmOpClass.M;

            public AsmSizeKind Size {get;}

            [MethodImpl(Inline)]
            public mem(AsmSizeKind size)
            {
                Size = size;
            }

            [MethodImpl(Inline)]
            public static implicit operator operand(mem src)
                => new operand(src.OpClass, src.Size);
        }

        public readonly struct m8 : IMemOp<m8>
        {
            public AsmOpClass OpClass => AsmOpClass.M;

            public AsmSizeKind Size => AsmSizeKind.@byte;

            [MethodImpl(Inline)]
            public static implicit operator mem(m8 src)
                => new mem(src.Size);

            [MethodImpl(Inline)]
            public static implicit operator operand(m8 src)
                => new operand(src.OpClass, src.Size);

        }

        public readonly struct m16 : IMemOp<m16>
        {
            public AsmOpClass OpClass => AsmOpClass.M;

            public AsmSizeKind Size => AsmSizeKind.word;

            [MethodImpl(Inline)]
            public static implicit operator mem(m16 src)
                => new mem(src.Size);

            [MethodImpl(Inline)]
            public static implicit operator operand(m16 src)
                => new operand(src.OpClass, src.Size);
        }


        public readonly struct m32 : IMemOp<m32>
        {
            public AsmOpClass OpClass => AsmOpClass.M;

            public AsmSizeKind Size => AsmSizeKind.dword;

            [MethodImpl(Inline)]
            public static implicit operator mem(m32 src)
                => new mem(src.Size);

            [MethodImpl(Inline)]
            public static implicit operator operand(m32 src)
                => new operand(src.OpClass, src.Size);

        }

        public readonly struct m64 : IMemOp<m64>
        {
            public AsmOpClass OpClass => AsmOpClass.M;

            public AsmSizeKind Size => AsmSizeKind.qword;

            [MethodImpl(Inline)]
            public static implicit operator mem(m64 src)
                => new mem(src.Size);

            [MethodImpl(Inline)]
            public static implicit operator operand(m64 src)
                => new operand(src.OpClass, src.Size);

        }

        public readonly struct m128 : IMemOp<m128>
        {
            public AsmOpClass OpClass => AsmOpClass.M;

            public AsmSizeKind Size => AsmSizeKind.xmmword;

            [MethodImpl(Inline)]
            public static implicit operator mem(m128 src)
                => new mem(src.Size);

            [MethodImpl(Inline)]
            public static implicit operator operand(m128 src)
                => new operand(src.OpClass, src.Size);

        }

        public readonly struct m256 : IMemOp<m256>
        {
            public AsmOpClass OpClass => AsmOpClass.M;

            public AsmSizeKind Size => AsmSizeKind.ymmword;

            [MethodImpl(Inline)]
            public static implicit operator mem(m256 src)
                => new mem(src.Size);

            [MethodImpl(Inline)]
            public static implicit operator operand(m256 src)
                => new operand(src.OpClass, src.Size);
        }

        public readonly struct m512 : IMemOp<m512>
        {
            public AsmOpClass OpClass => AsmOpClass.M;

            public AsmSizeKind Size => AsmSizeKind.zmmword;

            [MethodImpl(Inline)]
            public static implicit operator mem(m512 src)
                => new mem(src.Size);

            [MethodImpl(Inline)]
            public static implicit operator operand(m512 src)
                => new operand(src.OpClass, src.Size);
        }
    }
}