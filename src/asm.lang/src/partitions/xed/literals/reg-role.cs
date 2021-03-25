//-----------------------------------------------------------------------------
// Copyright   : Intel Corporation, 2020
// License     : Apache
// Source      : xed-reg-role-enum.h
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct XedModels
    {
        [SymbolSource]
        public enum RegRole : byte
        {
            None,

            NORMAL, //< Register is a normal register

            SEGREG0, //< The segment register associated with the first memop

            SEGREG1, //< The segment register associated with the second memop

            BASE0, //< The base register associated with the first memop

            BASE1, //< The base register associated with the second memop

            INDEX, //< The index register associated with the first memop
        }
    }
}