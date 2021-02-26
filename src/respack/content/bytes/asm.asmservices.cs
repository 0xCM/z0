//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
// Generated   : 2021-02-26 14:33:07 -06:00
//-----------------------------------------------------------------------------
namespace Z0.ByteCode
{
    using System;
    using System.Runtime.CompilerServices;


    public static class asm_asmservices
    {
        public static ReadOnlySpan<byte> decoder_ᐤAsmFormatConfigᕀinᐤ  =>  new byte[127]{0x57,0x56,0x53,0x48,0x83,0xec,0x60,0xc5,0xf8,0x77,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x20,0xb9,0x10,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0xc5,0xfa,0x6f,0x01,0xc5,0xfa,0x7f,0x44,0x24,0x20,0xc5,0xfa,0x6f,0x41,0x10,0xc5,0xfa,0x7f,0x44,0x24,0x30,0xc5,0xfa,0x6f,0x44,0x24,0x20,0xc5,0xfa,0x7f,0x44,0x24,0x40,0xc5,0xfa,0x6f,0x44,0x24,0x30,0xc5,0xfa,0x7f,0x44,0x24,0x50,0x48,0xb9,0x88,0x20,0xc7,0xdc,0xfd,0x7f,0x00,0x00,0xe8,0xc6,0x80,0x92,0x5b,0x48,0x8b,0xd8,0x48,0x8d,0x7b,0x08,0x48,0x8d,0x74,0x24,0x40,0xe8,0x95,0x72,0x92,0x5b,0xe8,0x90,0x72,0x92,0x5b,0x48,0xa5,0x48,0xa5,0x48,0x8b,0xc3,0x48,0x83,0xc4,0x60,0x5b,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> context_ᐤIWfShellᐤ  =>  new byte[329]{0x57,0x56,0x55,0x53,0x48,0x83,0xec,0x28,0x48,0x8b,0xf1,0x48,0xb9,0x18,0x0f,0x35,0xda,0xfd,0x7f,0x00,0x00,0xe8,0x06,0x9a,0xe6,0x59,0x48,0x8b,0xf8,0x48,0x8b,0xce,0xe8,0xfb,0x4d,0x35,0xfa,0x48,0x8b,0xd8,0x48,0x8d,0x4f,0x08,0x48,0x8b,0xd3,0xe8,0x2c,0x8b,0xe6,0x59,0x48,0x8d,0x4f,0x10,0x48,0x8b,0xd6,0xe8,0x20,0x8b,0xe6,0x59,0x48,0x8b,0xcb,0x49,0xbb,0x78,0x32,0x02,0xda,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0xe3,0x54,0x22,0xfa,0x48,0x8d,0x4f,0x18,0x48,0x8b,0xd0,0xe8,0xff,0x8a,0xe6,0x59,0x48,0x8b,0xcb,0x49,0xbb,0x80,0x32,0x02,0xda,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0xca,0x54,0x22,0xfa,0x48,0x8d,0x4f,0x20,0x48,0x8b,0xd0,0xe8,0xde,0x8a,0xe6,0x59,0x48,0xb9,0x50,0x4c,0x35,0xda,0xfd,0x7f,0x00,0x00,0xe8,0x8f,0x99,0xe6,0x59,0x48,0x8b,0xf0,0x48,0x8b,0xcb,0x49,0xbb,0x88,0x32,0x02,0xda,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0x9f,0x54,0x22,0xfa,0x48,0x8b,0xe8,0x48,0x8d,0x4e,0x08,0x48,0x8b,0xd7,0xe8,0xa8,0x8a,0xe6,0x59,0x48,0xb9,0xd0,0x30,0x15,0xda,0xfd,0x7f,0x00,0x00,0x48,0x89,0x4e,0x18,0x48,0x8b,0xcd,0x48,0x8b,0xd6,0x49,0xbb,0x90,0x32,0x02,0xda,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0x72,0x54,0x22,0xfa,0x48,0x8b,0xcb,0x49,0xbb,0x98,0x32,0x02,0xda,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0x65,0x54,0x22,0xfa,0x48,0x8d,0x4f,0x30,0x48,0x8b,0xd0,0xe8,0x61,0x8a,0xe6,0x59,0x48,0x8b,0x77,0x10,0x48,0xb9,0x68,0x4e,0x35,0xda,0xfd,0x7f,0x00,0x00,0xe8,0x0e,0x99,0xe6,0x59,0x48,0x8b,0xd8,0x48,0x8d,0x6b,0x08,0x48,0x8d,0x4d,0x00,0x48,0x8b,0xd6,0xe8,0x0b,0x8a,0xe6,0x59,0x48,0x8d,0x4d,0x08,0x48,0x8b,0xd7,0xe8,0xff,0x89,0xe6,0x59,0x48,0x8d,0x4f,0x28,0x48,0x8b,0xd3,0xe8,0x23,0x8a,0xe6,0x59,0x48,0x8b,0xc7,0x48,0x83,0xc4,0x28,0x5b,0x5d,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> create_ᐤIWfShellᐤ  =>  new byte[374]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xec,0x20,0x48,0x8b,0xf1,0x48,0xb9,0x18,0x0f,0x35,0xda,0xfd,0x7f,0x00,0x00,0xe8,0x94,0x98,0xe6,0x59,0x48,0x8b,0xf8,0x48,0x8b,0xce,0xe8,0x89,0x4c,0x35,0xfa,0x48,0x8b,0xd8,0x48,0x8d,0x4f,0x08,0x48,0x8b,0xd3,0xe8,0xba,0x89,0xe6,0x59,0x48,0x8d,0x4f,0x10,0x48,0x8b,0xd6,0xe8,0xae,0x89,0xe6,0x59,0x48,0x8b,0xcb,0x49,0xbb,0xa0,0x32,0x02,0xda,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0x99,0x53,0x22,0xfa,0x48,0x8d,0x4f,0x18,0x48,0x8b,0xd0,0xe8,0x8d,0x89,0xe6,0x59,0x48,0x8b,0xcb,0x49,0xbb,0xa8,0x32,0x02,0xda,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0x80,0x53,0x22,0xfa,0x48,0x8d,0x4f,0x20,0x48,0x8b,0xd0,0xe8,0x6c,0x89,0xe6,0x59,0x48,0xb9,0x50,0x4c,0x35,0xda,0xfd,0x7f,0x00,0x00,0xe8,0x1d,0x98,0xe6,0x59,0x48,0x8b,0xe8,0x48,0x8b,0xcb,0x49,0xbb,0xb0,0x32,0x02,0xda,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0x55,0x53,0x22,0xfa,0x4c,0x8b,0xf0,0x48,0x8d,0x4d,0x08,0x48,0x8b,0xd7,0xe8,0x36,0x89,0xe6,0x59,0x48,0xb9,0xd0,0x30,0x15,0xda,0xfd,0x7f,0x00,0x00,0x48,0x89,0x4d,0x18,0x49,0x8b,0xce,0x48,0x8b,0xd5,0x49,0xbb,0xb8,0x32,0x02,0xda,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0x28,0x53,0x22,0xfa,0x48,0x8b,0xcb,0x49,0xbb,0xc0,0x32,0x02,0xda,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0x1b,0x53,0x22,0xfa,0x48,0x8d,0x4f,0x30,0x48,0x8b,0xd0,0xe8,0xef,0x88,0xe6,0x59,0x48,0x8b,0x5f,0x10,0x48,0xb9,0x68,0x4e,0x35,0xda,0xfd,0x7f,0x00,0x00,0xe8,0x9c,0x97,0xe6,0x59,0x48,0x8b,0xe8,0x4c,0x8d,0x75,0x08,0x49,0x8d,0x0e,0x48,0x8b,0xd3,0xe8,0x9a,0x88,0xe6,0x59,0x49,0x8d,0x4e,0x08,0x48,0x8b,0xd7,0xe8,0x8e,0x88,0xe6,0x59,0x48,0x8d,0x4f,0x28,0x48,0x8b,0xd5,0xe8,0xb2,0x88,0xe6,0x59,0x48,0xb9,0x58,0x2d,0xc7,0xdc,0xfd,0x7f,0x00,0x00,0xe8,0x63,0x97,0xe6,0x59,0x48,0x8b,0xd8,0x48,0x8d,0x4b,0x08,0x48,0x8b,0xd6,0xe8,0x94,0x88,0xe6,0x59,0x48,0x8d,0x4b,0x10,0x48,0x8b,0xd7,0xe8,0x88,0x88,0xe6,0x59,0x48,0x8b,0xc3,0x48,0x83,0xc4,0x20,0x5b,0x5d,0x5e,0x5f,0x41,0x5e,0xc3};

        public static ReadOnlySpan<byte> workflow_ᐤIWfShellᐤ  =>  new byte[1173]{0x55,0x41,0x57,0x41,0x56,0x57,0x56,0x53,0x48,0x81,0xec,0xd8,0x01,0x00,0x00,0xc5,0xf8,0x77,0x48,0x8d,0xac,0x24,0x00,0x02,0x00,0x00,0x48,0x8b,0xf1,0x48,0x8d,0xbd,0x48,0xfe,0xff,0xff,0xb9,0x64,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x8b,0xd9,0x48,0xb9,0x18,0x0f,0x35,0xda,0xfd,0x7f,0x00,0x00,0xe8,0xce,0x96,0xe6,0x59,0x4c,0x8b,0xf0,0x48,0x8b,0xcb,0xe8,0xc3,0x4a,0x35,0xfa,0x48,0x8b,0xf0,0x49,0x8d,0x4e,0x08,0x48,0x8b,0xd6,0xe8,0xf4,0x87,0xe6,0x59,0x49,0x8d,0x4e,0x10,0x48,0x8b,0xd3,0xe8,0xe8,0x87,0xe6,0x59,0x48,0x8b,0xce,0x49,0xbb,0xc8,0x32,0x02,0xda,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0xfb,0x51,0x22,0xfa,0x49,0x8d,0x4e,0x18,0x48,0x8b,0xd0,0xe8,0xc7,0x87,0xe6,0x59,0x48,0x8b,0xce,0x49,0xbb,0xd0,0x32,0x02,0xda,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0xe2,0x51,0x22,0xfa,0x49,0x8d,0x4e,0x20,0x48,0x8b,0xd0,0xe8,0xa6,0x87,0xe6,0x59,0x48,0xb9,0x50,0x4c,0x35,0xda,0xfd,0x7f,0x00,0x00,0xe8,0x57,0x96,0xe6,0x59,0x48,0x8b,0xf8,0x48,0x8b,0xce,0x49,0xbb,0xd8,0x32,0x02,0xda,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0xb7,0x51,0x22,0xfa,0x4c,0x8b,0xf8,0x48,0x8d,0x4f,0x08,0x49,0x8b,0xd6,0xe8,0x70,0x87,0xe6,0x59,0x48,0xb9,0xd0,0x30,0x15,0xda,0xfd,0x7f,0x00,0x00,0x48,0x89,0x4f,0x18,0x49,0x8b,0xcf,0x48,0x8b,0xd7,0x49,0xbb,0xe0,0x32,0x02,0xda,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0x8a,0x51,0x22,0xfa,0x48,0x8b,0xce,0x49,0xbb,0xe8,0x32,0x02,0xda,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0x7d,0x51,0x22,0xfa,0x49,0x8d,0x4e,0x30,0x48,0x8b,0xd0,0xe8,0x29,0x87,0xe6,0x59,0x49,0x8b,0x76,0x10,0x48,0xb9,0x68,0x4e,0x35,0xda,0xfd,0x7f,0x00,0x00,0xe8,0xd6,0x95,0xe6,0x59,0x48,0x8b,0xf8,0x4c,0x8d,0x7f,0x08,0x49,0x8d,0x0f,0x48,0x8b,0xd6,0xe8,0xd4,0x86,0xe6,0x59,0x49,0x8d,0x4f,0x08,0x49,0x8b,0xd6,0xe8,0xc8,0x86,0xe6,0x59,0x49,0x8d,0x4e,0x28,0x48,0x8b,0xd7,0xe8,0xec,0x86,0xe6,0x59,0x33,0xc9,0x48,0x8d,0x45,0x80,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x00,0xc5,0xfa,0x7f,0x40,0x10,0xc5,0xfa,0x7f,0x40,0x20,0xc5,0xfa,0x7f,0x40,0x30,0xc5,0xfa,0x7f,0x40,0x40,0x48,0x89,0x48,0x50,0x48,0x8d,0x8d,0x60,0xff,0xff,0xff,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0xc5,0xfa,0x7f,0x41,0x10,0x48,0x89,0x5d,0x80,0x4c,0x89,0x75,0x88,0x48,0xb9,0x58,0x2d,0xc7,0xdc,0xfd,0x7f,0x00,0x00,0xe8,0x5b,0x95,0xe6,0x59,0x48,0x8b,0xf0,0x48,0x8d,0x4e,0x08,0x48,0x8b,0xd3,0xe8,0x8c,0x86,0xe6,0x59,0x48,0x8d,0x4e,0x10,0x49,0x8b,0xd6,0xe8,0x80,0x86,0xe6,0x59,0x48,0x89,0x75,0x90,0x48,0x8d,0x8d,0x40,0xff,0xff,0xff,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0xc5,0xfa,0x7f,0x41,0x10,0xc7,0x44,0x24,0x20,0x01,0x00,0x00,0x00,0xc7,0x44,0x24,0x28,0x28,0x00,0x00,0x00,0xc7,0x44,0x24,0x30,0x01,0x00,0x00,0x00,0xc7,0x44,0x24,0x38,0x01,0x00,0x00,0x00,0xc7,0x44,0x24,0x40,0x78,0x00,0x00,0x00,0x48,0x8d,0x8d,0x40,0xff,0xff,0xff,0xba,0x01,0x00,0x00,0x00,0x41,0xb8,0x01,0x00,0x00,0x00,0x41,0xb9,0x01,0x00,0x00,0x00,0xe8,0xc3,0x11,0x54,0xfe,0xc5,0xfa,0x6f,0x85,0x40,0xff,0xff,0xff,0xc5,0xfa,0x7f,0x85,0x60,0xff,0xff,0xff,0xc5,0xfa,0x6f,0x85,0x50,0xff,0xff,0xff,0xc5,0xfa,0x7f,0x85,0x70,0xff,0xff,0xff,0x48,0x8d,0x95,0x60,0xff,0xff,0xff,0x48,0x8b,0x4d,0x90,0x39,0x09,0xe8,0xf1,0x1d,0x86,0xfc,0x48,0x89,0x45,0x98,0x48,0x8b,0x4d,0x90,0x8b,0x09,0x33,0xc9,0x48,0x8d,0x95,0x18,0xff,0xff,0xff,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x02,0xc5,0xfa,0x7f,0x42,0x10,0x48,0x89,0x4a,0x20,0xc5,0xfa,0x6f,0x85,0x60,0xff,0xff,0xff,0xc5,0xfa,0x7f,0x85,0xd8,0xfe,0xff,0xff,0xc5,0xfa,0x6f,0x85,0x70,0xff,0xff,0xff,0xc5,0xfa,0x7f,0x85,0xe8,0xfe,0xff,0xff,0xc5,0xfa,0x6f,0x85,0xd8,0xfe,0xff,0xff,0xc5,0xfa,0x7f,0x85,0x20,0xff,0xff,0xff,0xc5,0xfa,0x6f,0x85,0xe8,0xfe,0xff,0xff,0xc5,0xfa,0x7f,0x85,0x30,0xff,0xff,0xff,0xc6,0x85,0x18,0xff,0xff,0xff,0x01,0x48,0x8d,0x8d,0xf8,0xfe,0xff,0xff,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0xc5,0xfa,0x7f,0x41,0x10,0xc5,0xfa,0x6f,0x85,0x18,0xff,0xff,0xff,0xc5,0xfa,0x7f,0x85,0xb0,0xfe,0xff,0xff,0xc5,0xfa,0x6f,0x85,0x28,0xff,0xff,0xff,0xc5,0xfa,0x7f,0x85,0xc0,0xfe,0xff,0xff,0x48,0x8b,0x8d,0x38,0xff,0xff,0xff,0x48,0x89,0x8d,0xd0,0xfe,0xff,0xff,0xc5,0xfa,0x6f,0x85,0xb0,0xfe,0xff,0xff,0xc5,0xfa,0x7f,0x85,0x88,0xfe,0xff,0xff,0xc5,0xfa,0x6f,0x85,0xc0,0xfe,0xff,0xff,0xc5,0xfa,0x7f,0x85,0x98,0xfe,0xff,0xff,0x48,0x8b,0x8d,0xd0,0xfe,0xff,0xff,0x48,0x89,0x8d,0xa8,0xfe,0xff,0xff,0x48,0x8d,0xbd,0xf8,0xfe,0xff,0xff,0x80,0xbd,0x88,0xfe,0xff,0xff,0x00,0x0f,0x85,0x79,0x00,0x00,0x00,0x48,0x8d,0x8d,0x48,0xfe,0xff,0xff,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0xc5,0xfa,0x7f,0x41,0x10,0x33,0xc9,0x89,0x4c,0x24,0x20,0xc7,0x44,0x24,0x28,0x28,0x00,0x00,0x00,0xc7,0x44,0x24,0x30,0x01,0x00,0x00,0x00,0xc7,0x44,0x24,0x38,0x01,0x00,0x00,0x00,0xc7,0x44,0x24,0x40,0x78,0x00,0x00,0x00,0x48,0x8d,0x8d,0x48,0xfe,0xff,0xff,0xba,0x01,0x00,0x00,0x00,0x41,0xb8,0x01,0x00,0x00,0x00,0x41,0xb9,0x01,0x00,0x00,0x00,0xe8,0x4b,0x10,0x54,0xfe,0xc5,0xfa,0x6f,0x85,0x48,0xfe,0xff,0xff,0xc5,0xfa,0x7f,0x85,0x68,0xfe,0xff,0xff,0xc5,0xfa,0x6f,0x85,0x58,0xfe,0xff,0xff,0xc5,0xfa,0x7f,0x85,0x78,0xfe,0xff,0xff,0xeb,0x20,0xc5,0xfa,0x6f,0x85,0x90,0xfe,0xff,0xff,0xc5,0xfa,0x7f,0x85,0x68,0xfe,0xff,0xff,0xc5,0xfa,0x6f,0x85,0xa0,0xfe,0xff,0xff,0xc5,0xfa,0x7f,0x85,0x78,0xfe,0xff,0xff,0x48,0x8d,0xb5,0x68,0xfe,0xff,0xff,0xe8,0xfd,0x84,0xe6,0x59,0xe8,0xf8,0x84,0xe6,0x59,0x48,0xa5,0x48,0xa5,0x48,0xb9,0x40,0xf6,0xc6,0xdc,0xfd,0x7f,0x00,0x00,0xe8,0x05,0x93,0xe6,0x59,0x4c,0x8b,0xf8,0x49,0x8d,0x7f,0x08,0x48,0x8d,0xb5,0xf8,0xfe,0xff,0xff,0xe8,0xd2,0x84,0xe6,0x59,0xe8,0xcd,0x84,0xe6,0x59,0x48,0xa5,0x48,0xa5,0x4c,0x89,0x7d,0xa0,0x48,0x8d,0x4d,0xa8,0x48,0x8b,0xd3,0x4d,0x8b,0xc6,0xe8,0x46,0x6c,0xff,0xff,0x48,0xb9,0x48,0x2f,0xc7,0xdc,0xfd,0x7f,0x00,0x00,0xe8,0xc7,0x92,0xe6,0x59,0x48,0x8b,0xd8,0x48,0x8d,0x7b,0x08,0x48,0x8d,0x75,0x80,0xe8,0x97,0x84,0xe6,0x59,0xe8,0x92,0x84,0xe6,0x59,0xe8,0x8d,0x84,0xe6,0x59,0xe8,0x88,0x84,0xe6,0x59,0xe8,0x83,0x84,0xe6,0x59,0xe8,0x7e,0x84,0xe6,0x59,0xe8,0x79,0x84,0xe6,0x59,0xe8,0x74,0x84,0xe6,0x59,0x48,0xa5,0x48,0xa5,0xe8,0x6b,0x84,0xe6,0x59,0x48,0x8b,0xc3,0x48,0x8d,0x65,0xd8,0x5b,0x5e,0x5f,0x41,0x5e,0x41,0x5f,0x5d,0xc3};

        public static ReadOnlySpan<byte> apicapture_ᐤIWfShellㆍIAsmContextᐤ  =>  new byte[768]{0x41,0x57,0x41,0x56,0x41,0x55,0x41,0x54,0x57,0x56,0x55,0x53,0x48,0x81,0xec,0xe8,0x00,0x00,0x00,0xc5,0xf8,0x77,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x28,0xb9,0x30,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x8b,0xd9,0x48,0x8b,0xf2,0x49,0x8b,0xf8,0x48,0x8d,0x94,0x24,0x98,0x00,0x00,0x00,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x02,0xc5,0xfa,0x7f,0x42,0x10,0xc5,0xfa,0x7f,0x42,0x20,0xc5,0xfa,0x7f,0x42,0x30,0xc5,0xfa,0x7f,0x42,0x40,0x33,0xd2,0x48,0x89,0x94,0x24,0x90,0x00,0x00,0x00,0x48,0xba,0xf0,0x3b,0xe0,0x13,0xd3,0x01,0x00,0x00,0x48,0x8b,0x12,0x48,0x8d,0x8c,0x24,0x90,0x00,0x00,0x00,0xe8,0xb5,0xb2,0x3a,0xfd,0x48,0x8b,0xac,0x24,0x90,0x00,0x00,0x00,0x48,0xb9,0x10,0x58,0x4d,0xdd,0xfd,0x7f,0x00,0x00,0xe8,0x8e,0x91,0xe6,0x59,0x4c,0x8b,0xf0,0x48,0xb9,0x10,0x58,0x4d,0xdd,0xfd,0x7f,0x00,0x00,0xe8,0x1c,0xcf,0xdf,0x59,0x4c,0x8b,0xf8,0x49,0x8d,0x4e,0x08,0x49,0x8b,0xd7,0xe8,0xad,0x82,0xe6,0x59,0x4d,0x8b,0x66,0x08,0x49,0x8b,0xcc,0x49,0x8b,0x04,0x24,0x48,0x8b,0x40,0x50,0xff,0x50,0x38,0x4c,0x8b,0xe8,0x49,0x8b,0xcc,0x49,0x8b,0x04,0x24,0x48,0x8b,0x40,0x50,0xff,0x50,0x08,0x44,0x8b,0xe0,0x49,0x8d,0x46,0x10,0x48,0x89,0x44,0x24,0x20,0x48,0x8d,0x08,0x49,0x8b,0xd5,0xe8,0x43,0x82,0xe6,0x59,0x4c,0x8b,0x6c,0x24,0x20,0x45,0x89,0x65,0x08,0x49,0x8d,0x4e,0x20,0x49,0x8b,0xd7,0xe8,0x5e,0x82,0xe6,0x59,0x49,0x8d,0x4e,0x28,0x48,0x8b,0xd5,0xe8,0x52,0x82,0xe6,0x59,0x49,0x8b,0x4e,0x28,0x48,0x89,0x4c,0x24,0x58,0x48,0x8d,0x4c,0x24,0x58,0xe8,0xaf,0xc6,0x3a,0xfd,0x48,0x8b,0xe8,0x48,0xb9,0xf0,0xa1,0x32,0xda,0xfd,0x7f,0x00,0x00,0xe8,0xed,0x90,0xe6,0x59,0x4c,0x8b,0xf8,0x4d,0x8b,0x66,0x08,0x49,0x8b,0xce,0x48,0xba,0x40,0x59,0x4d,0xdd,0xfd,0x7f,0x00,0x00,0x49,0xb8,0x00,0xee,0xec,0xdc,0xfd,0x7f,0x00,0x00,0xe8,0xfa,0x79,0xd4,0x59,0x4c,0x8b,0xe8,0x49,0x8d,0x4f,0x08,0x49,0x8b,0xd6,0xe8,0xfb,0x81,0xe6,0x59,0x4d,0x89,0x6f,0x18,0x48,0x8d,0x4c,0x24,0x60,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0xc5,0xfa,0x7f,0x41,0x10,0xc5,0xfa,0x7f,0x41,0x20,0x48,0x8d,0x4c,0x24,0x70,0x48,0x89,0x29,0x33,0xc0,0x89,0x41,0x08,0x4c,0x89,0x64,0x24,0x60,0x49,0x8b,0xcc,0x49,0x8b,0x04,0x24,0x48,0x8b,0x40,0x40,0xff,0x50,0x30,0x48,0x85,0xc0,0x75,0x04,0x33,0xc9,0xeb,0x07,0x48,0x8d,0x48,0x0c,0x8b,0x50,0x08,0x8b,0x50,0x08,0xd1,0xe2,0x8b,0xd2,0xc4,0xe1,0xf9,0x6e,0xc1,0xc4,0xe3,0xf9,0x22,0xc2,0x01,0x48,0x8d,0x8c,0x24,0x80,0x00,0x00,0x00,0xc5,0xf9,0x11,0x01,0x4c,0x89,0x7c,0x24,0x68,0xc5,0xfa,0x6f,0x44,0x24,0x60,0xc5,0xfa,0x7f,0x84,0x24,0xb0,0x00,0x00,0x00,0xc5,0xfa,0x6f,0x44,0x24,0x70,0xc5,0xfa,0x7f,0x84,0x24,0xc0,0x00,0x00,0x00,0xc5,0xfa,0x6f,0x84,0x24,0x80,0x00,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0xd0,0x00,0x00,0x00,0x48,0x8b,0xce,0xc5,0xfa,0x6f,0x84,0x24,0xb0,0x00,0x00,0x00,0xc5,0xfa,0x7f,0x44,0x24,0x28,0xc5,0xfa,0x6f,0x84,0x24,0xc0,0x00,0x00,0x00,0xc5,0xfa,0x7f,0x44,0x24,0x38,0xc5,0xfa,0x6f,0x84,0x24,0xd0,0x00,0x00,0x00,0xc5,0xfa,0x7f,0x44,0x24,0x48,0x48,0x8d,0x54,0x24,0x28,0x49,0xbb,0xf0,0x32,0x02,0xda,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0x66,0x4b,0x22,0xfa,0x48,0x89,0x84,0x24,0x98,0x00,0x00,0x00,0x48,0x89,0xbc,0x24,0xa0,0x00,0x00,0x00,0x48,0x8b,0x8c,0x24,0x98,0x00,0x00,0x00,0x49,0xbb,0xf8,0x32,0x02,0xda,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0x44,0x4b,0x22,0xfa,0xb9,0x00,0x41,0x00,0x00,0xe8,0x92,0x31,0x52,0xfe,0x48,0x89,0x84,0x24,0xe0,0x00,0x00,0x00,0x48,0x8b,0xd6,0x48,0xb9,0x88,0xb6,0xbd,0xdc,0xfd,0x7f,0x00,0x00,0xe8,0x68,0xec,0x51,0xfe,0x8b,0x10,0x48,0x8b,0x50,0x10,0x48,0xb9,0x38,0x9a,0x0b,0xdd,0xfd,0x7f,0x00,0x00,0xe8,0x53,0xec,0x51,0xfe,0x48,0x89,0x84,0x24,0xa8,0x00,0x00,0x00,0x48,0x8b,0xfb,0x48,0x8d,0xb4,0x24,0x98,0x00,0x00,0x00,0xe8,0x3b,0x81,0xe6,0x59,0xe8,0x36,0x81,0xe6,0x59,0xe8,0x31,0x81,0xe6,0x59,0xe8,0x2c,0x81,0xe6,0x59,0xe8,0x27,0x81,0xe6,0x59,0xe8,0x22,0x81,0xe6,0x59,0x48,0xa5,0x48,0xa5,0x48,0xa5,0xe8,0x17,0x81,0xe6,0x59,0x48,0x8b,0xc3,0x48,0x81,0xc4,0xe8,0x00,0x00,0x00,0x5b,0x5d,0x5e,0x5f,0x41,0x5c,0x41,0x5d,0x41,0x5e,0x41,0x5f,0xc3};

        public static ReadOnlySpan<byte> ResCapture_ᐤIWfShellᐤ  =>  new byte[31]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xd1,0x48,0xb9,0xe0,0x11,0xc3,0xdc,0xfd,0x7f,0x00,0x00,0x48,0xb8,0x40,0xd4,0x31,0xde,0xfd,0x7f,0x00,0x00,0x48,0xff,0xe0};

