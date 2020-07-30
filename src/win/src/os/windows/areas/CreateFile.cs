//-----------------------------------------------------------------------------
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//-----------------------------------------------------------------------------
namespace Z0
{
    using Microsoft.Win32.SafeHandles;
    using System;
    using System.IO;
    using System.Runtime.InteropServices;
    using System.Diagnostics;

    using Z0.MS;

    partial struct Windows
    {
        partial struct Kernel32
        {            
            // [DllImport(Libraries.Kernel32, SetLastError = true, ExactSpelling = true)]
            // public static extern UIntPtr VirtualQuery(SafeHandle lpAddress, ref MEMORY_BASIC_INFORMATION lpBuffer, UIntPtr dwLength);

            // [DllImport(Libraries.Kernel32, SetLastError = true, ExactSpelling = true)]
            // public static extern unsafe UIntPtr VirtualQuery(void* lpAddress, ref MEMORY_BASIC_INFORMATION lpBuffer, UIntPtr dwLength);

            /// <summary>
            /// WARNING: This method does not implicitly handle long paths. Use CreateFile.
            /// </summary>
            [DllImport(Dll, EntryPoint = "CreateFileW", SetLastError = true, CharSet = CharSet.Unicode, BestFitMapping = false, ExactSpelling = true)]
            public static extern unsafe IntPtr CreateFilePrivate_IntPtr(string lpFileName, int dwDesiredAccess, FileShare dwShareMode,
                SECURITY_ATTRIBUTES* lpSecurityAttributes, FileMode dwCreationDisposition, int dwFlagsAndAttributes, IntPtr hTemplateFile);            
            
            public static unsafe IntPtr CreateFile_IntPtr(string lpFileName, int dwDesiredAccess, FileShare dwShareMode,
                FileMode dwCreationDisposition, int dwFlagsAndAttributes)
            {
                lpFileName = PathUtilities.EnsureExtendedPrefixIfNeeded(lpFileName);
                return CreateFilePrivate_IntPtr(lpFileName, dwDesiredAccess, dwShareMode, null, dwCreationDisposition, dwFlagsAndAttributes, IntPtr.Zero);
            }

            /// <summary>
            /// WARNING: This method does not implicitly handle long paths. Use CreateFile.
            /// </summary>
            [DllImport(Dll, EntryPoint = "CreateFileW", SetLastError = true, CharSet = CharSet.Unicode, BestFitMapping = false, ExactSpelling = true)]
            private static extern unsafe SafeFileHandle CreateFilePrivate(
                string lpFileName,
                int dwDesiredAccess,
                FileShare dwShareMode,
                SECURITY_ATTRIBUTES* lpSecurityAttributes,
                FileMode dwCreationDisposition,
                int dwFlagsAndAttributes,
                IntPtr hTemplateFile);

            public static unsafe SafeFileHandle CreateFile(
                string lpFileName,
                int dwDesiredAccess,
                FileShare dwShareMode,
                SECURITY_ATTRIBUTES* lpSecurityAttributes,
                FileMode dwCreationDisposition,
                int dwFlagsAndAttributes,
                IntPtr hTemplateFile)
            {
                lpFileName = PathUtilities.EnsureExtendedPrefixIfNeeded(lpFileName);
                return CreateFilePrivate(lpFileName, dwDesiredAccess, dwShareMode, lpSecurityAttributes, dwCreationDisposition, dwFlagsAndAttributes, hTemplateFile);
            }

            public static unsafe SafeFileHandle CreateFile(
                string lpFileName,
                int dwDesiredAccess,
                FileShare dwShareMode,
                FileMode dwCreationDisposition,
                int dwFlagsAndAttributes)
            {
                lpFileName = PathUtilities.EnsureExtendedPrefixIfNeeded(lpFileName);
                return CreateFilePrivate(lpFileName, dwDesiredAccess, dwShareMode, null, dwCreationDisposition, dwFlagsAndAttributes, IntPtr.Zero);
            }
        }
    }
}