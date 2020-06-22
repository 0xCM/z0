//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.ByteCode
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public static class bitsvc_bits
    {
        public static ReadOnlySpan<byte> byteswap_gᐸ16uᐳᐤ16uᐤ  =>  new byte[27]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb7,0xc1,0x8b,0xd0,0xc1,0xfa,0x08,0x25,0xff,0x00,0x00,0x00,0xc1,0xe0,0x08,0x0b,0xd0,0x0f,0xb7,0xc2,0xc3};

        public static ReadOnlySpan<byte> byteswap_gᐸ32uᐳᐤ32uᐤ  =>  new byte[48]{0x0f,0x1f,0x44,0x00,0x00,0x8b,0xc1,0xc1,0xe8,0x18,0x0f,0xb6,0xc0,0x8b,0xd1,0xc1,0xea,0x10,0x0f,0xb6,0xd2,0xc1,0xe2,0x08,0x0b,0xc2,0x8b,0xd1,0xc1,0xea,0x08,0x0f,0xb6,0xd2,0xc1,0xe2,0x10,0x0b,0xc2,0x0f,0xb6,0xd1,0xc1,0xe2,0x18,0x0b,0xc2,0xc3};

        public static ReadOnlySpan<byte> byteswap_gᐸ64uᐳᐤ64uᐤ  =>  new byte[128]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0x48,0xc1,0xe8,0x38,0x0f,0xb6,0xc0,0x48,0x8b,0xd1,0x48,0xc1,0xea,0x30,0x0f,0xb6,0xd2,0x48,0xc1,0xe2,0x08,0x48,0x0b,0xc2,0x48,0x8b,0xd1,0x48,0xc1,0xea,0x28,0x0f,0xb6,0xd2,0x48,0xc1,0xe2,0x10,0x48,0x0b,0xc2,0x48,0x8b,0xd1,0x48,0xc1,0xea,0x20,0x0f,0xb6,0xd2,0x48,0xc1,0xe2,0x18,0x48,0x0b,0xc2,0x48,0x8b,0xd1,0x48,0xc1,0xea,0x18,0x0f,0xb6,0xd2,0x48,0xc1,0xe2,0x20,0x48,0x0b,0xc2,0x48,0x8b,0xd1,0x48,0xc1,0xea,0x10,0x0f,0xb6,0xd2,0x48,0xc1,0xe2,0x28,0x48,0x0b,0xc2,0x48,0x8b,0xd1,0x48,0xc1,0xea,0x08,0x0f,0xb6,0xd2,0x48,0xc1,0xe2,0x30,0x48,0x0b,0xc2,0x0f,0xb6,0xd1,0x48,0xc1,0xe2,0x38,0x48,0x0b,0xc2,0xc3};

        public static ReadOnlySpan<byte> bitslice_gᐸ8uᐳᐤ8uㆍ8uㆍ8uᐤ  =>  new byte[32]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x41,0x0f,0xb6,0xc8,0xc1,0xe1,0x08,0x0b,0xd1,0x0f,0xb7,0xd2,0xc4,0xe2,0x68,0xf7,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> bitslice_gᐸ16uᐳᐤ16uㆍ8uㆍ8uᐤ  =>  new byte[32]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb7,0xc1,0x0f,0xb6,0xd2,0x41,0x0f,0xb6,0xc8,0xc1,0xe1,0x08,0x0b,0xd1,0x0f,0xb7,0xd2,0xc4,0xe2,0x68,0xf7,0xc0,0x0f,0xb7,0xc0,0xc3};

        public static ReadOnlySpan<byte> bitslice_gᐸ32uᐳᐤ32uㆍ8uㆍ8uᐤ  =>  new byte[26]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc2,0x41,0x0f,0xb6,0xd0,0xc1,0xe2,0x08,0x0b,0xc2,0x0f,0xb7,0xc0,0xc4,0xe2,0x78,0xf7,0xc1,0xc3};

        public static ReadOnlySpan<byte> bitslice_gᐸ64uᐳᐤ64uㆍ8uㆍ8uᐤ  =>  new byte[26]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc2,0x41,0x0f,0xb6,0xd0,0xc1,0xe2,0x08,0x0b,0xc2,0x0f,0xb7,0xc0,0xc4,0xe2,0xf8,0xf7,0xc1,0xc3};

    }
}
