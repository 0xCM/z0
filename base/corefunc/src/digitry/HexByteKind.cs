//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    /// <summary>
    /// Classifies each byte value
    /// </summary>
    [Flags]
    public enum HexByteKind : byte
    {
        /// <summary> 
        /// Identifies the hex value 0x00 := 0
        /// </summary> 
        X00 = 0x00,

        /// <summary> 
        /// Identifies the hex value 0x01 := 1
        /// </summary> 
        X01 = 0x01,

        /// <summary> 
        /// Identifies the hex value 0x02 := 2
        /// </summary> 
        X02 = 0x02,

        /// <summary> 
        /// Identifies the hex value 0x03 := 3
        /// </summary> 
        X03 = 0x03,

        /// <summary> 
        /// Identifies the hex value 0x04 := 4
        /// </summary> 
        X04 = 0x04,

        /// <summary> 
        /// Identifies the hex value 0x05 := 5
        /// </summary> 
        X05 = 0x05,

        /// <summary> 
        /// Identifies the hex value 0x06 := 6
        /// </summary> 
        X06 = 0x06,

        /// <summary> 
        /// Identifies the hex value 0x07 := 7
        /// </summary> 
        X07 = 0x07,

        /// <summary> 
        /// Identifies the hex value 0x08 := 8
        /// </summary> 
        X08 = 0x08,

        /// <summary> 
        /// Identifies the hex value 0x09 := 9
        /// </summary> 
        X09 = 0x09,

        /// <summary> 
        /// Identifies the hex value 0x0A := 10
        /// </summary> 
        X0A = 0x0A,

        /// <summary> 
        /// Identifies the hex value 0x0B := 11
        /// </summary> 
        X0B = 0x0B,

        /// <summary> 
        /// Identifies the hex value 0x0C := 12
        /// </summary> 
        X0C = 0x0C,

        /// <summary> 
        /// Identifies the hex value 0x0D := 13
        /// </summary> 
        X0D = 0x0D,

        /// <summary> 
        /// Identifies the hex value 0x0E := 14
        /// </summary> 
        X0E = 0x0E,

        /// <summary> 
        /// Identifies the hex value 0x0F := 15
        /// </summary> 
        X0F = 0x0F,

        /// <summary> 
        /// Identifies the hex value 0x10 := 16
        /// </summary> 
        X10 = 0x10,

        /// <summary> 
        /// Identifies the hex value 0x11 := 17
        /// </summary> 
        X11 = 0x11,

        /// <summary> 
        /// Identifies the hex value 0x12 := 18
        /// </summary> 
        X12 = 0x12,

        /// <summary> 
        /// Identifies the hex value 0x13 := 19
        /// </summary> 
        X13 = 0x13,

        /// <summary> 
        /// Identifies the hex value 0x14 := 20
        /// </summary> 
        X14 = 0x14,

        /// <summary> 
        /// Identifies the hex value 0x15 := 21
        /// </summary> 
        X15 = 0x15,

        /// <summary> 
        /// Identifies the hex value 0x16 := 22
        /// </summary> 
        X16 = 0x16,

        /// <summary> 
        /// Identifies the hex value 0x17 := 23
        /// </summary> 
        X17 = 0x17,

        /// <summary> 
        /// Identifies the hex value 0x18 := 24
        /// </summary> 
        X18 = 0x18,

        /// <summary> 
        /// Identifies the hex value 0x19 := 25
        /// </summary> 
        X19 = 0x19,

        /// <summary> 
        /// Identifies the hex value 0x1A := 26
        /// </summary> 
        X1A = 0x1A,

        /// <summary> 
        /// Identifies the hex value 0x1B := 27
        /// </summary> 
        X1B = 0x1B,

        /// <summary> 
        /// Identifies the hex value 0x1C := 28
        /// </summary> 
        X1C = 0x1C,

        /// <summary> 
        /// Identifies the hex value 0x1D := 29
        /// </summary> 
        X1D = 0x1D,

        /// <summary> 
        /// Identifies the hex value 0x1E := 30
        /// </summary> 
        X1E = 0x1E,

        /// <summary> 
        /// Identifies the hex value 0x1F := 31
        /// </summary> 
        X1F = 0x1F,

        /// <summary> 
        /// Identifies the hex value 0x20 := 32
        /// </summary> 
        X20 = 0x20,

        /// <summary> 
        /// Identifies the hex value 0x21 := 33
        /// </summary> 
        X21 = 0x21,

        /// <summary> 
        /// Identifies the hex value 0x22 := 34
        /// </summary> 
        X22 = 0x22,

        /// <summary> 
        /// Identifies the hex value 0x23 := 35
        /// </summary> 
        X23 = 0x23,

        /// <summary> 
        /// Identifies the hex value 0x24 := 36
        /// </summary> 
        X24 = 0x24,

        /// <summary> 
        /// Identifies the hex value 0x25 := 37
        /// </summary> 
        X25 = 0x25,

        /// <summary> 
        /// Identifies the hex value 0x26 := 38
        /// </summary> 
        X26 = 0x26,

        /// <summary> 
        /// Identifies the hex value 0x27 := 39
        /// </summary> 
        X27 = 0x27,

        /// <summary> 
        /// Identifies the hex value 0x28 := 40
        /// </summary> 
        X28 = 0x28,

        /// <summary> 
        /// Identifies the hex value 0x29 := 41
        /// </summary> 
        X29 = 0x29,

        /// <summary> 
        /// Identifies the hex value 0x2A := 42
        /// </summary> 
        X2A = 0x2A,

        /// <summary> 
        /// Identifies the hex value 0x2B := 43
        /// </summary> 
        X2B = 0x2B,

        /// <summary> 
        /// Identifies the hex value 0x2C := 44
        /// </summary> 
        X2C = 0x2C,

        /// <summary> 
        /// Identifies the hex value 0x2D := 45
        /// </summary> 
        X2D = 0x2D,

        /// <summary> 
        /// Identifies the hex value 0x2E := 46
        /// </summary> 
        X2E = 0x2E,

        /// <summary> 
        /// Identifies the hex value 0x2F := 47
        /// </summary> 
        X2F = 0x2F,

        /// <summary> 
        /// Identifies the hex value 0x30 := 48
        /// </summary> 
        X30 = 0x30,

        /// <summary> 
        /// Identifies the hex value 0x31 := 49
        /// </summary> 
        X31 = 0x31,

        /// <summary> 
        /// Identifies the hex value 0x32 := 50
        /// </summary> 
        X32 = 0x32,

        /// <summary> 
        /// Identifies the hex value 0x33 := 51
        /// </summary> 
        X33 = 0x33,

        /// <summary> 
        /// Identifies the hex value 0x34 := 52
        /// </summary> 
        X34 = 0x34,

        /// <summary> 
        /// Identifies the hex value 0x35 := 53
        /// </summary> 
        X35 = 0x35,

        /// <summary> 
        /// Identifies the hex value 0x36 := 54
        /// </summary> 
        X36 = 0x36,

        /// <summary> 
        /// Identifies the hex value 0x37 := 55
        /// </summary> 
        X37 = 0x37,

        /// <summary> 
        /// Identifies the hex value 0x38 := 56
        /// </summary> 
        X38 = 0x38,

        /// <summary> 
        /// Identifies the hex value 0x39 := 57
        /// </summary> 
        X39 = 0x39,

        /// <summary> 
        /// Identifies the hex value 0x3A := 58
        /// </summary> 
        X3A = 0x3A,

        /// <summary> 
        /// Identifies the hex value 0x3B := 59
        /// </summary> 
        X3B = 0x3B,

        /// <summary> 
        /// Identifies the hex value 0x3C := 60
        /// </summary> 
        X3C = 0x3C,

        /// <summary> 
        /// Identifies the hex value 0x3D := 61
        /// </summary> 
        X3D = 0x3D,

        /// <summary> 
        /// Identifies the hex value 0x3E := 62
        /// </summary> 
        X3E = 0x3E,

        /// <summary> 
        /// Identifies the hex value 0x3F := 63
        /// </summary> 
        X3F = 0x3F,

        /// <summary> 
        /// Identifies the hex value 0x40 := 64
        /// </summary> 
        X40 = 0x40,

        /// <summary> 
        /// Identifies the hex value 0x41 := 65
        /// </summary> 
        X41 = 0x41,

        /// <summary> 
        /// Identifies the hex value 0x42 := 66
        /// </summary> 
        X42 = 0x42,

        /// <summary> 
        /// Identifies the hex value 0x43 := 67
        /// </summary> 
        X43 = 0x43,

        /// <summary> 
        /// Identifies the hex value 0x44 := 68
        /// </summary> 
        X44 = 0x44,

        /// <summary> 
        /// Identifies the hex value 0x45 := 69
        /// </summary> 
        X45 = 0x45,

        /// <summary> 
        /// Identifies the hex value 0x46 := 70
        /// </summary> 
        X46 = 0x46,

        /// <summary> 
        /// Identifies the hex value 0x47 := 71
        /// </summary> 
        X47 = 0x47,

        /// <summary> 
        /// Identifies the hex value 0x48 := 72
        /// </summary> 
        X48 = 0x48,

        /// <summary> 
        /// Identifies the hex value 0x49 := 73
        /// </summary> 
        X49 = 0x49,

        /// <summary> 
        /// Identifies the hex value 0x4A := 74
        /// </summary> 
        X4A = 0x4A,

        /// <summary> 
        /// Identifies the hex value 0x4B := 75
        /// </summary> 
        X4B = 0x4B,

        /// <summary> 
        /// Identifies the hex value 0x4C := 76
        /// </summary> 
        X4C = 0x4C,

        /// <summary> 
        /// Identifies the hex value 0x4D := 77
        /// </summary> 
        X4D = 0x4D,

        /// <summary> 
        /// Identifies the hex value 0x4E := 78
        /// </summary> 
        X4E = 0x4E,

        /// <summary> 
        /// Identifies the hex value 0x4F := 79
        /// </summary> 
        X4F = 0x4F,

        /// <summary> 
        /// Identifies the hex value 0x50 := 80
        /// </summary> 
        X50 = 0x50,

        /// <summary> 
        /// Identifies the hex value 0x51 := 81
        /// </summary> 
        X51 = 0x51,

        /// <summary> 
        /// Identifies the hex value 0x52 := 82
        /// </summary> 
        X52 = 0x52,

        /// <summary> 
        /// Identifies the hex value 0x53 := 83
        /// </summary> 
        X53 = 0x53,

        /// <summary> 
        /// Identifies the hex value 0x54 := 84
        /// </summary> 
        X54 = 0x54,

        /// <summary> 
        /// Identifies the hex value 0x55 := 85
        /// </summary> 
        X55 = 0x55,

        /// <summary> 
        /// Identifies the hex value 0x56 := 86
        /// </summary> 
        X56 = 0x56,

        /// <summary> 
        /// Identifies the hex value 0x57 := 87
        /// </summary> 
        X57 = 0x57,

        /// <summary> 
        /// Identifies the hex value 0x58 := 88
        /// </summary> 
        X58 = 0x58,

        /// <summary> 
        /// Identifies the hex value 0x59 := 89
        /// </summary> 
        X59 = 0x59,

        /// <summary> 
        /// Identifies the hex value 0x5A := 90
        /// </summary> 
        X5A = 0x5A,

        /// <summary> 
        /// Identifies the hex value 0x5B := 91
        /// </summary> 
        X5B = 0x5B,

        /// <summary> 
        /// Identifies the hex value 0x5C := 92
        /// </summary> 
        X5C = 0x5C,

        /// <summary> 
        /// Identifies the hex value 0x5D := 93
        /// </summary> 
        X5D = 0x5D,

        /// <summary> 
        /// Identifies the hex value 0x5E := 94
        /// </summary> 
        X5E = 0x5E,

        /// <summary> 
        /// Identifies the hex value 0x5F := 95
        /// </summary> 
        X5F = 0x5F,

        /// <summary> 
        /// Identifies the hex value 0x60 := 96
        /// </summary> 
        X60 = 0x60,

        /// <summary> 
        /// Identifies the hex value 0x61 := 97
        /// </summary> 
        X61 = 0x61,

        /// <summary> 
        /// Identifies the hex value 0x62 := 98
        /// </summary> 
        X62 = 0x62,

        /// <summary> 
        /// Identifies the hex value 0x63 := 99
        /// </summary> 
        X63 = 0x63,

        /// <summary> 
        /// Identifies the hex value 0x64 := 100
        /// </summary> 
        X64 = 0x64,

        /// <summary> 
        /// Identifies the hex value 0x65 := 101
        /// </summary> 
        X65 = 0x65,

        /// <summary> 
        /// Identifies the hex value 0x66 := 102
        /// </summary> 
        X66 = 0x66,

        /// <summary> 
        /// Identifies the hex value 0x67 := 103
        /// </summary> 
        X67 = 0x67,

        /// <summary> 
        /// Identifies the hex value 0x68 := 104
        /// </summary> 
        X68 = 0x68,

        /// <summary> 
        /// Identifies the hex value 0x69 := 105
        /// </summary> 
        X69 = 0x69,

        /// <summary> 
        /// Identifies the hex value 0x6A := 106
        /// </summary> 
        X6A = 0x6A,

        /// <summary> 
        /// Identifies the hex value 0x6B := 107
        /// </summary> 
        X6B = 0x6B,

        /// <summary> 
        /// Identifies the hex value 0x6C := 108
        /// </summary> 
        X6C = 0x6C,

        /// <summary> 
        /// Identifies the hex value 0x6D := 109
        /// </summary> 
        X6D = 0x6D,

        /// <summary> 
        /// Identifies the hex value 0x6E := 110
        /// </summary> 
        X6E = 0x6E,

        /// <summary> 
        /// Identifies the hex value 0x6F := 111
        /// </summary> 
        X6F = 0x6F,

        /// <summary> 
        /// Identifies the hex value 0x70 := 112
        /// </summary> 
        X70 = 0x70,

        /// <summary> 
        /// Identifies the hex value 0x71 := 113
        /// </summary> 
        X71 = 0x71,

        /// <summary> 
        /// Identifies the hex value 0x72 := 114
        /// </summary> 
        X72 = 0x72,

        /// <summary> 
        /// Identifies the hex value 0x73 := 115
        /// </summary> 
        X73 = 0x73,

        /// <summary> 
        /// Identifies the hex value 0x74 := 116
        /// </summary> 
        X74 = 0x74,

        /// <summary> 
        /// Identifies the hex value 0x75 := 117
        /// </summary> 
        X75 = 0x75,

        /// <summary> 
        /// Identifies the hex value 0x76 := 118
        /// </summary> 
        X76 = 0x76,

        /// <summary> 
        /// Identifies the hex value 0x77 := 119
        /// </summary> 
        X77 = 0x77,

        /// <summary> 
        /// Identifies the hex value 0x78 := 120
        /// </summary> 
        X78 = 0x78,

        /// <summary> 
        /// Identifies the hex value 0x79 := 121
        /// </summary> 
        X79 = 0x79,

        /// <summary> 
        /// Identifies the hex value 0x7A := 122
        /// </summary> 
        X7A = 0x7A,

        /// <summary> 
        /// Identifies the hex value 0x7B := 123
        /// </summary> 
        X7B = 0x7B,

        /// <summary> 
        /// Identifies the hex value 0x7C := 124
        /// </summary> 
        X7C = 0x7C,

        /// <summary> 
        /// Identifies the hex value 0x7D := 125
        /// </summary> 
        X7D = 0x7D,

        /// <summary> 
        /// Identifies the hex value 0x7E := 126
        /// </summary> 
        X7E = 0x7E,

        /// <summary> 
        /// Identifies the hex value 0x7F := 127
        /// </summary> 
        X7F = 0x7F,

        /// <summary> 
        /// Identifies the hex value 0x80 := 128
        /// </summary> 
        X80 = 0x80,

        /// <summary> 
        /// Identifies the hex value 0x81 := 129
        /// </summary> 
        X81 = 0x81,

        /// <summary> 
        /// Identifies the hex value 0x82 := 130
        /// </summary> 
        X82 = 0x82,

        /// <summary> 
        /// Identifies the hex value 0x83 := 131
        /// </summary> 
        X83 = 0x83,

        /// <summary> 
        /// Identifies the hex value 0x84 := 132
        /// </summary> 
        X84 = 0x84,

        /// <summary> 
        /// Identifies the hex value 0x85 := 133
        /// </summary> 
        X85 = 0x85,

        /// <summary> 
        /// Identifies the hex value 0x86 := 134
        /// </summary> 
        X86 = 0x86,

        /// <summary> 
        /// Identifies the hex value 0x87 := 135
        /// </summary> 
        X87 = 0x87,

        /// <summary> 
        /// Identifies the hex value 0x88 := 136
        /// </summary> 
        X88 = 0x88,

        /// <summary> 
        /// Identifies the hex value 0x89 := 137
        /// </summary> 
        X89 = 0x89,

        /// <summary> 
        /// Identifies the hex value 0x8A := 138
        /// </summary> 
        X8A = 0x8A,

        /// <summary> 
        /// Identifies the hex value 0x8B := 139
        /// </summary> 
        X8B = 0x8B,

        /// <summary> 
        /// Identifies the hex value 0x8C := 140
        /// </summary> 
        X8C = 0x8C,

        /// <summary> 
        /// Identifies the hex value 0x8D := 141
        /// </summary> 
        X8D = 0x8D,

        /// <summary> 
        /// Identifies the hex value 0x8E := 142
        /// </summary> 
        X8E = 0x8E,

        /// <summary> 
        /// Identifies the hex value 0x8F := 143
        /// </summary> 
        X8F = 0x8F,

        /// <summary> 
        /// Identifies the hex value 0x90 := 144
        /// </summary> 
        X90 = 0x90,

        /// <summary> 
        /// Identifies the hex value 0x91 := 145
        /// </summary> 
        X91 = 0x91,

        /// <summary> 
        /// Identifies the hex value 0x92 := 146
        /// </summary> 
        X92 = 0x92,

        /// <summary> 
        /// Identifies the hex value 0x93 := 147
        /// </summary> 
        X93 = 0x93,

        /// <summary> 
        /// Identifies the hex value 0x94 := 148
        /// </summary> 
        X94 = 0x94,

        /// <summary> 
        /// Identifies the hex value 0x95 := 149
        /// </summary> 
        X95 = 0x95,

        /// <summary> 
        /// Identifies the hex value 0x96 := 150
        /// </summary> 
        X96 = 0x96,

        /// <summary> 
        /// Identifies the hex value 0x97 := 151
        /// </summary> 
        X97 = 0x97,

        /// <summary> 
        /// Identifies the hex value 0x98 := 152
        /// </summary> 
        X98 = 0x98,

        /// <summary> 
        /// Identifies the hex value 0x99 := 153
        /// </summary> 
        X99 = 0x99,

        /// <summary> 
        /// Identifies the hex value 0x9A := 154
        /// </summary> 
        X9A = 0x9A,

        /// <summary> 
        /// Identifies the hex value 0x9B := 155
        /// </summary> 
        X9B = 0x9B,

        /// <summary> 
        /// Identifies the hex value 0x9C := 156
        /// </summary> 
        X9C = 0x9C,

        /// <summary> 
        /// Identifies the hex value 0x9D := 157
        /// </summary> 
        X9D = 0x9D,

        /// <summary> 
        /// Identifies the hex value 0x9E := 158
        /// </summary> 
        X9E = 0x9E,

        /// <summary> 
        /// Identifies the hex value 0x9F := 159
        /// </summary> 
        X9F = 0x9F,

        /// <summary> 
        /// Identifies the hex value 0xA0 := 160
        /// </summary> 
        XA0 = 0xA0,

        /// <summary> 
        /// Identifies the hex value 0xA1 := 161
        /// </summary> 
        XA1 = 0xA1,

        /// <summary> 
        /// Identifies the hex value 0xA2 := 162
        /// </summary> 
        XA2 = 0xA2,

        /// <summary> 
        /// Identifies the hex value 0xA3 := 163
        /// </summary> 
        XA3 = 0xA3,

        /// <summary> 
        /// Identifies the hex value 0xA4 := 164
        /// </summary> 
        XA4 = 0xA4,

        /// <summary> 
        /// Identifies the hex value 0xA5 := 165
        /// </summary> 
        XA5 = 0xA5,

        /// <summary> 
        /// Identifies the hex value 0xA6 := 166
        /// </summary> 
        XA6 = 0xA6,

        /// <summary> 
        /// Identifies the hex value 0xA7 := 167
        /// </summary> 
        XA7 = 0xA7,

        /// <summary> 
        /// Identifies the hex value 0xA8 := 168
        /// </summary> 
        XA8 = 0xA8,

        /// <summary> 
        /// Identifies the hex value 0xA9 := 169
        /// </summary> 
        XA9 = 0xA9,

        /// <summary> 
        /// Identifies the hex value 0xAA := 170
        /// </summary> 
        XAA = 0xAA,

        /// <summary> 
        /// Identifies the hex value 0xAB := 171
        /// </summary> 
        XAB = 0xAB,

        /// <summary> 
        /// Identifies the hex value 0xAC := 172
        /// </summary> 
        XAC = 0xAC,

        /// <summary> 
        /// Identifies the hex value 0xAD := 173
        /// </summary> 
        XAD = 0xAD,

        /// <summary> 
        /// Identifies the hex value 0xAE := 174
        /// </summary> 
        XAE = 0xAE,

        /// <summary> 
        /// Identifies the hex value 0xAF := 175
        /// </summary> 
        XAF = 0xAF,

        /// <summary> 
        /// Identifies the hex value 0xB0 := 176
        /// </summary> 
        XB0 = 0xB0,

        /// <summary> 
        /// Identifies the hex value 0xB1 := 177
        /// </summary> 
        XB1 = 0xB1,

        /// <summary> 
        /// Identifies the hex value 0xB2 := 178
        /// </summary> 
        XB2 = 0xB2,

        /// <summary> 
        /// Identifies the hex value 0xB3 := 179
        /// </summary> 
        XB3 = 0xB3,

        /// <summary> 
        /// Identifies the hex value 0xB4 := 180
        /// </summary> 
        XB4 = 0xB4,

        /// <summary> 
        /// Identifies the hex value 0xB5 := 181
        /// </summary> 
        XB5 = 0xB5,

        /// <summary> 
        /// Identifies the hex value 0xB6 := 182
        /// </summary> 
        XB6 = 0xB6,

        /// <summary> 
        /// Identifies the hex value 0xB7 := 183
        /// </summary> 
        XB7 = 0xB7,

        /// <summary> 
        /// Identifies the hex value 0xB8 := 184
        /// </summary> 
        XB8 = 0xB8,

        /// <summary> 
        /// Identifies the hex value 0xB9 := 185
        /// </summary> 
        XB9 = 0xB9,

        /// <summary> 
        /// Identifies the hex value 0xBA := 186
        /// </summary> 
        XBA = 0xBA,

        /// <summary> 
        /// Identifies the hex value 0xBB := 187
        /// </summary> 
        XBB = 0xBB,

        /// <summary> 
        /// Identifies the hex value 0xBC := 188
        /// </summary> 
        XBC = 0xBC,

        /// <summary> 
        /// Identifies the hex value 0xBD := 189
        /// </summary> 
        XBD = 0xBD,

        /// <summary> 
        /// Identifies the hex value 0xBE := 190
        /// </summary> 
        XBE = 0xBE,

        /// <summary> 
        /// Identifies the hex value 0xBF := 191
        /// </summary> 
        XBF = 0xBF,

        /// <summary> 
        /// Identifies the hex value 0xC0 := 192
        /// </summary> 
        XC0 = 0xC0,

        /// <summary> 
        /// Identifies the hex value 0xC1 := 193
        /// </summary> 
        XC1 = 0xC1,

        /// <summary> 
        /// Identifies the hex value 0xC2 := 194
        /// </summary> 
        XC2 = 0xC2,

        /// <summary> 
        /// Identifies the hex value 0xC3 := 195
        /// </summary> 
        XC3 = 0xC3,

        /// <summary> 
        /// Identifies the hex value 0xC4 := 196
        /// </summary> 
        XC4 = 0xC4,

        /// <summary> 
        /// Identifies the hex value 0xC5 := 197
        /// </summary> 
        XC5 = 0xC5,

        /// <summary> 
        /// Identifies the hex value 0xC6 := 198
        /// </summary> 
        XC6 = 0xC6,

        /// <summary> 
        /// Identifies the hex value 0xC7 := 199
        /// </summary> 
        XC7 = 0xC7,

        /// <summary> 
        /// Identifies the hex value 0xC8 := 200
        /// </summary> 
        XC8 = 0xC8,

        /// <summary> 
        /// Identifies the hex value 0xC9 := 201
        /// </summary> 
        XC9 = 0xC9,

        /// <summary> 
        /// Identifies the hex value 0xCA := 202
        /// </summary> 
        XCA = 0xCA,

        /// <summary> 
        /// Identifies the hex value 0xCB := 203
        /// </summary> 
        XCB = 0xCB,

        /// <summary> 
        /// Identifies the hex value 0xCC := 204
        /// </summary> 
        XCC = 0xCC,

        /// <summary> 
        /// Identifies the hex value 0xCD := 205
        /// </summary> 
        XCD = 0xCD,

        /// <summary> 
        /// Identifies the hex value 0xCE := 206
        /// </summary> 
        XCE = 0xCE,

        /// <summary> 
        /// Identifies the hex value 0xCF := 207
        /// </summary> 
        XCF = 0xCF,

        /// <summary> 
        /// Identifies the hex value 0xD0 := 208
        /// </summary> 
        XD0 = 0xD0,

        /// <summary> 
        /// Identifies the hex value 0xD1 := 209
        /// </summary> 
        XD1 = 0xD1,

        /// <summary> 
        /// Identifies the hex value 0xD2 := 210
        /// </summary> 
        XD2 = 0xD2,

        /// <summary> 
        /// Identifies the hex value 0xD3 := 211
        /// </summary> 
        XD3 = 0xD3,

        /// <summary> 
        /// Identifies the hex value 0xD4 := 212
        /// </summary> 
        XD4 = 0xD4,

        /// <summary> 
        /// Identifies the hex value 0xD5 := 213
        /// </summary> 
        XD5 = 0xD5,

        /// <summary> 
        /// Identifies the hex value 0xD6 := 214
        /// </summary> 
        XD6 = 0xD6,

        /// <summary> 
        /// Identifies the hex value 0xD7 := 215
        /// </summary> 
        XD7 = 0xD7,

        /// <summary> 
        /// Identifies the hex value 0xD8 := 216
        /// </summary> 
        XD8 = 0xD8,

        /// <summary> 
        /// Identifies the hex value 0xD9 := 217
        /// </summary> 
        XD9 = 0xD9,

        /// <summary> 
        /// Identifies the hex value 0xDA := 218
        /// </summary> 
        XDA = 0xDA,

        /// <summary> 
        /// Identifies the hex value 0xDB := 219
        /// </summary> 
        XDB = 0xDB,

        /// <summary> 
        /// Identifies the hex value 0xDC := 220
        /// </summary> 
        XDC = 0xDC,

        /// <summary> 
        /// Identifies the hex value 0xDD := 221
        /// </summary> 
        XDD = 0xDD,

        /// <summary> 
        /// Identifies the hex value 0xDE := 222
        /// </summary> 
        XDE = 0xDE,

        /// <summary> 
        /// Identifies the hex value 0xDF := 223
        /// </summary> 
        XDF = 0xDF,

        /// <summary> 
        /// Identifies the hex value 0xE0 := 224
        /// </summary> 
        XE0 = 0xE0,

        /// <summary> 
        /// Identifies the hex value 0xE1 := 225
        /// </summary> 
        XE1 = 0xE1,

        /// <summary> 
        /// Identifies the hex value 0xE2 := 226
        /// </summary> 
        XE2 = 0xE2,

        /// <summary> 
        /// Identifies the hex value 0xE3 := 227
        /// </summary> 
        XE3 = 0xE3,

        /// <summary> 
        /// Identifies the hex value 0xE4 := 228
        /// </summary> 
        XE4 = 0xE4,

        /// <summary> 
        /// Identifies the hex value 0xE5 := 229
        /// </summary> 
        XE5 = 0xE5,

        /// <summary> 
        /// Identifies the hex value 0xE6 := 230
        /// </summary> 
        XE6 = 0xE6,

        /// <summary> 
        /// Identifies the hex value 0xE7 := 231
        /// </summary> 
        XE7 = 0xE7,

        /// <summary> 
        /// Identifies the hex value 0xE8 := 232
        /// </summary> 
        XE8 = 0xE8,

        /// <summary> 
        /// Identifies the hex value 0xE9 := 233
        /// </summary> 
        XE9 = 0xE9,

        /// <summary> 
        /// Identifies the hex value 0xEA := 234
        /// </summary> 
        XEA = 0xEA,

        /// <summary> 
        /// Identifies the hex value 0xEB := 235
        /// </summary> 
        XEB = 0xEB,

        /// <summary> 
        /// Identifies the hex value 0xEC := 236
        /// </summary> 
        XEC = 0xEC,

        /// <summary> 
        /// Identifies the hex value 0xED := 237
        /// </summary> 
        XED = 0xED,

        /// <summary> 
        /// Identifies the hex value 0xEE := 238
        /// </summary> 
        XEE = 0xEE,

        /// <summary> 
        /// Identifies the hex value 0xEF := 239
        /// </summary> 
        XEF = 0xEF,

        /// <summary> 
        /// Identifies the hex value 0xF0 := 240
        /// </summary> 
        XF0 = 0xF0,

        /// <summary> 
        /// Identifies the hex value 0xF1 := 241
        /// </summary> 
        XF1 = 0xF1,

        /// <summary> 
        /// Identifies the hex value 0xF2 := 242
        /// </summary> 
        XF2 = 0xF2,

        /// <summary> 
        /// Identifies the hex value 0xF3 := 243
        /// </summary> 
        XF3 = 0xF3,

        /// <summary> 
        /// Identifies the hex value 0xF4 := 244
        /// </summary> 
        XF4 = 0xF4,

        /// <summary> 
        /// Identifies the hex value 0xF5 := 245
        /// </summary> 
        XF5 = 0xF5,

        /// <summary> 
        /// Identifies the hex value 0xF6 := 246
        /// </summary> 
        XF6 = 0xF6,

        /// <summary> 
        /// Identifies the hex value 0xF7 := 247
        /// </summary> 
        XF7 = 0xF7,

        /// <summary> 
        /// Identifies the hex value 0xF8 := 248
        /// </summary> 
        XF8 = 0xF8,

        /// <summary> 
        /// Identifies the hex value 0xF9 := 249
        /// </summary> 
        XF9 = 0xF9,

        /// <summary> 
        /// Identifies the hex value 0xFA := 250
        /// </summary> 
        XFA = 0xFA,

        /// <summary> 
        /// Identifies the hex value 0xFB := 251
        /// </summary> 
        XFB = 0xFB,

        /// <summary> 
        /// Identifies the hex value 0xFC := 252
        /// </summary> 
        XFC = 0xFC,

        /// <summary> 
        /// Identifies the hex value 0xFD := 253
        /// </summary> 
        XFD = 0xFD,

        /// <summary> 
        /// Identifies the hex value 0xFE := 254
        /// </summary> 
        XFE = 0xFE,

        /// <summary> 
        /// Identifies the hex value 0xFF := 255
        /// </summary> 
        XFF = 0xFF,

    }
}

