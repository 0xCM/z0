//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;
    using System.Runtime.CompilerServices;

    public enum xed_machine_mode_enum_t
    {
        XED_MACHINE_MODE_INVALID,
        XED_MACHINE_MODE_LONG_64, ///< 64b operating mode
        XED_MACHINE_MODE_LONG_COMPAT_32, ///< 32b protected mode
        XED_MACHINE_MODE_LONG_COMPAT_16, ///< 16b protected mode
        XED_MACHINE_MODE_LEGACY_32, ///< 32b protected mode
        XED_MACHINE_MODE_LEGACY_16, ///< 16b protected mode
        XED_MACHINE_MODE_REAL_16, ///< 16b real mode
        XED_MACHINE_MODE_REAL_32, ///< 32b real mode (CS.D bit = 1)
        XED_MACHINE_MODE_LAST        
    }
}