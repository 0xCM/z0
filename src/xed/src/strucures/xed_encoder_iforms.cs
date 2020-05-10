//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;
    using System.Runtime.CompilerServices;

    public struct xed_encoder_iforms
    {
        public xed_uint32_t x_SIBBASE_ENCODE;
        public xed_uint32_t x_SIBBASE_ENCODE_SIB1;
        public xed_uint32_t x_SIBINDEX_ENCODE;
        public xed_uint32_t x_MODRM_MOD_ENCODE;
        public xed_uint32_t x_MODRM_RM_ENCODE;
        public xed_uint32_t x_MODRM_RM_ENCODE_EA16_SIB0;
        public xed_uint32_t x_MODRM_RM_ENCODE_EA64_SIB0;
        public xed_uint32_t x_MODRM_RM_ENCODE_EA32_SIB0;
        public xed_uint32_t x_SIB_NT;
        public xed_uint32_t x_DISP_NT;
        public xed_uint32_t x_REMOVE_SEGMENT;
        public xed_uint32_t x_REX_PREFIX_ENC;
        public xed_uint32_t x_PREFIX_ENC;
        public xed_uint32_t x_VEXED_REX;
        public xed_uint32_t x_XOP_TYPE_ENC;
        public xed_uint32_t x_XOP_MAP_ENC;
        public xed_uint32_t x_XOP_REXXB_ENC;
        public xed_uint32_t x_VEX_TYPE_ENC;
        public xed_uint32_t x_VEX_REXR_ENC;
        public xed_uint32_t x_VEX_REXXB_ENC;
        public xed_uint32_t x_VEX_MAP_ENC;
        public xed_uint32_t x_VEX_REG_ENC;
        public xed_uint32_t x_VEX_ESCVL_ENC;
        public xed_uint32_t x_SE_IMM8;
        public xed_uint32_t x_VSIB_ENC_BASE;
        public xed_uint32_t x_VSIB_ENC;
        public xed_uint32_t x_EVEX_62_REXR_ENC;
        public xed_uint32_t x_EVEX_REXX_ENC;
        public xed_uint32_t x_EVEX_REXB_ENC;
        public xed_uint32_t x_EVEX_REXRR_ENC;
        public xed_uint32_t x_EVEX_MAP_ENC;
        public xed_uint32_t x_EVEX_REXW_VVVV_ENC;
        public xed_uint32_t x_EVEX_UPP_ENC;
        public xed_uint32_t x_AVX512_EVEX_BYTE3_ENC;
        public xed_uint32_t x_UIMMv;
        public xed_uint32_t x_SIMMz;
        public xed_uint32_t x_SIMM8;
        public xed_uint32_t x_UIMM8;
        public xed_uint32_t x_UIMM8_1;
        public xed_uint32_t x_UIMM16;
        public xed_uint32_t x_UIMM32;
        public xed_uint32_t x_BRDISP8;
        public xed_uint32_t x_BRDISP32;
        public xed_uint32_t x_BRDISPz;
        public xed_uint32_t x_MEMDISPv;
        public xed_uint32_t x_MEMDISP32;
        public xed_uint32_t x_MEMDISP16;
        public xed_uint32_t x_MEMDISP8;
        public xed_uint32_t x_MEMDISP;
    }
}