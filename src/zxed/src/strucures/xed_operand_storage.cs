//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    public struct xed_operand_storage_t
    {
        public xed_uint8_t agen;
  
        public xed_uint8_t amd3dnow;
  
        public xed_uint8_t asz;
  
        public xed_uint8_t bcrc;
  
        public xed_uint8_t cet;
  
        public xed_uint8_t cldemote;
  
        public xed_uint8_t df32;
  
        public xed_uint8_t df64;
  
        public xed_uint8_t dummy;
  
        public xed_uint8_t encoder_preferred;
  
        public xed_uint8_t has_sib;
  
        public xed_uint8_t ild_f2;
  
        public xed_uint8_t ild_f3;
  
        public xed_uint8_t imm0;
  
        public xed_uint8_t imm0signed;
  
        public xed_uint8_t imm1;
  
        public xed_uint8_t @lock;
  
        public xed_uint8_t lzcnt;
  
        public xed_uint8_t mem0;
  
        public xed_uint8_t mem1;
  
        public xed_uint8_t modep5;
  
        public xed_uint8_t modep55c;
  
        public xed_uint8_t mode_first_prefix;
  
        public xed_uint8_t mpxmode;
  
        public xed_uint8_t must_use_evex;
  
        public xed_uint8_t needrex;
  
        public xed_uint8_t norex;
  
        public xed_uint8_t no_scale_disp8;
  
        public xed_uint8_t osz;
  
        public xed_uint8_t out_of_bytes;
  
        public xed_uint8_t p4;
  
        public xed_uint8_t prefix66;
  
        public xed_uint8_t ptr;
  
        public xed_uint8_t realmode;
  
        public xed_uint8_t relbr;
  
        public xed_uint8_t rex;
  
        public xed_uint8_t rexb;
  
        public xed_uint8_t rexr;
  
        public xed_uint8_t rexrr;
  
        public xed_uint8_t rexw;
  
        public xed_uint8_t rexx;
  
        public xed_uint8_t sae;
  
        public xed_uint8_t sib;
  
        public xed_uint8_t skip_osz;
  
        public xed_uint8_t tzcnt;
  
        public xed_uint8_t ubit;
  
        public xed_uint8_t using_default_segment0;
  
        public xed_uint8_t using_default_segment1;
  
        public xed_uint8_t vexdest3;
  
        public xed_uint8_t vexdest4;
  
        public xed_uint8_t vex_c4;
  
        public xed_uint8_t wbnoinvd;
  
        public xed_uint8_t zeroing;
  
        public xed_uint8_t default_seg;
  
        public xed_uint8_t easz;
  
        public xed_uint8_t eosz;
  
        public xed_uint8_t first_f2f3;
  
        public xed_uint8_t has_modrm;
  
        public xed_uint8_t last_f2f3;
  
        public xed_uint8_t llrc;
  
        public xed_uint8_t mod;
  
        public xed_operand_mode mode;
  
        public xed_uint8_t rep;
  
        public xed_uint8_t sibscale;
  
        public xed_uint8_t smode;
  
        public xed_uint8_t vex_prefix;
  
        public xed_uint8_t vl;
  
        public xed_uint8_t hint;
  
        public xed_uint8_t mask;
  
        public xed_uint8_t reg;
  
        public xed_uint8_t rm;
        
        public xed_uint8_t roundc;
        
        public xed_uint8_t seg_ovd;
        
        public xed_uint8_t sibbase;
        
        public xed_uint8_t sibindex;
        
        public xed_uint8_t srm;
        
        public xed_uint8_t vexdest210;
        
        public xed_uint8_t vexvalid;
        
        public xed_uint8_t error;
        
        public xed_uint8_t esrc;
        
        public xed_uint8_t map;
        
        public xed_uint8_t nelem;
        
        public xed_uint8_t scale;
        
        public xed_uint8_t bcast;
        
        public xed_chip_enum_t chip;
        
        public xed_uint8_t need_memdisp;
        
        public xed_uint8_t brdisp_width;
        
        public xed_uint8_t disp_width;
        
        public xed_uint8_t ild_seg;
        
        public xed_uint8_t imm1_bytes;
        
        public xed_uint8_t imm_width;
        
        public xed_uint8_t max_bytes;
        
        public xed_uint8_t modrm_byte;
        
        public xed_uint8_t nominal_opcode;
        
        public xed_uint8_t nprefixes;
        
        public xed_uint8_t nrexes;
        
        public xed_uint8_t nseg_prefixes;
        
        public xed_uint8_t pos_disp;
        
        public xed_uint8_t pos_imm;
        
        public xed_uint8_t pos_imm1;
        
        public xed_uint8_t pos_modrm;
        
        public xed_uint8_t pos_nominal_opcode;
        
        public xed_uint8_t pos_sib;
        
        public xed_uint8_t uimm1;
        
        public xed_uint16_t base0;
        
        public xed_uint16_t base1;
        
        public xed_uint16_t element_size;
        
        public xed_uint16_t index;
        
        public xed_uint16_t outreg;
        
        public xed_uint16_t reg0;
        
        public xed_uint16_t reg1;
        
        public xed_uint16_t reg2;
        
        public xed_uint16_t reg3;
 
        public xed_uint16_t reg4;
 
        public xed_uint16_t reg5;
 
        public xed_uint16_t reg6;
 
        public xed_uint16_t reg7;
 
        public xed_uint16_t reg8;
 
        public xed_uint16_t seg0;
 
        public xed_uint16_t seg1;
 
        public xed_uint16_t iclass;
 
        public xed_uint16_t mem_width;
 
        public xed_uint64_t disp;
 
        public xed_uint64_t uimm0;        
    }
}