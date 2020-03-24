//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    [AttributeUsage(AttributeTargets.Struct)]
    public class SegmentedAttribute : Attribute
    {            
        public SegmentedAttribute(object totalwidth, bool sequenced, params object[] segwidths)
        {
            this.TotalWdth = (FixedWidth)totalwidth;
            this.Sequenced = sequenced;
            this.SegWidths = segwidths.Select(w => (FixedWidth)w).ToArray();
        }

        public FixedWidth TotalWdth {get;}

        public FixedWidth[] SegWidths {get;}

        public bool Sequenced {get;}
    }
}