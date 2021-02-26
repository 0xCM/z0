//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
// Generated   : 2021-02-25 19:10:09 -06:00
//-----------------------------------------------------------------------------
namespace Z0.ByteCode
{
    using System;
    using System.Runtime.CompilerServices;


    public static class cli_imagearchives
    {
        public static ReadOnlySpan<byte> csvreader_ᐤIWfShellㆍFilePathᐤ  =>  new byte[173]{0x57,0x56,0x53,0x48,0x83,0xec,0x60,0xc5,0xf8,0x77,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x28,0xb9,0x0e,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x8b,0xf1,0x48,0x8b,0xda,0x48,0x8b,0xcb,0xe8,0xa4,0xb2,0x64,0x65,0x85,0xc0,0x74,0x6d,0x33,0xc9,0x48,0x8d,0x54,0x24,0x28,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x02,0xc5,0xfa,0x7f,0x42,0x10,0xc5,0xfa,0x7f,0x42,0x20,0x48,0x89,0x4a,0x30,0x48,0x8d,0x4c,0x24,0x28,0x48,0x8b,0xd6,0x4c,0x8b,0xc3,0xe8,0xdb,0xc6,0xf0,0xfc,0x48,0xb9,0x68,0xfe,0xb2,0xde,0xfd,0x7f,0x00,0x00,0xe8,0x74,0x86,0x4b,0x5a,0x48,0x8b,0xd8,0x48,0x8d,0x7b,0x08,0x48,0x8d,0x74,0x24,0x28,0xe8,0x43,0x78,0x4b,0x5a,0xe8,0x3e,0x78,0x4b,0x5a,0xe8,0x39,0x78,0x4b,0x5a,0x48,0xa5,0xe8,0x32,0x78,0x4b,0x5a,0x48,0xa5,0x48,0xa5,0x48,0x8b,0xc3,0x48,0x83,0xc4,0x60,0x5b,0x5e,0x5f,0xc3,0x48,0x8b,0xcb,0xe8,0x5b,0x10,0x8f,0xff,0x48,0x8b,0xc8,0xe8,0xb3,0xe6,0x21,0xff};

        public static ReadOnlySpan<byte> pipe_ᐤIWfShellㆍFilePathㆍRecordSinkᐸImageContentᐳᐤ  =>  new byte[192]{0x55,0x56,0x48,0x83,0xec,0x48,0x48,0x8d,0x6c,0x24,0x50,0x33,0xc0,0x48,0x89,0x45,0xe8,0x48,0x89,0x45,0xf0,0x48,0x89,0x65,0xd0,0x4c,0x89,0x45,0x20,0xe8,0xfe,0xfa,0xff,0xff,0x48,0x89,0x45,0xe0,0x33,0xd2,0x48,0x89,0x55,0xe8,0x33,0xd2,0x48,0x89,0x55,0xf0,0xbe,0x01,0x00,0x00,0x00,0x48,0x8d,0x55,0xe8,0x48,0x8b,0x4d,0xe0,0x49,0xbb,0x20,0x2f,0xc7,0xdb,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0x6f,0x39,0x89,0xfa,0x85,0xc0,0x74,0x0f,0x48,0x8d,0x4d,0x20,0x48,0x8d,0x55,0xe8,0xe8,0x86,0x0d,0x47,0xfe,0xeb,0x02,0x33,0xf6,0x85,0xf6,0x75,0xcd,0x48,0x8b,0x4d,0xe0,0x49,0xbb,0x28,0x2f,0xc7,0xdb,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0x48,0x39,0x89,0xfa,0x90,0x48,0x8d,0x65,0xf8,0x5e,0x5d,0xc3,0x55,0x56,0x48,0x83,0xec,0x28,0x48,0x8b,0x69,0x20,0x48,0x89,0x6c,0x24,0x20,0x48,0x8d,0x6d,0x50,0x48,0x83,0x7d,0xe0,0x00,0x74,0x16,0x48,0x8b,0x4d,0xe0,0x49,0xbb,0x28,0x2f,0xc7,0xdb,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0x10,0x39,0x89,0xfa,0x90,0x48,0x83,0xc4,0x28,0x5e,0x5d,0xc3};

