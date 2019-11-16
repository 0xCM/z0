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
        /// Interchanges span elements i and j
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="i">An index of a span element</param>
        /// <param name="j">An index of a span element</param>
        /// <typeparam name="T">The span element type</typeparam>
        [MethodImpl(Inline)]
        public static void Swap<T>(this Span<T> src, int i, int j)
            where T : unmanaged
        {
            if(i==j)
                return;
            
            ref var data = ref head(src);
            var a = seek(ref data, i);
            seek(ref data, i) = skip(in data, j);
            seek(ref data, j) = a;
        }

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
            return BitString.fromseq(bits);                            
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