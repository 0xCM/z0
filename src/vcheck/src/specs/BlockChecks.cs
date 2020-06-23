//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct BlockChecks : TCheckBlocks
    {
        public static TCheckBlocks Checker => default(BlockChecks);
    }
}