        public static ReadOnlySpan<byte> EmitBuildArchiveList_ᐤIWfShellㆍFolderPathㆍstringᐤ  =>  new byte[883]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x81,0xec,0xe0,0x00,0x00,0x00,0xc5,0xf8,0x77,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x28,0xb9,0x2e,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x8b,0xd9,0x48,0x8b,0xf2,0x49,0x8b,0xe8,0x48,0x8d,0x94,0x24,0xd0,0x00,0x00,0x00,0x48,0x8b,0xcb,0x49,0xbb,0x30,0x2f,0xc7,0xdb,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0x96,0x38,0x89,0xfa,0x33,0xc9,0x48,0x8d,0x54,0x24,0x70,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x02,0x48,0x89,0x4a,0x10,0x48,0x89,0x5c,0x24,0x70,0x48,0x8d,0x4c,0x24,0x78,0x48,0x89,0x31,0x48,0x8d,0x4c,0x24,0x50,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0x48,0x8d,0x4c,0x24,0x50,0x48,0x89,0x31,0x48,0xb9,0xf8,0xbb,0xb8,0xde,0xfd,0x7f,0x00,0x00,0xba,0x05,0x00,0x00,0x00,0xe8,0xad,0x81,0x4b,0x5a,0x48,0x8b,0xf8,0xe8,0x85,0xc0,0xb8,0xfe,0x48,0x8d,0x4f,0x10,0x48,0x8b,0xd0,0xe8,0xa9,0x71,0x4b,0x5a,0xe8,0xf4,0x4a,0x9f,0xfd,0x48,0x8d,0x4f,0x18,0x48,0x8b,0xd0,0xe8,0x98,0x71,0x4b,0x5a,0xe8,0x4b,0x4b,0x9f,0xfd,0x48,0x8d,0x4f,0x20,0x48,0x8b,0xd0,0xe8,0x87,0x71,0x4b,0x5a,0xe8,0x1a,0x4b,0x9f,0xfd,0x48,0x8d,0x4f,0x28,0x48,0x8b,0xd0,0xe8,0x76,0x71,0x4b,0x5a,0xe8,0x61,0x4b,0x9f,0xfd,0x48,0x8d,0x4f,0x30,0x48,0x8b,0xd0,0xe8,0x65,0x71,0x4b,0x5a,0x48,0x8b,0xce,0x4c,0x8b,0xc7,0x33,0xd2,0xe8,0x70,0x47,0x9c,0xfa,0x48,0x89,0x44,0x24,0x48,0x48,0xb9,0xe8,0x4d,0xf7,0xdb,0xfd,0x7f,0x00,0x00,0xba,0xc3,0x07,0x00,0x00,0xe8,0xff,0x83,0x4b,0x5a,0x48,0xb9,0xe8,0x65,0x2c,0xe7,0x8f,0x02,0x00,0x00,0x48,0x8b,0x11,0x48,0x8d,0x74,0x24,0x50,0x48,0x8d,0x7c,0x24,0x48,0x48,0x85,0xd2,0x75,0x54,0x48,0xb9,0xc8,0xea,0xfa,0xdb,0xfd,0x7f,0x00,0x00,0xe8,0xd4,0x7f,0x4b,0x5a,0x4c,0x8b,0xf0,0x48,0xba,0xe0,0x65,0x2c,0xe7,0x8f,0x02,0x00,0x00,0x48,0x8b,0x12,0x48,0x85,0xd2,0x0f,0x84,0x16,0x02,0x00,0x00,0x49,0x8d,0x4e,0x08,0xe8,0xf2,0x70,0x4b,0x5a,0x48,0xba,0x38,0x41,0xdd,0xde,0xfd,0x7f,0x00,0x00,0x49,0x89,0x56,0x18,0x48,0xb9,0xe8,0x65,0x2c,0xe7,0x8f,0x02,0x00,0x00,0x49,0x8b,0xd6,0xe8,0xa2,0x70,0x4b,0x5a,0x49,0x8b,0xd6,0x48,0x8b,0x0f,0x48,0x85,0xc9,0x75,0x07,0x33,0xc0,0x45,0x33,0xc0,0xeb,0x08,0x48,0x8d,0x41,0x10,0x44,0x8b,0x41,0x08,0x48,0x8d,0x4c,0x24,0x38,0x48,0x89,0x01,0x44,0x89,0x41,0x08,0x48,0x8d,0x4c,0x24,0x38,0xe8,0xc2,0x0f,0x9d,0xfa,0x48,0x8d,0x4e,0x08,0x48,0x8b,0xd0,0xe8,0x66,0x70,0x4b,0x5a,0xc5,0xfa,0x6f,0x44,0x24,0x50,0xc5,0xfa,0x7f,0x44,0x24,0x60,0x48,0x8b,0x4c,0x24,0x68,0x48,0x89,0x8c,0x24,0x80,0x00,0x00,0x00,0x48,0xb9,0xa0,0xfe,0xfe,0xde,0xfd,0x7f,0x00,0x00,0xe8,0x2e,0x7f,0x4b,0x5a,0x4c,0x8b,0xf0,0x49,0x8d,0x7e,0x08,0x48,0x8d,0x74,0x24,0x70,0xe8,0xfd,0x70,0x4b,0x5a,0xe8,0xf8,0x70,0x4b,0x5a,0xe8,0xf3,0x70,0x4b,0x5a,0x48,0xb9,0xf8,0xbb,0xb8,0xde,0xfd,0x7f,0x00,0x00,0xba,0x06,0x00,0x00,0x00,0xe8,0x2f,0x80,0x4b,0x5a,0x48,0x8b,0xf0,0x49,0x8b,0xce,0xe8,0x14,0xd7,0xd4,0xfa,0x48,0x8d,0x4e,0x10,0x48,0x8b,0xd0,0xe8,0x28,0x70,0x4b,0x5a,0x49,0x8b,0xce,0xe8,0x30,0xd7,0xd4,0xfa,0x48,0x8d,0x4e,0x18,0x48,0x8b,0xd0,0xe8,0x14,0x70,0x4b,0x5a,0x49,0x8b,0xce,0xe8,0xf4,0xd6,0xd4,0xfa,0x48,0x8d,0x4e,0x20,0x48,0x8b,0xd0,0xe8,0x00,0x70,0x4b,0x5a,0x49,0x8b,0xce,0xe8,0x48,0xd7,0xd4,0xfa,0x48,0x8d,0x4e,0x28,0x48,0x8b,0xd0,0xe8,0xec,0x6f,0x4b,0x5a,0x49,0x8b,0xce,0xe8,0xd4,0xd6,0xd4,0xfa,0x48,0x8d,0x4e,0x30,0x48,0x8b,0xd0,0xe8,0xd8,0x6f,0x4b,0x5a,0x49,0x8b,0xce,0xe8,0xc8,0xd6,0xd4,0xfa,0x48,0x8d,0x4e,0x38,0x48,0x8b,0xd0,0xe8,0xc4,0x6f,0x4b,0x5a,0x48,0x8b,0xce,0xe8,0xcc,0xf8,0xff,0xff,0x48,0x8b,0xf0,0x48,0xba,0xd0,0xe6,0x68,0xe7,0x8f,0x02,0x00,0x00,0x48,0x8b,0x12,0x48,0x8b,0xcd,0xe8,0x74,0xa2,0x06,0x4c,0x48,0x8b,0xf8,0x49,0x8b,0xce,0xe8,0x11,0xab,0x9c,0xfd,0x4c,0x8b,0xc8,0x48,0x8d,0x8c,0x24,0xa8,0x00,0x00,0x00,0x48,0x8d,0x54,0x24,0x28,0x4c,0x8b,0x84,0x24,0xd0,0x00,0x00,0x00,0x4c,0x89,0x02,0x4c,0x8b,0x84,0x24,0xd8,0x00,0x00,0x00,0x4c,0x89,0x42,0x08,0x48,0x89,0x74,0x24,0x20,0x48,0x8d,0x54,0x24,0x28,0x4c,0x8b,0xc7,0xe8,0x48,0x47,0xf1,0xfc,0x48,0xb9,0xe8,0xc4,0xb8,0xde,0xfd,0x7f,0x00,0x00,0xe8,0x11,0x7e,0x4b,0x5a,0x48,0x8b,0xe8,0x48,0x8b,0xcb,0x49,0xbb,0x70,0x2f,0xc7,0xdb,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0x09,0x36,0x89,0xfa,0x48,0x8b,0xd8,0x48,0x8d,0x7d,0x08,0x48,0x8d,0xb4,0x24,0xa8,0x00,0x00,0x00,0xe8,0xc5,0x6f,0x4b,0x5a,0x48,0xa5,0xe8,0xbe,0x6f,0x4b,0x5a,0xe8,0xb9,0x6f,0x4b,0x5a,0xe8,0xb4,0x6f,0x4b,0x5a,0x4c,0x8b,0xc5,0x48,0x8d,0x94,0x24,0x88,0x00,0x00,0x00,0x48,0x8b,0xcb,0x49,0xbb,0x78,0x2f,0xc7,0xdb,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0xcc,0x35,0x89,0xfa,0x90,0x48,0x81,0xc4,0xe0,0x00,0x00,0x00,0x5b,0x5d,0x5e,0x5f,0x41,0x5e,0xc3,0x49,0x8b,0xce,0xe8,0xed,0x41,0x9b,0xfa};

