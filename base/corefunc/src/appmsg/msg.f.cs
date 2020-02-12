//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;

using Z0;

partial class zfunc
{
    public static AppMsg appMsg(object content, SeverityLevel level = SeverityLevel.Info)
        => level == SeverityLevel.Warning ? AppMsg.Define($"{content} (warning)",level) : AppMsg.Define($"{content}",level);

    public static AppMsg appMsg(Exception content)
        => AppMsg.Define(content.ToString(), SeverityLevel.Error);

    /// <summary>
    /// Defines an application exception reporting the conent of an application message
    /// </summary>
    /// <param name="msg">The source message</param>
    public static AppException appFail(AppMsg msg)           
        =>  AppException.Define(msg);

}