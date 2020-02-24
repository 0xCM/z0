//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Linq;
using System.Threading;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using Z0;

partial class zfunc
{

    /// <summary>
    /// Searches for a thread given an OS-assigned id, not the useless clr id
    /// </summary>
    /// <param name="id">The OS thread Id</param>
    [MethodImpl(Inline)]   
    public static Option<ProcessThread> thread(uint id)
        => CurrentProcess.ProcessThread(id);
}
