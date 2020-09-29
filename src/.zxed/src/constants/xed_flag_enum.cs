//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    public enum xed_flag_enum_t : byte
    {
        XED_FLAG_INVALID,

        XED_FLAG_of, ///<< overflow flag

        XED_FLAG_sf, ///< sign flag

        XED_FLAG_zf, ///< zero flag

        XED_FLAG_af, ///< auxiliary flag

        XED_FLAG_pf, ///< parity flag

        XED_FLAG_cf, ///< carry flag

        XED_FLAG_df, ///< direction flag

        XED_FLAG_vif, ///< virtual interrupt flag

        XED_FLAG_iopl, ///< I/O privilege level

        XED_FLAG_if, ///< interrupt flag

        XED_FLAG_ac, ///< alignment check

        XED_FLAG_vm, ///< virtual-8086 mode

        XED_FLAG_rf, ///< resume flag

        XED_FLAG_nt, ///< nested task

        XED_FLAG_tf, ///< traf flag

        XED_FLAG_id, ///< ID flag

        XED_FLAG_vip, ///< virtual interrupt pending

        XED_FLAG_fc0, ///< x87 FC0 flag

        XED_FLAG_fc1, ///< x87 FC1 flag

        XED_FLAG_fc2, ///< x87 FC2 flag

        XED_FLAG_fc3, ///< x87 FC3 flag

        XED_FLAG_LAST
    }
}