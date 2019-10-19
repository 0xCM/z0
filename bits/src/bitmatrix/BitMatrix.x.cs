//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Diagnostics;

    using static zfunc;

    public static partial class BitMatrixX
    {   
        /// <summary>
        /// Converts the matrix to a bitvector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitvector(this BitMatrix8 A)
            => A.Data.AsUInt64()[0];

        /// <summary>
        /// Converts the matrix to a bitvector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector<N256,ushort> ToBitvector(this BitMatrix16 A)
            => BitVector.Load(A.Data, n256);

        /// <summary>
        /// Converts the matrix to a bitvector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector<N1024,uint> ToBitvector(this BitMatrix32 A)
            => BitVector.Load(A.Data, n1024);

        /// <summary>
        /// Converts the matrix to a bitvector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector<N4096,ulong> ToBitvector(this BitMatrix64 A)
            => BitVector.Load(A.Data, n4096);

        /// <summary>
        /// Creates the matrix determined by a permutation
        /// </summary>
        /// <param name="perm">The source permutation</param>
        [MethodImpl(Inline)]
        public static BitMatrix8 ToBitMatrix(this Perm<N8> perm)
        {
            var dst = BitMatrix8.Alloc();
            for(var row = 0; row<perm.Length; row++)
                dst[row, perm[row]] = Bit.On;
            return dst;
        }

        /// <summary>
        /// Creates the matrix determined by a permutation
        /// </summary>
        /// <param name="perm">The source permutation</param>
        [MethodImpl(Inline)]
        public static BitMatrix16 ToBitMatrix(this Perm<N16> perm)
        {
            var dst = BitMatrix16.Alloc();
            for(var row = 0; row<perm.Length; row++)
                dst[row,perm[row]] = Bit.On;
            return dst;
        }

        /// <summary>
        /// Creates the matrix determined by a permutation
        /// </summary>
        /// <param name="src">The source permutation</param>
        [MethodImpl(Inline)]
        public static BitMatrix32 ToBitMatrix(this Perm<N32> perm)
        {
            var dst = BitMatrix32.Alloc();
            for(var row = 0; row<perm.Length; row++)
                dst[row,perm[row]] = Bit.On;
            return dst;
        }

        /// <summary>
        /// Creates the matrix determined by a permutation
        /// </summary>
        /// <param name="perm">The source permutation</param>
        [MethodImpl(Inline)]
        public static BitMatrix64 ToBitMatrix(this Perm<N64> perm)            
        {
            var dst = BitMatrix64.Alloc();
            for(var row = 0; row<perm.Length; row++)
                dst[row,perm[row]] = Bit.On;
            return dst;
        }

        internal static string FormatMatrixBits(this Span<byte> src, int rowlen)            
        {
            var dst = gbits.bitchars(src);
            var sb = sbuild();
            for(var i=0; i<dst.Length; i+= rowlen)
            {
                var remaining = dst.Length - i;
                var segment = math.min(remaining, rowlen);
                var rowbits = dst.Slice(i, segment);
                var row = new string(rowbits.Intersperse(AsciSym.Space));                                
                sb.AppendLine(row);
            }
            return sb.ToString();
        }       

        [MethodImpl(Inline)]
        internal static string FormatMatrixBits(this Span<ushort> src, int rowlen)            
            => src.AsBytes().FormatMatrixBits(rowlen);

        [MethodImpl(Inline)]
        internal static string FormatMatrixBits(this Span<uint> src, int rowlen)            
            => src.AsBytes().FormatMatrixBits(rowlen);


        [MethodImpl(Inline)]
        internal static string FormatMatrixBits(this Span<ulong> src, int rowlen)            
            => src.AsBytes().FormatMatrixBits(rowlen);
                
        /// <summary>
        /// Part of a pattern to do cross-lane 256-bit shuffles
        /// </summary>
        /// <remarks> See https://stackoverflow.com/questions/30669556/shuffle-elements-of-m256i-vector</remarks>
        static ReadOnlySpan<byte> Tr16x16A => new byte[]
        {
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 
            0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0        
        };

        static ReadOnlySpan<byte> Tr16x16B => new byte[]
        {
            0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 
            0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70        
        };
    }
}