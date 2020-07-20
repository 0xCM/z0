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

    partial struct Windows
    {
        partial struct Kernel32
        {             

            [DllImport(Libraries.Kernel32, SetLastError = true)]
            public static extern bool FlushViewOfFile(IntPtr lpBaseAddress, UIntPtr dwNumberOfBytesToFlush);
        }
    }
}