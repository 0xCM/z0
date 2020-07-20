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

    partial struct Windows
    {
        public const int INVALID_FILE_SIZE = -1;

        partial struct Kernel32
        {            
            [DllImport(Libraries.Kernel32, SetLastError = true)] [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool FlushFileBuffers(SafeHandle hHandle);

            [DllImport(Libraries.Kernel32, EntryPoint = "SetEnvironmentVariableW", SetLastError = true, CharSet = CharSet.Unicode, BestFitMapping = false, ExactSpelling = true)]
            public static extern bool SetEnvironmentVariable(string lpName, string lpValue);

            /// <summary>
            /// WARNING: This method does not implicitly handle long paths. Use SetFileAttributes.
            /// </summary>
            [DllImport(Libraries.Kernel32, EntryPoint = "SetFileAttributesW", SetLastError = true, CharSet = CharSet.Unicode, BestFitMapping = false)]
            private static extern bool SetFileAttributesPrivate(string name, int attr);

            public static bool SetFileAttributes(string name, int attr)
            {
                name = PathInternal.EnsureExtendedPrefixIfNeeded(name);
                return SetFileAttributesPrivate(name, attr);
            }
       }
    }
}