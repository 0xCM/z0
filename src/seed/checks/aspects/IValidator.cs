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
        Type HostType => GetType();
        
        /// <summary>
        /// Creates, but does not throw, a claim exception
        /// </summary>
        /// <param name="claim">The sort of claim that failed</param>
        /// <param name="msg">The failure description</param>
        ClaimException Failed(ClaimKind claim, IAppMsg msg)    
            => ClaimException.Define(claim, msg);

        /// <summary>
        /// Handles a claim failure by throwing an exception
        /// </summary>
        /// <param name="claim">The sort of claim that failed</param>
        void OnFailure(ClaimKind claim, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw Failed(claim, caller, file,line);

        /// <summary>
        /// Raises an exception if an invariant does not hold
        /// </summary>
        /// <param name="condition">The invariant state</param>
        /// <param name="claim">The sort of claim that failed</param>
        void Require(bool condition, ClaimKind claim, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        {
            if(!condition)
                throw Failed(claim,caller,file,line);
        }

        /// <summary>
        /// Creates, but does not throw, a claim exception
        /// </summary>
        /// <param name="claim">The sort of claim that failed</param>
        ClaimException Failed(ClaimKind claim, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)    
            => Failed(claim, AppMsg.Error("failed", caller, file,line));

        /// <summary>
        /// Fails unconditionally with a message
        /// </summary>
        /// <param name="msg">The failure reason</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        void FailWith(string msg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw Failed(ClaimKind.Fail, AppMsg.Error(msg, caller, file,line));

        void Fail([Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw Failed(ClaimKind.Fail, AppMsg.Error("failed", caller, file,line));
    }

    public interface IValidator<I> : IValidator
        where I : IValidator
    {
        I Validator {get;}
    }

    public interface IValidator<V,I> : IValidator<I>
        where V : struct, IValidator<V,I>, I
        where I : IValidator
    {
        static I Checker => default(V);

        I IValidator<I>.Validator => Checker;
    }
}