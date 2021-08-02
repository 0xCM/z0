//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct AsmCodes
    {
        public enum BranchTargetKind : byte
        {
            None = 0,

            Near = 1,

            Far = 2
        }
    }
}