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
    
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public readonly struct CheckGeneric : ICheckGeneric
    {
        public static ICheckGeneric Checker => default(CheckGeneric);
    }

    public interface ICheckGeneric : IValidator
    {
        [MethodImpl(Inline)]
        void eq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged 
        {
            if(typeof(T) == typeof(bit))
                gmath.eq((uint)bit.specific(lhs), (uint)bit.specific(rhs)).OnNone(() => throw Failed(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line)));
            else if(typeof(T).IsPrimalNumeric())
                gmath.eq(lhs,rhs).OnNone(() => throw Failed(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line)));
            else
                CheckEqual.Checker.eq(lhs,rhs);
        }

        [MethodImpl(Inline)]
        void numeq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged 
                => eq<T>(lhs,rhs, caller, file, line);

        [MethodImpl(Inline)]
        void neq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged 
        {
            if(typeof(T) == typeof(bit))
                gmath.neq((uint)bit.specific(lhs), (uint)bit.specific(rhs)).OnNone(() => throw Failed(ClaimKind.NEq, Equal(lhs, rhs, caller, file, line)));
            else if(typeof(T).IsPrimalNumeric())
                gmath.neq(lhs,rhs).OnNone(() => throw Failed(ClaimKind.NEq, Equal(lhs, rhs, caller, file, line)));
            else
                CheckEqual.Checker.neq(lhs,rhs);
        }

        [MethodImpl(Inline)]
        bool nonzero<T>(T x, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)        
            where T : unmanaged 
                => gmath.nonz(x) ? true : throw AppErrors.NotNonzero(caller,file,line);

        [MethodImpl(Inline)]
        bool zero<T>(T x, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)        
            where T : unmanaged 
                => !gmath.nonz(x) ? true : throw AppErrors.NotNonzero(caller,file,line);

        [MethodImpl(Inline)]
        bool gt<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => gmath.gt(lhs,rhs) ? true : throw Failed(ClaimKind.Gt, NotGreaterThan(lhs, rhs, caller, file, line));        

        [MethodImpl(Inline)]
        bool gteq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => gmath.gt(lhs,rhs) ? true : throw Failed(ClaimKind.Gt, NotGreaterThan(lhs, rhs, caller, file, line));
        
        [MethodImpl(Inline)]
        bool lt<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => gmath.lt(lhs,rhs) ? true : throw Failed(ClaimKind.Lt, NotLessThan(lhs, rhs, caller, file, line));
        
        [MethodImpl(Inline)]
        bool lteq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => gmath.lteq(lhs,rhs) ? true : throw Failed(ClaimKind.GtEq, NotGreaterThanOrEqual(lhs, rhs, caller, file, line));
    }
}