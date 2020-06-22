//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.ByteCode
{
    using System;
    using System.Runtime.CompilerServices;


    public static class seed_pointedreader
    {
        public static ReadOnlySpan<byte> Create_ᐤ8uᕀptrㆍ32iᐤ  =>  new byte[69]{0x48,0x83,0xec,0x18,0xc5,0xf8,0x77,0x48,0x8d,0x44,0x24,0x08,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x00,0x33,0xc0,0x89,0x04,0x24,0x89,0x44,0x24,0x04,0x44,0x89,0x04,0x24,0x89,0x44,0x24,0x04,0x48,0x8b,0x04,0x24,0x48,0x89,0x44,0x24,0x10,0x48,0x89,0x54,0x24,0x08,0xc5,0xfa,0x6f,0x44,0x24,0x08,0xc5,0xfa,0x7f,0x01,0x48,0x8b,0xc1,0x48,0x83,0xc4,0x18,0xc3};

        public static ReadOnlySpan<byte> Advance_ᐤᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x39,0x09,0x48,0x83,0xc1,0x08,0xff,0x41,0x04,0xc3};

        public static ReadOnlySpan<byte> Advance_ᐤ32uᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x39,0x09,0x48,0x83,0xc1,0x08,0x01,0x51,0x04,0xc3};

        public static ReadOnlySpan<byte> Read_ᐤ8uᕀrefᐤ  =>  new byte[48]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x01,0x44,0x8b,0x41,0x0c,0x4d,0x63,0xc0,0x42,0x0f,0xb6,0x04,0x00,0x88,0x02,0x48,0x83,0xc1,0x08,0x48,0x8b,0xc1,0xff,0x40,0x04,0x8b,0x41,0x04,0x8b,0x11,0xff,0xca,0x3b,0xc2,0x0f,0x9c,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> Read_ᐤ32iㆍ32iㆍspan8uᐤ  =>  new byte[77]{0x56,0x0f,0x1f,0x40,0x00,0x48,0x8d,0x41,0x08,0x4c,0x8b,0xd0,0x45,0x8b,0x1a,0x45,0x2b,0x5a,0x04,0x45,0x3b,0xc3,0x7e,0x02,0xeb,0x03,0x45,0x8b,0xd8,0x48,0x8b,0x09,0x4d,0x8b,0x01,0x46,0x8d,0x0c,0x1a,0x41,0x3b,0xd1,0x7d,0x18,0x4c,0x63,0xd2,0x4d,0x03,0xd0,0x48,0x63,0xf2,0x40,0x0f,0xb6,0x34,0x31,0x41,0x88,0x32,0xff,0xc2,0x41,0x3b,0xd1,0x7c,0xe8,0x44,0x01,0x58,0x04,0x41,0x8b,0xc3,0x5e,0xc3};

        public static ReadOnlySpan<byte> ReadAll_ᐤspan8uᐤ  =>  new byte[77]{0x0f,0x1f,0x44,0x00,0x00,0x8b,0x41,0x08,0x48,0x8b,0x12,0x4c,0x8d,0x41,0x08,0x4d,0x8b,0xc8,0x45,0x8b,0x11,0x45,0x2b,0x51,0x04,0x41,0x3b,0xc2,0x7e,0x02,0xeb,0x03,0x44,0x8b,0xd0,0x48,0x8b,0x01,0x33,0xc9,0x45,0x85,0xd2,0x7e,0x18,0x4c,0x63,0xc9,0x4c,0x03,0xca,0x4c,0x63,0xd9,0x46,0x0f,0xb6,0x1c,0x18,0x45,0x88,0x19,0xff,0xc1,0x41,0x3b,0xca,0x7c,0xe8,0x45,0x01,0x50,0x04,0x41,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> Seek_ᐤ32uᐤ  =>  new byte[45]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x83,0xc1,0x08,0x8b,0xc2,0x44,0x8b,0x01,0x4d,0x63,0xc0,0x49,0x3b,0xc0,0x7c,0x09,0xc7,0x41,0x04,0xff,0xff,0xff,0xff,0xeb,0x03,0x89,0x51,0x04,0x83,0x79,0x04,0x00,0x0f,0x9d,0xc0,0x0f,0xb6,0xc0,0xc3};

    }
}
