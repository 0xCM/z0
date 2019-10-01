//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;
    using static As;

    partial class BitMatrix
    {
        [MethodImpl(Inline)]
        public static BitMatrix8 flip(BitMatrix8 src)
             => BitMatrix8.From(BitConverter.GetBytes((~(ulong)src)));

        [MethodImpl(Inline)]
        public static BitMatrix16 flip(BitMatrix16 src)
        {
            src.GetCells(out Vec256<ushort> vSrc);
            dinx.vflip(vSrc).StoreTo(ref src.Data[0]);
            return src;
        }

        public static BitMatrix32 flip(BitMatrix32 A)
        {
            const int rowstep = 8;
            var dst = BitMatrix32.Alloc();
            for(var i=0; i< A.RowCount; i += rowstep)
            {
                var x1 = vload256(ref A[i]);
                dinx.vflip(in x1).StoreTo(ref dst[i]);
            }
            return dst;
        }

        public static ref BitMatrix64 flip(ref BitMatrix64 A)
        {
            const int rowstep = 4;
            for(var i=0; i< A.RowCount; i += rowstep)
            {
                A.GetCells(i, out Vec256<ulong> vSrc);
                dinx.vflip(vSrc).StoreTo(ref A[i]);
            }
            return ref A;
        }

        [MethodImpl(Inline)]
        public static BitMatrix64 flip(BitMatrix64 A)
        {
            var dst = A.Replicate();
            return flip(ref dst);
        }

        /// <summary>
        /// Computes the bitwise compliement of entries in the source matrix and stores the
        /// result a caller-supplied target matrix
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="B">The target matrix</param>
        /// <typeparam name="N">The col dimension type</typeparam>
        /// <typeparam name="T">The matrix storage type</typeparam>
        [MethodImpl(Inline)]
        public static ref BitMatrix<N,T> flip<N,T>(in BitMatrix<N,T> A, ref BitMatrix<N,T> B)        
            where N : ITypeNat, new()
            where T : unmanaged
        {
            mathspan.flip(A.Data, B.Data);
            return ref B;
        }

        /// <summary>
        /// Computes the bitwise compliement of entries in the source matrix and stores the
        /// result to a caller-supplied target matrix
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="B">The target matrix</param>
        /// <typeparam name="M">The row dimension type</typeparam>
        /// <typeparam name="N">The col dimension type</typeparam>
        /// <typeparam name="T">The matrix storage type</typeparam>
        [MethodImpl(Inline)]
        public static ref BitMatrix<M,N,T> flip<M,N,T>(in BitMatrix<M,N,T> A, ref BitMatrix<M,N,T> B)        
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged
        {
            mathspan.flip(A.Data,B.Data);
            return ref B;
        }


    }

}