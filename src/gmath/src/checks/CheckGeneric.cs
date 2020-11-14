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

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;


    public readonly struct CheckGeneric : TCheckGeneric
    {
        [MethodImpl(Inline)]
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

        [MethodImpl(Inline)]
        public static void numeq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => eq<T>(lhs,rhs, caller, file, line);

        [MethodImpl(Inline)]
        public static void neq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
        {
            if(typeof(T) == typeof(Bit32))
                gmath.neq((uint)Bit32.specific(lhs), (uint)Bit32.specific(rhs)).OnNone(() => throw failed(ClaimKind.NEq, Equal(lhs, rhs, caller, file, line)));
            else if(typeof(T).IsPrimalNumeric())
                gmath.neq(lhs,rhs).OnNone(() => throw failed(ClaimKind.NEq, Equal(lhs, rhs, caller, file, line)));
            else
                CheckEqual.Checker.Neq(lhs,rhs);
        }

        [MethodImpl(Inline)]
        public static bool nonzero<T>(T x, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => gmath.nonz(x) ? true : throw AppErrors.NotNonzero(caller,file,line);

        [MethodImpl(Inline)]
        public static bool zero<T>(T x, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => !gmath.nonz(x) ? true : throw AppErrors.NotNonzero(caller,file,line);

        [MethodImpl(Inline)]
        public static bool gt<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => gmath.gt(lhs,rhs) ? true : throw failed(ClaimKind.Gt, NotGreaterThan(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool gteq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => gmath.gt(lhs,rhs) ? true : throw failed(ClaimKind.Gt, NotGreaterThan(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool lt<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => gmath.lt(lhs,rhs) ? true : throw failed(ClaimKind.Lt, NotLessThan(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool lteq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => gmath.lteq(lhs,rhs) ? true : throw failed(ClaimKind.GtEq, NotGreaterThanOrEqual(lhs, rhs, caller, file, line));
    }
}