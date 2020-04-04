//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    public sealed class BlockedAttribute : SegmentedAttribute
    {
        public BlockedAttribute(TypeWidth width, bool sequenced, params CellWidth[] cells)
            : base(width, sequenced, cells)
        {
        }
    }        
}