//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Nats;

    [IdentityProvider(typeof(BitMatrixIdentityProvider))]
    public ref struct BitMatrix4
    {        
        ushort data;

        /// <summary>
        /// The matrix order
        /// </summary>
        public const uint N = 4;
                                        
        /// <summary>
        /// Allocates a 4x4 identity bitmatrix
        /// </summary>
        public static BitMatrix4 Identity => BitMatrix.identity(n4); 
        
        public static BitMatrix4 Zero => new BitMatrix4(ushort.MinValue);

        public static BitMatrix4 Ones => new BitMatrix4(ushort.MaxValue);

        /// <summary>
        /// Allocates a matrix, optionally assigning each element to the specified bit value
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix4 Alloc(bit fill)                
            => fill == bit.On ? new BitMatrix4(ushort.MaxValue) : new BitMatrix4(ushort.MinValue);

        [MethodImpl(Inline)]
        public static BitMatrix4 From(ushort src)        
            => new BitMatrix4(src);

        [MethodImpl(Inline)]
        public static explicit operator ushort(BitMatrix4 src)
            => src.data;

        [MethodImpl(Inline)]
        public static explicit operator uint(BitMatrix4 src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator BitMatrix4(ushort src)
            => From(src);

        [MethodImpl(Inline)]
        public static BitMatrix4 operator & (in BitMatrix4 A, in BitMatrix4 B)
            => BitMatrix.and(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix4 operator | (in BitMatrix4 A, in BitMatrix4 B)
            => BitMatrix.or(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix4 operator ^ (in BitMatrix4 A, in BitMatrix4 B)
            => BitMatrix.xor(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix4 operator ~ (in BitMatrix4 src)
            => BitMatrix.not(src);

        [MethodImpl(Inline)]
        public static BitMatrix4 operator * (in BitMatrix4 A, in BitMatrix4 B)
            => BitMatrix.mul(A,B);

        [MethodImpl(Inline)]
        public static BitVector4 operator * (in BitMatrix4 A, in BitVector4 x)
            => BitMatrix.mul(A,x);

        [MethodImpl(Inline)]
        public static bool operator ==(BitMatrix4 A, BitMatrix4 B)
            => BitMatrix.same(A,B);

        [MethodImpl(Inline)]
        public static bool operator !=(BitMatrix4 A, BitMatrix4 B)
            => !BitMatrix.same(A,B);

        const byte M4 = 0b1111;

        [MethodImpl(Inline)]
        internal BitMatrix4(ushort src)
        {
            this.data = src;
        }

        public int Order => (int)N;

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get =>  BitConvert.GetBytes(data);
        }

        public BitView<ushort> Data
        {
            [MethodImpl(Inline)]
            get => BitView.Over(ref data);
        }

        /// <summary>
        /// Gets an index-identified row vector
        /// </summary>
        /// <param name="index">The row index</param>
        [MethodImpl(Inline)]
        BitVector4 GetRow(int index)
            => (byte)(M4 & (data >> index*4));

        [MethodImpl(Inline)]
        void SetRow(int row, BitVector4 value)
        {
            ushort result = 0;
            for(var i=0; i<N; i++)
                result |= (ushort)(i == row ? value.Scalar << 4*i : this[row]);
            data = result;
        }

        public bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => bit.test(data, row*4 + col);

            [MethodImpl(Inline)]
            set => data = bit.set(data, (byte)(row*4 + col), value);
        }            

        public BitVector4 this[int row]
        {
            [MethodImpl(Inline)]
            get => GetRow(row);

            [MethodImpl(Inline)]
            set => SetRow(row, value);

        }
            
        [MethodImpl(Inline)]
        public readonly bool Equals(in BitMatrix4 B)
            => data == B.data;

        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}