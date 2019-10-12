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
        public static ref BitMatrix<N8,N16,uint> Transpose(this ref BitMatrix<N8,N16,uint> A)
        {
            var vec = Vec128.Load(ref head(A.Bytes));
            vstore(dinx.vshuffle(in vec, Tr8x16Mask), ref head(A.Bytes));
            return ref A;
        }

        public static BitMatrix8 transpose(in BitMatrix8 A)
        {
            var src = (ulong)A;
            var B = BitMatrix8.Alloc();
            for(var i=0; i<8; i++)
            {
                B[i] = (byte)BitParts.select(src, BitMask64.Lsb8);
                src >>= 1;
            }
            
            return B;
        }

        static Vec128<byte> Tr8x16Mask
        {
            [MethodImpl(Inline)]
            get => Vec128.Load(ref As.asRef(in Tr8x16MaskBytes[0]));
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