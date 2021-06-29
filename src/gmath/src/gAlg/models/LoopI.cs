//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public struct Loop<I> : ITextual
        where I : unmanaged, IComparable<I>
    {
        public I LowerBound;

        public bit LowerInclusive;

        public I UpperBound;

        public bit UpperInclusive;

        public I Step;

        public string Format()
        {
            var dst = TextTools.buffer();
            dst.Append(LowerInclusive ? $"[{LowerBound}" : $"({LowerBound}");
            dst.Append(UpperInclusive ? $", {UpperBound}]" : $", {UpperBound})");
            dst.Append($" step({Step})");
            return dst.Emit();
        }

        public override string ToString()
            => Format();
    }
}