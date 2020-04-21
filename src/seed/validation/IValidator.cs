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
        Type ValidatorType => GetType();
        
        /// <summary>
        /// Creates, but does not throw, a claim exception
        /// </summary>
        /// <param name="op">The kind of claim that failed</param>
        /// <param name="msg">The failure description</param>
        ClaimException failed(ClaimKind op, IAppMsg msg)    
            => ClaimException.Define(op, msg);

        /// <summary>
        /// Fails unconditionally with a message
        /// </summary>
        /// <param name="msg">The failure reason</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        void failwith(string msg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw failed(ClaimKind.Fail, AppMsg.Error(msg, caller, file,line));

        void fail([Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw failed(ClaimKind.Fail, AppMsg.Error("failed", caller, file,line));
    }
}