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
        internal static ReadOnlySpan<byte> VEX
            =>new byte[] {
				// handlers_Grp_0F71
				0x01,// ArrayReference
				0x08,// 0x8
				// 0 = 0x00
				0x01,// Invalid2

				// 2 = 0x02
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x1A,// HRIb
							0x4D,// XMM0
							0xE1, 0x0C,// VEX_Vpsrlw_xmm_xmm_imm8
						0x1A,// HRIb
							0x6D,// YMM0
							0xE2, 0x0C,// VEX_Vpsrlw_ymm_ymm_imm8
					0x00,// Invalid
					0x00,// Invalid

				// 3 = 0x03
				0x00,// Invalid

				// 4 = 0x04
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x1A,// HRIb
							0x4D,// XMM0
							0xE8, 0x0C,// VEX_Vpsraw_xmm_xmm_imm8
						0x1A,// HRIb
							0x6D,// YMM0
							0xE9, 0x0C,// VEX_Vpsraw_ymm_ymm_imm8
					0x00,// Invalid
					0x00,// Invalid

				// 5 = 0x05
				0x00,// Invalid

				// 6 = 0x06
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x1A,// HRIb
							0x4D,// XMM0
							0xEF, 0x0C,// VEX_Vpsllw_xmm_xmm_imm8
						0x1A,// HRIb
							0x6D,// YMM0
							0xF0, 0x0C,// VEX_Vpsllw_ymm_ymm_imm8
					0x00,// Invalid
					0x00,// Invalid

				// 7 = 0x07
				0x00,// Invalid

				// handlers_Grp_0F72
				0x01,// ArrayReference
				0x08,// 0x8
				// 0 = 0x00
				0x01,// Invalid2

				// 2 = 0x02
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x1A,// HRIb
							0x4D,// XMM0
							0x82, 0x0D,// VEX_Vpsrld_xmm_xmm_imm8
						0x1A,// HRIb
							0x6D,// YMM0
							0x83, 0x0D,// VEX_Vpsrld_ymm_ymm_imm8
					0x00,// Invalid
					0x00,// Invalid

				// 3 = 0x03
				0x00,// Invalid

				// 4 = 0x04
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x1A,// HRIb
							0x4D,// XMM0
							0x89, 0x0D,// VEX_Vpsrad_xmm_xmm_imm8
						0x1A,// HRIb
							0x6D,// YMM0
							0x8A, 0x0D,// VEX_Vpsrad_ymm_ymm_imm8
					0x00,// Invalid
					0x00,// Invalid

				// 5 = 0x05
				0x00,// Invalid

				// 6 = 0x06
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x1A,// HRIb
							0x4D,// XMM0
							0x93, 0x0D,// VEX_Vpslld_xmm_xmm_imm8
						0x1A,// HRIb
							0x6D,// YMM0
							0x94, 0x0D,// VEX_Vpslld_ymm_ymm_imm8
					0x00,// Invalid
					0x00,// Invalid

				// 7 = 0x07
				0x00,// Invalid

				// handlers_Grp_0F73
				0x01,// ArrayReference
				0x08,// 0x8
				// 0 = 0x00
				0x01,// Invalid2

				// 2 = 0x02
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x1A,// HRIb
							0x4D,// XMM0
							0x9A, 0x0D,// VEX_Vpsrlq_xmm_xmm_imm8
						0x1A,// HRIb
							0x6D,// YMM0
							0x9B, 0x0D,// VEX_Vpsrlq_ymm_ymm_imm8
					0x00,// Invalid
					0x00,// Invalid

				// 3 = 0x03
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x1A,// HRIb
							0x4D,// XMM0
							0xA0, 0x0D,// VEX_Vpsrldq_xmm_xmm_imm8
						0x1A,// HRIb
							0x6D,// YMM0
							0xA1, 0x0D,// VEX_Vpsrldq_ymm_ymm_imm8
					0x00,// Invalid
					0x00,// Invalid

				// 4 = 0x04
				0x01,// Invalid2

				// 6 = 0x06
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x1A,// HRIb
							0x4D,// XMM0
							0xA7, 0x0D,// VEX_Vpsllq_xmm_xmm_imm8
						0x1A,// HRIb
							0x6D,// YMM0
							0xA8, 0x0D,// VEX_Vpsllq_ymm_ymm_imm8
					0x00,// Invalid
					0x00,// Invalid

				// 7 = 0x07
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x1A,// HRIb
							0x4D,// XMM0
							0xAD, 0x0D,// VEX_Vpslldq_xmm_xmm_imm8
						0x1A,// HRIb
							0x6D,// YMM0
							0xAE, 0x0D,// VEX_Vpslldq_ymm_ymm_imm8
					0x00,// Invalid
					0x00,// Invalid

				// handlers_Grp_0FAE
				0x01,// ArrayReference
				0x08,// 0x8
				// 0 = 0x00
				0x01,// Invalid2

				// 2 = 0x02
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x1D,// M
							0xE3, 0x0F,// VEX_Vldmxcsr_m32
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 3 = 0x03
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x1D,// M
							0xE7, 0x0F,// VEX_Vstmxcsr_m32
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 4 = 0x04
				0x02,// Dup
					0x04,// 4
					0x00,// Invalid

				// handlers_Grp_0F38F3
				0x01,// ArrayReference
				0x08,// 0x8
				// 0 = 0x00
				0x00,// Invalid

				// 1 = 0x01
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x1C,// Hv_Ev
							0xD9, 0x1C,// VEX_Blsr_r32_rm32
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 2 = 0x02
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x1C,// Hv_Ev
							0xDB, 0x1C,// VEX_Blsmsk_r32_rm32
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 3 = 0x03
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x1C,// Hv_Ev
							0xDD, 0x1C,// VEX_Blsi_r32_rm32
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 4 = 0x04
				0x02,// Dup
					0x04,// 4
					0x00,// Invalid

				// ThreeByteHandlers_0F38XX
				0x01,// ArrayReference
				0x80, 0x02,// 0x100
				// 0 = 0x00
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0x84, 0x14,// VEX_Vpshufb_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0x85, 0x14,// VEX_Vpshufb_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 1 = 0x01
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0x8B, 0x14,// VEX_Vphaddw_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0x8C, 0x14,// VEX_Vphaddw_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 2 = 0x02
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0x8F, 0x14,// VEX_Vphaddd_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0x90, 0x14,// VEX_Vphaddd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 3 = 0x03
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0x93, 0x14,// VEX_Vphaddsw_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0x94, 0x14,// VEX_Vphaddsw_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 4 = 0x04
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0x97, 0x14,// VEX_Vpmaddubsw_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0x98, 0x14,// VEX_Vpmaddubsw_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 5 = 0x05
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0x9E, 0x14,// VEX_Vphsubw_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0x9F, 0x14,// VEX_Vphsubw_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 6 = 0x06
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xA2, 0x14,// VEX_Vphsubd_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xA3, 0x14,// VEX_Vphsubd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 7 = 0x07
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xA6, 0x14,// VEX_Vphsubsw_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xA7, 0x14,// VEX_Vphsubsw_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 8 = 0x08
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xAA, 0x14,// VEX_Vpsignb_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xAB, 0x14,// VEX_Vpsignb_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 9 = 0x09
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xAE, 0x14,// VEX_Vpsignw_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xAF, 0x14,// VEX_Vpsignw_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 10 = 0x0A
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xB2, 0x14,// VEX_Vpsignd_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xB3, 0x14,// VEX_Vpsignd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 11 = 0x0B
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xB6, 0x14,// VEX_Vpmulhrsw_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xB7, 0x14,// VEX_Vpmulhrsw_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 12 = 0x0C
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0xBB, 0x14,// VEX_Vpermilps_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0xBC, 0x14,// VEX_Vpermilps_ymm_ymm_ymmm256
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 13 = 0x0D
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0xC0, 0x14,// VEX_Vpermilpd_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0xC1, 0x14,// VEX_Vpermilpd_ymm_ymm_ymmm256
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 14 = 0x0E
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x36,// VW_2
								0x4D,// XMM0
								0xC5, 0x14,// VEX_Vtestps_xmm_xmmm128
							0x36,// VW_2
								0x6D,// YMM0
								0xC6, 0x14,// VEX_Vtestps_ymm_ymmm256
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 15 = 0x0F
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x36,// VW_2
								0x4D,// XMM0
								0xC7, 0x14,// VEX_Vtestpd_xmm_xmmm128
							0x36,// VW_2
								0x6D,// YMM0
								0xC8, 0x14,// VEX_Vtestpd_ymm_ymmm256
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 16 = 0x10
				0x02,// Dup
					0x03,// 3
					0x00,// Invalid

				// 19 = 0x13
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x37,// VW_3
								0x4D,// XMM0
								0x4D,// XMM0
								0xDC, 0x14,// VEX_Vcvtph2ps_xmm_xmmm64
							0x37,// VW_3
								0x6D,// YMM0
								0x4D,// XMM0
								0xDD, 0x14,// VEX_Vcvtph2ps_ymm_xmmm128
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 20 = 0x14
				0x01,// Invalid2

				// 22 = 0x16
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x00,// Invalid
							0x29,// VHW_2
								0x6D,// YMM0
								0xF8, 0x14,// VEX_Vpermps_ymm_ymm_ymmm256
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 23 = 0x17
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x36,// VW_2
							0x4D,// XMM0
							0xFE, 0x14,// VEX_Vptest_xmm_xmmm128
						0x36,// VW_2
							0x6D,// YMM0
							0xFF, 0x14,// VEX_Vptest_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 24 = 0x18
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x37,// VW_3
								0x4D,// XMM0
								0x4D,// XMM0
								0x80, 0x15,// VEX_Vbroadcastss_xmm_xmmm32
							0x37,// VW_3
								0x6D,// YMM0
								0x4D,// XMM0
								0x81, 0x15,// VEX_Vbroadcastss_ymm_xmmm32
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 25 = 0x19
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x00,// Invalid
							0x37,// VW_3
								0x6D,// YMM0
								0x4D,// XMM0
								0x85, 0x15,// VEX_Vbroadcastsd_ymm_xmmm64
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 26 = 0x1A
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x00,// Invalid
							0x35,// VM
								0x6D,// YMM0
								0x8A, 0x15,// VEX_Vbroadcastf128_ymm_m128
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 27 = 0x1B
				0x00,// Invalid

				// 28 = 0x1C
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x36,// VW_2
							0x4D,// XMM0
							0x93, 0x15,// VEX_Vpabsb_xmm_xmmm128
						0x36,// VW_2
							0x6D,// YMM0
							0x94, 0x15,// VEX_Vpabsb_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 29 = 0x1D
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x36,// VW_2
							0x4D,// XMM0
							0x9A, 0x15,// VEX_Vpabsw_xmm_xmmm128
						0x36,// VW_2
							0x6D,// YMM0
							0x9B, 0x15,// VEX_Vpabsw_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 30 = 0x1E
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x36,// VW_2
							0x4D,// XMM0
							0xA1, 0x15,// VEX_Vpabsd_xmm_xmmm128
						0x36,// VW_2
							0x6D,// YMM0
							0xA2, 0x15,// VEX_Vpabsd_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 31 = 0x1F
				0x00,// Invalid

				// 32 = 0x20
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x37,// VW_3
							0x4D,// XMM0
							0x4D,// XMM0
							0xAA, 0x15,// VEX_Vpmovsxbw_xmm_xmmm64
						0x37,// VW_3
							0x6D,// YMM0
							0x4D,// XMM0
							0xAB, 0x15,// VEX_Vpmovsxbw_ymm_xmmm128
					0x00,// Invalid
					0x00,// Invalid

				// 33 = 0x21
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x37,// VW_3
							0x4D,// XMM0
							0x4D,// XMM0
							0xB3, 0x15,// VEX_Vpmovsxbd_xmm_xmmm32
						0x37,// VW_3
							0x6D,// YMM0
							0x4D,// XMM0
							0xB4, 0x15,// VEX_Vpmovsxbd_ymm_xmmm64
					0x00,// Invalid
					0x00,// Invalid

				// 34 = 0x22
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x37,// VW_3
							0x4D,// XMM0
							0x4D,// XMM0
							0xBC, 0x15,// VEX_Vpmovsxbq_xmm_xmmm16
						0x37,// VW_3
							0x6D,// YMM0
							0x4D,// XMM0
							0xBD, 0x15,// VEX_Vpmovsxbq_ymm_xmmm32
					0x00,// Invalid
					0x00,// Invalid

				// 35 = 0x23
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x37,// VW_3
							0x4D,// XMM0
							0x4D,// XMM0
							0xC5, 0x15,// VEX_Vpmovsxwd_xmm_xmmm64
						0x37,// VW_3
							0x6D,// YMM0
							0x4D,// XMM0
							0xC6, 0x15,// VEX_Vpmovsxwd_ymm_xmmm128
					0x00,// Invalid
					0x00,// Invalid

				// 36 = 0x24
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x37,// VW_3
							0x4D,// XMM0
							0x4D,// XMM0
							0xCE, 0x15,// VEX_Vpmovsxwq_xmm_xmmm32
						0x37,// VW_3
							0x6D,// YMM0
							0x4D,// XMM0
							0xCF, 0x15,// VEX_Vpmovsxwq_ymm_xmmm64
					0x00,// Invalid
					0x00,// Invalid

				// 37 = 0x25
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x37,// VW_3
							0x4D,// XMM0
							0x4D,// XMM0
							0xD7, 0x15,// VEX_Vpmovsxdq_xmm_xmmm64
						0x37,// VW_3
							0x6D,// YMM0
							0x4D,// XMM0
							0xD8, 0x15,// VEX_Vpmovsxdq_ymm_xmmm128
					0x00,// Invalid
					0x00,// Invalid

				// 38 = 0x26
				0x01,// Invalid2

				// 40 = 0x28
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xF8, 0x15,// VEX_Vpmuldq_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xF9, 0x15,// VEX_Vpmuldq_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 41 = 0x29
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0x84, 0x16,// VEX_Vpcmpeqq_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0x85, 0x16,// VEX_Vpcmpeqq_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 42 = 0x2A
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x35,// VM
							0x4D,// XMM0
							0x90, 0x16,// VEX_Vmovntdqa_xmm_m128
						0x35,// VM
							0x6D,// YMM0
							0x91, 0x16,// VEX_Vmovntdqa_ymm_m256
					0x00,// Invalid
					0x00,// Invalid

				// 43 = 0x2B
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0x99, 0x16,// VEX_Vpackusdw_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0x9A, 0x16,// VEX_Vpackusdw_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 44 = 0x2C
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x28,// VHM
								0x4D,// XMM0
								0x9E, 0x16,// VEX_Vmaskmovps_xmm_xmm_m128
							0x28,// VHM
								0x6D,// YMM0
								0x9F, 0x16,// VEX_Vmaskmovps_ymm_ymm_m256
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 45 = 0x2D
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x28,// VHM
								0x4D,// XMM0
								0xA6, 0x16,// VEX_Vmaskmovpd_xmm_xmm_m128
							0x28,// VHM
								0x6D,// YMM0
								0xA7, 0x16,// VEX_Vmaskmovpd_ymm_ymm_m256
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 46 = 0x2E
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x1E,// MHV
								0x4D,// XMM0
								0xAA, 0x16,// VEX_Vmaskmovps_m128_xmm_xmm
							0x1E,// MHV
								0x6D,// YMM0
								0xAB, 0x16,// VEX_Vmaskmovps_m256_ymm_ymm
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 47 = 0x2F
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x1E,// MHV
								0x4D,// XMM0
								0xAC, 0x16,// VEX_Vmaskmovpd_m128_xmm_xmm
							0x1E,// MHV
								0x6D,// YMM0
								0xAD, 0x16,// VEX_Vmaskmovpd_m256_ymm_ymm
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 48 = 0x30
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x37,// VW_3
							0x4D,// XMM0
							0x4D,// XMM0
							0xAF, 0x16,// VEX_Vpmovzxbw_xmm_xmmm64
						0x37,// VW_3
							0x6D,// YMM0
							0x4D,// XMM0
							0xB0, 0x16,// VEX_Vpmovzxbw_ymm_xmmm128
					0x00,// Invalid
					0x00,// Invalid

				// 49 = 0x31
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x37,// VW_3
							0x4D,// XMM0
							0x4D,// XMM0
							0xB8, 0x16,// VEX_Vpmovzxbd_xmm_xmmm32
						0x37,// VW_3
							0x6D,// YMM0
							0x4D,// XMM0
							0xB9, 0x16,// VEX_Vpmovzxbd_ymm_xmmm64
					0x00,// Invalid
					0x00,// Invalid

				// 50 = 0x32
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x37,// VW_3
							0x4D,// XMM0
							0x4D,// XMM0
							0xC1, 0x16,// VEX_Vpmovzxbq_xmm_xmmm16
						0x37,// VW_3
							0x6D,// YMM0
							0x4D,// XMM0
							0xC2, 0x16,// VEX_Vpmovzxbq_ymm_xmmm32
					0x00,// Invalid
					0x00,// Invalid

				// 51 = 0x33
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x37,// VW_3
							0x4D,// XMM0
							0x4D,// XMM0
							0xCA, 0x16,// VEX_Vpmovzxwd_xmm_xmmm64
						0x37,// VW_3
							0x6D,// YMM0
							0x4D,// XMM0
							0xCB, 0x16,// VEX_Vpmovzxwd_ymm_xmmm128
					0x00,// Invalid
					0x00,// Invalid

				// 52 = 0x34
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x37,// VW_3
							0x4D,// XMM0
							0x4D,// XMM0
							0xD3, 0x16,// VEX_Vpmovzxwq_xmm_xmmm32
						0x37,// VW_3
							0x6D,// YMM0
							0x4D,// XMM0
							0xD4, 0x16,// VEX_Vpmovzxwq_ymm_xmmm64
					0x00,// Invalid
					0x00,// Invalid

				// 53 = 0x35
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x37,// VW_3
							0x4D,// XMM0
							0x4D,// XMM0
							0xDC, 0x16,// VEX_Vpmovzxdq_xmm_xmmm64
						0x37,// VW_3
							0x6D,// YMM0
							0x4D,// XMM0
							0xDD, 0x16,// VEX_Vpmovzxdq_ymm_xmmm128
					0x00,// Invalid
					0x00,// Invalid

				// 54 = 0x36
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x00,// Invalid
							0x29,// VHW_2
								0x6D,// YMM0
								0xE4, 0x16,// VEX_Vpermd_ymm_ymm_ymmm256
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 55 = 0x37
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xEA, 0x16,// VEX_Vpcmpgtq_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xEB, 0x16,// VEX_Vpcmpgtq_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 56 = 0x38
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xF0, 0x16,// VEX_Vpminsb_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xF1, 0x16,// VEX_Vpminsb_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 57 = 0x39
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xFC, 0x16,// VEX_Vpminsd_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xFD, 0x16,// VEX_Vpminsd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 58 = 0x3A
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0x8B, 0x17,// VEX_Vpminuw_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0x8C, 0x17,// VEX_Vpminuw_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 59 = 0x3B
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0x94, 0x17,// VEX_Vpminud_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0x95, 0x17,// VEX_Vpminud_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 60 = 0x3C
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0x9D, 0x17,// VEX_Vpmaxsb_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0x9E, 0x17,// VEX_Vpmaxsb_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 61 = 0x3D
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xA3, 0x17,// VEX_Vpmaxsd_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xA4, 0x17,// VEX_Vpmaxsd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 62 = 0x3E
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xAC, 0x17,// VEX_Vpmaxuw_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xAD, 0x17,// VEX_Vpmaxuw_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 63 = 0x3F
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xB2, 0x17,// VEX_Vpmaxud_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xB3, 0x17,// VEX_Vpmaxud_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 64 = 0x40
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xBB, 0x17,// VEX_Vpmulld_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xBC, 0x17,// VEX_Vpmulld_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 65 = 0x41
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x36,// VW_2
							0x4D,// XMM0
							0xC4, 0x17,// VEX_Vphminposuw_xmm_xmmm128
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 66 = 0x42
				0x02,// Dup
					0x03,// 3
					0x00,// Invalid

				// 69 = 0x45
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0xD3, 0x17,// VEX_Vpsrlvd_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0xD4, 0x17,// VEX_Vpsrlvd_ymm_ymm_ymmm256
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0xD5, 0x17,// VEX_Vpsrlvq_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0xD6, 0x17,// VEX_Vpsrlvq_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 70 = 0x46
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0xDD, 0x17,// VEX_Vpsravd_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0xDE, 0x17,// VEX_Vpsravd_ymm_ymm_ymmm256
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 71 = 0x47
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0xE5, 0x17,// VEX_Vpsllvd_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0xE6, 0x17,// VEX_Vpsllvd_ymm_ymm_ymmm256
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0xE7, 0x17,// VEX_Vpsllvq_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0xE8, 0x17,// VEX_Vpsllvq_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 72 = 0x48
				0x02,// Dup
					0x10,// 16
					0x00,// Invalid

				// 88 = 0x58
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x37,// VW_3
								0x4D,// XMM0
								0x4D,// XMM0
								0x9C, 0x18,// VEX_Vpbroadcastd_xmm_xmmm32
							0x37,// VW_3
								0x6D,// YMM0
								0x4D,// XMM0
								0x9D, 0x18,// VEX_Vpbroadcastd_ymm_xmmm32
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 89 = 0x59
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x37,// VW_3
								0x4D,// XMM0
								0x4D,// XMM0
								0xA1, 0x18,// VEX_Vpbroadcastq_xmm_xmmm64
							0x37,// VW_3
								0x6D,// YMM0
								0x4D,// XMM0
								0xA2, 0x18,// VEX_Vpbroadcastq_ymm_xmmm64
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 90 = 0x5A
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x00,// Invalid
							0x35,// VM
								0x6D,// YMM0
								0xA9, 0x18,// VEX_Vbroadcasti128_ymm_m128
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 91 = 0x5B
				0x02,// Dup
					0x1D,// 29
					0x00,// Invalid

				// 120 = 0x78
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x37,// VW_3
								0x4D,// XMM0
								0x4D,// XMM0
								0xFE, 0x18,// VEX_Vpbroadcastb_xmm_xmmm8
							0x37,// VW_3
								0x6D,// YMM0
								0x4D,// XMM0
								0xFF, 0x18,// VEX_Vpbroadcastb_ymm_xmmm8
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 121 = 0x79
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x37,// VW_3
								0x4D,// XMM0
								0x4D,// XMM0
								0x83, 0x19,// VEX_Vpbroadcastw_xmm_xmmm16
							0x37,// VW_3
								0x6D,// YMM0
								0x4D,// XMM0
								0x84, 0x19,// VEX_Vpbroadcastw_ymm_xmmm16
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 122 = 0x7A
				0x02,// Dup
					0x12,// 18
					0x00,// Invalid

				// 140 = 0x8C
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x28,// VHM
								0x4D,// XMM0
								0xC7, 0x19,// VEX_Vpmaskmovd_xmm_xmm_m128
							0x28,// VHM
								0x6D,// YMM0
								0xC8, 0x19,// VEX_Vpmaskmovd_ymm_ymm_m256
						0x0E,// VectorLength
							0x28,// VHM
								0x4D,// XMM0
								0xC9, 0x19,// VEX_Vpmaskmovq_xmm_xmm_m128
							0x28,// VHM
								0x6D,// YMM0
								0xCA, 0x19,// VEX_Vpmaskmovq_ymm_ymm_m256
					0x00,// Invalid
					0x00,// Invalid

				// 141 = 0x8D
				0x00,// Invalid

				// 142 = 0x8E
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x1E,// MHV
								0x4D,// XMM0
								0xD1, 0x19,// VEX_Vpmaskmovd_m128_xmm_xmm
							0x1E,// MHV
								0x6D,// YMM0
								0xD2, 0x19,// VEX_Vpmaskmovd_m256_ymm_ymm
						0x0E,// VectorLength
							0x1E,// MHV
								0x4D,// XMM0
								0xD3, 0x19,// VEX_Vpmaskmovq_m128_xmm_xmm
							0x1E,// MHV
								0x6D,// YMM0
								0xD4, 0x19,// VEX_Vpmaskmovq_m256_ymm_ymm
					0x00,// Invalid
					0x00,// Invalid

				// 143 = 0x8F
				0x00,// Invalid

				// 144 = 0x90
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x3C,// VX_VSIB_HX
								0x4D,// XMM0
								0x4D,// XMM0
								0x4D,// XMM0
								0xD8, 0x19,// VEX_Vpgatherdd_xmm_vm32x_xmm
							0x3C,// VX_VSIB_HX
								0x6D,// YMM0
								0x6D,// YMM0
								0x6D,// YMM0
								0xD9, 0x19,// VEX_Vpgatherdd_ymm_vm32y_ymm
						0x0E,// VectorLength
							0x3C,// VX_VSIB_HX
								0x4D,// XMM0
								0x4D,// XMM0
								0x4D,// XMM0
								0xDA, 0x19,// VEX_Vpgatherdq_xmm_vm32x_xmm
							0x3C,// VX_VSIB_HX
								0x6D,// YMM0
								0x4D,// XMM0
								0x6D,// YMM0
								0xDB, 0x19,// VEX_Vpgatherdq_ymm_vm32x_ymm
					0x00,// Invalid
					0x00,// Invalid

				// 145 = 0x91
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x3C,// VX_VSIB_HX
								0x4D,// XMM0
								0x4D,// XMM0
								0x4D,// XMM0
								0xE2, 0x19,// VEX_Vpgatherqd_xmm_vm64x_xmm
							0x3C,// VX_VSIB_HX
								0x4D,// XMM0
								0x6D,// YMM0
								0x4D,// XMM0
								0xE3, 0x19,// VEX_Vpgatherqd_xmm_vm64y_xmm
						0x0E,// VectorLength
							0x3C,// VX_VSIB_HX
								0x4D,// XMM0
								0x4D,// XMM0
								0x4D,// XMM0
								0xE4, 0x19,// VEX_Vpgatherqq_xmm_vm64x_xmm
							0x3C,// VX_VSIB_HX
								0x6D,// YMM0
								0x6D,// YMM0
								0x6D,// YMM0
								0xE5, 0x19,// VEX_Vpgatherqq_ymm_vm64y_ymm
					0x00,// Invalid
					0x00,// Invalid

				// 146 = 0x92
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x3C,// VX_VSIB_HX
								0x4D,// XMM0
								0x4D,// XMM0
								0x4D,// XMM0
								0xEC, 0x19,// VEX_Vgatherdps_xmm_vm32x_xmm
							0x3C,// VX_VSIB_HX
								0x6D,// YMM0
								0x6D,// YMM0
								0x6D,// YMM0
								0xED, 0x19,// VEX_Vgatherdps_ymm_vm32y_ymm
						0x0E,// VectorLength
							0x3C,// VX_VSIB_HX
								0x4D,// XMM0
								0x4D,// XMM0
								0x4D,// XMM0
								0xEE, 0x19,// VEX_Vgatherdpd_xmm_vm32x_xmm
							0x3C,// VX_VSIB_HX
								0x6D,// YMM0
								0x4D,// XMM0
								0x6D,// YMM0
								0xEF, 0x19,// VEX_Vgatherdpd_ymm_vm32x_ymm
					0x00,// Invalid
					0x00,// Invalid

				// 147 = 0x93
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x3C,// VX_VSIB_HX
								0x4D,// XMM0
								0x4D,// XMM0
								0x4D,// XMM0
								0xF6, 0x19,// VEX_Vgatherqps_xmm_vm64x_xmm
							0x3C,// VX_VSIB_HX
								0x4D,// XMM0
								0x6D,// YMM0
								0x4D,// XMM0
								0xF7, 0x19,// VEX_Vgatherqps_xmm_vm64y_xmm
						0x0E,// VectorLength
							0x3C,// VX_VSIB_HX
								0x4D,// XMM0
								0x4D,// XMM0
								0x4D,// XMM0
								0xF8, 0x19,// VEX_Vgatherqpd_xmm_vm64x_xmm
							0x3C,// VX_VSIB_HX
								0x6D,// YMM0
								0x6D,// YMM0
								0x6D,// YMM0
								0xF9, 0x19,// VEX_Vgatherqpd_ymm_vm64y_ymm
					0x00,// Invalid
					0x00,// Invalid

				// 148 = 0x94
				0x01,// Invalid2

				// 150 = 0x96
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0x80, 0x1A,// VEX_Vfmaddsub132ps_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0x81, 0x1A,// VEX_Vfmaddsub132ps_ymm_ymm_ymmm256
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0x82, 0x1A,// VEX_Vfmaddsub132pd_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0x83, 0x1A,// VEX_Vfmaddsub132pd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 151 = 0x97
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0x8A, 0x1A,// VEX_Vfmsubadd132ps_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0x8B, 0x1A,// VEX_Vfmsubadd132ps_ymm_ymm_ymmm256
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0x8C, 0x1A,// VEX_Vfmsubadd132pd_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0x8D, 0x1A,// VEX_Vfmsubadd132pd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 152 = 0x98
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0x94, 0x1A,// VEX_Vfmadd132ps_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0x95, 0x1A,// VEX_Vfmadd132ps_ymm_ymm_ymmm256
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0x96, 0x1A,// VEX_Vfmadd132pd_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0x97, 0x1A,// VEX_Vfmadd132pd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 153 = 0x99
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x29,// VHW_2
							0x4D,// XMM0
							0x9E, 0x1A,// VEX_Vfmadd132ss_xmm_xmm_xmmm32
						0x29,// VHW_2
							0x4D,// XMM0
							0x9F, 0x1A,// VEX_Vfmadd132sd_xmm_xmm_xmmm64
					0x00,// Invalid
					0x00,// Invalid

				// 154 = 0x9A
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0xA2, 0x1A,// VEX_Vfmsub132ps_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0xA3, 0x1A,// VEX_Vfmsub132ps_ymm_ymm_ymmm256
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0xA4, 0x1A,// VEX_Vfmsub132pd_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0xA5, 0x1A,// VEX_Vfmsub132pd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 155 = 0x9B
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x29,// VHW_2
							0x4D,// XMM0
							0xAD, 0x1A,// VEX_Vfmsub132ss_xmm_xmm_xmmm32
						0x29,// VHW_2
							0x4D,// XMM0
							0xAE, 0x1A,// VEX_Vfmsub132sd_xmm_xmm_xmmm64
					0x00,// Invalid
					0x00,// Invalid

				// 156 = 0x9C
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0xB2, 0x1A,// VEX_Vfnmadd132ps_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0xB3, 0x1A,// VEX_Vfnmadd132ps_ymm_ymm_ymmm256
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0xB4, 0x1A,// VEX_Vfnmadd132pd_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0xB5, 0x1A,// VEX_Vfnmadd132pd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 157 = 0x9D
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x29,// VHW_2
							0x4D,// XMM0
							0xBC, 0x1A,// VEX_Vfnmadd132ss_xmm_xmm_xmmm32
						0x29,// VHW_2
							0x4D,// XMM0
							0xBD, 0x1A,// VEX_Vfnmadd132sd_xmm_xmm_xmmm64
					0x00,// Invalid
					0x00,// Invalid

				// 158 = 0x9E
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0xC0, 0x1A,// VEX_Vfnmsub132ps_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0xC1, 0x1A,// VEX_Vfnmsub132ps_ymm_ymm_ymmm256
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0xC2, 0x1A,// VEX_Vfnmsub132pd_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0xC3, 0x1A,// VEX_Vfnmsub132pd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 159 = 0x9F
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x29,// VHW_2
							0x4D,// XMM0
							0xCA, 0x1A,// VEX_Vfnmsub132ss_xmm_xmm_xmmm32
						0x29,// VHW_2
							0x4D,// XMM0
							0xCB, 0x1A,// VEX_Vfnmsub132sd_xmm_xmm_xmmm64
					0x00,// Invalid
					0x00,// Invalid

				// 160 = 0xA0
				0x02,// Dup
					0x06,// 6
					0x00,// Invalid

				// 166 = 0xA6
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0xE6, 0x1A,// VEX_Vfmaddsub213ps_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0xE7, 0x1A,// VEX_Vfmaddsub213ps_ymm_ymm_ymmm256
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0xE8, 0x1A,// VEX_Vfmaddsub213pd_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0xE9, 0x1A,// VEX_Vfmaddsub213pd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 167 = 0xA7
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0xF0, 0x1A,// VEX_Vfmsubadd213ps_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0xF1, 0x1A,// VEX_Vfmsubadd213ps_ymm_ymm_ymmm256
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0xF2, 0x1A,// VEX_Vfmsubadd213pd_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0xF3, 0x1A,// VEX_Vfmsubadd213pd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 168 = 0xA8
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0xFA, 0x1A,// VEX_Vfmadd213ps_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0xFB, 0x1A,// VEX_Vfmadd213ps_ymm_ymm_ymmm256
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0xFC, 0x1A,// VEX_Vfmadd213pd_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0xFD, 0x1A,// VEX_Vfmadd213pd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 169 = 0xA9
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x29,// VHW_2
							0x4D,// XMM0
							0x84, 0x1B,// VEX_Vfmadd213ss_xmm_xmm_xmmm32
						0x29,// VHW_2
							0x4D,// XMM0
							0x85, 0x1B,// VEX_Vfmadd213sd_xmm_xmm_xmmm64
					0x00,// Invalid
					0x00,// Invalid

				// 170 = 0xAA
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0x88, 0x1B,// VEX_Vfmsub213ps_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0x89, 0x1B,// VEX_Vfmsub213ps_ymm_ymm_ymmm256
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0x8A, 0x1B,// VEX_Vfmsub213pd_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0x8B, 0x1B,// VEX_Vfmsub213pd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 171 = 0xAB
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x29,// VHW_2
							0x4D,// XMM0
							0x93, 0x1B,// VEX_Vfmsub213ss_xmm_xmm_xmmm32
						0x29,// VHW_2
							0x4D,// XMM0
							0x94, 0x1B,// VEX_Vfmsub213sd_xmm_xmm_xmmm64
					0x00,// Invalid
					0x00,// Invalid

				// 172 = 0xAC
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0x98, 0x1B,// VEX_Vfnmadd213ps_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0x99, 0x1B,// VEX_Vfnmadd213ps_ymm_ymm_ymmm256
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0x9A, 0x1B,// VEX_Vfnmadd213pd_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0x9B, 0x1B,// VEX_Vfnmadd213pd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 173 = 0xAD
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x29,// VHW_2
							0x4D,// XMM0
							0xA2, 0x1B,// VEX_Vfnmadd213ss_xmm_xmm_xmmm32
						0x29,// VHW_2
							0x4D,// XMM0
							0xA3, 0x1B,// VEX_Vfnmadd213sd_xmm_xmm_xmmm64
					0x00,// Invalid
					0x00,// Invalid

				// 174 = 0xAE
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0xA6, 0x1B,// VEX_Vfnmsub213ps_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0xA7, 0x1B,// VEX_Vfnmsub213ps_ymm_ymm_ymmm256
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0xA8, 0x1B,// VEX_Vfnmsub213pd_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0xA9, 0x1B,// VEX_Vfnmsub213pd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 175 = 0xAF
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x29,// VHW_2
							0x4D,// XMM0
							0xB0, 0x1B,// VEX_Vfnmsub213ss_xmm_xmm_xmmm32
						0x29,// VHW_2
							0x4D,// XMM0
							0xB1, 0x1B,// VEX_Vfnmsub213sd_xmm_xmm_xmmm64
					0x00,// Invalid
					0x00,// Invalid

				// 176 = 0xB0
				0x02,// Dup
					0x06,// 6
					0x00,// Invalid

				// 182 = 0xB6
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0xBA, 0x1B,// VEX_Vfmaddsub231ps_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0xBB, 0x1B,// VEX_Vfmaddsub231ps_ymm_ymm_ymmm256
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0xBC, 0x1B,// VEX_Vfmaddsub231pd_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0xBD, 0x1B,// VEX_Vfmaddsub231pd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 183 = 0xB7
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0xC4, 0x1B,// VEX_Vfmsubadd231ps_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0xC5, 0x1B,// VEX_Vfmsubadd231ps_ymm_ymm_ymmm256
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0xC6, 0x1B,// VEX_Vfmsubadd231pd_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0xC7, 0x1B,// VEX_Vfmsubadd231pd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 184 = 0xB8
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0xCE, 0x1B,// VEX_Vfmadd231ps_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0xCF, 0x1B,// VEX_Vfmadd231ps_ymm_ymm_ymmm256
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0xD0, 0x1B,// VEX_Vfmadd231pd_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0xD1, 0x1B,// VEX_Vfmadd231pd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 185 = 0xB9
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x29,// VHW_2
							0x4D,// XMM0
							0xD8, 0x1B,// VEX_Vfmadd231ss_xmm_xmm_xmmm32
						0x29,// VHW_2
							0x4D,// XMM0
							0xD9, 0x1B,// VEX_Vfmadd231sd_xmm_xmm_xmmm64
					0x00,// Invalid
					0x00,// Invalid

				// 186 = 0xBA
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0xDC, 0x1B,// VEX_Vfmsub231ps_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0xDD, 0x1B,// VEX_Vfmsub231ps_ymm_ymm_ymmm256
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0xDE, 0x1B,// VEX_Vfmsub231pd_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0xDF, 0x1B,// VEX_Vfmsub231pd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 187 = 0xBB
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x29,// VHW_2
							0x4D,// XMM0
							0xE6, 0x1B,// VEX_Vfmsub231ss_xmm_xmm_xmmm32
						0x29,// VHW_2
							0x4D,// XMM0
							0xE7, 0x1B,// VEX_Vfmsub231sd_xmm_xmm_xmmm64
					0x00,// Invalid
					0x00,// Invalid

				// 188 = 0xBC
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0xEA, 0x1B,// VEX_Vfnmadd231ps_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0xEB, 0x1B,// VEX_Vfnmadd231ps_ymm_ymm_ymmm256
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0xEC, 0x1B,// VEX_Vfnmadd231pd_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0xED, 0x1B,// VEX_Vfnmadd231pd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 189 = 0xBD
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x29,// VHW_2
							0x4D,// XMM0
							0xF4, 0x1B,// VEX_Vfnmadd231ss_xmm_xmm_xmmm32
						0x29,// VHW_2
							0x4D,// XMM0
							0xF5, 0x1B,// VEX_Vfnmadd231sd_xmm_xmm_xmmm64
					0x00,// Invalid
					0x00,// Invalid

				// 190 = 0xBE
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0xF8, 0x1B,// VEX_Vfnmsub231ps_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0xF9, 0x1B,// VEX_Vfnmsub231ps_ymm_ymm_ymmm256
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0xFA, 0x1B,// VEX_Vfnmsub231pd_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0xFB, 0x1B,// VEX_Vfnmsub231pd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 191 = 0xBF
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x29,// VHW_2
							0x4D,// XMM0
							0x82, 0x1C,// VEX_Vfnmsub231ss_xmm_xmm_xmmm32
						0x29,// VHW_2
							0x4D,// XMM0
							0x83, 0x1C,// VEX_Vfnmsub231sd_xmm_xmm_xmmm64
					0x00,// Invalid
					0x00,// Invalid

				// 192 = 0xC0
				0x02,// Dup
					0x0F,// 15
					0x00,// Invalid

				// 207 = 0xCF
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x29,// VHW_2
								0x4D,// XMM0
								0xAD, 0x1C,// VEX_Vgf2p8mulb_xmm_xmm_xmmm128
							0x29,// VHW_2
								0x6D,// YMM0
								0xAE, 0x1C,// VEX_Vgf2p8mulb_ymm_ymm_ymmm256
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 208 = 0xD0
				0x02,// Dup
					0x0B,// 11
					0x00,// Invalid

				// 219 = 0xDB
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x36,// VW_2
							0x4D,// XMM0
							0xB3, 0x1C,// VEX_Vaesimc_xmm_xmmm128
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 220 = 0xDC
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xB5, 0x1C,// VEX_Vaesenc_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xB6, 0x1C,// VEX_Vaesenc_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 221 = 0xDD
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xBB, 0x1C,// VEX_Vaesenclast_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xBC, 0x1C,// VEX_Vaesenclast_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 222 = 0xDE
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xC1, 0x1C,// VEX_Vaesdec_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xC2, 0x1C,// VEX_Vaesdec_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 223 = 0xDF
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xC7, 0x1C,// VEX_Vaesdeclast_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xC8, 0x1C,// VEX_Vaesdeclast_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 224 = 0xE0
				0x02,// Dup
					0x12,// 18
					0x00,// Invalid

				// 242 = 0xF2
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x16,// Gv_Gv_Ev
							0xD7, 0x1C,// VEX_Andn_r32_r32_rm32
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 243 = 0xF3
				0x08,// Group
					0x06,// ArrayReference
						0x04,// 0x4 = handlers_Grp_0F38F3

				// 244 = 0xF4
				0x00,// Invalid

				// 245 = 0xF5
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x12,// Gv_Ev_Gv
							0xDF, 0x1C,// VEX_Bzhi_r32_rm32_r32
						0x00,// Invalid
					0x00,// Invalid
					0x0E,// VectorLength
						0x16,// Gv_Gv_Ev
							0xE3, 0x1C,// VEX_Pext_r32_r32_rm32
						0x00,// Invalid
					0x0E,// VectorLength
						0x16,// Gv_Gv_Ev
							0xE5, 0x1C,// VEX_Pdep_r32_r32_rm32
						0x00,// Invalid

				// 246 = 0xF6
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid
					0x0E,// VectorLength
						0x16,// Gv_Gv_Ev
							0xED, 0x1C,// VEX_Mulx_r32_r32_rm32
						0x00,// Invalid

				// 247 = 0xF7
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x12,// Gv_Ev_Gv
							0xEF, 0x1C,// VEX_Bextr_r32_rm32_r32
						0x00,// Invalid
					0x0E,// VectorLength
						0x12,// Gv_Ev_Gv
							0xF1, 0x1C,// VEX_Shlx_r32_rm32_r32
						0x00,// Invalid
					0x0E,// VectorLength
						0x12,// Gv_Ev_Gv
							0xF3, 0x1C,// VEX_Sarx_r32_rm32_r32
						0x00,// Invalid
					0x0E,// VectorLength
						0x12,// Gv_Ev_Gv
							0xF5, 0x1C,// VEX_Shrx_r32_rm32_r32
						0x00,// Invalid

				// 248 = 0xF8
				0x02,// Dup
					0x08,// 8
					0x00,// Invalid

				// ThreeByteHandlers_0F3AXX
				0x01,// ArrayReference
				0x80, 0x02,// 0x100
				// 0 = 0x00
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x00,// Invalid
						0x0E,// VectorLength
							0x00,// Invalid
							0x39,// VWIb_2
								0x6D,// YMM0
								0x82, 0x1D,// VEX_Vpermq_ymm_ymmm256_imm8
					0x00,// Invalid
					0x00,// Invalid

				// 1 = 0x01
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x00,// Invalid
						0x0E,// VectorLength
							0x00,// Invalid
							0x39,// VWIb_2
								0x6D,// YMM0
								0x85, 0x1D,// VEX_Vpermpd_ymm_ymmm256_imm8
					0x00,// Invalid
					0x00,// Invalid

				// 2 = 0x02
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x2C,// VHWIb_2
								0x4D,// XMM0
								0x88, 0x1D,// VEX_Vpblendd_xmm_xmm_xmmm128_imm8
							0x2C,// VHWIb_2
								0x6D,// YMM0
								0x89, 0x1D,// VEX_Vpblendd_ymm_ymm_ymmm256_imm8
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 3 = 0x03
				0x00,// Invalid

				// 4 = 0x04
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x39,// VWIb_2
								0x4D,// XMM0
								0x90, 0x1D,// VEX_Vpermilps_xmm_xmmm128_imm8
							0x39,// VWIb_2
								0x6D,// YMM0
								0x91, 0x1D,// VEX_Vpermilps_ymm_ymmm256_imm8
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 5 = 0x05
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x39,// VWIb_2
								0x4D,// XMM0
								0x95, 0x1D,// VEX_Vpermilpd_xmm_xmmm128_imm8
							0x39,// VWIb_2
								0x6D,// YMM0
								0x96, 0x1D,// VEX_Vpermilpd_ymm_ymmm256_imm8
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 6 = 0x06
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x00,// Invalid
							0x2C,// VHWIb_2
								0x6D,// YMM0
								0x9A, 0x1D,// VEX_Vperm2f128_ymm_ymm_ymmm256_imm8
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 7 = 0x07
				0x00,// Invalid

				// 8 = 0x08
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x39,// VWIb_2
							0x4D,// XMM0
							0x9C, 0x1D,// VEX_Vroundps_xmm_xmmm128_imm8
						0x39,// VWIb_2
							0x6D,// YMM0
							0x9D, 0x1D,// VEX_Vroundps_ymm_ymmm256_imm8
					0x00,// Invalid
					0x00,// Invalid

				// 9 = 0x09
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x39,// VWIb_2
							0x4D,// XMM0
							0xA2, 0x1D,// VEX_Vroundpd_xmm_xmmm128_imm8
						0x39,// VWIb_2
							0x6D,// YMM0
							0xA3, 0x1D,// VEX_Vroundpd_ymm_ymmm256_imm8
					0x00,// Invalid
					0x00,// Invalid

				// 10 = 0x0A
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x2C,// VHWIb_2
						0x4D,// XMM0
						0xA8, 0x1D,// VEX_Vroundss_xmm_xmm_xmmm32_imm8
					0x00,// Invalid
					0x00,// Invalid

				// 11 = 0x0B
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x2C,// VHWIb_2
						0x4D,// XMM0
						0xAB, 0x1D,// VEX_Vroundsd_xmm_xmm_xmmm64_imm8
					0x00,// Invalid
					0x00,// Invalid

				// 12 = 0x0C
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x2C,// VHWIb_2
							0x4D,// XMM0
							0xAE, 0x1D,// VEX_Vblendps_xmm_xmm_xmmm128_imm8
						0x2C,// VHWIb_2
							0x6D,// YMM0
							0xAF, 0x1D,// VEX_Vblendps_ymm_ymm_ymmm256_imm8
					0x00,// Invalid
					0x00,// Invalid

				// 13 = 0x0D
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x2C,// VHWIb_2
							0x4D,// XMM0
							0xB1, 0x1D,// VEX_Vblendpd_xmm_xmm_xmmm128_imm8
						0x2C,// VHWIb_2
							0x6D,// YMM0
							0xB2, 0x1D,// VEX_Vblendpd_ymm_ymm_ymmm256_imm8
					0x00,// Invalid
					0x00,// Invalid

				// 14 = 0x0E
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x2C,// VHWIb_2
							0x4D,// XMM0
							0xB4, 0x1D,// VEX_Vpblendw_xmm_xmm_xmmm128_imm8
						0x2C,// VHWIb_2
							0x6D,// YMM0
							0xB5, 0x1D,// VEX_Vpblendw_ymm_ymm_ymmm256_imm8
					0x00,// Invalid
					0x00,// Invalid

				// 15 = 0x0F
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x2C,// VHWIb_2
							0x4D,// XMM0
							0xB8, 0x1D,// VEX_Vpalignr_xmm_xmm_xmmm128_imm8
						0x2C,// VHWIb_2
							0x6D,// YMM0
							0xB9, 0x1D,// VEX_Vpalignr_ymm_ymm_ymmm256_imm8
					0x00,// Invalid
					0x00,// Invalid

				// 16 = 0x10
				0x02,// Dup
					0x04,// 4
					0x00,// Invalid

				// 20 = 0x14
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x19,// GvM_VX_Ib
							0x4D,// XMM0
							0xBF, 0x1D,// VEX_Vpextrb_r32m8_xmm_imm8
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 21 = 0x15
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x19,// GvM_VX_Ib
							0x4D,// XMM0
							0xC5, 0x1D,// VEX_Vpextrw_r32m16_xmm_imm8
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 22 = 0x16
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x19,// GvM_VX_Ib
							0x4D,// XMM0
							0xCB, 0x1D,// VEX_Vpextrd_rm32_xmm_imm8
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 23 = 0x17
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x0F,// Ed_V_Ib
							0x4D,// XMM0
							0xD1, 0x1D,// VEX_Vextractps_rm32_xmm_imm8
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 24 = 0x18
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x00,// Invalid
							0x2D,// VHWIb_4
								0x6D,// YMM0
								0x6D,// YMM0
								0x4D,// XMM0
								0xD5, 0x1D,// VEX_Vinsertf128_ymm_ymm_xmmm128_imm8
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 25 = 0x19
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x00,// Invalid
							0x3F,// WVIb
								0x4D,// XMM0
								0x6D,// YMM0
								0xDA, 0x1D,// VEX_Vextractf128_xmmm128_ymm_imm8
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 26 = 0x1A
				0x02,// Dup
					0x03,// 3
					0x00,// Invalid

				// 29 = 0x1D
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x3F,// WVIb
								0x4D,// XMM0
								0x4D,// XMM0
								0xE3, 0x1D,// VEX_Vcvtps2ph_xmmm64_xmm_imm8
							0x3F,// WVIb
								0x4D,// XMM0
								0x6D,// YMM0
								0xE4, 0x1D,// VEX_Vcvtps2ph_xmmm128_ymm_imm8
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 30 = 0x1E
				0x01,// Invalid2

				// 32 = 0x20
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x25,// VHEvIb
							0x4D,// XMM0
							0xF6, 0x1D,// VEX_Vpinsrb_xmm_xmm_r32m8_imm8
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 33 = 0x21
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x2C,// VHWIb_2
							0x4D,// XMM0
							0xFB, 0x1D,// VEX_Vinsertps_xmm_xmm_xmmm32_imm8
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 34 = 0x22
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x25,// VHEvIb
							0x4D,// XMM0
							0xFF, 0x1D,// VEX_Vpinsrd_xmm_xmm_rm32_imm8
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 35 = 0x23
				0x02,// Dup
					0x0D,// 13
					0x00,// Invalid

				// 48 = 0x30
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x09,// W
							0x33,// VK_RK_Ib
								0x95, 0x1E,// VEX_Kshiftrb_k_k_imm8
							0x33,// VK_RK_Ib
								0x96, 0x1E,// VEX_Kshiftrw_k_k_imm8
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 49 = 0x31
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x09,// W
							0x33,// VK_RK_Ib
								0x97, 0x1E,// VEX_Kshiftrd_k_k_imm8
							0x33,// VK_RK_Ib
								0x98, 0x1E,// VEX_Kshiftrq_k_k_imm8
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 50 = 0x32
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x09,// W
							0x33,// VK_RK_Ib
								0x99, 0x1E,// VEX_Kshiftlb_k_k_imm8
							0x33,// VK_RK_Ib
								0x9A, 0x1E,// VEX_Kshiftlw_k_k_imm8
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 51 = 0x33
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x09,// W
							0x33,// VK_RK_Ib
								0x9B, 0x1E,// VEX_Kshiftld_k_k_imm8
							0x33,// VK_RK_Ib
								0x9C, 0x1E,// VEX_Kshiftlq_k_k_imm8
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 52 = 0x34
				0x02,// Dup
					0x04,// 4
					0x00,// Invalid

				// 56 = 0x38
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x00,// Invalid
							0x2D,// VHWIb_4
								0x6D,// YMM0
								0x6D,// YMM0
								0x4D,// XMM0
								0x9D, 0x1E,// VEX_Vinserti128_ymm_ymm_xmmm128_imm8
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 57 = 0x39
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x00,// Invalid
							0x3F,// WVIb
								0x4D,// XMM0
								0x6D,// YMM0
								0xA2, 0x1E,// VEX_Vextracti128_xmmm128_ymm_imm8
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 58 = 0x3A
				0x02,// Dup
					0x06,// 6
					0x00,// Invalid

				// 64 = 0x40
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x2C,// VHWIb_2
							0x4D,// XMM0
							0xB8, 0x1E,// VEX_Vdpps_xmm_xmm_xmmm128_imm8
						0x2C,// VHWIb_2
							0x6D,// YMM0
							0xB9, 0x1E,// VEX_Vdpps_ymm_ymm_ymmm256_imm8
					0x00,// Invalid
					0x00,// Invalid

				// 65 = 0x41
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x2C,// VHWIb_2
							0x4D,// XMM0
							0xBB, 0x1E,// VEX_Vdppd_xmm_xmm_xmmm128_imm8
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 66 = 0x42
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x2C,// VHWIb_2
							0x4D,// XMM0
							0xBD, 0x1E,// VEX_Vmpsadbw_xmm_xmm_xmmm128_imm8
						0x2C,// VHWIb_2
							0x6D,// YMM0
							0xBE, 0x1E,// VEX_Vmpsadbw_ymm_ymm_ymmm256_imm8
					0x00,// Invalid
					0x00,// Invalid

				// 67 = 0x43
				0x00,// Invalid

				// 68 = 0x44
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x2C,// VHWIb_2
							0x4D,// XMM0
							0xC7, 0x1E,// VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8
						0x2C,// VHWIb_2
							0x6D,// YMM0
							0xC8, 0x1E,// VEX_Vpclmulqdq_ymm_ymm_ymmm256_imm8
					0x00,// Invalid
					0x00,// Invalid

				// 69 = 0x45
				0x00,// Invalid

				// 70 = 0x46
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x00,// Invalid
							0x2C,// VHWIb_2
								0x6D,// YMM0
								0xCC, 0x1E,// VEX_Vperm2i128_ymm_ymm_ymmm256_imm8
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 71 = 0x47
				0x00,// Invalid

				// 72 = 0x48
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x2F,// VHWIs5
								0x4D,// XMM0
								0xCD, 0x1E,// VEX_Vpermil2ps_xmm_xmm_xmmm128_xmm_imm2
							0x2F,// VHWIs5
								0x6D,// YMM0
								0xCE, 0x1E,// VEX_Vpermil2ps_ymm_ymm_ymmm256_ymm_imm2
						0x0E,// VectorLength
							0x27,// VHIs5W
								0x4D,// XMM0
								0xCF, 0x1E,// VEX_Vpermil2ps_xmm_xmm_xmm_xmmm128_imm2
							0x27,// VHIs5W
								0x6D,// YMM0
								0xD0, 0x1E,// VEX_Vpermil2ps_ymm_ymm_ymm_ymmm256_imm2
					0x00,// Invalid
					0x00,// Invalid

				// 73 = 0x49
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x2F,// VHWIs5
								0x4D,// XMM0
								0xD1, 0x1E,// VEX_Vpermil2pd_xmm_xmm_xmmm128_xmm_imm2
							0x2F,// VHWIs5
								0x6D,// YMM0
								0xD2, 0x1E,// VEX_Vpermil2pd_ymm_ymm_ymmm256_ymm_imm2
						0x0E,// VectorLength
							0x27,// VHIs5W
								0x4D,// XMM0
								0xD3, 0x1E,// VEX_Vpermil2pd_xmm_xmm_xmm_xmmm128_imm2
							0x27,// VHIs5W
								0x6D,// YMM0
								0xD4, 0x1E,// VEX_Vpermil2pd_ymm_ymm_ymm_ymmm256_imm2
					0x00,// Invalid
					0x00,// Invalid

				// 74 = 0x4A
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xD5, 0x1E,// VEX_Vblendvps_xmm_xmm_xmmm128_xmm
							0x2E,// VHWIs4
								0x6D,// YMM0
								0xD6, 0x1E,// VEX_Vblendvps_ymm_ymm_ymmm256_ymm
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 75 = 0x4B
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xD7, 0x1E,// VEX_Vblendvpd_xmm_xmm_xmmm128_xmm
							0x2E,// VHWIs4
								0x6D,// YMM0
								0xD8, 0x1E,// VEX_Vblendvpd_ymm_ymm_ymmm256_ymm
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 76 = 0x4C
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xD9, 0x1E,// VEX_Vpblendvb_xmm_xmm_xmmm128_xmm
							0x2E,// VHWIs4
								0x6D,// YMM0
								0xDA, 0x1E,// VEX_Vpblendvb_ymm_ymm_ymmm256_ymm
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 77 = 0x4D
				0x02,// Dup
					0x0F,// 15
					0x00,// Invalid

				// 92 = 0x5C
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xF3, 0x1E,// VEX_Vfmaddsubps_xmm_xmm_xmmm128_xmm
							0x2E,// VHWIs4
								0x6D,// YMM0
								0xF4, 0x1E,// VEX_Vfmaddsubps_ymm_ymm_ymmm256_ymm
						0x0E,// VectorLength
							0x26,// VHIs4W
								0x4D,// XMM0
								0xF5, 0x1E,// VEX_Vfmaddsubps_xmm_xmm_xmm_xmmm128
							0x26,// VHIs4W
								0x6D,// YMM0
								0xF6, 0x1E,// VEX_Vfmaddsubps_ymm_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 93 = 0x5D
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xF7, 0x1E,// VEX_Vfmaddsubpd_xmm_xmm_xmmm128_xmm
							0x2E,// VHWIs4
								0x6D,// YMM0
								0xF8, 0x1E,// VEX_Vfmaddsubpd_ymm_ymm_ymmm256_ymm
						0x0E,// VectorLength
							0x26,// VHIs4W
								0x4D,// XMM0
								0xF9, 0x1E,// VEX_Vfmaddsubpd_xmm_xmm_xmm_xmmm128
							0x26,// VHIs4W
								0x6D,// YMM0
								0xFA, 0x1E,// VEX_Vfmaddsubpd_ymm_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 94 = 0x5E
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xFB, 0x1E,// VEX_Vfmsubaddps_xmm_xmm_xmmm128_xmm
							0x2E,// VHWIs4
								0x6D,// YMM0
								0xFC, 0x1E,// VEX_Vfmsubaddps_ymm_ymm_ymmm256_ymm
						0x0E,// VectorLength
							0x26,// VHIs4W
								0x4D,// XMM0
								0xFD, 0x1E,// VEX_Vfmsubaddps_xmm_xmm_xmm_xmmm128
							0x26,// VHIs4W
								0x6D,// YMM0
								0xFE, 0x1E,// VEX_Vfmsubaddps_ymm_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 95 = 0x5F
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xFF, 0x1E,// VEX_Vfmsubaddpd_xmm_xmm_xmmm128_xmm
							0x2E,// VHWIs4
								0x6D,// YMM0
								0x80, 0x1F,// VEX_Vfmsubaddpd_ymm_ymm_ymmm256_ymm
						0x0E,// VectorLength
							0x26,// VHIs4W
								0x4D,// XMM0
								0x81, 0x1F,// VEX_Vfmsubaddpd_xmm_xmm_xmm_xmmm128
							0x26,// VHIs4W
								0x6D,// YMM0
								0x82, 0x1F,// VEX_Vfmsubaddpd_ymm_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 96 = 0x60
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x3A,// VWIb_3
							0x4D,// XMM0
							0x85, 0x1F,// VEX_Vpcmpestrm_xmm_xmmm128_imm8
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 97 = 0x61
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x3A,// VWIb_3
							0x4D,// XMM0
							0x89, 0x1F,// VEX_Vpcmpestri_xmm_xmmm128_imm8
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 98 = 0x62
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x39,// VWIb_2
							0x4D,// XMM0
							0x8C, 0x1F,// VEX_Vpcmpistrm_xmm_xmmm128_imm8
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 99 = 0x63
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x39,// VWIb_2
							0x4D,// XMM0
							0x8E, 0x1F,// VEX_Vpcmpistri_xmm_xmmm128_imm8
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 100 = 0x64
				0x02,// Dup
					0x04,// 4
					0x00,// Invalid

				// 104 = 0x68
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x2E,// VHWIs4
								0x4D,// XMM0
								0x97, 0x1F,// VEX_Vfmaddps_xmm_xmm_xmmm128_xmm
							0x2E,// VHWIs4
								0x6D,// YMM0
								0x98, 0x1F,// VEX_Vfmaddps_ymm_ymm_ymmm256_ymm
						0x0E,// VectorLength
							0x26,// VHIs4W
								0x4D,// XMM0
								0x99, 0x1F,// VEX_Vfmaddps_xmm_xmm_xmm_xmmm128
							0x26,// VHIs4W
								0x6D,// YMM0
								0x9A, 0x1F,// VEX_Vfmaddps_ymm_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 105 = 0x69
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x2E,// VHWIs4
								0x4D,// XMM0
								0x9B, 0x1F,// VEX_Vfmaddpd_xmm_xmm_xmmm128_xmm
							0x2E,// VHWIs4
								0x6D,// YMM0
								0x9C, 0x1F,// VEX_Vfmaddpd_ymm_ymm_ymmm256_ymm
						0x0E,// VectorLength
							0x26,// VHIs4W
								0x4D,// XMM0
								0x9D, 0x1F,// VEX_Vfmaddpd_xmm_xmm_xmm_xmmm128
							0x26,// VHIs4W
								0x6D,// YMM0
								0x9E, 0x1F,// VEX_Vfmaddpd_ymm_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 106 = 0x6A
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x2E,// VHWIs4
							0x4D,// XMM0
							0x9F, 0x1F,// VEX_Vfmaddss_xmm_xmm_xmmm32_xmm
						0x26,// VHIs4W
							0x4D,// XMM0
							0xA0, 0x1F,// VEX_Vfmaddss_xmm_xmm_xmm_xmmm32
					0x00,// Invalid
					0x00,// Invalid

				// 107 = 0x6B
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x2E,// VHWIs4
							0x4D,// XMM0
							0xA1, 0x1F,// VEX_Vfmaddsd_xmm_xmm_xmmm64_xmm
						0x26,// VHIs4W
							0x4D,// XMM0
							0xA2, 0x1F,// VEX_Vfmaddsd_xmm_xmm_xmm_xmmm64
					0x00,// Invalid
					0x00,// Invalid

				// 108 = 0x6C
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xA3, 0x1F,// VEX_Vfmsubps_xmm_xmm_xmmm128_xmm
							0x2E,// VHWIs4
								0x6D,// YMM0
								0xA4, 0x1F,// VEX_Vfmsubps_ymm_ymm_ymmm256_ymm
						0x0E,// VectorLength
							0x26,// VHIs4W
								0x4D,// XMM0
								0xA5, 0x1F,// VEX_Vfmsubps_xmm_xmm_xmm_xmmm128
							0x26,// VHIs4W
								0x6D,// YMM0
								0xA6, 0x1F,// VEX_Vfmsubps_ymm_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 109 = 0x6D
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xA7, 0x1F,// VEX_Vfmsubpd_xmm_xmm_xmmm128_xmm
							0x2E,// VHWIs4
								0x6D,// YMM0
								0xA8, 0x1F,// VEX_Vfmsubpd_ymm_ymm_ymmm256_ymm
						0x0E,// VectorLength
							0x26,// VHIs4W
								0x4D,// XMM0
								0xA9, 0x1F,// VEX_Vfmsubpd_xmm_xmm_xmm_xmmm128
							0x26,// VHIs4W
								0x6D,// YMM0
								0xAA, 0x1F,// VEX_Vfmsubpd_ymm_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 110 = 0x6E
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x2E,// VHWIs4
							0x4D,// XMM0
							0xAB, 0x1F,// VEX_Vfmsubss_xmm_xmm_xmmm32_xmm
						0x26,// VHIs4W
							0x4D,// XMM0
							0xAC, 0x1F,// VEX_Vfmsubss_xmm_xmm_xmm_xmmm32
					0x00,// Invalid
					0x00,// Invalid

				// 111 = 0x6F
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x2E,// VHWIs4
							0x4D,// XMM0
							0xAD, 0x1F,// VEX_Vfmsubsd_xmm_xmm_xmmm64_xmm
						0x26,// VHIs4W
							0x4D,// XMM0
							0xAE, 0x1F,// VEX_Vfmsubsd_xmm_xmm_xmm_xmmm64
					0x00,// Invalid
					0x00,// Invalid

				// 112 = 0x70
				0x02,// Dup
					0x08,// 8
					0x00,// Invalid

				// 120 = 0x78
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xC1, 0x1F,// VEX_Vfnmaddps_xmm_xmm_xmmm128_xmm
							0x2E,// VHWIs4
								0x6D,// YMM0
								0xC2, 0x1F,// VEX_Vfnmaddps_ymm_ymm_ymmm256_ymm
						0x0E,// VectorLength
							0x26,// VHIs4W
								0x4D,// XMM0
								0xC3, 0x1F,// VEX_Vfnmaddps_xmm_xmm_xmm_xmmm128
							0x26,// VHIs4W
								0x6D,// YMM0
								0xC4, 0x1F,// VEX_Vfnmaddps_ymm_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 121 = 0x79
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xC5, 0x1F,// VEX_Vfnmaddpd_xmm_xmm_xmmm128_xmm
							0x2E,// VHWIs4
								0x6D,// YMM0
								0xC6, 0x1F,// VEX_Vfnmaddpd_ymm_ymm_ymmm256_ymm
						0x0E,// VectorLength
							0x26,// VHIs4W
								0x4D,// XMM0
								0xC7, 0x1F,// VEX_Vfnmaddpd_xmm_xmm_xmm_xmmm128
							0x26,// VHIs4W
								0x6D,// YMM0
								0xC8, 0x1F,// VEX_Vfnmaddpd_ymm_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 122 = 0x7A
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x2E,// VHWIs4
							0x4D,// XMM0
							0xC9, 0x1F,// VEX_Vfnmaddss_xmm_xmm_xmmm32_xmm
						0x26,// VHIs4W
							0x4D,// XMM0
							0xCA, 0x1F,// VEX_Vfnmaddss_xmm_xmm_xmm_xmmm32
					0x00,// Invalid
					0x00,// Invalid

				// 123 = 0x7B
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x2E,// VHWIs4
							0x4D,// XMM0
							0xCB, 0x1F,// VEX_Vfnmaddsd_xmm_xmm_xmmm64_xmm
						0x26,// VHIs4W
							0x4D,// XMM0
							0xCC, 0x1F,// VEX_Vfnmaddsd_xmm_xmm_xmm_xmmm64
					0x00,// Invalid
					0x00,// Invalid

				// 124 = 0x7C
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xCD, 0x1F,// VEX_Vfnmsubps_xmm_xmm_xmmm128_xmm
							0x2E,// VHWIs4
								0x6D,// YMM0
								0xCE, 0x1F,// VEX_Vfnmsubps_ymm_ymm_ymmm256_ymm
						0x0E,// VectorLength
							0x26,// VHIs4W
								0x4D,// XMM0
								0xCF, 0x1F,// VEX_Vfnmsubps_xmm_xmm_xmm_xmmm128
							0x26,// VHIs4W
								0x6D,// YMM0
								0xD0, 0x1F,// VEX_Vfnmsubps_ymm_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 125 = 0x7D
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x0E,// VectorLength
							0x2E,// VHWIs4
								0x4D,// XMM0
								0xD1, 0x1F,// VEX_Vfnmsubpd_xmm_xmm_xmmm128_xmm
							0x2E,// VHWIs4
								0x6D,// YMM0
								0xD2, 0x1F,// VEX_Vfnmsubpd_ymm_ymm_ymmm256_ymm
						0x0E,// VectorLength
							0x26,// VHIs4W
								0x4D,// XMM0
								0xD3, 0x1F,// VEX_Vfnmsubpd_xmm_xmm_xmm_xmmm128
							0x26,// VHIs4W
								0x6D,// YMM0
								0xD4, 0x1F,// VEX_Vfnmsubpd_ymm_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 126 = 0x7E
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x2E,// VHWIs4
							0x4D,// XMM0
							0xD5, 0x1F,// VEX_Vfnmsubss_xmm_xmm_xmmm32_xmm
						0x26,// VHIs4W
							0x4D,// XMM0
							0xD6, 0x1F,// VEX_Vfnmsubss_xmm_xmm_xmm_xmmm32
					0x00,// Invalid
					0x00,// Invalid

				// 127 = 0x7F
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x2E,// VHWIs4
							0x4D,// XMM0
							0xD7, 0x1F,// VEX_Vfnmsubsd_xmm_xmm_xmmm64_xmm
						0x26,// VHIs4W
							0x4D,// XMM0
							0xD8, 0x1F,// VEX_Vfnmsubsd_xmm_xmm_xmm_xmmm64
					0x00,// Invalid
					0x00,// Invalid

				// 128 = 0x80
				0x02,// Dup
					0x4E,// 78
					0x00,// Invalid

				// 206 = 0xCE
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x00,// Invalid
						0x0E,// VectorLength
							0x2C,// VHWIb_2
								0x4D,// XMM0
								0xDB, 0x1F,// VEX_Vgf2p8affineqb_xmm_xmm_xmmm128_imm8
							0x2C,// VHWIb_2
								0x6D,// YMM0
								0xDC, 0x1F,// VEX_Vgf2p8affineqb_ymm_ymm_ymmm256_imm8
					0x00,// Invalid
					0x00,// Invalid

				// 207 = 0xCF
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x09,// W
						0x00,// Invalid
						0x0E,// VectorLength
							0x2C,// VHWIb_2
								0x4D,// XMM0
								0xE1, 0x1F,// VEX_Vgf2p8affineinvqb_xmm_xmm_xmmm128_imm8
							0x2C,// VHWIb_2
								0x6D,// YMM0
								0xE2, 0x1F,// VEX_Vgf2p8affineinvqb_ymm_ymm_ymmm256_imm8
					0x00,// Invalid
					0x00,// Invalid

				// 208 = 0xD0
				0x02,// Dup
					0x0F,// 15
					0x00,// Invalid

				// 223 = 0xDF
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x39,// VWIb_2
							0x4D,// XMM0
							0xE7, 0x1F,// VEX_Vaeskeygenassist_xmm_xmmm128_imm8
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 224 = 0xE0
				0x02,// Dup
					0x10,// 16
					0x00,// Invalid

				// 240 = 0xF0
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid
					0x0E,// VectorLength
						0x13,// Gv_Ev_Ib
							0xE8, 0x1F,// VEX_Rorx_r32_rm32_imm8
						0x00,// Invalid

				// 241 = 0xF1
				0x02,// Dup
					0x0F,// 15
					0x00,// Invalid

				// TwoByteHandlers_0FXX
				0x01,// ArrayReference
				0x80, 0x02,// 0x100
				// 0 = 0x00
				0x02,// Dup
					0x10,// 16
					0x00,// Invalid

				// 16 = 0x10
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x36,// VW_2
							0x4D,// XMM0
							0xFE, 0x06,// VEX_Vmovups_xmm_xmmm128
						0x36,// VW_2
							0x6D,// YMM0
							0xFF, 0x06,// VEX_Vmovups_ymm_ymmm256
					0x0E,// VectorLength
						0x36,// VW_2
							0x4D,// XMM0
							0x84, 0x07,// VEX_Vmovupd_xmm_xmmm128
						0x36,// VW_2
							0x6D,// YMM0
							0x85, 0x07,// VEX_Vmovupd_ymm_ymmm256
					0x07,// RM
						0x29,// VHW_2
							0x4D,// XMM0
							0x8A, 0x07,// VEX_Vmovss_xmm_xmm_xmm
						0x35,// VM
							0x4D,// XMM0
							0x8B, 0x07,// VEX_Vmovss_xmm_m32
					0x07,// RM
						0x29,// VHW_2
							0x4D,// XMM0
							0x8F, 0x07,// VEX_Vmovsd_xmm_xmm_xmm
						0x35,// VM
							0x4D,// XMM0
							0x90, 0x07,// VEX_Vmovsd_xmm_m64

				// 17 = 0x11
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x3E,// WV
							0x4D,// XMM0
							0x94, 0x07,// VEX_Vmovups_xmmm128_xmm
						0x3E,// WV
							0x6D,// YMM0
							0x95, 0x07,// VEX_Vmovups_ymmm256_ymm
					0x0E,// VectorLength
						0x3E,// WV
							0x4D,// XMM0
							0x9A, 0x07,// VEX_Vmovupd_xmmm128_xmm
						0x3E,// WV
							0x6D,// YMM0
							0x9B, 0x07,// VEX_Vmovupd_ymmm256_ymm
					0x07,// RM
						0x3D,// WHV
							0x4D,// XMM0
							0xA0, 0x07,// VEX_Vmovss_xmm_xmm_xmm_0F11
						0x20,// MV
							0x4D,// XMM0
							0xA1, 0x07,// VEX_Vmovss_m32_xmm
					0x07,// RM
						0x3D,// WHV
							0x4D,// XMM0
							0xA5, 0x07,// VEX_Vmovsd_xmm_xmm_xmm_0F11
						0x20,// MV
							0x4D,// XMM0
							0xA6, 0x07,// VEX_Vmovsd_m64_xmm

				// 18 = 0x12
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x2A,// VHW_3
							0x4D,// XMM0
							0xAB, 0x07,// VEX_Vmovhlps_xmm_xmm_xmm
							0xAC, 0x07,// VEX_Vmovlps_xmm_xmm_m64
						0x00,// Invalid
					0x0E,// VectorLength
						0x28,// VHM
							0x4D,// XMM0
							0xB0, 0x07,// VEX_Vmovlpd_xmm_xmm_m64
						0x00,// Invalid
					0x0E,// VectorLength
						0x36,// VW_2
							0x4D,// XMM0
							0xB3, 0x07,// VEX_Vmovsldup_xmm_xmmm128
						0x36,// VW_2
							0x6D,// YMM0
							0xB4, 0x07,// VEX_Vmovsldup_ymm_ymmm256
					0x0E,// VectorLength
						0x36,// VW_2
							0x4D,// XMM0
							0xB9, 0x07,// VEX_Vmovddup_xmm_xmmm64
						0x36,// VW_2
							0x6D,// YMM0
							0xBA, 0x07,// VEX_Vmovddup_ymm_ymmm256

				// 19 = 0x13
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x20,// MV
							0x4D,// XMM0
							0xBF, 0x07,// VEX_Vmovlps_m64_xmm
						0x00,// Invalid
					0x0E,// VectorLength
						0x20,// MV
							0x4D,// XMM0
							0xC2, 0x07,// VEX_Vmovlpd_m64_xmm
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 20 = 0x14
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xC5, 0x07,// VEX_Vunpcklps_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xC6, 0x07,// VEX_Vunpcklps_ymm_ymm_ymmm256
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xCB, 0x07,// VEX_Vunpcklpd_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xCC, 0x07,// VEX_Vunpcklpd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 21 = 0x15
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xD1, 0x07,// VEX_Vunpckhps_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xD2, 0x07,// VEX_Vunpckhps_ymm_ymm_ymmm256
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xD7, 0x07,// VEX_Vunpckhpd_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xD8, 0x07,// VEX_Vunpckhpd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 22 = 0x16
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x2A,// VHW_3
							0x4D,// XMM0
							0xDD, 0x07,// VEX_Vmovlhps_xmm_xmm_xmm
							0xE0, 0x07,// VEX_Vmovhps_xmm_xmm_m64
						0x00,// Invalid
					0x0E,// VectorLength
						0x28,// VHM
							0x4D,// XMM0
							0xE3, 0x07,// VEX_Vmovhpd_xmm_xmm_m64
						0x00,// Invalid
					0x0E,// VectorLength
						0x36,// VW_2
							0x4D,// XMM0
							0xE6, 0x07,// VEX_Vmovshdup_xmm_xmmm128
						0x36,// VW_2
							0x6D,// YMM0
							0xE7, 0x07,// VEX_Vmovshdup_ymm_ymmm256
					0x00,// Invalid

				// 23 = 0x17
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x20,// MV
							0x4D,// XMM0
							0xEC, 0x07,// VEX_Vmovhps_m64_xmm
						0x00,// Invalid
					0x0E,// VectorLength
						0x20,// MV
							0x4D,// XMM0
							0xEF, 0x07,// VEX_Vmovhpd_m64_xmm
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 24 = 0x18
				0x02,// Dup
					0x10,// 16
					0x00,// Invalid

				// 40 = 0x28
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x36,// VW_2
							0x4D,// XMM0
							0xAE, 0x08,// VEX_Vmovaps_xmm_xmmm128
						0x36,// VW_2
							0x6D,// YMM0
							0xAF, 0x08,// VEX_Vmovaps_ymm_ymmm256
					0x0E,// VectorLength
						0x36,// VW_2
							0x4D,// XMM0
							0xB4, 0x08,// VEX_Vmovapd_xmm_xmmm128
						0x36,// VW_2
							0x6D,// YMM0
							0xB5, 0x08,// VEX_Vmovapd_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 41 = 0x29
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x3E,// WV
							0x4D,// XMM0
							0xBA, 0x08,// VEX_Vmovaps_xmmm128_xmm
						0x3E,// WV
							0x6D,// YMM0
							0xBB, 0x08,// VEX_Vmovaps_ymmm256_ymm
					0x0E,// VectorLength
						0x3E,// WV
							0x4D,// XMM0
							0xC0, 0x08,// VEX_Vmovapd_xmmm128_xmm
						0x3E,// WV
							0x6D,// YMM0
							0xC1, 0x08,// VEX_Vmovapd_ymmm256_ymm
					0x00,// Invalid
					0x00,// Invalid

				// 42 = 0x2A
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x00,// Invalid
					0x24,// VHEv
						0x4D,// XMM0
						0xC9, 0x08,// VEX_Vcvtsi2ss_xmm_xmm_rm32
					0x24,// VHEv
						0x4D,// XMM0
						0xCF, 0x08,// VEX_Vcvtsi2sd_xmm_xmm_rm32

				// 43 = 0x2B
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x20,// MV
							0x4D,// XMM0
							0xD4, 0x08,// VEX_Vmovntps_m128_xmm
						0x20,// MV
							0x6D,// YMM0
							0xD5, 0x08,// VEX_Vmovntps_m256_ymm
					0x0E,// VectorLength
						0x20,// MV
							0x4D,// XMM0
							0xDA, 0x08,// VEX_Vmovntpd_m128_xmm
						0x20,// MV
							0x6D,// YMM0
							0xDB, 0x08,// VEX_Vmovntpd_m256_ymm
					0x00,// Invalid
					0x00,// Invalid

				// 44 = 0x2C
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x00,// Invalid
					0x18,// Gv_W
						0x4D,// XMM0
						0xE5, 0x08,// VEX_Vcvttss2si_r32_xmmm32
					0x18,// Gv_W
						0x4D,// XMM0
						0xEB, 0x08,// VEX_Vcvttsd2si_r32_xmmm64

				// 45 = 0x2D
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x00,// Invalid
					0x18,// Gv_W
						0x4D,// XMM0
						0xF3, 0x08,// VEX_Vcvtss2si_r32_xmmm32
					0x18,// Gv_W
						0x4D,// XMM0
						0xF9, 0x08,// VEX_Vcvtsd2si_r32_xmmm64

				// 46 = 0x2E
				0x0B,// MandatoryPrefix2_4
					0x36,// VW_2
						0x4D,// XMM0
						0xFE, 0x08,// VEX_Vucomiss_xmm_xmmm32
					0x36,// VW_2
						0x4D,// XMM0
						0x81, 0x09,// VEX_Vucomisd_xmm_xmmm64
					0x00,// Invalid
					0x00,// Invalid

				// 47 = 0x2F
				0x0B,// MandatoryPrefix2_4
					0x36,// VW_2
						0x4D,// XMM0
						0x85, 0x09,// VEX_Vcomiss_xmm_xmmm32
					0x36,// VW_2
						0x4D,// XMM0
						0x86, 0x09,// VEX_Vcomisd_xmm_xmmm64
					0x00,// Invalid
					0x00,// Invalid

				// 48 = 0x30
				0x02,// Dup
					0x11,// 17
					0x00,// Invalid

				// 65 = 0x41
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x00,// Invalid
						0x09,// W
							0x30,// VK_HK_RK
								0xC1, 0x09,// VEX_Kandw_k_k_k
							0x30,// VK_HK_RK
								0xC2, 0x09,// VEX_Kandq_k_k_k
					0x0E,// VectorLength
						0x00,// Invalid
						0x09,// W
							0x30,// VK_HK_RK
								0xC3, 0x09,// VEX_Kandb_k_k_k
							0x30,// VK_HK_RK
								0xC4, 0x09,// VEX_Kandd_k_k_k
					0x00,// Invalid
					0x00,// Invalid

				// 66 = 0x42
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x00,// Invalid
						0x09,// W
							0x30,// VK_HK_RK
								0xC5, 0x09,// VEX_Kandnw_k_k_k
							0x30,// VK_HK_RK
								0xC6, 0x09,// VEX_Kandnq_k_k_k
					0x0E,// VectorLength
						0x00,// Invalid
						0x09,// W
							0x30,// VK_HK_RK
								0xC7, 0x09,// VEX_Kandnb_k_k_k
							0x30,// VK_HK_RK
								0xC8, 0x09,// VEX_Kandnd_k_k_k
					0x00,// Invalid
					0x00,// Invalid

				// 67 = 0x43
				0x00,// Invalid

				// 68 = 0x44
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x09,// W
							0x32,// VK_RK
								0xC9, 0x09,// VEX_Knotw_k_k
							0x32,// VK_RK
								0xCA, 0x09,// VEX_Knotq_k_k
						0x00,// Invalid
					0x0E,// VectorLength
						0x09,// W
							0x32,// VK_RK
								0xCB, 0x09,// VEX_Knotb_k_k
							0x32,// VK_RK
								0xCC, 0x09,// VEX_Knotd_k_k
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 69 = 0x45
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x00,// Invalid
						0x09,// W
							0x30,// VK_HK_RK
								0xCD, 0x09,// VEX_Korw_k_k_k
							0x30,// VK_HK_RK
								0xCE, 0x09,// VEX_Korq_k_k_k
					0x0E,// VectorLength
						0x00,// Invalid
						0x09,// W
							0x30,// VK_HK_RK
								0xCF, 0x09,// VEX_Korb_k_k_k
							0x30,// VK_HK_RK
								0xD0, 0x09,// VEX_Kord_k_k_k
					0x00,// Invalid
					0x00,// Invalid

				// 70 = 0x46
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x00,// Invalid
						0x09,// W
							0x30,// VK_HK_RK
								0xD1, 0x09,// VEX_Kxnorw_k_k_k
							0x30,// VK_HK_RK
								0xD2, 0x09,// VEX_Kxnorq_k_k_k
					0x0E,// VectorLength
						0x00,// Invalid
						0x09,// W
							0x30,// VK_HK_RK
								0xD3, 0x09,// VEX_Kxnorb_k_k_k
							0x30,// VK_HK_RK
								0xD4, 0x09,// VEX_Kxnord_k_k_k
					0x00,// Invalid
					0x00,// Invalid

				// 71 = 0x47
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x00,// Invalid
						0x09,// W
							0x30,// VK_HK_RK
								0xD5, 0x09,// VEX_Kxorw_k_k_k
							0x30,// VK_HK_RK
								0xD6, 0x09,// VEX_Kxorq_k_k_k
					0x0E,// VectorLength
						0x00,// Invalid
						0x09,// W
							0x30,// VK_HK_RK
								0xD7, 0x09,// VEX_Kxorb_k_k_k
							0x30,// VK_HK_RK
								0xD8, 0x09,// VEX_Kxord_k_k_k
					0x00,// Invalid
					0x00,// Invalid

				// 72 = 0x48
				0x01,// Invalid2

				// 74 = 0x4A
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x00,// Invalid
						0x09,// W
							0x30,// VK_HK_RK
								0xD9, 0x09,// VEX_Kaddw_k_k_k
							0x30,// VK_HK_RK
								0xDA, 0x09,// VEX_Kaddq_k_k_k
					0x0E,// VectorLength
						0x00,// Invalid
						0x09,// W
							0x30,// VK_HK_RK
								0xDB, 0x09,// VEX_Kaddb_k_k_k
							0x30,// VK_HK_RK
								0xDC, 0x09,// VEX_Kaddd_k_k_k
					0x00,// Invalid
					0x00,// Invalid

				// 75 = 0x4B
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x00,// Invalid
						0x09,// W
							0x30,// VK_HK_RK
								0xDD, 0x09,// VEX_Kunpckwd_k_k_k
							0x30,// VK_HK_RK
								0xDE, 0x09,// VEX_Kunpckdq_k_k_k
					0x0E,// VectorLength
						0x00,// Invalid
						0x09,// W
							0x30,// VK_HK_RK
								0xDF, 0x09,// VEX_Kunpckbw_k_k_k
							0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 76 = 0x4C
				0x02,// Dup
					0x04,// 4
					0x00,// Invalid

				// 80 = 0x50
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x17,// Gv_RX
							0x4D,// XMM0
							0xE2, 0x09,// VEX_Vmovmskps_r32_xmm
						0x17,// Gv_RX
							0x6D,// YMM0
							0xE4, 0x09,// VEX_Vmovmskps_r32_ymm
					0x0E,// VectorLength
						0x17,// Gv_RX
							0x4D,// XMM0
							0xE8, 0x09,// VEX_Vmovmskpd_r32_xmm
						0x17,// Gv_RX
							0x6D,// YMM0
							0xEA, 0x09,// VEX_Vmovmskpd_r32_ymm
					0x00,// Invalid
					0x00,// Invalid

				// 81 = 0x51
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x36,// VW_2
							0x4D,// XMM0
							0xED, 0x09,// VEX_Vsqrtps_xmm_xmmm128
						0x36,// VW_2
							0x6D,// YMM0
							0xEE, 0x09,// VEX_Vsqrtps_ymm_ymmm256
					0x0E,// VectorLength
						0x36,// VW_2
							0x4D,// XMM0
							0xF3, 0x09,// VEX_Vsqrtpd_xmm_xmmm128
						0x36,// VW_2
							0x6D,// YMM0
							0xF4, 0x09,// VEX_Vsqrtpd_ymm_ymmm256
					0x29,// VHW_2
						0x4D,// XMM0
						0xF9, 0x09,// VEX_Vsqrtss_xmm_xmm_xmmm32
					0x29,// VHW_2
						0x4D,// XMM0
						0xFC, 0x09,// VEX_Vsqrtsd_xmm_xmm_xmmm64

				// 82 = 0x52
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x36,// VW_2
							0x4D,// XMM0
							0xFF, 0x09,// VEX_Vrsqrtps_xmm_xmmm128
						0x36,// VW_2
							0x6D,// YMM0
							0x80, 0x0A,// VEX_Vrsqrtps_ymm_ymmm256
					0x00,// Invalid
					0x29,// VHW_2
						0x4D,// XMM0
						0x82, 0x0A,// VEX_Vrsqrtss_xmm_xmm_xmmm32
					0x00,// Invalid

				// 83 = 0x53
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x36,// VW_2
							0x4D,// XMM0
							0x84, 0x0A,// VEX_Vrcpps_xmm_xmmm128
						0x36,// VW_2
							0x6D,// YMM0
							0x85, 0x0A,// VEX_Vrcpps_ymm_ymmm256
					0x00,// Invalid
					0x29,// VHW_2
						0x4D,// XMM0
						0x87, 0x0A,// VEX_Vrcpss_xmm_xmm_xmmm32
					0x00,// Invalid

				// 84 = 0x54
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0x89, 0x0A,// VEX_Vandps_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0x8A, 0x0A,// VEX_Vandps_ymm_ymm_ymmm256
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0x8F, 0x0A,// VEX_Vandpd_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0x90, 0x0A,// VEX_Vandpd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 85 = 0x55
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0x95, 0x0A,// VEX_Vandnps_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0x96, 0x0A,// VEX_Vandnps_ymm_ymm_ymmm256
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0x9B, 0x0A,// VEX_Vandnpd_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0x9C, 0x0A,// VEX_Vandnpd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 86 = 0x56
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xA1, 0x0A,// VEX_Vorps_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xA2, 0x0A,// VEX_Vorps_ymm_ymm_ymmm256
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xA7, 0x0A,// VEX_Vorpd_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xA8, 0x0A,// VEX_Vorpd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 87 = 0x57
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xAD, 0x0A,// VEX_Vxorps_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xAE, 0x0A,// VEX_Vxorps_ymm_ymm_ymmm256
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xB3, 0x0A,// VEX_Vxorpd_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xB4, 0x0A,// VEX_Vxorpd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 88 = 0x58
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xB9, 0x0A,// VEX_Vaddps_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xBA, 0x0A,// VEX_Vaddps_ymm_ymm_ymmm256
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xBF, 0x0A,// VEX_Vaddpd_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xC0, 0x0A,// VEX_Vaddpd_ymm_ymm_ymmm256
					0x29,// VHW_2
						0x4D,// XMM0
						0xC5, 0x0A,// VEX_Vaddss_xmm_xmm_xmmm32
					0x29,// VHW_2
						0x4D,// XMM0
						0xC8, 0x0A,// VEX_Vaddsd_xmm_xmm_xmmm64

				// 89 = 0x59
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xCB, 0x0A,// VEX_Vmulps_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xCC, 0x0A,// VEX_Vmulps_ymm_ymm_ymmm256
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xD1, 0x0A,// VEX_Vmulpd_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xD2, 0x0A,// VEX_Vmulpd_ymm_ymm_ymmm256
					0x29,// VHW_2
						0x4D,// XMM0
						0xD7, 0x0A,// VEX_Vmulss_xmm_xmm_xmmm32
					0x29,// VHW_2
						0x4D,// XMM0
						0xDA, 0x0A,// VEX_Vmulsd_xmm_xmm_xmmm64

				// 90 = 0x5A
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x36,// VW_2
							0x4D,// XMM0
							0xDD, 0x0A,// VEX_Vcvtps2pd_xmm_xmmm64
						0x37,// VW_3
							0x6D,// YMM0
							0x4D,// XMM0
							0xDE, 0x0A,// VEX_Vcvtps2pd_ymm_xmmm128
					0x0E,// VectorLength
						0x36,// VW_2
							0x4D,// XMM0
							0xE3, 0x0A,// VEX_Vcvtpd2ps_xmm_xmmm128
						0x37,// VW_3
							0x4D,// XMM0
							0x6D,// YMM0
							0xE4, 0x0A,// VEX_Vcvtpd2ps_xmm_ymmm256
					0x29,// VHW_2
						0x4D,// XMM0
						0xE9, 0x0A,// VEX_Vcvtss2sd_xmm_xmm_xmmm32
					0x29,// VHW_2
						0x4D,// XMM0
						0xEC, 0x0A,// VEX_Vcvtsd2ss_xmm_xmm_xmmm64

				// 91 = 0x5B
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x36,// VW_2
							0x4D,// XMM0
							0xEF, 0x0A,// VEX_Vcvtdq2ps_xmm_xmmm128
						0x36,// VW_2
							0x6D,// YMM0
							0xF0, 0x0A,// VEX_Vcvtdq2ps_ymm_ymmm256
					0x0E,// VectorLength
						0x36,// VW_2
							0x4D,// XMM0
							0xF8, 0x0A,// VEX_Vcvtps2dq_xmm_xmmm128
						0x36,// VW_2
							0x6D,// YMM0
							0xF9, 0x0A,// VEX_Vcvtps2dq_ymm_ymmm256
					0x0E,// VectorLength
						0x36,// VW_2
							0x4D,// XMM0
							0xFE, 0x0A,// VEX_Vcvttps2dq_xmm_xmmm128
						0x36,// VW_2
							0x6D,// YMM0
							0xFF, 0x0A,// VEX_Vcvttps2dq_ymm_ymmm256
					0x00,// Invalid

				// 92 = 0x5C
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0x84, 0x0B,// VEX_Vsubps_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0x85, 0x0B,// VEX_Vsubps_ymm_ymm_ymmm256
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0x8A, 0x0B,// VEX_Vsubpd_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0x8B, 0x0B,// VEX_Vsubpd_ymm_ymm_ymmm256
					0x29,// VHW_2
						0x4D,// XMM0
						0x90, 0x0B,// VEX_Vsubss_xmm_xmm_xmmm32
					0x29,// VHW_2
						0x4D,// XMM0
						0x93, 0x0B,// VEX_Vsubsd_xmm_xmm_xmmm64

				// 93 = 0x5D
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0x96, 0x0B,// VEX_Vminps_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0x97, 0x0B,// VEX_Vminps_ymm_ymm_ymmm256
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0x9C, 0x0B,// VEX_Vminpd_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0x9D, 0x0B,// VEX_Vminpd_ymm_ymm_ymmm256
					0x29,// VHW_2
						0x4D,// XMM0
						0xA2, 0x0B,// VEX_Vminss_xmm_xmm_xmmm32
					0x29,// VHW_2
						0x4D,// XMM0
						0xA5, 0x0B,// VEX_Vminsd_xmm_xmm_xmmm64

				// 94 = 0x5E
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xA8, 0x0B,// VEX_Vdivps_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xA9, 0x0B,// VEX_Vdivps_ymm_ymm_ymmm256
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xAE, 0x0B,// VEX_Vdivpd_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xAF, 0x0B,// VEX_Vdivpd_ymm_ymm_ymmm256
					0x29,// VHW_2
						0x4D,// XMM0
						0xB4, 0x0B,// VEX_Vdivss_xmm_xmm_xmmm32
					0x29,// VHW_2
						0x4D,// XMM0
						0xB7, 0x0B,// VEX_Vdivsd_xmm_xmm_xmmm64

				// 95 = 0x5F
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xBA, 0x0B,// VEX_Vmaxps_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xBB, 0x0B,// VEX_Vmaxps_ymm_ymm_ymmm256
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xC0, 0x0B,// VEX_Vmaxpd_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xC1, 0x0B,// VEX_Vmaxpd_ymm_ymm_ymmm256
					0x29,// VHW_2
						0x4D,// XMM0
						0xC6, 0x0B,// VEX_Vmaxss_xmm_xmm_xmmm32
					0x29,// VHW_2
						0x4D,// XMM0
						0xC9, 0x0B,// VEX_Vmaxsd_xmm_xmm_xmmm64

				// 96 = 0x60
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xCD, 0x0B,// VEX_Vpunpcklbw_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xCE, 0x0B,// VEX_Vpunpcklbw_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 97 = 0x61
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xD4, 0x0B,// VEX_Vpunpcklwd_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xD5, 0x0B,// VEX_Vpunpcklwd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 98 = 0x62
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xDB, 0x0B,// VEX_Vpunpckldq_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xDC, 0x0B,// VEX_Vpunpckldq_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 99 = 0x63
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xE2, 0x0B,// VEX_Vpacksswb_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xE3, 0x0B,// VEX_Vpacksswb_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 100 = 0x64
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xE9, 0x0B,// VEX_Vpcmpgtb_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xEA, 0x0B,// VEX_Vpcmpgtb_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 101 = 0x65
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xF0, 0x0B,// VEX_Vpcmpgtw_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xF1, 0x0B,// VEX_Vpcmpgtw_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 102 = 0x66
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xF7, 0x0B,// VEX_Vpcmpgtd_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xF8, 0x0B,// VEX_Vpcmpgtd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 103 = 0x67
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xFE, 0x0B,// VEX_Vpackuswb_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xFF, 0x0B,// VEX_Vpackuswb_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 104 = 0x68
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0x85, 0x0C,// VEX_Vpunpckhbw_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0x86, 0x0C,// VEX_Vpunpckhbw_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 105 = 0x69
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0x8C, 0x0C,// VEX_Vpunpckhwd_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0x8D, 0x0C,// VEX_Vpunpckhwd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 106 = 0x6A
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0x93, 0x0C,// VEX_Vpunpckhdq_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0x94, 0x0C,// VEX_Vpunpckhdq_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 107 = 0x6B
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0x9A, 0x0C,// VEX_Vpackssdw_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0x9B, 0x0C,// VEX_Vpackssdw_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 108 = 0x6C
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xA0, 0x0C,// VEX_Vpunpcklqdq_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xA1, 0x0C,// VEX_Vpunpcklqdq_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 109 = 0x6D
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xA6, 0x0C,// VEX_Vpunpckhqdq_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xA7, 0x0C,// VEX_Vpunpckhqdq_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 110 = 0x6E
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x3B,// VX_Ev
							0xAF, 0x0C,// VEX_Vmovd_xmm_rm32
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 111 = 0x6F
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x36,// VW_2
							0x4D,// XMM0
							0xB5, 0x0C,// VEX_Vmovdqa_xmm_xmmm128
						0x36,// VW_2
							0x6D,// YMM0
							0xB6, 0x0C,// VEX_Vmovdqa_ymm_ymmm256
					0x0E,// VectorLength
						0x36,// VW_2
							0x4D,// XMM0
							0xBE, 0x0C,// VEX_Vmovdqu_xmm_xmmm128
						0x36,// VW_2
							0x6D,// YMM0
							0xBF, 0x0C,// VEX_Vmovdqu_ymm_ymmm256
					0x00,// Invalid

				// 112 = 0x70
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x39,// VWIb_2
							0x4D,// XMM0
							0xCE, 0x0C,// VEX_Vpshufd_xmm_xmmm128_imm8
						0x39,// VWIb_2
							0x6D,// YMM0
							0xCF, 0x0C,// VEX_Vpshufd_ymm_ymmm256_imm8
					0x0E,// VectorLength
						0x39,// VWIb_2
							0x4D,// XMM0
							0xD4, 0x0C,// VEX_Vpshufhw_xmm_xmmm128_imm8
						0x39,// VWIb_2
							0x6D,// YMM0
							0xD5, 0x0C,// VEX_Vpshufhw_ymm_ymmm256_imm8
					0x0E,// VectorLength
						0x39,// VWIb_2
							0x4D,// XMM0
							0xDA, 0x0C,// VEX_Vpshuflw_xmm_xmmm128_imm8
						0x39,// VWIb_2
							0x6D,// YMM0
							0xDB, 0x0C,// VEX_Vpshuflw_ymm_ymmm256_imm8

				// 113 = 0x71
				0x08,// Group
					0x06,// ArrayReference
						0x00,// 0x0 = handlers_Grp_0F71

				// 114 = 0x72
				0x08,// Group
					0x06,// ArrayReference
						0x01,// 0x1 = handlers_Grp_0F72

				// 115 = 0x73
				0x08,// Group
					0x06,// ArrayReference
						0x02,// 0x2 = handlers_Grp_0F73

				// 116 = 0x74
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xB4, 0x0D,// VEX_Vpcmpeqb_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xB5, 0x0D,// VEX_Vpcmpeqb_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 117 = 0x75
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xBB, 0x0D,// VEX_Vpcmpeqw_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xBC, 0x0D,// VEX_Vpcmpeqw_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 118 = 0x76
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xC2, 0x0D,// VEX_Vpcmpeqd_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xC3, 0x0D,// VEX_Vpcmpeqd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 119 = 0x77
				0x0C,// MandatoryPrefix2_NoModRM
					0x0D,// VectorLength_NoModRM
						0x23,// Simple
							0xC8, 0x0D,// VEX_Vzeroupper
						0x23,// Simple
							0xC9, 0x0D,// VEX_Vzeroall
					0x03,// Invalid_NoModRM
					0x03,// Invalid_NoModRM
					0x03,// Invalid_NoModRM

				// 120 = 0x78
				0x02,// Dup
					0x04,// 4
					0x00,// Invalid

				// 124 = 0x7C
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0x8F, 0x0E,// VEX_Vhaddpd_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0x90, 0x0E,// VEX_Vhaddpd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0x92, 0x0E,// VEX_Vhaddps_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0x93, 0x0E,// VEX_Vhaddps_ymm_ymm_ymmm256

				// 125 = 0x7D
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0x95, 0x0E,// VEX_Vhsubpd_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0x96, 0x0E,// VEX_Vhsubpd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0x98, 0x0E,// VEX_Vhsubps_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0x99, 0x0E,// VEX_Vhsubps_ymm_ymm_ymmm256

				// 126 = 0x7E
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x10,// Ev_VX
							0x9E, 0x0E,// VEX_Vmovd_rm32_xmm
						0x00,// Invalid
					0x0E,// VectorLength
						0x36,// VW_2
							0x4D,// XMM0
							0xA3, 0x0E,// VEX_Vmovq_xmm_xmmm64
						0x00,// Invalid
					0x00,// Invalid

				// 127 = 0x7F
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x3E,// WV
							0x4D,// XMM0
							0xA7, 0x0E,// VEX_Vmovdqa_xmmm128_xmm
						0x3E,// WV
							0x6D,// YMM0
							0xA8, 0x0E,// VEX_Vmovdqa_ymmm256_ymm
					0x0E,// VectorLength
						0x3E,// WV
							0x4D,// XMM0
							0xB0, 0x0E,// VEX_Vmovdqu_xmmm128_xmm
						0x3E,// WV
							0x6D,// YMM0
							0xB1, 0x0E,// VEX_Vmovdqu_ymmm256_ymm
					0x00,// Invalid

				// 128 = 0x80
				0x02,// Dup
					0x10,// 16
					0x00,// Invalid

				// 144 = 0x90
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x09,// W
							0x34,// VK_WK
								0xFE, 0x0E,// VEX_Kmovw_k_km16
							0x34,// VK_WK
								0xFF, 0x0E,// VEX_Kmovq_k_km64
						0x00,// Invalid
					0x0E,// VectorLength
						0x09,// W
							0x34,// VK_WK
								0x80, 0x0F,// VEX_Kmovb_k_km8
							0x34,// VK_WK
								0x81, 0x0F,// VEX_Kmovd_k_km32
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 145 = 0x91
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x09,// W
							0x1F,// M_VK
								0x82, 0x0F,// VEX_Kmovw_m16_k
							0x1F,// M_VK
								0x83, 0x0F,// VEX_Kmovq_m64_k
						0x00,// Invalid
					0x0E,// VectorLength
						0x09,// W
							0x1F,// M_VK
								0x84, 0x0F,// VEX_Kmovb_m8_k
							0x1F,// M_VK
								0x85, 0x0F,// VEX_Kmovd_m32_k
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 146 = 0x92
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x09,// W
							0x31,// VK_R
								0x86, 0x0F,// VEX_Kmovw_k_r32
								0x25,// EAX
							0x00,// Invalid
						0x00,// Invalid
					0x0E,// VectorLength
						0x09,// W
							0x31,// VK_R
								0x87, 0x0F,// VEX_Kmovb_k_r32
								0x25,// EAX
							0x00,// Invalid
						0x00,// Invalid
					0x00,// Invalid
					0x0E,// VectorLength
						0x09,// W
							0x31,// VK_R
								0x88, 0x0F,// VEX_Kmovd_k_r32
								0x25,// EAX
							0x04,// Bitness_DontReadModRM
								0x00,// Invalid
								0x31,// VK_R
									0x89, 0x0F,// VEX_Kmovq_k_r64
									0x35,// RAX
						0x00,// Invalid

				// 147 = 0x93
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x09,// W
							0x11,// G_VK
								0x8A, 0x0F,// VEX_Kmovw_r32_k
								0x25,// EAX
							0x00,// Invalid
						0x00,// Invalid
					0x0E,// VectorLength
						0x09,// W
							0x11,// G_VK
								0x8B, 0x0F,// VEX_Kmovb_r32_k
								0x25,// EAX
							0x00,// Invalid
						0x00,// Invalid
					0x00,// Invalid
					0x0E,// VectorLength
						0x09,// W
							0x11,// G_VK
								0x8C, 0x0F,// VEX_Kmovd_r32_k
								0x25,// EAX
							0x04,// Bitness_DontReadModRM
								0x00,// Invalid
								0x11,// G_VK
									0x8D, 0x0F,// VEX_Kmovq_r64_k
									0x35,// RAX
						0x00,// Invalid

				// 148 = 0x94
				0x02,// Dup
					0x04,// 4
					0x00,// Invalid

				// 152 = 0x98
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x09,// W
							0x32,// VK_RK
								0x8E, 0x0F,// VEX_Kortestw_k_k
							0x32,// VK_RK
								0x8F, 0x0F,// VEX_Kortestq_k_k
						0x00,// Invalid
					0x0E,// VectorLength
						0x09,// W
							0x32,// VK_RK
								0x90, 0x0F,// VEX_Kortestb_k_k
							0x32,// VK_RK
								0x91, 0x0F,// VEX_Kortestd_k_k
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 153 = 0x99
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x09,// W
							0x32,// VK_RK
								0x92, 0x0F,// VEX_Ktestw_k_k
							0x32,// VK_RK
								0x93, 0x0F,// VEX_Ktestq_k_k
						0x00,// Invalid
					0x0E,// VectorLength
						0x09,// W
							0x32,// VK_RK
								0x94, 0x0F,// VEX_Ktestb_k_k
							0x32,// VK_RK
								0x95, 0x0F,// VEX_Ktestd_k_k
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 154 = 0x9A
				0x02,// Dup
					0x14,// 20
					0x00,// Invalid

				// 174 = 0xAE
				0x08,// Group
					0x06,// ArrayReference
						0x03,// 0x3 = handlers_Grp_0FAE

				// 175 = 0xAF
				0x02,// Dup
					0x13,// 19
					0x00,// Invalid

				// 194 = 0xC2
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x2C,// VHWIb_2
							0x4D,// XMM0
							0xDD, 0x10,// VEX_Vcmpps_xmm_xmm_xmmm128_imm8
						0x2C,// VHWIb_2
							0x6D,// YMM0
							0xDE, 0x10,// VEX_Vcmpps_ymm_ymm_ymmm256_imm8
					0x0E,// VectorLength
						0x2C,// VHWIb_2
							0x4D,// XMM0
							0xE3, 0x10,// VEX_Vcmppd_xmm_xmm_xmmm128_imm8
						0x2C,// VHWIb_2
							0x6D,// YMM0
							0xE4, 0x10,// VEX_Vcmppd_ymm_ymm_ymmm256_imm8
					0x2C,// VHWIb_2
						0x4D,// XMM0
						0xE9, 0x10,// VEX_Vcmpss_xmm_xmm_xmmm32_imm8
					0x2C,// VHWIb_2
						0x4D,// XMM0
						0xEC, 0x10,// VEX_Vcmpsd_xmm_xmm_xmmm64_imm8

				// 195 = 0xC3
				0x00,// Invalid

				// 196 = 0xC4
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x25,// VHEvIb
							0x4D,// XMM0
							0xF4, 0x10,// VEX_Vpinsrw_xmm_xmm_r32m16_imm8
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 197 = 0xC5
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x15,// Gv_GPR_Ib
							0x4D,// XMM0
							0xFC, 0x10,// VEX_Vpextrw_r32_xmm_imm8
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 198 = 0xC6
				0x0B,// MandatoryPrefix2_4
					0x0E,// VectorLength
						0x2C,// VHWIb_2
							0x4D,// XMM0
							0x81, 0x11,// VEX_Vshufps_xmm_xmm_xmmm128_imm8
						0x2C,// VHWIb_2
							0x6D,// YMM0
							0x82, 0x11,// VEX_Vshufps_ymm_ymm_ymmm256_imm8
					0x0E,// VectorLength
						0x2C,// VHWIb_2
							0x4D,// XMM0
							0x87, 0x11,// VEX_Vshufpd_xmm_xmm_xmmm128_imm8
						0x2C,// VHWIb_2
							0x6D,// YMM0
							0x88, 0x11,// VEX_Vshufpd_ymm_ymm_ymmm256_imm8
					0x00,// Invalid
					0x00,// Invalid

				// 199 = 0xC7
				0x02,// Dup
					0x09,// 9
					0x00,// Invalid

				// 208 = 0xD0
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xA4, 0x11,// VEX_Vaddsubpd_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xA5, 0x11,// VEX_Vaddsubpd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xA7, 0x11,// VEX_Vaddsubps_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xA8, 0x11,// VEX_Vaddsubps_ymm_ymm_ymmm256

				// 209 = 0xD1
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x2B,// VHW_4
							0x4D,// XMM0
							0x4D,// XMM0
							0x4D,// XMM0
							0xAB, 0x11,// VEX_Vpsrlw_xmm_xmm_xmmm128
						0x2B,// VHW_4
							0x6D,// YMM0
							0x6D,// YMM0
							0x4D,// XMM0
							0xAC, 0x11,// VEX_Vpsrlw_ymm_ymm_xmmm128
					0x00,// Invalid
					0x00,// Invalid

				// 210 = 0xD2
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x2B,// VHW_4
							0x4D,// XMM0
							0x4D,// XMM0
							0x4D,// XMM0
							0xB2, 0x11,// VEX_Vpsrld_xmm_xmm_xmmm128
						0x2B,// VHW_4
							0x6D,// YMM0
							0x6D,// YMM0
							0x4D,// XMM0
							0xB3, 0x11,// VEX_Vpsrld_ymm_ymm_xmmm128
					0x00,// Invalid
					0x00,// Invalid

				// 211 = 0xD3
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x2B,// VHW_4
							0x4D,// XMM0
							0x4D,// XMM0
							0x4D,// XMM0
							0xB9, 0x11,// VEX_Vpsrlq_xmm_xmm_xmmm128
						0x2B,// VHW_4
							0x6D,// YMM0
							0x6D,// YMM0
							0x4D,// XMM0
							0xBA, 0x11,// VEX_Vpsrlq_ymm_ymm_xmmm128
					0x00,// Invalid
					0x00,// Invalid

				// 212 = 0xD4
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xC0, 0x11,// VEX_Vpaddq_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xC1, 0x11,// VEX_Vpaddq_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 213 = 0xD5
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xC7, 0x11,// VEX_Vpmullw_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xC8, 0x11,// VEX_Vpmullw_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 214 = 0xD6
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x3E,// WV
							0x4D,// XMM0
							0xCD, 0x11,// VEX_Vmovq_xmmm64_xmm
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 215 = 0xD7
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x17,// Gv_RX
							0x4D,// XMM0
							0xD5, 0x11,// VEX_Vpmovmskb_r32_xmm
						0x17,// Gv_RX
							0x6D,// YMM0
							0xD7, 0x11,// VEX_Vpmovmskb_r32_ymm
					0x00,// Invalid
					0x00,// Invalid

				// 216 = 0xD8
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xDB, 0x11,// VEX_Vpsubusb_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xDC, 0x11,// VEX_Vpsubusb_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 217 = 0xD9
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xE2, 0x11,// VEX_Vpsubusw_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xE3, 0x11,// VEX_Vpsubusw_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 218 = 0xDA
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xE9, 0x11,// VEX_Vpminub_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xEA, 0x11,// VEX_Vpminub_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 219 = 0xDB
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xF0, 0x11,// VEX_Vpand_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xF1, 0x11,// VEX_Vpand_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 220 = 0xDC
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xFA, 0x11,// VEX_Vpaddusb_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xFB, 0x11,// VEX_Vpaddusb_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 221 = 0xDD
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0x81, 0x12,// VEX_Vpaddusw_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0x82, 0x12,// VEX_Vpaddusw_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 222 = 0xDE
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0x88, 0x12,// VEX_Vpmaxub_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0x89, 0x12,// VEX_Vpmaxub_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 223 = 0xDF
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0x8F, 0x12,// VEX_Vpandn_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0x90, 0x12,// VEX_Vpandn_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 224 = 0xE0
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0x99, 0x12,// VEX_Vpavgb_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0x9A, 0x12,// VEX_Vpavgb_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 225 = 0xE1
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x2B,// VHW_4
							0x4D,// XMM0
							0x4D,// XMM0
							0x4D,// XMM0
							0xA0, 0x12,// VEX_Vpsraw_xmm_xmm_xmmm128
						0x2B,// VHW_4
							0x6D,// YMM0
							0x6D,// YMM0
							0x4D,// XMM0
							0xA1, 0x12,// VEX_Vpsraw_ymm_ymm_xmmm128
					0x00,// Invalid
					0x00,// Invalid

				// 226 = 0xE2
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x2B,// VHW_4
							0x4D,// XMM0
							0x4D,// XMM0
							0x4D,// XMM0
							0xA7, 0x12,// VEX_Vpsrad_xmm_xmm_xmmm128
						0x2B,// VHW_4
							0x6D,// YMM0
							0x6D,// YMM0
							0x4D,// XMM0
							0xA8, 0x12,// VEX_Vpsrad_ymm_ymm_xmmm128
					0x00,// Invalid
					0x00,// Invalid

				// 227 = 0xE3
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xB1, 0x12,// VEX_Vpavgw_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xB2, 0x12,// VEX_Vpavgw_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 228 = 0xE4
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xB8, 0x12,// VEX_Vpmulhuw_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xB9, 0x12,// VEX_Vpmulhuw_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 229 = 0xE5
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xBF, 0x12,// VEX_Vpmulhw_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xC0, 0x12,// VEX_Vpmulhw_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 230 = 0xE6
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x36,// VW_2
							0x4D,// XMM0
							0xC5, 0x12,// VEX_Vcvttpd2dq_xmm_xmmm128
						0x37,// VW_3
							0x4D,// XMM0
							0x6D,// YMM0
							0xC6, 0x12,// VEX_Vcvttpd2dq_xmm_ymmm256
					0x0E,// VectorLength
						0x36,// VW_2
							0x4D,// XMM0
							0xCB, 0x12,// VEX_Vcvtdq2pd_xmm_xmmm64
						0x37,// VW_3
							0x6D,// YMM0
							0x4D,// XMM0
							0xCC, 0x12,// VEX_Vcvtdq2pd_ymm_xmmm128
					0x0E,// VectorLength
						0x36,// VW_2
							0x4D,// XMM0
							0xD4, 0x12,// VEX_Vcvtpd2dq_xmm_xmmm128
						0x37,// VW_3
							0x4D,// XMM0
							0x6D,// YMM0
							0xD5, 0x12,// VEX_Vcvtpd2dq_xmm_ymmm256

				// 231 = 0xE7
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x20,// MV
							0x4D,// XMM0
							0xDB, 0x12,// VEX_Vmovntdq_m128_xmm
						0x20,// MV
							0x6D,// YMM0
							0xDC, 0x12,// VEX_Vmovntdq_m256_ymm
					0x00,// Invalid
					0x00,// Invalid

				// 232 = 0xE8
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xE2, 0x12,// VEX_Vpsubsb_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xE3, 0x12,// VEX_Vpsubsb_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 233 = 0xE9
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xE9, 0x12,// VEX_Vpsubsw_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xEA, 0x12,// VEX_Vpsubsw_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 234 = 0xEA
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xF0, 0x12,// VEX_Vpminsw_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xF1, 0x12,// VEX_Vpminsw_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 235 = 0xEB
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xF7, 0x12,// VEX_Vpor_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xF8, 0x12,// VEX_Vpor_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 236 = 0xEC
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0x81, 0x13,// VEX_Vpaddsb_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0x82, 0x13,// VEX_Vpaddsb_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 237 = 0xED
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0x88, 0x13,// VEX_Vpaddsw_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0x89, 0x13,// VEX_Vpaddsw_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 238 = 0xEE
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0x8F, 0x13,// VEX_Vpmaxsw_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0x90, 0x13,// VEX_Vpmaxsw_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 239 = 0xEF
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0x96, 0x13,// VEX_Vpxor_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0x97, 0x13,// VEX_Vpxor_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 240 = 0xF0
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid
					0x0E,// VectorLength
						0x35,// VM
							0x4D,// XMM0
							0x9F, 0x13,// VEX_Vlddqu_xmm_m128
						0x35,// VM
							0x6D,// YMM0
							0xA0, 0x13,// VEX_Vlddqu_ymm_m256

				// 241 = 0xF1
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x2B,// VHW_4
							0x4D,// XMM0
							0x4D,// XMM0
							0x4D,// XMM0
							0xA3, 0x13,// VEX_Vpsllw_xmm_xmm_xmmm128
						0x2B,// VHW_4
							0x6D,// YMM0
							0x6D,// YMM0
							0x4D,// XMM0
							0xA4, 0x13,// VEX_Vpsllw_ymm_ymm_xmmm128
					0x00,// Invalid
					0x00,// Invalid

				// 242 = 0xF2
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x2B,// VHW_4
							0x4D,// XMM0
							0x4D,// XMM0
							0x4D,// XMM0
							0xAA, 0x13,// VEX_Vpslld_xmm_xmm_xmmm128
						0x2B,// VHW_4
							0x6D,// YMM0
							0x6D,// YMM0
							0x4D,// XMM0
							0xAB, 0x13,// VEX_Vpslld_ymm_ymm_xmmm128
					0x00,// Invalid
					0x00,// Invalid

				// 243 = 0xF3
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x2B,// VHW_4
							0x4D,// XMM0
							0x4D,// XMM0
							0x4D,// XMM0
							0xB1, 0x13,// VEX_Vpsllq_xmm_xmm_xmmm128
						0x2B,// VHW_4
							0x6D,// YMM0
							0x6D,// YMM0
							0x4D,// XMM0
							0xB2, 0x13,// VEX_Vpsllq_ymm_ymm_xmmm128
					0x00,// Invalid
					0x00,// Invalid

				// 244 = 0xF4
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xB8, 0x13,// VEX_Vpmuludq_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xB9, 0x13,// VEX_Vpmuludq_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 245 = 0xF5
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xBF, 0x13,// VEX_Vpmaddwd_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xC0, 0x13,// VEX_Vpmaddwd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 246 = 0xF6
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xC6, 0x13,// VEX_Vpsadbw_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xC7, 0x13,// VEX_Vpsadbw_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 247 = 0xF7
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x21,// rDI_VX_RX
							0x4D,// XMM0
							0xCD, 0x13,// VEX_Vmaskmovdqu_rDI_xmm_xmm
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 248 = 0xF8
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xD0, 0x13,// VEX_Vpsubb_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xD1, 0x13,// VEX_Vpsubb_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 249 = 0xF9
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xD7, 0x13,// VEX_Vpsubw_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xD8, 0x13,// VEX_Vpsubw_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 250 = 0xFA
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xDE, 0x13,// VEX_Vpsubd_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xDF, 0x13,// VEX_Vpsubd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 251 = 0xFB
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xE5, 0x13,// VEX_Vpsubq_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xE6, 0x13,// VEX_Vpsubq_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 252 = 0xFC
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xEC, 0x13,// VEX_Vpaddb_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xED, 0x13,// VEX_Vpaddb_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 253 = 0xFD
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xF3, 0x13,// VEX_Vpaddw_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xF4, 0x13,// VEX_Vpaddw_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 254 = 0xFE
				0x0B,// MandatoryPrefix2_4
					0x00,// Invalid
					0x0E,// VectorLength
						0x29,// VHW_2
							0x4D,// XMM0
							0xFA, 0x13,// VEX_Vpaddd_xmm_xmm_xmmm128
						0x29,// VHW_2
							0x6D,// YMM0
							0xFB, 0x13,// VEX_Vpaddd_ymm_ymm_ymmm256
					0x00,// Invalid
					0x00,// Invalid

				// 255 = 0xFF
				0x00,// Invalid
			};


    }
}