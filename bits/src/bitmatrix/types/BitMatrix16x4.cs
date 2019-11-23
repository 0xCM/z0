//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static As;
    using static HexConst;

    using static zfunc;
 
    /// <summary>
    /// Defines an 16x4 bitmatrix
    /// </summary>
    public struct BitMatrix16x4
    {
        internal ulong data;

        [MethodImpl(Inline)]
        public static BitMatrix16x4 operator & (in BitMatrix16x4 A, in BitMatrix16x4 B)
            =>  BitMatrix.and(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix16x4 operator | (in BitMatrix16x4 A, in BitMatrix16x4 B)
            => BitMatrix.or(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix16x4 operator ^ (in BitMatrix16x4 A, in BitMatrix16x4 B)
            => BitMatrix.xor(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix16x4 operator << (in BitMatrix16x4 A, int rot)
            =>  BitMatrix.rotl(A,rot);

        [MethodImpl(Inline)]
        public static BitMatrix16x4 operator >> (in BitMatrix16x4 A, int rot)
            =>  BitMatrix.rotr(A,rot);

        [MethodImpl(Inline)]
        public static BitMatrix16x4 operator ~ (in BitMatrix16x4 A)
            => BitMatrix.not(A);

        [MethodImpl(Inline)]
        public static BitMatrix16x4 operator - (in BitMatrix16x4 A)
            => BitMatrix.negate(A);


        [MethodImpl(Inline)]
        public static implicit operator ulong(BitMatrix16x4 A)
            => A.data;

        [MethodImpl(Inline)]
        public static implicit operator BitMatrix16x4(ulong src)
            => new BitMatrix16x4(src);

        [MethodImpl(Inline)]
        internal BitMatrix16x4(ulong data)
            => this.data = data;        

        /// <summary>
        /// Gets/Sets the data for a row
        /// </summary>
        /// <param name="index">The row index</param>
        public BitVector4 this[int index]
        {
            [MethodImpl(Inline)]
            get => BitMatrix.row(this, index);
        }

        public BitVector16 this[N0 col]
        {
            [MethodImpl(Inline)]
            get => BitMatrix.col(this,col);
        }

        public BitVector16 this[N1 col]
        {
            [MethodImpl(Inline)]
            get => BitMatrix.col(this, col);
        }

        public BitVector16 this[N2 col]
        {
            [MethodImpl(Inline)]
            get => BitMatrix.col(this,col);
        }

        public BitVector16 this[N3 col]
        {
            [MethodImpl(Inline)]
            get => BitMatrix.col(this,col);
        }
    }

    partial class BitMatrix
    {
        [MethodImpl(Inline)]
        public static BitMatrix16x4 alloc(N16 m, N4 n)        
            => default;

        [MethodImpl(Inline)]
        public static BitMatrix16x4 define(N16 m, N4 n, ulong data)
            => data;

        [MethodImpl(Inline)]
        public static BitMatrix16x4 not(BitMatrix16x4 A)        
            => math.not(A);

        [MethodImpl(Inline)]
        public static BitMatrix16x4 negate(BitMatrix16x4 A)        
            => math.negate(A);

        [MethodImpl(Inline)]
        public static BitMatrix16x4 inc(BitMatrix16x4 A)        
            => math.inc(A);

        [MethodImpl(Inline)]
        public static BitMatrix16x4 dec(BitMatrix16x4 A)        
            => math.dec(A);

        [MethodImpl(Inline)]
        public static BitMatrix16x4 and(BitMatrix16x4 A, BitMatrix16x4 B)        
            => math.and(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix16x4 or(BitMatrix16x4 A, BitMatrix16x4 B)        
            => math.or(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix16x4 xor(BitMatrix16x4 A, BitMatrix16x4 B)        
            => math.xor(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix16x4 rotr(BitMatrix16x4 A, int shift)        
            => Bits.rotr(A,shift);

        [MethodImpl(Inline)]
        public static BitMatrix16x4 rotl(BitMatrix16x4 A, int shift)        
            => Bits.rotl(A,shift);

        [MethodImpl(Inline)]
        public static uint pop(BitMatrix16x4 A)
            => Bits.pop(A);

        [MethodImpl(Inline)]
        public static BitVector4 row(BitMatrix16x4 A, int index)
            => BitVector.direct(n4, Bits.extract((ulong)A,(byte)(index*4), 4));

        [MethodImpl(Inline)]
        public static BitVector16 col<N>(BitMatrix16x4 A, N n = default)
            where N : unmanaged, ITypeNat
        {
            if(typeof(N) == typeof(N0))
                return col(A,n0);
            else if (typeof(N) == typeof(N1))
                return col(A,n1);
            else if (typeof(N) == typeof(N2))
                return col(A,n2);
            else if (typeof(N) == typeof(N3))
                return col(A,n3);
            else
                return default;
        }

        [MethodImpl(Inline)]
        public static BitMatrix4x16 transpose(BitMatrix16x4 A)
            => BitMatrix.define(n4,n16, ((ulong)col(A,n0) << 0) | ((ulong)col(A,n1) << 16) | ((ulong)col(A,n2) << 32) | ((ulong)col(A,n3) << 48));

        // [MethodImpl(Inline)]
        // public static BitGrid<N4,N16,ulong> transpose(BitMatrix16x4 A)
        //     => BitGrid.load(n4,n16, ((ulong)col(A,n0) << 0) | ((ulong)col(A,n1) << 16) | ((ulong)col(A,n2) << 32) | ((ulong)col(A,n3) << 48));

        // [0001 0001 ... 0001]
        const ulong C0 = 
            (1ul << 64 - 1*4) | (1ul << 64 - 2*4) | (1ul << 64 - 3*4) | (1ul << 64 - 4*4) | 
            (1ul << 64 - 5*4) | (1ul << 64 - 6*4) | (1ul << 64 - 7*4) | (1ul << 64 - 8*4) |
            (1ul << 64 - 9*4) | (1ul << 64 - A*4) | (1ul << 64 - B*4) | (1ul << 64 - C*4) |
            (1ul << 64 - D*4) | (1ul << 64 - E*4) | (1ul << 64 - F*4) | 1;
        
        // [0010 0010 ... 0010]
        const ulong C1 = (C0 << 1);
        
        // [0100 0100 ... 0100]
        const ulong C2 = (C0 << 2);
        
        // [1000 1000 ... 1000]
        const ulong C3 = (C0 << 3);

        [MethodImpl(Inline)]
        static BitVector16 col(BitMatrix16x4 A, N0 index)
            => BitVector.from(n16, Bits.gather(A,C0));

        [MethodImpl(Inline)]
        static BitVector16 col(BitMatrix16x4 A, N1 index)
            => BitVector.from(n16,Bits.gather(A,C1));

        [MethodImpl(Inline)]
        static BitVector16 col(BitMatrix16x4 A, N2 index)
            => BitVector.from(n16,Bits.gather(A,C2));

        [MethodImpl(Inline)]
        static BitVector16 col(BitMatrix16x4 A, N3 index)
            => BitVector.from(n16,Bits.gather(A,C3));

        /*
        0 | 0 1 2 3
        1 | 4 5 6 7
        2 | 8 9 A B
        3 | C D E F
        width = 4
        Col 0 = [... | C | 8 | 4 | 0] = [width*row + cidx] , cidx = 0 .. 15        
        Col 0 Mask = [ ... 0001 | 0001 | 0001 | 0000]  
        Col 1 = [... | D | 9 | 5 | 1] 
        Col 1 Mask = [... | 0010 | 0010 | 0001]


        */         
    }

    public static class BitMatrix16x4X
    {
        public static BitString ToBitString(this BitMatrix16x4 src)
            => src.data.ToBitString();

        public static string Format(this BitMatrix16x4 src)
            => src.data.AsBytes().FormatMatrixBits(4);


        [MethodImpl(Inline)]
        public static BitMatrix16x4 ToPrimalBits(this ulong src, N16 m, N4 n)
            => BitMatrix.define(m,n,src);

        [MethodImpl(Inline)]
        public static BitMatrix8 ToPrimalBits(this ulong src, N8 n = default)
            => BitMatrix.primal(n, src);



    }
}
            
