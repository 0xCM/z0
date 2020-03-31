//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Components;
    
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public interface ICheckNumericEquality : ICheckEquality
    {
        [MethodImpl(Inline)]
        new void eq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged 
                => CheckNumeric.eq(lhs, rhs, caller, file, line);

        [MethodImpl(Inline)]
        new void neq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged 
                => CheckNumeric.neq(lhs, rhs, caller, file, line);

        [MethodImpl(Inline)]
        bool nonzero<T>(T x, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)        
            where T : unmanaged 
                => CheckNumeric.nonzero(x, caller, file, line);

        [MethodImpl(Inline)]
        bool zero<T>(T x, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)        
            where T : unmanaged 
                => CheckNumeric.zero(x, caller, file, line);

        [MethodImpl(Inline)]
        bool eq(bit lhs, bit rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => CheckNumeric.eq(lhs, rhs, caller, file, line);

        [MethodImpl(Inline)]
        bool neq(bit lhs, bit rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => CheckNumeric.neq(lhs, rhs, caller, file, line);
    }
}