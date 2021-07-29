//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct SdmModels
    {
        public enum LegacyModeKind : byte
        {
            None = 0,

            [Symbol("Valid")]
            Valid,

            [Symbol("N.E.")]
            NE,
        }
    }
}