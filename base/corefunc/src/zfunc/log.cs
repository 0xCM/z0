//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Z0;

partial class zfunc
{
    /// <summary>
    /// Writes a sequence of messages to a log as a contiguous block
    /// </summary>
    /// <param name="messages">The messages to emit</param>
    /// <param name="dst">The destination log</param>
    public static void log(IEnumerable<AppMsg> messages, LogArea dst)
        => Log.Get(LogTarget.Define(dst)).Write(messages);
}