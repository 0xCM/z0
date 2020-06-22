//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.ByteCode
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public static class metareader_format
    {
        public static ReadOnlySpan<byte> format_ᐤBlobRecordᕀinㆍcharᐤ  =>  new byte[629]{0x41,0x57,0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x81,0xec,0xe8,0x00,0x00,0x00,0xc5,0xf8,0x77,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x28,0xb9,0x30,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x8b,0xf1,0x8b,0xfa,0xba,0x04,0x00,0x00,0x00,0x48,0xb9,0x90,0x75,0xa9,0xad,0xf9,0x7f,0x00,0x00,0xe8,0x91,0xa6,0x96,0x5d,0x48,0x8b,0xd8,0x48,0x8b,0xcb,0xe8,0x16,0x4d,0x90,0x5d,0x48,0x8b,0xe8,0x48,0xb9,0x92,0xf8,0xa7,0xad,0xf9,0x7f,0x00,0x00,0xe8,0xa4,0xe2,0x8f,0x5d,0x48,0x3b,0xe8,0x0f,0x85,0x0b,0x02,0x00,0x00,0x48,0x8d,0x6b,0x10,0x8b,0x5b,0x08,0x48,0x89,0xac,0x24,0xd8,0x00,0x00,0x00,0x89,0x9c,0x24,0xe0,0x00,0x00,0x00,0xc5,0xfa,0x6f,0x84,0x24,0xd8,0x00,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0xc8,0x00,0x00,0x00,0x4c,0x8b,0xb4,0x24,0xc8,0x00,0x00,0x00,0x8b,0x4e,0x08,0x48,0xba,0x45,0x43,0x73,0x2b,0xa0,0x02,0x00,0x00,0x44,0x0f,0xb6,0x3a,0x33,0xd2,0x45,0x33,0xc0,0x48,0x8d,0x44,0x24,0x48,0x48,0x89,0x10,0x44,0x89,0x40,0x08,0x48,0x8d,0x54,0x24,0x48,0x45,0x33,0xc0,0xe8,0x0c,0xde,0xf2,0x5c,0x8b,0x08,0x48,0x8b,0xc8,0x41,0x8b,0xd7,0x41,0xb8,0x20,0x00,0x00,0x00,0xe8,0x39,0x4a,0xfc,0x5c,0x48,0x8b,0xd0,0x49,0x8b,0xce,0xe8,0x6e,0x95,0x96,0x5d,0x48,0x89,0xac,0x24,0xb8,0x00,0x00,0x00,0x89,0x9c,0x24,0xc0,0x00,0x00,0x00,0xc5,0xfa,0x6f,0x84,0x24,0xb8,0x00,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0xa8,0x00,0x00,0x00,0x4c,0x8b,0xb4,0x24,0xa8,0x00,0x00,0x00,0x49,0x83,0xc6,0x08,0x8b,0x4e,0x0c,0x48,0xba,0x46,0x43,0x73,0x2b,0xa0,0x02,0x00,0x00,0x44,0x0f,0xb6,0x3a,0x33,0xd2,0x89,0x54,0x24,0x20,0xba,0x01,0x00,0x00,0x00,0x41,0xb8,0x01,0x00,0x00,0x00,0x45,0x33,0xc9,0xe8,0x5f,0x27,0xe5,0xfd,0x8b,0x08,0x48,0x8b,0xc8,0x41,0x8b,0xd7,0x41,0xb8,0x20,0x00,0x00,0x00,0xe8,0xc4,0x49,0xfc,0x5c,0x48,0x8b,0xd0,0x49,0x8b,0xce,0xe8,0xf9,0x94,0x96,0x5d,0x48,0x89,0xac,0x24,0x98,0x00,0x00,0x00,0x89,0x9c,0x24,0xa0,0x00,0x00,0x00,0xc5,0xfa,0x6f,0x84,0x24,0x98,0x00,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0x88,0x00,0x00,0x00,0x4c,0x8b,0xb4,0x24,0x88,0x00,0x00,0x00,0x49,0x83,0xc6,0x10,0x8b,0x4e,0x10,0x48,0xba,0x47,0x43,0x73,0x2b,0xa0,0x02,0x00,0x00,0x44,0x0f,0xb6,0x3a,0x33,0xd2,0x89,0x54,0x24,0x20,0xba,0x01,0x00,0x00,0x00,0x41,0xb8,0x01,0x00,0x00,0x00,0x45,0x33,0xc9,0xe8,0xea,0x26,0xe5,0xfd,0x8b,0x08,0x48,0x8b,0xc8,0x41,0x8b,0xd7,0x41,0xb8,0x20,0x00,0x00,0x00,0xe8,0x4f,0x49,0xfc,0x5c,0x48,0x8b,0xd0,0x49,0x8b,0xce,0xe8,0x84,0x94,0x96,0x5d,0x48,0x89,0x6c,0x24,0x78,0x89,0x9c,0x24,0x80,0x00,0x00,0x00,0xc5,0xfa,0x6f,0x44,0x24,0x78,0xc5,0xfa,0x7f,0x44,0x24,0x68,0x4c,0x8b,0x74,0x24,0x68,0x49,0x83,0xc6,0x18,0x48,0x8b,0x0e,0x48,0xba,0x48,0x43,0x73,0x2b,0xa0,0x02,0x00,0x00,0x40,0x0f,0xb6,0x32,0x33,0xd2,0x48,0x8d,0x44,0x24,0x58,0x48,0x89,0x10,0x66,0x89,0x50,0x08,0x48,0x8b,0x54,0x24,0x58,0x48,0x89,0x54,0x24,0x38,0x66,0x8b,0x54,0x24,0x60,0x66,0x89,0x54,0x24,0x40,0x48,0x8d,0x54,0x24,0x38,0xe8,0xb6,0xd0,0x10,0xff,0x8b,0x08,0x48,0x8b,0xc8,0x8b,0xd6,0x41,0xb8,0x20,0x00,0x00,0x00,0xe8,0xd4,0x48,0xfc,0x5c,0x48,0x8b,0xd0,0x49,0x8b,0xce,0xe8,0x09,0x94,0x96,0x5d,0x48,0x8d,0x4c,0x24,0x28,0x48,0x89,0x29,0x89,0x59,0x08,0x48,0x8d,0x4c,0x24,0x28,0x0f,0xb7,0xd7,0xe8,0x11,0xb6,0xa6,0xfe,0x90,0x48,0x81,0xc4,0xe8,0x00,0x00,0x00,0x5b,0x5d,0x5e,0x5f,0x41,0x5e,0x41,0x5f,0xc3,0xe8,0x6b,0xff,0xe4,0xfd};

        public static ReadOnlySpan<byte> format_ᐤConstantRecordᕀinㆍcharᐤ  =>  new byte[624]{0x41,0x57,0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x81,0xec,0xf8,0x00,0x00,0x00,0xc5,0xf8,0x77,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x28,0xb9,0x34,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x8b,0xf1,0x8b,0xfa,0xba,0x04,0x00,0x00,0x00,0x48,0xb9,0x90,0x75,0xa9,0xad,0xf9,0x7f,0x00,0x00,0xe8,0xf1,0xa3,0x96,0x5d,0x48,0x8b,0xd8,0x48,0x8b,0xcb,0xe8,0x76,0x4a,0x90,0x5d,0x48,0x8b,0xe8,0x48,0xb9,0x92,0xf8,0xa7,0xad,0xf9,0x7f,0x00,0x00,0xe8,0x04,0xe0,0x8f,0x5d,0x48,0x3b,0xe8,0x0f,0x85,0x06,0x02,0x00,0x00,0x48,0x8d,0x6b,0x10,0x8b,0x5b,0x08,0x48,0x89,0xac,0x24,0xd0,0x00,0x00,0x00,0x89,0x9c,0x24,0xd8,0x00,0x00,0x00,0xc5,0xfa,0x6f,0x84,0x24,0xd0,0x00,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0xc0,0x00,0x00,0x00,0x4c,0x8b,0xb4,0x24,0xc0,0x00,0x00,0x00,0x8b,0x4e,0x08,0x48,0xba,0x3d,0x43,0x73,0x2b,0xa0,0x02,0x00,0x00,0x44,0x0f,0xb6,0x3a,0x33,0xd2,0x45,0x33,0xc0,0x48,0x8d,0x44,0x24,0x38,0x48,0x89,0x10,0x44,0x89,0x40,0x08,0x48,0x8d,0x54,0x24,0x38,0x45,0x33,0xc0,0xe8,0x6c,0xdb,0xf2,0x5c,0x8b,0x08,0x48,0x8b,0xc8,0x41,0x8b,0xd7,0x41,0xb8,0x20,0x00,0x00,0x00,0xe8,0x99,0x47,0xfc,0x5c,0x48,0x8b,0xd0,0x49,0x8b,0xce,0xe8,0xce,0x92,0x96,0x5d,0x48,0x89,0xac,0x24,0xb0,0x00,0x00,0x00,0x89,0x9c,0x24,0xb8,0x00,0x00,0x00,0xc5,0xfa,0x6f,0x84,0x24,0xb0,0x00,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0xa0,0x00,0x00,0x00,0x4c,0x8b,0xb4,0x24,0xa0,0x00,0x00,0x00,0x49,0x83,0xc6,0x08,0x48,0x8b,0x0e,0x48,0xba,0x3e,0x43,0x73,0x2b,0xa0,0x02,0x00,0x00,0x0f,0xb6,0x12,0x44,0x8b,0x01,0x41,0xb8,0x20,0x00,0x00,0x00,0xe8,0x43,0x47,0xfc,0x5c,0x48,0x8b,0xd0,0x49,0x8b,0xce,0xe8,0x78,0x92,0x96,0x5d,0x48,0x89,0xac,0x24,0x90,0x00,0x00,0x00,0x89,0x9c,0x24,0x98,0x00,0x00,0x00,0xc5,0xfa,0x6f,0x84,0x24,0x90,0x00,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0x80,0x00,0x00,0x00,0x4c,0x8b,0xb4,0x24,0x80,0x00,0x00,0x00,0x49,0x83,0xc6,0x10,0x48,0xb9,0x38,0xf0,0x95,0xae,0xf9,0x7f,0x00,0x00,0xe8,0x2c,0xa1,0x96,0x5d,0x0f,0xb6,0x4e,0x0c,0x88,0x48,0x08,0x48,0xb9,0x3f,0x43,0x73,0x2b,0xa0,0x02,0x00,0x00,0x44,0x0f,0xb6,0x39,0x48,0x8b,0xc8,0x39,0x09,0xe8,0x2d,0x77,0xf3,0x5c,0x8b,0x08,0x48,0x8b,0xc8,0x41,0x8b,0xd7,0x41,0xb8,0x20,0x00,0x00,0x00,0xe8,0xca,0x46,0xfc,0x5c,0x48,0x8b,0xd0,0x49,0x8b,0xce,0xe8,0xff,0x91,0x96,0x5d,0x48,0x89,0x6c,0x24,0x70,0x89,0x5c,0x24,0x78,0xc5,0xfa,0x6f,0x44,0x24,0x70,0xc5,0xfa,0x7f,0x44,0x24,0x60,0x4c,0x8b,0x74,0x24,0x60,0x49,0x83,0xc6,0x18,0x48,0x83,0xc6,0x10,0xc5,0xfa,0x6f,0x06,0xc5,0xfa,0x7f,0x84,0x24,0xe0,0x00,0x00,0x00,0x48,0x8b,0x4e,0x10,0x48,0x89,0x8c,0x24,0xf0,0x00,0x00,0x00,0xc5,0xfa,0x6f,0x84,0x24,0xe0,0x00,0x00,0x00,0xc5,0xfa,0x7f,0x44,0x24,0x48,0x48,0x8b,0x8c,0x24,0xf0,0x00,0x00,0x00,0x48,0x89,0x4c,0x24,0x58,0x48,0xb9,0x40,0x43,0x73,0x2b,0xa0,0x02,0x00,0x00,0x40,0x0f,0xb6,0x31,0x48,0x8d,0x4c,0x24,0x48,0xba,0x7c,0x00,0x00,0x00,0xe8,0x3b,0xfb,0xff,0xff,0x8b,0x08,0x48,0x8b,0xc8,0x8b,0xd6,0x41,0xb8,0x20,0x00,0x00,0x00,0xe8,0x39,0x46,0xfc,0x5c,0x48,0x8b,0xd0,0x49,0x8b,0xce,0xe8,0x6e,0x91,0x96,0x5d,0x48,0x8d,0x4c,0x24,0x28,0x48,0x89,0x29,0x89,0x59,0x08,0x48,0x8d,0x4c,0x24,0x28,0x0f,0xb7,0xd7,0xe8,0x76,0xb3,0xa6,0xfe,0x90,0x48,0x81,0xc4,0xf8,0x00,0x00,0x00,0x5b,0x5d,0x5e,0x5f,0x41,0x5e,0x41,0x5f,0xc3,0xe8,0xd0,0xfc,0xe4,0xfd};

        public static ReadOnlySpan<byte> format_ᐤFieldRecordᕀinㆍcharᐤ  =>  new byte[992]{0x41,0x57,0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x81,0xec,0x88,0x01,0x00,0x00,0xc5,0xf8,0x77,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x28,0xb9,0x58,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x8b,0xf1,0x8b,0xfa,0xba,0x07,0x00,0x00,0x00,0x48,0xb9,0x90,0x75,0xa9,0xad,0xf9,0x7f,0x00,0x00,0xe8,0x51,0xa1,0x96,0x5d,0x48,0x8b,0xd8,0x48,0x8b,0xcb,0xe8,0xd6,0x47,0x90,0x5d,0x48,0x8b,0xe8,0x48,0xb9,0x92,0xf8,0xa7,0xad,0xf9,0x7f,0x00,0x00,0xe8,0x64,0xdd,0x8f,0x5d,0x48,0x3b,0xe8,0x0f,0x85,0x76,0x03,0x00,0x00,0x48,0x8d,0x6b,0x10,0x8b,0x5b,0x08,0x48,0x89,0xac,0x24,0x48,0x01,0x00,0x00,0x89,0x9c,0x24,0x50,0x01,0x00,0x00,0xc5,0xfa,0x6f,0x84,0x24,0x48,0x01,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0x38,0x01,0x00,0x00,0x4c,0x8b,0xb4,0x24,0x38,0x01,0x00,0x00,0x8b,0x4e,0x10,0x48,0xba,0x55,0x43,0x73,0x2b,0xa0,0x02,0x00,0x00,0x44,0x0f,0xb6,0x3a,0x33,0xd2,0x45,0x33,0xc0,0x48,0x8d,0x44,0x24,0x38,0x48,0x89,0x10,0x44,0x89,0x40,0x08,0x48,0x8d,0x54,0x24,0x38,0x45,0x33,0xc0,0xe8,0xcc,0xd8,0xf2,0x5c,0x8b,0x08,0x48,0x8b,0xc8,0x41,0x8b,0xd7,0x41,0xb8,0x20,0x00,0x00,0x00,0xe8,0xf9,0x44,0xfc,0x5c,0x48,0x8b,0xd0,0x49,0x8b,0xce,0xe8,0x2e,0x90,0x96,0x5d,0x48,0x89,0xac,0x24,0x28,0x01,0x00,0x00,0x89,0x9c,0x24,0x30,0x01,0x00,0x00,0xc5,0xfa,0x6f,0x84,0x24,0x28,0x01,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0x18,0x01,0x00,0x00,0x4c,0x8b,0xb4,0x24,0x18,0x01,0x00,0x00,0x49,0x83,0xc6,0x08,0x8b,0x4e,0x14,0x48,0xba,0x56,0x43,0x73,0x2b,0xa0,0x02,0x00,0x00,0x44,0x0f,0xb6,0x3a,0x33,0xd2,0x89,0x54,0x24,0x20,0xba,0x01,0x00,0x00,0x00,0x41,0xb8,0x01,0x00,0x00,0x00,0x45,0x33,0xc9,0xe8,0x1f,0x22,0xe5,0xfd,0x8b,0x08,0x48,0x8b,0xc8,0x41,0x8b,0xd7,0x41,0xb8,0x20,0x00,0x00,0x00,0xe8,0x84,0x44,0xfc,0x5c,0x48,0x8b,0xd0,0x49,0x8b,0xce,0xe8,0xb9,0x8f,0x96,0x5d,0x48,0x89,0xac,0x24,0x08,0x01,0x00,0x00,0x89,0x9c,0x24,0x10,0x01,0x00,0x00,0xc5,0xfa,0x6f,0x84,0x24,0x08,0x01,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0xf8,0x00,0x00,0x00,0x4c,0x8b,0xb4,0x24,0xf8,0x00,0x00,0x00,0x49,0x83,0xc6,0x10,0x8b,0x4e,0x18,0x48,0xba,0x57,0x43,0x73,0x2b,0xa0,0x02,0x00,0x00,0x44,0x0f,0xb6,0x3a,0x33,0xd2,0x89,0x54,0x24,0x20,0xba,0x01,0x00,0x00,0x00,0x41,0xb8,0x01,0x00,0x00,0x00,0x45,0x33,0xc9,0xe8,0xaa,0x21,0xe5,0xfd,0x8b,0x08,0x48,0x8b,0xc8,0x41,0x8b,0xd7,0x41,0xb8,0x20,0x00,0x00,0x00,0xe8,0x0f,0x44,0xfc,0x5c,0x48,0x8b,0xd0,0x49,0x8b,0xce,0xe8,0x44,0x8f,0x96,0x5d,0x48,0x89,0xac,0x24,0xe8,0x00,0x00,0x00,0x89,0x9c,0x24,0xf0,0x00,0x00,0x00,0xc5,0xfa,0x6f,0x84,0x24,0xe8,0x00,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0xd8,0x00,0x00,0x00,0x4c,0x8b,0xb4,0x24,0xd8,0x00,0x00,0x00,0x49,0x83,0xc6,0x18,0x48,0x8d,0x4e,0x20,0xc5,0xfa,0x6f,0x01,0xc5,0xfa,0x7f,0x84,0x24,0x70,0x01,0x00,0x00,0x48,0x8b,0x51,0x10,0x48,0x89,0x94,0x24,0x80,0x01,0x00,0x00,0xc5,0xfa,0x6f,0x84,0x24,0x70,0x01,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0xc0,0x00,0x00,0x00,0x48,0x8b,0x8c,0x24,0x80,0x01,0x00,0x00,0x48,0x89,0x8c,0x24,0xd0,0x00,0x00,0x00,0x48,0xb9,0x58,0x43,0x73,0x2b,0xa0,0x02,0x00,0x00,0x44,0x0f,0xb6,0x39,0x48,0x8d,0x8c,0x24,0xc0,0x00,0x00,0x00,0xba,0x7c,0x00,0x00,0x00,0xe8,0x40,0xb0,0xa6,0xfe,0x8b,0x08,0x48,0x8b,0xc8,0x41,0x8b,0xd7,0x41,0xb8,0x20,0x00,0x00,0x00,0xe8,0x65,0x43,0xfc,0x5c,0x48,0x8b,0xd0,0x49,0x8b,0xce,0xe8,0x9a,0x8e,0x96,0x5d,0x48,0x89,0xac,0x24,0xb0,0x00,0x00,0x00,0x89,0x9c,0x24,0xb8,0x00,0x00,0x00,0xc5,0xfa,0x6f,0x84,0x24,0xb0,0x00,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0xa0,0x00,0x00,0x00,0x4c,0x8b,0xb4,0x24,0xa0,0x00,0x00,0x00,0x49,0x83,0xc6,0x20,0x48,0x8d,0x4e,0x38,0xc5,0xfa,0x6f,0x01,0xc5,0xfa,0x7f,0x84,0x24,0x58,0x01,0x00,0x00,0x48,0x8b,0x51,0x10,0x48,0x89,0x94,0x24,0x68,0x01,0x00,0x00,0xc5,0xfa,0x6f,0x84,0x24,0x58,0x01,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0x88,0x00,0x00,0x00,0x48,0x8b,0x8c,0x24,0x68,0x01,0x00,0x00,0x48,0x89,0x8c,0x24,0x98,0x00,0x00,0x00,0x48,0xb9,0x59,0x43,0x73,0x2b,0xa0,0x02,0x00,0x00,0x44,0x0f,0xb6,0x39,0x48,0x8d,0x8c,0x24,0x88,0x00,0x00,0x00,0xba,0x7c,0x00,0x00,0x00,0xe8,0xbe,0xf7,0xff,0xff,0x8b,0x08,0x48,0x8b,0xc8,0x41,0x8b,0xd7,0x41,0xb8,0x20,0x00,0x00,0x00,0xe8,0xbb,0x42,0xfc,0x5c,0x48,0x8b,0xd0,0x49,0x8b,0xce,0xe8,0xf0,0x8d,0x96,0x5d,0x48,0x89,0x6c,0x24,0x78,0x89,0x9c,0x24,0x80,0x00,0x00,0x00,0xc5,0xfa,0x6f,0x44,0x24,0x78,0xc5,0xfa,0x7f,0x44,0x24,0x68,0x4c,0x8b,0x74,0x24,0x68,0x49,0x83,0xc6,0x28,0x48,0x8b,0x0e,0x48,0xba,0x5a,0x43,0x73,0x2b,0xa0,0x02,0x00,0x00,0x0f,0xb6,0x12,0x44,0x8b,0x01,0x41,0xb8,0x20,0x00,0x00,0x00,0xe8,0x71,0x42,0xfc,0x5c,0x48,0x8b,0xd0,0x49,0x8b,0xce,0xe8,0xa6,0x8d,0x96,0x5d,0x48,0x89,0x6c,0x24,0x58,0x89,0x5c,0x24,0x60,0xc5,0xfa,0x6f,0x44,0x24,0x58,0xc5,0xfa,0x7f,0x44,0x24,0x48,0x4c,0x8b,0x74,0x24,0x48,0x49,0x83,0xc6,0x30,0x48,0x8b,0x4e,0x08,0x48,0xba,0x5b,0x43,0x73,0x2b,0xa0,0x02,0x00,0x00,0x0f,0xb6,0x12,0x44,0x8b,0x01,0x41,0xb8,0x20,0x00,0x00,0x00,0xe8,0x29,0x42,0xfc,0x5c,0x48,0x8b,0xd0,0x49,0x8b,0xce,0xe8,0x5e,0x8d,0x96,0x5d,0x48,0x8d,0x4c,0x24,0x28,0x48,0x89,0x29,0x89,0x59,0x08,0x48,0x8d,0x4c,0x24,0x28,0x0f,0xb7,0xd7,0xe8,0x66,0xaf,0xa6,0xfe,0x90,0x48,0x81,0xc4,0x88,0x01,0x00,0x00,0x5b,0x5d,0x5e,0x5f,0x41,0x5e,0x41,0x5f,0xc3,0xe8,0xc0,0xf8,0xe4,0xfd};

        public static ReadOnlySpan<byte> format_ᐤLiteralRecordᕀinㆍcharᐤ  =>  new byte[654]{0x41,0x57,0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x81,0xec,0xe8,0x00,0x00,0x00,0xc5,0xf8,0x77,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x28,0xb9,0x30,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x8b,0xf1,0x8b,0xfa,0xba,0x05,0x00,0x00,0x00,0x48,0xb9,0x90,0x75,0xa9,0xad,0xf9,0x7f,0x00,0x00,0xe8,0x31,0x9d,0x96,0x5d,0x48,0x8b,0xd8,0x48,0x8b,0xcb,0xe8,0xb6,0x43,0x90,0x5d,0x48,0x8b,0xe8,0x48,0xb9,0x92,0xf8,0xa7,0xad,0xf9,0x7f,0x00,0x00,0xe8,0x44,0xd9,0x8f,0x5d,0x48,0x3b,0xe8,0x0f,0x85,0x24,0x02,0x00,0x00,0x48,0x8d,0x6b,0x10,0x8b,0x5b,0x08,0x48,0x89,0xac,0x24,0xd8,0x00,0x00,0x00,0x89,0x9c,0x24,0xe0,0x00,0x00,0x00,0xc5,0xfa,0x6f,0x84,0x24,0xd8,0x00,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0xc8,0x00,0x00,0x00,0x4c,0x8b,0xb4,0x24,0xc8,0x00,0x00,0x00,0x8b,0x4e,0x08,0x48,0xba,0x35,0x43,0x73,0x2b,0xa0,0x02,0x00,0x00,0x44,0x0f,0xb6,0x3a,0x33,0xd2,0x45,0x33,0xc0,0x48,0x8d,0x44,0x24,0x38,0x48,0x89,0x10,0x44,0x89,0x40,0x08,0x48,0x8d,0x54,0x24,0x38,0x45,0x33,0xc0,0xe8,0xac,0xd4,0xf2,0x5c,0x8b,0x08,0x48,0x8b,0xc8,0x41,0x8b,0xd7,0x41,0xb8,0x20,0x00,0x00,0x00,0xe8,0xd9,0x40,0xfc,0x5c,0x48,0x8b,0xd0,0x49,0x8b,0xce,0xe8,0x0e,0x8c,0x96,0x5d,0x48,0x89,0xac,0x24,0xb8,0x00,0x00,0x00,0x89,0x9c,0x24,0xc0,0x00,0x00,0x00,0xc5,0xfa,0x6f,0x84,0x24,0xb8,0x00,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0xa8,0x00,0x00,0x00,0x4c,0x8b,0xb4,0x24,0xa8,0x00,0x00,0x00,0x49,0x83,0xc6,0x08,0x8b,0x4e,0x0c,0x48,0xba,0x36,0x43,0x73,0x2b,0xa0,0x02,0x00,0x00,0x44,0x0f,0xb6,0x3a,0x33,0xd2,0x89,0x54,0x24,0x20,0xba,0x01,0x00,0x00,0x00,0x41,0xb8,0x01,0x00,0x00,0x00,0x45,0x33,0xc9,0xe8,0xff,0x1d,0xe5,0xfd,0x8b,0x08,0x48,0x8b,0xc8,0x41,0x8b,0xd7,0x41,0xb8,0x20,0x00,0x00,0x00,0xe8,0x64,0x40,0xfc,0x5c,0x48,0x8b,0xd0,0x49,0x8b,0xce,0xe8,0x99,0x8b,0x96,0x5d,0x48,0x89,0xac,0x24,0x98,0x00,0x00,0x00,0x89,0x9c,0x24,0xa0,0x00,0x00,0x00,0xc5,0xfa,0x6f,0x84,0x24,0x98,0x00,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0x88,0x00,0x00,0x00,0x4c,0x8b,0xb4,0x24,0x88,0x00,0x00,0x00,0x49,0x83,0xc6,0x10,0x8b,0x4e,0x10,0x48,0xba,0x37,0x43,0x73,0x2b,0xa0,0x02,0x00,0x00,0x44,0x0f,0xb6,0x3a,0x33,0xd2,0x45,0x33,0xc0,0x48,0x8d,0x44,0x24,0x38,0x48,0x89,0x10,0x44,0x89,0x40,0x08,0x48,0x8d,0x54,0x24,0x38,0x45,0x33,0xc0,0xe8,0xbd,0xd3,0xf2,0x5c,0x8b,0x08,0x48,0x8b,0xc8,0x41,0x8b,0xd7,0x41,0xb8,0x20,0x00,0x00,0x00,0xe8,0xea,0x3f,0xfc,0x5c,0x48,0x8b,0xd0,0x49,0x8b,0xce,0xe8,0x1f,0x8b,0x96,0x5d,0x48,0x89,0x6c,0x24,0x78,0x89,0x9c,0x24,0x80,0x00,0x00,0x00,0xc5,0xfa,0x6f,0x44,0x24,0x78,0xc5,0xfa,0x7f,0x44,0x24,0x68,0x4c,0x8b,0x74,0x24,0x68,0x49,0x83,0xc6,0x18,0x8b,0x4e,0x14,0x48,0xba,0x38,0x43,0x73,0x2b,0xa0,0x02,0x00,0x00,0x44,0x0f,0xb6,0x3a,0x33,0xd2,0x89,0x54,0x24,0x20,0xba,0x01,0x00,0x00,0x00,0x41,0xb8,0x01,0x00,0x00,0x00,0x45,0x33,0xc9,0xe8,0x1c,0x1d,0xe5,0xfd,0x8b,0x08,0x48,0x8b,0xc8,0x41,0x8b,0xd7,0x41,0xb8,0x20,0x00,0x00,0x00,0xe8,0x81,0x3f,0xfc,0x5c,0x48,0x8b,0xd0,0x49,0x8b,0xce,0xe8,0xb6,0x8a,0x96,0x5d,0x48,0x89,0x6c,0x24,0x58,0x89,0x5c,0x24,0x60,0xc5,0xfa,0x6f,0x44,0x24,0x58,0xc5,0xfa,0x7f,0x44,0x24,0x48,0x48,0x8b,0x4c,0x24,0x48,0x48,0x83,0xc1,0x20,0x48,0x8b,0x16,0xe8,0x90,0x8a,0x96,0x5d,0x48,0x8d,0x4c,0x24,0x28,0x48,0x89,0x29,0x89,0x59,0x08,0x48,0x8d,0x4c,0x24,0x28,0x0f,0xb7,0xd7,0xe8,0x98,0xac,0xa6,0xfe,0x90,0x48,0x81,0xc4,0xe8,0x00,0x00,0x00,0x5b,0x5d,0x5e,0x5f,0x41,0x5e,0x41,0x5f,0xc3,0xe8,0xf2,0xf5,0xe4,0xfd};

        public static ReadOnlySpan<byte> format_ᐤStringValueRecordᕀinㆍcharᐤ  =>  new byte[654]{0x41,0x57,0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x81,0xec,0xe8,0x00,0x00,0x00,0xc5,0xf8,0x77,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x28,0xb9,0x30,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x8b,0xf1,0x8b,0xfa,0xba,0x05,0x00,0x00,0x00,0x48,0xb9,0x90,0x75,0xa9,0xad,0xf9,0x7f,0x00,0x00,0xe8,0x61,0x96,0x96,0x5d,0x48,0x8b,0xd8,0x48,0x8b,0xcb,0xe8,0xe6,0x3c,0x90,0x5d,0x48,0x8b,0xe8,0x48,0xb9,0x92,0xf8,0xa7,0xad,0xf9,0x7f,0x00,0x00,0xe8,0x74,0xd2,0x8f,0x5d,0x48,0x3b,0xe8,0x0f,0x85,0x24,0x02,0x00,0x00,0x48,0x8d,0x6b,0x10,0x8b,0x5b,0x08,0x48,0x89,0xac,0x24,0xd8,0x00,0x00,0x00,0x89,0x9c,0x24,0xe0,0x00,0x00,0x00,0xc5,0xfa,0x6f,0x84,0x24,0xd8,0x00,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0xc8,0x00,0x00,0x00,0x4c,0x8b,0xb4,0x24,0xc8,0x00,0x00,0x00,0x8b,0x4e,0x08,0x48,0xba,0x35,0x43,0x73,0x2b,0xa0,0x02,0x00,0x00,0x44,0x0f,0xb6,0x3a,0x33,0xd2,0x45,0x33,0xc0,0x48,0x8d,0x44,0x24,0x38,0x48,0x89,0x10,0x44,0x89,0x40,0x08,0x48,0x8d,0x54,0x24,0x38,0x45,0x33,0xc0,0xe8,0xdc,0xcd,0xf2,0x5c,0x8b,0x08,0x48,0x8b,0xc8,0x41,0x8b,0xd7,0x41,0xb8,0x20,0x00,0x00,0x00,0xe8,0x09,0x3a,0xfc,0x5c,0x48,0x8b,0xd0,0x49,0x8b,0xce,0xe8,0x3e,0x85,0x96,0x5d,0x48,0x89,0xac,0x24,0xb8,0x00,0x00,0x00,0x89,0x9c,0x24,0xc0,0x00,0x00,0x00,0xc5,0xfa,0x6f,0x84,0x24,0xb8,0x00,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0xa8,0x00,0x00,0x00,0x4c,0x8b,0xb4,0x24,0xa8,0x00,0x00,0x00,0x49,0x83,0xc6,0x08,0x8b,0x4e,0x0c,0x48,0xba,0x36,0x43,0x73,0x2b,0xa0,0x02,0x00,0x00,0x44,0x0f,0xb6,0x3a,0x33,0xd2,0x89,0x54,0x24,0x20,0xba,0x01,0x00,0x00,0x00,0x41,0xb8,0x01,0x00,0x00,0x00,0x45,0x33,0xc9,0xe8,0x2f,0x17,0xe5,0xfd,0x8b,0x08,0x48,0x8b,0xc8,0x41,0x8b,0xd7,0x41,0xb8,0x20,0x00,0x00,0x00,0xe8,0x94,0x39,0xfc,0x5c,0x48,0x8b,0xd0,0x49,0x8b,0xce,0xe8,0xc9,0x84,0x96,0x5d,0x48,0x89,0xac,0x24,0x98,0x00,0x00,0x00,0x89,0x9c,0x24,0xa0,0x00,0x00,0x00,0xc5,0xfa,0x6f,0x84,0x24,0x98,0x00,0x00,0x00,0xc5,0xfa,0x7f,0x84,0x24,0x88,0x00,0x00,0x00,0x4c,0x8b,0xb4,0x24,0x88,0x00,0x00,0x00,0x49,0x83,0xc6,0x10,0x8b,0x4e,0x10,0x48,0xba,0x37,0x43,0x73,0x2b,0xa0,0x02,0x00,0x00,0x44,0x0f,0xb6,0x3a,0x33,0xd2,0x45,0x33,0xc0,0x48,0x8d,0x44,0x24,0x38,0x48,0x89,0x10,0x44,0x89,0x40,0x08,0x48,0x8d,0x54,0x24,0x38,0x45,0x33,0xc0,0xe8,0xed,0xcc,0xf2,0x5c,0x8b,0x08,0x48,0x8b,0xc8,0x41,0x8b,0xd7,0x41,0xb8,0x20,0x00,0x00,0x00,0xe8,0x1a,0x39,0xfc,0x5c,0x48,0x8b,0xd0,0x49,0x8b,0xce,0xe8,0x4f,0x84,0x96,0x5d,0x48,0x89,0x6c,0x24,0x78,0x89,0x9c,0x24,0x80,0x00,0x00,0x00,0xc5,0xfa,0x6f,0x44,0x24,0x78,0xc5,0xfa,0x7f,0x44,0x24,0x68,0x4c,0x8b,0x74,0x24,0x68,0x49,0x83,0xc6,0x18,0x8b,0x4e,0x14,0x48,0xba,0x38,0x43,0x73,0x2b,0xa0,0x02,0x00,0x00,0x44,0x0f,0xb6,0x3a,0x33,0xd2,0x89,0x54,0x24,0x20,0xba,0x01,0x00,0x00,0x00,0x41,0xb8,0x01,0x00,0x00,0x00,0x45,0x33,0xc9,0xe8,0x4c,0x16,0xe5,0xfd,0x8b,0x08,0x48,0x8b,0xc8,0x41,0x8b,0xd7,0x41,0xb8,0x20,0x00,0x00,0x00,0xe8,0xb1,0x38,0xfc,0x5c,0x48,0x8b,0xd0,0x49,0x8b,0xce,0xe8,0xe6,0x83,0x96,0x5d,0x48,0x89,0x6c,0x24,0x58,0x89,0x5c,0x24,0x60,0xc5,0xfa,0x6f,0x44,0x24,0x58,0xc5,0xfa,0x7f,0x44,0x24,0x48,0x48,0x8b,0x4c,0x24,0x48,0x48,0x83,0xc1,0x20,0x48,0x8b,0x16,0xe8,0xc0,0x83,0x96,0x5d,0x48,0x8d,0x4c,0x24,0x28,0x48,0x89,0x29,0x89,0x59,0x08,0x48,0x8d,0x4c,0x24,0x28,0x0f,0xb7,0xd7,0xe8,0xc8,0xa5,0xa6,0xfe,0x90,0x48,0x81,0xc4,0xe8,0x00,0x00,0x00,0x5b,0x5d,0x5e,0x5f,0x41,0x5e,0x41,0x5f,0xc3,0xe8,0x22,0xef,0xe4,0xfd};

    }
}
