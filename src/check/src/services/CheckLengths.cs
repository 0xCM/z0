//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct CheckLengths : TCheckLengths
    {
        [MethodImpl(Inline)]
        public static int length<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            => lhs.Length == rhs.Length ? lhs.Length : AppErrors.ThrowNotEqualNoCaller(lhs.Length, rhs.Length);

        [MethodImpl(Inline)]
        public static int length<T>(T[] lhs, T[] rhs)
            => lhs.Length == rhs.Length ? lhs.Length : AppErrors.ThrowNotEqualNoCaller(lhs.Length, rhs.Length);

        [MethodImpl(Inline)]
        public static int length<T>(Span<T> lhs, Span<T> rhs)
            => lhs.Length == rhs.Length ? lhs.Length : AppErrors.ThrowNotEqualNoCaller(lhs.Length, rhs.Length);
    }
}