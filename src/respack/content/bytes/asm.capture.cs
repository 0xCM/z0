//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
// Generated   : 2021-02-26 14:33:07 -06:00
//-----------------------------------------------------------------------------
namespace Z0.ByteCode
{
    using System;
    using System.Runtime.CompilerServices;


    public static class asm_capture
    {
        public static ReadOnlySpan<byte> run_ᐤarray_stringᐤ  =>  new byte[848]{0x55,0x41,0x56,0x57,0x56,0x53,0x48,0x81,0xec,0xf0,0x00,0x00,0x00,0xc5,0xf8,0x77,0x48,0x8d,0xac,0x24,0x10,0x01,0x00,0x00,0x48,0x8b,0xf1,0x48,0x8d,0xbd,0x18,0xff,0xff,0xff,0xb9,0x32,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x89,0xa5,0x10,0xff,0xff,0xff,0xba,0x01,0x00,0x00,0x00,0xe8,0x29,0xf1,0xff,0xff,0x48,0x8b,0xc8,0xe8,0x69,0xc5,0xff,0xff,0x48,0x89,0x85,0x18,0xff,0xff,0xff,0xb9,0x05,0x00,0x00,0x00,0xe8,0x08,0xf4,0xff,0xff,0x33,0xc9,0x48,0x89,0x8d,0x78,0xff,0xff,0xff,0x48,0x89,0x4d,0x80,0x48,0x89,0x8d,0x78,0xff,0xff,0xff,0x48,0x89,0x4d,0x80,0x48,0x8d,0x8d,0x78,0xff,0xff,0xff,0x48,0x8b,0xd0,0x49,0xb8,0x4f,0x81,0x67,0xf7,0x7e,0x7b,0x05,0x14,0xe8,0x7f,0xf5,0xff,0xff,0x48,0xb9,0x40,0x18,0x35,0xda,0xfd,0x7f,0x00,0x00,0xe8,0xa8,0x39,0xb1,0x5f,0x48,0x8b,0xf0,0x48,0x8d,0x4e,0x08,0x48,0x8b,0x85,0x78,0xff,0xff,0xff,0x48,0x89,0x01,0x48,0x8b,0x45,0x80,0x48,0x89,0x41,0x08,0x48,0xb9,0x28,0x39,0x35,0xda,0xfd,0x7f,0x00,0x00,0xe8,0x80,0x39,0xb1,0x5f,0x48,0x8b,0xf8,0x48,0x8d,0x4f,0x08,0x48,0x8b,0xd6,0xe8,0xb1,0x2a,0xb1,0x5f,0x48,0x8b,0xd6,0xbe,0x01,0x00,0x00,0x00,0x48,0x8d,0x5f,0x10,0x48,0x8d,0x0b,0xe8,0x6d,0x2a,0xb1,0x5f,0x40,0x88,0x73,0x08,0x48,0x8b,0x8d,0x18,0xff,0xff,0xff,0x48,0x8b,0xd7,0xe8,0x52,0xed,0xff,0xff,0x48,0x8b,0xf0,0x48,0xb9,0x18,0x0f,0x35,0xda,0xfd,0x7f,0x00,0x00,0xe8,0x38,0x39,0xb1,0x5f,0x48,0x8b,0xf8,0x48,0x8d,0x4f,0x08,0x48,0x8b,0xd6,0xe8,0x69,0x2a,0xb1,0x5f,0x48,0x8d,0x4f,0x10,0x48,0x8b,0x95,0x18,0xff,0xff,0xff,0xe8,0x59,0x2a,0xb1,0x5f,0x48,0x8b,0xce,0x49,0xbb,0x30,0x00,0x02,0xda,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0xd4,0xc1,0xec,0xff,0x48,0x8d,0x4f,0x18,0x48,0x8b,0xd0,0xe8,0x38,0x2a,0xb1,0x5f,0x48,0x8b,0xce,0x49,0xbb,0x38,0x00,0x02,0xda,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0xbb,0xc1,0xec,0xff,0x48,0x8d,0x4f,0x20,0x48,0x8b,0xd0,0xe8,0x17,0x2a,0xb1,0x5f,0x48,0xb9,0x50,0x4c,0x35,0xda,0xfd,0x7f,0x00,0x00,0xe8,0xc8,0x38,0xb1,0x5f,0x48,0x8b,0xd8,0x48,0x8b,0xce,0x49,0xbb,0x40,0x00,0x02,0xda,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0x90,0xc1,0xec,0xff,0x4c,0x8b,0xf0,0x48,0x8d,0x4b,0x08,0x48,0x8b,0xd7,0xe8,0xe1,0x29,0xb1,0x5f,0x48,0xb9,0xd0,0x30,0x15,0xda,0xfd,0x7f,0x00,0x00,0x48,0x89,0x4b,0x18,0x49,0x8b,0xce,0x48,0x8b,0xd3,0x49,0xbb,0x48,0x00,0x02,0xda,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0x63,0xc1,0xec,0xff,0x48,0x8b,0xce,0x49,0xbb,0x50,0x00,0x02,0xda,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0x56,0xc1,0xec,0xff,0x48,0x8d,0x4f,0x30,0x48,0x8b,0xd0,0xe8,0x9a,0x29,0xb1,0x5f,0x48,0x8b,0x77,0x10,0x48,0xb9,0x68,0x4e,0x35,0xda,0xfd,0x7f,0x00,0x00,0xe8,0x47,0x38,0xb1,0x5f,0x48,0x8b,0xd8,0x4c,0x8d,0x73,0x08,0x49,0x8d,0x0e,0x48,0x8b,0xd6,0xe8,0x45,0x29,0xb1,0x5f,0x49,0x8d,0x4e,0x08,0x48,0x8b,0xd7,0xe8,0x39,0x29,0xb1,0x5f,0x48,0x8d,0x4f,0x28,0x48,0x8b,0xd3,0xe8,0x5d,0x29,0xb1,0x5f,0x33,0xc9,0x48,0x8d,0x95,0x20,0xff,0xff,0xff,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x02,0xc5,0xfa,0x7f,0x42,0x10,0xc5,0xfa,0x7f,0x42,0x20,0xc5,0xfa,0x7f,0x42,0x30,0xc5,0xfa,0x7f,0x42,0x40,0x48,0x89,0x4a,0x50,0x48,0x8d,0x8d,0x20,0xff,0xff,0xff,0x48,0x8b,0x95,0x18,0xff,0xff,0xff,0x4c,0x8b,0xc7,0xe8,0x4e,0xe8,0xff,0xff,0x48,0x8d,0x7d,0x88,0x48,0x8d,0xb5,0x20,0xff,0xff,0xff,0xb9,0x0b,0x00,0x00,0x00,0xf3,0x48,0xa5,0x48,0x8d,0x4d,0x88,0xe8,0x4a,0xe8,0xff,0xff,0x90,0x48,0x8b,0x4d,0x88,0x49,0xbb,0x58,0x00,0x02,0xda,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0xa3,0xc0,0xec,0xff,0x90,0x48,0x83,0xbd,0x18,0xff,0xff,0xff,0x00,0x74,0x19,0x48,0x8b,0x8d,0x18,0xff,0xff,0xff,0x49,0xbb,0x28,0x00,0x02,0xda,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0x4f,0xc0,0xec,0xff,0x90,0x48,0x8d,0x65,0xe0,0x5b,0x5e,0x5f,0x41,0x5e,0x5d,0xc3,0x55,0x41,0x56,0x57,0x56,0x53,0x48,0x83,0xec,0x30,0xc5,0xf8,0x77,0x48,0x8b,0x69,0x20,0x48,0x89,0x6c,0x24,0x20,0x48,0x8d,0xad,0x10,0x01,0x00,0x00,0x48,0x8b,0x4d,0x88,0x49,0xbb,0x58,0x00,0x02,0xda,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0x40,0xc0,0xec,0xff,0x90,0x48,0x83,0xc4,0x30,0x5b,0x5e,0x5f,0x41,0x5e,0x5d,0xc3,0x55,0x41,0x56,0x57,0x56,0x53,0x48,0x83,0xec,0x30,0xc5,0xf8,0x77,0x48,0x8b,0x69,0x20,0x48,0x89,0x6c,0x24,0x20,0x48,0x8d,0xad,0x10,0x01,0x00,0x00,0x48,0x83,0xbd,0x18,0xff,0xff,0xff,0x00,0x74,0x19,0x48,0x8b,0x8d,0x18,0xff,0xff,0xff,0x49,0xbb,0x28,0x00,0x02,0xda,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0xc4,0xbf,0xec,0xff,0x90,0x48,0x83,0xc4,0x30,0x5b,0x5e,0x5f,0x41,0x5e,0x5d,0xc3};

