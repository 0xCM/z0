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
    using static As;
    using static AsIn;

    /// <summary>
    /// Defines a bit-polymorphic structure over a primal bitvector
    /// </summary>
    /// <remarks>There are four possible closed types that can be formed coresponding to the four primal bitvectors:
    /// {PrimalBits[BitVector8,byte], PrimalBits[BitVector16,ushort], PrimalBits[BitVector32,uint], PrimalBits[BitVector64,ulong]}
    /// </remarks>
    public struct PrimalBits<V,S>
        where V : unmanaged, IPrimalBitVector<V,S>
        where S : unmanaged
    {   
        V bv;
        
        public static readonly PrimalBits<V,S> Zero = default;

        [MethodImpl(Inline)]
        public static implicit operator V(PrimalBits<V,S> src)
            => src.Subject;

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
        public static PrimalBits<V,S> operator &(PrimalBits<V,S> lhs, PrimalBits<V,S> rhs)
            => and(lhs,rhs);

        /// <summary>
        /// Computes the bitwise OR of the source operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static PrimalBits<V,S> operator |(PrimalBits<V,S> lhs, PrimalBits<V,S> rhs)
            => or(lhs,rhs);

        /// <summary>
        /// Computes the bitwise XOR of the source operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static PrimalBits<V,S> operator ^(PrimalBits<V,S> lhs, PrimalBits<V,S> rhs)
            => xor(lhs,rhs);

        /// <summary>
        /// Computes the bitwise complement of the operand
        /// </summary>
        /// <param name="lhs">The left vector</param>
        [MethodImpl(Inline)]
        public static PrimalBits<V,S> operator ~(PrimalBits<V,S> src)
            => flip(src);

        /// <summary>
        /// Computes the two's complement of the operand
        /// </summary>
        /// <param name="lhs">The left vector</param>
        [MethodImpl(Inline)]
        public static PrimalBits<V,S> operator -(PrimalBits<V,S> src)
            => negate(src);

        /// <summary>
        /// Arithmetically increments the operand
        /// </summary>
        /// <param name="lhs">The left vector</param>
        [MethodImpl(Inline)]
        public static PrimalBits<V,S> operator ++(PrimalBits<V,S> src)
            => inc(src);

        /// <summary>
        /// Arithmetically increments the operand
        /// </summary>
        /// <param name="lhs">The left vector</param>
        [MethodImpl(Inline)]
        public static PrimalBits<V,S> operator --(PrimalBits<V,S> src)
            => dec(src);

        /// <summary>
        /// Applies a logical left-shift
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="rhs">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static PrimalBits<V,S> operator <<(PrimalBits<V,S> src, int offset)
            => sll(src,offset);

        /// <summary>
        /// Applies a logical right-shift
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="rhs">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static PrimalBits<V,S> operator >>(in PrimalBits<V,S> src, int offset)
            => srl(src,offset);

        internal BitVector8 bv8
        {
            [MethodImpl(Inline)]
            get => Unsafe.As<V,BitVector8>(ref bv);

            [MethodImpl(Inline)]
            set => Unsafe.As<V,BitVector8>(ref bv) = value;
        }

        internal BitVector16 bv16
        {
            [MethodImpl(Inline)]
            get => Unsafe.As<V,BitVector16>(ref bv);

            [MethodImpl(Inline)]
            set => Unsafe.As<V,BitVector16>(ref bv) = value;
        }

        internal BitVector32 bv32
        {
            [MethodImpl(Inline)]
            get => Unsafe.As<V,BitVector32>(ref bv);
            
            [MethodImpl(Inline)]
            set => Unsafe.As<V,BitVector32>(ref bv) = value;
        }

        internal BitVector64 bv64
        {
            [MethodImpl(Inline)]
            get => Unsafe.As<V,BitVector64>(ref bv);
            
            [MethodImpl(Inline)]
            set => Unsafe.As<V,BitVector64>(ref bv) = value;
        }

        [MethodImpl(Inline)]
        internal PrimalBits(byte scalar)
            : this(scalar.ToBitVector())
        {
            
        }

        [MethodImpl(Inline)]
        internal PrimalBits(ushort scalar)
            : this(scalar.ToBitVector())
        {
            
        }

        [MethodImpl(Inline)]
        internal PrimalBits(uint scalar)
            : this(scalar.ToBitVector())
        {
            
        }

        [MethodImpl(Inline)]
        internal PrimalBits(ulong scalar)
            : this(scalar.ToBitVector())
        {

        }


        [MethodImpl(Inline)]
        internal PrimalBits(in BitVector8 bv)
            : this()
        {
            this.bv = Unsafe.As<BitVector8,V>(ref asRef(in bv));
        }

        [MethodImpl(Inline)]
        internal PrimalBits(BitVector16 bv)
            : this()
        {
            this.bv = Unsafe.As<BitVector16,V>(ref asRef(in bv));
        }

        [MethodImpl(Inline)]
        internal PrimalBits(BitVector32 bv)
            : this()
        {
            this.bv = Unsafe.As<BitVector32,V>(ref asRef(in bv));
        }

        [MethodImpl(Inline)]
        internal PrimalBits(BitVector64 bv)
            : this()
        {
            this.bv = Unsafe.As<BitVector64,V>(ref asRef(in bv));
        }

        /// <summary>
        /// The primal bitvector's scalar value
        /// </summary>
        public S Scalar
        {
            [MethodImpl(Inline)]
            get => bv.Scalar;
        }

        /// <summary>
        /// The fixed-length primal bitvector upon which this parametric bitvector is predicated
        /// </summary>
        public V Subject
        {
            [MethodImpl(Inline)]
            get => bv;
        }

        [MethodImpl(Inline)]
        public static ref PrimalBits<U,D> As<U,D>(ref PrimalBits<V,S> src)
            where U : unmanaged, IPrimalBitVector<U,D>
            where D : unmanaged            
                => ref Unsafe.As<PrimalBits<V,S>, PrimalBits<U,D>>(ref src);
    }
}