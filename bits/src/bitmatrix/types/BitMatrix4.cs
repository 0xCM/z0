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

    using static zfunc;

    public ref struct BitMatrix4
    {        
        Span<byte> data;

        ushort _data;

        /// <summary>
        /// The matrix order
        /// </summary>
        public const uint Order = 4;

        /// <summary>
        /// The number of bytes required to store the matrix
        /// </summary>
        public const uint ByteCount = Order*Order / 8;

        /// <summary>
        /// The order type
        /// </summary>
        public static  N4 N => default;
                                        
        public static BitMatrix4 Identity => BitMatrix.identity(n4); 
        
        public static BitMatrix4 Zero => From(ushort.MinValue);

        public static BitMatrix4 Ones => From(ushort.MaxValue);

        /// <summary>
        /// Allocates a matrix, optionally assigning each element to the
        /// specified bit value
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix4 Alloc(bit fill)                
            => fill == bit.On ? new BitMatrix4(ushort.MaxValue) : new BitMatrix4(ushort.MinValue);

        [MethodImpl(Inline)]
        public static BitMatrix4 From(ushort src)        
            => new BitMatrix4(src);

        [MethodImpl(Inline)]
        public static explicit operator ushort(BitMatrix4 src)
            => src._data;

        [MethodImpl(Inline)]
        public static explicit operator uint(BitMatrix4 src)
            => src._data;

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
        BitMatrix4(ushort src)
        {
            this._data = src;
            this.data = span<byte>(
                (byte)(M4 & src), 
                (byte)(M4 & (src >> 4)),
                (byte)(M4 & (src >> 8)),
                (byte)(M4 & (src >> 12))
                );
        }

        public int RowCount
        {
            [MethodImpl(Inline)]
            get => N;
        }

        public int ColCount
        {
            [MethodImpl(Inline)]
            get => N;
        }

        /// <summary>
        /// Queries the matrix for the data in an index-identified row and returns
        /// the bitvector representative
        /// </summary>
        /// <param name="index">The row index</param>
        [MethodImpl(Inline)]
        public readonly BitVector4 RowVector(int index)
            => data[index];

        public Bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => BitMask.test(data[row], col);

            [MethodImpl(Inline)]
            set => BitMask.set(ref data[row], (byte)col, value);
        }            

        /// <summary>
        /// A mutable indexer
        /// </summary>
        /// <param name="row">The row index</param>
        public ref byte this[int row]
        {
            [MethodImpl(Inline)]
            get => ref data[row];
        }
            
        [MethodImpl(Inline)]
        public readonly bool Equals(in BitMatrix4 B)
            => _data == B._data;

        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}