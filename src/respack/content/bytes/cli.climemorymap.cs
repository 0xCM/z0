//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
// Generated   : 2021-02-26 14:33:08 -06:00
//-----------------------------------------------------------------------------
namespace Z0.ByteCode
{
    using System;
    using System.Runtime.CompilerServices;


    public static class cli_climemorymap
    {
        public static ReadOnlySpan<byte> AssemblyReferenceHandles_ᐤᐤ  =>  new byte[92]{0x57,0x56,0x53,0x48,0x83,0xec,0x30,0x33,0xc0,0x48,0x89,0x44,0x24,0x20,0x48,0x8b,0xf2,0x48,0x8b,0x79,0x18,0x8b,0x0f,0x48,0xb9,0x88,0x46,0x95,0xdc,0xfd,0x7f,0x00,0x00,0xe8,0x9a,0x93,0x50,0x5a,0x48,0x8b,0xd8,0x48,0x8d,0x4b,0x08,0x48,0x8b,0xd7,0xe8,0xcb,0x84,0x50,0x5a,0x48,0x8b,0xd3,0x48,0x8d,0x4c,0x24,0x20,0xe8,0x96,0xa2,0xff,0xff,0x48,0x8b,0x44,0x24,0x20,0x8b,0x54,0x24,0x28,0x48,0x89,0x06,0x89,0x56,0x08,0x48,0x8b,0xc6,0x48,0x83,0xc4,0x30,0x5b,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> AssemblyDependencies_ᐤᐤ  =>  new byte[246]{0x41,0x57,0x41,0x56,0x41,0x54,0x57,0x56,0x55,0x53,0x48,0x83,0xec,0x40,0x33,0xc0,0x48,0x89,0x44,0x24,0x30,0x48,0x89,0x44,0x24,0x38,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x44,0x24,0x28,0x48,0x8b,0xf1,0x48,0x8b,0xfa,0x48,0x8b,0x5e,0x18,0x8b,0x0b,0x48,0xb9,0x88,0x46,0x95,0xdc,0xfd,0x7f,0x00,0x00,0xe8,0x01,0x8f,0x50,0x5a,0x48,0x8b,0xe8,0x48,0x8d,0x4d,0x08,0x48,0x8b,0xd3,0xe8,0x32,0x80,0x50,0x5a,0x48,0x8b,0xd5,0x48,0x8d,0x4c,0x24,0x30,0xe8,0xfd,0x9d,0xff,0xff,0x48,0x8b,0x5c,0x24,0x30,0x8b,0x6c,0x24,0x38,0x48,0x63,0xcd,0xe8,0xe4,0xfb,0xff,0xff,0x4c,0x8b,0xf0,0x4d,0x85,0xf6,0x75,0x05,0x45,0x33,0xff,0xeb,0x08,0x4d,0x8d,0x7e,0x10,0x41,0x8b,0x4e,0x08,0x45,0x33,0xe4,0x48,0x63,0xcd,0x48,0x85,0xc9,0x7e,0x3f,0x48,0x8b,0x4e,0x18,0x49,0x63,0xd4,0x8b,0x14,0x93,0x44,0x8b,0x01,0x4c,0x8d,0x44,0x24,0x20,0x49,0x89,0x08,0x41,0x89,0x50,0x08,0x48,0x8b,0xce,0x48,0x8d,0x54,0x24,0x20,0x4d,0x63,0xc4,0x4f,0x8d,0x04,0x40,0x4f,0x8d,0x04,0xc7,0xe8,0x4b,0xed,0xf2,0xfc,0x41,0xff,0xc4,0x41,0x8b,0xc4,0x48,0x63,0xd5,0x48,0x3b,0xc2,0x7c,0xc1,0x4d,0x85,0xf6,0x75,0x06,0x33,0xc0,0x33,0xd2,0xeb,0x08,0x49,0x8d,0x46,0x10,0x41,0x8b,0x56,0x08,0x48,0x89,0x07,0x89,0x57,0x08,0x48,0x8b,0xc7,0x48,0x83,0xc4,0x40,0x5b,0x5d,0x5e,0x5f,0x41,0x5c,0x41,0x5e,0x41,0x5f,0xc3};

        public static ReadOnlySpan<byte> Read_ᐤrspanAssemblyReferenceHandleㆍspanAssemblyRefInfoᐤ  =>  new byte[122]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xec,0x30,0x33,0xc0,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x44,0x24,0x28,0x48,0x8b,0xf1,0x48,0x8b,0xfa,0x49,0x8b,0xd8,0x8b,0x6f,0x08,0x45,0x33,0xf6,0x48,0x63,0xcd,0x48,0x85,0xc9,0x7e,0x42,0x48,0x8b,0x4e,0x18,0x48,0x8b,0x17,0x4d,0x63,0xc6,0x42,0x8b,0x14,0x82,0x8b,0x01,0x48,0x8b,0x03,0x4c,0x8d,0x4c,0x24,0x20,0x49,0x89,0x09,0x41,0x89,0x51,0x08,0x48,0x8b,0xce,0x48,0x8d,0x54,0x24,0x20,0x4f,0x8d,0x04,0x40,0x4e,0x8d,0x04,0xc0,0xe8,0x87,0xec,0xf2,0xfc,0x41,0xff,0xc6,0x41,0x8b,0xc6,0x48,0x63,0xd5,0x48,0x3b,0xc2,0x7c,0xbe,0x48,0x83,0xc4,0x30,0x5b,0x5d,0x5e,0x5f,0x41,0x5e,0xc3};

