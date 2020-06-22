//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.ByteCode
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public static class kinds_blocked
    {
        public static ReadOnlySpan<byte> kind_ᐤTypeᐤ  =>  new byte[61]{0x57,0x56,0x48,0x83,0xec,0x28,0x48,0x8b,0xf1,0x48,0x8b,0xce,0xe8,0x8f,0xae,0x0c,0xff,0x0f,0xb7,0xf8,0x48,0x8b,0xce,0xe8,0xa4,0xc5,0xa8,0xfe,0xc1,0xe0,0x03,0xc1,0xe8,0x03,0xc1,0xe8,0x10,0x8b,0xd0,0xc1,0xe2,0x10,0x8b,0xcf,0x48,0xb8,0x68,0x1d,0x61,0xae,0xf9,0x7f,0x00,0x00,0x48,0x83,0xc4,0x28,0x5e,0x5f,0x48};

        public static ReadOnlySpan<byte> kind_ᐤTypeWidthᕀ16uㆍNumericTypeIdᕀ32uᐤ  =>  new byte[1060]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb7,0xc1,0x83,0xf8,0x40,0x77,0x1c,0x83,0xf8,0x10,0x74,0x3d,0x83,0xf8,0x20,0x0f,0x84,0x83,0x00,0x00,0x00,0x83,0xf8,0x40,0x0f,0x84,0x00,0x01,0x00,0x00,0xe9,0xf8,0x03,0x00,0x00,0x3d,0x80,0x00,0x00,0x00,0x0f,0x84,0xb0,0x01,0x00,0x00,0x3d,0x00,0x01,0x00,0x00,0x0f,0x84,0x65,0x02,0x00,0x00,0x3d,0x00,0x02,0x00,0x00,0x0f,0x84,0x1a,0x03,0x00,0x00,0xe9,0xd2,0x03,0x00,0x00,0x81,0xfa,0x00,0x00,0x02,0x00,0x77,0x12,0x81,0xfa,0x00,0x00,0x01,0x00,0x74,0x1c,0x81,0xfa,0x00,0x00,0x02,0x00,0x74,0x1b,0xeb,0x2e,0x81,0xfa,0x00,0x00,0x04,0x00,0x74,0x1f,0x81,0xfa,0x00,0x00,0x08,0x00,0x74,0x10,0xeb,0x1c,0xb8,0x18,0x00,0x01,0x20,0xeb,0x17,0xb8,0x18,0x00,0x02,0x80,0xeb,0x10,0xb8,0x10,0x00,0x08,0x80,0xeb,0x09,0xb8,0x10,0x00,0x04,0x20,0xeb,0x02,0x33,0xc0,0xe9,0x85,0x03,0x00,0x00,0x81,0xfa,0x00,0x00,0x04,0x00,0x77,0x1a,0x81,0xfa,0x00,0x00,0x01,0x00,0x74,0x3e,0x81,0xfa,0x00,0x00,0x02,0x00,0x74,0x3d,0x81,0xfa,0x00,0x00,0x04,0x00,0x74,0x43,0xeb,0x5d,0x81,0xfa,0x00,0x00,0x10,0x00,0x77,0x12,0x81,0xfa,0x00,0x00,0x08,0x00,0x74,0x2a,0x81,0xfa,0x00,0x00,0x10,0x00,0x74,0x37,0xeb,0x43,0x81,0xfa,0x00,0x00,0x20,0x00,0x74,0x26,0x81,0xfa,0x00,0x00,0x00,0x02,0x74,0x2c,0xeb,0x31,0xb8,0x28,0x00,0x01,0x20,0xeb,0x2c,0xb8,0x28,0x00,0x02,0x80,0xeb,0x25,0xb8,0x30,0x00,0x08,0x80,0xeb,0x1e,0xb8,0x30,0x00,0x04,0x20,0xeb,0x17,0xb8,0x20,0x00,0x20,0x80,0xeb,0x10,0xb8,0x20,0x00,0x10,0x20,0xeb,0x09,0xb8,0x20,0x00,0x00,0x42,0xeb,0x02,0x33,0xc0,0xe9,0xff,0x02,0x00,0x00,0x81,0xfa,0x00,0x00,0x10,0x00,0x77,0x37,0x81,0xfa,0x00,0x00,0x02,0x00,0x77,0x15,0x81,0xfa,0x00,0x00,0x01,0x00,0x74,0x5b,0x81,0xfa,0x00,0x00,0x02,0x00,0x74,0x5a,0xe9,0x94,0x00,0x00,0x00,0x81,0xfa,0x00,0x00,0x04,0x00,0x74,0x54,0x81,0xfa,0x00,0x00,0x08,0x00,0x74,0x53,0x81,0xfa,0x00,0x00,0x10,0x00,0x74,0x52,0xeb,0x7a,0x81,0xfa,0x00,0x00,0x40,0x00,0x77,0x12,0x81,0xfa,0x00,0x00,0x20,0x00,0x74,0x47,0x81,0xfa,0x00,0x00,0x40,0x00,0x74,0x46,0xeb,0x60,0x81,0xfa,0x00,0x00,0x80,0x00,0x74,0x43,0x81,0xfa,0x00,0x00,0x00,0x02,0x74,0x42,0x81,0xfa,0x00,0x00,0x00,0x04,0x74,0x41,0xeb,0x46,0xb8,0x48,0x00,0x01,0x20,0xeb,0x41,0xb8,0x48,0x00,0x02,0x80,0xeb,0x3a,0xb8,0x50,0x00,0x04,0x20,0xeb,0x33,0xb8,0x50,0x00,0x08,0x80,0xeb,0x2c,0xb8,0x60,0x00,0x20,0x80,0xeb,0x25,0xb8,0x60,0x00,0x20,0x80,0xeb,0x1e,0xb8,0x40,0x00,0x40,0x20,0xeb,0x17,0xb8,0x40,0x00,0x80,0x80,0xeb,0x10,0xb8,0x60,0x00,0x00,0x42,0xeb,0x09,0xb8,0x40,0x00,0x00,0x44,0xeb,0x02,0x33,0xc0,0xe9,0x3f,0x02,0x00,0x00,0x81,0xfa,0x00,0x00,0x10,0x00,0x77,0x37,0x81,0xfa,0x00,0x00,0x02,0x00,0x77,0x15,0x81,0xfa,0x00,0x00,0x01,0x00,0x74,0x5b,0x81,0xfa,0x00,0x00,0x02,0x00,0x74,0x5a,0xe9,0x94,0x00,0x00,0x00,0x81,0xfa,0x00,0x00,0x04,0x00,0x74,0x54,0x81,0xfa,0x00,0x00,0x08,0x00,0x74,0x53,0x81,0xfa,0x00,0x00,0x10,0x00,0x74,0x52,0xeb,0x7a,0x81,0xfa,0x00,0x00,0x40,0x00,0x77,0x12,0x81,0xfa,0x00,0x00,0x20,0x00,0x74,0x47,0x81,0xfa,0x00,0x00,0x40,0x00,0x74,0x46,0xeb,0x60,0x81,0xfa,0x00,0x00,0x80,0x00,0x74,0x43,0x81,0xfa,0x00,0x00,0x00,0x02,0x74,0x42,0x81,0xfa,0x00,0x00,0x00,0x04,0x74,0x41,0xeb,0x46,0xb8,0x88,0x00,0x01,0x20,0xeb,0x41,0xb8,0x88,0x00,0x02,0x80,0xeb,0x3a,0xb8,0x90,0x00,0x04,0x20,0xeb,0x33,0xb8,0x90,0x00,0x08,0x80,0xeb,0x2c,0xb8,0xa0,0x00,0x20,0x80,0xeb,0x25,0xb8,0xa0,0x00,0x20,0x80,0xeb,0x1e,0xb8,0xc0,0x00,0x40,0x20,0xeb,0x17,0xb8,0xc0,0x00,0x80,0x80,0xeb,0x10,0xb8,0xa0,0x00,0x00,0x42,0xeb,0x09,0xb8,0xc0,0x00,0x00,0x44,0xeb,0x02,0x33,0xc0,0xe9,0x7f,0x01,0x00,0x00,0x81,0xfa,0x00,0x00,0x10,0x00,0x77,0x37,0x81,0xfa,0x00,0x00,0x02,0x00,0x77,0x15,0x81,0xfa,0x00,0x00,0x01,0x00,0x74,0x5b,0x81,0xfa,0x00,0x00,0x02,0x00,0x74,0x5a,0xe9,0x94,0x00,0x00,0x00,0x81,0xfa,0x00,0x00,0x04,0x00,0x74,0x54,0x81,0xfa,0x00,0x00,0x08,0x00,0x74,0x53,0x81,0xfa,0x00,0x00,0x10,0x00,0x74,0x52,0xeb,0x7a,0x81,0xfa,0x00,0x00,0x40,0x00,0x77,0x12,0x81,0xfa,0x00,0x00,0x20,0x00,0x74,0x47,0x81,0xfa,0x00,0x00,0x40,0x00,0x74,0x46,0xeb,0x60,0x81,0xfa,0x00,0x00,0x80,0x00,0x74,0x43,0x81,0xfa,0x00,0x00,0x00,0x02,0x74,0x42,0x81,0xfa,0x00,0x00,0x00,0x04,0x74,0x41,0xeb,0x46,0xb8,0x08,0x01,0x01,0x20,0xeb,0x41,0xb8,0x08,0x01,0x02,0x80,0xeb,0x3a,0xb8,0x10,0x01,0x04,0x20,0xeb,0x33,0xb8,0x10,0x01,0x08,0x80,0xeb,0x2c,0xb8,0x20,0x01,0x20,0x80,0xeb,0x25,0xb8,0x20,0x01,0x20,0x80,0xeb,0x1e,0xb8,0x40,0x01,0x40,0x20,0xeb,0x17,0xb8,0x40,0x01,0x80,0x80,0xeb,0x10,0xb8,0x20,0x01,0x00,0x42,0xeb,0x09,0xb8,0x40,0x01,0x00,0x44,0xeb,0x02,0x33,0xc0,0xe9,0xbf,0x00,0x00,0x00,0x81,0xfa,0x00,0x00,0x10,0x00,0x77,0x37,0x81,0xfa,0x00,0x00,0x02,0x00,0x77,0x15,0x81,0xfa,0x00,0x00,0x01,0x00,0x74,0x5b,0x81,0xfa,0x00,0x00,0x02,0x00,0x74,0x5a,0xe9,0x94,0x00,0x00,0x00,0x81,0xfa,0x00,0x00,0x04,0x00,0x74,0x54,0x81,0xfa,0x00,0x00,0x08,0x00,0x74,0x53,0x81,0xfa,0x00,0x00,0x10,0x00,0x74,0x52,0xeb,0x7a,0x81,0xfa,0x00,0x00,0x40,0x00,0x77,0x12,0x81,0xfa,0x00,0x00,0x20,0x00,0x74,0x47,0x81,0xfa,0x00,0x00,0x40,0x00,0x74,0x46,0xeb,0x60,0x81,0xfa,0x00,0x00,0x80,0x00,0x74,0x43,0x81,0xfa,0x00,0x00,0x00,0x02,0x74,0x42,0x81,0xfa,0x00,0x00,0x00,0x04,0x74,0x41,0xeb,0x46,0xb8,0x08,0x02,0x01,0x20,0xeb,0x41,0xb8,0x08,0x02,0x02,0x80,0xeb,0x3a,0xb8,0x10,0x02,0x04,0x20,0xeb,0x33,0xb8,0x10,0x02,0x08,0x80,0xeb,0x2c,0xb8,0x20,0x02,0x20,0x80,0xeb,0x25,0xb8,0x20,0x02,0x20,0x80,0xeb,0x1e,0xb8,0x40,0x02,0x40,0x20,0xeb,0x17,0xb8,0x40,0x02,0x80,0x80,0xeb,0x10,0xb8,0x20,0x02,0x00,0x42,0xeb,0x09,0xb8,0x40,0x02,0x00,0x44,0xeb,0x02,0x33,0xc0,0xeb,0x02,0x33,0xc0,0xc3};

    }
}
