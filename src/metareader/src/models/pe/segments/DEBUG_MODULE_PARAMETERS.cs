//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    public readonly partial struct PeFile
    {
        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct DEBUG_MODULE_PARAMETERS
        {
            public ulong Base;
            
            public int Size;
            
            public int TimeDateStamp;
            
            public uint Checksum;
            
            public uint Flags;
            
            public uint SymbolType;
            
            public uint ImageNameSize;
            
            public uint ModuleNameSize;
            
            public uint LoadedImageNameSize;
            
            public uint SymbolFileNameSize;
            
            public uint MappedImageNameSize;
            
            public fixed ulong Reserved[2];
        }        
    }
}