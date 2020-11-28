//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;
    using static AppErrorMsg;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    using R = ClaimResults;

    [ApiHost]
    public readonly struct CheckVectors : ICheckVectors
    {
        public const NumericKind Closure = UnsignedInts;

        // [MethodImpl(Inline), Op, Closures(Closure)]
        // public static ClaimResult<Vector128<T>,Vector128<T>> veq<T>(Vector128<T> lhs, Vector128<T> rhs)
        //     where T : unmanaged
        //         => R.define("veq", ClaimKind.Eq, lhs.Equals(rhs), EmptyString, lhs, rhs);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ClaimResult veq<T>(Vector128<T> a, Vector128<T> b, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => a.Equals(b) ? tripled(ClaimKind.Eq, true, EmptyString) : tripled(ClaimKind.Eq, false, NotEqual(a,b, caller, file, line).Format());

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ClaimResult veq<T>(Vector256<T> lhs, Vector256<T> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => lhs.Equals(rhs) ? tripled(ClaimKind.Eq, true, EmptyString) : tripled(ClaimKind.Eq, false, NotEqual(lhs,rhs, caller, file, line).Format());

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ClaimResult vneq<T>(Vector128<T> a, Vector128<T> b, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => !a.Equals(b) ? tripled(ClaimKind.Eq, true, EmptyString) : tripled(ClaimKind.Eq, false, NotEqual(a,b, caller, file, line).Format());

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ClaimResult vneq<T>(Vector256<T> a, Vector256<T> b, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => !a.Equals(b) ? tripled(ClaimKind.Eq, true, EmptyString) : tripled(ClaimKind.Eq, false, NotEqual(a,b, caller, file, line).Format());

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ClaimResult veq<T>(Vector512<T> a, Vector512<T> b, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => a.Equals(b) ? tripled(ClaimKind.Eq, true, EmptyString) : tripled(ClaimKind.Eq, false, NotEqual(a,b, caller, file, line).Format());

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ClaimResult vneq<T>(Vector512<T> a, Vector512<T> b, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => !a.Equals(b) ? tripled(ClaimKind.Eq, true, EmptyString) : tripled(ClaimKind.Eq, false, NotEqual(a,b, caller, file, line).Format());
    }
}