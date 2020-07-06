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

    using static Enums;

    public readonly struct CheckEnum : ICheckEnum
    {
        public static ICheckEnum Checker => default(CheckEnum);
    }

    public interface ICheckEnum : TValidator<CheckEnum,ICheckEnum>
    {        
        [MethodImpl(Inline)]
        void eq<E>(E lhs, E rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where E : unmanaged, Enum
        {
            if(!e64u(lhs).Equals(e64u(rhs)))
                throw Failed(ClaimKind.Eq, NotEqual(lhs,rhs, caller, file, line));
        }
    }
}