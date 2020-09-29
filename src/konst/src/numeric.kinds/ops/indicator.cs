//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class NumericKinds
    {
        /// <summary>
        /// Determines the indicator of a numeric kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static NumericIndicator indicator(NumericKind src)
        {
            if(unsigned(src))
                return NumericIndicator.Unsigned;
            else if(signed(src))
                return NumericIndicator.Signed;
            else if(floating(src))
                return NumericIndicator.Float;
            else
                return NumericIndicator.None;
        }

    }
}