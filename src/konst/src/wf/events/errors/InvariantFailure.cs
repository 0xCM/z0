//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    partial class AppErrors
    {
        public static AppException InvariantFailure(object description, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(AppErrorMsg.InvariantFailure(description, caller, file, line));

        public static void ThrowInvariantFailure(object description, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw InvariantFailure(description, caller, file, line);

        public static void ThrowIfFalse(bool test, object msg = null, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        {
            if(!test)
                ThrowInvariantFailure(msg, caller, file, line);
        }
    }
}