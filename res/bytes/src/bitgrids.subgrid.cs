//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.ByteCode
{
    using System;
    using System.Runtime.CompilerServices;


    public static class bitgrids_subgrid
    {
        public static ReadOnlySpan<byte> init_ᐤPerm8Lᕀ32uᐤ  =>  new byte[8]{0x0f,0x1f,0x44,0x00,0x00,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> init_ᐤNatPermᐸN8ᐳᐤ  =>  new byte[65]{0x48,0x83,0xec,0x28,0x90,0x48,0x8b,0xc1,0x33,0xd2,0x45,0x33,0xc0,0x45,0x33,0xc9,0x44,0x8b,0x50,0x08,0x45,0x3b,0xc2,0x73,0x25,0x49,0x63,0xc8,0x44,0x8b,0x5c,0x88,0x10,0x41,0x8b,0xc9,0x41,0xd3,0xe3,0x41,0x0b,0xd3,0x41,0xff,0xc0,0x41,0x83,0xc1,0x03,0x41,0x83,0xf8,0x08,0x7c,0xdd,0x8b,0xc2,0x48,0x83,0xc4,0x28,0xc3,0xe8,0x1d,0x09};

        public static ReadOnlySpan<byte> init_ᐤNatPermᐸN32ᐳᐤ  =>  new byte[621]{0x41,0x57,0x41,0x56,0x41,0x54,0x57,0x56,0x55,0x53,0x48,0x81,0xec,0xc0,0x00,0x00,0x00,0xc5,0xf8,0x77,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x20,0xb9,0x28,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x8b,0xf9,0x48,0x8b,0xf2,0xc6,0x84,0x24,0x98,0x00,0x00,0x00,0x00,0x48,0x0f,0xbe,0x8c,0x24,0x98,0x00,0x00,0x00,0x88,0x8c,0x24,0xa8,0x00,0x00,0x00,0x48,0x0f,0xbe,0x8c,0x24,0xa8,0x00,0x00,0x00,0x88,0x8c,0x24,0x90,0x00,0x00,0x00,0x48,0x8d,0x8c,0x24,0xb0,0x00,0x00,0x00,0x48,0x0f,0xbe,0x94,0x24,0x90,0x00,0x00,0x00,0x41,0xb8,0x01,0x00,0x00,0x00,0x45,0x33,0xc9,0xe8,0xf3,0x3d,0xff,0xff,0x48,0xb9,0x10,0xea,0x9c,0xad,0xf9,0x7f,0x00,0x00,0xba,0x00,0x01,0x00,0x00,0xe8,0xb7,0x80,0x0e,0x5e,0x48,0x8b,0xd8,0x33,0xed,0x45,0x33,0xf6,0xe9,0x08,0x01,0x00,0x00,0x3b,0x6e,0x08,0x0f,0x83,0xc9,0x01,0x00,0x00,0x48,0x63,0xcd,0x44,0x8b,0x7c,0x8e,0x10,0x41,0xbc,0x20,0x00,0x00,0x00,0x48,0xb9,0x10,0xea,0x9c,0xad,0xf9,0x7f,0x00,0x00,0xba,0x20,0x00,0x00,0x00,0xe8,0x7f,0x80,0x0e,0x5e,0x48,0x8d,0x50,0x10,0x45,0x33,0xc0,0x41,0x8b,0xc8,0xc1,0xe1,0x03,0x4c,0x63,0xc9,0x4c,0x03,0xca,0x41,0x8b,0xc8,0xc1,0xe1,0x03,0x45,0x8b,0xd7,0x41,0xd3,0xea,0x41,0x0f,0xb6,0xca,0xc1,0xe1,0x03,0x48,0x63,0xc9,0x49,0xba,0x91,0xb6,0x55,0x2b,0xa0,0x02,0x00,0x00,0x49,0x03,0xca,0x48,0x8b,0x09,0x49,0x89,0x09,0x41,0xff,0xc0,0x41,0x83,0xf8,0x04,0x7c,0xc2,0x48,0x83,0xc0,0x10,0xb9,0x20,0x00,0x00,0x00,0x41,0x83,0xfc,0x20,0x7d,0x02,0xeb,0x06,0x41,0xbc,0x20,0x00,0x00,0x00,0x41,0x8b,0xd4,0x8b,0xc9,0x48,0x3b,0xd1,0x0f,0x87,0x37,0x01,0x00,0x00,0x48,0x89,0x84,0x24,0x80,0x00,0x00,0x00,0x44,0x89,0xa4,0x24,0x88,0x00,0x00,0x00,0x48,0x8d,0x8c,0x24,0x80,0x00,0x00,0x00,0xe8,0x38,0xe0,0x9c,0x5d,0x45,0x33,0xff,0x45,0x8d,0x66,0x05,0x45,0x3b,0xf4,0x7d,0x3d,0x8b,0x50,0x08,0x44,0x3b,0x78,0x08,0x0f,0x83,0x07,0x01,0x00,0x00,0x49,0x63,0xd7,0x80,0x7c,0x10,0x10,0x01,0x0f,0x94,0xc2,0x0f,0xb6,0xd2,0x0f,0xb6,0xd2,0x41,0x81,0xfe,0x00,0x01,0x00,0x00,0x0f,0x83,0xe9,0x00,0x00,0x00,0x49,0x63,0xce,0x88,0x54,0x0b,0x10,0x41,0xff,0xc6,0x41,0xff,0xc7,0x45,0x3b,0xf4,0x7c,0xc6,0x48,0x89,0x9c,0x24,0xa0,0x00,0x00,0x00,0xff,0xc5,0x45,0x8b,0xf4,0x83,0xfd,0x20,0x0f,0x8c,0xef,0xfe,0xff,0xff,0x48,0x83,0xc3,0x10,0xb9,0x00,0x01,0x00,0x00,0x33,0xd2,0x45,0x33,0xc9,0x4c,0x8d,0x44,0x24,0x70,0x48,0x8d,0x44,0x24,0x38,0x48,0x89,0x18,0x89,0x48,0x08,0x48,0x8d,0x4c,0x24,0x30,0x88,0x11,0x44,0x89,0x49,0x04,0x49,0x8b,0xc8,0x48,0x8d,0x54,0x24,0x38,0x4c,0x8b,0x4c,0x24,0x30,0x45,0x33,0xc0,0xe8,0xdb,0x80,0xe2,0xfe,0x48,0x8b,0x4c,0x24,0x70,0x8b,0x54,0x24,0x78,0xc1,0xea,0x03,0xc6,0x44,0x24,0x50,0x00,0x4c,0x0f,0xbe,0x44,0x24,0x50,0x44,0x88,0x44,0x24,0x68,0x4c,0x0f,0xbe,0x44,0x24,0x68,0x44,0x88,0x44,0x24,0x48,0x4c,0x8d,0x44,0x24,0x58,0x4c,0x0f,0xbe,0x4c,0x24,0x48,0x48,0x8d,0x44,0x24,0x20,0x48,0x89,0x08,0x89,0x50,0x08,0x49,0x8b,0xc8,0x41,0x8b,0xd1,0x4c,0x8d,0x44,0x24,0x20,0x45,0x33,0xc9,0xe8,0x53,0xfa,0xff,0xff,0x48,0x8d,0x44,0x24,0x58,0x48,0x8b,0x00,0xc5,0xff,0xf0,0x00,0xc5,0xfd,0x11,0x07,0x48,0x8b,0xc7,0xc5,0xf8,0x77,0x48,0x81,0xc4,0xc0,0x00,0x00,0x00,0x5b,0x5d,0x5e,0x5f,0x41,0x5c,0x41,0x5e,0x41,0x5f,0xc3,0xe8,0xee,0x00,0x21,0x5e,0xe8,0x61,0xda,0x5c,0xfe,0xcc,0xe8,0x93,0x02,0x21,0x5e};

    }
}
