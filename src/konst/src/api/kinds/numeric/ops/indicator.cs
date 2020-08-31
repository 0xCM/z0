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

    partial class XTend
    {
        /// <summary>
        /// Converts a numeric indicator to a character
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline)]
        public static char ToChar(this NumericIndicator src)
            => src != 0 ? (char)src : 'e';

        /// <summary>
        /// Producuces text in the form {'i' | 'u' | 'f'}
        /// </summary>
        /// <param name="src">The source kind</param>
        public static string Format(this NumericIndicator src)
            => src.ToChar().ToString();                 

        /// <summary>
        /// Produces text in the form {width}{indicator}
        /// </summary>
        /// <param name="k">The source kind</param>
        public static string Format(this NumericKind k)
            => $"{k.Width()}{k.Indicator().Format()}";            
    }    
}