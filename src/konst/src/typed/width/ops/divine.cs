//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

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
                return vector(t);
            else if(t.IsBlocked())
                return blocked(t);
            if(NumericKinds.test(t))
                return (TypeWidth)numeric(t);
            else 
                return t.Tag<WidthAttribute>().MapValueOrDefault(a => a.TypeWidth, TypeWidth.None);
        }
    }
}