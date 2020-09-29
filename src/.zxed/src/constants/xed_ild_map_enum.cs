//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    public enum xed_ild_map_enum_t : byte
    {
        XED_ILD_MAP0,

        XED_ILD_MAP1, /* 0F (all encoding spaces) */

        XED_ILD_MAP2, /* 0F38 (all encoding spaces) */

        XED_ILD_MAP3, /* 0F3A (all encoding spaces) */

        XED_ILD_MAP4,  /* required placeholders */

        XED_ILD_MAP5,

        XED_ILD_MAP6,

        XED_ILD_MAPAMD,   /* fake map 7 -  amd 3dnow */

        XED_ILD_MAP_XOP8, /* amd xop */

        XED_ILD_MAP_XOP9, /* amd xop */

        XED_ILD_MAP_XOPA, /* amd xop */

        XED_ILD_MAP_LAST,  /* for array sizing */

        XED_ILD_MAP_INVALID /* for error handling */
       
    }
}
