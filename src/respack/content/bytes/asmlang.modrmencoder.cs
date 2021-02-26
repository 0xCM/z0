//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
// Generated   : 2021-02-26 14:33:07 -06:00
//-----------------------------------------------------------------------------
namespace Z0.ByteCode
{
    using System;
    using System.Runtime.CompilerServices;


    public static class asmlang_modrmencoder
    {
        public static ReadOnlySpan<byte> define_ᐤ8uᐤ  =>  new byte[27]{0x50,0x0f,0x1f,0x40,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x04,0x8b,0x44,0x24,0x04,0x0f,0xb6,0xc0,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> define_ᐤuint3ㆍuint3ㆍuint2ᐤ  =>  new byte[140]{0x48,0x83,0xec,0x38,0x90,0x0f,0xb6,0xc1,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x30,0x0f,0xb6,0xc2,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x28,0x8b,0x44,0x24,0x28,0x0f,0xb6,0xc0,0xc1,0xe0,0x02,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x20,0x8b,0x44,0x24,0x30,0x0f,0xb6,0xc0,0x8b,0x54,0x24,0x20,0x0f,0xb6,0xd2,0x0b,0xc2,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x18,0x41,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x10,0x8b,0x44,0x24,0x10,0x0f,0xb6,0xc0,0xc1,0xe0,0x06,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x08,0x8b,0x44,0x24,0x18,0x0f,0xb6,0xc0,0x8b,0x54,0x24,0x08,0x0f,0xb6,0xd2,0x0b,0xc2,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x04,0x8b,0x44,0x24,0x04,0x0f,0xb6,0xc0,0x48,0x83,0xc4,0x38,0xc3};

        public static ReadOnlySpan<byte> fill_ᐤspanModRmEncodingᐤ  =>  new byte[391]{0x41,0x57,0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xec,0x48,0x33,0xc0,0x48,0x89,0x44,0x24,0x40,0x33,0xc0,0x33,0xd2,0x45,0x33,0xc0,0x45,0x33,0xc9,0x4c,0x63,0xd2,0x49,0xbb,0xcc,0x33,0x5c,0x1c,0xd3,0x01,0x00,0x00,0x4d,0x03,0xd3,0x4d,0x63,0xd8,0x48,0xbe,0xcc,0x33,0x5c,0x1c,0xd3,0x01,0x00,0x00,0x4c,0x03,0xde,0x49,0x8b,0xf2,0x49,0x8b,0xfb,0x49,0x63,0xd9,0x48,0xbd,0x04,0x2c,0x5c,0x1c,0xd3,0x01,0x00,0x00,0x48,0x03,0xdd,0x40,0x0f,0xb6,0x2e,0x44,0x0f,0xb6,0x37,0x44,0x0f,0xb6,0x3b,0x40,0x88,0x6c,0x24,0x30,0x44,0x88,0x74,0x24,0x28,0x8b,0x6c,0x24,0x28,0x40,0x0f,0xb6,0xed,0xc1,0xe5,0x02,0x40,0x0f,0xb6,0xed,0x40,0x0f,0xb6,0xed,0x40,0x88,0x6c,0x24,0x20,0x8b,0x6c,0x24,0x30,0x40,0x0f,0xb6,0xed,0x44,0x8b,0x74,0x24,0x20,0x45,0x0f,0xb6,0xf6,0x41,0x0b,0xee,0x40,0x0f,0xb6,0xed,0x40,0x0f,0xb6,0xed,0x40,0x88,0x6c,0x24,0x18,0x44,0x88,0x7c,0x24,0x10,0x8b,0x6c,0x24,0x10,0x40,0x0f,0xb6,0xed,0xc1,0xe5,0x06,0x40,0x0f,0xb6,0xed,0x40,0x0f,0xb6,0xed,0x40,0x88,0x6c,0x24,0x08,0x8b,0x6c,0x24,0x18,0x40,0x0f,0xb6,0xed,0x44,0x8b,0x74,0x24,0x08,0x45,0x0f,0xb6,0xf6,0x41,0x0b,0xee,0x40,0x0f,0xb6,0xed,0x40,0x0f,0xb6,0xed,0x40,0x88,0x6c,0x24,0x04,0x8b,0x6c,0x24,0x04,0x40,0x0f,0xb6,0xed,0x40,0x88,0x6c,0x24,0x40,0x48,0x8b,0x29,0x4c,0x63,0xf0,0x4a,0x8d,0x6c,0x75,0x00,0x40,0x0f,0xb6,0x36,0x40,0x0f,0xb6,0x3f,0x0f,0xb6,0x1b,0x66,0xc7,0x44,0x24,0x38,0x00,0x00,0x44,0x0f,0xb6,0x74,0x24,0x40,0x40,0x0f,0xb6,0xff,0xc1,0xe7,0x03,0x40,0x0f,0xb6,0xff,0x40,0x0f,0xb6,0xf6,0x0b,0xf7,0xc1,0xe3,0x06,0x40,0x0f,0xb6,0xfb,0x0b,0xf7,0x40,0x0f,0xb6,0xf6,0x40,0x0f,0xb6,0xf6,0x40,0x88,0x74,0x24,0x38,0x48,0x8d,0x74,0x24,0x39,0x44,0x88,0x36,0x48,0x0f,0xbf,0x74,0x24,0x38,0x66,0x89,0x75,0x00,0x41,0xff,0xc1,0xff,0xc0,0x41,0x8b,0xf1,0x48,0x83,0xfe,0x04,0x0f,0x8c,0xe2,0xfe,0xff,0xff,0x41,0xff,0xc0,0x45,0x8b,0xc8,0x49,0x83,0xf9,0x08,0x0f,0x8c,0xaf,0xfe,0xff,0xff,0xff,0xc2,0x44,0x8b,0xc2,0x49,0x83,0xf8,0x08,0x0f,0x8c,0x9d,0xfe,0xff,0xff,0x48,0x83,0xc4,0x48,0x5b,0x5d,0x5e,0x5f,0x41,0x5e,0x41,0x5f,0xc3};

    }
}
