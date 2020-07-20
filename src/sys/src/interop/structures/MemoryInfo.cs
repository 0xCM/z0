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
        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct MEMORY_BASIC_INFORMATION
        {
            public void* BaseAddress;

            public void* AllocationBase;

            public uint AllocationProtect;

            public UIntPtr RegionSize;

            public uint State;

            public uint Protect;

            public uint Type;
        }
    }
}