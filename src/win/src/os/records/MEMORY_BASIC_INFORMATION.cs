//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Runtime.InteropServices;

    [Record, StructLayout(LayoutKind.Sequential)]
    public struct MEMORY_BASIC_INFORMATION
    {
        public IntPtr Address;
        
        public IntPtr AllocationBase;
        
        public uint AllocationProtect;
        
        public IntPtr RegionSize;
        
        public uint State;
        
        public uint Protect;
        
        public uint Type;

        public ulong BaseAddress => (ulong)Address;
        
        public ulong Size => (ulong)RegionSize;
    }            
}