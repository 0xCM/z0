//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
// Generated   : 2021-02-26 14:33:08 -06:00
//-----------------------------------------------------------------------------
namespace Z0.ByteCode
{
    using System;
    using System.Runtime.CompilerServices;


    public static class external_clisigparser
    {
        public static ReadOnlySpan<byte> Parse_ᐤarray_8uᐤ  =>  new byte[157]{0x57,0x56,0x48,0x83,0xec,0x28,0x33,0xc0,0x48,0x89,0x44,0x24,0x20,0x48,0x8b,0xf1,0x48,0x8b,0xfa,0x48,0x8d,0x4e,0x08,0x48,0x8b,0xd7,0xe8,0x91,0x6b,0xe5,0x59,0x33,0xd2,0x89,0x56,0x10,0x8b,0x57,0x08,0x89,0x56,0x14,0x48,0x8d,0x54,0x24,0x20,0x48,0x8b,0xce,0xe8,0xb9,0xfa,0x88,0xfc,0x85,0xc0,0x74,0x59,0x8b,0x44,0x24,0x20,0x0f,0xb6,0xd0,0x8b,0xca,0x83,0xe1,0x0f,0x83,0xf9,0x08,0x77,0x48,0x8b,0xc9,0x48,0x8d,0x05,0x4b,0x00,0x00,0x00,0x8b,0x04,0x88,0x4c,0x8d,0x05,0xb4,0xff,0xff,0xff,0x49,0x03,0xc0,0xff,0xe0,0x48,0x8b,0xce,0xe8,0x94,0xfa,0x88,0xfc,0xeb,0x1c,0x48,0x8b,0xce,0xe8,0x92,0xfa,0x88,0xfc,0xeb,0x12,0x48,0x8b,0xce,0xe8,0x98,0xfa,0x88,0xfc,0xeb,0x08,0x48,0x8b,0xce,0xe8,0x86,0xfa,0x88,0xfc,0x0f,0xb6,0xc0,0x48,0x83,0xc4,0x28,0x5e,0x5f,0xc3,0x33,0xc0,0x48,0x83,0xc4,0x28,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> ParseByte_ᐤ8uᕀoutᐤ  =>  new byte[70]{0x48,0x83,0xec,0x28,0x90,0x8b,0x41,0x10,0x3b,0x41,0x14,0x7d,0x26,0x48,0x8b,0x41,0x08,0x44,0x8b,0x41,0x10,0x44,0x3b,0x40,0x08,0x73,0x22,0x4d,0x63,0xc0,0x42,0x0f,0xb6,0x44,0x00,0x10,0x88,0x02,0xff,0x41,0x10,0xb8,0x01,0x00,0x00,0x00,0x48,0x83,0xc4,0x28,0xc3,0xc6,0x02,0x00,0x33,0xc0,0x48,0x83,0xc4,0x28,0xc3,0xe8,0x0e,0xff,0xf7,0x59,0xcc,0x00,0x19,0x04};

        public static ReadOnlySpan<byte> ParseIntPtr_ᐤIntPtrᕀoutᐤ  =>  new byte[71]{0x57,0x56,0x48,0x83,0xec,0x28,0x48,0x8b,0xf1,0x48,0x8b,0xfa,0x8b,0x4e,0x10,0x83,0xc1,0x08,0x3b,0x4e,0x14,0x7f,0x24,0x48,0x8b,0x4e,0x08,0x8b,0x56,0x10,0xe8,0xe5,0xdb,0x33,0xfa,0x48,0x89,0x07,0x8b,0x46,0x10,0x83,0xc0,0x08,0x89,0x46,0x10,0xb8,0x01,0x00,0x00,0x00,0x48,0x83,0xc4,0x28,0x5e,0x5f,0xc3,0x33,0xc0,0x48,0x89,0x07,0x48,0x83,0xc4,0x28,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> ParseMethod_ᐤ8uᐤ  =>  new byte[266]{0x57,0x56,0x53,0x48,0x83,0xec,0x30,0x33,0xc0,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x20,0x48,0x8b,0xf1,0x40,0x0f,0xb6,0xfa,0x8b,0xd7,0x48,0x8b,0xce,0x48,0x8b,0x06,0x48,0x8b,0x40,0x40,0xff,0x50,0x20,0x40,0xf6,0xc7,0x10,0x74,0x26,0x48,0x8d,0x54,0x24,0x28,0x48,0x8b,0xce,0xe8,0x94,0xf9,0x88,0xfc,0x85,0xc0,0x0f,0x84,0xb0,0x00,0x00,0x00,0x48,0x8b,0xce,0x8b,0x54,0x24,0x28,0x48,0x8b,0x06,0x48,0x8b,0x40,0x48,0xff,0x50,0x20,0x48,0x8d,0x54,0x24,0x20,0x48,0x8b,0xce,0xe8,0x6e,0xf9,0x88,0xfc,0x85,0xc0,0x0f,0x84,0x8a,0x00,0x00,0x00,0x48,0x8b,0xce,0x8b,0x54,0x24,0x20,0x48,0x8b,0x06,0x48,0x8b,0x40,0x40,0xff,0x50,0x30,0x48,0x8b,0xce,0xe8,0x25,0xf9,0x88,0xfc,0x85,0xc0,0x74,0x6d,0x33,0xff,0x33,0xdb,0x83,0x7c,0x24,0x20,0x00,0x7e,0x48,0x8b,0x4e,0x10,0x3b,0x4e,0x14,0x7d,0x5a,0x48,0x8b,0x46,0x08,0x3b,0x48,0x08,0x73,0x5b,0x48,0x63,0xc9,0x80,0x7c,0x08,0x10,0x41,0x75,0x19,0x85,0xff,0x75,0x43,0xbf,0x01,0x00,0x00,0x00,0x48,0x8b,0xce,0x48,0x8b,0x06,0x48,0x8b,0x40,0x48,0xff,0x50,0x18,0xff,0x46,0x10,0x48,0x8b,0xce,0xe8,0xd2,0xf8,0x88,0xfc,0x85,0xc0,0x74,0x22,0xff,0xc3,0x3b,0x5c,0x24,0x20,0x7c,0xb8,0x48,0x8b,0xce,0x48,0x8b,0x06,0x48,0x8b,0x40,0x40,0xff,0x50,0x28,0xb8,0x01,0x00,0x00,0x00,0x48,0x83,0xc4,0x30,0x5b,0x5e,0x5f,0xc3,0x33,0xc0,0x48,0x83,0xc4,0x30,0x5b,0x5e,0x5f,0xc3,0xe8,0x8d,0xfd,0xf7,0x59,0xcc,0x19,0x07,0x04,0x00,0x07,0x52};

        public static ReadOnlySpan<byte> ParseField_ᐤ8uᐤ  =>  new byte[88]{0x56,0x48,0x83,0xec,0x20,0x48,0x8b,0xf1,0x0f,0xb6,0xd2,0x48,0x8b,0xce,0x48,0x8b,0x06,0x48,0x8b,0x40,0x48,0xff,0x50,0x28,0x48,0x8b,0xce,0xe8,0x50,0xf8,0x88,0xfc,0x85,0xc0,0x75,0x08,0x33,0xc0,0x48,0x83,0xc4,0x20,0x5e,0xc3,0x48,0x8b,0xce,0xe8,0x64,0xf8,0x88,0xfc,0x85,0xc0,0x75,0x08,0x33,0xc0,0x48,0x83,0xc4,0x20,0x5e,0xc3,0x48,0x8b,0xce,0x48,0x8b,0x06,0x48,0x8b,0x40,0x48,0xff,0x50,0x30,0xb8,0x01,0x00,0x00,0x00,0x48,0x83,0xc4,0x20,0x5e,0xc3};

        public static ReadOnlySpan<byte> ParseProperty_ᐤ8uᐤ  =>  new byte[153]{0x57,0x56,0x48,0x83,0xec,0x28,0x33,0xc0,0x48,0x89,0x44,0x24,0x20,0x48,0x8b,0xf1,0x0f,0xb6,0xd2,0x48,0x8b,0xce,0x48,0x8b,0x06,0x48,0x8b,0x40,0x50,0xff,0x50,0x28,0x48,0x8d,0x54,0x24,0x20,0x48,0x8b,0xce,0xe8,0x13,0xf8,0x88,0xfc,0x85,0xc0,0x74,0x5f,0x48,0x8b,0xce,0x8b,0x54,0x24,0x20,0x48,0x8b,0x06,0x48,0x8b,0x40,0x40,0xff,0x50,0x30,0x48,0x8b,0xce,0xe8,0xb6,0xf7,0x88,0xfc,0x85,0xc0,0x74,0x42,0x48,0x8b,0xce,0xe8,0xd2,0xf7,0x88,0xfc,0x85,0xc0,0x74,0x36,0x33,0xff,0x83,0x7c,0x24,0x20,0x00,0x7e,0x14,0x48,0x8b,0xce,0xe8,0xa5,0xf7,0x88,0xfc,0x85,0xc0,0x74,0x21,0xff,0xc7,0x3b,0x7c,0x24,0x20,0x7c,0xec,0x48,0x8b,0xce,0x48,0x8b,0x06,0x48,0x8b,0x40,0x50,0xff,0x50,0x30,0xb8,0x01,0x00,0x00,0x00,0x48,0x83,0xc4,0x28,0x5e,0x5f,0xc3,0x33,0xc0,0x48,0x83,0xc4,0x28,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> ParseLocals_ᐤ8uᐤ  =>  new byte[137]{0x57,0x56,0x48,0x83,0xec,0x28,0x33,0xc0,0x48,0x89,0x44,0x24,0x20,0x48,0x8b,0xf1,0x0f,0xb6,0xd2,0x48,0x8b,0xce,0x48,0x8b,0x06,0x48,0x8b,0x40,0x48,0xff,0x50,0x38,0x48,0x8d,0x54,0x24,0x20,0x48,0x8b,0xce,0xe8,0x53,0xf7,0x88,0xfc,0x85,0xc0,0x75,0x09,0x33,0xc0,0x48,0x83,0xc4,0x28,0x5e,0x5f,0xc3,0x48,0x8b,0xce,0x8b,0x54,0x24,0x20,0x48,0x8b,0x06,0x48,0x8b,0x40,0x50,0xff,0x50,0x08,0x33,0xff,0x83,0x7c,0x24,0x20,0x00,0x7e,0x14,0x48,0x8b,0xce,0xe8,0xd4,0xf6,0x88,0xfc,0x85,0xc0,0x74,0x20,0xff,0xc7,0x3b,0x7c,0x24,0x20,0x7c,0xec,0x48,0x8b,0xce,0x48,0x8b,0x06,0x48,0x8b,0x40,0x50,0xff,0x10,0xb8,0x01,0x00,0x00,0x00,0x48,0x83,0xc4,0x28,0x5e,0x5f,0xc3,0x33,0xc0,0x48,0x83,0xc4,0x28,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> ParseLocal_ᐤᐤ  =>  new byte[182]{0x56,0x48,0x83,0xec,0x20,0x48,0x8b,0xf1,0x48,0x8b,0xce,0x48,0x8b,0x06,0x48,0x8b,0x40,0x50,0xff,0x50,0x10,0x8b,0x4e,0x10,0x3b,0x4e,0x14,0x7d,0x6e,0x48,0x8b,0x4e,0x08,0x8b,0x46,0x10,0x3b,0x41,0x08,0x0f,0x83,0x7e,0x00,0x00,0x00,0x48,0x63,0xc0,0x80,0x7c,0x01,0x10,0x16,0x75,0x11,0x48,0x8b,0xce,0x48,0x8b,0x06,0x48,0x8b,0x40,0x60,0xff,0x10,0xff,0x46,0x10,0xeb,0x4b,0x48,0x8b,0xce,0xe8,0x38,0xf6,0x88,0xfc,0x85,0xc0,0x74,0x37,0x8b,0x4e,0x10,0x3b,0x4e,0x14,0x7d,0x2f,0x48,0x8b,0x46,0x08,0x3b,0x48,0x08,0x73,0x46,0x48,0x63,0xc9,0x80,0x7c,0x08,0x10,0x10,0x75,0x10,0x48,0x8b,0xce,0x48,0x8b,0x06,0x48,0x8b,0x40,0x60,0xff,0x50,0x08,0xff,0x46,0x10,0x48,0x8b,0xce,0xe8,0x31,0xf6,0x88,0xfc,0x85,0xc0,0x75,0x08,0x33,0xc0,0x48,0x83,0xc4,0x20,0x5e,0xc3,0x48,0x8b,0xce,0x48,0x8b,0x06,0x48,0x8b,0x40,0x50,0xff,0x50,0x18,0xb8,0x01,0x00,0x00,0x00,0x48,0x83,0xc4,0x20,0x5e,0xc3,0xe8,0xe0,0xfa,0xf7,0x59,0xcc,0x00,0x00,0x00,0x19,0x05};

        public static ReadOnlySpan<byte> ParseOptionalCustomModsOrConstraint_ᐤᐤ  =>  new byte[118]{0x56,0x48,0x83,0xec,0x20,0x48,0x8b,0xf1,0x8b,0x4e,0x10,0x3b,0x4e,0x14,0x7c,0x0b,0xb8,0x01,0x00,0x00,0x00,0x48,0x83,0xc4,0x20,0x5e,0xc3,0x48,0x8b,0x46,0x08,0x3b,0x48,0x08,0x73,0x4a,0x48,0x63,0xc9,0x0f,0xb6,0x54,0x08,0x10,0x8b,0xca,0x8d,0x41,0xe1,0x83,0xf8,0x01,0x76,0x07,0x83,0xf9,0x45,0x74,0x16,0xeb,0x26,0x48,0x8b,0xce,0xe8,0x83,0xf5,0x88,0xfc,0x85,0xc0,0x75,0xbf,0x33,0xc0,0x48,0x83,0xc4,0x20,0x5e,0xc3,0x48,0x8b,0xce,0x48,0x8b,0x06,0x48,0x8b,0x40,0x50,0xff,0x50,0x20,0xff,0x46,0x10,0xeb,0xa5,0xb8,0x01,0x00,0x00,0x00,0x48,0x83,0xc4,0x20,0x5e,0xc3,0xe8,0x4d,0xfa,0xf7,0x59,0xcc,0x19,0x05};

        public static ReadOnlySpan<byte> ParseOptionalCustomMods_ᐤᐤ  =>  new byte[296]{0x56,0x48,0x83,0xec,0x20,0x48,0x8b,0xf1,0x8b,0x4e,0x10,0x3b,0x4e,0x14,0x7c,0x0b,0xb8,0x01,0x00,0x00,0x00,0x48,0x83,0xc4,0x20,0x5e,0xc3,0x48,0x8b,0x46,0x08,0x3b,0x48,0x08,0x73,0x2f,0x48,0x63,0xc9,0x0f,0xb6,0x4c,0x08,0x10,0x83,0xc1,0xe1,0x83,0xf9,0x01,0x77,0x14,0x48,0x8b,0xce,0xe8,0xfc,0xf4,0x88,0xfc,0x85,0xc0,0x75,0xc8,0x33,0xc0,0x48,0x83,0xc4,0x20,0x5e,0xc3,0xb8,0x01,0x00,0x00,0x00,0x48,0x83,0xc4,0x20,0x5e,0xc3,0xe8,0xd8,0xf9,0xf7,0x59,0xcc,0x00,0x00,0x00,0x19,0x05,0x02,0x00,0x05,0x32,0x01,0x60,0x40,0x00,0x00,0x00,0xc0,0x00,0x03,0xe0,0xfd,0x7f,0x00,0x00,0x56,0x48,0x83,0xec,0x50,0x33,0xc0,0x48,0x89,0x44,0x24,0x48,0x48,0x89,0x44,0x24,0x40,0x48,0x89,0x44,0x24,0x38,0x48,0x89,0x44,0x24,0x30,0x48,0x8b,0xf1,0x33,0xd2,0x89,0x54,0x24,0x48,0x89,0x54,0x24,0x40,0x48,0x8d,0x54,0x24,0x48,0x48,0x8b,0xce,0xe8,0x3b,0xfa,0xff,0xff,0x85,0xc0,0x75,0x08,0x33,0xc0,0x48,0x83,0xc4,0x50,0x5e,0xc3,0x44,0x8b,0x4c,0x24,0x48,0x45,0x0f,0xb6,0xc9,0x41,0x83,0xf9,0x20,0x74,0x06,0x41,0x83,0xf9,0x1f,0x75,0x5a,0x4c,0x8d,0x4c,0x24,0x40,0x48,0x8d,0x54,0x24,0x30,0x4c,0x8d,0x44,0x24,0x38,0x48,0x8b,0xce,0xe8,0x8b,0xf4,0x88,0xfc,0x85,0xc0,0x75,0x08,0x33,0xc0,0x48,0x83,0xc4,0x50,0x5e,0xc3,0x44,0x8b,0x4c,0x24,0x40,0x44,0x89,0x4c,0x24,0x20,0x44,0x8b,0x4c,0x24,0x38,0x45,0x0f,0xb6,0xc9,0x8b,0x54,0x24,0x48,0x0f,0xb6,0xd2,0x48,0x8b,0xce,0x44,0x8b,0x44,0x24,0x30,0x48,0x8b,0x06,0x48,0x8b,0x40,0x60,0xff,0x50,0x18,0xb8,0x01,0x00,0x00,0x00,0x48,0x83,0xc4,0x50,0x5e,0xc3,0x33,0xc0,0x48,0x83,0xc4,0x50,0x5e,0xc3};

        public static ReadOnlySpan<byte> ParseCustomMod_ᐤᐤ  =>  new byte[184]{0x56,0x48,0x83,0xec,0x50,0x33,0xc0,0x48,0x89,0x44,0x24,0x48,0x48,0x89,0x44,0x24,0x40,0x48,0x89,0x44,0x24,0x38,0x48,0x89,0x44,0x24,0x30,0x48,0x8b,0xf1,0x33,0xd2,0x89,0x54,0x24,0x48,0x89,0x54,0x24,0x40,0x48,0x8d,0x54,0x24,0x48,0x48,0x8b,0xce,0xe8,0x3b,0xfa,0xff,0xff,0x85,0xc0,0x75,0x08,0x33,0xc0,0x48,0x83,0xc4,0x50,0x5e,0xc3,0x44,0x8b,0x4c,0x24,0x48,0x45,0x0f,0xb6,0xc9,0x41,0x83,0xf9,0x20,0x74,0x06,0x41,0x83,0xf9,0x1f,0x75,0x5a,0x4c,0x8d,0x4c,0x24,0x40,0x48,0x8d,0x54,0x24,0x30,0x4c,0x8d,0x44,0x24,0x38,0x48,0x8b,0xce,0xe8,0x8b,0xf4,0x88,0xfc,0x85,0xc0,0x75,0x08,0x33,0xc0,0x48,0x83,0xc4,0x50,0x5e,0xc3,0x44,0x8b,0x4c,0x24,0x40,0x44,0x89,0x4c,0x24,0x20,0x44,0x8b,0x4c,0x24,0x38,0x45,0x0f,0xb6,0xc9,0x8b,0x54,0x24,0x48,0x0f,0xb6,0xd2,0x48,0x8b,0xce,0x44,0x8b,0x44,0x24,0x30,0x48,0x8b,0x06,0x48,0x8b,0x40,0x60,0xff,0x50,0x18,0xb8,0x01,0x00,0x00,0x00,0x48,0x83,0xc4,0x50,0x5e,0xc3,0x33,0xc0,0x48,0x83,0xc4,0x50,0x5e,0xc3};

        public static ReadOnlySpan<byte> ParseParam_ᐤᐤ  =>  new byte[182]{0x57,0x56,0x48,0x83,0xec,0x28,0x48,0x8b,0xf1,0x48,0x8b,0xce,0x48,0x8b,0x06,0x48,0x8b,0x40,0x48,0xff,0x50,0x08,0x48,0x8b,0xce,0xe8,0xa2,0xfe,0xff,0xff,0x85,0xc0,0x75,0x09,0x33,0xc0,0x48,0x83,0xc4,0x28,0x5e,0x5f,0xc3,0x8b,0x4e,0x10,0x3b,0x4e,0x14,0x7c,0x09,0x33,0xc0,0x48,0x83,0xc4,0x28,0x5e,0x5f,0xc3,0x48,0x8b,0x46,0x08,0x3b,0x48,0x08,0x73,0x62,0x48,0x63,0xc9,0x40,0x0f,0xb6,0x7c,0x08,0x10,0x83,0xff,0x16,0x75,0x11,0x48,0x8b,0xce,0x48,0x8b,0x06,0x48,0x8b,0x40,0x60,0xff,0x10,0xff,0x46,0x10,0xeb,0x2a,0x83,0xff,0x10,0x75,0x10,0x48,0x8b,0xce,0x48,0x8b,0x06,0x48,0x8b,0x40,0x60,0xff,0x50,0x08,0xff,0x46,0x10,0x48,0x8b,0xce,0xe8,0x97,0xf3,0x88,0xfc,0x85,0xc0,0x75,0x09,0x33,0xc0,0x48,0x83,0xc4,0x28,0x5e,0x5f,0xc3,0x48,0x8b,0xce,0x48,0x8b,0x06,0x48,0x8b,0x40,0x48,0xff,0x50,0x10,0xb8,0x01,0x00,0x00,0x00,0x48,0x83,0xc4,0x28,0x5e,0x5f,0xc3,0xe8,0x44,0xf8,0xf7,0x59,0xcc,0x00,0x00,0x00,0x19,0x06,0x03,0x00,0x06,0x42};

        public static ReadOnlySpan<byte> ParseRetType_ᐤᐤ  =>  new byte[202]{0x57,0x56,0x48,0x83,0xec,0x28,0x48,0x8b,0xf1,0x48,0x8b,0xce,0x48,0x8b,0x06,0x48,0x8b,0x40,0x40,0xff,0x50,0x38,0x48,0x8b,0xce,0xe8,0xd2,0xfd,0xff,0xff,0x85,0xc0,0x75,0x09,0x33,0xc0,0x48,0x83,0xc4,0x28,0x5e,0x5f,0xc3,0x8b,0x4e,0x10,0x3b,0x4e,0x14,0x7c,0x09,0x33,0xc0,0x48,0x83,0xc4,0x28,0x5e,0x5f,0xc3,0x48,0x8b,0x46,0x08,0x3b,0x48,0x08,0x73,0x78,0x48,0x63,0xc9,0x40,0x0f,0xb6,0x7c,0x08,0x10,0x83,0xff,0x16,0x75,0x11,0x48,0x8b,0xce,0x48,0x8b,0x06,0x48,0x8b,0x40,0x60,0xff,0x10,0xff,0x46,0x10,0xeb,0x41,0x83,0xff,0x01,0x75,0x12,0x48,0x8b,0xce,0x48,0x8b,0x06,0x48,0x8b,0x40,0x60,0xff,0x50,0x10,0xff,0x46,0x10,0xeb,0x2a,0x83,0xff,0x10,0x75,0x10,0x48,0x8b,0xce,0x48,0x8b,0x06,0x48,0x8b,0x40,0x60,0xff,0x50,0x08,0xff,0x46,0x10,0x48,0x8b,0xce,0xe8,0xb0,0xf2,0x88,0xfc,0x85,0xc0,0x75,0x09,0x33,0xc0,0x48,0x83,0xc4,0x28,0x5e,0x5f,0xc3,0x48,0x8b,0xce,0x48,0x8b,0x06,0x48,0x8b,0x40,0x48,0xff,0x10,0xb8,0x01,0x00,0x00,0x00,0x48,0x83,0xc4,0x28,0x5e,0x5f,0xc3,0xe8,0x5e,0xf7,0xf7,0x59,0xcc,0x00,0x19,0x06,0x03,0x00,0x06,0x42};

        public static ReadOnlySpan<byte> ParseArrayShape_ᐤᐤ  =>  new byte[288]{0x57,0x56,0x48,0x83,0xec,0x38,0x33,0xc0,0x48,0x89,0x44,0x24,0x30,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x20,0x48,0x8b,0xf1,0x48,0x8b,0xce,0x48,0x8b,0x06,0x48,0x8b,0x40,0x50,0xff,0x50,0x38,0x48,0x8d,0x54,0x24,0x30,0x48,0x8b,0xce,0xe8,0x4c,0xf2,0x88,0xfc,0x85,0xc0,0x0f,0x84,0xdb,0x00,0x00,0x00,0x48,0x8b,0xce,0x8b,0x54,0x24,0x30,0x48,0x8b,0x06,0x48,0x8b,0x40,0x58,0xff,0x50,0x08,0x48,0x8d,0x54,0x24,0x28,0x48,0x8b,0xce,0xe8,0x26,0xf2,0x88,0xfc,0x85,0xc0,0x0f,0x84,0xb5,0x00,0x00,0x00,0x48,0x8b,0xce,0x8b,0x54,0x24,0x28,0x48,0x8b,0x06,0x48,0x8b,0x40,0x58,0xff,0x50,0x10,0x33,0xff,0x83,0x7c,0x24,0x28,0x00,0x7e,0x2e,0x48,0x8d,0x54,0x24,0x20,0x48,0x8b,0xce,0xe8,0xf7,0xf1,0x88,0xfc,0x85,0xc0,0x0f,0x84,0x86,0x00,0x00,0x00,0x48,0x8b,0xce,0x8b,0x54,0x24,0x20,0x48,0x8b,0x06,0x48,0x8b,0x40,0x58,0xff,0x50,0x18,0xff,0xc7,0x3b,0x7c,0x24,0x28,0x7c,0xd2,0x48,0x8d,0x54,0x24,0x28,0x48,0x8b,0xce,0xe8,0xc9,0xf1,0x88,0xfc,0x85,0xc0,0x74,0x5c,0x48,0x8b,0xce,0x8b,0x54,0x24,0x28,0x48,0x8b,0x06,0x48,0x8b,0x40,0x58,0xff,0x50,0x20,0x33,0xff,0x83,0x7c,0x24,0x28,0x00,0x7e,0x2a,0x48,0x8d,0x54,0x24,0x20,0x48,0x8b,0xce,0xe8,0x9e,0xf1,0x88,0xfc,0x85,0xc0,0x74,0x31,0x48,0x8b,0xce,0x8b,0x54,0x24,0x20,0x48,0x8b,0x06,0x48,0x8b,0x40,0x58,0xff,0x50,0x28,0xff,0xc7,0x3b,0x7c,0x24,0x28,0x7c,0xd6,0x48,0x8b,0xce,0x48,0x8b,0x06,0x48,0x8b,0x40,0x58,0xff,0x10,0xb8,0x01,0x00,0x00,0x00,0x48,0x83,0xc4,0x38,0x5e,0x5f,0xc3,0x33,0xc0,0x48,0x83,0xc4,0x38,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> ParseType_ᐤᐤ  =>  new byte[981]{0x57,0x56,0x48,0x83,0xec,0x48,0x33,0xc0,0x48,0x89,0x44,0x24,0x40,0x48,0x89,0x44,0x24,0x38,0x48,0x89,0x44,0x24,0x30,0x48,0x89,0x44,0x24,0x28,0x48,0x8b,0xf1,0x48,0x8b,0xce,0x48,0x8b,0x06,0x48,0x8b,0x40,0x58,0xff,0x50,0x30,0x48,0x8d,0x54,0x24,0x40,0x48,0x8b,0xce,0xe8,0x77,0xf6,0xff,0xff,0x85,0xc0,0x0f,0x84,0x89,0x02,0x00,0x00,0x8b,0x44,0x24,0x40,0x0f,0xb6,0xd0,0x8d,0x4a,0xfe,0x83,0xf9,0x1f,0x0f,0x87,0x7f,0x02,0x00,0x00,0x8b,0xc9,0x48,0x8d,0x05,0x9b,0x02,0x00,0x00,0x8b,0x04,0x88,0x4c,0x8d,0x05,0xb8,0xff,0xff,0xff,0x49,0x03,0xc0,0xff,0xe0,0x48,0x8b,0xce,0x48,0x8b,0x06,0x48,0x8b,0x40,0x60,0xff,0x50,0x20,0xe9,0x55,0x02,0x00,0x00,0x48,0x8b,0xce,0x48,0x8b,0x06,0x48,0x8b,0x40,0x68,0xff,0x50,0x18,0x48,0x8b,0xce,0xe8,0x3d,0xfb,0xff,0xff,0x85,0xc0,0x0f,0x84,0x2f,0x02,0x00,0x00,0x8b,0x4e,0x10,0x3b,0x4e,0x14,0x0f,0x8d,0x23,0x02,0x00,0x00,0x48,0x8b,0x46,0x08,0x8b,0xd1,0x3b,0x50,0x08,0x0f,0x83,0x36,0x02,0x00,0x00,0x48,0x63,0xd2,0x80,0x7c,0x10,0x10,0x01,0x75,0x17,0xff,0xc1,0x89,0x4e,0x10,0x48,0x8b,0xce,0x48,0x8b,0x06,0x48,0x8b,0x40,0x60,0xff,0x50,0x10,0xe9,0xfc,0x01,0x00,0x00,0x48,0x8b,0xce,0xe8,0x49,0xf0,0x88,0xfc,0x85,0xc0,0x0f,0x85,0xec,0x01,0x00,0x00,0xe9,0xde,0x01,0x00,0x00,0x48,0x8b,0xce,0x48,0x8b,0x06,0x48,0x8b,0x40,0x68,0xff,0x50,0x10,0x48,0x8d,0x54,0x24,0x30,0x48,0x8b,0xce,0xe8,0x3a,0xf0,0x88,0xfc,0x85,0xc0,0x0f,0x84,0xbc,0x01,0x00,0x00,0x44,0x8b,0x44,0x24,0x30,0x41,0x83,0xe0,0x03,0x44,0x8b,0x4c,0x24,0x30,0x41,0xc1,0xf9,0x02,0x48,0x8b,0xce,0x8b,0x54,0x24,0x30,0x48,0x8b,0x06,0x48,0x8b,0x40,0x60,0xff,0x50,0x28,0xe9,0x9d,0x01,0x00,0x00,0x48,0x8b,0xce,0x48,0x8b,0x06,0x48,0x8b,0x40,0x68,0xff,0x50,0x08,0x48,0x8d,0x54,0x24,0x28,0x48,0x8b,0xce,0xe8,0xf0,0xef,0x88,0xfc,0x85,0xc0,0x0f,0x84,0x72,0x01,0x00,0x00,0x44,0x8b,0x44,0x24,0x28,0x41,0x83,0xe0,0x03,0x44,0x8b,0x4c,0x24,0x28,0x41,0xc1,0xf9,0x02,0x48,0x8b,0xce,0x8b,0x54,0x24,0x28,0x48,0x8b,0x06,0x48,0x8b,0x40,0x60,0xff,0x50,0x28,0xe9,0x53,0x01,0x00,0x00,0x48,0x8b,0xce,0x48,0x8b,0x06,0x48,0x8b,0x40,0x68,0xff,0x50,0x20,0x48,0x8d,0x54,0x24,0x40,0x48,0x8b,0xce,0xe8,0x16,0xf5,0xff,0xff,0x85,0xc0,0x0f,0x84,0x28,0x01,0x00,0x00,0x8b,0x54,0x24,0x40,0x0f,0xb6,0xd2,0x48,0x8b,0xce,0xe8,0xbf,0xf5,0xff,0xff,0x85,0xc0,0x0f,0x85,0x1a,0x01,0x00,0x00,0xe9,0x0c,0x01,0x00,0x00,0x48,0x8b,0xce,0x48,0x8b,0x06,0x48,0x8b,0x40,0x68,0xff,0x50,0x28,0x48,0x8b,0xce,0xe8,0x55,0xef,0x88,0xfc,0x85,0xc0,0x0f,0x84,0xef,0x00,0x00,0x00,0x48,0x8b,0xce,0xe8,0xdd,0xfc,0xff,0xff,0x85,0xc0,0x0f,0x85,0xe8,0x00,0x00,0x00,0xe9,0xda,0x00,0x00,0x00,0x48,0x8b,0xce,0x48,0x8b,0x06,0x48,0x8b,0x40,0x68,0xff,0x50,0x30,0x48,0x8b,0xce,0xe8,0xcb,0xf9,0xff,0xff,0x85,0xc0,0x0f,0x84,0xbd,0x00,0x00,0x00,0x48,0x8b,0xce,0xe8,0x13,0xef,0x88,0xfc,0x85,0xc0,0x0f,0x85,0xb6,0x00,0x00,0x00,0xe9,0xa8,0x00,0x00,0x00,0x48,0x8b,0xce,0xe8,0xfe,0xee,0x88,0xfc,0x85,0xc0,0x0f,0x84,0x98,0x00,0x00,0x00,0x48,0x8d,0x54,0x24,0x38,0x48,0x8b,0xce,0xe8,0x01,0xef,0x88,0xfc,0x85,0xc0,0x0f,0x84,0x83,0x00,0x00,0x00,0x33,0xff,0x83,0x7c,0x24,0x38,0x00,0x7e,0x14,0x48,0x8b,0xce,0xe8,0xd0,0xee,0x88,0xfc,0x85,0xc0,0x74,0x6e,0xff,0xc7,0x3b,0x7c,0x24,0x38,0x7c,0xec,0x48,0x8b,0xce,0x8b,0x54,0x24,0x38,0x48,0x8b,0x06,0x48,0x8b,0x40,0x60,0xff,0x50,0x30,0xeb,0x5c,0x48,0x8d,0x54,0x24,0x38,0x48,0x8b,0xce,0xe8,0xbc,0xee,0x88,0xfc,0x85,0xc0,0x74,0x42,0x48,0x8b,0xce,0x8b,0x54,0x24,0x38,0x48,0x8b,0x06,0x48,0x8b,0x40,0x60,0xff,0x50,0x38,0xeb,0x38,0x48,0x8d,0x54,0x24,0x38,0x48,0x8b,0xce,0xe8,0x98,0xee,0x88,0xfc,0x85,0xc0,0x74,0x1e,0x48,0x8b,0xce,0x8b,0x54,0x24,0x38,0x48,0x8b,0x06,0x48,0x8b,0x40,0x68,0xff,0x10,0xeb,0x15,0x48,0x8b,0xce,0xe8,0x6a,0xee,0x88,0xfc,0x85,0xc0,0x75,0x09,0x33,0xc0,0x48,0x83,0xc4,0x48,0x5e,0x5f,0xc3,0x48,0x8b,0xce,0x48,0x8b,0x06,0x48,0x8b,0x40,0x58,0xff,0x50,0x38,0xb8,0x01,0x00,0x00,0x00,0x48,0x83,0xc4,0x48,0x5e,0x5f,0xc3,0xe8,0x0f,0xf3,0xf7,0x59,0xcc,0x00,0x00,0x00,0x00,0x00,0x00,0x4d,0x00,0x00,0x00,0x4d,0x00,0x00,0x00,0x4d,0x00,0x00,0x00,0x4d,0x00,0x00,0x00,0x4d,0x00,0x00,0x00,0x4d,0x00,0x00,0x00,0x4d,0x00,0x00,0x00,0x4d,0x00,0x00,0x00,0x4d,0x00,0x00,0x00,0x4d,0x00,0x00,0x00,0x4d,0x00,0x00,0x00,0x4d,0x00,0x00,0x00,0x4d,0x00,0x00,0x00,0x5f,0x00,0x00,0x00,0xb4,0x02,0x00,0x00,0x17,0x01,0x00,0x00,0xcd,0x00,0x00,0x00,0x58,0x02,0x00,0x00,0x9f,0x01,0x00,0x00,0x03,0x02,0x00,0x00,0xb4,0x02,0x00,0x00,0xb4,0x02,0x00,0x00,0x4d,0x00,0x00,0x00,0x4d,0x00,0x00,0x00,0xb4,0x02,0x00,0x00,0x61,0x01,0x00,0x00,0x4d,0x00,0x00,0x00,0xd1,0x01,0x00,0x00,0x7c,0x02,0x00,0x00,0xb4,0x02,0x00,0x00,0xb4,0x02,0x00,0x00,0x9f,0x02,0x00,0x00,0x19,0x06,0x03,0x00,0x06,0x82,0x02,0x60,0x01,0x70,0x00,0x00,0x40,0x00,0x00,0x00,0xe0,0x03,0x03,0xe0,0xfd,0x7f,0x00,0x00,0x56,0x48,0x83,0xec,0x30,0x33,0xc0,0x48,0x89,0x44,0x24,0x28,0x48,0x8b,0xf1,0x48,0x8d,0x54,0x24,0x28,0x48,0x8b,0xce,0xe8,0x64,0xf3,0xff,0xff,0x85,0xc0,0x75,0x08,0x33,0xc0,0x48,0x83,0xc4,0x30,0x5e,0xc3,0x48,0x8b,0xce,0x48,0x8b,0x54,0x24,0x28,0x48,0x8b,0x06,0x48,0x8b,0x40,0x68,0xff,0x50,0x38,0xb8,0x01,0x00,0x00,0x00,0x48,0x83,0xc4,0x30,0x5e,0xc3};

        public static ReadOnlySpan<byte> ParseInternal_ᐤᐤ  =>  new byte[69]{0x56,0x48,0x83,0xec,0x30,0x33,0xc0,0x48,0x89,0x44,0x24,0x28,0x48,0x8b,0xf1,0x48,0x8d,0x54,0x24,0x28,0x48,0x8b,0xce,0xe8,0x64,0xf3,0xff,0xff,0x85,0xc0,0x75,0x08,0x33,0xc0,0x48,0x83,0xc4,0x30,0x5e,0xc3,0x48,0x8b,0xce,0x48,0x8b,0x54,0x24,0x28,0x48,0x8b,0x06,0x48,0x8b,0x40,0x68,0xff,0x50,0x38,0xb8,0x01,0x00,0x00,0x00,0x48,0x83,0xc4,0x30,0x5e,0xc3};

        public static ReadOnlySpan<byte> ParseTypeDefOrRefEncoded_ᐤ32iᕀoutㆍ8uᕀoutㆍ32iᕀoutᐤ  =>  new byte[72]{0x57,0x56,0x53,0x48,0x83,0xec,0x20,0x48,0x8b,0xf2,0x49,0x8b,0xf8,0x49,0x8b,0xd9,0xc6,0x07,0x00,0x33,0xd2,0x89,0x13,0x48,0x8b,0xd6,0xe8,0x31,0xed,0x88,0xfc,0x85,0xc0,0x75,0x0a,0x33,0xc0,0x48,0x83,0xc4,0x20,0x5b,0x5e,0x5f,0xc3,0x8b,0x06,0x83,0xe0,0x03,0x88,0x07,0x8b,0x06,0xc1,0xf8,0x02,0x89,0x03,0xb8,0x01,0x00,0x00,0x00,0x48,0x83,0xc4,0x20,0x5b,0x5e,0x5f,0xc3};

        public static ReadOnlySpan<byte> ParseNumber_ᐤ32iᕀoutᐤ  =>  new byte[254]{0x57,0x56,0x48,0x83,0xec,0x48,0x33,0xc0,0x48,0x89,0x44,0x24,0x40,0x48,0x89,0x44,0x24,0x38,0x48,0x89,0x44,0x24,0x30,0x48,0x89,0x44,0x24,0x28,0x48,0x8b,0xf1,0x48,0x8b,0xfa,0x33,0xd2,0x89,0x17,0x89,0x54,0x24,0x40,0x89,0x54,0x24,0x38,0x89,0x54,0x24,0x30,0x89,0x54,0x24,0x28,0x48,0x8d,0x54,0x24,0x40,0x48,0x8b,0xce,0xe8,0x1d,0xf2,0xff,0xff,0x85,0xc0,0x74,0x72,0x8b,0x54,0x24,0x40,0x0f,0xb6,0xd2,0x81,0xfa,0xff,0x00,0x00,0x00,0x74,0x63,0xf6,0xc2,0x80,0x75,0x07,0x89,0x17,0xe9,0x90,0x00,0x00,0x00,0x48,0x8d,0x54,0x24,0x38,0x48,0x8b,0xce,0xe8,0xf1,0xf1,0xff,0xff,0x85,0xc0,0x74,0x46,0x8b,0x54,0x24,0x40,0x0f,0xb6,0xd2,0xf6,0xc2,0x40,0x75,0x13,0x83,0xe2,0x3f,0xc1,0xe2,0x08,0x8b,0x4c,0x24,0x38,0x0f,0xb6,0xc9,0x0b,0xd1,0x89,0x17,0xeb,0x60,0xf6,0xc2,0x20,0x75,0x22,0x48,0x8d,0x54,0x24,0x30,0x48,0x8b,0xce,0xe8,0xbc,0xf1,0xff,0xff,0x85,0xc0,0x74,0x11,0x48,0x8d,0x54,0x24,0x28,0x48,0x8b,0xce,0xe8,0xab,0xf1,0xff,0xff,0x85,0xc0,0x75,0x09,0x33,0xc0,0x48,0x83,0xc4,0x48,0x5e,0x5f,0xc3,0x8b,0x44,0x24,0x40,0x0f,0xb6,0xc0,0x83,0xe0,0x1f,0xc1,0xe0,0x18,0x8b,0x54,0x24,0x38,0x0f,0xb6,0xd2,0xc1,0xe2,0x10,0x0b,0xc2,0x8b,0x54,0x24,0x30,0x0f,0xb6,0xd2,0xc1,0xe2,0x08,0x0b,0xc2,0x8b,0x54,0x24,0x28,0x0f,0xb6,0xd2,0x0b,0xc2,0x89,0x07,0xb8,0x01,0x00,0x00,0x00,0x48,0x83,0xc4,0x48,0x5e,0x5f,0xc3};

    }
}
