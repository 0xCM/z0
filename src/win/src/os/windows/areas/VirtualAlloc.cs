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

    using Z0.MS;

    partial struct Windows
    {
        partial struct Kernel32
        {            
            [DllImport(WinLibs.Kernel32, ExactSpelling = true)]
            public static extern unsafe void* VirtualAlloc(void* lpAddress, UIntPtr dwSize, int flAllocationType, int flProtect);

            [DllImport(WinLibs.Kernel32, SetLastError = true, ExactSpelling = true)]
            public static extern IntPtr VirtualAlloc(SafeHandle lpAddress, UIntPtr dwSize, int flAllocationType, int flProtect);

            [DllImport(WinLibs.Kernel32, ExactSpelling = true)]
            public static extern unsafe bool VirtualFree(void* lpAddress, UIntPtr dwSize, int dwFreeType);
        }
    }
}