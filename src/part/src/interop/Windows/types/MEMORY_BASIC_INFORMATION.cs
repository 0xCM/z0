// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
namespace Windows
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct MEMORY_BASIC_INFORMATION
    {
        public byte* BaseAddress;

        public byte* AllocationBase;

        public VirtualAllocProtection AllocationProtect;

        public ulong RegionSize;

        public VirtualAllocType State;

        public VirtualAllocProtection Protect;

        public VirtualAllocType Type;
    }
}