//-----------------------------------------------------------------------------
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Security;

    partial struct Windows
    {
        partial struct Kernel32
        {
            /// <summary>
            /// Retrieves a pseudo handle for the calling thread.
            /// </summary>
            /// <returns>The return value is a pseudo handle for the current thread.</returns>
            /// <remarks>
            /// A pseudo handle is a special constant that is interpreted as the current thread handle. The calling thread can use this handle to specify itself
            /// whenever a thread handle is required. Pseudo handles are not inherited by child processes.
            ///
            /// This handle has the THREAD_ALL_ACCESS access right to the thread object.
            ///
            /// Windows Server 2003 and Windows XP:  This handle has the maximum access allowed by the security descriptor of the thread to the primary token of
            /// the process.
            ///
            /// The function cannot be used by one thread to create a handle that can be used by other threads to refer to the first thread.The handle is always
            /// interpreted as referring to the thread that is using it.A thread can create a "real" handle to itself that can be used by other threads, or
            /// inherited by other processes, by specifying the pseudo handle as the source handle in a call to the DuplicateHandle function.
            ///
            /// The pseudo handle need not be closed when it is no longer needed.Calling the <see cref="CloseHandle(IntPtr)"/> function with this handle has no effect. If the pseudo
            /// handle is duplicated by DuplicateHandle, the duplicate handle must be closed.
            ///
            /// Do not create a thread while impersonating a security context. The call will succeed, however the newly created thread will have reduced access
            /// rights to itself when calling GetCurrentThread.The access rights granted this thread will be derived from the access rights the impersonated user
            /// has to the process.Some access rights including THREAD_SET_THREAD_TOKEN and THREAD_GET_CONTEXT may not be present, leading to unexpected failures.
            /// </remarks>
            [DllImport(WinLibs.Kernel32), SuppressUnmanagedCodeSecurity]
            public static extern IntPtr GetCurrentThread();

            /// <summary>
            /// Retrieves the thread identifier of the calling thread.
            /// </summary>
            /// <returns>The thread identifier of the calling thread.</returns>
            [DllImport(WinLibs.Kernel32), SuppressUnmanagedCodeSecurity]
            public static extern int GetCurrentThreadId();

            /// <summary>Retrieves the process identifier of the calling process.</summary>
            /// <returns>The process identifier of the calling process.</returns>
            /// <remarks>Until the process terminates, the process identifier uniquely identifies the process throughout the system.</remarks>
            [DllImport(WinLibs.Kernel32), SuppressUnmanagedCodeSecurity]
            public static extern int GetCurrentProcessId();

            /// <summary>
            /// Retrieves the process identifier of the specified process.
            /// </summary>
            /// <param name="Process">A handle to the process. The handle must have the PROCESS_QUERY_INFORMATION or PROCESS_QUERY_LIMITED_INFORMATION access right. For more information, see Process Security and Access Rights.</param>
            /// <returns>The process identifier of the specified process.</returns>
            [DllImport(WinLibs.Kernel32), SuppressUnmanagedCodeSecurity]
            public static extern int GetProcessId(IntPtr Process);

            [DllImport(WinLibs.Kernel32, SetLastError = true)]
            public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

            /// <summary>Retrieves a pseudo handle for the current process.</summary>
            /// <returns>The return value is a pseudo handle to the current process.</returns>
            /// <remarks>
            ///     A pseudo handle is a special constant, currently (HANDLE)-1, that is interpreted as the current process handle. For
            ///     compatibility with future operating systems, it is best to call GetCurrentProcess instead of hard-coding this
            ///     constant value. The calling process can use a pseudo handle to specify its own process whenever a process handle is
            ///     required. Pseudo handles are not inherited by child processes.
            ///     <para>This handle has the PROCESS_ALL_ACCESS access right to the process object.</para>
            ///     <para>
            ///         Windows Server 2003 and Windows XP:  This handle has the maximum access allowed by the security descriptor of
            ///         the process to the primary token of the process.
            ///     </para>
            ///     <para>
            ///         A process can create a "real" handle to itself that is valid in the context of other processes, or that can
            ///         be inherited by other processes, by specifying the pseudo handle as the source handle in a call to the
            ///         DuplicateHandle function. A process can also use the OpenProcess function to open a real handle to itself.
            ///     </para>
            ///     <para>
            ///         The pseudo handle need not be closed when it is no longer needed. Calling the <see cref="CloseHandle" />
            ///         function with a pseudo handle has no effect.If the pseudo handle is duplicated by DuplicateHandle, the
            ///         duplicate handle must be closed.
            ///     </para>
            /// </remarks>
            [DllImport(WinLibs.Kernel32), SuppressUnmanagedCodeSecurity]
            public static extern IntPtr GetCurrentProcess();

            /// <summary>
            /// Flushes the instruction cache for the specified process.
            /// </summary>
            /// <param name="hProcess">A handle to a process whose instruction cache is to be flushed.</param>
            /// <param name="lpcBaseAddress">A pointer to the base of the region to be flushed. This parameter can be null.</param>
            /// <param name="dwSize">The size of the region to be flushed if the <paramref name="lpcBaseAddress"/> parameter is not null, in bytes.</param>
            /// <returns>
            /// If the function succeeds, the return value is nonzero.
            /// If the function fails, the return value is zero.To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            /// <remarks>
            /// Applications should call <see cref="FlushInstructionCache(SafeObjectHandle, void*, UIntPtr)"/> if they generate or modify code in memory.
            /// The CPU cannot detect the change, and may execute the old code it cached.
            /// </remarks>
            [DllImport(WinLibs.Kernel32, SetLastError = true), SuppressUnmanagedCodeSecurity]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static unsafe extern bool FlushInstructionCache(SafeObjectHandle hProcess, void* lpcBaseAddress, UIntPtr dwSize);


            [DllImport(WinLibs.Kernel32), SuppressUnmanagedCodeSecurity]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool IsWow64Process(IntPtr hProcess, out bool isWow64);

        }
    }
}