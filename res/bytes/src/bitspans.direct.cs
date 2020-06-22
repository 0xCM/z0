//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.ByteCode
{
    using System;
    using System.Runtime.CompilerServices;


    public static class bitspans_direct
    {
        public static ReadOnlySpan<byte> distribute_ᐤ8uᕀinㆍ32iㆍ32uᕀrefᐤ  =>  new byte[31]{0xc5,0xf8,0x77,0x66,0x90,0xc1,0xe2,0x03,0x48,0x63,0xc2,0x48,0x03,0xc8,0xc4,0xe2,0x7d,0x31,0x01,0x49,0x8d,0x04,0x80,0xc5,0xfe,0x7f,0x00,0xc5,0xf8,0x77,0xc3};

        public static ReadOnlySpan<byte> distribute_ᐤ8uᕀinㆍ32iㆍ32uᕀrefㆍ32iᐤ  =>  new byte[38]{0xc5,0xf8,0x77,0x66,0x90,0xc1,0xe2,0x03,0x48,0x63,0xc2,0x48,0x03,0xc1,0xc4,0xe2,0x7d,0x31,0x00,0x41,0xc1,0xe1,0x03,0x49,0x63,0xc1,0x49,0x8d,0x04,0x80,0xc5,0xfe,0x7f,0x00,0xc5,0xf8,0x77,0xc3};

        public static ReadOnlySpan<byte> extract_ᐤBitSpanᕀinㆍn8ㆍ32iᐤ  =>  new byte[164]{0x48,0x83,0xec,0x28,0xc5,0xf8,0x77,0x48,0x8b,0x01,0x8b,0x51,0x08,0x41,0x8b,0xc8,0x48,0x83,0xc1,0x08,0x8b,0xd2,0x48,0x3b,0xca,0x0f,0x87,0x80,0x00,0x00,0x00,0x49,0x63,0xd0,0x48,0x8d,0x04,0x90,0xc5,0xff,0xf0,0x00,0xc4,0xe3,0x7d,0x19,0xc1,0x00,0xc4,0xe3,0x7d,0x19,0xc0,0x01,0xc7,0x44,0x24,0x24,0xff,0xff,0x00,0x00,0x48,0x8d,0x44,0x24,0x24,0xc4,0xe2,0x79,0x58,0x54,0x24,0x24,0xc5,0xf1,0xdb,0xca,0xc5,0xf9,0xdb,0xc2,0xc4,0xe2,0x71,0x2b,0xc0,0xc5,0xf0,0x57,0xc9,0xc7,0x44,0x24,0x20,0xff,0x00,0x00,0x00,0x48,0x8d,0x44,0x24,0x20,0xc4,0xe2,0x79,0x79,0x54,0x24,0x20,0xc5,0xf9,0xdb,0xc2,0xc5,0xf1,0xdb,0xca,0xc5,0xf9,0x67,0xc1,0xb8,0x07,0x00,0x00,0x00,0xc5,0xf9,0x6e,0xc8,0xc5,0xf9,0xf3,0xc1,0xc5,0xf9,0xd7,0xc0,0x0f,0xb7,0xc0,0x0f,0xb6,0xc0,0xc5,0xf8,0x77,0x48,0x83,0xc4,0x28,0xc3,0xe8,0x11,0xb6,0x1d,0x5e,0xe8,0x84,0x8f,0x59,0xfe};

        public static ReadOnlySpan<byte> extract_ᐤBitSpanᕀinㆍn16ㆍ32iᐤ  =>  new byte[174]{0x48,0x83,0xec,0x28,0xc5,0xf8,0x77,0x48,0x8b,0x01,0x8b,0x51,0x08,0x41,0x8b,0xc8,0x48,0x83,0xc1,0x10,0x8b,0xd2,0x48,0x3b,0xca,0x0f,0x87,0x8a,0x00,0x00,0x00,0x49,0x63,0xd0,0x48,0x8d,0x04,0x90,0x48,0x8b,0xd0,0xc5,0xff,0xf0,0x02,0x48,0x83,0xc0,0x20,0xc5,0xff,0xf0,0x08,0xc7,0x44,0x24,0x24,0xff,0xff,0x00,0x00,0x48,0x8d,0x44,0x24,0x24,0xc4,0xe2,0x7d,0x58,0x54,0x24,0x24,0xc5,0xfd,0xdb,0xc2,0xc5,0xf5,0xdb,0xca,0xc4,0xe2,0x7d,0x2b,0xc1,0xc4,0xe3,0xfd,0x00,0xc0,0xd8,0xc4,0xe3,0x7d,0x19,0xc1,0x00,0xc4,0xe3,0x7d,0x19,0xc0,0x01,0xc7,0x44,0x24,0x20,0xff,0x00,0x00,0x00,0x48,0x8d,0x44,0x24,0x20,0xc4,0xe2,0x79,0x79,0x54,0x24,0x20,0xc5,0xf1,0xdb,0xca,0xc5,0xf9,0xdb,0xc2,0xc5,0xf1,0x67,0xc0,0xb8,0x07,0x00,0x00,0x00,0xc5,0xf9,0x6e,0xc8,0xc5,0xf9,0xf3,0xc1,0xc5,0xf9,0xd7,0xc0,0x0f,0xb7,0xc0,0xc5,0xf8,0x77,0x48,0x83,0xc4,0x28,0xc3,0xe8,0x37,0xb5,0x1d,0x5e,0xe8,0xaa,0x8e,0x59,0xfe};

        public static ReadOnlySpan<byte> extract_ᐤBitSpanᕀinㆍn32ㆍ32iᐤ  =>  new byte[220]{0x48,0x83,0xec,0x38,0xc5,0xf8,0x77,0x48,0x8b,0x01,0x8b,0x51,0x08,0x41,0x8b,0xc8,0x48,0x83,0xc1,0x20,0x8b,0xd2,0x48,0x3b,0xca,0x0f,0x87,0xb8,0x00,0x00,0x00,0x49,0x63,0xd0,0x48,0x8d,0x04,0x90,0x48,0x8b,0xd0,0xc5,0xff,0xf0,0x02,0x48,0x8d,0x50,0x20,0xc5,0xff,0xf0,0x0a,0xc7,0x44,0x24,0x34,0xff,0xff,0x00,0x00,0x48,0x8d,0x54,0x24,0x34,0xc4,0xe2,0x7d,0x58,0x54,0x24,0x34,0xc5,0xfd,0xdb,0xc2,0xc5,0xf5,0xdb,0xca,0xc4,0xe2,0x7d,0x2b,0xc1,0xc4,0xe3,0xfd,0x00,0xc0,0xd8,0x48,0x8d,0x50,0x40,0xc5,0xff,0xf0,0x0a,0x48,0x83,0xc0,0x60,0xc5,0xff,0xf0,0x10,0xc7,0x44,0x24,0x30,0xff,0xff,0x00,0x00,0x48,0x8d,0x44,0x24,0x30,0xc4,0xe2,0x7d,0x58,0x5c,0x24,0x30,0xc5,0xf5,0xdb,0xcb,0xc5,0xed,0xdb,0xd3,0xc4,0xe2,0x75,0x2b,0xca,0xc4,0xe3,0xfd,0x00,0xc9,0xd8,0xc7,0x44,0x24,0x2c,0xff,0x00,0x00,0x00,0x48,0x8d,0x44,0x24,0x2c,0xc4,0xe2,0x7d,0x79,0x54,0x24,0x2c,0xc5,0xfd,0xdb,0xc2,0xc5,0xf5,0xdb,0xca,0xc5,0xfd,0x67,0xc1,0xc4,0xe3,0xfd,0x00,0xc0,0xd8,0xb8,0x07,0x00,0x00,0x00,0xc5,0xf9,0x6e,0xc8,0xc5,0xfd,0xf3,0xc1,0xc5,0xfd,0xd7,0xc0,0xc5,0xf8,0x77,0x48,0x83,0xc4,0x38,0xc3,0xe8,0x39,0xb4,0x1d,0x5e,0xe8,0xac,0x8d,0x59,0xfe};

        public static ReadOnlySpan<byte> extract_ᐤBitSpanᕀinㆍn64ㆍ32iᐤ  =>  new byte[410]{0x48,0x83,0xec,0x38,0xc5,0xf8,0x77,0x48,0x8b,0x01,0x8b,0x51,0x08,0x41,0x8b,0xc8,0x48,0x83,0xc1,0x40,0x8b,0xd2,0x48,0x3b,0xca,0x0f,0x87,0x76,0x01,0x00,0x00,0x49,0x63,0xd0,0x48,0x8d,0x04,0x90,0x48,0x8b,0xd0,0xc5,0xff,0xf0,0x02,0x48,0x8d,0x50,0x20,0xc5,0xff,0xf0,0x0a,0xc7,0x44,0x24,0x34,0xff,0xff,0x00,0x00,0x48,0x8d,0x54,0x24,0x34,0xc4,0xe2,0x7d,0x58,0x54,0x24,0x34,0xc5,0xfd,0xdb,0xc2,0xc5,0xf5,0xdb,0xca,0xc4,0xe2,0x7d,0x2b,0xc1,0xc4,0xe3,0xfd,0x00,0xc0,0xd8,0x48,0x8d,0x50,0x40,0xc5,0xff,0xf0,0x0a,0x48,0x8d,0x50,0x60,0xc5,0xff,0xf0,0x12,0xc7,0x44,0x24,0x30,0xff,0xff,0x00,0x00,0x48,0x8d,0x54,0x24,0x30,0xc4,0xe2,0x7d,0x58,0x5c,0x24,0x30,0xc5,0xf5,0xdb,0xcb,0xc5,0xed,0xdb,0xd3,0xc4,0xe2,0x75,0x2b,0xca,0xc4,0xe3,0xfd,0x00,0xc9,0xd8,0xc7,0x44,0x24,0x2c,0xff,0x00,0x00,0x00,0x48,0x8d,0x54,0x24,0x2c,0xc4,0xe2,0x7d,0x79,0x54,0x24,0x2c,0xc5,0xfd,0xdb,0xc2,0xc5,0xf5,0xdb,0xca,0xc5,0xfd,0x67,0xc1,0xc4,0xe3,0xfd,0x00,0xc0,0xd8,0xba,0x07,0x00,0x00,0x00,0xc5,0xf9,0x6e,0xca,0xc5,0xfd,0xf3,0xc1,0xc5,0xfd,0xd7,0xd0,0x8b,0xd2,0x48,0x8d,0x88,0x80,0x00,0x00,0x00,0xc5,0xff,0xf0,0x09,0x48,0x8d,0x88,0xa0,0x00,0x00,0x00,0xc5,0xff,0xf0,0x11,0xc7,0x44,0x24,0x28,0xff,0xff,0x00,0x00,0x48,0x8d,0x4c,0x24,0x28,0xc4,0xe2,0x7d,0x58,0x44,0x24,0x28,0xc5,0xf5,0xdb,0xc8,0xc5,0xed,0xdb,0xc0,0xc4,0xe2,0x75,0x2b,0xc0,0xc4,0xe3,0xfd,0x00,0xc0,0xd8,0x48,0x8d,0x88,0xc0,0x00,0x00,0x00,0xc5,0xff,0xf0,0x09,0x48,0x05,0xe0,0x00,0x00,0x00,0xc5,0xff,0xf0,0x10,0xc7,0x44,0x24,0x24,0xff,0xff,0x00,0x00,0x48,0x8d,0x44,0x24,0x24,0xc4,0xe2,0x7d,0x58,0x5c,0x24,0x24,0xc5,0xf5,0xdb,0xcb,0xc5,0xed,0xdb,0xd3,0xc4,0xe2,0x75,0x2b,0xca,0xc4,0xe3,0xfd,0x00,0xc9,0xd8,0xc7,0x44,0x24,0x20,0xff,0x00,0x00,0x00,0x48,0x8d,0x44,0x24,0x20,0xc4,0xe2,0x7d,0x79,0x54,0x24,0x20,0xc5,0xfd,0xdb,0xc2,0xc5,0xf5,0xdb,0xca,0xc5,0xfd,0x67,0xc1,0xc4,0xe3,0xfd,0x00,0xc0,0xd8,0xb8,0x07,0x00,0x00,0x00,0xc5,0xf9,0x6e,0xc8,0xc5,0xfd,0xf3,0xc1,0xc5,0xfd,0xd7,0xc0,0x8b,0xc0,0x48,0xc1,0xe0,0x20,0x48,0x0b,0xd0,0x48,0x8b,0xc2,0xc5,0xf8,0x77,0x48,0x83,0xc4,0x38,0xc3,0xe8,0x7b,0xb2,0x1d,0x5e,0xe8,0xee,0x8b,0x59,0xfe};

        public static ReadOnlySpan<byte> extract_ᐤBitSpanᕀinㆍ32iㆍ32iᐤ  =>  new byte[145]{0x48,0x83,0xec,0x28,0x90,0x48,0x8b,0x02,0x8b,0x52,0x08,0x45,0x8b,0xd0,0x45,0x8b,0xd9,0x4d,0x03,0xd3,0x8b,0xd2,0x4c,0x3b,0xd2,0x77,0x1b,0x49,0x63,0xd0,0x48,0x8d,0x04,0x90,0x48,0x89,0x01,0x44,0x89,0x49,0x08,0x48,0x8b,0xc1,0x48,0x83,0xc4,0x28,0xc3,0xe8,0x0a,0xb2,0x1d,0x5e,0xe8,0x7d,0x8b,0x59,0xfe,0xcc,0x19,0x04,0x01,0x00,0x04,0x42,0x00,0x00,0x40,0x00,0x00,0x00,0xf8,0x5e,0x8b,0xaf,0xf9,0x7f,0x00,0x00,0x50,0xc5,0xf8,0x77,0x33,0xc0,0x48,0x89,0x04,0x24,0x33,0xc0,0x48,0x89,0x04,0x24,0x48,0x8d,0x04,0x24,0x4c,0x8b,0x02,0x0f,0xb6,0xc9,0x49,0xb9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xc4,0xc2,0xf3,0xf5,0xc9,0x48,0x89,0x08,0xc4,0xe2,0x7d,0x31,0x00,0xc4,0xc1,0x7e,0x7f,0x00,0x48,0x8b,0xc2,0xc5,0xf8,0x77,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> fill_ᐤ8uㆍBitSpanᕀinᐤ  =>  new byte[65]{0x50,0xc5,0xf8,0x77,0x33,0xc0,0x48,0x89,0x04,0x24,0x33,0xc0,0x48,0x89,0x04,0x24,0x48,0x8d,0x04,0x24,0x4c,0x8b,0x02,0x0f,0xb6,0xc9,0x49,0xb9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xc4,0xc2,0xf3,0xf5,0xc9,0x48,0x89,0x08,0xc4,0xe2,0x7d,0x31,0x00,0xc4,0xc1,0x7e,0x7f,0x00,0x48,0x8b,0xc2,0xc5,0xf8,0x77,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> fill_ᐤ16uㆍBitSpanᕀinᐤ  =>  new byte[130]{0x48,0x83,0xec,0x18,0xc5,0xf8,0x77,0x33,0xc0,0x48,0x89,0x44,0x24,0x08,0x48,0x89,0x44,0x24,0x10,0x33,0xc0,0x48,0x89,0x44,0x24,0x08,0x48,0x89,0x44,0x24,0x10,0x48,0x8d,0x44,0x24,0x08,0x4c,0x8b,0x02,0x44,0x0f,0xb7,0xc9,0x45,0x0f,0xb6,0xc9,0x49,0xba,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xc4,0x42,0xb3,0xf5,0xca,0x4c,0x89,0x08,0x4c,0x8d,0x48,0x08,0x0f,0xb7,0xc9,0xc1,0xf9,0x08,0x0f,0xb6,0xc9,0xc4,0xc2,0xf3,0xf5,0xca,0x49,0x89,0x09,0x48,0x8b,0xc8,0xc4,0xe2,0x7d,0x31,0x01,0x49,0x8b,0xc8,0xc5,0xfe,0x7f,0x01,0x48,0x83,0xc0,0x08,0xc4,0xe2,0x7d,0x31,0x00,0x49,0x83,0xc0,0x20,0xc4,0xc1,0x7e,0x7f,0x00,0x48,0x8b,0xc2,0xc5,0xf8,0x77,0x48,0x83,0xc4,0x18,0xc3};

        public static ReadOnlySpan<byte> fill_ᐤ32uㆍBitSpanᕀinᐤ  =>  new byte[216]{0x56,0x48,0x83,0xec,0x20,0xc5,0xf8,0x77,0x48,0x8b,0x02,0x44,0x8b,0x42,0x08,0x49,0x83,0xf8,0x20,0x0f,0x82,0xba,0x00,0x00,0x00,0x48,0x83,0xc0,0x60,0x4c,0x8b,0xc0,0x4c,0x8b,0x0a,0x44,0x0f,0xb6,0xd1,0x49,0xbb,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xc4,0x42,0xab,0xf5,0xd3,0x4d,0x89,0x10,0x4d,0x8d,0x50,0x08,0x44,0x8b,0xd9,0x41,0xc1,0xeb,0x08,0x45,0x0f,0xb6,0xdb,0x48,0xbe,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xc4,0x62,0xa3,0xf5,0xde,0x4d,0x89,0x1a,0x4d,0x8d,0x50,0x10,0x44,0x8b,0xd9,0x41,0xc1,0xeb,0x10,0x45,0x0f,0xb6,0xdb,0xc4,0x62,0xa3,0xf5,0xde,0x4d,0x89,0x1a,0x4d,0x8d,0x50,0x18,0xc1,0xe9,0x18,0x0f,0xb6,0xc9,0xc4,0xe2,0xf3,0xf5,0xce,0x49,0x89,0x0a,0x49,0x8b,0xc8,0xc4,0xe2,0x7d,0x31,0x01,0x49,0x8b,0xc9,0xc5,0xfe,0x7f,0x01,0x49,0x8d,0x48,0x08,0xc4,0xe2,0x7d,0x31,0x01,0x49,0x8d,0x49,0x20,0xc5,0xfe,0x7f,0x01,0x49,0x8d,0x48,0x10,0xc4,0xe2,0x7d,0x31,0x01,0x49,0x83,0xc1,0x40,0xc4,0xc1,0x7e,0x7f,0x01,0x49,0x83,0xc0,0x18,0xc4,0xc2,0x7d,0x31,0x00,0xc5,0xfe,0x7f,0x00,0x48,0x8b,0xc2,0xc5,0xf8,0x77,0x48,0x83,0xc4,0x20,0x5e,0xc3,0xe8,0x1d,0xb0,0x1d,0x5e,0xe8,0x90,0x89,0x59,0xfe};

        public static ReadOnlySpan<byte> fill_ᐤ64uㆍBitSpanᕀinᐤ  =>  new byte[378]{0x57,0x56,0x55,0x53,0x48,0x83,0xec,0x28,0xc5,0xf8,0x77,0x48,0x8b,0x02,0x44,0x8b,0x42,0x08,0x49,0x83,0xf8,0x40,0x0f,0x82,0x59,0x01,0x00,0x00,0x48,0x05,0xe0,0x00,0x00,0x00,0x4c,0x8b,0xc0,0x4c,0x8b,0x0a,0x44,0x8b,0xd1,0x45,0x0f,0xb6,0xda,0x48,0xbe,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xc4,0x62,0xa3,0xf5,0xde,0x4d,0x89,0x18,0x4d,0x8d,0x58,0x08,0x49,0x8b,0xf3,0x41,0x8b,0xfa,0xc1,0xef,0x08,0x40,0x0f,0xb6,0xff,0x48,0xbb,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xc4,0xe2,0xc3,0xf5,0xfb,0x48,0x89,0x3e,0x49,0x8d,0x70,0x10,0x48,0x8b,0xfe,0x41,0x8b,0xda,0xc1,0xeb,0x10,0x0f,0xb6,0xdb,0x48,0xbd,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xc4,0xe2,0xe3,0xf5,0xdd,0x48,0x89,0x1f,0x49,0x8d,0x78,0x18,0x48,0x8b,0xdf,0x41,0xc1,0xea,0x18,0x45,0x0f,0xb6,0xd2,0xc4,0x62,0xab,0xf5,0xd5,0x4c,0x89,0x13,0x4d,0x8b,0xd0,0xc4,0xc2,0x7d,0x31,0x02,0x4d,0x8b,0xd1,0xc4,0xc1,0x7e,0x7f,0x02,0x4d,0x8b,0xd3,0xc4,0xc2,0x7d,0x31,0x02,0x4d,0x8d,0x51,0x20,0xc4,0xc1,0x7e,0x7f,0x02,0x4c,0x8b,0xd6,0xc4,0xc2,0x7d,0x31,0x02,0x4d,0x8d,0x51,0x40,0xc4,0xc1,0x7e,0x7f,0x02,0x4c,0x8b,0xd7,0xc4,0xc2,0x7d,0x31,0x02,0x4d,0x8d,0x51,0x60,0xc4,0xc1,0x7e,0x7f,0x02,0x48,0xc1,0xe9,0x20,0x44,0x0f,0xb6,0xd1,0xc4,0x62,0xab,0xf5,0xd5,0x4d,0x89,0x10,0x4d,0x8b,0xd3,0x8b,0xd9,0xc1,0xeb,0x08,0x0f,0xb6,0xdb,0xc4,0xe2,0xe3,0xf5,0xdd,0x49,0x89,0x1a,0x4c,0x8b,0xd6,0x8b,0xd9,0xc1,0xeb,0x10,0x0f,0xb6,0xdb,0xc4,0xe2,0xe3,0xf5,0xdd,0x49,0x89,0x1a,0x4c,0x8b,0xd7,0xc1,0xe9,0x18,0x0f,0xb6,0xc9,0xc4,0xe2,0xf3,0xf5,0xcd,0x49,0x89,0x0a,0xc4,0xc2,0x7d,0x31,0x00,0x49,0x8d,0x89,0x80,0x00,0x00,0x00,0xc5,0xfe,0x7f,0x01,0xc4,0xc2,0x7d,0x31,0x03,0x49,0x8d,0x89,0xa0,0x00,0x00,0x00,0xc5,0xfe,0x7f,0x01,0xc4,0xe2,0x7d,0x31,0x06,0x49,0x81,0xc1,0xc0,0x00,0x00,0x00,0xc4,0xc1,0x7e,0x7f,0x01,0xc4,0xe2,0x7d,0x31,0x07,0xc5,0xfe,0x7f,0x00,0x48,0x8b,0xc2,0xc5,0xf8,0x77,0x48,0x83,0xc4,0x28,0x5b,0x5d,0x5e,0x5f,0xc3,0xe8,0x8b,0xae,0x1d,0x5e,0xe8,0xfe,0x87,0x59,0xfe};

        public static ReadOnlySpan<byte> from_ᐤ8uᐤ  =>  new byte[166]{0x57,0x56,0x53,0x48,0x83,0xec,0x60,0xc5,0xf8,0x77,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x28,0xb9,0x0e,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x8b,0xd9,0x33,0xc0,0x48,0x89,0x44,0x24,0x58,0x48,0x8d,0x44,0x24,0x58,0x48,0x8d,0x4c,0x24,0x38,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0xc5,0xfa,0x7f,0x41,0x10,0x48,0x8d,0x4c,0x24,0x38,0x0f,0xb6,0xd2,0x49,0xb8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xc4,0xc2,0xeb,0xf5,0xd0,0x48,0x89,0x10,0xc4,0xe2,0x7d,0x31,0x00,0xc5,0xfe,0x7f,0x01,0x48,0x8d,0x44,0x24,0x38,0xba,0x08,0x00,0x00,0x00,0x48,0x8d,0x4c,0x24,0x28,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0x48,0x8d,0x4c,0x24,0x28,0x48,0x89,0x01,0x89,0x51,0x08,0x48,0x8b,0xfb,0x48,0x8d,0x74,0x24,0x28,0xe8,0x6f,0x1c,0x0b,0x5e,0x48,0xa5,0x48,0x8b,0xc3,0xc5,0xf8,0x77,0x48,0x83,0xc4,0x60,0x5b,0x5e,0x5f,0xc3,0xe8,0xba,0xad,0x1d,0x5e};

        public static ReadOnlySpan<byte> from_ᐤ16uᐤ  =>  new byte[236]{0x57,0x56,0x53,0x48,0x81,0xec,0x80,0x00,0x00,0x00,0xc5,0xf8,0x77,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x20,0xb9,0x18,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x8b,0xd9,0x33,0xc0,0x48,0x89,0x44,0x24,0x70,0x48,0x89,0x44,0x24,0x78,0x48,0x8d,0x44,0x24,0x70,0x48,0x8d,0x4c,0x24,0x30,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0xc5,0xfa,0x7f,0x41,0x10,0xc5,0xfa,0x7f,0x41,0x20,0xc5,0xfa,0x7f,0x41,0x30,0x48,0x8d,0x4c,0x24,0x30,0x44,0x0f,0xb7,0xc2,0x45,0x0f,0xb6,0xc0,0x49,0xb9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xc4,0x42,0xbb,0xf5,0xc1,0x4c,0x89,0x00,0x4c,0x8d,0x40,0x08,0x0f,0xb7,0xd2,0xc1,0xfa,0x08,0x0f,0xb6,0xd2,0xc4,0xc2,0xeb,0xf5,0xd1,0x49,0x89,0x10,0x48,0x8b,0xd0,0xc4,0xe2,0x7d,0x31,0x02,0x48,0x8b,0xd1,0xc5,0xfe,0x7f,0x02,0x48,0x83,0xc0,0x08,0xc4,0xe2,0x7d,0x31,0x00,0x48,0x83,0xc1,0x20,0xc5,0xfe,0x7f,0x01,0x48,0x8d,0x44,0x24,0x30,0xba,0x10,0x00,0x00,0x00,0x48,0x8d,0x4c,0x24,0x20,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0x48,0x8d,0x4c,0x24,0x20,0x48,0x89,0x01,0x89,0x51,0x08,0x48,0x8b,0xfb,0x48,0x8d,0x74,0x24,0x20,0xe8,0x5c,0x1b,0x0b,0x5e,0x48,0xa5,0x48,0x8b,0xc3,0xc5,0xf8,0x77,0x48,0x81,0xc4,0x80,0x00,0x00,0x00,0x5b,0x5e,0x5f,0xc3,0xe8,0xa4,0xac,0x1d,0x5e};

        public static ReadOnlySpan<byte> from_ᐤ32uᐤ  =>  new byte[351]{0x57,0x56,0x53,0x48,0x81,0xec,0xd0,0x00,0x00,0x00,0xc5,0xf8,0x77,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x20,0xb9,0x2c,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x8b,0xd9,0x48,0x8d,0x84,0x24,0xb0,0x00,0x00,0x00,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x00,0xc5,0xfa,0x7f,0x40,0x10,0x48,0x8d,0x84,0x24,0xb0,0x00,0x00,0x00,0x48,0x8d,0x4c,0x24,0x30,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0xc5,0xfa,0x7f,0x41,0x10,0xc5,0xfa,0x7f,0x41,0x20,0xc5,0xfa,0x7f,0x41,0x30,0xc5,0xfa,0x7f,0x41,0x40,0xc5,0xfa,0x7f,0x41,0x50,0xc5,0xfa,0x7f,0x41,0x60,0xc5,0xfa,0x7f,0x41,0x70,0x48,0x8d,0x4c,0x24,0x30,0x44,0x0f,0xb6,0xc2,0x49,0xb9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xc4,0x42,0xbb,0xf5,0xc1,0x4c,0x89,0x00,0x4c,0x8d,0x40,0x08,0x44,0x8b,0xca,0x41,0xc1,0xe9,0x08,0x45,0x0f,0xb6,0xc9,0x49,0xba,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xc4,0x42,0xb3,0xf5,0xca,0x4d,0x89,0x08,0x4c,0x8d,0x40,0x10,0x44,0x8b,0xca,0x41,0xc1,0xe9,0x10,0x45,0x0f,0xb6,0xc9,0xc4,0x42,0xb3,0xf5,0xca,0x4d,0x89,0x08,0x4c,0x8d,0x40,0x18,0xc1,0xea,0x18,0x0f,0xb6,0xd2,0xc4,0xc2,0xeb,0xf5,0xd2,0x49,0x89,0x10,0x48,0x8b,0xd0,0xc4,0xe2,0x7d,0x31,0x02,0x48,0x8b,0xd1,0xc5,0xfe,0x7f,0x02,0x48,0x8d,0x50,0x08,0xc4,0xe2,0x7d,0x31,0x02,0x48,0x8d,0x51,0x20,0xc5,0xfe,0x7f,0x02,0x48,0x8d,0x50,0x10,0xc4,0xe2,0x7d,0x31,0x02,0x48,0x8d,0x51,0x40,0xc5,0xfe,0x7f,0x02,0x48,0x83,0xc0,0x18,0xc4,0xe2,0x7d,0x31,0x00,0x48,0x83,0xc1,0x60,0xc5,0xfe,0x7f,0x01,0x48,0x8d,0x44,0x24,0x30,0xba,0x20,0x00,0x00,0x00,0x48,0x8d,0x4c,0x24,0x20,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0x48,0x8d,0x4c,0x24,0x20,0x48,0x89,0x01,0x89,0x51,0x08,0x48,0x8b,0xfb,0x48,0x8d,0x74,0x24,0x20,0xe8,0xd9,0x19,0x0b,0x5e,0x48,0xa5,0x48,0x8b,0xc3,0xc5,0xf8,0x77,0x48,0x81,0xc4,0xd0,0x00,0x00,0x00,0x5b,0x5e,0x5f,0xc3,0xe8,0x21,0xab,0x1d,0x5e};

        public static ReadOnlySpan<byte> from_ᐤ64uᐤ  =>  new byte[496]{0x57,0x56,0x53,0x48,0x83,0xec,0x70,0xc5,0xf8,0x77,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x20,0xb9,0x14,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x8b,0xd9,0x48,0x8b,0xf2,0x48,0x8d,0x4c,0x24,0x30,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0xc5,0xfa,0x7f,0x41,0x10,0xc5,0xfa,0x7f,0x41,0x20,0xc5,0xfa,0x7f,0x41,0x30,0x48,0x8d,0x7c,0x24,0x30,0x48,0xb9,0x30,0xaf,0xe8,0xad,0xf9,0x7f,0x00,0x00,0xba,0x40,0x00,0x00,0x00,0xe8,0x87,0x28,0x0b,0x5e,0x48,0x83,0xc0,0x10,0xba,0x40,0x00,0x00,0x00,0x8b,0xce,0x44,0x0f,0xb6,0xc1,0x49,0xb9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xc4,0x42,0xbb,0xf5,0xc1,0x4c,0x89,0x07,0x4c,0x8d,0x47,0x08,0x44,0x8b,0xc9,0x41,0xc1,0xe9,0x08,0x45,0x0f,0xb6,0xc9,0x49,0xba,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xc4,0x42,0xb3,0xf5,0xca,0x4d,0x89,0x08,0x4c,0x8d,0x47,0x10,0x44,0x8b,0xc9,0x41,0xc1,0xe9,0x10,0x45,0x0f,0xb6,0xc9,0xc4,0x42,0xb3,0xf5,0xca,0x4d,0x89,0x08,0x4c,0x8d,0x47,0x18,0xc1,0xe9,0x18,0x0f,0xb6,0xc9,0xc4,0xc2,0xf3,0xf5,0xca,0x49,0x89,0x08,0x48,0xc1,0xee,0x20,0x8b,0xce,0x4c,0x8d,0x47,0x20,0x44,0x0f,0xb6,0xc9,0xc4,0x42,0xb3,0xf5,0xca,0x4d,0x89,0x08,0x4d,0x8d,0x48,0x08,0x44,0x8b,0xd1,0x41,0xc1,0xea,0x08,0x45,0x0f,0xb6,0xd2,0x49,0xbb,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xc4,0x42,0xab,0xf5,0xd3,0x4d,0x89,0x11,0x4d,0x8d,0x48,0x10,0x44,0x8b,0xd1,0x41,0xc1,0xea,0x10,0x45,0x0f,0xb6,0xd2,0xc4,0x42,0xab,0xf5,0xd3,0x4d,0x89,0x11,0x49,0x83,0xc0,0x18,0xc1,0xe9,0x18,0x0f,0xb6,0xc9,0xc4,0xc2,0xf3,0xf5,0xcb,0x49,0x89,0x08,0x48,0x8b,0xcf,0xc4,0xe2,0x7d,0x31,0x01,0x48,0x8b,0xc8,0xc5,0xfe,0x7f,0x01,0x48,0x8d,0x4f,0x08,0xc4,0xe2,0x7d,0x31,0x01,0x48,0x8d,0x48,0x20,0xc5,0xfe,0x7f,0x01,0x48,0x8d,0x4f,0x10,0xc4,0xe2,0x7d,0x31,0x01,0x48,0x8d,0x48,0x40,0xc5,0xfe,0x7f,0x01,0x48,0x8d,0x4f,0x18,0xc4,0xe2,0x7d,0x31,0x01,0x48,0x8d,0x48,0x60,0xc5,0xfe,0x7f,0x01,0x48,0x8d,0x4f,0x20,0xc4,0xe2,0x7d,0x31,0x01,0x48,0x8d,0x88,0x80,0x00,0x00,0x00,0xc5,0xfe,0x7f,0x01,0x48,0x8d,0x4f,0x28,0xc4,0xe2,0x7d,0x31,0x01,0x48,0x8d,0x88,0xa0,0x00,0x00,0x00,0xc5,0xfe,0x7f,0x01,0x48,0x8d,0x4f,0x30,0xc4,0xe2,0x7d,0x31,0x01,0x48,0x8d,0x88,0xc0,0x00,0x00,0x00,0xc5,0xfe,0x7f,0x01,0x48,0x83,0xc7,0x38,0xc4,0xe2,0x7d,0x31,0x07,0x48,0x8d,0x88,0xe0,0x00,0x00,0x00,0xc5,0xfe,0x7f,0x01,0x48,0x8d,0x4c,0x24,0x20,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0x48,0x8d,0x4c,0x24,0x20,0x48,0x89,0x01,0x89,0x51,0x08,0x48,0x8b,0xfb,0x48,0x8d,0x74,0x24,0x20,0xe8,0xb5,0x17,0x0b,0x5e,0x48,0xa5,0x48,0x8b,0xc3,0xc5,0xf8,0x77,0x48,0x83,0xc4,0x70,0x5b,0x5e,0x5f,0xc3,0xe8,0x00,0xa9,0x1d,0x5e};

        public static ReadOnlySpan<byte> slice_ᐤBitSpanᕀinㆍW8ㆍ32iㆍ32iᐤ  =>  new byte[203]{0x57,0x56,0x48,0x83,0xec,0x38,0xc5,0xf8,0x77,0x33,0xc0,0x48,0x89,0x44,0x24,0x30,0x33,0xd2,0x48,0x89,0x54,0x24,0x30,0x48,0x8d,0x74,0x24,0x30,0xbf,0x02,0x00,0x00,0x00,0x48,0x8d,0x44,0x24,0x30,0x48,0x8b,0x11,0x49,0x63,0xc8,0x48,0x8d,0x14,0x8a,0x45,0x8b,0xc1,0x41,0xc1,0xe0,0x02,0x48,0x8b,0xc8,0xe8,0xf1,0x18,0x0b,0x5e,0x8b,0xc7,0x48,0x83,0xf8,0x08,0x0f,0x82,0x7b,0x00,0x00,0x00,0xc5,0xff,0xf0,0x06,0xc4,0xe3,0x7d,0x19,0xc1,0x00,0xc4,0xe3,0x7d,0x19,0xc0,0x01,0xc7,0x44,0x24,0x2c,0xff,0xff,0x00,0x00,0x48,0x8d,0x44,0x24,0x2c,0xc4,0xe2,0x79,0x58,0x54,0x24,0x2c,0xc5,0xf1,0xdb,0xca,0xc5,0xf9,0xdb,0xc2,0xc4,0xe2,0x71,0x2b,0xc0,0xc5,0xf0,0x57,0xc9,0xc7,0x44,0x24,0x28,0xff,0x00,0x00,0x00,0x48,0x8d,0x44,0x24,0x28,0xc4,0xe2,0x79,0x79,0x54,0x24,0x28,0xc5,0xf9,0xdb,0xc2,0xc5,0xf1,0xdb,0xca,0xc5,0xf9,0x67,0xc1,0xb8,0x07,0x00,0x00,0x00,0xc5,0xf9,0x6e,0xc8,0xc5,0xf9,0xf3,0xc1,0xc5,0xf9,0xd7,0xc0,0x0f,0xb7,0xc0,0x0f,0xb6,0xc0,0xc5,0xf8,0x77,0x48,0x83,0xc4,0x38,0x5e,0x5f,0xc3,0xe8,0x0a,0xa8,0x1d,0x5e,0xe8,0x7d,0x81,0x59,0xfe};

        public static ReadOnlySpan<byte> slice_ᐤBitSpanᕀinㆍW16ㆍ32iㆍ32iᐤ  =>  new byte[223]{0x57,0x56,0x48,0x83,0xec,0x38,0xc5,0xf8,0x77,0x33,0xc0,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x30,0x33,0xd2,0x48,0x89,0x54,0x24,0x28,0x48,0x89,0x54,0x24,0x30,0x48,0x8d,0x74,0x24,0x28,0xbf,0x04,0x00,0x00,0x00,0x48,0x8d,0x44,0x24,0x28,0x48,0x8b,0x11,0x49,0x63,0xc8,0x48,0x8d,0x14,0x8a,0x45,0x8b,0xc1,0x41,0xc1,0xe0,0x02,0x48,0x8b,0xc8,0xe8,0xf7,0x17,0x0b,0x5e,0x8b,0xc7,0x48,0x83,0xf8,0x10,0x0f,0x82,0x85,0x00,0x00,0x00,0x48,0x8b,0xc6,0xc5,0xff,0xf0,0x00,0x48,0x83,0xc6,0x20,0xc5,0xff,0xf0,0x0e,0xc7,0x44,0x24,0x24,0xff,0xff,0x00,0x00,0x48,0x8d,0x44,0x24,0x24,0xc4,0xe2,0x7d,0x58,0x54,0x24,0x24,0xc5,0xfd,0xdb,0xc2,0xc5,0xf5,0xdb,0xca,0xc4,0xe2,0x7d,0x2b,0xc1,0xc4,0xe3,0xfd,0x00,0xc0,0xd8,0xc4,0xe3,0x7d,0x19,0xc1,0x00,0xc4,0xe3,0x7d,0x19,0xc0,0x01,0xc7,0x44,0x24,0x20,0xff,0x00,0x00,0x00,0x48,0x8d,0x44,0x24,0x20,0xc4,0xe2,0x79,0x79,0x54,0x24,0x20,0xc5,0xf1,0xdb,0xca,0xc5,0xf9,0xdb,0xc2,0xc5,0xf1,0x67,0xc0,0xb8,0x07,0x00,0x00,0x00,0xc5,0xf9,0x6e,0xc8,0xc5,0xf9,0xf3,0xc1,0xc5,0xf9,0xd7,0xc0,0x0f,0xb7,0xc0,0xc5,0xf8,0x77,0x48,0x83,0xc4,0x38,0x5e,0x5f,0xc3,0xe8,0x06,0xa7,0x1d,0x5e,0xe8,0x79,0x80,0x59,0xfe};

        public static ReadOnlySpan<byte> slice_ᐤBitSpanᕀinㆍW32ㆍ32iㆍ32iᐤ  =>  new byte[345]{0x57,0x56,0x48,0x83,0xec,0x58,0xc5,0xf8,0x77,0x33,0xc0,0x48,0x89,0x44,0x24,0x38,0x48,0x89,0x44,0x24,0x40,0x48,0x89,0x44,0x24,0x48,0x48,0x89,0x44,0x24,0x50,0x48,0x8d,0x54,0x24,0x38,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x02,0xc5,0xfa,0x7f,0x42,0x10,0x48,0x8d,0x74,0x24,0x38,0xbf,0x08,0x00,0x00,0x00,0x48,0x8b,0x11,0x8b,0x51,0x08,0x41,0x2b,0xd0,0x41,0x3b,0xd1,0x7c,0x02,0xeb,0x03,0x44,0x8b,0xca,0x48,0x8b,0x11,0x8b,0x49,0x08,0x41,0x8b,0xc0,0x45,0x8b,0xd1,0x49,0x03,0xc2,0x8b,0xc9,0x48,0x3b,0xc1,0x0f,0x87,0xe0,0x00,0x00,0x00,0x4d,0x63,0xc0,0x4a,0x8d,0x14,0x82,0x41,0x8b,0xc9,0x3b,0xcf,0x0f,0x87,0xd4,0x00,0x00,0x00,0x4c,0x63,0xc1,0x49,0xc1,0xe0,0x02,0x48,0x8b,0xce,0xe8,0x17,0x3d,0x67,0x5d,0x8b,0xc7,0x48,0x83,0xf8,0x20,0x0f,0x82,0xbf,0x00,0x00,0x00,0x48,0x8b,0xc6,0xc5,0xff,0xf0,0x00,0x48,0x8d,0x46,0x20,0xc5,0xff,0xf0,0x08,0xc7,0x44,0x24,0x34,0xff,0xff,0x00,0x00,0x48,0x8d,0x44,0x24,0x34,0xc4,0xe2,0x7d,0x58,0x54,0x24,0x34,0xc5,0xfd,0xdb,0xc2,0xc5,0xf5,0xdb,0xca,0xc4,0xe2,0x7d,0x2b,0xc1,0xc4,0xe3,0xfd,0x00,0xc0,0xd8,0x48,0x8d,0x46,0x40,0xc5,0xff,0xf0,0x08,0x48,0x83,0xc6,0x60,0xc5,0xff,0xf0,0x16,0xc7,0x44,0x24,0x30,0xff,0xff,0x00,0x00,0x48,0x8d,0x44,0x24,0x30,0xc4,0xe2,0x7d,0x58,0x5c,0x24,0x30,0xc5,0xf5,0xdb,0xcb,0xc5,0xed,0xdb,0xd3,0xc4,0xe2,0x75,0x2b,0xca,0xc4,0xe3,0xfd,0x00,0xc9,0xd8,0xc7,0x44,0x24,0x2c,0xff,0x00,0x00,0x00,0x48,0x8d,0x44,0x24,0x2c,0xc4,0xe2,0x7d,0x79,0x54,0x24,0x2c,0xc5,0xfd,0xdb,0xc2,0xc5,0xf5,0xdb,0xca,0xc5,0xfd,0x67,0xc1,0xc4,0xe3,0xfd,0x00,0xc0,0xd8,0xb8,0x07,0x00,0x00,0x00,0xc5,0xf9,0x6e,0xc8,0xc5,0xfd,0xf3,0xc1,0xc5,0xfd,0xd7,0xc0,0xc5,0xf8,0x77,0x48,0x83,0xc4,0x58,0x5e,0x5f,0xc3,0xe8,0x88,0xa5,0x1d,0x5e,0xe8,0xfb,0x7e,0x59,0xfe,0xcc,0xe8,0xfd,0x7e,0x59,0xfe,0xcc,0xe8,0xef,0x7e,0x59,0xfe};

        public static ReadOnlySpan<byte> slice_ᐤBitSpanᕀinㆍW64ㆍ32iㆍ32iᐤ  =>  new byte[481]{0x57,0x56,0x48,0x83,0xec,0x78,0xc5,0xf8,0x77,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x38,0xb9,0x10,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x8d,0x54,0x24,0x38,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x02,0xc5,0xfa,0x7f,0x42,0x10,0xc5,0xfa,0x7f,0x42,0x20,0xc5,0xfa,0x7f,0x42,0x30,0x48,0x8d,0x74,0x24,0x38,0xbf,0x10,0x00,0x00,0x00,0x48,0x8d,0x44,0x24,0x38,0x48,0x8b,0x11,0x49,0x63,0xc8,0x48,0x8d,0x14,0x8a,0x45,0x8b,0xc1,0x41,0xc1,0xe0,0x02,0x48,0x8b,0xc8,0xe8,0x3f,0x15,0x0b,0x5e,0x8b,0xc7,0x48,0x83,0xf8,0x40,0x0f,0x82,0x6f,0x01,0x00,0x00,0x48,0x8b,0xc6,0xc5,0xff,0xf0,0x00,0x48,0x8d,0x46,0x20,0xc5,0xff,0xf0,0x08,0xc7,0x44,0x24,0x34,0xff,0xff,0x00,0x00,0x48,0x8d,0x44,0x24,0x34,0xc4,0xe2,0x7d,0x58,0x54,0x24,0x34,0xc5,0xfd,0xdb,0xc2,0xc5,0xf5,0xdb,0xca,0xc4,0xe2,0x7d,0x2b,0xc1,0xc4,0xe3,0xfd,0x00,0xc0,0xd8,0x48,0x8d,0x46,0x40,0xc5,0xff,0xf0,0x08,0x48,0x8d,0x46,0x60,0xc5,0xff,0xf0,0x10,0xc7,0x44,0x24,0x30,0xff,0xff,0x00,0x00,0x48,0x8d,0x44,0x24,0x30,0xc4,0xe2,0x7d,0x58,0x5c,0x24,0x30,0xc5,0xf5,0xdb,0xcb,0xc5,0xed,0xdb,0xd3,0xc4,0xe2,0x75,0x2b,0xca,0xc4,0xe3,0xfd,0x00,0xc9,0xd8,0xc7,0x44,0x24,0x2c,0xff,0x00,0x00,0x00,0x48,0x8d,0x44,0x24,0x2c,0xc4,0xe2,0x7d,0x79,0x54,0x24,0x2c,0xc5,0xfd,0xdb,0xc2,0xc5,0xf5,0xdb,0xca,0xc5,0xfd,0x67,0xc1,0xc4,0xe3,0xfd,0x00,0xc0,0xd8,0xb8,0x07,0x00,0x00,0x00,0xc5,0xf9,0x6e,0xc8,0xc5,0xfd,0xf3,0xc1,0xc5,0xfd,0xd7,0xc0,0x8b,0xc0,0x48,0x8d,0x96,0x80,0x00,0x00,0x00,0xc5,0xff,0xf0,0x0a,0x48,0x8d,0x96,0xa0,0x00,0x00,0x00,0xc5,0xff,0xf0,0x12,0xc7,0x44,0x24,0x28,0xff,0xff,0x00,0x00,0x48,0x8d,0x54,0x24,0x28,0xc4,0xe2,0x7d,0x58,0x44,0x24,0x28,0xc5,0xf5,0xdb,0xc8,0xc5,0xed,0xdb,0xc0,0xc4,0xe2,0x75,0x2b,0xc0,0xc4,0xe3,0xfd,0x00,0xc0,0xd8,0x48,0x8d,0x96,0xc0,0x00,0x00,0x00,0xc5,0xff,0xf0,0x0a,0x48,0x81,0xc6,0xe0,0x00,0x00,0x00,0xc5,0xff,0xf0,0x16,0xc7,0x44,0x24,0x24,0xff,0xff,0x00,0x00,0x48,0x8d,0x54,0x24,0x24,0xc4,0xe2,0x7d,0x58,0x5c,0x24,0x24,0xc5,0xf5,0xdb,0xcb,0xc5,0xed,0xdb,0xd3,0xc4,0xe2,0x75,0x2b,0xca,0xc4,0xe3,0xfd,0x00,0xc9,0xd8,0xc7,0x44,0x24,0x20,0xff,0x00,0x00,0x00,0x48,0x8d,0x54,0x24,0x20,0xc4,0xe2,0x7d,0x79,0x54,0x24,0x20,0xc5,0xfd,0xdb,0xc2,0xc5,0xf5,0xdb,0xca,0xc5,0xfd,0x67,0xc1,0xc4,0xe3,0xfd,0x00,0xc0,0xd8,0xba,0x07,0x00,0x00,0x00,0xc5,0xf9,0x6e,0xca,0xc5,0xfd,0xf3,0xc1,0xc5,0xfd,0xd7,0xd0,0x8b,0xd2,0x48,0xc1,0xe2,0x20,0x48,0x0b,0xc2,0xc5,0xf8,0x77,0x48,0x83,0xc4,0x78,0x5e,0x5f,0xc3,0xe8,0x64,0xa3,0x1d,0x5e,0xe8,0xd7,0x7c,0x59,0xfe};

    }
}
