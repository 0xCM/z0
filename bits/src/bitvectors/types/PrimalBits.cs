//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static zfunc;    
    using static PrimalBits;

    public struct PrimalBits<V,S>
        where V : unmanaged, IFixedScalarBits<V,S>
        where S : unmanaged
    {   
        internal BitVector64 data;

        public static readonly PrimalBits<V,S> Zero = default;

        [MethodImpl(Inline)]
        public static implicit operator V(PrimalBits<V,S> src)
            => src.Subject;

        [MethodImpl(Inline)]
        public static implicit operator PrimalBits<V,S>(BitVector4 src)
            => new PrimalBits<V, S>(src);

        [MethodImpl(Inline)]
        public static implicit operator PrimalBits<V,S>(BitVector8 src)
            => new PrimalBits<V, S>(src);

        [MethodImpl(Inline)]
        public static implicit operator PrimalBits<V,S>(BitVector16 src)
            => new PrimalBits<V, S>(src);

        [MethodImpl(Inline)]
        public static implicit operator PrimalBits<V,S>(BitVector32 src)
            => new PrimalBits<V, S>(src);

        [MethodImpl(Inline)]
        public static implicit operator PrimalBits<V,S>(BitVector64 src)
            => new PrimalBits<V, S>(src);

        /// <summary>
        /// Computes the bitwise AND of the source operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static PrimalBits<V,S> operator &(in PrimalBits<V,S> lhs, in PrimalBits<V,S> rhs)
            => and(in lhs,in rhs);

        /// <summary>
        /// Computes the bitwise OR of the source operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static PrimalBits<V,S> operator |(in PrimalBits<V,S> lhs, in PrimalBits<V,S> rhs)
            => or(in lhs,in rhs);

        /// <summary>
        /// Computes the bitwise XOR of the source operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static PrimalBits<V,S> operator ^(in PrimalBits<V,S> lhs, in PrimalBits<V,S> rhs)
            => xor(in lhs,in rhs);

        /// <summary>
        /// Computes the bitwise complement of the operand
        /// </summary>
        /// <param name="lhs">The left vector</param>
        [MethodImpl(Inline)]
        public static PrimalBits<V,S> operator ~(in PrimalBits<V,S> src)
            => flip(in src);

        /// <summary>
        /// Applies a logical left-shift
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="rhs">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static PrimalBits<V,S> operator <<(in PrimalBits<V,S> src, int offset)
            => sll(in src,offset);

        /// <summary>
        /// Applies a logical left-shift
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="rhs">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static PrimalBits<V,S> operator >>(in PrimalBits<V,S> src, int offset)
            => srl(in src,offset);


        internal BitVector8 bv8
        {
            [MethodImpl(Inline)]
            get => (BitVector8)data;

            [MethodImpl(Inline)]
            set => data = value;
        }

        internal BitVector16 bv16
        {
            [MethodImpl(Inline)]
            get => (BitVector16)data;

            [MethodImpl(Inline)]
            set => data = value;
        }

        internal BitVector32 bv32
        {
            [MethodImpl(Inline)]
            get => (BitVector32)data;
            
            [MethodImpl(Inline)]
            set => data = value;
        }

        [MethodImpl(Inline)]
        internal PrimalBits(UInt4 bv)
            : this()
        {
            this.data = (byte)bv;
        }

        [MethodImpl(Inline)]
        internal PrimalBits(byte bv)
            : this()
        {
            this.data = bv;
        }

        [MethodImpl(Inline)]
        internal PrimalBits(ushort bv)
            : this()
        {
            this.data = bv;
        }

        [MethodImpl(Inline)]
        internal PrimalBits(uint bv)
            : this()
        {
            this.data = bv;
        }

        [MethodImpl(Inline)]
        internal PrimalBits(ulong bv)
            : this()
        {
            this.data = bv;
        }

        [MethodImpl(Inline)]
        internal PrimalBits(BitVector4 bv)
            : this()
        {
            this.data = (byte)bv.Scalar;
        }

        [MethodImpl(Inline)]
        internal PrimalBits(BitVector8 bv)
            : this()
        {
            this.data = bv;
        }

        [MethodImpl(Inline)]
        internal PrimalBits(BitVector16 bv)
            : this()
        {
            this.data = bv;
        }

        [MethodImpl(Inline)]
        internal PrimalBits(BitVector32 bv)
            : this()
        {
            this.data = bv;
        }

        [MethodImpl(Inline)]
        internal PrimalBits(BitVector64 bv)
            : this()
        {
            this.data = bv;
        }

        /// <summary>
        /// The primal bitvector's scalar value
        /// </summary>
        public S Scalar
        {
            [MethodImpl(Inline)]
            get => scalar(in this);
        }

        /// <summary>
        /// The fixed-length primal bitvector upon which this parametric bitvector is predicated
        /// </summary>
        public V Subject
        {
            [MethodImpl(Inline)]
            get => vector(in this);
        }

        [MethodImpl(Inline)]
        public static ref PrimalBits<U,D> As<U,D>(ref PrimalBits<V,S> src)
            where U : unmanaged, IFixedScalarBits<U,D>
            where D : unmanaged            
                => ref Unsafe.As<PrimalBits<V,S>, PrimalBits<U,D>>(ref src);
    }
}