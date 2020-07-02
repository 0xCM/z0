//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
            
    using static Konst;
    using static OpacityKind;
    
    partial struct sys
    {
        /// <summary>
        /// Tests whether the source string is nonempty
        /// </summary>
        /// <param name="src">The string to evaluate</param>
        [MethodImpl(Options), Opaque(EmptyStringTest)]
        public static bool nonempty(string src)
            => !string.IsNullOrWhiteSpace(src);

        /// <summary>
        /// Tests whether the source string is empty
        /// </summary>
        /// <param name="src">The string to evaluate</param>
        [MethodImpl(Options), Opaque(EmptyStringTest)]
        public static bool empty(string src)
            => string.IsNullOrWhiteSpace(src);
    }
}