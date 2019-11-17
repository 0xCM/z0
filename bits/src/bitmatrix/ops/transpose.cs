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
        /// Queries the matrix for the data in an index-identified column 
        /// </summary>
        /// <param name="index">The row index</param>
        public static BitVector4 column(in BitMatrix4 A, int index)
        {
            byte col = 0;
            for(var r = 0; r < BitMatrix4.N; r++)
                BitMask.set(ref col, (byte)r, BitMask.test(A[r], index));
            return col;
        }

        /// <summary>
        /// Transposes a copy of the matrix
        /// </summary>
        public static BitMatrix4 transpose(in BitMatrix4 A)
        {        
            var B = A.Replicate();
            for(var i=0; i<BitMatrix4.N; i++)                
                B[i] = column(A,i);

            return B;
        }

        [MethodImpl(Inline)]
        public static ref BitMatrix8 transpose(in BitMatrix8 A, ref BitMatrix8 Z)
        {
            var x = dinx.vscalar((ulong)A);
            for(var i=7; i>= 0; i--)
            {
                Z[i] = (byte)dinx.vmovemask(v8u(x));
                x = dinx.vsll(x,1);
            }
            return ref Z;
        }
        
        [MethodImpl(Inline)]
        public static BitMatrix8 transpose(in BitMatrix8 A)
        {
            var n = n8;
            var src = (ulong)A;
            var dst = 0ul;
            for(var i=0; i<8; i++)
            {
                dst |= (Bits.gather(src, BitMask.Lsb64x8) << i*8);
                src >>= 1;
            }
            return (BitMatrix8)dst;
        }

        /// <summary>
        /// Transposes an 8x8 bitmatrix
        /// </summary>
        /// <param name="A"></param>
        /// <param name="Z"></param>
        /// <remarks>Code adapted from Hacker's Delight</remarks>
        [MethodImpl(Inline)]
        public static ref BitMatrix8 transpose_v3(BitMatrix8 A, ref BitMatrix8 Z)
        {
            var src = (ulong)A;
            var t = (src ^ (src >> 7)) & 0x00AA00AA00AA00AAul;
            src = src ^ t ^ (t << 7);
            t = (src ^ (src >> 14)) & 0x0000CCCC0000CCCCul;
            src = src ^ t ^ (t << 14);
            t = (src ^ (src >> 28)) & 0x00000000F0F0F0F0ul;
            src = src ^ t ^ (t << 28);
            bytes(src).CopyTo(Z.Bytes);
            return ref Z;
        }

        public static BitMatrix16 transpose(in BitMatrix16 A)
        {
            var dst = A.Replicate();
            for(var i=0; i< BitMatrix16.N; i++)
                dst[i] = A.ColData(i);
            return dst;
        }

        public static BitMatrix<N16,N8,uint> transpose(in BitMatrix<N8,N16,uint> A)
        {
            var vec = ginx.vload(n128,A.Bytes);
            ginx.vstore(dinx.vshuf16x8(vec, Tr8x16Mask), ref head(A.Bytes));
            return BitMatrix.load<N16,N8,uint>(A.Data);
        }


        static Vec128<byte> Tr8x16Mask
        {
            [MethodImpl(Inline)]
            get => ginx.vload(n128,in head(Tr8x16MaskBytes));
        }

        /// <summary>
        ///  When used as a mask for _mm_shuffle_epi8, transposes a 8x16 bitmatrix
        /// </summary>
        static ReadOnlySpan<byte> Tr8x16MaskBytes => new byte[]
        {
            0, 4, 8, 12,
            1, 5, 9, 13,
            2, 6, 10, 14,
            3, 7, 11, 15
        };

    }
}