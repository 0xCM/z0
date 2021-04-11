//-----------------------------------------------------------------------------
// Copyright   : Intel Corporation, 2020
// License     : Apache
// Source      : xed-machine-mode-enum.h
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct XedModels
    {
        [SymbolSource]
        public enum MachineMode : byte
        {
            None,

            LONG_64, //< 64b operating mode

            LONG_COMPAT_32, //< 32b protected mode

            LONG_COMPAT_16, //< 16b protected mode

            LEGACY_32, //< 32b protected mode

            LEGACY_16, //< 16b protected mode

            REAL_16, //< 16b real mode

            REAL_32, //< 32b real mode (CS.D bit = 1)
        }
    }
}
