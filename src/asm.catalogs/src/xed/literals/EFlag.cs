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

            of, //<< overflow flag

            sf, //< sign flag

            zf, //< zero flag

            af, //< auxiliary flag

            pf, //< parity flag

            cf, //< carry flag

            df, //< direction flag

            vif, //< virtual interrupt flag

            iopl, //< I/O privilege level

            [Symbol("if")]
            _if, //< interrupt flag

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