//-----------------------------------------------------------------------------
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Microsoft.Win32.SafeHandles;
    using System.Runtime.InteropServices;
    using System.Security;

    using Z0.MS;
    using Z0.Image;

    partial struct Windows
    {
        partial struct Kernel32
        {
            public const int LOAD_LIBRARY_AS_DATAFILE = 0x00000002;

            public const int LOAD_LIBRARY_SEARCH_SYSTEM32 = 0x00000800;

            [DllImport(WinLibs.Kernel32, CharSet = CharSet.Ansi, BestFitMapping = false), SuppressUnmanagedCodeSecurity]
            public static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

            [DllImport(WinLibs.Kernel32, CharSet = CharSet.Unicode, SetLastError = true), SuppressUnmanagedCodeSecurity]
            public static extern IntPtr LoadLibrary(string libFilename);

            [DllImport(WinLibs.Kernel32, ExactSpelling = true, CharSet = CharSet.Unicode, SetLastError = true), SuppressUnmanagedCodeSecurity]
            public static extern IntPtr LoadLibraryExW([In] string lpwLibFileName, [In] IntPtr hFile, [In] uint dwFlags);

            [DllImport(WinLibs.Kernel32, EntryPoint = "GetModuleHandleW", CharSet = CharSet.Unicode, SetLastError = true), SuppressUnmanagedCodeSecurity]
            public static extern IntPtr GetModuleHandle(string moduleName);

            [DllImport(WinLibs.Kernel32, CharSet = CharSet.Unicode, SetLastError = true, BestFitMapping = false, EntryPoint = "K32GetModuleBaseNameW"), SuppressUnmanagedCodeSecurity]
            public static extern int GetModuleBaseName(IntPtr processHandle, IntPtr moduleHandle, [Out] char[] baseName, int size);

            [DllImport(WinLibs.Kernel32, CharSet = CharSet.Unicode, SetLastError = true, EntryPoint = "K32GetModuleInformation"), SuppressUnmanagedCodeSecurity]
            static extern bool GetModuleInformation(IntPtr processHandle, IntPtr moduleHandle, out NtModuleInfo ntModuleInfo, int size);

            public static unsafe bool GetModuleInformation(IntPtr processHandle, IntPtr moduleHandle, out NtModuleInfo ntModuleInfo)
                => GetModuleInformation(processHandle, moduleHandle, out ntModuleInfo, sizeof(NtModuleInfo));

            /// <summary>
            ///     Frees the loaded dynamic-link library (DLL) module and, if necessary, decrements its reference count. When the
            ///     reference count reaches zero, the module is unloaded from the address space of the calling process and the handle
            ///     is no longer valid.
            /// </summary>
            /// <param name="hModule">
            ///     A handle to the loaded library module. The LoadLibrary, LoadLibraryEx, GetModuleHandle, or
            ///     GetModuleHandleEx function returns this handle.
            /// </param>
            /// <returns>
            ///     If the function succeeds, the return value is a nonzero value.
            ///     <para>
            ///         If the function fails, the return value is zero. To get extended error information, call
            ///         <see cref="GetLastError" />.
            ///     </para>
            /// </returns>
            [DllImport(WinLibs.Kernel32, SetLastError = true), SuppressUnmanagedCodeSecurity]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool FreeLibrary(IntPtr hModule);
        }
    }
}