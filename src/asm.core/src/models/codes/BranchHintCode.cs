//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Hex8Seq;

    partial struct AsmCodes
    {
        public enum BranchHintCode : byte
        {
            None = 0,

            /// <summary>
            /// Branch taken
            /// </summary>
            BT = x2e,

            /// <summary>
            /// Branch not taken
            /// </summary>
            BNT = x3e,
        }
    }
}