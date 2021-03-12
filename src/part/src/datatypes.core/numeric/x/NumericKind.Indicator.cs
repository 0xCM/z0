//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static NumericKinds;

    partial class XNumeric
    {
        /// <summary>
        /// Determines the indicator of a numeric kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static NumericIndicator Indicator(this NumericKind src)
            => indicator(src);
    }
}