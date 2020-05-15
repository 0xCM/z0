//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;
    using System.Runtime.CompilerServices;

    /// @ingroup DEC
    /// constant information about a decoded instruction form, including
    /// the pointer to the constant operand properties #xed_operand_t for this
    /// instruction form.
    public struct xed_inst_t
    {
        // rflags info -- index in to the 2 tables of flags information. 
        // If _flag_complex is true, then the data are in the
        // xed_flags_complex_table[]. Otherwise, the data are in the
        // xed_flags_simple_table[].

        //xed_instruction_fixed_bit_confirmer_fn_t _confirmer;
        
        // number of operands in the operands array
        public xed_uint8_t _noperands; 
        
        public xed_uint8_t _cpl;  // the nominal CPL for the instruction.
        public xed_uint8_t _flag_complex; /* 1/0 valued, bool type */
        
        public xed_uint8_t _exceptions; //xed_exception_enum_t
        
        public xed_uint16_t _flag_info_index; 

        public xed_uint16_t  _iform_enum; //xed_iform_enum_t
        // index into the xed_operand[] array of xed_operand_t structures
        
        public xed_uint16_t _operand_base; 

        // index to table of xed_attributes_t structures
        public xed_uint16_t _attributes;
    }
}