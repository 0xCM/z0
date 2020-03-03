//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static Root;
    using static Vectors;

    partial class VectorExtensions
    {
        /// <summary>
        /// Loads a 128-bit vector from a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vector128<T> LoadVector<T>(this Span<T> src, N128 n, int offset = 0)
            where T : unmanaged            
                => vload(n, src, offset);

        /// <summary>
        /// Loads a 256-bit vector from a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vector256<T> LoadVector<T>(this Span<T> src, N256 n, int offset = 0)
            where T : unmanaged            
                => vload(n, src, offset);

        /// <summary>
        /// Loads a 512-bit vector from a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vector512<T> LoadVector<T>(this Span<T> src, N512 n, int offset = 0)
            where T : unmanaged            
                => vload(n, src, offset);

        /// <summary>
        /// Loads a 128-bit vector from a readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vector128<T> LoadVector<T>(this ReadOnlySpan<T> src, N128 n, int offset = 0)
            where T : unmanaged            
                => vload(n, src, offset);

        /// <summary>
        /// Loads a 256-bit vector from a readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vector256<T> LoadVector<T>(this ReadOnlySpan<T> src, N256 n, int offset = 0)
            where T : unmanaged            
                => vload(n, src, offset);

        /// <summary>
        /// Loads a 512-bit vector from a readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vector512<T> LoadVector<T>(this ReadOnlySpan<T> src, N512 n, int offset = 0)
            where T : unmanaged            
                => vload(n, src, offset);

        /// <summary>
        /// Loads a 128-bit vector from the first 128-bit block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> LoadVector<T>(this in Block128<T> src)            
            where T : unmanaged            
                => vload(src, 0);

        /// <summary>
        /// Loads a block-identified 128-bit vector
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> LoadVector<T>(this in Block128<T> src, int block)            
            where T : unmanaged            
                => vload(src, block);

        /// <summary>
        /// Loads 2 block-indexed 128-bit vectors
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block1">The block index of the first vector</param>
        /// <param name="block2">The block index of the second vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static ConstPair<Vector128<T>> LoadVectors<T>(this in Block128<T> src, int block1, int block2)            
            where T : unmanaged            
                => (vload(src, block1), vload(src, block2));

        /// <summary>
        /// Loads 3 block-indexed 128-bit vectors
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block1">The block index of the first vector</param>
        /// <param name="block2">The block index of the second vector</param>
        /// <param name="block3">The block index of the third vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static ConstTriple<Vector128<T>> LoadVectors<T>(this in Block128<T> src, int block1, int block2, int block3)            
            where T : unmanaged            
                => (vload(src, block1), vload(src, block2), vload(src, block3));

        /// <summary>
        /// Loads a 256-bit vector from the first 256-bit block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> LoadVector<T>(this in Block256<T> src)            
            where T : unmanaged            
                => vload(src);

        /// <summary>
        /// Loads 2 block-indexed 256-bit vectors
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block1">The block index of the first vector</param>
        /// <param name="block2">The block index of the second vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static ConstPair<Vector256<T>> LoadVectors<T>(this in Block256<T> src, int block1, int block2)            
            where T : unmanaged            
                => (vload(src, block1), vload(src, block2));

        /// <summary>
        /// Loads 3 block-indexed 256-bit vectors
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block1">The block index of the first vector</param>
        /// <param name="block2">The block index of the second vector</param>
        /// <param name="block3">The block index of the third vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static ConstTriple<Vector256<T>> LoadVectors<T>(this in Block256<T> src, int block1, int block2, int block3)            
            where T : unmanaged            
                => (vload(src, block1), vload(src, block2), vload(src, block3));

        /// <summary>
        /// Loads a 512-bit vector from the first 512-bit block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vector512<T> LoadVector<T>(this in Block512<T> src)            
            where T : unmanaged            
                => vload(src);

        /// <summary>
        /// Loads a 256-bit vector from an index-identified block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> LoadVector<T>(this in Block256<T> src, int block)            
            where T : unmanaged            
                => vload(src,block);

        /// <summary>
        /// Loads 512-bit vector from an index-identified block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vector512<T> LoadVector<T>(this in Block512<T> src, int block)            
            where T : unmanaged            
                => vload(src,block);
    }
}
