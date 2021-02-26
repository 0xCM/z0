//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
// Generated   : 2021-02-25 19:10:10 -06:00
//-----------------------------------------------------------------------------
namespace Z0.ByteCode
{
    using System;
    using System.Runtime.CompilerServices;


    public static class polyrand_pcg
    {
        public static ReadOnlySpan<byte> pcg32_ᐤ64uㆍulongᐤ  =>  new byte[98]{0x56,0x48,0x83,0xec,0x30,0x48,0x8b,0xf1,0x33,0xc9,0x48,0x89,0x4c,0x24,0x20,0x48,0x89,0x4c,0x24,0x28,0x41,0x0f,0xb6,0x08,0x4d,0x8b,0x40,0x08,0x33,0xc0,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x44,0x24,0x28,0x48,0x8d,0x44,0x24,0x20,0x84,0xc9,0x75,0x0f,0x48,0x8b,0xc8,0x49,0xb8,0x4f,0x81,0x67,0xf7,0x7e,0x7b,0x05,0x14,0xeb,0x03,0x48,0x8b,0xc8,0xe8,0xb0,0x75,0xa4,0xfd,0x48,0x8b,0x44,0x24,0x20,0x48,0x89,0x06,0x48,0x8b,0x44,0x24,0x28,0x48,0x89,0x46,0x08,0x48,0x8b,0xc6,0x48,0x83,0xc4,0x30,0x5e,0xc3};

        public static ReadOnlySpan<byte> pcg64_ᐤ64uㆍulongᐤ  =>  new byte[98]{0x56,0x48,0x83,0xec,0x30,0x48,0x8b,0xf1,0x33,0xc9,0x48,0x89,0x4c,0x24,0x20,0x48,0x89,0x4c,0x24,0x28,0x41,0x0f,0xb6,0x08,0x4d,0x8b,0x40,0x08,0x33,0xc0,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x44,0x24,0x28,0x48,0x8d,0x44,0x24,0x20,0x84,0xc9,0x75,0x0f,0x48,0x8b,0xc8,0x49,0xb8,0x4f,0x81,0x67,0xf7,0x7e,0x7b,0x05,0x14,0xeb,0x03,0x48,0x8b,0xc8,0xe8,0xe8,0x99,0xbb,0xfe,0x48,0x8b,0x44,0x24,0x20,0x48,0x89,0x06,0x48,0x8b,0x44,0x24,0x28,0x48,0x89,0x46,0x08,0x48,0x8b,0xc6,0x48,0x83,0xc4,0x30,0x5e,0xc3};

        public static ReadOnlySpan<byte> nav32_ᐤulongㆍulongᐤ  =>  new byte[124]{0x56,0x48,0x83,0xec,0x30,0x48,0x8b,0xf1,0x0f,0xb6,0x0a,0x48,0x8b,0x52,0x08,0x84,0xc9,0x75,0x0f,0x48,0xba,0x94,0xa4,0x2a,0xd7,0x8f,0x02,0x00,0x00,0x48,0x8b,0x12,0xeb,0x00,0x33,0xc9,0x48,0x89,0x4c,0x24,0x20,0x48,0x89,0x4c,0x24,0x28,0x41,0x0f,0xb6,0x08,0x4d,0x8b,0x40,0x08,0x33,0xc0,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x44,0x24,0x28,0x48,0x8d,0x44,0x24,0x20,0x84,0xc9,0x75,0x0f,0x48,0x8b,0xc8,0x49,0xb8,0x4f,0x81,0x67,0xf7,0x7e,0x7b,0x05,0x14,0xeb,0x03,0x48,0x8b,0xc8,0xe8,0x96,0x74,0xa4,0xfd,0x48,0x8b,0x44,0x24,0x20,0x48,0x89,0x06,0x48,0x8b,0x44,0x24,0x28,0x48,0x89,0x46,0x08,0x48,0x8b,0xc6,0x48,0x83,0xc4,0x30,0x5e,0xc3};

        public static ReadOnlySpan<byte> nav32_ᐤᐤ  =>  new byte[91]{0x56,0x48,0x83,0xec,0x30,0x48,0x8b,0xf1,0x33,0xc9,0x48,0x89,0x4c,0x24,0x20,0x48,0x89,0x4c,0x24,0x28,0x48,0xb9,0x94,0xa4,0x2a,0xd7,0x8f,0x02,0x00,0x00,0x48,0x8b,0x11,0x33,0xc9,0x48,0x89,0x4c,0x24,0x20,0x48,0x89,0x4c,0x24,0x28,0x48,0x8d,0x4c,0x24,0x20,0x49,0xb8,0x4f,0x81,0x67,0xf7,0x7e,0x7b,0x05,0x14,0xe8,0x27,0x74,0xa4,0xfd,0x48,0x8b,0x44,0x24,0x20,0x48,0x89,0x06,0x48,0x8b,0x44,0x24,0x28,0x48,0x89,0x46,0x08,0x48,0x8b,0xc6,0x48,0x83,0xc4,0x30,0x5e,0xc3};

