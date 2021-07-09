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
        [Flags]
        public enum OperandModifier : byte
        {
            None = 0,

            [Symbol("R")]
            Read = 1,

            [Symbol("W")]
            Write = 2
        }
    }
}