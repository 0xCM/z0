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


    public interface TCheckBit : TValidator
    {
        [MethodImpl(Inline)]
        bool eq(Bit32 lhs, Bit32 rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw Failed(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        bool neq(Bit32 lhs, Bit32 rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs != rhs ? true : throw Failed(ClaimKind.NEq, Equal(lhs, rhs, caller, file, line));
    }
}