//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.ByteCode
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public static class gmath_num
    {
        public static ReadOnlySpan<byte> from_gᐸ8uᐳᐤ8uᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> from_gᐸ8iᐳᐤ8iᐤ  =>  new byte[14]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbe,0xc1,0x48,0x0f,0xbe,0xc0,0xc3};

        public static ReadOnlySpan<byte> from_gᐸ16uᐳᐤ16uᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb7,0xc1,0x0f,0xb7,0xc0,0xc3};

        public static ReadOnlySpan<byte> from_gᐸ16iᐳᐤ16iᐤ  =>  new byte[14]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbf,0xc1,0x48,0x0f,0xbf,0xc0,0xc3};

        public static ReadOnlySpan<byte> from_gᐸ32uᐳᐤ32uᐤ  =>  new byte[8]{0x0f,0x1f,0x44,0x00,0x00,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> from_gᐸ32iᐳᐤ32iᐤ  =>  new byte[8]{0x0f,0x1f,0x44,0x00,0x00,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> from_gᐸ64uᐳᐤ64uᐤ  =>  new byte[9]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> from_gᐸ64iᐳᐤ64iᐤ  =>  new byte[9]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> from_gᐸ32fᐳᐤ32fᐤ  =>  new byte[18]{0x50,0xc5,0xf8,0x77,0x90,0xc5,0xfa,0x11,0x04,0x24,0x8b,0x04,0x24,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> from_gᐸ64fᐳᐤ64fᐤ  =>  new byte[19]{0x50,0xc5,0xf8,0x77,0x90,0xc5,0xfb,0x11,0x04,0x24,0x48,0x8b,0x04,0x24,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> zero_gᐸ8uᐳᐤᐤ  =>  new byte[8]{0x0f,0x1f,0x44,0x00,0x00,0x33,0xc0,0xc3};

        public static ReadOnlySpan<byte> zero_gᐸ8iᐳᐤᐤ  =>  new byte[8]{0x0f,0x1f,0x44,0x00,0x00,0x33,0xc0,0xc3};

        public static ReadOnlySpan<byte> zero_gᐸ16uᐳᐤᐤ  =>  new byte[8]{0x0f,0x1f,0x44,0x00,0x00,0x33,0xc0,0xc3};

        public static ReadOnlySpan<byte> zero_gᐸ16iᐳᐤᐤ  =>  new byte[8]{0x0f,0x1f,0x44,0x00,0x00,0x33,0xc0,0xc3};

        public static ReadOnlySpan<byte> zero_gᐸ32uᐳᐤᐤ  =>  new byte[8]{0x0f,0x1f,0x44,0x00,0x00,0x33,0xc0,0xc3};

        public static ReadOnlySpan<byte> zero_gᐸ32iᐳᐤᐤ  =>  new byte[8]{0x0f,0x1f,0x44,0x00,0x00,0x33,0xc0,0xc3};

        public static ReadOnlySpan<byte> zero_gᐸ64uᐳᐤᐤ  =>  new byte[8]{0x0f,0x1f,0x44,0x00,0x00,0x33,0xc0,0xc3};

        public static ReadOnlySpan<byte> zero_gᐸ64iᐳᐤᐤ  =>  new byte[8]{0x0f,0x1f,0x44,0x00,0x00,0x33,0xc0,0xc3};

        public static ReadOnlySpan<byte> zero_gᐸ32fᐳᐤᐤ  =>  new byte[22]{0x50,0xc5,0xf8,0x77,0x90,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x11,0x04,0x24,0x8b,0x04,0x24,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> zero_gᐸ64fᐳᐤᐤ  =>  new byte[23]{0x50,0xc5,0xf8,0x77,0x90,0xc5,0xf8,0x57,0xc0,0xc5,0xfb,0x11,0x04,0x24,0x48,0x8b,0x04,0x24,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> one_gᐸ8uᐳᐤᐤ  =>  new byte[11]{0x0f,0x1f,0x44,0x00,0x00,0xb8,0x01,0x00,0x00,0x00,0xc3};

        public static ReadOnlySpan<byte> one_gᐸ8iᐳᐤᐤ  =>  new byte[11]{0x0f,0x1f,0x44,0x00,0x00,0xb8,0x01,0x00,0x00,0x00,0xc3};

        public static ReadOnlySpan<byte> one_gᐸ16uᐳᐤᐤ  =>  new byte[11]{0x0f,0x1f,0x44,0x00,0x00,0xb8,0x01,0x00,0x00,0x00,0xc3};

        public static ReadOnlySpan<byte> one_gᐸ16iᐳᐤᐤ  =>  new byte[11]{0x0f,0x1f,0x44,0x00,0x00,0xb8,0x01,0x00,0x00,0x00,0xc3};

        public static ReadOnlySpan<byte> one_gᐸ32uᐳᐤᐤ  =>  new byte[11]{0x0f,0x1f,0x44,0x00,0x00,0xb8,0x01,0x00,0x00,0x00,0xc3};

        public static ReadOnlySpan<byte> one_gᐸ32iᐳᐤᐤ  =>  new byte[11]{0x0f,0x1f,0x44,0x00,0x00,0xb8,0x01,0x00,0x00,0x00,0xc3};

        public static ReadOnlySpan<byte> one_gᐸ64uᐳᐤᐤ  =>  new byte[11]{0x0f,0x1f,0x44,0x00,0x00,0xb8,0x01,0x00,0x00,0x00,0xc3};

        public static ReadOnlySpan<byte> one_gᐸ64iᐳᐤᐤ  =>  new byte[11]{0x0f,0x1f,0x44,0x00,0x00,0xb8,0x01,0x00,0x00,0x00,0xc3};

        public static ReadOnlySpan<byte> one_gᐸ32fᐳᐤᐤ  =>  new byte[26]{0x50,0xc5,0xf8,0x77,0x90,0xc5,0xfa,0x10,0x05,0x13,0x00,0x00,0x00,0xc5,0xfa,0x11,0x04,0x24,0x8b,0x04,0x24,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> one_gᐸ64fᐳᐤᐤ  =>  new byte[27]{0x50,0xc5,0xf8,0x77,0x90,0xc5,0xfb,0x10,0x05,0x13,0x00,0x00,0x00,0xc5,0xfb,0x11,0x04,0x24,0x48,0x8b,0x04,0x24,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> ones_gᐸ8uᐳᐤᐤ  =>  new byte[11]{0x0f,0x1f,0x44,0x00,0x00,0xb8,0xff,0x00,0x00,0x00,0xc3};

        public static ReadOnlySpan<byte> ones_gᐸ8iᐳᐤᐤ  =>  new byte[11]{0x0f,0x1f,0x44,0x00,0x00,0xb8,0xff,0xff,0xff,0xff,0xc3};

        public static ReadOnlySpan<byte> ones_gᐸ16uᐳᐤᐤ  =>  new byte[11]{0x0f,0x1f,0x44,0x00,0x00,0xb8,0xff,0xff,0x00,0x00,0xc3};

        public static ReadOnlySpan<byte> ones_gᐸ16iᐳᐤᐤ  =>  new byte[11]{0x0f,0x1f,0x44,0x00,0x00,0xb8,0xff,0xff,0xff,0xff,0xc3};

        public static ReadOnlySpan<byte> ones_gᐸ32uᐳᐤᐤ  =>  new byte[11]{0x0f,0x1f,0x44,0x00,0x00,0xb8,0xff,0xff,0xff,0xff,0xc3};

        public static ReadOnlySpan<byte> ones_gᐸ32iᐳᐤᐤ  =>  new byte[11]{0x0f,0x1f,0x44,0x00,0x00,0xb8,0xff,0xff,0xff,0xff,0xc3};

        public static ReadOnlySpan<byte> ones_gᐸ64uᐳᐤᐤ  =>  new byte[16]{0x0f,0x1f,0x44,0x00,0x00,0x48,0xb8,0xff,0xff,0xff,0xff,0xff,0xff,0xff,0xff,0xc3};

        public static ReadOnlySpan<byte> ones_gᐸ64iᐳᐤᐤ  =>  new byte[16]{0x0f,0x1f,0x44,0x00,0x00,0x48,0xb8,0xff,0xff,0xff,0xff,0xff,0xff,0xff,0xff,0xc3};

        public static ReadOnlySpan<byte> ones_gᐸ32fᐳᐤᐤ  =>  new byte[26]{0x50,0xc5,0xf8,0x77,0x90,0xc5,0xfa,0x10,0x05,0x13,0x00,0x00,0x00,0xc5,0xfa,0x11,0x04,0x24,0x8b,0x04,0x24,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> ones_gᐸ64fᐳᐤᐤ  =>  new byte[27]{0x50,0xc5,0xf8,0x77,0x90,0xc5,0xfb,0x10,0x05,0x13,0x00,0x00,0x00,0xc5,0xfb,0x11,0x04,0x24,0x48,0x8b,0x04,0x24,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> add_gᐸ8uᐳᐤnumᐸbyteᐳㆍnumᐸbyteᐳᐤ  =>  new byte[17]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x03,0xc2,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> add_gᐸ8iᐳᐤnumᐸsbyteᐳㆍnumᐸsbyteᐳᐤ  =>  new byte[20]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbe,0xc1,0x48,0x0f,0xbe,0xd2,0x03,0xc2,0x48,0x0f,0xbe,0xc0,0xc3};

        public static ReadOnlySpan<byte> add_gᐸ16uᐳᐤnumᐸushortᐳㆍnumᐸushortᐳᐤ  =>  new byte[17]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb7,0xc1,0x0f,0xb7,0xd2,0x03,0xc2,0x0f,0xb7,0xc0,0xc3};

        public static ReadOnlySpan<byte> add_gᐸ16iᐳᐤnumᐸshortᐳㆍnumᐸshortᐳᐤ  =>  new byte[20]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbf,0xc1,0x48,0x0f,0xbf,0xd2,0x03,0xc2,0x48,0x0f,0xbf,0xc0,0xc3};

        public static ReadOnlySpan<byte> add_gᐸ32uᐳᐤnumᐸuintᐳㆍnumᐸuintᐳᐤ  =>  new byte[10]{0x0f,0x1f,0x44,0x00,0x00,0x03,0xd1,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> add_gᐸ32iᐳᐤnumᐸintᐳㆍnumᐸintᐳᐤ  =>  new byte[10]{0x0f,0x1f,0x44,0x00,0x00,0x03,0xd1,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> add_gᐸ64uᐳᐤnumᐸulongᐳㆍnumᐸulongᐳᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x03,0xd1,0x48,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> add_gᐸ64iᐳᐤnumᐸlongᐳㆍnumᐸlongᐳᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x03,0xd1,0x48,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> add_gᐸ32fᐳᐤnumᐸfloatᐳㆍnumᐸfloatᐳᐤ  =>  new byte[44]{0x50,0xc5,0xf8,0x77,0x90,0x48,0x89,0x4c,0x24,0x10,0x48,0x89,0x54,0x24,0x18,0xc5,0xfa,0x10,0x44,0x24,0x10,0xc5,0xfa,0x10,0x4c,0x24,0x18,0xc5,0xfa,0x58,0xc1,0xc5,0xfa,0x11,0x04,0x24,0x8b,0x04,0x24,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> add_gᐸ64fᐳᐤnumᐸdoubleᐳㆍnumᐸdoubleᐳᐤ  =>  new byte[45]{0x50,0xc5,0xf8,0x77,0x90,0x48,0x89,0x4c,0x24,0x10,0x48,0x89,0x54,0x24,0x18,0xc5,0xfb,0x10,0x44,0x24,0x10,0xc5,0xfb,0x10,0x4c,0x24,0x18,0xc5,0xfb,0x58,0xc1,0xc5,0xfb,0x11,0x04,0x24,0x48,0x8b,0x04,0x24,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> mul_gᐸ8uᐳᐤnumᐸbyteᐳㆍnumᐸbyteᐳᐤ  =>  new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x0f,0xaf,0xc2,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> mul_gᐸ8iᐳᐤnumᐸsbyteᐳㆍnumᐸsbyteᐳᐤ  =>  new byte[21]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbe,0xc1,0x48,0x0f,0xbe,0xd2,0x0f,0xaf,0xc2,0x48,0x0f,0xbe,0xc0,0xc3};

        public static ReadOnlySpan<byte> mul_gᐸ16uᐳᐤnumᐸushortᐳㆍnumᐸushortᐳᐤ  =>  new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb7,0xc1,0x0f,0xb7,0xd2,0x0f,0xaf,0xc2,0x0f,0xb7,0xc0,0xc3};

        public static ReadOnlySpan<byte> mul_gᐸ16iᐳᐤnumᐸshortᐳㆍnumᐸshortᐳᐤ  =>  new byte[21]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbf,0xc1,0x48,0x0f,0xbf,0xd2,0x0f,0xaf,0xc2,0x48,0x0f,0xbf,0xc0,0xc3};

        public static ReadOnlySpan<byte> mul_gᐸ32uᐳᐤnumᐸuintᐳㆍnumᐸuintᐳᐤ  =>  new byte[11]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xaf,0xd1,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> mul_gᐸ32iᐳᐤnumᐸintᐳㆍnumᐸintᐳᐤ  =>  new byte[11]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xaf,0xd1,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> mul_gᐸ64uᐳᐤnumᐸulongᐳㆍnumᐸulongᐳᐤ  =>  new byte[13]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xaf,0xd1,0x48,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> mul_gᐸ64iᐳᐤnumᐸlongᐳㆍnumᐸlongᐳᐤ  =>  new byte[13]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xaf,0xd1,0x48,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> mul_gᐸ32fᐳᐤnumᐸfloatᐳㆍnumᐸfloatᐳᐤ  =>  new byte[44]{0x50,0xc5,0xf8,0x77,0x90,0x48,0x89,0x4c,0x24,0x10,0x48,0x89,0x54,0x24,0x18,0xc5,0xfa,0x10,0x44,0x24,0x10,0xc5,0xfa,0x10,0x4c,0x24,0x18,0xc5,0xfa,0x59,0xc1,0xc5,0xfa,0x11,0x04,0x24,0x8b,0x04,0x24,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> mul_gᐸ64fᐳᐤnumᐸdoubleᐳㆍnumᐸdoubleᐳᐤ  =>  new byte[45]{0x50,0xc5,0xf8,0x77,0x90,0x48,0x89,0x4c,0x24,0x10,0x48,0x89,0x54,0x24,0x18,0xc5,0xfb,0x10,0x44,0x24,0x10,0xc5,0xfb,0x10,0x4c,0x24,0x18,0xc5,0xfb,0x59,0xc1,0xc5,0xfb,0x11,0x04,0x24,0x48,0x8b,0x04,0x24,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> sub_gᐸ8uᐳᐤnumᐸbyteᐳㆍnumᐸbyteᐳᐤ  =>  new byte[17]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x2b,0xc2,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> sub_gᐸ8iᐳᐤnumᐸsbyteᐳㆍnumᐸsbyteᐳᐤ  =>  new byte[20]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbe,0xc1,0x48,0x0f,0xbe,0xd2,0x2b,0xc2,0x48,0x0f,0xbe,0xc0,0xc3};

        public static ReadOnlySpan<byte> sub_gᐸ16uᐳᐤnumᐸushortᐳㆍnumᐸushortᐳᐤ  =>  new byte[17]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb7,0xc1,0x0f,0xb7,0xd2,0x2b,0xc2,0x0f,0xb7,0xc0,0xc3};

        public static ReadOnlySpan<byte> sub_gᐸ16iᐳᐤnumᐸshortᐳㆍnumᐸshortᐳᐤ  =>  new byte[20]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbf,0xc1,0x48,0x0f,0xbf,0xd2,0x2b,0xc2,0x48,0x0f,0xbf,0xc0,0xc3};

        public static ReadOnlySpan<byte> sub_gᐸ32uᐳᐤnumᐸuintᐳㆍnumᐸuintᐳᐤ  =>  new byte[10]{0x0f,0x1f,0x44,0x00,0x00,0x2b,0xca,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> sub_gᐸ32iᐳᐤnumᐸintᐳㆍnumᐸintᐳᐤ  =>  new byte[10]{0x0f,0x1f,0x44,0x00,0x00,0x2b,0xca,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> sub_gᐸ64uᐳᐤnumᐸulongᐳㆍnumᐸulongᐳᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x2b,0xca,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> sub_gᐸ64iᐳᐤnumᐸlongᐳㆍnumᐸlongᐳᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x2b,0xca,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> sub_gᐸ32fᐳᐤnumᐸfloatᐳㆍnumᐸfloatᐳᐤ  =>  new byte[44]{0x50,0xc5,0xf8,0x77,0x90,0x48,0x89,0x4c,0x24,0x10,0x48,0x89,0x54,0x24,0x18,0xc5,0xfa,0x10,0x44,0x24,0x10,0xc5,0xfa,0x10,0x4c,0x24,0x18,0xc5,0xfa,0x5c,0xc1,0xc5,0xfa,0x11,0x04,0x24,0x8b,0x04,0x24,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> sub_gᐸ64fᐳᐤnumᐸdoubleᐳㆍnumᐸdoubleᐳᐤ  =>  new byte[45]{0x50,0xc5,0xf8,0x77,0x90,0x48,0x89,0x4c,0x24,0x10,0x48,0x89,0x54,0x24,0x18,0xc5,0xfb,0x10,0x44,0x24,0x10,0xc5,0xfb,0x10,0x4c,0x24,0x18,0xc5,0xfb,0x5c,0xc1,0xc5,0xfb,0x11,0x04,0x24,0x48,0x8b,0x04,0x24,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> div_gᐸ8uᐳᐤnumᐸbyteᐳㆍnumᐸbyteᐳᐤ  =>  new byte[21]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xca,0x0f,0xb6,0xc0,0x99,0xf7,0xf9,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> div_gᐸ8iᐳᐤnumᐸsbyteᐳㆍnumᐸsbyteᐳᐤ  =>  new byte[25]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbe,0xc1,0x48,0x0f,0xbe,0xca,0x48,0x0f,0xbe,0xc0,0x99,0xf7,0xf9,0x48,0x0f,0xbe,0xc0,0xc3};

        public static ReadOnlySpan<byte> div_gᐸ16uᐳᐤnumᐸushortᐳㆍnumᐸushortᐳᐤ  =>  new byte[21]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb7,0xc1,0x0f,0xb7,0xca,0x0f,0xb7,0xc0,0x99,0xf7,0xf9,0x0f,0xb7,0xc0,0xc3};

        public static ReadOnlySpan<byte> div_gᐸ16iᐳᐤnumᐸshortᐳㆍnumᐸshortᐳᐤ  =>  new byte[25]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbf,0xc1,0x48,0x0f,0xbf,0xca,0x48,0x0f,0xbf,0xc0,0x99,0xf7,0xf9,0x48,0x0f,0xbf,0xc0,0xc3};

        public static ReadOnlySpan<byte> div_gᐸ32uᐳᐤnumᐸuintᐳㆍnumᐸuintᐳᐤ  =>  new byte[14]{0x0f,0x1f,0x44,0x00,0x00,0x8b,0xc1,0x8b,0xca,0x33,0xd2,0xf7,0xf1,0xc3};

        public static ReadOnlySpan<byte> div_gᐸ32iᐳᐤnumᐸintᐳㆍnumᐸintᐳᐤ  =>  new byte[13]{0x0f,0x1f,0x44,0x00,0x00,0x8b,0xc1,0x8b,0xca,0x99,0xf7,0xf9,0xc3};

        public static ReadOnlySpan<byte> div_gᐸ64uᐳᐤnumᐸulongᐳㆍnumᐸulongᐳᐤ  =>  new byte[17]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0x48,0x8b,0xca,0x33,0xd2,0x48,0xf7,0xf1,0xc3};

        public static ReadOnlySpan<byte> div_gᐸ64iᐳᐤnumᐸlongᐳㆍnumᐸlongᐳᐤ  =>  new byte[17]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0x48,0x8b,0xca,0x48,0x99,0x48,0xf7,0xf9,0xc3};

        public static ReadOnlySpan<byte> div_gᐸ32fᐳᐤnumᐸfloatᐳㆍnumᐸfloatᐳᐤ  =>  new byte[44]{0x50,0xc5,0xf8,0x77,0x90,0x48,0x89,0x4c,0x24,0x10,0x48,0x89,0x54,0x24,0x18,0xc5,0xfa,0x10,0x44,0x24,0x10,0xc5,0xfa,0x10,0x4c,0x24,0x18,0xc5,0xfa,0x5e,0xc1,0xc5,0xfa,0x11,0x04,0x24,0x8b,0x04,0x24,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> div_gᐸ64fᐳᐤnumᐸdoubleᐳㆍnumᐸdoubleᐳᐤ  =>  new byte[45]{0x50,0xc5,0xf8,0x77,0x90,0x48,0x89,0x4c,0x24,0x10,0x48,0x89,0x54,0x24,0x18,0xc5,0xfb,0x10,0x44,0x24,0x10,0xc5,0xfb,0x10,0x4c,0x24,0x18,0xc5,0xfb,0x5e,0xc1,0xc5,0xfb,0x11,0x04,0x24,0x48,0x8b,0x04,0x24,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> mod_gᐸ8uᐳᐤnumᐸbyteᐳㆍnumᐸbyteᐳᐤ  =>  new byte[19]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xca,0x33,0xd2,0xf7,0xf1,0x0f,0xb6,0xc2,0xc3};

        public static ReadOnlySpan<byte> mod_gᐸ8iᐳᐤnumᐸsbyteᐳㆍnumᐸsbyteᐳᐤ  =>  new byte[21]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbe,0xc1,0x48,0x0f,0xbe,0xca,0x99,0xf7,0xf9,0x48,0x0f,0xbe,0xc2,0xc3};

        public static ReadOnlySpan<byte> mod_gᐸ16uᐳᐤnumᐸushortᐳㆍnumᐸushortᐳᐤ  =>  new byte[19]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb7,0xc1,0x0f,0xb7,0xca,0x33,0xd2,0xf7,0xf1,0x0f,0xb7,0xc2,0xc3};

        public static ReadOnlySpan<byte> mod_gᐸ16iᐳᐤnumᐸshortᐳㆍnumᐸshortᐳᐤ  =>  new byte[21]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbf,0xc1,0x48,0x0f,0xbf,0xca,0x99,0xf7,0xf9,0x48,0x0f,0xbf,0xc2,0xc3};

        public static ReadOnlySpan<byte> mod_gᐸ32uᐳᐤnumᐸuintᐳㆍnumᐸuintᐳᐤ  =>  new byte[16]{0x0f,0x1f,0x44,0x00,0x00,0x8b,0xc1,0x8b,0xca,0x33,0xd2,0xf7,0xf1,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> mod_gᐸ32iᐳᐤnumᐸintᐳㆍnumᐸintᐳᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x8b,0xc1,0x8b,0xca,0x99,0xf7,0xf9,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> mod_gᐸ64uᐳᐤnumᐸulongᐳㆍnumᐸulongᐳᐤ  =>  new byte[20]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0x48,0x8b,0xca,0x33,0xd2,0x48,0xf7,0xf1,0x48,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> mod_gᐸ64iᐳᐤnumᐸlongᐳㆍnumᐸlongᐳᐤ  =>  new byte[20]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0x48,0x8b,0xca,0x48,0x99,0x48,0xf7,0xf9,0x48,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> mod_gᐸ32fᐳᐤnumᐸfloatᐳㆍnumᐸfloatᐳᐤ  =>  new byte[49]{0x48,0x83,0xec,0x28,0xc5,0xf8,0x77,0x48,0x89,0x4c,0x24,0x30,0x48,0x89,0x54,0x24,0x38,0xc5,0xfa,0x10,0x44,0x24,0x30,0xc5,0xfa,0x10,0x4c,0x24,0x38,0xe8,0xde,0x14,0xb2,0x5d,0xc5,0xfa,0x11,0x44,0x24,0x20,0x8b,0x44,0x24,0x20,0x48,0x83,0xc4,0x28,0xc3};

        public static ReadOnlySpan<byte> mod_gᐸ64fᐳᐤnumᐸdoubleᐳㆍnumᐸdoubleᐳᐤ  =>  new byte[50]{0x48,0x83,0xec,0x28,0xc5,0xf8,0x77,0x48,0x89,0x4c,0x24,0x30,0x48,0x89,0x54,0x24,0x38,0xc5,0xfb,0x10,0x44,0x24,0x30,0xc5,0xfb,0x10,0x4c,0x24,0x38,0xe8,0xfe,0x13,0xb2,0x5d,0xc5,0xfb,0x11,0x44,0x24,0x20,0x48,0x8b,0x44,0x24,0x20,0x48,0x83,0xc4,0x28,0xc3};

        public static ReadOnlySpan<byte> negate_gᐸ8uᐳᐤnumᐸbyteᐳᐤ  =>  new byte[16]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0xf7,0xd0,0xff,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> negate_gᐸ8iᐳᐤnumᐸsbyteᐳᐤ  =>  new byte[16]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbe,0xc1,0xf7,0xd8,0x48,0x0f,0xbe,0xc0,0xc3};

        public static ReadOnlySpan<byte> negate_gᐸ16uᐳᐤnumᐸushortᐳᐤ  =>  new byte[16]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb7,0xc1,0xf7,0xd0,0xff,0xc0,0x0f,0xb7,0xc0,0xc3};

        public static ReadOnlySpan<byte> negate_gᐸ16iᐳᐤnumᐸshortᐳᐤ  =>  new byte[16]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbf,0xc1,0xf7,0xd8,0x48,0x0f,0xbf,0xc0,0xc3};

        public static ReadOnlySpan<byte> negate_gᐸ32uᐳᐤnumᐸuintᐳᐤ  =>  new byte[10]{0x0f,0x1f,0x44,0x00,0x00,0x8b,0xc1,0xf7,0xd8,0xc3};

        public static ReadOnlySpan<byte> negate_gᐸ32iᐳᐤnumᐸintᐳᐤ  =>  new byte[10]{0x0f,0x1f,0x44,0x00,0x00,0x8b,0xc1,0xf7,0xd8,0xc3};

        public static ReadOnlySpan<byte> negate_gᐸ64uᐳᐤnumᐸulongᐳᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0x48,0xf7,0xd8,0xc3};

        public static ReadOnlySpan<byte> negate_gᐸ64iᐳᐤnumᐸlongᐳᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0x48,0xf7,0xd8,0xc3};

        public static ReadOnlySpan<byte> negate_gᐸ32fᐳᐤnumᐸfloatᐳᐤ  =>  new byte[41]{0x50,0xc5,0xf8,0x77,0x90,0x48,0x89,0x4c,0x24,0x10,0xc5,0xfa,0x10,0x44,0x24,0x10,0xc5,0xfa,0x10,0x0d,0x18,0x00,0x00,0x00,0xc5,0xf8,0x57,0xc1,0xc5,0xfa,0x11,0x04,0x24,0x8b,0x04,0x24,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> negate_gᐸ64fᐳᐤnumᐸdoubleᐳᐤ  =>  new byte[42]{0x50,0xc5,0xf8,0x77,0x90,0x48,0x89,0x4c,0x24,0x10,0xc5,0xfb,0x10,0x44,0x24,0x10,0xc5,0xfb,0x10,0x0d,0x18,0x00,0x00,0x00,0xc5,0xf8,0x57,0xc1,0xc5,0xfb,0x11,0x04,0x24,0x48,0x8b,0x04,0x24,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> and_gᐸ8uᐳᐤnumᐸbyteᐳㆍnumᐸbyteᐳᐤ  =>  new byte[17]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x23,0xc2,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> and_gᐸ8iᐳᐤnumᐸsbyteᐳㆍnumᐸsbyteᐳᐤ  =>  new byte[20]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbe,0xc1,0x48,0x0f,0xbe,0xd2,0x23,0xc2,0x48,0x0f,0xbe,0xc0,0xc3};

        public static ReadOnlySpan<byte> and_gᐸ16uᐳᐤnumᐸushortᐳㆍnumᐸushortᐳᐤ  =>  new byte[17]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb7,0xc1,0x0f,0xb7,0xd2,0x23,0xc2,0x0f,0xb7,0xc0,0xc3};

        public static ReadOnlySpan<byte> and_gᐸ16iᐳᐤnumᐸshortᐳㆍnumᐸshortᐳᐤ  =>  new byte[20]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbf,0xc1,0x48,0x0f,0xbf,0xd2,0x23,0xc2,0x48,0x0f,0xbf,0xc0,0xc3};

        public static ReadOnlySpan<byte> and_gᐸ32uᐳᐤnumᐸuintᐳㆍnumᐸuintᐳᐤ  =>  new byte[10]{0x0f,0x1f,0x44,0x00,0x00,0x23,0xd1,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> and_gᐸ32iᐳᐤnumᐸintᐳㆍnumᐸintᐳᐤ  =>  new byte[10]{0x0f,0x1f,0x44,0x00,0x00,0x23,0xd1,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> and_gᐸ64uᐳᐤnumᐸulongᐳㆍnumᐸulongᐳᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x23,0xd1,0x48,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> and_gᐸ64iᐳᐤnumᐸlongᐳㆍnumᐸlongᐳᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x23,0xd1,0x48,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> or_gᐸ8uᐳᐤnumᐸbyteᐳㆍnumᐸbyteᐳᐤ  =>  new byte[17]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x0b,0xc2,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> or_gᐸ8iᐳᐤnumᐸsbyteᐳㆍnumᐸsbyteᐳᐤ  =>  new byte[20]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbe,0xc1,0x48,0x0f,0xbe,0xd2,0x0b,0xc2,0x48,0x0f,0xbe,0xc0,0xc3};

        public static ReadOnlySpan<byte> or_gᐸ16uᐳᐤnumᐸushortᐳㆍnumᐸushortᐳᐤ  =>  new byte[17]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb7,0xc1,0x0f,0xb7,0xd2,0x0b,0xc2,0x0f,0xb7,0xc0,0xc3};

        public static ReadOnlySpan<byte> or_gᐸ16iᐳᐤnumᐸshortᐳㆍnumᐸshortᐳᐤ  =>  new byte[20]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbf,0xc1,0x48,0x0f,0xbf,0xd2,0x0b,0xc2,0x48,0x0f,0xbf,0xc0,0xc3};

        public static ReadOnlySpan<byte> or_gᐸ32uᐳᐤnumᐸuintᐳㆍnumᐸuintᐳᐤ  =>  new byte[10]{0x0f,0x1f,0x44,0x00,0x00,0x0b,0xd1,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> or_gᐸ32iᐳᐤnumᐸintᐳㆍnumᐸintᐳᐤ  =>  new byte[10]{0x0f,0x1f,0x44,0x00,0x00,0x0b,0xd1,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> or_gᐸ64uᐳᐤnumᐸulongᐳㆍnumᐸulongᐳᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0b,0xd1,0x48,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> or_gᐸ64iᐳᐤnumᐸlongᐳㆍnumᐸlongᐳᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0b,0xd1,0x48,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> xor_gᐸ8uᐳᐤnumᐸbyteᐳㆍnumᐸbyteᐳᐤ  =>  new byte[17]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x33,0xc2,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> xor_gᐸ8iᐳᐤnumᐸsbyteᐳㆍnumᐸsbyteᐳᐤ  =>  new byte[20]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbe,0xc1,0x48,0x0f,0xbe,0xd2,0x33,0xc2,0x48,0x0f,0xbe,0xc0,0xc3};

        public static ReadOnlySpan<byte> xor_gᐸ16uᐳᐤnumᐸushortᐳㆍnumᐸushortᐳᐤ  =>  new byte[17]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb7,0xc1,0x0f,0xb7,0xd2,0x33,0xc2,0x0f,0xb7,0xc0,0xc3};

        public static ReadOnlySpan<byte> xor_gᐸ16iᐳᐤnumᐸshortᐳㆍnumᐸshortᐳᐤ  =>  new byte[20]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbf,0xc1,0x48,0x0f,0xbf,0xd2,0x33,0xc2,0x48,0x0f,0xbf,0xc0,0xc3};

        public static ReadOnlySpan<byte> xor_gᐸ32uᐳᐤnumᐸuintᐳㆍnumᐸuintᐳᐤ  =>  new byte[10]{0x0f,0x1f,0x44,0x00,0x00,0x33,0xd1,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> xor_gᐸ32iᐳᐤnumᐸintᐳㆍnumᐸintᐳᐤ  =>  new byte[10]{0x0f,0x1f,0x44,0x00,0x00,0x33,0xd1,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> xor_gᐸ64uᐳᐤnumᐸulongᐳㆍnumᐸulongᐳᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x33,0xd1,0x48,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> xor_gᐸ64iᐳᐤnumᐸlongᐳㆍnumᐸlongᐳᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x33,0xd1,0x48,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> not_gᐸ8uᐳᐤnumᐸbyteᐳᐤ  =>  new byte[14]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0xf7,0xd0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> not_gᐸ8iᐳᐤnumᐸsbyteᐳᐤ  =>  new byte[16]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbe,0xc1,0xf7,0xd0,0x48,0x0f,0xbe,0xc0,0xc3};

        public static ReadOnlySpan<byte> not_gᐸ16uᐳᐤnumᐸushortᐳᐤ  =>  new byte[14]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb7,0xc1,0xf7,0xd0,0x0f,0xb7,0xc0,0xc3};

        public static ReadOnlySpan<byte> not_gᐸ16iᐳᐤnumᐸshortᐳᐤ  =>  new byte[16]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbf,0xc1,0xf7,0xd0,0x48,0x0f,0xbf,0xc0,0xc3};

        public static ReadOnlySpan<byte> not_gᐸ32uᐳᐤnumᐸuintᐳᐤ  =>  new byte[10]{0x0f,0x1f,0x44,0x00,0x00,0x8b,0xc1,0xf7,0xd0,0xc3};

        public static ReadOnlySpan<byte> not_gᐸ32iᐳᐤnumᐸintᐳᐤ  =>  new byte[10]{0x0f,0x1f,0x44,0x00,0x00,0x8b,0xc1,0xf7,0xd0,0xc3};

        public static ReadOnlySpan<byte> not_gᐸ64uᐳᐤnumᐸulongᐳᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0x48,0xf7,0xd0,0xc3};

        public static ReadOnlySpan<byte> not_gᐸ64iᐳᐤnumᐸlongᐳᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0x48,0xf7,0xd0,0xc3};

        public static ReadOnlySpan<byte> sll_gᐸ8uᐳᐤnumᐸbyteᐳㆍ8uᐤ  =>  new byte[17]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xca,0xd3,0xe0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> sll_gᐸ8iᐳᐤnumᐸsbyteᐳㆍ8uᐤ  =>  new byte[19]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbe,0xc1,0x0f,0xb6,0xca,0xd3,0xe0,0x48,0x0f,0xbe,0xc0,0xc3};

        public static ReadOnlySpan<byte> sll_gᐸ16uᐳᐤnumᐸushortᐳㆍ8uᐤ  =>  new byte[17]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb7,0xc1,0x0f,0xb6,0xca,0xd3,0xe0,0x0f,0xb7,0xc0,0xc3};

        public static ReadOnlySpan<byte> sll_gᐸ16iᐳᐤnumᐸshortᐳㆍ8uᐤ  =>  new byte[19]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbf,0xc1,0x0f,0xb6,0xca,0xd3,0xe0,0x48,0x0f,0xbf,0xc0,0xc3};

        public static ReadOnlySpan<byte> sll_gᐸ32uᐳᐤnumᐸuintᐳㆍ8uᐤ  =>  new byte[13]{0x0f,0x1f,0x44,0x00,0x00,0x8b,0xc1,0x0f,0xb6,0xca,0xd3,0xe0,0xc3};

        public static ReadOnlySpan<byte> sll_gᐸ32iᐳᐤnumᐸintᐳㆍ8uᐤ  =>  new byte[13]{0x0f,0x1f,0x44,0x00,0x00,0x8b,0xc1,0x0f,0xb6,0xca,0xd3,0xe0,0xc3};

        public static ReadOnlySpan<byte> sll_gᐸ64uᐳᐤnumᐸulongᐳㆍ8uᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0x0f,0xb6,0xca,0x48,0xd3,0xe0,0xc3};

        public static ReadOnlySpan<byte> sll_gᐸ64iᐳᐤnumᐸlongᐳㆍ8uᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0x0f,0xb6,0xca,0x48,0xd3,0xe0,0xc3};

        public static ReadOnlySpan<byte> srl_gᐸ8uᐳᐤnumᐸbyteᐳㆍ8uᐤ  =>  new byte[17]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xca,0xd3,0xe8,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> srl_gᐸ8iᐳᐤnumᐸsbyteᐳㆍ8uᐤ  =>  new byte[19]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbe,0xc1,0x0f,0xb6,0xca,0xd3,0xe8,0x48,0x0f,0xbe,0xc0,0xc3};

        public static ReadOnlySpan<byte> srl_gᐸ16uᐳᐤnumᐸushortᐳㆍ8uᐤ  =>  new byte[17]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb7,0xc1,0x0f,0xb6,0xca,0xd3,0xe8,0x0f,0xb7,0xc0,0xc3};

        public static ReadOnlySpan<byte> srl_gᐸ16iᐳᐤnumᐸshortᐳㆍ8uᐤ  =>  new byte[19]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbf,0xc1,0x0f,0xb6,0xca,0xd3,0xe8,0x48,0x0f,0xbf,0xc0,0xc3};

        public static ReadOnlySpan<byte> srl_gᐸ32uᐳᐤnumᐸuintᐳㆍ8uᐤ  =>  new byte[13]{0x0f,0x1f,0x44,0x00,0x00,0x8b,0xc1,0x0f,0xb6,0xca,0xd3,0xe8,0xc3};

        public static ReadOnlySpan<byte> srl_gᐸ32iᐳᐤnumᐸintᐳㆍ8uᐤ  =>  new byte[13]{0x0f,0x1f,0x44,0x00,0x00,0x8b,0xc1,0x0f,0xb6,0xca,0xd3,0xe8,0xc3};

        public static ReadOnlySpan<byte> srl_gᐸ64uᐳᐤnumᐸulongᐳㆍ8uᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0x0f,0xb6,0xca,0x48,0xd3,0xe8,0xc3};

        public static ReadOnlySpan<byte> srl_gᐸ64iᐳᐤnumᐸlongᐳㆍ8uᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0x0f,0xb6,0xca,0x48,0xd3,0xe8,0xc3};

        public static ReadOnlySpan<byte> eq_gᐸ8uᐳᐤnumᐸbyteᐳㆍnumᐸbyteᐳᐤ  =>  new byte[23]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x0f,0xb6,0xc0,0x3b,0xc2,0x0f,0x94,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> eq_gᐸ8iᐳᐤnumᐸsbyteᐳㆍnumᐸsbyteᐳᐤ  =>  new byte[26]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbe,0xc1,0x48,0x0f,0xbe,0xd2,0x48,0x0f,0xbe,0xc0,0x3b,0xc2,0x0f,0x94,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> eq_gᐸ16uᐳᐤnumᐸushortᐳㆍnumᐸushortᐳᐤ  =>  new byte[23]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb7,0xc1,0x0f,0xb7,0xd2,0x0f,0xb7,0xc0,0x3b,0xc2,0x0f,0x94,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> eq_gᐸ16iᐳᐤnumᐸshortᐳㆍnumᐸshortᐳᐤ  =>  new byte[26]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbf,0xc1,0x48,0x0f,0xbf,0xd2,0x48,0x0f,0xbf,0xc0,0x3b,0xc2,0x0f,0x94,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> eq_gᐸ32uᐳᐤnumᐸuintᐳㆍnumᐸuintᐳᐤ  =>  new byte[14]{0x0f,0x1f,0x44,0x00,0x00,0x3b,0xca,0x0f,0x94,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> eq_gᐸ32iᐳᐤnumᐸintᐳㆍnumᐸintᐳᐤ  =>  new byte[14]{0x0f,0x1f,0x44,0x00,0x00,0x3b,0xca,0x0f,0x94,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> eq_gᐸ64uᐳᐤnumᐸulongᐳㆍnumᐸulongᐳᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x3b,0xca,0x0f,0x94,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> eq_gᐸ64iᐳᐤnumᐸlongᐳㆍnumᐸlongᐳᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x3b,0xca,0x0f,0x94,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> eq_gᐸ32fᐳᐤnumᐸfloatᐳㆍnumᐸfloatᐳᐤ  =>  new byte[43]{0xc5,0xf8,0x77,0x66,0x90,0x48,0x89,0x4c,0x24,0x08,0x48,0x89,0x54,0x24,0x10,0xc5,0xfa,0x10,0x44,0x24,0x08,0xc5,0xfa,0x10,0x4c,0x24,0x10,0xc5,0xf8,0x2e,0xc1,0x0f,0x9b,0xc0,0x7a,0x03,0x0f,0x94,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> eq_gᐸ64fᐳᐤnumᐸdoubleᐳㆍnumᐸdoubleᐳᐤ  =>  new byte[43]{0xc5,0xf8,0x77,0x66,0x90,0x48,0x89,0x4c,0x24,0x08,0x48,0x89,0x54,0x24,0x10,0xc5,0xfb,0x10,0x44,0x24,0x08,0xc5,0xfb,0x10,0x4c,0x24,0x10,0xc5,0xf9,0x2e,0xc1,0x0f,0x9b,0xc0,0x7a,0x03,0x0f,0x94,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> neq_gᐸ8uᐳᐤnumᐸbyteᐳㆍnumᐸbyteᐳᐤ  =>  new byte[23]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x0f,0xb6,0xc0,0x3b,0xc2,0x0f,0x95,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> neq_gᐸ8iᐳᐤnumᐸsbyteᐳㆍnumᐸsbyteᐳᐤ  =>  new byte[26]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbe,0xc1,0x48,0x0f,0xbe,0xd2,0x48,0x0f,0xbe,0xc0,0x3b,0xc2,0x0f,0x95,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> neq_gᐸ16uᐳᐤnumᐸushortᐳㆍnumᐸushortᐳᐤ  =>  new byte[23]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb7,0xc1,0x0f,0xb7,0xd2,0x0f,0xb7,0xc0,0x3b,0xc2,0x0f,0x95,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> neq_gᐸ16iᐳᐤnumᐸshortᐳㆍnumᐸshortᐳᐤ  =>  new byte[26]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbf,0xc1,0x48,0x0f,0xbf,0xd2,0x48,0x0f,0xbf,0xc0,0x3b,0xc2,0x0f,0x95,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> neq_gᐸ32uᐳᐤnumᐸuintᐳㆍnumᐸuintᐳᐤ  =>  new byte[14]{0x0f,0x1f,0x44,0x00,0x00,0x3b,0xca,0x0f,0x95,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> neq_gᐸ32iᐳᐤnumᐸintᐳㆍnumᐸintᐳᐤ  =>  new byte[14]{0x0f,0x1f,0x44,0x00,0x00,0x3b,0xca,0x0f,0x95,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> neq_gᐸ64uᐳᐤnumᐸulongᐳㆍnumᐸulongᐳᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x3b,0xca,0x0f,0x95,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> neq_gᐸ64iᐳᐤnumᐸlongᐳㆍnumᐸlongᐳᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x3b,0xca,0x0f,0x95,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> neq_gᐸ32fᐳᐤnumᐸfloatᐳㆍnumᐸfloatᐳᐤ  =>  new byte[43]{0xc5,0xf8,0x77,0x66,0x90,0x48,0x89,0x4c,0x24,0x08,0x48,0x89,0x54,0x24,0x10,0xc5,0xfa,0x10,0x44,0x24,0x08,0xc5,0xfa,0x10,0x4c,0x24,0x10,0xc5,0xf8,0x2e,0xc1,0x0f,0x9a,0xc0,0x7a,0x03,0x0f,0x95,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> neq_gᐸ64fᐳᐤnumᐸdoubleᐳㆍnumᐸdoubleᐳᐤ  =>  new byte[43]{0xc5,0xf8,0x77,0x66,0x90,0x48,0x89,0x4c,0x24,0x08,0x48,0x89,0x54,0x24,0x10,0xc5,0xfb,0x10,0x44,0x24,0x08,0xc5,0xfb,0x10,0x4c,0x24,0x10,0xc5,0xf9,0x2e,0xc1,0x0f,0x9a,0xc0,0x7a,0x03,0x0f,0x95,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> lt_gᐸ8uᐳᐤnumᐸbyteᐳㆍnumᐸbyteᐳᐤ  =>  new byte[20]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x3b,0xc2,0x0f,0x92,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> lt_gᐸ8iᐳᐤnumᐸsbyteᐳㆍnumᐸsbyteᐳᐤ  =>  new byte[22]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbe,0xc1,0x48,0x0f,0xbe,0xd2,0x3b,0xc2,0x0f,0x9c,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> lt_gᐸ16uᐳᐤnumᐸushortᐳㆍnumᐸushortᐳᐤ  =>  new byte[20]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb7,0xc1,0x0f,0xb7,0xd2,0x3b,0xc2,0x0f,0x92,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> lt_gᐸ16iᐳᐤnumᐸshortᐳㆍnumᐸshortᐳᐤ  =>  new byte[22]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbf,0xc1,0x48,0x0f,0xbf,0xd2,0x3b,0xc2,0x0f,0x9c,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> lt_gᐸ32uᐳᐤnumᐸuintᐳㆍnumᐸuintᐳᐤ  =>  new byte[14]{0x0f,0x1f,0x44,0x00,0x00,0x3b,0xca,0x0f,0x92,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> lt_gᐸ32iᐳᐤnumᐸintᐳㆍnumᐸintᐳᐤ  =>  new byte[14]{0x0f,0x1f,0x44,0x00,0x00,0x3b,0xca,0x0f,0x9c,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> lt_gᐸ64uᐳᐤnumᐸulongᐳㆍnumᐸulongᐳᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x3b,0xca,0x0f,0x92,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> lt_gᐸ64iᐳᐤnumᐸlongᐳㆍnumᐸlongᐳᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x3b,0xca,0x0f,0x9c,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> lt_gᐸ32fᐳᐤnumᐸfloatᐳㆍnumᐸfloatᐳᐤ  =>  new byte[38]{0xc5,0xf8,0x77,0x66,0x90,0x48,0x89,0x4c,0x24,0x08,0x48,0x89,0x54,0x24,0x10,0xc5,0xfa,0x10,0x44,0x24,0x08,0xc5,0xfa,0x10,0x4c,0x24,0x10,0xc5,0xf8,0x2e,0xc8,0x0f,0x97,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> lt_gᐸ64fᐳᐤnumᐸdoubleᐳㆍnumᐸdoubleᐳᐤ  =>  new byte[38]{0xc5,0xf8,0x77,0x66,0x90,0x48,0x89,0x4c,0x24,0x08,0x48,0x89,0x54,0x24,0x10,0xc5,0xfb,0x10,0x44,0x24,0x08,0xc5,0xfb,0x10,0x4c,0x24,0x10,0xc5,0xf9,0x2e,0xc8,0x0f,0x97,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> gt_gᐸ8uᐳᐤnumᐸbyteᐳㆍnumᐸbyteᐳᐤ  =>  new byte[20]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x3b,0xc2,0x0f,0x97,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> gt_gᐸ8iᐳᐤnumᐸsbyteᐳㆍnumᐸsbyteᐳᐤ  =>  new byte[22]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbe,0xc1,0x48,0x0f,0xbe,0xd2,0x3b,0xc2,0x0f,0x9f,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> gt_gᐸ16uᐳᐤnumᐸushortᐳㆍnumᐸushortᐳᐤ  =>  new byte[20]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb7,0xc1,0x0f,0xb7,0xd2,0x3b,0xc2,0x0f,0x97,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> gt_gᐸ16iᐳᐤnumᐸshortᐳㆍnumᐸshortᐳᐤ  =>  new byte[22]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbf,0xc1,0x48,0x0f,0xbf,0xd2,0x3b,0xc2,0x0f,0x9f,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> gt_gᐸ32uᐳᐤnumᐸuintᐳㆍnumᐸuintᐳᐤ  =>  new byte[14]{0x0f,0x1f,0x44,0x00,0x00,0x3b,0xca,0x0f,0x97,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> gt_gᐸ32iᐳᐤnumᐸintᐳㆍnumᐸintᐳᐤ  =>  new byte[14]{0x0f,0x1f,0x44,0x00,0x00,0x3b,0xca,0x0f,0x9f,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> gt_gᐸ64uᐳᐤnumᐸulongᐳㆍnumᐸulongᐳᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x3b,0xca,0x0f,0x97,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> gt_gᐸ64iᐳᐤnumᐸlongᐳㆍnumᐸlongᐳᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x3b,0xca,0x0f,0x9f,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> gt_gᐸ32fᐳᐤnumᐸfloatᐳㆍnumᐸfloatᐳᐤ  =>  new byte[38]{0xc5,0xf8,0x77,0x66,0x90,0x48,0x89,0x4c,0x24,0x08,0x48,0x89,0x54,0x24,0x10,0xc5,0xfa,0x10,0x44,0x24,0x08,0xc5,0xfa,0x10,0x4c,0x24,0x10,0xc5,0xf8,0x2e,0xc1,0x0f,0x97,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> gt_gᐸ64fᐳᐤnumᐸdoubleᐳㆍnumᐸdoubleᐳᐤ  =>  new byte[38]{0xc5,0xf8,0x77,0x66,0x90,0x48,0x89,0x4c,0x24,0x08,0x48,0x89,0x54,0x24,0x10,0xc5,0xfb,0x10,0x44,0x24,0x08,0xc5,0xfb,0x10,0x4c,0x24,0x10,0xc5,0xf9,0x2e,0xc1,0x0f,0x97,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> lteq_gᐸ8uᐳᐤnumᐸbyteᐳㆍnumᐸbyteᐳᐤ  =>  new byte[20]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x3b,0xc2,0x0f,0x96,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> lteq_gᐸ8iᐳᐤnumᐸsbyteᐳㆍnumᐸsbyteᐳᐤ  =>  new byte[22]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbe,0xc1,0x48,0x0f,0xbe,0xd2,0x3b,0xc2,0x0f,0x9e,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> lteq_gᐸ16uᐳᐤnumᐸushortᐳㆍnumᐸushortᐳᐤ  =>  new byte[20]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb7,0xc1,0x0f,0xb7,0xd2,0x3b,0xc2,0x0f,0x96,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> lteq_gᐸ16iᐳᐤnumᐸshortᐳㆍnumᐸshortᐳᐤ  =>  new byte[22]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbf,0xc1,0x48,0x0f,0xbf,0xd2,0x3b,0xc2,0x0f,0x9e,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> lteq_gᐸ32uᐳᐤnumᐸuintᐳㆍnumᐸuintᐳᐤ  =>  new byte[14]{0x0f,0x1f,0x44,0x00,0x00,0x3b,0xca,0x0f,0x96,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> lteq_gᐸ32iᐳᐤnumᐸintᐳㆍnumᐸintᐳᐤ  =>  new byte[14]{0x0f,0x1f,0x44,0x00,0x00,0x3b,0xca,0x0f,0x9e,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> lteq_gᐸ64uᐳᐤnumᐸulongᐳㆍnumᐸulongᐳᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x3b,0xca,0x0f,0x96,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> lteq_gᐸ64iᐳᐤnumᐸlongᐳㆍnumᐸlongᐳᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x3b,0xca,0x0f,0x9e,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> lteq_gᐸ32fᐳᐤnumᐸfloatᐳㆍnumᐸfloatᐳᐤ  =>  new byte[38]{0xc5,0xf8,0x77,0x66,0x90,0x48,0x89,0x4c,0x24,0x08,0x48,0x89,0x54,0x24,0x10,0xc5,0xfa,0x10,0x44,0x24,0x08,0xc5,0xfa,0x10,0x4c,0x24,0x10,0xc5,0xf8,0x2e,0xc8,0x0f,0x93,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> lteq_gᐸ64fᐳᐤnumᐸdoubleᐳㆍnumᐸdoubleᐳᐤ  =>  new byte[38]{0xc5,0xf8,0x77,0x66,0x90,0x48,0x89,0x4c,0x24,0x08,0x48,0x89,0x54,0x24,0x10,0xc5,0xfb,0x10,0x44,0x24,0x08,0xc5,0xfb,0x10,0x4c,0x24,0x10,0xc5,0xf9,0x2e,0xc8,0x0f,0x93,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> gteq_gᐸ8uᐳᐤnumᐸbyteᐳㆍnumᐸbyteᐳᐤ  =>  new byte[20]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x3b,0xc2,0x0f,0x93,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> gteq_gᐸ8iᐳᐤnumᐸsbyteᐳㆍnumᐸsbyteᐳᐤ  =>  new byte[22]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbe,0xc1,0x48,0x0f,0xbe,0xd2,0x3b,0xc2,0x0f,0x9d,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> gteq_gᐸ16uᐳᐤnumᐸushortᐳㆍnumᐸushortᐳᐤ  =>  new byte[20]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb7,0xc1,0x0f,0xb7,0xd2,0x3b,0xc2,0x0f,0x93,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> gteq_gᐸ16iᐳᐤnumᐸshortᐳㆍnumᐸshortᐳᐤ  =>  new byte[22]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbf,0xc1,0x48,0x0f,0xbf,0xd2,0x3b,0xc2,0x0f,0x9d,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> gteq_gᐸ32uᐳᐤnumᐸuintᐳㆍnumᐸuintᐳᐤ  =>  new byte[14]{0x0f,0x1f,0x44,0x00,0x00,0x3b,0xca,0x0f,0x93,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> gteq_gᐸ32iᐳᐤnumᐸintᐳㆍnumᐸintᐳᐤ  =>  new byte[14]{0x0f,0x1f,0x44,0x00,0x00,0x3b,0xca,0x0f,0x9d,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> gteq_gᐸ64uᐳᐤnumᐸulongᐳㆍnumᐸulongᐳᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x3b,0xca,0x0f,0x93,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> gteq_gᐸ64iᐳᐤnumᐸlongᐳㆍnumᐸlongᐳᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x3b,0xca,0x0f,0x9d,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> gteq_gᐸ32fᐳᐤnumᐸfloatᐳㆍnumᐸfloatᐳᐤ  =>  new byte[38]{0xc5,0xf8,0x77,0x66,0x90,0x48,0x89,0x4c,0x24,0x08,0x48,0x89,0x54,0x24,0x10,0xc5,0xfa,0x10,0x44,0x24,0x08,0xc5,0xfa,0x10,0x4c,0x24,0x10,0xc5,0xf8,0x2e,0xc1,0x0f,0x93,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> gteq_gᐸ64fᐳᐤnumᐸdoubleᐳㆍnumᐸdoubleᐳᐤ  =>  new byte[38]{0xc5,0xf8,0x77,0x66,0x90,0x48,0x89,0x4c,0x24,0x08,0x48,0x89,0x54,0x24,0x10,0xc5,0xfb,0x10,0x44,0x24,0x08,0xc5,0xfb,0x10,0x4c,0x24,0x10,0xc5,0xf9,0x2e,0xc1,0x0f,0x93,0xc0,0x0f,0xb6,0xc0,0xc3};

    }
}
