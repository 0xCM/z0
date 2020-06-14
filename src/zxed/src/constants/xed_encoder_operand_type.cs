//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;

    public enum xed_encoder_operand_type_t
    {
        XED_ENCODER_OPERAND_TYPE_INVALID,
        XED_ENCODER_OPERAND_TYPE_BRDISP,
        XED_ENCODER_OPERAND_TYPE_REG,
        XED_ENCODER_OPERAND_TYPE_IMM0,
        XED_ENCODER_OPERAND_TYPE_SIMM0,
        XED_ENCODER_OPERAND_TYPE_IMM1,
        XED_ENCODER_OPERAND_TYPE_MEM,
        XED_ENCODER_OPERAND_TYPE_PTR,
        
        /* special for things with suppressed implicit memops */
        XED_ENCODER_OPERAND_TYPE_SEG0,
        
        /* special for things with suppressed implicit memops */
        XED_ENCODER_OPERAND_TYPE_SEG1,
        
        /* specific operand storage fields -- must supply a name */
        XED_ENCODER_OPERAND_TYPE_OTHER          
    }
}