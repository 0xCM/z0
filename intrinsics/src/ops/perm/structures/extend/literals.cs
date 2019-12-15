//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;    

    public static partial class PermX
    {                

        /// <summary>
        /// Constructs the sequence of permutation symbols corresponding to the canonical literal representation
        /// </summary>
        /// <param name="src">The canonical literal representation of a 4-symbol permutation</param>
        [MethodImpl(Inline)]
        public static Span<Perm4> Literals(this Perm4 src)
            => Perm.literals(src);

        /// <summary>
        /// Constructs the sequence of permutation symbols corresponding to the canonical literal representation
        /// </summary>
        /// <param name="src">The canonical literal representation of a 8-symbol permutation</param>
        [MethodImpl(Inline)]
        public static Span<Perm8> Literals(this Perm8 src)
            => Perm.literals(src);

        /// <summary>
        /// Constructs the sequence of permutation symbols corresponding to the canonical literal representation
        /// </summary>
        /// <param name="src">The canonical literal representation of a 16-symbol permutation</param>
        [MethodImpl(Inline)]
        public static Span<Perm16> Literals(this Perm16 src)
            => Perm.literals(src);        

        /// <summary>
        /// Constructs the canonical literal representation of a natural permutation on 4 symbols
        /// </summary>
        /// <param name="src">The natural permutation</param>
        [MethodImpl(Inline)]
        public static Perm4 ToLiteral(this NatPerm<N4> src)
            => Perm.literal(src);

        /// <summary>
        /// Constructs the canonical literal representation of a natural permutation on 8 symbols
        /// </summary>
        /// <param name="src">The natural permutation</param>
        [MethodImpl(Inline)]
        public static Perm8 ToLiteral(this NatPerm<N8> src)
            => Perm.literal(src);

        /// <summary>
        /// Constructs the canonical literal representation of a natural permutation on 16 symbols
        /// </summary>
        /// <param name="src">The natural permutation</param>
        [MethodImpl(Inline)]
        public static Perm16 ToLiteral(this NatPerm<N16> src)
            => Perm.literal(src);

    }

}