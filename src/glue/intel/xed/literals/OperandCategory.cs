//-----------------------------------------------------------------------------
// Copyright   : Intel Corporation, 2020
// License     : Apache
// Source      : xed-iclass-enum.h
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct XedModels
    {
        [SymSource(xed)]
        public enum OperandCategory : byte
        {
            INVALID,

            ERROR,

            IMM,

            IMM_CONST,

            NT_LOOKUP_FN,

            NT_LOOKUP_FN2,

            NT_LOOKUP_FN4,

            REG,
        }
    }
}