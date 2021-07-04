//-----------------------------------------------------------------------------
// Copyright   : Intel Corporation, 2020
// License     : Apache
// Source      : xed-operand-storage.h
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct XedModels
    {
        [SymSource(xed)]
        public enum EOSZ : sbyte
        {
            [Symbol("eosz8")]
            W8 = 0,

            [Symbol("eosz16")]
            W16 = 1,

            [Symbol("eosz32")]
            W32 = 2,

            [Symbol("eosz64")]
            W64 = 3,

            [Symbol("not_eosz16")]
            Not16 = ~W16,

            [Symbol("eosznot64")]
            Not64 = ~W64
        }
    }
}