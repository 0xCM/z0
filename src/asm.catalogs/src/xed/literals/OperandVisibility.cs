//-----------------------------------------------------------------------------
// Copyright   : Intel Corporation, 2020
// License     : Apache
// Source      : xed-operand-width-enum.h
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct XedModels
    {
        [SymbolSource(xed)]
        public enum OperandVisibility : byte
        {
            INVALID,

            EXPLICIT, ///< Shows up in operand encoding

            IMPLICIT, ///< Part of the opcode, but listed as an operand

            SUPPRESSED, ///< Part of the opcode, but not typically listed as an operand

            LAST
        }
    }
}