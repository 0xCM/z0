//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Hex8Seq;

    partial struct AsmCodes
    {
        public enum BndPrefixCode : byte
        {
            None = 0,

            BND = xf2
        }
    }
}