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

    /// <summary>
    /// Applied to a user-defined type to identify it as an intrinsic vector (or, rather, should be treated/classified as one)
    /// </summary>
    public class VectorAttribute : SegmentedAttribute
    {
        public static bool Test(Type src)
            => Attribute.IsDefined(src, typeof(VectorAttribute));

        public VectorAttribute(object totalwidth)
            : base(totalwidth,false, FixedWidth.NumericWidths)
        {
        }
    }

    public class BlockedAttribute : SegmentedAttribute
    {
        public BlockedAttribute(object totalwidth, bool sequenced, params object[] segwidths)
            : base(totalwidth, sequenced, segwidths)
        {
        }
    }        

    public class FixedAttribute : SegmentedAttribute
    {
        public FixedAttribute(object totalwidth, bool sequenced, params object[] segwidths)
            : base(totalwidth, sequenced, segwidths)
        {
        }
    }    
}