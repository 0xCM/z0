//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    /// <summary>
    /// Defines a message that encapsulates application diagnostic/status/error message content
    /// </summary>
    partial class AppMsg
    {
        [MethodImpl(Inline), Op]
        public static AppMsg called(object content, LogLevel kind, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new AppMsg(content, kind, (FlairKind)kind, caller, file, line);
    }
}