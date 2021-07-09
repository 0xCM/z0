//-----------------------------------------------------------------------------
// Copyright   : Intel Corporation, 2020
// License     : Apache
// Source      : xed-extension-enum.h
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct XedModels
    {
        /// <summary>
        /// xed-flag-action-enum.h
        /// </summary>
        [SymSource(xed)]
        public enum FlagAction
        {
            ///< undefined (treated as a write)
            [Symbol("u")]
            FLAG_ACTION_u,

            ///< test (read)
            [Symbol("tst")]
            FLAG_ACTION_tst,

            ///< modification (write)
            [Symbol("mod")]
            FLAG_ACTION_mod,

            ///< value will be zero (write)
            [Symbol("0")]
            FLAG_ACTION_0,

            ///< value comes from the stack (write)
            [Symbol("pop")]
            FLAG_ACTION_pop,

            ///< value comes from AH (write)
            [Symbol("ah")]
            FLAG_ACTION_ah,

            ///< value will be 1 (write)
            [Symbol("1")]
            FLAG_ACTION_1,
        }
    }
}