        public static ReadOnlySpan<byte> quick_ᐤIWfShellㆍIAsmContextᐤ  =>  new byte[548]{0x41,0x57,0x41,0x56,0x41,0x55,0x41,0x54,0x57,0x56,0x55,0x53,0x48,0x81,0xec,0xf8,0x00,0x00,0x00,0xc5,0xf8,0x77,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x48,0xb9,0x2c,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x8b,0xd9,0x48,0x8b,0xfa,0x49,0x8b,0xf0,0x48,0x8b,0xce,0x49,0xbb,0xf8,0x31,0x02,0xda,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0xe0,0xe0,0x22,0xfa,0x8b,0xd0,0x48,0x8d,0x4c,0x24,0x48,0x41,0xb8,0x05,0x00,0x00,0x00,0x45,0x33,0xc9,0xe8,0x13,0x8e,0x33,0xfd,0x48,0x8d,0x4c,0x24,0x48,0x48,0x8b,0x29,0x44,0x8b,0x71,0x08,0xc5,0xfa,0x6f,0x44,0x24,0x48,0xc5,0xfa,0x7f,0x84,0x24,0xb8,0x00,0x00,0x00,0xc5,0xfa,0x6f,0x44,0x24,0x58,0xc5,0xfa,0x7f,0x84,0x24,0xc8,0x00,0x00,0x00,0xc5,0xfa,0x6f,0x44,0x24,0x68,0xc5,0xfa,0x7f,0x84,0x24,0xd8,0x00,0x00,0x00,0xc5,0xfa,0x6f,0x44,0x24,0x78,0xc5,0xfa,0x7f,0x84,0x24,0xe8,0x00,0x00,0x00,0x83,0xbc,0x24,0xe0,0x00,0x00,0x00,0x00,0x75,0x23,0x48,0xb9,0x20,0x00,0x11,0xda,0xfd,0x7f,0x00,0x00,0xba,0x70,0x01,0x00,0x00,0xe8,0x2d,0xe5,0xe3,0x59,0x48,0xba,0xf8,0x4a,0xc7,0x13,0xd3,0x01,0x00,0x00,0x4c,0x8b,0x3a,0xeb,0x3c,0x8b,0x94,0x24,0xe0,0x00,0x00,0x00,0x48,0x63,0xd2,0x48,0xb9,0x38,0x92,0xc3,0xdc,0xfd,0x7f,0x00,0x00,0xe8,0xd5,0x26,0xe7,0x59,0x4c,0x8b,0xf8,0x49,0x8d,0x4f,0x10,0x48,0x8b,0x94,0x24,0xd8,0x00,0x00,0x00,0x44,0x8b,0x84,0x24,0xe0,0x00,0x00,0x00,0x4d,0x63,0xc0,0x49,0xc1,0xe0,0x04,0xe8,0x42,0x42,0xc1,0x57,0x41,0x83,0x7f,0x08,0x03,0x0f,0x86,0x06,0x01,0x00,0x00,0x49,0x8d,0x4f,0x40,0x48,0x8b,0x01,0x8b,0x49,0x08,0x48,0x8d,0x54,0x24,0x38,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x02,0x48,0x8d,0x54,0x24,0x38,0x48,0x89,0x02,0x89,0x4a,0x08,0x48,0xb9,0xa8,0x50,0xc7,0xdc,0xfd,0x7f,0x00,0x00,0xe8,0x46,0x25,0xe7,0x59,0x4c,0x8b,0xe0,0x49,0x8d,0x4c,0x24,0x08,0xc5,0xfa,0x6f,0x44,0x24,0x38,0xc5,0xfa,0x7f,0x01,0x48,0x8b,0xce,0x49,0xbb,0x00,0x32,0x02,0xda,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0xbf,0xdf,0x22,0xfa,0x4c,0x8b,0xe8,0x48,0xb9,0xd0,0x51,0xc7,0xdc,0xfd,0x7f,0x00,0x00,0xe8,0x0d,0x25,0xe7,0x59,0x48,0x89,0x44,0x24,0x30,0x4c,0x8d,0x40,0x08,0x4c,0x89,0x44,0x24,0x28,0x49,0x8d,0x08,0x49,0x8b,0xd4,0xe8,0x04,0x16,0xe7,0x59,0x4c,0x8b,0x64,0x24,0x28,0x49,0x8d,0x4c,0x24,0x08,0x49,0x8b,0xd5,0xe8,0xf2,0x15,0xe7,0x59,0x48,0x89,0xbc,0x24,0x88,0x00,0x00,0x00,0x48,0x89,0xb4,0x24,0x90,0x00,0x00,0x00,0x48,0x8d,0x84,0x24,0xb0,0x00,0x00,0x00,0x4c,0x89,0x38,0x48,0x8b,0x74,0x24,0x30,0x48,0x89,0xb4,0x24,0x98,0x00,0x00,0x00,0x48,0x8d,0x84,0x24,0xa0,0x00,0x00,0x00,0x48,0x89,0x28,0x44,0x89,0x70,0x08,0x48,0x8b,0xfb,0x48,0x8d,0xb4,0x24,0x88,0x00,0x00,0x00,0xe8,0x7b,0x16,0xe7,0x59,0xe8,0x76,0x16,0xe7,0x59,0xe8,0x71,0x16,0xe7,0x59,0x48,0xa5,0x48,0xa5,0xe8,0x68,0x16,0xe7,0x59,0x48,0x8b,0xc3,0x48,0x81,0xc4,0xf8,0x00,0x00,0x00,0x5b,0x5d,0x5e,0x5f,0x41,0x5c,0x41,0x5d,0x41,0x5e,0x41,0x5f,0xc3,0xe8,0x2c,0xaa,0xf9,0x59};

