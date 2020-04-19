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

    public interface ICheckEquatable : IChecker<CheckEquatable>
    {
        [MethodImpl(Inline)]
        void eq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : IEquatable<T>
        {
            if(!lhs.Equals(rhs))
                throw failed(ClaimKind.Eq, NotEqual(lhs,rhs, caller, file, line));
        }        
    }    

    public readonly struct CheckEquatable : ICheckEquatable
    {                    

    }
}