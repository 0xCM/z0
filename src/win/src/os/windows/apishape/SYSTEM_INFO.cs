//-----------------------------------------------------------------------------
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEM_INFO
    {
        public ushort wProcessorArchitecture;

        public ushort wReserved;

        public int dwPageSize;

        public IntPtr lpMinimumApplicationAddress;

        public IntPtr lpMaximumApplicationAddress;

        public IntPtr dwActiveProcessorMask;

        public int dwNumberOfProcessors;

        public int dwProcessorType;

        public int dwAllocationGranularity;

        public short wProcessorLevel;

        public short wProcessorRevision;
    }

}