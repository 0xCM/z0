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

    public interface ICheckNumericEquality : ICheckEqual
    {
        [MethodImpl(Inline)]
        new void eq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged 
        {
            if(typeof(T) == typeof(bit))
                eq(bit.specific(lhs), bit.specific(rhs));
            else
                gmath.eq(lhs,rhs).OnNone(() => throw failed(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line)));
        }

        [MethodImpl(Inline)]
        new void neq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged 
        {
            if(typeof(T) == typeof(bit))
                neq(bit.specific(lhs), bit.specific(rhs));
            else
                gmath.neq(lhs,rhs).OnNone(() => throw failed(ClaimKind.NEq, Equal(lhs, rhs, caller, file, line)));
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
        bool eq(bit lhs, bit rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        bool neq(bit lhs, bit rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs != rhs ? true : throw failed(ClaimKind.NEq, Equal(lhs, rhs, caller, file, line));
    }
}