//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static AppErrorMsg;
    using static Validator;
    using static z;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public readonly struct CheckNumeric : TCheckNumeric
    {
        public static TCheckNumeric Checker => default(CheckNumeric);

        const NumericKind Closure = UnsignedInts;

        public static void eq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
        {
            if(typeof(T) == typeof(Bit32))
                gmath.eq((uint)Bit32.specific(lhs), (uint)Bit32.specific(rhs)).OnNone(() => throw ClaimException.Define(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line)));
            else if(typeof(T).IsPrimalNumeric())
                gmath.eq(lhs,rhs).OnNone(() => throw ClaimException.Define(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line)));
            else
                CheckEqual.Checker.Eq(lhs,rhs);
        }

        public static void neq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
        {
            if(typeof(T) == typeof(Bit32))
                gmath.neq((uint)Bit32.specific(lhs), (uint)Bit32.specific(rhs)).OnNone(() => throw exception(ClaimKind.NEq, Equal(lhs, rhs, caller, file, line)));
            else if(typeof(T).IsPrimalNumeric())
                gmath.neq(lhs,rhs).OnNone(() => throw exception(ClaimKind.NEq, Equal(lhs, rhs, caller, file, line)));
            else
                CheckEqual.Checker.Neq(lhs,rhs);
        }

        public static bool nonzero<T>(T x, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => gmath.nonz(x) ? true : throw AppErrors.NotNonzero(caller,file,line);

        public static bool zero<T>(T x, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => !gmath.nonz(x) ? true : throw AppErrors.NotNonzero(caller,file,line);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Outcome contains<T>(ClosedInterval<T> src, T point)
            where T : unmanaged
                => src.Contains(point) ? true : (false, Msg.NotIn<T>().Format(point,src));

        public static bool gt<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => gmath.gt(lhs,rhs) ? true : throw exception(ClaimKind.Gt, NotGreaterThan(lhs, rhs, caller, file, line));

        public static bool gteq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => gmath.gteq(lhs,rhs) ? true : throw exception(ClaimKind.Gt, NotGreaterThan(lhs, rhs, caller, file, line));

        public static bool lt<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => gmath.lt(lhs,rhs) ? true : throw exception(ClaimKind.Lt, NotLessThan(lhs, rhs, caller, file, line));

        public static bool lteq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => gmath.lteq(lhs,rhs) ? true : throw exception(ClaimKind.GtEq, NotGreaterThanOrEqual(lhs, rhs, caller, file, line));

        [Op, Closures(Closure)]
        public static void eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
                => iter(lhs, rhs, (a,b) => eq(a,b));

        [Op, Closures(Closure)]
        public static void eq<T>(Span<T> lhs, Span<T> rhs)
            where T : unmanaged
                => iter(lhs,rhs, (a,b) => eq(a,b));
    }
}