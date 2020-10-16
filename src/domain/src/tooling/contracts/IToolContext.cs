//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IToolContext : ICorrelated
    {
        IShellPaths Paths {get;}

        string ProcessName
            => CurrentProcess.Name;

        int ProcessId
            => CurrentProcess.ProcessId;

        uint OsThreadId
            => CurrentProcess.OsThreadId;

        int ManagedThreadId
            => CurrentProcess.ManagedThreadId;
    }
}