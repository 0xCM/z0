//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct CheckRowVectors : ICheckRowVectors<CheckRowVectors>
    {
        [MethodImpl(Inline)]
        public static int length<T>(RowVector256<T> lhs, RowVector256<T> rhs)
            where T : unmanaged
                => lhs.Length == rhs.Length ? lhs.Length  : AppErrors.ThrowNotEqualNoCaller(lhs.Length, rhs.Length);
    }
}