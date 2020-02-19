//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [Flags]
    public enum ByteKind : byte
    {
        X00 = 0x00,

        X01 = 0x01,
        
        X02 = 0x02,
        
        X03 = 0x03,
        
        X04 = 0x04,
        
        X05 = 0x05,
        
        X06 = 0x06,
        
        X07 = 0x07,
        
        X08 = 0x08,
        
        X09 = 0x09,
        
        X0A = 0x0a,
        
        X0B = 0x0b,
        
        X0C = 0x0c,
        
        X0D = 0x0d,
        
        X0E = 0x0e,
        
        X0F = 0x0f,
        
        X10 = 0x10,
        
        X11 = 0x11,
        
        X12 = 0x12,
        
        X13 = 0x13,
        
        X14 = 0x14,
        
        X15 = 0x15,
        
        X16 = 0x16,
        
        X17 = 0x17,
        
        X18 = 0x18,
        
        X19 = 0x19,
        
        X1A = 0x1a,
        
        X1B = 0x1b,
        
        X1C = 0x1c,
        
        X1D = 0x1d,
        
        X1E = 0x1e,
        
        X1F = 0x1f,
        
        X20 = 0x20,
        
        X21 = 0x21,
        
        X22 = 0x22,
        
        X23 = 0x23,
        
        X24 = 0x24,
        
        X25 = 0x25,
        
        X26 = 0x26,
        
        X27 = 0x27,
        
        X28 = 0x28,
        
        X29 = 0x29,
        
        X2A = 0x2a,
        
        X2B = 0x2b,
        
        X2C = 0x2c,
        
        X2D = 0x2d,
        
        X2E = 0x2e,
        
        X2F = 0x2f,
        
        X30 = 0x30,
        
        X31 = 0x31,
        
        X32 = 0x32,
        
        X33 = 0x33,
        
        X34 = 0x34,
        
        X35 = 0x35,
        
        X36 = 0x36,
        
        X37 = 0x37,
        
        X38 = 0x38,
        
        X39 = 0x39,
        
        X3A = 0x3a,
        
        X3B = 0x3b,
        
        X3C = 0x3c,
        
        X3D = 0x3d,
        
        X3E = 0x3e,
        
        X3F = 0x3f,
        
        X40 = 0x40,
        
        X41 = 0x41,
        
        X42 = 0x42,
        
        X43 = 0x43,
        
        X44 = 0x44,
        
        X45 = 0x45,
        
        X46 = 0x46,
        
        X47 = 0x47,
        
        X48 = 0x48,
        
        X49 = 0x49,
        
        X4A = 0x4a,
        
        X4B = 0x4b,
        
        X4C = 0x4c,
        
        X4D = 0x4d,
        
        X4E = 0x4e,

        X4F = 0x4f,

        X50 = 0x50,

        X51 = 0x51,

        X52 = 0x52,

        X53 = 0x53,

        X54 = 0x54,

        X55 = 0x55,

        X56 = 0x56,

        X57 = 0x57,

        X58 = 0x58,

        X59 = 0x59,

        X5A = 0x5a,

        X5B = 0x5b,

        X5C = 0x5c,

        X5D = 0x5d,

        X5E = 0x5e,

        X5F = 0x5f,

        X60 = 0x60,

        X61 = 0x61,

        X62 = 0x62,

        X63 = 0x63,

        X64 = 0x64,

        X65 = 0x65,

        X66 = 0x66,

        X67 = 0x67,

        X68 = 0x68,

        X69 = 0x69,

        X6A = 0x6a,

        X6B = 0x6b,

        X6C = 0x6c,

        X6D = 0x6d,

        X6E = 0x6e,

        X6F = 0x6f,

        X70 = 0x70,

        X71 = 0x71,

        X72 = 0x72,

        X73 = 0x73,

        X74 = 0x74,

        X75 = 0x75,

        X76 = 0x76,

        X77 = 0x77,

        X78 = 0x78,

        X79 = 0x79,

        X7A = 0x7a,

        X7B = 0x7b,
        X7C = 0x7c,
        X7D = 0x7d,
        X7E = 0x7e,
        X7F = 0x7f,
        X80 = 0x80,
        X81 = 0x81,
        X82 = 0x82,
        X83 = 0x83,
        X84 = 0x84,
        X85 = 0x85,
        X86 = 0x86,
        X87 = 0x87,
        X88 = 0x88,
        X89 = 0x89,
        X8A = 0x8a,
        X8B = 0x8b,
        X8C = 0x8c,
        X8D = 0x8d,
        X8E = 0x8e,
        X8F = 0x8f,
        X90 = 0x90,
        X91 = 0x91,
        X92 = 0x92,
        X93 = 0x93,
        X94 = 0x94,
        X95 = 0x95,
        X96 = 0x96,
        X97 = 0x97,
        X98 = 0x98,
        X99 = 0x99,
        X9A = 0x9a,
        X9B = 0x9b,
        X9C = 0x9c,
        X9D = 0x9d,
        X9E = 0x9e,
        X9F = 0x9f,
        XA0 = 0xa0,
        XA1 = 0xa1,
        XA2 = 0xa2,
        XA3 = 0xa3,
        XA4 = 0xa4,
        XA5 = 0xa5,
        XA6 = 0xa6,
        XA7 = 0xa7,
        XA8 = 0xa8,
        XA9 = 0xa9,
        XAA = 0xaa,
        XAB = 0xab,
        XAC = 0xac,
        XAD = 0xad,
        XAE = 0xae,
        XAF = 0xaf,
        XB0 = 0xb0,
        XB1 = 0xb1,
        XB2 = 0xb2,
        XB3 = 0xb3,
        XB4 = 0xb4,
        XB5 = 0xb5,
        XB6 = 0xb6,
        XB7 = 0xb7,
        XB8 = 0xb8,
        XB9 = 0xb9,
        XBA = 0xba,
        XBB = 0xbb,
        XBC = 0xbc,
        XBD = 0xbd,
        XBE = 0xbe,
        XBF = 0xbf,
        XC0 = 0xc0,
        XC1 = 0xc1,
        XC2 = 0xc2,
        XC3 = 0xc3,
        XC4 = 0xc4,
        XC5 = 0xc5,
        XC6 = 0xc6,
        XC7 = 0xc7,
        XC8 = 0xc8,
        XC9 = 0xc9,
        XCA = 0xca,
        XCB = 0xcb,
        XCC = 0xcc,
        XCD = 0xcd,
        XCE = 0xce,
        XCF = 0xcf,
        XD0 = 0xd0,
        XD1 = 0xd1,
        XD2 = 0xd2,
        XD3 = 0xd3,
        XD4 = 0xd4,
        XD5 = 0xd5,
        XD6 = 0xd6,
        XD7 = 0xd7,
        XD8 = 0xd8,
        XD9 = 0xd9,
        XDA = 0xda,
        XDB = 0xdb,
        XDC = 0xdc,
        XDD = 0xdd,
        XDE = 0xde,
        XDF = 0xdf,
        XE0 = 0xe0,
        XE1 = 0xe1,
        XE2 = 0xe2,
        XE3 = 0xe3,
        XE4 = 0xe4,
        XE5 = 0xe5,
        XE6 = 0xe6,
        XE7 = 0xe7,
        XE8 = 0xe8,
        XE9 = 0xe9,
        XEA = 0xea,
        XEB = 0xeb,
        XEC = 0xec,
        XED = 0xed,
        XEE = 0xee,
        XEF = 0xef,
        XF0 = 0xf0,
        XF1 = 0xf1,
        XF2 = 0xf2,
        XF3 = 0xf3,
        XF4 = 0xf4,
        XF5 = 0xf5,
        XF6 = 0xf6,
        XF7 = 0xf7,
        XF8 = 0xf8,
        XF9 = 0xf9,
        XFA = 0xfa,
        XFB = 0xfb,
        XFC = 0xfc,
        XFD = 0xfd,
        XFE = 0xfe,
        XFF = 0xff,
    }
}