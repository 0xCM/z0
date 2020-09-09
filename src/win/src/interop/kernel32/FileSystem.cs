//-----------------------------------------------------------------------------
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.InteropServices;
    using System.Security;

    using Z0.MS;

    partial struct Windows
    {
        public const int INVALID_FILE_SIZE = -1;

        partial struct Kernel32
        {
            /// <summary>
            /// WARNING: This method does not implicitly handle long paths. Use CreateFile.
            /// </summary>
            [DllImport(WinLibs.Kernel32, EntryPoint = "CreateFileW", SetLastError = true, CharSet = CharSet.Unicode, BestFitMapping = false, ExactSpelling = true), SuppressUnmanagedCodeSecurity]
            public static extern unsafe IntPtr CreateFile(string lpFileName, int dwDesiredAccess, FileShare dwShareMode,
                SECURITY_ATTRIBUTES* lpSecurityAttributes, FileMode dwCreationDisposition, int dwFlagsAndAttributes, IntPtr hTemplateFile);

            public static unsafe IntPtr CreateFile(FS.FilePath path, int dwDesiredAccess, FileShare dwShareMode, FileMode dwCreationDisposition, int dwFlagsAndAttributes)
            {
                var lpFileName = PathUtilities.EnsureExtendedPrefixIfNeeded(path.Name);
                return CreateFile(lpFileName, dwDesiredAccess, dwShareMode, null, dwCreationDisposition, dwFlagsAndAttributes, IntPtr.Zero);
            }

            public static unsafe IntPtr CreateFile(FS.FilePath path, int dwDesiredAccess, FileShare dwShareMode, SECURITY_ATTRIBUTES* lpSecurityAttributes,
                FileMode dwCreationDisposition, int dwFlagsAndAttributes, IntPtr hTemplateFile)
            {
                var lpFileName = PathUtilities.EnsureExtendedPrefixIfNeeded(path.Name);
                return CreateFile(lpFileName, dwDesiredAccess, dwShareMode, lpSecurityAttributes, dwCreationDisposition, dwFlagsAndAttributes, hTemplateFile);
            }

            [DllImport(WinLibs.Kernel32, SetLastError = true), SuppressUnmanagedCodeSecurity]
            public static extern unsafe int WriteFile(IntPtr handle, byte* bytes, int numBytesToWrite, out int numBytesWritten, IntPtr mustBeZero);

            [DllImport(WinLibs.Kernel32, SetLastError = true), SuppressUnmanagedCodeSecurity]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool FlushFileBuffers(SafeHandle hHandle);

            [DllImport(WinLibs.Kernel32, EntryPoint = "SetEnvironmentVariableW", SetLastError = true, CharSet = CharSet.Unicode, BestFitMapping = false, ExactSpelling = true), SuppressUnmanagedCodeSecurity]
            public static extern bool SetEnvironmentVariable(string lpName, string lpValue);

            /// <summary>
            /// WARNING: This method does not implicitly handle long paths. Use SetFileAttributes.
            /// </summary>
            [DllImport(WinLibs.Kernel32, EntryPoint = "SetFileAttributesW", SetLastError = true, CharSet = CharSet.Unicode, BestFitMapping = false), SuppressUnmanagedCodeSecurity]
            private static extern bool SetFileAttributesPrivate(string name, int attr);

            public static bool SetFileAttributes(string name, int attr)
            {
                name = PathUtilities.EnsureExtendedPrefixIfNeeded(name);
                return SetFileAttributesPrivate(name, attr);
            }

            [DllImport(WinLibs.Kernel32, SetLastError = true), SuppressUnmanagedCodeSecurity]
            public static extern bool SetFilePointerEx(IntPtr hFile, long liDistanceToMove, out long lpNewFilePointer, uint dwMoveMethod);
       }
    }
}