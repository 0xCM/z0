//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System.Reflection;
using System;
using Z0;

using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

[ApiType]
struct Msg
{
    static RenderPattern<S,Type> TransformFailedPattern<S>()
        => "The transformation {0}->{1} failed";

    public static IAppMsg TransformFailed<S,T>(S src, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        => AppMsg.error(TransformFailedPattern<S>().Format(src, typeof(T)), caller, file, line);
}