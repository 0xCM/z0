//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct ApiIdentify
    {
        /// <summary>
        /// Divines the bit-width of a specified type, if possible
        /// </summary>
        /// <param name="t">The type to examine</param>
        [Op]
        public static TypeWidth width(Type t)
        {
            if(t.IsVector())
                return Widths.vector(t);
            else if(t.IsSegmented())
                return Widths.segmented(t);
            if(NumericKinds.test(t))
                return (TypeWidth)Widths.numeric(t);
            else
                return t.Tag<WidthAttribute>().MapValueOrDefault(a => a.TypeWidth, TypeWidth.None);
        }
    }
}