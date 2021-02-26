//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
// Generated   : 2021-02-26 14:33:09 -06:00
//-----------------------------------------------------------------------------
namespace Z0.ByteCode
{
    using System;
    using System.Runtime.CompilerServices;


    public static class part_text_rules_parse
    {
        public static ReadOnlySpan<byte> before_ᐤstringㆍcharᐤ  =>  new byte[118]{0x57,0x56,0x0f,0x1f,0x00,0x41,0xb8,0xff,0xff,0xff,0xff,0x44,0x8b,0x49,0x08,0x33,0xf6,0x45,0x85,0xc9,0x7e,0x40,0x45,0x85,0xc9,0x0f,0x9d,0xc0,0x0f,0xb6,0xc0,0xa8,0x01,0x74,0x18,0x0f,0xb7,0xfa,0x48,0x63,0xc6,0x0f,0xb7,0x44,0x41,0x0c,0x3b,0xc7,0x74,0x21,0xff,0xc6,0x41,0x3b,0xf1,0x7c,0xed,0xeb,0x1b,0x48,0x63,0xc6,0x0f,0xb7,0x44,0x41,0x0c,0x0f,0xb7,0xfa,0x3b,0xc7,0x74,0x09,0xff,0xc6,0x41,0x3b,0xf1,0x7c,0xea,0xeb,0x03,0x44,0x8b,0xc6,0x41,0x83,0xf8,0xff,0x75,0x06,0x48,0x8b,0xc1,0x5e,0x5f,0xc3,0x33,0xd2,0x48,0xb8,0x40,0x7e,0x15,0xda,0xfd,0x7f,0x00,0x00,0x5e,0x5f,0x48,0xff,0xe0,0x00,0x19,0x02};

        public static ReadOnlySpan<byte> after_ᐤstringㆍcharᐤ  =>  new byte[122]{0x57,0x56,0x0f,0x1f,0x00,0x41,0xb8,0xff,0xff,0xff,0xff,0x44,0x8b,0x49,0x08,0x33,0xf6,0x45,0x85,0xc9,0x7e,0x40,0x45,0x85,0xc9,0x0f,0x9d,0xc0,0x0f,0xb6,0xc0,0xa8,0x01,0x74,0x18,0x0f,0xb7,0xfa,0x48,0x63,0xc6,0x0f,0xb7,0x44,0x41,0x0c,0x3b,0xc7,0x74,0x21,0xff,0xc6,0x41,0x3b,0xf1,0x7c,0xed,0xeb,0x1b,0x48,0x63,0xc6,0x0f,0xb7,0x44,0x41,0x0c,0x0f,0xb7,0xfa,0x3b,0xc7,0x74,0x09,0xff,0xc6,0x41,0x3b,0xf1,0x7c,0xea,0xeb,0x03,0x44,0x8b,0xc6,0x41,0x83,0xf8,0xff,0x75,0x06,0x48,0x8b,0xc1,0x5e,0x5f,0xc3,0x41,0x8d,0x50,0x01,0x48,0xb8,0x38,0x7e,0x15,0xda,0xfd,0x7f,0x00,0x00,0x5e,0x5f,0x48,0xff,0xe0,0x00,0x00,0x00,0x19,0x02};

        public static ReadOnlySpan<byte> remove_ᐤstringㆍarray_charᐤ  =>  new byte[271]{0x41,0x57,0x41,0x56,0x41,0x54,0x57,0x56,0x55,0x53,0x48,0x83,0xec,0x40,0x33,0xc0,0x48,0x89,0x44,0x24,0x30,0x48,0x89,0x44,0x24,0x38,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x44,0x24,0x28,0x48,0x8b,0xf1,0x48,0x8b,0xfa,0x48,0xb9,0x28,0xbd,0x7d,0xde,0xfd,0x7f,0x00,0x00,0xe8,0x87,0x5f,0x95,0x5b,0x48,0x8b,0xd8,0x48,0xb9,0x20,0x00,0x11,0xda,0xfd,0x7f,0x00,0x00,0xba,0x15,0x01,0x00,0x00,0xe8,0xd0,0x1e,0x92,0x5b,0x49,0xb8,0x30,0x2e,0xc6,0x13,0xd3,0x01,0x00,0x00,0x4d,0x8b,0x00,0x48,0x8b,0xd7,0x48,0x8b,0xcb,0xe8,0xe0,0xf9,0xff,0xff,0x48,0x8b,0xce,0x48,0x8b,0xd3,0xe8,0x6d,0xf0,0xe7,0xfe,0x85,0xc0,0x75,0x12,0x48,0x8b,0xc6,0x48,0x83,0xc4,0x40,0x5b,0x5d,0x5e,0x5f,0x41,0x5c,0x41,0x5e,0x41,0x5f,0xc3,0x8b,0x7e,0x08,0x48,0x8d,0x4c,0x24,0x30,0x8b,0xd7,0xe8,0x78,0xfc,0xff,0xff,0x48,0x8d,0x6e,0x0c,0x8b,0x56,0x08,0x33,0xf6,0x45,0x33,0xf6,0x85,0xff,0x7e,0x39,0x49,0x63,0xd6,0x4c,0x8d,0x7c,0x55,0x00,0x41,0x0f,0xb7,0x17,0x48,0x8b,0xcb,0xe8,0xbc,0xf9,0xff,0xff,0x85,0xc0,0x75,0x19,0x8d,0x56,0x01,0x44,0x8b,0xe2,0x48,0x8b,0x54,0x24,0x30,0x41,0x0f,0xb7,0x0f,0x48,0x63,0xc6,0x66,0x89,0x0c,0x42,0x41,0x8b,0xf4,0x41,0xff,0xc6,0x44,0x3b,0xf7,0x7c,0xc7,0x48,0x8b,0x54,0x24,0x30,0x8b,0xce,0x48,0x8d,0x44,0x24,0x20,0x48,0x89,0x10,0x89,0x48,0x08,0x48,0x8d,0x54,0x24,0x20,0x33,0xc9,0xe8,0xd9,0x2c,0xe3,0xfb,0x90,0x48,0x83,0xc4,0x40,0x5b,0x5d,0x5e,0x5f,0x41,0x5c,0x41,0x5e,0x41,0x5f,0xc3};

