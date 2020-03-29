//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;

    public static partial class PermX
    {                
        /// <summary>
        /// Deconstructs a permutation literal into an odered sequence of symbols that define the permutation
        /// </summary>
        /// <param name="src">The perm literal</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> Symbols(this Perm4L src)
            => Z0.Permute.symbols(src);

        /// <summary>
        /// Deconstructs a permutation literal into an odered sequence of symbols that define the permutation
        /// </summary>
        /// <param name="src">The perm literal</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> Symbols(this Perm8L src)
            => Z0.Permute.symbols(src);

        /// <summary>
        /// Deconstructs a permutation literal into an odered sequence of symbols that define the permutation
        /// </summary>
        /// <param name="src">The perm literal</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> Symbols(this Perm16L src)
            => Z0.Permute.symbols(src);

        /// <summary>
        /// Deconstructs a permutation literal into an odered sequence of symbols that define the permutation
        /// </summary>
        /// <param name="src">The perm literal</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> Symbols(this Perm2x4 src)
            => Z0.Permute.symbols(src);

        /// <summary>
        /// Determines whether a permutation literal is a symbol
        /// </summary>
        /// <param name="src">The value to inspect</param>
        [MethodImpl(Inline)]
        public static bit IsSymbol(this Perm4L src)
            => (byte)src <= 3;

        /// <summary>
        /// Determines whether a permutation literal is a symbol
        /// </summary>
        /// <param name="src">The value to inspect</param>
        [MethodImpl(Inline)]
        public static bit IsSymbol(this Perm8L src)
            => (uint)src <= 7;

        /// <summary>
        /// Determines whether a permutation literal is a symbol
        /// </summary>
        /// <param name="src">The value to inspect</param>
        [MethodImpl(Inline)]
        public static bit IsSymbol(this Perm16L src)
            => (ulong)src <= 15;
    }
}