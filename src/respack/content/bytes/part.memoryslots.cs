//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
// Generated   : 2021-02-26 14:33:09 -06:00
//-----------------------------------------------------------------------------
namespace Z0.ByteCode
{
    using System;
    using System.Runtime.CompilerServices;


    public static class part_memoryslots
    {
        public static ReadOnlySpan<byte> advance_ᐤMemorySlotᕀrefᐤ  =>  new byte[28]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0x01,0x3d,0xff,0x00,0x00,0x00,0x75,0x05,0xc6,0x01,0x00,0xeb,0x04,0xff,0xc0,0x88,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> retreat_ᐤMemorySlotᕀrefᐤ  =>  new byte[25]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0x01,0x85,0xc0,0x75,0x05,0xc6,0x01,0xff,0xeb,0x04,0xff,0xc8,0x88,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> format_gᐸ8uᐳᐤMemorySlotsᐸbyteᐳㆍspanstringᐤ  =>  new byte[231]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xec,0x60,0xc5,0xf8,0x77,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x28,0xb9,0x0c,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x8b,0xf2,0x8b,0x79,0x08,0x33,0xc0,0x89,0x44,0x24,0x5c,0x8b,0x44,0x24,0x5c,0x0f,0xb6,0xc0,0x48,0x83,0xc1,0x10,0x8b,0xd8,0x48,0xc1,0xe3,0x04,0x48,0x03,0xd9,0x33,0xed,0x48,0x63,0xcf,0x48,0x85,0xc9,0x0f,0x8e,0x8d,0x00,0x00,0x00,0x48,0x8b,0x0e,0x48,0x89,0x4c,0x24,0x48,0x8b,0x4e,0x08,0x89,0x4c,0x24,0x50,0xc5,0xfa,0x6f,0x44,0x24,0x48,0xc5,0xfa,0x7f,0x44,0x24,0x38,0x48,0x8b,0x4c,0x24,0x38,0x48,0x63,0xc5,0x4c,0x8d,0x34,0xc1,0x33,0xc9,0x48,0x89,0x4c,0x24,0x28,0x48,0x89,0x4c,0x24,0x30,0x48,0x63,0xcd,0x48,0xc1,0xe1,0x04,0x48,0x03,0xcb,0xc5,0xf9,0x10,0x01,0xc4,0xe1,0xf9,0x7e,0xc0,0xc5,0xf9,0x10,0x01,0xc4,0xe1,0xf9,0x7e,0xc2,0xc5,0xf9,0x10,0x01,0xc4,0xe3,0xf9,0x16,0xc1,0x01,0x8b,0xc9,0x48,0x03,0xca,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x4c,0x24,0x30,0x48,0x8d,0x4c,0x24,0x28,0xe8,0x8f,0x73,0xd7,0xfd,0x48,0x8b,0xd0,0x49,0x8b,0xce,0xe8,0x84,0xdd,0x33,0x5b,0xff,0xc5,0x8b,0xc5,0x48,0x63,0xd7,0x48,0x3b,0xc2,0x0f,0x8c,0x73,0xff,0xff,0xff,0x48,0x83,0xc4,0x60,0x5b,0x5d,0x5e,0x5f,0x41,0x5e,0xc3};

