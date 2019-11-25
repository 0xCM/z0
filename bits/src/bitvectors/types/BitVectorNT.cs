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

    /// <summary>
    /// Defines a bitvector of natural effective width
    /// </summary>
    /// <typeparam name="T">The cell type</typeparam>
    /// <typeparam name="N">The bit-width type</typeparam>
    public struct BitVector<N,T>
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        internal T data;

        [MethodImpl(Inline)]
        public static implicit operator BitVector<N,T>(T data)
            => new BitVector<N, T>(data);

        [MethodImpl(Inline)]
        public static implicit operator T(BitVector<N,T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static bool operator ==(BitVector<N,T> x, BitVector<N,T> y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(BitVector<N,T> x, BitVector<N,T> y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        internal BitVector(T data)
            => this.data = gmath.and(gbits.lomask<N,T>(), data);

        public T Scalar
        {
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// The effective bitvector width
        /// </summary>
        public int Width
        {
            [MethodImpl(Inline)]
            get => natval<N>();
        }

        /// <summary>
        /// Reads/Manipulates a single bit
        /// </summary>
        public bit this[int index]
        {
            [MethodImpl(Inline)]
            get => gbits.test(data, index);
            
            [MethodImpl(Inline)]
            set => data = gbits.set(data, index, value);
        }

        /// <summary>
        /// Extracts a contiguous sequence of bits defined by an inclusive range
        /// </summary>
        /// <param name="first">The first bit position</param>
        /// <param name="last">The last bit position</param>
        public BitVector<T> this[int first, int last]
        {
            [MethodImpl(Inline)]
            get => gbits.between(data, first, last);
        }

        [MethodImpl(Inline)]
        public readonly bool Equals(BitVector<N,T> y)
            => gmath.eq(data, y.data);

        public readonly override bool Equals(object obj)
            => obj is BitVector<N,T> x && Equals(x);
        
        public readonly override int GetHashCode()
            => data.GetHashCode();

        public override string ToString()
            => this.Format();
    }
}