//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using api = Validator;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public interface TValidator
    {
        Type HostType => GetType();

        /// <summary>
        /// Creates, but does not throw, a claim exception
        /// </summary>
        /// <param name="claim">The sort of claim that failed</param>
        /// <param name="msg">The failure description</param>
        ClaimException Failed(ClaimKind claim, IAppMsg msg)
            => api.failed(claim, msg);

        /// <summary>
        /// Raises an exception if an invariant does not hold
        /// </summary>
        /// <param name="condition">The invariant state</param>
        /// <param name="claim">The sort of claim that failed</param>
        void Require(bool condition, ClaimKind claim, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => api.require(condition,claim, caller,file,line);

        /// <summary>
        /// Creates, but does not throw, a claim exception
        /// </summary>
        /// <param name="claim">The sort of claim that failed</param>
        ClaimException Failed(ClaimKind claim, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => api.failed(claim, AppMsg.error("failed", caller, file,line));

        /// <summary>
        /// Fails unconditionally with a message
        /// </summary>
        /// <param name="msg">The failure reason</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        void FailWith(string msg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => api.failmsg(msg,caller,file,line);

        void Fail([Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => api.fail(caller,file,line);
    }

    public interface TValidator<V,I> : TValidator
        where V : struct, TValidator<V,I>, I
        where I : TValidator
    {
        I Validator
            => default(V);
    }
}