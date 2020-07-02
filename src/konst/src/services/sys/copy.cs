//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static System.Runtime.CompilerServices.Unsafe;
    
    using static OpacityKind;

    using O = OpacityKind;

    partial struct sys
    {
        [MethodImpl(Options), Opaque(O.CopyBlock)]
        public static void copy(in byte src, ref byte dst, uint count)
            => CopyBlock(ref dst, ref AsRef(src), count);

        [MethodImpl(Options), Opaque(O.CopyBlock)]
        public static unsafe void copy(byte* pSrc, byte* pDst, uint count)
            => CopyBlock(pDst, pSrc, count);

        [MethodImpl(Options), Opaque(O.CopyBlock)]
        public static unsafe void copy<T>(T* pSrc, T* pDst, uint count)
            where T : unmanaged
                => CopyBlock(pDst, pSrc, count* (uint)SizeOf<T>());

        /// <summary>
        /// Copies a reference-identified cell to a pointer-identified target
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="pDst">The target</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Options), Opaque(O.CopyCellToVoidPointer)]
        public static unsafe void copy<T>(in T src, void* pDst)
            => Copy(pDst, ref AsRef(src));   

        /// <summary>
        /// Copies a reference-identified T-cell of unmanaged kind to a T-pointer-identified target
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="pDst">The target</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Options), Opaque(O.CopyCellToGenericPointer)]
        public static unsafe void copy<T>(in T src, T* pDst)
            where T : unmanaged
                => Copy(pDst, ref AsRef(src));   

        [MethodImpl(Options), Opaque(CopySpan), Closures(Closure)]
        public static ref readonly Span<T> copy<T>(ReadOnlySpan<T> src, in Span<T> dst)
        {
            src.CopyTo(dst);
            return ref dst;
        }
    }
}