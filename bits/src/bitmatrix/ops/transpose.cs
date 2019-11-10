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
        /// Transposes an 8x8 bitmatrix
        /// </summary>
        /// <param name="A"></param>
        /// <param name="Z"></param>
        /// <remarks>Code adapted from Hacker's Delight</remarks>
        [MethodImpl(Inline)]
        public static ref BitMatrix8 transpose(BitMatrix8 A, ref BitMatrix8 Z)
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

        public static ref BitMatrix<N8,N16,uint> transpose(this ref BitMatrix<N8,N16,uint> A)
        {
            var vec = ginx.vload(n128,A.Bytes);
            ginx.vstore(dinx.vshuffle(vec, Tr8x16Mask), ref head(A.Bytes));
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