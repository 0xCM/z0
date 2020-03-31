//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public interface ICheckEnum : IValidator
    {
        [MethodImpl(Inline)]
        void eq<E>(E lhs, E rhs)
            where E : unmanaged, Enum
                => Enums.u64(lhs).Equals(Enums.u64(rhs));
    }
}