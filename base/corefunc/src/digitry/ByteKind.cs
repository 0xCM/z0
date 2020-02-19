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
    public enum ByteKind : byte
    {
        /// <summary> 
        /// Identifies the decimal value 0 := 0x00 
        /// </summary> 
        b000 = 0,

        /// <summary> 
        /// Identifies the decimal value 1 := 0x01 
        /// </summary> 
        b001 = 1,

        /// <summary> 
        /// Identifies the decimal value 2 := 0x02 
        /// </summary> 
        b002 = 2,

        /// <summary> 
        /// Identifies the decimal value 3 := 0x03 
        /// </summary> 
        b003 = 3,

        /// <summary> 
        /// Identifies the decimal value 4 := 0x04 
        /// </summary> 
        b004 = 4,

        /// <summary> 
        /// Identifies the decimal value 5 := 0x05 
        /// </summary> 
        b005 = 5,

        /// <summary> 
        /// Identifies the decimal value 6 := 0x06 
        /// </summary> 
        b006 = 6,

        /// <summary> 
        /// Identifies the decimal value 7 := 0x07 
        /// </summary> 
        b007 = 7,

        /// <summary> 
        /// Identifies the decimal value 8 := 0x08 
        /// </summary> 
        b008 = 8,

        /// <summary> 
        /// Identifies the decimal value 9 := 0x09 
        /// </summary> 
        b009 = 9,

        /// <summary> 
        /// Identifies the decimal value 10 := 0x0A 
        /// </summary> 
        b010 = 10,

        /// <summary> 
        /// Identifies the decimal value 11 := 0x0B 
        /// </summary> 
        b011 = 11,

        /// <summary> 
        /// Identifies the decimal value 12 := 0x0C 
        /// </summary> 
        b012 = 12,

        /// <summary> 
        /// Identifies the decimal value 13 := 0x0D 
        /// </summary> 
        b013 = 13,

        /// <summary> 
        /// Identifies the decimal value 14 := 0x0E 
        /// </summary> 
        b014 = 14,

        /// <summary> 
        /// Identifies the decimal value 15 := 0x0F 
        /// </summary> 
        b015 = 15,

        /// <summary> 
        /// Identifies the decimal value 16 := 0x10 
        /// </summary> 
        b016 = 16,

        /// <summary> 
        /// Identifies the decimal value 17 := 0x11 
        /// </summary> 
        b017 = 17,

        /// <summary> 
        /// Identifies the decimal value 18 := 0x12 
        /// </summary> 
        b018 = 18,

        /// <summary> 
        /// Identifies the decimal value 19 := 0x13 
        /// </summary> 
        b019 = 19,

        /// <summary> 
        /// Identifies the decimal value 20 := 0x14 
        /// </summary> 
        b020 = 20,

        /// <summary> 
        /// Identifies the decimal value 21 := 0x15 
        /// </summary> 
        b021 = 21,

        /// <summary> 
        /// Identifies the decimal value 22 := 0x16 
        /// </summary> 
        b022 = 22,

        /// <summary> 
        /// Identifies the decimal value 23 := 0x17 
        /// </summary> 
        b023 = 23,

        /// <summary> 
        /// Identifies the decimal value 24 := 0x18 
        /// </summary> 
        b024 = 24,

        /// <summary> 
        /// Identifies the decimal value 25 := 0x19 
        /// </summary> 
        b025 = 25,

        /// <summary> 
        /// Identifies the decimal value 26 := 0x1A 
        /// </summary> 
        b026 = 26,

        /// <summary> 
        /// Identifies the decimal value 27 := 0x1B 
        /// </summary> 
        b027 = 27,

        /// <summary> 
        /// Identifies the decimal value 28 := 0x1C 
        /// </summary> 
        b028 = 28,

        /// <summary> 
        /// Identifies the decimal value 29 := 0x1D 
        /// </summary> 
        b029 = 29,

        /// <summary> 
        /// Identifies the decimal value 30 := 0x1E 
        /// </summary> 
        b030 = 30,

        /// <summary> 
        /// Identifies the decimal value 31 := 0x1F 
        /// </summary> 
        b031 = 31,

        /// <summary> 
        /// Identifies the decimal value 32 := 0x20 
        /// </summary> 
        b032 = 32,

        /// <summary> 
        /// Identifies the decimal value 33 := 0x21 
        /// </summary> 
        b033 = 33,

        /// <summary> 
        /// Identifies the decimal value 34 := 0x22 
        /// </summary> 
        b034 = 34,

        /// <summary> 
        /// Identifies the decimal value 35 := 0x23 
        /// </summary> 
        b035 = 35,

        /// <summary> 
        /// Identifies the decimal value 36 := 0x24 
        /// </summary> 
        b036 = 36,

        /// <summary> 
        /// Identifies the decimal value 37 := 0x25 
        /// </summary> 
        b037 = 37,

        /// <summary> 
        /// Identifies the decimal value 38 := 0x26 
        /// </summary> 
        b038 = 38,

        /// <summary> 
        /// Identifies the decimal value 39 := 0x27 
        /// </summary> 
        b039 = 39,

        /// <summary> 
        /// Identifies the decimal value 40 := 0x28 
        /// </summary> 
        b040 = 40,

        /// <summary> 
        /// Identifies the decimal value 41 := 0x29 
        /// </summary> 
        b041 = 41,

        /// <summary> 
        /// Identifies the decimal value 42 := 0x2A 
        /// </summary> 
        b042 = 42,

        /// <summary> 
        /// Identifies the decimal value 43 := 0x2B 
        /// </summary> 
        b043 = 43,

        /// <summary> 
        /// Identifies the decimal value 44 := 0x2C 
        /// </summary> 
        b044 = 44,

        /// <summary> 
        /// Identifies the decimal value 45 := 0x2D 
        /// </summary> 
        b045 = 45,

        /// <summary> 
        /// Identifies the decimal value 46 := 0x2E 
        /// </summary> 
        b046 = 46,

        /// <summary> 
        /// Identifies the decimal value 47 := 0x2F 
        /// </summary> 
        b047 = 47,

        /// <summary> 
        /// Identifies the decimal value 48 := 0x30 
        /// </summary> 
        b048 = 48,

        /// <summary> 
        /// Identifies the decimal value 49 := 0x31 
        /// </summary> 
        b049 = 49,

        /// <summary> 
        /// Identifies the decimal value 50 := 0x32 
        /// </summary> 
        b050 = 50,

        /// <summary> 
        /// Identifies the decimal value 51 := 0x33 
        /// </summary> 
        b051 = 51,

        /// <summary> 
        /// Identifies the decimal value 52 := 0x34 
        /// </summary> 
        b052 = 52,

        /// <summary> 
        /// Identifies the decimal value 53 := 0x35 
        /// </summary> 
        b053 = 53,

        /// <summary> 
        /// Identifies the decimal value 54 := 0x36 
        /// </summary> 
        b054 = 54,

        /// <summary> 
        /// Identifies the decimal value 55 := 0x37 
        /// </summary> 
        b055 = 55,

        /// <summary> 
        /// Identifies the decimal value 56 := 0x38 
        /// </summary> 
        b056 = 56,

        /// <summary> 
        /// Identifies the decimal value 57 := 0x39 
        /// </summary> 
        b057 = 57,

        /// <summary> 
        /// Identifies the decimal value 58 := 0x3A 
        /// </summary> 
        b058 = 58,

        /// <summary> 
        /// Identifies the decimal value 59 := 0x3B 
        /// </summary> 
        b059 = 59,

        /// <summary> 
        /// Identifies the decimal value 60 := 0x3C 
        /// </summary> 
        b060 = 60,

        /// <summary> 
        /// Identifies the decimal value 61 := 0x3D 
        /// </summary> 
        b061 = 61,

        /// <summary> 
        /// Identifies the decimal value 62 := 0x3E 
        /// </summary> 
        b062 = 62,

        /// <summary> 
        /// Identifies the decimal value 63 := 0x3F 
        /// </summary> 
        b063 = 63,

        /// <summary> 
        /// Identifies the decimal value 64 := 0x40 
        /// </summary> 
        b064 = 64,

        /// <summary> 
        /// Identifies the decimal value 65 := 0x41 
        /// </summary> 
        b065 = 65,

        /// <summary> 
        /// Identifies the decimal value 66 := 0x42 
        /// </summary> 
        b066 = 66,

        /// <summary> 
        /// Identifies the decimal value 67 := 0x43 
        /// </summary> 
        b067 = 67,

        /// <summary> 
        /// Identifies the decimal value 68 := 0x44 
        /// </summary> 
        b068 = 68,

        /// <summary> 
        /// Identifies the decimal value 69 := 0x45 
        /// </summary> 
        b069 = 69,

        /// <summary> 
        /// Identifies the decimal value 70 := 0x46 
        /// </summary> 
        b070 = 70,

        /// <summary> 
        /// Identifies the decimal value 71 := 0x47 
        /// </summary> 
        b071 = 71,

        /// <summary> 
        /// Identifies the decimal value 72 := 0x48 
        /// </summary> 
        b072 = 72,

        /// <summary> 
        /// Identifies the decimal value 73 := 0x49 
        /// </summary> 
        b073 = 73,

        /// <summary> 
        /// Identifies the decimal value 74 := 0x4A 
        /// </summary> 
        b074 = 74,

        /// <summary> 
        /// Identifies the decimal value 75 := 0x4B 
        /// </summary> 
        b075 = 75,

        /// <summary> 
        /// Identifies the decimal value 76 := 0x4C 
        /// </summary> 
        b076 = 76,

        /// <summary> 
        /// Identifies the decimal value 77 := 0x4D 
        /// </summary> 
        b077 = 77,

        /// <summary> 
        /// Identifies the decimal value 78 := 0x4E 
        /// </summary> 
        b078 = 78,

        /// <summary> 
        /// Identifies the decimal value 79 := 0x4F 
        /// </summary> 
        b079 = 79,

        /// <summary> 
        /// Identifies the decimal value 80 := 0x50 
        /// </summary> 
        b080 = 80,

        /// <summary> 
        /// Identifies the decimal value 81 := 0x51 
        /// </summary> 
        b081 = 81,

        /// <summary> 
        /// Identifies the decimal value 82 := 0x52 
        /// </summary> 
        b082 = 82,

        /// <summary> 
        /// Identifies the decimal value 83 := 0x53 
        /// </summary> 
        b083 = 83,

        /// <summary> 
        /// Identifies the decimal value 84 := 0x54 
        /// </summary> 
        b084 = 84,

        /// <summary> 
        /// Identifies the decimal value 85 := 0x55 
        /// </summary> 
        b085 = 85,

        /// <summary> 
        /// Identifies the decimal value 86 := 0x56 
        /// </summary> 
        b086 = 86,

        /// <summary> 
        /// Identifies the decimal value 87 := 0x57 
        /// </summary> 
        b087 = 87,

        /// <summary> 
        /// Identifies the decimal value 88 := 0x58 
        /// </summary> 
        b088 = 88,

        /// <summary> 
        /// Identifies the decimal value 89 := 0x59 
        /// </summary> 
        b089 = 89,

        /// <summary> 
        /// Identifies the decimal value 90 := 0x5A 
        /// </summary> 
        b090 = 90,

        /// <summary> 
        /// Identifies the decimal value 91 := 0x5B 
        /// </summary> 
        b091 = 91,

        /// <summary> 
        /// Identifies the decimal value 92 := 0x5C 
        /// </summary> 
        b092 = 92,

        /// <summary> 
        /// Identifies the decimal value 93 := 0x5D 
        /// </summary> 
        b093 = 93,

        /// <summary> 
        /// Identifies the decimal value 94 := 0x5E 
        /// </summary> 
        b094 = 94,

        /// <summary> 
        /// Identifies the decimal value 95 := 0x5F 
        /// </summary> 
        b095 = 95,

        /// <summary> 
        /// Identifies the decimal value 96 := 0x60 
        /// </summary> 
        b096 = 96,

        /// <summary> 
        /// Identifies the decimal value 97 := 0x61 
        /// </summary> 
        b097 = 97,

        /// <summary> 
        /// Identifies the decimal value 98 := 0x62 
        /// </summary> 
        b098 = 98,

        /// <summary> 
        /// Identifies the decimal value 99 := 0x63 
        /// </summary> 
        b099 = 99,

        /// <summary> 
        /// Identifies the decimal value 100 := 0x64 
        /// </summary> 
        b100 = 100,

        /// <summary> 
        /// Identifies the decimal value 101 := 0x65 
        /// </summary> 
        b101 = 101,

        /// <summary> 
        /// Identifies the decimal value 102 := 0x66 
        /// </summary> 
        b102 = 102,

        /// <summary> 
        /// Identifies the decimal value 103 := 0x67 
        /// </summary> 
        b103 = 103,

        /// <summary> 
        /// Identifies the decimal value 104 := 0x68 
        /// </summary> 
        b104 = 104,

        /// <summary> 
        /// Identifies the decimal value 105 := 0x69 
        /// </summary> 
        b105 = 105,

        /// <summary> 
        /// Identifies the decimal value 106 := 0x6A 
        /// </summary> 
        b106 = 106,

        /// <summary> 
        /// Identifies the decimal value 107 := 0x6B 
        /// </summary> 
        b107 = 107,

        /// <summary> 
        /// Identifies the decimal value 108 := 0x6C 
        /// </summary> 
        b108 = 108,

        /// <summary> 
        /// Identifies the decimal value 109 := 0x6D 
        /// </summary> 
        b109 = 109,

        /// <summary> 
        /// Identifies the decimal value 110 := 0x6E 
        /// </summary> 
        b110 = 110,

        /// <summary> 
        /// Identifies the decimal value 111 := 0x6F 
        /// </summary> 
        b111 = 111,

        /// <summary> 
        /// Identifies the decimal value 112 := 0x70 
        /// </summary> 
        b112 = 112,

        /// <summary> 
        /// Identifies the decimal value 113 := 0x71 
        /// </summary> 
        b113 = 113,

        /// <summary> 
        /// Identifies the decimal value 114 := 0x72 
        /// </summary> 
        b114 = 114,

        /// <summary> 
        /// Identifies the decimal value 115 := 0x73 
        /// </summary> 
        b115 = 115,

        /// <summary> 
        /// Identifies the decimal value 116 := 0x74 
        /// </summary> 
        b116 = 116,

        /// <summary> 
        /// Identifies the decimal value 117 := 0x75 
        /// </summary> 
        b117 = 117,

        /// <summary> 
        /// Identifies the decimal value 118 := 0x76 
        /// </summary> 
        b118 = 118,

        /// <summary> 
        /// Identifies the decimal value 119 := 0x77 
        /// </summary> 
        b119 = 119,

        /// <summary> 
        /// Identifies the decimal value 120 := 0x78 
        /// </summary> 
        b120 = 120,

        /// <summary> 
        /// Identifies the decimal value 121 := 0x79 
        /// </summary> 
        b121 = 121,

        /// <summary> 
        /// Identifies the decimal value 122 := 0x7A 
        /// </summary> 
        b122 = 122,

        /// <summary> 
        /// Identifies the decimal value 123 := 0x7B 
        /// </summary> 
        b123 = 123,

        /// <summary> 
        /// Identifies the decimal value 124 := 0x7C 
        /// </summary> 
        b124 = 124,

        /// <summary> 
        /// Identifies the decimal value 125 := 0x7D 
        /// </summary> 
        b125 = 125,

        /// <summary> 
        /// Identifies the decimal value 126 := 0x7E 
        /// </summary> 
        b126 = 126,

        /// <summary> 
        /// Identifies the decimal value 127 := 0x7F 
        /// </summary> 
        b127 = 127,

        /// <summary> 
        /// Identifies the decimal value 128 := 0x80 
        /// </summary> 
        b128 = 128,

        /// <summary> 
        /// Identifies the decimal value 129 := 0x81 
        /// </summary> 
        b129 = 129,

        /// <summary> 
        /// Identifies the decimal value 130 := 0x82 
        /// </summary> 
        b130 = 130,

        /// <summary> 
        /// Identifies the decimal value 131 := 0x83 
        /// </summary> 
        b131 = 131,

        /// <summary> 
        /// Identifies the decimal value 132 := 0x84 
        /// </summary> 
        b132 = 132,

        /// <summary> 
        /// Identifies the decimal value 133 := 0x85 
        /// </summary> 
        b133 = 133,

        /// <summary> 
        /// Identifies the decimal value 134 := 0x86 
        /// </summary> 
        b134 = 134,

        /// <summary> 
        /// Identifies the decimal value 135 := 0x87 
        /// </summary> 
        b135 = 135,

        /// <summary> 
        /// Identifies the decimal value 136 := 0x88 
        /// </summary> 
        b136 = 136,

        /// <summary> 
        /// Identifies the decimal value 137 := 0x89 
        /// </summary> 
        b137 = 137,

        /// <summary> 
        /// Identifies the decimal value 138 := 0x8A 
        /// </summary> 
        b138 = 138,

        /// <summary> 
        /// Identifies the decimal value 139 := 0x8B 
        /// </summary> 
        b139 = 139,

        /// <summary> 
        /// Identifies the decimal value 140 := 0x8C 
        /// </summary> 
        b140 = 140,

        /// <summary> 
        /// Identifies the decimal value 141 := 0x8D 
        /// </summary> 
        b141 = 141,

        /// <summary> 
        /// Identifies the decimal value 142 := 0x8E 
        /// </summary> 
        b142 = 142,

        /// <summary> 
        /// Identifies the decimal value 143 := 0x8F 
        /// </summary> 
        b143 = 143,

        /// <summary> 
        /// Identifies the decimal value 144 := 0x90 
        /// </summary> 
        b144 = 144,

        /// <summary> 
        /// Identifies the decimal value 145 := 0x91 
        /// </summary> 
        b145 = 145,

        /// <summary> 
        /// Identifies the decimal value 146 := 0x92 
        /// </summary> 
        b146 = 146,

        /// <summary> 
        /// Identifies the decimal value 147 := 0x93 
        /// </summary> 
        b147 = 147,

        /// <summary> 
        /// Identifies the decimal value 148 := 0x94 
        /// </summary> 
        b148 = 148,

        /// <summary> 
        /// Identifies the decimal value 149 := 0x95 
        /// </summary> 
        b149 = 149,

        /// <summary> 
        /// Identifies the decimal value 150 := 0x96 
        /// </summary> 
        b150 = 150,

        /// <summary> 
        /// Identifies the decimal value 151 := 0x97 
        /// </summary> 
        b151 = 151,

        /// <summary> 
        /// Identifies the decimal value 152 := 0x98 
        /// </summary> 
        b152 = 152,

        /// <summary> 
        /// Identifies the decimal value 153 := 0x99 
        /// </summary> 
        b153 = 153,

        /// <summary> 
        /// Identifies the decimal value 154 := 0x9A 
        /// </summary> 
        b154 = 154,

        /// <summary> 
        /// Identifies the decimal value 155 := 0x9B 
        /// </summary> 
        b155 = 155,

        /// <summary> 
        /// Identifies the decimal value 156 := 0x9C 
        /// </summary> 
        b156 = 156,

        /// <summary> 
        /// Identifies the decimal value 157 := 0x9D 
        /// </summary> 
        b157 = 157,

        /// <summary> 
        /// Identifies the decimal value 158 := 0x9E 
        /// </summary> 
        b158 = 158,

        /// <summary> 
        /// Identifies the decimal value 159 := 0x9F 
        /// </summary> 
        b159 = 159,

        /// <summary> 
        /// Identifies the decimal value 160 := 0xA0 
        /// </summary> 
        b160 = 160,

        /// <summary> 
        /// Identifies the decimal value 161 := 0xA1 
        /// </summary> 
        b161 = 161,

        /// <summary> 
        /// Identifies the decimal value 162 := 0xA2 
        /// </summary> 
        b162 = 162,

        /// <summary> 
        /// Identifies the decimal value 163 := 0xA3 
        /// </summary> 
        b163 = 163,

        /// <summary> 
        /// Identifies the decimal value 164 := 0xA4 
        /// </summary> 
        b164 = 164,

        /// <summary> 
        /// Identifies the decimal value 165 := 0xA5 
        /// </summary> 
        b165 = 165,

        /// <summary> 
        /// Identifies the decimal value 166 := 0xA6 
        /// </summary> 
        b166 = 166,

        /// <summary> 
        /// Identifies the decimal value 167 := 0xA7 
        /// </summary> 
        b167 = 167,

        /// <summary> 
        /// Identifies the decimal value 168 := 0xA8 
        /// </summary> 
        b168 = 168,

        /// <summary> 
        /// Identifies the decimal value 169 := 0xA9 
        /// </summary> 
        b169 = 169,

        /// <summary> 
        /// Identifies the decimal value 170 := 0xAA 
        /// </summary> 
        b170 = 170,

        /// <summary> 
        /// Identifies the decimal value 171 := 0xAB 
        /// </summary> 
        b171 = 171,

        /// <summary> 
        /// Identifies the decimal value 172 := 0xAC 
        /// </summary> 
        b172 = 172,

        /// <summary> 
        /// Identifies the decimal value 173 := 0xAD 
        /// </summary> 
        b173 = 173,

        /// <summary> 
        /// Identifies the decimal value 174 := 0xAE 
        /// </summary> 
        b174 = 174,

        /// <summary> 
        /// Identifies the decimal value 175 := 0xAF 
        /// </summary> 
        b175 = 175,

        /// <summary> 
        /// Identifies the decimal value 176 := 0xB0 
        /// </summary> 
        b176 = 176,

        /// <summary> 
        /// Identifies the decimal value 177 := 0xB1 
        /// </summary> 
        b177 = 177,

        /// <summary> 
        /// Identifies the decimal value 178 := 0xB2 
        /// </summary> 
        b178 = 178,

        /// <summary> 
        /// Identifies the decimal value 179 := 0xB3 
        /// </summary> 
        b179 = 179,

        /// <summary> 
        /// Identifies the decimal value 180 := 0xB4 
        /// </summary> 
        b180 = 180,

        /// <summary> 
        /// Identifies the decimal value 181 := 0xB5 
        /// </summary> 
        b181 = 181,

        /// <summary> 
        /// Identifies the decimal value 182 := 0xB6 
        /// </summary> 
        b182 = 182,

        /// <summary> 
        /// Identifies the decimal value 183 := 0xB7 
        /// </summary> 
        b183 = 183,

        /// <summary> 
        /// Identifies the decimal value 184 := 0xB8 
        /// </summary> 
        b184 = 184,

        /// <summary> 
        /// Identifies the decimal value 185 := 0xB9 
        /// </summary> 
        b185 = 185,

        /// <summary> 
        /// Identifies the decimal value 186 := 0xBA 
        /// </summary> 
        b186 = 186,

        /// <summary> 
        /// Identifies the decimal value 187 := 0xBB 
        /// </summary> 
        b187 = 187,

        /// <summary> 
        /// Identifies the decimal value 188 := 0xBC 
        /// </summary> 
        b188 = 188,

        /// <summary> 
        /// Identifies the decimal value 189 := 0xBD 
        /// </summary> 
        b189 = 189,

        /// <summary> 
        /// Identifies the decimal value 190 := 0xBE 
        /// </summary> 
        b190 = 190,

        /// <summary> 
        /// Identifies the decimal value 191 := 0xBF 
        /// </summary> 
        b191 = 191,

        /// <summary> 
        /// Identifies the decimal value 192 := 0xC0 
        /// </summary> 
        b192 = 192,

        /// <summary> 
        /// Identifies the decimal value 193 := 0xC1 
        /// </summary> 
        b193 = 193,

        /// <summary> 
        /// Identifies the decimal value 194 := 0xC2 
        /// </summary> 
        b194 = 194,

        /// <summary> 
        /// Identifies the decimal value 195 := 0xC3 
        /// </summary> 
        b195 = 195,

        /// <summary> 
        /// Identifies the decimal value 196 := 0xC4 
        /// </summary> 
        b196 = 196,

        /// <summary> 
        /// Identifies the decimal value 197 := 0xC5 
        /// </summary> 
        b197 = 197,

        /// <summary> 
        /// Identifies the decimal value 198 := 0xC6 
        /// </summary> 
        b198 = 198,

        /// <summary> 
        /// Identifies the decimal value 199 := 0xC7 
        /// </summary> 
        b199 = 199,

        /// <summary> 
        /// Identifies the decimal value 200 := 0xC8 
        /// </summary> 
        b200 = 200,

        /// <summary> 
        /// Identifies the decimal value 201 := 0xC9 
        /// </summary> 
        b201 = 201,

        /// <summary> 
        /// Identifies the decimal value 202 := 0xCA 
        /// </summary> 
        b202 = 202,

        /// <summary> 
        /// Identifies the decimal value 203 := 0xCB 
        /// </summary> 
        b203 = 203,

        /// <summary> 
        /// Identifies the decimal value 204 := 0xCC 
        /// </summary> 
        b204 = 204,

        /// <summary> 
        /// Identifies the decimal value 205 := 0xCD 
        /// </summary> 
        b205 = 205,

        /// <summary> 
        /// Identifies the decimal value 206 := 0xCE 
        /// </summary> 
        b206 = 206,

        /// <summary> 
        /// Identifies the decimal value 207 := 0xCF 
        /// </summary> 
        b207 = 207,

        /// <summary> 
        /// Identifies the decimal value 208 := 0xD0 
        /// </summary> 
        b208 = 208,

        /// <summary> 
        /// Identifies the decimal value 209 := 0xD1 
        /// </summary> 
        b209 = 209,

        /// <summary> 
        /// Identifies the decimal value 210 := 0xD2 
        /// </summary> 
        b210 = 210,

        /// <summary> 
        /// Identifies the decimal value 211 := 0xD3 
        /// </summary> 
        b211 = 211,

        /// <summary> 
        /// Identifies the decimal value 212 := 0xD4 
        /// </summary> 
        b212 = 212,

        /// <summary> 
        /// Identifies the decimal value 213 := 0xD5 
        /// </summary> 
        b213 = 213,

        /// <summary> 
        /// Identifies the decimal value 214 := 0xD6 
        /// </summary> 
        b214 = 214,

        /// <summary> 
        /// Identifies the decimal value 215 := 0xD7 
        /// </summary> 
        b215 = 215,

        /// <summary> 
        /// Identifies the decimal value 216 := 0xD8 
        /// </summary> 
        b216 = 216,

        /// <summary> 
        /// Identifies the decimal value 217 := 0xD9 
        /// </summary> 
        b217 = 217,

        /// <summary> 
        /// Identifies the decimal value 218 := 0xDA 
        /// </summary> 
        b218 = 218,

        /// <summary> 
        /// Identifies the decimal value 219 := 0xDB 
        /// </summary> 
        b219 = 219,

        /// <summary> 
        /// Identifies the decimal value 220 := 0xDC 
        /// </summary> 
        b220 = 220,

        /// <summary> 
        /// Identifies the decimal value 221 := 0xDD 
        /// </summary> 
        b221 = 221,

        /// <summary> 
        /// Identifies the decimal value 222 := 0xDE 
        /// </summary> 
        b222 = 222,

        /// <summary> 
        /// Identifies the decimal value 223 := 0xDF 
        /// </summary> 
        b223 = 223,

        /// <summary> 
        /// Identifies the decimal value 224 := 0xE0 
        /// </summary> 
        b224 = 224,

        /// <summary> 
        /// Identifies the decimal value 225 := 0xE1 
        /// </summary> 
        b225 = 225,

        /// <summary> 
        /// Identifies the decimal value 226 := 0xE2 
        /// </summary> 
        b226 = 226,

        /// <summary> 
        /// Identifies the decimal value 227 := 0xE3 
        /// </summary> 
        b227 = 227,

        /// <summary> 
        /// Identifies the decimal value 228 := 0xE4 
        /// </summary> 
        b228 = 228,

        /// <summary> 
        /// Identifies the decimal value 229 := 0xE5 
        /// </summary> 
        b229 = 229,

        /// <summary> 
        /// Identifies the decimal value 230 := 0xE6 
        /// </summary> 
        b230 = 230,

        /// <summary> 
        /// Identifies the decimal value 231 := 0xE7 
        /// </summary> 
        b231 = 231,

        /// <summary> 
        /// Identifies the decimal value 232 := 0xE8 
        /// </summary> 
        b232 = 232,

        /// <summary> 
        /// Identifies the decimal value 233 := 0xE9 
        /// </summary> 
        b233 = 233,

        /// <summary> 
        /// Identifies the decimal value 234 := 0xEA 
        /// </summary> 
        b234 = 234,

        /// <summary> 
        /// Identifies the decimal value 235 := 0xEB 
        /// </summary> 
        b235 = 235,

        /// <summary> 
        /// Identifies the decimal value 236 := 0xEC 
        /// </summary> 
        b236 = 236,

        /// <summary> 
        /// Identifies the decimal value 237 := 0xED 
        /// </summary> 
        b237 = 237,

        /// <summary> 
        /// Identifies the decimal value 238 := 0xEE 
        /// </summary> 
        b238 = 238,

        /// <summary> 
        /// Identifies the decimal value 239 := 0xEF 
        /// </summary> 
        b239 = 239,

        /// <summary> 
        /// Identifies the decimal value 240 := 0xF0 
        /// </summary> 
        b240 = 240,

        /// <summary> 
        /// Identifies the decimal value 241 := 0xF1 
        /// </summary> 
        b241 = 241,

        /// <summary> 
        /// Identifies the decimal value 242 := 0xF2 
        /// </summary> 
        b242 = 242,

        /// <summary> 
        /// Identifies the decimal value 243 := 0xF3 
        /// </summary> 
        b243 = 243,

        /// <summary> 
        /// Identifies the decimal value 244 := 0xF4 
        /// </summary> 
        b244 = 244,

        /// <summary> 
        /// Identifies the decimal value 245 := 0xF5 
        /// </summary> 
        b245 = 245,

        /// <summary> 
        /// Identifies the decimal value 246 := 0xF6 
        /// </summary> 
        b246 = 246,

        /// <summary> 
        /// Identifies the decimal value 247 := 0xF7 
        /// </summary> 
        b247 = 247,

        /// <summary> 
        /// Identifies the decimal value 248 := 0xF8 
        /// </summary> 
        b248 = 248,

        /// <summary> 
        /// Identifies the decimal value 249 := 0xF9 
        /// </summary> 
        b249 = 249,

        /// <summary> 
        /// Identifies the decimal value 250 := 0xFA 
        /// </summary> 
        b250 = 250,

        /// <summary> 
        /// Identifies the decimal value 251 := 0xFB 
        /// </summary> 
        b251 = 251,

        /// <summary> 
        /// Identifies the decimal value 252 := 0xFC 
        /// </summary> 
        b252 = 252,

        /// <summary> 
        /// Identifies the decimal value 253 := 0xFD 
        /// </summary> 
        b253 = 253,

        /// <summary> 
        /// Identifies the decimal value 254 := 0xFE 
        /// </summary> 
        b254 = 254,

        /// <summary> 
        /// Identifies the decimal value 255 := 0xFF 
        /// </summary> 
        b255 = 255,

    }
}

