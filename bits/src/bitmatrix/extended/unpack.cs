//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class BitMatrix
    {
        /// <summary>
        /// Projects the bits of a fixed primal bitmatrix into a generic target matrix of the same order
        /// </summary>
        /// <param name="src">The source matrix</param>
        /// <param name="dst">The target metrix</param>
        /// <typeparam name="T">The element type of the target matrix</typeparam>
        [MethodImpl(Inline)]
        public static ref Matrix<N8, T> unpack<T>(BitMatrix8 src, ref Matrix<N8,T> dst)
            where T : unmanaged
        {
            gbits.unpack(src.Data, dst.Data.AsSpan());            
            return ref dst;
        }

        /// <summary>
        /// Projects the bits of a fixed primal bitmatrix into a generic target matrix of the same order
        /// </summary>
        /// <param name="src">The source matrix</param>
        /// <param name="dst">The target metrix</param>
        /// <typeparam name="T">The element type of the target matrix</typeparam>
        [MethodImpl(Inline)]
        public static Matrix<N8, T> unpack<T>(BitMatrix8 src, Matrix<N8,T> dst)
            where T : unmanaged
        {
            gbits.unpack(src.Data, dst.Data.AsSpan());            
            return dst;
        }

        /// <summary>
        /// Projects the bits of a fixed primal bitmatrix into a generic target matrix of the same order
        /// </summary>
        /// <param name="src">The source matrix</param>
        /// <param name="dst">The target metrix</param>
        /// <typeparam name="T">The element type of the target matrix</typeparam>
        [MethodImpl(Inline)]
        public static ref Matrix<N16, T> unpack<T>(BitMatrix16 src, ref Matrix<N16,T> dst)
            where T : unmanaged
        {
            gbits.unpack(src.Data, dst.Data.AsSpan());            
            return ref dst;
        }

        /// <summary>
        /// Projects the bits of a fixed primal bitmatrix into a generic target matrix of the same order
        /// </summary>
        /// <param name="src">The source matrix</param>
        /// <param name="dst">The target metrix</param>
        /// <typeparam name="T">The element type of the target matrix</typeparam>
        [MethodImpl(Inline)]
        public static ref Matrix<N32, T> unpack<T>(BitMatrix32 src, ref Matrix<N32,T> dst)
            where T : unmanaged
        {
            gbits.unpack(src.Data, dst.Data.AsSpan());            
            return ref dst;
        }

        /// <summary>
        /// Projects the bits of a fixed primal bitmatrix into a generic target matrix of the same order
        /// </summary>
        /// <param name="src">The source matrix</param>
        /// <param name="dst">The target metrix</param>
        /// <typeparam name="T">The element type of the target matrix</typeparam>
        [MethodImpl(Inline)]
        public static ref Matrix<N64, T> unpack<T>(BitMatrix64 src, ref Matrix<N64,T> dst)
            where T : unmanaged
        {
            gbits.unpack(src.Data, dst.Data.AsSpan());            
            return ref dst;
        }

   }
}