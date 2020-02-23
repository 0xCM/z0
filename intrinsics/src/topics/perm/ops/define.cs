//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    

    partial class permute
    {
        /// <summary>
        /// Defines an untyped permutation determined by values in a source span
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]
        public static Perm define(ReadOnlySpan<int> src)
            => new Perm(src.ToArray());

        /// <summary>
        /// Creates a permutation from the elements in a readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The integral type</typeparam>
        [MethodImpl(Inline)]
        public static Perm<T> define<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => new Perm<T>(src.ToArray());

        /// <summary>
        /// Creates a permutation from the elements in a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The integral type</typeparam>
        [MethodImpl(Inline)]
        public static Perm<T> define<T>(Span<T> src)
            where T : unmanaged
            => new Perm<T>(src);

        /// <summary>
        /// Creates a permutation from the elements in a parameter array
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="T">The integral type</typeparam>
        [MethodImpl(Inline)]
        public static Perm<T> define<T>(params T[] src)
            where T : unmanaged
            => new Perm<T>(src);

        [MethodImpl(Inline)]
        public static Perm16 define(N16 n, Vector128<byte> data)
            => Perm16.from(data);

        [MethodImpl(Inline)]
        public static Perm16 define(NatPerm<N16,byte> spec)
            => Perm16.from(spec);

        [MethodImpl(Inline)]
        public static Perm32 define(N32 n, Vector256<byte> data)
            => Perm32.from(data);

        [MethodImpl(Inline)]
        public static Perm32 define(NatPerm<N32,byte> spec)
            => Perm32.from(spec);
    }
}