//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.ByteCode
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public static class lsquare_bytelogic
    {
        public static ReadOnlySpan<byte> not_ᐤ8uᕀinㆍ8uᕀrefᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x01,0x48,0xf7,0xd0,0x48,0x89,0x02,0xc3};

        public static ReadOnlySpan<byte> select_ᐤ8uᕀinㆍ8uᕀinㆍ8uᕀinㆍ8uᕀrefᐤ  =>  new byte[29]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x01,0x48,0x8b,0x12,0x49,0x8b,0x08,0x48,0x23,0xd0,0xc4,0xe2,0xf8,0xf2,0xc1,0x48,0x0b,0xc2,0x49,0x89,0x01,0xc3};

        public static ReadOnlySpan<byte> and_ᐤ8uᕀinㆍ8uᕀinㆍ8uᕀrefᐤ  =>  new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x01,0x48,0x8b,0x12,0x48,0x23,0xc2,0x49,0x89,0x00,0xc3};

        public static ReadOnlySpan<byte> nand_ᐤ8uᕀinㆍ8uᕀinㆍ8uᕀrefᐤ  =>  new byte[21]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x01,0x48,0x8b,0x12,0x48,0x23,0xc2,0x48,0xf7,0xd0,0x49,0x89,0x00,0xc3};

        public static ReadOnlySpan<byte> or_ᐤ8uᕀinㆍ8uᕀinㆍ8uᕀrefᐤ  =>  new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x01,0x48,0x8b,0x12,0x48,0x0b,0xc2,0x49,0x89,0x00,0xc3};

        public static ReadOnlySpan<byte> nor_ᐤ8uᕀinㆍ8uᕀinㆍ8uᕀrefᐤ  =>  new byte[21]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x01,0x48,0x8b,0x12,0x48,0x0b,0xc2,0x48,0xf7,0xd0,0x49,0x89,0x00,0xc3};

        public static ReadOnlySpan<byte> xor_ᐤ8uᕀinㆍ8uᕀinㆍ8uᕀrefᐤ  =>  new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x01,0x48,0x8b,0x12,0x48,0x33,0xc2,0x49,0x89,0x00,0xc3};

        public static ReadOnlySpan<byte> xnor_ᐤ8uᕀinㆍ8uᕀinㆍ8uᕀrefᐤ  =>  new byte[21]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x01,0x48,0x8b,0x12,0x48,0x33,0xc2,0x48,0xf7,0xd0,0x49,0x89,0x00,0xc3};

        public static ReadOnlySpan<byte> nonimpl_ᐤ8uᕀinㆍ8uᕀinㆍ8uᕀrefᐤ  =>  new byte[20]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x01,0x48,0x8b,0x12,0xc4,0xe2,0xf8,0xf2,0xc2,0x49,0x89,0x00,0xc3};

        public static ReadOnlySpan<byte> impl_ᐤ8uᕀinㆍ8uᕀinㆍ8uᕀrefᐤ  =>  new byte[21]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x01,0x48,0x8b,0x12,0x48,0xf7,0xd2,0x48,0x0b,0xc2,0x49,0x89,0x00,0xc3};

        public static ReadOnlySpan<byte> cimpl_ᐤ8uᕀinㆍ8uᕀinㆍ8uᕀrefᐤ  =>  new byte[21]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x01,0x48,0x8b,0x12,0x48,0xf7,0xd0,0x48,0x0b,0xc2,0x49,0x89,0x00,0xc3};

        public static ReadOnlySpan<byte> cnonimpl_ᐤ8uᕀinㆍ8uᕀinㆍ8uᕀrefᐤ  =>  new byte[20]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x01,0x48,0x8b,0x12,0xc4,0xe2,0xe8,0xf2,0xc0,0x49,0x89,0x00,0xc3};

        public static ReadOnlySpan<byte> xornot_ᐤ8uᕀinㆍ8uᕀinㆍ8uᕀrefᐤ  =>  new byte[21]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x01,0x48,0x8b,0x12,0x48,0xf7,0xd2,0x48,0x33,0xc2,0x49,0x89,0x00,0xc3};

        public static ReadOnlySpan<byte> testz_ᐤ8uᕀinㆍ8uᕀinᐤ  =>  new byte[63]{0x48,0x83,0xec,0x18,0xc5,0xf8,0x77,0x48,0x8b,0x01,0x48,0x8b,0x12,0x48,0x89,0x44,0x24,0x10,0x48,0x8d,0x44,0x24,0x10,0xc4,0xe2,0x79,0x59,0x44,0x24,0x10,0x48,0x89,0x54,0x24,0x08,0x48,0x8d,0x44,0x24,0x08,0xc4,0xe2,0x79,0x59,0x4c,0x24,0x08,0xc4,0xe2,0x79,0x17,0xc1,0x0f,0x94,0xc0,0x0f,0xb6,0xc0,0x48,0x83,0xc4,0x18,0xc3};

        public static ReadOnlySpan<byte> testc_ᐤ8uᕀinㆍ8uᕀinᐤ  =>  new byte[63]{0x48,0x83,0xec,0x18,0xc5,0xf8,0x77,0x48,0x8b,0x01,0x48,0x8b,0x12,0x48,0x89,0x44,0x24,0x10,0x48,0x8d,0x44,0x24,0x10,0xc4,0xe2,0x79,0x59,0x44,0x24,0x10,0x48,0x89,0x54,0x24,0x08,0x48,0x8d,0x44,0x24,0x08,0xc4,0xe2,0x79,0x59,0x4c,0x24,0x08,0xc4,0xe2,0x79,0x17,0xc1,0x0f,0x92,0xc0,0x0f,0xb6,0xc0,0x48,0x83,0xc4,0x18,0xc3};

        public static ReadOnlySpan<byte> testc_ᐤ8uᕀinᐤ  =>  new byte[51]{0x50,0xc5,0xf8,0x77,0x90,0x48,0x8b,0x01,0x48,0x89,0x04,0x24,0x48,0x8d,0x04,0x24,0xc4,0xe2,0x79,0x59,0x04,0x24,0xc5,0xf0,0x57,0xc9,0xc5,0xe8,0x57,0xd2,0xc4,0xe2,0x71,0x29,0xca,0xc4,0xe2,0x79,0x17,0xc1,0x0f,0x92,0xc0,0x0f,0xb6,0xc0,0x48,0x83,0xc4,0x08,0xc3};

    }
}
