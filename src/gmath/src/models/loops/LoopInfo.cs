//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public struct LoopInfo
    {
        public ClrNumericKind IndexKind;

        public ulong LowerBound;

        public bit LowerInclusive;

        public ulong UpperBound;

        public bit UpperInclusive;

        public ulong Step;
    }
}