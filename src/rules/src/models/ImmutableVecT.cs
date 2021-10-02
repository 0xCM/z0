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
        public readonly ref struct ImmutableVec<T>
        {
            readonly ReadOnlySpan<T> Data;

            [MethodImpl(Inline)]
            public ImmutableVec(ReadOnlySpan<T> src)
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

            public ref readonly T this[long index]
            {
                [MethodImpl(Inline)]
                get => ref skip(Data,index);
            }

            public ref readonly T this[ulong index]
            {
                [MethodImpl(Inline)]
                get => ref skip(Data,index);
            }

            public ReadOnlySpan<T> Storage
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            [MethodImpl(Inline)]
            public static implicit operator ImmutableVec<T>(T[] src)
                => new ImmutableVec<T>(src);

            [MethodImpl(Inline)]
            public static implicit operator ImmutableVec<T>(Span<T> src)
                => new ImmutableVec<T>(src);

            [MethodImpl(Inline)]
            public static implicit operator ImmutableVec<T>(ReadOnlySpan<T> src)
                => new ImmutableVec<T>(src);

            [MethodImpl(Inline)]
            public static implicit operator ImmutableVec<T>(Vec<T> src)
                => new ImmutableVec<T>(src.Storage);

            [MethodImpl(Inline)]
            public static implicit operator ImmutableVec<T>(SpanVec<T> src)
                => new ImmutableVec<T>(src.Storage);

            public static ImmutableVec<T> Empty => default;
        }

    }
}