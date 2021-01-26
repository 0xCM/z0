//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using api = ClaimValidator;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public interface IClaimValidator
    {
        Type HostType => GetType();

        ClaimException Failed(ClaimKind claim, IAppMsg msg)
            => api.exception(claim, msg);

        void Require(bool condition, ClaimKind claim, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => api.require(condition,claim, caller,file,line);

        ClaimException Failed(ClaimKind claim, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => api.exception(claim, AppMsg.error("failed", caller, file,line));

        void FailWith(string msg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => api.fail(msg,caller,file,line);

        void Fail([Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => api.fail(caller,file,line);
    }

    public interface IClaimValidator<V,I> : IClaimValidator
        where V : struct, IClaimValidator<V,I>, I
        where I : IClaimValidator
    {
        I Validator
            => default(V);
    }
}