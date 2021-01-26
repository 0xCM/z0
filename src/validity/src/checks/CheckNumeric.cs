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
    using static ClaimValidator;
    using static z;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public readonly struct CheckNumeric : ICheckNumeric
    {
        public static ICheckNumeric Checker => default(CheckNumeric);

        const NumericKind Closure = UnsignedInts;

        public static void eq(Bit32 lhs, Bit32 rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => CheckPrimal.eq((uint)lhs, (uint)rhs, caller, file, line);

        public static void eq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
        {
            if(typeof(T).IsPrimalNumeric())
                gmath.eq(lhs,rhs).OnNone(() => throw ClaimException.Define(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line)));
            else
                CheckEqual.Checker.Eq(lhs,rhs);
        }

        public static void neq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
        {
            if(typeof(T).IsPrimalNumeric())
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

        /// <summary>
        /// Asserts content equality for two natural spans of coincident length
        /// </summary>
        /// <param name="a">The left span</param>
        /// <param name="b">The right span</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        public static void eq<N,T>(NatSpan<N,T> a, NatSpan<N,T> b)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => eq(a.Edit,b.Edit);

        /// <summary>
        /// Asserts content equality for two tabular spans of coincident dimension
        /// </summary>
        /// <param name="a">The left span</param>
        /// <param name="b">The right span</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="M">The row dimension type</typeparam>
        /// <typeparam name="N">The column dimension type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        public static void eq<M,N,T>(TableSpan<M,N,T> a, TableSpan<M,N,T> b)
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
            where T : unmanaged
                => eq(a.Data, b.Data);
    }
}