        public static ReadOnlySpan<byte> Read_ᐤAssemblyReferenceㆍAssemblyRefInfoᕀrefᐤ  =>  new byte[168]{0x57,0x56,0x53,0x48,0x83,0xec,0x30,0x33,0xc0,0x48,0x89,0x44,0x24,0x28,0x48,0x8b,0xd9,0x48,0x8b,0xf2,0x49,0x8b,0xf8,0x48,0x8b,0x4b,0x18,0x39,0x09,0xe8,0x66,0xf7,0xb1,0xfb,0x48,0x89,0x44,0x24,0x28,0x48,0x8d,0x4c,0x24,0x28,0xe8,0xef,0x0b,0xec,0xfc,0x48,0x8b,0xd0,0x48,0x8b,0xcf,0xe8,0x54,0x7e,0x50,0x5a,0x48,0x8b,0xce,0xe8,0x34,0x0c,0xec,0xfc,0x48,0x8d,0x4f,0x08,0x48,0x8b,0xd0,0xe8,0x40,0x7e,0x50,0x5a,0xf7,0x46,0x08,0x00,0x00,0x00,0x80,0x74,0x0a,0x48,0x8b,0xce,0xe8,0x97,0x0c,0xec,0xfc,0xeb,0x1a,0x48,0x8b,0x0e,0x39,0x09,0x48,0x81,0xc1,0x30,0x06,0x00,0x00,0x8b,0x56,0x08,0x81,0xe2,0xff,0xff,0xff,0x00,0xe8,0xdb,0xee,0xb1,0xfb,0x8b,0xd0,0x48,0x8b,0x4b,0x18,0x8b,0x01,0x48,0x81,0xc1,0x88,0x00,0x00,0x00,0xe8,0x5f,0xe8,0xb1,0xfb,0x48,0x8d,0x4f,0x10,0x48,0x8b,0xd0,0xe8,0xf3,0x7d,0x50,0x5a,0x48,0x8b,0xc7,0x48,0x83,0xc4,0x30,0x5b,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> AssemblyFileHandles_ᐤᐤ  =>  new byte[84]{0x57,0x56,0x48,0x83,0xec,0x38,0x33,0xc0,0x48,0x89,0x44,0x24,0x28,0x48,0x8b,0xf2,0x48,0x8b,0x49,0x18,0x8b,0x01,0x8b,0xb9,0xd0,0x06,0x00,0x00,0x48,0xb9,0xe8,0x4c,0x95,0xdc,0xfd,0x7f,0x00,0x00,0xe8,0x95,0x8c,0x50,0x5a,0x89,0x78,0x08,0x48,0x8b,0xd0,0x48,0x8d,0x4c,0x24,0x28,0xe8,0xcd,0xfb,0xff,0xff,0x48,0x8b,0x44,0x24,0x28,0x8b,0x54,0x24,0x30,0x48,0x89,0x06,0x89,0x56,0x08,0x48,0x8b,0xc6,0x48,0x83,0xc4,0x38,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> Read_ᐤAssemblyFileHandleᐤ  =>  new byte[34]{0x57,0x56,0x0f,0x1f,0x00,0x48,0x8b,0xf2,0x48,0x8b,0x51,0x18,0x8b,0x0a,0x41,0x8b,0xf8,0x48,0x8b,0xce,0xe8,0x47,0x7d,0x50,0x5a,0x89,0x7e,0x08,0x48,0x8b,0xc6,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> Read_ᐤAssemblyFileHandleㆍAssemblyFileᕀrefᐤ  =>  new byte[45]{0x57,0x56,0x50,0x66,0x90,0x49,0x8b,0xf0,0x48,0x8b,0x49,0x18,0x8b,0x01,0x48,0x89,0x0c,0x24,0x8b,0xfa,0x48,0x8b,0x14,0x24,0x48,0x8b,0xce,0xe8,0x00,0x7d,0x50,0x5a,0x89,0x7e,0x08,0x48,0x8b,0xc6,0x48,0x83,0xc4,0x08,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> Read_ᐤrspanAssemblyFileHandleㆍspanAssemblyFileᐤ  =>  new byte[104]{0x41,0x57,0x41,0x56,0x41,0x55,0x41,0x54,0x57,0x56,0x55,0x53,0x48,0x8b,0xd9,0x48,0x8b,0xf2,0x49,0x8b,0xf8,0x8b,0x6e,0x08,0x45,0x33,0xf6,0x48,0x63,0xd5,0x48,0x85,0xd2,0x7e,0x38,0x48,0x8b,0x16,0x49,0x63,0xce,0x44,0x8b,0x3c,0x8a,0x4c,0x8b,0x27,0x4d,0x63,0xee,0x49,0xc1,0xe5,0x04,0x4d,0x03,0xe5,0x48,0x8b,0x53,0x18,0x8b,0x0a,0x49,0x8b,0xcc,0xe8,0x88,0x7c,0x50,0x5a,0x45,0x89,0x7c,0x24,0x08,0x41,0xff,0xc6,0x41,0x8b,0xc6,0x48,0x63,0xd5,0x48,0x3b,0xc2,0x7c,0xc8,0x5b,0x5d,0x5e,0x5f,0x41,0x5c,0x41,0x5d,0x41,0x5e,0x41,0x5f,0xc3};

        public static ReadOnlySpan<byte> Read_ᐤBlobHandleᐤ  =>  new byte[29]{0x48,0x83,0xec,0x28,0x90,0x48,0x8b,0x49,0x18,0x8b,0x01,0x48,0x81,0xc1,0x88,0x00,0x00,0x00,0xe8,0x89,0xe6,0xb1,0xfb,0x90,0x48,0x83,0xc4,0x28,0xc3};

        public static ReadOnlySpan<byte> Read_ᐤBlobHandleㆍBinaryCodeᕀrefᐤ  =>  new byte[46]{0x56,0x48,0x83,0xec,0x20,0x49,0x8b,0xf0,0x48,0x8b,0x49,0x18,0x8b,0x01,0x48,0x81,0xc1,0x88,0x00,0x00,0x00,0xe8,0x46,0xe6,0xb1,0xfb,0x48,0x8b,0xce,0x48,0x8b,0xd0,0xe8,0xdb,0x7b,0x50,0x5a,0x48,0x8b,0xc6,0x48,0x83,0xc4,0x20,0x5e,0xc3};

        public static ReadOnlySpan<byte> Read_ᐤTableSpanᐸCustomAttributeHandleᐳㆍReceiverᐸCustomAttributeᐳᐤ  =>  new byte[126]{0x57,0x56,0x53,0x48,0x83,0xec,0x20,0x48,0x89,0x54,0x24,0x48,0x48,0x8b,0xf1,0x49,0x8b,0xf8,0x48,0xb9,0x38,0x87,0xef,0xdc,0xfd,0x7f,0x00,0x00,0xe8,0x7f,0x86,0x50,0x5a,0x48,0x8b,0xd8,0x48,0x8d,0x4b,0x08,0x48,0x8b,0xd7,0xe8,0xb0,0x77,0x50,0x5a,0x48,0x8d,0x4b,0x10,0x48,0x8b,0xd6,0xe8,0xa4,0x77,0x50,0x5a,0x48,0xb9,0x60,0x29,0xa6,0xdf,0xfd,0x7f,0x00,0x00,0xe8,0x55,0x86,0x50,0x5a,0x48,0x8b,0xf0,0x48,0x8d,0x4e,0x08,0x48,0x8b,0xd3,0xe8,0x86,0x77,0x50,0x5a,0x48,0xb9,0xd8,0xfb,0x68,0xdc,0xfd,0x7f,0x00,0x00,0x48,0x89,0x4e,0x18,0x48,0x8d,0x4c,0x24,0x48,0x48,0x8b,0xd6,0xe8,0xf3,0x17,0x48,0xfe,0x90,0x48,0x83,0xc4,0x20,0x5b,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> Read_ᐤFieldDefinitionHandleᐤ  =>  new byte[64]{0x57,0x56,0x53,0x48,0x83,0xec,0x20,0x48,0x8b,0xf2,0x48,0x8b,0x79,0x18,0x41,0x8b,0xd0,0x8b,0x0f,0x83,0x7f,0x50,0x00,0x75,0x04,0x8b,0xda,0xeb,0x0a,0x48,0x8b,0xcf,0xe8,0x1b,0xeb,0xb1,0xfb,0x8b,0xd8,0x48,0x8b,0xd7,0x48,0x8b,0xce,0xe8,0xde,0x76,0x50,0x5a,0x89,0x5e,0x08,0x48,0x8b,0xc6,0x48,0x83,0xc4,0x20,0x5b,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> Read_ᐤFieldDefinitionHandleㆍFieldDefinitionᕀrefᐤ  =>  new byte[61]{0x57,0x56,0x53,0x48,0x83,0xec,0x20,0x49,0x8b,0xf0,0x48,0x8b,0x79,0x18,0x8b,0x0f,0x83,0x7f,0x50,0x00,0x75,0x04,0x8b,0xda,0xeb,0x0a,0x48,0x8b,0xcf,0xe8,0xbe,0xea,0xb1,0xfb,0x8b,0xd8,0x48,0x8b,0xd7,0x48,0x8b,0xce,0xe8,0x81,0x76,0x50,0x5a,0x89,0x5e,0x08,0x48,0x8b,0xc6,0x48,0x83,0xc4,0x20,0x5b,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> Read_ᐤrspanFieldDefinitionHandleㆍspanFieldDefinitionᐤ  =>  new byte[139]{0x41,0x57,0x41,0x56,0x41,0x55,0x41,0x54,0x57,0x56,0x55,0x53,0x48,0x83,0xec,0x28,0x48,0x8b,0xd9,0x48,0x8b,0xf2,0x49,0x8b,0xf8,0x8b,0x6e,0x08,0x45,0x33,0xf6,0x48,0x63,0xcd,0x48,0x85,0xc9,0x7e,0x53,0x48,0x8b,0x0e,0x49,0x63,0xd6,0x8b,0x14,0x91,0x4c,0x8b,0x3f,0x4d,0x63,0xe6,0x49,0xc1,0xe4,0x04,0x4d,0x03,0xfc,0x4c,0x8b,0x63,0x18,0x41,0x8b,0x0c,0x24,0x41,0x83,0x7c,0x24,0x50,0x00,0x75,0x05,0x44,0x8b,0xea,0xeb,0x0b,0x49,0x8b,0xcc,0xe8,0x26,0xea,0xb1,0xfb,0x44,0x8b,0xe8,0x49,0x8b,0xd4,0x49,0x8b,0xcf,0xe8,0xe8,0x75,0x50,0x5a,0x45,0x89,0x6f,0x08,0x41,0xff,0xc6,0x41,0x8b,0xc6,0x48,0x63,0xd5,0x48,0x3b,0xc2,0x7c,0xad,0x48,0x83,0xc4,0x28,0x5b,0x5d,0x5e,0x5f,0x41,0x5c,0x41,0x5d,0x41,0x5e,0x41,0x5f,0xc3};

        public static ReadOnlySpan<byte> Read_ᐤMetadataReaderㆍManifestResourceHandleᐤ  =>  new byte[30]{0x57,0x56,0x0f,0x1f,0x00,0x48,0x8b,0xf1,0x8b,0x0a,0x41,0x8b,0xf8,0x48,0x8b,0xce,0xe8,0x8b,0x75,0x50,0x5a,0x89,0x7e,0x08,0x48,0x8b,0xc6,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> Read_ᐤMetadataReaderㆍManifestResourceHandleㆍManifestResourceᕀoutᐤ  =>  new byte[41]{0x57,0x56,0x50,0x66,0x90,0x49,0x8b,0xf0,0x8b,0x01,0x48,0x89,0x0c,0x24,0x8b,0xfa,0x48,0x8b,0x14,0x24,0x48,0x8b,0xce,0xe8,0x44,0x75,0x50,0x5a,0x89,0x7e,0x08,0x48,0x8b,0xc6,0x48,0x83,0xc4,0x08,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> Search_ᐤstringㆍResourceSegmentᕀoutᐤ  =>  new byte[1092]{0x41,0x57,0x41,0x56,0x41,0x55,0x41,0x54,0x57,0x56,0x55,0x53,0x48,0x81,0xec,0xe8,0x00,0x00,0x00,0xc5,0xf8,0x77,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x50,0xb9,0x26,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x8b,0xf1,0x48,0x8b,0xfa,0x49,0x8b,0xd8,0x33,0xc9,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x03,0x48,0x89,0x4b,0x10,0x48,0x8b,0x6e,0x10,0x48,0x83,0x7d,0x10,0x00,0x75,0x08,0x48,0x8b,0xcd,0xe8,0x0c,0x67,0xbb,0xfe,0x48,0x8b,0x4d,0x10,0x48,0x8b,0x49,0x18,0x48,0x8b,0x49,0x20,0x48,0x89,0x8c,0x24,0xb0,0x00,0x00,0x00,0x48,0x8b,0x4e,0x10,0x48,0x8d,0x94,0x24,0xd8,0x00,0x00,0x00,0x44,0x8b,0x84,0x24,0xb0,0x00,0x00,0x00,0x39,0x09,0xe8,0x05,0xeb,0xeb,0xfc,0x48,0x8b,0x4e,0x18,0x8b,0x01,0x8b,0xa9,0x28,0x07,0x00,0x00,0x48,0xb9,0xb8,0x49,0x95,0xdc,0xfd,0x7f,0x00,0x00,0xe8,0x62,0x7f,0x50,0x5a,0x89,0x68,0x08,0x48,0x8b,0xd0,0x48,0x8d,0x8c,0x24,0x88,0x00,0x00,0x00,0xe8,0xff,0xf7,0xff,0xff,0x48,0x8b,0xac,0x24,0x88,0x00,0x00,0x00,0x44,0x8b,0xb4,0x24,0x90,0x00,0x00,0x00,0x49,0x63,0xce,0xe8,0x07,0xf8,0xff,0xff,0x48,0x85,0xc0,0x75,0x08,0x45,0x33,0xff,0x45,0x33,0xe4,0xeb,0x08,0x4c,0x8d,0x78,0x10,0x44,0x8b,0x60,0x08,0x45,0x33,0xed,0x49,0x63,0xce,0x48,0x85,0xc9,0x0f,0x8e,0x46,0x02,0x00,0x00,0x49,0x63,0xcd,0x8b,0x4c,0x8d,0x00,0x48,0x8b,0x56,0x18,0x8b,0x02,0x48,0x89,0x54,0x24,0x78,0x89,0x8c,0x24,0x80,0x00,0x00,0x00,0x48,0x8d,0x44,0x24,0x78,0x49,0x63,0xcd,0x48,0x8d,0x0c,0x49,0x4d,0x8d,0x04,0xcf,0x4c,0x89,0x44,0x24,0x40,0x48,0x8b,0x08,0x39,0x09,0x48,0x81,0xc1,0x28,0x07,0x00,0x00,0x48,0x89,0x44,0x24,0x48,0x8b,0x50,0x08,0xe8,0x64,0xe1,0xb1,0xfb,0x48,0x8b,0x56,0x18,0x8b,0x0a,0x48,0x8d,0x4a,0x70,0x48,0x8b,0x52,0x38,0x48,0x89,0x54,0x24,0x38,0xa9,0x00,0x00,0x00,0x80,0x0f,0x85,0xb2,0x00,0x00,0x00,0x45,0x33,0xc0,0x44,0x89,0x44,0x24,0x68,0x44,0x8b,0xc0,0x41,0xc1,0xe8,0x1d,0x45,0x0f,0xb6,0xc0,0x41,0x83,0xf8,0x01,0x74,0x05,0x45,0x33,0xc0,0xeb,0x06,0x41,0xb8,0x2e,0x00,0x00,0x00,0x45,0x0f,0xb7,0xc0,0x44,0x89,0x44,0x24,0x74,0x39,0x09,0x48,0x83,0xc1,0x08,0x25,0xff,0xff,0xff,0x1f,0x89,0x44,0x24,0x64,0x44,0x8b,0xc8,0x48,0x89,0x4c,0x24,0x30,0x44,0x8b,0x51,0x08,0x4d,0x63,0xd2,0x4d,0x3b,0xca,0x76,0x45,0xe8,0x41,0xd9,0xeb,0xfc,0x8b,0x44,0x24,0x64,0x4c,0x8d,0x44,0x24,0x68,0x48,0x8b,0x4c,0x24,0x30,0x89,0x44,0x24,0x64,0x8b,0xd0,0x44,0x8b,0x4c,0x24,0x74,0xe8,0xeb,0xb9,0xbb,0xfe,0x8b,0x4c,0x24,0x64,0x48,0x63,0xd1,0x48,0x8b,0x4c,0x24,0x30,0x48,0x03,0x11,0x85,0xc0,0x75,0x15,0x48,0xb9,0x60,0x30,0xc6,0x13,0xd3,0x01,0x00,0x00,0x48,0x8b,0x11,0xeb,0x1b,0x8b,0x44,0x24,0x64,0xeb,0xbe,0x48,0x8b,0x4c,0x24,0x38,0x44,0x8b,0xc0,0x48,0x8b,0x01,0x48,0x8b,0x40,0x40,0xff,0x50,0x20,0x48,0x8b,0xd0,0xeb,0x0f,0x8b,0xd0,0x4c,0x8b,0x44,0x24,0x38,0xe8,0x00,0xd9,0xb1,0xfb,0x48,0x8b,0xd0,0x48,0x8b,0x4c,0x24,0x40,0xe8,0xf3,0x6e,0x50,0x5a,0x48,0x8b,0x44,0x24,0x48,0x48,0x8b,0x08,0x39,0x09,0x48,0x8d,0x91,0x28,0x07,0x00,0x00,0x48,0x89,0x44,0x24,0x48,0x8b,0x48,0x08,0xff,0xc9,0x0f,0xaf,0x4a,0x18,0x39,0x12,0x4c,0x8d,0x42,0x20,0x03,0x4a,0x08,0x8b,0xd1,0x89,0x54,0x24,0x60,0x8b,0xca,0x48,0x83,0xc1,0x04,0x4c,0x89,0x44,0x24,0x28,0x45,0x8b,0x48,0x08,0x4d,0x63,0xc9,0x49,0x3b,0xc9,0x76,0x05,0xe8,0x81,0xd8,0xeb,0xfc,0x8b,0x54,0x24,0x60,0x48,0x63,0xd2,0x4c,0x8b,0x44,0x24,0x28,0x49,0x03,0x10,0x0f,0xb6,0x0a,0x44,0x0f,0xb6,0x42,0x01,0x41,0xc1,0xe0,0x08,0x41,0x0b,0xc8,0x44,0x0f,0xb6,0x42,0x02,0x41,0xc1,0xe0,0x10,0x41,0x0b,0xc8,0x0f,0xb6,0x52,0x03,0xc1,0xe2,0x18,0x0b,0xd1,0x48,0x8b,0x4c,0x24,0x40,0x48,0x89,0x51,0x10,0x48,0x8b,0x44,0x24,0x48,0x48,0x8b,0x10,0x39,0x12,0x48,0x81,0xc2,0x28,0x07,0x00,0x00,0x8b,0x40,0x08,0xff,0xc8,0x0f,0xaf,0x42,0x18,0x39,0x12,0x4c,0x8d,0x42,0x20,0x03,0x42,0x0c,0x89,0x44,0x24,0x5c,0x8b,0xd0,0x48,0x83,0xc2,0x04,0x4c,0x89,0x44,0x24,0x20,0x45,0x8b,0x48,0x08,0x4d,0x63,0xc9,0x49,0x3b,0xd1,0x76,0x05,0xe8,0x02,0xd8,0xeb,0xfc,0x8b,0x44,0x24,0x5c,0x48,0x63,0xd0,0x4c,0x8b,0x44,0x24,0x20,0x49,0x03,0x10,0x0f,0xb6,0x02,0x44,0x0f,0xb6,0x42,0x01,0x41,0xc1,0xe0,0x08,0x41,0x0b,0xc0,0x44,0x0f,0xb6,0x42,0x02,0x41,0xc1,0xe0,0x10,0x41,0x0b,0xc0,0x0f,0xb6,0x52,0x03,0xc1,0xe2,0x18,0x0b,0xd0,0x48,0x8b,0x4c,0x24,0x40,0x89,0x51,0x08,0x41,0xff,0xc5,0x41,0x8b,0xcd,0x49,0x63,0xd6,0x48,0x3b,0xca,0x0f,0x8c,0xba,0xfd,0xff,0xff,0x33,0xf6,0x45,0x85,0xe4,0x7e,0x24,0x48,0x63,0xce,0x48,0x8d,0x0c,0x49,0x49,0x8d,0x2c,0xcf,0x48,0x8b,0x4d,0x00,0x48,0x8b,0xd7,0x39,0x09,0xe8,0xed,0x6c,0x2e,0x58,0x85,0xc0,0x75,0x1d,0xff,0xc6,0x41,0x3b,0xf4,0x7c,0xdc,0x33,0xc0,0x48,0x81,0xc4,0xe8,0x00,0x00,0x00,0x5b,0x5d,0x5e,0x5f,0x41,0x5c,0x41,0x5d,0x41,0x5e,0x41,0x5f,0xc3,0x48,0x8b,0x4d,0x10,0x0f,0xb7,0xf1,0x48,0x8d,0x8c,0x24,0xd8,0x00,0x00,0x00,0xe8,0x38,0xe7,0xeb,0xfc,0x44,0x8b,0xc8,0x48,0x8b,0x55,0x10,0x0f,0xb7,0xd2,0x44,0x2b,0xca,0x48,0x8d,0x94,0x24,0xb8,0x00,0x00,0x00,0x48,0x8d,0x8c,0x24,0xd8,0x00,0x00,0x00,0x44,0x8b,0xc6,0xe8,0x23,0xe7,0xeb,0xfc,0x48,0x8d,0x8c,0x24,0xb8,0x00,0x00,0x00,0xe8,0x26,0xa4,0xbb,0xfe,0x8b,0xf0,0x48,0x8b,0xac,0x24,0xd0,0x00,0x00,0x00,0x33,0xc9,0x48,0x89,0x4c,0x24,0x50,0x48,0x8d,0x4c,0x24,0x50,0x48,0x8b,0xd7,0xe8,0x38,0x9d,0xa4,0xfd,0x48,0x8b,0x44,0x24,0x50,0x8b,0xd6,0xc4,0xe1,0xf9,0x6e,0xc5,0xc4,0xe3,0xf9,0x22,0xc2,0x01,0x33,0xd2,0x48,0x8d,0x8c,0x24,0x98,0x00,0x00,0x00,0xc5,0xf0,0x57,0xc9,0xc5,0xfa,0x7f,0x09,0x48,0x89,0x51,0x10,0x48,0x8d,0x94,0x24,0x98,0x00,0x00,0x00,0x48,0x89,0x02,0x48,0x8d,0x84,0x24,0xa0,0x00,0x00,0x00,0xc5,0xf9,0x11,0x00,0x48,0x8b,0xfb,0x48,0x8d,0xb4,0x24,0x98,0x00,0x00,0x00,0xe8,0xb9,0x6d,0x50,0x5a,0x48,0xa5,0x48,0xa5,0xb8,0x01,0x00,0x00,0x00,0x48,0x81,0xc4,0xe8,0x00,0x00,0x00,0x5b,0x5d,0x5e,0x5f,0x41,0x5c,0x41,0x5d,0x41,0x5e,0x41,0x5f,0xc3};

        public static ReadOnlySpan<byte> ResourceSegments_ᐤᐤ  =>  new byte[1089]{0x41,0x57,0x41,0x56,0x41,0x55,0x41,0x54,0x57,0x56,0x55,0x53,0x48,0x81,0xec,0xf8,0x00,0x00,0x00,0xc5,0xf8,0x77,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x50,0xb9,0x2a,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x8b,0xd9,0x48,0x8b,0xea,0x48,0x8b,0x4b,0x18,0x8b,0x01,0x8b,0xb1,0x28,0x07,0x00,0x00,0x48,0xb9,0xb8,0x49,0x95,0xdc,0xfd,0x7f,0x00,0x00,0xe8,0x45,0x7b,0x50,0x5a,0x89,0x70,0x08,0x48,0x8b,0xd0,0x48,0x8d,0x8c,0x24,0x88,0x00,0x00,0x00,0xe8,0xe2,0xf3,0xff,0xff,0x48,0x8b,0xb4,0x24,0x88,0x00,0x00,0x00,0x8b,0xbc,0x24,0x90,0x00,0x00,0x00,0x48,0x63,0xcf,0xe8,0xeb,0xf3,0xff,0xff,0x48,0x85,0xc0,0x75,0x08,0x45,0x33,0xf6,0x45,0x33,0xff,0xeb,0x08,0x4c,0x8d,0x70,0x10,0x44,0x8b,0x78,0x08,0x45,0x33,0xe4,0x48,0x63,0xcf,0x48,0x85,0xc9,0x0f,0x8e,0x2d,0x02,0x00,0x00,0x49,0x63,0xcc,0x8b,0x0c,0x8e,0x48,0x8b,0x53,0x18,0x8b,0x02,0x48,0x89,0x54,0x24,0x78,0x89,0x8c,0x24,0x80,0x00,0x00,0x00,0x4c,0x8d,0x6c,0x24,0x78,0x49,0x63,0xcc,0x48,0x8d,0x0c,0x49,0x49,0x8d,0x04,0xce,0x48,0x89,0x44,0x24,0x48,0x49,0x8b,0x4d,0x00,0x39,0x09,0x48,0x81,0xc1,0x28,0x07,0x00,0x00,0x41,0x8b,0x55,0x08,0xe8,0x4c,0xdd,0xb1,0xfb,0x48,0x8b,0x53,0x18,0x8b,0x0a,0x48,0x8d,0x4a,0x70,0x48,0x8b,0x52,0x38,0x48,0x89,0x54,0x24,0x40,0xa9,0x00,0x00,0x00,0x80,0x0f,0x85,0xb2,0x00,0x00,0x00,0x45,0x33,0xc0,0x44,0x89,0x44,0x24,0x68,0x44,0x8b,0xc0,0x41,0xc1,0xe8,0x1d,0x45,0x0f,0xb6,0xc0,0x41,0x83,0xf8,0x01,0x74,0x05,0x45,0x33,0xc0,0xeb,0x06,0x41,0xb8,0x2e,0x00,0x00,0x00,0x45,0x0f,0xb7,0xc0,0x44,0x89,0x44,0x24,0x74,0x39,0x09,0x48,0x83,0xc1,0x08,0x25,0xff,0xff,0xff,0x1f,0x89,0x44,0x24,0x64,0x44,0x8b,0xc8,0x48,0x89,0x4c,0x24,0x38,0x44,0x8b,0x51,0x08,0x4d,0x63,0xd2,0x4d,0x3b,0xca,0x76,0x45,0xe8,0x29,0xd5,0xeb,0xfc,0x8b,0x44,0x24,0x64,0x4c,0x8d,0x44,0x24,0x68,0x48,0x8b,0x4c,0x24,0x38,0x89,0x44,0x24,0x64,0x8b,0xd0,0x44,0x8b,0x4c,0x24,0x74,0xe8,0xd3,0xb5,0xbb,0xfe,0x8b,0x4c,0x24,0x64,0x48,0x63,0xd1,0x48,0x8b,0x4c,0x24,0x38,0x48,0x03,0x11,0x85,0xc0,0x75,0x15,0x48,0xb9,0x60,0x30,0xc6,0x13,0xd3,0x01,0x00,0x00,0x48,0x8b,0x11,0xeb,0x1b,0x8b,0x44,0x24,0x64,0xeb,0xbe,0x48,0x8b,0x4c,0x24,0x40,0x44,0x8b,0xc0,0x48,0x8b,0x01,0x48,0x8b,0x40,0x40,0xff,0x50,0x20,0x48,0x8b,0xd0,0xeb,0x0f,0x8b,0xd0,0x4c,0x8b,0x44,0x24,0x40,0xe8,0xe8,0xd4,0xb1,0xfb,0x48,0x8b,0xd0,0x48,0x8b,0x4c,0x24,0x48,0xe8,0xdb,0x6a,0x50,0x5a,0x49,0x8b,0x4d,0x00,0x39,0x09,0x48,0x8d,0x81,0x28,0x07,0x00,0x00,0x41,0x8b,0x55,0x08,0xff,0xca,0x0f,0xaf,0x50,0x18,0x39,0x00,0x48,0x8d,0x48,0x20,0x03,0x50,0x08,0x8b,0xc2,0x89,0x44,0x24,0x60,0x8b,0xd0,0x48,0x83,0xc2,0x04,0x48,0x89,0x4c,0x24,0x30,0x44,0x8b,0x41,0x08,0x4d,0x63,0xc0,0x49,0x3b,0xd0,0x76,0x05,0xe8,0x71,0xd4,0xeb,0xfc,0x8b,0x44,0x24,0x60,0x48,0x63,0xc0,0x48,0x8b,0x4c,0x24,0x30,0x48,0x03,0x01,0x0f,0xb6,0x10,0x0f,0xb6,0x48,0x01,0xc1,0xe1,0x08,0x0b,0xd1,0x0f,0xb6,0x48,0x02,0xc1,0xe1,0x10,0x0b,0xd1,0x0f,0xb6,0x40,0x03,0xc1,0xe0,0x18,0x0b,0xc2,0x48,0x8b,0x54,0x24,0x48,0x48,0x89,0x42,0x10,0x49,0x8b,0x4d,0x00,0x39,0x09,0x48,0x8d,0x81,0x28,0x07,0x00,0x00,0x45,0x8b,0x6d,0x08,0x41,0xff,0xcd,0x44,0x0f,0xaf,0x68,0x18,0x39,0x00,0x48,0x8d,0x48,0x20,0x44,0x03,0x68,0x0c,0x41,0x8b,0xc5,0x48,0x83,0xc0,0x04,0x48,0x89,0x4c,0x24,0x28,0x44,0x8b,0x41,0x08,0x4d,0x63,0xc0,0x49,0x3b,0xc0,0x76,0x05,0xe8,0xfb,0xd3,0xeb,0xfc,0x49,0x63,0xc5,0x48,0x8b,0x4c,0x24,0x28,0x48,0x03,0x01,0x0f,0xb6,0x08,0x44,0x0f,0xb6,0x40,0x01,0x41,0xc1,0xe0,0x08,0x41,0x0b,0xc8,0x44,0x0f,0xb6,0x40,0x02,0x41,0xc1,0xe0,0x10,0x41,0x0b,0xc8,0x0f,0xb6,0x40,0x03,0xc1,0xe0,0x18,0x0b,0xc8,0x48,0x8b,0x54,0x24,0x48,0x89,0x4a,0x08,0x41,0xff,0xc4,0x41,0x8b,0xcc,0x48,0x63,0xd7,0x48,0x3b,0xca,0x0f,0x8c,0xd3,0xfd,0xff,0xff,0x41,0x8b,0xd7,0x48,0x8d,0x8c,0x24,0xe8,0x00,0x00,0x00,0xe8,0x8a,0xf6,0xff,0xff,0x45,0x33,0xe4,0x49,0x63,0xcf,0x48,0x85,0xc9,0x0f,0x8e,0x2f,0x01,0x00,0x00,0x49,0x63,0xcc,0x48,0x8d,0x3c,0x49,0x48,0xc1,0xe7,0x03,0x49,0x8d,0x34,0x3e,0x4c,0x8b,0x6b,0x10,0x49,0x83,0x7d,0x10,0x00,0x75,0x08,0x49,0x8b,0xcd,0xe8,0xe9,0x5f,0xbb,0xfe,0x49,0x8b,0x4d,0x10,0x48,0x8b,0x49,0x18,0x48,0x8b,0x49,0x20,0x48,0x89,0x8c,0x24,0xb0,0x00,0x00,0x00,0x48,0x8b,0x4b,0x10,0x48,0x8d,0x94,0x24,0xd8,0x00,0x00,0x00,0x44,0x8b,0x84,0x24,0xb0,0x00,0x00,0x00,0x39,0x09,0xe8,0xe2,0xe3,0xeb,0xfc,0x48,0x8b,0x4e,0x10,0x44,0x0f,0xb7,0xe9,0x48,0x8d,0x8c,0x24,0xd8,0x00,0x00,0x00,0xe8,0x05,0xe3,0xeb,0xfc,0x44,0x8b,0xc8,0x48,0x8b,0x56,0x10,0x0f,0xb7,0xd2,0x44,0x2b,0xca,0x48,0x8d,0x94,0x24,0xb8,0x00,0x00,0x00,0x48,0x8d,0x8c,0x24,0xd8,0x00,0x00,0x00,0x45,0x8b,0xc5,0xe8,0xf0,0xe2,0xeb,0xfc,0x48,0x8d,0x8c,0x24,0xb8,0x00,0x00,0x00,0xe8,0xf3,0x9f,0xbb,0xfe,0x44,0x8b,0xe8,0x48,0x8b,0x84,0x24,0xd0,0x00,0x00,0x00,0x48,0x89,0x44,0x24,0x58,0x48,0x8b,0x8c,0x24,0xe8,0x00,0x00,0x00,0x48,0x03,0xf9,0x48,0x8b,0x16,0x33,0xc9,0x48,0x89,0x4c,0x24,0x50,0x48,0x8d,0x4c,0x24,0x50,0xe8,0xf4,0x98,0xa4,0xfd,0x48,0x8b,0x44,0x24,0x50,0x41,0x8b,0xd5,0x48,0x8b,0x74,0x24,0x58,0xc4,0xe1,0xf9,0x6e,0xc6,0xc4,0xe3,0xf9,0x22,0xc2,0x01,0x33,0xd2,0x48,0x8d,0x8c,0x24,0x98,0x00,0x00,0x00,0xc5,0xf0,0x57,0xc9,0xc5,0xfa,0x7f,0x09,0x48,0x89,0x51,0x10,0x48,0x8d,0x94,0x24,0x98,0x00,0x00,0x00,0x48,0x89,0x02,0x48,0x8d,0x84,0x24,0xa0,0x00,0x00,0x00,0xc5,0xf9,0x11,0x00,0x48,0x8d,0xb4,0x24,0x98,0x00,0x00,0x00,0xe8,0x72,0x69,0x50,0x5a,0x48,0xa5,0x48,0xa5,0x41,0xff,0xc4,0x41,0x8b,0xc4,0x49,0x63,0xd7,0x48,0x3b,0xc2,0x0f,0x8c,0xd1,0xfe,0xff,0xff,0x48,0x8b,0x84,0x24,0xe8,0x00,0x00,0x00,0x8b,0x94,0x24,0xf0,0x00,0x00,0x00,0x48,0x89,0x45,0x00,0x89,0x55,0x08,0x48,0x8b,0xc5,0x48,0x81,0xc4,0xf8,0x00,0x00,0x00,0x5b,0x5d,0x5e,0x5f,0x41,0x5c,0x41,0x5d,0x41,0x5e,0x41,0x5f,0xc3};

        public static ReadOnlySpan<byte> ManifestResourceDescriptions_ᐤᐤ  =>  new byte[728]{0x41,0x57,0x41,0x56,0x41,0x55,0x41,0x54,0x57,0x56,0x55,0x53,0x48,0x81,0xec,0x88,0x00,0x00,0x00,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x58,0xb9,0x0c,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x8b,0xf1,0x48,0x8b,0xfa,0x48,0x8b,0x4e,0x18,0x8b,0x01,0x8b,0x99,0x28,0x07,0x00,0x00,0x48,0xb9,0xb8,0x49,0x95,0xdc,0xfd,0x7f,0x00,0x00,0xe8,0xd8,0x76,0x50,0x5a,0x89,0x58,0x08,0x48,0x8b,0xd0,0x48,0x8d,0x4c,0x24,0x78,0xe8,0x78,0xef,0xff,0xff,0x48,0x8b,0x5c,0x24,0x78,0x8b,0xac,0x24,0x80,0x00,0x00,0x00,0x48,0x63,0xcd,0xe8,0x84,0xef,0xff,0xff,0x48,0x85,0xc0,0x75,0x08,0x45,0x33,0xf6,0x45,0x33,0xff,0xeb,0x08,0x4c,0x8d,0x70,0x10,0x44,0x8b,0x78,0x08,0x45,0x33,0xe4,0x48,0x63,0xcd,0x48,0x85,0xc9,0x0f,0x8e,0x2a,0x02,0x00,0x00,0x49,0x63,0xcc,0x8b,0x0c,0x8b,0x48,0x8b,0x56,0x18,0x8b,0x02,0x48,0x89,0x54,0x24,0x68,0x89,0x4c,0x24,0x70,0x4c,0x8d,0x6c,0x24,0x68,0x49,0x63,0xcc,0x48,0x8d,0x0c,0x49,0x49,0x8d,0x04,0xce,0x48,0x89,0x44,0x24,0x48,0x49,0x8b,0x4d,0x00,0x39,0x09,0x48,0x81,0xc1,0x28,0x07,0x00,0x00,0x41,0x8b,0x55,0x08,0xe8,0xe8,0xd8,0xb1,0xfb,0x48,0x8b,0x56,0x18,0x8b,0x0a,0x48,0x8d,0x4a,0x70,0x48,0x8b,0x52,0x38,0x48,0x89,0x54,0x24,0x40,0xa9,0x00,0x00,0x00,0x80,0x0f,0x85,0xb2,0x00,0x00,0x00,0x45,0x33,0xc0,0x44,0x89,0x44,0x24,0x58,0x44,0x8b,0xc0,0x41,0xc1,0xe8,0x1d,0x45,0x0f,0xb6,0xc0,0x41,0x83,0xf8,0x01,0x74,0x05,0x45,0x33,0xc0,0xeb,0x06,0x41,0xb8,0x2e,0x00,0x00,0x00,0x45,0x0f,0xb7,0xc0,0x44,0x89,0x44,0x24,0x64,0x39,0x09,0x48,0x83,0xc1,0x08,0x25,0xff,0xff,0xff,0x1f,0x89,0x44,0x24,0x54,0x44,0x8b,0xc8,0x48,0x89,0x4c,0x24,0x38,0x44,0x8b,0x51,0x08,0x4d,0x63,0xd2,0x4d,0x3b,0xca,0x76,0x45,0xe8,0xc5,0xd0,0xeb,0xfc,0x8b,0x44,0x24,0x54,0x4c,0x8d,0x44,0x24,0x58,0x48,0x8b,0x4c,0x24,0x38,0x89,0x44,0x24,0x54,0x8b,0xd0,0x44,0x8b,0x4c,0x24,0x64,0xe8,0x6f,0xb1,0xbb,0xfe,0x8b,0x4c,0x24,0x54,0x48,0x63,0xd1,0x48,0x8b,0x4c,0x24,0x38,0x48,0x03,0x11,0x85,0xc0,0x75,0x15,0x48,0xb9,0x60,0x30,0xc6,0x13,0xd3,0x01,0x00,0x00,0x48,0x8b,0x11,0xeb,0x1b,0x8b,0x44,0x24,0x54,0xeb,0xbe,0x48,0x8b,0x4c,0x24,0x40,0x44,0x8b,0xc0,0x48,0x8b,0x01,0x48,0x8b,0x40,0x40,0xff,0x50,0x20,0x48,0x8b,0xd0,0xeb,0x0f,0x8b,0xd0,0x4c,0x8b,0x44,0x24,0x40,0xe8,0x84,0xd0,0xb1,0xfb,0x48,0x8b,0xd0,0x48,0x8b,0x4c,0x24,0x48,0xe8,0x77,0x66,0x50,0x5a,0x49,0x8b,0x4d,0x00,0x39,0x09,0x48,0x8d,0x81,0x28,0x07,0x00,0x00,0x41,0x8b,0x55,0x08,0xff,0xca,0x0f,0xaf,0x50,0x18,0x39,0x00,0x48,0x8d,0x48,0x20,0x03,0x50,0x08,0x8b,0xc2,0x89,0x44,0x24,0x50,0x8b,0xd0,0x48,0x83,0xc2,0x04,0x48,0x89,0x4c,0x24,0x30,0x44,0x8b,0x41,0x08,0x4d,0x63,0xc0,0x49,0x3b,0xd0,0x76,0x05,0xe8,0x0d,0xd0,0xeb,0xfc,0x8b,0x44,0x24,0x50,0x48,0x63,0xc0,0x48,0x8b,0x4c,0x24,0x30,0x48,0x03,0x01,0x0f,0xb6,0x10,0x0f,0xb6,0x48,0x01,0xc1,0xe1,0x08,0x0b,0xd1,0x0f,0xb6,0x48,0x02,0xc1,0xe1,0x10,0x0b,0xd1,0x0f,0xb6,0x40,0x03,0xc1,0xe0,0x18,0x0b,0xc2,0x48,0x8b,0x54,0x24,0x48,0x48,0x89,0x42,0x10,0x49,0x8b,0x4d,0x00,0x39,0x09,0x48,0x8d,0x81,0x28,0x07,0x00,0x00,0x45,0x8b,0x6d,0x08,0x41,0xff,0xcd,0x44,0x0f,0xaf,0x68,0x18,0x39,0x00,0x48,0x8d,0x48,0x20,0x44,0x03,0x68,0x0c,0x41,0x8b,0xc5,0x48,0x83,0xc0,0x04,0x48,0x89,0x4c,0x24,0x28,0x44,0x8b,0x41,0x08,0x4d,0x63,0xc0,0x49,0x3b,0xc0,0x76,0x05,0xe8,0x97,0xcf,0xeb,0xfc,0x49,0x63,0xc5,0x48,0x8b,0x4c,0x24,0x28,0x48,0x03,0x01,0x0f,0xb6,0x08,0x44,0x0f,0xb6,0x40,0x01,0x41,0xc1,0xe0,0x08,0x41,0x0b,0xc8,0x44,0x0f,0xb6,0x40,0x02,0x41,0xc1,0xe0,0x10,0x41,0x0b,0xc8,0x0f,0xb6,0x40,0x03,0xc1,0xe0,0x18,0x0b,0xc1,0x48,0x8b,0x54,0x24,0x48,0x89,0x42,0x08,0x41,0xff,0xc4,0x41,0x8b,0xc4,0x48,0x63,0xd5,0x48,0x3b,0xc2,0x0f,0x8c,0xd6,0xfd,0xff,0xff,0x4c,0x89,0x37,0x44,0x89,0x7f,0x08,0x48,0x8b,0xc7,0x48,0x81,0xc4,0x88,0x00,0x00,0x00,0x5b,0x5d,0x5e,0x5f,0x41,0x5c,0x41,0x5d,0x41,0x5e,0x41,0x5f,0xc3};

        public static ReadOnlySpan<byte> ManifestResourceHandles_ᐤᐤ  =>  new byte[84]{0x57,0x56,0x48,0x83,0xec,0x38,0x33,0xc0,0x48,0x89,0x44,0x24,0x28,0x48,0x8b,0xf2,0x48,0x8b,0x49,0x18,0x8b,0x01,0x8b,0xb9,0x28,0x07,0x00,0x00,0x48,0xb9,0xb8,0x49,0x95,0xdc,0xfd,0x7f,0x00,0x00,0xe8,0xf5,0x73,0x50,0x5a,0x89,0x78,0x08,0x48,0x8b,0xd0,0x48,0x8d,0x4c,0x24,0x28,0xe8,0x95,0xec,0xff,0xff,0x48,0x8b,0x44,0x24,0x28,0x8b,0x54,0x24,0x30,0x48,0x89,0x06,0x89,0x56,0x08,0x48,0x8b,0xc6,0x48,0x83,0xc4,0x38,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> Read_ᐤManifestResourceHandleᐤ  =>  new byte[34]{0x57,0x56,0x0f,0x1f,0x00,0x48,0x8b,0xf2,0x48,0x8b,0x51,0x18,0x8b,0x0a,0x41,0x8b,0xf8,0x48,0x8b,0xce,0xe8,0xa7,0x64,0x50,0x5a,0x89,0x7e,0x08,0x48,0x8b,0xc6,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> Read_ᐤManifestResourceHandleㆍManifestResourceᕀoutᐤ  =>  new byte[45]{0x57,0x56,0x50,0x66,0x90,0x49,0x8b,0xf0,0x48,0x8b,0x49,0x18,0x8b,0x01,0x48,0x89,0x0c,0x24,0x8b,0xfa,0x48,0x8b,0x14,0x24,0x48,0x8b,0xce,0xe8,0x60,0x64,0x50,0x5a,0x89,0x7e,0x08,0x48,0x8b,0xc6,0x48,0x83,0xc4,0x08,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> Read_ᐤrspanManifestResourceHandleㆍspanCliManifestResourceInfoᐤ  =>  new byte[637]{0x41,0x57,0x41,0x56,0x41,0x55,0x41,0x54,0x57,0x56,0x55,0x53,0x48,0x83,0xec,0x68,0x33,0xc0,0x48,0x89,0x44,0x24,0x58,0x48,0x89,0x44,0x24,0x60,0x48,0x89,0x44,0x24,0x48,0x48,0x8b,0xf9,0x48,0x8b,0xea,0x49,0x8b,0xf0,0x49,0x8b,0xd9,0x44,0x8b,0x76,0x08,0x45,0x33,0xff,0x49,0x63,0xce,0x48,0x85,0xc9,0x0f,0x8e,0x1c,0x02,0x00,0x00,0x48,0x8b,0x0e,0x49,0x63,0xd7,0x8b,0x0c,0x91,0x48,0x8b,0x57,0x18,0x8b,0x02,0x48,0x89,0x54,0x24,0x58,0x89,0x4c,0x24,0x60,0x4c,0x8d,0x64,0x24,0x58,0x48,0x8b,0x0b,0x49,0x63,0xd7,0x48,0x8d,0x14,0x52,0x4c,0x8d,0x2c,0xd1,0x49,0x8b,0x0c,0x24,0x39,0x09,0x48,0x81,0xc1,0x28,0x07,0x00,0x00,0x41,0x8b,0x54,0x24,0x08,0xe8,0x36,0xd5,0xb1,0xfb,0x48,0x8b,0x57,0x18,0x8b,0x0a,0x48,0x8d,0x4a,0x70,0x48,0x8b,0x52,0x38,0x48,0x89,0x54,0x24,0x38,0xa9,0x00,0x00,0x00,0x80,0x0f,0x85,0xb2,0x00,0x00,0x00,0x45,0x33,0xc0,0x44,0x89,0x44,0x24,0x48,0x44,0x8b,0xc0,0x41,0xc1,0xe8,0x1d,0x45,0x0f,0xb6,0xc0,0x41,0x83,0xf8,0x01,0x74,0x05,0x45,0x33,0xc0,0xeb,0x06,0x41,0xb8,0x2e,0x00,0x00,0x00,0x45,0x0f,0xb7,0xc0,0x44,0x89,0x44,0x24,0x54,0x39,0x09,0x48,0x83,0xc1,0x08,0x25,0xff,0xff,0xff,0x1f,0x89,0x44,0x24,0x44,0x44,0x8b,0xc8,0x48,0x89,0x4c,0x24,0x30,0x44,0x8b,0x51,0x08,0x4d,0x63,0xd2,0x4d,0x3b,0xca,0x76,0x45,0xe8,0x13,0xcd,0xeb,0xfc,0x8b,0x44,0x24,0x44,0x4c,0x8d,0x44,0x24,0x48,0x48,0x8b,0x4c,0x24,0x30,0x89,0x44,0x24,0x44,0x8b,0xd0,0x44,0x8b,0x4c,0x24,0x54,0xe8,0xbd,0xad,0xbb,0xfe,0x8b,0x4c,0x24,0x44,0x48,0x63,0xd1,0x48,0x8b,0x4c,0x24,0x30,0x48,0x03,0x11,0x85,0xc0,0x75,0x15,0x48,0xb9,0x60,0x30,0xc6,0x13,0xd3,0x01,0x00,0x00,0x48,0x8b,0x11,0xeb,0x1b,0x8b,0x44,0x24,0x44,0xeb,0xbe,0x48,0x8b,0x4c,0x24,0x38,0x44,0x8b,0xc0,0x48,0x8b,0x01,0x48,0x8b,0x40,0x40,0xff,0x50,0x20,0x48,0x8b,0xd0,0xeb,0x0f,0x8b,0xd0,0x4c,0x8b,0x44,0x24,0x38,0xe8,0xd2,0xcc,0xb1,0xfb,0x48,0x8b,0xd0,0x49,0x8b,0xcd,0xe8,0xc7,0x62,0x50,0x5a,0x49,0x8b,0x0c,0x24,0x39,0x09,0x48,0x8d,0x81,0x28,0x07,0x00,0x00,0x41,0x8b,0x54,0x24,0x08,0xff,0xca,0x0f,0xaf,0x50,0x18,0x39,0x00,0x48,0x8d,0x48,0x20,0x03,0x50,0x08,0x8b,0xc2,0x89,0x44,0x24,0x40,0x8b,0xd0,0x48,0x83,0xc2,0x04,0x48,0x89,0x4c,0x24,0x28,0x44,0x8b,0x41,0x08,0x4d,0x63,0xc0,0x49,0x3b,0xd0,0x76,0x05,0xe8,0x5c,0xcc,0xeb,0xfc,0x8b,0x44,0x24,0x40,0x48,0x63,0xc0,0x48,0x8b,0x4c,0x24,0x28,0x48,0x03,0x01,0x0f,0xb6,0x10,0x0f,0xb6,0x48,0x01,0xc1,0xe1,0x08,0x0b,0xd1,0x0f,0xb6,0x48,0x02,0xc1,0xe1,0x10,0x0b,0xd1,0x0f,0xb6,0x40,0x03,0xc1,0xe0,0x18,0x0b,0xc2,0x49,0x89,0x45,0x10,0x49,0x8b,0x0c,0x24,0x39,0x09,0x48,0x8d,0x81,0x28,0x07,0x00,0x00,0x45,0x8b,0x64,0x24,0x08,0x41,0xff,0xcc,0x44,0x0f,0xaf,0x60,0x18,0x39,0x00,0x48,0x8d,0x50,0x20,0x44,0x03,0x60,0x0c,0x41,0x8b,0xc4,0x48,0x83,0xc0,0x04,0x48,0x89,0x54,0x24,0x20,0x8b,0x4a,0x08,0x48,0x63,0xc9,0x48,0x3b,0xc1,0x76,0x05,0xe8,0xeb,0xcb,0xeb,0xfc,0x49,0x63,0xc4,0x48,0x8b,0x54,0x24,0x20,0x48,0x03,0x02,0x0f,0xb6,0x10,0x0f,0xb6,0x48,0x01,0xc1,0xe1,0x08,0x0b,0xd1,0x0f,0xb6,0x48,0x02,0xc1,0xe1,0x10,0x0b,0xd1,0x0f,0xb6,0x40,0x03,0xc1,0xe0,0x18,0x0b,0xc2,0x41,0x89,0x45,0x08,0x41,0xff,0xc7,0x41,0x8b,0xc7,0x49,0x63,0xd6,0x48,0x3b,0xc2,0x0f,0x8c,0xe4,0xfd,0xff,0xff,0x48,0x8b,0xfd,0x48,0x8b,0xf3,0xe8,0x99,0x62,0x50,0x5a,0x48,0xa5,0x48,0x8b,0xc5,0x48,0x83,0xc4,0x68,0x5b,0x5d,0x5e,0x5f,0x41,0x5c,0x41,0x5d,0x41,0x5e,0x41,0x5f,0xc3};

        public static ReadOnlySpan<byte> Read_ᐤManifestResourceᕀinㆍCliManifestResourceInfoᕀrefᐤ  =>  new byte[129]{0x57,0x56,0x53,0x48,0x83,0xec,0x20,0x48,0x8b,0xd9,0x48,0x8b,0xf2,0x49,0x8b,0xf8,0x48,0x8b,0x0e,0x39,0x09,0x48,0x81,0xc1,0x28,0x07,0x00,0x00,0x8b,0x56,0x08,0xe8,0xe4,0xd2,0xb1,0xfb,0x8b,0xd0,0x4c,0x8b,0x43,0x18,0x41,0x8b,0x08,0x49,0x8d,0x48,0x70,0x4d,0x8b,0x40,0x38,0xe8,0x16,0xcb,0xb1,0xfb,0x48,0x8b,0xd0,0x48,0x8b,0xcf,0xe8,0x3b,0x61,0x50,0x5a,0x48,0x8b,0x0e,0x39,0x09,0x48,0x81,0xc1,0x28,0x07,0x00,0x00,0x8b,0x56,0x08,0xe8,0xbf,0xd2,0xb1,0xfb,0x8b,0xc8,0x48,0x89,0x4f,0x10,0x48,0x8b,0x0e,0x39,0x09,0x48,0x81,0xc1,0x28,0x07,0x00,0x00,0x8b,0x56,0x08,0xe8,0xad,0xd2,0xb1,0xfb,0x89,0x47,0x08,0x48,0x8b,0xc7,0x48,0x83,0xc4,0x20,0x5b,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> MethodDefinitionHandles_ᐤᐤ  =>  new byte[119]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xec,0x30,0x33,0xc0,0x48,0x89,0x44,0x24,0x20,0x48,0x8b,0xf2,0x48,0x8b,0x79,0x18,0x8b,0x0f,0x8b,0x9f,0xb8,0x01,0x00,0x00,0x48,0xb9,0x70,0x4c,0x7b,0xdb,0xfd,0x7f,0x00,0x00,0xe8,0xa1,0x6f,0x50,0x5a,0x48,0x8b,0xe8,0x4c,0x8d,0x75,0x08,0x49,0x8b,0xce,0x48,0x8b,0xd7,0xe8,0x9f,0x60,0x50,0x5a,0x41,0xc7,0x46,0x08,0x01,0x00,0x00,0x00,0x41,0x89,0x5e,0x0c,0x48,0x8b,0xd5,0x48,0x8d,0x4c,0x24,0x20,0xe8,0xde,0xee,0xff,0xff,0x48,0x8b,0x44,0x24,0x20,0x8b,0x54,0x24,0x28,0x48,0x89,0x06,0x89,0x56,0x08,0x48,0x8b,0xc6,0x48,0x83,0xc4,0x30,0x5b,0x5d,0x5e,0x5f,0x41,0x5e,0xc3};

        public static ReadOnlySpan<byte> Read_ᐤMethodDefinitionㆍMethodBodyBlockᕀrefᐤ  =>  new byte[86]{0x57,0x56,0x48,0x83,0xec,0x28,0x49,0x8b,0xf0,0x48,0x8b,0x02,0x8b,0x52,0x08,0x48,0x8b,0x79,0x10,0x8b,0xca,0xc1,0xe9,0x18,0x0f,0xb6,0xc9,0x85,0xc9,0x75,0x16,0x39,0x00,0x48,0x8d,0x88,0xb8,0x01,0x00,0x00,0x81,0xe2,0xff,0xff,0xff,0x00,0xe8,0x45,0xcc,0xb1,0xfb,0xeb,0x02,0x33,0xc0,0x48,0x8b,0xcf,0x8b,0xd0,0xe8,0x4f,0x26,0xec,0xfc,0x48,0x8b,0xd0,0x48,0x8b,0xce,0xe8,0xf4,0x5f,0x50,0x5a,0x48,0x8b,0xc6,0x48,0x83,0xc4,0x28,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> Read_ᐤMethodDefinitionHandleᐤ  =>  new byte[64]{0x57,0x56,0x53,0x48,0x83,0xec,0x20,0x48,0x8b,0xf2,0x48,0x8b,0x79,0x18,0x41,0x8b,0xd0,0x8b,0x0f,0x83,0x7f,0x50,0x00,0x75,0x04,0x8b,0xda,0xeb,0x0a,0x48,0x8b,0xcf,0xe8,0xcb,0xd3,0xb1,0xfb,0x8b,0xd8,0x48,0x8b,0xd7,0x48,0x8b,0xce,0xe8,0x9e,0x5f,0x50,0x5a,0x89,0x5e,0x08,0x48,0x8b,0xc6,0x48,0x83,0xc4,0x20,0x5b,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> Read_ᐤMethodDefinitionHandleㆍMethodDefinitionᕀrefᐤ  =>  new byte[61]{0x57,0x56,0x53,0x48,0x83,0xec,0x20,0x49,0x8b,0xf0,0x48,0x8b,0x79,0x18,0x8b,0x0f,0x83,0x7f,0x50,0x00,0x75,0x04,0x8b,0xda,0xeb,0x0a,0x48,0x8b,0xcf,0xe8,0x6e,0xd3,0xb1,0xfb,0x8b,0xd8,0x48,0x8b,0xd7,0x48,0x8b,0xce,0xe8,0x41,0x5f,0x50,0x5a,0x89,0x5e,0x08,0x48,0x8b,0xc6,0x48,0x83,0xc4,0x20,0x5b,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> Read_ᐤrspanMethodDefinitionHandleㆍspanMethodDefinitionᐤ  =>  new byte[139]{0x41,0x57,0x41,0x56,0x41,0x55,0x41,0x54,0x57,0x56,0x55,0x53,0x48,0x83,0xec,0x28,0x48,0x8b,0xd9,0x48,0x8b,0xf2,0x49,0x8b,0xf8,0x8b,0x6e,0x08,0x45,0x33,0xf6,0x48,0x63,0xcd,0x48,0x85,0xc9,0x7e,0x53,0x48,0x8b,0x0e,0x49,0x63,0xd6,0x8b,0x14,0x91,0x4c,0x8b,0x3f,0x4d,0x63,0xe6,0x49,0xc1,0xe4,0x04,0x4d,0x03,0xfc,0x4c,0x8b,0x63,0x18,0x41,0x8b,0x0c,0x24,0x41,0x83,0x7c,0x24,0x50,0x00,0x75,0x05,0x44,0x8b,0xea,0xeb,0x0b,0x49,0x8b,0xcc,0xe8,0xd6,0xce,0xb1,0xfb,0x44,0x8b,0xe8,0x49,0x8b,0xd4,0x49,0x8b,0xcf,0xe8,0xa8,0x5a,0x50,0x5a,0x45,0x89,0x6f,0x08,0x41,0xff,0xc6,0x41,0x8b,0xc6,0x48,0x63,0xd5,0x48,0x3b,0xc2,0x7c,0xad,0x48,0x83,0xc4,0x28,0x5b,0x5d,0x5e,0x5f,0x41,0x5c,0x41,0x5d,0x41,0x5e,0x41,0x5f,0xc3};

        public static ReadOnlySpan<byte> Read_ᐤMethodImplementationHandleᐤ  =>  new byte[34]{0x57,0x56,0x0f,0x1f,0x00,0x48,0x8b,0xf2,0x48,0x8b,0x51,0x18,0x8b,0x0a,0x41,0x8b,0xf8,0x48,0x8b,0xce,0xe8,0x47,0x5a,0x50,0x5a,0x89,0x7e,0x08,0x48,0x8b,0xc6,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> Read_ᐤMethodImplementationHandleㆍMethodImplementationᕀrefᐤ  =>  new byte[45]{0x57,0x56,0x50,0x66,0x90,0x49,0x8b,0xf0,0x48,0x8b,0x49,0x18,0x8b,0x01,0x48,0x89,0x0c,0x24,0x8b,0xfa,0x48,0x8b,0x14,0x24,0x48,0x8b,0xce,0xe8,0x00,0x5a,0x50,0x5a,0x89,0x7e,0x08,0x48,0x8b,0xc6,0x48,0x83,0xc4,0x08,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> Read_ᐤrspanMethodImplementationHandleㆍspanMethodImplementationᐤ  =>  new byte[104]{0x41,0x57,0x41,0x56,0x41,0x55,0x41,0x54,0x57,0x56,0x55,0x53,0x48,0x8b,0xd9,0x48,0x8b,0xf2,0x49,0x8b,0xf8,0x8b,0x6e,0x08,0x45,0x33,0xf6,0x48,0x63,0xd5,0x48,0x85,0xd2,0x7e,0x38,0x48,0x8b,0x16,0x49,0x63,0xce,0x44,0x8b,0x3c,0x8a,0x4c,0x8b,0x27,0x4d,0x63,0xee,0x49,0xc1,0xe5,0x04,0x4d,0x03,0xe5,0x48,0x8b,0x53,0x18,0x8b,0x0a,0x49,0x8b,0xcc,0xe8,0x88,0x59,0x50,0x5a,0x45,0x89,0x7c,0x24,0x08,0x41,0xff,0xc6,0x41,0x8b,0xc6,0x48,0x63,0xd5,0x48,0x3b,0xc2,0x7c,0xc8,0x5b,0x5d,0x5e,0x5f,0x41,0x5c,0x41,0x5d,0x41,0x5e,0x41,0x5f,0xc3};

        public static ReadOnlySpan<byte> Read_ᐤStringHandleᐤ  =>  new byte[31]{0x48,0x83,0xec,0x28,0x90,0x4c,0x8b,0x41,0x18,0x41,0x8b,0x08,0x49,0x8d,0x48,0x70,0x4d,0x8b,0x40,0x38,0xe8,0xf7,0xc2,0xb1,0xfb,0x90,0x48,0x83,0xc4,0x28,0xc3};

        public static ReadOnlySpan<byte> Read_ᐤStringHandleㆍstringᕀrefᐤ  =>  new byte[48]{0x56,0x48,0x83,0xec,0x20,0x49,0x8b,0xf0,0x4c,0x8b,0x41,0x18,0x41,0x8b,0x08,0x49,0x8d,0x48,0x70,0x4d,0x8b,0x40,0x38,0xe8,0xb4,0xc2,0xb1,0xfb,0x48,0x8b,0xd0,0x48,0x8b,0xce,0xe8,0xd9,0x58,0x50,0x5a,0x48,0x8b,0xc6,0x48,0x83,0xc4,0x20,0x5e,0xc3};

        public static ReadOnlySpan<byte> Read_ᐤTypeDefinitionHandleㆍReceiverᐸTypeDefinitionᐳᐤ  =>  new byte[74]{0x57,0x56,0x48,0x83,0xec,0x38,0x33,0xc0,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x30,0x49,0x8b,0xf0,0x48,0x8b,0x79,0x18,0x8b,0x0f,0x83,0x7f,0x50,0x00,0x75,0x02,0xeb,0x0a,0x48,0x8b,0xcf,0xe8,0x75,0xcc,0xb1,0xfb,0x8b,0xd0,0x48,0x89,0x7c,0x24,0x28,0x89,0x54,0x24,0x30,0x48,0x8d,0x54,0x24,0x28,0x48,0x8b,0x4e,0x08,0xff,0x56,0x18,0x90,0x48,0x83,0xc4,0x38,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> Read_ᐤTableSpanᐸTypeDefinitionHandleᐳㆍReceiverᐸTypeDefinitionᐳᐤ  =>  new byte[126]{0x57,0x56,0x53,0x48,0x83,0xec,0x20,0x48,0x89,0x54,0x24,0x48,0x48,0x8b,0xf1,0x49,0x8b,0xf8,0x48,0xb9,0x20,0x88,0xef,0xdc,0xfd,0x7f,0x00,0x00,0xe8,0x0f,0x67,0x50,0x5a,0x48,0x8b,0xd8,0x48,0x8d,0x4b,0x08,0x48,0x8b,0xd7,0xe8,0x40,0x58,0x50,0x5a,0x48,0x8d,0x4b,0x10,0x48,0x8b,0xd6,0xe8,0x34,0x58,0x50,0x5a,0x48,0xb9,0x30,0x5c,0xa6,0xdf,0xfd,0x7f,0x00,0x00,0xe8,0xe5,0x66,0x50,0x5a,0x48,0x8b,0xf0,0x48,0x8d,0x4e,0x08,0x48,0x8b,0xd3,0xe8,0x16,0x58,0x50,0x5a,0x48,0xb9,0xf0,0xfb,0x68,0xdc,0xfd,0x7f,0x00,0x00,0x48,0x89,0x4e,0x18,0x48,0x8d,0x4c,0x24,0x48,0x48,0x8b,0xd6,0xe8,0xb3,0x03,0x48,0xfe,0x90,0x48,0x83,0xc4,0x20,0x5b,0x5e,0x5f,0xc3};

    }
}
