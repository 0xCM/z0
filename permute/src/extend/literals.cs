//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public static partial class PermX
    {                
        /// <summary>
        /// Constructs the sequence of permutation symbols corresponding to the canonical literal representation
        /// </summary>
        /// <param name="src">The canonical literal representation of a 4-symbol permutation</param>
        [MethodImpl(Inline)]
        public static Span<Perm4L> Literals(this Perm4L src)
            => Z0.Permute.literals(src);

        /// <summary>
        /// Constructs the sequence of permutation symbols corresponding to the canonical literal representation
        /// </summary>
        /// <param name="src">The canonical literal representation of a 8-symbol permutation</param>
        [MethodImpl(Inline)]
        public static Span<Perm8L> Literals(this Perm8L src)
            => Z0.Permute.literals(src);

        /// <summary>
        /// Constructs the sequence of permutation symbols corresponding to the canonical literal representation
        /// </summary>
        /// <param name="src">The canonical literal representation of a 16-symbol permutation</param>
        [MethodImpl(Inline)]
        public static Span<Perm16L> Literals(this Perm16L src)
            => Z0.Permute.literals(src);        

        /// <summary>
        /// Constructs the canonical literal representation of a natural permutation on 4 symbols
        /// </summary>
        /// <param name="src">The natural permutation</param>
        [MethodImpl(Inline)]
        public static Perm4L ToLiteral(this NatPerm<N4> src)
            => Z0.Permute.literal(src);

        /// <summary>
        /// Constructs the canonical literal representation of a natural permutation on 8 symbols
        /// </summary>
        /// <param name="src">The natural permutation</param>
        [MethodImpl(Inline)]
        public static Perm8L ToLiteral(this NatPerm<N8> src)
            => Z0.Permute.literal(src);

        /// <summary>
        /// Constructs the canonical literal representation of a natural permutation on 16 symbols
        /// </summary>
        /// <param name="src">The natural permutation</param>
        [MethodImpl(Inline)]
        public static Perm16L ToLiteral(this NatPerm<N16> src)
            => Z0.Permute.literal(src);
    }
}