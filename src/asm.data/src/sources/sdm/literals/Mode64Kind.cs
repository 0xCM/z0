//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct SdmModels
    {
        [SymSource]
        public enum Mode64Kind : byte
        {
            None = 0,

            [Symbol("Valid")]
            Valid,

            [Symbol("N.E.")]
            NE,

            [Symbol("V/N.E.")]
            VNE,
        }
    }
}