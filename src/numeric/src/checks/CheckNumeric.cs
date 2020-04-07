//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Seed;
    using static AppErrorMsg;
    
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public readonly struct CheckNumeric : ICheckNumeric<CheckNumeric>
    {
        public static ICheckNumeric<CheckNumeric> Check => default(CheckNumeric);
        
        [MethodImpl(Inline)]
        public static bool eq(bit lhs, bit rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw Check.failed(ValidityClaim.Eq, NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool neq(bit lhs, bit rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs != rhs ? true : throw Check.failed(ValidityClaim.NEq, Equal(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static void eq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged 
        {
            if(typeof(T) == typeof(bit))
                eq(bit.specific(lhs), bit.specific(rhs));
            else
                Numeric.eq(lhs,rhs).OnNone(() => throw Check.failed(ValidityClaim.Eq, NotEqual(lhs, rhs, caller, file, line)));
        }

        [MethodImpl(Inline)]
        public static void neq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged 
        {
            if(typeof(T) == typeof(bit))
                neq(bit.specific(lhs), bit.specific(rhs));
            else
                Numeric.neq(lhs,rhs).OnNone(() => throw Check.failed(ValidityClaim.NEq, Equal(lhs, rhs, caller, file, line)));
        }

        [MethodImpl(Inline)]
        public static bool nonzero<T>(T x, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)        
            where T : unmanaged 
                => Numeric.nonz(x) ? true : throw AppErrors.NotNonzero(caller,file,line);
        
        [MethodImpl(Inline)]
        public static bool zero<T>(T x, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)        
            where T : unmanaged 
                => !Numeric.nonz(x) ? true : throw AppErrors.NotNonzero(caller,file,line);

        [MethodImpl(Inline)]
        public static bool gt<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => Numeric.gt(lhs,rhs) ? true : throw Check.failed(ValidityClaim.Gt, NotGreaterThan(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        public static bool gteq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => Numeric.gteq(lhs,rhs) ? true : throw Check.failed(ValidityClaim.GtEq, NotGreaterThanOrEqual(lhs, rhs, caller, file, line));
        
        [MethodImpl(Inline)]
        public static bool lt<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => Numeric.lt(lhs,rhs) ? true : throw Check.failed(ValidityClaim.Lt, NotLessThan(lhs, rhs, caller, file, line));
        
        [MethodImpl(Inline)]
        public static bool lteq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => Numeric.lteq(lhs,rhs) ? true : throw Check.failed(ValidityClaim.GtEq, NotGreaterThanOrEqual(lhs, rhs, caller, file, line));

        public static void eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged 
                => Spans.iter(lhs, rhs, (a,b) => eq(a,b, caller,file,line));

        public static void eq<T>(Span<T> lhs, Span<T> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged             
                => Spans.iter(lhs,rhs, (a,b) => eq(a,b, caller,file,line));
    }
}