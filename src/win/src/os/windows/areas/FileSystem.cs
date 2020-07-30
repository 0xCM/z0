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
        public const int INVALID_FILE_SIZE = -1;

        partial struct Kernel32
        {            
            [DllImport(WinLibs.Kernel32, SetLastError = true)]
            public static extern unsafe int WriteFile(IntPtr handle, byte* bytes, int numBytesToWrite, out int numBytesWritten, IntPtr mustBeZero);

            // Note there are two different WriteFile prototypes - this is to use
            // the type system to force you to not trip across a "feature" in
            // Win32's async IO support.  You can't do the following three things
            // simultaneously: overlapped IO, free the memory for the overlapped
            // struct in a callback (or an EndWrite method called by that callback),
            // and pass in an address for the numBytesRead parameter.

            [DllImport(WinLibs.Kernel32, SetLastError = true)]
            public static extern unsafe int WriteFile(SafeHandle handle, byte* bytes, int numBytesToWrite, out int numBytesWritten, IntPtr mustBeZero);


            [DllImport(WinLibs.Kernel32, SetLastError = true)] [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool FlushFileBuffers(SafeHandle hHandle);

            [DllImport(WinLibs.Kernel32, EntryPoint = "SetEnvironmentVariableW", SetLastError = true, CharSet = CharSet.Unicode, BestFitMapping = false, ExactSpelling = true)]
            public static extern bool SetEnvironmentVariable(string lpName, string lpValue);

            /// <summary>
            /// WARNING: This method does not implicitly handle long paths. Use SetFileAttributes.
            /// </summary>
            [DllImport(WinLibs.Kernel32, EntryPoint = "SetFileAttributesW", SetLastError = true, CharSet = CharSet.Unicode, BestFitMapping = false)]
            private static extern bool SetFileAttributesPrivate(string name, int attr);

            public static bool SetFileAttributes(string name, int attr)
            {
                name = PathUtilities.EnsureExtendedPrefixIfNeeded(name);
                return SetFileAttributesPrivate(name, attr);
            }


            [DllImport(WinLibs.Kernel32, SetLastError = true)]
            public static extern bool SetFilePointerEx(SafeFileHandle hFile, long liDistanceToMove, out long lpNewFilePointer, uint dwMoveMethod);            
       }
    }
}