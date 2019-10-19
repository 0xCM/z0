//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Specifies ternary logic operator identifiers consistent with AVX-512 encoding
    /// </summary>
    [Flags]
    public enum TernaryLogicOpKind : byte
    {
        X00 = 0x00,
        
        /// <summary>
        /// 00000001
        /// </summary>
        X01 = 0x01,
        
        /// <summary>
        /// 00000010
        /// </summary>
        X02 = 0x02,
        
        /// <summary>
        /// 00000011
        /// </summary>
        X03 = 0x03,
        
        /// <summary>
        /// 00000100
        /// </summary>
        X04 = 0x04,
        
        /// <summary>
        /// 00000101
        /// </summary>
        X05 = 0x05,
        
        /// <summary>
        /// 00000110
        /// </summary>
        X06 = 0x06,
        
        /// <summary>
        /// 00000111
        /// </summary>
        X07 = 0x07,

        /// <summary>
        /// 00001000
        /// </summary>
        X08 = 0x08,

        /// <summary>
        /// 00001001
        ///  nor(a, xor(b,c))
        /// </summary>
        X09 = 0x09,

        /// <summary>
        /// 00001010
        /// </summary>
        X0A = 0x0a,

        /// <summary>
        /// 00001011
        /// </summary>
        X0B = 0x0b,

        /// <summary>
        /// 00001100
        /// </summary>
        X0C = 0x0c,

        /// <summary>
        /// 00001101
        /// </summary>
        X0D = 0x0d,

        /// <summary>
        /// 00001110
        /// </summary>
        X0E = 0x0e,

        /// <summary>
        /// 00001111
        /// </summary>
        X0F = 0x0f,

        /// <summary>
        /// 00010000
        /// </summary>
        X10 = 0x10,

        /// <summary>
        /// 00010001
        /// </summary>
        X11 = 0x11,

        /// <summary>
        /// 00010010
        /// </summary>
        X12 = 0x12,

        /// <summary>
        /// 00010011
        /// </summary>
        X13 = 0x13,

        /// <summary>
        /// 00010100
        /// </summary>
        X14 = 0x14,

        /// <summary>
        /// 00010101
        /// </summary>
        X15 = 0x15,

        /// <summary>
        /// 00010110
        /// </summary>
        X16 = 0x16,

        /// <summary>
        /// 00010111
        /// </summary>
        X17 = 0x17,

        /// <summary>
        /// 00011000
        /// </summary>
        X18 = 0x18,

        /// <summary>
        /// 00011001
        /// </summary>
        X19 = 0x19,

        /// <summary>
        /// 00011010
        /// </summary>
        X1A = 0x1a,

        /// <summary>
        /// 00011011
        /// </summary>
        X1B = 0x1b,

        /// <summary>
        /// 00011100
        /// </summary>
        X1C = 0x1c,

        /// <summary>
        /// 00011101
        /// </summary>
        X1D = 0x1d,

        /// <summary>
        /// 00011110
        /// </summary>
        X1E = 0x1e,

        /// <summary>
        /// 00011111
        /// </summary>
        X1F = 0x1f,

        /// <summary>
        /// 00100000
        /// </summary>
        X20 = 0x20,

        /// <summary>
        /// 00100001
        /// </summary>
        X21 = 0x21,

        /// <summary>
        /// 00100010
        /// </summary>
        X22 = 0x22,

        /// <summary>
        /// 00100011
        /// </summary>
        X23 = 0x23,

        /// <summary>
        /// 00100100
        /// </summary>
        X24 = 0x24,

        /// <summary>
        /// 00100101
        /// </summary>
        X25 = 0x25,

        /// <summary>
        /// 00100110
        /// </summary>
        X26 = 0x26,

        /// <summary>
        /// 00100111
        /// </summary>
        X27 = 0x27,

        /// <summary>
        /// 00101000
        /// </summary>
        X28 = 0x28,

        /// <summary>
        /// 00101001
        /// </summary>
        X29 = 0x29,

        /// <summary>
        /// 00101010
        /// </summary>
        X2A = 0x2a,

        /// <summary>
        /// 00101011
        /// </summary>
        X2B = 0x2b,

        /// <summary>
        /// 00101100
        /// </summary>
        X2C = 0x2c,

        /// <summary>
        ///  00101101
        /// </summary>
        X2D = 0x2d,

        /// <summary>
        /// 00101110
        /// </summary>
        X2E = 0x2e,

        /// <summary>
        /// 00101111
        /// </summary>
        X2F = 0x2f,

        /// <summary>
        /// 00110000
        ///  andnot(a,b)
        /// </summary>
        X30 = 0x30,

        /// <summary>
        /// 00110001
        /// </summary>
        X31 = 0x31,

        /// <summary>
        /// 00110010
        /// </summary>
        X32 = 0x32,

        /// <summary>
        /// 00110011
        ///  not(b)
        /// </summary>
        X33 = 0x33,

        /// <summary>
        /// 
        /// </summary>
        X34 = 0x34,

        /// <summary>
        /// 
        /// </summary>
        X35 = 0x35,

        /// <summary>
        /// 
        /// </summary>
        X36 = 0x36,

        /// <summary>
        /// 
        /// </summary>
        X37 = 0x37,

        /// <summary>
        /// 
        /// </summary>
        X38 = 0x38,

        /// <summary>
        /// 
        /// </summary>
        X39 = 0x39,

        /// <summary>
        /// 
        /// </summary>
        X3A = 0x3a,

        /// <summary>
        /// 
        /// </summary>
        X3B = 0x3b,

        /// <summary>
        /// xor(b,a)
        /// </summary>
        X3C = 0x3c,

        /// <summary>
        /// 
        /// </summary>
        X3D = 0x3d,

        /// <summary>
        /// 
        /// </summary>
        X3E = 0x3e,

        /// <summary>
        /// nand(b,a)
        /// </summary>
        X3F = 0x3f,

        /// <summary>
        /// 
        /// </summary>
        X40 = 0x40,

        /// <summary>
        /// 
        /// </summary>
        X41 = 0x41,

        /// <summary>
        /// 
        /// </summary>
        X42 = 0x42,

        /// <summary>
        /// 
        /// </summary>
        X43 = 0x43,

        /// <summary>
        /// andnot(b,c)
        /// </summary>
        X44 = 0x44,
        
        /// <summary>
        /// 
        /// </summary>
        X45 = 0x45,

        /// <summary>
        /// 
        /// </summary>
        X46 = 0x46,

        /// <summary>
        /// 
        /// </summary>
        X47 = 0x47,

        /// <summary>
        /// 
        /// </summary>
        X48 = 0x48,

        /// <summary>
        /// 
        /// </summary>
        X49 = 0x49,

        /// <summary>
        /// 
        /// </summary>
        X4A = 0x4a,

        /// <summary>
        /// 
        /// </summary>
        X4B = 0x4b,

        /// <summary>
        /// 
        /// </summary>
        X4C = 0x4c,

        /// <summary>
        /// 
        /// </summary>
        X4D = 0x4d,

        /// <summary>
        /// 
        /// </summary>
        X4E = 0x4e,

        /// <summary>
        /// 
        /// </summary>

        X4F = 0x4f,

        /// <summary>
        /// 
        /// </summary>
        X50 = 0x50,

        /// <summary>
        /// 
        /// </summary>
        X51 = 0x51,

        /// <summary>
        /// 
        /// </summary>
        X52 = 0x52,

        /// <summary>
        /// 
        /// </summary>
        X53 = 0x53,

        /// <summary>
        /// 
        /// </summary>
        X54 = 0x54,
        
        /// <summary>
        /// 01010101 
        /// </summary>
        X55 = 0x55,
        
        /// <summary>
        /// 
        /// </summary>
        X56 = 0x56,

        /// <summary>
        /// 
        /// </summary>
        X57 = 0x57,

        /// <summary>
        /// 
        /// </summary>
        X58 = 0x58,

        /// <summary>
        /// 
        /// </summary>
        X59 = 0x59,

        /// <summary>
        /// 
        /// </summary>
        X5A = 0x5a,

        /// <summary>
        /// 
        /// </summary>
        X5B = 0x5b,

        /// <summary>
        /// 
        /// </summary>
        X5C = 0x5c,

        /// <summary>
        /// 
        /// </summary>
        X5D = 0x5d,

        /// <summary>
        /// 
        /// </summary>
        X5E = 0x5e,

        /// <summary>
        /// 
        /// </summary>
        X5F = 0x5f,

        /// <summary>
        /// 
        /// </summary>
        X60 = 0x60,

        /// <summary>
        /// 
        /// </summary>
        X61 = 0x61,

        /// <summary>
        /// 
        /// </summary>
        X62 = 0x62,

        /// <summary>
        /// 
        /// </summary>
        X63 = 0x63,

        /// <summary>
        /// 
        /// </summary>
        X64 = 0x64,

        /// <summary>
        /// 
        /// </summary>
        X65 = 0x65,

        /// <summary>
        /// 
        /// </summary>
        X66 = 0x66,

        /// <summary>
        /// 
        /// </summary>
        X67 = 0x67,

        /// <summary>
        /// 
        /// </summary>

        /// <summary>
        /// 
        /// </summary>
        X68 = 0x68,

        /// <summary>
        /// 
        /// </summary>
        X69 = 0x69,

        /// <summary>
        /// 
        /// </summary>
        X6A = 0x6a,

        /// <summary>
        /// 
        /// </summary>
        X6B = 0x6b,

        /// <summary>
        /// 
        /// </summary>
        X6C = 0x6c,

        /// <summary>
        /// 
        /// </summary>
        X6D = 0x6d,

        /// <summary>
        /// 
        /// </summary>
        X6E = 0x6e,

        /// <summary>
        /// 
        /// </summary>
        X6F = 0x6f,

        /// <summary>
        /// 
        /// </summary>
        X70 = 0x70,

        /// <summary>
        /// 
        /// </summary>
        X71 = 0x71,

        /// <summary>
        /// 
        /// </summary>
        X72 = 0x72,

        /// <summary>
        /// 
        /// </summary>
        X73 = 0x73,

        /// <summary>
        /// 
        /// </summary>
        X74 = 0x74,

        /// <summary>
        /// 
        /// </summary>
        X75 = 0x75,

        /// <summary>
        /// 
        /// </summary>
        X76 = 0x76,

        /// <summary>
        /// 
        /// </summary>
        X77 = 0x77,

        /// <summary>
        /// 
        /// </summary>
        X78 = 0x78,

        /// <summary>
        /// 
        /// </summary>
        X79 = 0x79,

        /// <summary>
        /// 
        /// </summary>
        X7A = 0x7a,

        /// <summary>
        /// 
        /// </summary>
        X7B = 0x7b,

        /// <summary>
        /// 
        /// </summary>
        X7C = 0x7c,

        /// <summary>
        /// 
        /// </summary>
        X7D = 0x7d,

        /// <summary>
        /// 
        /// </summary>
        X7E = 0x7e,

        /// <summary>
        /// 
        /// </summary>
        X7F = 0x7f,

        /// <summary>
        /// 
        /// </summary>
        X80 = 0x80,

        /// <summary>
        /// 
        /// </summary>
        X81 = 0x81,

        /// <summary>
        /// 
        /// </summary>
        X82 = 0x82,

        /// <summary>
        /// 
        /// </summary>
        X83 = 0x83,

        /// <summary>
        /// 
        /// </summary>
        X84 = 0x84,

        /// <summary>
        /// 
        /// </summary>
        X85 = 0x85,

        /// <summary>
        /// 
        /// </summary>
        X86 = 0x86,

        /// <summary>
        /// 
        /// </summary>
        X87 = 0x87,

        /// <summary>
        /// 
        /// </summary>
        X88 = 0x88,

        /// <summary>
        /// 
        /// </summary>
        X89 = 0x89,

        /// <summary>
        /// 
        /// </summary>
        X8A = 0x8a,

        /// <summary>
        /// 
        /// </summary>
        X8B = 0x8b,

        /// <summary>
        /// 
        /// </summary>
        X8C = 0x8c,

        /// <summary>
        /// 
        /// </summary>
        X8D = 0x8d,

        /// <summary>
        /// 
        /// </summary>
        X8E = 0x8e,

        /// <summary>
        /// 
        /// </summary>
        X8F = 0x8f,

        /// <summary>
        /// 
        /// </summary>
        X90 = 0x90,

        /// <summary>
        /// 
        /// </summary>
        X91 = 0x91,

        /// <summary>
        /// 
        /// </summary>
        X92 = 0x92,

        /// <summary>
        /// 
        /// </summary>
        X93 = 0x93,

        /// <summary>
        /// 
        /// </summary>
        X94 = 0x94,

        /// <summary>
        /// 
        /// </summary>
        X95 = 0x95,

        /// <summary>
        /// 
        /// </summary>
        X96 = 0x96,

        /// <summary>
        /// 
        /// </summary>
        X97 = 0x97,

        /// <summary>
        /// 
        /// </summary>
        X98 = 0x98,

        /// <summary>
        /// 
        /// </summary>
        X99 = 0x99,

        /// <summary>
        /// 
        /// </summary>
        X9A = 0x9a,

        /// <summary>
        /// 
        /// </summary>
        X9B = 0x9b,

        /// <summary>
        /// 
        /// </summary>
        X9C = 0x9c,

        /// <summary>
        /// 
        /// </summary>
        X9D = 0x9d,

        /// <summary>
        /// 
        /// </summary>
        X9E = 0x9e,

        /// <summary>
        /// 
        /// </summary>
        X9F = 0x9f,

        /// <summary>
        /// 
        /// </summary>
        XA0 = 0xa0,

        /// <summary>
        /// 
        /// </summary>
        XA1 = 0xa1,

        /// <summary>
        /// 
        /// </summary>
        XA2 = 0xa2,

        /// <summary>
        /// 
        /// </summary>
        XA3 = 0xa3,

        /// <summary>
        /// 
        /// </summary>
        XA4 = 0xa4,

        /// <summary>
        /// 
        /// </summary>
        XA5 = 0xa5,

        /// <summary>
        /// 
        /// </summary>
        XA6 = 0xa6,

        /// <summary>
        /// 
        /// </summary>
        XA7 = 0xa7,

        /// <summary>
        /// 
        /// </summary>
        XA8 = 0xa8,

        /// <summary>
        /// 
        /// </summary>
        XA9 = 0xa9,

        
        /// <summary>
        /// 10101010
        /// </summary>
        XAA = 0xaa,

        /// <summary>
        /// 
        /// </summary>
        XAB = 0xab,

        /// <summary>
        /// 
        /// </summary>
        XAC = 0xac,

        /// <summary>
        /// 
        /// </summary>
        XAD = 0xad,

        /// <summary>
        /// 
        /// </summary>
        XAE = 0xae,

        /// <summary>
        /// 
        /// </summary>
        XAF = 0xaf,

        /// <summary>
        /// 
        /// </summary>
        XB0 = 0xb0,

        /// <summary>
        /// 
        /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
        XF2 = 0xf2,

        /// <summary>
        /// 
        /// </summary>
        XF3 = 0xf3,

        /// <summary>
        /// 
        /// </summary>
        XF4 = 0xf4,

        /// <summary>
        /// 
        /// </summary>
        XF5 = 0xf5,

        /// <summary>
        /// 
        /// </summary>
        XF6 = 0xf6,

        /// <summary>
        /// 
        /// </summary>
        XF7 = 0xf7,

        /// <summary>
        /// 
        /// </summary>
        XF8 = 0xf8,

        /// <summary>
        /// 
        /// </summary>
        XF9 = 0xf9,

        /// <summary>
        /// 
        /// </summary>
        XFA = 0xfa,

        /// <summary>
        /// 
        /// </summary>
        XFB = 0xfb,

        /// <summary>
        /// 
        /// </summary>
        XFC = 0xfc,

        /// <summary>
        /// 
        /// </summary>
        XFD = 0xfd,

        /// <summary>
        /// 
        /// </summary>
        XFE = 0xfe,

        /// <summary>
        /// 
        /// </summary>
        XFF = 0xff,
    }



}