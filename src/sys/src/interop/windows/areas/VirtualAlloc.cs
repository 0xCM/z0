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

    partial struct Windows
    {
        partial struct Kernel32
        {            
            [DllImport(Libraries.Kernel32, ExactSpelling = true)]
            public static extern unsafe void* VirtualAlloc(void* lpAddress, UIntPtr dwSize, int flAllocationType, int flProtect);

            [DllImport(Libraries.Kernel32, SetLastError = true, ExactSpelling = true)]
            public static extern IntPtr VirtualAlloc(SafeHandle lpAddress, UIntPtr dwSize, int flAllocationType, int flProtect);

            [DllImport(Libraries.Kernel32, ExactSpelling = true)]
            public static extern unsafe bool VirtualFree(void* lpAddress, UIntPtr dwSize, int dwFreeType);
        }
    }
}