//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public sealed class BlockedAttribute : SegmentedAttribute
    {
        public BlockedAttribute(TypeWidth width, params CellWidth[] cells)
            : base(width, false, cells)
        {
        }

        public BlockedAttribute(TypeWidth width, SpanBlockKind kind)
            : base(width, false)
        {
            Kind = kind;
        }

        public SpanBlockKind Kind {get;}

    }
}