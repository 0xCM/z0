//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    [AttributeUsage(AttributeTargets.Struct)]
    public class SegmentedAttribute : WidthAttribute
    {
        public SegmentedAttribute(TypeWidth width, bool sequenced, params CellWidth[] widths)
            : base(width)
        {
            this.Sequenced = sequenced;
            this.CellWidths = widths;
        }

        /// <summary>
        /// Specifies the potential cell widths of a segmented type
        /// </summary>
        public CellWidth[] CellWidths {get;}

        public bool Sequenced {get;}
    }

}