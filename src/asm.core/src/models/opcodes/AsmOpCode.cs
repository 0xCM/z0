//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public struct AsmOpCode
    {
        uint Literal;

        uint Field;

        [MethodImpl(Inline)]
        public AsmOpCode(uint literal, uint field)
        {
            Literal = literal;
            Field = field;
        }

        public ref byte Lead
        {
            [MethodImpl(Inline)]
            get => ref seek(Bytes,0);
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Field == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Field != 0;
        }

        Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => slice(bytes(Field),0, 3);
        }

        public static AsmOpCode Empty
            => default;
    }
}