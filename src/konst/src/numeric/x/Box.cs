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
        /// Puts a value of any numeric kind into a box of any numeric kind
        /// </summary>
        /// <param name="dst">The target box kind</param>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static BoxedNumber Box<T>(this NumericKind dst, T src)
            where T : unmanaged
                => BoxedNumber.define(Numeric.rebox(src,dst), dst);

        /// <summary>
        /// Puts an enum value into a (numeric) box
        /// </summary>
        /// <param name="e">The enumeration value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static BoxedNumber Box<E>(this E src)
            where E : unmanaged, Enum
                => BoxedNumber.from(src);
    }
}