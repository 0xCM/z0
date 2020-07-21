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
        [StructLayout(LayoutKind.Sequential)]
        internal struct PROCESS_MEMORY_COUNTERS
        {
            public uint cb;
            
            public uint PageFaultCount;
            
            public UIntPtr PeakWorkingSetSize;
            
            public UIntPtr WorkingSetSize;
            
            public UIntPtr QuotaPeakPagedPoolUsage;
            
            public UIntPtr QuotaPagedPoolUsage;
            
            public UIntPtr QuotaPeakNonPagedPoolUsage;
            
            public UIntPtr QuotaNonPagedPoolUsage;
            
            public UIntPtr PagefileUsage;
            
            public UIntPtr PeakPagefileUsage;
        }
    }
}