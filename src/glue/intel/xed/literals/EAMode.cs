//-----------------------------------------------------------------------------
// Copyright   : Intel Corporation, 2020
// License     : Apache
// Source      : xed-cpuid-bit-enum.h
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct XedModels
    {
        /// <summary>
        /// Derived from xed-state-bits.txt
        /// </summary>
        [SymbolSource(xed)]
        public enum EAMode : sbyte
        {
            [Symbol("eanot16")]
            Not16 = 0,

            [Symbol("eamode16")]
            Mode16 = 1,

            [Symbol("eamode32")]
            Mode32 = 2,

            [Symbol("eamode64")]
            Mode64 = 3
        }
    }
}