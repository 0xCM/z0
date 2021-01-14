//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class XTend
    {
        /// <summary>
        /// Returns 0 in a box
        /// </summary>
        /// <param name="kind">The numeric kind of 0 to be put into the box</param>
        [MethodImpl(Inline), Op]
        public static BoxedNumber ZBox(this NumericKind kind)
            => BoxedNumber.Define(Numeric.rebox(byte.MinValue, kind), kind);
   }
}