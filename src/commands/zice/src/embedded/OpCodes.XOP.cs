//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Linq;

    using static Konst;
    using static Memories;

    partial class OpCodeData
    {
        internal static ReadOnlySpan<byte> XOP
            => 	new byte[] {
				// grp_XOP9_01
				0x01,// ArrayReference
				0x08,// 0x8
				// 0 = 0x00
				0x00,// Invalid

				// 1 = 0x01
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x1C,// Hv_Ev
							0x88, 0x20,// XOP_Blcfill_r32_rm32
						0x00,// Invalid

				// 2 = 0x02
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x1C,// Hv_Ev
							0x8A, 0x20,// XOP_Blsfill_r32_rm32
						0x00,// Invalid

				// 3 = 0x03
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x1C,// Hv_Ev
							0x8C, 0x20,// XOP_Blcs_r32_rm32
						0x00,// Invalid

				// 4 = 0x04
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x1C,// Hv_Ev
							0x8E, 0x20,// XOP_Tzmsk_r32_rm32
						0x00,// Invalid

				// 5 = 0x05
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x1C,// Hv_Ev
							0x90, 0x20,// XOP_Blcic_r32_rm32
						0x00,// Invalid

				// 6 = 0x06
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x1C,// Hv_Ev
							0x92, 0x20,// XOP_Blsic_r32_rm32
						0x00,// Invalid

				// 7 = 0x07
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x1C,// Hv_Ev
							0x94, 0x20,// XOP_T1mskc_r32_rm32
						0x00,// Invalid

				// grp_XOP9_02
				0x01,// ArrayReference
				0x08,// 0x8
				// 0 = 0x00
				0x00,// Invalid

				// 1 = 0x01
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x1C,// Hv_Ev
							0x96, 0x20,// XOP_Blcmsk_r32_rm32
						0x00,// Invalid

				// 2 = 0x02
				0x02,// Dup
					0x04,// 4
					0x00,// Invalid

				// 6 = 0x06
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x1C,// Hv_Ev
							0x98, 0x20,// XOP_Blci_r32_rm32
						0x00,// Invalid

				// 7 = 0x07
				0x00,// Invalid

				// grp_XOP9_12
				0x01,// ArrayReference
				0x08,// 0x8
				// 0 = 0x00
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x22,// RdRq
							0x9A, 0x20,// XOP_Llwpcb_r32
						0x00,// Invalid

				// 1 = 0x01
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x22,// RdRq
							0x9C, 0x20,// XOP_Slwpcb_r32
						0x00,// Invalid

				// 2 = 0x02
				0x02,// Dup
					0x06,// 6
					0x00,// Invalid

				// grp_XOPA_12
				0x01,// ArrayReference
				0x08,// 0x8
				// 0 = 0x00
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x1B,// Hv_Ed_Id
							0xCD, 0x20,// XOP_Lwpins_r32_rm32_imm32
						0x00,// Invalid

				// 1 = 0x01
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x1B,// Hv_Ed_Id
							0xCF, 0x20,// XOP_Lwpval_r32_rm32_imm32
						0x00,// Invalid

				// 2 = 0x02
				0x02,// Dup
					0x06,// 6
					0x00,// Invalid

				// XOP8
				0x01,// ArrayReference
				0x80, 0x02,// 0x100
				// 0 = 0x00
				0x02,// Dup
					0x85, 0x01,// 133
					0x00,// Invalid

				// 133 = 0x85
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xEA, 0x1F,// XOP_Vpmacssww_xmm_xmm_xmmm128_xmm
							0x00,// Invalid
						0x00,// Invalid

				// 134 = 0x86
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xEB, 0x1F,// XOP_Vpmacsswd_xmm_xmm_xmmm128_xmm
							0x00,// Invalid
						0x00,// Invalid

				// 135 = 0x87
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xEC, 0x1F,// XOP_Vpmacssdql_xmm_xmm_xmmm128_xmm
							0x00,// Invalid
						0x00,// Invalid

				// 136 = 0x88
				0x02,// Dup
					0x06,// 6
					0x00,// Invalid

				// 142 = 0x8E
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xED, 0x1F,// XOP_Vpmacssdd_xmm_xmm_xmmm128_xmm
							0x00,// Invalid
						0x00,// Invalid

				// 143 = 0x8F
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xEE, 0x1F,// XOP_Vpmacssdqh_xmm_xmm_xmmm128_xmm
							0x00,// Invalid
						0x00,// Invalid

				// 144 = 0x90
				0x02,// Dup
					0x05,// 5
					0x00,// Invalid

				// 149 = 0x95
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xEF, 0x1F,// XOP_Vpmacsww_xmm_xmm_xmmm128_xmm
							0x00,// Invalid
						0x00,// Invalid

				// 150 = 0x96
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xF0, 0x1F,// XOP_Vpmacswd_xmm_xmm_xmmm128_xmm
							0x00,// Invalid
						0x00,// Invalid

				// 151 = 0x97
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xF1, 0x1F,// XOP_Vpmacsdql_xmm_xmm_xmmm128_xmm
							0x00,// Invalid
						0x00,// Invalid

				// 152 = 0x98
				0x02,// Dup
					0x06,// 6
					0x00,// Invalid

				// 158 = 0x9E
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xF2, 0x1F,// XOP_Vpmacsdd_xmm_xmm_xmmm128_xmm
							0x00,// Invalid
						0x00,// Invalid

				// 159 = 0x9F
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xF3, 0x1F,// XOP_Vpmacsdqh_xmm_xmm_xmmm128_xmm
							0x00,// Invalid
						0x00,// Invalid

				// 160 = 0xA0
				0x01,// Invalid2

				// 162 = 0xA2
				0x0A,// MandatoryPrefix2_1
					0x09,// W
						0x0E,// VectorLength
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xF4, 0x1F,// XOP_Vpcmov_xmm_xmm_xmmm128_xmm
							0x2E,// VHWIs4
								0x6D,// YMM0
								0xF5, 0x1F,// XOP_Vpcmov_ymm_ymm_ymmm256_ymm
						0x0E,// VectorLength
							0x26,// VHIs4W
								0x4D,// XMM0
								0xF6, 0x1F,// XOP_Vpcmov_xmm_xmm_xmm_xmmm128
							0x26,// VHIs4W
								0x6D,// YMM0
								0xF7, 0x1F,// XOP_Vpcmov_ymm_ymm_ymm_ymmm256

				// 163 = 0xA3
				0x0A,// MandatoryPrefix2_1
					0x09,// W
						0x0E,// VectorLength
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xF8, 0x1F,// XOP_Vpperm_xmm_xmm_xmmm128_xmm
							0x00,// Invalid
						0x0E,// VectorLength
							0x26,// VHIs4W
								0x4D,// XMM0
								0xF9, 0x1F,// XOP_Vpperm_xmm_xmm_xmm_xmmm128
							0x00,// Invalid

				// 164 = 0xA4
				0x01,// Invalid2

				// 166 = 0xA6
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xFA, 0x1F,// XOP_Vpmadcsswd_xmm_xmm_xmmm128_xmm
							0x00,// Invalid
						0x00,// Invalid

				// 167 = 0xA7
				0x02,// Dup
					0x0F,// 15
					0x00,// Invalid

				// 182 = 0xB6
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xFB, 0x1F,// XOP_Vpmadcswd_xmm_xmm_xmmm128_xmm
							0x00,// Invalid
						0x00,// Invalid

				// 183 = 0xB7
				0x02,// Dup
					0x09,// 9
					0x00,// Invalid

				// 192 = 0xC0
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x39,// VWIb_2
								0x4D,// XMM0
								0xFC, 0x1F,// XOP_Vprotb_xmm_xmmm128_imm8
							0x00,// Invalid
						0x00,// Invalid

				// 193 = 0xC1
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x39,// VWIb_2
								0x4D,// XMM0
								0xFD, 0x1F,// XOP_Vprotw_xmm_xmmm128_imm8
							0x00,// Invalid
						0x00,// Invalid

				// 194 = 0xC2
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x39,// VWIb_2
								0x4D,// XMM0
								0xFE, 0x1F,// XOP_Vprotd_xmm_xmmm128_imm8
							0x00,// Invalid
						0x00,// Invalid

				// 195 = 0xC3
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x39,// VWIb_2
								0x4D,// XMM0
								0xFF, 0x1F,// XOP_Vprotq_xmm_xmmm128_imm8
							0x00,// Invalid
						0x00,// Invalid

				// 196 = 0xC4
				0x02,// Dup
					0x08,// 8
					0x00,// Invalid

				// 204 = 0xCC
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2C,// VHWIb_2
								0x4D,// XMM0
								0x80, 0x20,// XOP_Vpcomb_xmm_xmm_xmmm128_imm8
							0x00,// Invalid
						0x00,// Invalid

				// 205 = 0xCD
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2C,// VHWIb_2
								0x4D,// XMM0
								0x81, 0x20,// XOP_Vpcomw_xmm_xmm_xmmm128_imm8
							0x00,// Invalid
						0x00,// Invalid

				// 206 = 0xCE
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2C,// VHWIb_2
								0x4D,// XMM0
								0x82, 0x20,// XOP_Vpcomd_xmm_xmm_xmmm128_imm8
							0x00,// Invalid
						0x00,// Invalid

				// 207 = 0xCF
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2C,// VHWIb_2
								0x4D,// XMM0
								0x83, 0x20,// XOP_Vpcomq_xmm_xmm_xmmm128_imm8
							0x00,// Invalid
						0x00,// Invalid

				// 208 = 0xD0
				0x02,// Dup
					0x1C,// 28
					0x00,// Invalid

				// 236 = 0xEC
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2C,// VHWIb_2
								0x4D,// XMM0
								0x84, 0x20,// XOP_Vpcomub_xmm_xmm_xmmm128_imm8
							0x00,// Invalid
						0x00,// Invalid

				// 237 = 0xED
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2C,// VHWIb_2
								0x4D,// XMM0
								0x85, 0x20,// XOP_Vpcomuw_xmm_xmm_xmmm128_imm8
							0x00,// Invalid
						0x00,// Invalid

				// 238 = 0xEE
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2C,// VHWIb_2
								0x4D,// XMM0
								0x86, 0x20,// XOP_Vpcomud_xmm_xmm_xmmm128_imm8
							0x00,// Invalid
						0x00,// Invalid

				// 239 = 0xEF
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x2C,// VHWIb_2
								0x4D,// XMM0
								0x87, 0x20,// XOP_Vpcomuq_xmm_xmm_xmmm128_imm8
							0x00,// Invalid
						0x00,// Invalid

				// 240 = 0xF0
				0x02,// Dup
					0x10,// 16
					0x00,// Invalid

				// XOP9
				0x01,// ArrayReference
				0x80, 0x02,// 0x100
				// 0 = 0x00
				0x00,// Invalid

				// 1 = 0x01
				0x08,// Group
					0x06,// ArrayReference
						0x00,// 0x0 = grp_XOP9_01

				// 2 = 0x02
				0x08,// Group
					0x06,// ArrayReference
						0x01,// 0x1 = grp_XOP9_02

				// 3 = 0x03
				0x02,// Dup
					0x0F,// 15
					0x00,// Invalid

				// 18 = 0x12
				0x08,// Group
					0x06,// ArrayReference
						0x02,// 0x2 = grp_XOP9_12

				// 19 = 0x13
				0x02,// Dup
					0x6D,// 109
					0x00,// Invalid

				// 128 = 0x80
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x36,// VW_2
								0x4D,// XMM0
								0x9E, 0x20,// XOP_Vfrczps_xmm_xmmm128
							0x00,// Invalid
						0x09,// W
							0x36,// VW_2
								0x6D,// YMM0
								0x9F, 0x20,// XOP_Vfrczps_ymm_ymmm256
							0x00,// Invalid

				// 129 = 0x81
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x36,// VW_2
								0x4D,// XMM0
								0xA0, 0x20,// XOP_Vfrczpd_xmm_xmmm128
							0x00,// Invalid
						0x09,// W
							0x36,// VW_2
								0x6D,// YMM0
								0xA1, 0x20,// XOP_Vfrczpd_ymm_ymmm256
							0x00,// Invalid

				// 130 = 0x82
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x36,// VW_2
								0x4D,// XMM0
								0xA2, 0x20,// XOP_Vfrczss_xmm_xmmm32
							0x00,// Invalid
						0x00,// Invalid

				// 131 = 0x83
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x36,// VW_2
								0x4D,// XMM0
								0xA3, 0x20,// XOP_Vfrczsd_xmm_xmmm64
							0x00,// Invalid
						0x00,// Invalid

				// 132 = 0x84
				0x02,// Dup
					0x0C,// 12
					0x00,// Invalid

				// 144 = 0x90
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x38,// VWH
								0x4D,// XMM0
								0xA4, 0x20,// XOP_Vprotb_xmm_xmmm128_xmm
							0x29,// VHW_2
								0x4D,// XMM0
								0xA5, 0x20,// XOP_Vprotb_xmm_xmm_xmmm128
						0x00,// Invalid

				// 145 = 0x91
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x38,// VWH
								0x4D,// XMM0
								0xA6, 0x20,// XOP_Vprotw_xmm_xmmm128_xmm
							0x29,// VHW_2
								0x4D,// XMM0
								0xA7, 0x20,// XOP_Vprotw_xmm_xmm_xmmm128
						0x00,// Invalid

				// 146 = 0x92
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x38,// VWH
								0x4D,// XMM0
								0xA8, 0x20,// XOP_Vprotd_xmm_xmmm128_xmm
							0x29,// VHW_2
								0x4D,// XMM0
								0xA9, 0x20,// XOP_Vprotd_xmm_xmm_xmmm128
						0x00,// Invalid

				// 147 = 0x93
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x38,// VWH
								0x4D,// XMM0
								0xAA, 0x20,// XOP_Vprotq_xmm_xmmm128_xmm
							0x29,// VHW_2
								0x4D,// XMM0
								0xAB, 0x20,// XOP_Vprotq_xmm_xmm_xmmm128
						0x00,// Invalid

				// 148 = 0x94
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x38,// VWH
								0x4D,// XMM0
								0xAC, 0x20,// XOP_Vpshlb_xmm_xmmm128_xmm
							0x29,// VHW_2
								0x4D,// XMM0
								0xAD, 0x20,// XOP_Vpshlb_xmm_xmm_xmmm128
						0x00,// Invalid

				// 149 = 0x95
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x38,// VWH
								0x4D,// XMM0
								0xAE, 0x20,// XOP_Vpshlw_xmm_xmmm128_xmm
							0x29,// VHW_2
								0x4D,// XMM0
								0xAF, 0x20,// XOP_Vpshlw_xmm_xmm_xmmm128
						0x00,// Invalid

				// 150 = 0x96
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x38,// VWH
								0x4D,// XMM0
								0xB0, 0x20,// XOP_Vpshld_xmm_xmmm128_xmm
							0x29,// VHW_2
								0x4D,// XMM0
								0xB1, 0x20,// XOP_Vpshld_xmm_xmm_xmmm128
						0x00,// Invalid

				// 151 = 0x97
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x38,// VWH
								0x4D,// XMM0
								0xB2, 0x20,// XOP_Vpshlq_xmm_xmmm128_xmm
							0x29,// VHW_2
								0x4D,// XMM0
								0xB3, 0x20,// XOP_Vpshlq_xmm_xmm_xmmm128
						0x00,// Invalid

				// 152 = 0x98
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x38,// VWH
								0x4D,// XMM0
								0xB4, 0x20,// XOP_Vpshab_xmm_xmmm128_xmm
							0x29,// VHW_2
								0x4D,// XMM0
								0xB5, 0x20,// XOP_Vpshab_xmm_xmm_xmmm128
						0x00,// Invalid

				// 153 = 0x99
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x38,// VWH
								0x4D,// XMM0
								0xB6, 0x20,// XOP_Vpshaw_xmm_xmmm128_xmm
							0x29,// VHW_2
								0x4D,// XMM0
								0xB7, 0x20,// XOP_Vpshaw_xmm_xmm_xmmm128
						0x00,// Invalid

				// 154 = 0x9A
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x38,// VWH
								0x4D,// XMM0
								0xB8, 0x20,// XOP_Vpshad_xmm_xmmm128_xmm
							0x29,// VHW_2
								0x4D,// XMM0
								0xB9, 0x20,// XOP_Vpshad_xmm_xmm_xmmm128
						0x00,// Invalid

				// 155 = 0x9B
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x38,// VWH
								0x4D,// XMM0
								0xBA, 0x20,// XOP_Vpshaq_xmm_xmmm128_xmm
							0x29,// VHW_2
								0x4D,// XMM0
								0xBB, 0x20,// XOP_Vpshaq_xmm_xmm_xmmm128
						0x00,// Invalid

				// 156 = 0x9C
				0x02,// Dup
					0x25,// 37
					0x00,// Invalid

				// 193 = 0xC1
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x36,// VW_2
								0x4D,// XMM0
								0xBC, 0x20,// XOP_Vphaddbw_xmm_xmmm128
							0x00,// Invalid
						0x00,// Invalid

				// 194 = 0xC2
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x36,// VW_2
								0x4D,// XMM0
								0xBD, 0x20,// XOP_Vphaddbd_xmm_xmmm128
							0x00,// Invalid
						0x00,// Invalid

				// 195 = 0xC3
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x36,// VW_2
								0x4D,// XMM0
								0xBE, 0x20,// XOP_Vphaddbq_xmm_xmmm128
							0x00,// Invalid
						0x00,// Invalid

				// 196 = 0xC4
				0x01,// Invalid2

				// 198 = 0xC6
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x36,// VW_2
								0x4D,// XMM0
								0xBF, 0x20,// XOP_Vphaddwd_xmm_xmmm128
							0x00,// Invalid
						0x00,// Invalid

				// 199 = 0xC7
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x36,// VW_2
								0x4D,// XMM0
								0xC0, 0x20,// XOP_Vphaddwq_xmm_xmmm128
							0x00,// Invalid
						0x00,// Invalid

				// 200 = 0xC8
				0x02,// Dup
					0x03,// 3
					0x00,// Invalid

				// 203 = 0xCB
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x36,// VW_2
								0x4D,// XMM0
								0xC1, 0x20,// XOP_Vphadddq_xmm_xmmm128
							0x00,// Invalid
						0x00,// Invalid

				// 204 = 0xCC
				0x02,// Dup
					0x05,// 5
					0x00,// Invalid

				// 209 = 0xD1
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x36,// VW_2
								0x4D,// XMM0
								0xC2, 0x20,// XOP_Vphaddubw_xmm_xmmm128
							0x00,// Invalid
						0x00,// Invalid

				// 210 = 0xD2
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x36,// VW_2
								0x4D,// XMM0
								0xC3, 0x20,// XOP_Vphaddubd_xmm_xmmm128
							0x00,// Invalid
						0x00,// Invalid

				// 211 = 0xD3
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x36,// VW_2
								0x4D,// XMM0
								0xC4, 0x20,// XOP_Vphaddubq_xmm_xmmm128
							0x00,// Invalid
						0x00,// Invalid

				// 212 = 0xD4
				0x01,// Invalid2

				// 214 = 0xD6
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x36,// VW_2
								0x4D,// XMM0
								0xC5, 0x20,// XOP_Vphadduwd_xmm_xmmm128
							0x00,// Invalid
						0x00,// Invalid

				// 215 = 0xD7
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x36,// VW_2
								0x4D,// XMM0
								0xC6, 0x20,// XOP_Vphadduwq_xmm_xmmm128
							0x00,// Invalid
						0x00,// Invalid

				// 216 = 0xD8
				0x02,// Dup
					0x03,// 3
					0x00,// Invalid

				// 219 = 0xDB
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x36,// VW_2
								0x4D,// XMM0
								0xC7, 0x20,// XOP_Vphaddudq_xmm_xmmm128
							0x00,// Invalid
						0x00,// Invalid

				// 220 = 0xDC
				0x02,// Dup
					0x05,// 5
					0x00,// Invalid

				// 225 = 0xE1
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x36,// VW_2
								0x4D,// XMM0
								0xC8, 0x20,// XOP_Vphsubbw_xmm_xmmm128
							0x00,// Invalid
						0x00,// Invalid

				// 226 = 0xE2
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x36,// VW_2
								0x4D,// XMM0
								0xC9, 0x20,// XOP_Vphsubwd_xmm_xmmm128
							0x00,// Invalid
						0x00,// Invalid

				// 227 = 0xE3
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x09,// W
							0x36,// VW_2
								0x4D,// XMM0
								0xCA, 0x20,// XOP_Vphsubdq_xmm_xmmm128
							0x00,// Invalid
						0x00,// Invalid

				// 228 = 0xE4
				0x02,// Dup
					0x1C,// 28
					0x00,// Invalid

				// XOPA
				0x01,// ArrayReference
				0x80, 0x02,// 0x100
				// 0 = 0x00
				0x02,// Dup
					0x10,// 16
					0x00,// Invalid

				// 16 = 0x10
				0x0A,// MandatoryPrefix2_1
					0x0E,// VectorLength
						0x14,// Gv_Ev_Id
							0xCB, 0x20,// XOP_Bextr_r32_rm32_imm32
						0x00,// Invalid

				// 17 = 0x11
				0x00,// Invalid

				// 18 = 0x12
				0x08,// Group
					0x06,// ArrayReference
						0x03,// 0x3 = grp_XOPA_12

				// 19 = 0x13
				0x02,// Dup
					0xED, 0x01,// 237
					0x00,// Invalid
			};
	

		public static uint[] Encoded
			=> new uint[4212 * 3] 
			{
				0x00000000, 0x00000000, 0x00000000,// INVALID
				0x00000000, 0x00000000, 0x00000000,// DeclareByte
				0x00000000, 0x00000000, 0x00000000,// DeclareWord
				0x00000000, 0x00000000, 0x00000000,// DeclareDword
				0x00000000, 0x00000000, 0x00000000,// DeclareQword
				0x00000000, 0x00001C00, 0x0000149A,// Add_rm8_r8
				0x00010000, 0x00011C00, 0x0000151B,// Add_rm16_r16
				0x00010000, 0x00021C00, 0x0000159C,// Add_rm32_r32
				0x00010000, 0x00031C20, 0x00001620,// Add_rm64_r64
				0x00020000, 0x00000000, 0x00000D29,// Add_r8_rm8
				0x00030000, 0x00010000, 0x00000DAA,// Add_r16_rm16
				0x00030000, 0x00020000, 0x00000E2B,// Add_r32_rm32
				0x00030000, 0x00030020, 0x0000102C,// Add_r64_rm64
				0x00040000, 0x00000000, 0x00001CED,// Add_AL_imm8
				0x00050000, 0x00010000, 0x00001EEF,// Add_AX_imm16
				0x00050000, 0x00020000, 0x00001F71,// Add_EAX_imm32
				0x00050000, 0x00030020, 0x00001FF2,// Add_RAX_imm32
				0x00060000, 0x00010010, 0x00000067,// Pushw_ES
				0x00060000, 0x00020010, 0x00000067,// Pushd_ES
				0x00070000, 0x00010010, 0x00000067,// Popw_ES
				0x00070000, 0x00020010, 0x00000067,// Popd_ES
				0x00080000, 0x00001C00, 0x0000149A,// Or_rm8_r8
				0x00090000, 0x00011C00, 0x0000151B,// Or_rm16_r16
				0x00090000, 0x00021C00, 0x0000159C,// Or_rm32_r32
				0x00090000, 0x00031C20, 0x00001620,// Or_rm64_r64
				0x000A0000, 0x00000000, 0x00000D29,// Or_r8_rm8
				0x000B0000, 0x00010000, 0x00000DAA,// Or_r16_rm16
				0x000B0000, 0x00020000, 0x00000E2B,// Or_r32_rm32
				0x000B0000, 0x00030020, 0x0000102C,// Or_r64_rm64
				0x000C0000, 0x00000000, 0x00001CED,// Or_AL_imm8
				0x000D0000, 0x00010000, 0x00001EEF,// Or_AX_imm16
				0x000D0000, 0x00020000, 0x00001F71,// Or_EAX_imm32
				0x000D0000, 0x00030020, 0x00001FF2,// Or_RAX_imm32
				0x000E0000, 0x00010010, 0x00000068,// Pushw_CS
				0x000E0000, 0x00020010, 0x00000068,// Pushd_CS
				0x000F0000, 0x00010010, 0x00000068,// Popw_CS
				0x00100000, 0x00001C00, 0x0000149A,// Adc_rm8_r8
				0x00110000, 0x00011C00, 0x0000151B,// Adc_rm16_r16
				0x00110000, 0x00021C00, 0x0000159C,// Adc_rm32_r32
				0x00110000, 0x00031C20, 0x00001620,// Adc_rm64_r64
				0x00120000, 0x00000000, 0x00000D29,// Adc_r8_rm8
				0x00130000, 0x00010000, 0x00000DAA,// Adc_r16_rm16
				0x00130000, 0x00020000, 0x00000E2B,// Adc_r32_rm32
				0x00130000, 0x00030020, 0x0000102C,// Adc_r64_rm64
				0x00140000, 0x00000000, 0x00001CED,// Adc_AL_imm8
				0x00150000, 0x00010000, 0x00001EEF,// Adc_AX_imm16
				0x00150000, 0x00020000, 0x00001F71,// Adc_EAX_imm32
				0x00150000, 0x00030020, 0x00001FF2,// Adc_RAX_imm32
				0x00160000, 0x00010010, 0x00000069,// Pushw_SS
				0x00160000, 0x00020010, 0x00000069,// Pushd_SS
				0x00170000, 0x00010010, 0x00000069,// Popw_SS
				0x00170000, 0x00020010, 0x00000069,// Popd_SS
				0x00180000, 0x00001C00, 0x0000149A,// Sbb_rm8_r8
				0x00190000, 0x00011C00, 0x0000151B,// Sbb_rm16_r16
				0x00190000, 0x00021C00, 0x0000159C,// Sbb_rm32_r32
				0x00190000, 0x00031C20, 0x00001620,// Sbb_rm64_r64
				0x001A0000, 0x00000000, 0x00000D29,// Sbb_r8_rm8
				0x001B0000, 0x00010000, 0x00000DAA,// Sbb_r16_rm16
				0x001B0000, 0x00020000, 0x00000E2B,// Sbb_r32_rm32
				0x001B0000, 0x00030020, 0x0000102C,// Sbb_r64_rm64
				0x001C0000, 0x00000000, 0x00001CED,// Sbb_AL_imm8
				0x001D0000, 0x00010000, 0x00001EEF,// Sbb_AX_imm16
				0x001D0000, 0x00020000, 0x00001F71,// Sbb_EAX_imm32
				0x001D0000, 0x00030020, 0x00001FF2,// Sbb_RAX_imm32
				0x001E0000, 0x00010010, 0x0000006A,// Pushw_DS
				0x001E0000, 0x00020010, 0x0000006A,// Pushd_DS
				0x001F0000, 0x00010010, 0x0000006A,// Popw_DS
				0x001F0000, 0x00020010, 0x0000006A,// Popd_DS
				0x00200000, 0x00001C00, 0x0000149A,// And_rm8_r8
				0x00210000, 0x00011C00, 0x0000151B,// And_rm16_r16
				0x00210000, 0x00021C00, 0x0000159C,// And_rm32_r32
				0x00210000, 0x00031C20, 0x00001620,// And_rm64_r64
				0x00220000, 0x00000000, 0x00000D29,// And_r8_rm8
				0x00230000, 0x00010000, 0x00000DAA,// And_r16_rm16
				0x00230000, 0x00020000, 0x00000E2B,// And_r32_rm32
				0x00230000, 0x00030020, 0x0000102C,// And_r64_rm64
				0x00240000, 0x00000000, 0x00001CED,// And_AL_imm8
				0x00250000, 0x00010000, 0x00001EEF,// And_AX_imm16
				0x00250000, 0x00020000, 0x00001F71,// And_EAX_imm32
				0x00250000, 0x00030020, 0x00001FF2,// And_RAX_imm32
				0x00270000, 0x00000010, 0x00000000,// Daa
				0x00280000, 0x00001C00, 0x0000149A,// Sub_rm8_r8
				0x00290000, 0x00011C00, 0x0000151B,// Sub_rm16_r16
				0x00290000, 0x00021C00, 0x0000159C,// Sub_rm32_r32
				0x00290000, 0x00031C20, 0x00001620,// Sub_rm64_r64
				0x002A0000, 0x00000000, 0x00000D29,// Sub_r8_rm8
				0x002B0000, 0x00010000, 0x00000DAA,// Sub_r16_rm16
				0x002B0000, 0x00020000, 0x00000E2B,// Sub_r32_rm32
				0x002B0000, 0x00030020, 0x0000102C,// Sub_r64_rm64
				0x002C0000, 0x00000000, 0x00001CED,// Sub_AL_imm8
				0x002D0000, 0x00010000, 0x00001EEF,// Sub_AX_imm16
				0x002D0000, 0x00020000, 0x00001F71,// Sub_EAX_imm32
				0x002D0000, 0x00030020, 0x00001FF2,// Sub_RAX_imm32
				0x002F0000, 0x00000010, 0x00000000,// Das
				0x00300000, 0x00001C00, 0x0000149A,// Xor_rm8_r8
				0x00310000, 0x00011C00, 0x0000151B,// Xor_rm16_r16
				0x00310000, 0x00021C00, 0x0000159C,// Xor_rm32_r32
				0x00310000, 0x00031C20, 0x00001620,// Xor_rm64_r64
				0x00320000, 0x00000000, 0x00000D29,// Xor_r8_rm8
				0x00330000, 0x00010000, 0x00000DAA,// Xor_r16_rm16
				0x00330000, 0x00020000, 0x00000E2B,// Xor_r32_rm32
				0x00330000, 0x00030020, 0x0000102C,// Xor_r64_rm64
				0x00340000, 0x00000000, 0x00001CED,// Xor_AL_imm8
				0x00350000, 0x00010000, 0x00001EEF,// Xor_AX_imm16
				0x00350000, 0x00020000, 0x00001F71,// Xor_EAX_imm32
				0x00350000, 0x00030020, 0x00001FF2,// Xor_RAX_imm32
				0x00370000, 0x00000010, 0x00000000,// Aaa
				0x00380000, 0x00000000, 0x0000149A,// Cmp_rm8_r8
				0x00390000, 0x00010000, 0x0000151B,// Cmp_rm16_r16
				0x00390000, 0x00020000, 0x0000159C,// Cmp_rm32_r32
				0x00390000, 0x00030020, 0x00001620,// Cmp_rm64_r64
				0x003A0000, 0x00000000, 0x00000D29,// Cmp_r8_rm8
				0x003B0000, 0x00010000, 0x00000DAA,// Cmp_r16_rm16
				0x003B0000, 0x00020000, 0x00000E2B,// Cmp_r32_rm32
				0x003B0000, 0x00030020, 0x0000102C,// Cmp_r64_rm64
				0x003C0000, 0x00000000, 0x00001CED,// Cmp_AL_imm8
				0x003D0000, 0x00010000, 0x00001EEF,// Cmp_AX_imm16
				0x003D0000, 0x00020000, 0x00001F71,// Cmp_EAX_imm32
				0x003D0000, 0x00030020, 0x00001FF2,// Cmp_RAX_imm32
				0x003F0000, 0x00000010, 0x00000000,// Aas
				0x00400000, 0x00010010, 0x00000076,// Inc_r16
				0x00400000, 0x00020010, 0x00000077,// Inc_r32
				0x00480000, 0x00010010, 0x00000076,// Dec_r16
				0x00480000, 0x00020010, 0x00000077,// Dec_r32
				0x00500000, 0x00010000, 0x00000076,// Push_r16
				0x00500000, 0x00020010, 0x00000077,// Push_r32
				0x00500000, 0x00000020, 0x00000078,// Push_r64
				0x00580000, 0x00010000, 0x00000076,// Pop_r16
				0x00580000, 0x00020010, 0x00000077,// Pop_r32
				0x00580000, 0x00000020, 0x00000078,// Pop_r64
				0x00600000, 0x00010010, 0x00000000,// Pushaw
				0x00600000, 0x00020010, 0x00000000,// Pushad
				0x00610000, 0x00010010, 0x00000000,// Popaw
				0x00610000, 0x00020010, 0x00000000,// Popad
				0x00620000, 0x00010010, 0x00000C2A,// Bound_r16_m1616
				0x00620000, 0x00020010, 0x00000CAB,// Bound_r32_m3232
				0x00630000, 0x00010010, 0x0000151B,// Arpl_rm16_r16
				0x00630000, 0x00020010, 0x000015A7,// Arpl_r32m16_r32
				0x00630000, 0x00010020, 0x00000DAA,// Movsxd_r16_rm16
				0x00630000, 0x00020020, 0x00000E2B,// Movsxd_r32_rm32
				0x00630000, 0x00030020, 0x00000E2C,// Movsxd_r64_rm32
				0x00680000, 0x00010000, 0x0000003D,// Push_imm16
				0x00680000, 0x00020010, 0x0000003E,// Pushd_imm32
				0x00680000, 0x00000020, 0x0000003F,// Pushq_imm32
				0x00690000, 0x00010000, 0x000F4DAA,// Imul_r16_rm16_imm16
				0x00690000, 0x00020000, 0x000F8E2B,// Imul_r32_rm32_imm32
				0x00690000, 0x00030020, 0x000FD02C,// Imul_r64_rm64_imm32
				0x006A0000, 0x00010000, 0x0000003A,// Pushw_imm8
				0x006A0000, 0x00020010, 0x0000003B,// Pushd_imm8
				0x006A0000, 0x00000020, 0x0000003C,// Pushq_imm8
				0x006B0000, 0x00010000, 0x000E8DAA,// Imul_r16_rm16_imm8
				0x006B0000, 0x00020000, 0x000ECE2B,// Imul_r32_rm32_imm8
				0x006B0000, 0x00030020, 0x000F102C,// Imul_r64_rm64_imm8
				0x006C0000, 0x00001400, 0x00003847,// Insb_m8_DX
				0x006D0000, 0x00011400, 0x00003848,// Insw_m16_DX
				0x006D0000, 0x00021400, 0x00003849,// Insd_m32_DX
				0x006E0000, 0x00001400, 0x000021F0,// Outsb_DX_m8
				0x006F0000, 0x00011400, 0x00002270,// Outsw_DX_m16
				0x006F0000, 0x00021400, 0x000022F0,// Outsd_DX_m32
				0x00700000, 0x00010C00, 0x0000004B,// Jo_rel8_16
				0x00700000, 0x00020C10, 0x0000004C,// Jo_rel8_32
				0x00700000, 0x00000C20, 0x0000004D,// Jo_rel8_64
				0x00710000, 0x00010C00, 0x0000004B,// Jno_rel8_16
				0x00710000, 0x00020C10, 0x0000004C,// Jno_rel8_32
				0x00710000, 0x00000C20, 0x0000004D,// Jno_rel8_64
				0x00720000, 0x00010C00, 0x0000004B,// Jb_rel8_16
				0x00720000, 0x00020C10, 0x0000004C,// Jb_rel8_32
				0x00720000, 0x00000C20, 0x0000004D,// Jb_rel8_64
				0x00730000, 0x00010C00, 0x0000004B,// Jae_rel8_16
				0x00730000, 0x00020C10, 0x0000004C,// Jae_rel8_32
				0x00730000, 0x00000C20, 0x0000004D,// Jae_rel8_64
				0x00740000, 0x00010C00, 0x0000004B,// Je_rel8_16
				0x00740000, 0x00020C10, 0x0000004C,// Je_rel8_32
				0x00740000, 0x00000C20, 0x0000004D,// Je_rel8_64
				0x00750000, 0x00010C00, 0x0000004B,// Jne_rel8_16
				0x00750000, 0x00020C10, 0x0000004C,// Jne_rel8_32
				0x00750000, 0x00000C20, 0x0000004D,// Jne_rel8_64
				0x00760000, 0x00010C00, 0x0000004B,// Jbe_rel8_16
				0x00760000, 0x00020C10, 0x0000004C,// Jbe_rel8_32
				0x00760000, 0x00000C20, 0x0000004D,// Jbe_rel8_64
				0x00770000, 0x00010C00, 0x0000004B,// Ja_rel8_16
				0x00770000, 0x00020C10, 0x0000004C,// Ja_rel8_32
				0x00770000, 0x00000C20, 0x0000004D,// Ja_rel8_64
				0x00780000, 0x00010C00, 0x0000004B,// Js_rel8_16
				0x00780000, 0x00020C10, 0x0000004C,// Js_rel8_32
				0x00780000, 0x00000C20, 0x0000004D,// Js_rel8_64
				0x00790000, 0x00010C00, 0x0000004B,// Jns_rel8_16
				0x00790000, 0x00020C10, 0x0000004C,// Jns_rel8_32
				0x00790000, 0x00000C20, 0x0000004D,// Jns_rel8_64
				0x007A0000, 0x00010C00, 0x0000004B,// Jp_rel8_16
				0x007A0000, 0x00020C10, 0x0000004C,// Jp_rel8_32
				0x007A0000, 0x00000C20, 0x0000004D,// Jp_rel8_64
				0x007B0000, 0x00010C00, 0x0000004B,// Jnp_rel8_16
				0x007B0000, 0x00020C10, 0x0000004C,// Jnp_rel8_32
				0x007B0000, 0x00000C20, 0x0000004D,// Jnp_rel8_64
				0x007C0000, 0x00010C00, 0x0000004B,// Jl_rel8_16
				0x007C0000, 0x00020C10, 0x0000004C,// Jl_rel8_32
				0x007C0000, 0x00000C20, 0x0000004D,// Jl_rel8_64
				0x007D0000, 0x00010C00, 0x0000004B,// Jge_rel8_16
				0x007D0000, 0x00020C10, 0x0000004C,// Jge_rel8_32
				0x007D0000, 0x00000C20, 0x0000004D,// Jge_rel8_64
				0x007E0000, 0x00010C00, 0x0000004B,// Jle_rel8_16
				0x007E0000, 0x00020C10, 0x0000004C,// Jle_rel8_32
				0x007E0000, 0x00000C20, 0x0000004D,// Jle_rel8_64
				0x007F0000, 0x00010C00, 0x0000004B,// Jg_rel8_16
				0x007F0000, 0x00020C10, 0x0000004C,// Jg_rel8_32
				0x007F0000, 0x00000C20, 0x0000004D,// Jg_rel8_64
				0x00800000, 0x00001C40, 0x00001C9A,// Add_rm8_imm8
				0x00800000, 0x00001CC0, 0x00001C9A,// Or_rm8_imm8
				0x00800000, 0x00001D40, 0x00001C9A,// Adc_rm8_imm8
				0x00800000, 0x00001DC0, 0x00001C9A,// Sbb_rm8_imm8
				0x00800000, 0x00001E40, 0x00001C9A,// And_rm8_imm8
				0x00800000, 0x00001EC0, 0x00001C9A,// Sub_rm8_imm8
				0x00800000, 0x00001F40, 0x00001C9A,// Xor_rm8_imm8
				0x00800000, 0x000003C0, 0x00001C9A,// Cmp_rm8_imm8
				0x00810000, 0x00011C40, 0x00001E9B,// Add_rm16_imm16
				0x00810000, 0x00021C40, 0x00001F1C,// Add_rm32_imm32
				0x00810000, 0x00031C60, 0x00001FA0,// Add_rm64_imm32
				0x00810000, 0x00011CC0, 0x00001E9B,// Or_rm16_imm16
				0x00810000, 0x00021CC0, 0x00001F1C,// Or_rm32_imm32
				0x00810000, 0x00031CE0, 0x00001FA0,// Or_rm64_imm32
				0x00810000, 0x00011D40, 0x00001E9B,// Adc_rm16_imm16
				0x00810000, 0x00021D40, 0x00001F1C,// Adc_rm32_imm32
				0x00810000, 0x00031D60, 0x00001FA0,// Adc_rm64_imm32
				0x00810000, 0x00011DC0, 0x00001E9B,// Sbb_rm16_imm16
				0x00810000, 0x00021DC0, 0x00001F1C,// Sbb_rm32_imm32
				0x00810000, 0x00031DE0, 0x00001FA0,// Sbb_rm64_imm32
				0x00810000, 0x00011E40, 0x00001E9B,// And_rm16_imm16
				0x00810000, 0x00021E40, 0x00001F1C,// And_rm32_imm32
				0x00810000, 0x00031E60, 0x00001FA0,// And_rm64_imm32
				0x00810000, 0x00011EC0, 0x00001E9B,// Sub_rm16_imm16
				0x00810000, 0x00021EC0, 0x00001F1C,// Sub_rm32_imm32
				0x00810000, 0x00031EE0, 0x00001FA0,// Sub_rm64_imm32
				0x00810000, 0x00011F40, 0x00001E9B,// Xor_rm16_imm16
				0x00810000, 0x00021F40, 0x00001F1C,// Xor_rm32_imm32
				0x00810000, 0x00031F60, 0x00001FA0,// Xor_rm64_imm32
				0x00810000, 0x000103C0, 0x00001E9B,// Cmp_rm16_imm16
				0x00810000, 0x000203C0, 0x00001F1C,// Cmp_rm32_imm32
				0x00810000, 0x000303E0, 0x00001FA0,// Cmp_rm64_imm32
				0x00820000, 0x00001C50, 0x00001C9A,// Add_rm8_imm8_82
				0x00820000, 0x00001CD0, 0x00001C9A,// Or_rm8_imm8_82
				0x00820000, 0x00001D50, 0x00001C9A,// Adc_rm8_imm8_82
				0x00820000, 0x00001DD0, 0x00001C9A,// Sbb_rm8_imm8_82
				0x00820000, 0x00001E50, 0x00001C9A,// And_rm8_imm8_82
				0x00820000, 0x00001ED0, 0x00001C9A,// Sub_rm8_imm8_82
				0x00820000, 0x00001F50, 0x00001C9A,// Xor_rm8_imm8_82
				0x00820000, 0x000003D0, 0x00001C9A,// Cmp_rm8_imm8_82
				0x00830000, 0x00011C40, 0x00001D1B,// Add_rm16_imm8
				0x00830000, 0x00021C40, 0x00001D9C,// Add_rm32_imm8
				0x00830000, 0x00031C60, 0x00001E20,// Add_rm64_imm8
				0x00830000, 0x00011CC0, 0x00001D1B,// Or_rm16_imm8
				0x00830000, 0x00021CC0, 0x00001D9C,// Or_rm32_imm8
				0x00830000, 0x00031CE0, 0x00001E20,// Or_rm64_imm8
				0x00830000, 0x00011D40, 0x00001D1B,// Adc_rm16_imm8
				0x00830000, 0x00021D40, 0x00001D9C,// Adc_rm32_imm8
				0x00830000, 0x00031D60, 0x00001E20,// Adc_rm64_imm8
				0x00830000, 0x00011DC0, 0x00001D1B,// Sbb_rm16_imm8
				0x00830000, 0x00021DC0, 0x00001D9C,// Sbb_rm32_imm8
				0x00830000, 0x00031DE0, 0x00001E20,// Sbb_rm64_imm8
				0x00830000, 0x00011E40, 0x00001D1B,// And_rm16_imm8
				0x00830000, 0x00021E40, 0x00001D9C,// And_rm32_imm8
				0x00830000, 0x00031E60, 0x00001E20,// And_rm64_imm8
				0x00830000, 0x00011EC0, 0x00001D1B,// Sub_rm16_imm8
				0x00830000, 0x00021EC0, 0x00001D9C,// Sub_rm32_imm8
				0x00830000, 0x00031EE0, 0x00001E20,// Sub_rm64_imm8
				0x00830000, 0x00011F40, 0x00001D1B,// Xor_rm16_imm8
				0x00830000, 0x00021F40, 0x00001D9C,// Xor_rm32_imm8
				0x00830000, 0x00031F60, 0x00001E20,// Xor_rm64_imm8
				0x00830000, 0x000103C0, 0x00001D1B,// Cmp_rm16_imm8
				0x00830000, 0x000203C0, 0x00001D9C,// Cmp_rm32_imm8
				0x00830000, 0x000303E0, 0x00001E20,// Cmp_rm64_imm8
				0x00840000, 0x00000000, 0x0000149A,// Test_rm8_r8
				0x00850000, 0x00010000, 0x0000151B,// Test_rm16_r16
				0x00850000, 0x00020000, 0x0000159C,// Test_rm32_r32
				0x00850000, 0x00030020, 0x00001620,// Test_rm64_r64
				0x00860000, 0x00001C00, 0x0000149A,// Xchg_rm8_r8
				0x00870000, 0x00011C00, 0x0000151B,// Xchg_rm16_r16
				0x00870000, 0x00021C00, 0x0000159C,// Xchg_rm32_r32
				0x00870000, 0x00031C20, 0x00001620,// Xchg_rm64_r64
				0x00880000, 0x00002000, 0x0000149A,// Mov_rm8_r8
				0x00890000, 0x00012000, 0x0000151B,// Mov_rm16_r16
				0x00890000, 0x00022000, 0x0000159C,// Mov_rm32_r32
				0x00890000, 0x00032020, 0x00001620,// Mov_rm64_r64
				0x008A0000, 0x00000000, 0x00000D29,// Mov_r8_rm8
				0x008B0000, 0x00010000, 0x00000DAA,// Mov_r16_rm16
				0x008B0000, 0x00020000, 0x00000E2B,// Mov_r32_rm32
				0x008B0000, 0x00030020, 0x0000102C,// Mov_r64_rm64
				0x008C0000, 0x00010000, 0x0000199B,// Mov_rm16_Sreg
				0x008C0000, 0x00020000, 0x0000199C,// Mov_r32m16_Sreg
				0x008C0000, 0x00030020, 0x000019A0,// Mov_r64m16_Sreg
				0x008D0000, 0x00010000, 0x000001AA,// Lea_r16_m
				0x008D0000, 0x00020000, 0x000001AB,// Lea_r32_m
				0x008D0000, 0x00030020, 0x000001AC,// Lea_r64_m
				0x008E0000, 0x00010000, 0x00000DB3,// Mov_Sreg_rm16
				0x008E0000, 0x00020000, 0x00000E33,// Mov_Sreg_r32m16
				0x008E0000, 0x00030020, 0x00001033,// Mov_Sreg_r64m16
				0x008F0000, 0x00010040, 0x0000001B,// Pop_rm16
				0x008F0000, 0x00020050, 0x0000001C,// Pop_rm32
				0x008F0000, 0x00000060, 0x00000020,// Pop_rm64
				0x00900000, 0x00010000, 0x00000000,// Nopw
				0x00900000, 0x00020000, 0x00000000,// Nopd
				0x00900000, 0x00030020, 0x00000000,// Nopq
				0x00900000, 0x00010000, 0x000037F6,// Xchg_r16_AX
				0x00900000, 0x00020000, 0x000038F7,// Xchg_r32_EAX
				0x00900000, 0x00030020, 0x00003978,// Xchg_r64_RAX
				0x00900000, 0x00008002, 0x00000000,// Pause
				0x00980000, 0x00010000, 0x00000000,// Cbw
				0x00980000, 0x00020000, 0x00000000,// Cwde
				0x00980000, 0x00030020, 0x00000000,// Cdqe
				0x00990000, 0x00010000, 0x00000000,// Cwd
				0x00990000, 0x00020000, 0x00000000,// Cdq
				0x00990000, 0x00030020, 0x00000000,// Cqo
				0x009A0000, 0x00010010, 0x00000001,// Call_ptr1616
				0x009A0000, 0x00020010, 0x00000002,// Call_ptr1632
				0x009B0000, 0x00000000, 0x00000000,// Wait
				0x009C0000, 0x00010000, 0x00000000,// Pushfw
				0x009C0000, 0x00020010, 0x00000000,// Pushfd
				0x009C0000, 0x00000020, 0x00000000,// Pushfq
				0x009D0000, 0x00010000, 0x00000000,// Popfw
				0x009D0000, 0x00020010, 0x00000000,// Popfd
				0x009D0000, 0x00000020, 0x00000000,// Popfq
				0x009E0000, 0x00000000, 0x00000000,// Sahf
				0x009F0000, 0x00000000, 0x00000000,// Lahf
				0x00A00000, 0x00000000, 0x00002B6D,// Mov_AL_moffs8
				0x00A10000, 0x00010000, 0x00002BEF,// Mov_AX_moffs16
				0x00A10000, 0x00020000, 0x00002C71,// Mov_EAX_moffs32
				0x00A10000, 0x00030020, 0x00002CF2,// Mov_RAX_moffs64
				0x00A20000, 0x00000000, 0x000036D6,// Mov_moffs8_AL
				0x00A30000, 0x00010000, 0x000037D7,// Mov_moffs16_AX
				0x00A30000, 0x00020000, 0x000038D8,// Mov_moffs32_EAX
				0x00A30000, 0x00030020, 0x00003959,// Mov_moffs64_RAX
				0x00A40000, 0x00001400, 0x000021C7,// Movsb_m8_m8
				0x00A50000, 0x00011400, 0x00002248,// Movsw_m16_m16
				0x00A50000, 0x00021400, 0x000022C9,// Movsd_m32_m32
				0x00A50000, 0x00031420, 0x0000234A,// Movsq_m64_m64
				0x00A60000, 0x00001800, 0x000023C3,// Cmpsb_m8_m8
				0x00A70000, 0x00011800, 0x00002444,// Cmpsw_m16_m16
				0x00A70000, 0x00021800, 0x000024C5,// Cmpsd_m32_m32
				0x00A70000, 0x00031820, 0x00002546,// Cmpsq_m64_m64
				0x00A80000, 0x00000000, 0x00001CED,// Test_AL_imm8
				0x00A90000, 0x00010000, 0x00001EEF,// Test_AX_imm16
				0x00A90000, 0x00020000, 0x00001F71,// Test_EAX_imm32
				0x00A90000, 0x00030020, 0x00001FF2,// Test_RAX_imm32
				0x00AA0000, 0x00001400, 0x000036C7,// Stosb_m8_AL
				0x00AB0000, 0x00011400, 0x000037C8,// Stosw_m16_AX
				0x00AB0000, 0x00021400, 0x000038C9,// Stosd_m32_EAX
				0x00AB0000, 0x00031420, 0x0000394A,// Stosq_m64_RAX
				0x00AC0000, 0x00001400, 0x000021ED,// Lodsb_AL_m8
				0x00AD0000, 0x00011400, 0x0000226F,// Lodsw_AX_m16
				0x00AD0000, 0x00021400, 0x000022F1,// Lodsd_EAX_m32
				0x00AD0000, 0x00031420, 0x00002372,// Lodsq_RAX_m64
				0x00AE0000, 0x00001800, 0x000023ED,// Scasb_AL_m8
				0x00AF0000, 0x00011800, 0x0000246F,// Scasw_AX_m16
				0x00AF0000, 0x00021800, 0x000024F1,// Scasd_EAX_m32
				0x00AF0000, 0x00031820, 0x00002572,// Scasq_RAX_m64
				0x00B00000, 0x00000000, 0x00001CF5,// Mov_r8_imm8
				0x00B80000, 0x00010000, 0x00001EF6,// Mov_r16_imm16
				0x00B80000, 0x00020000, 0x00001F77,// Mov_r32_imm32
				0x00B80000, 0x00030020, 0x00002078,// Mov_r64_imm64
				0x00C00000, 0x00000040, 0x00001C9A,// Rol_rm8_imm8
				0x00C00000, 0x000000C0, 0x00001C9A,// Ror_rm8_imm8
				0x00C00000, 0x00000140, 0x00001C9A,// Rcl_rm8_imm8
				0x00C00000, 0x000001C0, 0x00001C9A,// Rcr_rm8_imm8
				0x00C00000, 0x00000240, 0x00001C9A,// Shl_rm8_imm8
				0x00C00000, 0x000002C0, 0x00001C9A,// Shr_rm8_imm8
				0x00C00000, 0x00000340, 0x00001C9A,// Sal_rm8_imm8
				0x00C00000, 0x000003C0, 0x00001C9A,// Sar_rm8_imm8
				0x00C10000, 0x00010040, 0x00001C9B,// Rol_rm16_imm8
				0x00C10000, 0x00020040, 0x00001C9C,// Rol_rm32_imm8
				0x00C10000, 0x00030060, 0x00001CA0,// Rol_rm64_imm8
				0x00C10000, 0x000100C0, 0x00001C9B,// Ror_rm16_imm8
				0x00C10000, 0x000200C0, 0x00001C9C,// Ror_rm32_imm8
				0x00C10000, 0x000300E0, 0x00001CA0,// Ror_rm64_imm8
				0x00C10000, 0x00010140, 0x00001C9B,// Rcl_rm16_imm8
				0x00C10000, 0x00020140, 0x00001C9C,// Rcl_rm32_imm8
				0x00C10000, 0x00030160, 0x00001CA0,// Rcl_rm64_imm8
				0x00C10000, 0x000101C0, 0x00001C9B,// Rcr_rm16_imm8
				0x00C10000, 0x000201C0, 0x00001C9C,// Rcr_rm32_imm8
				0x00C10000, 0x000301E0, 0x00001CA0,// Rcr_rm64_imm8
				0x00C10000, 0x00010240, 0x00001C9B,// Shl_rm16_imm8
				0x00C10000, 0x00020240, 0x00001C9C,// Shl_rm32_imm8
				0x00C10000, 0x00030260, 0x00001CA0,// Shl_rm64_imm8
				0x00C10000, 0x000102C0, 0x00001C9B,// Shr_rm16_imm8
				0x00C10000, 0x000202C0, 0x00001C9C,// Shr_rm32_imm8
				0x00C10000, 0x000302E0, 0x00001CA0,// Shr_rm64_imm8
				0x00C10000, 0x00010340, 0x00001C9B,// Sal_rm16_imm8
				0x00C10000, 0x00020340, 0x00001C9C,// Sal_rm32_imm8
				0x00C10000, 0x00030360, 0x00001CA0,// Sal_rm64_imm8
				0x00C10000, 0x000103C0, 0x00001C9B,// Sar_rm16_imm8
				0x00C10000, 0x000203C0, 0x00001C9C,// Sar_rm32_imm8
				0x00C10000, 0x000303E0, 0x00001CA0,// Sar_rm64_imm8
				0x00C20000, 0x00010400, 0x0000003D,// Retnw_imm16
				0x00C20000, 0x00020410, 0x0000003D,// Retnd_imm16
				0x00C20000, 0x00000420, 0x0000003D,// Retnq_imm16
				0x00C30000, 0x00010400, 0x00000000,// Retnw
				0x00C30000, 0x00020410, 0x00000000,// Retnd
				0x00C30000, 0x00000420, 0x00000000,// Retnq
				0x00C40000, 0x00010010, 0x000007AA,// Les_r16_m1616
				0x00C40000, 0x00020010, 0x000007AB,// Les_r32_m1632
				0x00C50000, 0x00010010, 0x000007AA,// Lds_r16_m1616
				0x00C50000, 0x00020010, 0x000007AB,// Lds_r32_m1632
				0x00C60000, 0x00002040, 0x00001C9A,// Mov_rm8_imm8
				0xC6F80000, 0x00000000, 0x00000039,// Xabort_imm8
				0x00C70000, 0x00012040, 0x00001E9B,// Mov_rm16_imm16
				0x00C70000, 0x00022040, 0x00001F1C,// Mov_rm32_imm32
				0x00C70000, 0x00032060, 0x00001FA0,// Mov_rm64_imm32
				0xC7F80000, 0x00010000, 0x00000052,// Xbegin_rel16
				0xC7F80000, 0x00020000, 0x00000053,// Xbegin_rel32
				0x00C80000, 0x00010000, 0x000020BD,// Enterw_imm16_imm8
				0x00C80000, 0x00020010, 0x000020BD,// Enterd_imm16_imm8
				0x00C80000, 0x00000020, 0x000020BD,// Enterq_imm16_imm8
				0x00C90000, 0x00010000, 0x00000000,// Leavew
				0x00C90000, 0x00020010, 0x00000000,// Leaved
				0x00C90000, 0x00000020, 0x00000000,// Leaveq
				0x00CA0000, 0x00010000, 0x0000003D,// Retfw_imm16
				0x00CA0000, 0x00020000, 0x0000003D,// Retfd_imm16
				0x00CA0000, 0x00030020, 0x0000003D,// Retfq_imm16
				0x00CB0000, 0x00010000, 0x00000000,// Retfw
				0x00CB0000, 0x00020000, 0x00000000,// Retfd
				0x00CB0000, 0x00030020, 0x00000000,// Retfq
				0x00CC0000, 0x00000000, 0x00000000,// Int3
				0x00CD0000, 0x00000000, 0x00000039,// Int_imm8
				0x00CE0000, 0x00000010, 0x00000000,// Into
				0x00CF0000, 0x00010000, 0x00000000,// Iretw
				0x00CF0000, 0x00020000, 0x00000000,// Iretd
				0x00CF0000, 0x00030020, 0x00000000,// Iretq
				0x00D00000, 0x00000040, 0x00002D1A,// Rol_rm8_1
				0x00D00000, 0x000000C0, 0x00002D1A,// Ror_rm8_1
				0x00D00000, 0x00000140, 0x00002D1A,// Rcl_rm8_1
				0x00D00000, 0x000001C0, 0x00002D1A,// Rcr_rm8_1
				0x00D00000, 0x00000240, 0x00002D1A,// Shl_rm8_1
				0x00D00000, 0x000002C0, 0x00002D1A,// Shr_rm8_1
				0x00D00000, 0x00000340, 0x00002D1A,// Sal_rm8_1
				0x00D00000, 0x000003C0, 0x00002D1A,// Sar_rm8_1
				0x00D10000, 0x00010040, 0x00002D1B,// Rol_rm16_1
				0x00D10000, 0x00020040, 0x00002D1C,// Rol_rm32_1
				0x00D10000, 0x00030060, 0x00002D20,// Rol_rm64_1
				0x00D10000, 0x000100C0, 0x00002D1B,// Ror_rm16_1
				0x00D10000, 0x000200C0, 0x00002D1C,// Ror_rm32_1
				0x00D10000, 0x000300E0, 0x00002D20,// Ror_rm64_1
				0x00D10000, 0x00010140, 0x00002D1B,// Rcl_rm16_1
				0x00D10000, 0x00020140, 0x00002D1C,// Rcl_rm32_1
				0x00D10000, 0x00030160, 0x00002D20,// Rcl_rm64_1
				0x00D10000, 0x000101C0, 0x00002D1B,// Rcr_rm16_1
				0x00D10000, 0x000201C0, 0x00002D1C,// Rcr_rm32_1
				0x00D10000, 0x000301E0, 0x00002D20,// Rcr_rm64_1
				0x00D10000, 0x00010240, 0x00002D1B,// Shl_rm16_1
				0x00D10000, 0x00020240, 0x00002D1C,// Shl_rm32_1
				0x00D10000, 0x00030260, 0x00002D20,// Shl_rm64_1
				0x00D10000, 0x000102C0, 0x00002D1B,// Shr_rm16_1
				0x00D10000, 0x000202C0, 0x00002D1C,// Shr_rm32_1
				0x00D10000, 0x000302E0, 0x00002D20,// Shr_rm64_1
				0x00D10000, 0x00010340, 0x00002D1B,// Sal_rm16_1
				0x00D10000, 0x00020340, 0x00002D1C,// Sal_rm32_1
				0x00D10000, 0x00030360, 0x00002D20,// Sal_rm64_1
				0x00D10000, 0x000103C0, 0x00002D1B,// Sar_rm16_1
				0x00D10000, 0x000203C0, 0x00002D1C,// Sar_rm32_1
				0x00D10000, 0x000303E0, 0x00002D20,// Sar_rm64_1
				0x00D20000, 0x00000040, 0x0000371A,// Rol_rm8_CL
				0x00D20000, 0x000000C0, 0x0000371A,// Ror_rm8_CL
				0x00D20000, 0x00000140, 0x0000371A,// Rcl_rm8_CL
				0x00D20000, 0x000001C0, 0x0000371A,// Rcr_rm8_CL
				0x00D20000, 0x00000240, 0x0000371A,// Shl_rm8_CL
				0x00D20000, 0x000002C0, 0x0000371A,// Shr_rm8_CL
				0x00D20000, 0x00000340, 0x0000371A,// Sal_rm8_CL
				0x00D20000, 0x000003C0, 0x0000371A,// Sar_rm8_CL
				0x00D30000, 0x00010040, 0x0000371B,// Rol_rm16_CL
				0x00D30000, 0x00020040, 0x0000371C,// Rol_rm32_CL
				0x00D30000, 0x00030060, 0x00003720,// Rol_rm64_CL
				0x00D30000, 0x000100C0, 0x0000371B,// Ror_rm16_CL
				0x00D30000, 0x000200C0, 0x0000371C,// Ror_rm32_CL
				0x00D30000, 0x000300E0, 0x00003720,// Ror_rm64_CL
				0x00D30000, 0x00010140, 0x0000371B,// Rcl_rm16_CL
				0x00D30000, 0x00020140, 0x0000371C,// Rcl_rm32_CL
				0x00D30000, 0x00030160, 0x00003720,// Rcl_rm64_CL
				0x00D30000, 0x000101C0, 0x0000371B,// Rcr_rm16_CL
				0x00D30000, 0x000201C0, 0x0000371C,// Rcr_rm32_CL
				0x00D30000, 0x000301E0, 0x00003720,// Rcr_rm64_CL
				0x00D30000, 0x00010240, 0x0000371B,// Shl_rm16_CL
				0x00D30000, 0x00020240, 0x0000371C,// Shl_rm32_CL
				0x00D30000, 0x00030260, 0x00003720,// Shl_rm64_CL
				0x00D30000, 0x000102C0, 0x0000371B,// Shr_rm16_CL
				0x00D30000, 0x000202C0, 0x0000371C,// Shr_rm32_CL
				0x00D30000, 0x000302E0, 0x00003720,// Shr_rm64_CL
				0x00D30000, 0x00010340, 0x0000371B,// Sal_rm16_CL
				0x00D30000, 0x00020340, 0x0000371C,// Sal_rm32_CL
				0x00D30000, 0x00030360, 0x00003720,// Sal_rm64_CL
				0x00D30000, 0x000103C0, 0x0000371B,// Sar_rm16_CL
				0x00D30000, 0x000203C0, 0x0000371C,// Sar_rm32_CL
				0x00D30000, 0x000303E0, 0x00003720,// Sar_rm64_CL
				0x00D40000, 0x00000010, 0x00000039,// Aam_imm8
				0x00D50000, 0x00000010, 0x00000039,// Aad_imm8
				0x00D60000, 0x00000010, 0x00000000,// Salc
				0x00D70000, 0x00000000, 0x00000066,// Xlat_m8
				0x00D80000, 0x00000040, 0x00000005,// Fadd_m32fp
				0x00D80000, 0x000000C0, 0x00000005,// Fmul_m32fp
				0x00D80000, 0x00000140, 0x00000005,// Fcom_m32fp
				0x00D80000, 0x000001C0, 0x00000005,// Fcomp_m32fp
				0x00D80000, 0x00000240, 0x00000005,// Fsub_m32fp
				0x00D80000, 0x000002C0, 0x00000005,// Fsubr_m32fp
				0x00D80000, 0x00000340, 0x00000005,// Fdiv_m32fp
				0x00D80000, 0x000003C0, 0x00000005,// Fdivr_m32fp
				0xD8C00000, 0x00000000, 0x00003A73,// Fadd_st0_sti
				0xD8C80000, 0x00000000, 0x00003A73,// Fmul_st0_sti
				0xD8D00000, 0x00000000, 0x00003A73,// Fcom_st0_sti
				0xD8D80000, 0x00000000, 0x00003A73,// Fcomp_st0_sti
				0xD8E00000, 0x00000000, 0x00003A73,// Fsub_st0_sti
				0xD8E80000, 0x00000000, 0x00003A73,// Fsubr_st0_sti
				0xD8F00000, 0x00000000, 0x00003A73,// Fdiv_st0_sti
				0xD8F80000, 0x00000000, 0x00003A73,// Fdivr_st0_sti
				0x00D90000, 0x00000040, 0x00000005,// Fld_m32fp
				0x00D90000, 0x00000140, 0x00000005,// Fst_m32fp
				0x00D90000, 0x000001C0, 0x00000005,// Fstp_m32fp
				0x00D90000, 0x00010240, 0x0000000B,// Fldenv_m14byte
				0x00D90000, 0x00020240, 0x0000000C,// Fldenv_m28byte
				0x00D90000, 0x000002C0, 0x00000013,// Fldcw_m2byte
				0x00D90000, 0x00010340, 0x0000000B,// Fnstenv_m14byte
				0x00D90000, 0x00014340, 0x0000000B,// Fstenv_m14byte
				0x00D90000, 0x00020340, 0x0000000C,// Fnstenv_m28byte
				0x00D90000, 0x00024340, 0x0000000C,// Fstenv_m28byte
				0x00D90000, 0x000003C0, 0x00000013,// Fnstcw_m2byte
				0x00D90000, 0x000043C0, 0x00000013,// Fstcw_m2byte
				0xD9C00000, 0x00000000, 0x00003A73,// Fld_st0_sti
				0xD9C80000, 0x00000000, 0x00003A73,// Fxch_st0_sti
				0xD9D00000, 0x00000000, 0x00000000,// Fnop
				0xD9D80000, 0x00000000, 0x00000074,// Fstpnce_sti
				0xD9E00000, 0x00000000, 0x00000000,// Fchs
				0xD9E10000, 0x00000000, 0x00000000,// Fabs
				0xD9E40000, 0x00000000, 0x00000000,// Ftst
				0xD9E50000, 0x00000000, 0x00000000,// Fxam
				0xD9E80000, 0x00000000, 0x00000000,// Fld1
				0xD9E90000, 0x00000000, 0x00000000,// Fldl2t
				0xD9EA0000, 0x00000000, 0x00000000,// Fldl2e
				0xD9EB0000, 0x00000000, 0x00000000,// Fldpi
				0xD9EC0000, 0x00000000, 0x00000000,// Fldlg2
				0xD9ED0000, 0x00000000, 0x00000000,// Fldln2
				0xD9EE0000, 0x00000000, 0x00000000,// Fldz
				0xD9F00000, 0x00000000, 0x00000000,// F2xm1
				0xD9F10000, 0x00000000, 0x00000000,// Fyl2x
				0xD9F20000, 0x00000000, 0x00000000,// Fptan
				0xD9F30000, 0x00000000, 0x00000000,// Fpatan
				0xD9F40000, 0x00000000, 0x00000000,// Fxtract
				0xD9F50000, 0x00000000, 0x00000000,// Fprem1
				0xD9F60000, 0x00000000, 0x00000000,// Fdecstp
				0xD9F70000, 0x00000000, 0x00000000,// Fincstp
				0xD9F80000, 0x00000000, 0x00000000,// Fprem
				0xD9F90000, 0x00000000, 0x00000000,// Fyl2xp1
				0xD9FA0000, 0x00000000, 0x00000000,// Fsqrt
				0xD9FB0000, 0x00000000, 0x00000000,// Fsincos
				0xD9FC0000, 0x00000000, 0x00000000,// Frndint
				0xD9FD0000, 0x00000000, 0x00000000,// Fscale
				0xD9FE0000, 0x00000000, 0x00000000,// Fsin
				0xD9FF0000, 0x00000000, 0x00000000,// Fcos
				0x00DA0000, 0x00000040, 0x00000009,// Fiadd_m32int
				0x00DA0000, 0x000000C0, 0x00000009,// Fimul_m32int
				0x00DA0000, 0x00000140, 0x00000009,// Ficom_m32int
				0x00DA0000, 0x000001C0, 0x00000009,// Ficomp_m32int
				0x00DA0000, 0x00000240, 0x00000009,// Fisub_m32int
				0x00DA0000, 0x000002C0, 0x00000009,// Fisubr_m32int
				0x00DA0000, 0x00000340, 0x00000009,// Fidiv_m32int
				0x00DA0000, 0x000003C0, 0x00000009,// Fidivr_m32int
				0xDAC00000, 0x00000000, 0x00003A73,// Fcmovb_st0_sti
				0xDAC80000, 0x00000000, 0x00003A73,// Fcmove_st0_sti
				0xDAD00000, 0x00000000, 0x00003A73,// Fcmovbe_st0_sti
				0xDAD80000, 0x00000000, 0x00003A73,// Fcmovu_st0_sti
				0xDAE90000, 0x00000000, 0x00000000,// Fucompp
				0x00DB0000, 0x00000040, 0x00000009,// Fild_m32int
				0x00DB0000, 0x000000C0, 0x00000009,// Fisttp_m32int
				0x00DB0000, 0x00000140, 0x00000009,// Fist_m32int
				0x00DB0000, 0x000001C0, 0x00000009,// Fistp_m32int
				0x00DB0000, 0x000002C0, 0x00000007,// Fld_m80fp
				0x00DB0000, 0x000003C0, 0x00000007,// Fstp_m80fp
				0xDBC00000, 0x00000000, 0x00003A73,// Fcmovnb_st0_sti
				0xDBC80000, 0x00000000, 0x00003A73,// Fcmovne_st0_sti
				0xDBD00000, 0x00000000, 0x00003A73,// Fcmovnbe_st0_sti
				0xDBD80000, 0x00000000, 0x00003A73,// Fcmovnu_st0_sti
				0xDBE00000, 0x00000000, 0x00000000,// Fneni
				0xDBE00000, 0x00004000, 0x00000000,// Feni
				0xDBE10000, 0x00000000, 0x00000000,// Fndisi
				0xDBE10000, 0x00004000, 0x00000000,// Fdisi
				0xDBE20000, 0x00000000, 0x00000000,// Fnclex
				0xDBE20000, 0x00004000, 0x00000000,// Fclex
				0xDBE30000, 0x00000000, 0x00000000,// Fninit
				0xDBE30000, 0x00004000, 0x00000000,// Finit
				0xDBE40000, 0x00000000, 0x00000000,// Fnsetpm
				0xDBE40000, 0x00004000, 0x00000000,// Fsetpm
				0xDBE50000, 0x00000010, 0x00000000,// Frstpm
				0xDBE80000, 0x00000000, 0x00003A73,// Fucomi_st0_sti
				0xDBF00000, 0x00000000, 0x00003A73,// Fcomi_st0_sti
				0x00DC0000, 0x00000040, 0x00000006,// Fadd_m64fp
				0x00DC0000, 0x000000C0, 0x00000006,// Fmul_m64fp
				0x00DC0000, 0x00000140, 0x00000006,// Fcom_m64fp
				0x00DC0000, 0x000001C0, 0x00000006,// Fcomp_m64fp
				0x00DC0000, 0x00000240, 0x00000006,// Fsub_m64fp
				0x00DC0000, 0x000002C0, 0x00000006,// Fsubr_m64fp
				0x00DC0000, 0x00000340, 0x00000006,// Fdiv_m64fp
				0x00DC0000, 0x000003C0, 0x00000006,// Fdivr_m64fp
				0xDCC00000, 0x00000000, 0x000039F4,// Fadd_sti_st0
				0xDCC80000, 0x00000000, 0x000039F4,// Fmul_sti_st0
				0xDCD00000, 0x00000000, 0x00003A73,// Fcom_st0_sti_DCD0
				0xDCD80000, 0x00000000, 0x00003A73,// Fcomp_st0_sti_DCD8
				0xDCE00000, 0x00000000, 0x000039F4,// Fsubr_sti_st0
				0xDCE80000, 0x00000000, 0x000039F4,// Fsub_sti_st0
				0xDCF00000, 0x00000000, 0x000039F4,// Fdivr_sti_st0
				0xDCF80000, 0x00000000, 0x000039F4,// Fdiv_sti_st0
				0x00DD0000, 0x00000040, 0x00000006,// Fld_m64fp
				0x00DD0000, 0x000000C0, 0x00000006,// Fisttp_m64int
				0x00DD0000, 0x00000140, 0x00000006,// Fst_m64fp
				0x00DD0000, 0x000001C0, 0x00000006,// Fstp_m64fp
				0x00DD0000, 0x00010240, 0x0000000D,// Frstor_m94byte
				0x00DD0000, 0x00020240, 0x0000000E,// Frstor_m108byte
				0x00DD0000, 0x00010340, 0x0000000D,// Fnsave_m94byte
				0x00DD0000, 0x00014340, 0x0000000D,// Fsave_m94byte
				0x00DD0000, 0x00020340, 0x0000000E,// Fnsave_m108byte
				0x00DD0000, 0x00024340, 0x0000000E,// Fsave_m108byte
				0x00DD0000, 0x000003C0, 0x00000013,// Fnstsw_m2byte
				0x00DD0000, 0x000043C0, 0x00000013,// Fstsw_m2byte
				0xDDC00000, 0x00000000, 0x00000074,// Ffree_sti
				0xDDC80000, 0x00000000, 0x00003A73,// Fxch_st0_sti_DDC8
				0xDDD00000, 0x00000000, 0x00000074,// Fst_sti
				0xDDD80000, 0x00000000, 0x00000074,// Fstp_sti
				0xDDE00000, 0x00000000, 0x00003A73,// Fucom_st0_sti
				0xDDE80000, 0x00000000, 0x00003A73,// Fucomp_st0_sti
				0x00DE0000, 0x00000040, 0x00000008,// Fiadd_m16int
				0x00DE0000, 0x000000C0, 0x00000008,// Fimul_m16int
				0x00DE0000, 0x00000140, 0x00000008,// Ficom_m16int
				0x00DE0000, 0x000001C0, 0x00000008,// Ficomp_m16int
				0x00DE0000, 0x00000240, 0x00000008,// Fisub_m16int
				0x00DE0000, 0x000002C0, 0x00000008,// Fisubr_m16int
				0x00DE0000, 0x00000340, 0x00000008,// Fidiv_m16int
				0x00DE0000, 0x000003C0, 0x00000008,// Fidivr_m16int
				0xDEC00000, 0x00000000, 0x000039F4,// Faddp_sti_st0
				0xDEC80000, 0x00000000, 0x000039F4,// Fmulp_sti_st0
				0xDED00000, 0x00000000, 0x00003A73,// Fcomp_st0_sti_DED0
				0xDED90000, 0x00000000, 0x00000000,// Fcompp
				0xDEE00000, 0x00000000, 0x000039F4,// Fsubrp_sti_st0
				0xDEE80000, 0x00000000, 0x000039F4,// Fsubp_sti_st0
				0xDEF00000, 0x00000000, 0x000039F4,// Fdivrp_sti_st0
				0xDEF80000, 0x00000000, 0x000039F4,// Fdivp_sti_st0
				0x00DF0000, 0x00000040, 0x00000008,// Fild_m16int
				0x00DF0000, 0x000000C0, 0x00000008,// Fisttp_m16int
				0x00DF0000, 0x00000140, 0x00000008,// Fist_m16int
				0x00DF0000, 0x000001C0, 0x00000008,// Fistp_m16int
				0x00DF0000, 0x00000240, 0x00000004,// Fbld_m80bcd
				0x00DF0000, 0x000002C0, 0x0000000A,// Fild_m64int
				0x00DF0000, 0x00000340, 0x00000004,// Fbstp_m80bcd
				0x00DF0000, 0x000003C0, 0x0000000A,// Fistp_m64int
				0xDFC00000, 0x00000000, 0x00000074,// Ffreep_sti
				0xDFC80000, 0x00000000, 0x00003A73,// Fxch_st0_sti_DFC8
				0xDFD00000, 0x00000000, 0x00000074,// Fstp_sti_DFD0
				0xDFD80000, 0x00000000, 0x00000074,// Fstp_sti_DFD8
				0xDFE00000, 0x00000000, 0x0000006F,// Fnstsw_AX
				0xDFE00000, 0x00004000, 0x0000006F,// Fstsw_AX
				0xDFE10000, 0x00000010, 0x0000006F,// Fstdw_AX
				0xDFE20000, 0x00000010, 0x0000006F,// Fstsg_AX
				0xDFE80000, 0x00000000, 0x00003A73,// Fucomip_st0_sti
				0xDFF00000, 0x00000000, 0x00003A73,// Fcomip_st0_sti
				0x00E00000, 0x00050010, 0x0000004B,// Loopne_rel8_16_CX
				0x00E00000, 0x00060010, 0x0000004C,// Loopne_rel8_32_CX
				0x00E00000, 0x00090000, 0x0000004B,// Loopne_rel8_16_ECX
				0x00E00000, 0x000A0010, 0x0000004C,// Loopne_rel8_32_ECX
				0x00E00000, 0x00080020, 0x0000004D,// Loopne_rel8_64_ECX
				0x00E00000, 0x00010020, 0x0000004B,// Loopne_rel8_16_RCX
				0x00E00000, 0x00000020, 0x0000004D,// Loopne_rel8_64_RCX
				0x00E10000, 0x00050010, 0x0000004B,// Loope_rel8_16_CX
				0x00E10000, 0x00060010, 0x0000004C,// Loope_rel8_32_CX
				0x00E10000, 0x00090000, 0x0000004B,// Loope_rel8_16_ECX
				0x00E10000, 0x000A0010, 0x0000004C,// Loope_rel8_32_ECX
				0x00E10000, 0x00080020, 0x0000004D,// Loope_rel8_64_ECX
				0x00E10000, 0x00010020, 0x0000004B,// Loope_rel8_16_RCX
				0x00E10000, 0x00000020, 0x0000004D,// Loope_rel8_64_RCX
				0x00E20000, 0x00050010, 0x0000004B,// Loop_rel8_16_CX
				0x00E20000, 0x00060010, 0x0000004C,// Loop_rel8_32_CX
				0x00E20000, 0x00090000, 0x0000004B,// Loop_rel8_16_ECX
				0x00E20000, 0x000A0010, 0x0000004C,// Loop_rel8_32_ECX
				0x00E20000, 0x00080020, 0x0000004D,// Loop_rel8_64_ECX
				0x00E20000, 0x00010020, 0x0000004B,// Loop_rel8_16_RCX
				0x00E20000, 0x00000020, 0x0000004D,// Loop_rel8_64_RCX
				0x00E30000, 0x00050010, 0x0000004B,// Jcxz_rel8_16
				0x00E30000, 0x00060010, 0x0000004C,// Jcxz_rel8_32
				0x00E30000, 0x00090000, 0x0000004B,// Jecxz_rel8_16
				0x00E30000, 0x000A0010, 0x0000004C,// Jecxz_rel8_32
				0x00E30000, 0x00080020, 0x0000004D,// Jecxz_rel8_64
				0x00E30000, 0x00010020, 0x0000004B,// Jrcxz_rel8_16
				0x00E30000, 0x00000020, 0x0000004D,// Jrcxz_rel8_64
				0x00E40000, 0x00000000, 0x00001CED,// In_AL_imm8
				0x00E50000, 0x00010000, 0x00001CEF,// In_AX_imm8
				0x00E50000, 0x00020000, 0x00001CF1,// In_EAX_imm8
				0x00E60000, 0x00000000, 0x000036B9,// Out_imm8_AL
				0x00E70000, 0x00010000, 0x000037B9,// Out_imm8_AX
				0x00E70000, 0x00020000, 0x000038B9,// Out_imm8_EAX
				0x00E80000, 0x00010400, 0x0000004E,// Call_rel16
				0x00E80000, 0x00020410, 0x00000050,// Call_rel32_32
				0x00E80000, 0x00000420, 0x00000051,// Call_rel32_64
				0x00E90000, 0x00010400, 0x0000004E,// Jmp_rel16
				0x00E90000, 0x00020410, 0x00000050,// Jmp_rel32_32
				0x00E90000, 0x00000420, 0x00000051,// Jmp_rel32_64
				0x00EA0000, 0x00010010, 0x00000001,// Jmp_ptr1616
				0x00EA0000, 0x00020010, 0x00000002,// Jmp_ptr1632
				0x00EB0000, 0x00010000, 0x0000004B,// Jmp_rel8_16
				0x00EB0000, 0x00020010, 0x0000004C,// Jmp_rel8_32
				0x00EB0000, 0x00000020, 0x0000004D,// Jmp_rel8_64
				0x00EC0000, 0x00000000, 0x0000386D,// In_AL_DX
				0x00ED0000, 0x00010000, 0x0000386F,// In_AX_DX
				0x00ED0000, 0x00020000, 0x00003871,// In_EAX_DX
				0x00EE0000, 0x00000000, 0x000036F0,// Out_DX_AL
				0x00EF0000, 0x00010000, 0x000037F0,// Out_DX_AX
				0x00EF0000, 0x00020000, 0x000038F0,// Out_DX_EAX
				0x00F10000, 0x00000000, 0x00000000,// Int1
				0x00F40000, 0x00000000, 0x00000000,// Hlt
				0x00F50000, 0x00000000, 0x00000000,// Cmc
				0x00F60000, 0x00000040, 0x00001C9A,// Test_rm8_imm8
				0x00F60000, 0x000000C0, 0x00001C9A,// Test_rm8_imm8_F6r1
				0x00F60000, 0x00001D40, 0x0000001A,// Not_rm8
				0x00F60000, 0x00001DC0, 0x0000001A,// Neg_rm8
				0x00F60000, 0x00000240, 0x0000001A,// Mul_rm8
				0x00F60000, 0x000002C0, 0x0000001A,// Imul_rm8
				0x00F60000, 0x00000340, 0x0000001A,// Div_rm8
				0x00F60000, 0x000003C0, 0x0000001A,// Idiv_rm8
				0x00F70000, 0x00010040, 0x00001E9B,// Test_rm16_imm16
				0x00F70000, 0x00020040, 0x00001F1C,// Test_rm32_imm32
				0x00F70000, 0x00030060, 0x00001FA0,// Test_rm64_imm32
				0x00F70000, 0x000100C0, 0x00001E9B,// Test_rm16_imm16_F7r1
				0x00F70000, 0x000200C0, 0x00001F1C,// Test_rm32_imm32_F7r1
				0x00F70000, 0x000300E0, 0x00001FA0,// Test_rm64_imm32_F7r1
				0x00F70000, 0x00011D40, 0x0000001B,// Not_rm16
				0x00F70000, 0x00021D40, 0x0000001C,// Not_rm32
				0x00F70000, 0x00031D60, 0x00000020,// Not_rm64
				0x00F70000, 0x00011DC0, 0x0000001B,// Neg_rm16
				0x00F70000, 0x00021DC0, 0x0000001C,// Neg_rm32
				0x00F70000, 0x00031DE0, 0x00000020,// Neg_rm64
				0x00F70000, 0x00010240, 0x0000001B,// Mul_rm16
				0x00F70000, 0x00020240, 0x0000001C,// Mul_rm32
				0x00F70000, 0x00030260, 0x00000020,// Mul_rm64
				0x00F70000, 0x000102C0, 0x0000001B,// Imul_rm16
				0x00F70000, 0x000202C0, 0x0000001C,// Imul_rm32
				0x00F70000, 0x000302E0, 0x00000020,// Imul_rm64
				0x00F70000, 0x00010340, 0x0000001B,// Div_rm16
				0x00F70000, 0x00020340, 0x0000001C,// Div_rm32
				0x00F70000, 0x00030360, 0x00000020,// Div_rm64
				0x00F70000, 0x000103C0, 0x0000001B,// Idiv_rm16
				0x00F70000, 0x000203C0, 0x0000001C,// Idiv_rm32
				0x00F70000, 0x000303E0, 0x00000020,// Idiv_rm64
				0x00F80000, 0x00000000, 0x00000000,// Clc
				0x00F90000, 0x00000000, 0x00000000,// Stc
				0x00FA0000, 0x00000000, 0x00000000,// Cli
				0x00FB0000, 0x00000000, 0x00000000,// Sti
				0x00FC0000, 0x00000000, 0x00000000,// Cld
				0x00FD0000, 0x00000000, 0x00000000,// Std
				0x00FE0000, 0x00001C40, 0x0000001A,// Inc_rm8
				0x00FE0000, 0x00001CC0, 0x0000001A,// Dec_rm8
				0x00FF0000, 0x00011C40, 0x0000001B,// Inc_rm16
				0x00FF0000, 0x00021C40, 0x0000001C,// Inc_rm32
				0x00FF0000, 0x00031C60, 0x00000020,// Inc_rm64
				0x00FF0000, 0x00011CC0, 0x0000001B,// Dec_rm16
				0x00FF0000, 0x00021CC0, 0x0000001C,// Dec_rm32
				0x00FF0000, 0x00031CE0, 0x00000020,// Dec_rm64
				0x00FF0000, 0x00010940, 0x0000001B,// Call_rm16
				0x00FF0000, 0x00020950, 0x0000001C,// Call_rm32
				0x00FF0000, 0x00000960, 0x00000020,// Call_rm64
				0x00FF0000, 0x000101C0, 0x00000022,// Call_m1616
				0x00FF0000, 0x000201C0, 0x00000023,// Call_m1632
				0x00FF0000, 0x000301E0, 0x00000024,// Call_m1664
				0x00FF0000, 0x00010A40, 0x0000001B,// Jmp_rm16
				0x00FF0000, 0x00020A50, 0x0000001C,// Jmp_rm32
				0x00FF0000, 0x00000A60, 0x00000020,// Jmp_rm64
				0x00FF0000, 0x000102C0, 0x00000022,// Jmp_m1616
				0x00FF0000, 0x000202C0, 0x00000023,// Jmp_m1632
				0x00FF0000, 0x000302E0, 0x00000024,// Jmp_m1664
				0x00FF0000, 0x00010340, 0x0000001B,// Push_rm16
				0x00FF0000, 0x00020350, 0x0000001C,// Push_rm32
				0x00FF0000, 0x00000360, 0x00000020,// Push_rm64
				0x00000000, 0x00010044, 0x0000001B,// Sldt_rm16
				0x00000000, 0x00020044, 0x0000001E,// Sldt_r32m16
				0x00000000, 0x00030064, 0x0000001F,// Sldt_r64m16
				0x00000000, 0x000100C4, 0x0000001B,// Str_rm16
				0x00000000, 0x000200C4, 0x0000001E,// Str_r32m16
				0x00000000, 0x000300E4, 0x0000001F,// Str_r64m16
				0x00000000, 0x00010144, 0x0000001B,// Lldt_rm16
				0x00000000, 0x00020144, 0x0000001E,// Lldt_r32m16
				0x00000000, 0x00030164, 0x0000001F,// Lldt_r64m16
				0x00000000, 0x000101C4, 0x0000001B,// Ltr_rm16
				0x00000000, 0x000201C4, 0x0000001E,// Ltr_r32m16
				0x00000000, 0x000301E4, 0x0000001F,// Ltr_r64m16
				0x00000000, 0x00010244, 0x0000001B,// Verr_rm16
				0x00000000, 0x00020244, 0x0000001E,// Verr_r32m16
				0x00000000, 0x00030264, 0x0000001F,// Verr_r64m16
				0x00000000, 0x000102C4, 0x0000001B,// Verw_rm16
				0x00000000, 0x000202C4, 0x0000001E,// Verw_r32m16
				0x00000000, 0x000302E4, 0x0000001F,// Verw_r64m16
				0x00000000, 0x00010354, 0x0000001B,// Jmpe_rm16
				0x00000000, 0x00020354, 0x0000001C,// Jmpe_rm32
				0x00010000, 0x00010054, 0x00000010,// Sgdt_m1632_16
				0x00010000, 0x00020054, 0x00000010,// Sgdt_m1632
				0x00010000, 0x00000064, 0x00000010,// Sgdt_m1664
				0x00010000, 0x000100D4, 0x00000010,// Sidt_m1632_16
				0x00010000, 0x000200D4, 0x00000010,// Sidt_m1632
				0x00010000, 0x000000E4, 0x00000010,// Sidt_m1664
				0x00010000, 0x00010154, 0x00000010,// Lgdt_m1632_16
				0x00010000, 0x00020154, 0x00000010,// Lgdt_m1632
				0x00010000, 0x00000164, 0x00000010,// Lgdt_m1664
				0x00010000, 0x000101D4, 0x00000010,// Lidt_m1632_16
				0x00010000, 0x000201D4, 0x00000010,// Lidt_m1632
				0x00010000, 0x000001E4, 0x00000010,// Lidt_m1664
				0x00010000, 0x00010244, 0x0000001B,// Smsw_rm16
				0x00010000, 0x00020244, 0x0000001E,// Smsw_r32m16
				0x00010000, 0x00030264, 0x0000001F,// Smsw_r64m16
				0x00010000, 0x000082C6, 0x00000016,// Rstorssp_m64
				0x00010000, 0x00010344, 0x0000001B,// Lmsw_rm16
				0x00010000, 0x00020344, 0x0000001E,// Lmsw_r32m16
				0x00010000, 0x00030364, 0x0000001F,// Lmsw_r64m16
				0x00010000, 0x000003C4, 0x00000003,// Invlpg_m
				0x01C00000, 0x00008004, 0x00000000,// Enclv
				0x01C10000, 0x00008004, 0x00000000,// Vmcall
				0x01C20000, 0x00008004, 0x00000000,// Vmlaunch
				0x01C30000, 0x00008004, 0x00000000,// Vmresume
				0x01C40000, 0x00008004, 0x00000000,// Vmxoff
				0x01C50000, 0x00008004, 0x00000000,// Pconfig
				0x01C80000, 0x00048014, 0x00000000,// Monitorw
				0x01C80000, 0x00088004, 0x00000000,// Monitord
				0x01C80000, 0x00008024, 0x00000000,// Monitorq
				0x01C90000, 0x00008004, 0x00000000,// Mwait
				0x01CA0000, 0x00008004, 0x00000000,// Clac
				0x01CB0000, 0x00008004, 0x00000000,// Stac
				0x01CF0000, 0x00008004, 0x00000000,// Encls
				0x01D00000, 0x00008004, 0x00000000,// Xgetbv
				0x01D10000, 0x00008004, 0x00000000,// Xsetbv
				0x01D40000, 0x00008004, 0x00000000,// Vmfunc
				0x01D50000, 0x00008004, 0x00000000,// Xend
				0x01D60000, 0x00008004, 0x00000000,// Xtest
				0x01D70000, 0x00008004, 0x00000000,// Enclu
				0x01D80000, 0x00040014, 0x00000000,// Vmrunw
				0x01D80000, 0x00080004, 0x00000000,// Vmrund
				0x01D80000, 0x00000024, 0x00000000,// Vmrunq
				0x01D90000, 0x00000004, 0x00000000,// Vmmcall
				0x01DA0000, 0x00040014, 0x00000000,// Vmloadw
				0x01DA0000, 0x00080004, 0x00000000,// Vmloadd
				0x01DA0000, 0x00000024, 0x00000000,// Vmloadq
				0x01DB0000, 0x00040014, 0x00000000,// Vmsavew
				0x01DB0000, 0x00080004, 0x00000000,// Vmsaved
				0x01DB0000, 0x00000024, 0x00000000,// Vmsaveq
				0x01DC0000, 0x00000004, 0x00000000,// Stgi
				0x01DD0000, 0x00000004, 0x00000000,// Clgi
				0x01DE0000, 0x00000004, 0x00000000,// Skinit
				0x01DF0000, 0x00040014, 0x00000000,// Invlpgaw
				0x01DF0000, 0x00080004, 0x00000000,// Invlpgad
				0x01DF0000, 0x00000024, 0x00000000,// Invlpgaq
				0x01E80000, 0x00008006, 0x00000000,// Setssbsy
				0x01EA0000, 0x00008006, 0x00000000,// Saveprevssp
				0x01EE0000, 0x00008004, 0x00000000,// Rdpkru
				0x01EF0000, 0x00008004, 0x00000000,// Wrpkru
				0x01F80000, 0x00000024, 0x00000000,// Swapgs
				0x01F90000, 0x00000004, 0x00000000,// Rdtscp
				0x01FA0000, 0x00048014, 0x00000000,// Monitorxw
				0x01FA0000, 0x00088004, 0x00000000,// Monitorxd
				0x01FA0000, 0x00008024, 0x00000000,// Monitorxq
				0x01FA0000, 0x00008006, 0x00000000,// Mcommit
				0x01FB0000, 0x00000004, 0x00000000,// Mwaitx
				0x01FC0000, 0x00040014, 0x00000000,// Clzerow
				0x01FC0000, 0x00080004, 0x00000000,// Clzerod
				0x01FC0000, 0x00000024, 0x00000000,// Clzeroq
				0x01FD0000, 0x00000004, 0x00000000,// Rdpru
				0x00020000, 0x00010004, 0x00000DAA,// Lar_r16_rm16
				0x00020000, 0x00020004, 0x00000E2B,// Lar_r32_r32m16
				0x00020000, 0x00030024, 0x0000102C,// Lar_r64_r64m16
				0x00030000, 0x00010004, 0x00000DAA,// Lsl_r16_rm16
				0x00030000, 0x00020004, 0x00000E2B,// Lsl_r32_r32m16
				0x00030000, 0x00030024, 0x0000102C,// Lsl_r64_r64m16
				0x00040000, 0x00000014, 0x00000000,// Loadallreset286
				0x00050000, 0x00000014, 0x00000000,// Loadall286
				0x00050000, 0x00000004, 0x00000000,// Syscall
				0x00060000, 0x00000004, 0x00000000,// Clts
				0x00070000, 0x00000014, 0x00000000,// Loadall386
				0x00070000, 0x00000004, 0x00000000,// Sysretd
				0x00070000, 0x00030024, 0x00000000,// Sysretq
				0x00080000, 0x00000004, 0x00000000,// Invd
				0x00090000, 0x00000004, 0x00000000,// Wbinvd
				0x00090000, 0x00008006, 0x00000000,// Wbnoinvd
				0x000A0000, 0x00000004, 0x00000000,// Cl1invmb
				0x000B0000, 0x00000004, 0x00000000,// Ud2
				0x000D0000, 0x00010004, 0x0000151B,// ReservedNop_rm16_r16_0F0D
				0x000D0000, 0x00020004, 0x0000159C,// ReservedNop_rm32_r32_0F0D
				0x000D0000, 0x00030024, 0x00001620,// ReservedNop_rm64_r64_0F0D
				0x000D0000, 0x00000044, 0x00000012,// Prefetch_m8
				0x000D0000, 0x000000C4, 0x00000012,// Prefetchw_m8
				0x000D0000, 0x00000144, 0x00000012,// Prefetchwt1_m8
				0x000E0000, 0x00000004, 0x00000000,// Femms
				0x00100000, 0x00000014, 0x0000149A,// Umov_rm8_r8
				0x00110000, 0x00010014, 0x0000151B,// Umov_rm16_r16
				0x00110000, 0x00020014, 0x0000159C,// Umov_rm32_r32
				0x00120000, 0x00000014, 0x00000D29,// Umov_r8_rm8
				0x00130000, 0x00010014, 0x00000DAA,// Umov_r16_rm16
				0x00130000, 0x00020014, 0x00000E2B,// Umov_r32_rm32
				0x00100000, 0x00008004, 0x00003263,// Movups_xmm_xmmm128
				0x00100001, 0x00004C04, 0x00000962,// VEX_Vmovups_xmm_xmmm128
				0x00100001, 0x00005004, 0x000009A3,// VEX_Vmovups_ymm_ymmm256
				0x00100002, 0x0301C004, 0x0000085E,// EVEX_Vmovups_xmm_k1z_xmmm128
				0x00100002, 0x03020404, 0x0000089F,// EVEX_Vmovups_ymm_k1z_ymmm256
				0x00100002, 0x03024804, 0x000008E0,// EVEX_Vmovups_zmm_k1z_zmmm512
				0x00100000, 0x00008005, 0x00003263,// Movupd_xmm_xmmm128
				0x00100001, 0x00004C05, 0x00000962,// VEX_Vmovupd_xmm_xmmm128
				0x00100001, 0x00005005, 0x000009A3,// VEX_Vmovupd_ymm_ymmm256
				0x00100002, 0x0301D005, 0x0000085E,// EVEX_Vmovupd_xmm_k1z_xmmm128
				0x00100002, 0x03021405, 0x0000089F,// EVEX_Vmovupd_ymm_k1z_ymmm256
				0x00100002, 0x03025805, 0x000008E0,// EVEX_Vmovupd_zmm_k1z_zmmm512
				0x00100000, 0x00008006, 0x00003263,// Movss_xmm_xmmm32
				0x00100001, 0x00005406, 0x0001B3A2,// VEX_Vmovss_xmm_xmm_xmm
				0x00100001, 0x00005406, 0x000005A2,// VEX_Vmovss_xmm_m32
				0x00100002, 0x03128006, 0x0001225E,// EVEX_Vmovss_xmm_k1z_xmm_xmm
				0x00100002, 0x03128006, 0x000003DE,// EVEX_Vmovss_xmm_k1z_m32
				0x00100000, 0x00008007, 0x00003263,// Movsd_xmm_xmmm64
				0x00100001, 0x00005407, 0x0001B3A2,// VEX_Vmovsd_xmm_xmm_xmm
				0x00100001, 0x00005407, 0x000005A2,// VEX_Vmovsd_xmm_m64
				0x00100002, 0x03129007, 0x0001225E,// EVEX_Vmovsd_xmm_k1z_xmm_xmm
				0x00100002, 0x03129007, 0x000003DE,// EVEX_Vmovsd_xmm_k1z_m64
				0x00110000, 0x00008004, 0x000031E4,// Movups_xmmm128_xmm
				0x00110001, 0x00004C04, 0x000008A5,// VEX_Vmovups_xmmm128_xmm
				0x00110001, 0x00005004, 0x000008E6,// VEX_Vmovups_ymmm256_ymm
				0x00110002, 0x0301C004, 0x000007A1,// EVEX_Vmovups_xmmm128_k1z_xmm
				0x00110002, 0x03020404, 0x000007E2,// EVEX_Vmovups_ymmm256_k1z_ymm
				0x00110002, 0x03024804, 0x00000823,// EVEX_Vmovups_zmmm512_k1z_zmm
				0x00110000, 0x00008005, 0x000031E4,// Movupd_xmmm128_xmm
				0x00110001, 0x00004C05, 0x000008A5,// VEX_Vmovupd_xmmm128_xmm
				0x00110001, 0x00005005, 0x000008E6,// VEX_Vmovupd_ymmm256_ymm
				0x00110002, 0x0301D005, 0x000007A1,// EVEX_Vmovupd_xmmm128_k1z_xmm
				0x00110002, 0x03021405, 0x000007E2,// EVEX_Vmovupd_ymmm256_k1z_ymm
				0x00110002, 0x03025805, 0x00000823,// EVEX_Vmovupd_zmmm512_k1z_zmm
				0x00110000, 0x00008006, 0x000031E4,// Movss_xmmm32_xmm
				0x00110001, 0x00005406, 0x0002239B,// VEX_Vmovss_xmm_xmm_xmm_0F11
				0x00110001, 0x00005406, 0x00000896,// VEX_Vmovss_m32_xmm
				0x00110002, 0x03128006, 0x0001E252,// EVEX_Vmovss_xmm_k1z_xmm_xmm_0F11
				0x00110002, 0x01128006, 0x0000078F,// EVEX_Vmovss_m32_k1_xmm
				0x00110000, 0x00008007, 0x000031E4,// Movsd_xmmm64_xmm
				0x00110001, 0x00005407, 0x0002239B,// VEX_Vmovsd_xmm_xmm_xmm_0F11
				0x00110001, 0x00005407, 0x00000896,// VEX_Vmovsd_m64_xmm
				0x00110002, 0x03129007, 0x0001E252,// EVEX_Vmovsd_xmm_k1z_xmm_xmm_0F11
				0x00110002, 0x01129007, 0x0000078F,// EVEX_Vmovsd_m64_k1_xmm
				0x00120000, 0x00008004, 0x00003163,// Movhlps_xmm_xmm
				0x00120000, 0x00008004, 0x000001E3,// Movlps_xmm_m64
				0x00120001, 0x00004C04, 0x0001B3A2,// VEX_Vmovhlps_xmm_xmm_xmm
				0x00120001, 0x00004C04, 0x000163A2,// VEX_Vmovlps_xmm_xmm_m64
				0x00120002, 0x00044004, 0x0001225E,// EVEX_Vmovhlps_xmm_xmm_xmm
				0x00120002, 0x00044004, 0x0000F25E,// EVEX_Vmovlps_xmm_xmm_m64
				0x00120000, 0x00008005, 0x000001E3,// Movlpd_xmm_m64
				0x00120001, 0x00004C05, 0x000163A2,// VEX_Vmovlpd_xmm_xmm_m64
				0x00120002, 0x00029005, 0x0000F25E,// EVEX_Vmovlpd_xmm_xmm_m64
				0x00120000, 0x00008006, 0x00003263,// Movsldup_xmm_xmmm128
				0x00120001, 0x00004C06, 0x00000962,// VEX_Vmovsldup_xmm_xmmm128
				0x00120001, 0x00005006, 0x000009A3,// VEX_Vmovsldup_ymm_ymmm256
				0x00120002, 0x0301C006, 0x0000085E,// EVEX_Vmovsldup_xmm_k1z_xmmm128
				0x00120002, 0x03020406, 0x0000089F,// EVEX_Vmovsldup_ymm_k1z_ymmm256
				0x00120002, 0x03024806, 0x000008E0,// EVEX_Vmovsldup_zmm_k1z_zmmm512
				0x00120000, 0x00008007, 0x00003263,// Movddup_xmm_xmmm64
				0x00120001, 0x00004C07, 0x00000962,// VEX_Vmovddup_xmm_xmmm64
				0x00120001, 0x00005007, 0x000009A3,// VEX_Vmovddup_ymm_ymmm256
				0x00120002, 0x0307D007, 0x0000085E,// EVEX_Vmovddup_xmm_k1z_xmmm64
				0x00120002, 0x03081407, 0x0000089F,// EVEX_Vmovddup_ymm_k1z_ymmm256
				0x00120002, 0x03085807, 0x000008E0,// EVEX_Vmovddup_zmm_k1z_zmmm512
				0x00130000, 0x00008004, 0x00003183,// Movlps_m64_xmm
				0x00130001, 0x00004C04, 0x00000896,// VEX_Vmovlps_m64_xmm
				0x00130002, 0x00044004, 0x0000078F,// EVEX_Vmovlps_m64_xmm
				0x00130000, 0x00008005, 0x00003183,// Movlpd_m64_xmm
				0x00130001, 0x00004C05, 0x00000896,// VEX_Vmovlpd_m64_xmm
				0x00130002, 0x00029005, 0x0000078F,// EVEX_Vmovlpd_m64_xmm
				0x00140000, 0x00008004, 0x00003263,// Unpcklps_xmm_xmmm128
				0x00140001, 0x00004C04, 0x000253A2,// VEX_Vunpcklps_xmm_xmm_xmmm128
				0x00140001, 0x00005004, 0x000263E3,// VEX_Vunpcklps_ymm_ymm_ymmm256
				0x00140002, 0x03204004, 0x0002125E,// EVEX_Vunpcklps_xmm_k1z_xmm_xmmm128b32
				0x00140002, 0x03208404, 0x0002229F,// EVEX_Vunpcklps_ymm_k1z_ymm_ymmm256b32
				0x00140002, 0x0320C804, 0x000232E0,// EVEX_Vunpcklps_zmm_k1z_zmm_zmmm512b32
				0x00140000, 0x00008005, 0x00003263,// Unpcklpd_xmm_xmmm128
				0x00140001, 0x00004C05, 0x000253A2,// VEX_Vunpcklpd_xmm_xmm_xmmm128
				0x00140001, 0x00005005, 0x000263E3,// VEX_Vunpcklpd_ymm_ymm_ymmm256
				0x00140002, 0x03205005, 0x0002125E,// EVEX_Vunpcklpd_xmm_k1z_xmm_xmmm128b64
				0x00140002, 0x03209405, 0x0002229F,// EVEX_Vunpcklpd_ymm_k1z_ymm_ymmm256b64
				0x00140002, 0x0320D805, 0x000232E0,// EVEX_Vunpcklpd_zmm_k1z_zmm_zmmm512b64
				0x00150000, 0x00008004, 0x00003263,// Unpckhps_xmm_xmmm128
				0x00150001, 0x00004C04, 0x000253A2,// VEX_Vunpckhps_xmm_xmm_xmmm128
				0x00150001, 0x00005004, 0x000263E3,// VEX_Vunpckhps_ymm_ymm_ymmm256
				0x00150002, 0x03204004, 0x0002125E,// EVEX_Vunpckhps_xmm_k1z_xmm_xmmm128b32
				0x00150002, 0x03208404, 0x0002229F,// EVEX_Vunpckhps_ymm_k1z_ymm_ymmm256b32
				0x00150002, 0x0320C804, 0x000232E0,// EVEX_Vunpckhps_zmm_k1z_zmm_zmmm512b32
				0x00150000, 0x00008005, 0x00003263,// Unpckhpd_xmm_xmmm128
				0x00150001, 0x00004C05, 0x000253A2,// VEX_Vunpckhpd_xmm_xmm_xmmm128
				0x00150001, 0x00005005, 0x000263E3,// VEX_Vunpckhpd_ymm_ymm_ymmm256
				0x00150002, 0x03205005, 0x0002125E,// EVEX_Vunpckhpd_xmm_k1z_xmm_xmmm128b64
				0x00150002, 0x03209405, 0x0002229F,// EVEX_Vunpckhpd_ymm_k1z_ymm_ymmm256b64
				0x00150002, 0x0320D805, 0x000232E0,// EVEX_Vunpckhpd_zmm_k1z_zmm_zmmm512b64
				0x00160000, 0x00008004, 0x00003163,// Movlhps_xmm_xmm
				0x00160001, 0x00004C04, 0x0001B3A2,// VEX_Vmovlhps_xmm_xmm_xmm
				0x00160002, 0x00044004, 0x0001225E,// EVEX_Vmovlhps_xmm_xmm_xmm
				0x00160000, 0x00008004, 0x000001E3,// Movhps_xmm_m64
				0x00160001, 0x00004C04, 0x000163A2,// VEX_Vmovhps_xmm_xmm_m64
				0x00160002, 0x00044004, 0x0000F25E,// EVEX_Vmovhps_xmm_xmm_m64
				0x00160000, 0x00008005, 0x000001E3,// Movhpd_xmm_m64
				0x00160001, 0x00004C05, 0x000163A2,// VEX_Vmovhpd_xmm_xmm_m64
				0x00160002, 0x00029005, 0x0000F25E,// EVEX_Vmovhpd_xmm_xmm_m64
				0x00160000, 0x00008006, 0x00003263,// Movshdup_xmm_xmmm128
				0x00160001, 0x00004C06, 0x00000962,// VEX_Vmovshdup_xmm_xmmm128
				0x00160001, 0x00005006, 0x000009A3,// VEX_Vmovshdup_ymm_ymmm256
				0x00160002, 0x0301C006, 0x0000085E,// EVEX_Vmovshdup_xmm_k1z_xmmm128
				0x00160002, 0x03020406, 0x0000089F,// EVEX_Vmovshdup_ymm_k1z_ymmm256
				0x00160002, 0x03024806, 0x000008E0,// EVEX_Vmovshdup_zmm_k1z_zmmm512
				0x00170000, 0x00008004, 0x00003183,// Movhps_m64_xmm
				0x00170001, 0x00004C04, 0x00000896,// VEX_Vmovhps_m64_xmm
				0x00170002, 0x00044004, 0x0000078F,// EVEX_Vmovhps_m64_xmm
				0x00170000, 0x00008005, 0x00003183,// Movhpd_m64_xmm
				0x00170001, 0x00004C05, 0x00000896,// VEX_Vmovhpd_m64_xmm
				0x00170002, 0x00029005, 0x0000078F,// EVEX_Vmovhpd_m64_xmm
				0x00180000, 0x00010004, 0x0000151B,// ReservedNop_rm16_r16_0F18
				0x00180000, 0x00020004, 0x0000159C,// ReservedNop_rm32_r32_0F18
				0x00180000, 0x00030024, 0x00001620,// ReservedNop_rm64_r64_0F18
				0x00190000, 0x00010004, 0x0000151B,// ReservedNop_rm16_r16_0F19
				0x00190000, 0x00020004, 0x0000159C,// ReservedNop_rm32_r32_0F19
				0x00190000, 0x00030024, 0x00001620,// ReservedNop_rm64_r64_0F19
				0x001A0000, 0x00010004, 0x0000151B,// ReservedNop_rm16_r16_0F1A
				0x001A0000, 0x00020004, 0x0000159C,// ReservedNop_rm32_r32_0F1A
				0x001A0000, 0x00030024, 0x00001620,// ReservedNop_rm64_r64_0F1A
				0x001B0000, 0x00010004, 0x0000151B,// ReservedNop_rm16_r16_0F1B
				0x001B0000, 0x00020004, 0x0000159C,// ReservedNop_rm32_r32_0F1B
				0x001B0000, 0x00030024, 0x00001620,// ReservedNop_rm64_r64_0F1B
				0x001C0000, 0x00010004, 0x0000151B,// ReservedNop_rm16_r16_0F1C
				0x001C0000, 0x00020004, 0x0000159C,// ReservedNop_rm32_r32_0F1C
				0x001C0000, 0x00030024, 0x00001620,// ReservedNop_rm64_r64_0F1C
				0x001D0000, 0x00010004, 0x0000151B,// ReservedNop_rm16_r16_0F1D
				0x001D0000, 0x00020004, 0x0000159C,// ReservedNop_rm32_r32_0F1D
				0x001D0000, 0x00030024, 0x00001620,// ReservedNop_rm64_r64_0F1D
				0x001E0000, 0x00010004, 0x0000151B,// ReservedNop_rm16_r16_0F1E
				0x001E0000, 0x00020004, 0x0000159C,// ReservedNop_rm32_r32_0F1E
				0x001E0000, 0x00030024, 0x00001620,// ReservedNop_rm64_r64_0F1E
				0x001F0000, 0x00010004, 0x0000151B,// ReservedNop_rm16_r16_0F1F
				0x001F0000, 0x00020004, 0x0000159C,// ReservedNop_rm32_r32_0F1F
				0x001F0000, 0x00030024, 0x00001620,// ReservedNop_rm64_r64_0F1F
				0x00180000, 0x00000044, 0x00000012,// Prefetchnta_m8
				0x00180000, 0x000000C4, 0x00000012,// Prefetcht0_m8
				0x00180000, 0x00000144, 0x00000012,// Prefetcht1_m8
				0x00180000, 0x000001C4, 0x00000012,// Prefetcht2_m8
				0x001A0000, 0x00008004, 0x00002F5B,// Bndldx_bnd_mib
				0x001A0000, 0x00008015, 0x00002E5B,// Bndmov_bnd_bndm64
				0x001A0000, 0x00008025, 0x00002EDB,// Bndmov_bnd_bndm128
				0x001A0000, 0x00008016, 0x00000EDB,// Bndcl_bnd_rm32
				0x001A0000, 0x00008026, 0x000010DB,// Bndcl_bnd_rm64
				0x001A0000, 0x00008017, 0x00000EDB,// Bndcu_bnd_rm32
				0x001A0000, 0x00008027, 0x000010DB,// Bndcu_bnd_rm64
				0x001B0000, 0x00008004, 0x00002DDE,// Bndstx_mib_bnd
				0x001B0000, 0x00008015, 0x00002DDC,// Bndmov_bndm64_bnd
				0x001B0000, 0x00008025, 0x00002DDD,// Bndmov_bndm128_bnd
				0x001B0000, 0x00008016, 0x00000ADB,// Bndmk_bnd_m32
				0x001B0000, 0x00008026, 0x00000BDB,// Bndmk_bnd_m64
				0x001B0000, 0x00008017, 0x00000EDB,// Bndcn_bnd_rm32
				0x001B0000, 0x00008027, 0x000010DB,// Bndcn_bnd_rm64
				0x001C0000, 0x00008044, 0x00000012,// Cldemote_m8
				0x001E0000, 0x000080C6, 0x00000031,// Rdsspd_r32
				0x001E0000, 0x000380E6, 0x00000032,// Rdsspq_r64
				0x1EFA0000, 0x00008006, 0x00000000,// Endbr64
				0x1EFB0000, 0x00008006, 0x00000000,// Endbr32
				0x001F0000, 0x00010044, 0x0000001B,// Nop_rm16
				0x001F0000, 0x00020044, 0x0000001C,// Nop_rm32
				0x001F0000, 0x00030064, 0x00000020,// Nop_rm64
				0x00200000, 0x00000014, 0x00001A31,// Mov_r32_cr
				0x00200000, 0x00000024, 0x00001AB2,// Mov_r64_cr
				0x00210000, 0x00000014, 0x00001B31,// Mov_r32_dr
				0x00210000, 0x00000024, 0x00001BB2,// Mov_r64_dr
				0x00220000, 0x00000014, 0x000018B4,// Mov_cr_r32
				0x00220000, 0x00000024, 0x00001935,// Mov_cr_r64
				0x00230000, 0x00000014, 0x000018B6,// Mov_dr_r32
				0x00230000, 0x00000024, 0x00001937,// Mov_dr_r64
				0x00240000, 0x00000014, 0x00001C31,// Mov_r32_tr
				0x00260000, 0x00000014, 0x000018B8,// Mov_tr_r32
				0x00280000, 0x00008004, 0x00003263,// Movaps_xmm_xmmm128
				0x00280001, 0x00004C04, 0x00000962,// VEX_Vmovaps_xmm_xmmm128
				0x00280001, 0x00005004, 0x000009A3,// VEX_Vmovaps_ymm_ymmm256
				0x00280002, 0x0301C004, 0x0000085E,// EVEX_Vmovaps_xmm_k1z_xmmm128
				0x00280002, 0x03020404, 0x0000089F,// EVEX_Vmovaps_ymm_k1z_ymmm256
				0x00280002, 0x03024804, 0x000008E0,// EVEX_Vmovaps_zmm_k1z_zmmm512
				0x00280000, 0x00008005, 0x00003263,// Movapd_xmm_xmmm128
				0x00280001, 0x00004C05, 0x00000962,// VEX_Vmovapd_xmm_xmmm128
				0x00280001, 0x00005005, 0x000009A3,// VEX_Vmovapd_ymm_ymmm256
				0x00280002, 0x0301D005, 0x0000085E,// EVEX_Vmovapd_xmm_k1z_xmmm128
				0x00280002, 0x03021405, 0x0000089F,// EVEX_Vmovapd_ymm_k1z_ymmm256
				0x00280002, 0x03025805, 0x000008E0,// EVEX_Vmovapd_zmm_k1z_zmmm512
				0x00290000, 0x00008004, 0x000031E4,// Movaps_xmmm128_xmm
				0x00290001, 0x00004C04, 0x000008A5,// VEX_Vmovaps_xmmm128_xmm
				0x00290001, 0x00005004, 0x000008E6,// VEX_Vmovaps_ymmm256_ymm
				0x00290002, 0x0301C004, 0x000007A1,// EVEX_Vmovaps_xmmm128_k1z_xmm
				0x00290002, 0x03020404, 0x000007E2,// EVEX_Vmovaps_ymmm256_k1z_ymm
				0x00290002, 0x03024804, 0x00000823,// EVEX_Vmovaps_zmmm512_k1z_zmm
				0x00290000, 0x00008005, 0x000031E4,// Movapd_xmmm128_xmm
				0x00290001, 0x00004C05, 0x000008A5,// VEX_Vmovapd_xmmm128_xmm
				0x00290001, 0x00005005, 0x000008E6,// VEX_Vmovapd_ymmm256_ymm
				0x00290002, 0x0301D005, 0x000007A1,// EVEX_Vmovapd_xmmm128_k1z_xmm
				0x00290002, 0x03021405, 0x000007E2,// EVEX_Vmovapd_ymmm256_k1z_ymm
				0x00290002, 0x03025805, 0x00000823,// EVEX_Vmovapd_zmmm512_k1z_zmm
				0x002A0000, 0x00008004, 0x000030E3,// Cvtpi2ps_xmm_mmm64
				0x002A0000, 0x00008005, 0x000030E3,// Cvtpi2pd_xmm_mmm64
				0x002A0000, 0x00008006, 0x00000E63,// Cvtsi2ss_xmm_rm32
				0x002A0000, 0x00038026, 0x00001063,// Cvtsi2ss_xmm_rm64
				0x002A0001, 0x00007406, 0x000013A2,// VEX_Vcvtsi2ss_xmm_xmm_rm32
				0x002A0001, 0x00003426, 0x000023A2,// VEX_Vcvtsi2ss_xmm_xmm_rm64
				0x002A0002, 0x0052B006, 0x0000125E,// EVEX_Vcvtsi2ss_xmm_xmm_rm32_er
				0x002A0002, 0x00529026, 0x0000225E,// EVEX_Vcvtsi2ss_xmm_xmm_rm64_er
				0x002A0000, 0x00008007, 0x00000E63,// Cvtsi2sd_xmm_rm32
				0x002A0000, 0x00038027, 0x00001063,// Cvtsi2sd_xmm_rm64
				0x002A0001, 0x00007407, 0x000013A2,// VEX_Vcvtsi2sd_xmm_xmm_rm32
				0x002A0001, 0x00003427, 0x000023A2,// VEX_Vcvtsi2sd_xmm_xmm_rm64
				0x002A0002, 0x0052B007, 0x0000125E,// EVEX_Vcvtsi2sd_xmm_xmm_rm32_er
				0x002A0002, 0x00529027, 0x0000225E,// EVEX_Vcvtsi2sd_xmm_xmm_rm64_er
				0x002B0000, 0x00008004, 0x00003183,// Movntps_m128_xmm
				0x002B0001, 0x00004C04, 0x00000896,// VEX_Vmovntps_m128_xmm
				0x002B0001, 0x00005004, 0x000008D6,// VEX_Vmovntps_m256_ymm
				0x002B0002, 0x0001C004, 0x0000078F,// EVEX_Vmovntps_m128_xmm
				0x002B0002, 0x00020404, 0x000007CF,// EVEX_Vmovntps_m256_ymm
				0x002B0002, 0x00024804, 0x0000080F,// EVEX_Vmovntps_m512_zmm
				0x002B0000, 0x00008005, 0x00003183,// Movntpd_m128_xmm
				0x002B0001, 0x00004C05, 0x00000896,// VEX_Vmovntpd_m128_xmm
				0x002B0001, 0x00005005, 0x000008D6,// VEX_Vmovntpd_m256_ymm
				0x002B0002, 0x0001D005, 0x0000078F,// EVEX_Vmovntpd_m128_xmm
				0x002B0002, 0x00021405, 0x000007CF,// EVEX_Vmovntpd_m256_ymm
				0x002B0002, 0x00025805, 0x0000080F,// EVEX_Vmovntpd_m512_zmm
				0x002B0000, 0x00008006, 0x00003183,// Movntss_m32_xmm
				0x002B0000, 0x00008007, 0x00003183,// Movntsd_m64_xmm
				0x002C0000, 0x00008004, 0x00003260,// Cvttps2pi_mm_xmmm64
				0x002C0000, 0x00008005, 0x00003260,// Cvttpd2pi_mm_xmmm128
				0x002C0000, 0x00008006, 0x0000322B,// Cvttss2si_r32_xmmm32
				0x002C0000, 0x00038026, 0x0000322C,// Cvttss2si_r64_xmmm32
				0x002C0001, 0x00007406, 0x00000943,// VEX_Vcvttss2si_r32_xmmm32
				0x002C0001, 0x00003426, 0x00000944,// VEX_Vcvttss2si_r64_xmmm32
				0x002C0002, 0x00937006, 0x00000843,// EVEX_Vcvttss2si_r32_xmmm32_sae
				0x002C0002, 0x00935026, 0x00000844,// EVEX_Vcvttss2si_r64_xmmm32_sae
				0x002C0000, 0x00008007, 0x0000322B,// Cvttsd2si_r32_xmmm64
				0x002C0000, 0x00038027, 0x0000322C,// Cvttsd2si_r64_xmmm64
				0x002C0001, 0x00007407, 0x00000943,// VEX_Vcvttsd2si_r32_xmmm64
				0x002C0001, 0x00003427, 0x00000944,// VEX_Vcvttsd2si_r64_xmmm64
				0x002C0002, 0x0093B007, 0x00000843,// EVEX_Vcvttsd2si_r32_xmmm64_sae
				0x002C0002, 0x00939027, 0x00000844,// EVEX_Vcvttsd2si_r64_xmmm64_sae
				0x002D0000, 0x00008004, 0x00003260,// Cvtps2pi_mm_xmmm64
				0x002D0000, 0x00008005, 0x00003260,// Cvtpd2pi_mm_xmmm128
				0x002D0000, 0x00008006, 0x0000322B,// Cvtss2si_r32_xmmm32
				0x002D0000, 0x00038026, 0x0000322C,// Cvtss2si_r64_xmmm32
				0x002D0001, 0x00007406, 0x00000943,// VEX_Vcvtss2si_r32_xmmm32
				0x002D0001, 0x00003426, 0x00000944,// VEX_Vcvtss2si_r64_xmmm32
				0x002D0002, 0x00537006, 0x00000843,// EVEX_Vcvtss2si_r32_xmmm32_er
				0x002D0002, 0x00535026, 0x00000844,// EVEX_Vcvtss2si_r64_xmmm32_er
				0x002D0000, 0x00008007, 0x0000322B,// Cvtsd2si_r32_xmmm64
				0x002D0000, 0x00038027, 0x0000322C,// Cvtsd2si_r64_xmmm64
				0x002D0001, 0x00007407, 0x00000943,// VEX_Vcvtsd2si_r32_xmmm64
				0x002D0001, 0x00003427, 0x00000944,// VEX_Vcvtsd2si_r64_xmmm64
				0x002D0002, 0x0053B007, 0x00000843,// EVEX_Vcvtsd2si_r32_xmmm64_er
				0x002D0002, 0x00539027, 0x00000844,// EVEX_Vcvtsd2si_r64_xmmm64_er
				0x002E0000, 0x00008004, 0x00003263,// Ucomiss_xmm_xmmm32
				0x002E0001, 0x00005404, 0x00000962,// VEX_Vucomiss_xmm_xmmm32
				0x002E0002, 0x00928004, 0x0000085E,// EVEX_Vucomiss_xmm_xmmm32_sae
				0x002E0000, 0x00008005, 0x00003263,// Ucomisd_xmm_xmmm64
				0x002E0001, 0x00005405, 0x00000962,// VEX_Vucomisd_xmm_xmmm64
				0x002E0002, 0x00929005, 0x0000085E,// EVEX_Vucomisd_xmm_xmmm64_sae
				0x002F0000, 0x00008004, 0x00003263,// Comiss_xmm_xmmm32
				0x002F0000, 0x00008005, 0x00003263,// Comisd_xmm_xmmm64
				0x002F0001, 0x00005404, 0x00000962,// VEX_Vcomiss_xmm_xmmm32
				0x002F0001, 0x00005405, 0x00000962,// VEX_Vcomisd_xmm_xmmm64
				0x002F0002, 0x00928004, 0x0000085E,// EVEX_Vcomiss_xmm_xmmm32_sae
				0x002F0002, 0x00929005, 0x0000085E,// EVEX_Vcomisd_xmm_xmmm64_sae
				0x00300000, 0x00000004, 0x00000000,// Wrmsr
				0x00310000, 0x00000004, 0x00000000,// Rdtsc
				0x00320000, 0x00000004, 0x00000000,// Rdmsr
				0x00330000, 0x00000004, 0x00000000,// Rdpmc
				0x00340000, 0x00000004, 0x00000000,// Sysenter
				0x00350000, 0x00000004, 0x00000000,// Sysexitd
				0x00350000, 0x00030024, 0x00000000,// Sysexitq
				0x00370000, 0x00008004, 0x00000000,// Getsec
				0x00400000, 0x00010004, 0x00000DAA,// Cmovo_r16_rm16
				0x00400000, 0x00020004, 0x00000E2B,// Cmovo_r32_rm32
				0x00400000, 0x00030024, 0x0000102C,// Cmovo_r64_rm64
				0x00410000, 0x00010004, 0x00000DAA,// Cmovno_r16_rm16
				0x00410000, 0x00020004, 0x00000E2B,// Cmovno_r32_rm32
				0x00410000, 0x00030024, 0x0000102C,// Cmovno_r64_rm64
				0x00420000, 0x00010004, 0x00000DAA,// Cmovb_r16_rm16
				0x00420000, 0x00020004, 0x00000E2B,// Cmovb_r32_rm32
				0x00420000, 0x00030024, 0x0000102C,// Cmovb_r64_rm64
				0x00430000, 0x00010004, 0x00000DAA,// Cmovae_r16_rm16
				0x00430000, 0x00020004, 0x00000E2B,// Cmovae_r32_rm32
				0x00430000, 0x00030024, 0x0000102C,// Cmovae_r64_rm64
				0x00440000, 0x00010004, 0x00000DAA,// Cmove_r16_rm16
				0x00440000, 0x00020004, 0x00000E2B,// Cmove_r32_rm32
				0x00440000, 0x00030024, 0x0000102C,// Cmove_r64_rm64
				0x00450000, 0x00010004, 0x00000DAA,// Cmovne_r16_rm16
				0x00450000, 0x00020004, 0x00000E2B,// Cmovne_r32_rm32
				0x00450000, 0x00030024, 0x0000102C,// Cmovne_r64_rm64
				0x00460000, 0x00010004, 0x00000DAA,// Cmovbe_r16_rm16
				0x00460000, 0x00020004, 0x00000E2B,// Cmovbe_r32_rm32
				0x00460000, 0x00030024, 0x0000102C,// Cmovbe_r64_rm64
				0x00470000, 0x00010004, 0x00000DAA,// Cmova_r16_rm16
				0x00470000, 0x00020004, 0x00000E2B,// Cmova_r32_rm32
				0x00470000, 0x00030024, 0x0000102C,// Cmova_r64_rm64
				0x00480000, 0x00010004, 0x00000DAA,// Cmovs_r16_rm16
				0x00480000, 0x00020004, 0x00000E2B,// Cmovs_r32_rm32
				0x00480000, 0x00030024, 0x0000102C,// Cmovs_r64_rm64
				0x00490000, 0x00010004, 0x00000DAA,// Cmovns_r16_rm16
				0x00490000, 0x00020004, 0x00000E2B,// Cmovns_r32_rm32
				0x00490000, 0x00030024, 0x0000102C,// Cmovns_r64_rm64
				0x004A0000, 0x00010004, 0x00000DAA,// Cmovp_r16_rm16
				0x004A0000, 0x00020004, 0x00000E2B,// Cmovp_r32_rm32
				0x004A0000, 0x00030024, 0x0000102C,// Cmovp_r64_rm64
				0x004B0000, 0x00010004, 0x00000DAA,// Cmovnp_r16_rm16
				0x004B0000, 0x00020004, 0x00000E2B,// Cmovnp_r32_rm32
				0x004B0000, 0x00030024, 0x0000102C,// Cmovnp_r64_rm64
				0x004C0000, 0x00010004, 0x00000DAA,// Cmovl_r16_rm16
				0x004C0000, 0x00020004, 0x00000E2B,// Cmovl_r32_rm32
				0x004C0000, 0x00030024, 0x0000102C,// Cmovl_r64_rm64
				0x004D0000, 0x00010004, 0x00000DAA,// Cmovge_r16_rm16
				0x004D0000, 0x00020004, 0x00000E2B,// Cmovge_r32_rm32
				0x004D0000, 0x00030024, 0x0000102C,// Cmovge_r64_rm64
				0x004E0000, 0x00010004, 0x00000DAA,// Cmovle_r16_rm16
				0x004E0000, 0x00020004, 0x00000E2B,// Cmovle_r32_rm32
				0x004E0000, 0x00030024, 0x0000102C,// Cmovle_r64_rm64
				0x004F0000, 0x00010004, 0x00000DAA,// Cmovg_r16_rm16
				0x004F0000, 0x00020004, 0x00000E2B,// Cmovg_r32_rm32
				0x004F0000, 0x00030024, 0x0000102C,// Cmovg_r64_rm64
				0x00410001, 0x00000804, 0x0001A35D,// VEX_Kandw_k_k_k
				0x00410001, 0x00002804, 0x0001A35D,// VEX_Kandq_k_k_k
				0x00410001, 0x00000805, 0x0001A35D,// VEX_Kandb_k_k_k
				0x00410001, 0x00002805, 0x0001A35D,// VEX_Kandd_k_k_k
				0x00420001, 0x00000804, 0x0001A35D,// VEX_Kandnw_k_k_k
				0x00420001, 0x00002804, 0x0001A35D,// VEX_Kandnq_k_k_k
				0x00420001, 0x00000805, 0x0001A35D,// VEX_Kandnb_k_k_k
				0x00420001, 0x00002805, 0x0001A35D,// VEX_Kandnd_k_k_k
				0x00440001, 0x00000404, 0x0000069D,// VEX_Knotw_k_k
				0x00440001, 0x00002404, 0x0000069D,// VEX_Knotq_k_k
				0x00440001, 0x00000405, 0x0000069D,// VEX_Knotb_k_k
				0x00440001, 0x00002405, 0x0000069D,// VEX_Knotd_k_k
				0x00450001, 0x00000804, 0x0001A35D,// VEX_Korw_k_k_k
				0x00450001, 0x00002804, 0x0001A35D,// VEX_Korq_k_k_k
				0x00450001, 0x00000805, 0x0001A35D,// VEX_Korb_k_k_k
				0x00450001, 0x00002805, 0x0001A35D,// VEX_Kord_k_k_k
				0x00460001, 0x00000804, 0x0001A35D,// VEX_Kxnorw_k_k_k
				0x00460001, 0x00002804, 0x0001A35D,// VEX_Kxnorq_k_k_k
				0x00460001, 0x00000805, 0x0001A35D,// VEX_Kxnorb_k_k_k
				0x00460001, 0x00002805, 0x0001A35D,// VEX_Kxnord_k_k_k
				0x00470001, 0x00000804, 0x0001A35D,// VEX_Kxorw_k_k_k
				0x00470001, 0x00002804, 0x0001A35D,// VEX_Kxorq_k_k_k
				0x00470001, 0x00000805, 0x0001A35D,// VEX_Kxorb_k_k_k
				0x00470001, 0x00002805, 0x0001A35D,// VEX_Kxord_k_k_k
				0x004A0001, 0x00000804, 0x0001A35D,// VEX_Kaddw_k_k_k
				0x004A0001, 0x00002804, 0x0001A35D,// VEX_Kaddq_k_k_k
				0x004A0001, 0x00000805, 0x0001A35D,// VEX_Kaddb_k_k_k
				0x004A0001, 0x00002805, 0x0001A35D,// VEX_Kaddd_k_k_k
				0x004B0001, 0x00000804, 0x0001A35D,// VEX_Kunpckwd_k_k_k
				0x004B0001, 0x00002804, 0x0001A35D,// VEX_Kunpckdq_k_k_k
				0x004B0001, 0x00000805, 0x0001A35D,// VEX_Kunpckbw_k_k_k
				0x00500000, 0x00008004, 0x0000312B,// Movmskps_r32_xmm
				0x00500000, 0x00038024, 0x0000312C,// Movmskps_r64_xmm
				0x00500001, 0x00006C04, 0x000006C3,// VEX_Vmovmskps_r32_xmm
				0x00500001, 0x00002C24, 0x000006C4,// VEX_Vmovmskps_r64_xmm
				0x00500001, 0x00007004, 0x00000703,// VEX_Vmovmskps_r32_ymm
				0x00500001, 0x00003024, 0x00000704,// VEX_Vmovmskps_r64_ymm
				0x00500000, 0x00008005, 0x0000312B,// Movmskpd_r32_xmm
				0x00500000, 0x00038025, 0x0000312C,// Movmskpd_r64_xmm
				0x00500001, 0x00006C05, 0x000006C3,// VEX_Vmovmskpd_r32_xmm
				0x00500001, 0x00002C25, 0x000006C4,// VEX_Vmovmskpd_r64_xmm
				0x00500001, 0x00007005, 0x00000703,// VEX_Vmovmskpd_r32_ymm
				0x00500001, 0x00003025, 0x00000704,// VEX_Vmovmskpd_r64_ymm
				0x00510000, 0x00008004, 0x00003263,// Sqrtps_xmm_xmmm128
				0x00510001, 0x00004C04, 0x00000962,// VEX_Vsqrtps_xmm_xmmm128
				0x00510001, 0x00005004, 0x000009A3,// VEX_Vsqrtps_ymm_ymmm256
				0x00510002, 0x03204004, 0x0000085E,// EVEX_Vsqrtps_xmm_k1z_xmmm128b32
				0x00510002, 0x03208404, 0x0000089F,// EVEX_Vsqrtps_ymm_k1z_ymmm256b32
				0x00510002, 0x0360C804, 0x000008E0,// EVEX_Vsqrtps_zmm_k1z_zmmm512b32_er
				0x00510000, 0x00008005, 0x00003263,// Sqrtpd_xmm_xmmm128
				0x00510001, 0x00004C05, 0x00000962,// VEX_Vsqrtpd_xmm_xmmm128
				0x00510001, 0x00005005, 0x000009A3,// VEX_Vsqrtpd_ymm_ymmm256
				0x00510002, 0x03205005, 0x0000085E,// EVEX_Vsqrtpd_xmm_k1z_xmmm128b64
				0x00510002, 0x03209405, 0x0000089F,// EVEX_Vsqrtpd_ymm_k1z_ymmm256b64
				0x00510002, 0x0360D805, 0x000008E0,// EVEX_Vsqrtpd_zmm_k1z_zmmm512b64_er
				0x00510000, 0x00008006, 0x00003263,// Sqrtss_xmm_xmmm32
				0x00510001, 0x00005406, 0x000253A2,// VEX_Vsqrtss_xmm_xmm_xmmm32
				0x00510002, 0x03528006, 0x0002125E,// EVEX_Vsqrtss_xmm_k1z_xmm_xmmm32_er
				0x00510000, 0x00008007, 0x00003263,// Sqrtsd_xmm_xmmm64
				0x00510001, 0x00005407, 0x000253A2,// VEX_Vsqrtsd_xmm_xmm_xmmm64
				0x00510002, 0x03529007, 0x0002125E,// EVEX_Vsqrtsd_xmm_k1z_xmm_xmmm64_er
				0x00520000, 0x00008004, 0x00003263,// Rsqrtps_xmm_xmmm128
				0x00520001, 0x00004C04, 0x00000962,// VEX_Vrsqrtps_xmm_xmmm128
				0x00520001, 0x00005004, 0x000009A3,// VEX_Vrsqrtps_ymm_ymmm256
				0x00520000, 0x00008006, 0x00003263,// Rsqrtss_xmm_xmmm32
				0x00520001, 0x00005406, 0x000253A2,// VEX_Vrsqrtss_xmm_xmm_xmmm32
				0x00530000, 0x00008004, 0x00003263,// Rcpps_xmm_xmmm128
				0x00530001, 0x00004C04, 0x00000962,// VEX_Vrcpps_xmm_xmmm128
				0x00530001, 0x00005004, 0x000009A3,// VEX_Vrcpps_ymm_ymmm256
				0x00530000, 0x00008006, 0x00003263,// Rcpss_xmm_xmmm32
				0x00530001, 0x00005406, 0x000253A2,// VEX_Vrcpss_xmm_xmm_xmmm32
				0x00540000, 0x00008004, 0x00003263,// Andps_xmm_xmmm128
				0x00540001, 0x00004C04, 0x000253A2,// VEX_Vandps_xmm_xmm_xmmm128
				0x00540001, 0x00005004, 0x000263E3,// VEX_Vandps_ymm_ymm_ymmm256
				0x00540002, 0x03204004, 0x0002125E,// EVEX_Vandps_xmm_k1z_xmm_xmmm128b32
				0x00540002, 0x03208404, 0x0002229F,// EVEX_Vandps_ymm_k1z_ymm_ymmm256b32
				0x00540002, 0x0320C804, 0x000232E0,// EVEX_Vandps_zmm_k1z_zmm_zmmm512b32
				0x00540000, 0x00008005, 0x00003263,// Andpd_xmm_xmmm128
				0x00540001, 0x00004C05, 0x000253A2,// VEX_Vandpd_xmm_xmm_xmmm128
				0x00540001, 0x00005005, 0x000263E3,// VEX_Vandpd_ymm_ymm_ymmm256
				0x00540002, 0x03205005, 0x0002125E,// EVEX_Vandpd_xmm_k1z_xmm_xmmm128b64
				0x00540002, 0x03209405, 0x0002229F,// EVEX_Vandpd_ymm_k1z_ymm_ymmm256b64
				0x00540002, 0x0320D805, 0x000232E0,// EVEX_Vandpd_zmm_k1z_zmm_zmmm512b64
				0x00550000, 0x00008004, 0x00003263,// Andnps_xmm_xmmm128
				0x00550001, 0x00004C04, 0x000253A2,// VEX_Vandnps_xmm_xmm_xmmm128
				0x00550001, 0x00005004, 0x000263E3,// VEX_Vandnps_ymm_ymm_ymmm256
				0x00550002, 0x03204004, 0x0002125E,// EVEX_Vandnps_xmm_k1z_xmm_xmmm128b32
				0x00550002, 0x03208404, 0x0002229F,// EVEX_Vandnps_ymm_k1z_ymm_ymmm256b32
				0x00550002, 0x0320C804, 0x000232E0,// EVEX_Vandnps_zmm_k1z_zmm_zmmm512b32
				0x00550000, 0x00008005, 0x00003263,// Andnpd_xmm_xmmm128
				0x00550001, 0x00004C05, 0x000253A2,// VEX_Vandnpd_xmm_xmm_xmmm128
				0x00550001, 0x00005005, 0x000263E3,// VEX_Vandnpd_ymm_ymm_ymmm256
				0x00550002, 0x03205005, 0x0002125E,// EVEX_Vandnpd_xmm_k1z_xmm_xmmm128b64
				0x00550002, 0x03209405, 0x0002229F,// EVEX_Vandnpd_ymm_k1z_ymm_ymmm256b64
				0x00550002, 0x0320D805, 0x000232E0,// EVEX_Vandnpd_zmm_k1z_zmm_zmmm512b64
				0x00560000, 0x00008004, 0x00003263,// Orps_xmm_xmmm128
				0x00560001, 0x00004C04, 0x000253A2,// VEX_Vorps_xmm_xmm_xmmm128
				0x00560001, 0x00005004, 0x000263E3,// VEX_Vorps_ymm_ymm_ymmm256
				0x00560002, 0x03204004, 0x0002125E,// EVEX_Vorps_xmm_k1z_xmm_xmmm128b32
				0x00560002, 0x03208404, 0x0002229F,// EVEX_Vorps_ymm_k1z_ymm_ymmm256b32
				0x00560002, 0x0320C804, 0x000232E0,// EVEX_Vorps_zmm_k1z_zmm_zmmm512b32
				0x00560000, 0x00008005, 0x00003263,// Orpd_xmm_xmmm128
				0x00560001, 0x00004C05, 0x000253A2,// VEX_Vorpd_xmm_xmm_xmmm128
				0x00560001, 0x00005005, 0x000263E3,// VEX_Vorpd_ymm_ymm_ymmm256
				0x00560002, 0x03205005, 0x0002125E,// EVEX_Vorpd_xmm_k1z_xmm_xmmm128b64
				0x00560002, 0x03209405, 0x0002229F,// EVEX_Vorpd_ymm_k1z_ymm_ymmm256b64
				0x00560002, 0x0320D805, 0x000232E0,// EVEX_Vorpd_zmm_k1z_zmm_zmmm512b64
				0x00570000, 0x00008004, 0x00003263,// Xorps_xmm_xmmm128
				0x00570001, 0x00004C04, 0x000253A2,// VEX_Vxorps_xmm_xmm_xmmm128
				0x00570001, 0x00005004, 0x000263E3,// VEX_Vxorps_ymm_ymm_ymmm256
				0x00570002, 0x03204004, 0x0002125E,// EVEX_Vxorps_xmm_k1z_xmm_xmmm128b32
				0x00570002, 0x03208404, 0x0002229F,// EVEX_Vxorps_ymm_k1z_ymm_ymmm256b32
				0x00570002, 0x0320C804, 0x000232E0,// EVEX_Vxorps_zmm_k1z_zmm_zmmm512b32
				0x00570000, 0x00008005, 0x00003263,// Xorpd_xmm_xmmm128
				0x00570001, 0x00004C05, 0x000253A2,// VEX_Vxorpd_xmm_xmm_xmmm128
				0x00570001, 0x00005005, 0x000263E3,// VEX_Vxorpd_ymm_ymm_ymmm256
				0x00570002, 0x03205005, 0x0002125E,// EVEX_Vxorpd_xmm_k1z_xmm_xmmm128b64
				0x00570002, 0x03209405, 0x0002229F,// EVEX_Vxorpd_ymm_k1z_ymm_ymmm256b64
				0x00570002, 0x0320D805, 0x000232E0,// EVEX_Vxorpd_zmm_k1z_zmm_zmmm512b64
				0x00580000, 0x00008004, 0x00003263,// Addps_xmm_xmmm128
				0x00580001, 0x00004C04, 0x000253A2,// VEX_Vaddps_xmm_xmm_xmmm128
				0x00580001, 0x00005004, 0x000263E3,// VEX_Vaddps_ymm_ymm_ymmm256
				0x00580002, 0x03204004, 0x0002125E,// EVEX_Vaddps_xmm_k1z_xmm_xmmm128b32
				0x00580002, 0x03208404, 0x0002229F,// EVEX_Vaddps_ymm_k1z_ymm_ymmm256b32
				0x00580002, 0x0360C804, 0x000232E0,// EVEX_Vaddps_zmm_k1z_zmm_zmmm512b32_er
				0x00580000, 0x00008005, 0x00003263,// Addpd_xmm_xmmm128
				0x00580001, 0x00004C05, 0x000253A2,// VEX_Vaddpd_xmm_xmm_xmmm128
				0x00580001, 0x00005005, 0x000263E3,// VEX_Vaddpd_ymm_ymm_ymmm256
				0x00580002, 0x03205005, 0x0002125E,// EVEX_Vaddpd_xmm_k1z_xmm_xmmm128b64
				0x00580002, 0x03209405, 0x0002229F,// EVEX_Vaddpd_ymm_k1z_ymm_ymmm256b64
				0x00580002, 0x0360D805, 0x000232E0,// EVEX_Vaddpd_zmm_k1z_zmm_zmmm512b64_er
				0x00580000, 0x00008006, 0x00003263,// Addss_xmm_xmmm32
				0x00580001, 0x00005406, 0x000253A2,// VEX_Vaddss_xmm_xmm_xmmm32
				0x00580002, 0x03528006, 0x0002125E,// EVEX_Vaddss_xmm_k1z_xmm_xmmm32_er
				0x00580000, 0x00008007, 0x00003263,// Addsd_xmm_xmmm64
				0x00580001, 0x00005407, 0x000253A2,// VEX_Vaddsd_xmm_xmm_xmmm64
				0x00580002, 0x03529007, 0x0002125E,// EVEX_Vaddsd_xmm_k1z_xmm_xmmm64_er
				0x00590000, 0x00008004, 0x00003263,// Mulps_xmm_xmmm128
				0x00590001, 0x00004C04, 0x000253A2,// VEX_Vmulps_xmm_xmm_xmmm128
				0x00590001, 0x00005004, 0x000263E3,// VEX_Vmulps_ymm_ymm_ymmm256
				0x00590002, 0x03204004, 0x0002125E,// EVEX_Vmulps_xmm_k1z_xmm_xmmm128b32
				0x00590002, 0x03208404, 0x0002229F,// EVEX_Vmulps_ymm_k1z_ymm_ymmm256b32
				0x00590002, 0x0360C804, 0x000232E0,// EVEX_Vmulps_zmm_k1z_zmm_zmmm512b32_er
				0x00590000, 0x00008005, 0x00003263,// Mulpd_xmm_xmmm128
				0x00590001, 0x00004C05, 0x000253A2,// VEX_Vmulpd_xmm_xmm_xmmm128
				0x00590001, 0x00005005, 0x000263E3,// VEX_Vmulpd_ymm_ymm_ymmm256
				0x00590002, 0x03205005, 0x0002125E,// EVEX_Vmulpd_xmm_k1z_xmm_xmmm128b64
				0x00590002, 0x03209405, 0x0002229F,// EVEX_Vmulpd_ymm_k1z_ymm_ymmm256b64
				0x00590002, 0x0360D805, 0x000232E0,// EVEX_Vmulpd_zmm_k1z_zmm_zmmm512b64_er
				0x00590000, 0x00008006, 0x00003263,// Mulss_xmm_xmmm32
				0x00590001, 0x00005406, 0x000253A2,// VEX_Vmulss_xmm_xmm_xmmm32
				0x00590002, 0x03528006, 0x0002125E,// EVEX_Vmulss_xmm_k1z_xmm_xmmm32_er
				0x00590000, 0x00008007, 0x00003263,// Mulsd_xmm_xmmm64
				0x00590001, 0x00005407, 0x000253A2,// VEX_Vmulsd_xmm_xmm_xmmm64
				0x00590002, 0x03529007, 0x0002125E,// EVEX_Vmulsd_xmm_k1z_xmm_xmmm64_er
				0x005A0000, 0x00008004, 0x00003263,// Cvtps2pd_xmm_xmmm64
				0x005A0001, 0x00004C04, 0x00000962,// VEX_Vcvtps2pd_xmm_xmmm64
				0x005A0001, 0x00005004, 0x00000963,// VEX_Vcvtps2pd_ymm_xmmm128
				0x005A0002, 0x03210004, 0x0000085E,// EVEX_Vcvtps2pd_xmm_k1z_xmmm64b32
				0x005A0002, 0x03214404, 0x0000085F,// EVEX_Vcvtps2pd_ymm_k1z_xmmm128b32
				0x005A0002, 0x03A18804, 0x000008A0,// EVEX_Vcvtps2pd_zmm_k1z_ymmm256b32_sae
				0x005A0000, 0x00008005, 0x00003263,// Cvtpd2ps_xmm_xmmm128
				0x005A0001, 0x00004C05, 0x00000962,// VEX_Vcvtpd2ps_xmm_xmmm128
				0x005A0001, 0x00005005, 0x000009A2,// VEX_Vcvtpd2ps_xmm_ymmm256
				0x005A0002, 0x03205005, 0x0000085E,// EVEX_Vcvtpd2ps_xmm_k1z_xmmm128b64
				0x005A0002, 0x03209405, 0x0000089E,// EVEX_Vcvtpd2ps_xmm_k1z_ymmm256b64
				0x005A0002, 0x0360D805, 0x000008DF,// EVEX_Vcvtpd2ps_ymm_k1z_zmmm512b64_er
				0x005A0000, 0x00008006, 0x00003263,// Cvtss2sd_xmm_xmmm32
				0x005A0001, 0x00005406, 0x000253A2,// VEX_Vcvtss2sd_xmm_xmm_xmmm32
				0x005A0002, 0x03928006, 0x0002125E,// EVEX_Vcvtss2sd_xmm_k1z_xmm_xmmm32_sae
				0x005A0000, 0x00008007, 0x00003263,// Cvtsd2ss_xmm_xmmm64
				0x005A0001, 0x00005407, 0x000253A2,// VEX_Vcvtsd2ss_xmm_xmm_xmmm64
				0x005A0002, 0x03529007, 0x0002125E,// EVEX_Vcvtsd2ss_xmm_k1z_xmm_xmmm64_er
				0x005B0000, 0x00008004, 0x00003263,// Cvtdq2ps_xmm_xmmm128
				0x005B0001, 0x00004C04, 0x00000962,// VEX_Vcvtdq2ps_xmm_xmmm128
				0x005B0001, 0x00005004, 0x000009A3,// VEX_Vcvtdq2ps_ymm_ymmm256
				0x005B0002, 0x03204004, 0x0000085E,// EVEX_Vcvtdq2ps_xmm_k1z_xmmm128b32
				0x005B0002, 0x03208404, 0x0000089F,// EVEX_Vcvtdq2ps_ymm_k1z_ymmm256b32
				0x005B0002, 0x0360C804, 0x000008E0,// EVEX_Vcvtdq2ps_zmm_k1z_zmmm512b32_er
				0x005B0002, 0x03205004, 0x0000085E,// EVEX_Vcvtqq2ps_xmm_k1z_xmmm128b64
				0x005B0002, 0x03209404, 0x0000089E,// EVEX_Vcvtqq2ps_xmm_k1z_ymmm256b64
				0x005B0002, 0x0360D804, 0x000008DF,// EVEX_Vcvtqq2ps_ymm_k1z_zmmm512b64_er
				0x005B0000, 0x00008005, 0x00003263,// Cvtps2dq_xmm_xmmm128
				0x005B0001, 0x00004C05, 0x00000962,// VEX_Vcvtps2dq_xmm_xmmm128
				0x005B0001, 0x00005005, 0x000009A3,// VEX_Vcvtps2dq_ymm_ymmm256
				0x005B0002, 0x03204005, 0x0000085E,// EVEX_Vcvtps2dq_xmm_k1z_xmmm128b32
				0x005B0002, 0x03208405, 0x0000089F,// EVEX_Vcvtps2dq_ymm_k1z_ymmm256b32
				0x005B0002, 0x0360C805, 0x000008E0,// EVEX_Vcvtps2dq_zmm_k1z_zmmm512b32_er
				0x005B0000, 0x00008006, 0x00003263,// Cvttps2dq_xmm_xmmm128
				0x005B0001, 0x00004C06, 0x00000962,// VEX_Vcvttps2dq_xmm_xmmm128
				0x005B0001, 0x00005006, 0x000009A3,// VEX_Vcvttps2dq_ymm_ymmm256
				0x005B0002, 0x03204006, 0x0000085E,// EVEX_Vcvttps2dq_xmm_k1z_xmmm128b32
				0x005B0002, 0x03208406, 0x0000089F,// EVEX_Vcvttps2dq_ymm_k1z_ymmm256b32
				0x005B0002, 0x03A0C806, 0x000008E0,// EVEX_Vcvttps2dq_zmm_k1z_zmmm512b32_sae
				0x005C0000, 0x00008004, 0x00003263,// Subps_xmm_xmmm128
				0x005C0001, 0x00004C04, 0x000253A2,// VEX_Vsubps_xmm_xmm_xmmm128
				0x005C0001, 0x00005004, 0x000263E3,// VEX_Vsubps_ymm_ymm_ymmm256
				0x005C0002, 0x03204004, 0x0002125E,// EVEX_Vsubps_xmm_k1z_xmm_xmmm128b32
				0x005C0002, 0x03208404, 0x0002229F,// EVEX_Vsubps_ymm_k1z_ymm_ymmm256b32
				0x005C0002, 0x0360C804, 0x000232E0,// EVEX_Vsubps_zmm_k1z_zmm_zmmm512b32_er
				0x005C0000, 0x00008005, 0x00003263,// Subpd_xmm_xmmm128
				0x005C0001, 0x00004C05, 0x000253A2,// VEX_Vsubpd_xmm_xmm_xmmm128
				0x005C0001, 0x00005005, 0x000263E3,// VEX_Vsubpd_ymm_ymm_ymmm256
				0x005C0002, 0x03205005, 0x0002125E,// EVEX_Vsubpd_xmm_k1z_xmm_xmmm128b64
				0x005C0002, 0x03209405, 0x0002229F,// EVEX_Vsubpd_ymm_k1z_ymm_ymmm256b64
				0x005C0002, 0x0360D805, 0x000232E0,// EVEX_Vsubpd_zmm_k1z_zmm_zmmm512b64_er
				0x005C0000, 0x00008006, 0x00003263,// Subss_xmm_xmmm32
				0x005C0001, 0x00005406, 0x000253A2,// VEX_Vsubss_xmm_xmm_xmmm32
				0x005C0002, 0x03528006, 0x0002125E,// EVEX_Vsubss_xmm_k1z_xmm_xmmm32_er
				0x005C0000, 0x00008007, 0x00003263,// Subsd_xmm_xmmm64
				0x005C0001, 0x00005407, 0x000253A2,// VEX_Vsubsd_xmm_xmm_xmmm64
				0x005C0002, 0x03529007, 0x0002125E,// EVEX_Vsubsd_xmm_k1z_xmm_xmmm64_er
				0x005D0000, 0x00008004, 0x00003263,// Minps_xmm_xmmm128
				0x005D0001, 0x00004C04, 0x000253A2,// VEX_Vminps_xmm_xmm_xmmm128
				0x005D0001, 0x00005004, 0x000263E3,// VEX_Vminps_ymm_ymm_ymmm256
				0x005D0002, 0x03204004, 0x0002125E,// EVEX_Vminps_xmm_k1z_xmm_xmmm128b32
				0x005D0002, 0x03208404, 0x0002229F,// EVEX_Vminps_ymm_k1z_ymm_ymmm256b32
				0x005D0002, 0x03A0C804, 0x000232E0,// EVEX_Vminps_zmm_k1z_zmm_zmmm512b32_sae
				0x005D0000, 0x00008005, 0x00003263,// Minpd_xmm_xmmm128
				0x005D0001, 0x00004C05, 0x000253A2,// VEX_Vminpd_xmm_xmm_xmmm128
				0x005D0001, 0x00005005, 0x000263E3,// VEX_Vminpd_ymm_ymm_ymmm256
				0x005D0002, 0x03205005, 0x0002125E,// EVEX_Vminpd_xmm_k1z_xmm_xmmm128b64
				0x005D0002, 0x03209405, 0x0002229F,// EVEX_Vminpd_ymm_k1z_ymm_ymmm256b64
				0x005D0002, 0x03A0D805, 0x000232E0,// EVEX_Vminpd_zmm_k1z_zmm_zmmm512b64_sae
				0x005D0000, 0x00008006, 0x00003263,// Minss_xmm_xmmm32
				0x005D0001, 0x00005406, 0x000253A2,// VEX_Vminss_xmm_xmm_xmmm32
				0x005D0002, 0x03928006, 0x0002125E,// EVEX_Vminss_xmm_k1z_xmm_xmmm32_sae
				0x005D0000, 0x00008007, 0x00003263,// Minsd_xmm_xmmm64
				0x005D0001, 0x00005407, 0x000253A2,// VEX_Vminsd_xmm_xmm_xmmm64
				0x005D0002, 0x03929007, 0x0002125E,// EVEX_Vminsd_xmm_k1z_xmm_xmmm64_sae
				0x005E0000, 0x00008004, 0x00003263,// Divps_xmm_xmmm128
				0x005E0001, 0x00004C04, 0x000253A2,// VEX_Vdivps_xmm_xmm_xmmm128
				0x005E0001, 0x00005004, 0x000263E3,// VEX_Vdivps_ymm_ymm_ymmm256
				0x005E0002, 0x03204004, 0x0002125E,// EVEX_Vdivps_xmm_k1z_xmm_xmmm128b32
				0x005E0002, 0x03208404, 0x0002229F,// EVEX_Vdivps_ymm_k1z_ymm_ymmm256b32
				0x005E0002, 0x0360C804, 0x000232E0,// EVEX_Vdivps_zmm_k1z_zmm_zmmm512b32_er
				0x005E0000, 0x00008005, 0x00003263,// Divpd_xmm_xmmm128
				0x005E0001, 0x00004C05, 0x000253A2,// VEX_Vdivpd_xmm_xmm_xmmm128
				0x005E0001, 0x00005005, 0x000263E3,// VEX_Vdivpd_ymm_ymm_ymmm256
				0x005E0002, 0x03205005, 0x0002125E,// EVEX_Vdivpd_xmm_k1z_xmm_xmmm128b64
				0x005E0002, 0x03209405, 0x0002229F,// EVEX_Vdivpd_ymm_k1z_ymm_ymmm256b64
				0x005E0002, 0x0360D805, 0x000232E0,// EVEX_Vdivpd_zmm_k1z_zmm_zmmm512b64_er
				0x005E0000, 0x00008006, 0x00003263,// Divss_xmm_xmmm32
				0x005E0001, 0x00005406, 0x000253A2,// VEX_Vdivss_xmm_xmm_xmmm32
				0x005E0002, 0x03528006, 0x0002125E,// EVEX_Vdivss_xmm_k1z_xmm_xmmm32_er
				0x005E0000, 0x00008007, 0x00003263,// Divsd_xmm_xmmm64
				0x005E0001, 0x00005407, 0x000253A2,// VEX_Vdivsd_xmm_xmm_xmmm64
				0x005E0002, 0x03529007, 0x0002125E,// EVEX_Vdivsd_xmm_k1z_xmm_xmmm64_er
				0x005F0000, 0x00008004, 0x00003263,// Maxps_xmm_xmmm128
				0x005F0001, 0x00004C04, 0x000253A2,// VEX_Vmaxps_xmm_xmm_xmmm128
				0x005F0001, 0x00005004, 0x000263E3,// VEX_Vmaxps_ymm_ymm_ymmm256
				0x005F0002, 0x03204004, 0x0002125E,// EVEX_Vmaxps_xmm_k1z_xmm_xmmm128b32
				0x005F0002, 0x03208404, 0x0002229F,// EVEX_Vmaxps_ymm_k1z_ymm_ymmm256b32
				0x005F0002, 0x03A0C804, 0x000232E0,// EVEX_Vmaxps_zmm_k1z_zmm_zmmm512b32_sae
				0x005F0000, 0x00008005, 0x00003263,// Maxpd_xmm_xmmm128
				0x005F0001, 0x00004C05, 0x000253A2,// VEX_Vmaxpd_xmm_xmm_xmmm128
				0x005F0001, 0x00005005, 0x000263E3,// VEX_Vmaxpd_ymm_ymm_ymmm256
				0x005F0002, 0x03205005, 0x0002125E,// EVEX_Vmaxpd_xmm_k1z_xmm_xmmm128b64
				0x005F0002, 0x03209405, 0x0002229F,// EVEX_Vmaxpd_ymm_k1z_ymm_ymmm256b64
				0x005F0002, 0x03A0D805, 0x000232E0,// EVEX_Vmaxpd_zmm_k1z_zmm_zmmm512b64_sae
				0x005F0000, 0x00008006, 0x00003263,// Maxss_xmm_xmmm32
				0x005F0001, 0x00005406, 0x000253A2,// VEX_Vmaxss_xmm_xmm_xmmm32
				0x005F0002, 0x03928006, 0x0002125E,// EVEX_Vmaxss_xmm_k1z_xmm_xmmm32_sae
				0x005F0000, 0x00008007, 0x00003263,// Maxsd_xmm_xmmm64
				0x005F0001, 0x00005407, 0x000253A2,// VEX_Vmaxsd_xmm_xmm_xmmm64
				0x005F0002, 0x03929007, 0x0002125E,// EVEX_Vmaxsd_xmm_k1z_xmm_xmmm64_sae
				0x00600000, 0x00008004, 0x000030E0,// Punpcklbw_mm_mmm32
				0x00600000, 0x00008005, 0x00003263,// Punpcklbw_xmm_xmmm128
				0x00600001, 0x00004C05, 0x000253A2,// VEX_Vpunpcklbw_xmm_xmm_xmmm128
				0x00600001, 0x00005005, 0x000263E3,// VEX_Vpunpcklbw_ymm_ymm_ymmm256
				0x00600002, 0x0301E005, 0x0002125E,// EVEX_Vpunpcklbw_xmm_k1z_xmm_xmmm128
				0x00600002, 0x03022405, 0x0002229F,// EVEX_Vpunpcklbw_ymm_k1z_ymm_ymmm256
				0x00600002, 0x03026805, 0x000232E0,// EVEX_Vpunpcklbw_zmm_k1z_zmm_zmmm512
				0x00610000, 0x00008004, 0x000030E0,// Punpcklwd_mm_mmm32
				0x00610000, 0x00008005, 0x00003263,// Punpcklwd_xmm_xmmm128
				0x00610001, 0x00004C05, 0x000253A2,// VEX_Vpunpcklwd_xmm_xmm_xmmm128
				0x00610001, 0x00005005, 0x000263E3,// VEX_Vpunpcklwd_ymm_ymm_ymmm256
				0x00610002, 0x0301E005, 0x0002125E,// EVEX_Vpunpcklwd_xmm_k1z_xmm_xmmm128
				0x00610002, 0x03022405, 0x0002229F,// EVEX_Vpunpcklwd_ymm_k1z_ymm_ymmm256
				0x00610002, 0x03026805, 0x000232E0,// EVEX_Vpunpcklwd_zmm_k1z_zmm_zmmm512
				0x00620000, 0x00008004, 0x000030E0,// Punpckldq_mm_mmm32
				0x00620000, 0x00008005, 0x00003263,// Punpckldq_xmm_xmmm128
				0x00620001, 0x00004C05, 0x000253A2,// VEX_Vpunpckldq_xmm_xmm_xmmm128
				0x00620001, 0x00005005, 0x000263E3,// VEX_Vpunpckldq_ymm_ymm_ymmm256
				0x00620002, 0x03204005, 0x0002125E,// EVEX_Vpunpckldq_xmm_k1z_xmm_xmmm128b32
				0x00620002, 0x03208405, 0x0002229F,// EVEX_Vpunpckldq_ymm_k1z_ymm_ymmm256b32
				0x00620002, 0x0320C805, 0x000232E0,// EVEX_Vpunpckldq_zmm_k1z_zmm_zmmm512b32
				0x00630000, 0x00008004, 0x000030E0,// Packsswb_mm_mmm64
				0x00630000, 0x00008005, 0x00003263,// Packsswb_xmm_xmmm128
				0x00630001, 0x00004C05, 0x000253A2,// VEX_Vpacksswb_xmm_xmm_xmmm128
				0x00630001, 0x00005005, 0x000263E3,// VEX_Vpacksswb_ymm_ymm_ymmm256
				0x00630002, 0x0301E005, 0x0002125E,// EVEX_Vpacksswb_xmm_k1z_xmm_xmmm128
				0x00630002, 0x03022405, 0x0002229F,// EVEX_Vpacksswb_ymm_k1z_ymm_ymmm256
				0x00630002, 0x03026805, 0x000232E0,// EVEX_Vpacksswb_zmm_k1z_zmm_zmmm512
				0x00640000, 0x00008004, 0x000030E0,// Pcmpgtb_mm_mmm64
				0x00640000, 0x00008005, 0x00003263,// Pcmpgtb_xmm_xmmm128
				0x00640001, 0x00004C05, 0x000253A2,// VEX_Vpcmpgtb_xmm_xmm_xmmm128
				0x00640001, 0x00005005, 0x000263E3,// VEX_Vpcmpgtb_ymm_ymm_ymmm256
				0x00640002, 0x0101E005, 0x0002125C,// EVEX_Vpcmpgtb_k_k1_xmm_xmmm128
				0x00640002, 0x01022405, 0x0002229C,// EVEX_Vpcmpgtb_k_k1_ymm_ymmm256
				0x00640002, 0x01026805, 0x000232DC,// EVEX_Vpcmpgtb_k_k1_zmm_zmmm512
				0x00650000, 0x00008004, 0x000030E0,// Pcmpgtw_mm_mmm64
				0x00650000, 0x00008005, 0x00003263,// Pcmpgtw_xmm_xmmm128
				0x00650001, 0x00004C05, 0x000253A2,// VEX_Vpcmpgtw_xmm_xmm_xmmm128
				0x00650001, 0x00005005, 0x000263E3,// VEX_Vpcmpgtw_ymm_ymm_ymmm256
				0x00650002, 0x0101E005, 0x0002125C,// EVEX_Vpcmpgtw_k_k1_xmm_xmmm128
				0x00650002, 0x01022405, 0x0002229C,// EVEX_Vpcmpgtw_k_k1_ymm_ymmm256
				0x00650002, 0x01026805, 0x000232DC,// EVEX_Vpcmpgtw_k_k1_zmm_zmmm512
				0x00660000, 0x00008004, 0x000030E0,// Pcmpgtd_mm_mmm64
				0x00660000, 0x00008005, 0x00003263,// Pcmpgtd_xmm_xmmm128
				0x00660001, 0x00004C05, 0x000253A2,// VEX_Vpcmpgtd_xmm_xmm_xmmm128
				0x00660001, 0x00005005, 0x000263E3,// VEX_Vpcmpgtd_ymm_ymm_ymmm256
				0x00660002, 0x01204005, 0x0002125C,// EVEX_Vpcmpgtd_k_k1_xmm_xmmm128b32
				0x00660002, 0x01208405, 0x0002229C,// EVEX_Vpcmpgtd_k_k1_ymm_ymmm256b32
				0x00660002, 0x0120C805, 0x000232DC,// EVEX_Vpcmpgtd_k_k1_zmm_zmmm512b32
				0x00670000, 0x00008004, 0x000030E0,// Packuswb_mm_mmm64
				0x00670000, 0x00008005, 0x00003263,// Packuswb_xmm_xmmm128
				0x00670001, 0x00004C05, 0x000253A2,// VEX_Vpackuswb_xmm_xmm_xmmm128
				0x00670001, 0x00005005, 0x000263E3,// VEX_Vpackuswb_ymm_ymm_ymmm256
				0x00670002, 0x0301E005, 0x0002125E,// EVEX_Vpackuswb_xmm_k1z_xmm_xmmm128
				0x00670002, 0x03022405, 0x0002229F,// EVEX_Vpackuswb_ymm_k1z_ymm_ymmm256
				0x00670002, 0x03026805, 0x000232E0,// EVEX_Vpackuswb_zmm_k1z_zmm_zmmm512
				0x00680000, 0x00008004, 0x000030E0,// Punpckhbw_mm_mmm64
				0x00680000, 0x00008005, 0x00003263,// Punpckhbw_xmm_xmmm128
				0x00680001, 0x00004C05, 0x000253A2,// VEX_Vpunpckhbw_xmm_xmm_xmmm128
				0x00680001, 0x00005005, 0x000263E3,// VEX_Vpunpckhbw_ymm_ymm_ymmm256
				0x00680002, 0x0301E005, 0x0002125E,// EVEX_Vpunpckhbw_xmm_k1z_xmm_xmmm128
				0x00680002, 0x03022405, 0x0002229F,// EVEX_Vpunpckhbw_ymm_k1z_ymm_ymmm256
				0x00680002, 0x03026805, 0x000232E0,// EVEX_Vpunpckhbw_zmm_k1z_zmm_zmmm512
				0x00690000, 0x00008004, 0x000030E0,// Punpckhwd_mm_mmm64
				0x00690000, 0x00008005, 0x00003263,// Punpckhwd_xmm_xmmm128
				0x00690001, 0x00004C05, 0x000253A2,// VEX_Vpunpckhwd_xmm_xmm_xmmm128
				0x00690001, 0x00005005, 0x000263E3,// VEX_Vpunpckhwd_ymm_ymm_ymmm256
				0x00690002, 0x0301E005, 0x0002125E,// EVEX_Vpunpckhwd_xmm_k1z_xmm_xmmm128
				0x00690002, 0x03022405, 0x0002229F,// EVEX_Vpunpckhwd_ymm_k1z_ymm_ymmm256
				0x00690002, 0x03026805, 0x000232E0,// EVEX_Vpunpckhwd_zmm_k1z_zmm_zmmm512
				0x006A0000, 0x00008004, 0x000030E0,// Punpckhdq_mm_mmm64
				0x006A0000, 0x00008005, 0x00003263,// Punpckhdq_xmm_xmmm128
				0x006A0001, 0x00004C05, 0x000253A2,// VEX_Vpunpckhdq_xmm_xmm_xmmm128
				0x006A0001, 0x00005005, 0x000263E3,// VEX_Vpunpckhdq_ymm_ymm_ymmm256
				0x006A0002, 0x03204005, 0x0002125E,// EVEX_Vpunpckhdq_xmm_k1z_xmm_xmmm128b32
				0x006A0002, 0x03208405, 0x0002229F,// EVEX_Vpunpckhdq_ymm_k1z_ymm_ymmm256b32
				0x006A0002, 0x0320C805, 0x000232E0,// EVEX_Vpunpckhdq_zmm_k1z_zmm_zmmm512b32
				0x006B0000, 0x00008004, 0x000030E0,// Packssdw_mm_mmm64
				0x006B0000, 0x00008005, 0x00003263,// Packssdw_xmm_xmmm128
				0x006B0001, 0x00004C05, 0x000253A2,// VEX_Vpackssdw_xmm_xmm_xmmm128
				0x006B0001, 0x00005005, 0x000263E3,// VEX_Vpackssdw_ymm_ymm_ymmm256
				0x006B0002, 0x03204005, 0x0002125E,// EVEX_Vpackssdw_xmm_k1z_xmm_xmmm128b32
				0x006B0002, 0x03208405, 0x0002229F,// EVEX_Vpackssdw_ymm_k1z_ymm_ymmm256b32
				0x006B0002, 0x0320C805, 0x000232E0,// EVEX_Vpackssdw_zmm_k1z_zmm_zmmm512b32
				0x006C0000, 0x00008005, 0x00003263,// Punpcklqdq_xmm_xmmm128
				0x006C0001, 0x00004C05, 0x000253A2,// VEX_Vpunpcklqdq_xmm_xmm_xmmm128
				0x006C0001, 0x00005005, 0x000263E3,// VEX_Vpunpcklqdq_ymm_ymm_ymmm256
				0x006C0002, 0x03205005, 0x0002125E,// EVEX_Vpunpcklqdq_xmm_k1z_xmm_xmmm128b64
				0x006C0002, 0x03209405, 0x0002229F,// EVEX_Vpunpcklqdq_ymm_k1z_ymm_ymmm256b64
				0x006C0002, 0x0320D805, 0x000232E0,// EVEX_Vpunpcklqdq_zmm_k1z_zmm_zmmm512b64
				0x006D0000, 0x00008005, 0x00003263,// Punpckhqdq_xmm_xmmm128
				0x006D0001, 0x00004C05, 0x000253A2,// VEX_Vpunpckhqdq_xmm_xmm_xmmm128
				0x006D0001, 0x00005005, 0x000263E3,// VEX_Vpunpckhqdq_ymm_ymm_ymmm256
				0x006D0002, 0x03205005, 0x0002125E,// EVEX_Vpunpckhqdq_xmm_k1z_xmm_xmmm128b64
				0x006D0002, 0x03209405, 0x0002229F,// EVEX_Vpunpckhqdq_ymm_k1z_ymm_ymmm256b64
				0x006D0002, 0x0320D805, 0x000232E0,// EVEX_Vpunpckhqdq_zmm_k1z_zmm_zmmm512b64
				0x006E0000, 0x00008004, 0x00000E60,// Movd_mm_rm32
				0x006E0000, 0x00038024, 0x00001060,// Movq_mm_rm64
				0x006E0000, 0x00008005, 0x00000E63,// Movd_xmm_rm32
				0x006E0000, 0x00038025, 0x00001063,// Movq_xmm_rm64
				0x006E0001, 0x00006C05, 0x00000062,// VEX_Vmovd_xmm_rm32
				0x006E0001, 0x00002C25, 0x000000A2,// VEX_Vmovq_xmm_rm64
				0x006E0002, 0x0002B005, 0x0000005E,// EVEX_Vmovd_xmm_rm32
				0x006E0002, 0x00029025, 0x0000009E,// EVEX_Vmovq_xmm_rm64
				0x006F0000, 0x00008004, 0x000030E0,// Movq_mm_mmm64
				0x006F0000, 0x00008005, 0x00003263,// Movdqa_xmm_xmmm128
				0x006F0001, 0x00004C05, 0x00000962,// VEX_Vmovdqa_xmm_xmmm128
				0x006F0001, 0x00005005, 0x000009A3,// VEX_Vmovdqa_ymm_ymmm256
				0x006F0002, 0x0301C005, 0x0000085E,// EVEX_Vmovdqa32_xmm_k1z_xmmm128
				0x006F0002, 0x03020405, 0x0000089F,// EVEX_Vmovdqa32_ymm_k1z_ymmm256
				0x006F0002, 0x03024805, 0x000008E0,// EVEX_Vmovdqa32_zmm_k1z_zmmm512
				0x006F0002, 0x0301D005, 0x0000085E,// EVEX_Vmovdqa64_xmm_k1z_xmmm128
				0x006F0002, 0x03021405, 0x0000089F,// EVEX_Vmovdqa64_ymm_k1z_ymmm256
				0x006F0002, 0x03025805, 0x000008E0,// EVEX_Vmovdqa64_zmm_k1z_zmmm512
				0x006F0000, 0x00008006, 0x00003263,// Movdqu_xmm_xmmm128
				0x006F0001, 0x00004C06, 0x00000962,// VEX_Vmovdqu_xmm_xmmm128
				0x006F0001, 0x00005006, 0x000009A3,// VEX_Vmovdqu_ymm_ymmm256
				0x006F0002, 0x0301C006, 0x0000085E,// EVEX_Vmovdqu32_xmm_k1z_xmmm128
				0x006F0002, 0x03020406, 0x0000089F,// EVEX_Vmovdqu32_ymm_k1z_ymmm256
				0x006F0002, 0x03024806, 0x000008E0,// EVEX_Vmovdqu32_zmm_k1z_zmmm512
				0x006F0002, 0x0301D006, 0x0000085E,// EVEX_Vmovdqu64_xmm_k1z_xmmm128
				0x006F0002, 0x03021406, 0x0000089F,// EVEX_Vmovdqu64_ymm_k1z_ymmm256
				0x006F0002, 0x03025806, 0x000008E0,// EVEX_Vmovdqu64_zmm_k1z_zmmm512
				0x006F0002, 0x0301C007, 0x0000085E,// EVEX_Vmovdqu8_xmm_k1z_xmmm128
				0x006F0002, 0x03020407, 0x0000089F,// EVEX_Vmovdqu8_ymm_k1z_ymmm256
				0x006F0002, 0x03024807, 0x000008E0,// EVEX_Vmovdqu8_zmm_k1z_zmmm512
				0x006F0002, 0x0301D007, 0x0000085E,// EVEX_Vmovdqu16_xmm_k1z_xmmm128
				0x006F0002, 0x03021407, 0x0000089F,// EVEX_Vmovdqu16_ymm_k1z_ymmm256
				0x006F0002, 0x03025807, 0x000008E0,// EVEX_Vmovdqu16_zmm_k1z_zmmm512
				0x00700000, 0x00008004, 0x000E70E0,// Pshufw_mm_mmm64_imm8
				0x00700000, 0x00008005, 0x000E7263,// Pshufd_xmm_xmmm128_imm8
				0x00700001, 0x00004C05, 0x00010962,// VEX_Vpshufd_xmm_xmmm128_imm8
				0x00700001, 0x00005005, 0x000109A3,// VEX_Vpshufd_ymm_ymmm256_imm8
				0x00700002, 0x03204005, 0x0000E85E,// EVEX_Vpshufd_xmm_k1z_xmmm128b32_imm8
				0x00700002, 0x03208405, 0x0000E89F,// EVEX_Vpshufd_ymm_k1z_ymmm256b32_imm8
				0x00700002, 0x0320C805, 0x0000E8E0,// EVEX_Vpshufd_zmm_k1z_zmmm512b32_imm8
				0x00700000, 0x00008006, 0x000E7263,// Pshufhw_xmm_xmmm128_imm8
				0x00700001, 0x00004C06, 0x00010962,// VEX_Vpshufhw_xmm_xmmm128_imm8
				0x00700001, 0x00005006, 0x000109A3,// VEX_Vpshufhw_ymm_ymmm256_imm8
				0x00700002, 0x0301E006, 0x0000E85E,// EVEX_Vpshufhw_xmm_k1z_xmmm128_imm8
				0x00700002, 0x03022406, 0x0000E89F,// EVEX_Vpshufhw_ymm_k1z_ymmm256_imm8
				0x00700002, 0x03026806, 0x0000E8E0,// EVEX_Vpshufhw_zmm_k1z_zmmm512_imm8
				0x00700000, 0x00008007, 0x000E7263,// Pshuflw_xmm_xmmm128_imm8
				0x00700001, 0x00004C07, 0x00010962,// VEX_Vpshuflw_xmm_xmmm128_imm8
				0x00700001, 0x00005007, 0x000109A3,// VEX_Vpshuflw_ymm_ymmm256_imm8
				0x00700002, 0x0301E007, 0x0000E85E,// EVEX_Vpshuflw_xmm_k1z_xmmm128_imm8
				0x00700002, 0x03022407, 0x0000E89F,// EVEX_Vpshuflw_ymm_k1z_ymmm256_imm8
				0x00700002, 0x03026807, 0x0000E8E0,// EVEX_Vpshuflw_zmm_k1z_zmmm512_imm8
				0x00710000, 0x00008144, 0x00001CDF,// Psrlw_mm_imm8
				0x00710000, 0x00008145, 0x00001CE2,// Psrlw_xmm_imm8
				0x00710001, 0x00004D45, 0x000106CE,// VEX_Vpsrlw_xmm_xmm_imm8
				0x00710001, 0x00005145, 0x0001070F,// VEX_Vpsrlw_ymm_ymm_imm8
				0x00710002, 0x0301E145, 0x0000E849,// EVEX_Vpsrlw_xmm_k1z_xmmm128_imm8
				0x00710002, 0x03022545, 0x0000E88A,// EVEX_Vpsrlw_ymm_k1z_ymmm256_imm8
				0x00710002, 0x03026945, 0x0000E8CB,// EVEX_Vpsrlw_zmm_k1z_zmmm512_imm8
				0x00710000, 0x00008244, 0x00001CDF,// Psraw_mm_imm8
				0x00710000, 0x00008245, 0x00001CE2,// Psraw_xmm_imm8
				0x00710001, 0x00004E45, 0x000106CE,// VEX_Vpsraw_xmm_xmm_imm8
				0x00710001, 0x00005245, 0x0001070F,// VEX_Vpsraw_ymm_ymm_imm8
				0x00710002, 0x0301E245, 0x0000E849,// EVEX_Vpsraw_xmm_k1z_xmmm128_imm8
				0x00710002, 0x03022645, 0x0000E88A,// EVEX_Vpsraw_ymm_k1z_ymmm256_imm8
				0x00710002, 0x03026A45, 0x0000E8CB,// EVEX_Vpsraw_zmm_k1z_zmmm512_imm8
				0x00710000, 0x00008344, 0x00001CDF,// Psllw_mm_imm8
				0x00710000, 0x00008345, 0x00001CE2,// Psllw_xmm_imm8
				0x00710001, 0x00004F45, 0x000106CE,// VEX_Vpsllw_xmm_xmm_imm8
				0x00710001, 0x00005345, 0x0001070F,// VEX_Vpsllw_ymm_ymm_imm8
				0x00710002, 0x0301E345, 0x0000E849,// EVEX_Vpsllw_xmm_k1z_xmmm128_imm8
				0x00710002, 0x03022745, 0x0000E88A,// EVEX_Vpsllw_ymm_k1z_ymmm256_imm8
				0x00710002, 0x03026B45, 0x0000E8CB,// EVEX_Vpsllw_zmm_k1z_zmmm512_imm8
				0x00720002, 0x03204045, 0x0000E849,// EVEX_Vprord_xmm_k1z_xmmm128b32_imm8
				0x00720002, 0x03208445, 0x0000E88A,// EVEX_Vprord_ymm_k1z_ymmm256b32_imm8
				0x00720002, 0x0320C845, 0x0000E8CB,// EVEX_Vprord_zmm_k1z_zmmm512b32_imm8
				0x00720002, 0x03205045, 0x0000E849,// EVEX_Vprorq_xmm_k1z_xmmm128b64_imm8
				0x00720002, 0x03209445, 0x0000E88A,// EVEX_Vprorq_ymm_k1z_ymmm256b64_imm8
				0x00720002, 0x0320D845, 0x0000E8CB,// EVEX_Vprorq_zmm_k1z_zmmm512b64_imm8
				0x00720002, 0x032040C5, 0x0000E849,// EVEX_Vprold_xmm_k1z_xmmm128b32_imm8
				0x00720002, 0x032084C5, 0x0000E88A,// EVEX_Vprold_ymm_k1z_ymmm256b32_imm8
				0x00720002, 0x0320C8C5, 0x0000E8CB,// EVEX_Vprold_zmm_k1z_zmmm512b32_imm8
				0x00720002, 0x032050C5, 0x0000E849,// EVEX_Vprolq_xmm_k1z_xmmm128b64_imm8
				0x00720002, 0x032094C5, 0x0000E88A,// EVEX_Vprolq_ymm_k1z_ymmm256b64_imm8
				0x00720002, 0x0320D8C5, 0x0000E8CB,// EVEX_Vprolq_zmm_k1z_zmmm512b64_imm8
				0x00720000, 0x00008144, 0x00001CDF,// Psrld_mm_imm8
				0x00720000, 0x00008145, 0x00001CE2,// Psrld_xmm_imm8
				0x00720001, 0x00004D45, 0x000106CE,// VEX_Vpsrld_xmm_xmm_imm8
				0x00720001, 0x00005145, 0x0001070F,// VEX_Vpsrld_ymm_ymm_imm8
				0x00720002, 0x03204145, 0x0000E849,// EVEX_Vpsrld_xmm_k1z_xmmm128b32_imm8
				0x00720002, 0x03208545, 0x0000E88A,// EVEX_Vpsrld_ymm_k1z_ymmm256b32_imm8
				0x00720002, 0x0320C945, 0x0000E8CB,// EVEX_Vpsrld_zmm_k1z_zmmm512b32_imm8
				0x00720000, 0x00008244, 0x00001CDF,// Psrad_mm_imm8
				0x00720000, 0x00008245, 0x00001CE2,// Psrad_xmm_imm8
				0x00720001, 0x00004E45, 0x000106CE,// VEX_Vpsrad_xmm_xmm_imm8
				0x00720001, 0x00005245, 0x0001070F,// VEX_Vpsrad_ymm_ymm_imm8
				0x00720002, 0x03204245, 0x0000E849,// EVEX_Vpsrad_xmm_k1z_xmmm128b32_imm8
				0x00720002, 0x03208645, 0x0000E88A,// EVEX_Vpsrad_ymm_k1z_ymmm256b32_imm8
				0x00720002, 0x0320CA45, 0x0000E8CB,// EVEX_Vpsrad_zmm_k1z_zmmm512b32_imm8
				0x00720002, 0x03205245, 0x0000E849,// EVEX_Vpsraq_xmm_k1z_xmmm128b64_imm8
				0x00720002, 0x03209645, 0x0000E88A,// EVEX_Vpsraq_ymm_k1z_ymmm256b64_imm8
				0x00720002, 0x0320DA45, 0x0000E8CB,// EVEX_Vpsraq_zmm_k1z_zmmm512b64_imm8
				0x00720000, 0x00008344, 0x00001CDF,// Pslld_mm_imm8
				0x00720000, 0x00008345, 0x00001CE2,// Pslld_xmm_imm8
				0x00720001, 0x00004F45, 0x000106CE,// VEX_Vpslld_xmm_xmm_imm8
				0x00720001, 0x00005345, 0x0001070F,// VEX_Vpslld_ymm_ymm_imm8
				0x00720002, 0x03204345, 0x0000E849,// EVEX_Vpslld_xmm_k1z_xmmm128b32_imm8
				0x00720002, 0x03208745, 0x0000E88A,// EVEX_Vpslld_ymm_k1z_ymmm256b32_imm8
				0x00720002, 0x0320CB45, 0x0000E8CB,// EVEX_Vpslld_zmm_k1z_zmmm512b32_imm8
				0x00730000, 0x00008144, 0x00001CDF,// Psrlq_mm_imm8
				0x00730000, 0x00008145, 0x00001CE2,// Psrlq_xmm_imm8
				0x00730001, 0x00004D45, 0x000106CE,// VEX_Vpsrlq_xmm_xmm_imm8
				0x00730001, 0x00005145, 0x0001070F,// VEX_Vpsrlq_ymm_ymm_imm8
				0x00730002, 0x03205145, 0x0000E849,// EVEX_Vpsrlq_xmm_k1z_xmmm128b64_imm8
				0x00730002, 0x03209545, 0x0000E88A,// EVEX_Vpsrlq_ymm_k1z_ymmm256b64_imm8
				0x00730002, 0x0320D945, 0x0000E8CB,// EVEX_Vpsrlq_zmm_k1z_zmmm512b64_imm8
				0x00730000, 0x000081C5, 0x00001CE2,// Psrldq_xmm_imm8
				0x00730001, 0x00004DC5, 0x000106CE,// VEX_Vpsrldq_xmm_xmm_imm8
				0x00730001, 0x000051C5, 0x0001070F,// VEX_Vpsrldq_ymm_ymm_imm8
				0x00730002, 0x0001E1C5, 0x0000E849,// EVEX_Vpsrldq_xmm_xmmm128_imm8
				0x00730002, 0x000225C5, 0x0000E88A,// EVEX_Vpsrldq_ymm_ymmm256_imm8
				0x00730002, 0x000269C5, 0x0000E8CB,// EVEX_Vpsrldq_zmm_zmmm512_imm8
				0x00730000, 0x00008344, 0x00001CDF,// Psllq_mm_imm8
				0x00730000, 0x00008345, 0x00001CE2,// Psllq_xmm_imm8
				0x00730001, 0x00004F45, 0x000106CE,// VEX_Vpsllq_xmm_xmm_imm8
				0x00730001, 0x00005345, 0x0001070F,// VEX_Vpsllq_ymm_ymm_imm8
				0x00730002, 0x03205345, 0x0000E849,// EVEX_Vpsllq_xmm_k1z_xmmm128b64_imm8
				0x00730002, 0x03209745, 0x0000E88A,// EVEX_Vpsllq_ymm_k1z_ymmm256b64_imm8
				0x00730002, 0x0320DB45, 0x0000E8CB,// EVEX_Vpsllq_zmm_k1z_zmmm512b64_imm8
				0x00730000, 0x000083C5, 0x00001CE2,// Pslldq_xmm_imm8
				0x00730001, 0x00004FC5, 0x000106CE,// VEX_Vpslldq_xmm_xmm_imm8
				0x00730001, 0x000053C5, 0x0001070F,// VEX_Vpslldq_ymm_ymm_imm8
				0x00730002, 0x0001E3C5, 0x0000E849,// EVEX_Vpslldq_xmm_xmmm128_imm8
				0x00730002, 0x000227C5, 0x0000E88A,// EVEX_Vpslldq_ymm_ymmm256_imm8
				0x00730002, 0x00026BC5, 0x0000E8CB,// EVEX_Vpslldq_zmm_zmmm512_imm8
				0x00740000, 0x00008004, 0x000030E0,// Pcmpeqb_mm_mmm64
				0x00740000, 0x00008005, 0x00003263,// Pcmpeqb_xmm_xmmm128
				0x00740001, 0x00004C05, 0x000253A2,// VEX_Vpcmpeqb_xmm_xmm_xmmm128
				0x00740001, 0x00005005, 0x000263E3,// VEX_Vpcmpeqb_ymm_ymm_ymmm256
				0x00740002, 0x0101E005, 0x0002125C,// EVEX_Vpcmpeqb_k_k1_xmm_xmmm128
				0x00740002, 0x01022405, 0x0002229C,// EVEX_Vpcmpeqb_k_k1_ymm_ymmm256
				0x00740002, 0x01026805, 0x000232DC,// EVEX_Vpcmpeqb_k_k1_zmm_zmmm512
				0x00750000, 0x00008004, 0x000030E0,// Pcmpeqw_mm_mmm64
				0x00750000, 0x00008005, 0x00003263,// Pcmpeqw_xmm_xmmm128
				0x00750001, 0x00004C05, 0x000253A2,// VEX_Vpcmpeqw_xmm_xmm_xmmm128
				0x00750001, 0x00005005, 0x000263E3,// VEX_Vpcmpeqw_ymm_ymm_ymmm256
				0x00750002, 0x0101E005, 0x0002125C,// EVEX_Vpcmpeqw_k_k1_xmm_xmmm128
				0x00750002, 0x01022405, 0x0002229C,// EVEX_Vpcmpeqw_k_k1_ymm_ymmm256
				0x00750002, 0x01026805, 0x000232DC,// EVEX_Vpcmpeqw_k_k1_zmm_zmmm512
				0x00760000, 0x00008004, 0x000030E0,// Pcmpeqd_mm_mmm64
				0x00760000, 0x00008005, 0x00003263,// Pcmpeqd_xmm_xmmm128
				0x00760001, 0x00004C05, 0x000253A2,// VEX_Vpcmpeqd_xmm_xmm_xmmm128
				0x00760001, 0x00005005, 0x000263E3,// VEX_Vpcmpeqd_ymm_ymm_ymmm256
				0x00760002, 0x01204005, 0x0002125C,// EVEX_Vpcmpeqd_k_k1_xmm_xmmm128b32
				0x00760002, 0x01208405, 0x0002229C,// EVEX_Vpcmpeqd_k_k1_ymm_ymmm256b32
				0x00760002, 0x0120C805, 0x000232DC,// EVEX_Vpcmpeqd_k_k1_zmm_zmmm512b32
				0x00770000, 0x00008004, 0x00000000,// Emms
				0x00770001, 0x00004C04, 0x00000000,// VEX_Vzeroupper
				0x00770001, 0x00005004, 0x00000000,// VEX_Vzeroall
				0x00780000, 0x00008014, 0x0000159C,// Vmread_rm32_r32
				0x00780000, 0x00008024, 0x00001620,// Vmread_rm64_r64
				0x00780002, 0x03204004, 0x0000085E,// EVEX_Vcvttps2udq_xmm_k1z_xmmm128b32
				0x00780002, 0x03208404, 0x0000089F,// EVEX_Vcvttps2udq_ymm_k1z_ymmm256b32
				0x00780002, 0x03A0C804, 0x000008E0,// EVEX_Vcvttps2udq_zmm_k1z_zmmm512b32_sae
				0x00780002, 0x03205004, 0x0000085E,// EVEX_Vcvttpd2udq_xmm_k1z_xmmm128b64
				0x00780002, 0x03209404, 0x0000089E,// EVEX_Vcvttpd2udq_xmm_k1z_ymmm256b64
				0x00780002, 0x03A0D804, 0x000008DF,// EVEX_Vcvttpd2udq_ymm_k1z_zmmm512b64_sae
				0x00780000, 0x00008045, 0x00109CE2,// Extrq_xmm_imm8_imm8
				0x00780002, 0x03210005, 0x0000085E,// EVEX_Vcvttps2uqq_xmm_k1z_xmmm64b32
				0x00780002, 0x03214405, 0x0000085F,// EVEX_Vcvttps2uqq_ymm_k1z_xmmm128b32
				0x00780002, 0x03A18805, 0x000008A0,// EVEX_Vcvttps2uqq_zmm_k1z_ymmm256b32_sae
				0x00780002, 0x03205005, 0x0000085E,// EVEX_Vcvttpd2uqq_xmm_k1z_xmmm128b64
				0x00780002, 0x03209405, 0x0000089F,// EVEX_Vcvttpd2uqq_ymm_k1z_ymmm256b64
				0x00780002, 0x03A0D805, 0x000008E0,// EVEX_Vcvttpd2uqq_zmm_k1z_zmmm512b64_sae
				0x00780002, 0x0093F006, 0x00000843,// EVEX_Vcvttss2usi_r32_xmmm32_sae
				0x00780002, 0x0093D026, 0x00000844,// EVEX_Vcvttss2usi_r64_xmmm32_sae
				0x00780000, 0x00008007, 0x084E7163,// Insertq_xmm_xmm_imm8_imm8
				0x00780002, 0x00943007, 0x00000843,// EVEX_Vcvttsd2usi_r32_xmmm64_sae
				0x00780002, 0x00941027, 0x00000844,// EVEX_Vcvttsd2usi_r64_xmmm64_sae
				0x00790000, 0x00008014, 0x00000E2B,// Vmwrite_r32_rm32
				0x00790000, 0x00008024, 0x0000102C,// Vmwrite_r64_rm64
				0x00790002, 0x03204004, 0x0000085E,// EVEX_Vcvtps2udq_xmm_k1z_xmmm128b32
				0x00790002, 0x03208404, 0x0000089F,// EVEX_Vcvtps2udq_ymm_k1z_ymmm256b32
				0x00790002, 0x0360C804, 0x000008E0,// EVEX_Vcvtps2udq_zmm_k1z_zmmm512b32_er
				0x00790002, 0x03205004, 0x0000085E,// EVEX_Vcvtpd2udq_xmm_k1z_xmmm128b64
				0x00790002, 0x03209404, 0x0000089E,// EVEX_Vcvtpd2udq_xmm_k1z_ymmm256b64
				0x00790002, 0x0360D804, 0x000008DF,// EVEX_Vcvtpd2udq_ymm_k1z_zmmm512b64_er
				0x00790000, 0x00008005, 0x00003163,// Extrq_xmm_xmm
				0x00790002, 0x03210005, 0x0000085E,// EVEX_Vcvtps2uqq_xmm_k1z_xmmm64b32
				0x00790002, 0x03214405, 0x0000085F,// EVEX_Vcvtps2uqq_ymm_k1z_xmmm128b32
				0x00790002, 0x03618805, 0x000008A0,// EVEX_Vcvtps2uqq_zmm_k1z_ymmm256b32_er
				0x00790002, 0x03205005, 0x0000085E,// EVEX_Vcvtpd2uqq_xmm_k1z_xmmm128b64
				0x00790002, 0x03209405, 0x0000089F,// EVEX_Vcvtpd2uqq_ymm_k1z_ymmm256b64
				0x00790002, 0x0360D805, 0x000008E0,// EVEX_Vcvtpd2uqq_zmm_k1z_zmmm512b64_er
				0x00790002, 0x0053F006, 0x00000843,// EVEX_Vcvtss2usi_r32_xmmm32_er
				0x00790002, 0x0053D026, 0x00000844,// EVEX_Vcvtss2usi_r64_xmmm32_er
				0x00790000, 0x00008007, 0x00003163,// Insertq_xmm_xmm
				0x00790002, 0x00543007, 0x00000843,// EVEX_Vcvtsd2usi_r32_xmmm64_er
				0x00790002, 0x00541027, 0x00000844,// EVEX_Vcvtsd2usi_r64_xmmm64_er
				0x007A0002, 0x03210005, 0x0000085E,// EVEX_Vcvttps2qq_xmm_k1z_xmmm64b32
				0x007A0002, 0x03214405, 0x0000085F,// EVEX_Vcvttps2qq_ymm_k1z_xmmm128b32
				0x007A0002, 0x03A18805, 0x000008A0,// EVEX_Vcvttps2qq_zmm_k1z_ymmm256b32_sae
				0x007A0002, 0x03205005, 0x0000085E,// EVEX_Vcvttpd2qq_xmm_k1z_xmmm128b64
				0x007A0002, 0x03209405, 0x0000089F,// EVEX_Vcvttpd2qq_ymm_k1z_ymmm256b64
				0x007A0002, 0x03A0D805, 0x000008E0,// EVEX_Vcvttpd2qq_zmm_k1z_zmmm512b64_sae
				0x007A0002, 0x03210006, 0x0000085E,// EVEX_Vcvtudq2pd_xmm_k1z_xmmm64b32
				0x007A0002, 0x03214406, 0x0000085F,// EVEX_Vcvtudq2pd_ymm_k1z_xmmm128b32
				0x007A0002, 0x03218806, 0x000008A0,// EVEX_Vcvtudq2pd_zmm_k1z_ymmm256b32
				0x007A0002, 0x03205006, 0x0000085E,// EVEX_Vcvtuqq2pd_xmm_k1z_xmmm128b64
				0x007A0002, 0x03209406, 0x0000089F,// EVEX_Vcvtuqq2pd_ymm_k1z_ymmm256b64
				0x007A0002, 0x0360D806, 0x000008E0,// EVEX_Vcvtuqq2pd_zmm_k1z_zmmm512b64_er
				0x007A0002, 0x03204007, 0x0000085E,// EVEX_Vcvtudq2ps_xmm_k1z_xmmm128b32
				0x007A0002, 0x03208407, 0x0000089F,// EVEX_Vcvtudq2ps_ymm_k1z_ymmm256b32
				0x007A0002, 0x0360C807, 0x000008E0,// EVEX_Vcvtudq2ps_zmm_k1z_zmmm512b32_er
				0x007A0002, 0x03205007, 0x0000085E,// EVEX_Vcvtuqq2ps_xmm_k1z_xmmm128b64
				0x007A0002, 0x03209407, 0x0000089E,// EVEX_Vcvtuqq2ps_xmm_k1z_ymmm256b64
				0x007A0002, 0x0360D807, 0x000008DF,// EVEX_Vcvtuqq2ps_ymm_k1z_zmmm512b64_er
				0x007B0002, 0x03210005, 0x0000085E,// EVEX_Vcvtps2qq_xmm_k1z_xmmm64b32
				0x007B0002, 0x03214405, 0x0000085F,// EVEX_Vcvtps2qq_ymm_k1z_xmmm128b32
				0x007B0002, 0x03618805, 0x000008A0,// EVEX_Vcvtps2qq_zmm_k1z_ymmm256b32_er
				0x007B0002, 0x03205005, 0x0000085E,// EVEX_Vcvtpd2qq_xmm_k1z_xmmm128b64
				0x007B0002, 0x03209405, 0x0000089F,// EVEX_Vcvtpd2qq_ymm_k1z_ymmm256b64
				0x007B0002, 0x0360D805, 0x000008E0,// EVEX_Vcvtpd2qq_zmm_k1z_zmmm512b64_er
				0x007B0002, 0x0053F006, 0x0000125E,// EVEX_Vcvtusi2ss_xmm_xmm_rm32_er
				0x007B0002, 0x00541026, 0x0000225E,// EVEX_Vcvtusi2ss_xmm_xmm_rm64_er
				0x007B0002, 0x0053F007, 0x0000125E,// EVEX_Vcvtusi2sd_xmm_xmm_rm32_er
				0x007B0002, 0x00541027, 0x0000225E,// EVEX_Vcvtusi2sd_xmm_xmm_rm64_er
				0x007C0000, 0x00008005, 0x00003263,// Haddpd_xmm_xmmm128
				0x007C0001, 0x00004C05, 0x000253A2,// VEX_Vhaddpd_xmm_xmm_xmmm128
				0x007C0001, 0x00005005, 0x000263E3,// VEX_Vhaddpd_ymm_ymm_ymmm256
				0x007C0000, 0x00008007, 0x00003263,// Haddps_xmm_xmmm128
				0x007C0001, 0x00004C07, 0x000253A2,// VEX_Vhaddps_xmm_xmm_xmmm128
				0x007C0001, 0x00005007, 0x000263E3,// VEX_Vhaddps_ymm_ymm_ymmm256
				0x007D0000, 0x00008005, 0x00003263,// Hsubpd_xmm_xmmm128
				0x007D0001, 0x00004C05, 0x000253A2,// VEX_Vhsubpd_xmm_xmm_xmmm128
				0x007D0001, 0x00005005, 0x000263E3,// VEX_Vhsubpd_ymm_ymm_ymmm256
				0x007D0000, 0x00008007, 0x00003263,// Hsubps_xmm_xmmm128
				0x007D0001, 0x00004C07, 0x000253A2,// VEX_Vhsubps_xmm_xmm_xmmm128
				0x007D0001, 0x00005007, 0x000263E3,// VEX_Vhsubps_ymm_ymm_ymmm256
				0x007E0000, 0x00008004, 0x0000301C,// Movd_rm32_mm
				0x007E0000, 0x00038024, 0x00003020,// Movq_rm64_mm
				0x007E0000, 0x00008005, 0x0000319C,// Movd_rm32_xmm
				0x007E0000, 0x00038025, 0x000031A0,// Movq_rm64_xmm
				0x007E0001, 0x00006C05, 0x00000881,// VEX_Vmovd_rm32_xmm
				0x007E0001, 0x00002C25, 0x00000882,// VEX_Vmovq_rm64_xmm
				0x007E0002, 0x0002B005, 0x00000781,// EVEX_Vmovd_rm32_xmm
				0x007E0002, 0x00029025, 0x00000782,// EVEX_Vmovq_rm64_xmm
				0x007E0000, 0x00008006, 0x00003263,// Movq_xmm_xmmm64
				0x007E0001, 0x00004C06, 0x00000962,// VEX_Vmovq_xmm_xmmm64
				0x007E0002, 0x00029006, 0x0000085E,// EVEX_Vmovq_xmm_xmmm64
				0x007F0000, 0x00008004, 0x00003061,// Movq_mmm64_mm
				0x007F0000, 0x00008005, 0x000031E4,// Movdqa_xmmm128_xmm
				0x007F0001, 0x00004C05, 0x000008A5,// VEX_Vmovdqa_xmmm128_xmm
				0x007F0001, 0x00005005, 0x000008E6,// VEX_Vmovdqa_ymmm256_ymm
				0x007F0002, 0x0301C005, 0x000007A1,// EVEX_Vmovdqa32_xmmm128_k1z_xmm
				0x007F0002, 0x03020405, 0x000007E2,// EVEX_Vmovdqa32_ymmm256_k1z_ymm
				0x007F0002, 0x03024805, 0x00000823,// EVEX_Vmovdqa32_zmmm512_k1z_zmm
				0x007F0002, 0x0301D005, 0x000007A1,// EVEX_Vmovdqa64_xmmm128_k1z_xmm
				0x007F0002, 0x03021405, 0x000007E2,// EVEX_Vmovdqa64_ymmm256_k1z_ymm
				0x007F0002, 0x03025805, 0x00000823,// EVEX_Vmovdqa64_zmmm512_k1z_zmm
				0x007F0000, 0x00008006, 0x000031E4,// Movdqu_xmmm128_xmm
				0x007F0001, 0x00004C06, 0x000008A5,// VEX_Vmovdqu_xmmm128_xmm
				0x007F0001, 0x00005006, 0x000008E6,// VEX_Vmovdqu_ymmm256_ymm
				0x007F0002, 0x0301C006, 0x000007A1,// EVEX_Vmovdqu32_xmmm128_k1z_xmm
				0x007F0002, 0x03020406, 0x000007E2,// EVEX_Vmovdqu32_ymmm256_k1z_ymm
				0x007F0002, 0x03024806, 0x00000823,// EVEX_Vmovdqu32_zmmm512_k1z_zmm
				0x007F0002, 0x0301D006, 0x000007A1,// EVEX_Vmovdqu64_xmmm128_k1z_xmm
				0x007F0002, 0x03021406, 0x000007E2,// EVEX_Vmovdqu64_ymmm256_k1z_ymm
				0x007F0002, 0x03025806, 0x00000823,// EVEX_Vmovdqu64_zmmm512_k1z_zmm
				0x007F0002, 0x0301C007, 0x000007A1,// EVEX_Vmovdqu8_xmmm128_k1z_xmm
				0x007F0002, 0x03020407, 0x000007E2,// EVEX_Vmovdqu8_ymmm256_k1z_ymm
				0x007F0002, 0x03024807, 0x00000823,// EVEX_Vmovdqu8_zmmm512_k1z_zmm
				0x007F0002, 0x0301D007, 0x000007A1,// EVEX_Vmovdqu16_xmmm128_k1z_xmm
				0x007F0002, 0x03021407, 0x000007E2,// EVEX_Vmovdqu16_ymmm256_k1z_ymm
				0x007F0002, 0x03025807, 0x00000823,// EVEX_Vmovdqu16_zmmm512_k1z_zmm
				0x00800000, 0x00010C04, 0x0000004E,// Jo_rel16
				0x00800000, 0x00020C14, 0x00000050,// Jo_rel32_32
				0x00800000, 0x00000C24, 0x00000051,// Jo_rel32_64
				0x00810000, 0x00010C04, 0x0000004E,// Jno_rel16
				0x00810000, 0x00020C14, 0x00000050,// Jno_rel32_32
				0x00810000, 0x00000C24, 0x00000051,// Jno_rel32_64
				0x00820000, 0x00010C04, 0x0000004E,// Jb_rel16
				0x00820000, 0x00020C14, 0x00000050,// Jb_rel32_32
				0x00820000, 0x00000C24, 0x00000051,// Jb_rel32_64
				0x00830000, 0x00010C04, 0x0000004E,// Jae_rel16
				0x00830000, 0x00020C14, 0x00000050,// Jae_rel32_32
				0x00830000, 0x00000C24, 0x00000051,// Jae_rel32_64
				0x00840000, 0x00010C04, 0x0000004E,// Je_rel16
				0x00840000, 0x00020C14, 0x00000050,// Je_rel32_32
				0x00840000, 0x00000C24, 0x00000051,// Je_rel32_64
				0x00850000, 0x00010C04, 0x0000004E,// Jne_rel16
				0x00850000, 0x00020C14, 0x00000050,// Jne_rel32_32
				0x00850000, 0x00000C24, 0x00000051,// Jne_rel32_64
				0x00860000, 0x00010C04, 0x0000004E,// Jbe_rel16
				0x00860000, 0x00020C14, 0x00000050,// Jbe_rel32_32
				0x00860000, 0x00000C24, 0x00000051,// Jbe_rel32_64
				0x00870000, 0x00010C04, 0x0000004E,// Ja_rel16
				0x00870000, 0x00020C14, 0x00000050,// Ja_rel32_32
				0x00870000, 0x00000C24, 0x00000051,// Ja_rel32_64
				0x00880000, 0x00010C04, 0x0000004E,// Js_rel16
				0x00880000, 0x00020C14, 0x00000050,// Js_rel32_32
				0x00880000, 0x00000C24, 0x00000051,// Js_rel32_64
				0x00890000, 0x00010C04, 0x0000004E,// Jns_rel16
				0x00890000, 0x00020C14, 0x00000050,// Jns_rel32_32
				0x00890000, 0x00000C24, 0x00000051,// Jns_rel32_64
				0x008A0000, 0x00010C04, 0x0000004E,// Jp_rel16
				0x008A0000, 0x00020C14, 0x00000050,// Jp_rel32_32
				0x008A0000, 0x00000C24, 0x00000051,// Jp_rel32_64
				0x008B0000, 0x00010C04, 0x0000004E,// Jnp_rel16
				0x008B0000, 0x00020C14, 0x00000050,// Jnp_rel32_32
				0x008B0000, 0x00000C24, 0x00000051,// Jnp_rel32_64
				0x008C0000, 0x00010C04, 0x0000004E,// Jl_rel16
				0x008C0000, 0x00020C14, 0x00000050,// Jl_rel32_32
				0x008C0000, 0x00000C24, 0x00000051,// Jl_rel32_64
				0x008D0000, 0x00010C04, 0x0000004E,// Jge_rel16
				0x008D0000, 0x00020C14, 0x00000050,// Jge_rel32_32
				0x008D0000, 0x00000C24, 0x00000051,// Jge_rel32_64
				0x008E0000, 0x00010C04, 0x0000004E,// Jle_rel16
				0x008E0000, 0x00020C14, 0x00000050,// Jle_rel32_32
				0x008E0000, 0x00000C24, 0x00000051,// Jle_rel32_64
				0x008F0000, 0x00010C04, 0x0000004E,// Jg_rel16
				0x008F0000, 0x00020C14, 0x00000050,// Jg_rel32_32
				0x008F0000, 0x00000C24, 0x00000051,// Jg_rel32_64
				0x00900000, 0x00000004, 0x0000001A,// Seto_rm8
				0x00910000, 0x00000004, 0x0000001A,// Setno_rm8
				0x00920000, 0x00000004, 0x0000001A,// Setb_rm8
				0x00930000, 0x00000004, 0x0000001A,// Setae_rm8
				0x00940000, 0x00000004, 0x0000001A,// Sete_rm8
				0x00950000, 0x00000004, 0x0000001A,// Setne_rm8
				0x00960000, 0x00000004, 0x0000001A,// Setbe_rm8
				0x00970000, 0x00000004, 0x0000001A,// Seta_rm8
				0x00980000, 0x00000004, 0x0000001A,// Sets_rm8
				0x00990000, 0x00000004, 0x0000001A,// Setns_rm8
				0x009A0000, 0x00000004, 0x0000001A,// Setp_rm8
				0x009B0000, 0x00000004, 0x0000001A,// Setnp_rm8
				0x009C0000, 0x00000004, 0x0000001A,// Setl_rm8
				0x009D0000, 0x00000004, 0x0000001A,// Setge_rm8
				0x009E0000, 0x00000004, 0x0000001A,// Setle_rm8
				0x009F0000, 0x00000004, 0x0000001A,// Setg_rm8
				0x00900001, 0x00000404, 0x0000091D,// VEX_Kmovw_k_km16
				0x00900001, 0x00002404, 0x0000091D,// VEX_Kmovq_k_km64
				0x00900001, 0x00000405, 0x0000091D,// VEX_Kmovb_k_km8
				0x00900001, 0x00002405, 0x0000091D,// VEX_Kmovd_k_km32
				0x00910001, 0x00000404, 0x00000758,// VEX_Kmovw_m16_k
				0x00910001, 0x00002404, 0x00000758,// VEX_Kmovq_m64_k
				0x00910001, 0x00000405, 0x00000758,// VEX_Kmovb_m8_k
				0x00910001, 0x00002405, 0x00000758,// VEX_Kmovd_m32_k
				0x00920001, 0x00000404, 0x0000025D,// VEX_Kmovw_k_r32
				0x00920001, 0x00000405, 0x0000025D,// VEX_Kmovb_k_r32
				0x00920001, 0x00000407, 0x0000025D,// VEX_Kmovd_k_r32
				0x00920001, 0x00002427, 0x0000029D,// VEX_Kmovq_k_r64
				0x00930001, 0x00000404, 0x00000683,// VEX_Kmovw_r32_k
				0x00930001, 0x00000405, 0x00000683,// VEX_Kmovb_r32_k
				0x00930001, 0x00000407, 0x00000683,// VEX_Kmovd_r32_k
				0x00930001, 0x00002427, 0x00000684,// VEX_Kmovq_r64_k
				0x00980001, 0x00000404, 0x0000069D,// VEX_Kortestw_k_k
				0x00980001, 0x00002404, 0x0000069D,// VEX_Kortestq_k_k
				0x00980001, 0x00000405, 0x0000069D,// VEX_Kortestb_k_k
				0x00980001, 0x00002405, 0x0000069D,// VEX_Kortestd_k_k
				0x00990001, 0x00000404, 0x0000069D,// VEX_Ktestw_k_k
				0x00990001, 0x00002404, 0x0000069D,// VEX_Ktestq_k_k
				0x00990001, 0x00000405, 0x0000069D,// VEX_Ktestb_k_k
				0x00990001, 0x00002405, 0x0000069D,// VEX_Ktestd_k_k
				0x00A00000, 0x00010004, 0x0000006B,// Pushw_FS
				0x00A00000, 0x00020014, 0x0000006B,// Pushd_FS
				0x00A00000, 0x00000024, 0x0000006B,// Pushq_FS
				0x00A10000, 0x00010004, 0x0000006B,// Popw_FS
				0x00A10000, 0x00020014, 0x0000006B,// Popd_FS
				0x00A10000, 0x00000024, 0x0000006B,// Popq_FS
				0x00A20000, 0x00000004, 0x00000000,// Cpuid
				0x00A30000, 0x00010004, 0x0000151B,// Bt_rm16_r16
				0x00A30000, 0x00020004, 0x0000159C,// Bt_rm32_r32
				0x00A30000, 0x00030024, 0x00001620,// Bt_rm64_r64
				0x00A40000, 0x00010004, 0x000E551B,// Shld_rm16_r16_imm8
				0x00A40000, 0x00020004, 0x000E559C,// Shld_rm32_r32_imm8
				0x00A40000, 0x00030024, 0x000E5620,// Shld_rm64_r64_imm8
				0x00A50000, 0x00010004, 0x001B951B,// Shld_rm16_r16_CL
				0x00A50000, 0x00020004, 0x001B959C,// Shld_rm32_r32_CL
				0x00A50000, 0x00030024, 0x001B9620,// Shld_rm64_r64_CL
				0xA6C00000, 0x00041414, 0x00000000,// Montmul_16
				0xA6C00000, 0x00081404, 0x00000000,// Montmul_32
				0xA6C00000, 0x00001424, 0x00000000,// Montmul_64
				0xA6C80000, 0x00041414, 0x00000000,// Xsha1_16
				0xA6C80000, 0x00081404, 0x00000000,// Xsha1_32
				0xA6C80000, 0x00001424, 0x00000000,// Xsha1_64
				0xA6D00000, 0x00041414, 0x00000000,// Xsha256_16
				0xA6D00000, 0x00081404, 0x00000000,// Xsha256_32
				0xA6D00000, 0x00001424, 0x00000000,// Xsha256_64
				0x00A60000, 0x00010014, 0x00000DAA,// Xbts_r16_rm16
				0x00A60000, 0x00020014, 0x00000E2B,// Xbts_r32_rm32
				0xA7C00000, 0x00041414, 0x00000000,// Xstore_16
				0xA7C00000, 0x00081404, 0x00000000,// Xstore_32
				0xA7C00000, 0x00001424, 0x00000000,// Xstore_64
				0xA7C80000, 0x00041414, 0x00000000,// XcryptEcb_16
				0xA7C80000, 0x00081404, 0x00000000,// XcryptEcb_32
				0xA7C80000, 0x00001424, 0x00000000,// XcryptEcb_64
				0xA7D00000, 0x00041414, 0x00000000,// XcryptCbc_16
				0xA7D00000, 0x00081404, 0x00000000,// XcryptCbc_32
				0xA7D00000, 0x00001424, 0x00000000,// XcryptCbc_64
				0xA7D80000, 0x00041414, 0x00000000,// XcryptCtr_16
				0xA7D80000, 0x00081404, 0x00000000,// XcryptCtr_32
				0xA7D80000, 0x00001424, 0x00000000,// XcryptCtr_64
				0xA7E00000, 0x00041414, 0x00000000,// XcryptCfb_16
				0xA7E00000, 0x00081404, 0x00000000,// XcryptCfb_32
				0xA7E00000, 0x00001424, 0x00000000,// XcryptCfb_64
				0xA7E80000, 0x00041414, 0x00000000,// XcryptOfb_16
				0xA7E80000, 0x00081404, 0x00000000,// XcryptOfb_32
				0xA7E80000, 0x00001424, 0x00000000,// XcryptOfb_64
				0x00A70000, 0x00010014, 0x0000151B,// Ibts_rm16_r16
				0x00A70000, 0x00020014, 0x0000159C,// Ibts_rm32_r32
				0x00A60000, 0x00000014, 0x0000149A,// Cmpxchg486_rm8_r8
				0x00A70000, 0x00010014, 0x0000151B,// Cmpxchg486_rm16_r16
				0x00A70000, 0x00020014, 0x0000159C,// Cmpxchg486_rm32_r32
				0x00A80000, 0x00010004, 0x0000006C,// Pushw_GS
				0x00A80000, 0x00020014, 0x0000006C,// Pushd_GS
				0x00A80000, 0x00000024, 0x0000006C,// Pushq_GS
				0x00A90000, 0x00010004, 0x0000006C,// Popw_GS
				0x00A90000, 0x00020014, 0x0000006C,// Popd_GS
				0x00A90000, 0x00000024, 0x0000006C,// Popq_GS
				0x00AA0000, 0x00000004, 0x00000000,// Rsm
				0x00AB0000, 0x00011C04, 0x0000151B,// Bts_rm16_r16
				0x00AB0000, 0x00021C04, 0x0000159C,// Bts_rm32_r32
				0x00AB0000, 0x00031C24, 0x00001620,// Bts_rm64_r64
				0x00AC0000, 0x00010004, 0x000E551B,// Shrd_rm16_r16_imm8
				0x00AC0000, 0x00020004, 0x000E559C,// Shrd_rm32_r32_imm8
				0x00AC0000, 0x00030024, 0x000E5620,// Shrd_rm64_r64_imm8
				0x00AD0000, 0x00010004, 0x001B951B,// Shrd_rm16_r16_CL
				0x00AD0000, 0x00020004, 0x001B959C,// Shrd_rm32_r32_CL
				0x00AD0000, 0x00030024, 0x001B9620,// Shrd_rm64_r64_CL
				0x00AE0000, 0x00008044, 0x00000003,// Fxsave_m512byte
				0x00AE0000, 0x00038064, 0x00000003,// Fxsave64_m512byte
				0x00AE0000, 0x00008066, 0x00000031,// Rdfsbase_r32
				0x00AE0000, 0x00038066, 0x00000032,// Rdfsbase_r64
				0x00AE0000, 0x000080C4, 0x00000003,// Fxrstor_m512byte
				0x00AE0000, 0x000380E4, 0x00000003,// Fxrstor64_m512byte
				0x00AE0000, 0x000080E6, 0x00000031,// Rdgsbase_r32
				0x00AE0000, 0x000380E6, 0x00000032,// Rdgsbase_r64
				0x00AE0000, 0x00008144, 0x00000014,// Ldmxcsr_m32
				0x00AE0000, 0x00008166, 0x00000031,// Wrfsbase_r32
				0x00AE0000, 0x00038166, 0x00000032,// Wrfsbase_r64
				0x00AE0001, 0x00004144, 0x00000017,// VEX_Vldmxcsr_m32
				0x00AE0000, 0x000081C4, 0x00000014,// Stmxcsr_m32
				0x00AE0000, 0x000081E6, 0x00000031,// Wrgsbase_r32
				0x00AE0000, 0x000381E6, 0x00000032,// Wrgsbase_r64
				0x00AE0001, 0x000041C4, 0x00000017,// VEX_Vstmxcsr_m32
				0x00AE0000, 0x00008244, 0x00000003,// Xsave_mem
				0x00AE0000, 0x00038264, 0x00000003,// Xsave64_mem
				0x00AE0000, 0x00008246, 0x0000001C,// Ptwrite_rm32
				0x00AE0000, 0x00038266, 0x00000020,// Ptwrite_rm64
				0x00AE0000, 0x000082C4, 0x00000003,// Xrstor_mem
				0x00AE0000, 0x000382E4, 0x00000003,// Xrstor64_mem
				0x00AE0000, 0x000082C6, 0x00000031,// Incsspd_r32
				0x00AE0000, 0x000382E6, 0x00000032,// Incsspq_r64
				0x00AE0000, 0x00008344, 0x00000003,// Xsaveopt_mem
				0x00AE0000, 0x00038364, 0x00000003,// Xsaveopt64_mem
				0x00AE0000, 0x00008345, 0x00000012,// Clwb_m8
				0x00AE0000, 0x00008345, 0x00000031,// Tpause_r32
				0x00AE0000, 0x00038365, 0x00000032,// Tpause_r64
				0x00AE0000, 0x00008346, 0x00000016,// Clrssbsy_m64
				0x00AE0000, 0x00048356, 0x00000030,// Umonitor_r16
				0x00AE0000, 0x00088346, 0x00000031,// Umonitor_r32
				0x00AE0000, 0x00008366, 0x00000032,// Umonitor_r64
				0x00AE0000, 0x00008347, 0x00000031,// Umwait_r32
				0x00AE0000, 0x00038367, 0x00000032,// Umwait_r64
				0x00AE0000, 0x000083C4, 0x00000012,// Clflush_m8
				0x00AE0000, 0x000083C5, 0x00000012,// Clflushopt_m8
				0xAEE80000, 0x00008004, 0x00000000,// Lfence
				0xAEE90000, 0x00008004, 0x00000000,// Lfence_E9
				0xAEEA0000, 0x00008004, 0x00000000,// Lfence_EA
				0xAEEB0000, 0x00008004, 0x00000000,// Lfence_EB
				0xAEEC0000, 0x00008004, 0x00000000,// Lfence_EC
				0xAEED0000, 0x00008004, 0x00000000,// Lfence_ED
				0xAEEE0000, 0x00008004, 0x00000000,// Lfence_EE
				0xAEEF0000, 0x00008004, 0x00000000,// Lfence_EF
				0xAEF00000, 0x00008004, 0x00000000,// Mfence
				0xAEF10000, 0x00008004, 0x00000000,// Mfence_F1
				0xAEF20000, 0x00008004, 0x00000000,// Mfence_F2
				0xAEF30000, 0x00008004, 0x00000000,// Mfence_F3
				0xAEF40000, 0x00008004, 0x00000000,// Mfence_F4
				0xAEF50000, 0x00008004, 0x00000000,// Mfence_F5
				0xAEF60000, 0x00008004, 0x00000000,// Mfence_F6
				0xAEF70000, 0x00008004, 0x00000000,// Mfence_F7
				0xAEF80000, 0x00008004, 0x00000000,// Sfence
				0xAEF90000, 0x00008004, 0x00000000,// Sfence_F9
				0xAEFA0000, 0x00008004, 0x00000000,// Sfence_FA
				0xAEFB0000, 0x00008004, 0x00000000,// Sfence_FB
				0xAEFC0000, 0x00008004, 0x00000000,// Sfence_FC
				0xAEFD0000, 0x00008004, 0x00000000,// Sfence_FD
				0xAEFE0000, 0x00008004, 0x00000000,// Sfence_FE
				0xAEFF0000, 0x00008004, 0x00000000,// Sfence_FF
				0xAEF80000, 0x00008005, 0x00000000,// Pcommit
				0x00AF0000, 0x00010004, 0x00000DAA,// Imul_r16_rm16
				0x00AF0000, 0x00020004, 0x00000E2B,// Imul_r32_rm32
				0x00AF0000, 0x00030024, 0x0000102C,// Imul_r64_rm64
				0x00B00000, 0x00001C04, 0x0000149A,// Cmpxchg_rm8_r8
				0x00B10000, 0x00011C04, 0x0000151B,// Cmpxchg_rm16_r16
				0x00B10000, 0x00021C04, 0x0000159C,// Cmpxchg_rm32_r32
				0x00B10000, 0x00031C24, 0x00001620,// Cmpxchg_rm64_r64
				0x00B20000, 0x00010004, 0x000007AA,// Lss_r16_m1616
				0x00B20000, 0x00020004, 0x000007AB,// Lss_r32_m1632
				0x00B20000, 0x00030024, 0x000007AC,// Lss_r64_m1664
				0x00B30000, 0x00011C04, 0x0000151B,// Btr_rm16_r16
				0x00B30000, 0x00021C04, 0x0000159C,// Btr_rm32_r32
				0x00B30000, 0x00031C24, 0x00001620,// Btr_rm64_r64
				0x00B40000, 0x00010004, 0x000007AA,// Lfs_r16_m1616
				0x00B40000, 0x00020004, 0x000007AB,// Lfs_r32_m1632
				0x00B40000, 0x00030024, 0x000007AC,// Lfs_r64_m1664
				0x00B50000, 0x00010004, 0x000007AA,// Lgs_r16_m1616
				0x00B50000, 0x00020004, 0x000007AB,// Lgs_r32_m1632
				0x00B50000, 0x00030024, 0x000007AC,// Lgs_r64_m1664
				0x00B60000, 0x00010004, 0x00000D2A,// Movzx_r16_rm8
				0x00B60000, 0x00020004, 0x00000D2B,// Movzx_r32_rm8
				0x00B60000, 0x00030024, 0x00000D2C,// Movzx_r64_rm8
				0x00B70000, 0x00010004, 0x00000DAA,// Movzx_r16_rm16
				0x00B70000, 0x00020004, 0x00000DAB,// Movzx_r32_rm16
				0x00B70000, 0x00030024, 0x00000DAC,// Movzx_r64_rm16
				0x00B80000, 0x00010014, 0x00000054,// Jmpe_disp16
				0x00B80000, 0x00020014, 0x00000055,// Jmpe_disp32
				0x00B80000, 0x00018006, 0x00000DAA,// Popcnt_r16_rm16
				0x00B80000, 0x00028006, 0x00000E2B,// Popcnt_r32_rm32
				0x00B80000, 0x00038026, 0x0000102C,// Popcnt_r64_rm64
				0x00B90000, 0x00010004, 0x00000DAA,// Ud1_r16_rm16
				0x00B90000, 0x00020004, 0x00000E2B,// Ud1_r32_rm32
				0x00B90000, 0x00030024, 0x0000102C,// Ud1_r64_rm64
				0x00BA0000, 0x00010244, 0x00001C9B,// Bt_rm16_imm8
				0x00BA0000, 0x00020244, 0x00001C9C,// Bt_rm32_imm8
				0x00BA0000, 0x00030264, 0x00001CA0,// Bt_rm64_imm8
				0x00BA0000, 0x00011EC4, 0x00001C9B,// Bts_rm16_imm8
				0x00BA0000, 0x00021EC4, 0x00001C9C,// Bts_rm32_imm8
				0x00BA0000, 0x00031EE4, 0x00001CA0,// Bts_rm64_imm8
				0x00BA0000, 0x00011F44, 0x00001C9B,// Btr_rm16_imm8
				0x00BA0000, 0x00021F44, 0x00001C9C,// Btr_rm32_imm8
				0x00BA0000, 0x00031F64, 0x00001CA0,// Btr_rm64_imm8
				0x00BA0000, 0x00011FC4, 0x00001C9B,// Btc_rm16_imm8
				0x00BA0000, 0x00021FC4, 0x00001C9C,// Btc_rm32_imm8
				0x00BA0000, 0x00031FE4, 0x00001CA0,// Btc_rm64_imm8
				0x00BB0000, 0x00011C04, 0x0000151B,// Btc_rm16_r16
				0x00BB0000, 0x00021C04, 0x0000159C,// Btc_rm32_r32
				0x00BB0000, 0x00031C24, 0x00001620,// Btc_rm64_r64
				0x00BC0000, 0x00010004, 0x00000DAA,// Bsf_r16_rm16
				0x00BC0000, 0x00020004, 0x00000E2B,// Bsf_r32_rm32
				0x00BC0000, 0x00030024, 0x0000102C,// Bsf_r64_rm64
				0x00BC0000, 0x00018006, 0x00000DAA,// Tzcnt_r16_rm16
				0x00BC0000, 0x00028006, 0x00000E2B,// Tzcnt_r32_rm32
				0x00BC0000, 0x00038026, 0x0000102C,// Tzcnt_r64_rm64
				0x00BD0000, 0x00010004, 0x00000DAA,// Bsr_r16_rm16
				0x00BD0000, 0x00020004, 0x00000E2B,// Bsr_r32_rm32
				0x00BD0000, 0x00030024, 0x0000102C,// Bsr_r64_rm64
				0x00BD0000, 0x00018006, 0x00000DAA,// Lzcnt_r16_rm16
				0x00BD0000, 0x00028006, 0x00000E2B,// Lzcnt_r32_rm32
				0x00BD0000, 0x00038026, 0x0000102C,// Lzcnt_r64_rm64
				0x00BE0000, 0x00010004, 0x00000D2A,// Movsx_r16_rm8
				0x00BE0000, 0x00020004, 0x00000D2B,// Movsx_r32_rm8
				0x00BE0000, 0x00030024, 0x00000D2C,// Movsx_r64_rm8
				0x00BF0000, 0x00010004, 0x00000DAA,// Movsx_r16_rm16
				0x00BF0000, 0x00020004, 0x00000DAB,// Movsx_r32_rm16
				0x00BF0000, 0x00030024, 0x00000DAC,// Movsx_r64_rm16
				0x00C00000, 0x00001C04, 0x0000149A,// Xadd_rm8_r8
				0x00C10000, 0x00011C04, 0x0000151B,// Xadd_rm16_r16
				0x00C10000, 0x00021C04, 0x0000159C,// Xadd_rm32_r32
				0x00C10000, 0x00031C24, 0x00001620,// Xadd_rm64_r64
				0x00C20000, 0x00008004, 0x000E7263,// Cmpps_xmm_xmmm128_imm8
				0x00C20001, 0x00004C04, 0x004253A2,// VEX_Vcmpps_xmm_xmm_xmmm128_imm8
				0x00C20001, 0x00005004, 0x004263E3,// VEX_Vcmpps_ymm_ymm_ymmm256_imm8
				0x00C20002, 0x01204004, 0x003A125C,// EVEX_Vcmpps_k_k1_xmm_xmmm128b32_imm8
				0x00C20002, 0x01208404, 0x003A229C,// EVEX_Vcmpps_k_k1_ymm_ymmm256b32_imm8
				0x00C20002, 0x01A0C804, 0x003A32DC,// EVEX_Vcmpps_k_k1_zmm_zmmm512b32_imm8_sae
				0x00C20000, 0x00008005, 0x000E7263,// Cmppd_xmm_xmmm128_imm8
				0x00C20001, 0x00004C05, 0x004253A2,// VEX_Vcmppd_xmm_xmm_xmmm128_imm8
				0x00C20001, 0x00005005, 0x004263E3,// VEX_Vcmppd_ymm_ymm_ymmm256_imm8
				0x00C20002, 0x01205005, 0x003A125C,// EVEX_Vcmppd_k_k1_xmm_xmmm128b64_imm8
				0x00C20002, 0x01209405, 0x003A229C,// EVEX_Vcmppd_k_k1_ymm_ymmm256b64_imm8
				0x00C20002, 0x01A0D805, 0x003A32DC,// EVEX_Vcmppd_k_k1_zmm_zmmm512b64_imm8_sae
				0x00C20000, 0x00008006, 0x000E7263,// Cmpss_xmm_xmmm32_imm8
				0x00C20001, 0x00005406, 0x004253A2,// VEX_Vcmpss_xmm_xmm_xmmm32_imm8
				0x00C20002, 0x01928006, 0x003A125C,// EVEX_Vcmpss_k_k1_xmm_xmmm32_imm8_sae
				0x00C20000, 0x00008007, 0x000E7263,// Cmpsd_xmm_xmmm64_imm8
				0x00C20001, 0x00005407, 0x004253A2,// VEX_Vcmpsd_xmm_xmm_xmmm64_imm8
				0x00C20002, 0x01929007, 0x003A125C,// EVEX_Vcmpsd_k_k1_xmm_xmmm64_imm8_sae
				0x00C30000, 0x00008004, 0x00001594,// Movnti_m32_r32
				0x00C30000, 0x00038024, 0x00001616,// Movnti_m64_r64
				0x00C40000, 0x00008004, 0x000E53E0,// Pinsrw_mm_r32m16_imm8
				0x00C40000, 0x00038024, 0x000E5460,// Pinsrw_mm_r64m16_imm8
				0x00C40000, 0x00008005, 0x000E53E3,// Pinsrw_xmm_r32m16_imm8
				0x00C40000, 0x00038025, 0x000E5463,// Pinsrw_xmm_r64m16_imm8
				0x00C40001, 0x00006C05, 0x004073A2,// VEX_Vpinsrw_xmm_xmm_r32m16_imm8
				0x00C40001, 0x00002C25, 0x004083A2,// VEX_Vpinsrw_xmm_xmm_r64m16_imm8
				0x00C40002, 0x00033005, 0x0038725E,// EVEX_Vpinsrw_xmm_xmm_r32m16_imm8
				0x00C40002, 0x00031025, 0x0038825E,// EVEX_Vpinsrw_xmm_xmm_r64m16_imm8
				0x00C50000, 0x00008004, 0x000E6FAB,// Pextrw_r32_mm_imm8
				0x00C50000, 0x00038024, 0x000E6FAC,// Pextrw_r64_mm_imm8
				0x00C50000, 0x00008005, 0x000E712B,// Pextrw_r32_xmm_imm8
				0x00C50000, 0x00038025, 0x000E712C,// Pextrw_r64_xmm_imm8
				0x00C50001, 0x00006C05, 0x000106C3,// VEX_Vpextrw_r32_xmm_imm8
				0x00C50001, 0x00002C25, 0x000106C4,// VEX_Vpextrw_r64_xmm_imm8
				0x00C50002, 0x00003005, 0x0000E483,// EVEX_Vpextrw_r32_xmm_imm8
				0x00C50002, 0x00001025, 0x0000E484,// EVEX_Vpextrw_r64_xmm_imm8
				0x00C60000, 0x00008004, 0x000E7263,// Shufps_xmm_xmmm128_imm8
				0x00C60001, 0x00004C04, 0x004253A2,// VEX_Vshufps_xmm_xmm_xmmm128_imm8
				0x00C60001, 0x00005004, 0x004263E3,// VEX_Vshufps_ymm_ymm_ymmm256_imm8
				0x00C60002, 0x03204004, 0x003A125E,// EVEX_Vshufps_xmm_k1z_xmm_xmmm128b32_imm8
				0x00C60002, 0x03208404, 0x003A229F,// EVEX_Vshufps_ymm_k1z_ymm_ymmm256b32_imm8
				0x00C60002, 0x0320C804, 0x003A32E0,// EVEX_Vshufps_zmm_k1z_zmm_zmmm512b32_imm8
				0x00C60000, 0x00008005, 0x000E7263,// Shufpd_xmm_xmmm128_imm8
				0x00C60001, 0x00004C05, 0x004253A2,// VEX_Vshufpd_xmm_xmm_xmmm128_imm8
				0x00C60001, 0x00005005, 0x004263E3,// VEX_Vshufpd_ymm_ymm_ymmm256_imm8
				0x00C60002, 0x03205005, 0x003A125E,// EVEX_Vshufpd_xmm_k1z_xmm_xmmm128b64_imm8
				0x00C60002, 0x03209405, 0x003A229F,// EVEX_Vshufpd_ymm_k1z_ymm_ymmm256b64_imm8
				0x00C60002, 0x0320D805, 0x003A32E0,// EVEX_Vshufpd_zmm_k1z_zmm_zmmm512b64_imm8
				0x00C70000, 0x00001CC4, 0x00000016,// Cmpxchg8b_m64
				0x00C70000, 0x000310E4, 0x00000011,// Cmpxchg16b_m128
				0x00C70000, 0x000081C4, 0x00000003,// Xrstors_mem
				0x00C70000, 0x000381E4, 0x00000003,// Xrstors64_mem
				0x00C70000, 0x00008244, 0x00000003,// Xsavec_mem
				0x00C70000, 0x00038264, 0x00000003,// Xsavec64_mem
				0x00C70000, 0x000082C4, 0x00000003,// Xsaves_mem
				0x00C70000, 0x000382E4, 0x00000003,// Xsaves64_mem
				0x00C70000, 0x00008344, 0x00000003,// Vmptrld_m64
				0x00C70000, 0x00008345, 0x00000003,// Vmclear_m64
				0x00C70000, 0x00008346, 0x00000003,// Vmxon_m64
				0x00C70000, 0x00010344, 0x00000030,// Rdrand_r16
				0x00C70000, 0x00020344, 0x00000031,// Rdrand_r32
				0x00C70000, 0x00030364, 0x00000032,// Rdrand_r64
				0x00C70000, 0x000083C4, 0x00000003,// Vmptrst_m64
				0x00C70000, 0x000103C4, 0x00000030,// Rdseed_r16
				0x00C70000, 0x000203C4, 0x00000031,// Rdseed_r32
				0x00C70000, 0x000303E4, 0x00000032,// Rdseed_r64
				0x00C70000, 0x000083D6, 0x00000031,// Rdpid_r32
				0x00C70000, 0x000083E6, 0x00000032,// Rdpid_r64
				0x00C80000, 0x00010004, 0x00000076,// Bswap_r16
				0x00C80000, 0x00020004, 0x00000077,// Bswap_r32
				0x00C80000, 0x00030024, 0x00000078,// Bswap_r64
				0x00D00000, 0x00008005, 0x00003263,// Addsubpd_xmm_xmmm128
				0x00D00001, 0x00004C05, 0x000253A2,// VEX_Vaddsubpd_xmm_xmm_xmmm128
				0x00D00001, 0x00005005, 0x000263E3,// VEX_Vaddsubpd_ymm_ymm_ymmm256
				0x00D00000, 0x00008007, 0x00003263,// Addsubps_xmm_xmmm128
				0x00D00001, 0x00004C07, 0x000253A2,// VEX_Vaddsubps_xmm_xmm_xmmm128
				0x00D00001, 0x00005007, 0x000263E3,// VEX_Vaddsubps_ymm_ymm_ymmm256
				0x00D10000, 0x00008004, 0x000030E0,// Psrlw_mm_mmm64
				0x00D10000, 0x00008005, 0x00003263,// Psrlw_xmm_xmmm128
				0x00D10001, 0x00004C05, 0x000253A2,// VEX_Vpsrlw_xmm_xmm_xmmm128
				0x00D10001, 0x00005005, 0x000253E3,// VEX_Vpsrlw_ymm_ymm_xmmm128
				0x00D10002, 0x0307A005, 0x0002125E,// EVEX_Vpsrlw_xmm_k1z_xmm_xmmm128
				0x00D10002, 0x0307A405, 0x0002129F,// EVEX_Vpsrlw_ymm_k1z_ymm_xmmm128
				0x00D10002, 0x0307A805, 0x000212E0,// EVEX_Vpsrlw_zmm_k1z_zmm_xmmm128
				0x00D20000, 0x00008004, 0x000030E0,// Psrld_mm_mmm64
				0x00D20000, 0x00008005, 0x00003263,// Psrld_xmm_xmmm128
				0x00D20001, 0x00004C05, 0x000253A2,// VEX_Vpsrld_xmm_xmm_xmmm128
				0x00D20001, 0x00005005, 0x000253E3,// VEX_Vpsrld_ymm_ymm_xmmm128
				0x00D20002, 0x03078005, 0x0002125E,// EVEX_Vpsrld_xmm_k1z_xmm_xmmm128
				0x00D20002, 0x03078405, 0x0002129F,// EVEX_Vpsrld_ymm_k1z_ymm_xmmm128
				0x00D20002, 0x03078805, 0x000212E0,// EVEX_Vpsrld_zmm_k1z_zmm_xmmm128
				0x00D30000, 0x00008004, 0x000030E0,// Psrlq_mm_mmm64
				0x00D30000, 0x00008005, 0x00003263,// Psrlq_xmm_xmmm128
				0x00D30001, 0x00004C05, 0x000253A2,// VEX_Vpsrlq_xmm_xmm_xmmm128
				0x00D30001, 0x00005005, 0x000253E3,// VEX_Vpsrlq_ymm_ymm_xmmm128
				0x00D30002, 0x03079005, 0x0002125E,// EVEX_Vpsrlq_xmm_k1z_xmm_xmmm128
				0x00D30002, 0x03079405, 0x0002129F,// EVEX_Vpsrlq_ymm_k1z_ymm_xmmm128
				0x00D30002, 0x03079805, 0x000212E0,// EVEX_Vpsrlq_zmm_k1z_zmm_xmmm128
				0x00D40000, 0x00008004, 0x000030E0,// Paddq_mm_mmm64
				0x00D40000, 0x00008005, 0x00003263,// Paddq_xmm_xmmm128
				0x00D40001, 0x00004C05, 0x000253A2,// VEX_Vpaddq_xmm_xmm_xmmm128
				0x00D40001, 0x00005005, 0x000263E3,// VEX_Vpaddq_ymm_ymm_ymmm256
				0x00D40002, 0x03205005, 0x0002125E,// EVEX_Vpaddq_xmm_k1z_xmm_xmmm128b64
				0x00D40002, 0x03209405, 0x0002229F,// EVEX_Vpaddq_ymm_k1z_ymm_ymmm256b64
				0x00D40002, 0x0320D805, 0x000232E0,// EVEX_Vpaddq_zmm_k1z_zmm_zmmm512b64
				0x00D50000, 0x00008004, 0x000030E0,// Pmullw_mm_mmm64
				0x00D50000, 0x00008005, 0x00003263,// Pmullw_xmm_xmmm128
				0x00D50001, 0x00004C05, 0x000253A2,// VEX_Vpmullw_xmm_xmm_xmmm128
				0x00D50001, 0x00005005, 0x000263E3,// VEX_Vpmullw_ymm_ymm_ymmm256
				0x00D50002, 0x0301E005, 0x0002125E,// EVEX_Vpmullw_xmm_k1z_xmm_xmmm128
				0x00D50002, 0x03022405, 0x0002229F,// EVEX_Vpmullw_ymm_k1z_ymm_ymmm256
				0x00D50002, 0x03026805, 0x000232E0,// EVEX_Vpmullw_zmm_k1z_zmm_zmmm512
				0x00D60000, 0x00008005, 0x000031E4,// Movq_xmmm64_xmm
				0x00D60001, 0x00004C05, 0x000008A5,// VEX_Vmovq_xmmm64_xmm
				0x00D60002, 0x00029005, 0x000007A1,// EVEX_Vmovq_xmmm64_xmm
				0x00D60000, 0x00008006, 0x00002FE3,// Movq2dq_xmm_mm
				0x00D60000, 0x00008007, 0x00003160,// Movdq2q_mm_xmm
				0x00D70000, 0x00008004, 0x00002FAB,// Pmovmskb_r32_mm
				0x00D70000, 0x00038024, 0x00002FAC,// Pmovmskb_r64_mm
				0x00D70000, 0x00008005, 0x0000312B,// Pmovmskb_r32_xmm
				0x00D70000, 0x00038025, 0x0000312C,// Pmovmskb_r64_xmm
				0x00D70001, 0x00006C05, 0x000006C3,// VEX_Vpmovmskb_r32_xmm
				0x00D70001, 0x00002C25, 0x000006C4,// VEX_Vpmovmskb_r64_xmm
				0x00D70001, 0x00007005, 0x00000703,// VEX_Vpmovmskb_r32_ymm
				0x00D70001, 0x00003025, 0x00000704,// VEX_Vpmovmskb_r64_ymm
				0x00D80000, 0x00008004, 0x000030E0,// Psubusb_mm_mmm64
				0x00D80000, 0x00008005, 0x00003263,// Psubusb_xmm_xmmm128
				0x00D80001, 0x00004C05, 0x000253A2,// VEX_Vpsubusb_xmm_xmm_xmmm128
				0x00D80001, 0x00005005, 0x000263E3,// VEX_Vpsubusb_ymm_ymm_ymmm256
				0x00D80002, 0x0301E005, 0x0002125E,// EVEX_Vpsubusb_xmm_k1z_xmm_xmmm128
				0x00D80002, 0x03022405, 0x0002229F,// EVEX_Vpsubusb_ymm_k1z_ymm_ymmm256
				0x00D80002, 0x03026805, 0x000232E0,// EVEX_Vpsubusb_zmm_k1z_zmm_zmmm512
				0x00D90000, 0x00008004, 0x000030E0,// Psubusw_mm_mmm64
				0x00D90000, 0x00008005, 0x00003263,// Psubusw_xmm_xmmm128
				0x00D90001, 0x00004C05, 0x000253A2,// VEX_Vpsubusw_xmm_xmm_xmmm128
				0x00D90001, 0x00005005, 0x000263E3,// VEX_Vpsubusw_ymm_ymm_ymmm256
				0x00D90002, 0x0301E005, 0x0002125E,// EVEX_Vpsubusw_xmm_k1z_xmm_xmmm128
				0x00D90002, 0x03022405, 0x0002229F,// EVEX_Vpsubusw_ymm_k1z_ymm_ymmm256
				0x00D90002, 0x03026805, 0x000232E0,// EVEX_Vpsubusw_zmm_k1z_zmm_zmmm512
				0x00DA0000, 0x00008004, 0x000030E0,// Pminub_mm_mmm64
				0x00DA0000, 0x00008005, 0x00003263,// Pminub_xmm_xmmm128
				0x00DA0001, 0x00004C05, 0x000253A2,// VEX_Vpminub_xmm_xmm_xmmm128
				0x00DA0001, 0x00005005, 0x000263E3,// VEX_Vpminub_ymm_ymm_ymmm256
				0x00DA0002, 0x0301E005, 0x0002125E,// EVEX_Vpminub_xmm_k1z_xmm_xmmm128
				0x00DA0002, 0x03022405, 0x0002229F,// EVEX_Vpminub_ymm_k1z_ymm_ymmm256
				0x00DA0002, 0x03026805, 0x000232E0,// EVEX_Vpminub_zmm_k1z_zmm_zmmm512
				0x00DB0000, 0x00008004, 0x000030E0,// Pand_mm_mmm64
				0x00DB0000, 0x00008005, 0x00003263,// Pand_xmm_xmmm128
				0x00DB0001, 0x00004C05, 0x000253A2,// VEX_Vpand_xmm_xmm_xmmm128
				0x00DB0001, 0x00005005, 0x000263E3,// VEX_Vpand_ymm_ymm_ymmm256
				0x00DB0002, 0x03204005, 0x0002125E,// EVEX_Vpandd_xmm_k1z_xmm_xmmm128b32
				0x00DB0002, 0x03208405, 0x0002229F,// EVEX_Vpandd_ymm_k1z_ymm_ymmm256b32
				0x00DB0002, 0x0320C805, 0x000232E0,// EVEX_Vpandd_zmm_k1z_zmm_zmmm512b32
				0x00DB0002, 0x03205005, 0x0002125E,// EVEX_Vpandq_xmm_k1z_xmm_xmmm128b64
				0x00DB0002, 0x03209405, 0x0002229F,// EVEX_Vpandq_ymm_k1z_ymm_ymmm256b64
				0x00DB0002, 0x0320D805, 0x000232E0,// EVEX_Vpandq_zmm_k1z_zmm_zmmm512b64
				0x00DC0000, 0x00008004, 0x000030E0,// Paddusb_mm_mmm64
				0x00DC0000, 0x00008005, 0x00003263,// Paddusb_xmm_xmmm128
				0x00DC0001, 0x00004C05, 0x000253A2,// VEX_Vpaddusb_xmm_xmm_xmmm128
				0x00DC0001, 0x00005005, 0x000263E3,// VEX_Vpaddusb_ymm_ymm_ymmm256
				0x00DC0002, 0x0301E005, 0x0002125E,// EVEX_Vpaddusb_xmm_k1z_xmm_xmmm128
				0x00DC0002, 0x03022405, 0x0002229F,// EVEX_Vpaddusb_ymm_k1z_ymm_ymmm256
				0x00DC0002, 0x03026805, 0x000232E0,// EVEX_Vpaddusb_zmm_k1z_zmm_zmmm512
				0x00DD0000, 0x00008004, 0x000030E0,// Paddusw_mm_mmm64
				0x00DD0000, 0x00008005, 0x00003263,// Paddusw_xmm_xmmm128
				0x00DD0001, 0x00004C05, 0x000253A2,// VEX_Vpaddusw_xmm_xmm_xmmm128
				0x00DD0001, 0x00005005, 0x000263E3,// VEX_Vpaddusw_ymm_ymm_ymmm256
				0x00DD0002, 0x0301E005, 0x0002125E,// EVEX_Vpaddusw_xmm_k1z_xmm_xmmm128
				0x00DD0002, 0x03022405, 0x0002229F,// EVEX_Vpaddusw_ymm_k1z_ymm_ymmm256
				0x00DD0002, 0x03026805, 0x000232E0,// EVEX_Vpaddusw_zmm_k1z_zmm_zmmm512
				0x00DE0000, 0x00008004, 0x000030E0,// Pmaxub_mm_mmm64
				0x00DE0000, 0x00008005, 0x00003263,// Pmaxub_xmm_xmmm128
				0x00DE0001, 0x00004C05, 0x000253A2,// VEX_Vpmaxub_xmm_xmm_xmmm128
				0x00DE0001, 0x00005005, 0x000263E3,// VEX_Vpmaxub_ymm_ymm_ymmm256
				0x00DE0002, 0x0301E005, 0x0002125E,// EVEX_Vpmaxub_xmm_k1z_xmm_xmmm128
				0x00DE0002, 0x03022405, 0x0002229F,// EVEX_Vpmaxub_ymm_k1z_ymm_ymmm256
				0x00DE0002, 0x03026805, 0x000232E0,// EVEX_Vpmaxub_zmm_k1z_zmm_zmmm512
				0x00DF0000, 0x00008004, 0x000030E0,// Pandn_mm_mmm64
				0x00DF0000, 0x00008005, 0x00003263,// Pandn_xmm_xmmm128
				0x00DF0001, 0x00004C05, 0x000253A2,// VEX_Vpandn_xmm_xmm_xmmm128
				0x00DF0001, 0x00005005, 0x000263E3,// VEX_Vpandn_ymm_ymm_ymmm256
				0x00DF0002, 0x03204005, 0x0002125E,// EVEX_Vpandnd_xmm_k1z_xmm_xmmm128b32
				0x00DF0002, 0x03208405, 0x0002229F,// EVEX_Vpandnd_ymm_k1z_ymm_ymmm256b32
				0x00DF0002, 0x0320C805, 0x000232E0,// EVEX_Vpandnd_zmm_k1z_zmm_zmmm512b32
				0x00DF0002, 0x03205005, 0x0002125E,// EVEX_Vpandnq_xmm_k1z_xmm_xmmm128b64
				0x00DF0002, 0x03209405, 0x0002229F,// EVEX_Vpandnq_ymm_k1z_ymm_ymmm256b64
				0x00DF0002, 0x0320D805, 0x000232E0,// EVEX_Vpandnq_zmm_k1z_zmm_zmmm512b64
				0x00E00000, 0x00008004, 0x000030E0,// Pavgb_mm_mmm64
				0x00E00000, 0x00008005, 0x00003263,// Pavgb_xmm_xmmm128
				0x00E00001, 0x00004C05, 0x000253A2,// VEX_Vpavgb_xmm_xmm_xmmm128
				0x00E00001, 0x00005005, 0x000263E3,// VEX_Vpavgb_ymm_ymm_ymmm256
				0x00E00002, 0x0301E005, 0x0002125E,// EVEX_Vpavgb_xmm_k1z_xmm_xmmm128
				0x00E00002, 0x03022405, 0x0002229F,// EVEX_Vpavgb_ymm_k1z_ymm_ymmm256
				0x00E00002, 0x03026805, 0x000232E0,// EVEX_Vpavgb_zmm_k1z_zmm_zmmm512
				0x00E10000, 0x00008004, 0x000030E0,// Psraw_mm_mmm64
				0x00E10000, 0x00008005, 0x00003263,// Psraw_xmm_xmmm128
				0x00E10001, 0x00004C05, 0x000253A2,// VEX_Vpsraw_xmm_xmm_xmmm128
				0x00E10001, 0x00005005, 0x000253E3,// VEX_Vpsraw_ymm_ymm_xmmm128
				0x00E10002, 0x0307A005, 0x0002125E,// EVEX_Vpsraw_xmm_k1z_xmm_xmmm128
				0x00E10002, 0x0307A405, 0x0002129F,// EVEX_Vpsraw_ymm_k1z_ymm_xmmm128
				0x00E10002, 0x0307A805, 0x000212E0,// EVEX_Vpsraw_zmm_k1z_zmm_xmmm128
				0x00E20000, 0x00008004, 0x000030E0,// Psrad_mm_mmm64
				0x00E20000, 0x00008005, 0x00003263,// Psrad_xmm_xmmm128
				0x00E20001, 0x00004C05, 0x000253A2,// VEX_Vpsrad_xmm_xmm_xmmm128
				0x00E20001, 0x00005005, 0x000253E3,// VEX_Vpsrad_ymm_ymm_xmmm128
				0x00E20002, 0x03078005, 0x0002125E,// EVEX_Vpsrad_xmm_k1z_xmm_xmmm128
				0x00E20002, 0x03078405, 0x0002129F,// EVEX_Vpsrad_ymm_k1z_ymm_xmmm128
				0x00E20002, 0x03078805, 0x000212E0,// EVEX_Vpsrad_zmm_k1z_zmm_xmmm128
				0x00E20002, 0x03079005, 0x0002125E,// EVEX_Vpsraq_xmm_k1z_xmm_xmmm128
				0x00E20002, 0x03079405, 0x0002129F,// EVEX_Vpsraq_ymm_k1z_ymm_xmmm128
				0x00E20002, 0x03079805, 0x000212E0,// EVEX_Vpsraq_zmm_k1z_zmm_xmmm128
				0x00E30000, 0x00008004, 0x000030E0,// Pavgw_mm_mmm64
				0x00E30000, 0x00008005, 0x00003263,// Pavgw_xmm_xmmm128
				0x00E30001, 0x00004C05, 0x000253A2,// VEX_Vpavgw_xmm_xmm_xmmm128
				0x00E30001, 0x00005005, 0x000263E3,// VEX_Vpavgw_ymm_ymm_ymmm256
				0x00E30002, 0x0301E005, 0x0002125E,// EVEX_Vpavgw_xmm_k1z_xmm_xmmm128
				0x00E30002, 0x03022405, 0x0002229F,// EVEX_Vpavgw_ymm_k1z_ymm_ymmm256
				0x00E30002, 0x03026805, 0x000232E0,// EVEX_Vpavgw_zmm_k1z_zmm_zmmm512
				0x00E40000, 0x00008004, 0x000030E0,// Pmulhuw_mm_mmm64
				0x00E40000, 0x00008005, 0x00003263,// Pmulhuw_xmm_xmmm128
				0x00E40001, 0x00004C05, 0x000253A2,// VEX_Vpmulhuw_xmm_xmm_xmmm128
				0x00E40001, 0x00005005, 0x000263E3,// VEX_Vpmulhuw_ymm_ymm_ymmm256
				0x00E40002, 0x0301E005, 0x0002125E,// EVEX_Vpmulhuw_xmm_k1z_xmm_xmmm128
				0x00E40002, 0x03022405, 0x0002229F,// EVEX_Vpmulhuw_ymm_k1z_ymm_ymmm256
				0x00E40002, 0x03026805, 0x000232E0,// EVEX_Vpmulhuw_zmm_k1z_zmm_zmmm512
				0x00E50000, 0x00008004, 0x000030E0,// Pmulhw_mm_mmm64
				0x00E50000, 0x00008005, 0x00003263,// Pmulhw_xmm_xmmm128
				0x00E50001, 0x00004C05, 0x000253A2,// VEX_Vpmulhw_xmm_xmm_xmmm128
				0x00E50001, 0x00005005, 0x000263E3,// VEX_Vpmulhw_ymm_ymm_ymmm256
				0x00E50002, 0x0301E005, 0x0002125E,// EVEX_Vpmulhw_xmm_k1z_xmm_xmmm128
				0x00E50002, 0x03022405, 0x0002229F,// EVEX_Vpmulhw_ymm_k1z_ymm_ymmm256
				0x00E50002, 0x03026805, 0x000232E0,// EVEX_Vpmulhw_zmm_k1z_zmm_zmmm512
				0x00E60000, 0x00008005, 0x00003263,// Cvttpd2dq_xmm_xmmm128
				0x00E60001, 0x00004C05, 0x00000962,// VEX_Vcvttpd2dq_xmm_xmmm128
				0x00E60001, 0x00005005, 0x000009A2,// VEX_Vcvttpd2dq_xmm_ymmm256
				0x00E60002, 0x03205005, 0x0000085E,// EVEX_Vcvttpd2dq_xmm_k1z_xmmm128b64
				0x00E60002, 0x03209405, 0x0000089E,// EVEX_Vcvttpd2dq_xmm_k1z_ymmm256b64
				0x00E60002, 0x03A0D805, 0x000008DF,// EVEX_Vcvttpd2dq_ymm_k1z_zmmm512b64_sae
				0x00E60000, 0x00008006, 0x00003263,// Cvtdq2pd_xmm_xmmm64
				0x00E60001, 0x00004C06, 0x00000962,// VEX_Vcvtdq2pd_xmm_xmmm64
				0x00E60001, 0x00005006, 0x00000963,// VEX_Vcvtdq2pd_ymm_xmmm128
				0x00E60002, 0x03210006, 0x0000085E,// EVEX_Vcvtdq2pd_xmm_k1z_xmmm64b32
				0x00E60002, 0x03214406, 0x0000085F,// EVEX_Vcvtdq2pd_ymm_k1z_xmmm128b32
				0x00E60002, 0x03218806, 0x000008A0,// EVEX_Vcvtdq2pd_zmm_k1z_ymmm256b32
				0x00E60002, 0x03205006, 0x0000085E,// EVEX_Vcvtqq2pd_xmm_k1z_xmmm128b64
				0x00E60002, 0x03209406, 0x0000089F,// EVEX_Vcvtqq2pd_ymm_k1z_ymmm256b64
				0x00E60002, 0x0360D806, 0x000008E0,// EVEX_Vcvtqq2pd_zmm_k1z_zmmm512b64_er
				0x00E60000, 0x00008007, 0x00003263,// Cvtpd2dq_xmm_xmmm128
				0x00E60001, 0x00004C07, 0x00000962,// VEX_Vcvtpd2dq_xmm_xmmm128
				0x00E60001, 0x00005007, 0x000009A2,// VEX_Vcvtpd2dq_xmm_ymmm256
				0x00E60002, 0x03205007, 0x0000085E,// EVEX_Vcvtpd2dq_xmm_k1z_xmmm128b64
				0x00E60002, 0x03209407, 0x0000089E,// EVEX_Vcvtpd2dq_xmm_k1z_ymmm256b64
				0x00E60002, 0x0360D807, 0x000008DF,// EVEX_Vcvtpd2dq_ymm_k1z_zmmm512b64_er
				0x00E70000, 0x00008004, 0x00003003,// Movntq_m64_mm
				0x00E70000, 0x00008005, 0x00003183,// Movntdq_m128_xmm
				0x00E70001, 0x00004C05, 0x00000896,// VEX_Vmovntdq_m128_xmm
				0x00E70001, 0x00005005, 0x000008D6,// VEX_Vmovntdq_m256_ymm
				0x00E70002, 0x0001C005, 0x0000078F,// EVEX_Vmovntdq_m128_xmm
				0x00E70002, 0x00020405, 0x000007CF,// EVEX_Vmovntdq_m256_ymm
				0x00E70002, 0x00024805, 0x0000080F,// EVEX_Vmovntdq_m512_zmm
				0x00E80000, 0x00008004, 0x000030E0,// Psubsb_mm_mmm64
				0x00E80000, 0x00008005, 0x00003263,// Psubsb_xmm_xmmm128
				0x00E80001, 0x00004C05, 0x000253A2,// VEX_Vpsubsb_xmm_xmm_xmmm128
				0x00E80001, 0x00005005, 0x000263E3,// VEX_Vpsubsb_ymm_ymm_ymmm256
				0x00E80002, 0x0301E005, 0x0002125E,// EVEX_Vpsubsb_xmm_k1z_xmm_xmmm128
				0x00E80002, 0x03022405, 0x0002229F,// EVEX_Vpsubsb_ymm_k1z_ymm_ymmm256
				0x00E80002, 0x03026805, 0x000232E0,// EVEX_Vpsubsb_zmm_k1z_zmm_zmmm512
				0x00E90000, 0x00008004, 0x000030E0,// Psubsw_mm_mmm64
				0x00E90000, 0x00008005, 0x00003263,// Psubsw_xmm_xmmm128
				0x00E90001, 0x00004C05, 0x000253A2,// VEX_Vpsubsw_xmm_xmm_xmmm128
				0x00E90001, 0x00005005, 0x000263E3,// VEX_Vpsubsw_ymm_ymm_ymmm256
				0x00E90002, 0x0301E005, 0x0002125E,// EVEX_Vpsubsw_xmm_k1z_xmm_xmmm128
				0x00E90002, 0x03022405, 0x0002229F,// EVEX_Vpsubsw_ymm_k1z_ymm_ymmm256
				0x00E90002, 0x03026805, 0x000232E0,// EVEX_Vpsubsw_zmm_k1z_zmm_zmmm512
				0x00EA0000, 0x00008004, 0x000030E0,// Pminsw_mm_mmm64
				0x00EA0000, 0x00008005, 0x00003263,// Pminsw_xmm_xmmm128
				0x00EA0001, 0x00004C05, 0x000253A2,// VEX_Vpminsw_xmm_xmm_xmmm128
				0x00EA0001, 0x00005005, 0x000263E3,// VEX_Vpminsw_ymm_ymm_ymmm256
				0x00EA0002, 0x0301E005, 0x0002125E,// EVEX_Vpminsw_xmm_k1z_xmm_xmmm128
				0x00EA0002, 0x03022405, 0x0002229F,// EVEX_Vpminsw_ymm_k1z_ymm_ymmm256
				0x00EA0002, 0x03026805, 0x000232E0,// EVEX_Vpminsw_zmm_k1z_zmm_zmmm512
				0x00EB0000, 0x00008004, 0x000030E0,// Por_mm_mmm64
				0x00EB0000, 0x00008005, 0x00003263,// Por_xmm_xmmm128
				0x00EB0001, 0x00004C05, 0x000253A2,// VEX_Vpor_xmm_xmm_xmmm128
				0x00EB0001, 0x00005005, 0x000263E3,// VEX_Vpor_ymm_ymm_ymmm256
				0x00EB0002, 0x03204005, 0x0002125E,// EVEX_Vpord_xmm_k1z_xmm_xmmm128b32
				0x00EB0002, 0x03208405, 0x0002229F,// EVEX_Vpord_ymm_k1z_ymm_ymmm256b32
				0x00EB0002, 0x0320C805, 0x000232E0,// EVEX_Vpord_zmm_k1z_zmm_zmmm512b32
				0x00EB0002, 0x03205005, 0x0002125E,// EVEX_Vporq_xmm_k1z_xmm_xmmm128b64
				0x00EB0002, 0x03209405, 0x0002229F,// EVEX_Vporq_ymm_k1z_ymm_ymmm256b64
				0x00EB0002, 0x0320D805, 0x000232E0,// EVEX_Vporq_zmm_k1z_zmm_zmmm512b64
				0x00EC0000, 0x00008004, 0x000030E0,// Paddsb_mm_mmm64
				0x00EC0000, 0x00008005, 0x00003263,// Paddsb_xmm_xmmm128
				0x00EC0001, 0x00004C05, 0x000253A2,// VEX_Vpaddsb_xmm_xmm_xmmm128
				0x00EC0001, 0x00005005, 0x000263E3,// VEX_Vpaddsb_ymm_ymm_ymmm256
				0x00EC0002, 0x0301E005, 0x0002125E,// EVEX_Vpaddsb_xmm_k1z_xmm_xmmm128
				0x00EC0002, 0x03022405, 0x0002229F,// EVEX_Vpaddsb_ymm_k1z_ymm_ymmm256
				0x00EC0002, 0x03026805, 0x000232E0,// EVEX_Vpaddsb_zmm_k1z_zmm_zmmm512
				0x00ED0000, 0x00008004, 0x000030E0,// Paddsw_mm_mmm64
				0x00ED0000, 0x00008005, 0x00003263,// Paddsw_xmm_xmmm128
				0x00ED0001, 0x00004C05, 0x000253A2,// VEX_Vpaddsw_xmm_xmm_xmmm128
				0x00ED0001, 0x00005005, 0x000263E3,// VEX_Vpaddsw_ymm_ymm_ymmm256
				0x00ED0002, 0x0301E005, 0x0002125E,// EVEX_Vpaddsw_xmm_k1z_xmm_xmmm128
				0x00ED0002, 0x03022405, 0x0002229F,// EVEX_Vpaddsw_ymm_k1z_ymm_ymmm256
				0x00ED0002, 0x03026805, 0x000232E0,// EVEX_Vpaddsw_zmm_k1z_zmm_zmmm512
				0x00EE0000, 0x00008004, 0x000030E0,// Pmaxsw_mm_mmm64
				0x00EE0000, 0x00008005, 0x00003263,// Pmaxsw_xmm_xmmm128
				0x00EE0001, 0x00004C05, 0x000253A2,// VEX_Vpmaxsw_xmm_xmm_xmmm128
				0x00EE0001, 0x00005005, 0x000263E3,// VEX_Vpmaxsw_ymm_ymm_ymmm256
				0x00EE0002, 0x0301E005, 0x0002125E,// EVEX_Vpmaxsw_xmm_k1z_xmm_xmmm128
				0x00EE0002, 0x03022405, 0x0002229F,// EVEX_Vpmaxsw_ymm_k1z_ymm_ymmm256
				0x00EE0002, 0x03026805, 0x000232E0,// EVEX_Vpmaxsw_zmm_k1z_zmm_zmmm512
				0x00EF0000, 0x00008004, 0x000030E0,// Pxor_mm_mmm64
				0x00EF0000, 0x00008005, 0x00003263,// Pxor_xmm_xmmm128
				0x00EF0001, 0x00004C05, 0x000253A2,// VEX_Vpxor_xmm_xmm_xmmm128
				0x00EF0001, 0x00005005, 0x000263E3,// VEX_Vpxor_ymm_ymm_ymmm256
				0x00EF0002, 0x03204005, 0x0002125E,// EVEX_Vpxord_xmm_k1z_xmm_xmmm128b32
				0x00EF0002, 0x03208405, 0x0002229F,// EVEX_Vpxord_ymm_k1z_ymm_ymmm256b32
				0x00EF0002, 0x0320C805, 0x000232E0,// EVEX_Vpxord_zmm_k1z_zmm_zmmm512b32
				0x00EF0002, 0x03205005, 0x0002125E,// EVEX_Vpxorq_xmm_k1z_xmm_xmmm128b64
				0x00EF0002, 0x03209405, 0x0002229F,// EVEX_Vpxorq_ymm_k1z_ymm_ymmm256b64
				0x00EF0002, 0x0320D805, 0x000232E0,// EVEX_Vpxorq_zmm_k1z_zmm_zmmm512b64
				0x00F00000, 0x00008007, 0x000001E3,// Lddqu_xmm_m128
				0x00F00001, 0x00004C07, 0x000005A2,// VEX_Vlddqu_xmm_m128
				0x00F00001, 0x00005007, 0x000005A3,// VEX_Vlddqu_ymm_m256
				0x00F10000, 0x00008004, 0x000030E0,// Psllw_mm_mmm64
				0x00F10000, 0x00008005, 0x00003263,// Psllw_xmm_xmmm128
				0x00F10001, 0x00004C05, 0x000253A2,// VEX_Vpsllw_xmm_xmm_xmmm128
				0x00F10001, 0x00005005, 0x000253E3,// VEX_Vpsllw_ymm_ymm_xmmm128
				0x00F10002, 0x0307A005, 0x0002125E,// EVEX_Vpsllw_xmm_k1z_xmm_xmmm128
				0x00F10002, 0x0307A405, 0x0002129F,// EVEX_Vpsllw_ymm_k1z_ymm_xmmm128
				0x00F10002, 0x0307A805, 0x000212E0,// EVEX_Vpsllw_zmm_k1z_zmm_xmmm128
				0x00F20000, 0x00008004, 0x000030E0,// Pslld_mm_mmm64
				0x00F20000, 0x00008005, 0x00003263,// Pslld_xmm_xmmm128
				0x00F20001, 0x00004C05, 0x000253A2,// VEX_Vpslld_xmm_xmm_xmmm128
				0x00F20001, 0x00005005, 0x000253E3,// VEX_Vpslld_ymm_ymm_xmmm128
				0x00F20002, 0x03078005, 0x0002125E,// EVEX_Vpslld_xmm_k1z_xmm_xmmm128
				0x00F20002, 0x03078405, 0x0002129F,// EVEX_Vpslld_ymm_k1z_ymm_xmmm128
				0x00F20002, 0x03078805, 0x000212E0,// EVEX_Vpslld_zmm_k1z_zmm_xmmm128
				0x00F30000, 0x00008004, 0x000030E0,// Psllq_mm_mmm64
				0x00F30000, 0x00008005, 0x00003263,// Psllq_xmm_xmmm128
				0x00F30001, 0x00004C05, 0x000253A2,// VEX_Vpsllq_xmm_xmm_xmmm128
				0x00F30001, 0x00005005, 0x000253E3,// VEX_Vpsllq_ymm_ymm_xmmm128
				0x00F30002, 0x03079005, 0x0002125E,// EVEX_Vpsllq_xmm_k1z_xmm_xmmm128
				0x00F30002, 0x03079405, 0x0002129F,// EVEX_Vpsllq_ymm_k1z_ymm_xmmm128
				0x00F30002, 0x03079805, 0x000212E0,// EVEX_Vpsllq_zmm_k1z_zmm_xmmm128
				0x00F40000, 0x00008004, 0x000030E0,// Pmuludq_mm_mmm64
				0x00F40000, 0x00008005, 0x00003263,// Pmuludq_xmm_xmmm128
				0x00F40001, 0x00004C05, 0x000253A2,// VEX_Vpmuludq_xmm_xmm_xmmm128
				0x00F40001, 0x00005005, 0x000263E3,// VEX_Vpmuludq_ymm_ymm_ymmm256
				0x00F40002, 0x03205005, 0x0002125E,// EVEX_Vpmuludq_xmm_k1z_xmm_xmmm128b64
				0x00F40002, 0x03209405, 0x0002229F,// EVEX_Vpmuludq_ymm_k1z_ymm_ymmm256b64
				0x00F40002, 0x0320D805, 0x000232E0,// EVEX_Vpmuludq_zmm_k1z_zmm_zmmm512b64
				0x00F50000, 0x00008004, 0x000030E0,// Pmaddwd_mm_mmm64
				0x00F50000, 0x00008005, 0x00003263,// Pmaddwd_xmm_xmmm128
				0x00F50001, 0x00004C05, 0x000253A2,// VEX_Vpmaddwd_xmm_xmm_xmmm128
				0x00F50001, 0x00005005, 0x000263E3,// VEX_Vpmaddwd_ymm_ymm_ymmm256
				0x00F50002, 0x0301E005, 0x0002125E,// EVEX_Vpmaddwd_xmm_k1z_xmm_xmmm128
				0x00F50002, 0x03022405, 0x0002229F,// EVEX_Vpmaddwd_ymm_k1z_ymm_ymmm256
				0x00F50002, 0x03026805, 0x000232E0,// EVEX_Vpmaddwd_zmm_k1z_zmm_zmmm512
				0x00F60000, 0x00008004, 0x000030E0,// Psadbw_mm_mmm64
				0x00F60000, 0x00008005, 0x00003263,// Psadbw_xmm_xmmm128
				0x00F60001, 0x00004C05, 0x000253A2,// VEX_Vpsadbw_xmm_xmm_xmmm128
				0x00F60001, 0x00005005, 0x000263E3,// VEX_Vpsadbw_ymm_ymm_ymmm256
				0x00F60002, 0x0001E005, 0x0002125E,// EVEX_Vpsadbw_xmm_xmm_xmmm128
				0x00F60002, 0x00022405, 0x0002229F,// EVEX_Vpsadbw_ymm_ymm_ymmm256
				0x00F60002, 0x00026805, 0x000232E0,// EVEX_Vpsadbw_zmm_zmm_zmmm512
				0x00F70000, 0x00008004, 0x0017F065,// Maskmovq_rDI_mm_mm
				0x00F70000, 0x00008005, 0x0018B1E5,// Maskmovdqu_rDI_xmm_xmm
				0x00F70001, 0x00004C05, 0x0001B899,// VEX_Vmaskmovdqu_rDI_xmm_xmm
				0x00F80000, 0x00008004, 0x000030E0,// Psubb_mm_mmm64
				0x00F80000, 0x00008005, 0x00003263,// Psubb_xmm_xmmm128
				0x00F80001, 0x00004C05, 0x000253A2,// VEX_Vpsubb_xmm_xmm_xmmm128
				0x00F80001, 0x00005005, 0x000263E3,// VEX_Vpsubb_ymm_ymm_ymmm256
				0x00F80002, 0x0301E005, 0x0002125E,// EVEX_Vpsubb_xmm_k1z_xmm_xmmm128
				0x00F80002, 0x03022405, 0x0002229F,// EVEX_Vpsubb_ymm_k1z_ymm_ymmm256
				0x00F80002, 0x03026805, 0x000232E0,// EVEX_Vpsubb_zmm_k1z_zmm_zmmm512
				0x00F90000, 0x00008004, 0x000030E0,// Psubw_mm_mmm64
				0x00F90000, 0x00008005, 0x00003263,// Psubw_xmm_xmmm128
				0x00F90001, 0x00004C05, 0x000253A2,// VEX_Vpsubw_xmm_xmm_xmmm128
				0x00F90001, 0x00005005, 0x000263E3,// VEX_Vpsubw_ymm_ymm_ymmm256
				0x00F90002, 0x0301E005, 0x0002125E,// EVEX_Vpsubw_xmm_k1z_xmm_xmmm128
				0x00F90002, 0x03022405, 0x0002229F,// EVEX_Vpsubw_ymm_k1z_ymm_ymmm256
				0x00F90002, 0x03026805, 0x000232E0,// EVEX_Vpsubw_zmm_k1z_zmm_zmmm512
				0x00FA0000, 0x00008004, 0x000030E0,// Psubd_mm_mmm64
				0x00FA0000, 0x00008005, 0x00003263,// Psubd_xmm_xmmm128
				0x00FA0001, 0x00004C05, 0x000253A2,// VEX_Vpsubd_xmm_xmm_xmmm128
				0x00FA0001, 0x00005005, 0x000263E3,// VEX_Vpsubd_ymm_ymm_ymmm256
				0x00FA0002, 0x03204005, 0x0002125E,// EVEX_Vpsubd_xmm_k1z_xmm_xmmm128b32
				0x00FA0002, 0x03208405, 0x0002229F,// EVEX_Vpsubd_ymm_k1z_ymm_ymmm256b32
				0x00FA0002, 0x0320C805, 0x000232E0,// EVEX_Vpsubd_zmm_k1z_zmm_zmmm512b32
				0x00FB0000, 0x00008004, 0x000030E0,// Psubq_mm_mmm64
				0x00FB0000, 0x00008005, 0x00003263,// Psubq_xmm_xmmm128
				0x00FB0001, 0x00004C05, 0x000253A2,// VEX_Vpsubq_xmm_xmm_xmmm128
				0x00FB0001, 0x00005005, 0x000263E3,// VEX_Vpsubq_ymm_ymm_ymmm256
				0x00FB0002, 0x03205005, 0x0002125E,// EVEX_Vpsubq_xmm_k1z_xmm_xmmm128b64
				0x00FB0002, 0x03209405, 0x0002229F,// EVEX_Vpsubq_ymm_k1z_ymm_ymmm256b64
				0x00FB0002, 0x0320D805, 0x000232E0,// EVEX_Vpsubq_zmm_k1z_zmm_zmmm512b64
				0x00FC0000, 0x00008004, 0x000030E0,// Paddb_mm_mmm64
				0x00FC0000, 0x00008005, 0x00003263,// Paddb_xmm_xmmm128
				0x00FC0001, 0x00004C05, 0x000253A2,// VEX_Vpaddb_xmm_xmm_xmmm128
				0x00FC0001, 0x00005005, 0x000263E3,// VEX_Vpaddb_ymm_ymm_ymmm256
				0x00FC0002, 0x0301E005, 0x0002125E,// EVEX_Vpaddb_xmm_k1z_xmm_xmmm128
				0x00FC0002, 0x03022405, 0x0002229F,// EVEX_Vpaddb_ymm_k1z_ymm_ymmm256
				0x00FC0002, 0x03026805, 0x000232E0,// EVEX_Vpaddb_zmm_k1z_zmm_zmmm512
				0x00FD0000, 0x00008004, 0x000030E0,// Paddw_mm_mmm64
				0x00FD0000, 0x00008005, 0x00003263,// Paddw_xmm_xmmm128
				0x00FD0001, 0x00004C05, 0x000253A2,// VEX_Vpaddw_xmm_xmm_xmmm128
				0x00FD0001, 0x00005005, 0x000263E3,// VEX_Vpaddw_ymm_ymm_ymmm256
				0x00FD0002, 0x0301E005, 0x0002125E,// EVEX_Vpaddw_xmm_k1z_xmm_xmmm128
				0x00FD0002, 0x03022405, 0x0002229F,// EVEX_Vpaddw_ymm_k1z_ymm_ymmm256
				0x00FD0002, 0x03026805, 0x000232E0,// EVEX_Vpaddw_zmm_k1z_zmm_zmmm512
				0x00FE0000, 0x00008004, 0x000030E0,// Paddd_mm_mmm64
				0x00FE0000, 0x00008005, 0x00003263,// Paddd_xmm_xmmm128
				0x00FE0001, 0x00004C05, 0x000253A2,// VEX_Vpaddd_xmm_xmm_xmmm128
				0x00FE0001, 0x00005005, 0x000263E3,// VEX_Vpaddd_ymm_ymm_ymmm256
				0x00FE0002, 0x03204005, 0x0002125E,// EVEX_Vpaddd_xmm_k1z_xmm_xmmm128b32
				0x00FE0002, 0x03208405, 0x0002229F,// EVEX_Vpaddd_ymm_k1z_ymm_ymmm256b32
				0x00FE0002, 0x0320C805, 0x000232E0,// EVEX_Vpaddd_zmm_k1z_zmm_zmmm512b32
				0x00FF0000, 0x00010004, 0x00000DAA,// Ud0_r16_rm16
				0x00FF0000, 0x00020004, 0x00000E2B,// Ud0_r32_rm32
				0x00FF0000, 0x00030024, 0x0000102C,// Ud0_r64_rm64
				0x00000000, 0x00008008, 0x000030E0,// Pshufb_mm_mmm64
				0x00000000, 0x00008009, 0x00003263,// Pshufb_xmm_xmmm128
				0x00000001, 0x00004C09, 0x000253A2,// VEX_Vpshufb_xmm_xmm_xmmm128
				0x00000001, 0x00005009, 0x000263E3,// VEX_Vpshufb_ymm_ymm_ymmm256
				0x00000002, 0x0301E009, 0x0002125E,// EVEX_Vpshufb_xmm_k1z_xmm_xmmm128
				0x00000002, 0x03022409, 0x0002229F,// EVEX_Vpshufb_ymm_k1z_ymm_ymmm256
				0x00000002, 0x03026809, 0x000232E0,// EVEX_Vpshufb_zmm_k1z_zmm_zmmm512
				0x00010000, 0x00008008, 0x000030E0,// Phaddw_mm_mmm64
				0x00010000, 0x00008009, 0x00003263,// Phaddw_xmm_xmmm128
				0x00010001, 0x00004C09, 0x000253A2,// VEX_Vphaddw_xmm_xmm_xmmm128
				0x00010001, 0x00005009, 0x000263E3,// VEX_Vphaddw_ymm_ymm_ymmm256
				0x00020000, 0x00008008, 0x000030E0,// Phaddd_mm_mmm64
				0x00020000, 0x00008009, 0x00003263,// Phaddd_xmm_xmmm128
				0x00020001, 0x00004C09, 0x000253A2,// VEX_Vphaddd_xmm_xmm_xmmm128
				0x00020001, 0x00005009, 0x000263E3,// VEX_Vphaddd_ymm_ymm_ymmm256
				0x00030000, 0x00008008, 0x000030E0,// Phaddsw_mm_mmm64
				0x00030000, 0x00008009, 0x00003263,// Phaddsw_xmm_xmmm128
				0x00030001, 0x00004C09, 0x000253A2,// VEX_Vphaddsw_xmm_xmm_xmmm128
				0x00030001, 0x00005009, 0x000263E3,// VEX_Vphaddsw_ymm_ymm_ymmm256
				0x00040000, 0x00008008, 0x000030E0,// Pmaddubsw_mm_mmm64
				0x00040000, 0x00008009, 0x00003263,// Pmaddubsw_xmm_xmmm128
				0x00040001, 0x00004C09, 0x000253A2,// VEX_Vpmaddubsw_xmm_xmm_xmmm128
				0x00040001, 0x00005009, 0x000263E3,// VEX_Vpmaddubsw_ymm_ymm_ymmm256
				0x00040002, 0x0301E009, 0x0002125E,// EVEX_Vpmaddubsw_xmm_k1z_xmm_xmmm128
				0x00040002, 0x03022409, 0x0002229F,// EVEX_Vpmaddubsw_ymm_k1z_ymm_ymmm256
				0x00040002, 0x03026809, 0x000232E0,// EVEX_Vpmaddubsw_zmm_k1z_zmm_zmmm512
				0x00050000, 0x00008008, 0x000030E0,// Phsubw_mm_mmm64
				0x00050000, 0x00008009, 0x00003263,// Phsubw_xmm_xmmm128
				0x00050001, 0x00004C09, 0x000253A2,// VEX_Vphsubw_xmm_xmm_xmmm128
				0x00050001, 0x00005009, 0x000263E3,// VEX_Vphsubw_ymm_ymm_ymmm256
				0x00060000, 0x00008008, 0x000030E0,// Phsubd_mm_mmm64
				0x00060000, 0x00008009, 0x00003263,// Phsubd_xmm_xmmm128
				0x00060001, 0x00004C09, 0x000253A2,// VEX_Vphsubd_xmm_xmm_xmmm128
				0x00060001, 0x00005009, 0x000263E3,// VEX_Vphsubd_ymm_ymm_ymmm256
				0x00070000, 0x00008008, 0x000030E0,// Phsubsw_mm_mmm64
				0x00070000, 0x00008009, 0x00003263,// Phsubsw_xmm_xmmm128
				0x00070001, 0x00004C09, 0x000253A2,// VEX_Vphsubsw_xmm_xmm_xmmm128
				0x00070001, 0x00005009, 0x000263E3,// VEX_Vphsubsw_ymm_ymm_ymmm256
				0x00080000, 0x00008008, 0x000030E0,// Psignb_mm_mmm64
				0x00080000, 0x00008009, 0x00003263,// Psignb_xmm_xmmm128
				0x00080001, 0x00004C09, 0x000253A2,// VEX_Vpsignb_xmm_xmm_xmmm128
				0x00080001, 0x00005009, 0x000263E3,// VEX_Vpsignb_ymm_ymm_ymmm256
				0x00090000, 0x00008008, 0x000030E0,// Psignw_mm_mmm64
				0x00090000, 0x00008009, 0x00003263,// Psignw_xmm_xmmm128
				0x00090001, 0x00004C09, 0x000253A2,// VEX_Vpsignw_xmm_xmm_xmmm128
				0x00090001, 0x00005009, 0x000263E3,// VEX_Vpsignw_ymm_ymm_ymmm256
				0x000A0000, 0x00008008, 0x000030E0,// Psignd_mm_mmm64
				0x000A0000, 0x00008009, 0x00003263,// Psignd_xmm_xmmm128
				0x000A0001, 0x00004C09, 0x000253A2,// VEX_Vpsignd_xmm_xmm_xmmm128
				0x000A0001, 0x00005009, 0x000263E3,// VEX_Vpsignd_ymm_ymm_ymmm256
				0x000B0000, 0x00008008, 0x000030E0,// Pmulhrsw_mm_mmm64
				0x000B0000, 0x00008009, 0x00003263,// Pmulhrsw_xmm_xmmm128
				0x000B0001, 0x00004C09, 0x000253A2,// VEX_Vpmulhrsw_xmm_xmm_xmmm128
				0x000B0001, 0x00005009, 0x000263E3,// VEX_Vpmulhrsw_ymm_ymm_ymmm256
				0x000B0002, 0x0301E009, 0x0002125E,// EVEX_Vpmulhrsw_xmm_k1z_xmm_xmmm128
				0x000B0002, 0x03022409, 0x0002229F,// EVEX_Vpmulhrsw_ymm_k1z_ymm_ymmm256
				0x000B0002, 0x03026809, 0x000232E0,// EVEX_Vpmulhrsw_zmm_k1z_zmm_zmmm512
				0x000C0001, 0x00000C09, 0x000253A2,// VEX_Vpermilps_xmm_xmm_xmmm128
				0x000C0001, 0x00001009, 0x000263E3,// VEX_Vpermilps_ymm_ymm_ymmm256
				0x000C0002, 0x03204009, 0x0002125E,// EVEX_Vpermilps_xmm_k1z_xmm_xmmm128b32
				0x000C0002, 0x03208409, 0x0002229F,// EVEX_Vpermilps_ymm_k1z_ymm_ymmm256b32
				0x000C0002, 0x0320C809, 0x000232E0,// EVEX_Vpermilps_zmm_k1z_zmm_zmmm512b32
				0x000D0001, 0x00000C09, 0x000253A2,// VEX_Vpermilpd_xmm_xmm_xmmm128
				0x000D0001, 0x00001009, 0x000263E3,// VEX_Vpermilpd_ymm_ymm_ymmm256
				0x000D0002, 0x03205009, 0x0002125E,// EVEX_Vpermilpd_xmm_k1z_xmm_xmmm128b64
				0x000D0002, 0x03209409, 0x0002229F,// EVEX_Vpermilpd_ymm_k1z_ymm_ymmm256b64
				0x000D0002, 0x0320D809, 0x000232E0,// EVEX_Vpermilpd_zmm_k1z_zmm_zmmm512b64
				0x000E0001, 0x00000C09, 0x00000962,// VEX_Vtestps_xmm_xmmm128
				0x000E0001, 0x00001009, 0x000009A3,// VEX_Vtestps_ymm_ymmm256
				0x000F0001, 0x00000C09, 0x00000962,// VEX_Vtestpd_xmm_xmmm128
				0x000F0001, 0x00001009, 0x000009A3,// VEX_Vtestpd_ymm_ymmm256
				0x00100000, 0x00008009, 0x00003263,// Pblendvb_xmm_xmmm128
				0x00100002, 0x0301D009, 0x0002125E,// EVEX_Vpsrlvw_xmm_k1z_xmm_xmmm128
				0x00100002, 0x03021409, 0x0002229F,// EVEX_Vpsrlvw_ymm_k1z_ymm_ymmm256
				0x00100002, 0x03025809, 0x000232E0,// EVEX_Vpsrlvw_zmm_k1z_zmm_zmmm512
				0x00100002, 0x0305400A, 0x000007A1,// EVEX_Vpmovuswb_xmmm64_k1z_xmm
				0x00100002, 0x0305840A, 0x000007E1,// EVEX_Vpmovuswb_xmmm128_k1z_ymm
				0x00100002, 0x0305C80A, 0x00000822,// EVEX_Vpmovuswb_ymmm256_k1z_zmm
				0x00110002, 0x0301D009, 0x0002125E,// EVEX_Vpsravw_xmm_k1z_xmm_xmmm128
				0x00110002, 0x03021409, 0x0002229F,// EVEX_Vpsravw_ymm_k1z_ymm_ymmm256
				0x00110002, 0x03025809, 0x000232E0,// EVEX_Vpsravw_zmm_k1z_zmm_zmmm512
				0x00110002, 0x0306000A, 0x000007A1,// EVEX_Vpmovusdb_xmmm32_k1z_xmm
				0x00110002, 0x0306440A, 0x000007E1,// EVEX_Vpmovusdb_xmmm64_k1z_ymm
				0x00110002, 0x0306880A, 0x00000821,// EVEX_Vpmovusdb_xmmm128_k1z_zmm
				0x00120002, 0x0301D009, 0x0002125E,// EVEX_Vpsllvw_xmm_k1z_xmm_xmmm128
				0x00120002, 0x03021409, 0x0002229F,// EVEX_Vpsllvw_ymm_k1z_ymm_ymmm256
				0x00120002, 0x03025809, 0x000232E0,// EVEX_Vpsllvw_zmm_k1z_zmm_zmmm512
				0x00120002, 0x0306C00A, 0x000007A1,// EVEX_Vpmovusqb_xmmm16_k1z_xmm
				0x00120002, 0x0307040A, 0x000007E1,// EVEX_Vpmovusqb_xmmm32_k1z_ymm
				0x00120002, 0x0307480A, 0x00000821,// EVEX_Vpmovusqb_xmmm64_k1z_zmm
				0x00130001, 0x00000C09, 0x00000962,// VEX_Vcvtph2ps_xmm_xmmm64
				0x00130001, 0x00001009, 0x00000963,// VEX_Vcvtph2ps_ymm_xmmm128
				0x00130002, 0x03054009, 0x0000085E,// EVEX_Vcvtph2ps_xmm_k1z_xmmm64
				0x00130002, 0x03058409, 0x0000085F,// EVEX_Vcvtph2ps_ymm_k1z_xmmm128
				0x00130002, 0x0385C809, 0x000008A0,// EVEX_Vcvtph2ps_zmm_k1z_ymmm256_sae
				0x00130002, 0x0305400A, 0x000007A1,// EVEX_Vpmovusdw_xmmm64_k1z_xmm
				0x00130002, 0x0305840A, 0x000007E1,// EVEX_Vpmovusdw_xmmm128_k1z_ymm
				0x00130002, 0x0305C80A, 0x00000822,// EVEX_Vpmovusdw_ymmm256_k1z_zmm
				0x00140000, 0x00008009, 0x00003263,// Blendvps_xmm_xmmm128
				0x00140002, 0x03204009, 0x0002125E,// EVEX_Vprorvd_xmm_k1z_xmm_xmmm128b32
				0x00140002, 0x03208409, 0x0002229F,// EVEX_Vprorvd_ymm_k1z_ymm_ymmm256b32
				0x00140002, 0x0320C809, 0x000232E0,// EVEX_Vprorvd_zmm_k1z_zmm_zmmm512b32
				0x00140002, 0x03205009, 0x0002125E,// EVEX_Vprorvq_xmm_k1z_xmm_xmmm128b64
				0x00140002, 0x03209409, 0x0002229F,// EVEX_Vprorvq_ymm_k1z_ymm_ymmm256b64
				0x00140002, 0x0320D809, 0x000232E0,// EVEX_Vprorvq_zmm_k1z_zmm_zmmm512b64
				0x00140002, 0x0306000A, 0x000007A1,// EVEX_Vpmovusqw_xmmm32_k1z_xmm
				0x00140002, 0x0306440A, 0x000007E1,// EVEX_Vpmovusqw_xmmm64_k1z_ymm
				0x00140002, 0x0306880A, 0x00000821,// EVEX_Vpmovusqw_xmmm128_k1z_zmm
				0x00150000, 0x00008009, 0x00003263,// Blendvpd_xmm_xmmm128
				0x00150002, 0x03204009, 0x0002125E,// EVEX_Vprolvd_xmm_k1z_xmm_xmmm128b32
				0x00150002, 0x03208409, 0x0002229F,// EVEX_Vprolvd_ymm_k1z_ymm_ymmm256b32
				0x00150002, 0x0320C809, 0x000232E0,// EVEX_Vprolvd_zmm_k1z_zmm_zmmm512b32
				0x00150002, 0x03205009, 0x0002125E,// EVEX_Vprolvq_xmm_k1z_xmm_xmmm128b64
				0x00150002, 0x03209409, 0x0002229F,// EVEX_Vprolvq_ymm_k1z_ymm_ymmm256b64
				0x00150002, 0x0320D809, 0x000232E0,// EVEX_Vprolvq_zmm_k1z_zmm_zmmm512b64
				0x00150002, 0x0305400A, 0x000007A1,// EVEX_Vpmovusqd_xmmm64_k1z_xmm
				0x00150002, 0x0305840A, 0x000007E1,// EVEX_Vpmovusqd_xmmm128_k1z_ymm
				0x00150002, 0x0305C80A, 0x00000822,// EVEX_Vpmovusqd_ymmm256_k1z_zmm
				0x00160001, 0x00001009, 0x000263E3,// VEX_Vpermps_ymm_ymm_ymmm256
				0x00160002, 0x03208409, 0x0002229F,// EVEX_Vpermps_ymm_k1z_ymm_ymmm256b32
				0x00160002, 0x0320C809, 0x000232E0,// EVEX_Vpermps_zmm_k1z_zmm_zmmm512b32
				0x00160002, 0x03209409, 0x0002229F,// EVEX_Vpermpd_ymm_k1z_ymm_ymmm256b64
				0x00160002, 0x0320D809, 0x000232E0,// EVEX_Vpermpd_zmm_k1z_zmm_zmmm512b64
				0x00170000, 0x00008009, 0x00003263,// Ptest_xmm_xmmm128
				0x00170001, 0x00004C09, 0x00000962,// VEX_Vptest_xmm_xmmm128
				0x00170001, 0x00005009, 0x000009A3,// VEX_Vptest_ymm_ymmm256
				0x00180001, 0x00000C09, 0x00000962,// VEX_Vbroadcastss_xmm_xmmm32
				0x00180001, 0x00001009, 0x00000963,// VEX_Vbroadcastss_ymm_xmmm32
				0x00180002, 0x03028009, 0x0000085E,// EVEX_Vbroadcastss_xmm_k1z_xmmm32
				0x00180002, 0x03028409, 0x0000085F,// EVEX_Vbroadcastss_ymm_k1z_xmmm32
				0x00180002, 0x03028809, 0x00000860,// EVEX_Vbroadcastss_zmm_k1z_xmmm32
				0x00190001, 0x00001009, 0x00000963,// VEX_Vbroadcastsd_ymm_xmmm64
				0x00190002, 0x03044409, 0x0000085F,// EVEX_Vbroadcastf32x2_ymm_k1z_xmmm64
				0x00190002, 0x03044809, 0x00000860,// EVEX_Vbroadcastf32x2_zmm_k1z_xmmm64
				0x00190002, 0x03029409, 0x0000085F,// EVEX_Vbroadcastsd_ymm_k1z_xmmm64
				0x00190002, 0x03029809, 0x00000860,// EVEX_Vbroadcastsd_zmm_k1z_xmmm64
				0x001A0001, 0x00001009, 0x000005A3,// VEX_Vbroadcastf128_ymm_m128
				0x001A0002, 0x03048409, 0x000003DF,// EVEX_Vbroadcastf32x4_ymm_k1z_m128
				0x001A0002, 0x03048809, 0x000003E0,// EVEX_Vbroadcastf32x4_zmm_k1z_m128
				0x001A0002, 0x03045409, 0x000003DF,// EVEX_Vbroadcastf64x2_ymm_k1z_m128
				0x001A0002, 0x03045809, 0x000003E0,// EVEX_Vbroadcastf64x2_zmm_k1z_m128
				0x001B0002, 0x0304C809, 0x000003E0,// EVEX_Vbroadcastf32x8_zmm_k1z_m256
				0x001B0002, 0x03049809, 0x000003E0,// EVEX_Vbroadcastf64x4_zmm_k1z_m256
				0x001C0000, 0x00008008, 0x000030E0,// Pabsb_mm_mmm64
				0x001C0000, 0x00008009, 0x00003263,// Pabsb_xmm_xmmm128
				0x001C0001, 0x00004C09, 0x00000962,// VEX_Vpabsb_xmm_xmmm128
				0x001C0001, 0x00005009, 0x000009A3,// VEX_Vpabsb_ymm_ymmm256
				0x001C0002, 0x0301E009, 0x0000085E,// EVEX_Vpabsb_xmm_k1z_xmmm128
				0x001C0002, 0x03022409, 0x0000089F,// EVEX_Vpabsb_ymm_k1z_ymmm256
				0x001C0002, 0x03026809, 0x000008E0,// EVEX_Vpabsb_zmm_k1z_zmmm512
				0x001D0000, 0x00008008, 0x000030E0,// Pabsw_mm_mmm64
				0x001D0000, 0x00008009, 0x00003263,// Pabsw_xmm_xmmm128
				0x001D0001, 0x00004C09, 0x00000962,// VEX_Vpabsw_xmm_xmmm128
				0x001D0001, 0x00005009, 0x000009A3,// VEX_Vpabsw_ymm_ymmm256
				0x001D0002, 0x0301E009, 0x0000085E,// EVEX_Vpabsw_xmm_k1z_xmmm128
				0x001D0002, 0x03022409, 0x0000089F,// EVEX_Vpabsw_ymm_k1z_ymmm256
				0x001D0002, 0x03026809, 0x000008E0,// EVEX_Vpabsw_zmm_k1z_zmmm512
				0x001E0000, 0x00008008, 0x000030E0,// Pabsd_mm_mmm64
				0x001E0000, 0x00008009, 0x00003263,// Pabsd_xmm_xmmm128
				0x001E0001, 0x00004C09, 0x00000962,// VEX_Vpabsd_xmm_xmmm128
				0x001E0001, 0x00005009, 0x000009A3,// VEX_Vpabsd_ymm_ymmm256
				0x001E0002, 0x03204009, 0x0000085E,// EVEX_Vpabsd_xmm_k1z_xmmm128b32
				0x001E0002, 0x03208409, 0x0000089F,// EVEX_Vpabsd_ymm_k1z_ymmm256b32
				0x001E0002, 0x0320C809, 0x000008E0,// EVEX_Vpabsd_zmm_k1z_zmmm512b32
				0x001F0002, 0x03205009, 0x0000085E,// EVEX_Vpabsq_xmm_k1z_xmmm128b64
				0x001F0002, 0x03209409, 0x0000089F,// EVEX_Vpabsq_ymm_k1z_ymmm256b64
				0x001F0002, 0x0320D809, 0x000008E0,// EVEX_Vpabsq_zmm_k1z_zmmm512b64
				0x00200000, 0x00008009, 0x00003263,// Pmovsxbw_xmm_xmmm64
				0x00200001, 0x00004C09, 0x00000962,// VEX_Vpmovsxbw_xmm_xmmm64
				0x00200001, 0x00005009, 0x00000963,// VEX_Vpmovsxbw_ymm_xmmm128
				0x00200002, 0x03056009, 0x0000085E,// EVEX_Vpmovsxbw_xmm_k1z_xmmm64
				0x00200002, 0x0305A409, 0x0000085F,// EVEX_Vpmovsxbw_ymm_k1z_xmmm128
				0x00200002, 0x0305E809, 0x000008A0,// EVEX_Vpmovsxbw_zmm_k1z_ymmm256
				0x00200002, 0x0305400A, 0x000007A1,// EVEX_Vpmovswb_xmmm64_k1z_xmm
				0x00200002, 0x0305840A, 0x000007E1,// EVEX_Vpmovswb_xmmm128_k1z_ymm
				0x00200002, 0x0305C80A, 0x00000822,// EVEX_Vpmovswb_ymmm256_k1z_zmm
				0x00210000, 0x00008009, 0x00003263,// Pmovsxbd_xmm_xmmm32
				0x00210001, 0x00004C09, 0x00000962,// VEX_Vpmovsxbd_xmm_xmmm32
				0x00210001, 0x00005009, 0x00000963,// VEX_Vpmovsxbd_ymm_xmmm64
				0x00210002, 0x03062009, 0x0000085E,// EVEX_Vpmovsxbd_xmm_k1z_xmmm32
				0x00210002, 0x03066409, 0x0000085F,// EVEX_Vpmovsxbd_ymm_k1z_xmmm64
				0x00210002, 0x0306A809, 0x00000860,// EVEX_Vpmovsxbd_zmm_k1z_xmmm128
				0x00210002, 0x0306000A, 0x000007A1,// EVEX_Vpmovsdb_xmmm32_k1z_xmm
				0x00210002, 0x0306440A, 0x000007E1,// EVEX_Vpmovsdb_xmmm64_k1z_ymm
				0x00210002, 0x0306880A, 0x00000821,// EVEX_Vpmovsdb_xmmm128_k1z_zmm
				0x00220000, 0x00008009, 0x00003263,// Pmovsxbq_xmm_xmmm16
				0x00220001, 0x00004C09, 0x00000962,// VEX_Vpmovsxbq_xmm_xmmm16
				0x00220001, 0x00005009, 0x00000963,// VEX_Vpmovsxbq_ymm_xmmm32
				0x00220002, 0x0306E009, 0x0000085E,// EVEX_Vpmovsxbq_xmm_k1z_xmmm16
				0x00220002, 0x03072409, 0x0000085F,// EVEX_Vpmovsxbq_ymm_k1z_xmmm32
				0x00220002, 0x03076809, 0x00000860,// EVEX_Vpmovsxbq_zmm_k1z_xmmm64
				0x00220002, 0x0306C00A, 0x000007A1,// EVEX_Vpmovsqb_xmmm16_k1z_xmm
				0x00220002, 0x0307040A, 0x000007E1,// EVEX_Vpmovsqb_xmmm32_k1z_ymm
				0x00220002, 0x0307480A, 0x00000821,// EVEX_Vpmovsqb_xmmm64_k1z_zmm
				0x00230000, 0x00008009, 0x00003263,// Pmovsxwd_xmm_xmmm64
				0x00230001, 0x00004C09, 0x00000962,// VEX_Vpmovsxwd_xmm_xmmm64
				0x00230001, 0x00005009, 0x00000963,// VEX_Vpmovsxwd_ymm_xmmm128
				0x00230002, 0x03056009, 0x0000085E,// EVEX_Vpmovsxwd_xmm_k1z_xmmm64
				0x00230002, 0x0305A409, 0x0000085F,// EVEX_Vpmovsxwd_ymm_k1z_xmmm128
				0x00230002, 0x0305E809, 0x000008A0,// EVEX_Vpmovsxwd_zmm_k1z_ymmm256
				0x00230002, 0x0305400A, 0x000007A1,// EVEX_Vpmovsdw_xmmm64_k1z_xmm
				0x00230002, 0x0305840A, 0x000007E1,// EVEX_Vpmovsdw_xmmm128_k1z_ymm
				0x00230002, 0x0305C80A, 0x00000822,// EVEX_Vpmovsdw_ymmm256_k1z_zmm
				0x00240000, 0x00008009, 0x00003263,// Pmovsxwq_xmm_xmmm32
				0x00240001, 0x00004C09, 0x00000962,// VEX_Vpmovsxwq_xmm_xmmm32
				0x00240001, 0x00005009, 0x00000963,// VEX_Vpmovsxwq_ymm_xmmm64
				0x00240002, 0x03062009, 0x0000085E,// EVEX_Vpmovsxwq_xmm_k1z_xmmm32
				0x00240002, 0x03066409, 0x0000085F,// EVEX_Vpmovsxwq_ymm_k1z_xmmm64
				0x00240002, 0x0306A809, 0x00000860,// EVEX_Vpmovsxwq_zmm_k1z_xmmm128
				0x00240002, 0x0306000A, 0x000007A1,// EVEX_Vpmovsqw_xmmm32_k1z_xmm
				0x00240002, 0x0306440A, 0x000007E1,// EVEX_Vpmovsqw_xmmm64_k1z_ymm
				0x00240002, 0x0306880A, 0x00000821,// EVEX_Vpmovsqw_xmmm128_k1z_zmm
				0x00250000, 0x00008009, 0x00003263,// Pmovsxdq_xmm_xmmm64
				0x00250001, 0x00004C09, 0x00000962,// VEX_Vpmovsxdq_xmm_xmmm64
				0x00250001, 0x00005009, 0x00000963,// VEX_Vpmovsxdq_ymm_xmmm128
				0x00250002, 0x03054009, 0x0000085E,// EVEX_Vpmovsxdq_xmm_k1z_xmmm64
				0x00250002, 0x03058409, 0x0000085F,// EVEX_Vpmovsxdq_ymm_k1z_xmmm128
				0x00250002, 0x0305C809, 0x000008A0,// EVEX_Vpmovsxdq_zmm_k1z_ymmm256
				0x00250002, 0x0305400A, 0x000007A1,// EVEX_Vpmovsqd_xmmm64_k1z_xmm
				0x00250002, 0x0305840A, 0x000007E1,// EVEX_Vpmovsqd_xmmm128_k1z_ymm
				0x00250002, 0x0305C80A, 0x00000822,// EVEX_Vpmovsqd_ymmm256_k1z_zmm
				0x00260002, 0x0101C009, 0x0002125C,// EVEX_Vptestmb_k_k1_xmm_xmmm128
				0x00260002, 0x01020409, 0x0002229C,// EVEX_Vptestmb_k_k1_ymm_ymmm256
				0x00260002, 0x01024809, 0x000232DC,// EVEX_Vptestmb_k_k1_zmm_zmmm512
				0x00260002, 0x0101D009, 0x0002125C,// EVEX_Vptestmw_k_k1_xmm_xmmm128
				0x00260002, 0x01021409, 0x0002229C,// EVEX_Vptestmw_k_k1_ymm_ymmm256
				0x00260002, 0x01025809, 0x000232DC,// EVEX_Vptestmw_k_k1_zmm_zmmm512
				0x00260002, 0x0101C00A, 0x0002125C,// EVEX_Vptestnmb_k_k1_xmm_xmmm128
				0x00260002, 0x0102040A, 0x0002229C,// EVEX_Vptestnmb_k_k1_ymm_ymmm256
				0x00260002, 0x0102480A, 0x000232DC,// EVEX_Vptestnmb_k_k1_zmm_zmmm512
				0x00260002, 0x0101D00A, 0x0002125C,// EVEX_Vptestnmw_k_k1_xmm_xmmm128
				0x00260002, 0x0102140A, 0x0002229C,// EVEX_Vptestnmw_k_k1_ymm_ymmm256
				0x00260002, 0x0102580A, 0x000232DC,// EVEX_Vptestnmw_k_k1_zmm_zmmm512
				0x00270002, 0x01204009, 0x0002125C,// EVEX_Vptestmd_k_k1_xmm_xmmm128b32
				0x00270002, 0x01208409, 0x0002229C,// EVEX_Vptestmd_k_k1_ymm_ymmm256b32
				0x00270002, 0x0120C809, 0x000232DC,// EVEX_Vptestmd_k_k1_zmm_zmmm512b32
				0x00270002, 0x01205009, 0x0002125C,// EVEX_Vptestmq_k_k1_xmm_xmmm128b64
				0x00270002, 0x01209409, 0x0002229C,// EVEX_Vptestmq_k_k1_ymm_ymmm256b64
				0x00270002, 0x0120D809, 0x000232DC,// EVEX_Vptestmq_k_k1_zmm_zmmm512b64
				0x00270002, 0x0120400A, 0x0002125C,// EVEX_Vptestnmd_k_k1_xmm_xmmm128b32
				0x00270002, 0x0120840A, 0x0002229C,// EVEX_Vptestnmd_k_k1_ymm_ymmm256b32
				0x00270002, 0x0120C80A, 0x000232DC,// EVEX_Vptestnmd_k_k1_zmm_zmmm512b32
				0x00270002, 0x0120500A, 0x0002125C,// EVEX_Vptestnmq_k_k1_xmm_xmmm128b64
				0x00270002, 0x0120940A, 0x0002229C,// EVEX_Vptestnmq_k_k1_ymm_ymmm256b64
				0x00270002, 0x0120D80A, 0x000232DC,// EVEX_Vptestnmq_k_k1_zmm_zmmm512b64
				0x00280000, 0x00008009, 0x00003263,// Pmuldq_xmm_xmmm128
				0x00280001, 0x00004C09, 0x000253A2,// VEX_Vpmuldq_xmm_xmm_xmmm128
				0x00280001, 0x00005009, 0x000263E3,// VEX_Vpmuldq_ymm_ymm_ymmm256
				0x00280002, 0x03205009, 0x0002125E,// EVEX_Vpmuldq_xmm_k1z_xmm_xmmm128b64
				0x00280002, 0x03209409, 0x0002229F,// EVEX_Vpmuldq_ymm_k1z_ymm_ymmm256b64
				0x00280002, 0x0320D809, 0x000232E0,// EVEX_Vpmuldq_zmm_k1z_zmm_zmmm512b64
				0x00280002, 0x0000000A, 0x0000055E,// EVEX_Vpmovm2b_xmm_k
				0x00280002, 0x0000040A, 0x0000055F,// EVEX_Vpmovm2b_ymm_k
				0x00280002, 0x0000080A, 0x00000560,// EVEX_Vpmovm2b_zmm_k
				0x00280002, 0x0000100A, 0x0000055E,// EVEX_Vpmovm2w_xmm_k
				0x00280002, 0x0000140A, 0x0000055F,// EVEX_Vpmovm2w_ymm_k
				0x00280002, 0x0000180A, 0x00000560,// EVEX_Vpmovm2w_zmm_k
				0x00290000, 0x00008009, 0x00003263,// Pcmpeqq_xmm_xmmm128
				0x00290001, 0x00004C09, 0x000253A2,// VEX_Vpcmpeqq_xmm_xmm_xmmm128
				0x00290001, 0x00005009, 0x000263E3,// VEX_Vpcmpeqq_ymm_ymm_ymmm256
				0x00290002, 0x01205009, 0x0002125C,// EVEX_Vpcmpeqq_k_k1_xmm_xmmm128b64
				0x00290002, 0x01209409, 0x0002229C,// EVEX_Vpcmpeqq_k_k1_ymm_ymmm256b64
				0x00290002, 0x0120D809, 0x000232DC,// EVEX_Vpcmpeqq_k_k1_zmm_zmmm512b64
				0x00290002, 0x0000000A, 0x0000049C,// EVEX_Vpmovb2m_k_xmm
				0x00290002, 0x0000040A, 0x000004DC,// EVEX_Vpmovb2m_k_ymm
				0x00290002, 0x0000080A, 0x0000051C,// EVEX_Vpmovb2m_k_zmm
				0x00290002, 0x0000100A, 0x0000049C,// EVEX_Vpmovw2m_k_xmm
				0x00290002, 0x0000140A, 0x000004DC,// EVEX_Vpmovw2m_k_ymm
				0x00290002, 0x0000180A, 0x0000051C,// EVEX_Vpmovw2m_k_zmm
				0x002A0000, 0x00008009, 0x000001E3,// Movntdqa_xmm_m128
				0x002A0001, 0x00004C09, 0x000005A2,// VEX_Vmovntdqa_xmm_m128
				0x002A0001, 0x00005009, 0x000005A3,// VEX_Vmovntdqa_ymm_m256
				0x002A0002, 0x0001C009, 0x000003DE,// EVEX_Vmovntdqa_xmm_m128
				0x002A0002, 0x00020409, 0x000003DF,// EVEX_Vmovntdqa_ymm_m256
				0x002A0002, 0x00024809, 0x000003E0,// EVEX_Vmovntdqa_zmm_m512
				0x002A0002, 0x0000100A, 0x0000055E,// EVEX_Vpbroadcastmb2q_xmm_k
				0x002A0002, 0x0000140A, 0x0000055F,// EVEX_Vpbroadcastmb2q_ymm_k
				0x002A0002, 0x0000180A, 0x00000560,// EVEX_Vpbroadcastmb2q_zmm_k
				0x002B0000, 0x00008009, 0x00003263,// Packusdw_xmm_xmmm128
				0x002B0001, 0x00004C09, 0x000253A2,// VEX_Vpackusdw_xmm_xmm_xmmm128
				0x002B0001, 0x00005009, 0x000263E3,// VEX_Vpackusdw_ymm_ymm_ymmm256
				0x002B0002, 0x03204009, 0x0002125E,// EVEX_Vpackusdw_xmm_k1z_xmm_xmmm128b32
				0x002B0002, 0x03208409, 0x0002229F,// EVEX_Vpackusdw_ymm_k1z_ymm_ymmm256b32
				0x002B0002, 0x0320C809, 0x000232E0,// EVEX_Vpackusdw_zmm_k1z_zmm_zmmm512b32
				0x002C0001, 0x00000C09, 0x000163A2,// VEX_Vmaskmovps_xmm_xmm_m128
				0x002C0001, 0x00001009, 0x000163E3,// VEX_Vmaskmovps_ymm_ymm_m256
				0x002C0002, 0x03204009, 0x0002125E,// EVEX_Vscalefps_xmm_k1z_xmm_xmmm128b32
				0x002C0002, 0x03208409, 0x0002229F,// EVEX_Vscalefps_ymm_k1z_ymm_ymmm256b32
				0x002C0002, 0x0360C809, 0x000232E0,// EVEX_Vscalefps_zmm_k1z_zmm_zmmm512b32_er
				0x002C0002, 0x03205009, 0x0002125E,// EVEX_Vscalefpd_xmm_k1z_xmm_xmmm128b64
				0x002C0002, 0x03209409, 0x0002229F,// EVEX_Vscalefpd_ymm_k1z_ymm_ymmm256b64
				0x002C0002, 0x0360D809, 0x000232E0,// EVEX_Vscalefpd_zmm_k1z_zmm_zmmm512b64_er
				0x002D0001, 0x00000C09, 0x000163A2,// VEX_Vmaskmovpd_xmm_xmm_m128
				0x002D0001, 0x00001009, 0x000163E3,// VEX_Vmaskmovpd_ymm_ymm_m256
				0x002D0002, 0x03528009, 0x0002125E,// EVEX_Vscalefss_xmm_k1z_xmm_xmmm32_er
				0x002D0002, 0x03529009, 0x0002125E,// EVEX_Vscalefsd_xmm_k1z_xmm_xmmm64_er
				0x002E0001, 0x00000C09, 0x00022396,// VEX_Vmaskmovps_m128_xmm_xmm
				0x002E0001, 0x00001009, 0x000233D6,// VEX_Vmaskmovps_m256_ymm_ymm
				0x002F0001, 0x00000C09, 0x00022396,// VEX_Vmaskmovpd_m128_xmm_xmm
				0x002F0001, 0x00001009, 0x000233D6,// VEX_Vmaskmovpd_m256_ymm_ymm
				0x00300000, 0x00008009, 0x00003263,// Pmovzxbw_xmm_xmmm64
				0x00300001, 0x00004C09, 0x00000962,// VEX_Vpmovzxbw_xmm_xmmm64
				0x00300001, 0x00005009, 0x00000963,// VEX_Vpmovzxbw_ymm_xmmm128
				0x00300002, 0x03056009, 0x0000085E,// EVEX_Vpmovzxbw_xmm_k1z_xmmm64
				0x00300002, 0x0305A409, 0x0000085F,// EVEX_Vpmovzxbw_ymm_k1z_xmmm128
				0x00300002, 0x0305E809, 0x000008A0,// EVEX_Vpmovzxbw_zmm_k1z_ymmm256
				0x00300002, 0x0305400A, 0x000007A1,// EVEX_Vpmovwb_xmmm64_k1z_xmm
				0x00300002, 0x0305840A, 0x000007E1,// EVEX_Vpmovwb_xmmm128_k1z_ymm
				0x00300002, 0x0305C80A, 0x00000822,// EVEX_Vpmovwb_ymmm256_k1z_zmm
				0x00310000, 0x00008009, 0x00003263,// Pmovzxbd_xmm_xmmm32
				0x00310001, 0x00004C09, 0x00000962,// VEX_Vpmovzxbd_xmm_xmmm32
				0x00310001, 0x00005009, 0x00000963,// VEX_Vpmovzxbd_ymm_xmmm64
				0x00310002, 0x03062009, 0x0000085E,// EVEX_Vpmovzxbd_xmm_k1z_xmmm32
				0x00310002, 0x03066409, 0x0000085F,// EVEX_Vpmovzxbd_ymm_k1z_xmmm64
				0x00310002, 0x0306A809, 0x00000860,// EVEX_Vpmovzxbd_zmm_k1z_xmmm128
				0x00310002, 0x0306000A, 0x000007A1,// EVEX_Vpmovdb_xmmm32_k1z_xmm
				0x00310002, 0x0306440A, 0x000007E1,// EVEX_Vpmovdb_xmmm64_k1z_ymm
				0x00310002, 0x0306880A, 0x00000821,// EVEX_Vpmovdb_xmmm128_k1z_zmm
				0x00320000, 0x00008009, 0x00003263,// Pmovzxbq_xmm_xmmm16
				0x00320001, 0x00004C09, 0x00000962,// VEX_Vpmovzxbq_xmm_xmmm16
				0x00320001, 0x00005009, 0x00000963,// VEX_Vpmovzxbq_ymm_xmmm32
				0x00320002, 0x0306E009, 0x0000085E,// EVEX_Vpmovzxbq_xmm_k1z_xmmm16
				0x00320002, 0x03072409, 0x0000085F,// EVEX_Vpmovzxbq_ymm_k1z_xmmm32
				0x00320002, 0x03076809, 0x00000860,// EVEX_Vpmovzxbq_zmm_k1z_xmmm64
				0x00320002, 0x0306C00A, 0x000007A1,// EVEX_Vpmovqb_xmmm16_k1z_xmm
				0x00320002, 0x0307040A, 0x000007E1,// EVEX_Vpmovqb_xmmm32_k1z_ymm
				0x00320002, 0x0307480A, 0x00000821,// EVEX_Vpmovqb_xmmm64_k1z_zmm
				0x00330000, 0x00008009, 0x00003263,// Pmovzxwd_xmm_xmmm64
				0x00330001, 0x00004C09, 0x00000962,// VEX_Vpmovzxwd_xmm_xmmm64
				0x00330001, 0x00005009, 0x00000963,// VEX_Vpmovzxwd_ymm_xmmm128
				0x00330002, 0x03056009, 0x0000085E,// EVEX_Vpmovzxwd_xmm_k1z_xmmm64
				0x00330002, 0x0305A409, 0x0000085F,// EVEX_Vpmovzxwd_ymm_k1z_xmmm128
				0x00330002, 0x0305E809, 0x000008A0,// EVEX_Vpmovzxwd_zmm_k1z_ymmm256
				0x00330002, 0x0305400A, 0x000007A1,// EVEX_Vpmovdw_xmmm64_k1z_xmm
				0x00330002, 0x0305840A, 0x000007E1,// EVEX_Vpmovdw_xmmm128_k1z_ymm
				0x00330002, 0x0305C80A, 0x00000822,// EVEX_Vpmovdw_ymmm256_k1z_zmm
				0x00340000, 0x00008009, 0x00003263,// Pmovzxwq_xmm_xmmm32
				0x00340001, 0x00004C09, 0x00000962,// VEX_Vpmovzxwq_xmm_xmmm32
				0x00340001, 0x00005009, 0x00000963,// VEX_Vpmovzxwq_ymm_xmmm64
				0x00340002, 0x03062009, 0x0000085E,// EVEX_Vpmovzxwq_xmm_k1z_xmmm32
				0x00340002, 0x03066409, 0x0000085F,// EVEX_Vpmovzxwq_ymm_k1z_xmmm64
				0x00340002, 0x0306A809, 0x00000860,// EVEX_Vpmovzxwq_zmm_k1z_xmmm128
				0x00340002, 0x0306000A, 0x000007A1,// EVEX_Vpmovqw_xmmm32_k1z_xmm
				0x00340002, 0x0306440A, 0x000007E1,// EVEX_Vpmovqw_xmmm64_k1z_ymm
				0x00340002, 0x0306880A, 0x00000821,// EVEX_Vpmovqw_xmmm128_k1z_zmm
				0x00350000, 0x00008009, 0x00003263,// Pmovzxdq_xmm_xmmm64
				0x00350001, 0x00004C09, 0x00000962,// VEX_Vpmovzxdq_xmm_xmmm64
				0x00350001, 0x00005009, 0x00000963,// VEX_Vpmovzxdq_ymm_xmmm128
				0x00350002, 0x03054009, 0x0000085E,// EVEX_Vpmovzxdq_xmm_k1z_xmmm64
				0x00350002, 0x03058409, 0x0000085F,// EVEX_Vpmovzxdq_ymm_k1z_xmmm128
				0x00350002, 0x0305C809, 0x000008A0,// EVEX_Vpmovzxdq_zmm_k1z_ymmm256
				0x00350002, 0x0305400A, 0x000007A1,// EVEX_Vpmovqd_xmmm64_k1z_xmm
				0x00350002, 0x0305840A, 0x000007E1,// EVEX_Vpmovqd_xmmm128_k1z_ymm
				0x00350002, 0x0305C80A, 0x00000822,// EVEX_Vpmovqd_ymmm256_k1z_zmm
				0x00360001, 0x00001009, 0x000263E3,// VEX_Vpermd_ymm_ymm_ymmm256
				0x00360002, 0x03208409, 0x0002229F,// EVEX_Vpermd_ymm_k1z_ymm_ymmm256b32
				0x00360002, 0x0320C809, 0x000232E0,// EVEX_Vpermd_zmm_k1z_zmm_zmmm512b32
				0x00360002, 0x03209409, 0x0002229F,// EVEX_Vpermq_ymm_k1z_ymm_ymmm256b64
				0x00360002, 0x0320D809, 0x000232E0,// EVEX_Vpermq_zmm_k1z_zmm_zmmm512b64
				0x00370000, 0x00008009, 0x00003263,// Pcmpgtq_xmm_xmmm128
				0x00370001, 0x00004C09, 0x000253A2,// VEX_Vpcmpgtq_xmm_xmm_xmmm128
				0x00370001, 0x00005009, 0x000263E3,// VEX_Vpcmpgtq_ymm_ymm_ymmm256
				0x00370002, 0x01205009, 0x0002125C,// EVEX_Vpcmpgtq_k_k1_xmm_xmmm128b64
				0x00370002, 0x01209409, 0x0002229C,// EVEX_Vpcmpgtq_k_k1_ymm_ymmm256b64
				0x00370002, 0x0120D809, 0x000232DC,// EVEX_Vpcmpgtq_k_k1_zmm_zmmm512b64
				0x00380000, 0x00008009, 0x00003263,// Pminsb_xmm_xmmm128
				0x00380001, 0x00004C09, 0x000253A2,// VEX_Vpminsb_xmm_xmm_xmmm128
				0x00380001, 0x00005009, 0x000263E3,// VEX_Vpminsb_ymm_ymm_ymmm256
				0x00380002, 0x0301E009, 0x0002125E,// EVEX_Vpminsb_xmm_k1z_xmm_xmmm128
				0x00380002, 0x03022409, 0x0002229F,// EVEX_Vpminsb_ymm_k1z_ymm_ymmm256
				0x00380002, 0x03026809, 0x000232E0,// EVEX_Vpminsb_zmm_k1z_zmm_zmmm512
				0x00380002, 0x0000000A, 0x0000055E,// EVEX_Vpmovm2d_xmm_k
				0x00380002, 0x0000040A, 0x0000055F,// EVEX_Vpmovm2d_ymm_k
				0x00380002, 0x0000080A, 0x00000560,// EVEX_Vpmovm2d_zmm_k
				0x00380002, 0x0000100A, 0x0000055E,// EVEX_Vpmovm2q_xmm_k
				0x00380002, 0x0000140A, 0x0000055F,// EVEX_Vpmovm2q_ymm_k
				0x00380002, 0x0000180A, 0x00000560,// EVEX_Vpmovm2q_zmm_k
				0x00390000, 0x00008009, 0x00003263,// Pminsd_xmm_xmmm128
				0x00390001, 0x00004C09, 0x000253A2,// VEX_Vpminsd_xmm_xmm_xmmm128
				0x00390001, 0x00005009, 0x000263E3,// VEX_Vpminsd_ymm_ymm_ymmm256
				0x00390002, 0x03204009, 0x0002125E,// EVEX_Vpminsd_xmm_k1z_xmm_xmmm128b32
				0x00390002, 0x03208409, 0x0002229F,// EVEX_Vpminsd_ymm_k1z_ymm_ymmm256b32
				0x00390002, 0x0320C809, 0x000232E0,// EVEX_Vpminsd_zmm_k1z_zmm_zmmm512b32
				0x00390002, 0x03205009, 0x0002125E,// EVEX_Vpminsq_xmm_k1z_xmm_xmmm128b64
				0x00390002, 0x03209409, 0x0002229F,// EVEX_Vpminsq_ymm_k1z_ymm_ymmm256b64
				0x00390002, 0x0320D809, 0x000232E0,// EVEX_Vpminsq_zmm_k1z_zmm_zmmm512b64
				0x00390002, 0x0000000A, 0x0000049C,// EVEX_Vpmovd2m_k_xmm
				0x00390002, 0x0000040A, 0x000004DC,// EVEX_Vpmovd2m_k_ymm
				0x00390002, 0x0000080A, 0x0000051C,// EVEX_Vpmovd2m_k_zmm
				0x00390002, 0x0000100A, 0x0000049C,// EVEX_Vpmovq2m_k_xmm
				0x00390002, 0x0000140A, 0x000004DC,// EVEX_Vpmovq2m_k_ymm
				0x00390002, 0x0000180A, 0x0000051C,// EVEX_Vpmovq2m_k_zmm
				0x003A0000, 0x00008009, 0x00003263,// Pminuw_xmm_xmmm128
				0x003A0001, 0x00004C09, 0x000253A2,// VEX_Vpminuw_xmm_xmm_xmmm128
				0x003A0001, 0x00005009, 0x000263E3,// VEX_Vpminuw_ymm_ymm_ymmm256
				0x003A0002, 0x0301E009, 0x0002125E,// EVEX_Vpminuw_xmm_k1z_xmm_xmmm128
				0x003A0002, 0x03022409, 0x0002229F,// EVEX_Vpminuw_ymm_k1z_ymm_ymmm256
				0x003A0002, 0x03026809, 0x000232E0,// EVEX_Vpminuw_zmm_k1z_zmm_zmmm512
				0x003A0002, 0x0000000A, 0x0000055E,// EVEX_Vpbroadcastmw2d_xmm_k
				0x003A0002, 0x0000040A, 0x0000055F,// EVEX_Vpbroadcastmw2d_ymm_k
				0x003A0002, 0x0000080A, 0x00000560,// EVEX_Vpbroadcastmw2d_zmm_k
				0x003B0000, 0x00008009, 0x00003263,// Pminud_xmm_xmmm128
				0x003B0001, 0x00004C09, 0x000253A2,// VEX_Vpminud_xmm_xmm_xmmm128
				0x003B0001, 0x00005009, 0x000263E3,// VEX_Vpminud_ymm_ymm_ymmm256
				0x003B0002, 0x03204009, 0x0002125E,// EVEX_Vpminud_xmm_k1z_xmm_xmmm128b32
				0x003B0002, 0x03208409, 0x0002229F,// EVEX_Vpminud_ymm_k1z_ymm_ymmm256b32
				0x003B0002, 0x0320C809, 0x000232E0,// EVEX_Vpminud_zmm_k1z_zmm_zmmm512b32
				0x003B0002, 0x03205009, 0x0002125E,// EVEX_Vpminuq_xmm_k1z_xmm_xmmm128b64
				0x003B0002, 0x03209409, 0x0002229F,// EVEX_Vpminuq_ymm_k1z_ymm_ymmm256b64
				0x003B0002, 0x0320D809, 0x000232E0,// EVEX_Vpminuq_zmm_k1z_zmm_zmmm512b64
				0x003C0000, 0x00008009, 0x00003263,// Pmaxsb_xmm_xmmm128
				0x003C0001, 0x00004C09, 0x000253A2,// VEX_Vpmaxsb_xmm_xmm_xmmm128
				0x003C0001, 0x00005009, 0x000263E3,// VEX_Vpmaxsb_ymm_ymm_ymmm256
				0x003C0002, 0x0301E009, 0x0002125E,// EVEX_Vpmaxsb_xmm_k1z_xmm_xmmm128
				0x003C0002, 0x03022409, 0x0002229F,// EVEX_Vpmaxsb_ymm_k1z_ymm_ymmm256
				0x003C0002, 0x03026809, 0x000232E0,// EVEX_Vpmaxsb_zmm_k1z_zmm_zmmm512
				0x003D0000, 0x00008009, 0x00003263,// Pmaxsd_xmm_xmmm128
				0x003D0001, 0x00004C09, 0x000253A2,// VEX_Vpmaxsd_xmm_xmm_xmmm128
				0x003D0001, 0x00005009, 0x000263E3,// VEX_Vpmaxsd_ymm_ymm_ymmm256
				0x003D0002, 0x03204009, 0x0002125E,// EVEX_Vpmaxsd_xmm_k1z_xmm_xmmm128b32
				0x003D0002, 0x03208409, 0x0002229F,// EVEX_Vpmaxsd_ymm_k1z_ymm_ymmm256b32
				0x003D0002, 0x0320C809, 0x000232E0,// EVEX_Vpmaxsd_zmm_k1z_zmm_zmmm512b32
				0x003D0002, 0x03205009, 0x0002125E,// EVEX_Vpmaxsq_xmm_k1z_xmm_xmmm128b64
				0x003D0002, 0x03209409, 0x0002229F,// EVEX_Vpmaxsq_ymm_k1z_ymm_ymmm256b64
				0x003D0002, 0x0320D809, 0x000232E0,// EVEX_Vpmaxsq_zmm_k1z_zmm_zmmm512b64
				0x003E0000, 0x00008009, 0x00003263,// Pmaxuw_xmm_xmmm128
				0x003E0001, 0x00004C09, 0x000253A2,// VEX_Vpmaxuw_xmm_xmm_xmmm128
				0x003E0001, 0x00005009, 0x000263E3,// VEX_Vpmaxuw_ymm_ymm_ymmm256
				0x003E0002, 0x0301E009, 0x0002125E,// EVEX_Vpmaxuw_xmm_k1z_xmm_xmmm128
				0x003E0002, 0x03022409, 0x0002229F,// EVEX_Vpmaxuw_ymm_k1z_ymm_ymmm256
				0x003E0002, 0x03026809, 0x000232E0,// EVEX_Vpmaxuw_zmm_k1z_zmm_zmmm512
				0x003F0000, 0x00008009, 0x00003263,// Pmaxud_xmm_xmmm128
				0x003F0001, 0x00004C09, 0x000253A2,// VEX_Vpmaxud_xmm_xmm_xmmm128
				0x003F0001, 0x00005009, 0x000263E3,// VEX_Vpmaxud_ymm_ymm_ymmm256
				0x003F0002, 0x03204009, 0x0002125E,// EVEX_Vpmaxud_xmm_k1z_xmm_xmmm128b32
				0x003F0002, 0x03208409, 0x0002229F,// EVEX_Vpmaxud_ymm_k1z_ymm_ymmm256b32
				0x003F0002, 0x0320C809, 0x000232E0,// EVEX_Vpmaxud_zmm_k1z_zmm_zmmm512b32
				0x003F0002, 0x03205009, 0x0002125E,// EVEX_Vpmaxuq_xmm_k1z_xmm_xmmm128b64
				0x003F0002, 0x03209409, 0x0002229F,// EVEX_Vpmaxuq_ymm_k1z_ymm_ymmm256b64
				0x003F0002, 0x0320D809, 0x000232E0,// EVEX_Vpmaxuq_zmm_k1z_zmm_zmmm512b64
				0x00400000, 0x00008009, 0x00003263,// Pmulld_xmm_xmmm128
				0x00400001, 0x00004C09, 0x000253A2,// VEX_Vpmulld_xmm_xmm_xmmm128
				0x00400001, 0x00005009, 0x000263E3,// VEX_Vpmulld_ymm_ymm_ymmm256
				0x00400002, 0x03204009, 0x0002125E,// EVEX_Vpmulld_xmm_k1z_xmm_xmmm128b32
				0x00400002, 0x03208409, 0x0002229F,// EVEX_Vpmulld_ymm_k1z_ymm_ymmm256b32
				0x00400002, 0x0320C809, 0x000232E0,// EVEX_Vpmulld_zmm_k1z_zmm_zmmm512b32
				0x00400002, 0x03205009, 0x0002125E,// EVEX_Vpmullq_xmm_k1z_xmm_xmmm128b64
				0x00400002, 0x03209409, 0x0002229F,// EVEX_Vpmullq_ymm_k1z_ymm_ymmm256b64
				0x00400002, 0x0320D809, 0x000232E0,// EVEX_Vpmullq_zmm_k1z_zmm_zmmm512b64
				0x00410000, 0x00008009, 0x00003263,// Phminposuw_xmm_xmmm128
				0x00410001, 0x00004C09, 0x00000962,// VEX_Vphminposuw_xmm_xmmm128
				0x00420002, 0x03204009, 0x0000085E,// EVEX_Vgetexpps_xmm_k1z_xmmm128b32
				0x00420002, 0x03208409, 0x0000089F,// EVEX_Vgetexpps_ymm_k1z_ymmm256b32
				0x00420002, 0x03A0C809, 0x000008E0,// EVEX_Vgetexpps_zmm_k1z_zmmm512b32_sae
				0x00420002, 0x03205009, 0x0000085E,// EVEX_Vgetexppd_xmm_k1z_xmmm128b64
				0x00420002, 0x03209409, 0x0000089F,// EVEX_Vgetexppd_ymm_k1z_ymmm256b64
				0x00420002, 0x03A0D809, 0x000008E0,// EVEX_Vgetexppd_zmm_k1z_zmmm512b64_sae
				0x00430002, 0x03928009, 0x0002125E,// EVEX_Vgetexpss_xmm_k1z_xmm_xmmm32_sae
				0x00430002, 0x03929009, 0x0002125E,// EVEX_Vgetexpsd_xmm_k1z_xmm_xmmm64_sae
				0x00440002, 0x03204009, 0x0000085E,// EVEX_Vplzcntd_xmm_k1z_xmmm128b32
				0x00440002, 0x03208409, 0x0000089F,// EVEX_Vplzcntd_ymm_k1z_ymmm256b32
				0x00440002, 0x0320C809, 0x000008E0,// EVEX_Vplzcntd_zmm_k1z_zmmm512b32
				0x00440002, 0x03205009, 0x0000085E,// EVEX_Vplzcntq_xmm_k1z_xmmm128b64
				0x00440002, 0x03209409, 0x0000089F,// EVEX_Vplzcntq_ymm_k1z_ymmm256b64
				0x00440002, 0x0320D809, 0x000008E0,// EVEX_Vplzcntq_zmm_k1z_zmmm512b64
				0x00450001, 0x00000C09, 0x000253A2,// VEX_Vpsrlvd_xmm_xmm_xmmm128
				0x00450001, 0x00001009, 0x000263E3,// VEX_Vpsrlvd_ymm_ymm_ymmm256
				0x00450001, 0x00002C09, 0x000253A2,// VEX_Vpsrlvq_xmm_xmm_xmmm128
				0x00450001, 0x00003009, 0x000263E3,// VEX_Vpsrlvq_ymm_ymm_ymmm256
				0x00450002, 0x03204009, 0x0002125E,// EVEX_Vpsrlvd_xmm_k1z_xmm_xmmm128b32
				0x00450002, 0x03208409, 0x0002229F,// EVEX_Vpsrlvd_ymm_k1z_ymm_ymmm256b32
				0x00450002, 0x0320C809, 0x000232E0,// EVEX_Vpsrlvd_zmm_k1z_zmm_zmmm512b32
				0x00450002, 0x03205009, 0x0002125E,// EVEX_Vpsrlvq_xmm_k1z_xmm_xmmm128b64
				0x00450002, 0x03209409, 0x0002229F,// EVEX_Vpsrlvq_ymm_k1z_ymm_ymmm256b64
				0x00450002, 0x0320D809, 0x000232E0,// EVEX_Vpsrlvq_zmm_k1z_zmm_zmmm512b64
				0x00460001, 0x00000C09, 0x000253A2,// VEX_Vpsravd_xmm_xmm_xmmm128
				0x00460001, 0x00001009, 0x000263E3,// VEX_Vpsravd_ymm_ymm_ymmm256
				0x00460002, 0x03204009, 0x0002125E,// EVEX_Vpsravd_xmm_k1z_xmm_xmmm128b32
				0x00460002, 0x03208409, 0x0002229F,// EVEX_Vpsravd_ymm_k1z_ymm_ymmm256b32
				0x00460002, 0x0320C809, 0x000232E0,// EVEX_Vpsravd_zmm_k1z_zmm_zmmm512b32
				0x00460002, 0x03205009, 0x0002125E,// EVEX_Vpsravq_xmm_k1z_xmm_xmmm128b64
				0x00460002, 0x03209409, 0x0002229F,// EVEX_Vpsravq_ymm_k1z_ymm_ymmm256b64
				0x00460002, 0x0320D809, 0x000232E0,// EVEX_Vpsravq_zmm_k1z_zmm_zmmm512b64
				0x00470001, 0x00000C09, 0x000253A2,// VEX_Vpsllvd_xmm_xmm_xmmm128
				0x00470001, 0x00001009, 0x000263E3,// VEX_Vpsllvd_ymm_ymm_ymmm256
				0x00470001, 0x00002C09, 0x000253A2,// VEX_Vpsllvq_xmm_xmm_xmmm128
				0x00470001, 0x00003009, 0x000263E3,// VEX_Vpsllvq_ymm_ymm_ymmm256
				0x00470002, 0x03204009, 0x0002125E,// EVEX_Vpsllvd_xmm_k1z_xmm_xmmm128b32
				0x00470002, 0x03208409, 0x0002229F,// EVEX_Vpsllvd_ymm_k1z_ymm_ymmm256b32
				0x00470002, 0x0320C809, 0x000232E0,// EVEX_Vpsllvd_zmm_k1z_zmm_zmmm512b32
				0x00470002, 0x03205009, 0x0002125E,// EVEX_Vpsllvq_xmm_k1z_xmm_xmmm128b64
				0x00470002, 0x03209409, 0x0002229F,// EVEX_Vpsllvq_ymm_k1z_ymm_ymmm256b64
				0x00470002, 0x0320D809, 0x000232E0,// EVEX_Vpsllvq_zmm_k1z_zmm_zmmm512b64
				0x004C0002, 0x03204009, 0x0000085E,// EVEX_Vrcp14ps_xmm_k1z_xmmm128b32
				0x004C0002, 0x03208409, 0x0000089F,// EVEX_Vrcp14ps_ymm_k1z_ymmm256b32
				0x004C0002, 0x0320C809, 0x000008E0,// EVEX_Vrcp14ps_zmm_k1z_zmmm512b32
				0x004C0002, 0x03205009, 0x0000085E,// EVEX_Vrcp14pd_xmm_k1z_xmmm128b64
				0x004C0002, 0x03209409, 0x0000089F,// EVEX_Vrcp14pd_ymm_k1z_ymmm256b64
				0x004C0002, 0x0320D809, 0x000008E0,// EVEX_Vrcp14pd_zmm_k1z_zmmm512b64
				0x004D0002, 0x03128009, 0x0002125E,// EVEX_Vrcp14ss_xmm_k1z_xmm_xmmm32
				0x004D0002, 0x03129009, 0x0002125E,// EVEX_Vrcp14sd_xmm_k1z_xmm_xmmm64
				0x004E0002, 0x03204009, 0x0000085E,// EVEX_Vrsqrt14ps_xmm_k1z_xmmm128b32
				0x004E0002, 0x03208409, 0x0000089F,// EVEX_Vrsqrt14ps_ymm_k1z_ymmm256b32
				0x004E0002, 0x0320C809, 0x000008E0,// EVEX_Vrsqrt14ps_zmm_k1z_zmmm512b32
				0x004E0002, 0x03205009, 0x0000085E,// EVEX_Vrsqrt14pd_xmm_k1z_xmmm128b64
				0x004E0002, 0x03209409, 0x0000089F,// EVEX_Vrsqrt14pd_ymm_k1z_ymmm256b64
				0x004E0002, 0x0320D809, 0x000008E0,// EVEX_Vrsqrt14pd_zmm_k1z_zmmm512b64
				0x004F0002, 0x03128009, 0x0002125E,// EVEX_Vrsqrt14ss_xmm_k1z_xmm_xmmm32
				0x004F0002, 0x03129009, 0x0002125E,// EVEX_Vrsqrt14sd_xmm_k1z_xmm_xmmm64
				0x00500002, 0x03204009, 0x0002125E,// EVEX_Vpdpbusd_xmm_k1z_xmm_xmmm128b32
				0x00500002, 0x03208409, 0x0002229F,// EVEX_Vpdpbusd_ymm_k1z_ymm_ymmm256b32
				0x00500002, 0x0320C809, 0x000232E0,// EVEX_Vpdpbusd_zmm_k1z_zmm_zmmm512b32
				0x00510002, 0x03204009, 0x0002125E,// EVEX_Vpdpbusds_xmm_k1z_xmm_xmmm128b32
				0x00510002, 0x03208409, 0x0002229F,// EVEX_Vpdpbusds_ymm_k1z_ymm_ymmm256b32
				0x00510002, 0x0320C809, 0x000232E0,// EVEX_Vpdpbusds_zmm_k1z_zmm_zmmm512b32
				0x00520002, 0x03204009, 0x0002125E,// EVEX_Vpdpwssd_xmm_k1z_xmm_xmmm128b32
				0x00520002, 0x03208409, 0x0002229F,// EVEX_Vpdpwssd_ymm_k1z_ymm_ymmm256b32
				0x00520002, 0x0320C809, 0x000232E0,// EVEX_Vpdpwssd_zmm_k1z_zmm_zmmm512b32
				0x00520002, 0x0320400A, 0x0002125E,// EVEX_Vdpbf16ps_xmm_k1z_xmm_xmmm128b32
				0x00520002, 0x0320840A, 0x0002229F,// EVEX_Vdpbf16ps_ymm_k1z_ymm_ymmm256b32
				0x00520002, 0x0320C80A, 0x000232E0,// EVEX_Vdpbf16ps_zmm_k1z_zmm_zmmm512b32
				0x00520002, 0x0305080B, 0x0000F360,// EVEX_Vp4dpwssd_zmm_k1z_zmmp3_m128
				0x00530002, 0x03204009, 0x0002125E,// EVEX_Vpdpwssds_xmm_k1z_xmm_xmmm128b32
				0x00530002, 0x03208409, 0x0002229F,// EVEX_Vpdpwssds_ymm_k1z_ymm_ymmm256b32
				0x00530002, 0x0320C809, 0x000232E0,// EVEX_Vpdpwssds_zmm_k1z_zmm_zmmm512b32
				0x00530002, 0x0305080B, 0x0000F360,// EVEX_Vp4dpwssds_zmm_k1z_zmmp3_m128
				0x00540002, 0x0301C009, 0x0000085E,// EVEX_Vpopcntb_xmm_k1z_xmmm128
				0x00540002, 0x03020409, 0x0000089F,// EVEX_Vpopcntb_ymm_k1z_ymmm256
				0x00540002, 0x03024809, 0x000008E0,// EVEX_Vpopcntb_zmm_k1z_zmmm512
				0x00540002, 0x0301D009, 0x0000085E,// EVEX_Vpopcntw_xmm_k1z_xmmm128
				0x00540002, 0x03021409, 0x0000089F,// EVEX_Vpopcntw_ymm_k1z_ymmm256
				0x00540002, 0x03025809, 0x000008E0,// EVEX_Vpopcntw_zmm_k1z_zmmm512
				0x00550002, 0x03204009, 0x0000085E,// EVEX_Vpopcntd_xmm_k1z_xmmm128b32
				0x00550002, 0x03208409, 0x0000089F,// EVEX_Vpopcntd_ymm_k1z_ymmm256b32
				0x00550002, 0x0320C809, 0x000008E0,// EVEX_Vpopcntd_zmm_k1z_zmmm512b32
				0x00550002, 0x03205009, 0x0000085E,// EVEX_Vpopcntq_xmm_k1z_xmmm128b64
				0x00550002, 0x03209409, 0x0000089F,// EVEX_Vpopcntq_ymm_k1z_ymmm256b64
				0x00550002, 0x0320D809, 0x000008E0,// EVEX_Vpopcntq_zmm_k1z_zmmm512b64
				0x00580001, 0x00000C09, 0x00000962,// VEX_Vpbroadcastd_xmm_xmmm32
				0x00580001, 0x00001009, 0x00000963,// VEX_Vpbroadcastd_ymm_xmmm32
				0x00580002, 0x03028009, 0x0000085E,// EVEX_Vpbroadcastd_xmm_k1z_xmmm32
				0x00580002, 0x03028409, 0x0000085F,// EVEX_Vpbroadcastd_ymm_k1z_xmmm32
				0x00580002, 0x03028809, 0x00000860,// EVEX_Vpbroadcastd_zmm_k1z_xmmm32
				0x00590001, 0x00000C09, 0x00000962,// VEX_Vpbroadcastq_xmm_xmmm64
				0x00590001, 0x00001009, 0x00000963,// VEX_Vpbroadcastq_ymm_xmmm64
				0x00590002, 0x03044009, 0x0000085E,// EVEX_Vbroadcasti32x2_xmm_k1z_xmmm64
				0x00590002, 0x03044409, 0x0000085F,// EVEX_Vbroadcasti32x2_ymm_k1z_xmmm64
				0x00590002, 0x03044809, 0x00000860,// EVEX_Vbroadcasti32x2_zmm_k1z_xmmm64
				0x00590002, 0x03029009, 0x0000085E,// EVEX_Vpbroadcastq_xmm_k1z_xmmm64
				0x00590002, 0x03029409, 0x0000085F,// EVEX_Vpbroadcastq_ymm_k1z_xmmm64
				0x00590002, 0x03029809, 0x00000860,// EVEX_Vpbroadcastq_zmm_k1z_xmmm64
				0x005A0001, 0x00001009, 0x000005A3,// VEX_Vbroadcasti128_ymm_m128
				0x005A0002, 0x03048409, 0x000003DF,// EVEX_Vbroadcasti32x4_ymm_k1z_m128
				0x005A0002, 0x03048809, 0x000003E0,// EVEX_Vbroadcasti32x4_zmm_k1z_m128
				0x005A0002, 0x03045409, 0x000003DF,// EVEX_Vbroadcasti64x2_ymm_k1z_m128
				0x005A0002, 0x03045809, 0x000003E0,// EVEX_Vbroadcasti64x2_zmm_k1z_m128
				0x005B0002, 0x0304C809, 0x000003E0,// EVEX_Vbroadcasti32x8_zmm_k1z_m256
				0x005B0002, 0x03049809, 0x000003E0,// EVEX_Vbroadcasti64x4_zmm_k1z_m256
				0x00620002, 0x0302C009, 0x0000085E,// EVEX_Vpexpandb_xmm_k1z_xmmm128
				0x00620002, 0x0302C409, 0x0000089F,// EVEX_Vpexpandb_ymm_k1z_ymmm256
				0x00620002, 0x0302C809, 0x000008E0,// EVEX_Vpexpandb_zmm_k1z_zmmm512
				0x00620002, 0x03031009, 0x0000085E,// EVEX_Vpexpandw_xmm_k1z_xmmm128
				0x00620002, 0x03031409, 0x0000089F,// EVEX_Vpexpandw_ymm_k1z_ymmm256
				0x00620002, 0x03031809, 0x000008E0,// EVEX_Vpexpandw_zmm_k1z_zmmm512
				0x00630002, 0x0302C009, 0x000007A1,// EVEX_Vpcompressb_xmmm128_k1z_xmm
				0x00630002, 0x0302C409, 0x000007E2,// EVEX_Vpcompressb_ymmm256_k1z_ymm
				0x00630002, 0x0302C809, 0x00000823,// EVEX_Vpcompressb_zmmm512_k1z_zmm
				0x00630002, 0x03031009, 0x000007A1,// EVEX_Vpcompressw_xmmm128_k1z_xmm
				0x00630002, 0x03031409, 0x000007E2,// EVEX_Vpcompressw_ymmm256_k1z_ymm
				0x00630002, 0x03031809, 0x00000823,// EVEX_Vpcompressw_zmmm512_k1z_zmm
				0x00640002, 0x03204009, 0x0002125E,// EVEX_Vpblendmd_xmm_k1z_xmm_xmmm128b32
				0x00640002, 0x03208409, 0x0002229F,// EVEX_Vpblendmd_ymm_k1z_ymm_ymmm256b32
				0x00640002, 0x0320C809, 0x000232E0,// EVEX_Vpblendmd_zmm_k1z_zmm_zmmm512b32
				0x00640002, 0x03205009, 0x0002125E,// EVEX_Vpblendmq_xmm_k1z_xmm_xmmm128b64
				0x00640002, 0x03209409, 0x0002229F,// EVEX_Vpblendmq_ymm_k1z_ymm_ymmm256b64
				0x00640002, 0x0320D809, 0x000232E0,// EVEX_Vpblendmq_zmm_k1z_zmm_zmmm512b64
				0x00650002, 0x03204009, 0x0002125E,// EVEX_Vblendmps_xmm_k1z_xmm_xmmm128b32
				0x00650002, 0x03208409, 0x0002229F,// EVEX_Vblendmps_ymm_k1z_ymm_ymmm256b32
				0x00650002, 0x0320C809, 0x000232E0,// EVEX_Vblendmps_zmm_k1z_zmm_zmmm512b32
				0x00650002, 0x03205009, 0x0002125E,// EVEX_Vblendmpd_xmm_k1z_xmm_xmmm128b64
				0x00650002, 0x03209409, 0x0002229F,// EVEX_Vblendmpd_ymm_k1z_ymm_ymmm256b64
				0x00650002, 0x0320D809, 0x000232E0,// EVEX_Vblendmpd_zmm_k1z_zmm_zmmm512b64
				0x00660002, 0x0301C009, 0x0002125E,// EVEX_Vpblendmb_xmm_k1z_xmm_xmmm128
				0x00660002, 0x03020409, 0x0002229F,// EVEX_Vpblendmb_ymm_k1z_ymm_ymmm256
				0x00660002, 0x03024809, 0x000232E0,// EVEX_Vpblendmb_zmm_k1z_zmm_zmmm512
				0x00660002, 0x0301D009, 0x0002125E,// EVEX_Vpblendmw_xmm_k1z_xmm_xmmm128
				0x00660002, 0x03021409, 0x0002229F,// EVEX_Vpblendmw_ymm_k1z_ymm_ymmm256
				0x00660002, 0x03025809, 0x000232E0,// EVEX_Vpblendmw_zmm_k1z_zmm_zmmm512
				0x00680002, 0x0020400B, 0x0002125D,// EVEX_Vp2intersectd_kp1_xmm_xmmm128b32
				0x00680002, 0x0020840B, 0x0002229D,// EVEX_Vp2intersectd_kp1_ymm_ymmm256b32
				0x00680002, 0x0020C80B, 0x000232DD,// EVEX_Vp2intersectd_kp1_zmm_zmmm512b32
				0x00680002, 0x0020500B, 0x0002125D,// EVEX_Vp2intersectq_kp1_xmm_xmmm128b64
				0x00680002, 0x0020940B, 0x0002229D,// EVEX_Vp2intersectq_kp1_ymm_ymmm256b64
				0x00680002, 0x0020D80B, 0x000232DD,// EVEX_Vp2intersectq_kp1_zmm_zmmm512b64
				0x00700002, 0x0301D009, 0x0002125E,// EVEX_Vpshldvw_xmm_k1z_xmm_xmmm128
				0x00700002, 0x03021409, 0x0002229F,// EVEX_Vpshldvw_ymm_k1z_ymm_ymmm256
				0x00700002, 0x03025809, 0x000232E0,// EVEX_Vpshldvw_zmm_k1z_zmm_zmmm512
				0x00710002, 0x03204009, 0x0002125E,// EVEX_Vpshldvd_xmm_k1z_xmm_xmmm128b32
				0x00710002, 0x03208409, 0x0002229F,// EVEX_Vpshldvd_ymm_k1z_ymm_ymmm256b32
				0x00710002, 0x0320C809, 0x000232E0,// EVEX_Vpshldvd_zmm_k1z_zmm_zmmm512b32
				0x00710002, 0x03205009, 0x0002125E,// EVEX_Vpshldvq_xmm_k1z_xmm_xmmm128b64
				0x00710002, 0x03209409, 0x0002229F,// EVEX_Vpshldvq_ymm_k1z_ymm_ymmm256b64
				0x00710002, 0x0320D809, 0x000232E0,// EVEX_Vpshldvq_zmm_k1z_zmm_zmmm512b64
				0x00720002, 0x0301D009, 0x0002125E,// EVEX_Vpshrdvw_xmm_k1z_xmm_xmmm128
				0x00720002, 0x03021409, 0x0002229F,// EVEX_Vpshrdvw_ymm_k1z_ymm_ymmm256
				0x00720002, 0x03025809, 0x000232E0,// EVEX_Vpshrdvw_zmm_k1z_zmm_zmmm512
				0x00720002, 0x0320400A, 0x0000085E,// EVEX_Vcvtneps2bf16_xmm_k1z_xmmm128b32
				0x00720002, 0x0320840A, 0x0000089E,// EVEX_Vcvtneps2bf16_xmm_k1z_ymmm256b32
				0x00720002, 0x0320C80A, 0x000008DF,// EVEX_Vcvtneps2bf16_ymm_k1z_zmmm512b32
				0x00720002, 0x0320400B, 0x0002125E,// EVEX_Vcvtne2ps2bf16_xmm_k1z_xmm_xmmm128b32
				0x00720002, 0x0320840B, 0x0002229F,// EVEX_Vcvtne2ps2bf16_ymm_k1z_ymm_ymmm256b32
				0x00720002, 0x0320C80B, 0x000232E0,// EVEX_Vcvtne2ps2bf16_zmm_k1z_zmm_zmmm512b32
				0x00730002, 0x03204009, 0x0002125E,// EVEX_Vpshrdvd_xmm_k1z_xmm_xmmm128b32
				0x00730002, 0x03208409, 0x0002229F,// EVEX_Vpshrdvd_ymm_k1z_ymm_ymmm256b32
				0x00730002, 0x0320C809, 0x000232E0,// EVEX_Vpshrdvd_zmm_k1z_zmm_zmmm512b32
				0x00730002, 0x03205009, 0x0002125E,// EVEX_Vpshrdvq_xmm_k1z_xmm_xmmm128b64
				0x00730002, 0x03209409, 0x0002229F,// EVEX_Vpshrdvq_ymm_k1z_ymm_ymmm256b64
				0x00730002, 0x0320D809, 0x000232E0,// EVEX_Vpshrdvq_zmm_k1z_zmm_zmmm512b64
				0x00750002, 0x0301C009, 0x0002125E,// EVEX_Vpermi2b_xmm_k1z_xmm_xmmm128
				0x00750002, 0x03020409, 0x0002229F,// EVEX_Vpermi2b_ymm_k1z_ymm_ymmm256
				0x00750002, 0x03024809, 0x000232E0,// EVEX_Vpermi2b_zmm_k1z_zmm_zmmm512
				0x00750002, 0x0301D009, 0x0002125E,// EVEX_Vpermi2w_xmm_k1z_xmm_xmmm128
				0x00750002, 0x03021409, 0x0002229F,// EVEX_Vpermi2w_ymm_k1z_ymm_ymmm256
				0x00750002, 0x03025809, 0x000232E0,// EVEX_Vpermi2w_zmm_k1z_zmm_zmmm512
				0x00760002, 0x03204009, 0x0002125E,// EVEX_Vpermi2d_xmm_k1z_xmm_xmmm128b32
				0x00760002, 0x03208409, 0x0002229F,// EVEX_Vpermi2d_ymm_k1z_ymm_ymmm256b32
				0x00760002, 0x0320C809, 0x000232E0,// EVEX_Vpermi2d_zmm_k1z_zmm_zmmm512b32
				0x00760002, 0x03205009, 0x0002125E,// EVEX_Vpermi2q_xmm_k1z_xmm_xmmm128b64
				0x00760002, 0x03209409, 0x0002229F,// EVEX_Vpermi2q_ymm_k1z_ymm_ymmm256b64
				0x00760002, 0x0320D809, 0x000232E0,// EVEX_Vpermi2q_zmm_k1z_zmm_zmmm512b64
				0x00770002, 0x03204009, 0x0002125E,// EVEX_Vpermi2ps_xmm_k1z_xmm_xmmm128b32
				0x00770002, 0x03208409, 0x0002229F,// EVEX_Vpermi2ps_ymm_k1z_ymm_ymmm256b32
				0x00770002, 0x0320C809, 0x000232E0,// EVEX_Vpermi2ps_zmm_k1z_zmm_zmmm512b32
				0x00770002, 0x03205009, 0x0002125E,// EVEX_Vpermi2pd_xmm_k1z_xmm_xmmm128b64
				0x00770002, 0x03209409, 0x0002229F,// EVEX_Vpermi2pd_ymm_k1z_ymm_ymmm256b64
				0x00770002, 0x0320D809, 0x000232E0,// EVEX_Vpermi2pd_zmm_k1z_zmm_zmmm512b64
				0x00780001, 0x00000C09, 0x00000962,// VEX_Vpbroadcastb_xmm_xmmm8
				0x00780001, 0x00001009, 0x00000963,// VEX_Vpbroadcastb_ymm_xmmm8
				0x00780002, 0x0302C009, 0x0000085E,// EVEX_Vpbroadcastb_xmm_k1z_xmmm8
				0x00780002, 0x0302C409, 0x0000085F,// EVEX_Vpbroadcastb_ymm_k1z_xmmm8
				0x00780002, 0x0302C809, 0x00000860,// EVEX_Vpbroadcastb_zmm_k1z_xmmm8
				0x00790001, 0x00000C09, 0x00000962,// VEX_Vpbroadcastw_xmm_xmmm16
				0x00790001, 0x00001009, 0x00000963,// VEX_Vpbroadcastw_ymm_xmmm16
				0x00790002, 0x03030009, 0x0000085E,// EVEX_Vpbroadcastw_xmm_k1z_xmmm16
				0x00790002, 0x03030409, 0x0000085F,// EVEX_Vpbroadcastw_ymm_k1z_xmmm16
				0x00790002, 0x03030809, 0x00000860,// EVEX_Vpbroadcastw_zmm_k1z_xmmm16
				0x007A0002, 0x03000009, 0x0000041E,// EVEX_Vpbroadcastb_xmm_k1z_r32
				0x007A0002, 0x03000409, 0x0000041F,// EVEX_Vpbroadcastb_ymm_k1z_r32
				0x007A0002, 0x03000809, 0x00000420,// EVEX_Vpbroadcastb_zmm_k1z_r32
				0x007B0002, 0x03000009, 0x0000041E,// EVEX_Vpbroadcastw_xmm_k1z_r32
				0x007B0002, 0x03000409, 0x0000041F,// EVEX_Vpbroadcastw_ymm_k1z_r32
				0x007B0002, 0x03000809, 0x00000420,// EVEX_Vpbroadcastw_zmm_k1z_r32
				0x007C0002, 0x03003009, 0x0000041E,// EVEX_Vpbroadcastd_xmm_k1z_r32
				0x007C0002, 0x03003409, 0x0000041F,// EVEX_Vpbroadcastd_ymm_k1z_r32
				0x007C0002, 0x03003809, 0x00000420,// EVEX_Vpbroadcastd_zmm_k1z_r32
				0x007C0002, 0x03001029, 0x0000045E,// EVEX_Vpbroadcastq_xmm_k1z_r64
				0x007C0002, 0x03001429, 0x0000045F,// EVEX_Vpbroadcastq_ymm_k1z_r64
				0x007C0002, 0x03001829, 0x00000460,// EVEX_Vpbroadcastq_zmm_k1z_r64
				0x007D0002, 0x0301C009, 0x0002125E,// EVEX_Vpermt2b_xmm_k1z_xmm_xmmm128
				0x007D0002, 0x03020409, 0x0002229F,// EVEX_Vpermt2b_ymm_k1z_ymm_ymmm256
				0x007D0002, 0x03024809, 0x000232E0,// EVEX_Vpermt2b_zmm_k1z_zmm_zmmm512
				0x007D0002, 0x0301D009, 0x0002125E,// EVEX_Vpermt2w_xmm_k1z_xmm_xmmm128
				0x007D0002, 0x03021409, 0x0002229F,// EVEX_Vpermt2w_ymm_k1z_ymm_ymmm256
				0x007D0002, 0x03025809, 0x000232E0,// EVEX_Vpermt2w_zmm_k1z_zmm_zmmm512
				0x007E0002, 0x03204009, 0x0002125E,// EVEX_Vpermt2d_xmm_k1z_xmm_xmmm128b32
				0x007E0002, 0x03208409, 0x0002229F,// EVEX_Vpermt2d_ymm_k1z_ymm_ymmm256b32
				0x007E0002, 0x0320C809, 0x000232E0,// EVEX_Vpermt2d_zmm_k1z_zmm_zmmm512b32
				0x007E0002, 0x03205009, 0x0002125E,// EVEX_Vpermt2q_xmm_k1z_xmm_xmmm128b64
				0x007E0002, 0x03209409, 0x0002229F,// EVEX_Vpermt2q_ymm_k1z_ymm_ymmm256b64
				0x007E0002, 0x0320D809, 0x000232E0,// EVEX_Vpermt2q_zmm_k1z_zmm_zmmm512b64
				0x007F0002, 0x03204009, 0x0002125E,// EVEX_Vpermt2ps_xmm_k1z_xmm_xmmm128b32
				0x007F0002, 0x03208409, 0x0002229F,// EVEX_Vpermt2ps_ymm_k1z_ymm_ymmm256b32
				0x007F0002, 0x0320C809, 0x000232E0,// EVEX_Vpermt2ps_zmm_k1z_zmm_zmmm512b32
				0x007F0002, 0x03205009, 0x0002125E,// EVEX_Vpermt2pd_xmm_k1z_xmm_xmmm128b64
				0x007F0002, 0x03209409, 0x0002229F,// EVEX_Vpermt2pd_ymm_k1z_ymm_ymmm256b64
				0x007F0002, 0x0320D809, 0x000232E0,// EVEX_Vpermt2pd_zmm_k1z_zmm_zmmm512b64
				0x00800000, 0x00008019, 0x000001AB,// Invept_r32_m128
				0x00800000, 0x00008029, 0x000001AC,// Invept_r64_m128
				0x00810000, 0x00008019, 0x000001AB,// Invvpid_r32_m128
				0x00810000, 0x00008029, 0x000001AC,// Invvpid_r64_m128
				0x00820000, 0x00008019, 0x000001AB,// Invpcid_r32_m128
				0x00820000, 0x00008029, 0x000001AC,// Invpcid_r64_m128
				0x00830002, 0x03205009, 0x0002125E,// EVEX_Vpmultishiftqb_xmm_k1z_xmm_xmmm128b64
				0x00830002, 0x03209409, 0x0002229F,// EVEX_Vpmultishiftqb_ymm_k1z_ymm_ymmm256b64
				0x00830002, 0x0320D809, 0x000232E0,// EVEX_Vpmultishiftqb_zmm_k1z_zmm_zmmm512b64
				0x00880002, 0x03028009, 0x0000085E,// EVEX_Vexpandps_xmm_k1z_xmmm128
				0x00880002, 0x03028409, 0x0000089F,// EVEX_Vexpandps_ymm_k1z_ymmm256
				0x00880002, 0x03028809, 0x000008E0,// EVEX_Vexpandps_zmm_k1z_zmmm512
				0x00880002, 0x03029009, 0x0000085E,// EVEX_Vexpandpd_xmm_k1z_xmmm128
				0x00880002, 0x03029409, 0x0000089F,// EVEX_Vexpandpd_ymm_k1z_ymmm256
				0x00880002, 0x03029809, 0x000008E0,// EVEX_Vexpandpd_zmm_k1z_zmmm512
				0x00890002, 0x03028009, 0x0000085E,// EVEX_Vpexpandd_xmm_k1z_xmmm128
				0x00890002, 0x03028409, 0x0000089F,// EVEX_Vpexpandd_ymm_k1z_ymmm256
				0x00890002, 0x03028809, 0x000008E0,// EVEX_Vpexpandd_zmm_k1z_zmmm512
				0x00890002, 0x03029009, 0x0000085E,// EVEX_Vpexpandq_xmm_k1z_xmmm128
				0x00890002, 0x03029409, 0x0000089F,// EVEX_Vpexpandq_ymm_k1z_ymmm256
				0x00890002, 0x03029809, 0x000008E0,// EVEX_Vpexpandq_zmm_k1z_zmmm512
				0x008A0002, 0x03028009, 0x000007A1,// EVEX_Vcompressps_xmmm128_k1z_xmm
				0x008A0002, 0x03028409, 0x000007E2,// EVEX_Vcompressps_ymmm256_k1z_ymm
				0x008A0002, 0x03028809, 0x00000823,// EVEX_Vcompressps_zmmm512_k1z_zmm
				0x008A0002, 0x03029009, 0x000007A1,// EVEX_Vcompresspd_xmmm128_k1z_xmm
				0x008A0002, 0x03029409, 0x000007E2,// EVEX_Vcompresspd_ymmm256_k1z_ymm
				0x008A0002, 0x03029809, 0x00000823,// EVEX_Vcompresspd_zmmm512_k1z_zmm
				0x008B0002, 0x03028009, 0x000007A1,// EVEX_Vpcompressd_xmmm128_k1z_xmm
				0x008B0002, 0x03028409, 0x000007E2,// EVEX_Vpcompressd_ymmm256_k1z_ymm
				0x008B0002, 0x03028809, 0x00000823,// EVEX_Vpcompressd_zmmm512_k1z_zmm
				0x008B0002, 0x03029009, 0x000007A1,// EVEX_Vpcompressq_xmmm128_k1z_xmm
				0x008B0002, 0x03029409, 0x000007E2,// EVEX_Vpcompressq_ymmm256_k1z_ymm
				0x008B0002, 0x03029809, 0x00000823,// EVEX_Vpcompressq_zmmm512_k1z_zmm
				0x008C0001, 0x00000C09, 0x000163A2,// VEX_Vpmaskmovd_xmm_xmm_m128
				0x008C0001, 0x00001009, 0x000163E3,// VEX_Vpmaskmovd_ymm_ymm_m256
				0x008C0001, 0x00002C09, 0x000163A2,// VEX_Vpmaskmovq_xmm_xmm_m128
				0x008C0001, 0x00003009, 0x000163E3,// VEX_Vpmaskmovq_ymm_ymm_m256
				0x008D0002, 0x0301C009, 0x0002125E,// EVEX_Vpermb_xmm_k1z_xmm_xmmm128
				0x008D0002, 0x03020409, 0x0002229F,// EVEX_Vpermb_ymm_k1z_ymm_ymmm256
				0x008D0002, 0x03024809, 0x000232E0,// EVEX_Vpermb_zmm_k1z_zmm_zmmm512
				0x008D0002, 0x0301D009, 0x0002125E,// EVEX_Vpermw_xmm_k1z_xmm_xmmm128
				0x008D0002, 0x03021409, 0x0002229F,// EVEX_Vpermw_ymm_k1z_ymm_ymmm256
				0x008D0002, 0x03025809, 0x000232E0,// EVEX_Vpermw_zmm_k1z_zmm_zmmm512
				0x008E0001, 0x00000C09, 0x00022396,// VEX_Vpmaskmovd_m128_xmm_xmm
				0x008E0001, 0x00001009, 0x000233D6,// VEX_Vpmaskmovd_m256_ymm_ymm
				0x008E0001, 0x00002C09, 0x00022396,// VEX_Vpmaskmovq_m128_xmm_xmm
				0x008E0001, 0x00003009, 0x000233D6,// VEX_Vpmaskmovq_m256_ymm_ymm
				0x008F0002, 0x0101C009, 0x0002125C,// EVEX_Vpshufbitqmb_k_k1_xmm_xmmm128
				0x008F0002, 0x01020409, 0x0002229C,// EVEX_Vpshufbitqmb_k_k1_ymm_ymmm256
				0x008F0002, 0x01024809, 0x000232DC,// EVEX_Vpshufbitqmb_k_k1_zmm_zmmm512
				0x00900001, 0x00000C09, 0x0000E7A2,// VEX_Vpgatherdd_xmm_vm32x_xmm
				0x00900001, 0x00001009, 0x0000F7E3,// VEX_Vpgatherdd_ymm_vm32y_ymm
				0x00900001, 0x00002C09, 0x0000E7A2,// VEX_Vpgatherdq_xmm_vm32x_xmm
				0x00900001, 0x00003009, 0x0000F7A3,// VEX_Vpgatherdq_ymm_vm32x_ymm
				0x00900002, 0x05028009, 0x0000059E,// EVEX_Vpgatherdd_xmm_k1_vm32x
				0x00900002, 0x05028409, 0x000005DF,// EVEX_Vpgatherdd_ymm_k1_vm32y
				0x00900002, 0x05028809, 0x00000620,// EVEX_Vpgatherdd_zmm_k1_vm32z
				0x00900002, 0x05029009, 0x0000059E,// EVEX_Vpgatherdq_xmm_k1_vm32x
				0x00900002, 0x05029409, 0x0000059F,// EVEX_Vpgatherdq_ymm_k1_vm32x
				0x00900002, 0x05029809, 0x000005E0,// EVEX_Vpgatherdq_zmm_k1_vm32y
				0x00910001, 0x00000C09, 0x0000E822,// VEX_Vpgatherqd_xmm_vm64x_xmm
				0x00910001, 0x00001009, 0x0000E862,// VEX_Vpgatherqd_xmm_vm64y_xmm
				0x00910001, 0x00002C09, 0x0000E822,// VEX_Vpgatherqq_xmm_vm64x_xmm
				0x00910001, 0x00003009, 0x0000F863,// VEX_Vpgatherqq_ymm_vm64y_ymm
				0x00910002, 0x05028009, 0x0000065E,// EVEX_Vpgatherqd_xmm_k1_vm64x
				0x00910002, 0x05028409, 0x0000069E,// EVEX_Vpgatherqd_xmm_k1_vm64y
				0x00910002, 0x05028809, 0x000006DF,// EVEX_Vpgatherqd_ymm_k1_vm64z
				0x00910002, 0x05029009, 0x0000065E,// EVEX_Vpgatherqq_xmm_k1_vm64x
				0x00910002, 0x05029409, 0x0000069F,// EVEX_Vpgatherqq_ymm_k1_vm64y
				0x00910002, 0x05029809, 0x000006E0,// EVEX_Vpgatherqq_zmm_k1_vm64z
				0x00920001, 0x00000C09, 0x0000E7A2,// VEX_Vgatherdps_xmm_vm32x_xmm
				0x00920001, 0x00001009, 0x0000F7E3,// VEX_Vgatherdps_ymm_vm32y_ymm
				0x00920001, 0x00002C09, 0x0000E7A2,// VEX_Vgatherdpd_xmm_vm32x_xmm
				0x00920001, 0x00003009, 0x0000F7A3,// VEX_Vgatherdpd_ymm_vm32x_ymm
				0x00920002, 0x05028009, 0x0000059E,// EVEX_Vgatherdps_xmm_k1_vm32x
				0x00920002, 0x05028409, 0x000005DF,// EVEX_Vgatherdps_ymm_k1_vm32y
				0x00920002, 0x05028809, 0x00000620,// EVEX_Vgatherdps_zmm_k1_vm32z
				0x00920002, 0x05029009, 0x0000059E,// EVEX_Vgatherdpd_xmm_k1_vm32x
				0x00920002, 0x05029409, 0x0000059F,// EVEX_Vgatherdpd_ymm_k1_vm32x
				0x00920002, 0x05029809, 0x000005E0,// EVEX_Vgatherdpd_zmm_k1_vm32y
				0x00930001, 0x00000C09, 0x0000E822,// VEX_Vgatherqps_xmm_vm64x_xmm
				0x00930001, 0x00001009, 0x0000E862,// VEX_Vgatherqps_xmm_vm64y_xmm
				0x00930001, 0x00002C09, 0x0000E822,// VEX_Vgatherqpd_xmm_vm64x_xmm
				0x00930001, 0x00003009, 0x0000F863,// VEX_Vgatherqpd_ymm_vm64y_ymm
				0x00930002, 0x05028009, 0x0000065E,// EVEX_Vgatherqps_xmm_k1_vm64x
				0x00930002, 0x05028409, 0x0000069E,// EVEX_Vgatherqps_xmm_k1_vm64y
				0x00930002, 0x05028809, 0x000006DF,// EVEX_Vgatherqps_ymm_k1_vm64z
				0x00930002, 0x05029009, 0x0000065E,// EVEX_Vgatherqpd_xmm_k1_vm64x
				0x00930002, 0x05029409, 0x0000069F,// EVEX_Vgatherqpd_ymm_k1_vm64y
				0x00930002, 0x05029809, 0x000006E0,// EVEX_Vgatherqpd_zmm_k1_vm64z
				0x00960001, 0x00000C09, 0x000253A2,// VEX_Vfmaddsub132ps_xmm_xmm_xmmm128
				0x00960001, 0x00001009, 0x000263E3,// VEX_Vfmaddsub132ps_ymm_ymm_ymmm256
				0x00960001, 0x00002C09, 0x000253A2,// VEX_Vfmaddsub132pd_xmm_xmm_xmmm128
				0x00960001, 0x00003009, 0x000263E3,// VEX_Vfmaddsub132pd_ymm_ymm_ymmm256
				0x00960002, 0x03204009, 0x0002125E,// EVEX_Vfmaddsub132ps_xmm_k1z_xmm_xmmm128b32
				0x00960002, 0x03208409, 0x0002229F,// EVEX_Vfmaddsub132ps_ymm_k1z_ymm_ymmm256b32
				0x00960002, 0x0360C809, 0x000232E0,// EVEX_Vfmaddsub132ps_zmm_k1z_zmm_zmmm512b32_er
				0x00960002, 0x03205009, 0x0002125E,// EVEX_Vfmaddsub132pd_xmm_k1z_xmm_xmmm128b64
				0x00960002, 0x03209409, 0x0002229F,// EVEX_Vfmaddsub132pd_ymm_k1z_ymm_ymmm256b64
				0x00960002, 0x0360D809, 0x000232E0,// EVEX_Vfmaddsub132pd_zmm_k1z_zmm_zmmm512b64_er
				0x00970001, 0x00000C09, 0x000253A2,// VEX_Vfmsubadd132ps_xmm_xmm_xmmm128
				0x00970001, 0x00001009, 0x000263E3,// VEX_Vfmsubadd132ps_ymm_ymm_ymmm256
				0x00970001, 0x00002C09, 0x000253A2,// VEX_Vfmsubadd132pd_xmm_xmm_xmmm128
				0x00970001, 0x00003009, 0x000263E3,// VEX_Vfmsubadd132pd_ymm_ymm_ymmm256
				0x00970002, 0x03204009, 0x0002125E,// EVEX_Vfmsubadd132ps_xmm_k1z_xmm_xmmm128b32
				0x00970002, 0x03208409, 0x0002229F,// EVEX_Vfmsubadd132ps_ymm_k1z_ymm_ymmm256b32
				0x00970002, 0x0360C809, 0x000232E0,// EVEX_Vfmsubadd132ps_zmm_k1z_zmm_zmmm512b32_er
				0x00970002, 0x03205009, 0x0002125E,// EVEX_Vfmsubadd132pd_xmm_k1z_xmm_xmmm128b64
				0x00970002, 0x03209409, 0x0002229F,// EVEX_Vfmsubadd132pd_ymm_k1z_ymm_ymmm256b64
				0x00970002, 0x0360D809, 0x000232E0,// EVEX_Vfmsubadd132pd_zmm_k1z_zmm_zmmm512b64_er
				0x00980001, 0x00000C09, 0x000253A2,// VEX_Vfmadd132ps_xmm_xmm_xmmm128
				0x00980001, 0x00001009, 0x000263E3,// VEX_Vfmadd132ps_ymm_ymm_ymmm256
				0x00980001, 0x00002C09, 0x000253A2,// VEX_Vfmadd132pd_xmm_xmm_xmmm128
				0x00980001, 0x00003009, 0x000263E3,// VEX_Vfmadd132pd_ymm_ymm_ymmm256
				0x00980002, 0x03204009, 0x0002125E,// EVEX_Vfmadd132ps_xmm_k1z_xmm_xmmm128b32
				0x00980002, 0x03208409, 0x0002229F,// EVEX_Vfmadd132ps_ymm_k1z_ymm_ymmm256b32
				0x00980002, 0x0360C809, 0x000232E0,// EVEX_Vfmadd132ps_zmm_k1z_zmm_zmmm512b32_er
				0x00980002, 0x03205009, 0x0002125E,// EVEX_Vfmadd132pd_xmm_k1z_xmm_xmmm128b64
				0x00980002, 0x03209409, 0x0002229F,// EVEX_Vfmadd132pd_ymm_k1z_ymm_ymmm256b64
				0x00980002, 0x0360D809, 0x000232E0,// EVEX_Vfmadd132pd_zmm_k1z_zmm_zmmm512b64_er
				0x00990001, 0x00001409, 0x000253A2,// VEX_Vfmadd132ss_xmm_xmm_xmmm32
				0x00990001, 0x00003409, 0x000253A2,// VEX_Vfmadd132sd_xmm_xmm_xmmm64
				0x00990002, 0x03528009, 0x0002125E,// EVEX_Vfmadd132ss_xmm_k1z_xmm_xmmm32_er
				0x00990002, 0x03529009, 0x0002125E,// EVEX_Vfmadd132sd_xmm_k1z_xmm_xmmm64_er
				0x009A0001, 0x00000C09, 0x000253A2,// VEX_Vfmsub132ps_xmm_xmm_xmmm128
				0x009A0001, 0x00001009, 0x000263E3,// VEX_Vfmsub132ps_ymm_ymm_ymmm256
				0x009A0001, 0x00002C09, 0x000253A2,// VEX_Vfmsub132pd_xmm_xmm_xmmm128
				0x009A0001, 0x00003009, 0x000263E3,// VEX_Vfmsub132pd_ymm_ymm_ymmm256
				0x009A0002, 0x03204009, 0x0002125E,// EVEX_Vfmsub132ps_xmm_k1z_xmm_xmmm128b32
				0x009A0002, 0x03208409, 0x0002229F,// EVEX_Vfmsub132ps_ymm_k1z_ymm_ymmm256b32
				0x009A0002, 0x0360C809, 0x000232E0,// EVEX_Vfmsub132ps_zmm_k1z_zmm_zmmm512b32_er
				0x009A0002, 0x03205009, 0x0002125E,// EVEX_Vfmsub132pd_xmm_k1z_xmm_xmmm128b64
				0x009A0002, 0x03209409, 0x0002229F,// EVEX_Vfmsub132pd_ymm_k1z_ymm_ymmm256b64
				0x009A0002, 0x0360D809, 0x000232E0,// EVEX_Vfmsub132pd_zmm_k1z_zmm_zmmm512b64_er
				0x009A0002, 0x0305080B, 0x0000F360,// EVEX_V4fmaddps_zmm_k1z_zmmp3_m128
				0x009B0001, 0x00001409, 0x000253A2,// VEX_Vfmsub132ss_xmm_xmm_xmmm32
				0x009B0001, 0x00003409, 0x000253A2,// VEX_Vfmsub132sd_xmm_xmm_xmmm64
				0x009B0002, 0x03528009, 0x0002125E,// EVEX_Vfmsub132ss_xmm_k1z_xmm_xmmm32_er
				0x009B0002, 0x03529009, 0x0002125E,// EVEX_Vfmsub132sd_xmm_k1z_xmm_xmmm64_er
				0x009B0002, 0x0315000B, 0x0000F31E,// EVEX_V4fmaddss_xmm_k1z_xmmp3_m128
				0x009C0001, 0x00000C09, 0x000253A2,// VEX_Vfnmadd132ps_xmm_xmm_xmmm128
				0x009C0001, 0x00001009, 0x000263E3,// VEX_Vfnmadd132ps_ymm_ymm_ymmm256
				0x009C0001, 0x00002C09, 0x000253A2,// VEX_Vfnmadd132pd_xmm_xmm_xmmm128
				0x009C0001, 0x00003009, 0x000263E3,// VEX_Vfnmadd132pd_ymm_ymm_ymmm256
				0x009C0002, 0x03204009, 0x0002125E,// EVEX_Vfnmadd132ps_xmm_k1z_xmm_xmmm128b32
				0x009C0002, 0x03208409, 0x0002229F,// EVEX_Vfnmadd132ps_ymm_k1z_ymm_ymmm256b32
				0x009C0002, 0x0360C809, 0x000232E0,// EVEX_Vfnmadd132ps_zmm_k1z_zmm_zmmm512b32_er
				0x009C0002, 0x03205009, 0x0002125E,// EVEX_Vfnmadd132pd_xmm_k1z_xmm_xmmm128b64
				0x009C0002, 0x03209409, 0x0002229F,// EVEX_Vfnmadd132pd_ymm_k1z_ymm_ymmm256b64
				0x009C0002, 0x0360D809, 0x000232E0,// EVEX_Vfnmadd132pd_zmm_k1z_zmm_zmmm512b64_er
				0x009D0001, 0x00001409, 0x000253A2,// VEX_Vfnmadd132ss_xmm_xmm_xmmm32
				0x009D0001, 0x00003409, 0x000253A2,// VEX_Vfnmadd132sd_xmm_xmm_xmmm64
				0x009D0002, 0x03528009, 0x0002125E,// EVEX_Vfnmadd132ss_xmm_k1z_xmm_xmmm32_er
				0x009D0002, 0x03529009, 0x0002125E,// EVEX_Vfnmadd132sd_xmm_k1z_xmm_xmmm64_er
				0x009E0001, 0x00000C09, 0x000253A2,// VEX_Vfnmsub132ps_xmm_xmm_xmmm128
				0x009E0001, 0x00001009, 0x000263E3,// VEX_Vfnmsub132ps_ymm_ymm_ymmm256
				0x009E0001, 0x00002C09, 0x000253A2,// VEX_Vfnmsub132pd_xmm_xmm_xmmm128
				0x009E0001, 0x00003009, 0x000263E3,// VEX_Vfnmsub132pd_ymm_ymm_ymmm256
				0x009E0002, 0x03204009, 0x0002125E,// EVEX_Vfnmsub132ps_xmm_k1z_xmm_xmmm128b32
				0x009E0002, 0x03208409, 0x0002229F,// EVEX_Vfnmsub132ps_ymm_k1z_ymm_ymmm256b32
				0x009E0002, 0x0360C809, 0x000232E0,// EVEX_Vfnmsub132ps_zmm_k1z_zmm_zmmm512b32_er
				0x009E0002, 0x03205009, 0x0002125E,// EVEX_Vfnmsub132pd_xmm_k1z_xmm_xmmm128b64
				0x009E0002, 0x03209409, 0x0002229F,// EVEX_Vfnmsub132pd_ymm_k1z_ymm_ymmm256b64
				0x009E0002, 0x0360D809, 0x000232E0,// EVEX_Vfnmsub132pd_zmm_k1z_zmm_zmmm512b64_er
				0x009F0001, 0x00001409, 0x000253A2,// VEX_Vfnmsub132ss_xmm_xmm_xmmm32
				0x009F0001, 0x00003409, 0x000253A2,// VEX_Vfnmsub132sd_xmm_xmm_xmmm64
				0x009F0002, 0x03528009, 0x0002125E,// EVEX_Vfnmsub132ss_xmm_k1z_xmm_xmmm32_er
				0x009F0002, 0x03529009, 0x0002125E,// EVEX_Vfnmsub132sd_xmm_k1z_xmm_xmmm64_er
				0x00A00002, 0x05028009, 0x00000796,// EVEX_Vpscatterdd_vm32x_k1_xmm
				0x00A00002, 0x05028409, 0x000007D7,// EVEX_Vpscatterdd_vm32y_k1_ymm
				0x00A00002, 0x05028809, 0x00000818,// EVEX_Vpscatterdd_vm32z_k1_zmm
				0x00A00002, 0x05029009, 0x00000796,// EVEX_Vpscatterdq_vm32x_k1_xmm
				0x00A00002, 0x05029409, 0x000007D6,// EVEX_Vpscatterdq_vm32x_k1_ymm
				0x00A00002, 0x05029809, 0x00000817,// EVEX_Vpscatterdq_vm32y_k1_zmm
				0x00A10002, 0x05028009, 0x00000799,// EVEX_Vpscatterqd_vm64x_k1_xmm
				0x00A10002, 0x05028409, 0x0000079A,// EVEX_Vpscatterqd_vm64y_k1_xmm
				0x00A10002, 0x05028809, 0x000007DB,// EVEX_Vpscatterqd_vm64z_k1_ymm
				0x00A10002, 0x05029009, 0x00000799,// EVEX_Vpscatterqq_vm64x_k1_xmm
				0x00A10002, 0x05029409, 0x000007DA,// EVEX_Vpscatterqq_vm64y_k1_ymm
				0x00A10002, 0x05029809, 0x0000081B,// EVEX_Vpscatterqq_vm64z_k1_zmm
				0x00A20002, 0x05028009, 0x00000796,// EVEX_Vscatterdps_vm32x_k1_xmm
				0x00A20002, 0x05028409, 0x000007D7,// EVEX_Vscatterdps_vm32y_k1_ymm
				0x00A20002, 0x05028809, 0x00000818,// EVEX_Vscatterdps_vm32z_k1_zmm
				0x00A20002, 0x05029009, 0x00000796,// EVEX_Vscatterdpd_vm32x_k1_xmm
				0x00A20002, 0x05029409, 0x000007D6,// EVEX_Vscatterdpd_vm32x_k1_ymm
				0x00A20002, 0x05029809, 0x00000817,// EVEX_Vscatterdpd_vm32y_k1_zmm
				0x00A30002, 0x05028009, 0x00000799,// EVEX_Vscatterqps_vm64x_k1_xmm
				0x00A30002, 0x05028409, 0x0000079A,// EVEX_Vscatterqps_vm64y_k1_xmm
				0x00A30002, 0x05028809, 0x000007DB,// EVEX_Vscatterqps_vm64z_k1_ymm
				0x00A30002, 0x05029009, 0x00000799,// EVEX_Vscatterqpd_vm64x_k1_xmm
				0x00A30002, 0x05029409, 0x000007DA,// EVEX_Vscatterqpd_vm64y_k1_ymm
				0x00A30002, 0x05029809, 0x0000081B,// EVEX_Vscatterqpd_vm64z_k1_zmm
				0x00A60001, 0x00000C09, 0x000253A2,// VEX_Vfmaddsub213ps_xmm_xmm_xmmm128
				0x00A60001, 0x00001009, 0x000263E3,// VEX_Vfmaddsub213ps_ymm_ymm_ymmm256
				0x00A60001, 0x00002C09, 0x000253A2,// VEX_Vfmaddsub213pd_xmm_xmm_xmmm128
				0x00A60001, 0x00003009, 0x000263E3,// VEX_Vfmaddsub213pd_ymm_ymm_ymmm256
				0x00A60002, 0x03204009, 0x0002125E,// EVEX_Vfmaddsub213ps_xmm_k1z_xmm_xmmm128b32
				0x00A60002, 0x03208409, 0x0002229F,// EVEX_Vfmaddsub213ps_ymm_k1z_ymm_ymmm256b32
				0x00A60002, 0x0360C809, 0x000232E0,// EVEX_Vfmaddsub213ps_zmm_k1z_zmm_zmmm512b32_er
				0x00A60002, 0x03205009, 0x0002125E,// EVEX_Vfmaddsub213pd_xmm_k1z_xmm_xmmm128b64
				0x00A60002, 0x03209409, 0x0002229F,// EVEX_Vfmaddsub213pd_ymm_k1z_ymm_ymmm256b64
				0x00A60002, 0x0360D809, 0x000232E0,// EVEX_Vfmaddsub213pd_zmm_k1z_zmm_zmmm512b64_er
				0x00A70001, 0x00000C09, 0x000253A2,// VEX_Vfmsubadd213ps_xmm_xmm_xmmm128
				0x00A70001, 0x00001009, 0x000263E3,// VEX_Vfmsubadd213ps_ymm_ymm_ymmm256
				0x00A70001, 0x00002C09, 0x000253A2,// VEX_Vfmsubadd213pd_xmm_xmm_xmmm128
				0x00A70001, 0x00003009, 0x000263E3,// VEX_Vfmsubadd213pd_ymm_ymm_ymmm256
				0x00A70002, 0x03204009, 0x0002125E,// EVEX_Vfmsubadd213ps_xmm_k1z_xmm_xmmm128b32
				0x00A70002, 0x03208409, 0x0002229F,// EVEX_Vfmsubadd213ps_ymm_k1z_ymm_ymmm256b32
				0x00A70002, 0x0360C809, 0x000232E0,// EVEX_Vfmsubadd213ps_zmm_k1z_zmm_zmmm512b32_er
				0x00A70002, 0x03205009, 0x0002125E,// EVEX_Vfmsubadd213pd_xmm_k1z_xmm_xmmm128b64
				0x00A70002, 0x03209409, 0x0002229F,// EVEX_Vfmsubadd213pd_ymm_k1z_ymm_ymmm256b64
				0x00A70002, 0x0360D809, 0x000232E0,// EVEX_Vfmsubadd213pd_zmm_k1z_zmm_zmmm512b64_er
				0x00A80001, 0x00000C09, 0x000253A2,// VEX_Vfmadd213ps_xmm_xmm_xmmm128
				0x00A80001, 0x00001009, 0x000263E3,// VEX_Vfmadd213ps_ymm_ymm_ymmm256
				0x00A80001, 0x00002C09, 0x000253A2,// VEX_Vfmadd213pd_xmm_xmm_xmmm128
				0x00A80001, 0x00003009, 0x000263E3,// VEX_Vfmadd213pd_ymm_ymm_ymmm256
				0x00A80002, 0x03204009, 0x0002125E,// EVEX_Vfmadd213ps_xmm_k1z_xmm_xmmm128b32
				0x00A80002, 0x03208409, 0x0002229F,// EVEX_Vfmadd213ps_ymm_k1z_ymm_ymmm256b32
				0x00A80002, 0x0360C809, 0x000232E0,// EVEX_Vfmadd213ps_zmm_k1z_zmm_zmmm512b32_er
				0x00A80002, 0x03205009, 0x0002125E,// EVEX_Vfmadd213pd_xmm_k1z_xmm_xmmm128b64
				0x00A80002, 0x03209409, 0x0002229F,// EVEX_Vfmadd213pd_ymm_k1z_ymm_ymmm256b64
				0x00A80002, 0x0360D809, 0x000232E0,// EVEX_Vfmadd213pd_zmm_k1z_zmm_zmmm512b64_er
				0x00A90001, 0x00001409, 0x000253A2,// VEX_Vfmadd213ss_xmm_xmm_xmmm32
				0x00A90001, 0x00003409, 0x000253A2,// VEX_Vfmadd213sd_xmm_xmm_xmmm64
				0x00A90002, 0x03528009, 0x0002125E,// EVEX_Vfmadd213ss_xmm_k1z_xmm_xmmm32_er
				0x00A90002, 0x03529009, 0x0002125E,// EVEX_Vfmadd213sd_xmm_k1z_xmm_xmmm64_er
				0x00AA0001, 0x00000C09, 0x000253A2,// VEX_Vfmsub213ps_xmm_xmm_xmmm128
				0x00AA0001, 0x00001009, 0x000263E3,// VEX_Vfmsub213ps_ymm_ymm_ymmm256
				0x00AA0001, 0x00002C09, 0x000253A2,// VEX_Vfmsub213pd_xmm_xmm_xmmm128
				0x00AA0001, 0x00003009, 0x000263E3,// VEX_Vfmsub213pd_ymm_ymm_ymmm256
				0x00AA0002, 0x03204009, 0x0002125E,// EVEX_Vfmsub213ps_xmm_k1z_xmm_xmmm128b32
				0x00AA0002, 0x03208409, 0x0002229F,// EVEX_Vfmsub213ps_ymm_k1z_ymm_ymmm256b32
				0x00AA0002, 0x0360C809, 0x000232E0,// EVEX_Vfmsub213ps_zmm_k1z_zmm_zmmm512b32_er
				0x00AA0002, 0x03205009, 0x0002125E,// EVEX_Vfmsub213pd_xmm_k1z_xmm_xmmm128b64
				0x00AA0002, 0x03209409, 0x0002229F,// EVEX_Vfmsub213pd_ymm_k1z_ymm_ymmm256b64
				0x00AA0002, 0x0360D809, 0x000232E0,// EVEX_Vfmsub213pd_zmm_k1z_zmm_zmmm512b64_er
				0x00AA0002, 0x0305080B, 0x0000F360,// EVEX_V4fnmaddps_zmm_k1z_zmmp3_m128
				0x00AB0001, 0x00001409, 0x000253A2,// VEX_Vfmsub213ss_xmm_xmm_xmmm32
				0x00AB0001, 0x00003409, 0x000253A2,// VEX_Vfmsub213sd_xmm_xmm_xmmm64
				0x00AB0002, 0x03528009, 0x0002125E,// EVEX_Vfmsub213ss_xmm_k1z_xmm_xmmm32_er
				0x00AB0002, 0x03529009, 0x0002125E,// EVEX_Vfmsub213sd_xmm_k1z_xmm_xmmm64_er
				0x00AB0002, 0x0315000B, 0x0000F31E,// EVEX_V4fnmaddss_xmm_k1z_xmmp3_m128
				0x00AC0001, 0x00000C09, 0x000253A2,// VEX_Vfnmadd213ps_xmm_xmm_xmmm128
				0x00AC0001, 0x00001009, 0x000263E3,// VEX_Vfnmadd213ps_ymm_ymm_ymmm256
				0x00AC0001, 0x00002C09, 0x000253A2,// VEX_Vfnmadd213pd_xmm_xmm_xmmm128
				0x00AC0001, 0x00003009, 0x000263E3,// VEX_Vfnmadd213pd_ymm_ymm_ymmm256
				0x00AC0002, 0x03204009, 0x0002125E,// EVEX_Vfnmadd213ps_xmm_k1z_xmm_xmmm128b32
				0x00AC0002, 0x03208409, 0x0002229F,// EVEX_Vfnmadd213ps_ymm_k1z_ymm_ymmm256b32
				0x00AC0002, 0x0360C809, 0x000232E0,// EVEX_Vfnmadd213ps_zmm_k1z_zmm_zmmm512b32_er
				0x00AC0002, 0x03205009, 0x0002125E,// EVEX_Vfnmadd213pd_xmm_k1z_xmm_xmmm128b64
				0x00AC0002, 0x03209409, 0x0002229F,// EVEX_Vfnmadd213pd_ymm_k1z_ymm_ymmm256b64
				0x00AC0002, 0x0360D809, 0x000232E0,// EVEX_Vfnmadd213pd_zmm_k1z_zmm_zmmm512b64_er
				0x00AD0001, 0x00001409, 0x000253A2,// VEX_Vfnmadd213ss_xmm_xmm_xmmm32
				0x00AD0001, 0x00003409, 0x000253A2,// VEX_Vfnmadd213sd_xmm_xmm_xmmm64
				0x00AD0002, 0x03528009, 0x0002125E,// EVEX_Vfnmadd213ss_xmm_k1z_xmm_xmmm32_er
				0x00AD0002, 0x03529009, 0x0002125E,// EVEX_Vfnmadd213sd_xmm_k1z_xmm_xmmm64_er
				0x00AE0001, 0x00000C09, 0x000253A2,// VEX_Vfnmsub213ps_xmm_xmm_xmmm128
				0x00AE0001, 0x00001009, 0x000263E3,// VEX_Vfnmsub213ps_ymm_ymm_ymmm256
				0x00AE0001, 0x00002C09, 0x000253A2,// VEX_Vfnmsub213pd_xmm_xmm_xmmm128
				0x00AE0001, 0x00003009, 0x000263E3,// VEX_Vfnmsub213pd_ymm_ymm_ymmm256
				0x00AE0002, 0x03204009, 0x0002125E,// EVEX_Vfnmsub213ps_xmm_k1z_xmm_xmmm128b32
				0x00AE0002, 0x03208409, 0x0002229F,// EVEX_Vfnmsub213ps_ymm_k1z_ymm_ymmm256b32
				0x00AE0002, 0x0360C809, 0x000232E0,// EVEX_Vfnmsub213ps_zmm_k1z_zmm_zmmm512b32_er
				0x00AE0002, 0x03205009, 0x0002125E,// EVEX_Vfnmsub213pd_xmm_k1z_xmm_xmmm128b64
				0x00AE0002, 0x03209409, 0x0002229F,// EVEX_Vfnmsub213pd_ymm_k1z_ymm_ymmm256b64
				0x00AE0002, 0x0360D809, 0x000232E0,// EVEX_Vfnmsub213pd_zmm_k1z_zmm_zmmm512b64_er
				0x00AF0001, 0x00001409, 0x000253A2,// VEX_Vfnmsub213ss_xmm_xmm_xmmm32
				0x00AF0001, 0x00003409, 0x000253A2,// VEX_Vfnmsub213sd_xmm_xmm_xmmm64
				0x00AF0002, 0x03528009, 0x0002125E,// EVEX_Vfnmsub213ss_xmm_k1z_xmm_xmmm32_er
				0x00AF0002, 0x03529009, 0x0002125E,// EVEX_Vfnmsub213sd_xmm_k1z_xmm_xmmm64_er
				0x00B40002, 0x03205009, 0x0002125E,// EVEX_Vpmadd52luq_xmm_k1z_xmm_xmmm128b64
				0x00B40002, 0x03209409, 0x0002229F,// EVEX_Vpmadd52luq_ymm_k1z_ymm_ymmm256b64
				0x00B40002, 0x0320D809, 0x000232E0,// EVEX_Vpmadd52luq_zmm_k1z_zmm_zmmm512b64
				0x00B50002, 0x03205009, 0x0002125E,// EVEX_Vpmadd52huq_xmm_k1z_xmm_xmmm128b64
				0x00B50002, 0x03209409, 0x0002229F,// EVEX_Vpmadd52huq_ymm_k1z_ymm_ymmm256b64
				0x00B50002, 0x0320D809, 0x000232E0,// EVEX_Vpmadd52huq_zmm_k1z_zmm_zmmm512b64
				0x00B60001, 0x00000C09, 0x000253A2,// VEX_Vfmaddsub231ps_xmm_xmm_xmmm128
				0x00B60001, 0x00001009, 0x000263E3,// VEX_Vfmaddsub231ps_ymm_ymm_ymmm256
				0x00B60001, 0x00002C09, 0x000253A2,// VEX_Vfmaddsub231pd_xmm_xmm_xmmm128
				0x00B60001, 0x00003009, 0x000263E3,// VEX_Vfmaddsub231pd_ymm_ymm_ymmm256
				0x00B60002, 0x03204009, 0x0002125E,// EVEX_Vfmaddsub231ps_xmm_k1z_xmm_xmmm128b32
				0x00B60002, 0x03208409, 0x0002229F,// EVEX_Vfmaddsub231ps_ymm_k1z_ymm_ymmm256b32
				0x00B60002, 0x0360C809, 0x000232E0,// EVEX_Vfmaddsub231ps_zmm_k1z_zmm_zmmm512b32_er
				0x00B60002, 0x03205009, 0x0002125E,// EVEX_Vfmaddsub231pd_xmm_k1z_xmm_xmmm128b64
				0x00B60002, 0x03209409, 0x0002229F,// EVEX_Vfmaddsub231pd_ymm_k1z_ymm_ymmm256b64
				0x00B60002, 0x0360D809, 0x000232E0,// EVEX_Vfmaddsub231pd_zmm_k1z_zmm_zmmm512b64_er
				0x00B70001, 0x00000C09, 0x000253A2,// VEX_Vfmsubadd231ps_xmm_xmm_xmmm128
				0x00B70001, 0x00001009, 0x000263E3,// VEX_Vfmsubadd231ps_ymm_ymm_ymmm256
				0x00B70001, 0x00002C09, 0x000253A2,// VEX_Vfmsubadd231pd_xmm_xmm_xmmm128
				0x00B70001, 0x00003009, 0x000263E3,// VEX_Vfmsubadd231pd_ymm_ymm_ymmm256
				0x00B70002, 0x03204009, 0x0002125E,// EVEX_Vfmsubadd231ps_xmm_k1z_xmm_xmmm128b32
				0x00B70002, 0x03208409, 0x0002229F,// EVEX_Vfmsubadd231ps_ymm_k1z_ymm_ymmm256b32
				0x00B70002, 0x0360C809, 0x000232E0,// EVEX_Vfmsubadd231ps_zmm_k1z_zmm_zmmm512b32_er
				0x00B70002, 0x03205009, 0x0002125E,// EVEX_Vfmsubadd231pd_xmm_k1z_xmm_xmmm128b64
				0x00B70002, 0x03209409, 0x0002229F,// EVEX_Vfmsubadd231pd_ymm_k1z_ymm_ymmm256b64
				0x00B70002, 0x0360D809, 0x000232E0,// EVEX_Vfmsubadd231pd_zmm_k1z_zmm_zmmm512b64_er
				0x00B80001, 0x00000C09, 0x000253A2,// VEX_Vfmadd231ps_xmm_xmm_xmmm128
				0x00B80001, 0x00001009, 0x000263E3,// VEX_Vfmadd231ps_ymm_ymm_ymmm256
				0x00B80001, 0x00002C09, 0x000253A2,// VEX_Vfmadd231pd_xmm_xmm_xmmm128
				0x00B80001, 0x00003009, 0x000263E3,// VEX_Vfmadd231pd_ymm_ymm_ymmm256
				0x00B80002, 0x03204009, 0x0002125E,// EVEX_Vfmadd231ps_xmm_k1z_xmm_xmmm128b32
				0x00B80002, 0x03208409, 0x0002229F,// EVEX_Vfmadd231ps_ymm_k1z_ymm_ymmm256b32
				0x00B80002, 0x0360C809, 0x000232E0,// EVEX_Vfmadd231ps_zmm_k1z_zmm_zmmm512b32_er
				0x00B80002, 0x03205009, 0x0002125E,// EVEX_Vfmadd231pd_xmm_k1z_xmm_xmmm128b64
				0x00B80002, 0x03209409, 0x0002229F,// EVEX_Vfmadd231pd_ymm_k1z_ymm_ymmm256b64
				0x00B80002, 0x0360D809, 0x000232E0,// EVEX_Vfmadd231pd_zmm_k1z_zmm_zmmm512b64_er
				0x00B90001, 0x00001409, 0x000253A2,// VEX_Vfmadd231ss_xmm_xmm_xmmm32
				0x00B90001, 0x00003409, 0x000253A2,// VEX_Vfmadd231sd_xmm_xmm_xmmm64
				0x00B90002, 0x03528009, 0x0002125E,// EVEX_Vfmadd231ss_xmm_k1z_xmm_xmmm32_er
				0x00B90002, 0x03529009, 0x0002125E,// EVEX_Vfmadd231sd_xmm_k1z_xmm_xmmm64_er
				0x00BA0001, 0x00000C09, 0x000253A2,// VEX_Vfmsub231ps_xmm_xmm_xmmm128
				0x00BA0001, 0x00001009, 0x000263E3,// VEX_Vfmsub231ps_ymm_ymm_ymmm256
				0x00BA0001, 0x00002C09, 0x000253A2,// VEX_Vfmsub231pd_xmm_xmm_xmmm128
				0x00BA0001, 0x00003009, 0x000263E3,// VEX_Vfmsub231pd_ymm_ymm_ymmm256
				0x00BA0002, 0x03204009, 0x0002125E,// EVEX_Vfmsub231ps_xmm_k1z_xmm_xmmm128b32
				0x00BA0002, 0x03208409, 0x0002229F,// EVEX_Vfmsub231ps_ymm_k1z_ymm_ymmm256b32
				0x00BA0002, 0x0360C809, 0x000232E0,// EVEX_Vfmsub231ps_zmm_k1z_zmm_zmmm512b32_er
				0x00BA0002, 0x03205009, 0x0002125E,// EVEX_Vfmsub231pd_xmm_k1z_xmm_xmmm128b64
				0x00BA0002, 0x03209409, 0x0002229F,// EVEX_Vfmsub231pd_ymm_k1z_ymm_ymmm256b64
				0x00BA0002, 0x0360D809, 0x000232E0,// EVEX_Vfmsub231pd_zmm_k1z_zmm_zmmm512b64_er
				0x00BB0001, 0x00001409, 0x000253A2,// VEX_Vfmsub231ss_xmm_xmm_xmmm32
				0x00BB0001, 0x00003409, 0x000253A2,// VEX_Vfmsub231sd_xmm_xmm_xmmm64
				0x00BB0002, 0x03528009, 0x0002125E,// EVEX_Vfmsub231ss_xmm_k1z_xmm_xmmm32_er
				0x00BB0002, 0x03529009, 0x0002125E,// EVEX_Vfmsub231sd_xmm_k1z_xmm_xmmm64_er
				0x00BC0001, 0x00000C09, 0x000253A2,// VEX_Vfnmadd231ps_xmm_xmm_xmmm128
				0x00BC0001, 0x00001009, 0x000263E3,// VEX_Vfnmadd231ps_ymm_ymm_ymmm256
				0x00BC0001, 0x00002C09, 0x000253A2,// VEX_Vfnmadd231pd_xmm_xmm_xmmm128
				0x00BC0001, 0x00003009, 0x000263E3,// VEX_Vfnmadd231pd_ymm_ymm_ymmm256
				0x00BC0002, 0x03204009, 0x0002125E,// EVEX_Vfnmadd231ps_xmm_k1z_xmm_xmmm128b32
				0x00BC0002, 0x03208409, 0x0002229F,// EVEX_Vfnmadd231ps_ymm_k1z_ymm_ymmm256b32
				0x00BC0002, 0x0360C809, 0x000232E0,// EVEX_Vfnmadd231ps_zmm_k1z_zmm_zmmm512b32_er
				0x00BC0002, 0x03205009, 0x0002125E,// EVEX_Vfnmadd231pd_xmm_k1z_xmm_xmmm128b64
				0x00BC0002, 0x03209409, 0x0002229F,// EVEX_Vfnmadd231pd_ymm_k1z_ymm_ymmm256b64
				0x00BC0002, 0x0360D809, 0x000232E0,// EVEX_Vfnmadd231pd_zmm_k1z_zmm_zmmm512b64_er
				0x00BD0001, 0x00001409, 0x000253A2,// VEX_Vfnmadd231ss_xmm_xmm_xmmm32
				0x00BD0001, 0x00003409, 0x000253A2,// VEX_Vfnmadd231sd_xmm_xmm_xmmm64
				0x00BD0002, 0x03528009, 0x0002125E,// EVEX_Vfnmadd231ss_xmm_k1z_xmm_xmmm32_er
				0x00BD0002, 0x03529009, 0x0002125E,// EVEX_Vfnmadd231sd_xmm_k1z_xmm_xmmm64_er
				0x00BE0001, 0x00000C09, 0x000253A2,// VEX_Vfnmsub231ps_xmm_xmm_xmmm128
				0x00BE0001, 0x00001009, 0x000263E3,// VEX_Vfnmsub231ps_ymm_ymm_ymmm256
				0x00BE0001, 0x00002C09, 0x000253A2,// VEX_Vfnmsub231pd_xmm_xmm_xmmm128
				0x00BE0001, 0x00003009, 0x000263E3,// VEX_Vfnmsub231pd_ymm_ymm_ymmm256
				0x00BE0002, 0x03204009, 0x0002125E,// EVEX_Vfnmsub231ps_xmm_k1z_xmm_xmmm128b32
				0x00BE0002, 0x03208409, 0x0002229F,// EVEX_Vfnmsub231ps_ymm_k1z_ymm_ymmm256b32
				0x00BE0002, 0x0360C809, 0x000232E0,// EVEX_Vfnmsub231ps_zmm_k1z_zmm_zmmm512b32_er
				0x00BE0002, 0x03205009, 0x0002125E,// EVEX_Vfnmsub231pd_xmm_k1z_xmm_xmmm128b64
				0x00BE0002, 0x03209409, 0x0002229F,// EVEX_Vfnmsub231pd_ymm_k1z_ymm_ymmm256b64
				0x00BE0002, 0x0360D809, 0x000232E0,// EVEX_Vfnmsub231pd_zmm_k1z_zmm_zmmm512b64_er
				0x00BF0001, 0x00001409, 0x000253A2,// VEX_Vfnmsub231ss_xmm_xmm_xmmm32
				0x00BF0001, 0x00003409, 0x000253A2,// VEX_Vfnmsub231sd_xmm_xmm_xmmm64
				0x00BF0002, 0x03528009, 0x0002125E,// EVEX_Vfnmsub231ss_xmm_k1z_xmm_xmmm32_er
				0x00BF0002, 0x03529009, 0x0002125E,// EVEX_Vfnmsub231sd_xmm_k1z_xmm_xmmm64_er
				0x00C40002, 0x03204009, 0x0000085E,// EVEX_Vpconflictd_xmm_k1z_xmmm128b32
				0x00C40002, 0x03208409, 0x0000089F,// EVEX_Vpconflictd_ymm_k1z_ymmm256b32
				0x00C40002, 0x0320C809, 0x000008E0,// EVEX_Vpconflictd_zmm_k1z_zmmm512b32
				0x00C40002, 0x03205009, 0x0000085E,// EVEX_Vpconflictq_xmm_k1z_xmmm128b64
				0x00C40002, 0x03209409, 0x0000089F,// EVEX_Vpconflictq_ymm_k1z_ymmm256b64
				0x00C40002, 0x0320D809, 0x000008E0,// EVEX_Vpconflictq_zmm_k1z_zmmm512b64
				0x00C60002, 0x050288C9, 0x00000018,// EVEX_Vgatherpf0dps_vm32z_k1
				0x00C60002, 0x050298C9, 0x00000017,// EVEX_Vgatherpf0dpd_vm32y_k1
				0x00C60002, 0x05028949, 0x00000018,// EVEX_Vgatherpf1dps_vm32z_k1
				0x00C60002, 0x05029949, 0x00000017,// EVEX_Vgatherpf1dpd_vm32y_k1
				0x00C60002, 0x05028AC9, 0x00000018,// EVEX_Vscatterpf0dps_vm32z_k1
				0x00C60002, 0x05029AC9, 0x00000017,// EVEX_Vscatterpf0dpd_vm32y_k1
				0x00C60002, 0x05028B49, 0x00000018,// EVEX_Vscatterpf1dps_vm32z_k1
				0x00C60002, 0x05029B49, 0x00000017,// EVEX_Vscatterpf1dpd_vm32y_k1
				0x00C70002, 0x050288C9, 0x0000001B,// EVEX_Vgatherpf0qps_vm64z_k1
				0x00C70002, 0x050298C9, 0x0000001B,// EVEX_Vgatherpf0qpd_vm64z_k1
				0x00C70002, 0x05028949, 0x0000001B,// EVEX_Vgatherpf1qps_vm64z_k1
				0x00C70002, 0x05029949, 0x0000001B,// EVEX_Vgatherpf1qpd_vm64z_k1
				0x00C70002, 0x05028AC9, 0x0000001B,// EVEX_Vscatterpf0qps_vm64z_k1
				0x00C70002, 0x05029AC9, 0x0000001B,// EVEX_Vscatterpf0qpd_vm64z_k1
				0x00C70002, 0x05028B49, 0x0000001B,// EVEX_Vscatterpf1qps_vm64z_k1
				0x00C70002, 0x05029B49, 0x0000001B,// EVEX_Vscatterpf1qpd_vm64z_k1
				0x00C80000, 0x00008008, 0x00003263,// Sha1nexte_xmm_xmmm128
				0x00C80002, 0x03A0C809, 0x000008E0,// EVEX_Vexp2ps_zmm_k1z_zmmm512b32_sae
				0x00C80002, 0x03A0D809, 0x000008E0,// EVEX_Vexp2pd_zmm_k1z_zmmm512b64_sae
				0x00C90000, 0x00008008, 0x00003263,// Sha1msg1_xmm_xmmm128
				0x00CA0000, 0x00008008, 0x00003263,// Sha1msg2_xmm_xmmm128
				0x00CA0002, 0x03A0C809, 0x000008E0,// EVEX_Vrcp28ps_zmm_k1z_zmmm512b32_sae
				0x00CA0002, 0x03A0D809, 0x000008E0,// EVEX_Vrcp28pd_zmm_k1z_zmmm512b64_sae
				0x00CB0000, 0x00008008, 0x00003263,// Sha256rnds2_xmm_xmmm128
				0x00CB0002, 0x03928009, 0x0002125E,// EVEX_Vrcp28ss_xmm_k1z_xmm_xmmm32_sae
				0x00CB0002, 0x03929009, 0x0002125E,// EVEX_Vrcp28sd_xmm_k1z_xmm_xmmm64_sae
				0x00CC0000, 0x00008008, 0x00003263,// Sha256msg1_xmm_xmmm128
				0x00CC0002, 0x03A0C809, 0x000008E0,// EVEX_Vrsqrt28ps_zmm_k1z_zmmm512b32_sae
				0x00CC0002, 0x03A0D809, 0x000008E0,// EVEX_Vrsqrt28pd_zmm_k1z_zmmm512b64_sae
				0x00CD0000, 0x00008008, 0x00003263,// Sha256msg2_xmm_xmmm128
				0x00CD0002, 0x03928009, 0x0002125E,// EVEX_Vrsqrt28ss_xmm_k1z_xmm_xmmm32_sae
				0x00CD0002, 0x03929009, 0x0002125E,// EVEX_Vrsqrt28sd_xmm_k1z_xmm_xmmm64_sae
				0x00CF0000, 0x00008009, 0x00003263,// Gf2p8mulb_xmm_xmmm128
				0x00CF0001, 0x00000C09, 0x000253A2,// VEX_Vgf2p8mulb_xmm_xmm_xmmm128
				0x00CF0001, 0x00001009, 0x000263E3,// VEX_Vgf2p8mulb_ymm_ymm_ymmm256
				0x00CF0002, 0x0301C009, 0x0002125E,// EVEX_Vgf2p8mulb_xmm_k1z_xmm_xmmm128
				0x00CF0002, 0x03020409, 0x0002229F,// EVEX_Vgf2p8mulb_ymm_k1z_ymm_ymmm256
				0x00CF0002, 0x03024809, 0x000232E0,// EVEX_Vgf2p8mulb_zmm_k1z_zmm_zmmm512
				0x00DB0000, 0x00008009, 0x00003263,// Aesimc_xmm_xmmm128
				0x00DB0001, 0x00004C09, 0x00000962,// VEX_Vaesimc_xmm_xmmm128
				0x00DC0000, 0x00008009, 0x00003263,// Aesenc_xmm_xmmm128
				0x00DC0001, 0x00004C09, 0x000253A2,// VEX_Vaesenc_xmm_xmm_xmmm128
				0x00DC0001, 0x00005009, 0x000263E3,// VEX_Vaesenc_ymm_ymm_ymmm256
				0x00DC0002, 0x0001E009, 0x0002125E,// EVEX_Vaesenc_xmm_xmm_xmmm128
				0x00DC0002, 0x00022409, 0x0002229F,// EVEX_Vaesenc_ymm_ymm_ymmm256
				0x00DC0002, 0x00026809, 0x000232E0,// EVEX_Vaesenc_zmm_zmm_zmmm512
				0x00DD0000, 0x00008009, 0x00003263,// Aesenclast_xmm_xmmm128
				0x00DD0001, 0x00004C09, 0x000253A2,// VEX_Vaesenclast_xmm_xmm_xmmm128
				0x00DD0001, 0x00005009, 0x000263E3,// VEX_Vaesenclast_ymm_ymm_ymmm256
				0x00DD0002, 0x0001E009, 0x0002125E,// EVEX_Vaesenclast_xmm_xmm_xmmm128
				0x00DD0002, 0x00022409, 0x0002229F,// EVEX_Vaesenclast_ymm_ymm_ymmm256
				0x00DD0002, 0x00026809, 0x000232E0,// EVEX_Vaesenclast_zmm_zmm_zmmm512
				0x00DE0000, 0x00008009, 0x00003263,// Aesdec_xmm_xmmm128
				0x00DE0001, 0x00004C09, 0x000253A2,// VEX_Vaesdec_xmm_xmm_xmmm128
				0x00DE0001, 0x00005009, 0x000263E3,// VEX_Vaesdec_ymm_ymm_ymmm256
				0x00DE0002, 0x0001E009, 0x0002125E,// EVEX_Vaesdec_xmm_xmm_xmmm128
				0x00DE0002, 0x00022409, 0x0002229F,// EVEX_Vaesdec_ymm_ymm_ymmm256
				0x00DE0002, 0x00026809, 0x000232E0,// EVEX_Vaesdec_zmm_zmm_zmmm512
				0x00DF0000, 0x00008009, 0x00003263,// Aesdeclast_xmm_xmmm128
				0x00DF0001, 0x00004C09, 0x000253A2,// VEX_Vaesdeclast_xmm_xmm_xmmm128
				0x00DF0001, 0x00005009, 0x000263E3,// VEX_Vaesdeclast_ymm_ymm_ymmm256
				0x00DF0002, 0x0001E009, 0x0002125E,// EVEX_Vaesdeclast_xmm_xmm_xmmm128
				0x00DF0002, 0x00022409, 0x0002229F,// EVEX_Vaesdeclast_ymm_ymm_ymmm256
				0x00DF0002, 0x00026809, 0x000232E0,// EVEX_Vaesdeclast_zmm_zmm_zmmm512
				0x00F00000, 0x00010008, 0x000009AA,// Movbe_r16_m16
				0x00F00000, 0x00020008, 0x00000A2B,// Movbe_r32_m32
				0x00F00000, 0x00030028, 0x00000B2C,// Movbe_r64_m64
				0x00F00000, 0x0000800B, 0x00000D2B,// Crc32_r32_rm8
				0x00F00000, 0x0003802B, 0x00000D2C,// Crc32_r64_rm8
				0x00F10000, 0x00010008, 0x00001513,// Movbe_m16_r16
				0x00F10000, 0x00020008, 0x00001594,// Movbe_m32_r32
				0x00F10000, 0x00030028, 0x00001616,// Movbe_m64_r64
				0x00F10000, 0x0001800B, 0x00000DAB,// Crc32_r32_rm16
				0x00F10000, 0x0002800B, 0x00000E2B,// Crc32_r32_rm32
				0x00F10000, 0x0003802B, 0x0000102C,// Crc32_r64_rm64
				0x00F20001, 0x00006008, 0x000012C3,// VEX_Andn_r32_r32_rm32
				0x00F20001, 0x00002028, 0x00002304,// VEX_Andn_r64_r64_rm64
				0x00F30001, 0x000060C8, 0x0000004B,// VEX_Blsr_r32_rm32
				0x00F30001, 0x000020E8, 0x0000008C,// VEX_Blsr_r64_rm64
				0x00F30001, 0x00006148, 0x0000004B,// VEX_Blsmsk_r32_rm32
				0x00F30001, 0x00002168, 0x0000008C,// VEX_Blsmsk_r64_rm64
				0x00F30001, 0x000061C8, 0x0000004B,// VEX_Blsi_r32_rm32
				0x00F30001, 0x000021E8, 0x0000008C,// VEX_Blsi_r64_rm64
				0x00F50001, 0x00006008, 0x0000B043,// VEX_Bzhi_r32_rm32_r32
				0x00F50001, 0x00002028, 0x0000C084,// VEX_Bzhi_r64_rm64_r64
				0x00F50000, 0x00008009, 0x00001594,// Wrussd_m32_r32
				0x00F50000, 0x00038029, 0x00001616,// Wrussq_m64_r64
				0x00F50001, 0x0000600A, 0x000012C3,// VEX_Pext_r32_r32_rm32
				0x00F50001, 0x0000202A, 0x00002304,// VEX_Pext_r64_r64_rm64
				0x00F50001, 0x0000600B, 0x000012C3,// VEX_Pdep_r32_r32_rm32
				0x00F50001, 0x0000202B, 0x00002304,// VEX_Pdep_r64_r64_rm64
				0x00F60000, 0x00008008, 0x00001594,// Wrssd_m32_r32
				0x00F60000, 0x00038028, 0x00001616,// Wrssq_m64_r64
				0x00F60000, 0x00008009, 0x00000E2B,// Adcx_r32_rm32
				0x00F60000, 0x00038029, 0x0000102C,// Adcx_r64_rm64
				0x00F60000, 0x0000800A, 0x00000E2B,// Adox_r32_rm32
				0x00F60000, 0x0003802A, 0x0000102C,// Adox_r64_rm64
				0x00F60001, 0x0000600B, 0x000012C3,// VEX_Mulx_r32_r32_rm32
				0x00F60001, 0x0000202B, 0x00002304,// VEX_Mulx_r64_r64_rm64
				0x00F70001, 0x00006008, 0x0000B043,// VEX_Bextr_r32_rm32_r32
				0x00F70001, 0x00002028, 0x0000C084,// VEX_Bextr_r64_rm64_r64
				0x00F70001, 0x00006009, 0x0000B043,// VEX_Shlx_r32_rm32_r32
				0x00F70001, 0x00002029, 0x0000C084,// VEX_Shlx_r64_rm64_r64
				0x00F70001, 0x0000600A, 0x0000B043,// VEX_Sarx_r32_rm32_r32
				0x00F70001, 0x0000202A, 0x0000C084,// VEX_Sarx_r64_rm64_r64
				0x00F70001, 0x0000600B, 0x0000B043,// VEX_Shrx_r32_rm32_r32
				0x00F70001, 0x0000202B, 0x0000C084,// VEX_Shrx_r64_rm64_r64
				0x00F80000, 0x00048019, 0x000001AD,// Movdir64b_r16_m512
				0x00F80000, 0x00088009, 0x000001AE,// Movdir64b_r32_m512
				0x00F80000, 0x00008029, 0x000001AF,// Movdir64b_r64_m512
				0x00F80000, 0x0004801A, 0x000001AD,// Enqcmds_r16_m512
				0x00F80000, 0x0008800A, 0x000001AE,// Enqcmds_r32_m512
				0x00F80000, 0x0000802A, 0x000001AF,// Enqcmds_r64_m512
				0x00F80000, 0x0004801B, 0x000001AD,// Enqcmd_r16_m512
				0x00F80000, 0x0008800B, 0x000001AE,// Enqcmd_r32_m512
				0x00F80000, 0x0000802B, 0x000001AF,// Enqcmd_r64_m512
				0x00F90000, 0x00008008, 0x00001594,// Movdiri_m32_r32
				0x00F90000, 0x00038028, 0x00001616,// Movdiri_m64_r64
				0x00000001, 0x0000300D, 0x000109A3,// VEX_Vpermq_ymm_ymmm256_imm8
				0x00000002, 0x0320940D, 0x0000E89F,// EVEX_Vpermq_ymm_k1z_ymmm256b64_imm8
				0x00000002, 0x0320D80D, 0x0000E8E0,// EVEX_Vpermq_zmm_k1z_zmmm512b64_imm8
				0x00010001, 0x0000300D, 0x000109A3,// VEX_Vpermpd_ymm_ymmm256_imm8
				0x00010002, 0x0320940D, 0x0000E89F,// EVEX_Vpermpd_ymm_k1z_ymmm256b64_imm8
				0x00010002, 0x0320D80D, 0x0000E8E0,// EVEX_Vpermpd_zmm_k1z_zmmm512b64_imm8
				0x00020001, 0x00000C0D, 0x004253A2,// VEX_Vpblendd_xmm_xmm_xmmm128_imm8
				0x00020001, 0x0000100D, 0x004263E3,// VEX_Vpblendd_ymm_ymm_ymmm256_imm8
				0x00030002, 0x0320400D, 0x003A125E,// EVEX_Valignd_xmm_k1z_xmm_xmmm128b32_imm8
				0x00030002, 0x0320840D, 0x003A229F,// EVEX_Valignd_ymm_k1z_ymm_ymmm256b32_imm8
				0x00030002, 0x0320C80D, 0x003A32E0,// EVEX_Valignd_zmm_k1z_zmm_zmmm512b32_imm8
				0x00030002, 0x0320500D, 0x003A125E,// EVEX_Valignq_xmm_k1z_xmm_xmmm128b64_imm8
				0x00030002, 0x0320940D, 0x003A229F,// EVEX_Valignq_ymm_k1z_ymm_ymmm256b64_imm8
				0x00030002, 0x0320D80D, 0x003A32E0,// EVEX_Valignq_zmm_k1z_zmm_zmmm512b64_imm8
				0x00040001, 0x00000C0D, 0x00010962,// VEX_Vpermilps_xmm_xmmm128_imm8
				0x00040001, 0x0000100D, 0x000109A3,// VEX_Vpermilps_ymm_ymmm256_imm8
				0x00040002, 0x0320400D, 0x0000E85E,// EVEX_Vpermilps_xmm_k1z_xmmm128b32_imm8
				0x00040002, 0x0320840D, 0x0000E89F,// EVEX_Vpermilps_ymm_k1z_ymmm256b32_imm8
				0x00040002, 0x0320C80D, 0x0000E8E0,// EVEX_Vpermilps_zmm_k1z_zmmm512b32_imm8
				0x00050001, 0x00000C0D, 0x00010962,// VEX_Vpermilpd_xmm_xmmm128_imm8
				0x00050001, 0x0000100D, 0x000109A3,// VEX_Vpermilpd_ymm_ymmm256_imm8
				0x00050002, 0x0320500D, 0x0000E85E,// EVEX_Vpermilpd_xmm_k1z_xmmm128b64_imm8
				0x00050002, 0x0320940D, 0x0000E89F,// EVEX_Vpermilpd_ymm_k1z_ymmm256b64_imm8
				0x00050002, 0x0320D80D, 0x0000E8E0,// EVEX_Vpermilpd_zmm_k1z_zmmm512b64_imm8
				0x00060001, 0x0000100D, 0x004263E3,// VEX_Vperm2f128_ymm_ymm_ymmm256_imm8
				0x00080000, 0x0000800D, 0x000E7263,// Roundps_xmm_xmmm128_imm8
				0x00080001, 0x00004C0D, 0x00010962,// VEX_Vroundps_xmm_xmmm128_imm8
				0x00080001, 0x0000500D, 0x000109A3,// VEX_Vroundps_ymm_ymmm256_imm8
				0x00080002, 0x0320400D, 0x0000E85E,// EVEX_Vrndscaleps_xmm_k1z_xmmm128b32_imm8
				0x00080002, 0x0320840D, 0x0000E89F,// EVEX_Vrndscaleps_ymm_k1z_ymmm256b32_imm8
				0x00080002, 0x03A0C80D, 0x0000E8E0,// EVEX_Vrndscaleps_zmm_k1z_zmmm512b32_imm8_sae
				0x00090000, 0x0000800D, 0x000E7263,// Roundpd_xmm_xmmm128_imm8
				0x00090001, 0x00004C0D, 0x00010962,// VEX_Vroundpd_xmm_xmmm128_imm8
				0x00090001, 0x0000500D, 0x000109A3,// VEX_Vroundpd_ymm_ymmm256_imm8
				0x00090002, 0x0320500D, 0x0000E85E,// EVEX_Vrndscalepd_xmm_k1z_xmmm128b64_imm8
				0x00090002, 0x0320940D, 0x0000E89F,// EVEX_Vrndscalepd_ymm_k1z_ymmm256b64_imm8
				0x00090002, 0x03A0D80D, 0x0000E8E0,// EVEX_Vrndscalepd_zmm_k1z_zmmm512b64_imm8_sae
				0x000A0000, 0x0000800D, 0x000E7263,// Roundss_xmm_xmmm32_imm8
				0x000A0001, 0x0000540D, 0x004253A2,// VEX_Vroundss_xmm_xmm_xmmm32_imm8
				0x000A0002, 0x0392800D, 0x003A125E,// EVEX_Vrndscaless_xmm_k1z_xmm_xmmm32_imm8_sae
				0x000B0000, 0x0000800D, 0x000E7263,// Roundsd_xmm_xmmm64_imm8
				0x000B0001, 0x0000540D, 0x004253A2,// VEX_Vroundsd_xmm_xmm_xmmm64_imm8
				0x000B0002, 0x0392900D, 0x003A125E,// EVEX_Vrndscalesd_xmm_k1z_xmm_xmmm64_imm8_sae
				0x000C0000, 0x0000800D, 0x000E7263,// Blendps_xmm_xmmm128_imm8
				0x000C0001, 0x00004C0D, 0x004253A2,// VEX_Vblendps_xmm_xmm_xmmm128_imm8
				0x000C0001, 0x0000500D, 0x004263E3,// VEX_Vblendps_ymm_ymm_ymmm256_imm8
				0x000D0000, 0x0000800D, 0x000E7263,// Blendpd_xmm_xmmm128_imm8
				0x000D0001, 0x00004C0D, 0x004253A2,// VEX_Vblendpd_xmm_xmm_xmmm128_imm8
				0x000D0001, 0x0000500D, 0x004263E3,// VEX_Vblendpd_ymm_ymm_ymmm256_imm8
				0x000E0000, 0x0000800D, 0x000E7263,// Pblendw_xmm_xmmm128_imm8
				0x000E0001, 0x00004C0D, 0x004253A2,// VEX_Vpblendw_xmm_xmm_xmmm128_imm8
				0x000E0001, 0x0000500D, 0x004263E3,// VEX_Vpblendw_ymm_ymm_ymmm256_imm8
				0x000F0000, 0x0000800C, 0x000E70E0,// Palignr_mm_mmm64_imm8
				0x000F0000, 0x0000800D, 0x000E7263,// Palignr_xmm_xmmm128_imm8
				0x000F0001, 0x00004C0D, 0x004253A2,// VEX_Vpalignr_xmm_xmm_xmmm128_imm8
				0x000F0001, 0x0000500D, 0x004263E3,// VEX_Vpalignr_ymm_ymm_ymmm256_imm8
				0x000F0002, 0x0301E00D, 0x003A125E,// EVEX_Vpalignr_xmm_k1z_xmm_xmmm128_imm8
				0x000F0002, 0x0302240D, 0x003A229F,// EVEX_Vpalignr_ymm_k1z_ymm_ymmm256_imm8
				0x000F0002, 0x0302680D, 0x003A32E0,// EVEX_Vpalignr_zmm_k1z_zmm_zmmm512_imm8
				0x00140000, 0x0000800D, 0x000E71A5,// Pextrb_r32m8_xmm_imm8
				0x00140000, 0x0003802D, 0x000E71A6,// Pextrb_r64m8_xmm_imm8
				0x00140001, 0x00006C0D, 0x00010885,// VEX_Vpextrb_r32m8_xmm_imm8
				0x00140001, 0x00002C2D, 0x00010886,// VEX_Vpextrb_r64m8_xmm_imm8
				0x00140002, 0x0002F00D, 0x0000E785,// EVEX_Vpextrb_r32m8_xmm_imm8
				0x00140002, 0x0002D02D, 0x0000E786,// EVEX_Vpextrb_r64m8_xmm_imm8
				0x00150000, 0x0000800D, 0x000E71A7,// Pextrw_r32m16_xmm_imm8
				0x00150000, 0x0003802D, 0x000E71A8,// Pextrw_r64m16_xmm_imm8
				0x00150001, 0x00006C0D, 0x00010887,// VEX_Vpextrw_r32m16_xmm_imm8
				0x00150001, 0x00002C2D, 0x00010888,// VEX_Vpextrw_r64m16_xmm_imm8
				0x00150002, 0x0003300D, 0x0000E787,// EVEX_Vpextrw_r32m16_xmm_imm8
				0x00150002, 0x0003102D, 0x0000E788,// EVEX_Vpextrw_r64m16_xmm_imm8
				0x00160000, 0x0000800D, 0x000E719C,// Pextrd_rm32_xmm_imm8
				0x00160000, 0x0003802D, 0x000E71A0,// Pextrq_rm64_xmm_imm8
				0x00160001, 0x00006C0D, 0x00010881,// VEX_Vpextrd_rm32_xmm_imm8
				0x00160001, 0x00002C2D, 0x00010882,// VEX_Vpextrq_rm64_xmm_imm8
				0x00160002, 0x0003700D, 0x0000E781,// EVEX_Vpextrd_rm32_xmm_imm8
				0x00160002, 0x0003902D, 0x0000E782,// EVEX_Vpextrq_rm64_xmm_imm8
				0x00170000, 0x0000800D, 0x000E719C,// Extractps_rm32_xmm_imm8
				0x00170000, 0x0003802D, 0x000E71A0,// Extractps_r64m32_xmm_imm8
				0x00170001, 0x00006C0D, 0x00010881,// VEX_Vextractps_rm32_xmm_imm8
				0x00170001, 0x00002C2D, 0x00010882,// VEX_Vextractps_r64m32_xmm_imm8
				0x00170002, 0x0003700D, 0x0000E781,// EVEX_Vextractps_rm32_xmm_imm8
				0x00170002, 0x0003502D, 0x0000E782,// EVEX_Vextractps_r64m32_xmm_imm8
				0x00180001, 0x0000100D, 0x004253E3,// VEX_Vinsertf128_ymm_ymm_xmmm128_imm8
				0x00180002, 0x0304840D, 0x003A129F,// EVEX_Vinsertf32x4_ymm_k1z_ymm_xmmm128_imm8
				0x00180002, 0x0304880D, 0x003A12E0,// EVEX_Vinsertf32x4_zmm_k1z_zmm_xmmm128_imm8
				0x00180002, 0x0304540D, 0x003A129F,// EVEX_Vinsertf64x2_ymm_k1z_ymm_xmmm128_imm8
				0x00180002, 0x0304580D, 0x003A12E0,// EVEX_Vinsertf64x2_zmm_k1z_zmm_xmmm128_imm8
				0x00190001, 0x0000100D, 0x000108E5,// VEX_Vextractf128_xmmm128_ymm_imm8
				0x00190002, 0x0304840D, 0x0000E7E1,// EVEX_Vextractf32x4_xmmm128_k1z_ymm_imm8
				0x00190002, 0x0304880D, 0x0000E821,// EVEX_Vextractf32x4_xmmm128_k1z_zmm_imm8
				0x00190002, 0x0304540D, 0x0000E7E1,// EVEX_Vextractf64x2_xmmm128_k1z_ymm_imm8
				0x00190002, 0x0304580D, 0x0000E821,// EVEX_Vextractf64x2_xmmm128_k1z_zmm_imm8
				0x001A0002, 0x0304C80D, 0x003A22E0,// EVEX_Vinsertf32x8_zmm_k1z_zmm_ymmm256_imm8
				0x001A0002, 0x0304980D, 0x003A22E0,// EVEX_Vinsertf64x4_zmm_k1z_zmm_ymmm256_imm8
				0x001B0002, 0x0304C80D, 0x0000E822,// EVEX_Vextractf32x8_ymmm256_k1z_zmm_imm8
				0x001B0002, 0x0304980D, 0x0000E822,// EVEX_Vextractf64x4_ymmm256_k1z_zmm_imm8
				0x001D0001, 0x00000C0D, 0x000108A5,// VEX_Vcvtps2ph_xmmm64_xmm_imm8
				0x001D0001, 0x0000100D, 0x000108E5,// VEX_Vcvtps2ph_xmmm128_ymm_imm8
				0x001D0002, 0x0305400D, 0x0000E7A1,// EVEX_Vcvtps2ph_xmmm64_k1z_xmm_imm8
				0x001D0002, 0x0305840D, 0x0000E7E1,// EVEX_Vcvtps2ph_xmmm128_k1z_ymm_imm8
				0x001D0002, 0x0385C80D, 0x0000E822,// EVEX_Vcvtps2ph_ymmm256_k1z_zmm_imm8_sae
				0x001E0002, 0x0120400D, 0x003A125C,// EVEX_Vpcmpud_k_k1_xmm_xmmm128b32_imm8
				0x001E0002, 0x0120840D, 0x003A229C,// EVEX_Vpcmpud_k_k1_ymm_ymmm256b32_imm8
				0x001E0002, 0x0120C80D, 0x003A32DC,// EVEX_Vpcmpud_k_k1_zmm_zmmm512b32_imm8
				0x001E0002, 0x0120500D, 0x003A125C,// EVEX_Vpcmpuq_k_k1_xmm_xmmm128b64_imm8
				0x001E0002, 0x0120940D, 0x003A229C,// EVEX_Vpcmpuq_k_k1_ymm_ymmm256b64_imm8
				0x001E0002, 0x0120D80D, 0x003A32DC,// EVEX_Vpcmpuq_k_k1_zmm_zmmm512b64_imm8
				0x001F0002, 0x0120400D, 0x003A125C,// EVEX_Vpcmpd_k_k1_xmm_xmmm128b32_imm8
				0x001F0002, 0x0120840D, 0x003A229C,// EVEX_Vpcmpd_k_k1_ymm_ymmm256b32_imm8
				0x001F0002, 0x0120C80D, 0x003A32DC,// EVEX_Vpcmpd_k_k1_zmm_zmmm512b32_imm8
				0x001F0002, 0x0120500D, 0x003A125C,// EVEX_Vpcmpq_k_k1_xmm_xmmm128b64_imm8
				0x001F0002, 0x0120940D, 0x003A229C,// EVEX_Vpcmpq_k_k1_ymm_ymmm256b64_imm8
				0x001F0002, 0x0120D80D, 0x003A32DC,// EVEX_Vpcmpq_k_k1_zmm_zmmm512b64_imm8
				0x00200000, 0x0000800D, 0x000E52E3,// Pinsrb_xmm_r32m8_imm8
				0x00200000, 0x0003802D, 0x000E5363,// Pinsrb_xmm_r64m8_imm8
				0x00200001, 0x00006C0D, 0x004053A2,// VEX_Vpinsrb_xmm_xmm_r32m8_imm8
				0x00200001, 0x00002C2D, 0x004063A2,// VEX_Vpinsrb_xmm_xmm_r64m8_imm8
				0x00200002, 0x0002F00D, 0x0038525E,// EVEX_Vpinsrb_xmm_xmm_r32m8_imm8
				0x00200002, 0x0002D02D, 0x0038625E,// EVEX_Vpinsrb_xmm_xmm_r64m8_imm8
				0x00210000, 0x0000800D, 0x000E7263,// Insertps_xmm_xmmm32_imm8
				0x00210001, 0x00004C0D, 0x004253A2,// VEX_Vinsertps_xmm_xmm_xmmm32_imm8
				0x00210002, 0x0002800D, 0x003A125E,// EVEX_Vinsertps_xmm_xmm_xmmm32_imm8
				0x00220000, 0x0000800D, 0x000E4E63,// Pinsrd_xmm_rm32_imm8
				0x00220000, 0x0003802D, 0x000E5063,// Pinsrq_xmm_rm64_imm8
				0x00220001, 0x00006C0D, 0x004013A2,// VEX_Vpinsrd_xmm_xmm_rm32_imm8
				0x00220001, 0x00002C2D, 0x004023A2,// VEX_Vpinsrq_xmm_xmm_rm64_imm8
				0x00220002, 0x0003700D, 0x0038125E,// EVEX_Vpinsrd_xmm_xmm_rm32_imm8
				0x00220002, 0x0003902D, 0x0038225E,// EVEX_Vpinsrq_xmm_xmm_rm64_imm8
				0x00230002, 0x0320840D, 0x003A229F,// EVEX_Vshuff32x4_ymm_k1z_ymm_ymmm256b32_imm8
				0x00230002, 0x0320C80D, 0x003A32E0,// EVEX_Vshuff32x4_zmm_k1z_zmm_zmmm512b32_imm8
				0x00230002, 0x0320940D, 0x003A229F,// EVEX_Vshuff64x2_ymm_k1z_ymm_ymmm256b64_imm8
				0x00230002, 0x0320D80D, 0x003A32E0,// EVEX_Vshuff64x2_zmm_k1z_zmm_zmmm512b64_imm8
				0x00250002, 0x0320400D, 0x003A125E,// EVEX_Vpternlogd_xmm_k1z_xmm_xmmm128b32_imm8
				0x00250002, 0x0320840D, 0x003A229F,// EVEX_Vpternlogd_ymm_k1z_ymm_ymmm256b32_imm8
				0x00250002, 0x0320C80D, 0x003A32E0,// EVEX_Vpternlogd_zmm_k1z_zmm_zmmm512b32_imm8
				0x00250002, 0x0320500D, 0x003A125E,// EVEX_Vpternlogq_xmm_k1z_xmm_xmmm128b64_imm8
				0x00250002, 0x0320940D, 0x003A229F,// EVEX_Vpternlogq_ymm_k1z_ymm_ymmm256b64_imm8
				0x00250002, 0x0320D80D, 0x003A32E0,// EVEX_Vpternlogq_zmm_k1z_zmm_zmmm512b64_imm8
				0x00260002, 0x0320400D, 0x0000E85E,// EVEX_Vgetmantps_xmm_k1z_xmmm128b32_imm8
				0x00260002, 0x0320840D, 0x0000E89F,// EVEX_Vgetmantps_ymm_k1z_ymmm256b32_imm8
				0x00260002, 0x03A0C80D, 0x0000E8E0,// EVEX_Vgetmantps_zmm_k1z_zmmm512b32_imm8_sae
				0x00260002, 0x0320500D, 0x0000E85E,// EVEX_Vgetmantpd_xmm_k1z_xmmm128b64_imm8
				0x00260002, 0x0320940D, 0x0000E89F,// EVEX_Vgetmantpd_ymm_k1z_ymmm256b64_imm8
				0x00260002, 0x03A0D80D, 0x0000E8E0,// EVEX_Vgetmantpd_zmm_k1z_zmmm512b64_imm8_sae
				0x00270002, 0x0392800D, 0x003A125E,// EVEX_Vgetmantss_xmm_k1z_xmm_xmmm32_imm8_sae
				0x00270002, 0x0392900D, 0x003A125E,// EVEX_Vgetmantsd_xmm_k1z_xmm_xmmm64_imm8_sae
				0x00300001, 0x0000040D, 0x0001069D,// VEX_Kshiftrb_k_k_imm8
				0x00300001, 0x0000240D, 0x0001069D,// VEX_Kshiftrw_k_k_imm8
				0x00310001, 0x0000040D, 0x0001069D,// VEX_Kshiftrd_k_k_imm8
				0x00310001, 0x0000240D, 0x0001069D,// VEX_Kshiftrq_k_k_imm8
				0x00320001, 0x0000040D, 0x0001069D,// VEX_Kshiftlb_k_k_imm8
				0x00320001, 0x0000240D, 0x0001069D,// VEX_Kshiftlw_k_k_imm8
				0x00330001, 0x0000040D, 0x0001069D,// VEX_Kshiftld_k_k_imm8
				0x00330001, 0x0000240D, 0x0001069D,// VEX_Kshiftlq_k_k_imm8
				0x00380001, 0x0000100D, 0x004253E3,// VEX_Vinserti128_ymm_ymm_xmmm128_imm8
				0x00380002, 0x0304840D, 0x003A129F,// EVEX_Vinserti32x4_ymm_k1z_ymm_xmmm128_imm8
				0x00380002, 0x0304880D, 0x003A12E0,// EVEX_Vinserti32x4_zmm_k1z_zmm_xmmm128_imm8
				0x00380002, 0x0304540D, 0x003A129F,// EVEX_Vinserti64x2_ymm_k1z_ymm_xmmm128_imm8
				0x00380002, 0x0304580D, 0x003A12E0,// EVEX_Vinserti64x2_zmm_k1z_zmm_xmmm128_imm8
				0x00390001, 0x0000100D, 0x000108E5,// VEX_Vextracti128_xmmm128_ymm_imm8
				0x00390002, 0x0304840D, 0x0000E7E1,// EVEX_Vextracti32x4_xmmm128_k1z_ymm_imm8
				0x00390002, 0x0304880D, 0x0000E821,// EVEX_Vextracti32x4_xmmm128_k1z_zmm_imm8
				0x00390002, 0x0304540D, 0x0000E7E1,// EVEX_Vextracti64x2_xmmm128_k1z_ymm_imm8
				0x00390002, 0x0304580D, 0x0000E821,// EVEX_Vextracti64x2_xmmm128_k1z_zmm_imm8
				0x003A0002, 0x0304C80D, 0x003A22E0,// EVEX_Vinserti32x8_zmm_k1z_zmm_ymmm256_imm8
				0x003A0002, 0x0304980D, 0x003A22E0,// EVEX_Vinserti64x4_zmm_k1z_zmm_ymmm256_imm8
				0x003B0002, 0x0304C80D, 0x0000E822,// EVEX_Vextracti32x8_ymmm256_k1z_zmm_imm8
				0x003B0002, 0x0304980D, 0x0000E822,// EVEX_Vextracti64x4_ymmm256_k1z_zmm_imm8
				0x003E0002, 0x0101C00D, 0x003A125C,// EVEX_Vpcmpub_k_k1_xmm_xmmm128_imm8
				0x003E0002, 0x0102040D, 0x003A229C,// EVEX_Vpcmpub_k_k1_ymm_ymmm256_imm8
				0x003E0002, 0x0102480D, 0x003A32DC,// EVEX_Vpcmpub_k_k1_zmm_zmmm512_imm8
				0x003E0002, 0x0101D00D, 0x003A125C,// EVEX_Vpcmpuw_k_k1_xmm_xmmm128_imm8
				0x003E0002, 0x0102140D, 0x003A229C,// EVEX_Vpcmpuw_k_k1_ymm_ymmm256_imm8
				0x003E0002, 0x0102580D, 0x003A32DC,// EVEX_Vpcmpuw_k_k1_zmm_zmmm512_imm8
				0x003F0002, 0x0101C00D, 0x003A125C,// EVEX_Vpcmpb_k_k1_xmm_xmmm128_imm8
				0x003F0002, 0x0102040D, 0x003A229C,// EVEX_Vpcmpb_k_k1_ymm_ymmm256_imm8
				0x003F0002, 0x0102480D, 0x003A32DC,// EVEX_Vpcmpb_k_k1_zmm_zmmm512_imm8
				0x003F0002, 0x0101D00D, 0x003A125C,// EVEX_Vpcmpw_k_k1_xmm_xmmm128_imm8
				0x003F0002, 0x0102140D, 0x003A229C,// EVEX_Vpcmpw_k_k1_ymm_ymmm256_imm8
				0x003F0002, 0x0102580D, 0x003A32DC,// EVEX_Vpcmpw_k_k1_zmm_zmmm512_imm8
				0x00400000, 0x0000800D, 0x000E7263,// Dpps_xmm_xmmm128_imm8
				0x00400001, 0x00004C0D, 0x004253A2,// VEX_Vdpps_xmm_xmm_xmmm128_imm8
				0x00400001, 0x0000500D, 0x004263E3,// VEX_Vdpps_ymm_ymm_ymmm256_imm8
				0x00410000, 0x0000800D, 0x000E7263,// Dppd_xmm_xmmm128_imm8
				0x00410001, 0x00004C0D, 0x004253A2,// VEX_Vdppd_xmm_xmm_xmmm128_imm8
				0x00420000, 0x0000800D, 0x000E7263,// Mpsadbw_xmm_xmmm128_imm8
				0x00420001, 0x00004C0D, 0x004253A2,// VEX_Vmpsadbw_xmm_xmm_xmmm128_imm8
				0x00420001, 0x0000500D, 0x004263E3,// VEX_Vmpsadbw_ymm_ymm_ymmm256_imm8
				0x00420002, 0x0301C00D, 0x003A125E,// EVEX_Vdbpsadbw_xmm_k1z_xmm_xmmm128_imm8
				0x00420002, 0x0302040D, 0x003A229F,// EVEX_Vdbpsadbw_ymm_k1z_ymm_ymmm256_imm8
				0x00420002, 0x0302480D, 0x003A32E0,// EVEX_Vdbpsadbw_zmm_k1z_zmm_zmmm512_imm8
				0x00430002, 0x0320840D, 0x003A229F,// EVEX_Vshufi32x4_ymm_k1z_ymm_ymmm256b32_imm8
				0x00430002, 0x0320C80D, 0x003A32E0,// EVEX_Vshufi32x4_zmm_k1z_zmm_zmmm512b32_imm8
				0x00430002, 0x0320940D, 0x003A229F,// EVEX_Vshufi64x2_ymm_k1z_ymm_ymmm256b64_imm8
				0x00430002, 0x0320D80D, 0x003A32E0,// EVEX_Vshufi64x2_zmm_k1z_zmm_zmmm512b64_imm8
				0x00440000, 0x0000800D, 0x000E7263,// Pclmulqdq_xmm_xmmm128_imm8
				0x00440001, 0x00004C0D, 0x004253A2,// VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8
				0x00440001, 0x0000500D, 0x004263E3,// VEX_Vpclmulqdq_ymm_ymm_ymmm256_imm8
				0x00440002, 0x0001E00D, 0x003A125E,// EVEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8
				0x00440002, 0x0002240D, 0x003A229F,// EVEX_Vpclmulqdq_ymm_ymm_ymmm256_imm8
				0x00440002, 0x0002680D, 0x003A32E0,// EVEX_Vpclmulqdq_zmm_zmm_zmmm512_imm8
				0x00460001, 0x0000100D, 0x004263E3,// VEX_Vperm2i128_ymm_ymm_ymmm256_imm8
				0x00480001, 0x00000C0D, 0x115253A2,// VEX_Vpermil2ps_xmm_xmm_xmmm128_xmm_imm2
				0x00480001, 0x0000100D, 0x115663E3,// VEX_Vpermil2ps_ymm_ymm_ymmm256_ymm_imm2
				0x00480001, 0x00002C0D, 0x119543A2,// VEX_Vpermil2ps_xmm_xmm_xmm_xmmm128_imm2
				0x00480001, 0x0000300D, 0x119953E3,// VEX_Vpermil2ps_ymm_ymm_ymm_ymmm256_imm2
				0x00490001, 0x00000C0D, 0x115253A2,// VEX_Vpermil2pd_xmm_xmm_xmmm128_xmm_imm2
				0x00490001, 0x0000100D, 0x115663E3,// VEX_Vpermil2pd_ymm_ymm_ymmm256_ymm_imm2
				0x00490001, 0x00002C0D, 0x119543A2,// VEX_Vpermil2pd_xmm_xmm_xmm_xmmm128_imm2
				0x00490001, 0x0000300D, 0x119953E3,// VEX_Vpermil2pd_ymm_ymm_ymm_ymmm256_imm2
				0x004A0001, 0x00000C0D, 0x004A53A2,// VEX_Vblendvps_xmm_xmm_xmmm128_xmm
				0x004A0001, 0x0000100D, 0x004E63E3,// VEX_Vblendvps_ymm_ymm_ymmm256_ymm
				0x004B0001, 0x00000C0D, 0x004A53A2,// VEX_Vblendvpd_xmm_xmm_xmmm128_xmm
				0x004B0001, 0x0000100D, 0x004E63E3,// VEX_Vblendvpd_ymm_ymm_ymmm256_ymm
				0x004C0001, 0x00000C0D, 0x004A53A2,// VEX_Vpblendvb_xmm_xmm_xmmm128_xmm
				0x004C0001, 0x0000100D, 0x004E63E3,// VEX_Vpblendvb_ymm_ymm_ymmm256_ymm
				0x00500002, 0x0320400D, 0x003A125E,// EVEX_Vrangeps_xmm_k1z_xmm_xmmm128b32_imm8
				0x00500002, 0x0320840D, 0x003A229F,// EVEX_Vrangeps_ymm_k1z_ymm_ymmm256b32_imm8
				0x00500002, 0x03A0C80D, 0x003A32E0,// EVEX_Vrangeps_zmm_k1z_zmm_zmmm512b32_imm8_sae
				0x00500002, 0x0320500D, 0x003A125E,// EVEX_Vrangepd_xmm_k1z_xmm_xmmm128b64_imm8
				0x00500002, 0x0320940D, 0x003A229F,// EVEX_Vrangepd_ymm_k1z_ymm_ymmm256b64_imm8
				0x00500002, 0x03A0D80D, 0x003A32E0,// EVEX_Vrangepd_zmm_k1z_zmm_zmmm512b64_imm8_sae
				0x00510002, 0x0392800D, 0x003A125E,// EVEX_Vrangess_xmm_k1z_xmm_xmmm32_imm8_sae
				0x00510002, 0x0392900D, 0x003A125E,// EVEX_Vrangesd_xmm_k1z_xmm_xmmm64_imm8_sae
				0x00540002, 0x0320400D, 0x003A125E,// EVEX_Vfixupimmps_xmm_k1z_xmm_xmmm128b32_imm8
				0x00540002, 0x0320840D, 0x003A229F,// EVEX_Vfixupimmps_ymm_k1z_ymm_ymmm256b32_imm8
				0x00540002, 0x03A0C80D, 0x003A32E0,// EVEX_Vfixupimmps_zmm_k1z_zmm_zmmm512b32_imm8_sae
				0x00540002, 0x0320500D, 0x003A125E,// EVEX_Vfixupimmpd_xmm_k1z_xmm_xmmm128b64_imm8
				0x00540002, 0x0320940D, 0x003A229F,// EVEX_Vfixupimmpd_ymm_k1z_ymm_ymmm256b64_imm8
				0x00540002, 0x03A0D80D, 0x003A32E0,// EVEX_Vfixupimmpd_zmm_k1z_zmm_zmmm512b64_imm8_sae
				0x00550002, 0x0392800D, 0x003A125E,// EVEX_Vfixupimmss_xmm_k1z_xmm_xmmm32_imm8_sae
				0x00550002, 0x0392900D, 0x003A125E,// EVEX_Vfixupimmsd_xmm_k1z_xmm_xmmm64_imm8_sae
				0x00560002, 0x0320400D, 0x0000E85E,// EVEX_Vreduceps_xmm_k1z_xmmm128b32_imm8
				0x00560002, 0x0320840D, 0x0000E89F,// EVEX_Vreduceps_ymm_k1z_ymmm256b32_imm8
				0x00560002, 0x03A0C80D, 0x0000E8E0,// EVEX_Vreduceps_zmm_k1z_zmmm512b32_imm8_sae
				0x00560002, 0x0320500D, 0x0000E85E,// EVEX_Vreducepd_xmm_k1z_xmmm128b64_imm8
				0x00560002, 0x0320940D, 0x0000E89F,// EVEX_Vreducepd_ymm_k1z_ymmm256b64_imm8
				0x00560002, 0x03A0D80D, 0x0000E8E0,// EVEX_Vreducepd_zmm_k1z_zmmm512b64_imm8_sae
				0x00570002, 0x0392800D, 0x003A125E,// EVEX_Vreducess_xmm_k1z_xmm_xmmm32_imm8_sae
				0x00570002, 0x0392900D, 0x003A125E,// EVEX_Vreducesd_xmm_k1z_xmm_xmmm64_imm8_sae
				0x005C0001, 0x00000C0D, 0x004A53A2,// VEX_Vfmaddsubps_xmm_xmm_xmmm128_xmm
				0x005C0001, 0x0000100D, 0x004E63E3,// VEX_Vfmaddsubps_ymm_ymm_ymmm256_ymm
				0x005C0001, 0x00002C0D, 0x009523A2,// VEX_Vfmaddsubps_xmm_xmm_xmm_xmmm128
				0x005C0001, 0x0000300D, 0x009933E3,// VEX_Vfmaddsubps_ymm_ymm_ymm_ymmm256
				0x005D0001, 0x00000C0D, 0x004A53A2,// VEX_Vfmaddsubpd_xmm_xmm_xmmm128_xmm
				0x005D0001, 0x0000100D, 0x004E63E3,// VEX_Vfmaddsubpd_ymm_ymm_ymmm256_ymm
				0x005D0001, 0x00002C0D, 0x009523A2,// VEX_Vfmaddsubpd_xmm_xmm_xmm_xmmm128
				0x005D0001, 0x0000300D, 0x009933E3,// VEX_Vfmaddsubpd_ymm_ymm_ymm_ymmm256
				0x005E0001, 0x00000C0D, 0x004A53A2,// VEX_Vfmsubaddps_xmm_xmm_xmmm128_xmm
				0x005E0001, 0x0000100D, 0x004E63E3,// VEX_Vfmsubaddps_ymm_ymm_ymmm256_ymm
				0x005E0001, 0x00002C0D, 0x009523A2,// VEX_Vfmsubaddps_xmm_xmm_xmm_xmmm128
				0x005E0001, 0x0000300D, 0x009933E3,// VEX_Vfmsubaddps_ymm_ymm_ymm_ymmm256
				0x005F0001, 0x00000C0D, 0x004A53A2,// VEX_Vfmsubaddpd_xmm_xmm_xmmm128_xmm
				0x005F0001, 0x0000100D, 0x004E63E3,// VEX_Vfmsubaddpd_ymm_ymm_ymmm256_ymm
				0x005F0001, 0x00002C0D, 0x009523A2,// VEX_Vfmsubaddpd_xmm_xmm_xmm_xmmm128
				0x005F0001, 0x0000300D, 0x009933E3,// VEX_Vfmsubaddpd_ymm_ymm_ymm_ymmm256
				0x00600000, 0x0000800D, 0x000E7263,// Pcmpestrm_xmm_xmmm128_imm8
				0x00600000, 0x0003802D, 0x000E7263,// Pcmpestrm64_xmm_xmmm128_imm8
				0x00600001, 0x00006C0D, 0x00010962,// VEX_Vpcmpestrm_xmm_xmmm128_imm8
				0x00600001, 0x00002C2D, 0x00010962,// VEX_Vpcmpestrm64_xmm_xmmm128_imm8
				0x00610000, 0x0000800D, 0x000E7263,// Pcmpestri_xmm_xmmm128_imm8
				0x00610000, 0x0003802D, 0x000E7263,// Pcmpestri64_xmm_xmmm128_imm8
				0x00610001, 0x00006C0D, 0x00010962,// VEX_Vpcmpestri_xmm_xmmm128_imm8
				0x00610001, 0x00002C2D, 0x00010962,// VEX_Vpcmpestri64_xmm_xmmm128_imm8
				0x00620000, 0x0000800D, 0x000E7263,// Pcmpistrm_xmm_xmmm128_imm8
				0x00620001, 0x00004C0D, 0x00010962,// VEX_Vpcmpistrm_xmm_xmmm128_imm8
				0x00630000, 0x0000800D, 0x000E7263,// Pcmpistri_xmm_xmmm128_imm8
				0x00630001, 0x00004C0D, 0x00010962,// VEX_Vpcmpistri_xmm_xmmm128_imm8
				0x00660002, 0x0120400D, 0x0000E85C,// EVEX_Vfpclassps_k_k1_xmmm128b32_imm8
				0x00660002, 0x0120840D, 0x0000E89C,// EVEX_Vfpclassps_k_k1_ymmm256b32_imm8
				0x00660002, 0x0120C80D, 0x0000E8DC,// EVEX_Vfpclassps_k_k1_zmmm512b32_imm8
				0x00660002, 0x0120500D, 0x0000E85C,// EVEX_Vfpclasspd_k_k1_xmmm128b64_imm8
				0x00660002, 0x0120940D, 0x0000E89C,// EVEX_Vfpclasspd_k_k1_ymmm256b64_imm8
				0x00660002, 0x0120D80D, 0x0000E8DC,// EVEX_Vfpclasspd_k_k1_zmmm512b64_imm8
				0x00670002, 0x0112800D, 0x0000E85C,// EVEX_Vfpclassss_k_k1_xmmm32_imm8
				0x00670002, 0x0112900D, 0x0000E85C,// EVEX_Vfpclasssd_k_k1_xmmm64_imm8
				0x00680001, 0x00000C0D, 0x004A53A2,// VEX_Vfmaddps_xmm_xmm_xmmm128_xmm
				0x00680001, 0x0000100D, 0x004E63E3,// VEX_Vfmaddps_ymm_ymm_ymmm256_ymm
				0x00680001, 0x00002C0D, 0x009523A2,// VEX_Vfmaddps_xmm_xmm_xmm_xmmm128
				0x00680001, 0x0000300D, 0x009933E3,// VEX_Vfmaddps_ymm_ymm_ymm_ymmm256
				0x00690001, 0x00000C0D, 0x004A53A2,// VEX_Vfmaddpd_xmm_xmm_xmmm128_xmm
				0x00690001, 0x0000100D, 0x004E63E3,// VEX_Vfmaddpd_ymm_ymm_ymmm256_ymm
				0x00690001, 0x00002C0D, 0x009523A2,// VEX_Vfmaddpd_xmm_xmm_xmm_xmmm128
				0x00690001, 0x0000300D, 0x009933E3,// VEX_Vfmaddpd_ymm_ymm_ymm_ymmm256
				0x006A0001, 0x0000140D, 0x004A53A2,// VEX_Vfmaddss_xmm_xmm_xmmm32_xmm
				0x006A0001, 0x0000340D, 0x009523A2,// VEX_Vfmaddss_xmm_xmm_xmm_xmmm32
				0x006B0001, 0x0000140D, 0x004A53A2,// VEX_Vfmaddsd_xmm_xmm_xmmm64_xmm
				0x006B0001, 0x0000340D, 0x009523A2,// VEX_Vfmaddsd_xmm_xmm_xmm_xmmm64
				0x006C0001, 0x00000C0D, 0x004A53A2,// VEX_Vfmsubps_xmm_xmm_xmmm128_xmm
				0x006C0001, 0x0000100D, 0x004E63E3,// VEX_Vfmsubps_ymm_ymm_ymmm256_ymm
				0x006C0001, 0x00002C0D, 0x009523A2,// VEX_Vfmsubps_xmm_xmm_xmm_xmmm128
				0x006C0001, 0x0000300D, 0x009933E3,// VEX_Vfmsubps_ymm_ymm_ymm_ymmm256
				0x006D0001, 0x00000C0D, 0x004A53A2,// VEX_Vfmsubpd_xmm_xmm_xmmm128_xmm
				0x006D0001, 0x0000100D, 0x004E63E3,// VEX_Vfmsubpd_ymm_ymm_ymmm256_ymm
				0x006D0001, 0x00002C0D, 0x009523A2,// VEX_Vfmsubpd_xmm_xmm_xmm_xmmm128
				0x006D0001, 0x0000300D, 0x009933E3,// VEX_Vfmsubpd_ymm_ymm_ymm_ymmm256
				0x006E0001, 0x0000140D, 0x004A53A2,// VEX_Vfmsubss_xmm_xmm_xmmm32_xmm
				0x006E0001, 0x0000340D, 0x009523A2,// VEX_Vfmsubss_xmm_xmm_xmm_xmmm32
				0x006F0001, 0x0000140D, 0x004A53A2,// VEX_Vfmsubsd_xmm_xmm_xmmm64_xmm
				0x006F0001, 0x0000340D, 0x009523A2,// VEX_Vfmsubsd_xmm_xmm_xmm_xmmm64
				0x00700002, 0x0301D00D, 0x003A125E,// EVEX_Vpshldw_xmm_k1z_xmm_xmmm128_imm8
				0x00700002, 0x0302140D, 0x003A229F,// EVEX_Vpshldw_ymm_k1z_ymm_ymmm256_imm8
				0x00700002, 0x0302580D, 0x003A32E0,// EVEX_Vpshldw_zmm_k1z_zmm_zmmm512_imm8
				0x00710002, 0x0320400D, 0x003A125E,// EVEX_Vpshldd_xmm_k1z_xmm_xmmm128b32_imm8
				0x00710002, 0x0320840D, 0x003A229F,// EVEX_Vpshldd_ymm_k1z_ymm_ymmm256b32_imm8
				0x00710002, 0x0320C80D, 0x003A32E0,// EVEX_Vpshldd_zmm_k1z_zmm_zmmm512b32_imm8
				0x00710002, 0x0320500D, 0x003A125E,// EVEX_Vpshldq_xmm_k1z_xmm_xmmm128b64_imm8
				0x00710002, 0x0320940D, 0x003A229F,// EVEX_Vpshldq_ymm_k1z_ymm_ymmm256b64_imm8
				0x00710002, 0x0320D80D, 0x003A32E0,// EVEX_Vpshldq_zmm_k1z_zmm_zmmm512b64_imm8
				0x00720002, 0x0301D00D, 0x003A125E,// EVEX_Vpshrdw_xmm_k1z_xmm_xmmm128_imm8
				0x00720002, 0x0302140D, 0x003A229F,// EVEX_Vpshrdw_ymm_k1z_ymm_ymmm256_imm8
				0x00720002, 0x0302580D, 0x003A32E0,// EVEX_Vpshrdw_zmm_k1z_zmm_zmmm512_imm8
				0x00730002, 0x0320400D, 0x003A125E,// EVEX_Vpshrdd_xmm_k1z_xmm_xmmm128b32_imm8
				0x00730002, 0x0320840D, 0x003A229F,// EVEX_Vpshrdd_ymm_k1z_ymm_ymmm256b32_imm8
				0x00730002, 0x0320C80D, 0x003A32E0,// EVEX_Vpshrdd_zmm_k1z_zmm_zmmm512b32_imm8
				0x00730002, 0x0320500D, 0x003A125E,// EVEX_Vpshrdq_xmm_k1z_xmm_xmmm128b64_imm8
				0x00730002, 0x0320940D, 0x003A229F,// EVEX_Vpshrdq_ymm_k1z_ymm_ymmm256b64_imm8
				0x00730002, 0x0320D80D, 0x003A32E0,// EVEX_Vpshrdq_zmm_k1z_zmm_zmmm512b64_imm8
				0x00780001, 0x00000C0D, 0x004A53A2,// VEX_Vfnmaddps_xmm_xmm_xmmm128_xmm
				0x00780001, 0x0000100D, 0x004E63E3,// VEX_Vfnmaddps_ymm_ymm_ymmm256_ymm
				0x00780001, 0x00002C0D, 0x009523A2,// VEX_Vfnmaddps_xmm_xmm_xmm_xmmm128
				0x00780001, 0x0000300D, 0x009933E3,// VEX_Vfnmaddps_ymm_ymm_ymm_ymmm256
				0x00790001, 0x00000C0D, 0x004A53A2,// VEX_Vfnmaddpd_xmm_xmm_xmmm128_xmm
				0x00790001, 0x0000100D, 0x004E63E3,// VEX_Vfnmaddpd_ymm_ymm_ymmm256_ymm
				0x00790001, 0x00002C0D, 0x009523A2,// VEX_Vfnmaddpd_xmm_xmm_xmm_xmmm128
				0x00790001, 0x0000300D, 0x009933E3,// VEX_Vfnmaddpd_ymm_ymm_ymm_ymmm256
				0x007A0001, 0x0000140D, 0x004A53A2,// VEX_Vfnmaddss_xmm_xmm_xmmm32_xmm
				0x007A0001, 0x0000340D, 0x009523A2,// VEX_Vfnmaddss_xmm_xmm_xmm_xmmm32
				0x007B0001, 0x0000140D, 0x004A53A2,// VEX_Vfnmaddsd_xmm_xmm_xmmm64_xmm
				0x007B0001, 0x0000340D, 0x009523A2,// VEX_Vfnmaddsd_xmm_xmm_xmm_xmmm64
				0x007C0001, 0x00000C0D, 0x004A53A2,// VEX_Vfnmsubps_xmm_xmm_xmmm128_xmm
				0x007C0001, 0x0000100D, 0x004E63E3,// VEX_Vfnmsubps_ymm_ymm_ymmm256_ymm
				0x007C0001, 0x00002C0D, 0x009523A2,// VEX_Vfnmsubps_xmm_xmm_xmm_xmmm128
				0x007C0001, 0x0000300D, 0x009933E3,// VEX_Vfnmsubps_ymm_ymm_ymm_ymmm256
				0x007D0001, 0x00000C0D, 0x004A53A2,// VEX_Vfnmsubpd_xmm_xmm_xmmm128_xmm
				0x007D0001, 0x0000100D, 0x004E63E3,// VEX_Vfnmsubpd_ymm_ymm_ymmm256_ymm
				0x007D0001, 0x00002C0D, 0x009523A2,// VEX_Vfnmsubpd_xmm_xmm_xmm_xmmm128
				0x007D0001, 0x0000300D, 0x009933E3,// VEX_Vfnmsubpd_ymm_ymm_ymm_ymmm256
				0x007E0001, 0x0000140D, 0x004A53A2,// VEX_Vfnmsubss_xmm_xmm_xmmm32_xmm
				0x007E0001, 0x0000340D, 0x009523A2,// VEX_Vfnmsubss_xmm_xmm_xmm_xmmm32
				0x007F0001, 0x0000140D, 0x004A53A2,// VEX_Vfnmsubsd_xmm_xmm_xmmm64_xmm
				0x007F0001, 0x0000340D, 0x009523A2,// VEX_Vfnmsubsd_xmm_xmm_xmm_xmmm64
				0x00CC0000, 0x0000800C, 0x000E7263,// Sha1rnds4_xmm_xmmm128_imm8
				0x00CE0000, 0x0000800D, 0x000E7263,// Gf2p8affineqb_xmm_xmmm128_imm8
				0x00CE0001, 0x00002C0D, 0x004253A2,// VEX_Vgf2p8affineqb_xmm_xmm_xmmm128_imm8
				0x00CE0001, 0x0000300D, 0x004263E3,// VEX_Vgf2p8affineqb_ymm_ymm_ymmm256_imm8
				0x00CE0002, 0x0320500D, 0x003A125E,// EVEX_Vgf2p8affineqb_xmm_k1z_xmm_xmmm128b64_imm8
				0x00CE0002, 0x0320940D, 0x003A229F,// EVEX_Vgf2p8affineqb_ymm_k1z_ymm_ymmm256b64_imm8
				0x00CE0002, 0x0320D80D, 0x003A32E0,// EVEX_Vgf2p8affineqb_zmm_k1z_zmm_zmmm512b64_imm8
				0x00CF0000, 0x0000800D, 0x000E7263,// Gf2p8affineinvqb_xmm_xmmm128_imm8
				0x00CF0001, 0x00002C0D, 0x004253A2,// VEX_Vgf2p8affineinvqb_xmm_xmm_xmmm128_imm8
				0x00CF0001, 0x0000300D, 0x004263E3,// VEX_Vgf2p8affineinvqb_ymm_ymm_ymmm256_imm8
				0x00CF0002, 0x0320500D, 0x003A125E,// EVEX_Vgf2p8affineinvqb_xmm_k1z_xmm_xmmm128b64_imm8
				0x00CF0002, 0x0320940D, 0x003A229F,// EVEX_Vgf2p8affineinvqb_ymm_k1z_ymm_ymmm256b64_imm8
				0x00CF0002, 0x0320D80D, 0x003A32E0,// EVEX_Vgf2p8affineinvqb_zmm_k1z_zmm_zmmm512b64_imm8
				0x00DF0000, 0x0000800D, 0x000E7263,// Aeskeygenassist_xmm_xmmm128_imm8
				0x00DF0001, 0x00004C0D, 0x00010962,// VEX_Vaeskeygenassist_xmm_xmmm128_imm8
				0x00F00001, 0x0000600F, 0x00010043,// VEX_Rorx_r32_rm32_imm8
				0x00F00001, 0x0000202F, 0x00010084,// VEX_Rorx_r64_rm64_imm8
				0x00850003, 0x00000000, 0x0006C52F,// XOP_Vpmacssww_xmm_xmm_xmmm128_xmm
				0x00860003, 0x00000000, 0x0006C52F,// XOP_Vpmacsswd_xmm_xmm_xmmm128_xmm
				0x00870003, 0x00000000, 0x0006C52F,// XOP_Vpmacssdql_xmm_xmm_xmmm128_xmm
				0x008E0003, 0x00000000, 0x0006C52F,// XOP_Vpmacssdd_xmm_xmm_xmmm128_xmm
				0x008F0003, 0x00000000, 0x0006C52F,// XOP_Vpmacssdqh_xmm_xmm_xmmm128_xmm
				0x00950003, 0x00000000, 0x0006C52F,// XOP_Vpmacsww_xmm_xmm_xmmm128_xmm
				0x00960003, 0x00000000, 0x0006C52F,// XOP_Vpmacswd_xmm_xmm_xmmm128_xmm
				0x00970003, 0x00000000, 0x0006C52F,// XOP_Vpmacsdql_xmm_xmm_xmmm128_xmm
				0x009E0003, 0x00000000, 0x0006C52F,// XOP_Vpmacsdd_xmm_xmm_xmmm128_xmm
				0x009F0003, 0x00000000, 0x0006C52F,// XOP_Vpmacsdqh_xmm_xmm_xmmm128_xmm
				0x00A20003, 0x00000000, 0x0006C52F,// XOP_Vpcmov_xmm_xmm_xmmm128_xmm
				0x00A20003, 0x00000400, 0x00074950,// XOP_Vpcmov_ymm_ymm_ymmm256_ymm
				0x00A20003, 0x00001000, 0x0008B52F,// XOP_Vpcmov_xmm_xmm_xmm_xmmm128
				0x00A20003, 0x00001400, 0x00093950,// XOP_Vpcmov_ymm_ymm_ymm_ymmm256
				0x00A30003, 0x00000000, 0x0006C52F,// XOP_Vpperm_xmm_xmm_xmmm128_xmm
				0x00A30003, 0x00001000, 0x0008B52F,// XOP_Vpperm_xmm_xmm_xmm_xmmm128
				0x00A60003, 0x00000000, 0x0006C52F,// XOP_Vpmadcsswd_xmm_xmm_xmmm128_xmm
				0x00B60003, 0x00000000, 0x0006C52F,// XOP_Vpmadcswd_xmm_xmm_xmmm128_xmm
				0x00C00003, 0x00000000, 0x00002E2F,// XOP_Vprotb_xmm_xmmm128_imm8
				0x00C10003, 0x00000000, 0x00002E2F,// XOP_Vprotw_xmm_xmmm128_imm8
				0x00C20003, 0x00000000, 0x00002E2F,// XOP_Vprotd_xmm_xmmm128_imm8
				0x00C30003, 0x00000000, 0x00002E2F,// XOP_Vprotq_xmm_xmmm128_imm8
				0x00CC0003, 0x00000000, 0x0005C52F,// XOP_Vpcomb_xmm_xmm_xmmm128_imm8
				0x00CD0003, 0x00000000, 0x0005C52F,// XOP_Vpcomw_xmm_xmm_xmmm128_imm8
				0x00CE0003, 0x00000000, 0x0005C52F,// XOP_Vpcomd_xmm_xmm_xmmm128_imm8
				0x00CF0003, 0x00000000, 0x0005C52F,// XOP_Vpcomq_xmm_xmm_xmmm128_imm8
				0x00EC0003, 0x00000000, 0x0005C52F,// XOP_Vpcomub_xmm_xmm_xmmm128_imm8
				0x00ED0003, 0x00000000, 0x0005C52F,// XOP_Vpcomuw_xmm_xmm_xmmm128_imm8
				0x00EE0003, 0x00000000, 0x0005C52F,// XOP_Vpcomud_xmm_xmm_xmmm128_imm8
				0x00EF0003, 0x00000000, 0x0005C52F,// XOP_Vpcomuq_xmm_xmm_xmmm128_imm8
				0x00010003, 0x000038C4, 0x00000027,// XOP_Blcfill_r32_rm32
				0x00010003, 0x000018E4, 0x00000048,// XOP_Blcfill_r64_rm64
				0x00010003, 0x00003944, 0x00000027,// XOP_Blsfill_r32_rm32
				0x00010003, 0x00001964, 0x00000048,// XOP_Blsfill_r64_rm64
				0x00010003, 0x000039C4, 0x00000027,// XOP_Blcs_r32_rm32
				0x00010003, 0x000019E4, 0x00000048,// XOP_Blcs_r64_rm64
				0x00010003, 0x00003A44, 0x00000027,// XOP_Tzmsk_r32_rm32
				0x00010003, 0x00001A64, 0x00000048,// XOP_Tzmsk_r64_rm64
				0x00010003, 0x00003AC4, 0x00000027,// XOP_Blcic_r32_rm32
				0x00010003, 0x00001AE4, 0x00000048,// XOP_Blcic_r64_rm64
				0x00010003, 0x00003B44, 0x00000027,// XOP_Blsic_r32_rm32
				0x00010003, 0x00001B64, 0x00000048,// XOP_Blsic_r64_rm64
				0x00010003, 0x00003BC4, 0x00000027,// XOP_T1mskc_r32_rm32
				0x00010003, 0x00001BE4, 0x00000048,// XOP_T1mskc_r64_rm64
				0x00020003, 0x000038C4, 0x00000027,// XOP_Blcmsk_r32_rm32
				0x00020003, 0x000018E4, 0x00000048,// XOP_Blcmsk_r64_rm64
				0x00020003, 0x00003B44, 0x00000027,// XOP_Blci_r32_rm32
				0x00020003, 0x00001B64, 0x00000048,// XOP_Blci_r64_rm64
				0x00120003, 0x00003844, 0x00000005,// XOP_Llwpcb_r32
				0x00120003, 0x00001864, 0x00000006,// XOP_Llwpcb_r64
				0x00120003, 0x000038C4, 0x00000005,// XOP_Slwpcb_r32
				0x00120003, 0x000018E4, 0x00000006,// XOP_Slwpcb_r64
				0x00800003, 0x00000004, 0x0000022F,// XOP_Vfrczps_xmm_xmmm128
				0x00800003, 0x00000404, 0x00000250,// XOP_Vfrczps_ymm_ymmm256
				0x00810003, 0x00000004, 0x0000022F,// XOP_Vfrczpd_xmm_xmmm128
				0x00810003, 0x00000404, 0x00000250,// XOP_Vfrczpd_ymm_ymmm256
				0x00820003, 0x00000004, 0x0000022F,// XOP_Vfrczss_xmm_xmmm32
				0x00830003, 0x00000004, 0x0000022F,// XOP_Vfrczsd_xmm_xmmm64
				0x00900003, 0x00000004, 0x0000262F,// XOP_Vprotb_xmm_xmmm128_xmm
				0x00900003, 0x00001004, 0x0000452F,// XOP_Vprotb_xmm_xmm_xmmm128
				0x00910003, 0x00000004, 0x0000262F,// XOP_Vprotw_xmm_xmmm128_xmm
				0x00910003, 0x00001004, 0x0000452F,// XOP_Vprotw_xmm_xmm_xmmm128
				0x00920003, 0x00000004, 0x0000262F,// XOP_Vprotd_xmm_xmmm128_xmm
				0x00920003, 0x00001004, 0x0000452F,// XOP_Vprotd_xmm_xmm_xmmm128
				0x00930003, 0x00000004, 0x0000262F,// XOP_Vprotq_xmm_xmmm128_xmm
				0x00930003, 0x00001004, 0x0000452F,// XOP_Vprotq_xmm_xmm_xmmm128
				0x00940003, 0x00000004, 0x0000262F,// XOP_Vpshlb_xmm_xmmm128_xmm
				0x00940003, 0x00001004, 0x0000452F,// XOP_Vpshlb_xmm_xmm_xmmm128
				0x00950003, 0x00000004, 0x0000262F,// XOP_Vpshlw_xmm_xmmm128_xmm
				0x00950003, 0x00001004, 0x0000452F,// XOP_Vpshlw_xmm_xmm_xmmm128
				0x00960003, 0x00000004, 0x0000262F,// XOP_Vpshld_xmm_xmmm128_xmm
				0x00960003, 0x00001004, 0x0000452F,// XOP_Vpshld_xmm_xmm_xmmm128
				0x00970003, 0x00000004, 0x0000262F,// XOP_Vpshlq_xmm_xmmm128_xmm
				0x00970003, 0x00001004, 0x0000452F,// XOP_Vpshlq_xmm_xmm_xmmm128
				0x00980003, 0x00000004, 0x0000262F,// XOP_Vpshab_xmm_xmmm128_xmm
				0x00980003, 0x00001004, 0x0000452F,// XOP_Vpshab_xmm_xmm_xmmm128
				0x00990003, 0x00000004, 0x0000262F,// XOP_Vpshaw_xmm_xmmm128_xmm
				0x00990003, 0x00001004, 0x0000452F,// XOP_Vpshaw_xmm_xmm_xmmm128
				0x009A0003, 0x00000004, 0x0000262F,// XOP_Vpshad_xmm_xmmm128_xmm
				0x009A0003, 0x00001004, 0x0000452F,// XOP_Vpshad_xmm_xmm_xmmm128
				0x009B0003, 0x00000004, 0x0000262F,// XOP_Vpshaq_xmm_xmmm128_xmm
				0x009B0003, 0x00001004, 0x0000452F,// XOP_Vpshaq_xmm_xmm_xmmm128
				0x00C10003, 0x00000004, 0x0000022F,// XOP_Vphaddbw_xmm_xmmm128
				0x00C20003, 0x00000004, 0x0000022F,// XOP_Vphaddbd_xmm_xmmm128
				0x00C30003, 0x00000004, 0x0000022F,// XOP_Vphaddbq_xmm_xmmm128
				0x00C60003, 0x00000004, 0x0000022F,// XOP_Vphaddwd_xmm_xmmm128
				0x00C70003, 0x00000004, 0x0000022F,// XOP_Vphaddwq_xmm_xmmm128
				0x00CB0003, 0x00000004, 0x0000022F,// XOP_Vphadddq_xmm_xmmm128
				0x00D10003, 0x00000004, 0x0000022F,// XOP_Vphaddubw_xmm_xmmm128
				0x00D20003, 0x00000004, 0x0000022F,// XOP_Vphaddubd_xmm_xmmm128
				0x00D30003, 0x00000004, 0x0000022F,// XOP_Vphaddubq_xmm_xmmm128
				0x00D60003, 0x00000004, 0x0000022F,// XOP_Vphadduwd_xmm_xmmm128
				0x00D70003, 0x00000004, 0x0000022F,// XOP_Vphadduwq_xmm_xmmm128
				0x00DB0003, 0x00000004, 0x0000022F,// XOP_Vphaddudq_xmm_xmmm128
				0x00E10003, 0x00000004, 0x0000022F,// XOP_Vphsubbw_xmm_xmmm128
				0x00E20003, 0x00000004, 0x0000022F,// XOP_Vphsubwd_xmm_xmmm128
				0x00E30003, 0x00000004, 0x0000022F,// XOP_Vphsubdq_xmm_xmmm128
				0x00100003, 0x00003808, 0x00003023,// XOP_Bextr_r32_rm32_imm32
				0x00100003, 0x00001828, 0x00003044,// XOP_Bextr_r64_rm64_imm32
				0x00120003, 0x00003848, 0x00003027,// XOP_Lwpins_r32_rm32_imm32
				0x00120003, 0x00001868, 0x00003028,// XOP_Lwpins_r64_rm32_imm32
				0x00120003, 0x000038C8, 0x00003027,// XOP_Lwpval_r32_rm32_imm32
				0x00120003, 0x000018E8, 0x00003028,// XOP_Lwpval_r64_rm32_imm32
				0x000C0004, 0x00000000, 0x00000000,// D3NOW_Pi2fw_mm_mmm64
				0x000D0004, 0x00000000, 0x00000000,// D3NOW_Pi2fd_mm_mmm64
				0x001C0004, 0x00000000, 0x00000000,// D3NOW_Pf2iw_mm_mmm64
				0x001D0004, 0x00000000, 0x00000000,// D3NOW_Pf2id_mm_mmm64
				0x00860004, 0x00000000, 0x00000000,// D3NOW_Pfrcpv_mm_mmm64
				0x00870004, 0x00000000, 0x00000000,// D3NOW_Pfrsqrtv_mm_mmm64
				0x008A0004, 0x00000000, 0x00000000,// D3NOW_Pfnacc_mm_mmm64
				0x008E0004, 0x00000000, 0x00000000,// D3NOW_Pfpnacc_mm_mmm64
				0x00900004, 0x00000000, 0x00000000,// D3NOW_Pfcmpge_mm_mmm64
				0x00940004, 0x00000000, 0x00000000,// D3NOW_Pfmin_mm_mmm64
				0x00960004, 0x00000000, 0x00000000,// D3NOW_Pfrcp_mm_mmm64
				0x00970004, 0x00000000, 0x00000000,// D3NOW_Pfrsqrt_mm_mmm64
				0x009A0004, 0x00000000, 0x00000000,// D3NOW_Pfsub_mm_mmm64
				0x009E0004, 0x00000000, 0x00000000,// D3NOW_Pfadd_mm_mmm64
				0x00A00004, 0x00000000, 0x00000000,// D3NOW_Pfcmpgt_mm_mmm64
				0x00A40004, 0x00000000, 0x00000000,// D3NOW_Pfmax_mm_mmm64
				0x00A60004, 0x00000000, 0x00000000,// D3NOW_Pfrcpit1_mm_mmm64
				0x00A70004, 0x00000000, 0x00000000,// D3NOW_Pfrsqit1_mm_mmm64
				0x00AA0004, 0x00000000, 0x00000000,// D3NOW_Pfsubr_mm_mmm64
				0x00AE0004, 0x00000000, 0x00000000,// D3NOW_Pfacc_mm_mmm64
				0x00B00004, 0x00000000, 0x00000000,// D3NOW_Pfcmpeq_mm_mmm64
				0x00B40004, 0x00000000, 0x00000000,// D3NOW_Pfmul_mm_mmm64
				0x00B60004, 0x00000000, 0x00000000,// D3NOW_Pfrcpit2_mm_mmm64
				0x00B70004, 0x00000000, 0x00000000,// D3NOW_Pmulhrw_mm_mmm64
				0x00BB0004, 0x00000000, 0x00000000,// D3NOW_Pswapd_mm_mmm64
				0x00BF0004, 0x00000000, 0x00000000,// D3NOW_Pavgusb_mm_mmm64
				0x01FE0000, 0x00008026, 0x00000000,// Rmpadjust
				0x01FE0000, 0x00008027, 0x00000000,// Rmpupdate
				0x01FF0000, 0x00008026, 0x00000000,// Psmash
				0x01FF0000, 0x00048017, 0x00000000,// Pvalidatew
				0x01FF0000, 0x00088007, 0x00000000,// Pvalidated
				0x01FF0000, 0x00008027, 0x00000000,// Pvalidateq
				0x01E80000, 0x00008004, 0x00000000,// Serialize
				0x01E80000, 0x00008007, 0x00000000,// Xsusldtrk
				0x01E90000, 0x00008007, 0x00000000,// Xresldtrk
			};
    }
}