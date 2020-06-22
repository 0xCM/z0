//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.ByteCode
{
    using System;
    using System.Runtime.CompilerServices;


    public static class numeric_bitset
    {
        public static ReadOnlySpan<byte> uint1_ᐤ32iᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x83,0xe1,0x01,0x0f,0xb6,0xc1,0xc3};

        public static ReadOnlySpan<byte> uint1_ᐤ32uᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x83,0xe1,0x01,0x0f,0xb6,0xc1,0xc3};

        public static ReadOnlySpan<byte> uint1_ᐤ64iᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x83,0xe1,0x01,0x0f,0xb6,0xc1,0xc3};

        public static ReadOnlySpan<byte> uint1_ᐤ64uᐤ  =>  new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x83,0xe0,0x01,0x83,0xe0,0x01,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> uint1_ᐤboolᐤ  =>  new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x84,0xc9,0x75,0x03,0x33,0xc0,0xc3,0xb8,0x01,0x00,0x00,0x00,0xc3};

        public static ReadOnlySpan<byte> add_ᐤsingleㆍsingleᐤ  =>  new byte[30]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x03,0xc2,0x83,0xf8,0x02,0x7d,0x02,0xeb,0x03,0x83,0xc0,0xfe,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> sub_ᐤsingleㆍsingleᐤ  =>  new byte[35]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x2b,0xc2,0x85,0xc0,0x7c,0x05,0x0f,0xb6,0xd0,0xeb,0x06,0x83,0xc0,0x02,0x0f,0xb6,0xd0,0x0f,0xb6,0xc2,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> mul_ᐤsingleㆍsingleᐤ  =>  new byte[30]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x0f,0xaf,0xc2,0x0f,0xb6,0xc0,0x83,0xe0,0x0f,0x0f,0xb6,0xc0,0x83,0xe0,0x01,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> div_ᐤsingleㆍsingleᐤ  =>  new byte[24]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xca,0x99,0xf7,0xf9,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> mod_ᐤsingleㆍsingleᐤ  =>  new byte[24]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xca,0x99,0xf7,0xf9,0x0f,0xb6,0xc2,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> or_ᐤsingleㆍsingleᐤ  =>  new byte[23]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x0b,0xc2,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> and_ᐤsingleㆍsingleᐤ  =>  new byte[23]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x23,0xc2,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> xor_ᐤsingleㆍsingleᐤ  =>  new byte[23]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x33,0xc2,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> srl_ᐤsingleㆍ32iᐤ  =>  new byte[19]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x8b,0xca,0xd3,0xf8,0x83,0xe0,0x01,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> sll_ᐤsingleㆍ32iᐤ  =>  new byte[19]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x8b,0xca,0xd3,0xe0,0x83,0xe0,0x01,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> inc_ᐤsingleᐤ  =>  new byte[42]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x89,0x4c,0x24,0x08,0x80,0x7c,0x24,0x08,0x01,0x74,0x16,0x48,0x8d,0x44,0x24,0x08,0x0f,0xb6,0x10,0xff,0xc2,0x0f,0xb6,0xd2,0x88,0x10,0x83,0xe2,0x01,0x0f,0xb6,0xc2,0xc3,0x33,0xc0,0xc3};

        public static ReadOnlySpan<byte> dec_ᐤsingleᐤ  =>  new byte[39]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x89,0x4c,0x24,0x08,0x80,0x7c,0x24,0x08,0x00,0x74,0x09,0x48,0x8d,0x44,0x24,0x08,0xfe,0x08,0xeb,0x05,0xc6,0x44,0x24,0x08,0x01,0x8b,0x44,0x24,0x08,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> bit_ᐤsingleㆍ32iᐤ  =>  new byte[23]{0x0f,0x1f,0x44,0x00,0x00,0x85,0xd2,0x7e,0x03,0x33,0xc0,0xc3,0x0f,0xb6,0xc1,0x8b,0xca,0xd3,0xe8,0x83,0xe0,0x01,0xc3};

        public static ReadOnlySpan<byte> bit_ᐤsingleㆍ32iㆍ1uᐤ  =>  new byte[60]{0x0f,0x1f,0x44,0x00,0x00,0x85,0xd2,0x7f,0x2f,0x0f,0xb6,0xc1,0x41,0x0f,0xb6,0xc8,0x44,0x8b,0xc1,0x41,0xf7,0xd0,0x41,0xff,0xc0,0x44,0x33,0xc0,0x0f,0xb6,0xca,0xba,0x01,0x00,0x00,0x00,0xd3,0xe2,0x41,0x23,0xd0,0x0f,0xb6,0xd2,0x33,0xc2,0x0f,0xb6,0xc0,0x83,0xe0,0x01,0x0f,0xb6,0xc0,0xc3,0x0f,0xb6,0xc1,0xc3};

        public static ReadOnlySpan<byte> bit_ᐤsingleᕀrefㆍ32iㆍ1uᐤ  =>  new byte[59]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0x85,0xd2,0x7f,0x2e,0x44,0x0f,0xb6,0x08,0x41,0x0f,0xb6,0xc8,0x44,0x8b,0xc1,0x41,0xf7,0xd0,0x41,0xff,0xc0,0x45,0x33,0xc1,0x0f,0xb6,0xca,0xba,0x01,0x00,0x00,0x00,0xd3,0xe2,0x41,0x23,0xd0,0x0f,0xb6,0xd2,0x44,0x33,0xca,0x45,0x0f,0xb6,0xc9,0x44,0x88,0x08,0xc3};

        public static ReadOnlySpan<byte> eq_ᐤsingleㆍsingleᐤ  =>  new byte[20]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x3b,0xc2,0x0f,0x94,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> reduce1_ᐤ32uᐤ  =>  new byte[11]{0x0f,0x1f,0x44,0x00,0x00,0x8b,0xc1,0x83,0xe0,0x01,0xc3};

        public static ReadOnlySpan<byte> reduce1_ᐤ8uᐤ  =>  new byte[24]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x8b,0xd0,0xc1,0xea,0x1f,0x03,0xd0,0x83,0xe2,0xfe,0x2b,0xc2,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> uint3_ᐤ8uᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x83,0xe0,0x07,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> uint3_ᐤ8iᐤ  =>  new byte[16]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbe,0xc1,0x83,0xe0,0x07,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> uint3_ᐤ16uᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb7,0xc1,0x83,0xe0,0x07,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> uint3_ᐤ16iᐤ  =>  new byte[16]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbf,0xc1,0x83,0xe0,0x07,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> uint3_ᐤ32iᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x83,0xe1,0x07,0x0f,0xb6,0xc1,0xc3};

        public static ReadOnlySpan<byte> uint3_ᐤ32uᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x83,0xe1,0x07,0x0f,0xb6,0xc1,0xc3};

        public static ReadOnlySpan<byte> uint3_ᐤ64iᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x83,0xe1,0x07,0x0f,0xb6,0xc1,0xc3};

        public static ReadOnlySpan<byte> uint3_ᐤ64uᐤ  =>  new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x83,0xe0,0x07,0x83,0xe0,0x07,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> uint3_ᐤboolᐤ  =>  new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x84,0xc9,0x75,0x03,0x33,0xc0,0xc3,0xb8,0x01,0x00,0x00,0x00,0xc3};

        public static ReadOnlySpan<byte> uint3_ᐤ1uㆍ1uㆍ1uᐤ  =>  new byte[23]{0x0f,0x1f,0x44,0x00,0x00,0xd1,0xe2,0x0b,0xd1,0x41,0xc1,0xe0,0x02,0x41,0x0b,0xd0,0x0f,0xb6,0xc2,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> add_ᐤtriadㆍtriadᐤ  =>  new byte[30]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x03,0xc2,0x83,0xf8,0x08,0x7d,0x02,0xeb,0x03,0x83,0xc0,0xf8,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> sub_ᐤtriadㆍtriadᐤ  =>  new byte[35]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x2b,0xc2,0x85,0xc0,0x7c,0x05,0x0f,0xb6,0xd0,0xeb,0x06,0x83,0xc0,0x08,0x0f,0xb6,0xd0,0x0f,0xb6,0xc2,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> mul_ᐤtriadㆍtriadᐤ  =>  new byte[30]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x0f,0xaf,0xc2,0x0f,0xb6,0xc0,0x83,0xe0,0x0f,0x0f,0xb6,0xc0,0x83,0xe0,0x07,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> div_ᐤtriadㆍtriadᐤ  =>  new byte[24]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xca,0x99,0xf7,0xf9,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> mod_ᐤtriadㆍtriadᐤ  =>  new byte[24]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xca,0x99,0xf7,0xf9,0x0f,0xb6,0xc2,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> or_ᐤtriadㆍtriadᐤ  =>  new byte[23]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x0b,0xc2,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> and_ᐤtriadㆍtriadᐤ  =>  new byte[23]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x23,0xc2,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> xor_ᐤtriadㆍtriadᐤ  =>  new byte[23]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x33,0xc2,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> srl_ᐤtriadㆍ32iᐤ  =>  new byte[19]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x8b,0xca,0xd3,0xf8,0x83,0xe0,0x07,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> sll_ᐤtriadㆍ32iᐤ  =>  new byte[19]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x8b,0xca,0xd3,0xe0,0x83,0xe0,0x07,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> inc_ᐤtriadᐤ  =>  new byte[42]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x89,0x4c,0x24,0x08,0x80,0x7c,0x24,0x08,0x07,0x74,0x16,0x48,0x8d,0x44,0x24,0x08,0x0f,0xb6,0x10,0xff,0xc2,0x0f,0xb6,0xd2,0x88,0x10,0x83,0xe2,0x07,0x0f,0xb6,0xc2,0xc3,0x33,0xc0,0xc3};

        public static ReadOnlySpan<byte> dec_ᐤtriadᐤ  =>  new byte[39]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x89,0x4c,0x24,0x08,0x80,0x7c,0x24,0x08,0x00,0x74,0x09,0x48,0x8d,0x44,0x24,0x08,0xfe,0x08,0xeb,0x05,0xc6,0x44,0x24,0x08,0x07,0x8b,0x44,0x24,0x08,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> bit_ᐤtriadㆍ32iᐤ  =>  new byte[24]{0x0f,0x1f,0x44,0x00,0x00,0x83,0xfa,0x03,0x7c,0x03,0x33,0xc0,0xc3,0x0f,0xb6,0xc1,0x8b,0xca,0xd3,0xe8,0x83,0xe0,0x01,0xc3};

        public static ReadOnlySpan<byte> bit_ᐤtriadㆍ32iㆍ1uᐤ  =>  new byte[61]{0x0f,0x1f,0x44,0x00,0x00,0x83,0xfa,0x03,0x7d,0x2f,0x0f,0xb6,0xc1,0x41,0x0f,0xb6,0xc8,0x44,0x8b,0xc1,0x41,0xf7,0xd0,0x41,0xff,0xc0,0x44,0x33,0xc0,0x0f,0xb6,0xca,0xba,0x01,0x00,0x00,0x00,0xd3,0xe2,0x41,0x23,0xd0,0x0f,0xb6,0xd2,0x33,0xc2,0x0f,0xb6,0xc0,0x83,0xe0,0x07,0x0f,0xb6,0xc0,0xc3,0x0f,0xb6,0xc1,0xc3};

        public static ReadOnlySpan<byte> bit_ᐤtriadᕀrefㆍ32iㆍ1uᐤ  =>  new byte[60]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0x83,0xfa,0x03,0x7d,0x2e,0x44,0x0f,0xb6,0x08,0x41,0x0f,0xb6,0xc8,0x44,0x8b,0xc1,0x41,0xf7,0xd0,0x41,0xff,0xc0,0x45,0x33,0xc1,0x0f,0xb6,0xca,0xba,0x01,0x00,0x00,0x00,0xd3,0xe2,0x41,0x23,0xd0,0x0f,0xb6,0xd2,0x44,0x33,0xca,0x45,0x0f,0xb6,0xc9,0x44,0x88,0x08,0xc3};

        public static ReadOnlySpan<byte> eq_ᐤtriadㆍtriadᐤ  =>  new byte[20]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x3b,0xc2,0x0f,0x94,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> reduce3_ᐤ32uᐤ  =>  new byte[11]{0x0f,0x1f,0x44,0x00,0x00,0x8b,0xc1,0x83,0xe0,0x07,0xc3};

        public static ReadOnlySpan<byte> reduce3_ᐤ8uᐤ  =>  new byte[27]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x8b,0xd0,0xc1,0xfa,0x1f,0x83,0xe2,0x07,0x03,0xd0,0x83,0xe2,0xf8,0x2b,0xc2,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> extend_ᐤduetㆍW3ᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x83,0xe0,0x07,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> extend_ᐤduetㆍW3ㆍn1ᐤ  =>  new byte[36]{0x50,0x0f,0x1f,0x40,0x00,0x0f,0xb6,0xc1,0x83,0xe0,0x07,0x0f,0xb6,0xc0,0x88,0x04,0x24,0x8b,0x04,0x24,0x0f,0xb6,0xc0,0xd1,0xe0,0x83,0xe0,0x07,0x0f,0xb6,0xc0,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> extend_ᐤduetㆍW4ᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x83,0xe0,0x0f,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> extend_ᐤduetㆍW5ᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x83,0xe0,0x1f,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> extend_ᐤduetㆍW6ᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x83,0xe0,0x3f,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> extend_ᐤduetㆍW8ᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> extend_ᐤduetㆍW8ㆍn2ᐤ  =>  new byte[34]{0x50,0x0f,0x1f,0x40,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xc0,0x88,0x04,0x24,0x8b,0x04,0x24,0x0f,0xb6,0xc0,0xc1,0xe0,0x02,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> extend_ᐤduetㆍW8ㆍn3ᐤ  =>  new byte[34]{0x50,0x0f,0x1f,0x40,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xc0,0x88,0x04,0x24,0x8b,0x04,0x24,0x0f,0xb6,0xc0,0xc1,0xe0,0x03,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> extend_ᐤduetㆍW8ㆍn4ᐤ  =>  new byte[34]{0x50,0x0f,0x1f,0x40,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xc0,0x88,0x04,0x24,0x8b,0x04,0x24,0x0f,0xb6,0xc0,0xc1,0xe0,0x04,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> extend_ᐤtriadㆍW4ᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x83,0xe0,0x0f,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> extend_ᐤtriadㆍW5ᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x83,0xe0,0x1f,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> extend_ᐤtriadㆍW6ᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x83,0xe0,0x3f,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> extend_ᐤtriadㆍW8ᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> join_ᐤsingleㆍsingleᐤ  =>  new byte[75]{0x48,0x83,0xec,0x18,0x90,0x0f,0xb6,0xc1,0x83,0xe0,0x03,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x10,0x0f,0xb6,0xc2,0x83,0xe0,0x03,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x08,0x8b,0x44,0x24,0x08,0x0f,0xb6,0xc0,0xd1,0xe0,0x83,0xe0,0x03,0x0f,0xb6,0xc0,0x88,0x04,0x24,0x8b,0x44,0x24,0x10,0x0f,0xb6,0xc0,0x8b,0x14,0x24,0x0f,0xb6,0xd2,0x0b,0xc2,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x48,0x83,0xc4,0x18,0xc3};

        public static ReadOnlySpan<byte> join_ᐤsingleㆍsingleㆍsingleᐤ  =>  new byte[137]{0x48,0x83,0xec,0x38,0x90,0x0f,0xb6,0xc1,0x83,0xe0,0x07,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x30,0x0f,0xb6,0xc2,0x83,0xe0,0x07,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x28,0x8b,0x44,0x24,0x28,0x0f,0xb6,0xc0,0xd1,0xe0,0x83,0xe0,0x07,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x20,0x8b,0x44,0x24,0x30,0x0f,0xb6,0xc0,0x8b,0x54,0x24,0x20,0x0f,0xb6,0xd2,0x0b,0xc2,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x18,0x41,0x0f,0xb6,0xc0,0x83,0xe0,0x07,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x10,0x8b,0x44,0x24,0x10,0x0f,0xb6,0xc0,0xc1,0xe0,0x02,0x83,0xe0,0x07,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x08,0x8b,0x44,0x24,0x18,0x0f,0xb6,0xc0,0x8b,0x54,0x24,0x08,0x0f,0xb6,0xd2,0x0b,0xc2,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x48,0x83,0xc4,0x38,0xc3};

        public static ReadOnlySpan<byte> join_ᐤduetㆍduetᐤ  =>  new byte[76]{0x48,0x83,0xec,0x18,0x90,0x0f,0xb6,0xc1,0x83,0xe0,0x0f,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x10,0x0f,0xb6,0xc2,0x83,0xe0,0x0f,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x08,0x8b,0x44,0x24,0x08,0x0f,0xb6,0xc0,0xc1,0xe0,0x02,0x83,0xe0,0x0f,0x0f,0xb6,0xc0,0x88,0x04,0x24,0x8b,0x44,0x24,0x10,0x0f,0xb6,0xc0,0x8b,0x14,0x24,0x0f,0xb6,0xd2,0x0b,0xc2,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x48,0x83,0xc4,0x18,0xc3};

        public static ReadOnlySpan<byte> join_ᐤduetㆍduetㆍduetᐤ  =>  new byte[138]{0x48,0x83,0xec,0x38,0x90,0x0f,0xb6,0xc1,0x83,0xe0,0x3f,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x30,0x0f,0xb6,0xc2,0x83,0xe0,0x3f,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x28,0x8b,0x44,0x24,0x28,0x0f,0xb6,0xc0,0xc1,0xe0,0x02,0x83,0xe0,0x3f,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x20,0x8b,0x44,0x24,0x30,0x0f,0xb6,0xc0,0x8b,0x54,0x24,0x20,0x0f,0xb6,0xd2,0x0b,0xc2,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x18,0x41,0x0f,0xb6,0xc0,0x83,0xe0,0x3f,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x10,0x8b,0x44,0x24,0x10,0x0f,0xb6,0xc0,0xc1,0xe0,0x04,0x83,0xe0,0x3f,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x08,0x8b,0x44,0x24,0x18,0x0f,0xb6,0xc0,0x8b,0x54,0x24,0x08,0x0f,0xb6,0xd2,0x0b,0xc2,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x48,0x83,0xc4,0x38,0xc3};

        public static ReadOnlySpan<byte> join_ᐤduetㆍduetㆍduetㆍduetᐤ  =>  new byte[184]{0x48,0x83,0xec,0x48,0x90,0x0f,0xb6,0xc1,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x40,0x0f,0xb6,0xc2,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x38,0x8b,0x44,0x24,0x38,0x0f,0xb6,0xc0,0xc1,0xe0,0x02,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x30,0x8b,0x44,0x24,0x40,0x0f,0xb6,0xc0,0x8b,0x54,0x24,0x30,0x0f,0xb6,0xd2,0x0b,0xc2,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x28,0x41,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x20,0x8b,0x44,0x24,0x20,0x0f,0xb6,0xc0,0xc1,0xe0,0x04,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x18,0x8b,0x44,0x24,0x28,0x0f,0xb6,0xc0,0x8b,0x54,0x24,0x18,0x0f,0xb6,0xd2,0x0b,0xc2,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x10,0x41,0x0f,0xb6,0xc1,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x08,0x8b,0x44,0x24,0x08,0x0f,0xb6,0xc0,0xc1,0xe0,0x06,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x88,0x04,0x24,0x8b,0x44,0x24,0x10,0x0f,0xb6,0xc0,0x8b,0x14,0x24,0x0f,0xb6,0xd2,0x0b,0xc2,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x48,0x83,0xc4,0x48,0xc3};

        public static ReadOnlySpan<byte> join_ᐤtriadㆍtriadㆍduetᐤ  =>  new byte[129]{0x48,0x83,0xec,0x38,0x90,0x0f,0xb6,0xc1,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x30,0x0f,0xb6,0xc2,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x28,0x8b,0x44,0x24,0x28,0x0f,0xb6,0xc0,0xc1,0xe0,0x03,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x20,0x8b,0x44,0x24,0x30,0x0f,0xb6,0xc0,0x8b,0x54,0x24,0x20,0x0f,0xb6,0xd2,0x0b,0xc2,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x18,0x41,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x10,0x8b,0x44,0x24,0x10,0x0f,0xb6,0xc0,0xc1,0xe0,0x06,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x88,0x44,0x24,0x08,0x8b,0x44,0x24,0x18,0x0f,0xb6,0xc0,0x8b,0x54,0x24,0x08,0x0f,0xb6,0xd2,0x0b,0xc2,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x48,0x83,0xc4,0x38,0xc3};

        public static ReadOnlySpan<byte> uint2_ᐤ8uᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x83,0xe0,0x03,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> uint2_ᐤ8iᐤ  =>  new byte[16]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbe,0xc1,0x83,0xe0,0x03,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> uint2_ᐤ16uᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb7,0xc1,0x83,0xe0,0x03,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> uint2_ᐤ16iᐤ  =>  new byte[16]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbf,0xc1,0x83,0xe0,0x03,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> uint2_ᐤ32iᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x83,0xe1,0x03,0x0f,0xb6,0xc1,0xc3};

        public static ReadOnlySpan<byte> uint2_ᐤ32uᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x83,0xe1,0x03,0x0f,0xb6,0xc1,0xc3};

        public static ReadOnlySpan<byte> uint2_ᐤ64iᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x83,0xe1,0x03,0x0f,0xb6,0xc1,0xc3};

        public static ReadOnlySpan<byte> uint2_ᐤ64uᐤ  =>  new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x83,0xe0,0x03,0x83,0xe0,0x03,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> uint2_ᐤboolᐤ  =>  new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x84,0xc9,0x75,0x03,0x33,0xc0,0xc3,0xb8,0x01,0x00,0x00,0x00,0xc3};

        public static ReadOnlySpan<byte> uint2_ᐤ1uㆍ1uㆍ1uᐤ  =>  new byte[23]{0x0f,0x1f,0x44,0x00,0x00,0xd1,0xe2,0x0b,0xd1,0x41,0xc1,0xe0,0x02,0x41,0x0b,0xd0,0x0f,0xb6,0xc2,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> add_ᐤduetㆍduetᐤ  =>  new byte[30]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x03,0xc2,0x83,0xf8,0x04,0x7d,0x02,0xeb,0x03,0x83,0xc0,0xfc,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> sub_ᐤduetㆍduetᐤ  =>  new byte[35]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x2b,0xc2,0x85,0xc0,0x7c,0x05,0x0f,0xb6,0xd0,0xeb,0x06,0x83,0xc0,0x04,0x0f,0xb6,0xd0,0x0f,0xb6,0xc2,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> mul_ᐤduetㆍduetᐤ  =>  new byte[30]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x0f,0xaf,0xc2,0x0f,0xb6,0xc0,0x83,0xe0,0x0f,0x0f,0xb6,0xc0,0x83,0xe0,0x03,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> div_ᐤduetㆍduetᐤ  =>  new byte[24]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xca,0x99,0xf7,0xf9,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> mod_ᐤduetㆍduetᐤ  =>  new byte[24]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xca,0x99,0xf7,0xf9,0x0f,0xb6,0xc2,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> or_ᐤduetㆍduetᐤ  =>  new byte[23]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x0b,0xc2,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> and_ᐤduetㆍduetᐤ  =>  new byte[23]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x23,0xc2,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> xor_ᐤduetㆍduetᐤ  =>  new byte[23]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x33,0xc2,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> srl_ᐤduetㆍ32iᐤ  =>  new byte[19]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x8b,0xca,0xd3,0xf8,0x83,0xe0,0x03,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> sll_ᐤduetㆍ32iᐤ  =>  new byte[19]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x8b,0xca,0xd3,0xe0,0x83,0xe0,0x03,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> inc_ᐤduetᐤ  =>  new byte[42]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x89,0x4c,0x24,0x08,0x80,0x7c,0x24,0x08,0x03,0x74,0x16,0x48,0x8d,0x44,0x24,0x08,0x0f,0xb6,0x10,0xff,0xc2,0x0f,0xb6,0xd2,0x88,0x10,0x83,0xe2,0x03,0x0f,0xb6,0xc2,0xc3,0x33,0xc0,0xc3};

        public static ReadOnlySpan<byte> dec_ᐤduetᐤ  =>  new byte[39]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x89,0x4c,0x24,0x08,0x80,0x7c,0x24,0x08,0x00,0x74,0x09,0x48,0x8d,0x44,0x24,0x08,0xfe,0x08,0xeb,0x05,0xc6,0x44,0x24,0x08,0x03,0x8b,0x44,0x24,0x08,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> bit_ᐤduetㆍ32iᐤ  =>  new byte[24]{0x0f,0x1f,0x44,0x00,0x00,0x83,0xfa,0x02,0x7c,0x03,0x33,0xc0,0xc3,0x0f,0xb6,0xc1,0x8b,0xca,0xd3,0xe8,0x83,0xe0,0x01,0xc3};

        public static ReadOnlySpan<byte> bit_ᐤduetㆍ32iㆍ1uᐤ  =>  new byte[61]{0x0f,0x1f,0x44,0x00,0x00,0x83,0xfa,0x02,0x7d,0x2f,0x0f,0xb6,0xc1,0x41,0x0f,0xb6,0xc8,0x44,0x8b,0xc1,0x41,0xf7,0xd0,0x41,0xff,0xc0,0x44,0x33,0xc0,0x0f,0xb6,0xca,0xba,0x01,0x00,0x00,0x00,0xd3,0xe2,0x41,0x23,0xd0,0x0f,0xb6,0xd2,0x33,0xc2,0x0f,0xb6,0xc0,0x83,0xe0,0x03,0x0f,0xb6,0xc0,0xc3,0x0f,0xb6,0xc1,0xc3};

        public static ReadOnlySpan<byte> bit_ᐤduetᕀrefㆍ32iㆍ1uᐤ  =>  new byte[60]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0x83,0xfa,0x02,0x7d,0x2e,0x44,0x0f,0xb6,0x08,0x41,0x0f,0xb6,0xc8,0x44,0x8b,0xc1,0x41,0xf7,0xd0,0x41,0xff,0xc0,0x45,0x33,0xc1,0x0f,0xb6,0xca,0xba,0x01,0x00,0x00,0x00,0xd3,0xe2,0x41,0x23,0xd0,0x0f,0xb6,0xd2,0x44,0x33,0xca,0x45,0x0f,0xb6,0xc9,0x44,0x88,0x08,0xc3};

        public static ReadOnlySpan<byte> eq_ᐤduetㆍduetᐤ  =>  new byte[20]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x3b,0xc2,0x0f,0x94,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> reduce2_ᐤ32uᐤ  =>  new byte[11]{0x0f,0x1f,0x44,0x00,0x00,0x8b,0xc1,0x83,0xe0,0x03,0xc3};

        public static ReadOnlySpan<byte> reduce2_ᐤ8uᐤ  =>  new byte[27]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x8b,0xd0,0xc1,0xfa,0x1f,0x83,0xe2,0x03,0x03,0xd0,0x83,0xe2,0xfc,0x2b,0xc2,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> uint4_ᐤ8uᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x83,0xe0,0x0f,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> uint4_ᐤ8iᐤ  =>  new byte[16]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbe,0xc1,0x83,0xe0,0x0f,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> uint4_ᐤ16uᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb7,0xc1,0x83,0xe0,0x0f,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> uint4_ᐤ16iᐤ  =>  new byte[16]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbf,0xc1,0x83,0xe0,0x0f,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> uint4_ᐤ32iᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x83,0xe1,0x0f,0x0f,0xb6,0xc1,0xc3};

        public static ReadOnlySpan<byte> uint4_ᐤ32uᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x83,0xe1,0x0f,0x0f,0xb6,0xc1,0xc3};

        public static ReadOnlySpan<byte> uint4_ᐤ64iᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x83,0xe1,0x0f,0x0f,0xb6,0xc1,0xc3};

        public static ReadOnlySpan<byte> uint4_ᐤ64uᐤ  =>  new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x83,0xe0,0x0f,0x83,0xe0,0x0f,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> uint4_ᐤ1uㆍ1uㆍ1uㆍ1uᐤ  =>  new byte[30]{0x0f,0x1f,0x44,0x00,0x00,0xd1,0xe2,0x0b,0xd1,0x41,0xc1,0xe0,0x02,0x41,0x0b,0xd0,0x41,0xc1,0xe1,0x03,0x41,0x0b,0xd1,0x0f,0xb6,0xc2,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> add_ᐤquartetㆍquartetᐤ  =>  new byte[36]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x03,0xc2,0x0f,0xb6,0xc0,0x83,0xf8,0x10,0x7d,0x02,0xeb,0x06,0x83,0xc0,0xf0,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> sub_ᐤquartetㆍquartetᐤ  =>  new byte[29]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x2b,0xc2,0x85,0xc0,0x7c,0x02,0xeb,0x03,0x83,0xc0,0x10,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> mul_ᐤquartetㆍquartetᐤ  =>  new byte[27]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x0f,0xaf,0xc2,0x83,0xe0,0x0f,0x0f,0xb6,0xc0,0x83,0xe0,0x0f,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> inc_ᐤquartetᐤ  =>  new byte[42]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x89,0x4c,0x24,0x08,0x80,0x7c,0x24,0x08,0x0f,0x74,0x16,0x48,0x8d,0x44,0x24,0x08,0x0f,0xb6,0x10,0xff,0xc2,0x0f,0xb6,0xd2,0x88,0x10,0x83,0xe2,0x0f,0x0f,0xb6,0xc2,0xc3,0x33,0xc0,0xc3};

        public static ReadOnlySpan<byte> dec_ᐤquartetᐤ  =>  new byte[39]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x89,0x4c,0x24,0x08,0x80,0x7c,0x24,0x08,0x00,0x74,0x09,0x48,0x8d,0x44,0x24,0x08,0xfe,0x08,0xeb,0x05,0xc6,0x44,0x24,0x08,0x0f,0x8b,0x44,0x24,0x08,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> hi_ᐤquartetᐤ  =>  new byte[21]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0xc1,0xf8,0x02,0x83,0xe0,0x03,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> lo_ᐤquartetᐤ  =>  new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x83,0xe0,0x03,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> bit_ᐤquartetㆍ32iᐤ  =>  new byte[24]{0x0f,0x1f,0x44,0x00,0x00,0x83,0xfa,0x04,0x7c,0x03,0x33,0xc0,0xc3,0x0f,0xb6,0xc1,0x8b,0xca,0xd3,0xe8,0x83,0xe0,0x01,0xc3};

        public static ReadOnlySpan<byte> bit_ᐤquartetㆍ32iㆍ1uᐤ  =>  new byte[61]{0x0f,0x1f,0x44,0x00,0x00,0x83,0xfa,0x04,0x7d,0x2f,0x0f,0xb6,0xc1,0x41,0x0f,0xb6,0xc8,0x44,0x8b,0xc1,0x41,0xf7,0xd0,0x41,0xff,0xc0,0x44,0x33,0xc0,0x0f,0xb6,0xca,0xba,0x01,0x00,0x00,0x00,0xd3,0xe2,0x41,0x23,0xd0,0x0f,0xb6,0xd2,0x33,0xc2,0x0f,0xb6,0xc0,0x83,0xe0,0x0f,0x0f,0xb6,0xc0,0xc3,0x0f,0xb6,0xc1,0xc3};

        public static ReadOnlySpan<byte> bit_ᐤquartetᕀrefㆍ32iㆍ1uᐤ  =>  new byte[60]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0x83,0xfa,0x04,0x7d,0x2e,0x44,0x0f,0xb6,0x08,0x41,0x0f,0xb6,0xc8,0x44,0x8b,0xc1,0x41,0xf7,0xd0,0x41,0xff,0xc0,0x45,0x33,0xc1,0x0f,0xb6,0xca,0xba,0x01,0x00,0x00,0x00,0xd3,0xe2,0x41,0x23,0xd0,0x0f,0xb6,0xd2,0x44,0x33,0xca,0x45,0x0f,0xb6,0xc9,0x44,0x88,0x08,0xc3};

        public static ReadOnlySpan<byte> reduce4_ᐤ32uᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x83,0xe1,0x0f,0x0f,0xb6,0xc1,0xc3};

        public static ReadOnlySpan<byte> reduce4_ᐤ32iᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x83,0xe1,0x0f,0x0f,0xb6,0xc1,0xc3};

        public static ReadOnlySpan<byte> uint5_ᐤ8uᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x83,0xe0,0x1f,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> uint5_ᐤ8iᐤ  =>  new byte[16]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbe,0xc1,0x83,0xe0,0x1f,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> uint5_ᐤ16uᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb7,0xc1,0x83,0xe0,0x1f,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> uint5_ᐤ16iᐤ  =>  new byte[16]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbf,0xc1,0x83,0xe0,0x1f,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> uint5_ᐤ32iᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x83,0xe1,0x1f,0x0f,0xb6,0xc1,0xc3};

        public static ReadOnlySpan<byte> uint5_ᐤ32uᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x83,0xe1,0x1f,0x0f,0xb6,0xc1,0xc3};

        public static ReadOnlySpan<byte> uint5_ᐤ64iᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x83,0xe1,0x1f,0x0f,0xb6,0xc1,0xc3};

        public static ReadOnlySpan<byte> uint5_ᐤ64uᐤ  =>  new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x83,0xe0,0x1f,0x83,0xe0,0x1f,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> uint5_ᐤ1uㆍ1uㆍ1uㆍ1uㆍ1uᐤ  =>  new byte[39]{0x0f,0x1f,0x44,0x00,0x00,0xd1,0xe2,0x0b,0xd1,0x41,0xc1,0xe0,0x02,0x41,0x0b,0xd0,0x41,0xc1,0xe1,0x03,0x41,0x0b,0xd1,0x8b,0x44,0x24,0x28,0xc1,0xe0,0x04,0x0b,0xc2,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> add_ᐤquintetㆍquintetᐤ  =>  new byte[36]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x03,0xc2,0x0f,0xb6,0xc0,0x83,0xf8,0x20,0x7d,0x02,0xeb,0x06,0x83,0xc0,0xe0,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> sub_ᐤquintetㆍquintetᐤ  =>  new byte[29]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x2b,0xc2,0x85,0xc0,0x7c,0x02,0xeb,0x03,0x83,0xc0,0x20,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> div_ᐤquintetㆍquintetᐤ  =>  new byte[24]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xca,0x99,0xf7,0xf9,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> mod_ᐤquintetㆍquintetᐤ  =>  new byte[24]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xca,0x99,0xf7,0xf9,0x0f,0xb6,0xc2,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> mul_ᐤquintetㆍquintetᐤ  =>  new byte[27]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x0f,0xaf,0xc2,0x83,0xe0,0x1f,0x0f,0xb6,0xc0,0x83,0xe0,0x1f,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> or_ᐤquintetㆍquintetᐤ  =>  new byte[23]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x0b,0xc2,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> and_ᐤquintetㆍquintetᐤ  =>  new byte[23]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x23,0xc2,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> xor_ᐤquintetㆍquintetᐤ  =>  new byte[23]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x33,0xc2,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> srl_ᐤquintetㆍ32iᐤ  =>  new byte[19]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x8b,0xca,0xd3,0xf8,0x83,0xe0,0x1f,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> sll_ᐤquintetㆍ32iᐤ  =>  new byte[19]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x8b,0xca,0xd3,0xe0,0x83,0xe0,0x1f,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> inc_ᐤquintetᐤ  =>  new byte[42]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x89,0x4c,0x24,0x08,0x80,0x7c,0x24,0x08,0x1f,0x74,0x16,0x48,0x8d,0x44,0x24,0x08,0x0f,0xb6,0x10,0xff,0xc2,0x0f,0xb6,0xd2,0x88,0x10,0x83,0xe2,0x1f,0x0f,0xb6,0xc2,0xc3,0x33,0xc0,0xc3};

        public static ReadOnlySpan<byte> dec_ᐤquintetᐤ  =>  new byte[39]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x89,0x4c,0x24,0x08,0x80,0x7c,0x24,0x08,0x00,0x74,0x09,0x48,0x8d,0x44,0x24,0x08,0xfe,0x08,0xeb,0x05,0xc6,0x44,0x24,0x08,0x1f,0x8b,0x44,0x24,0x08,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> hi_ᐤquintetᐤ  =>  new byte[21]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0xc1,0xf8,0x02,0x83,0xe0,0x03,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> lo_ᐤquintetᐤ  =>  new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x83,0xe0,0x03,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> bit_ᐤquintetㆍ32iᐤ  =>  new byte[24]{0x0f,0x1f,0x44,0x00,0x00,0x83,0xfa,0x05,0x7c,0x03,0x33,0xc0,0xc3,0x0f,0xb6,0xc1,0x8b,0xca,0xd3,0xe8,0x83,0xe0,0x01,0xc3};

        public static ReadOnlySpan<byte> bit_ᐤquintetㆍ32iㆍ1uᐤ  =>  new byte[61]{0x0f,0x1f,0x44,0x00,0x00,0x83,0xfa,0x05,0x7d,0x2f,0x0f,0xb6,0xc1,0x41,0x0f,0xb6,0xc8,0x44,0x8b,0xc1,0x41,0xf7,0xd0,0x41,0xff,0xc0,0x44,0x33,0xc0,0x0f,0xb6,0xca,0xba,0x01,0x00,0x00,0x00,0xd3,0xe2,0x41,0x23,0xd0,0x0f,0xb6,0xd2,0x33,0xc2,0x0f,0xb6,0xc0,0x83,0xe0,0x1f,0x0f,0xb6,0xc0,0xc3,0x0f,0xb6,0xc1,0xc3};

        public static ReadOnlySpan<byte> bit_ᐤquintetᕀrefㆍ32iㆍ1uᐤ  =>  new byte[60]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0x83,0xfa,0x05,0x7d,0x2e,0x44,0x0f,0xb6,0x08,0x41,0x0f,0xb6,0xc8,0x44,0x8b,0xc1,0x41,0xf7,0xd0,0x41,0xff,0xc0,0x45,0x33,0xc1,0x0f,0xb6,0xca,0xba,0x01,0x00,0x00,0x00,0xd3,0xe2,0x41,0x23,0xd0,0x0f,0xb6,0xd2,0x44,0x33,0xca,0x45,0x0f,0xb6,0xc9,0x44,0x88,0x08,0xc3};

        public static ReadOnlySpan<byte> reduce5_ᐤ32uᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x83,0xe1,0x1f,0x0f,0xb6,0xc1,0xc3};

        public static ReadOnlySpan<byte> reduce5_ᐤ32iᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x83,0xe1,0x1f,0x0f,0xb6,0xc1,0xc3};

        public static ReadOnlySpan<byte> uint6_ᐤ8uᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x83,0xe0,0x3f,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> uint6_ᐤ8iᐤ  =>  new byte[16]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbe,0xc1,0x83,0xe0,0x3f,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> uint6_ᐤ16uᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb7,0xc1,0x83,0xe0,0x3f,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> uint6_ᐤ16iᐤ  =>  new byte[16]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbf,0xc1,0x83,0xe0,0x3f,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> uint6_ᐤ32iᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x83,0xe1,0x3f,0x0f,0xb6,0xc1,0xc3};

        public static ReadOnlySpan<byte> uint6_ᐤ32uᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x83,0xe1,0x3f,0x0f,0xb6,0xc1,0xc3};

        public static ReadOnlySpan<byte> uint6_ᐤ64iᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x83,0xe1,0x3f,0x0f,0xb6,0xc1,0xc3};

        public static ReadOnlySpan<byte> uint6_ᐤ64uᐤ  =>  new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x83,0xe0,0x3f,0x83,0xe0,0x3f,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> uint6_ᐤ1uㆍ1uㆍ1uㆍ1uㆍ1uᐤ  =>  new byte[39]{0x0f,0x1f,0x44,0x00,0x00,0xd1,0xe2,0x0b,0xd1,0x41,0xc1,0xe0,0x02,0x41,0x0b,0xd0,0x41,0xc1,0xe1,0x03,0x41,0x0b,0xd1,0x8b,0x44,0x24,0x28,0xc1,0xe0,0x04,0x0b,0xc2,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> add_ᐤsextetㆍsextetᐤ  =>  new byte[36]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x03,0xc2,0x0f,0xb6,0xc0,0x83,0xf8,0x40,0x7d,0x02,0xeb,0x06,0x83,0xc0,0xc0,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> sub_ᐤsextetㆍsextetᐤ  =>  new byte[29]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x2b,0xc2,0x85,0xc0,0x7c,0x02,0xeb,0x03,0x83,0xc0,0x40,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> div_ᐤsextetㆍsextetᐤ  =>  new byte[24]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xca,0x99,0xf7,0xf9,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> mod_ᐤsextetㆍsextetᐤ  =>  new byte[24]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xca,0x99,0xf7,0xf9,0x0f,0xb6,0xc2,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> mul_ᐤsextetㆍsextetᐤ  =>  new byte[27]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x0f,0xaf,0xc2,0x83,0xe0,0x3f,0x0f,0xb6,0xc0,0x83,0xe0,0x3f,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> or_ᐤsextetㆍsextetᐤ  =>  new byte[23]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x0b,0xc2,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> and_ᐤsextetㆍsextetᐤ  =>  new byte[23]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x23,0xc2,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> xor_ᐤsextetㆍsextetᐤ  =>  new byte[23]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x33,0xc2,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> srl_ᐤsextetㆍ32iᐤ  =>  new byte[19]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x8b,0xca,0xd3,0xf8,0x83,0xe0,0x3f,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> sll_ᐤsextetㆍ32iᐤ  =>  new byte[19]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x8b,0xca,0xd3,0xe0,0x83,0xe0,0x3f,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> inc_ᐤsextetᐤ  =>  new byte[42]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x89,0x4c,0x24,0x08,0x80,0x7c,0x24,0x08,0x3f,0x74,0x16,0x48,0x8d,0x44,0x24,0x08,0x0f,0xb6,0x10,0xff,0xc2,0x0f,0xb6,0xd2,0x88,0x10,0x83,0xe2,0x3f,0x0f,0xb6,0xc2,0xc3,0x33,0xc0,0xc3};

        public static ReadOnlySpan<byte> dec_ᐤsextetᐤ  =>  new byte[39]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x89,0x4c,0x24,0x08,0x80,0x7c,0x24,0x08,0x00,0x74,0x09,0x48,0x8d,0x44,0x24,0x08,0xfe,0x08,0xeb,0x05,0xc6,0x44,0x24,0x08,0x3f,0x8b,0x44,0x24,0x08,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> hi_ᐤsextetᐤ  =>  new byte[21]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0xc1,0xf8,0x02,0x83,0xe0,0x03,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> lo_ᐤsextetᐤ  =>  new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x83,0xe0,0x03,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> bit_ᐤsextetㆍ32iᐤ  =>  new byte[24]{0x0f,0x1f,0x44,0x00,0x00,0x83,0xfa,0x06,0x7c,0x03,0x33,0xc0,0xc3,0x0f,0xb6,0xc1,0x8b,0xca,0xd3,0xe8,0x83,0xe0,0x01,0xc3};

        public static ReadOnlySpan<byte> bit_ᐤsextetㆍ32iㆍ1uᐤ  =>  new byte[61]{0x0f,0x1f,0x44,0x00,0x00,0x83,0xfa,0x06,0x7d,0x2f,0x0f,0xb6,0xc1,0x41,0x0f,0xb6,0xc8,0x44,0x8b,0xc1,0x41,0xf7,0xd0,0x41,0xff,0xc0,0x44,0x33,0xc0,0x0f,0xb6,0xca,0xba,0x01,0x00,0x00,0x00,0xd3,0xe2,0x41,0x23,0xd0,0x0f,0xb6,0xd2,0x33,0xc2,0x0f,0xb6,0xc0,0x83,0xe0,0x3f,0x0f,0xb6,0xc0,0xc3,0x0f,0xb6,0xc1,0xc3};

        public static ReadOnlySpan<byte> bit_ᐤsextetᕀrefㆍ32iㆍ1uᐤ  =>  new byte[60]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0x83,0xfa,0x06,0x7d,0x2e,0x44,0x0f,0xb6,0x08,0x41,0x0f,0xb6,0xc8,0x44,0x8b,0xc1,0x41,0xf7,0xd0,0x41,0xff,0xc0,0x45,0x33,0xc1,0x0f,0xb6,0xca,0xba,0x01,0x00,0x00,0x00,0xd3,0xe2,0x41,0x23,0xd0,0x0f,0xb6,0xd2,0x44,0x33,0xca,0x45,0x0f,0xb6,0xc9,0x44,0x88,0x08,0xc3};

        public static ReadOnlySpan<byte> reduce6_ᐤ32uᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x83,0xe1,0x3f,0x0f,0xb6,0xc1,0xc3};

        public static ReadOnlySpan<byte> reduce6_ᐤ32iᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x83,0xe1,0x3f,0x0f,0xb6,0xc1,0xc3};

        public static ReadOnlySpan<byte> uint1_ᐤ8uᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x83,0xe0,0x01,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> uint1_ᐤ8iᐤ  =>  new byte[16]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbe,0xc1,0x83,0xe0,0x01,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> uint1_ᐤ16uᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb7,0xc1,0x83,0xe0,0x01,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> uint1_ᐤ16iᐤ  =>  new byte[16]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbf,0xc1,0x83,0xe0,0x01,0x0f,0xb6,0xc0,0xc3};

    }
}
