//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    public class HexCodes
    {
        [MethodImpl(Inline)]
        public static HexKind kind<H>(H h= default)
            where H : unmanaged, IHexCode
                => h.Kind;

        [MethodImpl(Inline)]
        public static byte value<H>(H h= default)
            where H : unmanaged, IHexCode
                => (byte)h.Kind;                

        static ReadOnlySpan<byte> Codes
            => new byte[256]{
                x00,x01,x02,x03,x04,x05,x06,x07,x08,x09,x0a,x0b,x0c,x0d,x0e,x0f,
                x10,x11,x12,x13,x14,x15,x16,x17,x18,x19,x1a,x1b,x1c,x1d,x1e,x1f,
                x20,x21,x22,x23,x24,x25,x26,x27,x28,x29,x2a,x2b,x2c,x2d,x2e,x2f,
                x30,x31,x32,x33,x34,x35,x36,x37,x38,x39,x3a,x3b,x3c,x3d,x3e,x3f,
                x40,x41,x42,x43,x44,x45,x46,x47,x48,x49,x4a,x4b,x4c,x4d,x4e,x4f,
                x50,x51,x52,x53,x54,x55,x56,x57,x58,x59,x5a,x5b,x5c,x5d,x5e,x5f,
                x60,x61,x62,x63,x64,x65,x66,x67,x68,x69,x6a,x6b,x6c,x6d,x6e,x6f,
                x70,x71,x72,x73,x74,x75,x76,x77,x78,x79,x7a,x7b,x7c,x7d,x7e,x7f,
                x80,x81,x82,x83,x84,x85,x86,x87,x88,x89,x8a,x8b,x8c,x8d,x8e,x8f,
                x90,x91,x92,x93,x94,x95,x96,x97,x98,x99,x9a,x9b,x9c,x9d,x9e,x9f,
                xa0,xa1,xa2,xa3,xa4,xa5,xa6,xa7,xa8,xa9,xaa,xab,xac,xad,xae,xaf,
                xb0,xb1,xb2,xb3,xb4,xb5,xb6,xb7,xb8,xb9,xba,xbb,xbc,xbd,xbe,xbf,
                xc0,xc1,xc2,xc3,xc4,xc5,xc6,xc7,xc8,xc9,xca,xcb,xcc,xcd,xce,xcf,
                xd0,xd1,xd2,xd3,xd4,xd5,xd6,xd7,xd8,xd9,xda,xdb,xdc,xdd,xde,xdf,
                xe0,xe1,xe2,xe3,xe4,xe5,xe6,xe7,xe8,xe9,xea,xeb,xec,xed,xee,xef,
                xf0,xf1,xf2,xf3,xf4,xf5,xf6,xf7,xf8,xf9,xfa,xfb,xfc,xfd,xfe,xff,
                };

        public static X00 x00 => default;

        public static X01 x01 => default;

        public static X02 x02 => default;

        public static X03 x03 => default;

        public static X04 x04 => default;

        public static X05 x05 => default;

        public static X06 x06 => default;

        public static X07 x07 => default;

        public static X08 x08 => default;

        public static X09 x09 => default;

        public static X0A x0a => default;

        public static X0B x0b => default;

        public static X0C x0c => default;

        public static X0D x0d => default;

        public static X0E x0e => default;

        public static X0F x0f => default;

        public static X10 x10 => default;

        public static X11 x11 => default;

        public static X12 x12 => default;

        public static X13 x13 => default;

        public static X14 x14 => default;

        public static X15 x15 => default;

        public static X16 x16 => default;

        public static X17 x17 => default;

        public static X18 x18 => default;

        public static X19 x19 => default;

        public static X1A x1a => default;

        public static X1B x1b => default;

        public static X1C x1c => default;

        public static X1D x1d => default;

        public static X1E x1e => default;

        public static X1F x1f => default;

        public static X20 x20 => default;

        public static X21 x21 => default;

        public static X22 x22 => default;

        public static X23 x23 => default;

        public static X24 x24 => default;

        public static X25 x25 => default;

        public static X26 x26 => default;

        public static X27 x27 => default;

        public static X28 x28 => default;

        public static X29 x29 => default;

        public static X2A x2a => default;

        public static X2B x2b => default;

        public static X2C x2c => default;

        public static X2D x2d => default;

        public static X2E x2e => default;

        public static X2F x2f => default;

        public static X30 x30 => default;

        public static X31 x31 => default;

        public static X32 x32 => default;

        public static X33 x33 => default;

        public static X34 x34 => default;

        public static X35 x35 => default;

        public static X36 x36 => default;

        public static X37 x37 => default;

        public static X38 x38 => default;

        public static X39 x39 => default;

        public static X3A x3a => default;

        public static X3B x3b => default;

        public static X3C x3c => default;

        public static X3D x3d => default;

        public static X3E x3e => default;

        public static X3F x3f => default;

        public static X40 x40 => default;

        public static X41 x41 => default;

        public static X42 x42 => default;

        public static X43 x43 => default;

        public static X44 x44 => default;

        public static X45 x45 => default;

        public static X46 x46 => default;

        public static X47 x47 => default;

        public static X48 x48 => default;

        public static X49 x49 => default;

        public static X4A x4a => default;

        public static X4B x4b => default;

        public static X4C x4c => default;

        public static X4D x4d => default;

        public static X4E x4e => default;

        public static X4F x4f => default;

        public static X50 x50 => default;

        public static X51 x51 => default;

        public static X52 x52 => default;

        public static X53 x53 => default;

        public static X54 x54 => default;

        public static X55 x55 => default;

        public static X56 x56 => default;

        public static X57 x57 => default;

        public static X58 x58 => default;

        public static X59 x59 => default;

        public static X5A x5a => default;

        public static X5B x5b => default;

        public static X5C x5c => default;

        public static X5D x5d => default;

        public static X5E x5e => default;

        public static X5F x5f => default;

        public static X60 x60 => default;

        public static X61 x61 => default;

        public static X62 x62 => default;

        public static X63 x63 => default;

        public static X64 x64 => default;

        public static X65 x65 => default;

        public static X66 x66 => default;

        public static X67 x67 => default;

        public static X68 x68 => default;

        public static X69 x69 => default;

        public static X6A x6a => default;

        public static X6B x6b => default;

        public static X6C x6c => default;

        public static X6D x6d => default;

        public static X6E x6e => default;

        public static X6F x6f => default;

        public static X70 x70 => default;

        public static X71 x71 => default;

        public static X72 x72 => default;

        /// <summary> 
        /// Defines 0x73 = 115
        /// </summary> 
        public static X73 x73 => default;

        /// <summary> 
        /// Defines 0x74 = 116
        /// </summary> 
        public static X74 x74 => default;

        /// <summary> 
        /// Defines 0x75 = 117
        /// </summary> 
        public static X75 x75 => default;

        /// <summary> 
        /// Defines 0x76 = 118
        /// </summary> 
        public static X76 x76 => default;

        public static X77 x77 => default;

        public static X78 x78 => default;

        public static X79 x79 => default;

        public static X7A x7a => default;

        public static X7B x7b => default;

        public static X7C x7c => default;

        public static X7D x7d => default;

        public static X7E x7e => default;

        public static X7F x7f => default;

        public static X80 x80 => default;

        public static X81 x81 => default;

        public static X82 x82 => default;

        public static X83 x83 => default;

        public static X84 x84 => default;

        public static X85 x85 => default;

        public static X86 x86 => default;

        public static X87 x87 => default;

        public static X88 x88 => default;

        public static X89 x89 => default;

        public static X8A x8a => default;

        public static X8B x8b => default;

        public static X8C x8c => default;

        public static X8D x8d => default;

        public static X8E x8e => default;

        public static X8F x8f => default;

        public static X90 x90 => default;

        public static X91 x91 => default;

        public static X92 x92 => default;

        public static X93 x93 => default;

        public static X94 x94 => default;

        public static X95 x95 => default;

        public static X96 x96 => default;

        public static X97 x97 => default;

        public static X98 x98 => default;

        public static X99 x99 => default;

        public static X9A x9a => default;

        public static X9B x9b => default;

        public static X9C x9c => default;

        public static X9D x9d => default;

        public static X9E x9e => default;

        public static X9F x9f => default;

        public static XA0 xa0 => default;

        public static XA1 xa1 => default;

        public static XA2 xa2 => default;

        public static XA3 xa3 => default;

        public static XA4 xa4 => default;

        public static XA5 xa5 => default;

        public static XA6 xa6 => default;

        public static XA7 xa7 => default;

        public static XA8 xa8 => default;

        public static XA9 xa9 => default;

        public static XAA xaa => default;

        public static XAB xab => default;

        public static XAC xac => default;

        public static XAD xad => default;

        public static XAE xae => default;

        public static XAF xaf => default;

        public static XB0 xb0 => default;

        public static XB1 xb1 => default;

        public static XB2 xb2 => default;

        public static XB3 xb3 => default;

        public static XB4 xb4 => default;

        public static XB5 xb5 => default;

        public static XB6 xb6 => default;

        public static XB7 xb7 => default;

        public static XB8 xb8 => default;

        public static XB9 xb9 => default;

        public static XBA xba => default;

        public static XBB xbb => default;

        public static XBC xbc => default;

        public static XBD xbd => default;

        public static XBE xbe => default;

        public static XBF xbf => default;

        public static XC0 xc0 => default;

        public static XC1 xc1 => default;

        public static XC2 xc2 => default;

        public static XC3 xc3 => default;

        public static XC4 xc4 => default;

        public static XC5 xc5 => default;

        public static XC6 xc6 => default;

        public static XC7 xc7 => default;

        public static XC8 xc8 => default;

        public static XC9 xc9 => default;

        public static XCA xca => default;

        public static XCB xcb => default;

        public static XCC xcc => default;

        public static XCD xcd => default;

        public static XCE xce => default;

        public static XCF xcf => default;

        public static XD0 xd0 => default;

        public static XD1 xd1 => default;

        public static XD2 xd2 => default;

        public static XD3 xd3 => default;

        public static XD4 xd4 => default;

        public static XD5 xd5 => default;

        public static XD6 xd6 => default;

        public static XD7 xd7 => default;

        public static XD8 xd8 => default;

        public static XD9 xd9 => default;

        public static XDA xda => default;

        public static XDB xdb => default;

        public static XDC xdc => default;

        public static XDD xdd => default;

        public static XDE xde => default;

        public static XDF xdf => default;

        public static XE0 xe0 => default;

        public static XE1 xe1 => default;

        public static XE2 xe2 => default;

        public static XE3 xe3 => default;

        public static XE4 xe4 => default;

        public static XE5 xe5 => default;

        public static XE6 xe6 => default;

        public static XE7 xe7 => default;

        public static XE8 xe8 => default;

        public static XE9 xe9 => default;

        public static XEA xea => default;

        public static XEB xeb => default;

        public static XEC xec => default;

        public static XED xed => default;

        public static XEE xee => default;

        public static XEF xef => default;

        public static XF0 xf0 => default;

        public static XF1 xf1 => default;

        public static XF2 xf2 => default;

        public static XF3 xf3 => default;

        public static XF4 xf4 => default;

        public static XF5 xf5 => default;

        public static XF6 xf6 => default;

        public static XF7 xf7 => default;

        public static XF8 xf8 => default;

        public static XF9 xf9 => default;

        public static XFA xfa => default;

        public static XFB xfb => default;

        public static XFC xfc => default;

        public static XFD xfd => default;

        public static XFE xfe => default;

        public static XFF xff => default;                
   }
}