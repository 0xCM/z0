//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;

using Z0;
using static Z0.Konst;

static class nfunc
{
    /// <summary>
    /// Constructs a natural representative
    /// </summary>
    /// <typeparam name="K">The representative type</typeparam>
    [MethodImpl(Inline)]
    internal static K natrep<K>()
        where K : unmanaged, ITypeNat
            => default;

    /// <summary>
    /// Demands truth that is enforced with an exception upon false
    /// </summary>
    /// <param name="x">The value to test</param>
    [MethodImpl(Inline)]
    internal static bool demand(bool x, string message = null)
        => x ? x : throw new Exception(message ?? "demand failed");
}