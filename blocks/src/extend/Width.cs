//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Reflection;
    using System.Linq;    

    using static Root;

    partial class ExtendedBlocks    
    {
        /// <summary>
        /// Divines the bit-width of a specified type, if possible
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static FixedWidth Width(this Type t)
        {
            if(VectorType.test(t))
                return VectorType.width(t);
            else if(t.IsBlocked())
                return BK.width(t);
            if(t.IsNumeric())
                return Numeric.width(t);
            else if(t == typeof(bit))
                return FixedWidth.W1;
            else
                return FixedWidth.None;
        }
    }
}