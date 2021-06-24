//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Hex8Seq;

    partial struct AsmCodes
    {
        [SymbolSource]
        public enum BranchHintCode : byte
        {
            None = 0,

            /// <summary>
            /// Branch taken
            /// </summary>
            [Symbol("BT", "2e - Branch Taken")]
            BT = x2e,

            /// <summary>
            /// Branch not taken
            /// </summary>
            [Symbol("BT", "3e - Branch Not Taken")]
            BNT = x3e,
        }
    }
}