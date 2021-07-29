//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct SdmModels
    {
        public enum Mode64x32Kind
        {
            None = 0,

            [Symbol("V/V")]
            VV,

            [Symbol("V/N. E.")]
            VNE,

            [Symbol("V 1 /V")]
            V1V,

            [Symbol("V/I 2")]
            VI2,
        }
    }
}