        public static ReadOnlySpan<byte> HostCapture_ᐤIWfShellᐤ  =>  new byte[31]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xd1,0x48,0xb9,0xa0,0xe1,0xc6,0xdc,0xfd,0x7f,0x00,0x00,0x48,0xb8,0x40,0xd4,0x31,0xde,0xfd,0x7f,0x00,0x00,0x48,0xff,0xe0};

        public static ReadOnlySpan<byte> HostDecoder_ᐤIWfShellㆍIAsmDecoderᐤ  =>  new byte[662]{0x41,0x57,0x41,0x56,0x41,0x55,0x41,0x54,0x57,0x56,0x55,0x53,0x48,0x81,0xec,0xd8,0x00,0x00,0x00,0xc5,0xf8,0x77,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x28,0xb9,0x2c,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x8b,0xd9,0x48,0x8b,0xf2,0x49,0x8b,0xf8,0x48,0x8d,0x94,0x24,0x98,0x00,0x00,0x00,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x02,0xc5,0xfa,0x7f,0x42,0x10,0xc5,0xfa,0x7f,0x42,0x20,0xc5,0xfa,0x7f,0x42,0x30,0x33,0xd2,0x48,0x89,0x94,0x24,0x90,0x00,0x00,0x00,0x48,0xba,0xf0,0x3e,0xe0,0x13,0xd3,0x01,0x00,0x00,0x48,0x8b,0x12,0x48,0x8d,0x8c,0x24,0x90,0x00,0x00,0x00,0xe8,0x1a,0xaf,0x3a,0xfd,0x48,0x8b,0xac,0x24,0x90,0x00,0x00,0x00,0x48,0xb9,0x10,0x58,0x4d,0xdd,0xfd,0x7f,0x00,0x00,0xe8,0xf3,0x8d,0xe6,0x59,0x4c,0x8b,0xf0,0x48,0xb9,0x10,0x58,0x4d,0xdd,0xfd,0x7f,0x00,0x00,0xe8,0x81,0xcb,0xdf,0x59,0x4c,0x8b,0xf8,0x49,0x8d,0x4e,0x08,0x49,0x8b,0xd7,0xe8,0x12,0x7f,0xe6,0x59,0x4d,0x8b,0x66,0x08,0x49,0x8b,0xcc,0x49,0x8b,0x04,0x24,0x48,0x8b,0x40,0x50,0xff,0x50,0x38,0x4c,0x8b,0xe8,0x49,0x8b,0xcc,0x49,0x8b,0x04,0x24,0x48,0x8b,0x40,0x50,0xff,0x50,0x08,0x44,0x8b,0xe0,0x49,0x8d,0x46,0x10,0x48,0x89,0x44,0x24,0x20,0x48,0x8d,0x08,0x49,0x8b,0xd5,0xe8,0xa8,0x7e,0xe6,0x59,0x4c,0x8b,0x6c,0x24,0x20,0x45,0x89,0x65,0x08,0x49,0x8d,0x4e,0x20,0x49,0x8b,0xd7,0xe8,0xc3,0x7e,0xe6,0x59,0x49,0x8d,0x4e,0x28,0x48,0x8b,0xd5,0xe8,0xb7,0x7e,0xe6,0x59,0x49,0x8b,0x4e,0x28,0x48,0x89,0x4c,0x24,0x58,0x48,0x8d,0x4c,0x24,0x58,0xe8,0x14,0xc3,0x3a,0xfd,0x48,0x8b,0xe8,0x48,0xb9,0xf0,0xa1,0x32,0xda,0xfd,0x7f,0x00,0x00,0xe8,0x52,0x8d,0xe6,0x59,0x4c,0x8b,0xf8,0x4d,0x8b,0x66,0x08,0x49,0x8b,0xce,0x48,0xba,0x40,0x59,0x4d,0xdd,0xfd,0x7f,0x00,0x00,0x49,0xb8,0x00,0xee,0xec,0xdc,0xfd,0x7f,0x00,0x00,0xe8,0x5f,0x76,0xd4,0x59,0x4c,0x8b,0xe8,0x49,0x8d,0x4f,0x08,0x49,0x8b,0xd6,0xe8,0x60,0x7e,0xe6,0x59,0x4d,0x89,0x6f,0x18,0x48,0x8d,0x4c,0x24,0x60,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0xc5,0xfa,0x7f,0x41,0x10,0xc5,0xfa,0x7f,0x41,0x20,0x48,0x8d,0x4c,0x24,0x70,0x48,0x89,0x29,0x33,0xc0,0x89,0x41,0x08,0x4c,0x89,0x64,0x24,0x60,0x49,0x8b,0xcc,0x49,0x8b,0x04,0x24,0x48,0x8b,0x40,0x40,0xff,0x50,0x30,0x48,0x85,0xc0,0x75,0x04,0x33,0xc9,0xeb,0x07,0x48,0x8d,0x48,0x0c,0x8b,0x50,0x08,0x8b,0x50,0x08,0xd1,0xe2,0x8b,0xd2,0xc4,0xe1,0xf9,0x6e,0xc1,0xc4,0xe3,0xf9,0x22,0xc2,0x01,0x48,0x8d,0x8c,0x24,0x80,0x00,0x00,0x00,0xc5,0xf9,0x11,0x01,0x4c,0x89,0x7c,0x24,0x68,0xc5,0xfa,0x6f,0x44,0x24,0x60,0xc5,0xfa,0x7f,0x84,0x24,0xa8,0x00,0x00,0x00,0xc5,0xfa,0x6f,0x44,0x24,0x70,0xc5,0xfa,0x7f,0x84,0x24,0xb8,0x00,0x00,0x00,0xc5,0xfa,0x6f,0x84,0x24,0x80,0x00,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0xc8,0x00,0x00,0x00,0x48,0x8b,0xce,0xc5,0xfa,0x6f,0x84,0x24,0xa8,0x00,0x00,0x00,0xc5,0xfa,0x7f,0x44,0x24,0x28,0xc5,0xfa,0x6f,0x84,0x24,0xb8,0x00,0x00,0x00,0xc5,0xfa,0x7f,0x44,0x24,0x38,0xc5,0xfa,0x6f,0x84,0x24,0xc8,0x00,0x00,0x00,0xc5,0xfa,0x7f,0x44,0x24,0x48,0x48,0x8d,0x54,0x24,0x28,0x49,0xbb,0x00,0x33,0x02,0xda,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0xdb,0x47,0x22,0xfa,0x48,0x89,0x84,0x24,0x98,0x00,0x00,0x00,0x48,0x89,0xbc,0x24,0xa0,0x00,0x00,0x00,0x48,0x8b,0xfb,0x48,0x8d,0xb4,0x24,0x98,0x00,0x00,0x00,0xe8,0xfb,0x7d,0xe6,0x59,0xe8,0xf6,0x7d,0xe6,0x59,0xe8,0xf1,0x7d,0xe6,0x59,0xe8,0xec,0x7d,0xe6,0x59,0xe8,0xe7,0x7d,0xe6,0x59,0x48,0xa5,0x48,0xa5,0x48,0xa5,0x48,0x8b,0xc3,0x48,0x81,0xc4,0xd8,0x00,0x00,0x00,0x5b,0x5d,0x5e,0x5f,0x41,0x5c,0x41,0x5d,0x41,0x5e,0x41,0x5f,0xc3};

