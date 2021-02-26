//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
// Generated   : 2021-02-25 19:10:09 -06:00
//-----------------------------------------------------------------------------
namespace Z0.ByteCode
{
    using System;
    using System.Runtime.CompilerServices;


    public static class cmdspec_xcmd
    {
        public static ReadOnlySpan<byte> CheckBitmasks_ᐤCmdBuilderᐤ  =>  new byte[21]{0x50,0x33,0xc0,0x48,0x89,0x04,0x24,0xc6,0x04,0x24,0x00,0x48,0x0f,0xbe,0x04,0x24,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> CheckService_ᐤCmdBuilderㆍNameᐤ  =>  new byte[9]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> DumpCliTables_ᐤCmdBuilderㆍFilePathᐤ  =>  new byte[189]{0x57,0x56,0x53,0x48,0x83,0xec,0x40,0xc5,0xf8,0x77,0x33,0xc0,0x48,0x89,0x44,0x24,0x30,0x48,0x89,0x44,0x24,0x38,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x20,0x48,0x8b,0xd9,0x48,0x8d,0x4c,0x24,0x30,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0x48,0x8d,0x4c,0x24,0x30,0x4c,0x89,0x01,0x48,0x8b,0x72,0x08,0x49,0x8b,0xc8,0xe8,0x4c,0xff,0x09,0x4c,0x48,0x8b,0xd0,0x33,0xc9,0x48,0x89,0x4c,0x24,0x28,0x48,0x8d,0x4c,0x24,0x28,0xe8,0xa8,0x8f,0xb8,0xfe,0x48,0x8b,0x4c,0x24,0x28,0xe8,0xce,0x38,0x9c,0xfa,0x48,0x8b,0xd0,0x33,0xc9,0x48,0x89,0x4c,0x24,0x20,0x48,0x8d,0x4c,0x24,0x20,0xe8,0x8a,0x8f,0xb8,0xfe,0x48,0x8b,0x7c,0x24,0x20,0xe8,0xb8,0x88,0x9c,0xfd,0x4c,0x8b,0xc0,0x48,0x8b,0xce,0x48,0x8b,0xd7,0x49,0xbb,0x48,0x30,0xc7,0xdb,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0x6d,0x08,0x89,0xfa,0x48,0x89,0x44,0x24,0x38,0x48,0x8b,0xfb,0x48,0x8d,0x74,0x24,0x30,0xe8,0x53,0x41,0x4b,0x5a,0xe8,0x4e,0x41,0x4b,0x5a,0x48,0x8b,0xc3,0x48,0x83,0xc4,0x40,0x5b,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> DumpCliTables_ᐤCmdBuilderㆍAssemblyᐤ  =>  new byte[270]{0x57,0x56,0x53,0x48,0x83,0xec,0x50,0xc5,0xf8,0x77,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x20,0xb9,0x0c,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x8b,0xd9,0x48,0x8b,0xf2,0x48,0x8d,0x4c,0x24,0x40,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0x49,0x8b,0xc8,0x49,0x8b,0x00,0x48,0x8b,0x40,0x48,0xff,0x50,0x30,0x48,0x8b,0xd0,0x33,0xc9,0x48,0x89,0x4c,0x24,0x38,0x48,0x8d,0x4c,0x24,0x38,0xe8,0xce,0x8e,0xb8,0xfe,0x48,0x8b,0x4c,0x24,0x38,0xba,0x5c,0x00,0x00,0x00,0x41,0xb8,0x2f,0x00,0x00,0x00,0x39,0x09,0xe8,0x57,0xfa,0x0a,0x4c,0x48,0x8b,0xd0,0x33,0xc9,0x48,0x89,0x4c,0x24,0x30,0x48,0x8d,0x4c,0x24,0x30,0xe8,0xa3,0x8e,0xb8,0xfe,0x48,0x8b,0x4c,0x24,0x30,0x48,0x89,0x4c,0x24,0x40,0x48,0x8b,0x76,0x08,0x48,0x8b,0x4c,0x24,0x40,0xe8,0x1b,0xfe,0x09,0x4c,0x48,0x8b,0xd0,0x33,0xc9,0x48,0x89,0x4c,0x24,0x28,0x48,0x8d,0x4c,0x24,0x28,0xe8,0x77,0x8e,0xb8,0xfe,0x48,0x8b,0x4c,0x24,0x28,0xe8,0x9d,0x37,0x9c,0xfa,0x48,0x8b,0xd0,0x33,0xc9,0x48,0x89,0x4c,0x24,0x20,0x48,0x8d,0x4c,0x24,0x20,0xe8,0x59,0x8e,0xb8,0xfe,0x48,0x8b,0x7c,0x24,0x20,0xe8,0x87,0x87,0x9c,0xfd,0x4c,0x8b,0xc0,0x48,0x8b,0xce,0x48,0x8b,0xd7,0x49,0xbb,0x50,0x30,0xc7,0xdb,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0x44,0x07,0x89,0xfa,0x48,0x89,0x44,0x24,0x48,0x48,0x8b,0xfb,0x48,0x8d,0x74,0x24,0x40,0xe8,0x22,0x40,0x4b,0x5a,0xe8,0x1d,0x40,0x4b,0x5a,0x48,0x8b,0xc3,0x48,0x83,0xc4,0x50,0x5b,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> DumpImages_ᐤCmdBuilderㆍFolderPathㆍFolderPathᐤ  =>  new byte[79]{0x57,0x56,0x53,0x48,0x83,0xec,0x10,0xc5,0xf8,0x77,0x33,0xc0,0x48,0x89,0x04,0x24,0x48,0x89,0x44,0x24,0x08,0x48,0x8b,0xd9,0x48,0x8d,0x04,0x24,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x00,0x48,0x8d,0x04,0x24,0x4c,0x89,0x00,0x48,0x8d,0x44,0x24,0x08,0x4c,0x89,0x08,0x48,0x8b,0xfb,0x48,0x8d,0x34,0x24,0xe8,0xb1,0x3f,0x4b,0x5a,0xe8,0xac,0x3f,0x4b,0x5a,0x48,0x8b,0xc3,0x48,0x83,0xc4,0x10,0x5b,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> DumpImages_ᐤCmdBuilderᐤ  =>  new byte[17]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> EmitAsmOpCodes_ᐤCmdBuilderㆍNullableᐸFilePathᐳᐤ  =>  new byte[155]{0x57,0x56,0x48,0x83,0xec,0x58,0xc5,0xf8,0x77,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x20,0xb9,0x0e,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x45,0x33,0xc0,0x4c,0x89,0x44,0x24,0x50,0xc5,0xfa,0x6f,0x02,0xc5,0xfa,0x7f,0x44,0x24,0x40,0x48,0x8d,0x74,0x24,0x50,0x80,0x7c,0x24,0x40,0x00,0x75,0x44,0x4c,0x8d,0x44,0x24,0x30,0xc5,0xf8,0x57,0xc0,0xc4,0xc1,0x7a,0x7f,0x00,0x48,0x8b,0x49,0x08,0x49,0xb8,0x70,0xe7,0x68,0xe7,0x8f,0x02,0x00,0x00,0x49,0x8b,0x10,0xc5,0xfa,0x6f,0x44,0x24,0x30,0xc5,0xfa,0x7f,0x44,0x24,0x20,0x4c,0x8d,0x44,0x24,0x20,0x49,0xbb,0x58,0x30,0xc7,0xdb,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0xeb,0x05,0x89,0xfa,0xeb,0x05,0x48,0x8b,0x44,0x24,0x48,0x48,0x8d,0x0e,0x48,0x8b,0xd0,0xe8,0xf1,0x3d,0x4b,0x5a,0x48,0x8b,0x44,0x24,0x50,0x48,0x83,0xc4,0x58,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> EmitDocComments_ᐤCmdBuilderᐤ  =>  new byte[21]{0x50,0x33,0xc0,0x48,0x89,0x04,0x24,0xc6,0x04,0x24,0x00,0x48,0x0f,0xbe,0x04,0x24,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> EmitEnumCatalog_ᐤCmdBuilderㆍFilePathᐤ  =>  new byte[23]{0x50,0x33,0xc0,0x48,0x89,0x04,0x24,0x48,0x8d,0x04,0x24,0x48,0x89,0x10,0x48,0x8b,0x04,0x24,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> EmitEnumCatalog_ᐤCmdBuilderᐤ  =>  new byte[61]{0x48,0x83,0xec,0x28,0x33,0xc0,0x48,0x89,0x44,0x24,0x20,0x48,0x8b,0x49,0x08,0x48,0xba,0x78,0xe7,0x68,0xe7,0x8f,0x02,0x00,0x00,0x48,0x8b,0x12,0x49,0xbb,0x60,0x30,0xc7,0xdb,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0x22,0x05,0x89,0xfa,0x48,0x89,0x44,0x24,0x20,0x48,0x8b,0x44,0x24,0x20,0x48,0x83,0xc4,0x28,0xc3};

        public static ReadOnlySpan<byte> EmitHexIndex_ᐤCmdBuilderᐤ  =>  new byte[21]{0x50,0x33,0xc0,0x48,0x89,0x04,0x24,0xc6,0x04,0x24,0x00,0x48,0x0f,0xbe,0x04,0x24,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> EmitILTables_ᐤCmdBuilderㆍFilePathᐤ  =>  new byte[189]{0x57,0x56,0x53,0x48,0x83,0xec,0x40,0xc5,0xf8,0x77,0x33,0xc0,0x48,0x89,0x44,0x24,0x30,0x48,0x89,0x44,0x24,0x38,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x20,0x48,0x8b,0xd9,0x48,0x8d,0x4c,0x24,0x30,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0x48,0x8d,0x4c,0x24,0x30,0x4c,0x89,0x01,0x48,0x8b,0x72,0x08,0x49,0x8b,0xc8,0xe8,0xec,0xfa,0x09,0x4c,0x48,0x8b,0xd0,0x33,0xc9,0x48,0x89,0x4c,0x24,0x28,0x48,0x8d,0x4c,0x24,0x28,0xe8,0x48,0x8b,0xb8,0xfe,0x48,0x8b,0x4c,0x24,0x28,0xe8,0x6e,0x34,0x9c,0xfa,0x48,0x8b,0xd0,0x33,0xc9,0x48,0x89,0x4c,0x24,0x20,0x48,0x8d,0x4c,0x24,0x20,0xe8,0x2a,0x8b,0xb8,0xfe,0x48,0x8b,0x7c,0x24,0x20,0xe8,0x30,0x84,0x9c,0xfd,0x4c,0x8b,0xc0,0x48,0x8b,0xce,0x48,0x8b,0xd7,0x49,0xbb,0x68,0x30,0xc7,0xdb,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0x2d,0x04,0x89,0xfa,0x48,0x89,0x44,0x24,0x38,0x48,0x8b,0xfb,0x48,0x8d,0x74,0x24,0x30,0xe8,0xf3,0x3c,0x4b,0x5a,0xe8,0xee,0x3c,0x4b,0x5a,0x48,0x8b,0xc3,0x48,0x83,0xc4,0x40,0x5b,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> EmitImageContent_ᐤCmdBuilderᐤ  =>  new byte[310]{0x57,0x56,0x55,0x53,0x48,0x81,0xec,0x88,0x00,0x00,0x00,0xc5,0xf8,0x77,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x28,0xb9,0x18,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x8b,0xd9,0x48,0x8b,0xf2,0x48,0x8d,0x44,0x24,0x58,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x00,0xc5,0xfa,0x7f,0x40,0x10,0xc5,0xfa,0x7f,0x40,0x20,0xe8,0x74,0x68,0x4e,0xfc,0x48,0x8b,0xf8,0x8b,0x0f,0x48,0x8b,0xcf,0xba,0x03,0x00,0x00,0x00,0xe8,0x22,0x68,0x4e,0xfc,0x48,0x8d,0x6c,0x24,0x58,0x8b,0x8f,0xc8,0x00,0x00,0x00,0xe8,0xb2,0x74,0x4e,0xfc,0x48,0x8b,0xd0,0x48,0x8b,0xcd,0xe8,0xdf,0x72,0x2a,0xff,0x48,0x8b,0x76,0x08,0x48,0x8b,0x4c,0x24,0x60,0xe8,0xd1,0xf9,0x09,0x4c,0x48,0x8b,0xd0,0x33,0xc9,0x48,0x89,0x4c,0x24,0x40,0x48,0x8d,0x4c,0x24,0x40,0xe8,0x2d,0x8a,0xb8,0xfe,0x48,0x8b,0x4c,0x24,0x40,0xe8,0x53,0x33,0x9c,0xfa,0x48,0x8b,0xd0,0x33,0xc9,0x48,0x89,0x4c,0x24,0x38,0x48,0x8d,0x4c,0x24,0x38,0xe8,0x0f,0x8a,0xb8,0xfe,0x48,0x8b,0x7c,0x24,0x38,0x48,0x8d,0x4c,0x24,0x48,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0x48,0x8b,0xce,0x48,0xba,0x00,0xc6,0x1f,0xdc,0xfd,0x7f,0x00,0x00,0x49,0xb8,0xe0,0x37,0x6e,0xe1,0xfd,0x7f,0x00,0x00,0xe8,0x31,0x33,0x39,0x5a,0x48,0x8b,0xce,0x48,0xba,0x80,0xe7,0x68,0xe7,0x8f,0x02,0x00,0x00,0x48,0x8b,0x12,0x4c,0x8b,0xc7,0xc5,0xfa,0x6f,0x44,0x24,0x48,0xc5,0xfa,0x7f,0x44,0x24,0x28,0x4c,0x8d,0x4c,0x24,0x28,0xff,0xd0,0x48,0x89,0x84,0x24,0x80,0x00,0x00,0x00,0x48,0x8b,0xfb,0x48,0x8d,0x74,0x24,0x58,0x48,0xa5,0xe8,0xa4,0x3b,0x4b,0x5a,0x48,0xa5,0x48,0xa5,0x48,0xa5,0xe8,0x99,0x3b,0x4b,0x5a,0x48,0x8b,0xc3,0x48,0x81,0xc4,0x88,0x00,0x00,0x00,0x5b,0x5d,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> specify_ᐤIWfShellㆍProcessModuleㆍEmitImageContentCmdᕀrefᐤ  =>  new byte[282]{0x57,0x56,0x55,0x53,0x48,0x81,0xec,0x88,0x00,0x00,0x00,0xc5,0xf8,0x77,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x28,0xb9,0x18,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x8b,0xe9,0x49,0x8b,0xd8,0x48,0x8d,0x4c,0x24,0x58,0xe8,0xbe,0x71,0x2a,0xff,0x48,0x8b,0xfb,0x48,0x8d,0x74,0x24,0x58,0x48,0xa5,0xe8,0x1f,0x3b,0x4b,0x5a,0x48,0xa5,0x48,0xa5,0x48,0xa5,0x48,0x8b,0xcd,0x49,0xbb,0x70,0x30,0xc7,0xdb,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0x34,0x02,0x89,0xfa,0x48,0x8b,0xf0,0x48,0x8b,0x4c,0x24,0x60,0xe8,0x87,0xf8,0x09,0x4c,0x48,0x8b,0xd0,0x33,0xc9,0x48,0x89,0x4c,0x24,0x40,0x48,0x8d,0x4c,0x24,0x40,0xe8,0xe3,0x88,0xb8,0xfe,0x48,0x8b,0x4c,0x24,0x40,0xe8,0x09,0x32,0x9c,0xfa,0x48,0x8b,0xd0,0x33,0xc9,0x48,0x89,0x4c,0x24,0x38,0x48,0x8d,0x4c,0x24,0x38,0xe8,0xc5,0x88,0xb8,0xfe,0x48,0x8b,0x7c,0x24,0x38,0x48,0x8d,0x4c,0x24,0x48,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0x48,0x8b,0xce,0x48,0xba,0x00,0xc6,0x1f,0xdc,0xfd,0x7f,0x00,0x00,0x49,0xb8,0xe0,0x37,0x6e,0xe1,0xfd,0x7f,0x00,0x00,0xe8,0xe7,0x31,0x39,0x5a,0x48,0x8d,0x4b,0x28,0x48,0x89,0x8c,0x24,0x80,0x00,0x00,0x00,0x48,0xba,0x80,0xe7,0x68,0xe7,0x8f,0x02,0x00,0x00,0x48,0x8b,0x12,0x4c,0x8b,0xc7,0xc5,0xfa,0x6f,0x44,0x24,0x48,0xc5,0xfa,0x7f,0x44,0x24,0x28,0x48,0x8b,0xce,0x4c,0x8d,0x4c,0x24,0x28,0xff,0xd0,0x48,0x8b,0x8c,0x24,0x80,0x00,0x00,0x00,0x48,0x8b,0xd0,0xe8,0x85,0x39,0x4b,0x5a,0x48,0x8b,0xc3,0x48,0x81,0xc4,0x88,0x00,0x00,0x00,0x5b,0x5d,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> specify_ᐤIWfShellㆍProcessㆍIndexᐸEmitImageContentCmdᐳᕀoutᐤ  =>  new byte[173]{0x57,0x56,0x55,0x53,0x48,0x83,0xec,0x58,0xc5,0xf8,0x77,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x28,0xb9,0x0c,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x8b,0xf1,0x49,0x8b,0xf8,0x48,0x8d,0x4c,0x24,0x48,0xe8,0xc9,0x10,0xf1,0xfc,0x8b,0x5c,0x24,0x50,0x48,0x63,0xcb,0xe8,0x85,0xc4,0xff,0xff,0x48,0x8b,0xcf,0x48,0x8b,0xd0,0xe8,0x0a,0x39,0x4b,0x5a,0x4c,0x8b,0x07,0x4d,0x85,0xc0,0x75,0x04,0x33,0xff,0xeb,0x08,0x49,0x8d,0x78,0x10,0x45,0x8b,0x40,0x08,0x33,0xed,0x85,0xdb,0x7e,0x44,0x4c,0x8b,0x44,0x24,0x48,0x4c,0x89,0x44,0x24,0x38,0x44,0x8b,0x44,0x24,0x50,0x44,0x89,0x44,0x24,0x40,0xc5,0xfa,0x6f,0x44,0x24,0x38,0xc5,0xfa,0x7f,0x44,0x24,0x28,0x4c,0x8b,0x44,0x24,0x28,0x48,0x63,0xcd,0x49,0x8b,0x14,0xc8,0x4c,0x63,0xc5,0x4d,0x6b,0xc0,0x30,0x4c,0x03,0xc7,0x48,0x8b,0xce,0xe8,0x22,0xfe,0xff,0xff,0xff,0xc5,0x3b,0xeb,0x7c,0xbc,0x48,0x83,0xc4,0x58,0x5b,0x5d,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> EmitImageHeaders_ᐤCmdBuilderㆍFilesㆍFilePathᐤ  =>  new byte[79]{0x57,0x56,0x53,0x48,0x83,0xec,0x10,0xc5,0xf8,0x77,0x33,0xc0,0x48,0x89,0x04,0x24,0x48,0x89,0x44,0x24,0x08,0x48,0x8b,0xd9,0x48,0x8d,0x04,0x24,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x00,0x48,0x8d,0x04,0x24,0x4c,0x89,0x00,0x48,0x8d,0x44,0x24,0x08,0x4c,0x89,0x08,0x48,0x8b,0xfb,0x48,0x8d,0x34,0x24,0xe8,0x11,0x39,0x4b,0x5a,0xe8,0x0c,0x39,0x4b,0x5a,0x48,0x8b,0xc3,0x48,0x83,0xc4,0x10,0x5b,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> EmitImageMaps_ᐤCmdBuilderᐤ  =>  new byte[61]{0x48,0x83,0xec,0x28,0x33,0xc0,0x48,0x89,0x44,0x24,0x20,0x48,0x8b,0x49,0x08,0x48,0xba,0x88,0xe7,0x68,0xe7,0x8f,0x02,0x00,0x00,0x48,0x8b,0x12,0x49,0xbb,0x78,0x30,0xc7,0xdb,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0xea,0xff,0x88,0xfa,0x48,0x89,0x44,0x24,0x20,0x48,0x8b,0x44,0x24,0x20,0x48,0x83,0xc4,0x28,0xc3};

        public static ReadOnlySpan<byte> EmitImageMaps_ᐤCmdBuilderㆍstringᐤ  =>  new byte[74]{0x56,0x48,0x83,0xec,0x30,0x33,0xc0,0x48,0x89,0x44,0x24,0x28,0x48,0x8b,0x71,0x08,0x48,0xb9,0x90,0xe7,0x68,0xe7,0x8f,0x02,0x00,0x00,0x48,0x8b,0x09,0xe8,0x8e,0x6a,0x06,0x4c,0x48,0x8b,0xd0,0x48,0x8b,0xce,0x49,0xbb,0x80,0x30,0xc7,0xdb,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0x86,0xff,0x88,0xfa,0x48,0x89,0x44,0x24,0x28,0x48,0x8b,0x44,0x24,0x28,0x48,0x83,0xc4,0x30,0x5e,0xc3};

        public static ReadOnlySpan<byte> EmitProcessDump_ᐤCmdBuilderᐤ  =>  new byte[172]{0x57,0x56,0x55,0x53,0x48,0x83,0xec,0x38,0xc5,0xf8,0x77,0x33,0xc0,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x30,0x48,0x8b,0xd9,0x48,0x8b,0xf2,0x48,0x8d,0x44,0x24,0x28,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x00,0xe8,0xe9,0x63,0x4e,0xfc,0x48,0x8b,0xf8,0x48,0xb9,0x98,0x26,0x15,0xdf,0xfd,0x7f,0x00,0x00,0xe8,0xff,0x45,0x4b,0x5a,0x48,0x8b,0xe8,0x48,0x8d,0x4d,0x08,0x48,0x8b,0xd7,0xe8,0x30,0x37,0x4b,0x5a,0x48,0x8b,0x7d,0x08,0x48,0x89,0x7c,0x24,0x28,0x48,0x8b,0x76,0x08,0x8b,0x0f,0x48,0x8b,0xcf,0xba,0x08,0x00,0x00,0x00,0xe8,0x6c,0x63,0x4e,0xfc,0x48,0x8b,0x57,0x28,0x48,0x8b,0x52,0x10,0x48,0x8b,0xce,0x49,0xbb,0x88,0x30,0xc7,0xdb,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0xdf,0xfe,0x88,0xfa,0x48,0x89,0x44,0x24,0x30,0x48,0x8b,0xfb,0x48,0x8d,0x74,0x24,0x28,0xe8,0x85,0x37,0x4b,0x5a,0xe8,0x80,0x37,0x4b,0x5a,0x48,0x8b,0xc3,0x48,0x83,0xc4,0x38,0x5b,0x5d,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> EmitProcessDump_ᐤCmdBuilderㆍProcessᐤ  =>  new byte[130]{0x57,0x56,0x53,0x48,0x83,0xec,0x30,0xc5,0xf8,0x77,0x33,0xc0,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x44,0x24,0x28,0x48,0x8b,0xd9,0x48,0x8d,0x4c,0x24,0x20,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0x4c,0x89,0x44,0x24,0x20,0x48,0x8b,0x72,0x08,0x48,0x8b,0x7c,0x24,0x20,0x8b,0x0f,0x48,0x8b,0xcf,0xba,0x08,0x00,0x00,0x00,0xe8,0xc5,0x62,0x4e,0xfc,0x48,0x8b,0x57,0x28,0x48,0x8b,0x52,0x10,0x48,0x8b,0xce,0x49,0xbb,0x90,0x30,0xc7,0xdb,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0x40,0xfe,0x88,0xfa,0x48,0x89,0x44,0x24,0x28,0x48,0x8b,0xfb,0x48,0x8d,0x74,0x24,0x20,0xe8,0xde,0x36,0x4b,0x5a,0xe8,0xd9,0x36,0x4b,0x5a,0x48,0x8b,0xc3,0x48,0x83,0xc4,0x30,0x5b,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> EmitRenderPatterns_ᐤCmdBuilderㆍTypeᐤ  =>  new byte[159]{0x57,0x56,0x55,0x53,0x48,0x83,0xec,0x38,0xc5,0xf8,0x77,0x33,0xc0,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x30,0x48,0x8b,0xd9,0x48,0x8d,0x4c,0x24,0x28,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0x4c,0x89,0x44,0x24,0x28,0x48,0x8b,0x72,0x08,0x49,0x8b,0xc8,0x49,0x8b,0x00,0x48,0x8b,0x40,0x40,0xff,0x50,0x30,0x48,0x8b,0xf8,0xe8,0x7b,0x7d,0x9c,0xfd,0x48,0x8b,0xe8,0x48,0x8b,0xce,0x48,0xba,0x00,0xc6,0x1f,0xdc,0xfd,0x7f,0x00,0x00,0x49,0xb8,0x78,0x41,0x6e,0xe1,0xfd,0x7f,0x00,0x00,0xe8,0x9c,0x2d,0x39,0x5a,0x48,0xba,0x98,0xe7,0x68,0xe7,0x8f,0x02,0x00,0x00,0x48,0x8b,0x12,0x48,0x8b,0xce,0x4c,0x8b,0xc7,0x4c,0x8b,0xcd,0xff,0xd0,0x48,0x89,0x44,0x24,0x30,0x48,0x8b,0xfb,0x48,0x8d,0x74,0x24,0x28,0xe8,0x22,0x36,0x4b,0x5a,0xe8,0x1d,0x36,0x4b,0x5a,0x48,0x8b,0xc3,0x48,0x83,0xc4,0x38,0x5b,0x5d,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> EmitResData_ᐤCmdBuilderㆍAssemblyㆍstringㆍstringᐤ  =>  new byte[304]{0x57,0x56,0x55,0x53,0x48,0x83,0xec,0x48,0xc5,0xf8,0x77,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x20,0xb9,0x0a,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x8b,0xd9,0x48,0x8b,0xf2,0x49,0x8b,0xf9,0x48,0x8d,0x4c,0x24,0x28,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0xc5,0xfa,0x7f,0x41,0x10,0x48,0x8d,0x6c,0x24,0x28,0x49,0x8b,0xd0,0x48,0x85,0xd2,0x75,0x1a,0x48,0xb9,0x40,0xdb,0x46,0xdf,0xfd,0x7f,0x00,0x00,0xe8,0x5a,0x81,0x44,0x5a,0x48,0x8b,0xc8,0xe8,0xb2,0x6e,0x45,0x5a,0x48,0x8b,0xd0,0x48,0x8b,0xcd,0xe8,0xb7,0x34,0x4b,0x5a,0x48,0x8d,0x6c,0x24,0x28,0x48,0x8b,0x4e,0x08,0x49,0xbb,0x98,0x30,0xc7,0xdb,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0xc4,0xfc,0x88,0xfa,0x48,0x8b,0xf0,0x48,0x8b,0xd7,0x48,0x85,0xd2,0x75,0x0d,0x48,0xba,0x60,0x68,0x46,0xe7,0x8f,0x02,0x00,0x00,0x48,0x8b,0x12,0x33,0xc9,0x48,0x89,0x4c,0x24,0x20,0x48,0x8d,0x4c,0x24,0x20,0xe8,0x43,0x83,0xb8,0xfe,0x48,0x8b,0x54,0x24,0x20,0x48,0x8b,0xce,0xe8,0xbe,0x09,0x9c,0xfa,0x48,0x8d,0x4d,0x10,0x48,0x8b,0xd0,0xe8,0x5a,0x34,0x4b,0x5a,0x48,0x8d,0x74,0x24,0x28,0x48,0x8b,0xbc,0x24,0x90,0x00,0x00,0x00,0x48,0x8b,0xd7,0x48,0x85,0xd2,0x75,0x0d,0x48,0xba,0x60,0x30,0x2c,0xe7,0x8f,0x02,0x00,0x00,0x48,0x8b,0x12,0x48,0xb9,0x20,0x18,0x2c,0xe7,0x8f,0x02,0x00,0x00,0x48,0x8b,0x09,0x48,0x8b,0x01,0x48,0x8b,0x40,0x58,0xff,0x50,0x10,0x48,0x8d,0x4e,0x18,0x48,0x8b,0xd0,0xe8,0x15,0x34,0x4b,0x5a,0x48,0x8b,0xfb,0x48,0x8d,0x74,0x24,0x28,0xe8,0xd8,0x34,0x4b,0x5a,0x48,0xa5,0xe8,0xd1,0x34,0x4b,0x5a,0xe8,0xcc,0x34,0x4b,0x5a,0x48,0x8b,0xc3,0x48,0x83,0xc4,0x48,0x5b,0x5d,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> EmitRuntimeIndex_ᐤCmdBuilderᐤ  =>  new byte[21]{0x50,0x33,0xc0,0x48,0x89,0x04,0x24,0xc6,0x04,0x24,0x00,0x48,0x0f,0xbe,0x04,0x24,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> JitApiCmd_ᐤCmdBuilderᐤ  =>  new byte[21]{0x50,0x33,0xc0,0x48,0x89,0x04,0x24,0xc6,0x04,0x24,0x00,0x48,0x0f,0xbe,0x04,0x24,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> ListFiles_ᐤCmdBuilderㆍstringㆍFolderPathㆍarray_FileExtᐤ  =>  new byte[173]{0x57,0x56,0x53,0x48,0x83,0xec,0x50,0xc5,0xf8,0x77,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x28,0xb9,0x0a,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x8b,0xd9,0x49,0x8b,0xf0,0x33,0xc0,0x48,0x8d,0x4c,0x24,0x28,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0xc5,0xfa,0x7f,0x41,0x10,0x48,0x89,0x41,0x20,0x48,0x89,0x74,0x24,0x28,0x48,0x8d,0x44,0x24,0x38,0x4c,0x89,0x08,0x48,0x8b,0x84,0x24,0x90,0x00,0x00,0x00,0x48,0x89,0x44,0x24,0x40,0x48,0x8b,0x7a,0x08,0xe8,0xf1,0x7a,0x9c,0xfd,0x4c,0x8b,0xc0,0x48,0x8b,0xcf,0x48,0x8b,0xd6,0x49,0xbb,0xa0,0x30,0xc7,0xdb,0xfd,0x7f,0x00,0x00,0x39,0x09,0xff,0x15,0x26,0xfb,0x88,0xfa,0x48,0x89,0x44,0x24,0x48,0xc6,0x44,0x24,0x35,0x02,0x48,0x8b,0xfb,0x48,0x8d,0x74,0x24,0x28,0xe8,0xaf,0x33,0x4b,0x5a,0x48,0xa5,0xe8,0xa8,0x33,0x4b,0x5a,0xe8,0xa3,0x33,0x4b,0x5a,0xe8,0x9e,0x33,0x4b,0x5a,0x48,0x8b,0xc3,0x48,0x83,0xc4,0x50,0x5b,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> WithExt_ᐤListFilesCmdᕀrefㆍarray_FileExtᐤ  =>  new byte[22]{0x56,0x0f,0x1f,0x40,0x00,0x48,0x8b,0xf1,0x48,0x8d,0x4e,0x18,0xe8,0x8f,0x32,0x4b,0x5a,0x48,0x8b,0xc6,0x5e,0xc3};

        public static ReadOnlySpan<byte> WithFormat_ᐤListFilesCmdᕀrefㆍListFormatKindᕀ8uᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x88,0x51,0x0d,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> WithLimit_ᐤListFilesCmdᕀrefㆍ32uᐤ  =>  new byte[12]{0x0f,0x1f,0x44,0x00,0x00,0x89,0x51,0x08,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> RunPart_ᐤCmdBuilderㆍPartIdᕀ64uᐤ  =>  new byte[9]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> RunScript_ᐤCmdBuilderㆍFilePathᐤ  =>  new byte[23]{0x50,0x33,0xc0,0x48,0x89,0x04,0x24,0x48,0x8d,0x04,0x24,0x48,0x89,0x10,0x48,0x8b,0x04,0x24,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> Show_ᐤCmdBuilderㆍstringᐤ  =>  new byte[9]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> ShowEnv_ᐤCmdBuilderᐤ  =>  new byte[21]{0x50,0x33,0xc0,0x48,0x89,0x04,0x24,0xc6,0x04,0x24,0x00,0x48,0x0f,0xbe,0x04,0x24,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> ShowProcessMemory_ᐤCmdBuilderᐤ  =>  new byte[21]{0x50,0x33,0xc0,0x48,0x89,0x04,0x24,0xc6,0x04,0x24,0x00,0x48,0x0f,0xbe,0x04,0x24,0x48,0x83,0xc4,0x08,0xc3};

    }
}
