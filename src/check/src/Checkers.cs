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

    public readonly struct Checkers
    {
        public static ClaimException exception(ClaimKind claim, IAppMsg msg)
            => api.exception(claim, msg);

        public static ClaimException exception(ClaimKind claim, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => api.exception(claim, AppMsg.error("failed", caller, file,line));

        public static void require(bool condition, ClaimKind claim, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => api.require(condition,claim, caller,file,line);

        public static void fail(string msg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => api.fail(msg,caller,file,line);

        public static void fail([Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => api.fail(caller,file,line);
    }
}