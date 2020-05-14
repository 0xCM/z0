//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;
    using System.Runtime.CompilerServices;

    public enum xed_operand_ctype_enum_t
    {
        XED_OPERAND_CTYPE_INVALID,
        XED_OPERAND_CTYPE_XED_BITS_T,
        XED_OPERAND_CTYPE_XED_CHIP_ENUM_T,
        XED_OPERAND_CTYPE_XED_ERROR_ENUM_T,
        XED_OPERAND_CTYPE_XED_ICLASS_ENUM_T,
        XED_OPERAND_CTYPE_XED_INT64_T,
        XED_OPERAND_CTYPE_XED_REG_ENUM_T,
        XED_OPERAND_CTYPE_XED_UINT16_T,
        XED_OPERAND_CTYPE_XED_UINT64_T,
        XED_OPERAND_CTYPE_XED_UINT8_T,
        XED_OPERAND_CTYPE_LAST
    }

}