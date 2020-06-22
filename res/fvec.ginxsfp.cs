//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.ByteCode
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public static class fvec_ginxsfp
    {
        public static ReadOnlySpan<byte> load_gᐸ32fᐳᐤ32fᐤ  =>  new byte[29]{0x50,0xc5,0xf8,0x77,0x90,0xc5,0xfa,0x11,0x4c,0x24,0x04,0xc5,0xfa,0x10,0x44,0x24,0x04,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> load_gᐸ64fᐳᐤ64fᐤ  =>  new byte[27]{0x50,0xc5,0xf8,0x77,0x90,0xc5,0xfb,0x11,0x0c,0x24,0xc5,0xfb,0x10,0x04,0x24,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> store_gᐸ32fᐳᐤv128x32fᐤ  =>  new byte[47]{0x50,0xc5,0xf8,0x77,0x33,0xc0,0x89,0x44,0x24,0x04,0xc5,0xf9,0x10,0x01,0xc5,0xf0,0x57,0xc9,0xc5,0xfa,0x11,0x4c,0x24,0x04,0xc5,0xfa,0x11,0x4c,0x24,0x04,0xc5,0xfa,0x11,0x44,0x24,0x04,0xc5,0xfa,0x10,0x44,0x24,0x04,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> store_gᐸ64fᐳᐤv128x64fᐤ  =>  new byte[43]{0x50,0xc5,0xf8,0x77,0x33,0xc0,0x48,0x89,0x04,0x24,0xc5,0xf9,0x10,0x01,0xc5,0xf0,0x57,0xc9,0xc5,0xfb,0x11,0x0c,0x24,0xc5,0xfb,0x11,0x0c,0x24,0xc5,0xfb,0x11,0x04,0x24,0xc5,0xfb,0x10,0x04,0x24,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> add_gᐸ32fᐳᐤv128x32fㆍv128x32fᐤ  =>  new byte[26]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x02,0xc4,0xc1,0x79,0x10,0x08,0xc5,0xfa,0x58,0xc1,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> add_gᐸ64fᐳᐤv128x64fㆍv128x64fᐤ  =>  new byte[26]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x02,0xc4,0xc1,0x79,0x10,0x08,0xc5,0xfb,0x58,0xc1,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> sub_gᐸ32fᐳᐤv128x32fㆍv128x32fᐤ  =>  new byte[26]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x02,0xc4,0xc1,0x79,0x10,0x08,0xc5,0xfa,0x5c,0xc1,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> sub_gᐸ64fᐳᐤv128x64fㆍv128x64fᐤ  =>  new byte[26]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x02,0xc4,0xc1,0x79,0x10,0x08,0xc5,0xfb,0x5c,0xc1,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> mul_gᐸ32fᐳᐤv128x32fㆍv128x32fᐤ  =>  new byte[26]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x02,0xc4,0xc1,0x79,0x10,0x08,0xc5,0xfa,0x59,0xc1,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> mul_gᐸ64fᐳᐤv128x64fㆍv128x64fᐤ  =>  new byte[26]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x02,0xc4,0xc1,0x79,0x10,0x08,0xc5,0xfb,0x59,0xc1,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> div_gᐸ32fᐳᐤv128x32fㆍv128x32fᐤ  =>  new byte[26]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x02,0xc4,0xc1,0x79,0x10,0x08,0xc5,0xfa,0x5e,0xc1,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> div_gᐸ64fᐳᐤv128x64fㆍv128x64fᐤ  =>  new byte[26]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x02,0xc4,0xc1,0x79,0x10,0x08,0xc5,0xfb,0x5e,0xc1,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> min_gᐸ32fᐳᐤv128x32fㆍv128x32fᐤ  =>  new byte[26]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x02,0xc4,0xc1,0x79,0x10,0x08,0xc5,0xfa,0x5d,0xc1,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> min_gᐸ64fᐳᐤv128x64fㆍv128x64fᐤ  =>  new byte[26]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x02,0xc4,0xc1,0x79,0x10,0x08,0xc5,0xfb,0x5d,0xc1,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> max_gᐸ32fᐳᐤv128x32fㆍv128x32fᐤ  =>  new byte[26]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x02,0xc4,0xc1,0x79,0x10,0x08,0xc5,0xfa,0x5f,0xc1,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> max_gᐸ64fᐳᐤv128x64fㆍv128x64fᐤ  =>  new byte[26]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x02,0xc4,0xc1,0x79,0x10,0x08,0xc5,0xfb,0x5f,0xc1,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> ceil_gᐸ32fᐳᐤv128x32fᐤ  =>  new byte[23]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x02,0xc4,0xe3,0x79,0x0a,0xc0,0x0a,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> ceil_gᐸ64fᐳᐤv128x64fᐤ  =>  new byte[23]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x02,0xc4,0xe3,0x79,0x0b,0xc0,0x0a,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> floor_gᐸ32fᐳᐤv128x32fᐤ  =>  new byte[23]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x02,0xc4,0xe3,0x79,0x0a,0xc0,0x0a,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> floor_gᐸ64fᐳᐤv128x64fᐤ  =>  new byte[23]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x02,0xc4,0xe3,0x79,0x0b,0xc0,0x0a,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> sqrt_gᐸ32fᐳᐤv128x32fᐤ  =>  new byte[21]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x02,0xc5,0xfa,0x51,0xc0,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> sqrt_gᐸ64fᐳᐤv128x64fᐤ  =>  new byte[21]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x02,0xc5,0xfb,0x51,0xc0,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> fmadd_gᐸ32fᐳᐤv128x32fㆍv128x32fㆍv128x32fᐤ  =>  new byte[32]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x02,0xc4,0xc1,0x79,0x10,0x08,0xc4,0xc1,0x79,0x10,0x11,0xc4,0xe2,0x71,0xa9,0xc2,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> fmadd_gᐸ64fᐳᐤv128x64fㆍv128x64fㆍv128x64fᐤ  =>  new byte[32]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x02,0xc4,0xc1,0x79,0x10,0x08,0xc4,0xc1,0x79,0x10,0x11,0xc4,0xe2,0xf1,0xa9,0xc2,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> fmsub_gᐸ32fᐳᐤv128x32fㆍv128x32fㆍv128x32fᐤ  =>  new byte[32]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x02,0xc4,0xc1,0x79,0x10,0x08,0xc4,0xc1,0x79,0x10,0x11,0xc4,0xe2,0x71,0xab,0xc2,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> fmsub_gᐸ64fᐳᐤv128x64fㆍv128x64fㆍv128x64fᐤ  =>  new byte[32]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x02,0xc4,0xc1,0x79,0x10,0x08,0xc4,0xc1,0x79,0x10,0x11,0xc4,0xe2,0xf1,0xab,0xc2,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> fnmadd_gᐸ32fᐳᐤv128x32fㆍv128x32fㆍv128x32fᐤ  =>  new byte[32]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x02,0xc4,0xc1,0x79,0x10,0x08,0xc4,0xc1,0x79,0x10,0x11,0xc4,0xe2,0x71,0xad,0xc2,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> fnmadd_gᐸ64fᐳᐤv128x64fㆍv128x64fㆍv128x64fᐤ  =>  new byte[32]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x02,0xc4,0xc1,0x79,0x10,0x08,0xc4,0xc1,0x79,0x10,0x11,0xc4,0xe2,0xf1,0xad,0xc2,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> eq_gᐸ32fᐳᐤv128x32fㆍv128x32fᐤ  =>  new byte[31]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x01,0xc5,0xf9,0x10,0x0a,0xc5,0xf8,0x2e,0xc1,0x0f,0x9b,0xc2,0x0f,0x94,0xc0,0x22,0xc2,0x0f,0xb6,0xd0,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> eq_gᐸ64fᐳᐤv128x64fㆍv128x64fᐤ  =>  new byte[31]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x01,0xc5,0xf9,0x10,0x0a,0xc5,0xf9,0x2e,0xc1,0x0f,0x9b,0xc2,0x0f,0x94,0xc0,0x22,0xc2,0x0f,0xb6,0xd0,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> neq_gᐸ32fᐳᐤv128x32fㆍv128x32fᐤ  =>  new byte[31]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x01,0xc5,0xf9,0x10,0x0a,0xc5,0xf8,0x2f,0xc1,0x0f,0x9a,0xc2,0x0f,0x95,0xc0,0x0a,0xc2,0x0f,0xb6,0xd0,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> neq_gᐸ64fᐳᐤv128x64fㆍv128x64fᐤ  =>  new byte[31]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x01,0xc5,0xf9,0x10,0x0a,0xc5,0xf9,0x2f,0xc1,0x0f,0x9a,0xc2,0x0f,0x95,0xc0,0x0a,0xc2,0x0f,0xb6,0xd0,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> lteq_gᐸ32fᐳᐤv128x32fㆍv128x32fᐤ  =>  new byte[24]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x01,0xc5,0xf9,0x10,0x0a,0xc5,0xf8,0x2e,0xc8,0x0f,0x93,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> lteq_gᐸ64fᐳᐤv128x64fㆍv128x64fᐤ  =>  new byte[24]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x01,0xc5,0xf9,0x10,0x0a,0xc5,0xf8,0x2e,0xc8,0x0f,0x93,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> ngt_gᐸ32fᐳᐤv128x32fㆍv128x32fᐤ  =>  new byte[49]{0x50,0xc5,0xf8,0x77,0x90,0xc5,0xf9,0x10,0x01,0xc5,0xf9,0x10,0x0a,0xc5,0xfa,0xc2,0xc1,0x02,0xc5,0xfa,0x11,0x44,0x24,0x04,0x8b,0x44,0x24,0x04,0x25,0xff,0xff,0xff,0x7f,0x3d,0x00,0x00,0x80,0x7f,0x0f,0x9f,0xc0,0x0f,0xb6,0xc0,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> ngt_gᐸ64fᐳᐤv128x64fㆍv128x64fᐤ  =>  new byte[49]{0x50,0xc5,0xf8,0x77,0x90,0xc5,0xf9,0x10,0x01,0xc5,0xf9,0x10,0x0a,0xc5,0xfa,0xc2,0xc1,0x02,0xc5,0xfa,0x11,0x44,0x24,0x04,0x8b,0x44,0x24,0x04,0x25,0xff,0xff,0xff,0x7f,0x3d,0x00,0x00,0x80,0x7f,0x0f,0x9f,0xc0,0x0f,0xb6,0xc0,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> nlt_gᐸ32fᐳᐤv128x32fㆍv128x32fᐤ  =>  new byte[49]{0x50,0xc5,0xf8,0x77,0x90,0xc5,0xf9,0x10,0x01,0xc5,0xf9,0x10,0x0a,0xc5,0xfa,0xc2,0xc1,0x05,0xc5,0xfa,0x11,0x44,0x24,0x04,0x8b,0x44,0x24,0x04,0x25,0xff,0xff,0xff,0x7f,0x3d,0x00,0x00,0x80,0x7f,0x0f,0x9f,0xc0,0x0f,0xb6,0xc0,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> nlt_gᐸ64fᐳᐤv128x64fㆍv128x64fᐤ  =>  new byte[49]{0x50,0xc5,0xf8,0x77,0x90,0xc5,0xf9,0x10,0x01,0xc5,0xf9,0x10,0x0a,0xc5,0xfa,0xc2,0xc1,0x05,0xc5,0xfa,0x11,0x44,0x24,0x04,0x8b,0x44,0x24,0x04,0x25,0xff,0xff,0xff,0x7f,0x3d,0x00,0x00,0x80,0x7f,0x0f,0x9f,0xc0,0x0f,0xb6,0xc0,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> gt_gᐸ32fᐳᐤv128x32fㆍv128x32fᐤ  =>  new byte[24]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x01,0xc5,0xf9,0x10,0x0a,0xc5,0xf8,0x2f,0xc1,0x0f,0x97,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> gt_gᐸ64fᐳᐤv128x64fㆍv128x64fᐤ  =>  new byte[24]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x01,0xc5,0xf9,0x10,0x0a,0xc5,0xf9,0x2f,0xc1,0x0f,0x97,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> gteq_gᐸ32fᐳᐤv128x32fㆍv128x32fᐤ  =>  new byte[24]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x01,0xc5,0xf9,0x10,0x0a,0xc5,0xf8,0x2f,0xc1,0x0f,0x93,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> gteq_gᐸ64fᐳᐤv128x64fㆍv128x64fᐤ  =>  new byte[24]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x01,0xc5,0xf9,0x10,0x0a,0xc5,0xf9,0x2f,0xc1,0x0f,0x93,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> lt_gᐸ32fᐳᐤv128x32fㆍv128x32fᐤ  =>  new byte[24]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x01,0xc5,0xf9,0x10,0x0a,0xc5,0xf8,0x2f,0xc8,0x0f,0x97,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> lt_gᐸ64fᐳᐤv128x64fㆍv128x64fᐤ  =>  new byte[24]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x01,0xc5,0xf9,0x10,0x0a,0xc5,0xf9,0x2f,0xc8,0x0f,0x97,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> cmp_gᐸ32fᐳᐤv128x32fㆍv128x32fㆍFpCmpModeᕀ8uᐤ  =>  new byte[87]{0x56,0x48,0x83,0xec,0x50,0xc5,0xf8,0x77,0x33,0xc0,0x48,0x89,0x44,0x24,0x40,0x48,0x89,0x44,0x24,0x48,0x48,0x8b,0xf1,0xc5,0xf9,0x10,0x02,0xc4,0xc1,0x79,0x10,0x08,0x48,0x8d,0x4c,0x24,0x40,0xc5,0xf9,0x29,0x44,0x24,0x30,0xc5,0xf9,0x29,0x4c,0x24,0x20,0x48,0x8d,0x54,0x24,0x30,0x4c,0x8d,0x44,0x24,0x20,0x45,0x0f,0xb6,0xc9,0xe8,0x8c,0x8a,0xee,0xfd,0xc5,0xf9,0x28,0x44,0x24,0x40,0xc5,0xf9,0x11,0x06,0x48,0x8b,0xc6,0x48,0x83,0xc4,0x50,0x5e,0xc3};

        public static ReadOnlySpan<byte> cmp_gᐸ64fᐳᐤv128x64fㆍv128x64fㆍFpCmpModeᕀ8uᐤ  =>  new byte[87]{0x56,0x48,0x83,0xec,0x50,0xc5,0xf8,0x77,0x33,0xc0,0x48,0x89,0x44,0x24,0x40,0x48,0x89,0x44,0x24,0x48,0x48,0x8b,0xf1,0xc5,0xf9,0x10,0x02,0xc4,0xc1,0x79,0x10,0x08,0x48,0x8d,0x4c,0x24,0x40,0xc5,0xf9,0x29,0x44,0x24,0x30,0xc5,0xf9,0x29,0x4c,0x24,0x20,0x48,0x8d,0x54,0x24,0x30,0x4c,0x8d,0x44,0x24,0x20,0x45,0x0f,0xb6,0xc9,0xe8,0x14,0x8a,0xee,0xfd,0xc5,0xf9,0x28,0x44,0x24,0x40,0xc5,0xf9,0x11,0x06,0x48,0x8b,0xc6,0x48,0x83,0xc4,0x50,0x5e,0xc3};

    }
}
