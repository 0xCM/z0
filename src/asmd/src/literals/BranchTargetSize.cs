//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public enum BranchTargetSize : byte
    {
        None = 0,

        Branch16 = 16,

        Branch32 = 32,

        Branch64 = 64,
    }
}