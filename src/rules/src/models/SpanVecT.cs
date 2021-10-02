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

    partial struct RuleModels
    {
        public readonly ref struct SpanVec<T>
        {
            readonly Span<T> Data;

            [MethodImpl(Inline)]
            public SpanVec(Span<T> src)
            {
                Data = src;
            }

            public uint Length
            {
                [MethodImpl(Inline)]
                get => (uint)Data.Length;
            }

            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => Data.IsEmpty;
            }

            public bool IsNonEmpty
            {
                [MethodImpl(Inline)]
                get => !Data.IsEmpty;
            }

            public ref T this[long index]
            {
                [MethodImpl(Inline)]
                get => ref seek(Data,index);
            }

            public ref T this[ulong index]
            {
                [MethodImpl(Inline)]
                get => ref seek(Data,index);
            }

            public Span<T> Storage
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public static implicit operator SpanVec<T>(T[] src)
                => new SpanVec<T>(src);

            [MethodImpl(Inline)]
            public static implicit operator SpanVec<T>(Span<T> src)
                => new SpanVec<T>(src);

            [MethodImpl(Inline)]
            public static implicit operator SpanVec<T>(Vec<T> src)
                => new SpanVec<T>(src.Storage);

            public static SpanVec<T> Empty => default;

        }

    }
}