//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XDataTypes
    {
        /// <summary>
        /// Returns 0 in a box
        /// </summary>
        /// <param name="kind">The numeric kind of 0 to be put into the box</param>
        [MethodImpl(Inline), Op]
        public static BoxedNumber ZBox(this NumericKind kind)
            => BoxedNumber.Define(NumericBox.rebox(byte.MinValue, kind), kind);
   }
}