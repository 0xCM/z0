//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct SdmModels
    {
        public enum EncodingCrossRef : byte
        {
            None,

            [Symbol("A")]
            A,

            [Symbol("B")]
            B,

            [Symbol("C")]
            C,

            [Symbol("RVM")]
            RVM,

            [Symbol("MVR")]
            MVR
        }
    }
}