//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Security;

    using static Memories;

    /// <summary>
    /// Surfaces information about the currently executing process
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    public static class CurrentProcess
    {
        public static Process Current => Process.GetCurrentProcess();

        /// <summary>
        /// Gets the OS thread ID, not the "ManagedThreadId" which is useless
        /// </summary>
        public static uint CurrentThreadId => GetCurrentThreadId();

        /// <summary>
        /// The handle for the current process
        /// </summary>
        public static IntPtr Handle => Current.Handle;

        public static string Name => Current.ProcessName;

        public static IEnumerable<ProcessThread> Threads 
            => from ProcessThread pt in Current.Threads select pt;

        /// <summary>
        /// Searches for a thread given an OS-assigned id, not the useless clr id
        /// </summary>
        /// <param name="id">The OS thread Id</param>
        [MethodImpl(Inline)]   
        public static ProcessThread ProcessThread(uint id)
            => Threads.FirstOrDefault(t => t.Id == id);

        /// <summary>
        /// Get the OS ID of the current thread
        /// </summary>
        [DllImport(Kernel32)]
        static extern uint GetCurrentThreadId();

        /// <summary>
        /// Gets the handle of the current thread
        /// </summary>
        [DllImport(Kernel32)]
        static extern IntPtr GetCurrentThread();
    }
}