//-----------------------------------------------------------------------------
// Copyright   : Intel Corporation, 2020
// License     : Apache
// Source      : xed-address-width-enum.h
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Xed
    {
        [SymbolSource]
        public enum AddressWidth : byte
        {
            None=0,

            ///< 16b addressing
            [Symbol("16b")]
            W16b=2,

            //< 32b addressing
            [Symbol("32b")]
            W32b=4,

            //< 64b addressing
            [Symbol("64b")]
            W64b=8,
        }
    }
}