        public static ReadOnlySpan<byte> after_ᐤstringㆍstringᐤ  =>  new byte[90]{0x57,0x56,0x48,0x83,0xec,0x28,0x48,0x8b,0xf1,0x48,0x8b,0xfa,0x44,0x8b,0x0e,0x45,0x33,0xc9,0x44,0x89,0x4c,0x24,0x20,0x44,0x8b,0x4e,0x08,0x48,0x8b,0xce,0x48,0x8b,0xd7,0x45,0x33,0xc0,0xe8,0xd7,0x5a,0x78,0xfb,0x83,0xf8,0xff,0x75,0x0a,0x48,0x8b,0xc6,0x48,0x83,0xc4,0x28,0x5e,0x5f,0xc3,0x8b,0xd0,0x03,0x57,0x08,0x48,0x8b,0xce,0x48,0xb8,0xe0,0x9c,0x1a,0xdd,0xfd,0x7f,0x00,0x00,0x48,0x83,0xc4,0x28,0x5e,0x5f,0x48,0xff,0xe0,0x00,0x19,0x06,0x03,0x00,0x06,0x42};

        public static ReadOnlySpan<byte> after_ᐤstringㆍstringㆍstringᕀoutᐤ  =>  new byte[118]{0x57,0x56,0x53,0x48,0x83,0xec,0x30,0x48,0x8b,0xf1,0x48,0x8b,0xfa,0x49,0x8b,0xd8,0x44,0x8b,0x0e,0x45,0x33,0xc9,0x44,0x89,0x4c,0x24,0x20,0x44,0x8b,0x4e,0x08,0x48,0x8b,0xce,0x48,0x8b,0xd7,0x45,0x33,0xc0,0xe8,0x63,0x5a,0x78,0xfb,0x83,0xf8,0xff,0x75,0x1f,0x48,0xba,0x60,0x30,0xc6,0x13,0xd3,0x01,0x00,0x00,0x48,0x8b,0x12,0x48,0x8b,0xcb,0xe8,0x99,0x7e,0x2a,0x5b,0x33,0xc0,0x48,0x83,0xc4,0x30,0x5b,0x5e,0x5f,0xc3,0x8b,0xd0,0x03,0x57,0x08,0x48,0x8b,0xce,0xe8,0xf2,0xb2,0x7e,0xfe,0x48,0x8b,0xd0,0x48,0x8b,0xcb,0xe8,0x77,0x7e,0x2a,0x5b,0xb8,0x01,0x00,0x00,0x00,0x48,0x83,0xc4,0x30,0x5b,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> between_ᐤstringㆍcharㆍcharᐤ  =>  new byte[121]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xec,0x20,0x48,0x8b,0xf1,0x41,0x8b,0xf8,0x48,0xb9,0x60,0x30,0xc6,0x13,0xd3,0x01,0x00,0x00,0x48,0x8b,0x19,0x8b,0x0e,0x48,0x8d,0x4e,0x0c,0x44,0x8b,0x46,0x08,0x0f,0xb7,0xd2,0xe8,0x91,0xcd,0x78,0xfb,0x8b,0xe8,0x83,0xfd,0xff,0x74,0x35,0x44,0x8d,0x75,0x01,0x45,0x8b,0xc6,0x44,0x8b,0x4e,0x08,0x45,0x2b,0xc8,0x0f,0xb7,0xd7,0x48,0x8b,0xce,0xe8,0x41,0x59,0x78,0xfb,0x83,0xf8,0xff,0x74,0x17,0x44,0x8b,0xc0,0x44,0x2b,0xc5,0x41,0xff,0xc8,0x41,0x8b,0xd6,0x48,0x8b,0xce,0xe8,0x88,0xb1,0x7e,0xfe,0x48,0x8b,0xd8,0x48,0x8b,0xc3,0x48,0x83,0xc4,0x20,0x5b,0x5d,0x5e,0x5f,0x41,0x5e,0xc3};

