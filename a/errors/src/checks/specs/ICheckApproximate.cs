//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    using static Core;

    public interface ICheckApproximate : IValidator
    {
       [MethodImpl(Inline)]   
        bool almost(float lhs, float rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Claim.almost(lhs, rhs, caller, file, line);

        [MethodImpl(Inline)]   
        bool almost(double lhs, double rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Claim.almost(lhs, rhs, caller, file, line); 
    }
}