//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    

    partial class Perm
    {
        /// <summary>
        /// Defines an untyped permutation determined by values in a source span
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]
        public static PermSpec specify(ReadOnlySpan<int> src)
            => new PermSpec(src.ToArray());


        /// <summary>
        /// Creates a generic permutation by application of a sequence of transpositions to the identity permutation
        /// </summary>
        /// <param name="n">The permutation length</param>
        /// <param name="swaps">Pairs of permutation indices (i,j) to be transposed</param>
        /// <typeparam name="T">The integral type</typeparam>
        [MethodImpl(Inline)]
        public static PermSpec<T> specify<T>(T n, params (T i, T j)[] swaps)
            where T : unmanaged
                => new PermSpec<T>(n,swaps);

        /// <summary>
        /// Creates a generic permutation by application of a sequence of transpositions to the identity permutation
        /// </summary>
        /// <param name="n">The permutation length</param>
        /// <param name="swaps">Pairs of permutation indices (i,j) to be transposed</param>
        /// <typeparam name="T">The integral type</typeparam>
        [MethodImpl(Inline)]
        public static PermSpec<T> specify<T>(T n, params Swap<T>[] swaps)
            where T : unmanaged
                => new PermSpec<T>(n,swaps);

        /// <summary>
        /// Creates a permutation from the elements in a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The integral type</typeparam>
        [MethodImpl(Inline)]
        public static PermSpec<T> specify<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => new PermSpec<T>(src.ToArray());

        /// <summary>
        /// Creates a permutation from the elements in a parameter array
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="T">The integral type</typeparam>
        [MethodImpl(Inline)]
        public static PermSpec<T> specify<T>(params T[] src)
            where T : unmanaged
            => new PermSpec<T>(src);

        [MethodImpl(Inline)]
        public static Perm16Spec specify(N16 n, Vector128<byte> data)
            => Perm16Spec.from(data);

        [MethodImpl(Inline)]
        public static Perm16Spec specify(NatPerm<N16,byte> spec)
            => Perm16Spec.from(spec);

        [MethodImpl(Inline)]
        public static Perm32Spec specify(N32 n, Vector256<byte> data)
            => Perm32Spec.from(data);

        [MethodImpl(Inline)]
        public static Perm32Spec specify(NatPerm<N32,byte> spec)
            => Perm32Spec.from(spec);


    }

}