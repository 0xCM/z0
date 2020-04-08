//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class XTend
    {
        /// <summary>
        /// Returns true if the classifier is equivalent to an identity
        /// </summary>
        /// <param name="k">The class to query</param>
        /// <param name="id">The identity to match</param>
        [MethodImpl(Inline)]
        public static NumericIndicator Indicator(this NumericClass k)
            => NumericClasses.indicator(k);
    }
}