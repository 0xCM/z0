//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [AttributeUsage(AttributeTargets.Struct)]
    public class SegmentedAttribute : WidthAttribute
    {
        public SegmentedAttribute(TypeWidth width, bool sequenced, params CellWidth[] widths)
            : base(width)
        {

        }

        public SegmentedAttribute(TypeWidth width, params CellWidth[] cells)
            : this(width, false, cells)
        {
        }

        public SegmentedAttribute(TypeWidth width, SpanBlockKind kind)
            : this(width, false)
        {

        }

    }
}