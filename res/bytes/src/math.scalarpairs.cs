//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.ByteCode
{
    using System;
    using System.Runtime.CompilerServices;


    public static class math_scalarpairs
    {
        public static ReadOnlySpan<byte> not_ᐤConstPairᐸulongᐳᕀinᐤ  =>  new byte[29]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x02,0x48,0xf7,0xd0,0x48,0x8b,0x52,0x08,0x48,0xf7,0xd2,0x48,0x89,0x01,0x48,0x89,0x51,0x08,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> and_ᐤConstPairᐸulongᐳᕀinㆍConstPairᐸulongᐳᕀinᐤ  =>  new byte[30]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x02,0x49,0x23,0x00,0x48,0x8b,0x52,0x08,0x49,0x23,0x50,0x08,0x48,0x89,0x01,0x48,0x89,0x51,0x08,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> nand_ᐤConstPairᐸulongᐳᕀinㆍConstPairᐸulongᐳᕀinᐤ  =>  new byte[36]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x02,0x49,0x23,0x00,0x48,0x8b,0x52,0x08,0x49,0x23,0x50,0x08,0x48,0xf7,0xd0,0x48,0xf7,0xd2,0x48,0x89,0x01,0x48,0x89,0x51,0x08,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> or_ᐤConstPairᐸulongᐳᕀinㆍConstPairᐸulongᐳᕀinᐤ  =>  new byte[30]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x02,0x49,0x0b,0x00,0x48,0x8b,0x52,0x08,0x49,0x0b,0x50,0x08,0x48,0x89,0x01,0x48,0x89,0x51,0x08,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> nor_ᐤConstPairᐸulongᐳᕀinㆍConstPairᐸulongᐳᕀinᐤ  =>  new byte[36]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x02,0x49,0x0b,0x00,0x48,0x8b,0x52,0x08,0x49,0x0b,0x50,0x08,0x48,0xf7,0xd0,0x48,0xf7,0xd2,0x48,0x89,0x01,0x48,0x89,0x51,0x08,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> xor_ᐤConstPairᐸulongᐳᕀinㆍConstPairᐸulongᐳᕀinᐤ  =>  new byte[30]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x02,0x49,0x33,0x00,0x48,0x8b,0x52,0x08,0x49,0x33,0x50,0x08,0x48,0x89,0x01,0x48,0x89,0x51,0x08,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> xnor_ᐤConstPairᐸulongᐳᕀinㆍConstPairᐸulongᐳᕀinᐤ  =>  new byte[36]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x02,0x49,0x33,0x00,0x48,0x8b,0x52,0x08,0x49,0x33,0x50,0x08,0x48,0xf7,0xd0,0x48,0xf7,0xd2,0x48,0x89,0x01,0x48,0x89,0x51,0x08,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> same_ᐤConstPairᐸulongᐳᕀinㆍConstPairᐸulongᐳᕀinᐤ  =>  new byte[35]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x01,0x48,0x3b,0x02,0x75,0x10,0x48,0x8b,0x41,0x08,0x48,0x3b,0x42,0x08,0x0f,0x94,0xc0,0x0f,0xb6,0xc0,0xeb,0x02,0x33,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> lt_ᐤConstPairᐸulongᐳᕀinㆍConstPairᐸulongᐳᕀinᐤ  =>  new byte[52]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x41,0x08,0x4c,0x8b,0x42,0x08,0x49,0x3b,0xc0,0x41,0x0f,0x92,0xc1,0x45,0x0f,0xb6,0xc9,0x49,0x3b,0xc0,0x75,0x0e,0x48,0x8b,0x01,0x48,0x3b,0x02,0x0f,0x92,0xc0,0x0f,0xb6,0xc0,0xeb,0x02,0x33,0xc0,0x41,0x0b,0xc1,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> lteq_ᐤConstPairᐸulongᐳᕀinㆍConstPairᐸulongᐳᕀinᐤ  =>  new byte[52]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x41,0x08,0x4c,0x8b,0x42,0x08,0x49,0x3b,0xc0,0x41,0x0f,0x92,0xc1,0x45,0x0f,0xb6,0xc9,0x49,0x3b,0xc0,0x75,0x0e,0x48,0x8b,0x01,0x48,0x3b,0x02,0x0f,0x96,0xc0,0x0f,0xb6,0xc0,0xeb,0x02,0x33,0xc0,0x41,0x0b,0xc1,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> gt_ᐤConstPairᐸulongᐳᕀinㆍConstPairᐸulongᐳᕀinᐤ  =>  new byte[57]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x41,0x08,0x4c,0x8b,0x42,0x08,0x49,0x3b,0xc0,0x41,0x0f,0x92,0xc1,0x45,0x0f,0xb6,0xc9,0x49,0x3b,0xc0,0x75,0x0e,0x48,0x8b,0x01,0x48,0x3b,0x02,0x0f,0x96,0xc0,0x0f,0xb6,0xc0,0xeb,0x02,0x33,0xc0,0x41,0x0b,0xc1,0x0f,0xb6,0xc0,0xf7,0xd0,0x83,0xe0,0x01,0xc3};

        public static ReadOnlySpan<byte> gteq_ᐤConstPairᐸulongᐳᕀinㆍConstPairᐸulongᐳᕀinᐤ  =>  new byte[57]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x41,0x08,0x4c,0x8b,0x42,0x08,0x49,0x3b,0xc0,0x41,0x0f,0x92,0xc1,0x45,0x0f,0xb6,0xc9,0x49,0x3b,0xc0,0x75,0x0e,0x48,0x8b,0x01,0x48,0x3b,0x02,0x0f,0x92,0xc0,0x0f,0xb6,0xc0,0xeb,0x02,0x33,0xc0,0x41,0x0b,0xc1,0x0f,0xb6,0xc0,0xf7,0xd0,0x83,0xe0,0x01,0xc3};

        public static ReadOnlySpan<byte> add_ᐤConstPairᐸulongᐳᕀinㆍConstPairᐸulongᐳᕀinᐤ  =>  new byte[47]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x02,0x4c,0x8b,0xc8,0x4d,0x03,0x08,0x49,0x3b,0xc1,0x0f,0x97,0xc0,0x0f,0xb6,0xc0,0x48,0x8b,0x52,0x08,0x49,0x03,0x50,0x08,0x8b,0xc0,0x48,0x03,0xc2,0x4c,0x89,0x09,0x48,0x89,0x41,0x08,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> add_ᐤ64uᕀinㆍ64uᕀinㆍ64uᕀrefᐤ  =>  new byte[47]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x01,0x48,0x03,0x02,0x49,0x89,0x00,0x48,0x8b,0x01,0x49,0x3b,0x00,0x0f,0x97,0xc0,0x0f,0xb6,0xc0,0x49,0x83,0xc0,0x08,0x48,0x8b,0x49,0x08,0x48,0x03,0x4a,0x08,0x8b,0xc0,0x48,0x03,0xc1,0x49,0x89,0x00,0xc3};

        public static ReadOnlySpan<byte> sub_ᐤConstPairᐸulongᐳᕀinㆍConstPairᐸulongᐳᕀinᐤ  =>  new byte[47]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x02,0x4c,0x8b,0xc8,0x4d,0x2b,0x08,0x49,0x3b,0xc1,0x0f,0x92,0xc0,0x0f,0xb6,0xc0,0x48,0x8b,0x52,0x08,0x49,0x2b,0x50,0x08,0x8b,0xc0,0x48,0x2b,0xd0,0x4c,0x89,0x09,0x48,0x89,0x51,0x08,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> sub_ᐤ64uᕀinㆍ64uᕀinㆍ64uᕀrefᐤ  =>  new byte[47]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x01,0x48,0x2b,0x02,0x49,0x89,0x00,0x48,0x8b,0x01,0x49,0x3b,0x00,0x0f,0x92,0xc0,0x0f,0xb6,0xc0,0x49,0x83,0xc0,0x08,0x48,0x8b,0x49,0x08,0x48,0x2b,0x4a,0x08,0x8b,0xc0,0x48,0x2b,0xc8,0x49,0x89,0x08,0xc3};

        public static ReadOnlySpan<byte> negate_ᐤConstPairᐸulongᐳᐤ  =>  new byte[45]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x02,0x48,0xf7,0xd0,0x48,0x8b,0x52,0x08,0x48,0xf7,0xd2,0x4c,0x8d,0x40,0x01,0x49,0x3b,0xc0,0x0f,0x97,0xc0,0x0f,0xb6,0xc0,0x48,0x03,0xc2,0x4c,0x89,0x01,0x48,0x89,0x41,0x08,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> dec_ᐤConstPairᐸulongᐳᕀrefᐤ  =>  new byte[41]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x01,0x48,0x8d,0x50,0xff,0x48,0x3b,0xc2,0x0f,0x92,0xc0,0x0f,0xb6,0xc0,0x4c,0x8b,0x41,0x08,0x8b,0xc0,0x4c,0x2b,0xc0,0x48,0x89,0x11,0x4c,0x89,0x41,0x08,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> inc_ᐤConstPairᐸulongᐳᕀrefᐤ  =>  new byte[41]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x01,0x48,0x8d,0x50,0x01,0x48,0x3b,0xc2,0x0f,0x97,0xc0,0x0f,0xb6,0xc0,0x4c,0x8b,0x41,0x08,0x8b,0xc0,0x49,0x03,0xc0,0x48,0x89,0x11,0x48,0x89,0x41,0x08,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> inc_ᐤ64uᕀrefᐤ  =>  new byte[68]{0x48,0x83,0xec,0x18,0x33,0xc0,0x48,0x89,0x44,0x24,0x08,0x48,0x89,0x44,0x24,0x10,0x48,0xc7,0x44,0x24,0x08,0x01,0x00,0x00,0x00,0x33,0xc0,0x48,0x89,0x44,0x24,0x10,0x48,0x8b,0x44,0x24,0x08,0x48,0x01,0x01,0x48,0x8d,0x41,0x08,0x48,0x8b,0x51,0x08,0x4c,0x8d,0x44,0x24,0x08,0x49,0x03,0x50,0x08,0x48,0x89,0x10,0x48,0x8b,0xc1,0x48,0x83,0xc4,0x18,0xc3};

        public static ReadOnlySpan<byte> inc_ᐤ64uᕀinㆍ64uᕀrefᐤ  =>  new byte[85]{0x48,0x83,0xec,0x18,0x33,0xc0,0x48,0x89,0x44,0x24,0x08,0x48,0x89,0x44,0x24,0x10,0x48,0xc7,0x44,0x24,0x08,0x01,0x00,0x00,0x00,0x33,0xc0,0x48,0x89,0x44,0x24,0x10,0x48,0x8b,0x01,0x48,0x03,0x44,0x24,0x08,0x48,0x89,0x02,0x48,0x8b,0x01,0x48,0x3b,0x02,0x0f,0x97,0xc0,0x0f,0xb6,0xc0,0x48,0x83,0xc2,0x08,0x48,0x8b,0x49,0x08,0x4c,0x8d,0x44,0x24,0x08,0x49,0x03,0x48,0x08,0x8b,0xc0,0x48,0x03,0xc1,0x48,0x89,0x02,0x48,0x83,0xc4,0x18,0xc3};

        public static ReadOnlySpan<byte> dec_ᐤ64uᕀrefᐤ  =>  new byte[68]{0x48,0x83,0xec,0x18,0x33,0xc0,0x48,0x89,0x44,0x24,0x08,0x48,0x89,0x44,0x24,0x10,0x48,0xc7,0x44,0x24,0x08,0x01,0x00,0x00,0x00,0x33,0xc0,0x48,0x89,0x44,0x24,0x10,0x48,0x8b,0x44,0x24,0x08,0x48,0x29,0x01,0x48,0x8d,0x41,0x08,0x48,0x8b,0x51,0x08,0x4c,0x8d,0x44,0x24,0x08,0x49,0x2b,0x50,0x08,0x48,0x89,0x10,0x48,0x8b,0xc1,0x48,0x83,0xc4,0x18,0xc3};

        public static ReadOnlySpan<byte> dec_ᐤ64uᕀinㆍ64uᕀrefᐤ  =>  new byte[85]{0x48,0x83,0xec,0x18,0x33,0xc0,0x48,0x89,0x44,0x24,0x08,0x48,0x89,0x44,0x24,0x10,0x48,0xc7,0x44,0x24,0x08,0x01,0x00,0x00,0x00,0x33,0xc0,0x48,0x89,0x44,0x24,0x10,0x48,0x8b,0x01,0x48,0x2b,0x44,0x24,0x08,0x48,0x89,0x02,0x48,0x8b,0x01,0x48,0x3b,0x02,0x0f,0x92,0xc0,0x0f,0xb6,0xc0,0x48,0x83,0xc2,0x08,0x48,0x8b,0x49,0x08,0x4c,0x8d,0x44,0x24,0x08,0x49,0x2b,0x48,0x08,0x8b,0xc0,0x48,0x2b,0xc8,0x48,0x89,0x0a,0x48,0x83,0xc4,0x18,0xc3};

        public static ReadOnlySpan<byte> sll_ᐤConstPairᐸulongᐳᕀinㆍ8uᐤ  =>  new byte[112]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0x45,0x0f,0xb6,0xc0,0x41,0x83,0xf8,0x40,0x7c,0x28,0x41,0x81,0xf8,0x80,0x00,0x00,0x00,0x7c,0x0a,0x33,0xd2,0x48,0x89,0x10,0x48,0x89,0x50,0x08,0xc3,0x48,0x8b,0x12,0x41,0x8d,0x48,0xc0,0x48,0xd3,0xe2,0x48,0x89,0x10,0x45,0x33,0xc0,0x4c,0x89,0x40,0x08,0xc3,0x4c,0x8b,0x4a,0x08,0x45,0x8b,0xd0,0x41,0x83,0xe2,0x3f,0x41,0x8b,0xca,0x49,0xd3,0xe1,0x41,0x8b,0xc8,0xf7,0xd9,0x83,0xc1,0x3f,0x4c,0x8b,0x02,0x49,0xd1,0xe8,0x49,0xd3,0xe8,0x4d,0x0b,0xc1,0x48,0x8b,0x12,0x41,0x8b,0xca,0x48,0xd3,0xe2,0x4c,0x89,0x00,0x48,0x89,0x50,0x08,0xc3};

        public static ReadOnlySpan<byte> srl_ᐤConstPairᐸulongᐳᕀinㆍ8uᐤ  =>  new byte[112]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0x45,0x0f,0xb6,0xc0,0x41,0x83,0xf8,0x40,0x7c,0x28,0x41,0x81,0xf8,0x80,0x00,0x00,0x00,0x7c,0x0a,0x33,0xd2,0x48,0x89,0x10,0x48,0x89,0x50,0x08,0xc3,0x48,0x8b,0x12,0x41,0x8d,0x48,0xc0,0x48,0xd3,0xea,0x45,0x33,0xc0,0x4c,0x89,0x00,0x48,0x89,0x50,0x08,0xc3,0x4c,0x8b,0x4a,0x08,0x45,0x8b,0xd0,0x41,0x83,0xe2,0x3f,0x41,0x8b,0xca,0x4d,0x8b,0xd9,0x49,0xd3,0xeb,0x48,0x8b,0x12,0x41,0x8b,0xca,0x48,0xd3,0xea,0x41,0x8b,0xc8,0xf7,0xd9,0x83,0xc1,0x3f,0x49,0xd1,0xe1,0x49,0xd3,0xe1,0x49,0x0b,0xd1,0x4c,0x89,0x18,0x48,0x89,0x50,0x08,0xc3};

        public static ReadOnlySpan<byte> mullo_ᐤ64uㆍ64uᐤ  =>  new byte[47]{0x50,0x33,0xc0,0x48,0x89,0x04,0x24,0x48,0x89,0x54,0x24,0x18,0x33,0xc0,0x48,0x89,0x04,0x24,0x48,0x8d,0x04,0x24,0x4c,0x8b,0x44,0x24,0x18,0x48,0x8b,0xd1,0xc4,0xc2,0xb3,0xf6,0xd0,0x4c,0x89,0x08,0x48,0x8b,0x04,0x24,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> mulhi_ᐤ64uㆍ64uᐤ  =>  new byte[24]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x89,0x54,0x24,0x10,0x48,0x8b,0x44,0x24,0x10,0x48,0x8b,0xd1,0xc4,0xe2,0xfb,0xf6,0xc0,0xc3};

        public static ReadOnlySpan<byte> mul_ᐤ64uㆍ64uㆍ64uᕀoutㆍ64uᕀoutᐤ  =>  new byte[35]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x89,0x54,0x24,0x10,0x33,0xc0,0x49,0x89,0x00,0x48,0x8b,0x44,0x24,0x10,0x48,0x8b,0xd1,0xc4,0xe2,0xab,0xf6,0xc0,0x4d,0x89,0x10,0x49,0x89,0x01,0xc3};

        public static ReadOnlySpan<byte> mul_ᐤConstPairᐸulongᐳᕀinㆍPairᐸulongᐳᕀrefᐤ  =>  new byte[44]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x01,0x48,0x8b,0x49,0x08,0x48,0x89,0x54,0x24,0x10,0x4c,0x8b,0xc2,0x48,0x8b,0xd0,0xc4,0xe2,0xb3,0xf6,0xc1,0x4d,0x89,0x08,0x48,0x8b,0x54,0x24,0x10,0x48,0x89,0x42,0x08,0x48,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> mul_ᐤ64uㆍ64uㆍPairᐸulongᐳᕀoutᐤ  =>  new byte[49]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x89,0x54,0x24,0x10,0x45,0x39,0x00,0x49,0x8d,0x40,0x08,0x45,0x33,0xc9,0x4d,0x89,0x08,0x4d,0x8b,0xc8,0x4c,0x8b,0x54,0x24,0x10,0x48,0x8b,0xd1,0xc4,0xc2,0xa3,0xf6,0xd2,0x4d,0x89,0x19,0x48,0x89,0x10,0x49,0x8b,0xc0,0xc3};

        public static ReadOnlySpan<byte> mul_ref_ᐤ64uㆍ64uᐤ  =>  new byte[115]{0x0f,0x1f,0x44,0x00,0x00,0xb8,0xff,0xff,0xff,0xff,0x48,0x23,0xc2,0x48,0xc1,0xea,0x20,0x41,0xb9,0xff,0xff,0xff,0xff,0x4d,0x23,0xc8,0x49,0xc1,0xe8,0x20,0x4c,0x8b,0xd0,0x4d,0x0f,0xaf,0xd1,0x4c,0x0f,0xaf,0xca,0x49,0x0f,0xaf,0xc0,0x49,0x0f,0xaf,0xd0,0x4d,0x8b,0xc2,0x49,0xc1,0xe8,0x20,0x4d,0x03,0xc1,0x41,0xb9,0xff,0xff,0xff,0xff,0x4d,0x23,0xc8,0x49,0x03,0xc1,0x4c,0x8b,0xc8,0x49,0xc1,0xe1,0x20,0x41,0xbb,0xff,0xff,0xff,0xff,0x4d,0x23,0xd3,0x4d,0x0b,0xca,0x48,0xc1,0xe8,0x20,0x48,0x03,0xc2,0x49,0xc1,0xe8,0x20,0x49,0x03,0xc0,0x4c,0x89,0x09,0x48,0x89,0x41,0x08,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> lo_ref_ᐤ64uㆍ64uᐤ  =>  new byte[13]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0x48,0x0f,0xaf,0xc2,0xc3};

        public static ReadOnlySpan<byte> mullo_ᐤ32uㆍ32uᐤ  =>  new byte[46]{0x50,0x33,0xc0,0x89,0x44,0x24,0x04,0x89,0x54,0x24,0x18,0x33,0xc0,0x89,0x44,0x24,0x04,0x48,0x8d,0x44,0x24,0x04,0x44,0x8b,0x44,0x24,0x18,0x8b,0xd1,0xc4,0xc2,0x33,0xf6,0xd0,0x44,0x89,0x08,0x8b,0x44,0x24,0x04,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> mulhi_ᐤ32uㆍ32uᐤ  =>  new byte[23]{0x0f,0x1f,0x44,0x00,0x00,0x89,0x54,0x24,0x10,0x8b,0x44,0x24,0x10,0x8b,0xd1,0xc4,0xe2,0x7b,0xf6,0xc0,0x8b,0xc0,0xc3};

        public static ReadOnlySpan<byte> mul_ᐤ32uㆍ32uㆍ32uᕀoutㆍ32uᕀoutᐤ  =>  new byte[32]{0x0f,0x1f,0x44,0x00,0x00,0x89,0x54,0x24,0x10,0x33,0xc0,0x41,0x89,0x00,0x8b,0x44,0x24,0x10,0x8b,0xd1,0xc4,0xe2,0x2b,0xf6,0xc0,0x45,0x89,0x10,0x41,0x89,0x01,0xc3};

        public static ReadOnlySpan<byte> mul_ᐤ32uㆍ32uᐤ  =>  new byte[55]{0x50,0x33,0xc0,0x89,0x44,0x24,0x04,0x89,0x54,0x24,0x18,0x33,0xc0,0x89,0x44,0x24,0x04,0x48,0x8d,0x44,0x24,0x04,0x44,0x8b,0x44,0x24,0x18,0x8b,0xd1,0xc4,0xc2,0x33,0xf6,0xd0,0x44,0x89,0x08,0x8b,0xc2,0x48,0xc1,0xe0,0x20,0x8b,0x54,0x24,0x04,0x48,0x0b,0xc2,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> mul_ᐤ32uㆍ32uㆍPairᐸuintᐳᕀoutᐤ  =>  new byte[46]{0x0f,0x1f,0x44,0x00,0x00,0x89,0x54,0x24,0x10,0x45,0x39,0x00,0x49,0x8d,0x40,0x04,0x45,0x33,0xc9,0x45,0x89,0x08,0x4d,0x8b,0xc8,0x44,0x8b,0x54,0x24,0x10,0x8b,0xd1,0xc4,0xc2,0x23,0xf6,0xd2,0x45,0x89,0x19,0x89,0x10,0x49,0x8b,0xc0,0xc3};

        public static ReadOnlySpan<byte> mul_ᐤConstPairᐸuintᐳᕀinㆍPairᐸuintᐳᕀrefᐤ  =>  new byte[40]{0x0f,0x1f,0x44,0x00,0x00,0x8b,0x01,0x8b,0x49,0x04,0x48,0x89,0x54,0x24,0x10,0x4c,0x8b,0xc2,0x8b,0xd0,0xc4,0xe2,0x33,0xf6,0xc1,0x45,0x89,0x08,0x48,0x8b,0x54,0x24,0x10,0x89,0x42,0x04,0x48,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> add_ᐤ64uᕀrefㆍ64uᕀrefㆍ64uᐤ  =>  new byte[23]{0x0f,0x1f,0x44,0x00,0x00,0x49,0x8b,0xc0,0x48,0x03,0x02,0x48,0x89,0x02,0x49,0x3b,0xc0,0x73,0x03,0x48,0xff,0x01,0xc3};

        public static ReadOnlySpan<byte> add_ᐤ64uᕀrefㆍ64uᕀrefㆍ64uㆍ64uᐤ  =>  new byte[26]{0x0f,0x1f,0x44,0x00,0x00,0x49,0x8b,0xc1,0x48,0x03,0x02,0x48,0x89,0x02,0x49,0x3b,0xc1,0x73,0x03,0x48,0xff,0x01,0x4c,0x01,0x01,0xc3};

        public static ReadOnlySpan<byte> sub_ᐤ64uᕀrefㆍ64uᕀrefㆍ64uᐤ  =>  new byte[17]{0x0f,0x1f,0x44,0x00,0x00,0x4c,0x39,0x02,0x73,0x03,0x48,0xff,0x09,0x4c,0x29,0x02,0xc3};

        public static ReadOnlySpan<byte> sub_ᐤ64uㆍ64uㆍ64uᕀrefㆍ64uᕀrefᐤ  =>  new byte[20]{0x0f,0x1f,0x44,0x00,0x00,0x49,0x29,0x11,0x49,0x39,0x08,0x73,0x03,0x49,0xff,0x09,0x49,0x29,0x08,0xc3};

    }
}
