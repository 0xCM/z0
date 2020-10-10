//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using api = EquatableChecks;

    [ApiHost("checks.scalar")]
    public readonly struct ScalarChecks
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref SequenceJudgement<T> eq<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, ref SequenceJudgement<T> dst)
            where T : unmanaged, IEquatable<T>
                => ref api.check(a,b, ref dst);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static SequenceJudgement<T> eq<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b)
            where T : unmanaged, IEquatable<T>
        {
            var dst = SequenceJudgement.alloc<T>((uint)a.Length, true);
            return eq(a,b, ref dst);
        }
    }
}