        public static ReadOnlySpan<byte> digit_ᐤcharㆍ8uᕀoutᐤ  =>  new byte[100]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb7,0xc9,0x83,0xc1,0xd0,0x83,0xf9,0x09,0x77,0x4e,0x8b,0xc1,0x48,0x8d,0x0d,0x4f,0x00,0x00,0x00,0x8b,0x0c,0x81,0x4c,0x8d,0x05,0xe2,0xff,0xff,0xff,0x49,0x03,0xc8,0xff,0xe1,0xc6,0x02,0x00,0xeb,0x2b,0xc6,0x02,0x01,0xeb,0x26,0xc6,0x02,0x02,0xeb,0x21,0xc6,0x02,0x03,0xeb,0x1c,0xc6,0x02,0x04,0xeb,0x17,0xc6,0x02,0x05,0xeb,0x12,0xc6,0x02,0x06,0xeb,0x0d,0xc6,0x02,0x07,0xeb,0x08,0xc6,0x02,0x08,0xeb,0x03,0xc6,0x02,0x09,0xb8,0x01,0x00,0x00,0x00,0xc3,0xc6,0x02,0xff,0x33,0xc0,0xc3};

        public static ReadOnlySpan<byte> left_ᐤstringㆍ32iᐤ  =>  new byte[77]{0x57,0x56,0x48,0x83,0xec,0x28,0x48,0x8b,0xf1,0x8b,0xfa,0x48,0x8b,0xce,0xe8,0x4d,0xd5,0x04,0x59,0x84,0xc0,0x75,0x2c,0x48,0x8b,0xce,0x44,0x8b,0x41,0x08,0x44,0x3b,0xc7,0x7c,0x02,0xeb,0x06,0x48,0x8b,0xce,0x41,0x8b,0xf8,0x33,0xd2,0x44,0x8b,0xc7,0x48,0xb8,0x10,0x9c,0x1a,0xdd,0xfd,0x7f,0x00,0x00,0x48,0x83,0xc4,0x28,0x5e,0x5f,0x48,0xff,0xe0,0x48,0x8b,0xc6,0x48,0x83,0xc4,0x28,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> lines_ᐤstringㆍboolᐤ  =>  new byte[722]{0x55,0x41,0x57,0x41,0x56,0x57,0x56,0x53,0x48,0x83,0xec,0x68,0xc5,0xf8,0x77,0x48,0x8d,0xac,0x24,0x90,0x00,0x00,0x00,0x48,0x8b,0xf1,0x48,0x8d,0x7d,0xa8,0xb9,0x0c,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x89,0x65,0x90,0x48,0x8b,0xf9,0x8b,0xf2,0x48,0xb9,0x20,0x00,0x11,0xda,0xfd,0x7f,0x00,0x00,0xba,0x4e,0x01,0x00,0x00,0xe8,0x59,0x48,0x27,0x5b,0x48,0xb9,0x20,0x30,0xc6,0x13,0xd3,0x01,0x00,0x00,0x48,0x8b,0x19,0x48,0x85,0xdb,0x75,0x05,0x45,0x33,0xf6,0xeb,0x04,0x44,0x8b,0x73,0x08,0x45,0x85,0xf6,0x75,0x3e,0x48,0xb9,0x50,0x8e,0xe2,0xde,0xfd,0x7f,0x00,0x00,0xe8,0xca,0x88,0x2a,0x5b,0x4c,0x8b,0xf8,0x48,0xb9,0x20,0x00,0x11,0xda,0xfd,0x7f,0x00,0x00,0xba,0x4d,0x01,0x00,0x00,0xe8,0x13,0x48,0x27,0x5b,0x48,0xba,0xe0,0x11,0xcc,0x13,0xd3,0x01,0x00,0x00,0x48,0x8b,0x12,0x49,0x8d,0x4f,0x08,0xe8,0xdd,0x79,0x2a,0x5b,0xeb,0x2c,0x48,0xb9,0x50,0x8e,0xe2,0xde,0xfd,0x7f,0x00,0x00,0xe8,0x8c,0x88,0x2a,0x5b,0x4c,0x8b,0xf8,0x49,0x8b,0xcf,0x41,0x8b,0xd6,0xe8,0xee,0xfc,0xff,0xff,0x41,0x8b,0x57,0x10,0x49,0x8b,0xcf,0x4c,0x8b,0xc3,0xe8,0x87,0xfe,0xff,0xff,0x33,0xdb,0x48,0xb9,0x10,0x1f,0x9e,0xdc,0xfd,0x7f,0x00,0x00,0xe8,0x5e,0x88,0x2a,0x5b,0x4c,0x8b,0xf0,0x49,0x8b,0xce,0x48,0x8b,0xd7,0xe8,0x88,0xea,0xc6,0xfd,0x4c,0x89,0x75,0xa0,0x48,0x8b,0x4d,0xa0,0xe8,0xc3,0xea,0xc6,0xfd,0x48,0x8b,0xf8,0x48,0x85,0xff,0x0f,0x84,0x37,0x01,0x00,0x00,0x48,0x8b,0xcf,0xe8,0x8f,0xd1,0x04,0x59,0x0f,0xb6,0xd0,0x85,0xd2,0x0f,0x84,0x90,0x00,0x00,0x00,0x40,0x84,0xf6,0x0f,0x84,0x06,0x01,0x00,0x00,0xff,0xc3,0x48,0x8d,0x55,0xb8,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x02,0x89,0x5d,0xc0,0x48,0x8d,0x4d,0xb8,0x48,0x8b,0xd7,0x48,0x85,0xd2,0x75,0x0d,0x48,0xba,0x60,0x30,0xc6,0x13,0xd3,0x01,0x00,0x00,0x48,0x8b,0x12,0xe8,0xfc,0x78,0x2a,0x5b,0x48,0x8b,0x55,0xb8,0x8b,0x7d,0xc0,0x41,0xff,0x47,0x14,0x49,0x8b,0x4f,0x08,0x41,0x8b,0x47,0x10,0x39,0x41,0x08,0x76,0x25,0x44,0x8d,0x40,0x01,0x45,0x89,0x47,0x10,0x48,0x63,0xc0,0x48,0xc1,0xe0,0x04,0x4c,0x8d,0x74,0x01,0x10,0x49,0x8b,0xce,0xe8,0xc8,0x78,0x2a,0x5b,0x41,0x89,0x7e,0x08,0xe9,0x9a,0x00,0x00,0x00,0x48,0x8d,0x4d,0xa8,0x48,0x89,0x11,0x89,0x79,0x08,0x49,0x8b,0xcf,0x48,0x8d,0x55,0xa8,0xe8,0x89,0xfc,0xff,0xff,0xe9,0x7f,0x00,0x00,0x00,0xff,0xc3,0x48,0x8d,0x55,0xc8,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x02,0x89,0x5d,0xd0,0x48,0x8d,0x4d,0xc8,0x48,0x8b,0xd7,0x48,0x85,0xd2,0x75,0x0d,0x48,0xba,0x60,0x30,0xc6,0x13,0xd3,0x01,0x00,0x00,0x48,0x8b,0x12,0xe8,0x75,0x78,0x2a,0x5b,0x48,0x8b,0x55,0xc8,0x8b,0x7d,0xd0,0x41,0xff,0x47,0x14,0x49,0x8b,0x4f,0x08,0x41,0x8b,0x47,0x10,0x39,0x41,0x08,0x76,0x22,0x44,0x8d,0x40,0x01,0x45,0x89,0x47,0x10,0x48,0x63,0xc0,0x48,0xc1,0xe0,0x04,0x4c,0x8d,0x74,0x01,0x10,0x49,0x8b,0xce,0xe8,0x41,0x78,0x2a,0x5b,0x41,0x89,0x7e,0x08,0xeb,0x16,0x48,0x8d,0x4d,0xa8,0x48,0x89,0x11,0x89,0x79,0x08,0x49,0x8b,0xcf,0x48,0x8d,0x55,0xa8,0xe8,0x05,0xfc,0xff,0xff,0x48,0x8b,0x4d,0xa0,0xe8,0x8c,0xe9,0xc6,0xfd,0x48,0x8b,0xf8,0x48,0x85,0xff,0x0f,0x85,0xc9,0xfe,0xff,0xff,0x48,0x8b,0x4d,0xa0,0x33,0xc0,0x48,0x89,0x41,0x08,0x48,0x8b,0x4d,0xa0,0x33,0xc0,0x89,0x41,0x10,0x48,0x8b,0x4d,0xa0,0x89,0x41,0x14,0x48,0x8b,0x4d,0xa0,0xe8,0x7d,0x73,0x04,0x59,0x49,0x8b,0xcf,0x39,0x09,0xe8,0x63,0xfd,0xff,0xff,0x90,0x48,0x8d,0x65,0xd8,0x5b,0x5e,0x5f,0x41,0x5e,0x41,0x5f,0x5d,0xc3,0x55,0x41,0x57,0x41,0x56,0x57,0x56,0x53,0x48,0x83,0xec,0x28,0xc5,0xf8,0x77,0x48,0x8b,0x69,0x20,0x48,0x89,0x6c,0x24,0x20,0x48,0x8d,0xad,0x90,0x00,0x00,0x00,0x48,0x83,0x7d,0xa0,0x00,0x74,0x23,0x48,0x8b,0x4d,0xa0,0x33,0xc0,0x48,0x89,0x41,0x08,0x48,0x8b,0x4d,0xa0,0x33,0xc0,0x89,0x41,0x10,0x48,0x8b,0x4d,0xa0,0x89,0x41,0x14,0x48,0x8b,0x4d,0xa0,0xe8,0x1c,0x73,0x04,0x59,0x90,0x48,0x83,0xc4,0x28,0x5b,0x5e,0x5f,0x41,0x5e,0x41,0x5f,0x5d,0xc3};

        public static ReadOnlySpan<byte> lines_ᐤstringㆍActionᐸTextLineᐳᐤ  =>  new byte[318]{0x55,0x41,0x56,0x57,0x56,0x53,0x48,0x83,0xec,0x50,0xc5,0xf8,0x77,0x48,0x8d,0x6c,0x24,0x70,0x33,0xc0,0x48,0x89,0x45,0xd0,0x48,0x89,0x45,0xd8,0x48,0x89,0x45,0xc0,0x48,0x89,0x45,0xc8,0x48,0x89,0x65,0xb0,0x48,0x8b,0xf9,0x48,0x8b,0xf2,0x33,0xdb,0x48,0xb9,0x10,0x1f,0x9e,0xdc,0xfd,0x7f,0x00,0x00,0xe8,0xf1,0x85,0x2a,0x5b,0x4c,0x8b,0xf0,0x49,0x8b,0xce,0x48,0x8b,0xd7,0xe8,0x1b,0xe8,0xc6,0xfd,0x4c,0x89,0x75,0xb8,0x48,0x8b,0x4d,0xb8,0xe8,0x56,0xe8,0xc6,0xfd,0x48,0x8b,0xd0,0x48,0x85,0xd2,0x74,0x5c,0xff,0xc3,0x48,0x8d,0x4d,0xd0,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0x89,0x5d,0xd8,0x48,0x8d,0x4d,0xd0,0x48,0x85,0xd2,0x75,0x0d,0x48,0xba,0x60,0x30,0xc6,0x13,0xd3,0x01,0x00,0x00,0x48,0x8b,0x12,0xe8,0xb2,0x76,0x2a,0x5b,0x48,0x8b,0xc6,0x48,0x8d,0x4d,0xc0,0x48,0x8b,0x55,0xd0,0x48,0x89,0x11,0x8b,0x55,0xd8,0x89,0x51,0x08,0x48,0x8b,0x48,0x08,0x48,0x8d,0x55,0xc0,0xff,0x50,0x18,0x48,0x8b,0x4d,0xb8,0xe8,0xfa,0xe7,0xc6,0xfd,0x48,0x8b,0xd0,0x48,0x85,0xd2,0x75,0xa4,0x48,0x8b,0x4d,0xb8,0x33,0xc0,0x48,0x89,0x41,0x08,0x48,0x8b,0x4d,0xb8,0x33,0xc0,0x89,0x41,0x10,0x48,0x8b,0x4d,0xb8,0x89,0x41,0x14,0x48,0x8b,0x4d,0xb8,0xe8,0xef,0x71,0x04,0x59,0x8b,0xc3,0x48,0x8d,0x65,0xe0,0x5b,0x5e,0x5f,0x41,0x5e,0x5d,0xc3,0x55,0x41,0x56,0x57,0x56,0x53,0x48,0x83,0xec,0x30,0xc5,0xf8,0x77,0x48,0x8b,0x69,0x20,0x48,0x89,0x6c,0x24,0x20,0x48,0x8d,0x6d,0x70,0x48,0x83,0x7d,0xb8,0x00,0x74,0x23,0x48,0x8b,0x4d,0xb8,0x33,0xc0,0x48,0x89,0x41,0x08,0x48,0x8b,0x4d,0xb8,0x33,0xc0,0x89,0x41,0x10,0x48,0x8b,0x4d,0xb8,0x89,0x41,0x14,0x48,0x8b,0x4d,0xb8,0xe8,0x9e,0x71,0x04,0x59,0x90,0x48,0x83,0xc4,0x30,0x5b,0x5e,0x5f,0x41,0x5e,0x5d,0xc3};

        public static ReadOnlySpan<byte> remove_ᐤstringㆍstringᐤ  =>  new byte[34]{0x0f,0x1f,0x44,0x00,0x00,0x49,0xb8,0x60,0x30,0xc6,0x13,0xd3,0x01,0x00,0x00,0x4d,0x8b,0x00,0x48,0xb8,0x50,0x1e,0xa5,0x37,0xfe,0x7f,0x00,0x00,0x39,0x09,0x48,0xff,0xe0,0x00};

        public static ReadOnlySpan<byte> right_ᐤstringㆍ32iᐤ  =>  new byte[474]{0x55,0x57,0x56,0x48,0x83,0xec,0x40,0x48,0x8d,0x6c,0x24,0x20,0x33,0xc0,0x48,0x89,0x45,0x10,0x48,0x89,0x45,0x18,0x48,0x89,0x45,0x08,0x48,0xb8,0x5e,0x6c,0x64,0xb6,0x4e,0xef,0x00,0x00,0x48,0x89,0x45,0x08,0x48,0x85,0xc9,0x75,0x05,0x45,0x33,0xc0,0xeb,0x04,0x44,0x8b,0x41,0x08,0x45,0x85,0xc0,0x75,0x2b,0x48,0xb8,0x60,0x30,0xc6,0x13,0xd3,0x01,0x00,0x00,0x48,0x8b,0x00,0x48,0xb9,0x5e,0x6c,0x64,0xb6,0x4e,0xef,0x00,0x00,0x48,0x39,0x4d,0x08,0x74,0x05,0xe8,0x63,0x22,0x3d,0x5b,0x90,0x48,0x8d,0x65,0x20,0x5e,0x5f,0x5d,0xc3,0x48,0x85,0xc9,0x75,0x05,0x45,0x33,0xc9,0xeb,0x07,0x4c,0x8d,0x49,0x0c,0x8b,0x41,0x08,0x44,0x3b,0xc2,0x7c,0x04,0x8b,0xf2,0xeb,0x03,0x41,0x8b,0xf0,0x8b,0xc6,0xb9,0x02,0x00,0x00,0x00,0x48,0xf7,0xe1,0x0f,0x82,0x94,0x00,0x00,0x00,0x48,0x8b,0xd0,0x48,0x85,0xd2,0x74,0x1e,0x48,0x83,0xc2,0x0f,0x48,0xc1,0xea,0x04,0x48,0x83,0xc4,0x20,0x6a,0x00,0x6a,0x00,0x48,0xff,0xca,0x75,0xf7,0x48,0x83,0xec,0x20,0x48,0x8d,0x54,0x24,0x20,0x85,0xf6,0x7c,0x6f,0x8b,0xce,0x33,0xff,0x49,0x63,0xc0,0x48,0x85,0xc0,0x7e,0x2b,0x41,0x8b,0xc0,0x2b,0xc6,0x4c,0x63,0xd7,0x4e,0x8d,0x14,0x52,0x44,0x8b,0xdf,0x44,0x03,0xd8,0x4d,0x63,0xdb,0x47,0x0f,0xb7,0x1c,0x59,0x66,0x45,0x89,0x1a,0xff,0xc7,0x44,0x8b,0xd7,0x4d,0x63,0xd8,0x4d,0x3b,0xd3,0x7c,0xda,0x48,0x8d,0x45,0x10,0x48,0x89,0x10,0x89,0x48,0x08,0x48,0x8d,0x55,0x10,0x33,0xc9,0xe8,0x8f,0x51,0x78,0xfb,0x48,0xb9,0x5e,0x6c,0x64,0xb6,0x4e,0xef,0x00,0x00,0x48,0x39,0x4d,0x08,0x74,0x05,0xe8,0xa2,0x21,0x3d,0x5b,0x90,0x48,0x8d,0x65,0x20,0x5e,0x5f,0x5d,0xc3,0xe8,0x64,0x07,0x3d,0x5b,0xe8,0x47,0x0c,0x7a,0xfb,0xcc,0x00,0x00,0x19,0x0c,0x05,0x25,0x0c,0x03,0x07,0x72,0x03,0x60,0x02,0x70,0x01,0x50,0x00,0x00,0x40,0x00,0x00,0x00,0x40,0xc4,0xe5,0xde,0xfd,0x7f,0x00,0x00,0x57,0x56,0x53,0x48,0x83,0xec,0x40,0x33,0xc0,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x30,0x49,0x8b,0xf0,0x0f,0xb7,0x3a,0x48,0x8b,0x4a,0x08,0x48,0x85,0xc9,0x75,0x06,0x33,0xdb,0x33,0xc0,0xeb,0x07,0x48,0x8d,0x59,0x10,0x8b,0x41,0x08,0x48,0x8d,0x4c,0x24,0x28,0x48,0x89,0x19,0x89,0x41,0x08,0x48,0x8d,0x4c,0x24,0x28,0x0f,0xb7,0x12,0xe8,0x69,0x72,0x79,0xfb,0x83,0xf8,0xff,0x74,0x32,0x48,0x63,0xc0,0x0f,0xb7,0x04,0x43,0x66,0xc7,0x44,0x24,0x38,0x00,0x00,0x66,0xc7,0x44,0x24,0x3a,0x00,0x00,0x66,0x89,0x7c,0x24,0x38,0x66,0x89,0x44,0x24,0x3a,0x8b,0x44,0x24,0x38,0x89,0x06,0xb8,0x01,0x00,0x00,0x00,0x48,0x83,0xc4,0x40,0x5b,0x5e,0x5f,0xc3,0x33,0xc0,0x89,0x06,0x48,0x83,0xc4,0x40,0x5b,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> rule_ᐤstringㆍAdjacentᐸcharㆍOneOfᐸcharᐳᐳㆍAdjacentᐸcharᐳᕀoutᐤ  =>  new byte[138]{0x57,0x56,0x53,0x48,0x83,0xec,0x40,0x33,0xc0,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x30,0x49,0x8b,0xf0,0x0f,0xb7,0x3a,0x48,0x8b,0x4a,0x08,0x48,0x85,0xc9,0x75,0x06,0x33,0xdb,0x33,0xc0,0xeb,0x07,0x48,0x8d,0x59,0x10,0x8b,0x41,0x08,0x48,0x8d,0x4c,0x24,0x28,0x48,0x89,0x19,0x89,0x41,0x08,0x48,0x8d,0x4c,0x24,0x28,0x0f,0xb7,0x12,0xe8,0x69,0x72,0x79,0xfb,0x83,0xf8,0xff,0x74,0x32,0x48,0x63,0xc0,0x0f,0xb7,0x04,0x43,0x66,0xc7,0x44,0x24,0x38,0x00,0x00,0x66,0xc7,0x44,0x24,0x3a,0x00,0x00,0x66,0x89,0x7c,0x24,0x38,0x66,0x89,0x44,0x24,0x3a,0x8b,0x44,0x24,0x38,0x89,0x06,0xb8,0x01,0x00,0x00,0x00,0x48,0x83,0xc4,0x40,0x5b,0x5e,0x5f,0xc3,0x33,0xc0,0x89,0x06,0x48,0x83,0xc4,0x40,0x5b,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> segment_ᐤstringㆍ32iㆍ32iᐤ  =>  new byte[24]{0x0f,0x1f,0x44,0x00,0x00,0x44,0x2b,0xc2,0x41,0xff,0xc0,0x48,0xb8,0x10,0x9c,0x1a,0xdd,0xfd,0x7f,0x00,0x00,0x48,0xff,0xe0};

        public static ReadOnlySpan<byte> segment_ᐤstringㆍ32uㆍ32uᐤ  =>  new byte[24]{0x0f,0x1f,0x44,0x00,0x00,0x44,0x2b,0xc2,0x41,0xff,0xc0,0x48,0xb8,0x10,0x9c,0x1a,0xdd,0xfd,0x7f,0x00,0x00,0x48,0xff,0xe0};

        public static ReadOnlySpan<byte> slice_ᐤstringㆍ32iᐤ  =>  new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x48,0xb8,0xe0,0x9c,0x1a,0xdd,0xfd,0x7f,0x00,0x00,0x48,0xff,0xe0};

        public static ReadOnlySpan<byte> slice_ᐤstringㆍ32iㆍ32iᐤ  =>  new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x48,0xb8,0x10,0x9c,0x1a,0xdd,0xfd,0x7f,0x00,0x00,0x48,0xff,0xe0};

        public static ReadOnlySpan<byte> slice_ᐤstringㆍ32uᐤ  =>  new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x48,0xb8,0xe0,0x9c,0x1a,0xdd,0xfd,0x7f,0x00,0x00,0x48,0xff,0xe0};

