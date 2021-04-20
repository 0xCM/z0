//-----------------------------------------------------------------------------
// Copyright   : Intel Corporation, 2020
// License     : Apache
// Source      : xed-flag-enum.h
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct XedModels
    {
        [SymbolSource(xed)]
        public enum EFlag : byte
        {
            None,

            [Symbol("of", "overflow flag")]
            of,

            [Symbol("sf", "sign flag")]
            sf,

            [Symbol("zf", "zero flag")]
            zf,

            [Symbol("af", "auxiliary flag")]
            af,

            [Symbol("pf", "parity flag")]
            pf,

            [Symbol("df", "carry flag")]
            cf,

            [Symbol("df", "direction flag")]
            df,

            [Symbol("vif", "virtual interrupt flag")]
            vif,

            [Symbol("iopl", "I/O privilege level")]
            iopl,

            [Symbol("if", "interrupt flag")]
            _if,

            [Symbol("ac", "alignment check")]
            ac, //< alignment check

            vm, //< virtual-8086 mode

            rf, //< resume flag

            nt, //< nested task

            tf, //< traf flag

            id, //< ID flag

            vip, //< virtual interrupt pending

            fc0, //< x87 FC0 flag

            fc1, //< x87 FC1 flag

            fc2, //< x87 FC2 flag

            fc3, //< x87 FC3 flag
        }
    }
}