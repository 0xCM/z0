//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct Rules
    {
        public readonly ref struct SpanVecs<T>
        {
            readonly Span<T> Data;

            public uint Count {get;}

            public uint Dim {get;}

            [MethodImpl(Inline)]
            public SpanVecs(Span<T> src, uint count)
            {
                Data = src;
                Count = count;
                Dim = (uint)src.Length/count;
            }

            internal Span<T> Storage
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            public SpanVec<T> this[ulong index]
            {
                [MethodImpl(Inline)]
                get => vec(this, (uint)index);
            }

            public SpanVec<T> this[long index]
            {
                [MethodImpl(Inline)]
                get => vec(this, (uint)index);
            }
        }
    }
}