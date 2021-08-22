//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    public enum LlvmDatasetKind : byte
    {
        None = 0,

        Intrinsics = 1,

        Instructions = 2,

        ValueTypes = 8,

        Summary = 16,

        Details = 32,
    }
}