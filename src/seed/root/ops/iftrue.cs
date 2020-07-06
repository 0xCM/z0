//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class RootLegacy
    {
        /// <summary>
        /// Executes a function if the criterion is true, otherwise returns the supplied value
        /// </summary>
        /// <typeparam name="T">The function input/output type</typeparam>
        /// <param name="criterion">The criterion on which to branch</param>
        /// <param name="x">The value to supply to the chosen function</param>
        /// <param name="onTrue">The function to evaulate when the criterion is true</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static X iftrue<X>(X x, Func<X,bool> @bool, Func<X,X> onTrue)
            where X : struct
                => @bool(x) ? onTrue(x) : x;
    }
}