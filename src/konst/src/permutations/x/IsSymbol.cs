//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
     using System;
     using System.Runtime.CompilerServices;

     using static Konst;

    [ApiHost(ApiNames.PermSymbolicX, true)]
    public static partial class XPermSymbolic
    {
        /// <summary>
        /// Determines whether a permutation literal is a symbol
        /// </summary>
        /// <param name="src">The value to inspect</param>
        [MethodImpl(Inline), Op]
        public static bool IsSymbol(this Perm4L src)
            => PermSymbolic.test(src);

        /// <summary>
        /// Determines whether a permutation literal is a symbol
        /// </summary>
        /// <param name="src">The value to inspect</param>
        [MethodImpl(Inline), Op]
        public static bool IsSymbol(this Perm8L src)
            => PermSymbolic.test(src);

        /// <summary>
        /// Determines whether a permutation literal is a symbol
        /// </summary>
        /// <param name="src">The value to inspect</param>
        [MethodImpl(Inline), Op]
        public static bool IsSymbol(this Perm16L src)
            => PermSymbolic.test(src);
    }
}