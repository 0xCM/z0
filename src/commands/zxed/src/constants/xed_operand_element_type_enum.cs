//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;

    public enum xed_operand_element_type_enum_t
    {
        XED_OPERAND_ELEMENT_TYPE_INVALID,
        XED_OPERAND_ELEMENT_TYPE_UINT, ///< Unsigned integer
        XED_OPERAND_ELEMENT_TYPE_INT, ///< Signed integer
        XED_OPERAND_ELEMENT_TYPE_SINGLE, ///< 32b FP single precision
        XED_OPERAND_ELEMENT_TYPE_DOUBLE, ///< 64b FP double precision
        XED_OPERAND_ELEMENT_TYPE_LONGDOUBLE, ///< 80b FP x87
        XED_OPERAND_ELEMENT_TYPE_LONGBCD, ///< 80b decimal BCD
        XED_OPERAND_ELEMENT_TYPE_STRUCT, ///< a structure of various fields
        XED_OPERAND_ELEMENT_TYPE_VARIABLE, ///< depends on other fields in the instruction
        XED_OPERAND_ELEMENT_TYPE_FLOAT16, ///< 16b floating point
        XED_OPERAND_ELEMENT_TYPE_LAST
    }
}