//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static AppErrorMsg;
    using static ClaimValidator;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public readonly struct NumericClaims : ICheckNumeric
    {
        public static ICheckNumeric Checker => default(NumericClaims);

        const NumericKind Closure = UnsignedInts;

        public static void eq(Bit32 lhs, Bit32 rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => PrimalClaims.eq((uint)lhs, (uint)rhs, caller, file, line);

        public static void eq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
        {
            if(typeof(T).IsPrimalNumeric())
                gmath.eq(lhs,rhs).OnNone(() => throw ClaimException.define(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line).Format()));
            else
                CheckEqual.Checker.Eq(lhs,rhs);
        }

        public static void neq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
        {
            if(typeof(T).IsPrimalNumeric())
                gmath.neq(lhs,rhs).OnNone(() => throw failed(ClaimKind.NEq, Equal(lhs, rhs, caller, file, line)));
            else
                CheckEqual.Checker.Neq(lhs,rhs);
        }

        public static bool nonzero<T>(T x, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => gmath.nonz(x) ? true : throw AppErrors.NotNonzero(caller,file,line);

        public static bool zero<T>(T x, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => !gmath.nonz(x) ? true : throw AppErrors.NotNonzero(caller,file,line);

        public static bool gt<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => gmath.gt(lhs,rhs) ? true : throw failed(ClaimKind.Gt, NotGreaterThan(lhs, rhs, caller, file, line));

        public static bool gteq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => gmath.gteq(lhs,rhs) ? true : throw failed(ClaimKind.Gt, NotGreaterThan(lhs, rhs, caller, file, line));

        public static bool lt<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => gmath.lt(lhs,rhs) ? true : throw failed(ClaimKind.Lt, NotLessThan(lhs, rhs, caller, file, line));

        public static bool lteq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => gmath.lteq(lhs,rhs) ? true : throw failed(ClaimKind.GtEq, NotGreaterThanOrEqual(lhs, rhs, caller, file, line));
    }
}