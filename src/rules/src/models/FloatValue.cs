//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static Root;

    partial struct Rules
    {
        public readonly struct FloatValue : IBlittable
        {
            public FloatKind Kind {get;}

            readonly byte[] Data;

            [MethodImpl(Inline)]
            public FloatValue(FloatKind kind, byte[] data)
            {
                Kind = kind;
                Data = data;
            }

            public ReadOnlySpan<byte> View
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            public Span<byte> Edit
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            public BitWidth Width
            {
                [MethodImpl(Inline)]
                get => Data.Length*8;
            }
        }
    }
}