        public static ReadOnlySpan<byte> nav32Suite_ᐤspan64uㆍspan64uᐤ  =>  new byte[297]{0x41,0x57,0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xec,0x48,0x33,0xc0,0x48,0x89,0x44,0x24,0x38,0x48,0x89,0x44,0x24,0x40,0x48,0x8b,0xf9,0x49,0x8b,0xf0,0x48,0x8b,0x1a,0x8b,0x6a,0x08,0x8b,0xd5,0x48,0x8d,0x4c,0x24,0x38,0xe8,0x90,0xf8,0xff,0xff,0x45,0x33,0xf6,0x85,0xed,0x7e,0x63,0x44,0x3b,0x74,0x24,0x40,0x73,0x7b,0x4d,0x63,0xfe,0x49,0xc1,0xe7,0x04,0x4c,0x03,0x7c,0x24,0x38,0x49,0x63,0xce,0x48,0x8b,0x14,0xcb,0x44,0x3b,0x76,0x08,0x73,0x62,0x48,0x8b,0x0e,0x4d,0x63,0xc6,0x4e,0x8b,0x04,0xc1,0x33,0xc9,0x48,0x89,0x4c,0x24,0x28,0x48,0x89,0x4c,0x24,0x30,0x48,0x89,0x4c,0x24,0x28,0x48,0x89,0x4c,0x24,0x30,0x48,0x8d,0x4c,0x24,0x28,0xe8,0x77,0x73,0xa4,0xfd,0x48,0x8b,0x44,0x24,0x28,0x49,0x89,0x07,0x48,0x8b,0x44,0x24,0x30,0x49,0x89,0x47,0x08,0x41,0xff,0xc6,0x44,0x3b,0xf5,0x7c,0x9d,0x48,0x8b,0x44,0x24,0x38,0x48,0x89,0x07,0x8b,0x44,0x24,0x40,0x89,0x47,0x08,0x48,0x8b,0xc7,0x48,0x83,0xc4,0x48,0x5b,0x5d,0x5e,0x5f,0x41,0x5e,0x41,0x5f,0xc3,0xe8,0xd2,0xb2,0x5f,0x5a,0xcc,0x00,0x19,0x0c,0x07,0x00,0x0c,0x82,0x08,0x30,0x07,0x50,0x06,0x60,0x05,0x70,0x04,0xe0,0x02,0xf0,0x00,0x00,0x40,0x00,0x00,0x00,0x20,0x9f,0x68,0xe1,0xfd,0x7f,0x00,0x00,0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x01,0x48,0xba,0x2d,0x7f,0x95,0x4c,0x2d,0xf4,0x51,0x58,0x48,0x0f,0xaf,0xd0,0x48,0x03,0x51,0x08,0x48,0x89,0x11,0x48,0x8b,0xc8,0x48,0xc1,0xe9,0x3b,0x83,0xc1,0x05,0x48,0x8b,0xd0,0x48,0xd3,0xea,0x48,0x33,0xc2,0x48,0xba,0xd9,0xf2,0x8e,0x10,0x02,0x75,0xf1,0xae,0x48,0x0f,0xaf,0xc2,0x48,0x8b,0xd0,0x48,0xc1,0xea,0x2b,0x48,0x33,0xc2,0xc3};

        public static ReadOnlySpan<byte> next_ᐤPcg64ᕀrefᐤ  =>  new byte[73]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x01,0x48,0xba,0x2d,0x7f,0x95,0x4c,0x2d,0xf4,0x51,0x58,0x48,0x0f,0xaf,0xd0,0x48,0x03,0x51,0x08,0x48,0x89,0x11,0x48,0x8b,0xc8,0x48,0xc1,0xe9,0x3b,0x83,0xc1,0x05,0x48,0x8b,0xd0,0x48,0xd3,0xea,0x48,0x33,0xc2,0x48,0xba,0xd9,0xf2,0x8e,0x10,0x02,0x75,0xf1,0xae,0x48,0x0f,0xaf,0xc2,0x48,0x8b,0xd0,0x48,0xc1,0xea,0x2b,0x48,0x33,0xc2,0xc3};

        public static ReadOnlySpan<byte> step_ᐤPcg64ᕀrefᐤ  =>  new byte[30]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x01,0x48,0xba,0x2d,0x7f,0x95,0x4c,0x2d,0xf4,0x51,0x58,0x48,0x0f,0xaf,0xd0,0x48,0x03,0x51,0x08,0x48,0x89,0x11,0xc3};

        public static ReadOnlySpan<byte> rotr_ᐤ32uㆍ32uᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x8b,0xc1,0x8b,0xca,0xd3,0xc8,0xc3};

        public static ReadOnlySpan<byte> grind32_ᐤ64uᐤ  =>  new byte[26]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0x48,0xc1,0xe8,0x12,0x48,0x33,0xc1,0x48,0xc1,0xe8,0x1b,0x48,0xc1,0xe9,0x3b,0xd3,0xc8,0xc3};

        public static ReadOnlySpan<byte> grind64_ᐤ64uᐤ  =>  new byte[52]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0x48,0x8b,0xc8,0x48,0xc1,0xe9,0x3b,0x83,0xc1,0x05,0x48,0x8b,0xd0,0x48,0xd3,0xea,0x48,0x33,0xc2,0x48,0xba,0xd9,0xf2,0x8e,0x10,0x02,0x75,0xf1,0xae,0x48,0x0f,0xaf,0xc2,0x48,0x8b,0xd0,0x48,0xc1,0xea,0x2b,0x48,0x33,0xc2,0xc3};

        public static ReadOnlySpan<byte> advance_ᐤ64uㆍ64uㆍ64uㆍ64uᐤ  =>  new byte[66]{0x0f,0x1f,0x44,0x00,0x00,0xb8,0x01,0x00,0x00,0x00,0x45,0x33,0xd2,0x48,0x85,0xd2,0x74,0x28,0x44,0x8b,0xda,0x41,0xf6,0xc3,0x01,0x74,0x0b,0x49,0x0f,0xaf,0xc0,0x4d,0x0f,0xaf,0xd0,0x4d,0x03,0xd1,0x4d,0x8d,0x58,0x01,0x4d,0x0f,0xaf,0xcb,0x4d,0x0f,0xaf,0xc0,0x48,0xd1,0xea,0x48,0x85,0xd2,0x75,0xd8,0x48,0x0f,0xaf,0xc1,0x49,0x03,0xc2,0xc3};

    }
}