        public static ReadOnlySpan<byte> slice_ᐤstringㆍ32uㆍ32uᐤ  =>  new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x48,0xb8,0x10,0x9c,0x1a,0xdd,0xfd,0x7f,0x00,0x00,0x48,0xff,0xe0};

        public static ReadOnlySpan<byte> split_ᐤstringㆍcharㆍboolᐤ  =>  new byte[85]{0x48,0x83,0xec,0x38,0x33,0xc0,0x48,0x89,0x44,0x24,0x20,0x0f,0xb7,0xd2,0x45,0x84,0xc0,0x75,0x05,0x45,0x33,0xc9,0xeb,0x06,0x41,0xb9,0x01,0x00,0x00,0x00,0x0f,0xb7,0xd2,0x66,0x89,0x54,0x24,0x34,0x8b,0x11,0x48,0x8d,0x54,0x24,0x34,0x41,0xb8,0x01,0x00,0x00,0x00,0x48,0x8d,0x44,0x24,0x20,0x48,0x89,0x10,0x44,0x89,0x40,0x08,0x48,0x8d,0x54,0x24,0x20,0x41,0xb8,0xff,0xff,0xff,0x7f,0xe8,0x01,0xc3,0x04,0x59,0x90,0x48,0x83,0xc4,0x38,0xc3};

        public static ReadOnlySpan<byte> split_ᐤstringㆍstringㆍboolᐤ  =>  new byte[67]{0x48,0x83,0xec,0x28,0x90,0x45,0x84,0xc0,0x75,0x05,0x45,0x33,0xc0,0xeb,0x06,0x41,0xb8,0x01,0x00,0x00,0x00,0x44,0x8b,0x09,0x48,0x85,0xd2,0x75,0x0d,0x48,0xba,0x60,0x30,0xc6,0x13,0xd3,0x01,0x00,0x00,0x48,0x8b,0x12,0x44,0x89,0x44,0x24,0x20,0x45,0x33,0xc0,0x41,0xb9,0xff,0xff,0xff,0x7f,0xe8,0xeb,0x4b,0x78,0xfb,0x90,0x48,0x83,0xc4,0x28,0xc3};

        public static ReadOnlySpan<byte> substring_ᐤstringㆍ32iᐤ  =>  new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x48,0xb8,0xe0,0x9c,0x1a,0xdd,0xfd,0x7f,0x00,0x00,0x48,0xff,0xe0};

        public static ReadOnlySpan<byte> substring_ᐤstringㆍ32iㆍ32iᐤ  =>  new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x48,0xb8,0x10,0x9c,0x1a,0xdd,0xfd,0x7f,0x00,0x00,0x48,0xff,0xe0};

        public static ReadOnlySpan<byte> unfence_ᐤstringㆍFenceᐸcharᐳㆍstringᕀoutᐤ  =>  new byte[134]{0x57,0x56,0x53,0x48,0x83,0xec,0x20,0x48,0x89,0x54,0x24,0x48,0x48,0x8b,0xf1,0x49,0x8b,0xf8,0x48,0xba,0x60,0x30,0xc6,0x13,0xd3,0x01,0x00,0x00,0x48,0x8b,0x12,0x48,0x8b,0xcf,0xe8,0x19,0x71,0x2a,0x5b,0x48,0x8b,0xce,0xe8,0x61,0xc9,0x04,0x59,0x84,0xc0,0x75,0x49,0x48,0x8b,0xce,0x8b,0x54,0x24,0x48,0xe8,0x51,0x6f,0x79,0xfb,0x85,0xc0,0x74,0x39,0x8b,0x5e,0x08,0x48,0x8b,0xce,0xba,0x02,0x00,0x00,0x00,0xe8,0x7d,0x92,0x08,0x59,0x48,0x8b,0xc8,0x44,0x8d,0x43,0xfe,0xba,0x01,0x00,0x00,0x00,0xe8,0x7c,0xa4,0x7e,0xfe,0x48,0x8b,0xd0,0x48,0x8b,0xcf,0xe8,0xd1,0x70,0x2a,0x5b,0xb8,0x01,0x00,0x00,0x00,0x48,0x83,0xc4,0x20,0x5b,0x5e,0x5f,0xc3,0x33,0xc0,0x48,0x83,0xc4,0x20,0x5b,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> unfence_ᐤstringㆍFenceᐸstringᐳᐤ  =>  new byte[195]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xec,0x40,0x33,0xc0,0x48,0x89,0x44,0x24,0x38,0x48,0x8b,0xf9,0x48,0x8b,0xf2,0x48,0x8b,0x16,0x48,0x8b,0x5e,0x08,0x44,0x8b,0x0f,0x45,0x33,0xc9,0x44,0x89,0x4c,0x24,0x20,0x8b,0x6f,0x08,0x44,0x8b,0xcd,0x48,0x8b,0xcf,0x45,0x33,0xc0,0xe8,0x16,0x4c,0x78,0xfb,0x44,0x8b,0xf0,0x45,0x33,0xc9,0x44,0x89,0x4c,0x24,0x20,0x44,0x8b,0xcd,0x48,0x8b,0xcf,0x48,0x8b,0xd3,0x45,0x33,0xc0,0xe8,0xfa,0x4b,0x78,0xfb,0x33,0xc9,0x89,0x4c,0x24,0x30,0x89,0x4c,0x24,0x34,0x44,0x89,0x74,0x24,0x30,0x89,0x44,0x24,0x34,0x48,0x8b,0x4c,0x24,0x30,0x48,0x89,0x4c,0x24,0x38,0x8b,0x54,0x24,0x38,0x44,0x8b,0x44,0x24,0x3c,0x83,0x7c,0x24,0x38,0xff,0x74,0x28,0x41,0x83,0xf8,0xff,0x74,0x22,0x41,0x3b,0xd0,0x7d,0x1d,0x48,0x8b,0x0e,0x03,0x51,0x08,0x44,0x2b,0xc2,0x48,0x8b,0xcf,0xe8,0xa1,0xa3,0x7e,0xfe,0x90,0x48,0x83,0xc4,0x40,0x5b,0x5d,0x5e,0x5f,0x41,0x5e,0xc3,0x48,0xb8,0x60,0x30,0xc6,0x13,0xd3,0x01,0x00,0x00,0x48,0x8b,0x00,0x48,0x83,0xc4,0x40,0x5b,0x5d,0x5e,0x5f,0x41,0x5e,0xc3};

    }
}
