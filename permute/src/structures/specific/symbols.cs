//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static root;    

    partial class Permute
    {        
        /// <summary>
        /// Deconstructs a permutation literal into an ordered sequence of symbols that define the permutation
        /// </summary>
        /// <param name="src">The perm literal</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> symbols(Perm4L src)
            => Permute.symbols<Perm4Sym,byte>((byte)src,2);

        /// <summary>
        /// Deconstructs a permutation literal into an ordered sequence of symbols that define the permutation
        /// </summary>
        /// <param name="src">The perm literal</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> symbols(Perm8L src)
            => Permute.symbols<Perm8Sym,uint>((uint)src,3,24);

        /// <summary>
        /// Deconstructs a permutation literal into an ordered sequence of symbols that define the permutation
        /// </summary>
        /// <param name="src">The perm literal</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> symbols(Perm16L src)
            => Permute.symbols<Perm16Sym,ulong>((ulong)src,4);

        /// <summary>
        /// Deconstructs a permutation literal into an ordered sequence of symbols that define the permutation
        /// </summary>
        /// <param name="src">The perm literal</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> symbols(Perm2x4 src)
            => Permute.symbols<Perm4Sym,byte>((byte)src,4);
    }
}