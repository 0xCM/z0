//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;

    public enum xed_address_width_enum_t
    {
        XED_ADDRESS_WIDTH_INVALID=0,
        XED_ADDRESS_WIDTH_16b=2, ///< 16b addressing
        XED_ADDRESS_WIDTH_32b=4, ///< 32b addressing
        XED_ADDRESS_WIDTH_64b=8, ///< 64b addressing
        XED_ADDRESS_WIDTH_LAST

    }
}