        public static ReadOnlySpan<byte> runner_ᐤIWfShellㆍIAsmContextᐤ  =>  new byte[153]{0x57,0x56,0x53,0x48,0x81,0xec,0x80,0x00,0x00,0x00,0xc5,0xf8,0x77,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x28,0xb9,0x16,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x8b,0xd9,0x33,0xc9,0x48,0x8d,0x44,0x24,0x28,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x00,0xc5,0xfa,0x7f,0x40,0x10,0xc5,0xfa,0x7f,0x40,0x20,0xc5,0xfa,0x7f,0x40,0x30,0xc5,0xfa,0x7f,0x40,0x40,0x48,0x89,0x48,0x50,0x48,0x8d,0x4c,0x24,0x28,0xe8,0xab,0x7d,0x52,0xfe,0x48,0x8b,0xfb,0x48,0x8d,0x74,0x24,0x28,0xe8,0xae,0x15,0xe7,0x59,0xe8,0xa9,0x15,0xe7,0x59,0xe8,0xa4,0x15,0xe7,0x59,0xe8,0x9f,0x15,0xe7,0x59,0xe8,0x9a,0x15,0xe7,0x59,0xe8,0x95,0x15,0xe7,0x59,0xe8,0x90,0x15,0xe7,0x59,0xe8,0x8b,0x15,0xe7,0x59,0x48,0xa5,0x48,0xa5,0x48,0xa5,0x48,0x8b,0xc3,0x48,0x81,0xc4,0x80,0x00,0x00,0x00,0x5b,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> services_ᐤIWfShellㆍIAsmContextᐤ  =>  new byte[72]{0x57,0x56,0x55,0x53,0x48,0x83,0xec,0x28,0x48,0x8b,0xf1,0x48,0x8b,0xfa,0x48,0xb9,0x68,0x4e,0x35,0xda,0xfd,0x7f,0x00,0x00,0xe8,0x53,0x23,0xe7,0x59,0x48,0x8b,0xd8,0x48,0x8d,0x6b,0x08,0x48,0x8d,0x4d,0x00,0x48,0x8b,0xd6,0xe8,0x50,0x14,0xe7,0x59,0x48,0x8d,0x4d,0x08,0x48,0x8b,0xd7,0xe8,0x44,0x14,0xe7,0x59,0x48,0x8b,0xc3,0x48,0x83,0xc4,0x28,0x5b,0x5d,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> core_ᐤIWfShellㆍIAsmContextᐤ  =>  new byte[31]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xd1,0x48,0xb9,0x28,0x4c,0xc7,0xdc,0xfd,0x7f,0x00,0x00,0x48,0xb8,0x40,0xd4,0x31,0xde,0xfd,0x7f,0x00,0x00,0x48,0xff,0xe0};

        public static ReadOnlySpan<byte> emitter_ᐤIWfShellㆍIAsmContextᐤ  =>  new byte[136]{0x57,0x56,0x53,0x48,0x83,0xec,0x70,0xc5,0xf8,0x77,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x20,0xb9,0x14,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x8b,0xd9,0x48,0x8d,0x4c,0x24,0x20,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0xc5,0xfa,0x7f,0x41,0x10,0xc5,0xfa,0x7f,0x41,0x20,0xc5,0xfa,0x7f,0x41,0x30,0xc5,0xfa,0x7f,0x41,0x40,0x48,0x8d,0x4c,0x24,0x20,0xe8,0xd4,0xbf,0x53,0xfe,0x48,0x8b,0xfb,0x48,0x8d,0x74,0x24,0x20,0xe8,0x57,0x14,0xe7,0x59,0xe8,0x52,0x14,0xe7,0x59,0xe8,0x4d,0x14,0xe7,0x59,0xe8,0x48,0x14,0xe7,0x59,0xe8,0x43,0x14,0xe7,0x59,0xe8,0x3e,0x14,0xe7,0x59,0xe8,0x39,0x14,0xe7,0x59,0x48,0xa5,0x48,0xa5,0x48,0xa5,0x48,0x8b,0xc3,0x48,0x83,0xc4,0x70,0x5b,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> alt_ᐤIWfShellㆍIAsmContextᐤ  =>  new byte[31]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xd1,0x48,0xb9,0x88,0x87,0xc3,0xdc,0xfd,0x7f,0x00,0x00,0x48,0xb8,0x40,0xd4,0x31,0xde,0xfd,0x7f,0x00,0x00,0x48,0xff,0xe0};

        public static ReadOnlySpan<byte> exchange_ᐤIAsmContextᐤ  =>  new byte[116]{0x57,0x56,0x53,0x48,0x83,0xec,0x30,0xc5,0xf8,0x77,0x33,0xc0,0x48,0x89,0x44,0x24,0x20,0x48,0x8b,0xd9,0x48,0x8b,0xca,0x49,0xbb,0x08,0x32,0x02,0xda,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0x6f,0xdc,0x22,0xfa,0x48,0x63,0xd0,0x48,0xb9,0x18,0xea,0x11,0xda,0xfd,0x7f,0x00,0x00,0xe8,0xe5,0x22,0xe7,0x59,0x48,0x8d,0x50,0x10,0x8b,0x40,0x08,0x48,0x8d,0x4c,0x24,0x20,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0x48,0x8d,0x4c,0x24,0x20,0x48,0x89,0x11,0x89,0x41,0x08,0x48,0x8b,0xfb,0x48,0x8d,0x74,0x24,0x20,0xe8,0x69,0x13,0xe7,0x59,0x48,0xa5,0x48,0x8b,0xc3,0x48,0x83,0xc4,0x30,0x5b,0x5e,0x5f,0xc3};

    }
}
