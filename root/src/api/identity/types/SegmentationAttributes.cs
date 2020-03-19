//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    [AttributeUsage(AttributeTargets.Struct)]
    public class SegmentedAttribute : Attribute
    {            
        public SegmentedAttribute(object totalwidth, bool sequenced, params object[] segwidths)
        {
            this.TotalWdth = (FixedWidth)totalwidth;
            this.Sequenced = sequenced;
            this.SegWidths = segwidths.Map(w => (FixedWidth)w);
        }

        public FixedWidth TotalWdth {get;}

        public FixedWidth[] SegWidths {get;}

        public bool Sequenced {get;}
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

    /// <summary>
    /// Applied to a user-defined type to identify it as an intrinsic vector (or, rather, should be treated/classified as one)
    /// </summary>
    public class CpuVectorAttribute : SegmentedAttribute
    {
        public static bool Test(Type src)
            => Attribute.IsDefined(src, typeof(CpuVectorAttribute));

        public CpuVectorAttribute(object totalwidth)
            : base(totalwidth,false, FixedWidth.NumericWidths)
        {
        }
    }
}