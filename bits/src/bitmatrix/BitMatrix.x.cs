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
        public static BitVector<N256,ushort> ToBitVector(this BitMatrix16 A)
            => BitVector.natural(A.Data, n256);

        /// <summary>
        /// Converts the matrix to a bitvector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector<N1024,uint> ToBitVector(this BitMatrix32 A)
            => BitVector.natural(A.Data, n1024);


        /// <summary>
        /// Converts the matrix to a bitvector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector<N4096,ulong> ToBitVector(this BitMatrix64 A)
            => BitVector.natural(A.Data, n4096);

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
            var dst = BitMatrix.alloc(n32);
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

        /// <summary>
        /// Converts the source matrix to a square matrix of natural order
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix<N8,byte> ToNatural(this BitMatrix8 A)
            => BitMatrix.load(n8,A.Data);

        /// <summary>
        /// Converts the source matrix to a square matrix of natural order
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix<N8,byte> ToNatural(this BitMatrix<byte> A)
            => BitMatrix.load(n8,A.Data);

        /// <summary>
        /// Converts the source matrix to a square matrix of natural order
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix<N16,ushort> ToNatural(this BitMatrix16 A)
            => BitMatrix.load(n16,A.Data);

        /// <summary>
        /// Converts the source matrix to a square matrix of natural order
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix<N16,ushort> ToNatural(this BitMatrix<ushort> A)
            => BitMatrix.load(n16,A.Data);

        /// <summary>
        /// Converts the source matrix to a square matrix of natural order
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix<N32,uint> ToNatural(this BitMatrix32 A)
            => BitMatrix.load(n32,A.Data);

        /// <summary>
        /// Converts the source matrix to a square matrix of natural order
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix<N32,uint> ToNatural(this BitMatrix<uint> A)
            => BitMatrix.load(n32,A.Data);

        /// <summary>
        /// Converts the source matrix to a square matrix of natural order
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix<N64,ulong> ToNatural(this BitMatrix64 A)
            => BitMatrix.load(n64,A.Data);

        /// <summary>
        /// Converts the source matrix to a square matrix of natural order
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix<N64,ulong> ToNatural(this BitMatrix<ulong> A)
            => BitMatrix.load(n64,A.Data);

        [MethodImpl(Inline)]
        public static BitMatrix<N,T> AsSquare<N,T>(this BitMatrix<N,N,T> src)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                    => BitMatrix.load<N,T>(src.Data);
                    
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
        internal static string FormatMatrixBits<T>(this Span<T> src)
            where T : unmanaged
                => src.AsBytes().FormatMatrixBits(bitsize<T>());

        [MethodImpl(Inline)]
        internal static string FormatMatrixBits<T>(this Span<T> src, int rowlen)
            where T : unmanaged
                => src.AsBytes().FormatMatrixBits(rowlen);

        [MethodImpl(Inline)]
        internal static string FormatMatrixBits(this byte[] src, int rowlen)            
            => src.AsSpan().FormatMatrixBits(rowlen);


        [MethodImpl(Inline)]
        internal static string FormatMatrixBits(this uint[] src, int rowlen)            
            => src.AsSpan().AsBytes().FormatMatrixBits(rowlen);

        [MethodImpl(Inline)]
        internal static string FormatMatrixBits(this ulong[] src, int rowlen)            
            => src.AsSpan().AsBytes().FormatMatrixBits(rowlen);

        [MethodImpl(Inline)]
        public static string Format<T>(this BitMatrix<T> src)
            where T : unmanaged
                => src.Data.FormatMatrixBits();

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
            return BitString.FromBitSeq(bits);                            
        }

        [MethodImpl(Inline)]
        public static Span<byte> Pack<M,N,T>(this BitMatrix<M,N,T> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.ToBitString().ToPackedBytes();

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