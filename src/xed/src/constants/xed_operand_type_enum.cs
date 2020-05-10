//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;
    using System.Runtime.CompilerServices;

    public enum xed_operand_type_enum_t
    {
        XED_OPERAND_TYPE_INVALID,
        XED_OPERAND_TYPE_ERROR,
        XED_OPERAND_TYPE_IMM,
        XED_OPERAND_TYPE_IMM_CONST,
        XED_OPERAND_TYPE_NT_LOOKUP_FN,
        XED_OPERAND_TYPE_NT_LOOKUP_FN4,
        XED_OPERAND_TYPE_REG,
        XED_OPERAND_TYPE_LAST

    }

}