// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
namespace Windows
{
    using System;
    using System.Runtime.InteropServices;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    partial struct Kernel32
    {
        [DllImport(LibName), Free]
        internal static extern bool ProcessIdToSessionId(uint dwProcessId, out uint pSessionId);

        [DllImport(LibName), Free]
        public static extern int GetProcessId(IntPtr nativeHandle);

        [DllImport(LibName, SetLastError = true, EntryPoint = "K32EnumProcesses"), Free]
        public static extern unsafe bool EnumProcesses(int[] lpidProcess, int cb, out int lpcbNeeded);

        [DllImport(LibName, SetLastError = true), Free]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport(LibName, SetLastError = true), Free]
        public static extern IntPtr GetProcessHeap();

        /// <summary>
        /// Get the OS ID of the current thread
        /// </summary>
        [DllImport(LibName), Free]
        public static extern uint GetCurrentThreadId();

        /// <summary>
        /// Gets the handle of the current thread
        /// </summary>
        [DllImport(LibName), Free]
        public static extern IntPtr GetCurrentThread();
    }
}