        public static ReadOnlySpan<byte> tables_ᐤIWfShellᐤ  =>  new byte[115]{0x56,0x48,0x83,0xec,0x30,0x33,0xc0,0x48,0x89,0x44,0x24,0x28,0x49,0xbb,0x80,0x2f,0xc7,0xdb,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0x72,0x35,0x89,0xfa,0x48,0x8b,0xf0,0x48,0x8b,0xce,0x48,0xba,0x00,0xc6,0x1f,0xdc,0xfd,0x7f,0x00,0x00,0x49,0xb8,0xa0,0x33,0x6e,0xe1,0xfd,0x7f,0x00,0x00,0xe8,0x63,0x66,0x39,0x5a,0x48,0x8b,0xce,0xff,0xd0,0x48,0x8d,0x4c,0x24,0x28,0x48,0x89,0x01,0x48,0xb9,0x38,0x00,0xff,0xde,0xfd,0x7f,0x00,0x00,0xe8,0x17,0x7d,0x4b,0x5a,0x48,0x8b,0xf0,0x48,0x8b,0x54,0x24,0x28,0x48,0x8d,0x4e,0x08,0xe8,0x46,0x6e,0x4b,0x5a,0x48,0x8b,0xc6,0x48,0x83,0xc4,0x30,0x5e,0xc3};