        public static ReadOnlySpan<byte> HostEmitter_ᐤIWfShellㆍIAsmContextᐤ  =>  new byte[121]{0x57,0x56,0x53,0x48,0x83,0xec,0x60,0xc5,0xf8,0x77,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x20,0xb9,0x10,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x8b,0xd9,0x48,0x8d,0x4c,0x24,0x20,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0xc5,0xfa,0x7f,0x41,0x10,0xc5,0xfa,0x7f,0x41,0x20,0xc5,0xfa,0x7f,0x41,0x30,0x48,0x8d,0x4c,0x24,0x20,0xe8,0x89,0xfe,0x53,0xfe,0x48,0x8b,0xfb,0x48,0x8d,0x74,0x24,0x20,0xe8,0x3c,0x7d,0xe6,0x59,0xe8,0x37,0x7d,0xe6,0x59,0xe8,0x32,0x7d,0xe6,0x59,0xe8,0x2d,0x7d,0xe6,0x59,0xe8,0x28,0x7d,0xe6,0x59,0x48,0xa5,0x48,0xa5,0x48,0xa5,0x48,0x8b,0xc3,0x48,0x83,0xc4,0x60,0x5b,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> ApiProcessor_ᐤIWfShellᐤ  =>  new byte[252]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xec,0x30,0x33,0xc0,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x44,0x24,0x28,0x48,0x8b,0xf1,0x48,0xb9,0x30,0xe8,0x00,0xe0,0xfd,0x7f,0x00,0x00,0xe8,0xe8,0x86,0xe6,0x59,0x48,0x8b,0xf8,0x48,0x8d,0x4f,0x08,0x48,0x8b,0xd7,0xe8,0x19,0x78,0xe6,0x59,0x48,0xba,0xe0,0xe3,0x01,0xda,0xfd,0x7f,0x00,0x00,0x48,0x89,0x57,0x18,0x48,0xba,0xa8,0xb1,0xdf,0xdf,0xfd,0x7f,0x00,0x00,0x48,0x89,0x57,0x20,0xba,0x01,0x06,0x00,0x00,0x48,0xb9,0xb0,0xd9,0x00,0xe0,0xfd,0x7f,0x00,0x00,0xe8,0xd9,0x87,0xe6,0x59,0x48,0x8b,0xd8,0x48,0x8d,0x43,0x10,0x8b,0x53,0x08,0x48,0x89,0x44,0x24,0x20,0x89,0x54,0x24,0x28,0xe8,0x91,0xbe,0xff,0xff,0x48,0x8b,0xd0,0x48,0x8d,0x4c,0x24,0x20,0xe8,0xfc,0xfb,0xff,0xff,0x48,0xb9,0x90,0xdf,0x00,0xe0,0xfd,0x7f,0x00,0x00,0xe8,0x75,0x86,0xe6,0x59,0x48,0x8b,0xe8,0x4c,0x8d,0x75,0x08,0x49,0x8d,0x0e,0x48,0x8b,0xd7,0xe8,0x73,0x77,0xe6,0x59,0x49,0x8d,0x4e,0x08,0x48,0x8b,0xd3,0xe8,0x67,0x77,0xe6,0x59,0x48,0xb9,0xd8,0xfd,0xc0,0xdc,0xfd,0x7f,0x00,0x00,0xe8,0x48,0x86,0xe6,0x59,0x48,0x8b,0xf8,0x48,0x8d,0x5f,0x08,0x48,0x8d,0x0b,0x48,0x8b,0xd6,0xe8,0x46,0x77,0xe6,0x59,0x48,0x8d,0x4b,0x08,0x48,0x8b,0xd5,0xe8,0x3a,0x77,0xe6,0x59,0x48,0x8b,0xcf,0xe8,0xca,0xba,0x85,0xfc,0x48,0x8b,0xc7,0x48,0x83,0xc4,0x30,0x5b,0x5d,0x5e,0x5f,0x41,0x5e,0xc3};

