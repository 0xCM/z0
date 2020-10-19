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
    public partial struct z
    {
        [MethodImpl(Inline)]        
        internal static Span<T> EmptySpan<T>()
            => Span<T>.Empty;

        internal static Span<byte> EmptyByteSpan
        {
            [MethodImpl(Inline)]        
            get => Span<byte>.Empty;
        }

        const NumericKind Closure = UnsignedInts;
    }

    public static partial class XTend
    {
        const NumericKind Closure = UnsignedInts;

        const MethodImplOptions MethodOptions = MethodImplOptions.AggressiveInlining;
    }
}