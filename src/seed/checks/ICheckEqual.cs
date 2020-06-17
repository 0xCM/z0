//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static AppErrorMsg;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public readonly struct CheckEqual : ICheckEqual
    {
        public static ICheckEqual Checker => default(CheckEqual);
    }

    public interface ICheckEqual : IValidator
    {
        void eq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        {
            if(!object.Equals(lhs,rhs))
                throw Failed(ClaimKind.Eq, NotEqual(lhs,rhs, caller, file, line));
        }            

        void neq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        {
            if(object.Equals(lhs,rhs))
                throw Failed(ClaimKind.Eq, NotEqual(lhs,rhs, caller, file, line));
        }            
    }
}