        public static ReadOnlySpan<byte> formatter_ᐤAsmFormatConfigᕀinᐤ  =>  new byte[455]{0x55,0x57,0x56,0x53,0x48,0x81,0xec,0x48,0x01,0x00,0x00,0xc5,0xf8,0x77,0x48,0x8d,0xac,0x24,0x60,0x01,0x00,0x00,0x48,0x8b,0xf1,0x48,0x8d,0xbd,0xf0,0xfe,0xff,0xff,0xb9,0x3e,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x33,0xd2,0x4c,0x8d,0x45,0xc0,0xc5,0xf8,0x57,0xc0,0xc4,0xc1,0x7a,0x7f,0x00,0xc4,0xc1,0x7a,0x7f,0x40,0x10,0x49,0x89,0x50,0x20,0xc5,0xfa,0x6f,0x01,0xc5,0xfa,0x7f,0x45,0x80,0xc5,0xfa,0x6f,0x41,0x10,0xc5,0xfa,0x7f,0x45,0x90,0xc5,0xfa,0x6f,0x45,0x80,0xc5,0xfa,0x7f,0x45,0xc8,0xc5,0xfa,0x6f,0x45,0x90,0xc5,0xfa,0x7f,0x45,0xd8,0xc6,0x45,0xc0,0x01,0x48,0x8d,0x4d,0xa0,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0xc5,0xfa,0x7f,0x41,0x10,0xc5,0xfa,0x6f,0x45,0xc0,0xc5,0xfa,0x7f,0x85,0x58,0xff,0xff,0xff,0xc5,0xfa,0x6f,0x45,0xd0,0xc5,0xfa,0x7f,0x85,0x68,0xff,0xff,0xff,0x48,0x8b,0x4d,0xe0,0x48,0x89,0x8d,0x78,0xff,0xff,0xff,0xc5,0xfa,0x6f,0x85,0x58,0xff,0xff,0xff,0xc5,0xfa,0x7f,0x85,0x30,0xff,0xff,0xff,0xc5,0xfa,0x6f,0x85,0x68,0xff,0xff,0xff,0xc5,0xfa,0x7f,0x85,0x40,0xff,0xff,0xff,0x48,0x8b,0x8d,0x78,0xff,0xff,0xff,0x48,0x89,0x8d,0x50,0xff,0xff,0xff,0x48,0x8d,0x7d,0xa0,0x80,0xbd,0x30,0xff,0xff,0xff,0x00,0x0f,0x85,0x79,0x00,0x00,0x00,0x48,0x8d,0x8d,0xf0,0xfe,0xff,0xff,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0xc5,0xfa,0x7f,0x41,0x10,0x33,0xc9,0x89,0x4c,0x24,0x20,0xc7,0x44,0x24,0x28,0x28,0x00,0x00,0x00,0xc7,0x44,0x24,0x30,0x01,0x00,0x00,0x00,0xc7,0x44,0x24,0x38,0x01,0x00,0x00,0x00,0xc7,0x44,0x24,0x40,0x78,0x00,0x00,0x00,0x48,0x8d,0x8d,0xf0,0xfe,0xff,0xff,0xba,0x01,0x00,0x00,0x00,0x41,0xb8,0x01,0x00,0x00,0x00,0x41,0xb9,0x01,0x00,0x00,0x00,0xe8,0x94,0x01,0x54,0xfe,0xc5,0xfa,0x6f,0x85,0xf0,0xfe,0xff,0xff,0xc5,0xfa,0x7f,0x85,0x10,0xff,0xff,0xff,0xc5,0xfa,0x6f,0x85,0x00,0xff,0xff,0xff,0xc5,0xfa,0x7f,0x85,0x20,0xff,0xff,0xff,0xeb,0x20,0xc5,0xfa,0x6f,0x85,0x38,0xff,0xff,0xff,0xc5,0xfa,0x7f,0x85,0x10,0xff,0xff,0xff,0xc5,0xfa,0x6f,0x85,0x48,0xff,0xff,0xff,0xc5,0xfa,0x7f,0x85,0x20,0xff,0xff,0xff,0x48,0x8d,0xb5,0x10,0xff,0xff,0xff,0xe8,0x46,0x76,0xe6,0x59,0xe8,0x41,0x76,0xe6,0x59,0x48,0xa5,0x48,0xa5,0x48,0xb9,0x40,0xf6,0xc6,0xdc,0xfd,0x7f,0x00,0x00,0xe8,0x4e,0x84,0xe6,0x59,0x48,0x8b,0xd8,0x48,0x8d,0x7b,0x08,0x48,0x8d,0x75,0xa0,0xe8,0x1e,0x76,0xe6,0x59,0xe8,0x19,0x76,0xe6,0x59,0x48,0xa5,0x48,0xa5,0x48,0x8b,0xc3,0x48,0x8d,0x65,0xe8,0x5b,0x5e,0x5f,0x5d,0xc3};

