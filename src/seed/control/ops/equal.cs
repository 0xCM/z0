//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Control
    {
        [MethodImpl(Inline)]
        public static bool equal<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b)
            where T : IEquatable<T>
                => a.SequenceEqual(b);
    }
}