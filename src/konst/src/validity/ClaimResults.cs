//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    [ApiHost]
    public readonly struct ClaimResults
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static RenderPattern<T,ClosedInterval<T>> NotIn<T>()
            where T : unmanaged
                => "not({0} in {1})";

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static RenderPattern<T,T> NotEqual<T>()
            where T : unmanaged
                => "not({0}=={1})";

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static RenderPattern<T,T> NotGreaterThan<T>()
            where T : unmanaged
                => "not({0}>{1})";

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static RenderPattern<T,T> NotLessThan<T>()
            where T : unmanaged
                => "not({0}<{1})";

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static RenderPattern<T,T> NotGreaterThanOrEqual<T>()
            where T : unmanaged
                => "not({0}>={1})";

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static RenderPattern<T,T> NotLessThanOrEqual<T>()
            where T : unmanaged
                => "not({0}<={1})";

        [MethodImpl(Inline), Op]
        public static ClaimResult define(ClaimKind kind, bool success, string message)
            => new ClaimResult(kind,success, message);

        public static ClaimResult<A> define<A>(string identifier, ClaimKind claim, bool success, string message, A a)
            => new ClaimResult<A>(identifier, claim, success, message, a);

        public static ClaimResult<A0,A1> define<A0,A1>(string identifier, ClaimKind claim, bool success, string message, A0 a0, A1 a1)
            => new ClaimResult<A0,A1>(identifier, claim, success, message, a0, a1);

        public static ClaimResult<A0,A1,A2> define<A0,A1,A2>(string identifier, ClaimKind claim, bool success, string message, A0 a0, A1 a1, A2 a2)
            => new ClaimResult<A0,A1,A2>(identifier, claim, success, message, a0, a1, a2);
    }
}