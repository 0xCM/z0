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

    [StructLayout(LayoutKind.Explicit)]
    public struct IMAGE_OPTIONAL_HEADER_AGNOSTIC
    {
        [FieldOffset(0)]
        public ushort Magic;

        [FieldOffset(2)]
        public byte MajorLinkerVersion;

        [FieldOffset(3)]
        public byte MinorLinkerVersion;

        [FieldOffset(4)]
        public uint SizeOfCode;

        [FieldOffset(8)]
        public uint SizeOfInitializedData;

        [FieldOffset(12)]
        public uint SizeOfUninitializedData;

        [FieldOffset(16)]
        public uint AddressOfEntryPoint;

        [FieldOffset(20)]
        public uint BaseOfCode;
        
        [FieldOffset(24)]
        public ulong ImageBase64;
        
        [FieldOffset(24)]
        public uint BaseOfData;
        
        [FieldOffset(28)]
        public uint ImageBase;
        
        [FieldOffset(32)]
        public uint SectionAlignment;
        
        [FieldOffset(36)]
        public uint FileAlignment;
        
        [FieldOffset(40)]
        public ushort MajorOperatingSystemVersion;
        
        [FieldOffset(42)]
        public ushort MinorOperatingSystemVersion;
        
        [FieldOffset(44)]
        public ushort MajorImageVersion;
        
        [FieldOffset(46)]
        public ushort MinorImageVersion;
        
        [FieldOffset(48)]
        
        public ushort MajorSubsystemVersion;
        
        [FieldOffset(50)]
        public ushort MinorSubsystemVersion;
        
        [FieldOffset(52)]            
        public uint Win32VersionValue;
        
        [FieldOffset(56)]
        public uint SizeOfImage;
        
        [FieldOffset(60)]
        public uint SizeOfHeaders;
        
        [FieldOffset(64)]
        public uint CheckSum;
        
        [FieldOffset(68)]
        public ushort Subsystem;
        
        [FieldOffset(70)]
        public ushort DllCharacteristics;
    }                
}