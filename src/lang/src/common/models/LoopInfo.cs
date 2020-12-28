//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    public struct LoopInfo
    {
        public PrimalNumericKind IndexKind;

        public Cell64 LowerBound;

        public bit LowerInclusive;

        public Cell64 UpperBound;

        public bit UpperInclusive;

        public Cell64 Step;
    }
}