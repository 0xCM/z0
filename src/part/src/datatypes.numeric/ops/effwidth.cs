//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Numeric
    {
        /// <summary>
        /// Computes the bit-width of the smallest numeric type that can represent the source value
        /// </summary>
        [MethodImpl(Inline), Op]
        public static NumericWidth effwidth(ulong src)
        {
            if(src <= byte.MaxValue)
                return NumericWidth.W8;
            else if(src <= ushort.MaxValue)
                return NumericWidth.W16;
            else if(src <= uint.MaxValue)
                return NumericWidth.W32;
            else
                return NumericWidth.W64;
        }
    }
}