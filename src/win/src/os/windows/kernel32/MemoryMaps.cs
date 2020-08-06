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
    
    using Z0.MS;

    partial struct Windows
    {
        // https://docs.microsoft.com/en-us/windows/win32/memory/creating-a-file-mapping-object

        partial struct Kernel32
        {            

            [DllImport(Dll, EntryPoint = "CreateFileMappingW", CharSet = CharSet.Unicode, SetLastError = true)]
            public static extern SafeMemoryMappedFileHandle CreateFileMapping(IntPtr hFile, ref SECURITY_ATTRIBUTES lpFileMappingAttributes, 
                int flProtect, int dwMaximumSizeHigh, int dwMaximumSizeLow, string lpName);

            [DllImport(WinLibs.Kernel32, SetLastError = true)]
            public static extern bool FlushViewOfFile(IntPtr lpBaseAddress, UIntPtr dwNumberOfBytesToFlush);                

            [DllImport(WinLibs.Kernel32, EntryPoint = "MapViewOfFile", CharSet = CharSet.Unicode, SetLastError = true)]
            public static extern SafeMemoryMappedViewHandle MapViewOfFile(SafeMemoryMappedFileHandle hFileMappingObject, int dwDesiredAccess, 
                int dwFileOffsetHigh, int dwFileOffsetLow, UIntPtr dwNumberOfBytesToMap);

            [DllImport(WinLibs.Kernel32, EntryPoint = "MapViewOfFileEx", CharSet = CharSet.Unicode, SetLastError = true)]
            public unsafe static extern SafeMemoryMappedViewHandle MapViewOfFileEx(SafeMemoryMappedFileHandle hFileMappingObject, int dwDesiredAccess, 
                int dwFileOffsetHigh, int dwFileOffsetLow, UIntPtr dwNumberOfBytesToMap, void* lpBaseAddress);


            [DllImport(WinLibs.Kernel32, SetLastError = true)]
            public static extern bool UnmapViewOfFile(IntPtr lpBaseAddress);
        }
    }
}