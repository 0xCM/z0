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

    public static AppMsg errorMsg(object content)
        => AppMsg.Define($"{content}",SeverityLevel.Error);
}