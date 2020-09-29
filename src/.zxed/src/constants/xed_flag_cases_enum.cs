//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    public enum xed_flag_cases_enum_t : byte
    {
        XED_FLAG_CASE_IMMED_ZERO,

        XED_FLAG_CASE_IMMED_ONE,

        XED_FLAG_CASE_IMMED_OTHER,

        XED_FLAG_CASE_HAS_REP, // implies may-dependence for writes

        XED_FLAG_CASE_NO_REP,

        XED_FLAG_CASE_LAST        
    }
}