        public static ReadOnlySpan<byte> exchange_ᐤBufferTokenᐤ  =>  new byte[71]{0x48,0x83,0xec,0x38,0xc5,0xf8,0x77,0x48,0x8d,0x44,0x24,0x28,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x00,0x48,0x8b,0x01,0x8b,0x49,0x08,0x48,0x8d,0x54,0x24,0x28,0x48,0x89,0x02,0x89,0x4a,0x08,0x48,0xb9,0xa8,0x50,0xc7,0xdc,0xfd,0x7f,0x00,0x00,0xe8,0xac,0x83,0xe6,0x59,0x48,0x8d,0x50,0x08,0xc5,0xfa,0x6f,0x44,0x24,0x28,0xc5,0xfa,0x7f,0x02,0x48,0x83,0xc4,0x38,0xc3};

        public static ReadOnlySpan<byte> Formatter_ᐤAsmFormatConfigᕀinᐤ  =>  new byte[455]{0x55,0x57,0x56,0x53,0x48,0x81,0xec,0x48,0x01,0x00,0x00,0xc5,0xf8,0x77,0x48,0x8d,0xac,0x24,0x60,0x01,0x00,0x00,0x48,0x8b,0xf1,0x48,0x8d,0xbd,0xf0,0xfe,0xff,0xff,0xb9,0x3e,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x33,0xc9,0x4c,0x8d,0x45,0xc0,0xc5,0xf8,0x57,0xc0,0xc4,0xc1,0x7a,0x7f,0x00,0xc4,0xc1,0x7a,0x7f,0x40,0x10,0x49,0x89,0x48,0x20,0xc5,0xfa,0x6f,0x02,0xc5,0xfa,0x7f,0x45,0x80,0xc5,0xfa,0x6f,0x42,0x10,0xc5,0xfa,0x7f,0x45,0x90,0xc5,0xfa,0x6f,0x45,0x80,0xc5,0xfa,0x7f,0x45,0xc8,0xc5,0xfa,0x6f,0x45,0x90,0xc5,0xfa,0x7f,0x45,0xd8,0xc6,0x45,0xc0,0x01,0x48,0x8d,0x4d,0xa0,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0xc5,0xfa,0x7f,0x41,0x10,0xc5,0xfa,0x6f,0x45,0xc0,0xc5,0xfa,0x7f,0x85,0x58,0xff,0xff,0xff,0xc5,0xfa,0x6f,0x45,0xd0,0xc5,0xfa,0x7f,0x85,0x68,0xff,0xff,0xff,0x48,0x8b,0x4d,0xe0,0x48,0x89,0x8d,0x78,0xff,0xff,0xff,0xc5,0xfa,0x6f,0x85,0x58,0xff,0xff,0xff,0xc5,0xfa,0x7f,0x85,0x30,0xff,0xff,0xff,0xc5,0xfa,0x6f,0x85,0x68,0xff,0xff,0xff,0xc5,0xfa,0x7f,0x85,0x40,0xff,0xff,0xff,0x48,0x8b,0x8d,0x78,0xff,0xff,0xff,0x48,0x89,0x8d,0x50,0xff,0xff,0xff,0x48,0x8d,0x7d,0xa0,0x80,0xbd,0x30,0xff,0xff,0xff,0x00,0x0f,0x85,0x79,0x00,0x00,0x00,0x48,0x8d,0x8d,0xf0,0xfe,0xff,0xff,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0xc5,0xfa,0x7f,0x41,0x10,0x33,0xc9,0x89,0x4c,0x24,0x20,0xc7,0x44,0x24,0x28,0x28,0x00,0x00,0x00,0xc7,0x44,0x24,0x30,0x01,0x00,0x00,0x00,0xc7,0x44,0x24,0x38,0x01,0x00,0x00,0x00,0xc7,0x44,0x24,0x40,0x78,0x00,0x00,0x00,0x48,0x8d,0x8d,0xf0,0xfe,0xff,0xff,0xba,0x01,0x00,0x00,0x00,0x41,0xb8,0x01,0x00,0x00,0x00,0x41,0xb9,0x01,0x00,0x00,0x00,0xe8,0x24,0xff,0x53,0xfe,0xc5,0xfa,0x6f,0x85,0xf0,0xfe,0xff,0xff,0xc5,0xfa,0x7f,0x85,0x10,0xff,0xff,0xff,0xc5,0xfa,0x6f,0x85,0x00,0xff,0xff,0xff,0xc5,0xfa,0x7f,0x85,0x20,0xff,0xff,0xff,0xeb,0x20,0xc5,0xfa,0x6f,0x85,0x38,0xff,0xff,0xff,0xc5,0xfa,0x7f,0x85,0x10,0xff,0xff,0xff,0xc5,0xfa,0x6f,0x85,0x48,0xff,0xff,0xff,0xc5,0xfa,0x7f,0x85,0x20,0xff,0xff,0xff,0x48,0x8d,0xb5,0x10,0xff,0xff,0xff,0xe8,0xd6,0x73,0xe6,0x59,0xe8,0xd1,0x73,0xe6,0x59,0x48,0xa5,0x48,0xa5,0x48,0xb9,0x40,0xf6,0xc6,0xdc,0xfd,0x7f,0x00,0x00,0xe8,0xde,0x81,0xe6,0x59,0x48,0x8b,0xd8,0x48,0x8d,0x7b,0x08,0x48,0x8d,0x75,0xa0,0xe8,0xae,0x73,0xe6,0x59,0xe8,0xa9,0x73,0xe6,0x59,0x48,0xa5,0x48,0xa5,0x48,0x8b,0xc3,0x48,0x8d,0x65,0xe8,0x5b,0x5e,0x5f,0x5d,0xc3};

