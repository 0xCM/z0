//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static As;

    partial class XTend
    {   
        /// <summary>
        /// Constructs the sequence of permutation symbols corresponding to the canonical literal representation
        /// </summary>
        /// <param name="src">The canonical literal representation of a 4-symbol permutation</param>
        [MethodImpl(Inline)]
        public static Span<Perm4L> Literals(this Perm4L src)
            => Symbolic.literals(src);

        /// <summary>
        /// Constructs the sequence of permutation symbols corresponding to the canonical literal representation
        /// </summary>
        /// <param name="src">The canonical literal representation of a 8-symbol permutation</param>
        [MethodImpl(Inline)]
        public static Span<Perm8L> Literals(this Perm8L src)
            => Symbolic.literals(src);

        /// <summary>
        /// Constructs the sequence of permutation symbols corresponding to the canonical literal representation
        /// </summary>
        /// <param name="src">The canonical literal representation of a 16-symbol permutation</param>
        [MethodImpl(Inline)]
        public static Span<Perm16L> Literals(this Perm16L src)
            => Symbolic.literals(src);        
    }
}