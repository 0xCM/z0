//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    [Table, StructLayout(LayoutKind.Sequential)]
    public readonly struct CodeHeaderData
    {
        public readonly ClrDataAddress GCInfo;

        public readonly uint JITType;

        public readonly ClrDataAddress MethodDesc;

        public readonly ClrDataAddress MethodStart;

        public readonly uint MethodSize;

        public readonly ClrDataAddress ColdRegionStart;

        public readonly uint ColdRegionSize;

        public readonly uint HotRegionSize;
    }    
}