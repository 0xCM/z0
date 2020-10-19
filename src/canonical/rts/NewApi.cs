//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct NewApi
    {
        public static Span<byte> buffer(int index)
            => edit(Buffer_2688);

        static Span<byte> index()
            => edit(IndexBuffer);

        public static ReadOnlySpan<byte> Buffer_8
            =>  new byte[8]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1};

        public static ReadOnlySpan<byte> Buffer_16  =>  new byte[16]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x2e,0xd1,0x0f,0x93,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> Buffer_32 =>  new byte[32]{0x44,0x00,0x00,0x41,0x0f,0xb6,0xc0,0xf7,0xd0,0x0f,0xb6,0xc0,0x0f,0xb6,0xc9,0x0f,0xb6,0xd2,0x0b,0xd1,    0x0f,0xb6,0xd2,0x0f,0xb6,0xc0,0x23,0xc2,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> Buffer_48 =>  new byte[48]{0x0f,0x1f,0x44,0x00,0x00,0x33,0xc0,0x0f,0xb6,0xc9,0x0f,0xb6,0xd2,0x3b,0xca,0x7c,0x07,0xb8,0x0d,0x00,0x00,0x00,0xeb,0x14,0x3b,0xca,0x7f,0x07,0xb8,0x0e,0x00,0x00,0x00,0xeb,0x09,0x3b,0xca,0x74,0x05,0xb8,0x05,0x00,0x00,0x00,0xc3,0xc3,0xc3,0xc3};


        static ReadOnlySpan<byte> IndexBuffer => new byte[4*8 + 4*8]
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};

        public static ReadOnlySpan<byte> Buffer_2688  =>  new byte[2688]{0x41,0x57,0x41,0x56,0x41,0x55,0x41,0x54,0x57,0x56,0x55,0x53,0x48,0x81,0xec,0xf8,0x03,0x00,0x00,0xc5,0xf8,0x77,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x40,0xb9,0xee,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x8b,0xd9,0x48,0x8b,0xea,0x4d,0x8b,0xf0,0x33,0xc9,0x48,0x8d,0x94,0x24,0xe0,0x02,0x00,0x00,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x02,0xc5,0xfa,0x7f,0x42,0x10,0xc5,0xfa,0x7f,0x42,0x20,0x48,0x89,0x4a,0x30,0x48,0x8d,0x8c,0x24,0x90,0x02,0x00,0x00,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0xc5,0xfa,0x7f,0x41,0x10,0xc5,0xfa,0x7f,0x41,0x20,0xc5,0xfa,0x7f,0x41,0x30,0xc5,0xfa,0x7f,0x41,0x40,0x48,0x8d,0x8c,0x24,0x90,0x02,0x00,0x00,0x48,0x8b,0xd5,0xc5,0xfa,0x6f,0x84,0x24,0xe0,0x02,0x00,0x00,0xc5,0xfa,0x7f,0x44,0x24,0x50,0xc5,0xfa,0x6f,0x84,0x24,0xf0,0x02,0x00,0x00,0xc5,0xfa,0x7f,0x44,0x24,0x60,0xc5,0xfa,0x6f,0x84,0x24,0x00,0x03,0x00,0x00,0xc5,0xfa,0x7f,0x44,0x24,0x70,0x4c,0x8b,0x84,0x24,0x10,0x03,0x00,0x00,0x4c,0x89,0x84,0x24,0x80,0x00,0x00,0x00,0x4c,0x8d,0x44,0x24,0x50,0x45,0x33,0xc9,0xe8,0xc4,0x04,0xf8,0xff,0x48,0x8d,0xbc,0x24,0xa8,0x03,0x00,0x00,0x48,0x8d,0xb4,0x24,0x90,0x02,0x00,0x00,0xb9,0x0a,0x00,0x00,0x00,0xf3,0x48,0xa5,0x48,0x8b,0xcd,0xe8,0xe4,0xd2,0xec,0x5a,0x84,0xc0,0x74,0x36,0x48,0x8b,0xfb,0x48,0x8d,0xb4,0x24,0xa8,0x03,0x00,0x00,0xe8,0xf0,0x7d,0x82,0x5e,0xe8,0xeb,0x7d,0x82,0x5e,0x48,0xa5,0x48,0xa5,0xe8,0xe2,0x7d,0x82,0x5e,0x48,0xa5,0xe8,0xdb,0x7d,0x82,0x5e,0xe8,0xd6,0x7d,0x82,0x5e,0x48,0xa5,0x48,0xa5,0x48,0x8b,0xc3,0xe9,0x36,0x09,0x00,0x00,0x8b,0x4d,0x00,0x48,0x8b,0xcd,0xba,0x02,0x00,0x00,0x00,0xe8,0xda,0x9b,0xf0,0x5a,0x8b,0x10,0x83,0x78,0x08,0x00,0x74,0x45,0x66,0x83,0x78,0x0c,0x3b,0x0f,0x94,0xc0,0x0f,0xb6,0xc0,0x85,0xc0,0x74,0x36,0x48,0x8b,0xfb,0x48,0x8d,0xb4,0x24,0xa8,0x03,0x00,0x00,0xe8,0x93,0x7d,0x82,0x5e,0xe8,0x8e,0x7d,0x82,0x5e,0x48,0xa5,0x48,0xa5,0xe8,0x85,0x7d,0x82,0x5e,0x48,0xa5,0xe8,0x7e,0x7d,0x82,0x5e,0xe8,0x79,0x7d,0x82,0x5e,0x48,0xa5,0x48,0xa5,0x48,0x8b,0xc3,0xe9,0xd9,0x08,0x00,0x00,0xc7,0x84,0x24,0x8c,0x02,0x00,0x00,0x3b,0x00,0x00,0x00,0x48,0x8d,0x8c,0x24,0x8c,0x02,0x00,0x00,0xba,0x01,0x00,0x00,0x00,0x4c,0x8d,0x44,0x24,0x40,0x49,0x89,0x08,0x41,0x89,0x50,0x08,0x48,0x8b,0xcd,0x48,0x8d,0x54,0x24,0x40,0x41,0xb8,0xff,0xff,0xff,0x7f,0x41,0xb9,0x01,0x00,0x00,0x00,0xe8,0xa0,0xca,0xec,0x5a,0x4c,0x8b,0xf8,0x41,0x83,0x7f,0x08,0x02,0x74,0x36,0x48,0x8b,0xfb,0x48,0x8d,0xb4,0x24,0xa8,0x03,0x00,0x00,0xe8,0x16,0x7d,0x82,0x5e,0xe8,0x11,0x7d,0x82,0x5e,0x48,0xa5,0x48,0xa5,0xe8,0x08,0x7d,0x82,0x5e,0x48,0xa5,0xe8,0x01,0x7d,0x82,0x5e,0xe8,0xfc,0x7c,0x82,0x5e,0x48,0xa5,0x48,0xa5,0x48,0x8b,0xc3,0xe9,0x5c,0x08,0x00,0x00,0x41,0x83,0x7f,0x08,0x00,0x0f,0x86,0x70,0x08,0x00,0x00,0x49,0x8b,0x77,0x10,0x48,0xb9,0x08,0x94,0x23,0xaf,0xf9,0x7f,0x00,0x00,0xe8,0xf2,0x8a,0x82,0x5e,0x48,0x8b,0xf8,0x48,0x8d,0x4f,0x08,0x48,0x8b,0xd7,0xe8,0x23,0x7c,0x82,0x5e,0x48,0xb9,0xa0,0xd0,0x8d,0xad,0xf9,0x7f,0x00,0x00,0x48,0x89,0x4f,0x18,0x48,0xb9,0x10,0xdb,0xcf,0xae,0xf9,0x7f,0x00,0x00,0x48,0x89,0x4f,0x20,0x48,0x89,0xbc,0x24,0xa0,0x03,0x00,0x00,0x48,0x8d,0x8c,0x24,0xa0,0x03,0x00,0x00,0x48,0x8d,0x94,0x24,0x78,0x03,0x00,0x00,0x4c,0x8b,0xc6,0xe8,0x97,0x25,0x3d,0xff,0x80,0xbc,0x24,0x88,0x03,0x00,0x00,0x00,0x75,0x36,0x48,0x8b,0xfb,0x48,0x8d,0xb4,0x24,0xa8,0x03,0x00,0x00,0xe8,0x6d,0x7c,0x82,0x5e,0xe8,0x68,0x7c,0x82,0x5e,0x48,0xa5,0x48,0xa5,0xe8,0x5f,0x7c,0x82,0x5e,0x48,0xa5,0xe8,0x58,0x7c,0x82,0x5e,0xe8,0x53,0x7c,0x82,0x5e,0x48,0xa5,0x48,0xa5,0x48,0x8b,0xc3,0xe9,0xb3,0x07,0x00,0x00,0x41,0x83,0x7f,0x08,0x01,0x0f,0x86,0xc7,0x07,0x00,0x00,0x49,0x8b,0x77,0x18,0x48,0xb9,0x38,0x75,0xaa,0xad,0xf9,0x7f,0x00,0x00,0xba,0x01,0x00,0x00,0x00,0xe8,0xd4,0x8b,0x82,0x5e,0x48,0x8b,0xf8,0x49,0xb8,0x68,0x98,0xf2,0x92,0x5f,0x02,0x00,0x00,0x4d,0x8b,0x00,0x48,0x8b,0xcf,0x33,0xd2,0xe8,0x8a,0x7c,0x82,0x5e,0x8b,0x0e,0xc7,0x44,0x24,0x20,0x01,0x00,0x00,0x00,0x48,0x8b,0xce,0x4c,0x8b,0xc7,0x33,0xd2,0x41,0xb9,0xff,0xff,0xff,0x7f,0xe8,0x95,0x55,0xd0,0xfe,0x83,0x78,0x08,0x03,0x74,0x36,0x48,0x8b,0xfb,0x48,0x8d,0xb4,0x24,0xa8,0x03,0x00,0x00,0xe8,0xd7,0x7b,0x82,0x5e,0xe8,0xd2,0x7b,0x82,0x5e,0x48,0xa5,0x48,0xa5,0xe8,0xc9,0x7b,0x82,0x5e,0x48,0xa5,0xe8,0xc2,0x7b,0x82,0x5e,0xe8,0xbd,0x7b,0x82,0x5e,0x48,0xa5,0x48,0xa5,0x48,0x8b,0xc3,0xe9,0x1d,0x07,0x00,0x00,0x83,0x78,0x08,0x00,0x0f,0x86,0x32,0x07,0x00,0x00,0x4c,0x8b,0x78,0x10,0x83,0x78,0x08,0x01,0x0f,0x86,0x24,0x07,0x00,0x00,0x4c,0x8b,0x60,0x18,0x83,0x78,0x08,0x02,0x0f,0x86,0x16,0x07,0x00,0x00,0x48,0x8b,0x70,0x20,0xc5,0xf8,0x57,0xc0,0x33,0xc9,0x48,0x8d,0x94,0x24,0xe0,0x01,0x00,0x00,0xc5,0xf0,0x57,0xc9,0xc5,0xfa,0x7f,0x0a,0xc5,0xfa,0x7f,0x4a,0x10,0x48,0x89,0x4a,0x20,0x48,0x8d,0x8c,0x24,0xe0,0x01,0x00,0x00,0x48,0x8d,0x54,0x24,0x30,0xc5,0xf9,0x11,0x02,0x48,0x8b,0xd6,0x4c,0x8d,0x44,0x24,0x30,0x45,0x33,0xc9,0xe8,0x0f,0x03,0xf8,0xff,0xc5,0xfa,0x6f,0x84,0x24,0xe0,0x01,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0x38,0x02,0x00,0x00,0xc5,0xfa,0x6f,0x84,0x24,0xf0,0x01,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0x48,0x02,0x00,0x00,0x48,0x8b,0x8c,0x24,0x00,0x02,0x00,0x00,0x48,0x89,0x8c,0x24,0x58,0x02,0x00,0x00,0x48,0x8b,0xce,0xba,0x5b,0x00,0x00,0x00,0x41,0xb8,0x5d,0x00,0x00,0x00,0xe8,0x38,0x2e,0x99,0xff,0x48,0x89,0x84,0x24,0x30,0x02,0x00,0x00,0x8b,0x94,0x24,0x30,0x02,0x00,0x00,0x44,0x8b,0x84,0x24,0x34,0x02,0x00,0x00,0x83,0xbc,0x24,0x30,0x02,0x00,0x00,0xff,0x74,0x06,0x41,0x83,0xf8,0xff,0x75,0x39,0xc5,0xfa,0x6f,0x84,0x24,0x38,0x02,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0x60,0x02,0x00,0x00,0xc5,0xfa,0x6f,0x84,0x24,0x48,0x02,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0x70,0x02,0x00,0x00,0x48,0x8b,0x94,0x24,0x58,0x02,0x00,0x00,0x48,0x89,0x94,0x24,0x80,0x02,0x00,0x00,0xe9,0x07,0x04,0x00,0x00,0xff,0xc2,0x41,0xff,0xc8,0x44,0x2b,0xc2,0x41,0xff,0xc0,0x48,0x8b,0xce,0x39,0x09,0xe8,0x8b,0x9a,0xec,0x5a,0x48,0x8b,0xf8,0x33,0xc0,0x89,0x84,0x24,0xc0,0x01,0x00,0x00,0x45,0x33,0xed,0x48,0x85,0xff,0x75,0x0b,0x33,0xc0,0x89,0x84,0x24,0xc0,0x01,0x00,0x00,0xeb,0x39,0x48,0x8d,0x47,0x0c,0x8b,0x57,0x08,0x48,0x8d,0x4c,0x24,0x40,0x48,0x89,0x01,0x89,0x51,0x08,0xe8,0xdd,0xf3,0xff,0xff,0x4c,0x8b,0xc0,0x48,0x8d,0x4c,0x24,0x40,0x4c,0x8d,0x8c,0x24,0xc0,0x01,0x00,0x00,0xba,0x07,0x00,0x00,0x00,0xe8,0x2b,0x00,0xf7,0xff,0x85,0xc0,0x0f,0x94,0xc0,0x0f,0xb6,0xc0,0x85,0xc0,0x74,0x0f,0x44,0x8b,0xac,0x24,0xc0,0x01,0x00,0x00,0xb9,0x01,0x00,0x00,0x00,0xeb,0x02,0x33,0xc9,0x85,0xc9,0x74,0x62,0x33,0xc9,0x48,0x8d,0x94,0x24,0xa8,0x01,0x00,0x00,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x02,0x48,0x89,0x4a,0x10,0x48,0x8d,0x8c,0x24,0xa8,0x01,0x00,0x00,0x48,0x8b,0xd7,0x45,0x8b,0xc5,0x45,0x33,0xc9,0xe8,0xc6,0xee,0xff,0xff,0x48,0x8d,0x8c,0x24,0xc8,0x01,0x00,0x00,0x48,0x8b,0x94,0x24,0xa8,0x01,0x00,0x00,0x48,0x89,0x11,0x48,0x8b,0x94,0x24,0xb0,0x01,0x00,0x00,0x48,0x89,0x51,0x08,0x8b,0x94,0x24,0xb8,0x01,0x00,0x00,0x89,0x51,0x10,0x0f,0xb6,0x94,0x24,0xbc,0x01,0x00,0x00,0x88,0x51,0x14,0xeb,0x60,0x33,0xc9,0x48,0x8d,0x94,0x24,0x90,0x01,0x00,0x00,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x02,0x48,0x89,0x4a,0x10,0x48,0x8d,0x8c,0x24,0x90,0x01,0x00,0x00,0x48,0x8b,0xd7,0x45,0x33,0xc0,0x45,0x33,0xc9,0xe8,0x64,0xee,0xff,0xff,0x48,0x8d,0x8c,0x24,0xc8,0x01,0x00,0x00,0x48,0x8b,0x94,0x24,0x90,0x01,0x00,0x00,0x48,0x89,0x11,0x48,0x8b,0x94,0x24,0x98,0x01,0x00,0x00,0x48,0x89,0x51,0x08,0x8b,0x94,0x24,0xa0,0x01,0x00,0x00,0x89,0x51,0x10,0x0f,0xb6,0x94,0x24,0xa4,0x01,0x00,0x00,0x88,0x51,0x14,0x48,0x8d,0x8c,0x24,0xc8,0x01,0x00,0x00,0x48,0x8b,0x11,0x8b,0x79,0x10,0x0f,0xb6,0x49,0x14,0x84,0xc9,0x75,0x39,0xc5,0xfa,0x6f,0x84,0x24,0x38,0x02,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0x60,0x02,0x00,0x00,0xc5,0xfa,0x6f,0x84,0x24,0x48,0x02,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0x70,0x02,0x00,0x00,0x48,0x8b,0x8c,0x24,0x58,0x02,0x00,0x00,0x48,0x89,0x8c,0x24,0x80,0x02,0x00,0x00,0xe9,0x70,0x02,0x00,0x00,0x48,0x8b,0xce,0xba,0x7b,0x00,0x00,0x00,0x41,0xb8,0x7d,0x00,0x00,0x00,0xe8,0x2e,0x2c,0x99,0xff,0x48,0x89,0x84,0x24,0x28,0x02,0x00,0x00,0x8b,0x94,0x24,0x28,0x02,0x00,0x00,0x44,0x8b,0x84,0x24,0x2c,0x02,0x00,0x00,0x83,0xbc,0x24,0x28,0x02,0x00,0x00,0xff,0x74,0x06,0x41,0x83,0xf8,0xff,0x75,0x39,0xc5,0xfa,0x6f,0x84,0x24,0x38,0x02,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0x60,0x02,0x00,0x00,0xc5,0xfa,0x6f,0x84,0x24,0x48,0x02,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0x70,0x02,0x00,0x00,0x48,0x8b,0x94,0x24,0x58,0x02,0x00,0x00,0x48,0x89,0x94,0x24,0x80,0x02,0x00,0x00,0xe9,0xfd,0x01,0x00,0x00,0xff,0xc2,0x41,0xff,0xc8,0x44,0x2b,0xc2,0x41,0xff,0xc0,0x48,0x8b,0xce,0xe8,0x83,0x98,0xec,0x5a,0x4c,0x8b,0xe8,0x41,0x39,0x7d,0x08,0x74,0x39,0xc5,0xfa,0x6f,0x84,0x24,0x38,0x02,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0x60,0x02,0x00,0x00,0xc5,0xfa,0x6f,0x84,0x24,0x48,0x02,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0x70,0x02,0x00,0x00,0x48,0x8b,0x8c,0x24,0x58,0x02,0x00,0x00,0x48,0x89,0x8c,0x24,0x80,0x02,0x00,0x00,0xe9,0xa8,0x01,0x00,0x00,0xc6,0x84,0x24,0x88,0x01,0x00,0x00,0x00,0x48,0xb9,0x40,0xfe,0x8d,0xae,0xf9,0x7f,0x00,0x00,0xe8,0x4a,0x86,0x82,0x5e,0x48,0x8b,0xc8,0x48,0x0f,0xbe,0x94,0x24,0x88,0x01,0x00,0x00,0x88,0x51,0x08,0x48,0x8d,0x94,0x24,0x08,0x02,0x00,0x00,0x4d,0x8b,0xc5,0x49,0xbb,0x68,0x0b,0x8e,0xad,0xf9,0x7f,0x00,0x00,0x48,0xb8,0x68,0x0b,0x8e,0xad,0xf9,0x7f,0x00,0x00,0x39,0x09,0xff,0x10,0x80,0xbc,0x24,0x20,0x02,0x00,0x00,0x00,0x75,0x39,0xc5,0xfa,0x6f,0x84,0x24,0x38,0x02,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0x60,0x02,0x00,0x00,0xc5,0xfa,0x6f,0x84,0x24,0x48,0x02,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0x70,0x02,0x00,0x00,0x48,0x8b,0x8c,0x24,0x58,0x02,0x00,0x00,0x48,0x89,0x8c,0x24,0x80,0x02,0x00,0x00,0xe9,0x1c,0x01,0x00,0x00,0x48,0x8b,0x8c,0x24,0x10,0x02,0x00,0x00,0x39,0x79,0x08,0x74,0x39,0xc5,0xfa,0x6f,0x84,0x24,0x38,0x02,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0x60,0x02,0x00,0x00,0xc5,0xfa,0x6f,0x84,0x24,0x48,0x02,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0x70,0x02,0x00,0x00,0x48,0x8b,0x8c,0x24,0x58,0x02,0x00,0x00,0x48,0x89,0x8c,0x24,0x80,0x02,0x00,0x00,0xe9,0xd6,0x00,0x00,0x00,0x48,0x8d,0x51,0x10,0x8b,0x49,0x08,0xc5,0xf8,0x57,0xc0,0x44,0x8b,0xc1,0x83,0xf9,0x0f,0x7f,0x02,0xeb,0x05,0xb9,0x0f,0x00,0x00,0x00,0x45,0x33,0xc9,0x85,0xc9,0x7e,0x3a,0x49,0x63,0xc1,0x0f,0xb6,0x04,0x02,0x41,0x83,0xf9,0x10,0x0f,0x83,0xbd,0x02,0x00,0x00,0xc5,0xf9,0x29,0x84,0x24,0x70,0x01,0x00,0x00,0x4c,0x8d,0x94,0x24,0x70,0x01,0x00,0x00,0x4d,0x63,0xd9,0x43,0x88,0x04,0x1a,0xc5,0xf9,0x28,0x84,0x24,0x70,0x01,0x00,0x00,0x41,0xff,0xc1,0x44,0x3b,0xc9,0x7c,0xc6,0x41,0x0f,0xb6,0xc8,0xc4,0xe3,0x79,0x20,0xc1,0x0f,0x33,0xc9,0x48,0x8d,0x94,0x24,0x48,0x01,0x00,0x00,0xc5,0xf0,0x57,0xc9,0xc5,0xfa,0x7f,0x0a,0xc5,0xfa,0x7f,0x4a,0x10,0x48,0x89,0x4a,0x20,0x48,0x8d,0x8c,0x24,0x48,0x01,0x00,0x00,0x48,0x8b,0xd6,0x4c,0x8d,0x44,0x24,0x30,0xc4,0xc1,0x79,0x11,0x00,0x4c,0x8d,0x44,0x24,0x30,0x45,0x33,0xc9,0xe8,0x95,0xfe,0xf7,0xff,0xc5,0xfa,0x6f,0x84,0x24,0x48,0x01,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0x60,0x02,0x00,0x00,0xc5,0xfa,0x6f,0x84,0x24,0x58,0x01,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0x70,0x02,0x00,0x00,0x48,0x8b,0x84,0x24,0x68,0x01,0x00,0x00,0x48,0x89,0x84,0x24,0x80,0x02,0x00,0x00,0xc5,0xfa,0x6f,0x84,0x24,0x60,0x02,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0x50,0x03,0x00,0x00,0xc5,0xfa,0x6f,0x84,0x24,0x70,0x02,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0x60,0x03,0x00,0x00,0x48,0x8b,0x84,0x24,0x80,0x02,0x00,0x00,0x48,0x89,0x84,0x24,0x70,0x03,0x00,0x00,0x80,0xbc,0x24,0x60,0x03,0x00,0x00,0x00,0x75,0x36,0x48,0x8b,0xfb,0x48,0x8d,0xb4,0x24,0xa8,0x03,0x00,0x00,0xe8,0x4b,0x76,0x82,0x5e,0xe8,0x46,0x76,0x82,0x5e,0x48,0xa5,0x48,0xa5,0xe8,0x3d,0x76,0x82,0x5e,0x48,0xa5,0xe8,0x36,0x76,0x82,0x5e,0xe8,0x31,0x76,0x82,0x5e,0x48,0xa5,0x48,0xa5,0x48,0x8b,0xc3,0xe9,0x91,0x01,0x00,0x00,0x41,0x8b,0x0e,0x8d,0x51,0x01,0x41,0x89,0x16,0x48,0x8d,0x94,0x24,0x90,0x03,0x00,0x00,0x4c,0x8b,0x02,0x8b,0x52,0x08,0x4c,0x8d,0x8c,0x24,0x68,0x03,0x00,0x00,0xc4,0xc1,0x79,0x10,0x01,0x89,0x8c,0x24,0x18,0x03,0x00,0x00,0x48,0x8d,0x8c,0x24,0x20,0x03,0x00,0x00,0x4c,0x89,0x01,0x89,0x51,0x08,0x48,0x8d,0x8c,0x24,0x30,0x03,0x00,0x00,0x4c,0x89,0x21,0x48,0x8d,0x8c,0x24,0x38,0x03,0x00,0x00,0x4c,0x89,0x39,0x48,0x8d,0x8c,0x24,0x40,0x03,0x00,0x00,0xc5,0xf9,0x11,0x01,0xc5,0xfa,0x6f,0x84,0x24,0x18,0x03,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0x10,0x01,0x00,0x00,0xc5,0xfa,0x6f,0x84,0x24,0x28,0x03,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0x20,0x01,0x00,0x00,0xc5,0xfa,0x6f,0x84,0x24,0x38,0x03,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0x30,0x01,0x00,0x00,0x48,0x8b,0x8c,0x24,0x48,0x03,0x00,0x00,0x48,0x89,0x8c,0x24,0x40,0x01,0x00,0x00,0xc5,0xfa,0x6f,0x84,0x24,0x10,0x01,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0xd8,0x00,0x00,0x00,0xc5,0xfa,0x6f,0x84,0x24,0x20,0x01,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0xe8,0x00,0x00,0x00,0xc5,0xfa,0x6f,0x84,0x24,0x30,0x01,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0xf8,0x00,0x00,0x00,0x48,0x8b,0x8c,0x24,0x40,0x01,0x00,0x00,0x48,0x89,0x8c,0x24,0x08,0x01,0x00,0x00,0x48,0x8d,0x8c,0x24,0x88,0x00,0x00,0x00,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0xc5,0xfa,0x7f,0x41,0x10,0xc5,0xfa,0x7f,0x41,0x20,0xc5,0xfa,0x7f,0x41,0x30,0xc5,0xfa,0x7f,0x41,0x40,0x48,0x8d,0x8c,0x24,0x88,0x00,0x00,0x00,0x48,0x8b,0xd5,0xc5,0xfa,0x6f,0x84,0x24,0xd8,0x00,0x00,0x00,0xc5,0xfa,0x7f,0x44,0x24,0x50,0xc5,0xfa,0x6f,0x84,0x24,0xe8,0x00,0x00,0x00,0xc5,0xfa,0x7f,0x44,0x24,0x60,0xc5,0xfa,0x6f,0x84,0x24,0xf8,0x00,0x00,0x00,0xc5,0xfa,0x7f,0x44,0x24,0x70,0x4c,0x8b,0x84,0x24,0x08,0x01,0x00,0x00,0x4c,0x89,0x84,0x24,0x80,0x00,0x00,0x00,0x4c,0x8d,0x44,0x24,0x50,0x45,0x33,0xc9,0xe8,0x65,0xfb,0xf7,0xff,0x48,0x8b,0xfb,0x48,0x8d,0xb4,0x24,0x88,0x00,0x00,0x00,0xe8,0xb5,0x74,0x82,0x5e,0xe8,0xb0,0x74,0x82,0x5e,0x48,0xa5,0x48,0xa5,0xe8,0xa7,0x74,0x82,0x5e,0x48,0xa5,0xe8,0xa0,0x74,0x82,0x5e,0xe8,0x9b,0x74,0x82,0x5e,0x48,0xa5,0x48,0xa5,0x48,0x8b,0xc3,0x48,0x81,0xc4,0xf8,0x03,0x00,0x00,0x5b,0x5d,0x5e,0x5f,0x41,0x5c,0x41,0x5d,0x41,0x5e,0x41,0x5f,0xc3,0xb9,0x15,0x00,0x00,0x00,0xe8,0x4e,0xa8,0xd2,0xfe,0xcc,0xe8,0x80,0x07,0x95,0x5e};

        [Op, MethodImpl(Inline)]
        public static ReadOnlySpan<SegRef> init()
        {
            var x = index();
            seek64(x,0) = address(Buffer_8);
            seek64(x,16) = address(Buffer_16);
            seek64(x,16) = address(Buffer_32);
            return recover<SegRef>(x);
        }


        [MethodImpl(Inline), Op]
        public static Ref<byte> reference()
            => MemRefs.from(Buffer_2688);

        const byte Sz = SegRef.Size;

        static ReadOnlySpan<byte> SegIndex => new byte[8*Sz]{
            0,0,0,0,0,0,0,0,    0,0,0,0,0,0,0,0,
            0,0,0,0,0,0,0,0,    0,0,0,0,0,0,0,0,
            0,0,0,0,0,0,0,0,    0,0,0,0,0,0,0,0,
            0,0,0,0,0,0,0,0,    0,0,0,0,0,0,0,0,
            0,0,0,0,0,0,0,0,    0,0,0,0,0,0,0,0,
            0,0,0,0,0,0,0,0,    0,0,0,0,0,0,0,0,
            0,0,0,0,0,0,0,0,    0,0,0,0,0,0,0,0,
            0,0,0,0,0,0,0,0,    0,0,0,0,0,0,0,0
            };

        static ReadOnlySpan<byte> IndexPos => new byte[6]{
            0, 24, 47, 92, 128, 200
        };

        [Op, MethodImpl(Inline)]
        public static ReadOnlySpan<SegRef> segments()
        {
            var index = edit(SegIndex);
            var src = edit(Buffer_2688);
            var pos = IndexPos;

            seek64(index,0) = address(skip(src, skip(pos, 0)));
            seek64(index,1) = (ulong)(skip(pos, 1) - skip(pos,0));

            seek64(index,2) = address(skip(src,skip(pos, 1)));
            seek64(index,3) = (ulong)(skip(pos, 2) - skip(pos,1));

            seek64(index,4) = address(skip(src,skip(pos, 2)));
            seek64(index,5) = (ulong)(skip(pos, 3) - skip(pos,2));

            return recover<SegRef>(index);
        }
    }
}