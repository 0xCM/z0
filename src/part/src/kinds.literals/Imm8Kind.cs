//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Defines identifiers corresponding to each value that can be represented with an 8-bit unsigned integer
    /// </summary>
    public enum Imm8Kind : byte
    {
        /// <summary> 
        /// Identifies the decimal value 0 := 0x00 
        /// </summary> 
        Imm0 = 0,

        /// <summary> 
        /// Identifies the decimal value 1 := 0x01 
        /// </summary> 
        Imm1 = 1,

        /// <summary> 
        /// Identifies the decimal value 2 := 0x02 
        /// </summary> 
        Imm2 = 2,

        /// <summary> 
        /// Identifies the decimal value 3 := 0x03 
        /// </summary> 
        Imm3 = 3,

        /// <summary> 
        /// Identifies the decimal value 4 := 0x04 
        /// </summary> 
        Imm4 = 4,

        /// <summary> 
        /// Identifies the decimal value 5 := 0x05 
        /// </summary> 
        Imm5 = 5,

        /// <summary> 
        /// Identifies the decimal value 6 := 0x06 
        /// </summary> 
        Imm6 = 6,

        /// <summary> 
        /// Identifies the decimal value 7 := 0x07 
        /// </summary> 
        Imm7 = 7,

        /// <summary> 
        /// Identifies the decimal value 8 := 0x08 
        /// </summary> 
        Imm8 = 8,

        /// <summary> 
        /// Identifies the decimal value 9 := 0x09 
        /// </summary> 
        Imm9 = 9,

        /// <summary> 
        /// Identifies the decimal value 10 := 0x0A 
        /// </summary> 
        Imm10 = 10,

        /// <summary> 
        /// Identifies the decimal value 11 := 0x0B 
        /// </summary> 
        Imm11 = 11,

        /// <summary> 
        /// Identifies the decimal value 12 := 0x0C 
        /// </summary> 
        Imm12 = 12,

        /// <summary> 
        /// Identifies the decimal value 13 := 0x0D 
        /// </summary> 
        Imm13 = 13,

        /// <summary> 
        /// Identifies the decimal value 14 := 0x0E 
        /// </summary> 
        Imm14 = 14,

        /// <summary> 
        /// Identifies the decimal value 15 := 0x0F 
        /// </summary> 
        Imm15 = 15,

        /// <summary> 
        /// Identifies the decimal value 16 := 0x10 
        /// </summary> 
        Imm16 = 16,

        /// <summary> 
        /// Identifies the decimal value 17 := 0x11 
        /// </summary> 
        Imm17 = 17,

        /// <summary> 
        /// Identifies the decimal value 18 := 0x12 
        /// </summary> 
        Imm18 = 18,

        /// <summary> 
        /// Identifies the decimal value 19 := 0x13 
        /// </summary> 
        Imm19 = 19,

        /// <summary> 
        /// Identifies the decimal value 20 := 0x14 
        /// </summary> 
        Imm20 = 20,

        /// <summary> 
        /// Identifies the decimal value 21 := 0x15 
        /// </summary> 
        Imm21 = 21,

        /// <summary> 
        /// Identifies the decimal value 22 := 0x16 
        /// </summary> 
        Imm22 = 22,

        /// <summary> 
        /// Identifies the decimal value 23 := 0x17 
        /// </summary> 
        Imm23 = 23,

        /// <summary> 
        /// Identifies the decimal value 24 := 0x18 
        /// </summary> 
        Imm24 = 24,

        /// <summary> 
        /// Identifies the decimal value 25 := 0x19 
        /// </summary> 
        Imm25 = 25,

        /// <summary> 
        /// Identifies the decimal value 26 := 0x1A 
        /// </summary> 
        Imm26 = 26,

        /// <summary> 
        /// Identifies the decimal value 27 := 0x1B 
        /// </summary> 
        Imm27 = 27,

        /// <summary> 
        /// Identifies the decimal value 28 := 0x1C 
        /// </summary> 
        Imm28 = 28,

        /// <summary> 
        /// Identifies the decimal value 29 := 0x1D 
        /// </summary> 
        Imm29 = 29,

        /// <summary> 
        /// Identifies the decimal value 30 := 0x1E 
        /// </summary> 
        Imm30 = 30,

        /// <summary> 
        /// Identifies the decimal value 31 := 0x1F 
        /// </summary> 
        Imm31 = 31,

        /// <summary> 
        /// Identifies the decimal value 32 := 0x20 
        /// </summary> 
        Imm32 = 32,

        /// <summary> 
        /// Identifies the decimal value 33 := 0x21 
        /// </summary> 
        Imm33 = 33,

        /// <summary> 
        /// Identifies the decimal value 34 := 0x22 
        /// </summary> 
        Imm34 = 34,

        /// <summary> 
        /// Identifies the decimal value 35 := 0x23 
        /// </summary> 
        Imm35 = 35,

        /// <summary> 
        /// Identifies the decimal value 36 := 0x24 
        /// </summary> 
        Imm36 = 36,

        /// <summary> 
        /// Identifies the decimal value 37 := 0x25 
        /// </summary> 
        Imm37 = 37,

        /// <summary> 
        /// Identifies the decimal value 38 := 0x26 
        /// </summary> 
        Imm38 = 38,

        /// <summary> 
        /// Identifies the decimal value 39 := 0x27 
        /// </summary> 
        Imm39 = 39,

        /// <summary> 
        /// Identifies the decimal value 40 := 0x28 
        /// </summary> 
        Imm40 = 40,

        /// <summary> 
        /// Identifies the decimal value 41 := 0x29 
        /// </summary> 
        Imm41 = 41,

        /// <summary> 
        /// Identifies the decimal value 42 := 0x2A 
        /// </summary> 
        Imm42 = 42,

        /// <summary> 
        /// Identifies the decimal value 43 := 0x2B 
        /// </summary> 
        Imm43 = 43,

        /// <summary> 
        /// Identifies the decimal value 44 := 0x2C 
        /// </summary> 
        Imm44 = 44,

        /// <summary> 
        /// Identifies the decimal value 45 := 0x2D 
        /// </summary> 
        Imm45 = 45,

        /// <summary> 
        /// Identifies the decimal value 46 := 0x2E 
        /// </summary> 
        Imm46 = 46,

        /// <summary> 
        /// Identifies the decimal value 47 := 0x2F 
        /// </summary> 
        Imm47 = 47,

        /// <summary> 
        /// Identifies the decimal value 48 := 0x30 
        /// </summary> 
        Imm48 = 48,

        /// <summary> 
        /// Identifies the decimal value 49 := 0x31 
        /// </summary> 
        Imm49 = 49,

        /// <summary> 
        /// Identifies the decimal value 50 := 0x32 
        /// </summary> 
        Imm50 = 50,

        /// <summary> 
        /// Identifies the decimal value 51 := 0x33 
        /// </summary> 
        Imm51 = 51,

        /// <summary> 
        /// Identifies the decimal value 52 := 0x34 
        /// </summary> 
        Imm52 = 52,

        /// <summary> 
        /// Identifies the decimal value 53 := 0x35 
        /// </summary> 
        Imm53 = 53,

        /// <summary> 
        /// Identifies the decimal value 54 := 0x36 
        /// </summary> 
        Imm54 = 54,

        /// <summary> 
        /// Identifies the decimal value 55 := 0x37 
        /// </summary> 
        Imm55 = 55,

        /// <summary> 
        /// Identifies the decimal value 56 := 0x38 
        /// </summary> 
        Imm56 = 56,

        /// <summary> 
        /// Identifies the decimal value 57 := 0x39 
        /// </summary> 
        Imm57 = 57,

        /// <summary> 
        /// Identifies the decimal value 58 := 0x3A 
        /// </summary> 
        Imm58 = 58,

        /// <summary> 
        /// Identifies the decimal value 59 := 0x3B 
        /// </summary> 
        Imm59 = 59,

        /// <summary> 
        /// Identifies the decimal value 60 := 0x3C 
        /// </summary> 
        Imm60 = 60,

        /// <summary> 
        /// Identifies the decimal value 61 := 0x3D 
        /// </summary> 
        Imm61 = 61,

        /// <summary> 
        /// Identifies the decimal value 62 := 0x3E 
        /// </summary> 
        Imm62 = 62,

        /// <summary> 
        /// Identifies the decimal value 63 := 0x3F 
        /// </summary> 
        Imm63 = 63,

        /// <summary> 
        /// Identifies the decimal value 64 := 0x40 
        /// </summary> 
        Imm64 = 64,

        /// <summary> 
        /// Identifies the decimal value 65 := 0x41 
        /// </summary> 
        Imm65 = 65,

        /// <summary> 
        /// Identifies the decimal value 66 := 0x42 
        /// </summary> 
        Imm66 = 66,

        /// <summary> 
        /// Identifies the decimal value 67 := 0x43 
        /// </summary> 
        Imm67 = 67,

        /// <summary> 
        /// Identifies the decimal value 68 := 0x44 
        /// </summary> 
        Imm68 = 68,

        /// <summary> 
        /// Identifies the decimal value 69 := 0x45 
        /// </summary> 
        Imm69 = 69,

        /// <summary> 
        /// Identifies the decimal value 70 := 0x46 
        /// </summary> 
        Imm70 = 70,

        /// <summary> 
        /// Identifies the decimal value 71 := 0x47 
        /// </summary> 
        Imm71 = 71,

        /// <summary> 
        /// Identifies the decimal value 72 := 0x48 
        /// </summary> 
        Imm72 = 72,

        /// <summary> 
        /// Identifies the decimal value 73 := 0x49 
        /// </summary> 
        Imm73 = 73,

        /// <summary> 
        /// Identifies the decimal value 74 := 0x4A 
        /// </summary> 
        Imm74 = 74,

        /// <summary> 
        /// Identifies the decimal value 75 := 0x4B 
        /// </summary> 
        Imm75 = 75,

        /// <summary> 
        /// Identifies the decimal value 76 := 0x4C 
        /// </summary> 
        Imm76 = 76,

        /// <summary> 
        /// Identifies the decimal value 77 := 0x4D 
        /// </summary> 
        Imm77 = 77,

        /// <summary> 
        /// Identifies the decimal value 78 := 0x4E 
        /// </summary> 
        Imm78 = 78,

        /// <summary> 
        /// Identifies the decimal value 79 := 0x4F 
        /// </summary> 
        Imm79 = 79,

        /// <summary> 
        /// Identifies the decimal value 80 := 0x50 
        /// </summary> 
        Imm80 = 80,

        /// <summary> 
        /// Identifies the decimal value 81 := 0x51 
        /// </summary> 
        Imm81 = 81,

        /// <summary> 
        /// Identifies the decimal value 82 := 0x52 
        /// </summary> 
        Imm82 = 82,

        /// <summary> 
        /// Identifies the decimal value 83 := 0x53 
        /// </summary> 
        Imm83 = 83,

        /// <summary> 
        /// Identifies the decimal value 84 := 0x54 
        /// </summary> 
        Imm84 = 84,

        /// <summary> 
        /// Identifies the decimal value 85 := 0x55 
        /// </summary> 
        Imm85 = 85,

        /// <summary> 
        /// Identifies the decimal value 86 := 0x56 
        /// </summary> 
        Imm86 = 86,

        /// <summary> 
        /// Identifies the decimal value 87 := 0x57 
        /// </summary> 
        Imm87 = 87,

        /// <summary> 
        /// Identifies the decimal value 88 := 0x58 
        /// </summary> 
        Imm88 = 88,

        /// <summary> 
        /// Identifies the decimal value 89 := 0x59 
        /// </summary> 
        Imm89 = 89,

        /// <summary> 
        /// Identifies the decimal value 90 := 0x5A 
        /// </summary> 
        Imm90 = 90,

        /// <summary> 
        /// Identifies the decimal value 91 := 0x5B 
        /// </summary> 
        Imm91 = 91,

        /// <summary> 
        /// Identifies the decimal value 92 := 0x5C 
        /// </summary> 
        Imm92 = 92,

        /// <summary> 
        /// Identifies the decimal value 93 := 0x5D 
        /// </summary> 
        Imm93 = 93,

        /// <summary> 
        /// Identifies the decimal value 94 := 0x5E 
        /// </summary> 
        Imm94 = 94,

        /// <summary> 
        /// Identifies the decimal value 95 := 0x5F 
        /// </summary> 
        Imm95 = 95,

        /// <summary> 
        /// Identifies the decimal value 96 := 0x60 
        /// </summary> 
        Imm96 = 96,

        /// <summary> 
        /// Identifies the decimal value 97 := 0x61 
        /// </summary> 
        Imm97 = 97,

        /// <summary> 
        /// Identifies the decimal value 98 := 0x62 
        /// </summary> 
        Imm98 = 98,

        /// <summary> 
        /// Identifies the decimal value 99 := 0x63 
        /// </summary> 
        Imm99 = 99,

        /// <summary> 
        /// Identifies the decimal value 100 := 0x64 
        /// </summary> 
        Imm100 = 100,

        /// <summary> 
        /// Identifies the decimal value 101 := 0x65 
        /// </summary> 
        Imm101 = 101,

        /// <summary> 
        /// Identifies the decimal value 102 := 0x66 
        /// </summary> 
        Imm102 = 102,

        /// <summary> 
        /// Identifies the decimal value 103 := 0x67 
        /// </summary> 
        Imm103 = 103,

        /// <summary> 
        /// Identifies the decimal value 104 := 0x68 
        /// </summary> 
        Imm104 = 104,

        /// <summary> 
        /// Identifies the decimal value 105 := 0x69 
        /// </summary> 
        Imm105 = 105,

        /// <summary> 
        /// Identifies the decimal value 106 := 0x6A 
        /// </summary> 
        Imm106 = 106,

        /// <summary> 
        /// Identifies the decimal value 107 := 0x6B 
        /// </summary> 
        Imm107 = 107,

        /// <summary> 
        /// Identifies the decimal value 108 := 0x6C 
        /// </summary> 
        Imm108 = 108,

        /// <summary> 
        /// Identifies the decimal value 109 := 0x6D 
        /// </summary> 
        Imm109 = 109,

        /// <summary> 
        /// Identifies the decimal value 110 := 0x6E 
        /// </summary> 
        Imm110 = 110,

        /// <summary> 
        /// Identifies the decimal value 111 := 0x6F 
        /// </summary> 
        Imm111 = 111,

        /// <summary> 
        /// Identifies the decimal value 112 := 0x70 
        /// </summary> 
        Imm112 = 112,

        /// <summary> 
        /// Identifies the decimal value 113 := 0x71 
        /// </summary> 
        Imm113 = 113,

        /// <summary> 
        /// Identifies the decimal value 114 := 0x72 
        /// </summary> 
        Imm114 = 114,

        /// <summary> 
        /// Identifies the decimal value 115 := 0x73 
        /// </summary> 
        Imm115 = 115,

        /// <summary> 
        /// Identifies the decimal value 116 := 0x74 
        /// </summary> 
        Imm116 = 116,

        /// <summary> 
        /// Identifies the decimal value 117 := 0x75 
        /// </summary> 
        Imm117 = 117,

        /// <summary> 
        /// Identifies the decimal value 118 := 0x76 
        /// </summary> 
        Imm118 = 118,

        /// <summary> 
        /// Identifies the decimal value 119 := 0x77 
        /// </summary> 
        Imm119 = 119,

        /// <summary> 
        /// Identifies the decimal value 120 := 0x78 
        /// </summary> 
        Imm120 = 120,

        /// <summary> 
        /// Identifies the decimal value 121 := 0x79 
        /// </summary> 
        Imm121 = 121,

        /// <summary> 
        /// Identifies the decimal value 122 := 0x7A 
        /// </summary> 
        Imm122 = 122,

        /// <summary> 
        /// Identifies the decimal value 123 := 0x7B 
        /// </summary> 
        Imm123 = 123,

        /// <summary> 
        /// Identifies the decimal value 124 := 0x7C 
        /// </summary> 
        Imm124 = 124,

        /// <summary> 
        /// Identifies the decimal value 125 := 0x7D 
        /// </summary> 
        Imm125 = 125,

        /// <summary> 
        /// Identifies the decimal value 126 := 0x7E 
        /// </summary> 
        Imm126 = 126,

        /// <summary> 
        /// Identifies the decimal value 127 := 0x7F 
        /// </summary> 
        Imm127 = 127,

        /// <summary> 
        /// Identifies the decimal value 128 := 0x80 
        /// </summary> 
        Imm128 = 128,

        /// <summary> 
        /// Identifies the decimal value 129 := 0x81 
        /// </summary> 
        Imm129 = 129,

        /// <summary> 
        /// Identifies the decimal value 130 := 0x82 
        /// </summary> 
        Imm130 = 130,

        /// <summary> 
        /// Identifies the decimal value 131 := 0x83 
        /// </summary> 
        Imm131 = 131,

        /// <summary> 
        /// Identifies the decimal value 132 := 0x84 
        /// </summary> 
        Imm132 = 132,

        /// <summary> 
        /// Identifies the decimal value 133 := 0x85 
        /// </summary> 
        Imm133 = 133,

        /// <summary> 
        /// Identifies the decimal value 134 := 0x86 
        /// </summary> 
        Imm134 = 134,

        /// <summary> 
        /// Identifies the decimal value 135 := 0x87 
        /// </summary> 
        Imm135 = 135,

        /// <summary> 
        /// Identifies the decimal value 136 := 0x88 
        /// </summary> 
        Imm136 = 136,

        /// <summary> 
        /// Identifies the decimal value 137 := 0x89 
        /// </summary> 
        Imm137 = 137,

        /// <summary> 
        /// Identifies the decimal value 138 := 0x8A 
        /// </summary> 
        Imm138 = 138,

        /// <summary> 
        /// Identifies the decimal value 139 := 0x8B 
        /// </summary> 
        Imm139 = 139,

        /// <summary> 
        /// Identifies the decimal value 140 := 0x8C 
        /// </summary> 
        Imm140 = 140,

        /// <summary> 
        /// Identifies the decimal value 141 := 0x8D 
        /// </summary> 
        Imm141 = 141,

        /// <summary> 
        /// Identifies the decimal value 142 := 0x8E 
        /// </summary> 
        Imm142 = 142,

        /// <summary> 
        /// Identifies the decimal value 143 := 0x8F 
        /// </summary> 
        Imm143 = 143,

        /// <summary> 
        /// Identifies the decimal value 144 := 0x90 
        /// </summary> 
        Imm144 = 144,

        /// <summary> 
        /// Identifies the decimal value 145 := 0x91 
        /// </summary> 
        Imm145 = 145,

        /// <summary> 
        /// Identifies the decimal value 146 := 0x92 
        /// </summary> 
        Imm146 = 146,

        /// <summary> 
        /// Identifies the decimal value 147 := 0x93 
        /// </summary> 
        Imm147 = 147,

        /// <summary> 
        /// Identifies the decimal value 148 := 0x94 
        /// </summary> 
        Imm148 = 148,

        /// <summary> 
        /// Identifies the decimal value 149 := 0x95 
        /// </summary> 
        Imm149 = 149,

        /// <summary> 
        /// Identifies the decimal value 150 := 0x96 
        /// </summary> 
        Imm150 = 150,

        /// <summary> 
        /// Identifies the decimal value 151 := 0x97 
        /// </summary> 
        Imm151 = 151,

        /// <summary> 
        /// Identifies the decimal value 152 := 0x98 
        /// </summary> 
        Imm152 = 152,

        /// <summary> 
        /// Identifies the decimal value 153 := 0x99 
        /// </summary> 
        Imm153 = 153,

        /// <summary> 
        /// Identifies the decimal value 154 := 0x9A 
        /// </summary> 
        Imm154 = 154,

        /// <summary> 
        /// Identifies the decimal value 155 := 0x9B 
        /// </summary> 
        Imm155 = 155,

        /// <summary> 
        /// Identifies the decimal value 156 := 0x9C 
        /// </summary> 
        Imm156 = 156,

        /// <summary> 
        /// Identifies the decimal value 157 := 0x9D 
        /// </summary> 
        Imm157 = 157,

        /// <summary> 
        /// Identifies the decimal value 158 := 0x9E 
        /// </summary> 
        Imm158 = 158,

        /// <summary> 
        /// Identifies the decimal value 159 := 0x9F 
        /// </summary> 
        Imm159 = 159,

        /// <summary> 
        /// Identifies the decimal value 160 := 0xA0 
        /// </summary> 
        Imm160 = 160,

        /// <summary> 
        /// Identifies the decimal value 161 := 0xA1 
        /// </summary> 
        Imm161 = 161,

        /// <summary> 
        /// Identifies the decimal value 162 := 0xA2 
        /// </summary> 
        Imm162 = 162,

        /// <summary> 
        /// Identifies the decimal value 163 := 0xA3 
        /// </summary> 
        Imm163 = 163,

        /// <summary> 
        /// Identifies the decimal value 164 := 0xA4 
        /// </summary> 
        Imm164 = 164,

        /// <summary> 
        /// Identifies the decimal value 165 := 0xA5 
        /// </summary> 
        Imm165 = 165,

        /// <summary> 
        /// Identifies the decimal value 166 := 0xA6 
        /// </summary> 
        Imm166 = 166,

        /// <summary> 
        /// Identifies the decimal value 167 := 0xA7 
        /// </summary> 
        Imm167 = 167,

        /// <summary> 
        /// Identifies the decimal value 168 := 0xA8 
        /// </summary> 
        Imm168 = 168,

        /// <summary> 
        /// Identifies the decimal value 169 := 0xA9 
        /// </summary> 
        Imm169 = 169,

        /// <summary> 
        /// Identifies the decimal value 170 := 0xAA 
        /// </summary> 
        Imm170 = 170,

        /// <summary> 
        /// Identifies the decimal value 171 := 0xAB 
        /// </summary> 
        Imm171 = 171,

        /// <summary> 
        /// Identifies the decimal value 172 := 0xAC 
        /// </summary> 
        Imm172 = 172,

        /// <summary> 
        /// Identifies the decimal value 173 := 0xAD 
        /// </summary> 
        Imm173 = 173,

        /// <summary> 
        /// Identifies the decimal value 174 := 0xAE 
        /// </summary> 
        Imm174 = 174,

        /// <summary> 
        /// Identifies the decimal value 175 := 0xAF 
        /// </summary> 
        Imm175 = 175,

        /// <summary> 
        /// Identifies the decimal value 176 := 0xB0 
        /// </summary> 
        Imm176 = 176,

        /// <summary> 
        /// Identifies the decimal value 177 := 0xB1 
        /// </summary> 
        Imm177 = 177,

        /// <summary> 
        /// Identifies the decimal value 178 := 0xB2 
        /// </summary> 
        Imm178 = 178,

        /// <summary> 
        /// Identifies the decimal value 179 := 0xB3 
        /// </summary> 
        Imm179 = 179,

        /// <summary> 
        /// Identifies the decimal value 180 := 0xB4 
        /// </summary> 
        Imm180 = 180,

        /// <summary> 
        /// Identifies the decimal value 181 := 0xB5 
        /// </summary> 
        Imm181 = 181,

        /// <summary> 
        /// Identifies the decimal value 182 := 0xB6 
        /// </summary> 
        Imm182 = 182,

        /// <summary> 
        /// Identifies the decimal value 183 := 0xB7 
        /// </summary> 
        Imm183 = 183,

        /// <summary> 
        /// Identifies the decimal value 184 := 0xB8 
        /// </summary> 
        Imm184 = 184,

        /// <summary> 
        /// Identifies the decimal value 185 := 0xB9 
        /// </summary> 
        Imm185 = 185,

        /// <summary> 
        /// Identifies the decimal value 186 := 0xBA 
        /// </summary> 
        Imm186 = 186,

        /// <summary> 
        /// Identifies the decimal value 187 := 0xBB 
        /// </summary> 
        Imm187 = 187,

        /// <summary> 
        /// Identifies the decimal value 188 := 0xBC 
        /// </summary> 
        Imm188 = 188,

        /// <summary> 
        /// Identifies the decimal value 189 := 0xBD 
        /// </summary> 
        Imm189 = 189,

        /// <summary> 
        /// Identifies the decimal value 190 := 0xBE 
        /// </summary> 
        Imm190 = 190,

        /// <summary> 
        /// Identifies the decimal value 191 := 0xBF 
        /// </summary> 
        Imm191 = 191,

        /// <summary> 
        /// Identifies the decimal value 192 := 0xC0 
        /// </summary> 
        Imm192 = 192,

        /// <summary> 
        /// Identifies the decimal value 193 := 0xC1 
        /// </summary> 
        Imm193 = 193,

        /// <summary> 
        /// Identifies the decimal value 194 := 0xC2 
        /// </summary> 
        Imm194 = 194,

        /// <summary> 
        /// Identifies the decimal value 195 := 0xC3 
        /// </summary> 
        Imm195 = 195,

        /// <summary> 
        /// Identifies the decimal value 196 := 0xC4 
        /// </summary> 
        Imm196 = 196,

        /// <summary> 
        /// Identifies the decimal value 197 := 0xC5 
        /// </summary> 
        Imm197 = 197,

        /// <summary> 
        /// Identifies the decimal value 198 := 0xC6 
        /// </summary> 
        Imm198 = 198,

        /// <summary> 
        /// Identifies the decimal value 199 := 0xC7 
        /// </summary> 
        Imm199 = 199,

        /// <summary> 
        /// Identifies the decimal value 200 := 0xC8 
        /// </summary> 
        Imm200 = 200,

        /// <summary> 
        /// Identifies the decimal value 201 := 0xC9 
        /// </summary> 
        Imm201 = 201,

        /// <summary> 
        /// Identifies the decimal value 202 := 0xCA 
        /// </summary> 
        Imm202 = 202,

        /// <summary> 
        /// Identifies the decimal value 203 := 0xCB 
        /// </summary> 
        Imm203 = 203,

        /// <summary> 
        /// Identifies the decimal value 204 := 0xCC 
        /// </summary> 
        Imm204 = 204,

        /// <summary> 
        /// Identifies the decimal value 205 := 0xCD 
        /// </summary> 
        Imm205 = 205,

        /// <summary> 
        /// Identifies the decimal value 206 := 0xCE 
        /// </summary> 
        Imm206 = 206,

        /// <summary> 
        /// Identifies the decimal value 207 := 0xCF 
        /// </summary> 
        Imm207 = 207,

        /// <summary> 
        /// Identifies the decimal value 208 := 0xD0 
        /// </summary> 
        Imm208 = 208,

        /// <summary> 
        /// Identifies the decimal value 209 := 0xD1 
        /// </summary> 
        Imm209 = 209,

        /// <summary> 
        /// Identifies the decimal value 210 := 0xD2 
        /// </summary> 
        Imm210 = 210,

        /// <summary> 
        /// Identifies the decimal value 211 := 0xD3 
        /// </summary> 
        Imm211 = 211,

        /// <summary> 
        /// Identifies the decimal value 212 := 0xD4 
        /// </summary> 
        Imm212 = 212,

        /// <summary> 
        /// Identifies the decimal value 213 := 0xD5 
        /// </summary> 
        Imm213 = 213,

        /// <summary> 
        /// Identifies the decimal value 214 := 0xD6 
        /// </summary> 
        Imm214 = 214,

        /// <summary> 
        /// Identifies the decimal value 215 := 0xD7 
        /// </summary> 
        Imm215 = 215,

        /// <summary> 
        /// Identifies the decimal value 216 := 0xD8 
        /// </summary> 
        Imm216 = 216,

        /// <summary> 
        /// Identifies the decimal value 217 := 0xD9 
        /// </summary> 
        Imm217 = 217,

        /// <summary> 
        /// Identifies the decimal value 218 := 0xDA 
        /// </summary> 
        Imm218 = 218,

        /// <summary> 
        /// Identifies the decimal value 219 := 0xDB 
        /// </summary> 
        Imm219 = 219,

        /// <summary> 
        /// Identifies the decimal value 220 := 0xDC 
        /// </summary> 
        Imm220 = 220,

        /// <summary> 
        /// Identifies the decimal value 221 := 0xDD 
        /// </summary> 
        Imm221 = 221,

        /// <summary> 
        /// Identifies the decimal value 222 := 0xDE 
        /// </summary> 
        Imm222 = 222,

        /// <summary> 
        /// Identifies the decimal value 223 := 0xDF 
        /// </summary> 
        Imm223 = 223,

        /// <summary> 
        /// Identifies the decimal value 224 := 0xE0 
        /// </summary> 
        Imm224 = 224,

        /// <summary> 
        /// Identifies the decimal value 225 := 0xE1 
        /// </summary> 
        Imm225 = 225,

        /// <summary> 
        /// Identifies the decimal value 226 := 0xE2 
        /// </summary> 
        Imm226 = 226,

        /// <summary> 
        /// Identifies the decimal value 227 := 0xE3 
        /// </summary> 
        Imm227 = 227,

        /// <summary> 
        /// Identifies the decimal value 228 := 0xE4 
        /// </summary> 
        Imm228 = 228,

        /// <summary> 
        /// Identifies the decimal value 229 := 0xE5 
        /// </summary> 
        Imm229 = 229,

        /// <summary> 
        /// Identifies the decimal value 230 := 0xE6 
        /// </summary> 
        Imm230 = 230,

        /// <summary> 
        /// Identifies the decimal value 231 := 0xE7 
        /// </summary> 
        Imm231 = 231,

        /// <summary> 
        /// Identifies the decimal value 232 := 0xE8 
        /// </summary> 
        Imm232 = 232,

        /// <summary> 
        /// Identifies the decimal value 233 := 0xE9 
        /// </summary> 
        Imm233 = 233,

        /// <summary> 
        /// Identifies the decimal value 234 := 0xEA 
        /// </summary> 
        Imm234 = 234,

        /// <summary> 
        /// Identifies the decimal value 235 := 0xEB 
        /// </summary> 
        Imm235 = 235,

        /// <summary> 
        /// Identifies the decimal value 236 := 0xEC 
        /// </summary> 
        Imm236 = 236,

        /// <summary> 
        /// Identifies the decimal value 237 := 0xED 
        /// </summary> 
        Imm237 = 237,

        /// <summary> 
        /// Identifies the decimal value 238 := 0xEE 
        /// </summary> 
        Imm238 = 238,

        /// <summary> 
        /// Identifies the decimal value 239 := 0xEF 
        /// </summary> 
        Imm239 = 239,

        /// <summary> 
        /// Identifies the decimal value 240 := 0xF0 
        /// </summary> 
        Imm240 = 240,

        /// <summary> 
        /// Identifies the decimal value 241 := 0xF1 
        /// </summary> 
        Imm241 = 241,

        /// <summary> 
        /// Identifies the decimal value 242 := 0xF2 
        /// </summary> 
        Imm242 = 242,

        /// <summary> 
        /// Identifies the decimal value 243 := 0xF3 
        /// </summary> 
        Imm243 = 243,

        /// <summary> 
        /// Identifies the decimal value 244 := 0xF4 
        /// </summary> 
        Imm244 = 244,

        /// <summary> 
        /// Identifies the decimal value 245 := 0xF5 
        /// </summary> 
        Imm245 = 245,

        /// <summary> 
        /// Identifies the decimal value 246 := 0xF6 
        /// </summary> 
        Imm246 = 246,

        /// <summary> 
        /// Identifies the decimal value 247 := 0xF7 
        /// </summary> 
        Imm247 = 247,

        /// <summary> 
        /// Identifies the decimal value 248 := 0xF8 
        /// </summary> 
        Imm248 = 248,

        /// <summary> 
        /// Identifies the decimal value 249 := 0xF9 
        /// </summary> 
        Imm249 = 249,

        /// <summary> 
        /// Identifies the decimal value 250 := 0xFA 
        /// </summary> 
        Imm250 = 250,

        /// <summary> 
        /// Identifies the decimal value 251 := 0xFB 
        /// </summary> 
        Imm251 = 251,

        /// <summary> 
        /// Identifies the decimal value 252 := 0xFC 
        /// </summary> 
        Imm252 = 252,

        /// <summary> 
        /// Identifies the decimal value 253 := 0xFD 
        /// </summary> 
        Imm253 = 253,

        /// <summary> 
        /// Identifies the decimal value 254 := 0xFE 
        /// </summary> 
        Imm254 = 254,

        /// <summary> 
        /// Identifies the decimal value 255 := 0xFF 
        /// </summary> 
        Imm255 = 255,
    }
}