//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;
    using System.Runtime.CompilerServices;

     using static Seed;


    public struct xed_operand_t
    {
        public xed_uint8_t         _name; // xed_operand_enum_t
        
        // implicit, explicit, suppressed
        public xed_uint8_t         _operand_visibility; // xed_operand_visibility_enum_t

        public xed_uint8_t         _rw;   // read or written // xed_operand_action_enum_t
        
        // width code, could be invalid (then use register name)
        public xed_uint8_t         _oc2; // xed_operand_width_enum_t
        
        // IMM, IMM_CONST, NT_LOOKUP_FN, REG, ERROR
        public xed_uint8_t         _type; //xed_operand_type_enum_t
        
        public xed_uint8_t         _xtype; // xed data type: u32, f32, etc. //xed_operand_element_xtype_enum_t
        
        public xed_uint8_t         _cvt_idx; //  decoration index
        
        public xed_uint8_t         _nt; 
        
        // Storage for what was a union
        public uint _u;

        // value for some constant immmed
        public xed_uint32_t u_imm 
        {
             [MethodImpl(Inline)]
             get => (xed_uint32_t)_u;

             [MethodImpl(Inline)]
             set => _u = (uint)value;
        }  
        
        // for nt_lookup_fn's
        public xed_nonterminal_enum_t u_nt 
        { 
             [MethodImpl(Inline)]
             get => (xed_nonterminal_enum_t)_u;

             [MethodImpl(Inline)]
             set => _u = (uint)value;
        }   
        
        // register name
        public xed_reg_enum_t u_reg 
        {
             [MethodImpl(Inline)]
             get => (xed_reg_enum_t)_u;

             [MethodImpl(Inline)]
             set => _u = (uint)value;
        }                
    }
}