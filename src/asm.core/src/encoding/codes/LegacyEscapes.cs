//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct AsmCodes
    {
        public enum LegacyEscapes : ushort
        {
            None = 0,

            x0F = 0x0F,

            x0F38 = 0x0F38,

            x0F3A = 0x0F3A,
        }
    }
}