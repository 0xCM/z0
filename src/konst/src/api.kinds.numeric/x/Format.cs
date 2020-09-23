//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XTend
    {
        /// <summary>
        /// Converts a numeric indicator to a character
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline)]
        public static char ToChar(this NumericIndicator src)
            => NumericKinds.@char(src);

        /// <summary>
        /// Produces text in the form {'i' | 'u' | 'f'}
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline)]
        public static string Format(this NumericIndicator src)
            => NumericKinds.format(src);

        /// <summary>
        /// Produces text in the form {width}{indicator}
        /// </summary>
        /// <param name="k">The source kind</param>
        [MethodImpl(Inline)]
        public static string Format(this NumericKind k)
            => NumericKinds.format(k);
    }
}