//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Collective;

    partial class XCollective
    {
        /// <summary>
        /// Fills an array with the element type's default value
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="T">The array element type</typeparam>
        [MethodImpl(Inline)]
        public static T[] Clear<T>(this T[] src)
            => Arrays.clear(src);

    }
}