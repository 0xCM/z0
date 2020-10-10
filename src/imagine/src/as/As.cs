//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly partial struct AsDeprecated
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline)]
        internal static T[] alloc<T>(int length)
            => new T[length];

        [MethodImpl(Inline)]
        internal static uint size<T>()
            => (uint)Unsafe.SizeOf<T>();

        [MethodImpl(Inline)]
        internal static uint bitsize<T>()
            => (uint)Unsafe.SizeOf<T>() * 8;

        [MethodImpl(Inline)]
        internal static Span<T> EmptySpan<T>()
            => Span<T>.Empty;

        internal static Span<byte> EmptyByteSpan
        {
            [MethodImpl(Inline)]
            get => Span<byte>.Empty;
        }
    }


    [ApiHost]
    public readonly partial struct AsInternal
    {
        const NumericKind Closure = NumericKind.All;
    }
}