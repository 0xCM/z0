//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct IMAGE_SECTION_HEADER
    {
        public string Name
        {
            get
            {
                fixed (byte* ptr = NameBytes)
                {
                    if (ptr[7] == 0)
                        return Marshal.PtrToStringAnsi((IntPtr)ptr)!;

                    return Marshal.PtrToStringAnsi((IntPtr)ptr, 8);
                }
            }
        }

        public fixed byte NameBytes[8];
        
        public uint VirtualSize;
        
        public uint VirtualAddress;
        
        public uint SizeOfRawData;
        
        public uint PointerToRawData;
        
        public uint PointerToRelocations;
        
        public uint PointerToLinenumbers;
        
        public ushort NumberOfRelocations;
        
        public ushort NumberOfLinenumbers;
        
        public uint Characteristics;
    }
}