        public static ReadOnlySpan<byte> AsmWriter_ᐤFilePathㆍAsmFormatConfigᕀinᐤ  =>  new byte[660]{0x55,0x41,0x56,0x57,0x56,0x53,0x48,0x81,0xec,0x60,0x01,0x00,0x00,0xc5,0xf8,0x77,0x48,0x8d,0xac,0x24,0x80,0x01,0x00,0x00,0x48,0x8b,0xf1,0x48,0x8d,0xbd,0xc8,0xfe,0xff,0xff,0xb9,0x46,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x8b,0xda,0x33,0xc9,0x48,0x8d,0x55,0xa0,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x02,0xc5,0xfa,0x7f,0x42,0x10,0x48,0x89,0x4a,0x20,0xc4,0xc1,0x7a,0x6f,0x00,0xc5,0xfa,0x7f,0x85,0x60,0xff,0xff,0xff,0xc4,0xc1,0x7a,0x6f,0x40,0x10,0xc5,0xfa,0x7f,0x85,0x70,0xff,0xff,0xff,0xc5,0xfa,0x6f,0x85,0x60,0xff,0xff,0xff,0xc5,0xfa,0x7f,0x45,0xa8,0xc5,0xfa,0x6f,0x85,0x70,0xff,0xff,0xff,0xc5,0xfa,0x7f,0x45,0xb8,0xc6,0x45,0xa0,0x01,0x48,0x8d,0x4d,0x80,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0xc5,0xfa,0x7f,0x41,0x10,0xc5,0xfa,0x6f,0x45,0xa0,0xc5,0xfa,0x7f,0x85,0x38,0xff,0xff,0xff,0xc5,0xfa,0x6f,0x45,0xb0,0xc5,0xfa,0x7f,0x85,0x48,0xff,0xff,0xff,0x48,0x8b,0x4d,0xc0,0x48,0x89,0x8d,0x58,0xff,0xff,0xff,0xc5,0xfa,0x6f,0x85,0x38,0xff,0xff,0xff,0xc5,0xfa,0x7f,0x85,0x10,0xff,0xff,0xff,0xc5,0xfa,0x6f,0x85,0x48,0xff,0xff,0xff,0xc5,0xfa,0x7f,0x85,0x20,0xff,0xff,0xff,0x48,0x8b,0x8d,0x58,0xff,0xff,0xff,0x48,0x89,0x8d,0x30,0xff,0xff,0xff,0x48,0x8d,0x7d,0x80,0x80,0xbd,0x10,0xff,0xff,0xff,0x00,0x0f,0x85,0x79,0x00,0x00,0x00,0x48,0x8d,0x8d,0xd0,0xfe,0xff,0xff,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0xc5,0xfa,0x7f,0x41,0x10,0x33,0xc9,0x89,0x4c,0x24,0x20,0xc7,0x44,0x24,0x28,0x28,0x00,0x00,0x00,0xc7,0x44,0x24,0x30,0x01,0x00,0x00,0x00,0xc7,0x44,0x24,0x38,0x01,0x00,0x00,0x00,0xc7,0x44,0x24,0x40,0x78,0x00,0x00,0x00,0x48,0x8d,0x8d,0xd0,0xfe,0xff,0xff,0xba,0x01,0x00,0x00,0x00,0x41,0xb8,0x01,0x00,0x00,0x00,0x41,0xb9,0x01,0x00,0x00,0x00,0xe8,0x03,0xfd,0x53,0xfe,0xc5,0xfa,0x6f,0x85,0xd0,0xfe,0xff,0xff,0xc5,0xfa,0x7f,0x85,0xf0,0xfe,0xff,0xff,0xc5,0xfa,0x6f,0x85,0xe0,0xfe,0xff,0xff,0xc5,0xfa,0x7f,0x85,0x00,0xff,0xff,0xff,0xeb,0x20,0xc5,0xfa,0x6f,0x85,0x18,0xff,0xff,0xff,0xc5,0xfa,0x7f,0x85,0xf0,0xfe,0xff,0xff,0xc5,0xfa,0x6f,0x85,0x28,0xff,0xff,0xff,0xc5,0xfa,0x7f,0x85,0x00,0xff,0xff,0xff,0x48,0x8d,0xb5,0xf0,0xfe,0xff,0xff,0xe8,0xb5,0x71,0xe6,0x59,0xe8,0xb0,0x71,0xe6,0x59,0x48,0xa5,0x48,0xa5,0x48,0xb9,0x40,0xf6,0xc6,0xdc,0xfd,0x7f,0x00,0x00,0xe8,0xbd,0x7f,0xe6,0x59,0x4c,0x8b,0xf0,0x49,0x8d,0x7e,0x08,0x48,0x8d,0x75,0x80,0xe8,0x8d,0x71,0xe6,0x59,0xe8,0x88,0x71,0xe6,0x59,0x48,0xa5,0x48,0xa5,0x33,0xc9,0x48,0x8d,0x45,0xc8,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x00,0x48,0x89,0x48,0x10,0x48,0x8d,0x4d,0xd8,0x48,0x89,0x19,0x4c,0x89,0x75,0xd0,0x48,0x8b,0xcb,0x33,0xc0,0x48,0x89,0x85,0xc8,0xfe,0xff,0xff,0xe8,0xb6,0x66,0x4f,0xfe,0x48,0x89,0x85,0xc8,0xfe,0xff,0xff,0x48,0xb9,0x50,0x34,0xc7,0xdc,0xfd,0x7f,0x00,0x00,0xe8,0x60,0x7f,0xe6,0x59,0x48,0x8b,0xf0,0x48,0x8d,0x8d,0xc8,0xfe,0xff,0xff,0xe8,0x01,0xfe,0x4e,0xfe,0x48,0x8b,0xc8,0x49,0xb8,0xa0,0x22,0xc6,0x13,0xd3,0x01,0x00,0x00,0x49,0x8b,0x38,0x4c,0x8b,0xc7,0x33,0xd2,0x41,0xb9,0x00,0x04,0x00,0x00,0xe8,0xe1,0x1a,0xc2,0x57,0x48,0x8b,0xd0,0x33,0xc9,0x89,0x4c,0x24,0x20,0x48,0x8b,0xce,0x4c,0x8b,0xc7,0x41,0xb9,0x00,0x04,0x00,0x00,0xe8,0xc7,0x70,0xc0,0x57,0x48,0x89,0x75,0xc8,0x48,0xb9,0xe8,0x37,0xc7,0xdc,0xfd,0x7f,0x00,0x00,0xe8,0x04,0x7f,0xe6,0x59,0x48,0x8b,0xd8,0x48,0x8d,0x7b,0x08,0x48,0x8d,0x75,0xc8,0xe8,0xd4,0x70,0xe6,0x59,0xe8,0xcf,0x70,0xe6,0x59,0xe8,0xca,0x70,0xe6,0x59,0x48,0x8b,0xc3,0x48,0x8d,0x65,0xe0,0x5b,0x5e,0x5f,0x41,0x5e,0x5d,0xc3};

    }
}
