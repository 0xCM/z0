//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    public static class BitMatrixX
    {   
        /// <summary>
        /// Loads a generic bitmatrix from size-conformant sequence of row bits
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <typeparam name="T">The primal data type</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<T> ToBitMatrix<T>(this RowBits<T> src)
            where T : unmanaged
                => BitMatrix.from(src);

        [MethodImpl(Inline)]
        public static BitMatrix<N,T> AsSquare<N,T>(this BitMatrix<N,N,T> src)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                    => BitMatrix.load<N,T>(src.Data);                    

        [MethodImpl(Inline)]
        public static RowBits<T> ToRowBits<T>(this BitMatrix<T> src)
            where T : unmanaged
                => RowBits.load(src.Data);

        /// <summary>
        /// Exracts a contiguous bitstring that captures the defined matrix
        /// </summary>
        public static BitString ToBitString<M,N,T>(this BitMatrix<M,N,T> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged

        {
            Span<byte> bits = stackalloc byte[src.RowCount*src.ColCount];
            for(var i=0;i<src.RowCount; i++)
                src[i].ToBitString().BitSeq.CopyTo(bits.Slice(i*src.ColCount));
            return BitString.fromseq(bits);                            
        }

        [MethodImpl(Inline)]
        public static Span<byte> Pack<M,N,T>(this BitMatrix<M,N,T> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.ToBitString().ToPackedBytes();
    }
}