        public static ReadOnlySpan<byte> format_gᐸ16uᐳᐤMemorySlotsᐸushortᐳㆍspanstringᐤ  =>  new byte[231]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xec,0x60,0xc5,0xf8,0x77,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x28,0xb9,0x0c,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x8b,0xf2,0x8b,0x79,0x08,0x33,0xc0,0x89,0x44,0x24,0x5c,0x8b,0x44,0x24,0x5c,0x0f,0xb7,0xc0,0x48,0x83,0xc1,0x10,0x8b,0xd8,0x48,0xc1,0xe3,0x04,0x48,0x03,0xd9,0x33,0xed,0x48,0x63,0xcf,0x48,0x85,0xc9,0x0f,0x8e,0x8d,0x00,0x00,0x00,0x48,0x8b,0x0e,0x48,0x89,0x4c,0x24,0x48,0x8b,0x4e,0x08,0x89,0x4c,0x24,0x50,0xc5,0xfa,0x6f,0x44,0x24,0x48,0xc5,0xfa,0x7f,0x44,0x24,0x38,0x48,0x8b,0x4c,0x24,0x38,0x48,0x63,0xc5,0x4c,0x8d,0x34,0xc1,0x33,0xc9,0x48,0x89,0x4c,0x24,0x28,0x48,0x89,0x4c,0x24,0x30,0x48,0x63,0xcd,0x48,0xc1,0xe1,0x04,0x48,0x03,0xcb,0xc5,0xf9,0x10,0x01,0xc4,0xe1,0xf9,0x7e,0xc0,0xc5,0xf9,0x10,0x01,0xc4,0xe1,0xf9,0x7e,0xc2,0xc5,0xf9,0x10,0x01,0xc4,0xe3,0xf9,0x16,0xc1,0x01,0x8b,0xc9,0x48,0x03,0xca,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x4c,0x24,0x30,0x48,0x8d,0x4c,0x24,0x28,0xe8,0x7f,0x72,0xd7,0xfd,0x48,0x8b,0xd0,0x49,0x8b,0xce,0xe8,0x74,0xdc,0x33,0x5b,0xff,0xc5,0x8b,0xc5,0x48,0x63,0xd7,0x48,0x3b,0xc2,0x0f,0x8c,0x73,0xff,0xff,0xff,0x48,0x83,0xc4,0x60,0x5b,0x5d,0x5e,0x5f,0x41,0x5e,0xc3};

        public static ReadOnlySpan<byte> format_gᐸ32uᐳᐤMemorySlotsᐸuintᐳㆍspanstringᐤ  =>  new byte[212]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xec,0x50,0xc5,0xf8,0x77,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x20,0xb9,0x0c,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x8b,0xf2,0x8b,0x79,0x08,0x48,0x83,0xc1,0x10,0x48,0x8b,0xd9,0x33,0xed,0x48,0x63,0xcf,0x48,0x85,0xc9,0x0f,0x8e,0x8d,0x00,0x00,0x00,0x48,0x8b,0x0e,0x48,0x89,0x4c,0x24,0x40,0x8b,0x4e,0x08,0x89,0x4c,0x24,0x48,0xc5,0xfa,0x6f,0x44,0x24,0x40,0xc5,0xfa,0x7f,0x44,0x24,0x30,0x48,0x8b,0x4c,0x24,0x30,0x48,0x63,0xc5,0x4c,0x8d,0x34,0xc1,0x33,0xc9,0x48,0x89,0x4c,0x24,0x20,0x48,0x89,0x4c,0x24,0x28,0x48,0x63,0xcd,0x48,0xc1,0xe1,0x04,0x48,0x03,0xcb,0xc5,0xf9,0x10,0x01,0xc4,0xe1,0xf9,0x7e,0xc0,0xc5,0xf9,0x10,0x01,0xc4,0xe1,0xf9,0x7e,0xc2,0xc5,0xf9,0x10,0x01,0xc4,0xe3,0xf9,0x16,0xc1,0x01,0x8b,0xc9,0x48,0x03,0xca,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x4c,0x24,0x28,0x48,0x8d,0x4c,0x24,0x20,0xe8,0x82,0x71,0xd7,0xfd,0x48,0x8b,0xd0,0x49,0x8b,0xce,0xe8,0x77,0xdb,0x33,0x5b,0xff,0xc5,0x8b,0xc5,0x48,0x63,0xd7,0x48,0x3b,0xc2,0x0f,0x8c,0x73,0xff,0xff,0xff,0x48,0x83,0xc4,0x50,0x5b,0x5d,0x5e,0x5f,0x41,0x5e,0xc3};

        public static ReadOnlySpan<byte> format_gᐸ64uᐳᐤMemorySlotsᐸulongᐳㆍspanstringᐤ  =>  new byte[229]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xec,0x60,0xc5,0xf8,0x77,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x28,0xb9,0x0c,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x8b,0xf2,0x8b,0x79,0x08,0x33,0xc0,0x48,0x89,0x44,0x24,0x58,0x8b,0x44,0x24,0x58,0x48,0x83,0xc1,0x10,0x8b,0xd8,0x48,0xc1,0xe3,0x04,0x48,0x03,0xd9,0x33,0xed,0x48,0x63,0xcf,0x48,0x85,0xc9,0x0f,0x8e,0x8d,0x00,0x00,0x00,0x48,0x8b,0x0e,0x48,0x89,0x4c,0x24,0x48,0x8b,0x4e,0x08,0x89,0x4c,0x24,0x50,0xc5,0xfa,0x6f,0x44,0x24,0x48,0xc5,0xfa,0x7f,0x44,0x24,0x38,0x48,0x8b,0x4c,0x24,0x38,0x48,0x63,0xc5,0x4c,0x8d,0x34,0xc1,0x33,0xc9,0x48,0x89,0x4c,0x24,0x28,0x48,0x89,0x4c,0x24,0x30,0x48,0x63,0xcd,0x48,0xc1,0xe1,0x04,0x48,0x03,0xcb,0xc5,0xf9,0x10,0x01,0xc4,0xe1,0xf9,0x7e,0xc0,0xc5,0xf9,0x10,0x01,0xc4,0xe1,0xf9,0x7e,0xc2,0xc5,0xf9,0x10,0x01,0xc4,0xe3,0xf9,0x16,0xc1,0x01,0x8b,0xc9,0x48,0x03,0xca,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x4c,0x24,0x30,0x48,0x8d,0x4c,0x24,0x28,0xe8,0x71,0x70,0xd7,0xfd,0x48,0x8b,0xd0,0x49,0x8b,0xce,0xe8,0x66,0xda,0x33,0x5b,0xff,0xc5,0x8b,0xc5,0x48,0x63,0xd7,0x48,0x3b,0xc2,0x0f,0x8c,0x73,0xff,0xff,0xff,0x48,0x83,0xc4,0x60,0x5b,0x5d,0x5e,0x5f,0x41,0x5e,0xc3};

    }
}
