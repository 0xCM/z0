//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public interface IValidator
    {
        ClaimException failed(ClaimKind op, AppMsg msg)
            => Claim.failed(op,msg);

        void failwith(string msg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Claim.failwith(msg, caller, file, line);

        void fail([Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Claim.fail(caller, file, line);        
    }
}