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

    partial class AppMsg
    {
        [MethodImpl(Inline), Op]
        public static AppMsg error(object content, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => define($"{content} {caller} {line} {file}", LogLevel.Error);

        [MethodImpl(Inline), Op]
        public static AppMsg error(Exception e)
            => define(e.ToString(), LogLevel.Error);
    }
}