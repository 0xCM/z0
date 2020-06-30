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
        /// Determines whether a permutation literal is a symbol
        /// </summary>
        /// <param name="src">The value to inspect</param>
        [MethodImpl(Inline)]
        public static bit IsSymbol(this Perm4L src)
            => Symbolic.test(src);

        /// <summary>
        /// Determines whether a permutation literal is a symbol
        /// </summary>
        /// <param name="src">The value to inspect</param>
        [MethodImpl(Inline)]
        public static bit IsSymbol(this Perm8L src)
            => Symbolic.test(src);

        /// <summary>
        /// Determines whether a permutation literal is a symbol
        /// </summary>
        /// <param name="src">The value to inspect</param>
        [MethodImpl(Inline)]
        public static bit IsSymbol(this Perm16L src)
            => Symbolic.test(src);        
    }
}