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
            get => Row(index);
        }

        [MethodImpl(Inline)]
        public BitVector4 Row(int index)
            => BitVector.direct(n4, Bits.extract((ulong)this,index*4, 4));

        [MethodImpl(Inline)]
        public BitVector16 Col(int index)
            => BitVector.from(n16, dinx.gather(this,(C0 << index)));

        // C0 = [0001 0001 ... 0001]
        // C1 = C0 << 1 = [0010 0010 ... 0010]
        // C2 = C0 << 2 = [0100 0100 ... 0100]
        // C3 = C0 << 3 = [1000 1000 ... 1000]
        const ulong C0 = 
            (1ul << 64 - 1*4) | (1ul << 64 - 2*4) | (1ul << 64 - 3*4) | (1ul << 64 - 4*4) | 
            (1ul << 64 - 5*4) | (1ul << 64 - 6*4) | (1ul << 64 - 7*4) | (1ul << 64 - 8*4) |
            (1ul << 64 - 9*4) | (1ul << 64 - A*4) | (1ul << 64 - B*4) | (1ul << 64 - C*4) |
            (1ul << 64 - D*4) | (1ul << 64 - E*4) | (1ul << 64 - F*4) | 1;        
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
        public static BitMatrix4x16 transpose(BitMatrix16x4 A)
            => BitMatrix.define(n4,n16, ((ulong)A.Col(0) << 0) | ((ulong)A.Col(1) << 16) | ((ulong)A.Col(2) << 32) | ((ulong)A.Col(3) << 48));

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

    }
}
            
