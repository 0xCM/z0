//-----------------------------------------------------------------------------
// OpCode data Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Encoding
{
    using System;
    using System.Linq;

    using static Seed;
    using static Memories;

    partial class OpCodeData
    {
        internal static ReadOnlySpan<byte> EVEX
            => new byte[] {
				// handlers_Grp_0F71
				0x01,// ArrayReference
				0x08,// 0x8
				// 0 = 0x00
				0x01,// Invalid2

				// 2 = 0x02
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x10,// HkWIb_3
							0x4D,// XMM0
							0xE3, 0x0C,// EVEX_Vpsrlw_xmm_k1z_xmmm128_imm8
							0x07,// Full_Mem_128
						0x10,// HkWIb_3
							0x6D,// YMM0
							0xE4, 0x0C,// EVEX_Vpsrlw_ymm_k1z_ymmm256_imm8
							0x08,// Full_Mem_256
						0x10,// HkWIb_3
							0x8D,// ZMM0
							0xE5, 0x0C,// EVEX_Vpsrlw_zmm_k1z_zmmm512_imm8
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 3 = 0x03
				0x00,// Invalid

				// 4 = 0x04
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x10,// HkWIb_3
							0x4D,// XMM0
							0xEA, 0x0C,// EVEX_Vpsraw_xmm_k1z_xmmm128_imm8
							0x07,// Full_Mem_128
						0x10,// HkWIb_3
							0x6D,// YMM0
							0xEB, 0x0C,// EVEX_Vpsraw_ymm_k1z_ymmm256_imm8
							0x08,// Full_Mem_256
						0x10,// HkWIb_3
							0x8D,// ZMM0
							0xEC, 0x0C,// EVEX_Vpsraw_zmm_k1z_zmmm512_imm8
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 5 = 0x05
				0x00,// Invalid

				// 6 = 0x06
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x10,// HkWIb_3
							0x4D,// XMM0
							0xF1, 0x0C,// EVEX_Vpsllw_xmm_k1z_xmmm128_imm8
							0x07,// Full_Mem_128
						0x10,// HkWIb_3
							0x6D,// YMM0
							0xF2, 0x0C,// EVEX_Vpsllw_ymm_k1z_ymmm256_imm8
							0x08,// Full_Mem_256
						0x10,// HkWIb_3
							0x8D,// ZMM0
							0xF3, 0x0C,// EVEX_Vpsllw_zmm_k1z_zmmm512_imm8
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 7 = 0x07
				0x00,// Invalid

				// handlers_Grp_0F72
				0x01,// ArrayReference
				0x08,// 0x8
				// 0 = 0x00
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x11,// HkWIb_3b
								0x4D,// XMM0
								0xF4, 0x0C,// EVEX_Vprord_xmm_k1z_xmmm128b32_imm8
								0x01,// Full_128
							0x11,// HkWIb_3b
								0x6D,// YMM0
								0xF5, 0x0C,// EVEX_Vprord_ymm_k1z_ymmm256b32_imm8
								0x02,// Full_256
							0x11,// HkWIb_3b
								0x8D,// ZMM0
								0xF6, 0x0C,// EVEX_Vprord_zmm_k1z_zmmm512b32_imm8
								0x03,// Full_512
						0x09,// VectorLength
							0x11,// HkWIb_3b
								0x4D,// XMM0
								0xF7, 0x0C,// EVEX_Vprorq_xmm_k1z_xmmm128b64_imm8
								0x01,// Full_128
							0x11,// HkWIb_3b
								0x6D,// YMM0
								0xF8, 0x0C,// EVEX_Vprorq_ymm_k1z_ymmm256b64_imm8
								0x02,// Full_256
							0x11,// HkWIb_3b
								0x8D,// ZMM0
								0xF9, 0x0C,// EVEX_Vprorq_zmm_k1z_zmmm512b64_imm8
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 1 = 0x01
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x11,// HkWIb_3b
								0x4D,// XMM0
								0xFA, 0x0C,// EVEX_Vprold_xmm_k1z_xmmm128b32_imm8
								0x01,// Full_128
							0x11,// HkWIb_3b
								0x6D,// YMM0
								0xFB, 0x0C,// EVEX_Vprold_ymm_k1z_ymmm256b32_imm8
								0x02,// Full_256
							0x11,// HkWIb_3b
								0x8D,// ZMM0
								0xFC, 0x0C,// EVEX_Vprold_zmm_k1z_zmmm512b32_imm8
								0x03,// Full_512
						0x09,// VectorLength
							0x11,// HkWIb_3b
								0x4D,// XMM0
								0xFD, 0x0C,// EVEX_Vprolq_xmm_k1z_xmmm128b64_imm8
								0x01,// Full_128
							0x11,// HkWIb_3b
								0x6D,// YMM0
								0xFE, 0x0C,// EVEX_Vprolq_ymm_k1z_ymmm256b64_imm8
								0x02,// Full_256
							0x11,// HkWIb_3b
								0x8D,// ZMM0
								0xFF, 0x0C,// EVEX_Vprolq_zmm_k1z_zmmm512b64_imm8
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 2 = 0x02
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x11,// HkWIb_3b
								0x4D,// XMM0
								0x84, 0x0D,// EVEX_Vpsrld_xmm_k1z_xmmm128b32_imm8
								0x01,// Full_128
							0x11,// HkWIb_3b
								0x6D,// YMM0
								0x85, 0x0D,// EVEX_Vpsrld_ymm_k1z_ymmm256b32_imm8
								0x02,// Full_256
							0x11,// HkWIb_3b
								0x8D,// ZMM0
								0x86, 0x0D,// EVEX_Vpsrld_zmm_k1z_zmmm512b32_imm8
								0x03,// Full_512
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 3 = 0x03
				0x00,// Invalid

				// 4 = 0x04
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x11,// HkWIb_3b
								0x4D,// XMM0
								0x8B, 0x0D,// EVEX_Vpsrad_xmm_k1z_xmmm128b32_imm8
								0x01,// Full_128
							0x11,// HkWIb_3b
								0x6D,// YMM0
								0x8C, 0x0D,// EVEX_Vpsrad_ymm_k1z_ymmm256b32_imm8
								0x02,// Full_256
							0x11,// HkWIb_3b
								0x8D,// ZMM0
								0x8D, 0x0D,// EVEX_Vpsrad_zmm_k1z_zmmm512b32_imm8
								0x03,// Full_512
						0x09,// VectorLength
							0x11,// HkWIb_3b
								0x4D,// XMM0
								0x8E, 0x0D,// EVEX_Vpsraq_xmm_k1z_xmmm128b64_imm8
								0x01,// Full_128
							0x11,// HkWIb_3b
								0x6D,// YMM0
								0x8F, 0x0D,// EVEX_Vpsraq_ymm_k1z_ymmm256b64_imm8
								0x02,// Full_256
							0x11,// HkWIb_3b
								0x8D,// ZMM0
								0x90, 0x0D,// EVEX_Vpsraq_zmm_k1z_zmmm512b64_imm8
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 5 = 0x05
				0x00,// Invalid

				// 6 = 0x06
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x11,// HkWIb_3b
								0x4D,// XMM0
								0x95, 0x0D,// EVEX_Vpslld_xmm_k1z_xmmm128b32_imm8
								0x01,// Full_128
							0x11,// HkWIb_3b
								0x6D,// YMM0
								0x96, 0x0D,// EVEX_Vpslld_ymm_k1z_ymmm256b32_imm8
								0x02,// Full_256
							0x11,// HkWIb_3b
								0x8D,// ZMM0
								0x97, 0x0D,// EVEX_Vpslld_zmm_k1z_zmmm512b32_imm8
								0x03,// Full_512
						0x00,// Invalid
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
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x11,// HkWIb_3b
								0x4D,// XMM0
								0x9C, 0x0D,// EVEX_Vpsrlq_xmm_k1z_xmmm128b64_imm8
								0x01,// Full_128
							0x11,// HkWIb_3b
								0x6D,// YMM0
								0x9D, 0x0D,// EVEX_Vpsrlq_ymm_k1z_ymmm256b64_imm8
								0x02,// Full_256
							0x11,// HkWIb_3b
								0x8D,// ZMM0
								0x9E, 0x0D,// EVEX_Vpsrlq_zmm_k1z_zmmm512b64_imm8
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 3 = 0x03
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x12,// HWIb
							0x4D,// XMM0
							0xA2, 0x0D,// EVEX_Vpsrldq_xmm_xmmm128_imm8
							0x07,// Full_Mem_128
						0x12,// HWIb
							0x6D,// YMM0
							0xA3, 0x0D,// EVEX_Vpsrldq_ymm_ymmm256_imm8
							0x08,// Full_Mem_256
						0x12,// HWIb
							0x8D,// ZMM0
							0xA4, 0x0D,// EVEX_Vpsrldq_zmm_zmmm512_imm8
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 4 = 0x04
				0x01,// Invalid2

				// 6 = 0x06
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x11,// HkWIb_3b
								0x4D,// XMM0
								0xA9, 0x0D,// EVEX_Vpsllq_xmm_k1z_xmmm128b64_imm8
								0x01,// Full_128
							0x11,// HkWIb_3b
								0x6D,// YMM0
								0xAA, 0x0D,// EVEX_Vpsllq_ymm_k1z_ymmm256b64_imm8
								0x02,// Full_256
							0x11,// HkWIb_3b
								0x8D,// ZMM0
								0xAB, 0x0D,// EVEX_Vpsllq_zmm_k1z_zmmm512b64_imm8
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 7 = 0x07
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x12,// HWIb
							0x4D,// XMM0
							0xAF, 0x0D,// EVEX_Vpslldq_xmm_xmmm128_imm8
							0x07,// Full_Mem_128
						0x12,// HWIb
							0x6D,// YMM0
							0xB0, 0x0D,// EVEX_Vpslldq_ymm_ymmm256_imm8
							0x08,// Full_Mem_256
						0x12,// HWIb
							0x8D,// ZMM0
							0xB1, 0x0D,// EVEX_Vpslldq_zmm_zmmm512_imm8
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// handlers_Grp_0F38C6
				0x01,// ArrayReference
				0x08,// 0x8
				// 0 = 0x00
				0x00,// Invalid

				// 1 = 0x01
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x00,// Invalid
							0x00,// Invalid
							0x3F,// VSIB_k1
								0x8D,// ZMM0
								0x8C, 0x1C,// EVEX_Vgatherpf0dps_vm32z_k1
								0x0A,// Tuple1_Scalar
						0x09,// VectorLength
							0x00,// Invalid
							0x00,// Invalid
							0x3F,// VSIB_k1
								0x6D,// YMM0
								0x8D, 0x1C,// EVEX_Vgatherpf0dpd_vm32y_k1
								0x0A,// Tuple1_Scalar
					0x00,// Invalid
					0x00,// Invalid

				// 2 = 0x02
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x00,// Invalid
							0x00,// Invalid
							0x3F,// VSIB_k1
								0x8D,// ZMM0
								0x8E, 0x1C,// EVEX_Vgatherpf1dps_vm32z_k1
								0x0A,// Tuple1_Scalar
						0x09,// VectorLength
							0x00,// Invalid
							0x00,// Invalid
							0x3F,// VSIB_k1
								0x6D,// YMM0
								0x8F, 0x1C,// EVEX_Vgatherpf1dpd_vm32y_k1
								0x0A,// Tuple1_Scalar
					0x00,// Invalid
					0x00,// Invalid

				// 3 = 0x03
				0x01,// Invalid2

				// 5 = 0x05
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x00,// Invalid
							0x00,// Invalid
							0x3F,// VSIB_k1
								0x8D,// ZMM0
								0x90, 0x1C,// EVEX_Vscatterpf0dps_vm32z_k1
								0x0A,// Tuple1_Scalar
						0x09,// VectorLength
							0x00,// Invalid
							0x00,// Invalid
							0x3F,// VSIB_k1
								0x6D,// YMM0
								0x91, 0x1C,// EVEX_Vscatterpf0dpd_vm32y_k1
								0x0A,// Tuple1_Scalar
					0x00,// Invalid
					0x00,// Invalid

				// 6 = 0x06
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x00,// Invalid
							0x00,// Invalid
							0x3F,// VSIB_k1
								0x8D,// ZMM0
								0x92, 0x1C,// EVEX_Vscatterpf1dps_vm32z_k1
								0x0A,// Tuple1_Scalar
						0x09,// VectorLength
							0x00,// Invalid
							0x00,// Invalid
							0x3F,// VSIB_k1
								0x6D,// YMM0
								0x93, 0x1C,// EVEX_Vscatterpf1dpd_vm32y_k1
								0x0A,// Tuple1_Scalar
					0x00,// Invalid
					0x00,// Invalid

				// 7 = 0x07
				0x00,// Invalid

				// handlers_Grp_0F38C7
				0x01,// ArrayReference
				0x08,// 0x8
				// 0 = 0x00
				0x00,// Invalid

				// 1 = 0x01
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x00,// Invalid
							0x00,// Invalid
							0x3F,// VSIB_k1
								0x8D,// ZMM0
								0x94, 0x1C,// EVEX_Vgatherpf0qps_vm64z_k1
								0x0A,// Tuple1_Scalar
						0x09,// VectorLength
							0x00,// Invalid
							0x00,// Invalid
							0x3F,// VSIB_k1
								0x8D,// ZMM0
								0x95, 0x1C,// EVEX_Vgatherpf0qpd_vm64z_k1
								0x0A,// Tuple1_Scalar
					0x00,// Invalid
					0x00,// Invalid

				// 2 = 0x02
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x00,// Invalid
							0x00,// Invalid
							0x3F,// VSIB_k1
								0x8D,// ZMM0
								0x96, 0x1C,// EVEX_Vgatherpf1qps_vm64z_k1
								0x0A,// Tuple1_Scalar
						0x09,// VectorLength
							0x00,// Invalid
							0x00,// Invalid
							0x3F,// VSIB_k1
								0x8D,// ZMM0
								0x97, 0x1C,// EVEX_Vgatherpf1qpd_vm64z_k1
								0x0A,// Tuple1_Scalar
					0x00,// Invalid
					0x00,// Invalid

				// 3 = 0x03
				0x01,// Invalid2

				// 5 = 0x05
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x00,// Invalid
							0x00,// Invalid
							0x3F,// VSIB_k1
								0x8D,// ZMM0
								0x98, 0x1C,// EVEX_Vscatterpf0qps_vm64z_k1
								0x0A,// Tuple1_Scalar
						0x09,// VectorLength
							0x00,// Invalid
							0x00,// Invalid
							0x3F,// VSIB_k1
								0x8D,// ZMM0
								0x99, 0x1C,// EVEX_Vscatterpf0qpd_vm64z_k1
								0x0A,// Tuple1_Scalar
					0x00,// Invalid
					0x00,// Invalid

				// 6 = 0x06
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x00,// Invalid
							0x00,// Invalid
							0x3F,// VSIB_k1
								0x8D,// ZMM0
								0x9A, 0x1C,// EVEX_Vscatterpf1qps_vm64z_k1
								0x0A,// Tuple1_Scalar
						0x09,// VectorLength
							0x00,// Invalid
							0x00,// Invalid
							0x3F,// VSIB_k1
								0x8D,// ZMM0
								0x9B, 0x1C,// EVEX_Vscatterpf1qpd_vm64z_k1
								0x0A,// Tuple1_Scalar
					0x00,// Invalid
					0x00,// Invalid

				// 7 = 0x07
				0x00,// Invalid

				// ThreeByteHandlers_0F38XX
				0x01,// ArrayReference
				0x80, 0x02,// 0x100
				// 0 = 0x00
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x29,// VkHW_3
							0x4D,// XMM0
							0x86, 0x14,// EVEX_Vpshufb_xmm_k1z_xmm_xmmm128
							0x07,// Full_Mem_128
						0x29,// VkHW_3
							0x6D,// YMM0
							0x87, 0x14,// EVEX_Vpshufb_ymm_k1z_ymm_ymmm256
							0x08,// Full_Mem_256
						0x29,// VkHW_3
							0x8D,// ZMM0
							0x88, 0x14,// EVEX_Vpshufb_zmm_k1z_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 1 = 0x01
				0x02,// Dup
					0x03,// 3
					0x00,// Invalid

				// 4 = 0x04
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x29,// VkHW_3
							0x4D,// XMM0
							0x99, 0x14,// EVEX_Vpmaddubsw_xmm_k1z_xmm_xmmm128
							0x07,// Full_Mem_128
						0x29,// VkHW_3
							0x6D,// YMM0
							0x9A, 0x14,// EVEX_Vpmaddubsw_ymm_k1z_ymm_ymmm256
							0x08,// Full_Mem_256
						0x29,// VkHW_3
							0x8D,// ZMM0
							0x9B, 0x14,// EVEX_Vpmaddubsw_zmm_k1z_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 5 = 0x05
				0x02,// Dup
					0x06,// 6
					0x00,// Invalid

				// 11 = 0x0B
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x29,// VkHW_3
							0x4D,// XMM0
							0xB8, 0x14,// EVEX_Vpmulhrsw_xmm_k1z_xmm_xmmm128
							0x07,// Full_Mem_128
						0x29,// VkHW_3
							0x6D,// YMM0
							0xB9, 0x14,// EVEX_Vpmulhrsw_ymm_k1z_ymm_ymmm256
							0x08,// Full_Mem_256
						0x29,// VkHW_3
							0x8D,// ZMM0
							0xBA, 0x14,// EVEX_Vpmulhrsw_zmm_k1z_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 12 = 0x0C
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xBD, 0x14,// EVEX_Vpermilps_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xBE, 0x14,// EVEX_Vpermilps_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xBF, 0x14,// EVEX_Vpermilps_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 13 = 0x0D
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xC2, 0x14,// EVEX_Vpermilpd_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xC3, 0x14,// EVEX_Vpermilpd_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xC4, 0x14,// EVEX_Vpermilpd_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 14 = 0x0E
				0x01,// Invalid2

				// 16 = 0x10
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x29,// VkHW_3
								0x4D,// XMM0
								0xCA, 0x14,// EVEX_Vpsrlvw_xmm_k1z_xmm_xmmm128
								0x07,// Full_Mem_128
							0x29,// VkHW_3
								0x6D,// YMM0
								0xCB, 0x14,// EVEX_Vpsrlvw_ymm_k1z_ymm_ymmm256
								0x08,// Full_Mem_256
							0x29,// VkHW_3
								0x8D,// ZMM0
								0xCC, 0x14,// EVEX_Vpsrlvw_zmm_k1z_zmm_zmmm512
								0x09,// Full_Mem_512
					0x07,// W
						0x09,// VectorLength
							0x46,// WkV_4a
								0x4D,// XMM0
								0x4D,// XMM0
								0xCD, 0x14,// EVEX_Vpmovuswb_xmmm64_k1z_xmm
								0x15,// Half_Mem_128
							0x46,// WkV_4a
								0x4D,// XMM0
								0x6D,// YMM0
								0xCE, 0x14,// EVEX_Vpmovuswb_xmmm128_k1z_ymm
								0x16,// Half_Mem_256
							0x46,// WkV_4a
								0x6D,// YMM0
								0x8D,// ZMM0
								0xCF, 0x14,// EVEX_Vpmovuswb_ymmm256_k1z_zmm
								0x17,// Half_Mem_512
						0x00,// Invalid
					0x00,// Invalid

				// 17 = 0x11
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x29,// VkHW_3
								0x4D,// XMM0
								0xD0, 0x14,// EVEX_Vpsravw_xmm_k1z_xmm_xmmm128
								0x07,// Full_Mem_128
							0x29,// VkHW_3
								0x6D,// YMM0
								0xD1, 0x14,// EVEX_Vpsravw_ymm_k1z_ymm_ymmm256
								0x08,// Full_Mem_256
							0x29,// VkHW_3
								0x8D,// ZMM0
								0xD2, 0x14,// EVEX_Vpsravw_zmm_k1z_zmm_zmmm512
								0x09,// Full_Mem_512
					0x07,// W
						0x09,// VectorLength
							0x46,// WkV_4a
								0x4D,// XMM0
								0x4D,// XMM0
								0xD3, 0x14,// EVEX_Vpmovusdb_xmmm32_k1z_xmm
								0x18,// Quarter_Mem_128
							0x46,// WkV_4a
								0x4D,// XMM0
								0x6D,// YMM0
								0xD4, 0x14,// EVEX_Vpmovusdb_xmmm64_k1z_ymm
								0x19,// Quarter_Mem_256
							0x46,// WkV_4a
								0x4D,// XMM0
								0x8D,// ZMM0
								0xD5, 0x14,// EVEX_Vpmovusdb_xmmm128_k1z_zmm
								0x1A,// Quarter_Mem_512
						0x00,// Invalid
					0x00,// Invalid

				// 18 = 0x12
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x29,// VkHW_3
								0x4D,// XMM0
								0xD6, 0x14,// EVEX_Vpsllvw_xmm_k1z_xmm_xmmm128
								0x07,// Full_Mem_128
							0x29,// VkHW_3
								0x6D,// YMM0
								0xD7, 0x14,// EVEX_Vpsllvw_ymm_k1z_ymm_ymmm256
								0x08,// Full_Mem_256
							0x29,// VkHW_3
								0x8D,// ZMM0
								0xD8, 0x14,// EVEX_Vpsllvw_zmm_k1z_zmm_zmmm512
								0x09,// Full_Mem_512
					0x07,// W
						0x09,// VectorLength
							0x46,// WkV_4a
								0x4D,// XMM0
								0x4D,// XMM0
								0xD9, 0x14,// EVEX_Vpmovusqb_xmmm16_k1z_xmm
								0x1B,// Eighth_Mem_128
							0x46,// WkV_4a
								0x4D,// XMM0
								0x6D,// YMM0
								0xDA, 0x14,// EVEX_Vpmovusqb_xmmm32_k1z_ymm
								0x1C,// Eighth_Mem_256
							0x46,// WkV_4a
								0x4D,// XMM0
								0x8D,// ZMM0
								0xDB, 0x14,// EVEX_Vpmovusqb_xmmm64_k1z_zmm
								0x1D,// Eighth_Mem_512
						0x00,// Invalid
					0x00,// Invalid

				// 19 = 0x13
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x0A,// VectorLength_er
							0x3A,// VkW_er_6
								0x4D,// XMM0
								0x4D,// XMM0
								0xDE, 0x14,// EVEX_Vcvtph2ps_xmm_k1z_xmmm64
								0x15,// Half_Mem_128
								0x01,// true
								0x00,// false
							0x3A,// VkW_er_6
								0x6D,// YMM0
								0x4D,// XMM0
								0xDF, 0x14,// EVEX_Vcvtph2ps_ymm_k1z_xmmm128
								0x16,// Half_Mem_256
								0x01,// true
								0x00,// false
							0x3A,// VkW_er_6
								0x8D,// ZMM0
								0x6D,// YMM0
								0xE0, 0x14,// EVEX_Vcvtph2ps_zmm_k1z_ymmm256_sae
								0x17,// Half_Mem_512
								0x01,// true
								0x00,// false
						0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x46,// WkV_4a
								0x4D,// XMM0
								0x4D,// XMM0
								0xE1, 0x14,// EVEX_Vpmovusdw_xmmm64_k1z_xmm
								0x15,// Half_Mem_128
							0x46,// WkV_4a
								0x4D,// XMM0
								0x6D,// YMM0
								0xE2, 0x14,// EVEX_Vpmovusdw_xmmm128_k1z_ymm
								0x16,// Half_Mem_256
							0x46,// WkV_4a
								0x6D,// YMM0
								0x8D,// ZMM0
								0xE3, 0x14,// EVEX_Vpmovusdw_ymmm256_k1z_zmm
								0x17,// Half_Mem_512
						0x00,// Invalid
					0x00,// Invalid

				// 20 = 0x14
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xE5, 0x14,// EVEX_Vprorvd_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xE6, 0x14,// EVEX_Vprorvd_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xE7, 0x14,// EVEX_Vprorvd_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xE8, 0x14,// EVEX_Vprorvq_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xE9, 0x14,// EVEX_Vprorvq_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xEA, 0x14,// EVEX_Vprorvq_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x07,// W
						0x09,// VectorLength
							0x46,// WkV_4a
								0x4D,// XMM0
								0x4D,// XMM0
								0xEB, 0x14,// EVEX_Vpmovusqw_xmmm32_k1z_xmm
								0x18,// Quarter_Mem_128
							0x46,// WkV_4a
								0x4D,// XMM0
								0x6D,// YMM0
								0xEC, 0x14,// EVEX_Vpmovusqw_xmmm64_k1z_ymm
								0x19,// Quarter_Mem_256
							0x46,// WkV_4a
								0x4D,// XMM0
								0x8D,// ZMM0
								0xED, 0x14,// EVEX_Vpmovusqw_xmmm128_k1z_zmm
								0x1A,// Quarter_Mem_512
						0x00,// Invalid
					0x00,// Invalid

				// 21 = 0x15
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xEF, 0x14,// EVEX_Vprolvd_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xF0, 0x14,// EVEX_Vprolvd_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xF1, 0x14,// EVEX_Vprolvd_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xF2, 0x14,// EVEX_Vprolvq_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xF3, 0x14,// EVEX_Vprolvq_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xF4, 0x14,// EVEX_Vprolvq_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x07,// W
						0x09,// VectorLength
							0x46,// WkV_4a
								0x4D,// XMM0
								0x4D,// XMM0
								0xF5, 0x14,// EVEX_Vpmovusqd_xmmm64_k1z_xmm
								0x15,// Half_Mem_128
							0x46,// WkV_4a
								0x4D,// XMM0
								0x6D,// YMM0
								0xF6, 0x14,// EVEX_Vpmovusqd_xmmm128_k1z_ymm
								0x16,// Half_Mem_256
							0x46,// WkV_4a
								0x6D,// YMM0
								0x8D,// ZMM0
								0xF7, 0x14,// EVEX_Vpmovusqd_ymmm256_k1z_zmm
								0x17,// Half_Mem_512
						0x00,// Invalid
					0x00,// Invalid

				// 22 = 0x16
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x00,// Invalid
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xF9, 0x14,// EVEX_Vpermps_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xFA, 0x14,// EVEX_Vpermps_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x09,// VectorLength
							0x00,// Invalid
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xFB, 0x14,// EVEX_Vpermpd_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xFC, 0x14,// EVEX_Vpermpd_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 23 = 0x17
				0x00,// Invalid

				// 24 = 0x18
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x36,// VkW_4
								0x4D,// XMM0
								0x4D,// XMM0
								0x82, 0x15,// EVEX_Vbroadcastss_xmm_k1z_xmmm32
								0x0A,// Tuple1_Scalar
							0x36,// VkW_4
								0x6D,// YMM0
								0x4D,// XMM0
								0x83, 0x15,// EVEX_Vbroadcastss_ymm_k1z_xmmm32
								0x0A,// Tuple1_Scalar
							0x36,// VkW_4
								0x8D,// ZMM0
								0x4D,// XMM0
								0x84, 0x15,// EVEX_Vbroadcastss_zmm_k1z_xmmm32
								0x0A,// Tuple1_Scalar
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 25 = 0x19
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x00,// Invalid
							0x36,// VkW_4
								0x6D,// YMM0
								0x4D,// XMM0
								0x86, 0x15,// EVEX_Vbroadcastf32x2_ymm_k1z_xmmm64
								0x11,// Tuple2
							0x36,// VkW_4
								0x8D,// ZMM0
								0x4D,// XMM0
								0x87, 0x15,// EVEX_Vbroadcastf32x2_zmm_k1z_xmmm64
								0x11,// Tuple2
						0x09,// VectorLength
							0x00,// Invalid
							0x36,// VkW_4
								0x6D,// YMM0
								0x4D,// XMM0
								0x88, 0x15,// EVEX_Vbroadcastsd_ymm_k1z_xmmm64
								0x0A,// Tuple1_Scalar
							0x36,// VkW_4
								0x8D,// ZMM0
								0x4D,// XMM0
								0x89, 0x15,// EVEX_Vbroadcastsd_zmm_k1z_xmmm64
								0x0A,// Tuple1_Scalar
					0x00,// Invalid
					0x00,// Invalid

				// 26 = 0x1A
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x00,// Invalid
							0x33,// VkM
								0x6D,// YMM0
								0x8B, 0x15,// EVEX_Vbroadcastf32x4_ymm_k1z_m128
								0x12,// Tuple4
							0x33,// VkM
								0x8D,// ZMM0
								0x8C, 0x15,// EVEX_Vbroadcastf32x4_zmm_k1z_m128
								0x12,// Tuple4
						0x09,// VectorLength
							0x00,// Invalid
							0x33,// VkM
								0x6D,// YMM0
								0x8D, 0x15,// EVEX_Vbroadcastf64x2_ymm_k1z_m128
								0x11,// Tuple2
							0x33,// VkM
								0x8D,// ZMM0
								0x8E, 0x15,// EVEX_Vbroadcastf64x2_zmm_k1z_m128
								0x11,// Tuple2
					0x00,// Invalid
					0x00,// Invalid

				// 27 = 0x1B
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x00,// Invalid
							0x00,// Invalid
							0x33,// VkM
								0x8D,// ZMM0
								0x8F, 0x15,// EVEX_Vbroadcastf32x8_zmm_k1z_m256
								0x13,// Tuple8
						0x09,// VectorLength
							0x00,// Invalid
							0x00,// Invalid
							0x33,// VkM
								0x8D,// ZMM0
								0x90, 0x15,// EVEX_Vbroadcastf64x4_zmm_k1z_m256
								0x12,// Tuple4
					0x00,// Invalid
					0x00,// Invalid

				// 28 = 0x1C
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x34,// VkW_3
							0x4D,// XMM0
							0x95, 0x15,// EVEX_Vpabsb_xmm_k1z_xmmm128
							0x07,// Full_Mem_128
						0x34,// VkW_3
							0x6D,// YMM0
							0x96, 0x15,// EVEX_Vpabsb_ymm_k1z_ymmm256
							0x08,// Full_Mem_256
						0x34,// VkW_3
							0x8D,// ZMM0
							0x97, 0x15,// EVEX_Vpabsb_zmm_k1z_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 29 = 0x1D
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x34,// VkW_3
							0x4D,// XMM0
							0x9C, 0x15,// EVEX_Vpabsw_xmm_k1z_xmmm128
							0x07,// Full_Mem_128
						0x34,// VkW_3
							0x6D,// YMM0
							0x9D, 0x15,// EVEX_Vpabsw_ymm_k1z_ymmm256
							0x08,// Full_Mem_256
						0x34,// VkW_3
							0x8D,// ZMM0
							0x9E, 0x15,// EVEX_Vpabsw_zmm_k1z_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 30 = 0x1E
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x35,// VkW_3b
								0x4D,// XMM0
								0xA3, 0x15,// EVEX_Vpabsd_xmm_k1z_xmmm128b32
								0x01,// Full_128
							0x35,// VkW_3b
								0x6D,// YMM0
								0xA4, 0x15,// EVEX_Vpabsd_ymm_k1z_ymmm256b32
								0x02,// Full_256
							0x35,// VkW_3b
								0x8D,// ZMM0
								0xA5, 0x15,// EVEX_Vpabsd_zmm_k1z_zmmm512b32
								0x03,// Full_512
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 31 = 0x1F
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x35,// VkW_3b
								0x4D,// XMM0
								0xA6, 0x15,// EVEX_Vpabsq_xmm_k1z_xmmm128b64
								0x01,// Full_128
							0x35,// VkW_3b
								0x6D,// YMM0
								0xA7, 0x15,// EVEX_Vpabsq_ymm_k1z_ymmm256b64
								0x02,// Full_256
							0x35,// VkW_3b
								0x8D,// ZMM0
								0xA8, 0x15,// EVEX_Vpabsq_zmm_k1z_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 32 = 0x20
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x36,// VkW_4
							0x4D,// XMM0
							0x4D,// XMM0
							0xAC, 0x15,// EVEX_Vpmovsxbw_xmm_k1z_xmmm64
							0x15,// Half_Mem_128
						0x36,// VkW_4
							0x6D,// YMM0
							0x4D,// XMM0
							0xAD, 0x15,// EVEX_Vpmovsxbw_ymm_k1z_xmmm128
							0x16,// Half_Mem_256
						0x36,// VkW_4
							0x8D,// ZMM0
							0x6D,// YMM0
							0xAE, 0x15,// EVEX_Vpmovsxbw_zmm_k1z_ymmm256
							0x17,// Half_Mem_512
					0x07,// W
						0x09,// VectorLength
							0x46,// WkV_4a
								0x4D,// XMM0
								0x4D,// XMM0
								0xAF, 0x15,// EVEX_Vpmovswb_xmmm64_k1z_xmm
								0x15,// Half_Mem_128
							0x46,// WkV_4a
								0x4D,// XMM0
								0x6D,// YMM0
								0xB0, 0x15,// EVEX_Vpmovswb_xmmm128_k1z_ymm
								0x16,// Half_Mem_256
							0x46,// WkV_4a
								0x6D,// YMM0
								0x8D,// ZMM0
								0xB1, 0x15,// EVEX_Vpmovswb_ymmm256_k1z_zmm
								0x17,// Half_Mem_512
						0x00,// Invalid
					0x00,// Invalid

				// 33 = 0x21
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x36,// VkW_4
							0x4D,// XMM0
							0x4D,// XMM0
							0xB5, 0x15,// EVEX_Vpmovsxbd_xmm_k1z_xmmm32
							0x18,// Quarter_Mem_128
						0x36,// VkW_4
							0x6D,// YMM0
							0x4D,// XMM0
							0xB6, 0x15,// EVEX_Vpmovsxbd_ymm_k1z_xmmm64
							0x19,// Quarter_Mem_256
						0x36,// VkW_4
							0x8D,// ZMM0
							0x4D,// XMM0
							0xB7, 0x15,// EVEX_Vpmovsxbd_zmm_k1z_xmmm128
							0x1A,// Quarter_Mem_512
					0x07,// W
						0x09,// VectorLength
							0x46,// WkV_4a
								0x4D,// XMM0
								0x4D,// XMM0
								0xB8, 0x15,// EVEX_Vpmovsdb_xmmm32_k1z_xmm
								0x18,// Quarter_Mem_128
							0x46,// WkV_4a
								0x4D,// XMM0
								0x6D,// YMM0
								0xB9, 0x15,// EVEX_Vpmovsdb_xmmm64_k1z_ymm
								0x19,// Quarter_Mem_256
							0x46,// WkV_4a
								0x4D,// XMM0
								0x8D,// ZMM0
								0xBA, 0x15,// EVEX_Vpmovsdb_xmmm128_k1z_zmm
								0x1A,// Quarter_Mem_512
						0x00,// Invalid
					0x00,// Invalid

				// 34 = 0x22
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x36,// VkW_4
							0x4D,// XMM0
							0x4D,// XMM0
							0xBE, 0x15,// EVEX_Vpmovsxbq_xmm_k1z_xmmm16
							0x1B,// Eighth_Mem_128
						0x36,// VkW_4
							0x6D,// YMM0
							0x4D,// XMM0
							0xBF, 0x15,// EVEX_Vpmovsxbq_ymm_k1z_xmmm32
							0x1C,// Eighth_Mem_256
						0x36,// VkW_4
							0x8D,// ZMM0
							0x4D,// XMM0
							0xC0, 0x15,// EVEX_Vpmovsxbq_zmm_k1z_xmmm64
							0x1D,// Eighth_Mem_512
					0x07,// W
						0x09,// VectorLength
							0x46,// WkV_4a
								0x4D,// XMM0
								0x4D,// XMM0
								0xC1, 0x15,// EVEX_Vpmovsqb_xmmm16_k1z_xmm
								0x1B,// Eighth_Mem_128
							0x46,// WkV_4a
								0x4D,// XMM0
								0x6D,// YMM0
								0xC2, 0x15,// EVEX_Vpmovsqb_xmmm32_k1z_ymm
								0x1C,// Eighth_Mem_256
							0x46,// WkV_4a
								0x4D,// XMM0
								0x8D,// ZMM0
								0xC3, 0x15,// EVEX_Vpmovsqb_xmmm64_k1z_zmm
								0x1D,// Eighth_Mem_512
						0x00,// Invalid
					0x00,// Invalid

				// 35 = 0x23
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x36,// VkW_4
							0x4D,// XMM0
							0x4D,// XMM0
							0xC7, 0x15,// EVEX_Vpmovsxwd_xmm_k1z_xmmm64
							0x15,// Half_Mem_128
						0x36,// VkW_4
							0x6D,// YMM0
							0x4D,// XMM0
							0xC8, 0x15,// EVEX_Vpmovsxwd_ymm_k1z_xmmm128
							0x16,// Half_Mem_256
						0x36,// VkW_4
							0x8D,// ZMM0
							0x6D,// YMM0
							0xC9, 0x15,// EVEX_Vpmovsxwd_zmm_k1z_ymmm256
							0x17,// Half_Mem_512
					0x07,// W
						0x09,// VectorLength
							0x46,// WkV_4a
								0x4D,// XMM0
								0x4D,// XMM0
								0xCA, 0x15,// EVEX_Vpmovsdw_xmmm64_k1z_xmm
								0x15,// Half_Mem_128
							0x46,// WkV_4a
								0x4D,// XMM0
								0x6D,// YMM0
								0xCB, 0x15,// EVEX_Vpmovsdw_xmmm128_k1z_ymm
								0x16,// Half_Mem_256
							0x46,// WkV_4a
								0x6D,// YMM0
								0x8D,// ZMM0
								0xCC, 0x15,// EVEX_Vpmovsdw_ymmm256_k1z_zmm
								0x17,// Half_Mem_512
						0x00,// Invalid
					0x00,// Invalid

				// 36 = 0x24
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x36,// VkW_4
							0x4D,// XMM0
							0x4D,// XMM0
							0xD0, 0x15,// EVEX_Vpmovsxwq_xmm_k1z_xmmm32
							0x18,// Quarter_Mem_128
						0x36,// VkW_4
							0x6D,// YMM0
							0x4D,// XMM0
							0xD1, 0x15,// EVEX_Vpmovsxwq_ymm_k1z_xmmm64
							0x19,// Quarter_Mem_256
						0x36,// VkW_4
							0x8D,// ZMM0
							0x4D,// XMM0
							0xD2, 0x15,// EVEX_Vpmovsxwq_zmm_k1z_xmmm128
							0x1A,// Quarter_Mem_512
					0x07,// W
						0x09,// VectorLength
							0x46,// WkV_4a
								0x4D,// XMM0
								0x4D,// XMM0
								0xD3, 0x15,// EVEX_Vpmovsqw_xmmm32_k1z_xmm
								0x18,// Quarter_Mem_128
							0x46,// WkV_4a
								0x4D,// XMM0
								0x6D,// YMM0
								0xD4, 0x15,// EVEX_Vpmovsqw_xmmm64_k1z_ymm
								0x19,// Quarter_Mem_256
							0x46,// WkV_4a
								0x4D,// XMM0
								0x8D,// ZMM0
								0xD5, 0x15,// EVEX_Vpmovsqw_xmmm128_k1z_zmm
								0x1A,// Quarter_Mem_512
						0x00,// Invalid
					0x00,// Invalid

				// 37 = 0x25
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x36,// VkW_4
								0x4D,// XMM0
								0x4D,// XMM0
								0xD9, 0x15,// EVEX_Vpmovsxdq_xmm_k1z_xmmm64
								0x15,// Half_Mem_128
							0x36,// VkW_4
								0x6D,// YMM0
								0x4D,// XMM0
								0xDA, 0x15,// EVEX_Vpmovsxdq_ymm_k1z_xmmm128
								0x16,// Half_Mem_256
							0x36,// VkW_4
								0x8D,// ZMM0
								0x6D,// YMM0
								0xDB, 0x15,// EVEX_Vpmovsxdq_zmm_k1z_ymmm256
								0x17,// Half_Mem_512
						0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x46,// WkV_4a
								0x4D,// XMM0
								0x4D,// XMM0
								0xDC, 0x15,// EVEX_Vpmovsqd_xmmm64_k1z_xmm
								0x15,// Half_Mem_128
							0x46,// WkV_4a
								0x4D,// XMM0
								0x6D,// YMM0
								0xDD, 0x15,// EVEX_Vpmovsqd_xmmm128_k1z_ymm
								0x16,// Half_Mem_256
							0x46,// WkV_4a
								0x6D,// YMM0
								0x8D,// ZMM0
								0xDE, 0x15,// EVEX_Vpmovsqd_ymmm256_k1z_zmm
								0x17,// Half_Mem_512
						0x00,// Invalid
					0x00,// Invalid

				// 38 = 0x26
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x13,// KkHW_3
								0x4D,// XMM0
								0xDF, 0x15,// EVEX_Vptestmb_k_k1_xmm_xmmm128
								0x07,// Full_Mem_128
							0x13,// KkHW_3
								0x6D,// YMM0
								0xE0, 0x15,// EVEX_Vptestmb_k_k1_ymm_ymmm256
								0x08,// Full_Mem_256
							0x13,// KkHW_3
								0x8D,// ZMM0
								0xE1, 0x15,// EVEX_Vptestmb_k_k1_zmm_zmmm512
								0x09,// Full_Mem_512
						0x09,// VectorLength
							0x13,// KkHW_3
								0x4D,// XMM0
								0xE2, 0x15,// EVEX_Vptestmw_k_k1_xmm_xmmm128
								0x07,// Full_Mem_128
							0x13,// KkHW_3
								0x6D,// YMM0
								0xE3, 0x15,// EVEX_Vptestmw_k_k1_ymm_ymmm256
								0x08,// Full_Mem_256
							0x13,// KkHW_3
								0x8D,// ZMM0
								0xE4, 0x15,// EVEX_Vptestmw_k_k1_zmm_zmmm512
								0x09,// Full_Mem_512
					0x07,// W
						0x09,// VectorLength
							0x13,// KkHW_3
								0x4D,// XMM0
								0xE5, 0x15,// EVEX_Vptestnmb_k_k1_xmm_xmmm128
								0x07,// Full_Mem_128
							0x13,// KkHW_3
								0x6D,// YMM0
								0xE6, 0x15,// EVEX_Vptestnmb_k_k1_ymm_ymmm256
								0x08,// Full_Mem_256
							0x13,// KkHW_3
								0x8D,// ZMM0
								0xE7, 0x15,// EVEX_Vptestnmb_k_k1_zmm_zmmm512
								0x09,// Full_Mem_512
						0x09,// VectorLength
							0x13,// KkHW_3
								0x4D,// XMM0
								0xE8, 0x15,// EVEX_Vptestnmw_k_k1_xmm_xmmm128
								0x07,// Full_Mem_128
							0x13,// KkHW_3
								0x6D,// YMM0
								0xE9, 0x15,// EVEX_Vptestnmw_k_k1_ymm_ymmm256
								0x08,// Full_Mem_256
							0x13,// KkHW_3
								0x8D,// ZMM0
								0xEA, 0x15,// EVEX_Vptestnmw_k_k1_zmm_zmmm512
								0x09,// Full_Mem_512
					0x00,// Invalid

				// 39 = 0x27
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x14,// KkHW_3b
								0x4D,// XMM0
								0xEB, 0x15,// EVEX_Vptestmd_k_k1_xmm_xmmm128b32
								0x01,// Full_128
							0x14,// KkHW_3b
								0x6D,// YMM0
								0xEC, 0x15,// EVEX_Vptestmd_k_k1_ymm_ymmm256b32
								0x02,// Full_256
							0x14,// KkHW_3b
								0x8D,// ZMM0
								0xED, 0x15,// EVEX_Vptestmd_k_k1_zmm_zmmm512b32
								0x03,// Full_512
						0x09,// VectorLength
							0x14,// KkHW_3b
								0x4D,// XMM0
								0xEE, 0x15,// EVEX_Vptestmq_k_k1_xmm_xmmm128b64
								0x01,// Full_128
							0x14,// KkHW_3b
								0x6D,// YMM0
								0xEF, 0x15,// EVEX_Vptestmq_k_k1_ymm_ymmm256b64
								0x02,// Full_256
							0x14,// KkHW_3b
								0x8D,// ZMM0
								0xF0, 0x15,// EVEX_Vptestmq_k_k1_zmm_zmmm512b64
								0x03,// Full_512
					0x07,// W
						0x09,// VectorLength
							0x14,// KkHW_3b
								0x4D,// XMM0
								0xF1, 0x15,// EVEX_Vptestnmd_k_k1_xmm_xmmm128b32
								0x01,// Full_128
							0x14,// KkHW_3b
								0x6D,// YMM0
								0xF2, 0x15,// EVEX_Vptestnmd_k_k1_ymm_ymmm256b32
								0x02,// Full_256
							0x14,// KkHW_3b
								0x8D,// ZMM0
								0xF3, 0x15,// EVEX_Vptestnmd_k_k1_zmm_zmmm512b32
								0x03,// Full_512
						0x09,// VectorLength
							0x14,// KkHW_3b
								0x4D,// XMM0
								0xF4, 0x15,// EVEX_Vptestnmq_k_k1_xmm_xmmm128b64
								0x01,// Full_128
							0x14,// KkHW_3b
								0x6D,// YMM0
								0xF5, 0x15,// EVEX_Vptestnmq_k_k1_ymm_ymmm256b64
								0x02,// Full_256
							0x14,// KkHW_3b
								0x8D,// ZMM0
								0xF6, 0x15,// EVEX_Vptestnmq_k_k1_zmm_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid

				// 40 = 0x28
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xFA, 0x15,// EVEX_Vpmuldq_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xFB, 0x15,// EVEX_Vpmuldq_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xFC, 0x15,// EVEX_Vpmuldq_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x07,// W
						0x09,// VectorLength
							0x24,// VK
								0x4D,// XMM0
								0xFD, 0x15,// EVEX_Vpmovm2b_xmm_k
							0x24,// VK
								0x6D,// YMM0
								0xFE, 0x15,// EVEX_Vpmovm2b_ymm_k
							0x24,// VK
								0x8D,// ZMM0
								0xFF, 0x15,// EVEX_Vpmovm2b_zmm_k
						0x09,// VectorLength
							0x24,// VK
								0x4D,// XMM0
								0x80, 0x16,// EVEX_Vpmovm2w_xmm_k
							0x24,// VK
								0x6D,// YMM0
								0x81, 0x16,// EVEX_Vpmovm2w_ymm_k
							0x24,// VK
								0x8D,// ZMM0
								0x82, 0x16,// EVEX_Vpmovm2w_zmm_k
					0x00,// Invalid

				// 41 = 0x29
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x14,// KkHW_3b
								0x4D,// XMM0
								0x86, 0x16,// EVEX_Vpcmpeqq_k_k1_xmm_xmmm128b64
								0x01,// Full_128
							0x14,// KkHW_3b
								0x6D,// YMM0
								0x87, 0x16,// EVEX_Vpcmpeqq_k_k1_ymm_ymmm256b64
								0x02,// Full_256
							0x14,// KkHW_3b
								0x8D,// ZMM0
								0x88, 0x16,// EVEX_Vpcmpeqq_k_k1_zmm_zmmm512b64
								0x03,// Full_512
					0x07,// W
						0x09,// VectorLength
							0x1C,// KR
								0x4D,// XMM0
								0x89, 0x16,// EVEX_Vpmovb2m_k_xmm
							0x1C,// KR
								0x6D,// YMM0
								0x8A, 0x16,// EVEX_Vpmovb2m_k_ymm
							0x1C,// KR
								0x8D,// ZMM0
								0x8B, 0x16,// EVEX_Vpmovb2m_k_zmm
						0x09,// VectorLength
							0x1C,// KR
								0x4D,// XMM0
								0x8C, 0x16,// EVEX_Vpmovw2m_k_xmm
							0x1C,// KR
								0x6D,// YMM0
								0x8D, 0x16,// EVEX_Vpmovw2m_k_ymm
							0x1C,// KR
								0x8D,// ZMM0
								0x8E, 0x16,// EVEX_Vpmovw2m_k_zmm
					0x00,// Invalid

				// 42 = 0x2A
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x3E,// VM
								0x4D,// XMM0
								0x92, 0x16,// EVEX_Vmovntdqa_xmm_m128
								0x07,// Full_Mem_128
							0x3E,// VM
								0x6D,// YMM0
								0x93, 0x16,// EVEX_Vmovntdqa_ymm_m256
								0x08,// Full_Mem_256
							0x3E,// VM
								0x8D,// ZMM0
								0x94, 0x16,// EVEX_Vmovntdqa_zmm_m512
								0x09,// Full_Mem_512
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x24,// VK
								0x4D,// XMM0
								0x95, 0x16,// EVEX_Vpbroadcastmb2q_xmm_k
							0x24,// VK
								0x6D,// YMM0
								0x96, 0x16,// EVEX_Vpbroadcastmb2q_ymm_k
							0x24,// VK
								0x8D,// ZMM0
								0x97, 0x16,// EVEX_Vpbroadcastmb2q_zmm_k
					0x00,// Invalid

				// 43 = 0x2B
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0x9B, 0x16,// EVEX_Vpackusdw_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0x9C, 0x16,// EVEX_Vpackusdw_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0x9D, 0x16,// EVEX_Vpackusdw_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 44 = 0x2C
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0xA0, 0x16,// EVEX_Vscalefps_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0xA1, 0x16,// EVEX_Vscalefps_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0xA2, 0x16,// EVEX_Vscalefps_zmm_k1z_zmm_zmmm512b32_er
								0x03,// Full_512
								0x00,// false
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0xA3, 0x16,// EVEX_Vscalefpd_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0xA4, 0x16,// EVEX_Vscalefpd_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0xA5, 0x16,// EVEX_Vscalefpd_zmm_k1z_zmm_zmmm512b64_er
								0x03,// Full_512
								0x00,// false
					0x00,// Invalid
					0x00,// Invalid

				// 45 = 0x2D
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xA8, 0x16,// EVEX_Vscalefss_xmm_k1z_xmm_xmmm32_er
							0x0A,// Tuple1_Scalar
							0x00,// false
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xA9, 0x16,// EVEX_Vscalefsd_xmm_k1z_xmm_xmmm64_er
							0x0A,// Tuple1_Scalar
							0x00,// false
					0x00,// Invalid
					0x00,// Invalid

				// 46 = 0x2E
				0x01,// Invalid2

				// 48 = 0x30
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x36,// VkW_4
							0x4D,// XMM0
							0x4D,// XMM0
							0xB1, 0x16,// EVEX_Vpmovzxbw_xmm_k1z_xmmm64
							0x15,// Half_Mem_128
						0x36,// VkW_4
							0x6D,// YMM0
							0x4D,// XMM0
							0xB2, 0x16,// EVEX_Vpmovzxbw_ymm_k1z_xmmm128
							0x16,// Half_Mem_256
						0x36,// VkW_4
							0x8D,// ZMM0
							0x6D,// YMM0
							0xB3, 0x16,// EVEX_Vpmovzxbw_zmm_k1z_ymmm256
							0x17,// Half_Mem_512
					0x07,// W
						0x09,// VectorLength
							0x46,// WkV_4a
								0x4D,// XMM0
								0x4D,// XMM0
								0xB4, 0x16,// EVEX_Vpmovwb_xmmm64_k1z_xmm
								0x15,// Half_Mem_128
							0x46,// WkV_4a
								0x4D,// XMM0
								0x6D,// YMM0
								0xB5, 0x16,// EVEX_Vpmovwb_xmmm128_k1z_ymm
								0x16,// Half_Mem_256
							0x46,// WkV_4a
								0x6D,// YMM0
								0x8D,// ZMM0
								0xB6, 0x16,// EVEX_Vpmovwb_ymmm256_k1z_zmm
								0x17,// Half_Mem_512
						0x00,// Invalid
					0x00,// Invalid

				// 49 = 0x31
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x36,// VkW_4
							0x4D,// XMM0
							0x4D,// XMM0
							0xBA, 0x16,// EVEX_Vpmovzxbd_xmm_k1z_xmmm32
							0x18,// Quarter_Mem_128
						0x36,// VkW_4
							0x6D,// YMM0
							0x4D,// XMM0
							0xBB, 0x16,// EVEX_Vpmovzxbd_ymm_k1z_xmmm64
							0x19,// Quarter_Mem_256
						0x36,// VkW_4
							0x8D,// ZMM0
							0x4D,// XMM0
							0xBC, 0x16,// EVEX_Vpmovzxbd_zmm_k1z_xmmm128
							0x1A,// Quarter_Mem_512
					0x07,// W
						0x09,// VectorLength
							0x46,// WkV_4a
								0x4D,// XMM0
								0x4D,// XMM0
								0xBD, 0x16,// EVEX_Vpmovdb_xmmm32_k1z_xmm
								0x18,// Quarter_Mem_128
							0x46,// WkV_4a
								0x4D,// XMM0
								0x6D,// YMM0
								0xBE, 0x16,// EVEX_Vpmovdb_xmmm64_k1z_ymm
								0x19,// Quarter_Mem_256
							0x46,// WkV_4a
								0x4D,// XMM0
								0x8D,// ZMM0
								0xBF, 0x16,// EVEX_Vpmovdb_xmmm128_k1z_zmm
								0x1A,// Quarter_Mem_512
						0x00,// Invalid
					0x00,// Invalid

				// 50 = 0x32
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x36,// VkW_4
							0x4D,// XMM0
							0x4D,// XMM0
							0xC3, 0x16,// EVEX_Vpmovzxbq_xmm_k1z_xmmm16
							0x1B,// Eighth_Mem_128
						0x36,// VkW_4
							0x6D,// YMM0
							0x4D,// XMM0
							0xC4, 0x16,// EVEX_Vpmovzxbq_ymm_k1z_xmmm32
							0x1C,// Eighth_Mem_256
						0x36,// VkW_4
							0x8D,// ZMM0
							0x4D,// XMM0
							0xC5, 0x16,// EVEX_Vpmovzxbq_zmm_k1z_xmmm64
							0x1D,// Eighth_Mem_512
					0x07,// W
						0x09,// VectorLength
							0x46,// WkV_4a
								0x4D,// XMM0
								0x4D,// XMM0
								0xC6, 0x16,// EVEX_Vpmovqb_xmmm16_k1z_xmm
								0x1B,// Eighth_Mem_128
							0x46,// WkV_4a
								0x4D,// XMM0
								0x6D,// YMM0
								0xC7, 0x16,// EVEX_Vpmovqb_xmmm32_k1z_ymm
								0x1C,// Eighth_Mem_256
							0x46,// WkV_4a
								0x4D,// XMM0
								0x8D,// ZMM0
								0xC8, 0x16,// EVEX_Vpmovqb_xmmm64_k1z_zmm
								0x1D,// Eighth_Mem_512
						0x00,// Invalid
					0x00,// Invalid

				// 51 = 0x33
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x36,// VkW_4
							0x4D,// XMM0
							0x4D,// XMM0
							0xCC, 0x16,// EVEX_Vpmovzxwd_xmm_k1z_xmmm64
							0x15,// Half_Mem_128
						0x36,// VkW_4
							0x6D,// YMM0
							0x4D,// XMM0
							0xCD, 0x16,// EVEX_Vpmovzxwd_ymm_k1z_xmmm128
							0x16,// Half_Mem_256
						0x36,// VkW_4
							0x8D,// ZMM0
							0x6D,// YMM0
							0xCE, 0x16,// EVEX_Vpmovzxwd_zmm_k1z_ymmm256
							0x17,// Half_Mem_512
					0x07,// W
						0x09,// VectorLength
							0x46,// WkV_4a
								0x4D,// XMM0
								0x4D,// XMM0
								0xCF, 0x16,// EVEX_Vpmovdw_xmmm64_k1z_xmm
								0x15,// Half_Mem_128
							0x46,// WkV_4a
								0x4D,// XMM0
								0x6D,// YMM0
								0xD0, 0x16,// EVEX_Vpmovdw_xmmm128_k1z_ymm
								0x16,// Half_Mem_256
							0x46,// WkV_4a
								0x6D,// YMM0
								0x8D,// ZMM0
								0xD1, 0x16,// EVEX_Vpmovdw_ymmm256_k1z_zmm
								0x17,// Half_Mem_512
						0x00,// Invalid
					0x00,// Invalid

				// 52 = 0x34
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x36,// VkW_4
							0x4D,// XMM0
							0x4D,// XMM0
							0xD5, 0x16,// EVEX_Vpmovzxwq_xmm_k1z_xmmm32
							0x18,// Quarter_Mem_128
						0x36,// VkW_4
							0x6D,// YMM0
							0x4D,// XMM0
							0xD6, 0x16,// EVEX_Vpmovzxwq_ymm_k1z_xmmm64
							0x19,// Quarter_Mem_256
						0x36,// VkW_4
							0x8D,// ZMM0
							0x4D,// XMM0
							0xD7, 0x16,// EVEX_Vpmovzxwq_zmm_k1z_xmmm128
							0x1A,// Quarter_Mem_512
					0x07,// W
						0x09,// VectorLength
							0x46,// WkV_4a
								0x4D,// XMM0
								0x4D,// XMM0
								0xD8, 0x16,// EVEX_Vpmovqw_xmmm32_k1z_xmm
								0x18,// Quarter_Mem_128
							0x46,// WkV_4a
								0x4D,// XMM0
								0x6D,// YMM0
								0xD9, 0x16,// EVEX_Vpmovqw_xmmm64_k1z_ymm
								0x19,// Quarter_Mem_256
							0x46,// WkV_4a
								0x4D,// XMM0
								0x8D,// ZMM0
								0xDA, 0x16,// EVEX_Vpmovqw_xmmm128_k1z_zmm
								0x1A,// Quarter_Mem_512
						0x00,// Invalid
					0x00,// Invalid

				// 53 = 0x35
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x36,// VkW_4
								0x4D,// XMM0
								0x4D,// XMM0
								0xDE, 0x16,// EVEX_Vpmovzxdq_xmm_k1z_xmmm64
								0x15,// Half_Mem_128
							0x36,// VkW_4
								0x6D,// YMM0
								0x4D,// XMM0
								0xDF, 0x16,// EVEX_Vpmovzxdq_ymm_k1z_xmmm128
								0x16,// Half_Mem_256
							0x36,// VkW_4
								0x8D,// ZMM0
								0x6D,// YMM0
								0xE0, 0x16,// EVEX_Vpmovzxdq_zmm_k1z_ymmm256
								0x17,// Half_Mem_512
						0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x46,// WkV_4a
								0x4D,// XMM0
								0x4D,// XMM0
								0xE1, 0x16,// EVEX_Vpmovqd_xmmm64_k1z_xmm
								0x15,// Half_Mem_128
							0x46,// WkV_4a
								0x4D,// XMM0
								0x6D,// YMM0
								0xE2, 0x16,// EVEX_Vpmovqd_xmmm128_k1z_ymm
								0x16,// Half_Mem_256
							0x46,// WkV_4a
								0x6D,// YMM0
								0x8D,// ZMM0
								0xE3, 0x16,// EVEX_Vpmovqd_ymmm256_k1z_zmm
								0x17,// Half_Mem_512
						0x00,// Invalid
					0x00,// Invalid

				// 54 = 0x36
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x00,// Invalid
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xE5, 0x16,// EVEX_Vpermd_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xE6, 0x16,// EVEX_Vpermd_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x09,// VectorLength
							0x00,// Invalid
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xE7, 0x16,// EVEX_Vpermq_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xE8, 0x16,// EVEX_Vpermq_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 55 = 0x37
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x14,// KkHW_3b
								0x4D,// XMM0
								0xEC, 0x16,// EVEX_Vpcmpgtq_k_k1_xmm_xmmm128b64
								0x01,// Full_128
							0x14,// KkHW_3b
								0x6D,// YMM0
								0xED, 0x16,// EVEX_Vpcmpgtq_k_k1_ymm_ymmm256b64
								0x02,// Full_256
							0x14,// KkHW_3b
								0x8D,// ZMM0
								0xEE, 0x16,// EVEX_Vpcmpgtq_k_k1_zmm_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 56 = 0x38
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x29,// VkHW_3
							0x4D,// XMM0
							0xF2, 0x16,// EVEX_Vpminsb_xmm_k1z_xmm_xmmm128
							0x07,// Full_Mem_128
						0x29,// VkHW_3
							0x6D,// YMM0
							0xF3, 0x16,// EVEX_Vpminsb_ymm_k1z_ymm_ymmm256
							0x08,// Full_Mem_256
						0x29,// VkHW_3
							0x8D,// ZMM0
							0xF4, 0x16,// EVEX_Vpminsb_zmm_k1z_zmm_zmmm512
							0x09,// Full_Mem_512
					0x07,// W
						0x09,// VectorLength
							0x24,// VK
								0x4D,// XMM0
								0xF5, 0x16,// EVEX_Vpmovm2d_xmm_k
							0x24,// VK
								0x6D,// YMM0
								0xF6, 0x16,// EVEX_Vpmovm2d_ymm_k
							0x24,// VK
								0x8D,// ZMM0
								0xF7, 0x16,// EVEX_Vpmovm2d_zmm_k
						0x09,// VectorLength
							0x24,// VK
								0x4D,// XMM0
								0xF8, 0x16,// EVEX_Vpmovm2q_xmm_k
							0x24,// VK
								0x6D,// YMM0
								0xF9, 0x16,// EVEX_Vpmovm2q_ymm_k
							0x24,// VK
								0x8D,// ZMM0
								0xFA, 0x16,// EVEX_Vpmovm2q_zmm_k
					0x00,// Invalid

				// 57 = 0x39
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xFE, 0x16,// EVEX_Vpminsd_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xFF, 0x16,// EVEX_Vpminsd_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0x80, 0x17,// EVEX_Vpminsd_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0x81, 0x17,// EVEX_Vpminsq_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0x82, 0x17,// EVEX_Vpminsq_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0x83, 0x17,// EVEX_Vpminsq_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x07,// W
						0x09,// VectorLength
							0x1C,// KR
								0x4D,// XMM0
								0x84, 0x17,// EVEX_Vpmovd2m_k_xmm
							0x1C,// KR
								0x6D,// YMM0
								0x85, 0x17,// EVEX_Vpmovd2m_k_ymm
							0x1C,// KR
								0x8D,// ZMM0
								0x86, 0x17,// EVEX_Vpmovd2m_k_zmm
						0x09,// VectorLength
							0x1C,// KR
								0x4D,// XMM0
								0x87, 0x17,// EVEX_Vpmovq2m_k_xmm
							0x1C,// KR
								0x6D,// YMM0
								0x88, 0x17,// EVEX_Vpmovq2m_k_ymm
							0x1C,// KR
								0x8D,// ZMM0
								0x89, 0x17,// EVEX_Vpmovq2m_k_zmm
					0x00,// Invalid

				// 58 = 0x3A
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x29,// VkHW_3
							0x4D,// XMM0
							0x8D, 0x17,// EVEX_Vpminuw_xmm_k1z_xmm_xmmm128
							0x07,// Full_Mem_128
						0x29,// VkHW_3
							0x6D,// YMM0
							0x8E, 0x17,// EVEX_Vpminuw_ymm_k1z_ymm_ymmm256
							0x08,// Full_Mem_256
						0x29,// VkHW_3
							0x8D,// ZMM0
							0x8F, 0x17,// EVEX_Vpminuw_zmm_k1z_zmm_zmmm512
							0x09,// Full_Mem_512
					0x07,// W
						0x09,// VectorLength
							0x24,// VK
								0x4D,// XMM0
								0x90, 0x17,// EVEX_Vpbroadcastmw2d_xmm_k
							0x24,// VK
								0x6D,// YMM0
								0x91, 0x17,// EVEX_Vpbroadcastmw2d_ymm_k
							0x24,// VK
								0x8D,// ZMM0
								0x92, 0x17,// EVEX_Vpbroadcastmw2d_zmm_k
						0x00,// Invalid
					0x00,// Invalid

				// 59 = 0x3B
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0x96, 0x17,// EVEX_Vpminud_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0x97, 0x17,// EVEX_Vpminud_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0x98, 0x17,// EVEX_Vpminud_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0x99, 0x17,// EVEX_Vpminuq_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0x9A, 0x17,// EVEX_Vpminuq_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0x9B, 0x17,// EVEX_Vpminuq_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 60 = 0x3C
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x29,// VkHW_3
							0x4D,// XMM0
							0x9F, 0x17,// EVEX_Vpmaxsb_xmm_k1z_xmm_xmmm128
							0x07,// Full_Mem_128
						0x29,// VkHW_3
							0x6D,// YMM0
							0xA0, 0x17,// EVEX_Vpmaxsb_ymm_k1z_ymm_ymmm256
							0x08,// Full_Mem_256
						0x29,// VkHW_3
							0x8D,// ZMM0
							0xA1, 0x17,// EVEX_Vpmaxsb_zmm_k1z_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 61 = 0x3D
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xA5, 0x17,// EVEX_Vpmaxsd_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xA6, 0x17,// EVEX_Vpmaxsd_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xA7, 0x17,// EVEX_Vpmaxsd_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xA8, 0x17,// EVEX_Vpmaxsq_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xA9, 0x17,// EVEX_Vpmaxsq_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xAA, 0x17,// EVEX_Vpmaxsq_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 62 = 0x3E
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x29,// VkHW_3
							0x4D,// XMM0
							0xAE, 0x17,// EVEX_Vpmaxuw_xmm_k1z_xmm_xmmm128
							0x07,// Full_Mem_128
						0x29,// VkHW_3
							0x6D,// YMM0
							0xAF, 0x17,// EVEX_Vpmaxuw_ymm_k1z_ymm_ymmm256
							0x08,// Full_Mem_256
						0x29,// VkHW_3
							0x8D,// ZMM0
							0xB0, 0x17,// EVEX_Vpmaxuw_zmm_k1z_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 63 = 0x3F
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xB4, 0x17,// EVEX_Vpmaxud_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xB5, 0x17,// EVEX_Vpmaxud_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xB6, 0x17,// EVEX_Vpmaxud_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xB7, 0x17,// EVEX_Vpmaxuq_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xB8, 0x17,// EVEX_Vpmaxuq_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xB9, 0x17,// EVEX_Vpmaxuq_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 64 = 0x40
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xBD, 0x17,// EVEX_Vpmulld_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xBE, 0x17,// EVEX_Vpmulld_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xBF, 0x17,// EVEX_Vpmulld_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xC0, 0x17,// EVEX_Vpmullq_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xC1, 0x17,// EVEX_Vpmullq_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xC2, 0x17,// EVEX_Vpmullq_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 65 = 0x41
				0x00,// Invalid

				// 66 = 0x42
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x0A,// VectorLength_er
							0x38,// VkW_er_4
								0x4D,// XMM0
								0xC5, 0x17,// EVEX_Vgetexpps_xmm_k1z_xmmm128b32
								0x01,// Full_128
								0x01,// true
							0x38,// VkW_er_4
								0x6D,// YMM0
								0xC6, 0x17,// EVEX_Vgetexpps_ymm_k1z_ymmm256b32
								0x02,// Full_256
								0x01,// true
							0x38,// VkW_er_4
								0x8D,// ZMM0
								0xC7, 0x17,// EVEX_Vgetexpps_zmm_k1z_zmmm512b32_sae
								0x03,// Full_512
								0x01,// true
						0x0A,// VectorLength_er
							0x38,// VkW_er_4
								0x4D,// XMM0
								0xC8, 0x17,// EVEX_Vgetexppd_xmm_k1z_xmmm128b64
								0x01,// Full_128
								0x01,// true
							0x38,// VkW_er_4
								0x6D,// YMM0
								0xC9, 0x17,// EVEX_Vgetexppd_ymm_k1z_ymmm256b64
								0x02,// Full_256
								0x01,// true
							0x38,// VkW_er_4
								0x8D,// ZMM0
								0xCA, 0x17,// EVEX_Vgetexppd_zmm_k1z_zmmm512b64_sae
								0x03,// Full_512
								0x01,// true
					0x00,// Invalid
					0x00,// Invalid

				// 67 = 0x43
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xCB, 0x17,// EVEX_Vgetexpss_xmm_k1z_xmm_xmmm32_sae
							0x0A,// Tuple1_Scalar
							0x01,// true
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xCC, 0x17,// EVEX_Vgetexpsd_xmm_k1z_xmm_xmmm64_sae
							0x0A,// Tuple1_Scalar
							0x01,// true
					0x00,// Invalid
					0x00,// Invalid

				// 68 = 0x44
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x35,// VkW_3b
								0x4D,// XMM0
								0xCD, 0x17,// EVEX_Vplzcntd_xmm_k1z_xmmm128b32
								0x01,// Full_128
							0x35,// VkW_3b
								0x6D,// YMM0
								0xCE, 0x17,// EVEX_Vplzcntd_ymm_k1z_ymmm256b32
								0x02,// Full_256
							0x35,// VkW_3b
								0x8D,// ZMM0
								0xCF, 0x17,// EVEX_Vplzcntd_zmm_k1z_zmmm512b32
								0x03,// Full_512
						0x09,// VectorLength
							0x35,// VkW_3b
								0x4D,// XMM0
								0xD0, 0x17,// EVEX_Vplzcntq_xmm_k1z_xmmm128b64
								0x01,// Full_128
							0x35,// VkW_3b
								0x6D,// YMM0
								0xD1, 0x17,// EVEX_Vplzcntq_ymm_k1z_ymmm256b64
								0x02,// Full_256
							0x35,// VkW_3b
								0x8D,// ZMM0
								0xD2, 0x17,// EVEX_Vplzcntq_zmm_k1z_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 69 = 0x45
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xD7, 0x17,// EVEX_Vpsrlvd_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xD8, 0x17,// EVEX_Vpsrlvd_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xD9, 0x17,// EVEX_Vpsrlvd_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xDA, 0x17,// EVEX_Vpsrlvq_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xDB, 0x17,// EVEX_Vpsrlvq_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xDC, 0x17,// EVEX_Vpsrlvq_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 70 = 0x46
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xDF, 0x17,// EVEX_Vpsravd_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xE0, 0x17,// EVEX_Vpsravd_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xE1, 0x17,// EVEX_Vpsravd_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xE2, 0x17,// EVEX_Vpsravq_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xE3, 0x17,// EVEX_Vpsravq_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xE4, 0x17,// EVEX_Vpsravq_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 71 = 0x47
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xE9, 0x17,// EVEX_Vpsllvd_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xEA, 0x17,// EVEX_Vpsllvd_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xEB, 0x17,// EVEX_Vpsllvd_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xEC, 0x17,// EVEX_Vpsllvq_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xED, 0x17,// EVEX_Vpsllvq_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xEE, 0x17,// EVEX_Vpsllvq_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 72 = 0x48
				0x02,// Dup
					0x04,// 4
					0x00,// Invalid

				// 76 = 0x4C
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x35,// VkW_3b
								0x4D,// XMM0
								0xEF, 0x17,// EVEX_Vrcp14ps_xmm_k1z_xmmm128b32
								0x01,// Full_128
							0x35,// VkW_3b
								0x6D,// YMM0
								0xF0, 0x17,// EVEX_Vrcp14ps_ymm_k1z_ymmm256b32
								0x02,// Full_256
							0x35,// VkW_3b
								0x8D,// ZMM0
								0xF1, 0x17,// EVEX_Vrcp14ps_zmm_k1z_zmmm512b32
								0x03,// Full_512
						0x09,// VectorLength
							0x35,// VkW_3b
								0x4D,// XMM0
								0xF2, 0x17,// EVEX_Vrcp14pd_xmm_k1z_xmmm128b64
								0x01,// Full_128
							0x35,// VkW_3b
								0x6D,// YMM0
								0xF3, 0x17,// EVEX_Vrcp14pd_ymm_k1z_ymmm256b64
								0x02,// Full_256
							0x35,// VkW_3b
								0x8D,// ZMM0
								0xF4, 0x17,// EVEX_Vrcp14pd_zmm_k1z_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 77 = 0x4D
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x29,// VkHW_3
							0x4D,// XMM0
							0xF5, 0x17,// EVEX_Vrcp14ss_xmm_k1z_xmm_xmmm32
							0x0A,// Tuple1_Scalar
						0x29,// VkHW_3
							0x4D,// XMM0
							0xF6, 0x17,// EVEX_Vrcp14sd_xmm_k1z_xmm_xmmm64
							0x0A,// Tuple1_Scalar
					0x00,// Invalid
					0x00,// Invalid

				// 78 = 0x4E
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x35,// VkW_3b
								0x4D,// XMM0
								0xF7, 0x17,// EVEX_Vrsqrt14ps_xmm_k1z_xmmm128b32
								0x01,// Full_128
							0x35,// VkW_3b
								0x6D,// YMM0
								0xF8, 0x17,// EVEX_Vrsqrt14ps_ymm_k1z_ymmm256b32
								0x02,// Full_256
							0x35,// VkW_3b
								0x8D,// ZMM0
								0xF9, 0x17,// EVEX_Vrsqrt14ps_zmm_k1z_zmmm512b32
								0x03,// Full_512
						0x09,// VectorLength
							0x35,// VkW_3b
								0x4D,// XMM0
								0xFA, 0x17,// EVEX_Vrsqrt14pd_xmm_k1z_xmmm128b64
								0x01,// Full_128
							0x35,// VkW_3b
								0x6D,// YMM0
								0xFB, 0x17,// EVEX_Vrsqrt14pd_ymm_k1z_ymmm256b64
								0x02,// Full_256
							0x35,// VkW_3b
								0x8D,// ZMM0
								0xFC, 0x17,// EVEX_Vrsqrt14pd_zmm_k1z_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 79 = 0x4F
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x29,// VkHW_3
							0x4D,// XMM0
							0xFD, 0x17,// EVEX_Vrsqrt14ss_xmm_k1z_xmm_xmmm32
							0x0A,// Tuple1_Scalar
						0x29,// VkHW_3
							0x4D,// XMM0
							0xFE, 0x17,// EVEX_Vrsqrt14sd_xmm_k1z_xmm_xmmm64
							0x0A,// Tuple1_Scalar
					0x00,// Invalid
					0x00,// Invalid

				// 80 = 0x50
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xFF, 0x17,// EVEX_Vpdpbusd_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0x80, 0x18,// EVEX_Vpdpbusd_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0x81, 0x18,// EVEX_Vpdpbusd_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 81 = 0x51
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0x82, 0x18,// EVEX_Vpdpbusds_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0x83, 0x18,// EVEX_Vpdpbusds_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0x84, 0x18,// EVEX_Vpdpbusds_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 82 = 0x52
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0x85, 0x18,// EVEX_Vpdpwssd_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0x86, 0x18,// EVEX_Vpdpwssd_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0x87, 0x18,// EVEX_Vpdpwssd_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0x88, 0x18,// EVEX_Vdpbf16ps_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0x89, 0x18,// EVEX_Vdpbf16ps_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0x8A, 0x18,// EVEX_Vdpbf16ps_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x00,// Invalid
							0x00,// Invalid
							0x28,// VkHM
								0x8D,// ZMM0
								0x8B, 0x18,// EVEX_Vp4dpwssd_zmm_k1z_zmmp3_m128
								0x14,// Tuple1_4X
						0x00,// Invalid

				// 83 = 0x53
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0x8C, 0x18,// EVEX_Vpdpwssds_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0x8D, 0x18,// EVEX_Vpdpwssds_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0x8E, 0x18,// EVEX_Vpdpwssds_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x00,// Invalid
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x00,// Invalid
							0x00,// Invalid
							0x28,// VkHM
								0x8D,// ZMM0
								0x8F, 0x18,// EVEX_Vp4dpwssds_zmm_k1z_zmmp3_m128
								0x14,// Tuple1_4X
						0x00,// Invalid

				// 84 = 0x54
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x34,// VkW_3
								0x4D,// XMM0
								0x90, 0x18,// EVEX_Vpopcntb_xmm_k1z_xmmm128
								0x07,// Full_Mem_128
							0x34,// VkW_3
								0x6D,// YMM0
								0x91, 0x18,// EVEX_Vpopcntb_ymm_k1z_ymmm256
								0x08,// Full_Mem_256
							0x34,// VkW_3
								0x8D,// ZMM0
								0x92, 0x18,// EVEX_Vpopcntb_zmm_k1z_zmmm512
								0x09,// Full_Mem_512
						0x09,// VectorLength
							0x34,// VkW_3
								0x4D,// XMM0
								0x93, 0x18,// EVEX_Vpopcntw_xmm_k1z_xmmm128
								0x07,// Full_Mem_128
							0x34,// VkW_3
								0x6D,// YMM0
								0x94, 0x18,// EVEX_Vpopcntw_ymm_k1z_ymmm256
								0x08,// Full_Mem_256
							0x34,// VkW_3
								0x8D,// ZMM0
								0x95, 0x18,// EVEX_Vpopcntw_zmm_k1z_zmmm512
								0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 85 = 0x55
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x35,// VkW_3b
								0x4D,// XMM0
								0x96, 0x18,// EVEX_Vpopcntd_xmm_k1z_xmmm128b32
								0x01,// Full_128
							0x35,// VkW_3b
								0x6D,// YMM0
								0x97, 0x18,// EVEX_Vpopcntd_ymm_k1z_ymmm256b32
								0x02,// Full_256
							0x35,// VkW_3b
								0x8D,// ZMM0
								0x98, 0x18,// EVEX_Vpopcntd_zmm_k1z_zmmm512b32
								0x03,// Full_512
						0x09,// VectorLength
							0x35,// VkW_3b
								0x4D,// XMM0
								0x99, 0x18,// EVEX_Vpopcntq_xmm_k1z_xmmm128b64
								0x01,// Full_128
							0x35,// VkW_3b
								0x6D,// YMM0
								0x9A, 0x18,// EVEX_Vpopcntq_ymm_k1z_ymmm256b64
								0x02,// Full_256
							0x35,// VkW_3b
								0x8D,// ZMM0
								0x9B, 0x18,// EVEX_Vpopcntq_zmm_k1z_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 86 = 0x56
				0x01,// Invalid2

				// 88 = 0x58
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x36,// VkW_4
								0x4D,// XMM0
								0x4D,// XMM0
								0x9E, 0x18,// EVEX_Vpbroadcastd_xmm_k1z_xmmm32
								0x0A,// Tuple1_Scalar
							0x36,// VkW_4
								0x6D,// YMM0
								0x4D,// XMM0
								0x9F, 0x18,// EVEX_Vpbroadcastd_ymm_k1z_xmmm32
								0x0A,// Tuple1_Scalar
							0x36,// VkW_4
								0x8D,// ZMM0
								0x4D,// XMM0
								0xA0, 0x18,// EVEX_Vpbroadcastd_zmm_k1z_xmmm32
								0x0A,// Tuple1_Scalar
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 89 = 0x59
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x36,// VkW_4
								0x4D,// XMM0
								0x4D,// XMM0
								0xA3, 0x18,// EVEX_Vbroadcasti32x2_xmm_k1z_xmmm64
								0x11,// Tuple2
							0x36,// VkW_4
								0x6D,// YMM0
								0x4D,// XMM0
								0xA4, 0x18,// EVEX_Vbroadcasti32x2_ymm_k1z_xmmm64
								0x11,// Tuple2
							0x36,// VkW_4
								0x8D,// ZMM0
								0x4D,// XMM0
								0xA5, 0x18,// EVEX_Vbroadcasti32x2_zmm_k1z_xmmm64
								0x11,// Tuple2
						0x09,// VectorLength
							0x36,// VkW_4
								0x4D,// XMM0
								0x4D,// XMM0
								0xA6, 0x18,// EVEX_Vpbroadcastq_xmm_k1z_xmmm64
								0x0A,// Tuple1_Scalar
							0x36,// VkW_4
								0x6D,// YMM0
								0x4D,// XMM0
								0xA7, 0x18,// EVEX_Vpbroadcastq_ymm_k1z_xmmm64
								0x0A,// Tuple1_Scalar
							0x36,// VkW_4
								0x8D,// ZMM0
								0x4D,// XMM0
								0xA8, 0x18,// EVEX_Vpbroadcastq_zmm_k1z_xmmm64
								0x0A,// Tuple1_Scalar
					0x00,// Invalid
					0x00,// Invalid

				// 90 = 0x5A
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x00,// Invalid
							0x33,// VkM
								0x6D,// YMM0
								0xAA, 0x18,// EVEX_Vbroadcasti32x4_ymm_k1z_m128
								0x12,// Tuple4
							0x33,// VkM
								0x8D,// ZMM0
								0xAB, 0x18,// EVEX_Vbroadcasti32x4_zmm_k1z_m128
								0x12,// Tuple4
						0x09,// VectorLength
							0x00,// Invalid
							0x33,// VkM
								0x6D,// YMM0
								0xAC, 0x18,// EVEX_Vbroadcasti64x2_ymm_k1z_m128
								0x11,// Tuple2
							0x33,// VkM
								0x8D,// ZMM0
								0xAD, 0x18,// EVEX_Vbroadcasti64x2_zmm_k1z_m128
								0x11,// Tuple2
					0x00,// Invalid
					0x00,// Invalid

				// 91 = 0x5B
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x00,// Invalid
							0x00,// Invalid
							0x33,// VkM
								0x8D,// ZMM0
								0xAE, 0x18,// EVEX_Vbroadcasti32x8_zmm_k1z_m256
								0x13,// Tuple8
						0x09,// VectorLength
							0x00,// Invalid
							0x00,// Invalid
							0x33,// VkM
								0x8D,// ZMM0
								0xAF, 0x18,// EVEX_Vbroadcasti64x4_zmm_k1z_m256
								0x12,// Tuple4
					0x00,// Invalid
					0x00,// Invalid

				// 92 = 0x5C
				0x02,// Dup
					0x06,// 6
					0x00,// Invalid

				// 98 = 0x62
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x34,// VkW_3
								0x4D,// XMM0
								0xB0, 0x18,// EVEX_Vpexpandb_xmm_k1z_xmmm128
								0x0B,// Tuple1_Scalar_1
							0x34,// VkW_3
								0x6D,// YMM0
								0xB1, 0x18,// EVEX_Vpexpandb_ymm_k1z_ymmm256
								0x0B,// Tuple1_Scalar_1
							0x34,// VkW_3
								0x8D,// ZMM0
								0xB2, 0x18,// EVEX_Vpexpandb_zmm_k1z_zmmm512
								0x0B,// Tuple1_Scalar_1
						0x09,// VectorLength
							0x34,// VkW_3
								0x4D,// XMM0
								0xB3, 0x18,// EVEX_Vpexpandw_xmm_k1z_xmmm128
								0x0C,// Tuple1_Scalar_2
							0x34,// VkW_3
								0x6D,// YMM0
								0xB4, 0x18,// EVEX_Vpexpandw_ymm_k1z_ymmm256
								0x0C,// Tuple1_Scalar_2
							0x34,// VkW_3
								0x8D,// ZMM0
								0xB5, 0x18,// EVEX_Vpexpandw_zmm_k1z_zmmm512
								0x0C,// Tuple1_Scalar_2
					0x00,// Invalid
					0x00,// Invalid

				// 99 = 0x63
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x45,// WkV_3
								0x4D,// XMM0
								0xB6, 0x18,// EVEX_Vpcompressb_xmmm128_k1z_xmm
								0x0B,// Tuple1_Scalar_1
							0x45,// WkV_3
								0x6D,// YMM0
								0xB7, 0x18,// EVEX_Vpcompressb_ymmm256_k1z_ymm
								0x0B,// Tuple1_Scalar_1
							0x45,// WkV_3
								0x8D,// ZMM0
								0xB8, 0x18,// EVEX_Vpcompressb_zmmm512_k1z_zmm
								0x0B,// Tuple1_Scalar_1
						0x09,// VectorLength
							0x45,// WkV_3
								0x4D,// XMM0
								0xB9, 0x18,// EVEX_Vpcompressw_xmmm128_k1z_xmm
								0x0C,// Tuple1_Scalar_2
							0x45,// WkV_3
								0x6D,// YMM0
								0xBA, 0x18,// EVEX_Vpcompressw_ymmm256_k1z_ymm
								0x0C,// Tuple1_Scalar_2
							0x45,// WkV_3
								0x8D,// ZMM0
								0xBB, 0x18,// EVEX_Vpcompressw_zmmm512_k1z_zmm
								0x0C,// Tuple1_Scalar_2
					0x00,// Invalid
					0x00,// Invalid

				// 100 = 0x64
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xBC, 0x18,// EVEX_Vpblendmd_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xBD, 0x18,// EVEX_Vpblendmd_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xBE, 0x18,// EVEX_Vpblendmd_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xBF, 0x18,// EVEX_Vpblendmq_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xC0, 0x18,// EVEX_Vpblendmq_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xC1, 0x18,// EVEX_Vpblendmq_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 101 = 0x65
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xC2, 0x18,// EVEX_Vblendmps_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xC3, 0x18,// EVEX_Vblendmps_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xC4, 0x18,// EVEX_Vblendmps_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xC5, 0x18,// EVEX_Vblendmpd_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xC6, 0x18,// EVEX_Vblendmpd_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xC7, 0x18,// EVEX_Vblendmpd_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 102 = 0x66
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x29,// VkHW_3
								0x4D,// XMM0
								0xC8, 0x18,// EVEX_Vpblendmb_xmm_k1z_xmm_xmmm128
								0x07,// Full_Mem_128
							0x29,// VkHW_3
								0x6D,// YMM0
								0xC9, 0x18,// EVEX_Vpblendmb_ymm_k1z_ymm_ymmm256
								0x08,// Full_Mem_256
							0x29,// VkHW_3
								0x8D,// ZMM0
								0xCA, 0x18,// EVEX_Vpblendmb_zmm_k1z_zmm_zmmm512
								0x09,// Full_Mem_512
						0x09,// VectorLength
							0x29,// VkHW_3
								0x4D,// XMM0
								0xCB, 0x18,// EVEX_Vpblendmw_xmm_k1z_xmm_xmmm128
								0x07,// Full_Mem_128
							0x29,// VkHW_3
								0x6D,// YMM0
								0xCC, 0x18,// EVEX_Vpblendmw_ymm_k1z_ymm_ymmm256
								0x08,// Full_Mem_256
							0x29,// VkHW_3
								0x8D,// ZMM0
								0xCD, 0x18,// EVEX_Vpblendmw_zmm_k1z_zmm_zmmm512
								0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 103 = 0x67
				0x00,// Invalid

				// 104 = 0x68
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x1B,// KP1HW
								0x4D,// XMM0
								0xCE, 0x18,// EVEX_Vp2intersectd_kp1_xmm_xmmm128b32
								0x01,// Full_128
							0x1B,// KP1HW
								0x6D,// YMM0
								0xCF, 0x18,// EVEX_Vp2intersectd_kp1_ymm_ymmm256b32
								0x02,// Full_256
							0x1B,// KP1HW
								0x8D,// ZMM0
								0xD0, 0x18,// EVEX_Vp2intersectd_kp1_zmm_zmmm512b32
								0x03,// Full_512
						0x09,// VectorLength
							0x1B,// KP1HW
								0x4D,// XMM0
								0xD1, 0x18,// EVEX_Vp2intersectq_kp1_xmm_xmmm128b64
								0x01,// Full_128
							0x1B,// KP1HW
								0x6D,// YMM0
								0xD2, 0x18,// EVEX_Vp2intersectq_kp1_ymm_ymmm256b64
								0x02,// Full_256
							0x1B,// KP1HW
								0x8D,// ZMM0
								0xD3, 0x18,// EVEX_Vp2intersectq_kp1_zmm_zmmm512b64
								0x03,// Full_512

				// 105 = 0x69
				0x02,// Dup
					0x07,// 7
					0x00,// Invalid

				// 112 = 0x70
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x29,// VkHW_3
								0x4D,// XMM0
								0xD4, 0x18,// EVEX_Vpshldvw_xmm_k1z_xmm_xmmm128
								0x07,// Full_Mem_128
							0x29,// VkHW_3
								0x6D,// YMM0
								0xD5, 0x18,// EVEX_Vpshldvw_ymm_k1z_ymm_ymmm256
								0x08,// Full_Mem_256
							0x29,// VkHW_3
								0x8D,// ZMM0
								0xD6, 0x18,// EVEX_Vpshldvw_zmm_k1z_zmm_zmmm512
								0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 113 = 0x71
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xD7, 0x18,// EVEX_Vpshldvd_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xD8, 0x18,// EVEX_Vpshldvd_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xD9, 0x18,// EVEX_Vpshldvd_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xDA, 0x18,// EVEX_Vpshldvq_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xDB, 0x18,// EVEX_Vpshldvq_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xDC, 0x18,// EVEX_Vpshldvq_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 114 = 0x72
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x29,// VkHW_3
								0x4D,// XMM0
								0xDD, 0x18,// EVEX_Vpshrdvw_xmm_k1z_xmm_xmmm128
								0x07,// Full_Mem_128
							0x29,// VkHW_3
								0x6D,// YMM0
								0xDE, 0x18,// EVEX_Vpshrdvw_ymm_k1z_ymm_ymmm256
								0x08,// Full_Mem_256
							0x29,// VkHW_3
								0x8D,// ZMM0
								0xDF, 0x18,// EVEX_Vpshrdvw_zmm_k1z_zmm_zmmm512
								0x09,// Full_Mem_512
					0x07,// W
						0x09,// VectorLength
							0x37,// VkW_4b
								0x4D,// XMM0
								0x4D,// XMM0
								0xE0, 0x18,// EVEX_Vcvtneps2bf16_xmm_k1z_xmmm128b32
								0x01,// Full_128
							0x37,// VkW_4b
								0x4D,// XMM0
								0x6D,// YMM0
								0xE1, 0x18,// EVEX_Vcvtneps2bf16_xmm_k1z_ymmm256b32
								0x02,// Full_256
							0x37,// VkW_4b
								0x6D,// YMM0
								0x8D,// ZMM0
								0xE2, 0x18,// EVEX_Vcvtneps2bf16_ymm_k1z_zmmm512b32
								0x03,// Full_512
						0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xE3, 0x18,// EVEX_Vcvtne2ps2bf16_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xE4, 0x18,// EVEX_Vcvtne2ps2bf16_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xE5, 0x18,// EVEX_Vcvtne2ps2bf16_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x00,// Invalid

				// 115 = 0x73
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xE6, 0x18,// EVEX_Vpshrdvd_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xE7, 0x18,// EVEX_Vpshrdvd_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xE8, 0x18,// EVEX_Vpshrdvd_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xE9, 0x18,// EVEX_Vpshrdvq_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xEA, 0x18,// EVEX_Vpshrdvq_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xEB, 0x18,// EVEX_Vpshrdvq_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 116 = 0x74
				0x00,// Invalid

				// 117 = 0x75
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x29,// VkHW_3
								0x4D,// XMM0
								0xEC, 0x18,// EVEX_Vpermi2b_xmm_k1z_xmm_xmmm128
								0x07,// Full_Mem_128
							0x29,// VkHW_3
								0x6D,// YMM0
								0xED, 0x18,// EVEX_Vpermi2b_ymm_k1z_ymm_ymmm256
								0x08,// Full_Mem_256
							0x29,// VkHW_3
								0x8D,// ZMM0
								0xEE, 0x18,// EVEX_Vpermi2b_zmm_k1z_zmm_zmmm512
								0x09,// Full_Mem_512
						0x09,// VectorLength
							0x29,// VkHW_3
								0x4D,// XMM0
								0xEF, 0x18,// EVEX_Vpermi2w_xmm_k1z_xmm_xmmm128
								0x07,// Full_Mem_128
							0x29,// VkHW_3
								0x6D,// YMM0
								0xF0, 0x18,// EVEX_Vpermi2w_ymm_k1z_ymm_ymmm256
								0x08,// Full_Mem_256
							0x29,// VkHW_3
								0x8D,// ZMM0
								0xF1, 0x18,// EVEX_Vpermi2w_zmm_k1z_zmm_zmmm512
								0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 118 = 0x76
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xF2, 0x18,// EVEX_Vpermi2d_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xF3, 0x18,// EVEX_Vpermi2d_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xF4, 0x18,// EVEX_Vpermi2d_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xF5, 0x18,// EVEX_Vpermi2q_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xF6, 0x18,// EVEX_Vpermi2q_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xF7, 0x18,// EVEX_Vpermi2q_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 119 = 0x77
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xF8, 0x18,// EVEX_Vpermi2ps_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xF9, 0x18,// EVEX_Vpermi2ps_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xFA, 0x18,// EVEX_Vpermi2ps_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xFB, 0x18,// EVEX_Vpermi2pd_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xFC, 0x18,// EVEX_Vpermi2pd_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xFD, 0x18,// EVEX_Vpermi2pd_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 120 = 0x78
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x36,// VkW_4
								0x4D,// XMM0
								0x4D,// XMM0
								0x80, 0x19,// EVEX_Vpbroadcastb_xmm_k1z_xmmm8
								0x0B,// Tuple1_Scalar_1
							0x36,// VkW_4
								0x6D,// YMM0
								0x4D,// XMM0
								0x81, 0x19,// EVEX_Vpbroadcastb_ymm_k1z_xmmm8
								0x0B,// Tuple1_Scalar_1
							0x36,// VkW_4
								0x8D,// ZMM0
								0x4D,// XMM0
								0x82, 0x19,// EVEX_Vpbroadcastb_zmm_k1z_xmmm8
								0x0B,// Tuple1_Scalar_1
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 121 = 0x79
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x36,// VkW_4
								0x4D,// XMM0
								0x4D,// XMM0
								0x85, 0x19,// EVEX_Vpbroadcastw_xmm_k1z_xmmm16
								0x0C,// Tuple1_Scalar_2
							0x36,// VkW_4
								0x6D,// YMM0
								0x4D,// XMM0
								0x86, 0x19,// EVEX_Vpbroadcastw_ymm_k1z_xmmm16
								0x0C,// Tuple1_Scalar_2
							0x36,// VkW_4
								0x8D,// ZMM0
								0x4D,// XMM0
								0x87, 0x19,// EVEX_Vpbroadcastw_zmm_k1z_xmmm16
								0x0C,// Tuple1_Scalar_2
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 122 = 0x7A
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x26,// VkEv_REXW_2
								0x4D,// XMM0
								0x88, 0x19,// EVEX_Vpbroadcastb_xmm_k1z_r32
							0x26,// VkEv_REXW_2
								0x6D,// YMM0
								0x89, 0x19,// EVEX_Vpbroadcastb_ymm_k1z_r32
							0x26,// VkEv_REXW_2
								0x8D,// ZMM0
								0x8A, 0x19,// EVEX_Vpbroadcastb_zmm_k1z_r32
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 123 = 0x7B
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x26,// VkEv_REXW_2
								0x4D,// XMM0
								0x8B, 0x19,// EVEX_Vpbroadcastw_xmm_k1z_r32
							0x26,// VkEv_REXW_2
								0x6D,// YMM0
								0x8C, 0x19,// EVEX_Vpbroadcastw_ymm_k1z_r32
							0x26,// VkEv_REXW_2
								0x8D,// ZMM0
								0x8D, 0x19,// EVEX_Vpbroadcastw_zmm_k1z_r32
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 124 = 0x7C
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x27,// VkEv_REXW_3
							0x4D,// XMM0
							0x8E, 0x19,// EVEX_Vpbroadcastd_xmm_k1z_r32
							0x91, 0x19,// EVEX_Vpbroadcastq_xmm_k1z_r64
						0x27,// VkEv_REXW_3
							0x6D,// YMM0
							0x8F, 0x19,// EVEX_Vpbroadcastd_ymm_k1z_r32
							0x92, 0x19,// EVEX_Vpbroadcastq_ymm_k1z_r64
						0x27,// VkEv_REXW_3
							0x8D,// ZMM0
							0x90, 0x19,// EVEX_Vpbroadcastd_zmm_k1z_r32
							0x93, 0x19,// EVEX_Vpbroadcastq_zmm_k1z_r64
					0x00,// Invalid
					0x00,// Invalid

				// 125 = 0x7D
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x29,// VkHW_3
								0x4D,// XMM0
								0x94, 0x19,// EVEX_Vpermt2b_xmm_k1z_xmm_xmmm128
								0x07,// Full_Mem_128
							0x29,// VkHW_3
								0x6D,// YMM0
								0x95, 0x19,// EVEX_Vpermt2b_ymm_k1z_ymm_ymmm256
								0x08,// Full_Mem_256
							0x29,// VkHW_3
								0x8D,// ZMM0
								0x96, 0x19,// EVEX_Vpermt2b_zmm_k1z_zmm_zmmm512
								0x09,// Full_Mem_512
						0x09,// VectorLength
							0x29,// VkHW_3
								0x4D,// XMM0
								0x97, 0x19,// EVEX_Vpermt2w_xmm_k1z_xmm_xmmm128
								0x07,// Full_Mem_128
							0x29,// VkHW_3
								0x6D,// YMM0
								0x98, 0x19,// EVEX_Vpermt2w_ymm_k1z_ymm_ymmm256
								0x08,// Full_Mem_256
							0x29,// VkHW_3
								0x8D,// ZMM0
								0x99, 0x19,// EVEX_Vpermt2w_zmm_k1z_zmm_zmmm512
								0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 126 = 0x7E
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0x9A, 0x19,// EVEX_Vpermt2d_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0x9B, 0x19,// EVEX_Vpermt2d_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0x9C, 0x19,// EVEX_Vpermt2d_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0x9D, 0x19,// EVEX_Vpermt2q_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0x9E, 0x19,// EVEX_Vpermt2q_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0x9F, 0x19,// EVEX_Vpermt2q_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 127 = 0x7F
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xA0, 0x19,// EVEX_Vpermt2ps_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xA1, 0x19,// EVEX_Vpermt2ps_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xA2, 0x19,// EVEX_Vpermt2ps_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xA3, 0x19,// EVEX_Vpermt2pd_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xA4, 0x19,// EVEX_Vpermt2pd_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xA5, 0x19,// EVEX_Vpermt2pd_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 128 = 0x80
				0x02,// Dup
					0x03,// 3
					0x00,// Invalid

				// 131 = 0x83
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xAC, 0x19,// EVEX_Vpmultishiftqb_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xAD, 0x19,// EVEX_Vpmultishiftqb_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xAE, 0x19,// EVEX_Vpmultishiftqb_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 132 = 0x84
				0x02,// Dup
					0x04,// 4
					0x00,// Invalid

				// 136 = 0x88
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x34,// VkW_3
								0x4D,// XMM0
								0xAF, 0x19,// EVEX_Vexpandps_xmm_k1z_xmmm128
								0x0A,// Tuple1_Scalar
							0x34,// VkW_3
								0x6D,// YMM0
								0xB0, 0x19,// EVEX_Vexpandps_ymm_k1z_ymmm256
								0x0A,// Tuple1_Scalar
							0x34,// VkW_3
								0x8D,// ZMM0
								0xB1, 0x19,// EVEX_Vexpandps_zmm_k1z_zmmm512
								0x0A,// Tuple1_Scalar
						0x09,// VectorLength
							0x34,// VkW_3
								0x4D,// XMM0
								0xB2, 0x19,// EVEX_Vexpandpd_xmm_k1z_xmmm128
								0x0A,// Tuple1_Scalar
							0x34,// VkW_3
								0x6D,// YMM0
								0xB3, 0x19,// EVEX_Vexpandpd_ymm_k1z_ymmm256
								0x0A,// Tuple1_Scalar
							0x34,// VkW_3
								0x8D,// ZMM0
								0xB4, 0x19,// EVEX_Vexpandpd_zmm_k1z_zmmm512
								0x0A,// Tuple1_Scalar
					0x00,// Invalid
					0x00,// Invalid

				// 137 = 0x89
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x34,// VkW_3
								0x4D,// XMM0
								0xB5, 0x19,// EVEX_Vpexpandd_xmm_k1z_xmmm128
								0x0A,// Tuple1_Scalar
							0x34,// VkW_3
								0x6D,// YMM0
								0xB6, 0x19,// EVEX_Vpexpandd_ymm_k1z_ymmm256
								0x0A,// Tuple1_Scalar
							0x34,// VkW_3
								0x8D,// ZMM0
								0xB7, 0x19,// EVEX_Vpexpandd_zmm_k1z_zmmm512
								0x0A,// Tuple1_Scalar
						0x09,// VectorLength
							0x34,// VkW_3
								0x4D,// XMM0
								0xB8, 0x19,// EVEX_Vpexpandq_xmm_k1z_xmmm128
								0x0A,// Tuple1_Scalar
							0x34,// VkW_3
								0x6D,// YMM0
								0xB9, 0x19,// EVEX_Vpexpandq_ymm_k1z_ymmm256
								0x0A,// Tuple1_Scalar
							0x34,// VkW_3
								0x8D,// ZMM0
								0xBA, 0x19,// EVEX_Vpexpandq_zmm_k1z_zmmm512
								0x0A,// Tuple1_Scalar
					0x00,// Invalid
					0x00,// Invalid

				// 138 = 0x8A
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x45,// WkV_3
								0x4D,// XMM0
								0xBB, 0x19,// EVEX_Vcompressps_xmmm128_k1z_xmm
								0x0A,// Tuple1_Scalar
							0x45,// WkV_3
								0x6D,// YMM0
								0xBC, 0x19,// EVEX_Vcompressps_ymmm256_k1z_ymm
								0x0A,// Tuple1_Scalar
							0x45,// WkV_3
								0x8D,// ZMM0
								0xBD, 0x19,// EVEX_Vcompressps_zmmm512_k1z_zmm
								0x0A,// Tuple1_Scalar
						0x09,// VectorLength
							0x45,// WkV_3
								0x4D,// XMM0
								0xBE, 0x19,// EVEX_Vcompresspd_xmmm128_k1z_xmm
								0x0A,// Tuple1_Scalar
							0x45,// WkV_3
								0x6D,// YMM0
								0xBF, 0x19,// EVEX_Vcompresspd_ymmm256_k1z_ymm
								0x0A,// Tuple1_Scalar
							0x45,// WkV_3
								0x8D,// ZMM0
								0xC0, 0x19,// EVEX_Vcompresspd_zmmm512_k1z_zmm
								0x0A,// Tuple1_Scalar
					0x00,// Invalid
					0x00,// Invalid

				// 139 = 0x8B
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x45,// WkV_3
								0x4D,// XMM0
								0xC1, 0x19,// EVEX_Vpcompressd_xmmm128_k1z_xmm
								0x0A,// Tuple1_Scalar
							0x45,// WkV_3
								0x6D,// YMM0
								0xC2, 0x19,// EVEX_Vpcompressd_ymmm256_k1z_ymm
								0x0A,// Tuple1_Scalar
							0x45,// WkV_3
								0x8D,// ZMM0
								0xC3, 0x19,// EVEX_Vpcompressd_zmmm512_k1z_zmm
								0x0A,// Tuple1_Scalar
						0x09,// VectorLength
							0x45,// WkV_3
								0x4D,// XMM0
								0xC4, 0x19,// EVEX_Vpcompressq_xmmm128_k1z_xmm
								0x0A,// Tuple1_Scalar
							0x45,// WkV_3
								0x6D,// YMM0
								0xC5, 0x19,// EVEX_Vpcompressq_ymmm256_k1z_ymm
								0x0A,// Tuple1_Scalar
							0x45,// WkV_3
								0x8D,// ZMM0
								0xC6, 0x19,// EVEX_Vpcompressq_zmmm512_k1z_zmm
								0x0A,// Tuple1_Scalar
					0x00,// Invalid
					0x00,// Invalid

				// 140 = 0x8C
				0x00,// Invalid

				// 141 = 0x8D
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x29,// VkHW_3
								0x4D,// XMM0
								0xCB, 0x19,// EVEX_Vpermb_xmm_k1z_xmm_xmmm128
								0x07,// Full_Mem_128
							0x29,// VkHW_3
								0x6D,// YMM0
								0xCC, 0x19,// EVEX_Vpermb_ymm_k1z_ymm_ymmm256
								0x08,// Full_Mem_256
							0x29,// VkHW_3
								0x8D,// ZMM0
								0xCD, 0x19,// EVEX_Vpermb_zmm_k1z_zmm_zmmm512
								0x09,// Full_Mem_512
						0x09,// VectorLength
							0x29,// VkHW_3
								0x4D,// XMM0
								0xCE, 0x19,// EVEX_Vpermw_xmm_k1z_xmm_xmmm128
								0x07,// Full_Mem_128
							0x29,// VkHW_3
								0x6D,// YMM0
								0xCF, 0x19,// EVEX_Vpermw_ymm_k1z_ymm_ymmm256
								0x08,// Full_Mem_256
							0x29,// VkHW_3
								0x8D,// ZMM0
								0xD0, 0x19,// EVEX_Vpermw_zmm_k1z_zmm_zmmm512
								0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 142 = 0x8E
				0x00,// Invalid

				// 143 = 0x8F
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x13,// KkHW_3
								0x4D,// XMM0
								0xD5, 0x19,// EVEX_Vpshufbitqmb_k_k1_xmm_xmmm128
								0x07,// Full_Mem_128
							0x13,// KkHW_3
								0x6D,// YMM0
								0xD6, 0x19,// EVEX_Vpshufbitqmb_k_k1_ymm_ymmm256
								0x08,// Full_Mem_256
							0x13,// KkHW_3
								0x8D,// ZMM0
								0xD7, 0x19,// EVEX_Vpshufbitqmb_k_k1_zmm_zmmm512
								0x09,// Full_Mem_512
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 144 = 0x90
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x25,// Vk_VSIB
								0x4D,// XMM0
								0x4D,// XMM0
								0xDC, 0x19,// EVEX_Vpgatherdd_xmm_k1_vm32x
								0x0A,// Tuple1_Scalar
							0x25,// Vk_VSIB
								0x6D,// YMM0
								0x6D,// YMM0
								0xDD, 0x19,// EVEX_Vpgatherdd_ymm_k1_vm32y
								0x0A,// Tuple1_Scalar
							0x25,// Vk_VSIB
								0x8D,// ZMM0
								0x8D,// ZMM0
								0xDE, 0x19,// EVEX_Vpgatherdd_zmm_k1_vm32z
								0x0A,// Tuple1_Scalar
						0x09,// VectorLength
							0x25,// Vk_VSIB
								0x4D,// XMM0
								0x4D,// XMM0
								0xDF, 0x19,// EVEX_Vpgatherdq_xmm_k1_vm32x
								0x0A,// Tuple1_Scalar
							0x25,// Vk_VSIB
								0x6D,// YMM0
								0x4D,// XMM0
								0xE0, 0x19,// EVEX_Vpgatherdq_ymm_k1_vm32x
								0x0A,// Tuple1_Scalar
							0x25,// Vk_VSIB
								0x8D,// ZMM0
								0x6D,// YMM0
								0xE1, 0x19,// EVEX_Vpgatherdq_zmm_k1_vm32y
								0x0A,// Tuple1_Scalar
					0x00,// Invalid
					0x00,// Invalid

				// 145 = 0x91
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x25,// Vk_VSIB
								0x4D,// XMM0
								0x4D,// XMM0
								0xE6, 0x19,// EVEX_Vpgatherqd_xmm_k1_vm64x
								0x0A,// Tuple1_Scalar
							0x25,// Vk_VSIB
								0x4D,// XMM0
								0x6D,// YMM0
								0xE7, 0x19,// EVEX_Vpgatherqd_xmm_k1_vm64y
								0x0A,// Tuple1_Scalar
							0x25,// Vk_VSIB
								0x6D,// YMM0
								0x8D,// ZMM0
								0xE8, 0x19,// EVEX_Vpgatherqd_ymm_k1_vm64z
								0x0A,// Tuple1_Scalar
						0x09,// VectorLength
							0x25,// Vk_VSIB
								0x4D,// XMM0
								0x4D,// XMM0
								0xE9, 0x19,// EVEX_Vpgatherqq_xmm_k1_vm64x
								0x0A,// Tuple1_Scalar
							0x25,// Vk_VSIB
								0x6D,// YMM0
								0x6D,// YMM0
								0xEA, 0x19,// EVEX_Vpgatherqq_ymm_k1_vm64y
								0x0A,// Tuple1_Scalar
							0x25,// Vk_VSIB
								0x8D,// ZMM0
								0x8D,// ZMM0
								0xEB, 0x19,// EVEX_Vpgatherqq_zmm_k1_vm64z
								0x0A,// Tuple1_Scalar
					0x00,// Invalid
					0x00,// Invalid

				// 146 = 0x92
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x25,// Vk_VSIB
								0x4D,// XMM0
								0x4D,// XMM0
								0xF0, 0x19,// EVEX_Vgatherdps_xmm_k1_vm32x
								0x0A,// Tuple1_Scalar
							0x25,// Vk_VSIB
								0x6D,// YMM0
								0x6D,// YMM0
								0xF1, 0x19,// EVEX_Vgatherdps_ymm_k1_vm32y
								0x0A,// Tuple1_Scalar
							0x25,// Vk_VSIB
								0x8D,// ZMM0
								0x8D,// ZMM0
								0xF2, 0x19,// EVEX_Vgatherdps_zmm_k1_vm32z
								0x0A,// Tuple1_Scalar
						0x09,// VectorLength
							0x25,// Vk_VSIB
								0x4D,// XMM0
								0x4D,// XMM0
								0xF3, 0x19,// EVEX_Vgatherdpd_xmm_k1_vm32x
								0x0A,// Tuple1_Scalar
							0x25,// Vk_VSIB
								0x6D,// YMM0
								0x4D,// XMM0
								0xF4, 0x19,// EVEX_Vgatherdpd_ymm_k1_vm32x
								0x0A,// Tuple1_Scalar
							0x25,// Vk_VSIB
								0x8D,// ZMM0
								0x6D,// YMM0
								0xF5, 0x19,// EVEX_Vgatherdpd_zmm_k1_vm32y
								0x0A,// Tuple1_Scalar
					0x00,// Invalid
					0x00,// Invalid

				// 147 = 0x93
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x25,// Vk_VSIB
								0x4D,// XMM0
								0x4D,// XMM0
								0xFA, 0x19,// EVEX_Vgatherqps_xmm_k1_vm64x
								0x0A,// Tuple1_Scalar
							0x25,// Vk_VSIB
								0x4D,// XMM0
								0x6D,// YMM0
								0xFB, 0x19,// EVEX_Vgatherqps_xmm_k1_vm64y
								0x0A,// Tuple1_Scalar
							0x25,// Vk_VSIB
								0x6D,// YMM0
								0x8D,// ZMM0
								0xFC, 0x19,// EVEX_Vgatherqps_ymm_k1_vm64z
								0x0A,// Tuple1_Scalar
						0x09,// VectorLength
							0x25,// Vk_VSIB
								0x4D,// XMM0
								0x4D,// XMM0
								0xFD, 0x19,// EVEX_Vgatherqpd_xmm_k1_vm64x
								0x0A,// Tuple1_Scalar
							0x25,// Vk_VSIB
								0x6D,// YMM0
								0x6D,// YMM0
								0xFE, 0x19,// EVEX_Vgatherqpd_ymm_k1_vm64y
								0x0A,// Tuple1_Scalar
							0x25,// Vk_VSIB
								0x8D,// ZMM0
								0x8D,// ZMM0
								0xFF, 0x19,// EVEX_Vgatherqpd_zmm_k1_vm64z
								0x0A,// Tuple1_Scalar
					0x00,// Invalid
					0x00,// Invalid

				// 148 = 0x94
				0x01,// Invalid2

				// 150 = 0x96
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0x84, 0x1A,// EVEX_Vfmaddsub132ps_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0x85, 0x1A,// EVEX_Vfmaddsub132ps_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0x86, 0x1A,// EVEX_Vfmaddsub132ps_zmm_k1z_zmm_zmmm512b32_er
								0x03,// Full_512
								0x00,// false
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0x87, 0x1A,// EVEX_Vfmaddsub132pd_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0x88, 0x1A,// EVEX_Vfmaddsub132pd_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0x89, 0x1A,// EVEX_Vfmaddsub132pd_zmm_k1z_zmm_zmmm512b64_er
								0x03,// Full_512
								0x00,// false
					0x00,// Invalid
					0x00,// Invalid

				// 151 = 0x97
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0x8E, 0x1A,// EVEX_Vfmsubadd132ps_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0x8F, 0x1A,// EVEX_Vfmsubadd132ps_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0x90, 0x1A,// EVEX_Vfmsubadd132ps_zmm_k1z_zmm_zmmm512b32_er
								0x03,// Full_512
								0x00,// false
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0x91, 0x1A,// EVEX_Vfmsubadd132pd_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0x92, 0x1A,// EVEX_Vfmsubadd132pd_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0x93, 0x1A,// EVEX_Vfmsubadd132pd_zmm_k1z_zmm_zmmm512b64_er
								0x03,// Full_512
								0x00,// false
					0x00,// Invalid
					0x00,// Invalid

				// 152 = 0x98
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0x98, 0x1A,// EVEX_Vfmadd132ps_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0x99, 0x1A,// EVEX_Vfmadd132ps_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0x9A, 0x1A,// EVEX_Vfmadd132ps_zmm_k1z_zmm_zmmm512b32_er
								0x03,// Full_512
								0x00,// false
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0x9B, 0x1A,// EVEX_Vfmadd132pd_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0x9C, 0x1A,// EVEX_Vfmadd132pd_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0x9D, 0x1A,// EVEX_Vfmadd132pd_zmm_k1z_zmm_zmmm512b64_er
								0x03,// Full_512
								0x00,// false
					0x00,// Invalid
					0x00,// Invalid

				// 153 = 0x99
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xA0, 0x1A,// EVEX_Vfmadd132ss_xmm_k1z_xmm_xmmm32_er
							0x0A,// Tuple1_Scalar
							0x00,// false
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xA1, 0x1A,// EVEX_Vfmadd132sd_xmm_k1z_xmm_xmmm64_er
							0x0A,// Tuple1_Scalar
							0x00,// false
					0x00,// Invalid
					0x00,// Invalid

				// 154 = 0x9A
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0xA6, 0x1A,// EVEX_Vfmsub132ps_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0xA7, 0x1A,// EVEX_Vfmsub132ps_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0xA8, 0x1A,// EVEX_Vfmsub132ps_zmm_k1z_zmm_zmmm512b32_er
								0x03,// Full_512
								0x00,// false
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0xA9, 0x1A,// EVEX_Vfmsub132pd_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0xAA, 0x1A,// EVEX_Vfmsub132pd_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0xAB, 0x1A,// EVEX_Vfmsub132pd_zmm_k1z_zmm_zmmm512b64_er
								0x03,// Full_512
								0x00,// false
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x00,// Invalid
							0x00,// Invalid
							0x28,// VkHM
								0x8D,// ZMM0
								0xAC, 0x1A,// EVEX_V4fmaddps_zmm_k1z_zmmp3_m128
								0x14,// Tuple1_4X
						0x00,// Invalid

				// 155 = 0x9B
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xAF, 0x1A,// EVEX_Vfmsub132ss_xmm_k1z_xmm_xmmm32_er
							0x0A,// Tuple1_Scalar
							0x00,// false
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xB0, 0x1A,// EVEX_Vfmsub132sd_xmm_k1z_xmm_xmmm64_er
							0x0A,// Tuple1_Scalar
							0x00,// false
					0x00,// Invalid
					0x07,// W
						0x28,// VkHM
							0x4D,// XMM0
							0xB1, 0x1A,// EVEX_V4fmaddss_xmm_k1z_xmmp3_m128
							0x14,// Tuple1_4X
						0x00,// Invalid

				// 156 = 0x9C
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0xB6, 0x1A,// EVEX_Vfnmadd132ps_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0xB7, 0x1A,// EVEX_Vfnmadd132ps_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0xB8, 0x1A,// EVEX_Vfnmadd132ps_zmm_k1z_zmm_zmmm512b32_er
								0x03,// Full_512
								0x00,// false
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0xB9, 0x1A,// EVEX_Vfnmadd132pd_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0xBA, 0x1A,// EVEX_Vfnmadd132pd_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0xBB, 0x1A,// EVEX_Vfnmadd132pd_zmm_k1z_zmm_zmmm512b64_er
								0x03,// Full_512
								0x00,// false
					0x00,// Invalid
					0x00,// Invalid

				// 157 = 0x9D
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xBE, 0x1A,// EVEX_Vfnmadd132ss_xmm_k1z_xmm_xmmm32_er
							0x0A,// Tuple1_Scalar
							0x00,// false
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xBF, 0x1A,// EVEX_Vfnmadd132sd_xmm_k1z_xmm_xmmm64_er
							0x0A,// Tuple1_Scalar
							0x00,// false
					0x00,// Invalid
					0x00,// Invalid

				// 158 = 0x9E
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0xC4, 0x1A,// EVEX_Vfnmsub132ps_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0xC5, 0x1A,// EVEX_Vfnmsub132ps_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0xC6, 0x1A,// EVEX_Vfnmsub132ps_zmm_k1z_zmm_zmmm512b32_er
								0x03,// Full_512
								0x00,// false
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0xC7, 0x1A,// EVEX_Vfnmsub132pd_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0xC8, 0x1A,// EVEX_Vfnmsub132pd_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0xC9, 0x1A,// EVEX_Vfnmsub132pd_zmm_k1z_zmm_zmmm512b64_er
								0x03,// Full_512
								0x00,// false
					0x00,// Invalid
					0x00,// Invalid

				// 159 = 0x9F
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xCC, 0x1A,// EVEX_Vfnmsub132ss_xmm_k1z_xmm_xmmm32_er
							0x0A,// Tuple1_Scalar
							0x00,// false
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xCD, 0x1A,// EVEX_Vfnmsub132sd_xmm_k1z_xmm_xmmm64_er
							0x0A,// Tuple1_Scalar
							0x00,// false
					0x00,// Invalid
					0x00,// Invalid

				// 160 = 0xA0
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x40,// VSIB_k1_VX
								0x4D,// XMM0
								0x4D,// XMM0
								0xCE, 0x1A,// EVEX_Vpscatterdd_vm32x_k1_xmm
								0x0A,// Tuple1_Scalar
							0x40,// VSIB_k1_VX
								0x6D,// YMM0
								0x6D,// YMM0
								0xCF, 0x1A,// EVEX_Vpscatterdd_vm32y_k1_ymm
								0x0A,// Tuple1_Scalar
							0x40,// VSIB_k1_VX
								0x8D,// ZMM0
								0x8D,// ZMM0
								0xD0, 0x1A,// EVEX_Vpscatterdd_vm32z_k1_zmm
								0x0A,// Tuple1_Scalar
						0x09,// VectorLength
							0x40,// VSIB_k1_VX
								0x4D,// XMM0
								0x4D,// XMM0
								0xD1, 0x1A,// EVEX_Vpscatterdq_vm32x_k1_xmm
								0x0A,// Tuple1_Scalar
							0x40,// VSIB_k1_VX
								0x4D,// XMM0
								0x6D,// YMM0
								0xD2, 0x1A,// EVEX_Vpscatterdq_vm32x_k1_ymm
								0x0A,// Tuple1_Scalar
							0x40,// VSIB_k1_VX
								0x6D,// YMM0
								0x8D,// ZMM0
								0xD3, 0x1A,// EVEX_Vpscatterdq_vm32y_k1_zmm
								0x0A,// Tuple1_Scalar
					0x00,// Invalid
					0x00,// Invalid

				// 161 = 0xA1
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x40,// VSIB_k1_VX
								0x4D,// XMM0
								0x4D,// XMM0
								0xD4, 0x1A,// EVEX_Vpscatterqd_vm64x_k1_xmm
								0x0A,// Tuple1_Scalar
							0x40,// VSIB_k1_VX
								0x6D,// YMM0
								0x4D,// XMM0
								0xD5, 0x1A,// EVEX_Vpscatterqd_vm64y_k1_xmm
								0x0A,// Tuple1_Scalar
							0x40,// VSIB_k1_VX
								0x8D,// ZMM0
								0x6D,// YMM0
								0xD6, 0x1A,// EVEX_Vpscatterqd_vm64z_k1_ymm
								0x0A,// Tuple1_Scalar
						0x09,// VectorLength
							0x40,// VSIB_k1_VX
								0x4D,// XMM0
								0x4D,// XMM0
								0xD7, 0x1A,// EVEX_Vpscatterqq_vm64x_k1_xmm
								0x0A,// Tuple1_Scalar
							0x40,// VSIB_k1_VX
								0x6D,// YMM0
								0x6D,// YMM0
								0xD8, 0x1A,// EVEX_Vpscatterqq_vm64y_k1_ymm
								0x0A,// Tuple1_Scalar
							0x40,// VSIB_k1_VX
								0x8D,// ZMM0
								0x8D,// ZMM0
								0xD9, 0x1A,// EVEX_Vpscatterqq_vm64z_k1_zmm
								0x0A,// Tuple1_Scalar
					0x00,// Invalid
					0x00,// Invalid

				// 162 = 0xA2
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x40,// VSIB_k1_VX
								0x4D,// XMM0
								0x4D,// XMM0
								0xDA, 0x1A,// EVEX_Vscatterdps_vm32x_k1_xmm
								0x0A,// Tuple1_Scalar
							0x40,// VSIB_k1_VX
								0x6D,// YMM0
								0x6D,// YMM0
								0xDB, 0x1A,// EVEX_Vscatterdps_vm32y_k1_ymm
								0x0A,// Tuple1_Scalar
							0x40,// VSIB_k1_VX
								0x8D,// ZMM0
								0x8D,// ZMM0
								0xDC, 0x1A,// EVEX_Vscatterdps_vm32z_k1_zmm
								0x0A,// Tuple1_Scalar
						0x09,// VectorLength
							0x40,// VSIB_k1_VX
								0x4D,// XMM0
								0x4D,// XMM0
								0xDD, 0x1A,// EVEX_Vscatterdpd_vm32x_k1_xmm
								0x0A,// Tuple1_Scalar
							0x40,// VSIB_k1_VX
								0x4D,// XMM0
								0x6D,// YMM0
								0xDE, 0x1A,// EVEX_Vscatterdpd_vm32x_k1_ymm
								0x0A,// Tuple1_Scalar
							0x40,// VSIB_k1_VX
								0x6D,// YMM0
								0x8D,// ZMM0
								0xDF, 0x1A,// EVEX_Vscatterdpd_vm32y_k1_zmm
								0x0A,// Tuple1_Scalar
					0x00,// Invalid
					0x00,// Invalid

				// 163 = 0xA3
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x40,// VSIB_k1_VX
								0x4D,// XMM0
								0x4D,// XMM0
								0xE0, 0x1A,// EVEX_Vscatterqps_vm64x_k1_xmm
								0x0A,// Tuple1_Scalar
							0x40,// VSIB_k1_VX
								0x6D,// YMM0
								0x4D,// XMM0
								0xE1, 0x1A,// EVEX_Vscatterqps_vm64y_k1_xmm
								0x0A,// Tuple1_Scalar
							0x40,// VSIB_k1_VX
								0x8D,// ZMM0
								0x6D,// YMM0
								0xE2, 0x1A,// EVEX_Vscatterqps_vm64z_k1_ymm
								0x0A,// Tuple1_Scalar
						0x09,// VectorLength
							0x40,// VSIB_k1_VX
								0x4D,// XMM0
								0x4D,// XMM0
								0xE3, 0x1A,// EVEX_Vscatterqpd_vm64x_k1_xmm
								0x0A,// Tuple1_Scalar
							0x40,// VSIB_k1_VX
								0x6D,// YMM0
								0x6D,// YMM0
								0xE4, 0x1A,// EVEX_Vscatterqpd_vm64y_k1_ymm
								0x0A,// Tuple1_Scalar
							0x40,// VSIB_k1_VX
								0x8D,// ZMM0
								0x8D,// ZMM0
								0xE5, 0x1A,// EVEX_Vscatterqpd_vm64z_k1_zmm
								0x0A,// Tuple1_Scalar
					0x00,// Invalid
					0x00,// Invalid

				// 164 = 0xA4
				0x01,// Invalid2

				// 166 = 0xA6
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0xEA, 0x1A,// EVEX_Vfmaddsub213ps_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0xEB, 0x1A,// EVEX_Vfmaddsub213ps_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0xEC, 0x1A,// EVEX_Vfmaddsub213ps_zmm_k1z_zmm_zmmm512b32_er
								0x03,// Full_512
								0x00,// false
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0xED, 0x1A,// EVEX_Vfmaddsub213pd_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0xEE, 0x1A,// EVEX_Vfmaddsub213pd_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0xEF, 0x1A,// EVEX_Vfmaddsub213pd_zmm_k1z_zmm_zmmm512b64_er
								0x03,// Full_512
								0x00,// false
					0x00,// Invalid
					0x00,// Invalid

				// 167 = 0xA7
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0xF4, 0x1A,// EVEX_Vfmsubadd213ps_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0xF5, 0x1A,// EVEX_Vfmsubadd213ps_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0xF6, 0x1A,// EVEX_Vfmsubadd213ps_zmm_k1z_zmm_zmmm512b32_er
								0x03,// Full_512
								0x00,// false
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0xF7, 0x1A,// EVEX_Vfmsubadd213pd_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0xF8, 0x1A,// EVEX_Vfmsubadd213pd_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0xF9, 0x1A,// EVEX_Vfmsubadd213pd_zmm_k1z_zmm_zmmm512b64_er
								0x03,// Full_512
								0x00,// false
					0x00,// Invalid
					0x00,// Invalid

				// 168 = 0xA8
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0xFE, 0x1A,// EVEX_Vfmadd213ps_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0xFF, 0x1A,// EVEX_Vfmadd213ps_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0x80, 0x1B,// EVEX_Vfmadd213ps_zmm_k1z_zmm_zmmm512b32_er
								0x03,// Full_512
								0x00,// false
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0x81, 0x1B,// EVEX_Vfmadd213pd_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0x82, 0x1B,// EVEX_Vfmadd213pd_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0x83, 0x1B,// EVEX_Vfmadd213pd_zmm_k1z_zmm_zmmm512b64_er
								0x03,// Full_512
								0x00,// false
					0x00,// Invalid
					0x00,// Invalid

				// 169 = 0xA9
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0x86, 0x1B,// EVEX_Vfmadd213ss_xmm_k1z_xmm_xmmm32_er
							0x0A,// Tuple1_Scalar
							0x00,// false
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0x87, 0x1B,// EVEX_Vfmadd213sd_xmm_k1z_xmm_xmmm64_er
							0x0A,// Tuple1_Scalar
							0x00,// false
					0x00,// Invalid
					0x00,// Invalid

				// 170 = 0xAA
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0x8C, 0x1B,// EVEX_Vfmsub213ps_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0x8D, 0x1B,// EVEX_Vfmsub213ps_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0x8E, 0x1B,// EVEX_Vfmsub213ps_zmm_k1z_zmm_zmmm512b32_er
								0x03,// Full_512
								0x00,// false
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0x8F, 0x1B,// EVEX_Vfmsub213pd_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0x90, 0x1B,// EVEX_Vfmsub213pd_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0x91, 0x1B,// EVEX_Vfmsub213pd_zmm_k1z_zmm_zmmm512b64_er
								0x03,// Full_512
								0x00,// false
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x00,// Invalid
							0x00,// Invalid
							0x28,// VkHM
								0x8D,// ZMM0
								0x92, 0x1B,// EVEX_V4fnmaddps_zmm_k1z_zmmp3_m128
								0x14,// Tuple1_4X
						0x00,// Invalid

				// 171 = 0xAB
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0x95, 0x1B,// EVEX_Vfmsub213ss_xmm_k1z_xmm_xmmm32_er
							0x0A,// Tuple1_Scalar
							0x00,// false
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0x96, 0x1B,// EVEX_Vfmsub213sd_xmm_k1z_xmm_xmmm64_er
							0x0A,// Tuple1_Scalar
							0x00,// false
					0x00,// Invalid
					0x07,// W
						0x28,// VkHM
							0x4D,// XMM0
							0x97, 0x1B,// EVEX_V4fnmaddss_xmm_k1z_xmmp3_m128
							0x14,// Tuple1_4X
						0x00,// Invalid

				// 172 = 0xAC
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0x9C, 0x1B,// EVEX_Vfnmadd213ps_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0x9D, 0x1B,// EVEX_Vfnmadd213ps_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0x9E, 0x1B,// EVEX_Vfnmadd213ps_zmm_k1z_zmm_zmmm512b32_er
								0x03,// Full_512
								0x00,// false
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0x9F, 0x1B,// EVEX_Vfnmadd213pd_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0xA0, 0x1B,// EVEX_Vfnmadd213pd_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0xA1, 0x1B,// EVEX_Vfnmadd213pd_zmm_k1z_zmm_zmmm512b64_er
								0x03,// Full_512
								0x00,// false
					0x00,// Invalid
					0x00,// Invalid

				// 173 = 0xAD
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xA4, 0x1B,// EVEX_Vfnmadd213ss_xmm_k1z_xmm_xmmm32_er
							0x0A,// Tuple1_Scalar
							0x00,// false
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xA5, 0x1B,// EVEX_Vfnmadd213sd_xmm_k1z_xmm_xmmm64_er
							0x0A,// Tuple1_Scalar
							0x00,// false
					0x00,// Invalid
					0x00,// Invalid

				// 174 = 0xAE
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0xAA, 0x1B,// EVEX_Vfnmsub213ps_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0xAB, 0x1B,// EVEX_Vfnmsub213ps_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0xAC, 0x1B,// EVEX_Vfnmsub213ps_zmm_k1z_zmm_zmmm512b32_er
								0x03,// Full_512
								0x00,// false
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0xAD, 0x1B,// EVEX_Vfnmsub213pd_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0xAE, 0x1B,// EVEX_Vfnmsub213pd_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0xAF, 0x1B,// EVEX_Vfnmsub213pd_zmm_k1z_zmm_zmmm512b64_er
								0x03,// Full_512
								0x00,// false
					0x00,// Invalid
					0x00,// Invalid

				// 175 = 0xAF
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xB2, 0x1B,// EVEX_Vfnmsub213ss_xmm_k1z_xmm_xmmm32_er
							0x0A,// Tuple1_Scalar
							0x00,// false
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xB3, 0x1B,// EVEX_Vfnmsub213sd_xmm_k1z_xmm_xmmm64_er
							0x0A,// Tuple1_Scalar
							0x00,// false
					0x00,// Invalid
					0x00,// Invalid

				// 176 = 0xB0
				0x02,// Dup
					0x04,// 4
					0x00,// Invalid

				// 180 = 0xB4
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xB4, 0x1B,// EVEX_Vpmadd52luq_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xB5, 0x1B,// EVEX_Vpmadd52luq_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xB6, 0x1B,// EVEX_Vpmadd52luq_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 181 = 0xB5
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xB7, 0x1B,// EVEX_Vpmadd52huq_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xB8, 0x1B,// EVEX_Vpmadd52huq_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xB9, 0x1B,// EVEX_Vpmadd52huq_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 182 = 0xB6
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0xBE, 0x1B,// EVEX_Vfmaddsub231ps_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0xBF, 0x1B,// EVEX_Vfmaddsub231ps_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0xC0, 0x1B,// EVEX_Vfmaddsub231ps_zmm_k1z_zmm_zmmm512b32_er
								0x03,// Full_512
								0x00,// false
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0xC1, 0x1B,// EVEX_Vfmaddsub231pd_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0xC2, 0x1B,// EVEX_Vfmaddsub231pd_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0xC3, 0x1B,// EVEX_Vfmaddsub231pd_zmm_k1z_zmm_zmmm512b64_er
								0x03,// Full_512
								0x00,// false
					0x00,// Invalid
					0x00,// Invalid

				// 183 = 0xB7
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0xC8, 0x1B,// EVEX_Vfmsubadd231ps_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0xC9, 0x1B,// EVEX_Vfmsubadd231ps_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0xCA, 0x1B,// EVEX_Vfmsubadd231ps_zmm_k1z_zmm_zmmm512b32_er
								0x03,// Full_512
								0x00,// false
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0xCB, 0x1B,// EVEX_Vfmsubadd231pd_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0xCC, 0x1B,// EVEX_Vfmsubadd231pd_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0xCD, 0x1B,// EVEX_Vfmsubadd231pd_zmm_k1z_zmm_zmmm512b64_er
								0x03,// Full_512
								0x00,// false
					0x00,// Invalid
					0x00,// Invalid

				// 184 = 0xB8
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0xD2, 0x1B,// EVEX_Vfmadd231ps_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0xD3, 0x1B,// EVEX_Vfmadd231ps_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0xD4, 0x1B,// EVEX_Vfmadd231ps_zmm_k1z_zmm_zmmm512b32_er
								0x03,// Full_512
								0x00,// false
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0xD5, 0x1B,// EVEX_Vfmadd231pd_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0xD6, 0x1B,// EVEX_Vfmadd231pd_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0xD7, 0x1B,// EVEX_Vfmadd231pd_zmm_k1z_zmm_zmmm512b64_er
								0x03,// Full_512
								0x00,// false
					0x00,// Invalid
					0x00,// Invalid

				// 185 = 0xB9
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xDA, 0x1B,// EVEX_Vfmadd231ss_xmm_k1z_xmm_xmmm32_er
							0x0A,// Tuple1_Scalar
							0x00,// false
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xDB, 0x1B,// EVEX_Vfmadd231sd_xmm_k1z_xmm_xmmm64_er
							0x0A,// Tuple1_Scalar
							0x00,// false
					0x00,// Invalid
					0x00,// Invalid

				// 186 = 0xBA
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0xE0, 0x1B,// EVEX_Vfmsub231ps_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0xE1, 0x1B,// EVEX_Vfmsub231ps_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0xE2, 0x1B,// EVEX_Vfmsub231ps_zmm_k1z_zmm_zmmm512b32_er
								0x03,// Full_512
								0x00,// false
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0xE3, 0x1B,// EVEX_Vfmsub231pd_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0xE4, 0x1B,// EVEX_Vfmsub231pd_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0xE5, 0x1B,// EVEX_Vfmsub231pd_zmm_k1z_zmm_zmmm512b64_er
								0x03,// Full_512
								0x00,// false
					0x00,// Invalid
					0x00,// Invalid

				// 187 = 0xBB
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xE8, 0x1B,// EVEX_Vfmsub231ss_xmm_k1z_xmm_xmmm32_er
							0x0A,// Tuple1_Scalar
							0x00,// false
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xE9, 0x1B,// EVEX_Vfmsub231sd_xmm_k1z_xmm_xmmm64_er
							0x0A,// Tuple1_Scalar
							0x00,// false
					0x00,// Invalid
					0x00,// Invalid

				// 188 = 0xBC
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0xEE, 0x1B,// EVEX_Vfnmadd231ps_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0xEF, 0x1B,// EVEX_Vfnmadd231ps_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0xF0, 0x1B,// EVEX_Vfnmadd231ps_zmm_k1z_zmm_zmmm512b32_er
								0x03,// Full_512
								0x00,// false
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0xF1, 0x1B,// EVEX_Vfnmadd231pd_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0xF2, 0x1B,// EVEX_Vfnmadd231pd_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0xF3, 0x1B,// EVEX_Vfnmadd231pd_zmm_k1z_zmm_zmmm512b64_er
								0x03,// Full_512
								0x00,// false
					0x00,// Invalid
					0x00,// Invalid

				// 189 = 0xBD
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xF6, 0x1B,// EVEX_Vfnmadd231ss_xmm_k1z_xmm_xmmm32_er
							0x0A,// Tuple1_Scalar
							0x00,// false
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xF7, 0x1B,// EVEX_Vfnmadd231sd_xmm_k1z_xmm_xmmm64_er
							0x0A,// Tuple1_Scalar
							0x00,// false
					0x00,// Invalid
					0x00,// Invalid

				// 190 = 0xBE
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0xFC, 0x1B,// EVEX_Vfnmsub231ps_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0xFD, 0x1B,// EVEX_Vfnmsub231ps_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0xFE, 0x1B,// EVEX_Vfnmsub231ps_zmm_k1z_zmm_zmmm512b32_er
								0x03,// Full_512
								0x00,// false
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0xFF, 0x1B,// EVEX_Vfnmsub231pd_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0x80, 0x1C,// EVEX_Vfnmsub231pd_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0x81, 0x1C,// EVEX_Vfnmsub231pd_zmm_k1z_zmm_zmmm512b64_er
								0x03,// Full_512
								0x00,// false
					0x00,// Invalid
					0x00,// Invalid

				// 191 = 0xBF
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0x84, 0x1C,// EVEX_Vfnmsub231ss_xmm_k1z_xmm_xmmm32_er
							0x0A,// Tuple1_Scalar
							0x00,// false
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0x85, 0x1C,// EVEX_Vfnmsub231sd_xmm_k1z_xmm_xmmm64_er
							0x0A,// Tuple1_Scalar
							0x00,// false
					0x00,// Invalid
					0x00,// Invalid

				// 192 = 0xC0
				0x02,// Dup
					0x04,// 4
					0x00,// Invalid

				// 196 = 0xC4
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x35,// VkW_3b
								0x4D,// XMM0
								0x86, 0x1C,// EVEX_Vpconflictd_xmm_k1z_xmmm128b32
								0x01,// Full_128
							0x35,// VkW_3b
								0x6D,// YMM0
								0x87, 0x1C,// EVEX_Vpconflictd_ymm_k1z_ymmm256b32
								0x02,// Full_256
							0x35,// VkW_3b
								0x8D,// ZMM0
								0x88, 0x1C,// EVEX_Vpconflictd_zmm_k1z_zmmm512b32
								0x03,// Full_512
						0x09,// VectorLength
							0x35,// VkW_3b
								0x4D,// XMM0
								0x89, 0x1C,// EVEX_Vpconflictq_xmm_k1z_xmmm128b64
								0x01,// Full_128
							0x35,// VkW_3b
								0x6D,// YMM0
								0x8A, 0x1C,// EVEX_Vpconflictq_ymm_k1z_ymmm256b64
								0x02,// Full_256
							0x35,// VkW_3b
								0x8D,// ZMM0
								0x8B, 0x1C,// EVEX_Vpconflictq_zmm_k1z_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 197 = 0xC5
				0x00,// Invalid

				// 198 = 0xC6
				0x06,// Group
					0x04,// ArrayReference
						0x03,// 0x3 = handlers_Grp_0F38C6

				// 199 = 0xC7
				0x06,// Group
					0x04,// ArrayReference
						0x04,// 0x4 = handlers_Grp_0F38C7

				// 200 = 0xC8
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x0A,// VectorLength_er
							0x00,// Invalid
							0x00,// Invalid
							0x38,// VkW_er_4
								0x8D,// ZMM0
								0x9D, 0x1C,// EVEX_Vexp2ps_zmm_k1z_zmmm512b32_sae
								0x03,// Full_512
								0x01,// true
						0x0A,// VectorLength_er
							0x00,// Invalid
							0x00,// Invalid
							0x38,// VkW_er_4
								0x8D,// ZMM0
								0x9E, 0x1C,// EVEX_Vexp2pd_zmm_k1z_zmmm512b64_sae
								0x03,// Full_512
								0x01,// true
					0x00,// Invalid
					0x00,// Invalid

				// 201 = 0xC9
				0x00,// Invalid

				// 202 = 0xCA
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x0A,// VectorLength_er
							0x00,// Invalid
							0x00,// Invalid
							0x38,// VkW_er_4
								0x8D,// ZMM0
								0xA1, 0x1C,// EVEX_Vrcp28ps_zmm_k1z_zmmm512b32_sae
								0x03,// Full_512
								0x01,// true
						0x0A,// VectorLength_er
							0x00,// Invalid
							0x00,// Invalid
							0x38,// VkW_er_4
								0x8D,// ZMM0
								0xA2, 0x1C,// EVEX_Vrcp28pd_zmm_k1z_zmmm512b64_sae
								0x03,// Full_512
								0x01,// true
					0x00,// Invalid
					0x00,// Invalid

				// 203 = 0xCB
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xA4, 0x1C,// EVEX_Vrcp28ss_xmm_k1z_xmm_xmmm32_sae
							0x0A,// Tuple1_Scalar
							0x01,// true
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xA5, 0x1C,// EVEX_Vrcp28sd_xmm_k1z_xmm_xmmm64_sae
							0x0A,// Tuple1_Scalar
							0x01,// true
					0x00,// Invalid
					0x00,// Invalid

				// 204 = 0xCC
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x0A,// VectorLength_er
							0x00,// Invalid
							0x00,// Invalid
							0x38,// VkW_er_4
								0x8D,// ZMM0
								0xA7, 0x1C,// EVEX_Vrsqrt28ps_zmm_k1z_zmmm512b32_sae
								0x03,// Full_512
								0x01,// true
						0x0A,// VectorLength_er
							0x00,// Invalid
							0x00,// Invalid
							0x38,// VkW_er_4
								0x8D,// ZMM0
								0xA8, 0x1C,// EVEX_Vrsqrt28pd_zmm_k1z_zmmm512b64_sae
								0x03,// Full_512
								0x01,// true
					0x00,// Invalid
					0x00,// Invalid

				// 205 = 0xCD
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xAA, 0x1C,// EVEX_Vrsqrt28ss_xmm_k1z_xmm_xmmm32_sae
							0x0A,// Tuple1_Scalar
							0x01,// true
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xAB, 0x1C,// EVEX_Vrsqrt28sd_xmm_k1z_xmm_xmmm64_sae
							0x0A,// Tuple1_Scalar
							0x01,// true
					0x00,// Invalid
					0x00,// Invalid

				// 206 = 0xCE
				0x00,// Invalid

				// 207 = 0xCF
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x29,// VkHW_3
								0x4D,// XMM0
								0xAF, 0x1C,// EVEX_Vgf2p8mulb_xmm_k1z_xmm_xmmm128
								0x07,// Full_Mem_128
							0x29,// VkHW_3
								0x6D,// YMM0
								0xB0, 0x1C,// EVEX_Vgf2p8mulb_ymm_k1z_ymm_ymmm256
								0x08,// Full_Mem_256
							0x29,// VkHW_3
								0x8D,// ZMM0
								0xB1, 0x1C,// EVEX_Vgf2p8mulb_zmm_k1z_zmm_zmmm512
								0x09,// Full_Mem_512
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 208 = 0xD0
				0x02,// Dup
					0x0C,// 12
					0x00,// Invalid

				// 220 = 0xDC
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x21,// VHW_3
							0x4D,// XMM0
							0xB7, 0x1C,// EVEX_Vaesenc_xmm_xmm_xmmm128
							0x07,// Full_Mem_128
						0x21,// VHW_3
							0x6D,// YMM0
							0xB8, 0x1C,// EVEX_Vaesenc_ymm_ymm_ymmm256
							0x08,// Full_Mem_256
						0x21,// VHW_3
							0x8D,// ZMM0
							0xB9, 0x1C,// EVEX_Vaesenc_zmm_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 221 = 0xDD
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x21,// VHW_3
							0x4D,// XMM0
							0xBD, 0x1C,// EVEX_Vaesenclast_xmm_xmm_xmmm128
							0x07,// Full_Mem_128
						0x21,// VHW_3
							0x6D,// YMM0
							0xBE, 0x1C,// EVEX_Vaesenclast_ymm_ymm_ymmm256
							0x08,// Full_Mem_256
						0x21,// VHW_3
							0x8D,// ZMM0
							0xBF, 0x1C,// EVEX_Vaesenclast_zmm_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 222 = 0xDE
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x21,// VHW_3
							0x4D,// XMM0
							0xC3, 0x1C,// EVEX_Vaesdec_xmm_xmm_xmmm128
							0x07,// Full_Mem_128
						0x21,// VHW_3
							0x6D,// YMM0
							0xC4, 0x1C,// EVEX_Vaesdec_ymm_ymm_ymmm256
							0x08,// Full_Mem_256
						0x21,// VHW_3
							0x8D,// ZMM0
							0xC5, 0x1C,// EVEX_Vaesdec_zmm_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 223 = 0xDF
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x21,// VHW_3
							0x4D,// XMM0
							0xC9, 0x1C,// EVEX_Vaesdeclast_xmm_xmm_xmmm128
							0x07,// Full_Mem_128
						0x21,// VHW_3
							0x6D,// YMM0
							0xCA, 0x1C,// EVEX_Vaesdeclast_ymm_ymm_ymmm256
							0x08,// Full_Mem_256
						0x21,// VHW_3
							0x8D,// ZMM0
							0xCB, 0x1C,// EVEX_Vaesdeclast_zmm_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 224 = 0xE0
				0x02,// Dup
					0x20,// 32
					0x00,// Invalid

				// ThreeByteHandlers_0F3AXX
				0x01,// ArrayReference
				0x80, 0x02,// 0x100
				// 0 = 0x00
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x00,// Invalid
							0x3C,// VkWIb_3b
								0x6D,// YMM0
								0x83, 0x1D,// EVEX_Vpermq_ymm_k1z_ymmm256b64_imm8
								0x02,// Full_256
							0x3C,// VkWIb_3b
								0x8D,// ZMM0
								0x84, 0x1D,// EVEX_Vpermq_zmm_k1z_zmmm512b64_imm8
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 1 = 0x01
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x00,// Invalid
							0x3C,// VkWIb_3b
								0x6D,// YMM0
								0x86, 0x1D,// EVEX_Vpermpd_ymm_k1z_ymmm256b64_imm8
								0x02,// Full_256
							0x3C,// VkWIb_3b
								0x8D,// ZMM0
								0x87, 0x1D,// EVEX_Vpermpd_zmm_k1z_zmmm512b64_imm8
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 2 = 0x02
				0x00,// Invalid

				// 3 = 0x03
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2F,// VkHWIb_3b
								0x4D,// XMM0
								0x8A, 0x1D,// EVEX_Valignd_xmm_k1z_xmm_xmmm128b32_imm8
								0x01,// Full_128
							0x2F,// VkHWIb_3b
								0x6D,// YMM0
								0x8B, 0x1D,// EVEX_Valignd_ymm_k1z_ymm_ymmm256b32_imm8
								0x02,// Full_256
							0x2F,// VkHWIb_3b
								0x8D,// ZMM0
								0x8C, 0x1D,// EVEX_Valignd_zmm_k1z_zmm_zmmm512b32_imm8
								0x03,// Full_512
						0x09,// VectorLength
							0x2F,// VkHWIb_3b
								0x4D,// XMM0
								0x8D, 0x1D,// EVEX_Valignq_xmm_k1z_xmm_xmmm128b64_imm8
								0x01,// Full_128
							0x2F,// VkHWIb_3b
								0x6D,// YMM0
								0x8E, 0x1D,// EVEX_Valignq_ymm_k1z_ymm_ymmm256b64_imm8
								0x02,// Full_256
							0x2F,// VkHWIb_3b
								0x8D,// ZMM0
								0x8F, 0x1D,// EVEX_Valignq_zmm_k1z_zmm_zmmm512b64_imm8
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 4 = 0x04
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x3C,// VkWIb_3b
								0x4D,// XMM0
								0x92, 0x1D,// EVEX_Vpermilps_xmm_k1z_xmmm128b32_imm8
								0x01,// Full_128
							0x3C,// VkWIb_3b
								0x6D,// YMM0
								0x93, 0x1D,// EVEX_Vpermilps_ymm_k1z_ymmm256b32_imm8
								0x02,// Full_256
							0x3C,// VkWIb_3b
								0x8D,// ZMM0
								0x94, 0x1D,// EVEX_Vpermilps_zmm_k1z_zmmm512b32_imm8
								0x03,// Full_512
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 5 = 0x05
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x3C,// VkWIb_3b
								0x4D,// XMM0
								0x97, 0x1D,// EVEX_Vpermilpd_xmm_k1z_xmmm128b64_imm8
								0x01,// Full_128
							0x3C,// VkWIb_3b
								0x6D,// YMM0
								0x98, 0x1D,// EVEX_Vpermilpd_ymm_k1z_ymmm256b64_imm8
								0x02,// Full_256
							0x3C,// VkWIb_3b
								0x8D,// ZMM0
								0x99, 0x1D,// EVEX_Vpermilpd_zmm_k1z_zmmm512b64_imm8
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 6 = 0x06
				0x01,// Invalid2

				// 8 = 0x08
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x0A,// VectorLength_er
							0x3D,// VkWIb_er
								0x4D,// XMM0
								0x9E, 0x1D,// EVEX_Vrndscaleps_xmm_k1z_xmmm128b32_imm8
								0x01,// Full_128
							0x3D,// VkWIb_er
								0x6D,// YMM0
								0x9F, 0x1D,// EVEX_Vrndscaleps_ymm_k1z_ymmm256b32_imm8
								0x02,// Full_256
							0x3D,// VkWIb_er
								0x8D,// ZMM0
								0xA0, 0x1D,// EVEX_Vrndscaleps_zmm_k1z_zmmm512b32_imm8_sae
								0x03,// Full_512
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 9 = 0x09
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x0A,// VectorLength_er
							0x3D,// VkWIb_er
								0x4D,// XMM0
								0xA4, 0x1D,// EVEX_Vrndscalepd_xmm_k1z_xmmm128b64_imm8
								0x01,// Full_128
							0x3D,// VkWIb_er
								0x6D,// YMM0
								0xA5, 0x1D,// EVEX_Vrndscalepd_ymm_k1z_ymmm256b64_imm8
								0x02,// Full_256
							0x3D,// VkWIb_er
								0x8D,// ZMM0
								0xA6, 0x1D,// EVEX_Vrndscalepd_zmm_k1z_zmmm512b64_imm8_sae
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 10 = 0x0A
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x31,// VkHWIb_er_4
							0x4D,// XMM0
							0xA9, 0x1D,// EVEX_Vrndscaless_xmm_k1z_xmm_xmmm32_imm8_sae
							0x0A,// Tuple1_Scalar
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 11 = 0x0B
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x31,// VkHWIb_er_4
							0x4D,// XMM0
							0xAC, 0x1D,// EVEX_Vrndscalesd_xmm_k1z_xmm_xmmm64_imm8_sae
							0x0A,// Tuple1_Scalar
					0x00,// Invalid
					0x00,// Invalid

				// 12 = 0x0C
				0x02,// Dup
					0x03,// 3
					0x00,// Invalid

				// 15 = 0x0F
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x2E,// VkHWIb_3
							0x4D,// XMM0
							0xBA, 0x1D,// EVEX_Vpalignr_xmm_k1z_xmm_xmmm128_imm8
							0x07,// Full_Mem_128
						0x2E,// VkHWIb_3
							0x6D,// YMM0
							0xBB, 0x1D,// EVEX_Vpalignr_ymm_k1z_ymm_ymmm256_imm8
							0x08,// Full_Mem_256
						0x2E,// VkHWIb_3
							0x8D,// ZMM0
							0xBC, 0x1D,// EVEX_Vpalignr_zmm_k1z_zmm_zmmm512_imm8
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 16 = 0x10
				0x02,// Dup
					0x04,// 4
					0x00,// Invalid

				// 20 = 0x14
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x0F,// GvM_VX_Ib
							0x4D,// XMM0
							0xC1, 0x1D,// EVEX_Vpextrb_r32m8_xmm_imm8
							0x0B,// Tuple1_Scalar_1
							0x0B,// Tuple1_Scalar_1
						0x00,// Invalid
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 21 = 0x15
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x0F,// GvM_VX_Ib
							0x4D,// XMM0
							0xC7, 0x1D,// EVEX_Vpextrw_r32m16_xmm_imm8
							0x0C,// Tuple1_Scalar_2
							0x0C,// Tuple1_Scalar_2
						0x00,// Invalid
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 22 = 0x16
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x0F,// GvM_VX_Ib
							0x4D,// XMM0
							0xCD, 0x1D,// EVEX_Vpextrd_rm32_xmm_imm8
							0x0D,// Tuple1_Scalar_4
							0x0E,// Tuple1_Scalar_8
						0x00,// Invalid
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 23 = 0x17
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x0B,// Ed_V_Ib
							0x4D,// XMM0
							0xD3, 0x1D,// EVEX_Vextractps_rm32_xmm_imm8
							0x0D,// Tuple1_Scalar_4
							0x0D,// Tuple1_Scalar_4
						0x00,// Invalid
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 24 = 0x18
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x00,// Invalid
							0x30,// VkHWIb_5
								0x6D,// YMM0
								0x6D,// YMM0
								0x4D,// XMM0
								0xD6, 0x1D,// EVEX_Vinsertf32x4_ymm_k1z_ymm_xmmm128_imm8
								0x12,// Tuple4
							0x30,// VkHWIb_5
								0x8D,// ZMM0
								0x8D,// ZMM0
								0x4D,// XMM0
								0xD7, 0x1D,// EVEX_Vinsertf32x4_zmm_k1z_zmm_xmmm128_imm8
								0x12,// Tuple4
						0x09,// VectorLength
							0x00,// Invalid
							0x30,// VkHWIb_5
								0x6D,// YMM0
								0x6D,// YMM0
								0x4D,// XMM0
								0xD8, 0x1D,// EVEX_Vinsertf64x2_ymm_k1z_ymm_xmmm128_imm8
								0x11,// Tuple2
							0x30,// VkHWIb_5
								0x8D,// ZMM0
								0x8D,// ZMM0
								0x4D,// XMM0
								0xD9, 0x1D,// EVEX_Vinsertf64x2_zmm_k1z_zmm_xmmm128_imm8
								0x11,// Tuple2
					0x00,// Invalid
					0x00,// Invalid

				// 25 = 0x19
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x00,// Invalid
							0x48,// WkVIb
								0x4D,// XMM0
								0x6D,// YMM0
								0xDB, 0x1D,// EVEX_Vextractf32x4_xmmm128_k1z_ymm_imm8
								0x12,// Tuple4
							0x48,// WkVIb
								0x4D,// XMM0
								0x8D,// ZMM0
								0xDC, 0x1D,// EVEX_Vextractf32x4_xmmm128_k1z_zmm_imm8
								0x12,// Tuple4
						0x09,// VectorLength
							0x00,// Invalid
							0x48,// WkVIb
								0x4D,// XMM0
								0x6D,// YMM0
								0xDD, 0x1D,// EVEX_Vextractf64x2_xmmm128_k1z_ymm_imm8
								0x11,// Tuple2
							0x48,// WkVIb
								0x4D,// XMM0
								0x8D,// ZMM0
								0xDE, 0x1D,// EVEX_Vextractf64x2_xmmm128_k1z_zmm_imm8
								0x11,// Tuple2
					0x00,// Invalid
					0x00,// Invalid

				// 26 = 0x1A
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x00,// Invalid
							0x00,// Invalid
							0x30,// VkHWIb_5
								0x8D,// ZMM0
								0x8D,// ZMM0
								0x6D,// YMM0
								0xDF, 0x1D,// EVEX_Vinsertf32x8_zmm_k1z_zmm_ymmm256_imm8
								0x13,// Tuple8
						0x09,// VectorLength
							0x00,// Invalid
							0x00,// Invalid
							0x30,// VkHWIb_5
								0x8D,// ZMM0
								0x8D,// ZMM0
								0x6D,// YMM0
								0xE0, 0x1D,// EVEX_Vinsertf64x4_zmm_k1z_zmm_ymmm256_imm8
								0x12,// Tuple4
					0x00,// Invalid
					0x00,// Invalid

				// 27 = 0x1B
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x00,// Invalid
							0x00,// Invalid
							0x48,// WkVIb
								0x6D,// YMM0
								0x8D,// ZMM0
								0xE1, 0x1D,// EVEX_Vextractf32x8_ymmm256_k1z_zmm_imm8
								0x13,// Tuple8
						0x09,// VectorLength
							0x00,// Invalid
							0x00,// Invalid
							0x48,// WkVIb
								0x6D,// YMM0
								0x8D,// ZMM0
								0xE2, 0x1D,// EVEX_Vextractf64x4_ymmm256_k1z_zmm_imm8
								0x12,// Tuple4
					0x00,// Invalid
					0x00,// Invalid

				// 28 = 0x1C
				0x00,// Invalid

				// 29 = 0x1D
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x0A,// VectorLength_er
							0x49,// WkVIb_er
								0x4D,// XMM0
								0x4D,// XMM0
								0xE5, 0x1D,// EVEX_Vcvtps2ph_xmmm64_k1z_xmm_imm8
								0x15,// Half_Mem_128
							0x49,// WkVIb_er
								0x4D,// XMM0
								0x6D,// YMM0
								0xE6, 0x1D,// EVEX_Vcvtps2ph_xmmm128_k1z_ymm_imm8
								0x16,// Half_Mem_256
							0x49,// WkVIb_er
								0x6D,// YMM0
								0x8D,// ZMM0
								0xE7, 0x1D,// EVEX_Vcvtps2ph_ymmm256_k1z_zmm_imm8_sae
								0x17,// Half_Mem_512
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 30 = 0x1E
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x18,// KkHWIb_3b
								0x4D,// XMM0
								0xE8, 0x1D,// EVEX_Vpcmpud_k_k1_xmm_xmmm128b32_imm8
								0x01,// Full_128
							0x18,// KkHWIb_3b
								0x6D,// YMM0
								0xE9, 0x1D,// EVEX_Vpcmpud_k_k1_ymm_ymmm256b32_imm8
								0x02,// Full_256
							0x18,// KkHWIb_3b
								0x8D,// ZMM0
								0xEA, 0x1D,// EVEX_Vpcmpud_k_k1_zmm_zmmm512b32_imm8
								0x03,// Full_512
						0x09,// VectorLength
							0x18,// KkHWIb_3b
								0x4D,// XMM0
								0xEB, 0x1D,// EVEX_Vpcmpuq_k_k1_xmm_xmmm128b64_imm8
								0x01,// Full_128
							0x18,// KkHWIb_3b
								0x6D,// YMM0
								0xEC, 0x1D,// EVEX_Vpcmpuq_k_k1_ymm_ymmm256b64_imm8
								0x02,// Full_256
							0x18,// KkHWIb_3b
								0x8D,// ZMM0
								0xED, 0x1D,// EVEX_Vpcmpuq_k_k1_zmm_zmmm512b64_imm8
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 31 = 0x1F
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x18,// KkHWIb_3b
								0x4D,// XMM0
								0xEE, 0x1D,// EVEX_Vpcmpd_k_k1_xmm_xmmm128b32_imm8
								0x01,// Full_128
							0x18,// KkHWIb_3b
								0x6D,// YMM0
								0xEF, 0x1D,// EVEX_Vpcmpd_k_k1_ymm_ymmm256b32_imm8
								0x02,// Full_256
							0x18,// KkHWIb_3b
								0x8D,// ZMM0
								0xF0, 0x1D,// EVEX_Vpcmpd_k_k1_zmm_zmmm512b32_imm8
								0x03,// Full_512
						0x09,// VectorLength
							0x18,// KkHWIb_3b
								0x4D,// XMM0
								0xF1, 0x1D,// EVEX_Vpcmpq_k_k1_xmm_xmmm128b64_imm8
								0x01,// Full_128
							0x18,// KkHWIb_3b
								0x6D,// YMM0
								0xF2, 0x1D,// EVEX_Vpcmpq_k_k1_ymm_ymmm256b64_imm8
								0x02,// Full_256
							0x18,// KkHWIb_3b
								0x8D,// ZMM0
								0xF3, 0x1D,// EVEX_Vpcmpq_k_k1_zmm_zmmm512b64_imm8
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 32 = 0x20
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x1F,// V_H_Ev_Ib
							0x4D,// XMM0
							0xF8, 0x1D,// EVEX_Vpinsrb_xmm_xmm_r32m8_imm8
							0x0B,// Tuple1_Scalar_1
							0x0B,// Tuple1_Scalar_1
						0x00,// Invalid
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 33 = 0x21
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x23,// VHWIb
								0x4D,// XMM0
								0xFC, 0x1D,// EVEX_Vinsertps_xmm_xmm_xmmm32_imm8
								0x0A,// Tuple1_Scalar
							0x00,// Invalid
							0x00,// Invalid
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 34 = 0x22
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x1F,// V_H_Ev_Ib
							0x4D,// XMM0
							0x81, 0x1E,// EVEX_Vpinsrd_xmm_xmm_rm32_imm8
							0x0D,// Tuple1_Scalar_4
							0x0E,// Tuple1_Scalar_8
						0x00,// Invalid
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 35 = 0x23
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x00,// Invalid
							0x2F,// VkHWIb_3b
								0x6D,// YMM0
								0x83, 0x1E,// EVEX_Vshuff32x4_ymm_k1z_ymm_ymmm256b32_imm8
								0x02,// Full_256
							0x2F,// VkHWIb_3b
								0x8D,// ZMM0
								0x84, 0x1E,// EVEX_Vshuff32x4_zmm_k1z_zmm_zmmm512b32_imm8
								0x03,// Full_512
						0x09,// VectorLength
							0x00,// Invalid
							0x2F,// VkHWIb_3b
								0x6D,// YMM0
								0x85, 0x1E,// EVEX_Vshuff64x2_ymm_k1z_ymm_ymmm256b64_imm8
								0x02,// Full_256
							0x2F,// VkHWIb_3b
								0x8D,// ZMM0
								0x86, 0x1E,// EVEX_Vshuff64x2_zmm_k1z_zmm_zmmm512b64_imm8
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 36 = 0x24
				0x00,// Invalid

				// 37 = 0x25
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2F,// VkHWIb_3b
								0x4D,// XMM0
								0x87, 0x1E,// EVEX_Vpternlogd_xmm_k1z_xmm_xmmm128b32_imm8
								0x01,// Full_128
							0x2F,// VkHWIb_3b
								0x6D,// YMM0
								0x88, 0x1E,// EVEX_Vpternlogd_ymm_k1z_ymm_ymmm256b32_imm8
								0x02,// Full_256
							0x2F,// VkHWIb_3b
								0x8D,// ZMM0
								0x89, 0x1E,// EVEX_Vpternlogd_zmm_k1z_zmm_zmmm512b32_imm8
								0x03,// Full_512
						0x09,// VectorLength
							0x2F,// VkHWIb_3b
								0x4D,// XMM0
								0x8A, 0x1E,// EVEX_Vpternlogq_xmm_k1z_xmm_xmmm128b64_imm8
								0x01,// Full_128
							0x2F,// VkHWIb_3b
								0x6D,// YMM0
								0x8B, 0x1E,// EVEX_Vpternlogq_ymm_k1z_ymm_ymmm256b64_imm8
								0x02,// Full_256
							0x2F,// VkHWIb_3b
								0x8D,// ZMM0
								0x8C, 0x1E,// EVEX_Vpternlogq_zmm_k1z_zmm_zmmm512b64_imm8
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 38 = 0x26
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x0A,// VectorLength_er
							0x3D,// VkWIb_er
								0x4D,// XMM0
								0x8D, 0x1E,// EVEX_Vgetmantps_xmm_k1z_xmmm128b32_imm8
								0x01,// Full_128
							0x3D,// VkWIb_er
								0x6D,// YMM0
								0x8E, 0x1E,// EVEX_Vgetmantps_ymm_k1z_ymmm256b32_imm8
								0x02,// Full_256
							0x3D,// VkWIb_er
								0x8D,// ZMM0
								0x8F, 0x1E,// EVEX_Vgetmantps_zmm_k1z_zmmm512b32_imm8_sae
								0x03,// Full_512
						0x0A,// VectorLength_er
							0x3D,// VkWIb_er
								0x4D,// XMM0
								0x90, 0x1E,// EVEX_Vgetmantpd_xmm_k1z_xmmm128b64_imm8
								0x01,// Full_128
							0x3D,// VkWIb_er
								0x6D,// YMM0
								0x91, 0x1E,// EVEX_Vgetmantpd_ymm_k1z_ymmm256b64_imm8
								0x02,// Full_256
							0x3D,// VkWIb_er
								0x8D,// ZMM0
								0x92, 0x1E,// EVEX_Vgetmantpd_zmm_k1z_zmmm512b64_imm8_sae
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 39 = 0x27
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x31,// VkHWIb_er_4
							0x4D,// XMM0
							0x93, 0x1E,// EVEX_Vgetmantss_xmm_k1z_xmm_xmmm32_imm8_sae
							0x0A,// Tuple1_Scalar
						0x31,// VkHWIb_er_4
							0x4D,// XMM0
							0x94, 0x1E,// EVEX_Vgetmantsd_xmm_k1z_xmm_xmmm64_imm8_sae
							0x0A,// Tuple1_Scalar
					0x00,// Invalid
					0x00,// Invalid

				// 40 = 0x28
				0x02,// Dup
					0x10,// 16
					0x00,// Invalid

				// 56 = 0x38
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x00,// Invalid
							0x30,// VkHWIb_5
								0x6D,// YMM0
								0x6D,// YMM0
								0x4D,// XMM0
								0x9E, 0x1E,// EVEX_Vinserti32x4_ymm_k1z_ymm_xmmm128_imm8
								0x12,// Tuple4
							0x30,// VkHWIb_5
								0x8D,// ZMM0
								0x8D,// ZMM0
								0x4D,// XMM0
								0x9F, 0x1E,// EVEX_Vinserti32x4_zmm_k1z_zmm_xmmm128_imm8
								0x12,// Tuple4
						0x09,// VectorLength
							0x00,// Invalid
							0x30,// VkHWIb_5
								0x6D,// YMM0
								0x6D,// YMM0
								0x4D,// XMM0
								0xA0, 0x1E,// EVEX_Vinserti64x2_ymm_k1z_ymm_xmmm128_imm8
								0x11,// Tuple2
							0x30,// VkHWIb_5
								0x8D,// ZMM0
								0x8D,// ZMM0
								0x4D,// XMM0
								0xA1, 0x1E,// EVEX_Vinserti64x2_zmm_k1z_zmm_xmmm128_imm8
								0x11,// Tuple2
					0x00,// Invalid
					0x00,// Invalid

				// 57 = 0x39
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x00,// Invalid
							0x48,// WkVIb
								0x4D,// XMM0
								0x6D,// YMM0
								0xA3, 0x1E,// EVEX_Vextracti32x4_xmmm128_k1z_ymm_imm8
								0x12,// Tuple4
							0x48,// WkVIb
								0x4D,// XMM0
								0x8D,// ZMM0
								0xA4, 0x1E,// EVEX_Vextracti32x4_xmmm128_k1z_zmm_imm8
								0x12,// Tuple4
						0x09,// VectorLength
							0x00,// Invalid
							0x48,// WkVIb
								0x4D,// XMM0
								0x6D,// YMM0
								0xA5, 0x1E,// EVEX_Vextracti64x2_xmmm128_k1z_ymm_imm8
								0x11,// Tuple2
							0x48,// WkVIb
								0x4D,// XMM0
								0x8D,// ZMM0
								0xA6, 0x1E,// EVEX_Vextracti64x2_xmmm128_k1z_zmm_imm8
								0x11,// Tuple2
					0x00,// Invalid
					0x00,// Invalid

				// 58 = 0x3A
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x00,// Invalid
							0x00,// Invalid
							0x30,// VkHWIb_5
								0x8D,// ZMM0
								0x8D,// ZMM0
								0x6D,// YMM0
								0xA7, 0x1E,// EVEX_Vinserti32x8_zmm_k1z_zmm_ymmm256_imm8
								0x13,// Tuple8
						0x09,// VectorLength
							0x00,// Invalid
							0x00,// Invalid
							0x30,// VkHWIb_5
								0x8D,// ZMM0
								0x8D,// ZMM0
								0x6D,// YMM0
								0xA8, 0x1E,// EVEX_Vinserti64x4_zmm_k1z_zmm_ymmm256_imm8
								0x12,// Tuple4
					0x00,// Invalid
					0x00,// Invalid

				// 59 = 0x3B
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x00,// Invalid
							0x00,// Invalid
							0x48,// WkVIb
								0x6D,// YMM0
								0x8D,// ZMM0
								0xA9, 0x1E,// EVEX_Vextracti32x8_ymmm256_k1z_zmm_imm8
								0x13,// Tuple8
						0x09,// VectorLength
							0x00,// Invalid
							0x00,// Invalid
							0x48,// WkVIb
								0x6D,// YMM0
								0x8D,// ZMM0
								0xAA, 0x1E,// EVEX_Vextracti64x4_ymmm256_k1z_zmm_imm8
								0x12,// Tuple4
					0x00,// Invalid
					0x00,// Invalid

				// 60 = 0x3C
				0x01,// Invalid2

				// 62 = 0x3E
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x17,// KkHWIb_3
								0x4D,// XMM0
								0xAB, 0x1E,// EVEX_Vpcmpub_k_k1_xmm_xmmm128_imm8
								0x07,// Full_Mem_128
							0x17,// KkHWIb_3
								0x6D,// YMM0
								0xAC, 0x1E,// EVEX_Vpcmpub_k_k1_ymm_ymmm256_imm8
								0x08,// Full_Mem_256
							0x17,// KkHWIb_3
								0x8D,// ZMM0
								0xAD, 0x1E,// EVEX_Vpcmpub_k_k1_zmm_zmmm512_imm8
								0x09,// Full_Mem_512
						0x09,// VectorLength
							0x17,// KkHWIb_3
								0x4D,// XMM0
								0xAE, 0x1E,// EVEX_Vpcmpuw_k_k1_xmm_xmmm128_imm8
								0x07,// Full_Mem_128
							0x17,// KkHWIb_3
								0x6D,// YMM0
								0xAF, 0x1E,// EVEX_Vpcmpuw_k_k1_ymm_ymmm256_imm8
								0x08,// Full_Mem_256
							0x17,// KkHWIb_3
								0x8D,// ZMM0
								0xB0, 0x1E,// EVEX_Vpcmpuw_k_k1_zmm_zmmm512_imm8
								0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 63 = 0x3F
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x17,// KkHWIb_3
								0x4D,// XMM0
								0xB1, 0x1E,// EVEX_Vpcmpb_k_k1_xmm_xmmm128_imm8
								0x07,// Full_Mem_128
							0x17,// KkHWIb_3
								0x6D,// YMM0
								0xB2, 0x1E,// EVEX_Vpcmpb_k_k1_ymm_ymmm256_imm8
								0x08,// Full_Mem_256
							0x17,// KkHWIb_3
								0x8D,// ZMM0
								0xB3, 0x1E,// EVEX_Vpcmpb_k_k1_zmm_zmmm512_imm8
								0x09,// Full_Mem_512
						0x09,// VectorLength
							0x17,// KkHWIb_3
								0x4D,// XMM0
								0xB4, 0x1E,// EVEX_Vpcmpw_k_k1_xmm_xmmm128_imm8
								0x07,// Full_Mem_128
							0x17,// KkHWIb_3
								0x6D,// YMM0
								0xB5, 0x1E,// EVEX_Vpcmpw_k_k1_ymm_ymmm256_imm8
								0x08,// Full_Mem_256
							0x17,// KkHWIb_3
								0x8D,// ZMM0
								0xB6, 0x1E,// EVEX_Vpcmpw_k_k1_zmm_zmmm512_imm8
								0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 64 = 0x40
				0x01,// Invalid2

				// 66 = 0x42
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2E,// VkHWIb_3
								0x4D,// XMM0
								0xBF, 0x1E,// EVEX_Vdbpsadbw_xmm_k1z_xmm_xmmm128_imm8
								0x07,// Full_Mem_128
							0x2E,// VkHWIb_3
								0x6D,// YMM0
								0xC0, 0x1E,// EVEX_Vdbpsadbw_ymm_k1z_ymm_ymmm256_imm8
								0x08,// Full_Mem_256
							0x2E,// VkHWIb_3
								0x8D,// ZMM0
								0xC1, 0x1E,// EVEX_Vdbpsadbw_zmm_k1z_zmm_zmmm512_imm8
								0x09,// Full_Mem_512
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 67 = 0x43
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x00,// Invalid
							0x2F,// VkHWIb_3b
								0x6D,// YMM0
								0xC2, 0x1E,// EVEX_Vshufi32x4_ymm_k1z_ymm_ymmm256b32_imm8
								0x02,// Full_256
							0x2F,// VkHWIb_3b
								0x8D,// ZMM0
								0xC3, 0x1E,// EVEX_Vshufi32x4_zmm_k1z_zmm_zmmm512b32_imm8
								0x03,// Full_512
						0x09,// VectorLength
							0x00,// Invalid
							0x2F,// VkHWIb_3b
								0x6D,// YMM0
								0xC4, 0x1E,// EVEX_Vshufi64x2_ymm_k1z_ymm_ymmm256b64_imm8
								0x02,// Full_256
							0x2F,// VkHWIb_3b
								0x8D,// ZMM0
								0xC5, 0x1E,// EVEX_Vshufi64x2_zmm_k1z_zmm_zmmm512b64_imm8
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 68 = 0x44
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x23,// VHWIb
							0x4D,// XMM0
							0xC9, 0x1E,// EVEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8
							0x07,// Full_Mem_128
						0x23,// VHWIb
							0x6D,// YMM0
							0xCA, 0x1E,// EVEX_Vpclmulqdq_ymm_ymm_ymmm256_imm8
							0x08,// Full_Mem_256
						0x23,// VHWIb
							0x8D,// ZMM0
							0xCB, 0x1E,// EVEX_Vpclmulqdq_zmm_zmm_zmmm512_imm8
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 69 = 0x45
				0x02,// Dup
					0x0B,// 11
					0x00,// Invalid

				// 80 = 0x50
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x0A,// VectorLength_er
							0x32,// VkHWIb_er_4b
								0x4D,// XMM0
								0xDB, 0x1E,// EVEX_Vrangeps_xmm_k1z_xmm_xmmm128b32_imm8
								0x01,// Full_128
							0x32,// VkHWIb_er_4b
								0x6D,// YMM0
								0xDC, 0x1E,// EVEX_Vrangeps_ymm_k1z_ymm_ymmm256b32_imm8
								0x02,// Full_256
							0x32,// VkHWIb_er_4b
								0x8D,// ZMM0
								0xDD, 0x1E,// EVEX_Vrangeps_zmm_k1z_zmm_zmmm512b32_imm8_sae
								0x03,// Full_512
						0x0A,// VectorLength_er
							0x32,// VkHWIb_er_4b
								0x4D,// XMM0
								0xDE, 0x1E,// EVEX_Vrangepd_xmm_k1z_xmm_xmmm128b64_imm8
								0x01,// Full_128
							0x32,// VkHWIb_er_4b
								0x6D,// YMM0
								0xDF, 0x1E,// EVEX_Vrangepd_ymm_k1z_ymm_ymmm256b64_imm8
								0x02,// Full_256
							0x32,// VkHWIb_er_4b
								0x8D,// ZMM0
								0xE0, 0x1E,// EVEX_Vrangepd_zmm_k1z_zmm_zmmm512b64_imm8_sae
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 81 = 0x51
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x31,// VkHWIb_er_4
							0x4D,// XMM0
							0xE1, 0x1E,// EVEX_Vrangess_xmm_k1z_xmm_xmmm32_imm8_sae
							0x0A,// Tuple1_Scalar
						0x31,// VkHWIb_er_4
							0x4D,// XMM0
							0xE2, 0x1E,// EVEX_Vrangesd_xmm_k1z_xmm_xmmm64_imm8_sae
							0x0A,// Tuple1_Scalar
					0x00,// Invalid
					0x00,// Invalid

				// 82 = 0x52
				0x01,// Invalid2

				// 84 = 0x54
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x0A,// VectorLength_er
							0x32,// VkHWIb_er_4b
								0x4D,// XMM0
								0xE3, 0x1E,// EVEX_Vfixupimmps_xmm_k1z_xmm_xmmm128b32_imm8
								0x01,// Full_128
							0x32,// VkHWIb_er_4b
								0x6D,// YMM0
								0xE4, 0x1E,// EVEX_Vfixupimmps_ymm_k1z_ymm_ymmm256b32_imm8
								0x02,// Full_256
							0x32,// VkHWIb_er_4b
								0x8D,// ZMM0
								0xE5, 0x1E,// EVEX_Vfixupimmps_zmm_k1z_zmm_zmmm512b32_imm8_sae
								0x03,// Full_512
						0x0A,// VectorLength_er
							0x32,// VkHWIb_er_4b
								0x4D,// XMM0
								0xE6, 0x1E,// EVEX_Vfixupimmpd_xmm_k1z_xmm_xmmm128b64_imm8
								0x01,// Full_128
							0x32,// VkHWIb_er_4b
								0x6D,// YMM0
								0xE7, 0x1E,// EVEX_Vfixupimmpd_ymm_k1z_ymm_ymmm256b64_imm8
								0x02,// Full_256
							0x32,// VkHWIb_er_4b
								0x8D,// ZMM0
								0xE8, 0x1E,// EVEX_Vfixupimmpd_zmm_k1z_zmm_zmmm512b64_imm8_sae
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 85 = 0x55
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x31,// VkHWIb_er_4
							0x4D,// XMM0
							0xE9, 0x1E,// EVEX_Vfixupimmss_xmm_k1z_xmm_xmmm32_imm8_sae
							0x0A,// Tuple1_Scalar
						0x31,// VkHWIb_er_4
							0x4D,// XMM0
							0xEA, 0x1E,// EVEX_Vfixupimmsd_xmm_k1z_xmm_xmmm64_imm8_sae
							0x0A,// Tuple1_Scalar
					0x00,// Invalid
					0x00,// Invalid

				// 86 = 0x56
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x0A,// VectorLength_er
							0x3D,// VkWIb_er
								0x4D,// XMM0
								0xEB, 0x1E,// EVEX_Vreduceps_xmm_k1z_xmmm128b32_imm8
								0x01,// Full_128
							0x3D,// VkWIb_er
								0x6D,// YMM0
								0xEC, 0x1E,// EVEX_Vreduceps_ymm_k1z_ymmm256b32_imm8
								0x02,// Full_256
							0x3D,// VkWIb_er
								0x8D,// ZMM0
								0xED, 0x1E,// EVEX_Vreduceps_zmm_k1z_zmmm512b32_imm8_sae
								0x03,// Full_512
						0x0A,// VectorLength_er
							0x3D,// VkWIb_er
								0x4D,// XMM0
								0xEE, 0x1E,// EVEX_Vreducepd_xmm_k1z_xmmm128b64_imm8
								0x01,// Full_128
							0x3D,// VkWIb_er
								0x6D,// YMM0
								0xEF, 0x1E,// EVEX_Vreducepd_ymm_k1z_ymmm256b64_imm8
								0x02,// Full_256
							0x3D,// VkWIb_er
								0x8D,// ZMM0
								0xF0, 0x1E,// EVEX_Vreducepd_zmm_k1z_zmmm512b64_imm8_sae
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 87 = 0x57
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x31,// VkHWIb_er_4
							0x4D,// XMM0
							0xF1, 0x1E,// EVEX_Vreducess_xmm_k1z_xmm_xmmm32_imm8_sae
							0x0A,// Tuple1_Scalar
						0x31,// VkHWIb_er_4
							0x4D,// XMM0
							0xF2, 0x1E,// EVEX_Vreducesd_xmm_k1z_xmm_xmmm64_imm8_sae
							0x0A,// Tuple1_Scalar
					0x00,// Invalid
					0x00,// Invalid

				// 88 = 0x58
				0x02,// Dup
					0x0E,// 14
					0x00,// Invalid

				// 102 = 0x66
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x1A,// KkWIb_3b
								0x4D,// XMM0
								0x8F, 0x1F,// EVEX_Vfpclassps_k_k1_xmmm128b32_imm8
								0x01,// Full_128
							0x1A,// KkWIb_3b
								0x6D,// YMM0
								0x90, 0x1F,// EVEX_Vfpclassps_k_k1_ymmm256b32_imm8
								0x02,// Full_256
							0x1A,// KkWIb_3b
								0x8D,// ZMM0
								0x91, 0x1F,// EVEX_Vfpclassps_k_k1_zmmm512b32_imm8
								0x03,// Full_512
						0x09,// VectorLength
							0x1A,// KkWIb_3b
								0x4D,// XMM0
								0x92, 0x1F,// EVEX_Vfpclasspd_k_k1_xmmm128b64_imm8
								0x01,// Full_128
							0x1A,// KkWIb_3b
								0x6D,// YMM0
								0x93, 0x1F,// EVEX_Vfpclasspd_k_k1_ymmm256b64_imm8
								0x02,// Full_256
							0x1A,// KkWIb_3b
								0x8D,// ZMM0
								0x94, 0x1F,// EVEX_Vfpclasspd_k_k1_zmmm512b64_imm8
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 103 = 0x67
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x19,// KkWIb_3
							0x4D,// XMM0
							0x95, 0x1F,// EVEX_Vfpclassss_k_k1_xmmm32_imm8
							0x0A,// Tuple1_Scalar
						0x19,// KkWIb_3
							0x4D,// XMM0
							0x96, 0x1F,// EVEX_Vfpclasssd_k_k1_xmmm64_imm8
							0x0A,// Tuple1_Scalar
					0x00,// Invalid
					0x00,// Invalid

				// 104 = 0x68
				0x02,// Dup
					0x08,// 8
					0x00,// Invalid

				// 112 = 0x70
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x2E,// VkHWIb_3
								0x4D,// XMM0
								0xAF, 0x1F,// EVEX_Vpshldw_xmm_k1z_xmm_xmmm128_imm8
								0x07,// Full_Mem_128
							0x2E,// VkHWIb_3
								0x6D,// YMM0
								0xB0, 0x1F,// EVEX_Vpshldw_ymm_k1z_ymm_ymmm256_imm8
								0x08,// Full_Mem_256
							0x2E,// VkHWIb_3
								0x8D,// ZMM0
								0xB1, 0x1F,// EVEX_Vpshldw_zmm_k1z_zmm_zmmm512_imm8
								0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 113 = 0x71
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2F,// VkHWIb_3b
								0x4D,// XMM0
								0xB2, 0x1F,// EVEX_Vpshldd_xmm_k1z_xmm_xmmm128b32_imm8
								0x01,// Full_128
							0x2F,// VkHWIb_3b
								0x6D,// YMM0
								0xB3, 0x1F,// EVEX_Vpshldd_ymm_k1z_ymm_ymmm256b32_imm8
								0x02,// Full_256
							0x2F,// VkHWIb_3b
								0x8D,// ZMM0
								0xB4, 0x1F,// EVEX_Vpshldd_zmm_k1z_zmm_zmmm512b32_imm8
								0x03,// Full_512
						0x09,// VectorLength
							0x2F,// VkHWIb_3b
								0x4D,// XMM0
								0xB5, 0x1F,// EVEX_Vpshldq_xmm_k1z_xmm_xmmm128b64_imm8
								0x01,// Full_128
							0x2F,// VkHWIb_3b
								0x6D,// YMM0
								0xB6, 0x1F,// EVEX_Vpshldq_ymm_k1z_ymm_ymmm256b64_imm8
								0x02,// Full_256
							0x2F,// VkHWIb_3b
								0x8D,// ZMM0
								0xB7, 0x1F,// EVEX_Vpshldq_zmm_k1z_zmm_zmmm512b64_imm8
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 114 = 0x72
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x2E,// VkHWIb_3
								0x4D,// XMM0
								0xB8, 0x1F,// EVEX_Vpshrdw_xmm_k1z_xmm_xmmm128_imm8
								0x07,// Full_Mem_128
							0x2E,// VkHWIb_3
								0x6D,// YMM0
								0xB9, 0x1F,// EVEX_Vpshrdw_ymm_k1z_ymm_ymmm256_imm8
								0x08,// Full_Mem_256
							0x2E,// VkHWIb_3
								0x8D,// ZMM0
								0xBA, 0x1F,// EVEX_Vpshrdw_zmm_k1z_zmm_zmmm512_imm8
								0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 115 = 0x73
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2F,// VkHWIb_3b
								0x4D,// XMM0
								0xBB, 0x1F,// EVEX_Vpshrdd_xmm_k1z_xmm_xmmm128b32_imm8
								0x01,// Full_128
							0x2F,// VkHWIb_3b
								0x6D,// YMM0
								0xBC, 0x1F,// EVEX_Vpshrdd_ymm_k1z_ymm_ymmm256b32_imm8
								0x02,// Full_256
							0x2F,// VkHWIb_3b
								0x8D,// ZMM0
								0xBD, 0x1F,// EVEX_Vpshrdd_zmm_k1z_zmm_zmmm512b32_imm8
								0x03,// Full_512
						0x09,// VectorLength
							0x2F,// VkHWIb_3b
								0x4D,// XMM0
								0xBE, 0x1F,// EVEX_Vpshrdq_xmm_k1z_xmm_xmmm128b64_imm8
								0x01,// Full_128
							0x2F,// VkHWIb_3b
								0x6D,// YMM0
								0xBF, 0x1F,// EVEX_Vpshrdq_ymm_k1z_ymm_ymmm256b64_imm8
								0x02,// Full_256
							0x2F,// VkHWIb_3b
								0x8D,// ZMM0
								0xC0, 0x1F,// EVEX_Vpshrdq_zmm_k1z_zmm_zmmm512b64_imm8
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 116 = 0x74
				0x02,// Dup
					0x5A,// 90
					0x00,// Invalid

				// 206 = 0xCE
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x2F,// VkHWIb_3b
								0x4D,// XMM0
								0xDD, 0x1F,// EVEX_Vgf2p8affineqb_xmm_k1z_xmm_xmmm128b64_imm8
								0x01,// Full_128
							0x2F,// VkHWIb_3b
								0x6D,// YMM0
								0xDE, 0x1F,// EVEX_Vgf2p8affineqb_ymm_k1z_ymm_ymmm256b64_imm8
								0x02,// Full_256
							0x2F,// VkHWIb_3b
								0x8D,// ZMM0
								0xDF, 0x1F,// EVEX_Vgf2p8affineqb_zmm_k1z_zmm_zmmm512b64_imm8
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 207 = 0xCF
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x2F,// VkHWIb_3b
								0x4D,// XMM0
								0xE3, 0x1F,// EVEX_Vgf2p8affineinvqb_xmm_k1z_xmm_xmmm128b64_imm8
								0x01,// Full_128
							0x2F,// VkHWIb_3b
								0x6D,// YMM0
								0xE4, 0x1F,// EVEX_Vgf2p8affineinvqb_ymm_k1z_ymm_ymmm256b64_imm8
								0x02,// Full_256
							0x2F,// VkHWIb_3b
								0x8D,// ZMM0
								0xE5, 0x1F,// EVEX_Vgf2p8affineinvqb_zmm_k1z_zmm_zmmm512b64_imm8
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 208 = 0xD0
				0x02,// Dup
					0x30,// 48
					0x00,// Invalid

				// TwoByteHandlers_0FXX
				0x01,// ArrayReference
				0x80, 0x02,// 0x100
				// 0 = 0x00
				0x02,// Dup
					0x10,// 16
					0x00,// Invalid

				// 16 = 0x10
				0x08,// MandatoryPrefix2
					0x07,// W
						0x09,// VectorLength
							0x34,// VkW_3
								0x4D,// XMM0
								0x80, 0x07,// EVEX_Vmovups_xmm_k1z_xmmm128
								0x07,// Full_Mem_128
							0x34,// VkW_3
								0x6D,// YMM0
								0x81, 0x07,// EVEX_Vmovups_ymm_k1z_ymmm256
								0x08,// Full_Mem_256
							0x34,// VkW_3
								0x8D,// ZMM0
								0x82, 0x07,// EVEX_Vmovups_zmm_k1z_zmmm512
								0x09,// Full_Mem_512
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x34,// VkW_3
								0x4D,// XMM0
								0x86, 0x07,// EVEX_Vmovupd_xmm_k1z_xmmm128
								0x07,// Full_Mem_128
							0x34,// VkW_3
								0x6D,// YMM0
								0x87, 0x07,// EVEX_Vmovupd_ymm_k1z_ymmm256
								0x08,// Full_Mem_256
							0x34,// VkW_3
								0x8D,// ZMM0
								0x88, 0x07,// EVEX_Vmovupd_zmm_k1z_zmmm512
								0x09,// Full_Mem_512
					0x07,// W
						0x05,// RM
							0x29,// VkHW_3
								0x4D,// XMM0
								0x8C, 0x07,// EVEX_Vmovss_xmm_k1z_xmm_xmm
								0x0A,// Tuple1_Scalar
							0x34,// VkW_3
								0x4D,// XMM0
								0x8D, 0x07,// EVEX_Vmovss_xmm_k1z_m32
								0x0A,// Tuple1_Scalar
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x05,// RM
							0x29,// VkHW_3
								0x4D,// XMM0
								0x91, 0x07,// EVEX_Vmovsd_xmm_k1z_xmm_xmm
								0x0A,// Tuple1_Scalar
							0x34,// VkW_3
								0x4D,// XMM0
								0x92, 0x07,// EVEX_Vmovsd_xmm_k1z_m64
								0x0A,// Tuple1_Scalar

				// 17 = 0x11
				0x08,// MandatoryPrefix2
					0x07,// W
						0x09,// VectorLength
							0x45,// WkV_3
								0x4D,// XMM0
								0x96, 0x07,// EVEX_Vmovups_xmmm128_k1z_xmm
								0x07,// Full_Mem_128
							0x45,// WkV_3
								0x6D,// YMM0
								0x97, 0x07,// EVEX_Vmovups_ymmm256_k1z_ymm
								0x08,// Full_Mem_256
							0x45,// WkV_3
								0x8D,// ZMM0
								0x98, 0x07,// EVEX_Vmovups_zmmm512_k1z_zmm
								0x09,// Full_Mem_512
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x45,// WkV_3
								0x4D,// XMM0
								0x9C, 0x07,// EVEX_Vmovupd_xmmm128_k1z_xmm
								0x07,// Full_Mem_128
							0x45,// WkV_3
								0x6D,// YMM0
								0x9D, 0x07,// EVEX_Vmovupd_ymmm256_k1z_ymm
								0x08,// Full_Mem_256
							0x45,// WkV_3
								0x8D,// ZMM0
								0x9E, 0x07,// EVEX_Vmovupd_zmmm512_k1z_zmm
								0x09,// Full_Mem_512
					0x07,// W
						0x05,// RM
							0x44,// WkHV
								0x4D,// XMM0
								0xA2, 0x07,// EVEX_Vmovss_xmm_k1z_xmm_xmm_0F11
								0x0A,// Tuple1_Scalar
							0x47,// WkV_4b
								0x4D,// XMM0
								0xA3, 0x07,// EVEX_Vmovss_m32_k1_xmm
								0x0A,// Tuple1_Scalar
								0x00,// false
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x05,// RM
							0x44,// WkHV
								0x4D,// XMM0
								0xA7, 0x07,// EVEX_Vmovsd_xmm_k1z_xmm_xmm_0F11
								0x0A,// Tuple1_Scalar
							0x47,// WkV_4b
								0x4D,// XMM0
								0xA8, 0x07,// EVEX_Vmovsd_m64_k1_xmm
								0x0A,// Tuple1_Scalar
								0x00,// false

				// 18 = 0x12
				0x08,// MandatoryPrefix2
					0x07,// W
						0x09,// VectorLength
							0x22,// VHW_4
								0x4D,// XMM0
								0xAD, 0x07,// EVEX_Vmovhlps_xmm_xmm_xmm
								0xAE, 0x07,// EVEX_Vmovlps_xmm_xmm_m64
								0x11,// Tuple2
							0x00,// Invalid
							0x00,// Invalid
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x20,// VHM
								0x4D,// XMM0
								0xB1, 0x07,// EVEX_Vmovlpd_xmm_xmm_m64
								0x0A,// Tuple1_Scalar
							0x00,// Invalid
							0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x34,// VkW_3
								0x4D,// XMM0
								0xB5, 0x07,// EVEX_Vmovsldup_xmm_k1z_xmmm128
								0x07,// Full_Mem_128
							0x34,// VkW_3
								0x6D,// YMM0
								0xB6, 0x07,// EVEX_Vmovsldup_ymm_k1z_ymmm256
								0x08,// Full_Mem_256
							0x34,// VkW_3
								0x8D,// ZMM0
								0xB7, 0x07,// EVEX_Vmovsldup_zmm_k1z_zmmm512
								0x09,// Full_Mem_512
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x34,// VkW_3
								0x4D,// XMM0
								0xBB, 0x07,// EVEX_Vmovddup_xmm_k1z_xmmm64
								0x1F,// MOVDDUP_128
							0x34,// VkW_3
								0x6D,// YMM0
								0xBC, 0x07,// EVEX_Vmovddup_ymm_k1z_ymmm256
								0x20,// MOVDDUP_256
							0x34,// VkW_3
								0x8D,// ZMM0
								0xBD, 0x07,// EVEX_Vmovddup_zmm_k1z_zmmm512
								0x21,// MOVDDUP_512

				// 19 = 0x13
				0x08,// MandatoryPrefix2
					0x07,// W
						0x09,// VectorLength
							0x1D,// MV
								0x4D,// XMM0
								0xC0, 0x07,// EVEX_Vmovlps_m64_xmm
								0x11,// Tuple2
							0x00,// Invalid
							0x00,// Invalid
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x1D,// MV
								0x4D,// XMM0
								0xC3, 0x07,// EVEX_Vmovlpd_m64_xmm
								0x0A,// Tuple1_Scalar
							0x00,// Invalid
							0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 20 = 0x14
				0x08,// MandatoryPrefix2
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xC7, 0x07,// EVEX_Vunpcklps_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xC8, 0x07,// EVEX_Vunpcklps_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xC9, 0x07,// EVEX_Vunpcklps_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xCD, 0x07,// EVEX_Vunpcklpd_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xCE, 0x07,// EVEX_Vunpcklpd_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xCF, 0x07,// EVEX_Vunpcklpd_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 21 = 0x15
				0x08,// MandatoryPrefix2
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xD3, 0x07,// EVEX_Vunpckhps_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xD4, 0x07,// EVEX_Vunpckhps_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xD5, 0x07,// EVEX_Vunpckhps_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xD9, 0x07,// EVEX_Vunpckhpd_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xDA, 0x07,// EVEX_Vunpckhpd_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xDB, 0x07,// EVEX_Vunpckhpd_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 22 = 0x16
				0x08,// MandatoryPrefix2
					0x07,// W
						0x09,// VectorLength
							0x22,// VHW_4
								0x4D,// XMM0
								0xDE, 0x07,// EVEX_Vmovlhps_xmm_xmm_xmm
								0xE1, 0x07,// EVEX_Vmovhps_xmm_xmm_m64
								0x11,// Tuple2
							0x00,// Invalid
							0x00,// Invalid
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x20,// VHM
								0x4D,// XMM0
								0xE4, 0x07,// EVEX_Vmovhpd_xmm_xmm_m64
								0x0A,// Tuple1_Scalar
							0x00,// Invalid
							0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x34,// VkW_3
								0x4D,// XMM0
								0xE8, 0x07,// EVEX_Vmovshdup_xmm_k1z_xmmm128
								0x07,// Full_Mem_128
							0x34,// VkW_3
								0x6D,// YMM0
								0xE9, 0x07,// EVEX_Vmovshdup_ymm_k1z_ymmm256
								0x08,// Full_Mem_256
							0x34,// VkW_3
								0x8D,// ZMM0
								0xEA, 0x07,// EVEX_Vmovshdup_zmm_k1z_zmmm512
								0x09,// Full_Mem_512
						0x00,// Invalid
					0x00,// Invalid

				// 23 = 0x17
				0x08,// MandatoryPrefix2
					0x07,// W
						0x09,// VectorLength
							0x1D,// MV
								0x4D,// XMM0
								0xED, 0x07,// EVEX_Vmovhps_m64_xmm
								0x11,// Tuple2
							0x00,// Invalid
							0x00,// Invalid
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x1D,// MV
								0x4D,// XMM0
								0xF0, 0x07,// EVEX_Vmovhpd_m64_xmm
								0x0A,// Tuple1_Scalar
							0x00,// Invalid
							0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 24 = 0x18
				0x02,// Dup
					0x10,// 16
					0x00,// Invalid

				// 40 = 0x28
				0x08,// MandatoryPrefix2
					0x07,// W
						0x09,// VectorLength
							0x34,// VkW_3
								0x4D,// XMM0
								0xB0, 0x08,// EVEX_Vmovaps_xmm_k1z_xmmm128
								0x07,// Full_Mem_128
							0x34,// VkW_3
								0x6D,// YMM0
								0xB1, 0x08,// EVEX_Vmovaps_ymm_k1z_ymmm256
								0x08,// Full_Mem_256
							0x34,// VkW_3
								0x8D,// ZMM0
								0xB2, 0x08,// EVEX_Vmovaps_zmm_k1z_zmmm512
								0x09,// Full_Mem_512
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x34,// VkW_3
								0x4D,// XMM0
								0xB6, 0x08,// EVEX_Vmovapd_xmm_k1z_xmmm128
								0x07,// Full_Mem_128
							0x34,// VkW_3
								0x6D,// YMM0
								0xB7, 0x08,// EVEX_Vmovapd_ymm_k1z_ymmm256
								0x08,// Full_Mem_256
							0x34,// VkW_3
								0x8D,// ZMM0
								0xB8, 0x08,// EVEX_Vmovapd_zmm_k1z_zmmm512
								0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 41 = 0x29
				0x08,// MandatoryPrefix2
					0x07,// W
						0x09,// VectorLength
							0x45,// WkV_3
								0x4D,// XMM0
								0xBC, 0x08,// EVEX_Vmovaps_xmmm128_k1z_xmm
								0x07,// Full_Mem_128
							0x45,// WkV_3
								0x6D,// YMM0
								0xBD, 0x08,// EVEX_Vmovaps_ymmm256_k1z_ymm
								0x08,// Full_Mem_256
							0x45,// WkV_3
								0x8D,// ZMM0
								0xBE, 0x08,// EVEX_Vmovaps_zmmm512_k1z_zmm
								0x09,// Full_Mem_512
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x45,// WkV_3
								0x4D,// XMM0
								0xC2, 0x08,// EVEX_Vmovapd_xmmm128_k1z_xmm
								0x07,// Full_Mem_128
							0x45,// WkV_3
								0x6D,// YMM0
								0xC3, 0x08,// EVEX_Vmovapd_ymmm256_k1z_ymm
								0x08,// Full_Mem_256
							0x45,// WkV_3
								0x8D,// ZMM0
								0xC4, 0x08,// EVEX_Vmovapd_zmmm512_k1z_zmm
								0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 42 = 0x2A
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x00,// Invalid
					0x1E,// V_H_Ev_er
						0x4D,// XMM0
						0xCB, 0x08,// EVEX_Vcvtsi2ss_xmm_xmm_rm32_er
						0x0D,// Tuple1_Scalar_4
						0x0E,// Tuple1_Scalar_8
					0x1E,// V_H_Ev_er
						0x4D,// XMM0
						0xD1, 0x08,// EVEX_Vcvtsi2sd_xmm_xmm_rm32_er
						0x0D,// Tuple1_Scalar_4
						0x0E,// Tuple1_Scalar_8

				// 43 = 0x2B
				0x08,// MandatoryPrefix2
					0x07,// W
						0x09,// VectorLength
							0x1D,// MV
								0x4D,// XMM0
								0xD6, 0x08,// EVEX_Vmovntps_m128_xmm
								0x07,// Full_Mem_128
							0x1D,// MV
								0x6D,// YMM0
								0xD7, 0x08,// EVEX_Vmovntps_m256_ymm
								0x08,// Full_Mem_256
							0x1D,// MV
								0x8D,// ZMM0
								0xD8, 0x08,// EVEX_Vmovntps_m512_zmm
								0x09,// Full_Mem_512
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x1D,// MV
								0x4D,// XMM0
								0xDC, 0x08,// EVEX_Vmovntpd_m128_xmm
								0x07,// Full_Mem_128
							0x1D,// MV
								0x6D,// YMM0
								0xDD, 0x08,// EVEX_Vmovntpd_m256_ymm
								0x08,// Full_Mem_256
							0x1D,// MV
								0x8D,// ZMM0
								0xDE, 0x08,// EVEX_Vmovntpd_m512_zmm
								0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 44 = 0x2C
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x00,// Invalid
					0x0E,// Gv_W_er
						0x4D,// XMM0
						0xE7, 0x08,// EVEX_Vcvttss2si_r32_xmmm32_sae
						0x0D,// Tuple1_Scalar_4
						0x01,// true
					0x0E,// Gv_W_er
						0x4D,// XMM0
						0xED, 0x08,// EVEX_Vcvttsd2si_r32_xmmm64_sae
						0x0E,// Tuple1_Scalar_8
						0x01,// true

				// 45 = 0x2D
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x00,// Invalid
					0x0E,// Gv_W_er
						0x4D,// XMM0
						0xF5, 0x08,// EVEX_Vcvtss2si_r32_xmmm32_er
						0x0D,// Tuple1_Scalar_4
						0x00,// false
					0x0E,// Gv_W_er
						0x4D,// XMM0
						0xFB, 0x08,// EVEX_Vcvtsd2si_r32_xmmm64_er
						0x0E,// Tuple1_Scalar_8
						0x00,// false

				// 46 = 0x2E
				0x08,// MandatoryPrefix2
					0x07,// W
						0x42,// VW_er
							0x4D,// XMM0
							0xFF, 0x08,// EVEX_Vucomiss_xmm_xmmm32_sae
							0x0A,// Tuple1_Scalar
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x42,// VW_er
							0x4D,// XMM0
							0x82, 0x09,// EVEX_Vucomisd_xmm_xmmm64_sae
							0x0A,// Tuple1_Scalar
					0x00,// Invalid
					0x00,// Invalid

				// 47 = 0x2F
				0x08,// MandatoryPrefix2
					0x07,// W
						0x42,// VW_er
							0x4D,// XMM0
							0x87, 0x09,// EVEX_Vcomiss_xmm_xmmm32_sae
							0x0A,// Tuple1_Scalar
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x42,// VW_er
							0x4D,// XMM0
							0x88, 0x09,// EVEX_Vcomisd_xmm_xmmm64_sae
							0x0A,// Tuple1_Scalar
					0x00,// Invalid
					0x00,// Invalid

				// 48 = 0x30
				0x02,// Dup
					0x21,// 33
					0x00,// Invalid

				// 81 = 0x51
				0x08,// MandatoryPrefix2
					0x07,// W
						0x0A,// VectorLength_er
							0x38,// VkW_er_4
								0x4D,// XMM0
								0xEF, 0x09,// EVEX_Vsqrtps_xmm_k1z_xmmm128b32
								0x01,// Full_128
								0x00,// false
							0x38,// VkW_er_4
								0x6D,// YMM0
								0xF0, 0x09,// EVEX_Vsqrtps_ymm_k1z_ymmm256b32
								0x02,// Full_256
								0x00,// false
							0x38,// VkW_er_4
								0x8D,// ZMM0
								0xF1, 0x09,// EVEX_Vsqrtps_zmm_k1z_zmmm512b32_er
								0x03,// Full_512
								0x00,// false
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x0A,// VectorLength_er
							0x38,// VkW_er_4
								0x4D,// XMM0
								0xF5, 0x09,// EVEX_Vsqrtpd_xmm_k1z_xmmm128b64
								0x01,// Full_128
								0x00,// false
							0x38,// VkW_er_4
								0x6D,// YMM0
								0xF6, 0x09,// EVEX_Vsqrtpd_ymm_k1z_ymmm256b64
								0x02,// Full_256
								0x00,// false
							0x38,// VkW_er_4
								0x8D,// ZMM0
								0xF7, 0x09,// EVEX_Vsqrtpd_zmm_k1z_zmmm512b64_er
								0x03,// Full_512
								0x00,// false
					0x07,// W
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xFA, 0x09,// EVEX_Vsqrtss_xmm_k1z_xmm_xmmm32_er
							0x0A,// Tuple1_Scalar
							0x00,// false
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xFD, 0x09,// EVEX_Vsqrtsd_xmm_k1z_xmm_xmmm64_er
							0x0A,// Tuple1_Scalar
							0x00,// false

				// 82 = 0x52
				0x01,// Invalid2

				// 84 = 0x54
				0x08,// MandatoryPrefix2
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0x8B, 0x0A,// EVEX_Vandps_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0x8C, 0x0A,// EVEX_Vandps_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0x8D, 0x0A,// EVEX_Vandps_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0x91, 0x0A,// EVEX_Vandpd_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0x92, 0x0A,// EVEX_Vandpd_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0x93, 0x0A,// EVEX_Vandpd_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 85 = 0x55
				0x08,// MandatoryPrefix2
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0x97, 0x0A,// EVEX_Vandnps_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0x98, 0x0A,// EVEX_Vandnps_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0x99, 0x0A,// EVEX_Vandnps_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0x9D, 0x0A,// EVEX_Vandnpd_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0x9E, 0x0A,// EVEX_Vandnpd_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0x9F, 0x0A,// EVEX_Vandnpd_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 86 = 0x56
				0x08,// MandatoryPrefix2
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xA3, 0x0A,// EVEX_Vorps_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xA4, 0x0A,// EVEX_Vorps_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xA5, 0x0A,// EVEX_Vorps_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xA9, 0x0A,// EVEX_Vorpd_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xAA, 0x0A,// EVEX_Vorpd_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xAB, 0x0A,// EVEX_Vorpd_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 87 = 0x57
				0x08,// MandatoryPrefix2
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xAF, 0x0A,// EVEX_Vxorps_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xB0, 0x0A,// EVEX_Vxorps_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xB1, 0x0A,// EVEX_Vxorps_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xB5, 0x0A,// EVEX_Vxorpd_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xB6, 0x0A,// EVEX_Vxorpd_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xB7, 0x0A,// EVEX_Vxorpd_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 88 = 0x58
				0x08,// MandatoryPrefix2
					0x07,// W
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0xBB, 0x0A,// EVEX_Vaddps_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0xBC, 0x0A,// EVEX_Vaddps_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0xBD, 0x0A,// EVEX_Vaddps_zmm_k1z_zmm_zmmm512b32_er
								0x03,// Full_512
								0x00,// false
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0xC1, 0x0A,// EVEX_Vaddpd_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0xC2, 0x0A,// EVEX_Vaddpd_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0xC3, 0x0A,// EVEX_Vaddpd_zmm_k1z_zmm_zmmm512b64_er
								0x03,// Full_512
								0x00,// false
					0x07,// W
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xC6, 0x0A,// EVEX_Vaddss_xmm_k1z_xmm_xmmm32_er
							0x0A,// Tuple1_Scalar
							0x00,// false
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xC9, 0x0A,// EVEX_Vaddsd_xmm_k1z_xmm_xmmm64_er
							0x0A,// Tuple1_Scalar
							0x00,// false

				// 89 = 0x59
				0x08,// MandatoryPrefix2
					0x07,// W
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0xCD, 0x0A,// EVEX_Vmulps_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0xCE, 0x0A,// EVEX_Vmulps_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0xCF, 0x0A,// EVEX_Vmulps_zmm_k1z_zmm_zmmm512b32_er
								0x03,// Full_512
								0x00,// false
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0xD3, 0x0A,// EVEX_Vmulpd_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0xD4, 0x0A,// EVEX_Vmulpd_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0xD5, 0x0A,// EVEX_Vmulpd_zmm_k1z_zmm_zmmm512b64_er
								0x03,// Full_512
								0x00,// false
					0x07,// W
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xD8, 0x0A,// EVEX_Vmulss_xmm_k1z_xmm_xmmm32_er
							0x0A,// Tuple1_Scalar
							0x00,// false
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xDB, 0x0A,// EVEX_Vmulsd_xmm_k1z_xmm_xmmm64_er
							0x0A,// Tuple1_Scalar
							0x00,// false

				// 90 = 0x5A
				0x08,// MandatoryPrefix2
					0x07,// W
						0x0A,// VectorLength_er
							0x39,// VkW_er_5
								0x4D,// XMM0
								0x4D,// XMM0
								0xDF, 0x0A,// EVEX_Vcvtps2pd_xmm_k1z_xmmm64b32
								0x04,// Half_128
								0x01,// true
							0x39,// VkW_er_5
								0x6D,// YMM0
								0x4D,// XMM0
								0xE0, 0x0A,// EVEX_Vcvtps2pd_ymm_k1z_xmmm128b32
								0x05,// Half_256
								0x01,// true
							0x39,// VkW_er_5
								0x8D,// ZMM0
								0x6D,// YMM0
								0xE1, 0x0A,// EVEX_Vcvtps2pd_zmm_k1z_ymmm256b32_sae
								0x06,// Half_512
								0x01,// true
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x0A,// VectorLength_er
							0x39,// VkW_er_5
								0x4D,// XMM0
								0x4D,// XMM0
								0xE5, 0x0A,// EVEX_Vcvtpd2ps_xmm_k1z_xmmm128b64
								0x01,// Full_128
								0x00,// false
							0x39,// VkW_er_5
								0x4D,// XMM0
								0x6D,// YMM0
								0xE6, 0x0A,// EVEX_Vcvtpd2ps_xmm_k1z_ymmm256b64
								0x02,// Full_256
								0x00,// false
							0x39,// VkW_er_5
								0x6D,// YMM0
								0x8D,// ZMM0
								0xE7, 0x0A,// EVEX_Vcvtpd2ps_ymm_k1z_zmmm512b64_er
								0x03,// Full_512
								0x00,// false
					0x07,// W
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xEA, 0x0A,// EVEX_Vcvtss2sd_xmm_k1z_xmm_xmmm32_sae
							0x0A,// Tuple1_Scalar
							0x01,// true
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xED, 0x0A,// EVEX_Vcvtsd2ss_xmm_k1z_xmm_xmmm64_er
							0x0A,// Tuple1_Scalar
							0x00,// false

				// 91 = 0x5B
				0x08,// MandatoryPrefix2
					0x07,// W
						0x0A,// VectorLength_er
							0x38,// VkW_er_4
								0x4D,// XMM0
								0xF1, 0x0A,// EVEX_Vcvtdq2ps_xmm_k1z_xmmm128b32
								0x01,// Full_128
								0x00,// false
							0x38,// VkW_er_4
								0x6D,// YMM0
								0xF2, 0x0A,// EVEX_Vcvtdq2ps_ymm_k1z_ymmm256b32
								0x02,// Full_256
								0x00,// false
							0x38,// VkW_er_4
								0x8D,// ZMM0
								0xF3, 0x0A,// EVEX_Vcvtdq2ps_zmm_k1z_zmmm512b32_er
								0x03,// Full_512
								0x00,// false
						0x0A,// VectorLength_er
							0x39,// VkW_er_5
								0x4D,// XMM0
								0x4D,// XMM0
								0xF4, 0x0A,// EVEX_Vcvtqq2ps_xmm_k1z_xmmm128b64
								0x01,// Full_128
								0x00,// false
							0x39,// VkW_er_5
								0x4D,// XMM0
								0x6D,// YMM0
								0xF5, 0x0A,// EVEX_Vcvtqq2ps_xmm_k1z_ymmm256b64
								0x02,// Full_256
								0x00,// false
							0x39,// VkW_er_5
								0x6D,// YMM0
								0x8D,// ZMM0
								0xF6, 0x0A,// EVEX_Vcvtqq2ps_ymm_k1z_zmmm512b64_er
								0x03,// Full_512
								0x00,// false
					0x07,// W
						0x0A,// VectorLength_er
							0x38,// VkW_er_4
								0x4D,// XMM0
								0xFA, 0x0A,// EVEX_Vcvtps2dq_xmm_k1z_xmmm128b32
								0x01,// Full_128
								0x00,// false
							0x38,// VkW_er_4
								0x6D,// YMM0
								0xFB, 0x0A,// EVEX_Vcvtps2dq_ymm_k1z_ymmm256b32
								0x02,// Full_256
								0x00,// false
							0x38,// VkW_er_4
								0x8D,// ZMM0
								0xFC, 0x0A,// EVEX_Vcvtps2dq_zmm_k1z_zmmm512b32_er
								0x03,// Full_512
								0x00,// false
						0x00,// Invalid
					0x07,// W
						0x0A,// VectorLength_er
							0x38,// VkW_er_4
								0x4D,// XMM0
								0x80, 0x0B,// EVEX_Vcvttps2dq_xmm_k1z_xmmm128b32
								0x01,// Full_128
								0x01,// true
							0x38,// VkW_er_4
								0x6D,// YMM0
								0x81, 0x0B,// EVEX_Vcvttps2dq_ymm_k1z_ymmm256b32
								0x02,// Full_256
								0x01,// true
							0x38,// VkW_er_4
								0x8D,// ZMM0
								0x82, 0x0B,// EVEX_Vcvttps2dq_zmm_k1z_zmmm512b32_sae
								0x03,// Full_512
								0x01,// true
						0x00,// Invalid
					0x00,// Invalid

				// 92 = 0x5C
				0x08,// MandatoryPrefix2
					0x07,// W
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0x86, 0x0B,// EVEX_Vsubps_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0x87, 0x0B,// EVEX_Vsubps_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0x88, 0x0B,// EVEX_Vsubps_zmm_k1z_zmm_zmmm512b32_er
								0x03,// Full_512
								0x00,// false
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0x8C, 0x0B,// EVEX_Vsubpd_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0x8D, 0x0B,// EVEX_Vsubpd_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0x8E, 0x0B,// EVEX_Vsubpd_zmm_k1z_zmm_zmmm512b64_er
								0x03,// Full_512
								0x00,// false
					0x07,// W
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0x91, 0x0B,// EVEX_Vsubss_xmm_k1z_xmm_xmmm32_er
							0x0A,// Tuple1_Scalar
							0x00,// false
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0x94, 0x0B,// EVEX_Vsubsd_xmm_k1z_xmm_xmmm64_er
							0x0A,// Tuple1_Scalar
							0x00,// false

				// 93 = 0x5D
				0x08,// MandatoryPrefix2
					0x07,// W
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0x98, 0x0B,// EVEX_Vminps_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
								0x01,// true
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0x99, 0x0B,// EVEX_Vminps_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
								0x01,// true
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0x9A, 0x0B,// EVEX_Vminps_zmm_k1z_zmm_zmmm512b32_sae
								0x03,// Full_512
								0x01,// true
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0x9E, 0x0B,// EVEX_Vminpd_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
								0x01,// true
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0x9F, 0x0B,// EVEX_Vminpd_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
								0x01,// true
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0xA0, 0x0B,// EVEX_Vminpd_zmm_k1z_zmm_zmmm512b64_sae
								0x03,// Full_512
								0x01,// true
					0x07,// W
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xA3, 0x0B,// EVEX_Vminss_xmm_k1z_xmm_xmmm32_sae
							0x0A,// Tuple1_Scalar
							0x01,// true
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xA6, 0x0B,// EVEX_Vminsd_xmm_k1z_xmm_xmmm64_sae
							0x0A,// Tuple1_Scalar
							0x01,// true

				// 94 = 0x5E
				0x08,// MandatoryPrefix2
					0x07,// W
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0xAA, 0x0B,// EVEX_Vdivps_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0xAB, 0x0B,// EVEX_Vdivps_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0xAC, 0x0B,// EVEX_Vdivps_zmm_k1z_zmm_zmmm512b32_er
								0x03,// Full_512
								0x00,// false
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0xB0, 0x0B,// EVEX_Vdivpd_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
								0x00,// false
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0xB1, 0x0B,// EVEX_Vdivpd_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
								0x00,// false
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0xB2, 0x0B,// EVEX_Vdivpd_zmm_k1z_zmm_zmmm512b64_er
								0x03,// Full_512
								0x00,// false
					0x07,// W
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xB5, 0x0B,// EVEX_Vdivss_xmm_k1z_xmm_xmmm32_er
							0x0A,// Tuple1_Scalar
							0x00,// false
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xB8, 0x0B,// EVEX_Vdivsd_xmm_k1z_xmm_xmmm64_er
							0x0A,// Tuple1_Scalar
							0x00,// false

				// 95 = 0x5F
				0x08,// MandatoryPrefix2
					0x07,// W
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0xBC, 0x0B,// EVEX_Vmaxps_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
								0x01,// true
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0xBD, 0x0B,// EVEX_Vmaxps_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
								0x01,// true
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0xBE, 0x0B,// EVEX_Vmaxps_zmm_k1z_zmm_zmmm512b32_sae
								0x03,// Full_512
								0x01,// true
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x0A,// VectorLength_er
							0x2D,// VkHW_er_4b
								0x4D,// XMM0
								0xC2, 0x0B,// EVEX_Vmaxpd_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
								0x01,// true
							0x2D,// VkHW_er_4b
								0x6D,// YMM0
								0xC3, 0x0B,// EVEX_Vmaxpd_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
								0x01,// true
							0x2D,// VkHW_er_4b
								0x8D,// ZMM0
								0xC4, 0x0B,// EVEX_Vmaxpd_zmm_k1z_zmm_zmmm512b64_sae
								0x03,// Full_512
								0x01,// true
					0x07,// W
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xC7, 0x0B,// EVEX_Vmaxss_xmm_k1z_xmm_xmmm32_sae
							0x0A,// Tuple1_Scalar
							0x01,// true
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x2C,// VkHW_er_4
							0x4D,// XMM0
							0xCA, 0x0B,// EVEX_Vmaxsd_xmm_k1z_xmm_xmmm64_sae
							0x0A,// Tuple1_Scalar
							0x01,// true

				// 96 = 0x60
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x29,// VkHW_3
							0x4D,// XMM0
							0xCF, 0x0B,// EVEX_Vpunpcklbw_xmm_k1z_xmm_xmmm128
							0x07,// Full_Mem_128
						0x29,// VkHW_3
							0x6D,// YMM0
							0xD0, 0x0B,// EVEX_Vpunpcklbw_ymm_k1z_ymm_ymmm256
							0x08,// Full_Mem_256
						0x29,// VkHW_3
							0x8D,// ZMM0
							0xD1, 0x0B,// EVEX_Vpunpcklbw_zmm_k1z_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 97 = 0x61
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x29,// VkHW_3
							0x4D,// XMM0
							0xD6, 0x0B,// EVEX_Vpunpcklwd_xmm_k1z_xmm_xmmm128
							0x07,// Full_Mem_128
						0x29,// VkHW_3
							0x6D,// YMM0
							0xD7, 0x0B,// EVEX_Vpunpcklwd_ymm_k1z_ymm_ymmm256
							0x08,// Full_Mem_256
						0x29,// VkHW_3
							0x8D,// ZMM0
							0xD8, 0x0B,// EVEX_Vpunpcklwd_zmm_k1z_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 98 = 0x62
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xDD, 0x0B,// EVEX_Vpunpckldq_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xDE, 0x0B,// EVEX_Vpunpckldq_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xDF, 0x0B,// EVEX_Vpunpckldq_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 99 = 0x63
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x29,// VkHW_3
							0x4D,// XMM0
							0xE4, 0x0B,// EVEX_Vpacksswb_xmm_k1z_xmm_xmmm128
							0x07,// Full_Mem_128
						0x29,// VkHW_3
							0x6D,// YMM0
							0xE5, 0x0B,// EVEX_Vpacksswb_ymm_k1z_ymm_ymmm256
							0x08,// Full_Mem_256
						0x29,// VkHW_3
							0x8D,// ZMM0
							0xE6, 0x0B,// EVEX_Vpacksswb_zmm_k1z_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 100 = 0x64
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x13,// KkHW_3
							0x4D,// XMM0
							0xEB, 0x0B,// EVEX_Vpcmpgtb_k_k1_xmm_xmmm128
							0x07,// Full_Mem_128
						0x13,// KkHW_3
							0x6D,// YMM0
							0xEC, 0x0B,// EVEX_Vpcmpgtb_k_k1_ymm_ymmm256
							0x08,// Full_Mem_256
						0x13,// KkHW_3
							0x8D,// ZMM0
							0xED, 0x0B,// EVEX_Vpcmpgtb_k_k1_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 101 = 0x65
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x13,// KkHW_3
							0x4D,// XMM0
							0xF2, 0x0B,// EVEX_Vpcmpgtw_k_k1_xmm_xmmm128
							0x07,// Full_Mem_128
						0x13,// KkHW_3
							0x6D,// YMM0
							0xF3, 0x0B,// EVEX_Vpcmpgtw_k_k1_ymm_ymmm256
							0x08,// Full_Mem_256
						0x13,// KkHW_3
							0x8D,// ZMM0
							0xF4, 0x0B,// EVEX_Vpcmpgtw_k_k1_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 102 = 0x66
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x14,// KkHW_3b
								0x4D,// XMM0
								0xF9, 0x0B,// EVEX_Vpcmpgtd_k_k1_xmm_xmmm128b32
								0x01,// Full_128
							0x14,// KkHW_3b
								0x6D,// YMM0
								0xFA, 0x0B,// EVEX_Vpcmpgtd_k_k1_ymm_ymmm256b32
								0x02,// Full_256
							0x14,// KkHW_3b
								0x8D,// ZMM0
								0xFB, 0x0B,// EVEX_Vpcmpgtd_k_k1_zmm_zmmm512b32
								0x03,// Full_512
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 103 = 0x67
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x29,// VkHW_3
							0x4D,// XMM0
							0x80, 0x0C,// EVEX_Vpackuswb_xmm_k1z_xmm_xmmm128
							0x07,// Full_Mem_128
						0x29,// VkHW_3
							0x6D,// YMM0
							0x81, 0x0C,// EVEX_Vpackuswb_ymm_k1z_ymm_ymmm256
							0x08,// Full_Mem_256
						0x29,// VkHW_3
							0x8D,// ZMM0
							0x82, 0x0C,// EVEX_Vpackuswb_zmm_k1z_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 104 = 0x68
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x29,// VkHW_3
							0x4D,// XMM0
							0x87, 0x0C,// EVEX_Vpunpckhbw_xmm_k1z_xmm_xmmm128
							0x07,// Full_Mem_128
						0x29,// VkHW_3
							0x6D,// YMM0
							0x88, 0x0C,// EVEX_Vpunpckhbw_ymm_k1z_ymm_ymmm256
							0x08,// Full_Mem_256
						0x29,// VkHW_3
							0x8D,// ZMM0
							0x89, 0x0C,// EVEX_Vpunpckhbw_zmm_k1z_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 105 = 0x69
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x29,// VkHW_3
							0x4D,// XMM0
							0x8E, 0x0C,// EVEX_Vpunpckhwd_xmm_k1z_xmm_xmmm128
							0x07,// Full_Mem_128
						0x29,// VkHW_3
							0x6D,// YMM0
							0x8F, 0x0C,// EVEX_Vpunpckhwd_ymm_k1z_ymm_ymmm256
							0x08,// Full_Mem_256
						0x29,// VkHW_3
							0x8D,// ZMM0
							0x90, 0x0C,// EVEX_Vpunpckhwd_zmm_k1z_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 106 = 0x6A
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0x95, 0x0C,// EVEX_Vpunpckhdq_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0x96, 0x0C,// EVEX_Vpunpckhdq_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0x97, 0x0C,// EVEX_Vpunpckhdq_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 107 = 0x6B
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0x9C, 0x0C,// EVEX_Vpackssdw_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0x9D, 0x0C,// EVEX_Vpackssdw_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0x9E, 0x0C,// EVEX_Vpackssdw_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 108 = 0x6C
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xA2, 0x0C,// EVEX_Vpunpcklqdq_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xA3, 0x0C,// EVEX_Vpunpcklqdq_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xA4, 0x0C,// EVEX_Vpunpcklqdq_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 109 = 0x6D
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xA8, 0x0C,// EVEX_Vpunpckhqdq_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xA9, 0x0C,// EVEX_Vpunpckhqdq_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xAA, 0x0C,// EVEX_Vpunpckhqdq_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 110 = 0x6E
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x43,// VX_Ev
							0xB1, 0x0C,// EVEX_Vmovd_xmm_rm32
							0x0D,// Tuple1_Scalar_4
							0x0E,// Tuple1_Scalar_8
						0x00,// Invalid
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 111 = 0x6F
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x34,// VkW_3
								0x4D,// XMM0
								0xB7, 0x0C,// EVEX_Vmovdqa32_xmm_k1z_xmmm128
								0x07,// Full_Mem_128
							0x34,// VkW_3
								0x6D,// YMM0
								0xB8, 0x0C,// EVEX_Vmovdqa32_ymm_k1z_ymmm256
								0x08,// Full_Mem_256
							0x34,// VkW_3
								0x8D,// ZMM0
								0xB9, 0x0C,// EVEX_Vmovdqa32_zmm_k1z_zmmm512
								0x09,// Full_Mem_512
						0x09,// VectorLength
							0x34,// VkW_3
								0x4D,// XMM0
								0xBA, 0x0C,// EVEX_Vmovdqa64_xmm_k1z_xmmm128
								0x07,// Full_Mem_128
							0x34,// VkW_3
								0x6D,// YMM0
								0xBB, 0x0C,// EVEX_Vmovdqa64_ymm_k1z_ymmm256
								0x08,// Full_Mem_256
							0x34,// VkW_3
								0x8D,// ZMM0
								0xBC, 0x0C,// EVEX_Vmovdqa64_zmm_k1z_zmmm512
								0x09,// Full_Mem_512
					0x07,// W
						0x09,// VectorLength
							0x34,// VkW_3
								0x4D,// XMM0
								0xC0, 0x0C,// EVEX_Vmovdqu32_xmm_k1z_xmmm128
								0x07,// Full_Mem_128
							0x34,// VkW_3
								0x6D,// YMM0
								0xC1, 0x0C,// EVEX_Vmovdqu32_ymm_k1z_ymmm256
								0x08,// Full_Mem_256
							0x34,// VkW_3
								0x8D,// ZMM0
								0xC2, 0x0C,// EVEX_Vmovdqu32_zmm_k1z_zmmm512
								0x09,// Full_Mem_512
						0x09,// VectorLength
							0x34,// VkW_3
								0x4D,// XMM0
								0xC3, 0x0C,// EVEX_Vmovdqu64_xmm_k1z_xmmm128
								0x07,// Full_Mem_128
							0x34,// VkW_3
								0x6D,// YMM0
								0xC4, 0x0C,// EVEX_Vmovdqu64_ymm_k1z_ymmm256
								0x08,// Full_Mem_256
							0x34,// VkW_3
								0x8D,// ZMM0
								0xC5, 0x0C,// EVEX_Vmovdqu64_zmm_k1z_zmmm512
								0x09,// Full_Mem_512
					0x07,// W
						0x09,// VectorLength
							0x34,// VkW_3
								0x4D,// XMM0
								0xC6, 0x0C,// EVEX_Vmovdqu8_xmm_k1z_xmmm128
								0x07,// Full_Mem_128
							0x34,// VkW_3
								0x6D,// YMM0
								0xC7, 0x0C,// EVEX_Vmovdqu8_ymm_k1z_ymmm256
								0x08,// Full_Mem_256
							0x34,// VkW_3
								0x8D,// ZMM0
								0xC8, 0x0C,// EVEX_Vmovdqu8_zmm_k1z_zmmm512
								0x09,// Full_Mem_512
						0x09,// VectorLength
							0x34,// VkW_3
								0x4D,// XMM0
								0xC9, 0x0C,// EVEX_Vmovdqu16_xmm_k1z_xmmm128
								0x07,// Full_Mem_128
							0x34,// VkW_3
								0x6D,// YMM0
								0xCA, 0x0C,// EVEX_Vmovdqu16_ymm_k1z_ymmm256
								0x08,// Full_Mem_256
							0x34,// VkW_3
								0x8D,// ZMM0
								0xCB, 0x0C,// EVEX_Vmovdqu16_zmm_k1z_zmmm512
								0x09,// Full_Mem_512

				// 112 = 0x70
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x3C,// VkWIb_3b
								0x4D,// XMM0
								0xD0, 0x0C,// EVEX_Vpshufd_xmm_k1z_xmmm128b32_imm8
								0x01,// Full_128
							0x3C,// VkWIb_3b
								0x6D,// YMM0
								0xD1, 0x0C,// EVEX_Vpshufd_ymm_k1z_ymmm256b32_imm8
								0x02,// Full_256
							0x3C,// VkWIb_3b
								0x8D,// ZMM0
								0xD2, 0x0C,// EVEX_Vpshufd_zmm_k1z_zmmm512b32_imm8
								0x03,// Full_512
						0x00,// Invalid
					0x09,// VectorLength
						0x3B,// VkWIb_3
							0x4D,// XMM0
							0xD6, 0x0C,// EVEX_Vpshufhw_xmm_k1z_xmmm128_imm8
							0x07,// Full_Mem_128
						0x3B,// VkWIb_3
							0x6D,// YMM0
							0xD7, 0x0C,// EVEX_Vpshufhw_ymm_k1z_ymmm256_imm8
							0x08,// Full_Mem_256
						0x3B,// VkWIb_3
							0x8D,// ZMM0
							0xD8, 0x0C,// EVEX_Vpshufhw_zmm_k1z_zmmm512_imm8
							0x09,// Full_Mem_512
					0x09,// VectorLength
						0x3B,// VkWIb_3
							0x4D,// XMM0
							0xDC, 0x0C,// EVEX_Vpshuflw_xmm_k1z_xmmm128_imm8
							0x07,// Full_Mem_128
						0x3B,// VkWIb_3
							0x6D,// YMM0
							0xDD, 0x0C,// EVEX_Vpshuflw_ymm_k1z_ymmm256_imm8
							0x08,// Full_Mem_256
						0x3B,// VkWIb_3
							0x8D,// ZMM0
							0xDE, 0x0C,// EVEX_Vpshuflw_zmm_k1z_zmmm512_imm8
							0x09,// Full_Mem_512

				// 113 = 0x71
				0x06,// Group
					0x04,// ArrayReference
						0x00,// 0x0 = handlers_Grp_0F71

				// 114 = 0x72
				0x06,// Group
					0x04,// ArrayReference
						0x01,// 0x1 = handlers_Grp_0F72

				// 115 = 0x73
				0x06,// Group
					0x04,// ArrayReference
						0x02,// 0x2 = handlers_Grp_0F73

				// 116 = 0x74
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x13,// KkHW_3
							0x4D,// XMM0
							0xB6, 0x0D,// EVEX_Vpcmpeqb_k_k1_xmm_xmmm128
							0x07,// Full_Mem_128
						0x13,// KkHW_3
							0x6D,// YMM0
							0xB7, 0x0D,// EVEX_Vpcmpeqb_k_k1_ymm_ymmm256
							0x08,// Full_Mem_256
						0x13,// KkHW_3
							0x8D,// ZMM0
							0xB8, 0x0D,// EVEX_Vpcmpeqb_k_k1_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 117 = 0x75
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x13,// KkHW_3
							0x4D,// XMM0
							0xBD, 0x0D,// EVEX_Vpcmpeqw_k_k1_xmm_xmmm128
							0x07,// Full_Mem_128
						0x13,// KkHW_3
							0x6D,// YMM0
							0xBE, 0x0D,// EVEX_Vpcmpeqw_k_k1_ymm_ymmm256
							0x08,// Full_Mem_256
						0x13,// KkHW_3
							0x8D,// ZMM0
							0xBF, 0x0D,// EVEX_Vpcmpeqw_k_k1_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 118 = 0x76
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x14,// KkHW_3b
								0x4D,// XMM0
								0xC4, 0x0D,// EVEX_Vpcmpeqd_k_k1_xmm_xmmm128b32
								0x01,// Full_128
							0x14,// KkHW_3b
								0x6D,// YMM0
								0xC5, 0x0D,// EVEX_Vpcmpeqd_k_k1_ymm_ymmm256b32
								0x02,// Full_256
							0x14,// KkHW_3b
								0x8D,// ZMM0
								0xC6, 0x0D,// EVEX_Vpcmpeqd_k_k1_zmm_zmmm512b32
								0x03,// Full_512
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 119 = 0x77
				0x00,// Invalid

				// 120 = 0x78
				0x08,// MandatoryPrefix2
					0x07,// W
						0x0A,// VectorLength_er
							0x39,// VkW_er_5
								0x4D,// XMM0
								0x4D,// XMM0
								0xCC, 0x0D,// EVEX_Vcvttps2udq_xmm_k1z_xmmm128b32
								0x01,// Full_128
								0x01,// true
							0x39,// VkW_er_5
								0x6D,// YMM0
								0x6D,// YMM0
								0xCD, 0x0D,// EVEX_Vcvttps2udq_ymm_k1z_ymmm256b32
								0x02,// Full_256
								0x01,// true
							0x39,// VkW_er_5
								0x8D,// ZMM0
								0x8D,// ZMM0
								0xCE, 0x0D,// EVEX_Vcvttps2udq_zmm_k1z_zmmm512b32_sae
								0x03,// Full_512
								0x01,// true
						0x0A,// VectorLength_er
							0x39,// VkW_er_5
								0x4D,// XMM0
								0x4D,// XMM0
								0xCF, 0x0D,// EVEX_Vcvttpd2udq_xmm_k1z_xmmm128b64
								0x01,// Full_128
								0x01,// true
							0x39,// VkW_er_5
								0x4D,// XMM0
								0x6D,// YMM0
								0xD0, 0x0D,// EVEX_Vcvttpd2udq_xmm_k1z_ymmm256b64
								0x02,// Full_256
								0x01,// true
							0x39,// VkW_er_5
								0x6D,// YMM0
								0x8D,// ZMM0
								0xD1, 0x0D,// EVEX_Vcvttpd2udq_ymm_k1z_zmmm512b64_sae
								0x03,// Full_512
								0x01,// true
					0x07,// W
						0x0A,// VectorLength_er
							0x39,// VkW_er_5
								0x4D,// XMM0
								0x4D,// XMM0
								0xD3, 0x0D,// EVEX_Vcvttps2uqq_xmm_k1z_xmmm64b32
								0x04,// Half_128
								0x01,// true
							0x39,// VkW_er_5
								0x6D,// YMM0
								0x4D,// XMM0
								0xD4, 0x0D,// EVEX_Vcvttps2uqq_ymm_k1z_xmmm128b32
								0x05,// Half_256
								0x01,// true
							0x39,// VkW_er_5
								0x8D,// ZMM0
								0x6D,// YMM0
								0xD5, 0x0D,// EVEX_Vcvttps2uqq_zmm_k1z_ymmm256b32_sae
								0x06,// Half_512
								0x01,// true
						0x0A,// VectorLength_er
							0x39,// VkW_er_5
								0x4D,// XMM0
								0x4D,// XMM0
								0xD6, 0x0D,// EVEX_Vcvttpd2uqq_xmm_k1z_xmmm128b64
								0x01,// Full_128
								0x01,// true
							0x39,// VkW_er_5
								0x6D,// YMM0
								0x6D,// YMM0
								0xD7, 0x0D,// EVEX_Vcvttpd2uqq_ymm_k1z_ymmm256b64
								0x02,// Full_256
								0x01,// true
							0x39,// VkW_er_5
								0x8D,// ZMM0
								0x8D,// ZMM0
								0xD8, 0x0D,// EVEX_Vcvttpd2uqq_zmm_k1z_zmmm512b64_sae
								0x03,// Full_512
								0x01,// true
					0x0E,// Gv_W_er
						0x4D,// XMM0
						0xD9, 0x0D,// EVEX_Vcvttss2usi_r32_xmmm32_sae
						0x0F,// Tuple1_Fixed_4
						0x01,// true
					0x0E,// Gv_W_er
						0x4D,// XMM0
						0xDC, 0x0D,// EVEX_Vcvttsd2usi_r32_xmmm64_sae
						0x10,// Tuple1_Fixed_8
						0x01,// true

				// 121 = 0x79
				0x08,// MandatoryPrefix2
					0x07,// W
						0x0A,// VectorLength_er
							0x39,// VkW_er_5
								0x4D,// XMM0
								0x4D,// XMM0
								0xE0, 0x0D,// EVEX_Vcvtps2udq_xmm_k1z_xmmm128b32
								0x01,// Full_128
								0x00,// false
							0x39,// VkW_er_5
								0x6D,// YMM0
								0x6D,// YMM0
								0xE1, 0x0D,// EVEX_Vcvtps2udq_ymm_k1z_ymmm256b32
								0x02,// Full_256
								0x00,// false
							0x39,// VkW_er_5
								0x8D,// ZMM0
								0x8D,// ZMM0
								0xE2, 0x0D,// EVEX_Vcvtps2udq_zmm_k1z_zmmm512b32_er
								0x03,// Full_512
								0x00,// false
						0x0A,// VectorLength_er
							0x39,// VkW_er_5
								0x4D,// XMM0
								0x4D,// XMM0
								0xE3, 0x0D,// EVEX_Vcvtpd2udq_xmm_k1z_xmmm128b64
								0x01,// Full_128
								0x00,// false
							0x39,// VkW_er_5
								0x4D,// XMM0
								0x6D,// YMM0
								0xE4, 0x0D,// EVEX_Vcvtpd2udq_xmm_k1z_ymmm256b64
								0x02,// Full_256
								0x00,// false
							0x39,// VkW_er_5
								0x6D,// YMM0
								0x8D,// ZMM0
								0xE5, 0x0D,// EVEX_Vcvtpd2udq_ymm_k1z_zmmm512b64_er
								0x03,// Full_512
								0x00,// false
					0x07,// W
						0x0A,// VectorLength_er
							0x39,// VkW_er_5
								0x4D,// XMM0
								0x4D,// XMM0
								0xE7, 0x0D,// EVEX_Vcvtps2uqq_xmm_k1z_xmmm64b32
								0x04,// Half_128
								0x00,// false
							0x39,// VkW_er_5
								0x6D,// YMM0
								0x4D,// XMM0
								0xE8, 0x0D,// EVEX_Vcvtps2uqq_ymm_k1z_xmmm128b32
								0x05,// Half_256
								0x00,// false
							0x39,// VkW_er_5
								0x8D,// ZMM0
								0x6D,// YMM0
								0xE9, 0x0D,// EVEX_Vcvtps2uqq_zmm_k1z_ymmm256b32_er
								0x06,// Half_512
								0x00,// false
						0x0A,// VectorLength_er
							0x39,// VkW_er_5
								0x4D,// XMM0
								0x4D,// XMM0
								0xEA, 0x0D,// EVEX_Vcvtpd2uqq_xmm_k1z_xmmm128b64
								0x01,// Full_128
								0x00,// false
							0x39,// VkW_er_5
								0x6D,// YMM0
								0x6D,// YMM0
								0xEB, 0x0D,// EVEX_Vcvtpd2uqq_ymm_k1z_ymmm256b64
								0x02,// Full_256
								0x00,// false
							0x39,// VkW_er_5
								0x8D,// ZMM0
								0x8D,// ZMM0
								0xEC, 0x0D,// EVEX_Vcvtpd2uqq_zmm_k1z_zmmm512b64_er
								0x03,// Full_512
								0x00,// false
					0x0E,// Gv_W_er
						0x4D,// XMM0
						0xED, 0x0D,// EVEX_Vcvtss2usi_r32_xmmm32_er
						0x0F,// Tuple1_Fixed_4
						0x00,// false
					0x0E,// Gv_W_er
						0x4D,// XMM0
						0xF0, 0x0D,// EVEX_Vcvtsd2usi_r32_xmmm64_er
						0x10,// Tuple1_Fixed_8
						0x00,// false

				// 122 = 0x7A
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x0A,// VectorLength_er
							0x39,// VkW_er_5
								0x4D,// XMM0
								0x4D,// XMM0
								0xF2, 0x0D,// EVEX_Vcvttps2qq_xmm_k1z_xmmm64b32
								0x04,// Half_128
								0x01,// true
							0x39,// VkW_er_5
								0x6D,// YMM0
								0x4D,// XMM0
								0xF3, 0x0D,// EVEX_Vcvttps2qq_ymm_k1z_xmmm128b32
								0x05,// Half_256
								0x01,// true
							0x39,// VkW_er_5
								0x8D,// ZMM0
								0x6D,// YMM0
								0xF4, 0x0D,// EVEX_Vcvttps2qq_zmm_k1z_ymmm256b32_sae
								0x06,// Half_512
								0x01,// true
						0x0A,// VectorLength_er
							0x39,// VkW_er_5
								0x4D,// XMM0
								0x4D,// XMM0
								0xF5, 0x0D,// EVEX_Vcvttpd2qq_xmm_k1z_xmmm128b64
								0x01,// Full_128
								0x01,// true
							0x39,// VkW_er_5
								0x6D,// YMM0
								0x6D,// YMM0
								0xF6, 0x0D,// EVEX_Vcvttpd2qq_ymm_k1z_ymmm256b64
								0x02,// Full_256
								0x01,// true
							0x39,// VkW_er_5
								0x8D,// ZMM0
								0x8D,// ZMM0
								0xF7, 0x0D,// EVEX_Vcvttpd2qq_zmm_k1z_zmmm512b64_sae
								0x03,// Full_512
								0x01,// true
					0x07,// W
						0x09,// VectorLength
							0x37,// VkW_4b
								0x4D,// XMM0
								0x4D,// XMM0
								0xF8, 0x0D,// EVEX_Vcvtudq2pd_xmm_k1z_xmmm64b32
								0x04,// Half_128
							0x37,// VkW_4b
								0x6D,// YMM0
								0x4D,// XMM0
								0xF9, 0x0D,// EVEX_Vcvtudq2pd_ymm_k1z_xmmm128b32
								0x05,// Half_256
							0x37,// VkW_4b
								0x8D,// ZMM0
								0x6D,// YMM0
								0xFA, 0x0D,// EVEX_Vcvtudq2pd_zmm_k1z_ymmm256b32
								0x06,// Half_512
						0x0A,// VectorLength_er
							0x39,// VkW_er_5
								0x4D,// XMM0
								0x4D,// XMM0
								0xFB, 0x0D,// EVEX_Vcvtuqq2pd_xmm_k1z_xmmm128b64
								0x01,// Full_128
								0x00,// false
							0x39,// VkW_er_5
								0x6D,// YMM0
								0x6D,// YMM0
								0xFC, 0x0D,// EVEX_Vcvtuqq2pd_ymm_k1z_ymmm256b64
								0x02,// Full_256
								0x00,// false
							0x39,// VkW_er_5
								0x8D,// ZMM0
								0x8D,// ZMM0
								0xFD, 0x0D,// EVEX_Vcvtuqq2pd_zmm_k1z_zmmm512b64_er
								0x03,// Full_512
								0x00,// false
					0x07,// W
						0x0A,// VectorLength_er
							0x39,// VkW_er_5
								0x4D,// XMM0
								0x4D,// XMM0
								0xFE, 0x0D,// EVEX_Vcvtudq2ps_xmm_k1z_xmmm128b32
								0x01,// Full_128
								0x00,// false
							0x39,// VkW_er_5
								0x6D,// YMM0
								0x6D,// YMM0
								0xFF, 0x0D,// EVEX_Vcvtudq2ps_ymm_k1z_ymmm256b32
								0x02,// Full_256
								0x00,// false
							0x39,// VkW_er_5
								0x8D,// ZMM0
								0x8D,// ZMM0
								0x80, 0x0E,// EVEX_Vcvtudq2ps_zmm_k1z_zmmm512b32_er
								0x03,// Full_512
								0x00,// false
						0x0A,// VectorLength_er
							0x39,// VkW_er_5
								0x4D,// XMM0
								0x4D,// XMM0
								0x81, 0x0E,// EVEX_Vcvtuqq2ps_xmm_k1z_xmmm128b64
								0x01,// Full_128
								0x00,// false
							0x39,// VkW_er_5
								0x4D,// XMM0
								0x6D,// YMM0
								0x82, 0x0E,// EVEX_Vcvtuqq2ps_xmm_k1z_ymmm256b64
								0x02,// Full_256
								0x00,// false
							0x39,// VkW_er_5
								0x6D,// YMM0
								0x8D,// ZMM0
								0x83, 0x0E,// EVEX_Vcvtuqq2ps_ymm_k1z_zmmm512b64_er
								0x03,// Full_512
								0x00,// false

				// 123 = 0x7B
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x0A,// VectorLength_er
							0x39,// VkW_er_5
								0x4D,// XMM0
								0x4D,// XMM0
								0x84, 0x0E,// EVEX_Vcvtps2qq_xmm_k1z_xmmm64b32
								0x04,// Half_128
								0x00,// false
							0x39,// VkW_er_5
								0x6D,// YMM0
								0x4D,// XMM0
								0x85, 0x0E,// EVEX_Vcvtps2qq_ymm_k1z_xmmm128b32
								0x05,// Half_256
								0x00,// false
							0x39,// VkW_er_5
								0x8D,// ZMM0
								0x6D,// YMM0
								0x86, 0x0E,// EVEX_Vcvtps2qq_zmm_k1z_ymmm256b32_er
								0x06,// Half_512
								0x00,// false
						0x0A,// VectorLength_er
							0x39,// VkW_er_5
								0x4D,// XMM0
								0x4D,// XMM0
								0x87, 0x0E,// EVEX_Vcvtpd2qq_xmm_k1z_xmmm128b64
								0x01,// Full_128
								0x00,// false
							0x39,// VkW_er_5
								0x6D,// YMM0
								0x6D,// YMM0
								0x88, 0x0E,// EVEX_Vcvtpd2qq_ymm_k1z_ymmm256b64
								0x02,// Full_256
								0x00,// false
							0x39,// VkW_er_5
								0x8D,// ZMM0
								0x8D,// ZMM0
								0x89, 0x0E,// EVEX_Vcvtpd2qq_zmm_k1z_zmmm512b64_er
								0x03,// Full_512
								0x00,// false
					0x1E,// V_H_Ev_er
						0x4D,// XMM0
						0x8A, 0x0E,// EVEX_Vcvtusi2ss_xmm_xmm_rm32_er
						0x0F,// Tuple1_Fixed_4
						0x10,// Tuple1_Fixed_8
					0x1E,// V_H_Ev_er
						0x4D,// XMM0
						0x8C, 0x0E,// EVEX_Vcvtusi2sd_xmm_xmm_rm32_er
						0x0F,// Tuple1_Fixed_4
						0x10,// Tuple1_Fixed_8

				// 124 = 0x7C
				0x01,// Invalid2

				// 126 = 0x7E
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x0C,// Ev_VX
							0xA0, 0x0E,// EVEX_Vmovd_rm32_xmm
							0x0D,// Tuple1_Scalar_4
							0x0E,// Tuple1_Scalar_8
						0x00,// Invalid
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x41,// VW
								0x4D,// XMM0
								0xA4, 0x0E,// EVEX_Vmovq_xmm_xmmm64
								0x0A,// Tuple1_Scalar
							0x00,// Invalid
							0x00,// Invalid
					0x00,// Invalid

				// 127 = 0x7F
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x45,// WkV_3
								0x4D,// XMM0
								0xA9, 0x0E,// EVEX_Vmovdqa32_xmmm128_k1z_xmm
								0x07,// Full_Mem_128
							0x45,// WkV_3
								0x6D,// YMM0
								0xAA, 0x0E,// EVEX_Vmovdqa32_ymmm256_k1z_ymm
								0x08,// Full_Mem_256
							0x45,// WkV_3
								0x8D,// ZMM0
								0xAB, 0x0E,// EVEX_Vmovdqa32_zmmm512_k1z_zmm
								0x09,// Full_Mem_512
						0x09,// VectorLength
							0x45,// WkV_3
								0x4D,// XMM0
								0xAC, 0x0E,// EVEX_Vmovdqa64_xmmm128_k1z_xmm
								0x07,// Full_Mem_128
							0x45,// WkV_3
								0x6D,// YMM0
								0xAD, 0x0E,// EVEX_Vmovdqa64_ymmm256_k1z_ymm
								0x08,// Full_Mem_256
							0x45,// WkV_3
								0x8D,// ZMM0
								0xAE, 0x0E,// EVEX_Vmovdqa64_zmmm512_k1z_zmm
								0x09,// Full_Mem_512
					0x07,// W
						0x09,// VectorLength
							0x45,// WkV_3
								0x4D,// XMM0
								0xB2, 0x0E,// EVEX_Vmovdqu32_xmmm128_k1z_xmm
								0x07,// Full_Mem_128
							0x45,// WkV_3
								0x6D,// YMM0
								0xB3, 0x0E,// EVEX_Vmovdqu32_ymmm256_k1z_ymm
								0x08,// Full_Mem_256
							0x45,// WkV_3
								0x8D,// ZMM0
								0xB4, 0x0E,// EVEX_Vmovdqu32_zmmm512_k1z_zmm
								0x09,// Full_Mem_512
						0x09,// VectorLength
							0x45,// WkV_3
								0x4D,// XMM0
								0xB5, 0x0E,// EVEX_Vmovdqu64_xmmm128_k1z_xmm
								0x07,// Full_Mem_128
							0x45,// WkV_3
								0x6D,// YMM0
								0xB6, 0x0E,// EVEX_Vmovdqu64_ymmm256_k1z_ymm
								0x08,// Full_Mem_256
							0x45,// WkV_3
								0x8D,// ZMM0
								0xB7, 0x0E,// EVEX_Vmovdqu64_zmmm512_k1z_zmm
								0x09,// Full_Mem_512
					0x07,// W
						0x09,// VectorLength
							0x45,// WkV_3
								0x4D,// XMM0
								0xB8, 0x0E,// EVEX_Vmovdqu8_xmmm128_k1z_xmm
								0x07,// Full_Mem_128
							0x45,// WkV_3
								0x6D,// YMM0
								0xB9, 0x0E,// EVEX_Vmovdqu8_ymmm256_k1z_ymm
								0x08,// Full_Mem_256
							0x45,// WkV_3
								0x8D,// ZMM0
								0xBA, 0x0E,// EVEX_Vmovdqu8_zmmm512_k1z_zmm
								0x09,// Full_Mem_512
						0x09,// VectorLength
							0x45,// WkV_3
								0x4D,// XMM0
								0xBB, 0x0E,// EVEX_Vmovdqu16_xmmm128_k1z_xmm
								0x07,// Full_Mem_128
							0x45,// WkV_3
								0x6D,// YMM0
								0xBC, 0x0E,// EVEX_Vmovdqu16_ymmm256_k1z_ymm
								0x08,// Full_Mem_256
							0x45,// WkV_3
								0x8D,// ZMM0
								0xBD, 0x0E,// EVEX_Vmovdqu16_zmmm512_k1z_zmm
								0x09,// Full_Mem_512

				// 128 = 0x80
				0x02,// Dup
					0x42,// 66
					0x00,// Invalid

				// 194 = 0xC2
				0x08,// MandatoryPrefix2
					0x07,// W
						0x0A,// VectorLength_er
							0x16,// KkHWIb_sae_3b
								0x4D,// XMM0
								0xDF, 0x10,// EVEX_Vcmpps_k_k1_xmm_xmmm128b32_imm8
								0x01,// Full_128
							0x16,// KkHWIb_sae_3b
								0x6D,// YMM0
								0xE0, 0x10,// EVEX_Vcmpps_k_k1_ymm_ymmm256b32_imm8
								0x02,// Full_256
							0x16,// KkHWIb_sae_3b
								0x8D,// ZMM0
								0xE1, 0x10,// EVEX_Vcmpps_k_k1_zmm_zmmm512b32_imm8_sae
								0x03,// Full_512
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x0A,// VectorLength_er
							0x16,// KkHWIb_sae_3b
								0x4D,// XMM0
								0xE5, 0x10,// EVEX_Vcmppd_k_k1_xmm_xmmm128b64_imm8
								0x01,// Full_128
							0x16,// KkHWIb_sae_3b
								0x6D,// YMM0
								0xE6, 0x10,// EVEX_Vcmppd_k_k1_ymm_ymmm256b64_imm8
								0x02,// Full_256
							0x16,// KkHWIb_sae_3b
								0x8D,// ZMM0
								0xE7, 0x10,// EVEX_Vcmppd_k_k1_zmm_zmmm512b64_imm8_sae
								0x03,// Full_512
					0x07,// W
						0x15,// KkHWIb_sae_3
							0x4D,// XMM0
							0xEA, 0x10,// EVEX_Vcmpss_k_k1_xmm_xmmm32_imm8_sae
							0x0A,// Tuple1_Scalar
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x15,// KkHWIb_sae_3
							0x4D,// XMM0
							0xED, 0x10,// EVEX_Vcmpsd_k_k1_xmm_xmmm64_imm8_sae
							0x0A,// Tuple1_Scalar

				// 195 = 0xC3
				0x00,// Invalid

				// 196 = 0xC4
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x1F,// V_H_Ev_Ib
								0x4D,// XMM0
								0xF6, 0x10,// EVEX_Vpinsrw_xmm_xmm_r32m16_imm8
								0x0C,// Tuple1_Scalar_2
								0x0C,// Tuple1_Scalar_2
							0x00,// Invalid
							0x00,// Invalid
						0x09,// VectorLength
							0x1F,// V_H_Ev_Ib
								0x4D,// XMM0
								0xF6, 0x10,// EVEX_Vpinsrw_xmm_xmm_r32m16_imm8
								0x0C,// Tuple1_Scalar_2
								0x0C,// Tuple1_Scalar_2
							0x00,// Invalid
							0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 197 = 0xC5
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x05,// RM
								0x0D,// Ev_VX_Ib
									0x4D,// XMM0
									0xFE, 0x10,// EVEX_Vpextrw_r32_xmm_imm8
								0x00,// Invalid
							0x00,// Invalid
							0x00,// Invalid
						0x09,// VectorLength
							0x05,// RM
								0x0D,// Ev_VX_Ib
									0x4D,// XMM0
									0xFE, 0x10,// EVEX_Vpextrw_r32_xmm_imm8
								0x00,// Invalid
							0x00,// Invalid
							0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 198 = 0xC6
				0x08,// MandatoryPrefix2
					0x07,// W
						0x09,// VectorLength
							0x2F,// VkHWIb_3b
								0x4D,// XMM0
								0x83, 0x11,// EVEX_Vshufps_xmm_k1z_xmm_xmmm128b32_imm8
								0x01,// Full_128
							0x2F,// VkHWIb_3b
								0x6D,// YMM0
								0x84, 0x11,// EVEX_Vshufps_ymm_k1z_ymm_ymmm256b32_imm8
								0x02,// Full_256
							0x2F,// VkHWIb_3b
								0x8D,// ZMM0
								0x85, 0x11,// EVEX_Vshufps_zmm_k1z_zmm_zmmm512b32_imm8
								0x03,// Full_512
						0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x2F,// VkHWIb_3b
								0x4D,// XMM0
								0x89, 0x11,// EVEX_Vshufpd_xmm_k1z_xmm_xmmm128b64_imm8
								0x01,// Full_128
							0x2F,// VkHWIb_3b
								0x6D,// YMM0
								0x8A, 0x11,// EVEX_Vshufpd_ymm_k1z_ymm_ymmm256b64_imm8
								0x02,// Full_256
							0x2F,// VkHWIb_3b
								0x8D,// ZMM0
								0x8B, 0x11,// EVEX_Vshufpd_zmm_k1z_zmm_zmmm512b64_imm8
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 199 = 0xC7
				0x02,// Dup
					0x0A,// 10
					0x00,// Invalid

				// 209 = 0xD1
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x2B,// VkHW_5
							0x4D,// XMM0
							0x4D,// XMM0
							0x4D,// XMM0
							0xAD, 0x11,// EVEX_Vpsrlw_xmm_k1z_xmm_xmmm128
							0x1E,// Mem128
						0x2B,// VkHW_5
							0x6D,// YMM0
							0x6D,// YMM0
							0x4D,// XMM0
							0xAE, 0x11,// EVEX_Vpsrlw_ymm_k1z_ymm_xmmm128
							0x1E,// Mem128
						0x2B,// VkHW_5
							0x8D,// ZMM0
							0x8D,// ZMM0
							0x4D,// XMM0
							0xAF, 0x11,// EVEX_Vpsrlw_zmm_k1z_zmm_xmmm128
							0x1E,// Mem128
					0x00,// Invalid
					0x00,// Invalid

				// 210 = 0xD2
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2B,// VkHW_5
								0x4D,// XMM0
								0x4D,// XMM0
								0x4D,// XMM0
								0xB4, 0x11,// EVEX_Vpsrld_xmm_k1z_xmm_xmmm128
								0x1E,// Mem128
							0x2B,// VkHW_5
								0x6D,// YMM0
								0x6D,// YMM0
								0x4D,// XMM0
								0xB5, 0x11,// EVEX_Vpsrld_ymm_k1z_ymm_xmmm128
								0x1E,// Mem128
							0x2B,// VkHW_5
								0x8D,// ZMM0
								0x8D,// ZMM0
								0x4D,// XMM0
								0xB6, 0x11,// EVEX_Vpsrld_zmm_k1z_zmm_xmmm128
								0x1E,// Mem128
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 211 = 0xD3
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x2B,// VkHW_5
								0x4D,// XMM0
								0x4D,// XMM0
								0x4D,// XMM0
								0xBB, 0x11,// EVEX_Vpsrlq_xmm_k1z_xmm_xmmm128
								0x1E,// Mem128
							0x2B,// VkHW_5
								0x6D,// YMM0
								0x6D,// YMM0
								0x4D,// XMM0
								0xBC, 0x11,// EVEX_Vpsrlq_ymm_k1z_ymm_xmmm128
								0x1E,// Mem128
							0x2B,// VkHW_5
								0x8D,// ZMM0
								0x8D,// ZMM0
								0x4D,// XMM0
								0xBD, 0x11,// EVEX_Vpsrlq_zmm_k1z_zmm_xmmm128
								0x1E,// Mem128
					0x00,// Invalid
					0x00,// Invalid

				// 212 = 0xD4
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xC2, 0x11,// EVEX_Vpaddq_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xC3, 0x11,// EVEX_Vpaddq_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xC4, 0x11,// EVEX_Vpaddq_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 213 = 0xD5
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x29,// VkHW_3
							0x4D,// XMM0
							0xC9, 0x11,// EVEX_Vpmullw_xmm_k1z_xmm_xmmm128
							0x07,// Full_Mem_128
						0x29,// VkHW_3
							0x6D,// YMM0
							0xCA, 0x11,// EVEX_Vpmullw_ymm_k1z_ymm_ymmm256
							0x08,// Full_Mem_256
						0x29,// VkHW_3
							0x8D,// ZMM0
							0xCB, 0x11,// EVEX_Vpmullw_zmm_k1z_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 214 = 0xD6
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x4A,// WV
								0x4D,// XMM0
								0xCE, 0x11,// EVEX_Vmovq_xmmm64_xmm
								0x0A,// Tuple1_Scalar
							0x00,// Invalid
							0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 215 = 0xD7
				0x00,// Invalid

				// 216 = 0xD8
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x29,// VkHW_3
							0x4D,// XMM0
							0xDD, 0x11,// EVEX_Vpsubusb_xmm_k1z_xmm_xmmm128
							0x07,// Full_Mem_128
						0x29,// VkHW_3
							0x6D,// YMM0
							0xDE, 0x11,// EVEX_Vpsubusb_ymm_k1z_ymm_ymmm256
							0x08,// Full_Mem_256
						0x29,// VkHW_3
							0x8D,// ZMM0
							0xDF, 0x11,// EVEX_Vpsubusb_zmm_k1z_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 217 = 0xD9
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x29,// VkHW_3
							0x4D,// XMM0
							0xE4, 0x11,// EVEX_Vpsubusw_xmm_k1z_xmm_xmmm128
							0x07,// Full_Mem_128
						0x29,// VkHW_3
							0x6D,// YMM0
							0xE5, 0x11,// EVEX_Vpsubusw_ymm_k1z_ymm_ymmm256
							0x08,// Full_Mem_256
						0x29,// VkHW_3
							0x8D,// ZMM0
							0xE6, 0x11,// EVEX_Vpsubusw_zmm_k1z_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 218 = 0xDA
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x29,// VkHW_3
							0x4D,// XMM0
							0xEB, 0x11,// EVEX_Vpminub_xmm_k1z_xmm_xmmm128
							0x07,// Full_Mem_128
						0x29,// VkHW_3
							0x6D,// YMM0
							0xEC, 0x11,// EVEX_Vpminub_ymm_k1z_ymm_ymmm256
							0x08,// Full_Mem_256
						0x29,// VkHW_3
							0x8D,// ZMM0
							0xED, 0x11,// EVEX_Vpminub_zmm_k1z_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 219 = 0xDB
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xF2, 0x11,// EVEX_Vpandd_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xF3, 0x11,// EVEX_Vpandd_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xF4, 0x11,// EVEX_Vpandd_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xF5, 0x11,// EVEX_Vpandq_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xF6, 0x11,// EVEX_Vpandq_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xF7, 0x11,// EVEX_Vpandq_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 220 = 0xDC
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x29,// VkHW_3
							0x4D,// XMM0
							0xFC, 0x11,// EVEX_Vpaddusb_xmm_k1z_xmm_xmmm128
							0x07,// Full_Mem_128
						0x29,// VkHW_3
							0x6D,// YMM0
							0xFD, 0x11,// EVEX_Vpaddusb_ymm_k1z_ymm_ymmm256
							0x08,// Full_Mem_256
						0x29,// VkHW_3
							0x8D,// ZMM0
							0xFE, 0x11,// EVEX_Vpaddusb_zmm_k1z_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 221 = 0xDD
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x29,// VkHW_3
							0x4D,// XMM0
							0x83, 0x12,// EVEX_Vpaddusw_xmm_k1z_xmm_xmmm128
							0x07,// Full_Mem_128
						0x29,// VkHW_3
							0x6D,// YMM0
							0x84, 0x12,// EVEX_Vpaddusw_ymm_k1z_ymm_ymmm256
							0x08,// Full_Mem_256
						0x29,// VkHW_3
							0x8D,// ZMM0
							0x85, 0x12,// EVEX_Vpaddusw_zmm_k1z_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 222 = 0xDE
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x29,// VkHW_3
							0x4D,// XMM0
							0x8A, 0x12,// EVEX_Vpmaxub_xmm_k1z_xmm_xmmm128
							0x07,// Full_Mem_128
						0x29,// VkHW_3
							0x6D,// YMM0
							0x8B, 0x12,// EVEX_Vpmaxub_ymm_k1z_ymm_ymmm256
							0x08,// Full_Mem_256
						0x29,// VkHW_3
							0x8D,// ZMM0
							0x8C, 0x12,// EVEX_Vpmaxub_zmm_k1z_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 223 = 0xDF
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0x91, 0x12,// EVEX_Vpandnd_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0x92, 0x12,// EVEX_Vpandnd_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0x93, 0x12,// EVEX_Vpandnd_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0x94, 0x12,// EVEX_Vpandnq_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0x95, 0x12,// EVEX_Vpandnq_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0x96, 0x12,// EVEX_Vpandnq_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 224 = 0xE0
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x29,// VkHW_3
							0x4D,// XMM0
							0x9B, 0x12,// EVEX_Vpavgb_xmm_k1z_xmm_xmmm128
							0x07,// Full_Mem_128
						0x29,// VkHW_3
							0x6D,// YMM0
							0x9C, 0x12,// EVEX_Vpavgb_ymm_k1z_ymm_ymmm256
							0x08,// Full_Mem_256
						0x29,// VkHW_3
							0x8D,// ZMM0
							0x9D, 0x12,// EVEX_Vpavgb_zmm_k1z_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 225 = 0xE1
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x2B,// VkHW_5
							0x4D,// XMM0
							0x4D,// XMM0
							0x4D,// XMM0
							0xA2, 0x12,// EVEX_Vpsraw_xmm_k1z_xmm_xmmm128
							0x1E,// Mem128
						0x2B,// VkHW_5
							0x6D,// YMM0
							0x6D,// YMM0
							0x4D,// XMM0
							0xA3, 0x12,// EVEX_Vpsraw_ymm_k1z_ymm_xmmm128
							0x1E,// Mem128
						0x2B,// VkHW_5
							0x8D,// ZMM0
							0x8D,// ZMM0
							0x4D,// XMM0
							0xA4, 0x12,// EVEX_Vpsraw_zmm_k1z_zmm_xmmm128
							0x1E,// Mem128
					0x00,// Invalid
					0x00,// Invalid

				// 226 = 0xE2
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2B,// VkHW_5
								0x4D,// XMM0
								0x4D,// XMM0
								0x4D,// XMM0
								0xA9, 0x12,// EVEX_Vpsrad_xmm_k1z_xmm_xmmm128
								0x1E,// Mem128
							0x2B,// VkHW_5
								0x6D,// YMM0
								0x6D,// YMM0
								0x4D,// XMM0
								0xAA, 0x12,// EVEX_Vpsrad_ymm_k1z_ymm_xmmm128
								0x1E,// Mem128
							0x2B,// VkHW_5
								0x8D,// ZMM0
								0x8D,// ZMM0
								0x4D,// XMM0
								0xAB, 0x12,// EVEX_Vpsrad_zmm_k1z_zmm_xmmm128
								0x1E,// Mem128
						0x09,// VectorLength
							0x2B,// VkHW_5
								0x4D,// XMM0
								0x4D,// XMM0
								0x4D,// XMM0
								0xAC, 0x12,// EVEX_Vpsraq_xmm_k1z_xmm_xmmm128
								0x1E,// Mem128
							0x2B,// VkHW_5
								0x6D,// YMM0
								0x6D,// YMM0
								0x4D,// XMM0
								0xAD, 0x12,// EVEX_Vpsraq_ymm_k1z_ymm_xmmm128
								0x1E,// Mem128
							0x2B,// VkHW_5
								0x8D,// ZMM0
								0x8D,// ZMM0
								0x4D,// XMM0
								0xAE, 0x12,// EVEX_Vpsraq_zmm_k1z_zmm_xmmm128
								0x1E,// Mem128
					0x00,// Invalid
					0x00,// Invalid

				// 227 = 0xE3
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x29,// VkHW_3
							0x4D,// XMM0
							0xB3, 0x12,// EVEX_Vpavgw_xmm_k1z_xmm_xmmm128
							0x07,// Full_Mem_128
						0x29,// VkHW_3
							0x6D,// YMM0
							0xB4, 0x12,// EVEX_Vpavgw_ymm_k1z_ymm_ymmm256
							0x08,// Full_Mem_256
						0x29,// VkHW_3
							0x8D,// ZMM0
							0xB5, 0x12,// EVEX_Vpavgw_zmm_k1z_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 228 = 0xE4
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x29,// VkHW_3
							0x4D,// XMM0
							0xBA, 0x12,// EVEX_Vpmulhuw_xmm_k1z_xmm_xmmm128
							0x07,// Full_Mem_128
						0x29,// VkHW_3
							0x6D,// YMM0
							0xBB, 0x12,// EVEX_Vpmulhuw_ymm_k1z_ymm_ymmm256
							0x08,// Full_Mem_256
						0x29,// VkHW_3
							0x8D,// ZMM0
							0xBC, 0x12,// EVEX_Vpmulhuw_zmm_k1z_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 229 = 0xE5
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x29,// VkHW_3
							0x4D,// XMM0
							0xC1, 0x12,// EVEX_Vpmulhw_xmm_k1z_xmm_xmmm128
							0x07,// Full_Mem_128
						0x29,// VkHW_3
							0x6D,// YMM0
							0xC2, 0x12,// EVEX_Vpmulhw_ymm_k1z_ymm_ymmm256
							0x08,// Full_Mem_256
						0x29,// VkHW_3
							0x8D,// ZMM0
							0xC3, 0x12,// EVEX_Vpmulhw_zmm_k1z_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 230 = 0xE6
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x0A,// VectorLength_er
							0x39,// VkW_er_5
								0x4D,// XMM0
								0x4D,// XMM0
								0xC7, 0x12,// EVEX_Vcvttpd2dq_xmm_k1z_xmmm128b64
								0x01,// Full_128
								0x01,// true
							0x39,// VkW_er_5
								0x4D,// XMM0
								0x6D,// YMM0
								0xC8, 0x12,// EVEX_Vcvttpd2dq_xmm_k1z_ymmm256b64
								0x02,// Full_256
								0x01,// true
							0x39,// VkW_er_5
								0x6D,// YMM0
								0x8D,// ZMM0
								0xC9, 0x12,// EVEX_Vcvttpd2dq_ymm_k1z_zmmm512b64_sae
								0x03,// Full_512
								0x01,// true
					0x07,// W
						0x09,// VectorLength
							0x37,// VkW_4b
								0x4D,// XMM0
								0x4D,// XMM0
								0xCD, 0x12,// EVEX_Vcvtdq2pd_xmm_k1z_xmmm64b32
								0x04,// Half_128
							0x37,// VkW_4b
								0x6D,// YMM0
								0x4D,// XMM0
								0xCE, 0x12,// EVEX_Vcvtdq2pd_ymm_k1z_xmmm128b32
								0x05,// Half_256
							0x37,// VkW_4b
								0x8D,// ZMM0
								0x6D,// YMM0
								0xCF, 0x12,// EVEX_Vcvtdq2pd_zmm_k1z_ymmm256b32
								0x06,// Half_512
						0x0A,// VectorLength_er
							0x39,// VkW_er_5
								0x4D,// XMM0
								0x4D,// XMM0
								0xD0, 0x12,// EVEX_Vcvtqq2pd_xmm_k1z_xmmm128b64
								0x01,// Full_128
								0x00,// false
							0x39,// VkW_er_5
								0x6D,// YMM0
								0x6D,// YMM0
								0xD1, 0x12,// EVEX_Vcvtqq2pd_ymm_k1z_ymmm256b64
								0x02,// Full_256
								0x00,// false
							0x39,// VkW_er_5
								0x8D,// ZMM0
								0x8D,// ZMM0
								0xD2, 0x12,// EVEX_Vcvtqq2pd_zmm_k1z_zmmm512b64_er
								0x03,// Full_512
								0x00,// false
					0x07,// W
						0x00,// Invalid
						0x0A,// VectorLength_er
							0x39,// VkW_er_5
								0x4D,// XMM0
								0x4D,// XMM0
								0xD6, 0x12,// EVEX_Vcvtpd2dq_xmm_k1z_xmmm128b64
								0x01,// Full_128
								0x00,// false
							0x39,// VkW_er_5
								0x4D,// XMM0
								0x6D,// YMM0
								0xD7, 0x12,// EVEX_Vcvtpd2dq_xmm_k1z_ymmm256b64
								0x02,// Full_256
								0x00,// false
							0x39,// VkW_er_5
								0x6D,// YMM0
								0x8D,// ZMM0
								0xD8, 0x12,// EVEX_Vcvtpd2dq_ymm_k1z_zmmm512b64_er
								0x03,// Full_512
								0x00,// false

				// 231 = 0xE7
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x1D,// MV
								0x4D,// XMM0
								0xDD, 0x12,// EVEX_Vmovntdq_m128_xmm
								0x07,// Full_Mem_128
							0x1D,// MV
								0x6D,// YMM0
								0xDE, 0x12,// EVEX_Vmovntdq_m256_ymm
								0x08,// Full_Mem_256
							0x1D,// MV
								0x8D,// ZMM0
								0xDF, 0x12,// EVEX_Vmovntdq_m512_zmm
								0x09,// Full_Mem_512
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 232 = 0xE8
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x29,// VkHW_3
							0x4D,// XMM0
							0xE4, 0x12,// EVEX_Vpsubsb_xmm_k1z_xmm_xmmm128
							0x07,// Full_Mem_128
						0x29,// VkHW_3
							0x6D,// YMM0
							0xE5, 0x12,// EVEX_Vpsubsb_ymm_k1z_ymm_ymmm256
							0x08,// Full_Mem_256
						0x29,// VkHW_3
							0x8D,// ZMM0
							0xE6, 0x12,// EVEX_Vpsubsb_zmm_k1z_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 233 = 0xE9
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x29,// VkHW_3
							0x4D,// XMM0
							0xEB, 0x12,// EVEX_Vpsubsw_xmm_k1z_xmm_xmmm128
							0x07,// Full_Mem_128
						0x29,// VkHW_3
							0x6D,// YMM0
							0xEC, 0x12,// EVEX_Vpsubsw_ymm_k1z_ymm_ymmm256
							0x08,// Full_Mem_256
						0x29,// VkHW_3
							0x8D,// ZMM0
							0xED, 0x12,// EVEX_Vpsubsw_zmm_k1z_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 234 = 0xEA
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x29,// VkHW_3
							0x4D,// XMM0
							0xF2, 0x12,// EVEX_Vpminsw_xmm_k1z_xmm_xmmm128
							0x07,// Full_Mem_128
						0x29,// VkHW_3
							0x6D,// YMM0
							0xF3, 0x12,// EVEX_Vpminsw_ymm_k1z_ymm_ymmm256
							0x08,// Full_Mem_256
						0x29,// VkHW_3
							0x8D,// ZMM0
							0xF4, 0x12,// EVEX_Vpminsw_zmm_k1z_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 235 = 0xEB
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xF9, 0x12,// EVEX_Vpord_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xFA, 0x12,// EVEX_Vpord_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xFB, 0x12,// EVEX_Vpord_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xFC, 0x12,// EVEX_Vporq_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xFD, 0x12,// EVEX_Vporq_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xFE, 0x12,// EVEX_Vporq_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 236 = 0xEC
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x29,// VkHW_3
							0x4D,// XMM0
							0x83, 0x13,// EVEX_Vpaddsb_xmm_k1z_xmm_xmmm128
							0x07,// Full_Mem_128
						0x29,// VkHW_3
							0x6D,// YMM0
							0x84, 0x13,// EVEX_Vpaddsb_ymm_k1z_ymm_ymmm256
							0x08,// Full_Mem_256
						0x29,// VkHW_3
							0x8D,// ZMM0
							0x85, 0x13,// EVEX_Vpaddsb_zmm_k1z_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 237 = 0xED
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x29,// VkHW_3
							0x4D,// XMM0
							0x8A, 0x13,// EVEX_Vpaddsw_xmm_k1z_xmm_xmmm128
							0x07,// Full_Mem_128
						0x29,// VkHW_3
							0x6D,// YMM0
							0x8B, 0x13,// EVEX_Vpaddsw_ymm_k1z_ymm_ymmm256
							0x08,// Full_Mem_256
						0x29,// VkHW_3
							0x8D,// ZMM0
							0x8C, 0x13,// EVEX_Vpaddsw_zmm_k1z_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 238 = 0xEE
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x29,// VkHW_3
							0x4D,// XMM0
							0x91, 0x13,// EVEX_Vpmaxsw_xmm_k1z_xmm_xmmm128
							0x07,// Full_Mem_128
						0x29,// VkHW_3
							0x6D,// YMM0
							0x92, 0x13,// EVEX_Vpmaxsw_ymm_k1z_ymm_ymmm256
							0x08,// Full_Mem_256
						0x29,// VkHW_3
							0x8D,// ZMM0
							0x93, 0x13,// EVEX_Vpmaxsw_zmm_k1z_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 239 = 0xEF
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0x98, 0x13,// EVEX_Vpxord_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0x99, 0x13,// EVEX_Vpxord_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0x9A, 0x13,// EVEX_Vpxord_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0x9B, 0x13,// EVEX_Vpxorq_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0x9C, 0x13,// EVEX_Vpxorq_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0x9D, 0x13,// EVEX_Vpxorq_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 240 = 0xF0
				0x00,// Invalid

				// 241 = 0xF1
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x2B,// VkHW_5
							0x4D,// XMM0
							0x4D,// XMM0
							0x4D,// XMM0
							0xA5, 0x13,// EVEX_Vpsllw_xmm_k1z_xmm_xmmm128
							0x1E,// Mem128
						0x2B,// VkHW_5
							0x6D,// YMM0
							0x6D,// YMM0
							0x4D,// XMM0
							0xA6, 0x13,// EVEX_Vpsllw_ymm_k1z_ymm_xmmm128
							0x1E,// Mem128
						0x2B,// VkHW_5
							0x8D,// ZMM0
							0x8D,// ZMM0
							0x4D,// XMM0
							0xA7, 0x13,// EVEX_Vpsllw_zmm_k1z_zmm_xmmm128
							0x1E,// Mem128
					0x00,// Invalid
					0x00,// Invalid

				// 242 = 0xF2
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2B,// VkHW_5
								0x4D,// XMM0
								0x4D,// XMM0
								0x4D,// XMM0
								0xAC, 0x13,// EVEX_Vpslld_xmm_k1z_xmm_xmmm128
								0x1E,// Mem128
							0x2B,// VkHW_5
								0x6D,// YMM0
								0x6D,// YMM0
								0x4D,// XMM0
								0xAD, 0x13,// EVEX_Vpslld_ymm_k1z_ymm_xmmm128
								0x1E,// Mem128
							0x2B,// VkHW_5
								0x8D,// ZMM0
								0x8D,// ZMM0
								0x4D,// XMM0
								0xAE, 0x13,// EVEX_Vpslld_zmm_k1z_zmm_xmmm128
								0x1E,// Mem128
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 243 = 0xF3
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x2B,// VkHW_5
								0x4D,// XMM0
								0x4D,// XMM0
								0x4D,// XMM0
								0xB3, 0x13,// EVEX_Vpsllq_xmm_k1z_xmm_xmmm128
								0x1E,// Mem128
							0x2B,// VkHW_5
								0x6D,// YMM0
								0x6D,// YMM0
								0x4D,// XMM0
								0xB4, 0x13,// EVEX_Vpsllq_ymm_k1z_ymm_xmmm128
								0x1E,// Mem128
							0x2B,// VkHW_5
								0x8D,// ZMM0
								0x8D,// ZMM0
								0x4D,// XMM0
								0xB5, 0x13,// EVEX_Vpsllq_zmm_k1z_zmm_xmmm128
								0x1E,// Mem128
					0x00,// Invalid
					0x00,// Invalid

				// 244 = 0xF4
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xBA, 0x13,// EVEX_Vpmuludq_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xBB, 0x13,// EVEX_Vpmuludq_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xBC, 0x13,// EVEX_Vpmuludq_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 245 = 0xF5
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x29,// VkHW_3
							0x4D,// XMM0
							0xC1, 0x13,// EVEX_Vpmaddwd_xmm_k1z_xmm_xmmm128
							0x07,// Full_Mem_128
						0x29,// VkHW_3
							0x6D,// YMM0
							0xC2, 0x13,// EVEX_Vpmaddwd_ymm_k1z_ymm_ymmm256
							0x08,// Full_Mem_256
						0x29,// VkHW_3
							0x8D,// ZMM0
							0xC3, 0x13,// EVEX_Vpmaddwd_zmm_k1z_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 246 = 0xF6
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x21,// VHW_3
							0x4D,// XMM0
							0xC8, 0x13,// EVEX_Vpsadbw_xmm_xmm_xmmm128
							0x07,// Full_Mem_128
						0x21,// VHW_3
							0x6D,// YMM0
							0xC9, 0x13,// EVEX_Vpsadbw_ymm_ymm_ymmm256
							0x08,// Full_Mem_256
						0x21,// VHW_3
							0x8D,// ZMM0
							0xCA, 0x13,// EVEX_Vpsadbw_zmm_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 247 = 0xF7
				0x00,// Invalid

				// 248 = 0xF8
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x29,// VkHW_3
							0x4D,// XMM0
							0xD2, 0x13,// EVEX_Vpsubb_xmm_k1z_xmm_xmmm128
							0x07,// Full_Mem_128
						0x29,// VkHW_3
							0x6D,// YMM0
							0xD3, 0x13,// EVEX_Vpsubb_ymm_k1z_ymm_ymmm256
							0x08,// Full_Mem_256
						0x29,// VkHW_3
							0x8D,// ZMM0
							0xD4, 0x13,// EVEX_Vpsubb_zmm_k1z_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 249 = 0xF9
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x29,// VkHW_3
							0x4D,// XMM0
							0xD9, 0x13,// EVEX_Vpsubw_xmm_k1z_xmm_xmmm128
							0x07,// Full_Mem_128
						0x29,// VkHW_3
							0x6D,// YMM0
							0xDA, 0x13,// EVEX_Vpsubw_ymm_k1z_ymm_ymmm256
							0x08,// Full_Mem_256
						0x29,// VkHW_3
							0x8D,// ZMM0
							0xDB, 0x13,// EVEX_Vpsubw_zmm_k1z_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 250 = 0xFA
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xE0, 0x13,// EVEX_Vpsubd_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xE1, 0x13,// EVEX_Vpsubd_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xE2, 0x13,// EVEX_Vpsubd_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 251 = 0xFB
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x00,// Invalid
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xE7, 0x13,// EVEX_Vpsubq_xmm_k1z_xmm_xmmm128b64
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xE8, 0x13,// EVEX_Vpsubq_ymm_k1z_ymm_ymmm256b64
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xE9, 0x13,// EVEX_Vpsubq_zmm_k1z_zmm_zmmm512b64
								0x03,// Full_512
					0x00,// Invalid
					0x00,// Invalid

				// 252 = 0xFC
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x29,// VkHW_3
							0x4D,// XMM0
							0xEE, 0x13,// EVEX_Vpaddb_xmm_k1z_xmm_xmmm128
							0x07,// Full_Mem_128
						0x29,// VkHW_3
							0x6D,// YMM0
							0xEF, 0x13,// EVEX_Vpaddb_ymm_k1z_ymm_ymmm256
							0x08,// Full_Mem_256
						0x29,// VkHW_3
							0x8D,// ZMM0
							0xF0, 0x13,// EVEX_Vpaddb_zmm_k1z_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 253 = 0xFD
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x09,// VectorLength
						0x29,// VkHW_3
							0x4D,// XMM0
							0xF5, 0x13,// EVEX_Vpaddw_xmm_k1z_xmm_xmmm128
							0x07,// Full_Mem_128
						0x29,// VkHW_3
							0x6D,// YMM0
							0xF6, 0x13,// EVEX_Vpaddw_ymm_k1z_ymm_ymmm256
							0x08,// Full_Mem_256
						0x29,// VkHW_3
							0x8D,// ZMM0
							0xF7, 0x13,// EVEX_Vpaddw_zmm_k1z_zmm_zmmm512
							0x09,// Full_Mem_512
					0x00,// Invalid
					0x00,// Invalid

				// 254 = 0xFE
				0x08,// MandatoryPrefix2
					0x00,// Invalid
					0x07,// W
						0x09,// VectorLength
							0x2A,// VkHW_3b
								0x4D,// XMM0
								0xFC, 0x13,// EVEX_Vpaddd_xmm_k1z_xmm_xmmm128b32
								0x01,// Full_128
							0x2A,// VkHW_3b
								0x6D,// YMM0
								0xFD, 0x13,// EVEX_Vpaddd_ymm_k1z_ymm_ymmm256b32
								0x02,// Full_256
							0x2A,// VkHW_3b
								0x8D,// ZMM0
								0xFE, 0x13,// EVEX_Vpaddd_zmm_k1z_zmm_zmmm512b32
								0x03,// Full_512
						0x00,// Invalid
					0x00,// Invalid
					0x00,// Invalid

				// 255 = 0xFF
				0x00,// Invalid
			};

    }
}