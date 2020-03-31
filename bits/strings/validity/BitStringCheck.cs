//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static AppErrorMsg;
    using static Core;
    
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public readonly struct BitStringCheck : IBitStringCheck<BitStringCheck>
    {
        public static IBitStringCheck<BitStringCheck> Checker => default(BitStringCheck);
        
        public static bool neq(BitString lhs, BitString rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => !lhs.Equals(rhs) ? true : throw Checker.failed(ValidityClaim.NEq, Equal(lhs, rhs, caller, file, line));        

        public static bool eq(BitString lhs, BitString rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs.Equals(rhs) ? true : throw Checker.failed(ValidityClaim.Eq, NotEqual(lhs, rhs, caller, file, line));        
    }
}
