//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;

    public enum xed_operand_visibility_enum_t
    {
        XED_OPVIS_INVALID,
        XED_OPVIS_EXPLICIT, ///< Shows up in operand encoding
        XED_OPVIS_IMPLICIT, ///< Part of the opcode, but listed as an operand
        XED_OPVIS_SUPPRESSED, ///< Part of the opcode, but not typically listed as an operand
        XED_OPVIS_LAST
    }
}