//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using NK = NumericKinds;
    
    partial class XTend
    {
        /// <summary>
        /// Determines the indicator of a numeric kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline)]   
        public static NumericIndicator Indicator(this NumericKind src)
            => NK.indicator(src);
    }
}