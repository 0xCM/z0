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

    public interface ICheckNumericComparison : IValidator
    {
        [MethodImpl(Inline)]
        bool gt<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => CheckNumeric.gt(lhs,rhs, caller, file, line);

        [MethodImpl(Inline)]
        bool gteq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => CheckNumeric.gteq(lhs,rhs, caller, file, line);
        
        [MethodImpl(Inline)]
        bool lt<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => CheckNumeric.lt(lhs,rhs, caller, file, line);
        
        [MethodImpl(Inline)]
        bool lteq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => CheckNumeric.lteq(lhs,rhs, caller, file, line);
    }
}