        public static ReadOnlySpan<byte> runtime_ᐤIWfShellᐤ  =>  new byte[270]{0x57,0x56,0x48,0x83,0xec,0x58,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x28,0xb9,0x0c,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x49,0xbb,0x88,0x2f,0xc7,0xdb,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0xdc,0x34,0x89,0xfa,0x48,0x8b,0xc8,0x48,0x8b,0x00,0x48,0x8b,0x40,0x48,0xff,0x50,0x30,0x48,0x8b,0xd0,0x33,0xc9,0x48,0x89,0x4c,0x24,0x48,0x48,0x8d,0x4c,0x24,0x48,0xe8,0x73,0xbc,0xb8,0xfe,0x48,0x8b,0x4c,0x24,0x48,0xba,0x5c,0x00,0x00,0x00,0x41,0xb8,0x2f,0x00,0x00,0x00,0x39,0x09,0xe8,0xfc,0x27,0x0b,0x4c,0x48,0x8b,0xd0,0x33,0xc9,0x48,0x89,0x4c,0x24,0x40,0x48,0x8d,0x4c,0x24,0x40,0xe8,0x48,0xbc,0xb8,0xfe,0x48,0x8b,0x4c,0x24,0x40,0xe8,0xbe,0x8c,0x06,0x4c,0x48,0x8b,0xd0,0x33,0xc9,0x48,0x89,0x4c,0x24,0x30,0x48,0x8d,0x4c,0x24,0x30,0xe8,0x2a,0xbc,0xb8,0xfe,0x48,0x8b,0x4c,0x24,0x30,0xba,0x5c,0x00,0x00,0x00,0x41,0xb8,0x2f,0x00,0x00,0x00,0x39,0x09,0xe8,0xb3,0x27,0x0b,0x4c,0x48,0x8b,0xd0,0x33,0xc9,0x48,0x89,0x4c,0x24,0x28,0x48,0x8d,0x4c,0x24,0x28,0xe8,0xff,0xbb,0xb8,0xfe,0x33,0xc9,0x48,0x89,0x4c,0x24,0x38,0x48,0x8b,0x54,0x24,0x28,0x48,0x8d,0x4c,0x24,0x38,0xe8,0x69,0x7a,0x9c,0xfa,0x48,0x8b,0x4c,0x24,0x38,0x48,0x8d,0x44,0x24,0x50,0x48,0x89,0x08,0x48,0xb9,0x38,0x00,0xff,0xde,0xfd,0x7f,0x00,0x00,0xe8,0xed,0x7b,0x4b,0x5a,0x48,0x8b,0xf0,0x48,0x8b,0x54,0x24,0x50,0x48,0x8d,0x4e,0x08,0xe8,0x1c,0x6d,0x4b,0x5a,0x48,0x8b,0xc6,0x48,0x83,0xc4,0x58,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> build_ᐤIWfShellᐤ  =>  new byte[100]{0x56,0x48,0x83,0xec,0x30,0x33,0xc0,0x48,0x89,0x44,0x24,0x28,0x49,0xbb,0x90,0x2f,0xc7,0xdb,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0xc2,0x33,0x89,0xfa,0x48,0x8b,0xc8,0x49,0xbb,0x98,0x2f,0xc7,0xdb,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0xb5,0x33,0x89,0xfa,0x48,0x8d,0x4c,0x24,0x28,0x48,0x89,0x01,0x48,0xb9,0x38,0x00,0xff,0xde,0xfd,0x7f,0x00,0x00,0xe8,0x66,0x7b,0x4b,0x5a,0x48,0x8b,0xf0,0x48,0x8b,0x54,0x24,0x28,0x48,0x8d,0x4e,0x08,0xe8,0x95,0x6c,0x4b,0x5a,0x48,0x8b,0xc6,0x48,0x83,0xc4,0x30,0x5e,0xc3};

        public static ReadOnlySpan<byte> provider_ᐤ8uᕀptrㆍByteSizeᐤ  =>  new byte[16]{0x48,0x83,0xec,0x28,0x90,0xe8,0xb6,0xea,0xe9,0xfc,0x90,0x48,0x83,0xc4,0x28,0xc3};

        public static ReadOnlySpan<byte> provider_ᐤStreamㆍMetadataStreamOptionsᕀ32iᐤ  =>  new byte[21]{0x0f,0x1f,0x44,0x00,0x00,0x45,0x33,0xc0,0x48,0xb8,0x10,0xe7,0x27,0xde,0xfd,0x7f,0x00,0x00,0x48,0xff,0xe0};

        public static ReadOnlySpan<byte> pdbprovider_ᐤ8uᕀptrㆍByteSizeᐤ  =>  new byte[16]{0x48,0x83,0xec,0x28,0x90,0xe8,0x56,0xea,0xe9,0xfc,0x90,0x48,0x83,0xc4,0x28,0xc3};

        public static ReadOnlySpan<byte> pdbprovider_ᐤStreamㆍMetadataStreamOptionsᕀ32iᐤ  =>  new byte[21]{0x0f,0x1f,0x44,0x00,0x00,0x45,0x33,0xc0,0x48,0xb8,0x10,0xe7,0x27,0xde,0xfd,0x7f,0x00,0x00,0x48,0xff,0xe0};

    }
}
