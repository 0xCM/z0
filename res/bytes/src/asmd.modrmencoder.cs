//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.ByteCode
{
    using System;
    using System.Runtime.CompilerServices;


    public static class asmd_modrmencoder
    {
        public static ReadOnlySpan<byte> encode_ᐤtriadㆍtriadㆍduetᐤ  =>  new byte[141]{0x48,0x83,0xec,0x38,0x90,0x0f,0xb6,0xc2,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x30,0x41,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x28,0x8b,0x44,0x24,0x28,0x0f,0xb6,0xc0,0xc1,0xe0,0x02,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x20,0x8b,0x44,0x24,0x30,0x0f,0xb6,0xc0,0x8b,0x54,0x24,0x20,0x0f,0xb6,0xd2,0x0b,0xc2,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x18,0x41,0x0f,0xb6,0xc1,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x10,0x8b,0x44,0x24,0x10,0x0f,0xb6,0xc0,0xc1,0xe0,0x06,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x08,0x8b,0x44,0x24,0x18,0x0f,0xb6,0xc0,0x8b,0x54,0x24,0x08,0x0f,0xb6,0xd2,0x0b,0xc2,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x04,0x8b,0x44,0x24,0x04,0x0f,0xb6,0xc0,0x48,0x83,0xc4,0x38,0xc3};

        public static ReadOnlySpan<byte> table_ᐤspanModRmEncodingᐤ  =>  new byte[337]{0x57,0x56,0x55,0x53,0x48,0x83,0xec,0x68,0x33,0xc0,0x48,0x89,0x44,0x24,0x60,0x33,0xc0,0x33,0xc9,0x45,0x33,0xc0,0x45,0x33,0xc9,0x4c,0x63,0xd1,0x49,0xbb,0x83,0xc2,0x57,0x11,0xa0,0x02,0x00,0x00,0x47,0x0f,0xb6,0x14,0x1a,0x4d,0x63,0xd8,0x48,0xbe,0x83,0xc2,0x57,0x11,0xa0,0x02,0x00,0x00,0x45,0x0f,0xb6,0x1c,0x33,0x49,0x63,0xf1,0x48,0xbf,0x9b,0xba,0x57,0x11,0xa0,0x02,0x00,0x00,0x40,0x0f,0xb6,0x34,0x3e,0x44,0x88,0x54,0x24,0x50,0x44,0x88,0x5c,0x24,0x48,0x8b,0x7c,0x24,0x48,0x40,0x0f,0xb6,0xff,0xc1,0xe7,0x02,0x40,0x0f,0xb6,0xff,0x40,0x0f,0xb6,0xff,0x40,0x88,0x7c,0x24,0x40,0x8b,0x7c,0x24,0x50,0x40,0x0f,0xb6,0xff,0x8b,0x5c,0x24,0x40,0x0f,0xb6,0xdb,0x0b,0xfb,0x40,0x0f,0xb6,0xff,0x40,0x0f,0xb6,0xff,0x40,0x88,0x7c,0x24,0x38,0x40,0x88,0x74,0x24,0x30,0x8b,0x7c,0x24,0x30,0x40,0x0f,0xb6,0xff,0xc1,0xe7,0x06,0x40,0x0f,0xb6,0xff,0x40,0x0f,0xb6,0xff,0x40,0x88,0x7c,0x24,0x28,0x8b,0x7c,0x24,0x38,0x40,0x0f,0xb6,0xff,0x8b,0x5c,0x24,0x28,0x0f,0xb6,0xdb,0x0b,0xfb,0x40,0x0f,0xb6,0xff,0x40,0x0f,0xb6,0xff,0x40,0x88,0x7c,0x24,0x24,0x8b,0x7c,0x24,0x24,0x40,0x0f,0xb6,0xff,0x40,0x88,0x7c,0x24,0x60,0x48,0x8b,0x3a,0x48,0x63,0xd8,0x48,0x8d,0x3c,0x9f,0x33,0xdb,0x89,0x5c,0x24,0x58,0x0f,0xb6,0x5c,0x24,0x60,0x48,0x8d,0x6c,0x24,0x58,0x44,0x88,0x55,0x00,0x45,0x0f,0xb6,0xd3,0x45,0x0f,0xb6,0xd2,0x44,0x88,0x54,0x24,0x59,0x40,0x88,0x74,0x24,0x5a,0x4c,0x8d,0x54,0x24,0x5b,0x41,0x88,0x1a,0x44,0x8b,0x54,0x24,0x58,0x44,0x89,0x17,0x41,0xff,0xc1,0xff,0xc0,0x41,0x83,0xf9,0x04,0x0f,0x8c,0xf3,0xfe,0xff,0xff,0x41,0xff,0xc0,0x41,0x83,0xf8,0x08,0x0f,0x8c,0xe3,0xfe,0xff,0xff,0xff,0xc1,0x83,0xf9,0x08,0x0f,0x8c,0xd5,0xfe,0xff,0xff,0x48,0x83,0xc4,0x68,0x5b,0x5d,0x5e,0x5f,0xc3,0xe8,0xe4,0xec,0x25,0x5e,0xcc,0x00,0x00,0x00,0x19};

    }
}
