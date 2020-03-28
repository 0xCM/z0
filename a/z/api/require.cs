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

    partial class Root
    {
        public static void require(bool test, string info = null, [Caller] string caller = null, [File] string file = null,  [Line] int? line = null)
            => AppErrors.ThrowIfFalse(test, info, caller, file, line);
    }
}