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

    using static Enums;

    public readonly struct CheckEnum : ICheckEnum
    {
        public static ICheckEnum Checker => default(CheckEnum);
    }

    public interface ICheckEnum : IValidator<CheckEnum,ICheckEnum>
    {        
        [MethodImpl(Inline)]
        void eq<E>(E lhs, E rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where E : unmanaged, Enum
        {
            if(!u64(lhs).Equals(u64(rhs)))
                throw Failed(ClaimKind.Eq, NotEqual(lhs,rhs, caller, file, line));
        }
    }
}