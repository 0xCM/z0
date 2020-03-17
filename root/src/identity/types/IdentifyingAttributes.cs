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


    /// <summary>
    /// Applied to a user-defined type to identify it as an intrinsic vector (or, rather, should be treated/classified as one)
    /// </summary>
    [AttributeUsage(AttributeTargets.Struct)]
    public class IntrinsicVectorAttribute : Attribute
    {
        public static bool Test(Type src)
            => Attribute.IsDefined(src, typeof(IntrinsicVectorAttribute));

        public IntrinsicVectorAttribute(int width)
        {
            this.Width = width;
        }

        /// <summary>
        /// The vector width
        /// </summary>
        public BitSize Width {get;}
    }

}