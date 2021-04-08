//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static RegIndex;

    partial struct AsmLang
    {
        public enum BndReg : byte
        {
            [Symbol("bnd0")]
            BND0 = r0,

            [Symbol("bnd1")]
            BND1 = r1,

            [Symbol("bnd2")]
            BND2 = r2,

            [Symbol("bnd3")]
            BND3 = r3,
        }
    }
}