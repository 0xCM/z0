//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Widths
    {        
        /// <summary>
        /// Divines the bit-width of a specified type, if possible
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static TypeWidth divine(Type t)
        {
            if(t.IsVector())
                return Widths.vector(t);
            else if(t.IsBlocked())
                return Widths.blocked(t);
            if(NumericKinds.test(t))
                return (TypeWidth)Widths.numeric(t);
            else 
                return t.Tag<WidthAttribute>().MapValueOrDefault(a => a.TypeWidth, TypeWidth.None);
        }
    }
}