//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Diagnostics;

    partial class Root
    {
        /// <summary>
        /// Searches for a thread given an OS-assigned id, not the useless clr id
        /// </summary>
        /// <param name="id">The OS thread Id</param>
        [MethodImpl(Inline)]   
        public static Option<ProcessThread> thread(uint id)
            => CurrentProcess.ProcessThread(id);
    }
}