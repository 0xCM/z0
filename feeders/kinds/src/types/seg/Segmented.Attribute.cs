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
            this.TotalWdth = (TypeWidth)totalwidth;
            this.Sequenced = sequenced;
            this.SegWidths = segwidths.Select(w => (TypeWidth)w).ToArray();
        }

        public TypeWidth TotalWdth {get;}

        public TypeWidth[] SegWidths {get;}

        public bool Sequenced {get;}
    }
}