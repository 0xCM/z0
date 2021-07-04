//-----------------------------------------------------------------------------
// Copyright   : Intel Corporation, 2020
// License     : Apache
// Source      : xed-nonterminal-enum.h
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct XedModels
    {
        [SymSource(xed)]
        public enum Nonterminal : ushort
        {
            None,

            AR10,

            AR11,

            AR12,

            AR13,

            AR14,

            AR15,

            AR8,

            AR9,

            ARAX,

            ARBP,

            ARBX,

            ARCX,

            ARDI,

            ARDX,

            ARSI,

            ARSP,

            ASZ_NONTERM,

            AVX512_ROUND,

            AVX_INSTRUCTIONS,

            AVX_SPLITTER,

            A_GPR_B,

            A_GPR_R,

            BND_B,

            BND_B_CHECK,

            BND_R,

            BND_R_CHECK,

            BRANCH_HINT,

            BRDISP32,

            BRDISP8,

            BRDISPZ,

            CET_NO_TRACK,

            CR_B,

            CR_R,

            CR_WIDTH,

            DF64,

            DR_R,

            ESIZE_128_BITS,

            ESIZE_16_BITS,

            ESIZE_1_BITS,

            ESIZE_2_BITS,

            ESIZE_32_BITS,

            ESIZE_4_BITS,

            ESIZE_64_BITS,

            ESIZE_8_BITS,

            EVEX_INSTRUCTIONS,

            EVEX_SPLITTER,

            FINAL_DSEG,

            FINAL_DSEG1,

            FINAL_DSEG1_MODE64,

            FINAL_DSEG1_NOT64,

            FINAL_DSEG_MODE64,

            FINAL_DSEG_NOT64,

            FINAL_ESEG,

            FINAL_ESEG1,

            FINAL_SSEG,

            FINAL_SSEG0,

            FINAL_SSEG1,

            FINAL_SSEG_MODE64,

            FINAL_SSEG_NOT64,

            FIX_ROUND_LEN128,

            FIX_ROUND_LEN512,

            FORCE64,

            GPR16_B,

            GPR16_R,

            GPR16_SB,

            GPR32_B,

            GPR32_R,

            GPR32_SB,

            GPR32_X,

            GPR64_B,

            GPR64_R,

            GPR64_SB,

            GPR64_X,

            [Symbol("GPR8b")]
            GPR8_B,

            GPR8_R,

            GPR8_SB,

            GPRV_B,

            GPRV_R,

            GPRV_SB,

            GPRY_B,

            GPRY_R,

            GPRZ_B,

            GPRZ_R,

            IGNORE66,

            IMMUNE66,

            IMMUNE66_LOOP64,

            IMMUNE_REXW,

            INSTRUCTIONS,

            ISA,

            MASK1,

            MASKNOT0,

            MASK_B,

            MASK_N,

            MASK_N32,

            MASK_N64,

            MASK_R,

            MEMDISP,

            MEMDISP16,

            MEMDISP32,

            MEMDISP8,

            MEMDISPV,

            MMX_B,

            MMX_R,

            MODRM,

            MODRM16,

            MODRM32,

            MODRM64ALT32,

            NELEM_EIGHTHMEM,

            NELEM_FULL,

            NELEM_FULLMEM,

            NELEM_GPR_READER,

            NELEM_GPR_READER_BYTE,

            NELEM_GPR_READER_SUBDWORD,

            NELEM_GPR_READER_WORD,

            NELEM_GPR_WRITER_LDOP,

            NELEM_GPR_WRITER_LDOP_D,

            NELEM_GPR_WRITER_LDOP_Q,

            NELEM_GPR_WRITER_STORE,

            NELEM_GPR_WRITER_STORE_BYTE,

            NELEM_GPR_WRITER_STORE_SUBDWORD,

            NELEM_GPR_WRITER_STORE_WORD,

            NELEM_GSCAT,

            NELEM_HALF,

            NELEM_HALFMEM,

            NELEM_MEM128,

            NELEM_MOVDDUP,

            NELEM_QUARTERMEM,

            NELEM_SCALAR,

            NELEM_TUPLE1,

            NELEM_TUPLE1_4X,

            NELEM_TUPLE1_BYTE,

            NELEM_TUPLE1_SUBDWORD,

            NELEM_TUPLE1_WORD,

            NELEM_TUPLE2,

            NELEM_TUPLE4,

            NELEM_TUPLE8,

            OEAX,

            ONE,

            ORAX,

            ORBP,

            ORBX,

            ORCX,

            ORDX,

            ORSP,

            OSZ_NONTERM,

            OVERRIDE_SEG0,

            OVERRIDE_SEG1,

            PREFIXES,

            REFINING66,

            REMOVE_SEGMENT,

            RFLAGS,

            RIP,

            RIPA,

            SAE,

            SEG,

            SEG_MOV,

            SE_IMM8,

            SIB,

            SIB_BASE0,

            SIMM8,

            SIMMZ,

            SRBP,

            SRSP,

            TMM_B,

            TMM_N,

            TMM_R,

            UIMM16,

            UIMM32,

            UIMM8,

            UIMM8_1,

            UIMMV,

            UISA_VMODRM_XMM,

            UISA_VMODRM_YMM,

            UISA_VMODRM_ZMM,

            UISA_VSIB_BASE,

            UISA_VSIB_INDEX_XMM,

            UISA_VSIB_INDEX_YMM,

            UISA_VSIB_INDEX_ZMM,

            UISA_VSIB_XMM,

            UISA_VSIB_YMM,

            UISA_VSIB_ZMM,

            VGPR32_B,

            VGPR32_B_32,

            VGPR32_B_64,

            VGPR32_N,

            VGPR32_N_32,

            VGPR32_N_64,

            VGPR32_R,

            VGPR32_R_32,

            VGPR32_R_64,

            VGPR64_B,

            VGPR64_N,

            VGPR64_R,

            VGPRY_B,

            VGPRY_N,

            VGPRY_R,

            VMODRM_XMM,

            VMODRM_YMM,

            VSIB_BASE,

            VSIB_INDEX_XMM,

            VSIB_INDEX_YMM,

            VSIB_XMM,

            VSIB_YMM,

            X87,

            XMM_B,

            XMM_B3,

            XMM_B3_32,

            XMM_B3_64,

            XMM_B_32,

            XMM_B_64,

            XMM_N,

            XMM_N3,

            XMM_N3_32,

            XMM_N3_64,

            XMM_N_32,

            XMM_N_64,

            XMM_R,

            XMM_R3,

            XMM_R3_32,

            XMM_R3_64,

            XMM_R_32,

            XMM_R_64,

            XMM_SE,

            XMM_SE32,

            XMM_SE64,

            XOP_INSTRUCTIONS,

            YMM_B,

            YMM_B3,

            YMM_B3_32,

            YMM_B3_64,

            YMM_B_32,

            YMM_B_64,

            YMM_N,

            YMM_N3,

            YMM_N3_32,

            YMM_N3_64,

            YMM_N_32,

            YMM_N_64,

            YMM_R,

            YMM_R3,
            YMM_R3_32,

            YMM_R3_64,

            YMM_R_32,

            YMM_R_64,

            YMM_SE,

            YMM_SE32,

            YMM_SE64,

            ZMM_B3,

            ZMM_B3_32,

            ZMM_B3_64,

            ZMM_N3,

            ZMM_N3_32,

            ZMM_N3_64,

            ZMM_R3,

            ZMM_R3_32,

            ZMM_R3_64,
        }
    }
}