//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    using static Seed;
    using static AppErrorMsg;    
    
    public readonly struct Claim : ICheck
    {
        public static ICheck Checker => default(Claim);
                    
        public static void eq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        {
            if(!object.Equals(lhs,rhs))
                throw ClaimException.Define(ClaimKind.Eq, NotEqual(lhs,rhs, caller, file, line));
        }            
    }
}