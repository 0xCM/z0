//-----------------------------------------------------------------------------
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct Windows
    {
        partial struct Kernel32
        {            
            [DllImport(Libraries.Kernel32, SetLastError = true, ExactSpelling = true)]
            public static extern UIntPtr VirtualQuery(SafeHandle lpAddress, ref MEMORY_BASIC_INFORMATION lpBuffer, UIntPtr dwLength);

            [DllImport(Libraries.Kernel32, SetLastError = true, ExactSpelling = true)]
            public static extern unsafe UIntPtr VirtualQuery(void* lpAddress, ref MEMORY_BASIC_INFORMATION lpBuffer, UIntPtr dwLength);
        }
    }
}