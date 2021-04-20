//-----------------------------------------------------------------------------
// Copyright   : Intel Corporation, 2020
// License     : Apache
// Source      : xed-operand-width-enum.h
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct XedModels
    {
        public enum OperandVisibility : byte
        {
            XED_OPVIS_INVALID,

            XED_OPVIS_EXPLICIT, ///< Shows up in operand encoding

            XED_OPVIS_IMPLICIT, ///< Part of the opcode, but listed as an operand

            XED_OPVIS_SUPPRESSED, ///< Part of the opcode, but not typically listed as an operand

            XED_OPVIS_LAST
        }
    }
}