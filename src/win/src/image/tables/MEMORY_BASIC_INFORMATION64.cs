//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;
    using System.Runtime.InteropServices;

    [Table, StructLayout(LayoutKind.Sequential)]
    public struct MEMORY_BASIC_INFORMATION64
    {
        public ulong BaseAddress;
        
        public ulong AllocationBase;
        
        public PAGE AllocationProtect;
        
        public uint __alignment1;
        
        public ulong RegionSize;
        
        public MEM State;
        
        public PAGE Protect;
        
        public MEM Type;
        
        public uint __alignment2;
    }
}