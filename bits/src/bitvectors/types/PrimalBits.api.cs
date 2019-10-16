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
    using static nfunc;
    using static As;
    using static AsIn;

    public static class PrimalBits
    {
        /// <summary>
        /// Given a primal scalar over which a primal bitvector is defined, creates the
        /// corresponding generic closure
        /// </summary>
        /// <param name="src">The primal scalar value</param>
        /// <param name="rep">A representative bitvector for type inference</param>
        /// <typeparam name="V">The primal bitvector type</typeparam>
        /// <typeparam name="S">The primal scalar type</typeparam>
        [MethodImpl(Inline)]
        public static PrimalBits<V,S> define<V,S>(in S src, V rep = default)
            where V : unmanaged, IPrimalBitVector<V,S>
            where S : unmanaged
        {
            if(typeof(S) == typeof(byte))
                return new PrimalBits<V,S>(uint8(in src));
            else if(typeof(S) == typeof(ushort))
                return new PrimalBits<V,S>(uint64(in src));
            else if(typeof(S) == typeof(uint))
                return new PrimalBits<V,S>(uint32(in src));
            else if(typeof(S) == typeof(ulong))
                return new PrimalBits<V,S>(uint64(in src));
            else
                throw unsupported<S>();
        }

        /// <summary>
        /// Computes the bitwise AND between primal generic bitvectors of the same type
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="V">The primal bitvector type</typeparam>
        /// <typeparam name="T">The primal scalar type</typeparam>
        [MethodImpl(Inline)]
        public static PrimalBits<V,T> and<V,T>(PrimalBits<V,T> x, PrimalBits<V,T> y)
            where V : unmanaged, IPrimalBitVector<V,T>
            where T : unmanaged
        {
            if(typeof(V) == typeof(BitVector8))
                return generic<V,T>(bitvector.and(x.bv8, y.bv8));
            else if(typeof(V) == typeof(BitVector16))
                return generic<V,T>(bitvector.and(x.bv16, y.bv16));
            else if(typeof(V) == typeof(BitVector32))
                return generic<V,T>(bitvector.and(x.bv32, y.bv32));
            else if(typeof(V) == typeof(BitVector64))
                return generic<V,T>(bitvector.and(x.bv64, y.bv64));
            else
                throw unsupported<T>();
        }


        /// <summary>
        /// Computes the bitwise OR between primal generic bitvectors of the same type
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="V">The primal bitvector type</typeparam>
        /// <typeparam name="S">The primal scalar type</typeparam>
        [MethodImpl(Inline)]
        public static PrimalBits<V,S> or<V,S>(in PrimalBits<V,S> x, in PrimalBits<V,S> y)
            where V : unmanaged, IPrimalBitVector<V,S>
            where S : unmanaged
        {
            if(typeof(V) == typeof(BitVector8))
                return generic<V,S>(bitvector.or(x.bv8, y.bv8));
            else if(typeof(V) == typeof(BitVector16))
                return generic<V,S>(bitvector.or(x.bv16, y.bv16));
            else if(typeof(V) == typeof(BitVector32))
                return generic<V,S>(bitvector.or(x.bv32, y.bv32));
            else if(typeof(V) == typeof(BitVector64))
                return generic<V,S>(bitvector.or(x.bv64, y.bv64));
            else
                throw unsupported<S>();
        }

        /// <summary>
        /// Computes the bitwise XOR between primal generic bitvectors of the same type
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="V">The primal bitvector type</typeparam>
        /// <typeparam name="S">The primal scalar type</typeparam>
        [MethodImpl(Inline)]
        public static PrimalBits<V,S> xor<V,S>(in PrimalBits<V,S> x, in PrimalBits<V,S> y)
            where V : unmanaged, IPrimalBitVector<V,S>
            where S : unmanaged
        {
            if(typeof(V) == typeof(BitVector8))
                return generic<V,S>(bitvector.xor(x.bv8, y.bv8));
            else if(typeof(V) == typeof(BitVector16))
                return generic<V,S>(bitvector.xor(x.bv16, y.bv16));
            else if(typeof(V) == typeof(BitVector32))
                return generic<V,S>(bitvector.xor(x.bv32, y.bv32));
            else if(typeof(V) == typeof(BitVector64))
                return generic<V,S>(bitvector.xor(x.bv64, y.bv64));
            else
                throw unsupported<S>();
        }

        /// <summary>
        /// Computes the left shift of a primal generic bitvector
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="V">The primal bitvector type</typeparam>
        /// <typeparam name="S">The primal scalar type</typeparam>
        [MethodImpl(Inline)]
        public static PrimalBits<V,S> sll<V,S>(in PrimalBits<V,S> x, int offset)
            where V : unmanaged, IPrimalBitVector<V,S>
            where S : unmanaged
        {
            if(typeof(V) == typeof(BitVector8))
                return generic<V,S>(bitvector.sll(x.bv8, offset));
            else if(typeof(V) == typeof(BitVector16))
                return generic<V,S>(bitvector.sll(x.bv16, offset));
            else if(typeof(V) == typeof(BitVector32))
                return generic<V,S>(bitvector.sll(x.bv32, offset));
            else if(typeof(V) == typeof(BitVector64))
                return generic<V,S>(bitvector.sll(x.bv64, offset));
            else
                throw unsupported<S>();
        }

        /// <summary>
        /// Computes the right shift of a primal generic bitvector
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="V">The primal bitvector type</typeparam>
        /// <typeparam name="S">The primal scalar type</typeparam>
        [MethodImpl(Inline)]
        public static PrimalBits<V,S> srl<V,S>(in PrimalBits<V,S> x, int offset)
            where V : unmanaged, IPrimalBitVector<V,S>
            where S : unmanaged
        {
            if(typeof(V) == typeof(BitVector8))
                return generic<V,S>(bitvector.srl(x.bv8, offset));
            else if(typeof(V) == typeof(BitVector16))
                return generic<V,S>(bitvector.srl(x.bv16, offset));
            else if(typeof(V) == typeof(BitVector32))
                return generic<V,S>(bitvector.srl(x.bv32, offset));
            else if(typeof(V) == typeof(BitVector64))
                return generic<V,S>(bitvector.srl(x.bv64, offset));
            else
                throw unsupported<S>();
        }

        [MethodImpl(Inline)]
        public static PrimalBits<V,S> rotl<V,S>(in PrimalBits<V,S> x, int offset)
            where V : unmanaged, IPrimalBitVector<V,S>
            where S : unmanaged
        {
            if(typeof(V) == typeof(BitVector8))
                return generic<V,S>(bitvector.rotl(x.bv8, offset));
            else if(typeof(V) == typeof(BitVector16))
                return generic<V,S>(bitvector.rotl(x.bv16, offset));
            else if(typeof(V) == typeof(BitVector32))
                return generic<V,S>(bitvector.rotl(x.bv32, offset));
            else if(typeof(V) == typeof(BitVector64))
                return generic<V,S>(bitvector.rotl(x.bv64, offset));
            else
                throw unsupported<S>();
        }

        [MethodImpl(Inline)]
        public static PrimalBits<V,S> rotr<V,S>(in PrimalBits<V,S> x, int offset)
            where V : unmanaged, IPrimalBitVector<V,S>
            where S : unmanaged
        {
            if(typeof(V) == typeof(BitVector8))
                return generic<V,S>(bitvector.rotr(x.bv8, offset));
            else if(typeof(V) == typeof(BitVector16))
                return generic<V,S>(bitvector.rotr(x.bv16, offset));
            else if(typeof(V) == typeof(BitVector32))
                return generic<V,S>(bitvector.rotr(x.bv32, offset));
            else if(typeof(V) == typeof(BitVector64))
                return generic<V,S>(bitvector.rotr(x.bv64, offset));
            else
                throw unsupported<S>();
        }

        /// <summary>
        /// Computes the bitwise complement of a primal generic bitvector
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="V">The primal bitvector type</typeparam>
        /// <typeparam name="S">The primal scalar type</typeparam>
        [MethodImpl(Inline)]
        public static PrimalBits<V,S> flip<V,S>(in PrimalBits<V,S> x)
            where V : unmanaged, IPrimalBitVector<V,S>
            where S : unmanaged
        {
            if(typeof(V) == typeof(BitVector8))
                return generic<V,S>(bitvector.not(x.bv8));
            else if(typeof(V) == typeof(BitVector16))
                return generic<V,S>(bitvector.not(x.bv16));
            else if(typeof(V) == typeof(BitVector32))
                return generic<V,S>(bitvector.not(x.bv32));
            else if(typeof(V) == typeof(BitVector64))
                return generic<V,S>(bitvector.not(x.bv64));
            else
                throw unsupported<S>();
        }

        /// <summary>
        /// Computes the bitwise two's complement of a primal generic bitvector
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="V">The primal bitvector type</typeparam>
        /// <typeparam name="S">The primal scalar type</typeparam>
        [MethodImpl(Inline)]
        public static PrimalBits<V,S> negate<V,S>(in PrimalBits<V,S> x)
            where V : unmanaged, IPrimalBitVector<V,S>
            where S : unmanaged
        {
            if(typeof(V) == typeof(BitVector8))
                return generic<V,S>(bitvector.negate(x.bv8));
            else if(typeof(V) == typeof(BitVector16))
                return generic<V,S>(bitvector.negate(x.bv16));
            else if(typeof(V) == typeof(BitVector32))
                return generic<V,S>(bitvector.negate(x.bv32));
            else if(typeof(V) == typeof(BitVector64))
                return generic<V,S>(bitvector.negate(x.bv64));
            else
                throw unsupported<S>();
        }

        /// <summary>
        /// Arithmetically increments the bitvector
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="V">The primal bitvector type</typeparam>
        /// <typeparam name="S">The primal scalar type</typeparam>
        [MethodImpl(Inline)]
        public static PrimalBits<V,S> inc<V,S>(in PrimalBits<V,S> x)
            where V : unmanaged, IPrimalBitVector<V,S>
            where S : unmanaged
        {
            if(typeof(V) == typeof(BitVector8))
                return generic<V,S>(bitvector.inc(x.bv8));
            else if(typeof(V) == typeof(BitVector16))
                return generic<V,S>(bitvector.inc(x.bv16));
            else if(typeof(V) == typeof(BitVector32))
                return generic<V,S>(bitvector.inc(x.bv32));
            else if(typeof(V) == typeof(BitVector64))
                return generic<V,S>(bitvector.inc(x.bv64));
            else
                throw unsupported<S>();
        }

        /// <summary>
        /// Arithmetically decrements the bitvector
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="V">The primal bitvector type</typeparam>
        /// <typeparam name="S">The primal scalar type</typeparam>
        [MethodImpl(Inline)]
        public static PrimalBits<V,S> dec<V,S>(in PrimalBits<V,S> x)
            where V : unmanaged, IPrimalBitVector<V,S>
            where S : unmanaged
        {
            if(typeof(V) == typeof(BitVector8))
                return generic<V,S>(bitvector.dec(x.bv8));
            else if(typeof(V) == typeof(BitVector16))
                return generic<V,S>(bitvector.dec(x.bv16));
            else if(typeof(V) == typeof(BitVector32))
                return generic<V,S>(bitvector.dec(x.bv32));
            else if(typeof(V) == typeof(BitVector64))
                return generic<V,S>(bitvector.dec(x.bv64));
            else
                throw unsupported<S>();
        }

        /// <summary>
        /// Extracts the primal scalar from the generic enclosure
        /// </summary>
        /// <param name="src">The generic enclosure</param>
        /// <typeparam name="V">The enclosed primal bitvector</typeparam>
        /// <typeparam name="S">The associated primal scalar</typeparam>
        [MethodImpl(Inline)]
        internal static S scalar<V,S>(in PrimalBits<V,S> src)
            where V : unmanaged, IPrimalBitVector<V,S>
            where S : unmanaged
        {
            if (typeof(S) == typeof(byte))
                return scalar8(in src);
            else if (typeof(S) == typeof(ushort))
                return scalar16(in src);
            else if (typeof(S) == typeof(uint))
                return scalar32(in src);
            else if(typeof(S) == typeof(ulong))
                return scalar64(in src);
            else 
                throw unsupported<S>();
        }


        /// <summary>
        /// Creates a type-parametric fixed-length bitvector from a scalar source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="V">The nonparametric vector of fixed size</typeparam>
        /// <typeparam name="S">A supported scalar type</typeparam>
        [MethodImpl(Inline)]
        internal static V vector<V,S>(in S src)
            where V : unmanaged, IPrimalBitVector<V,S>
            where S : unmanaged
        {
            if (typeof(S) == typeof(byte))
                return bv8<V,S>(src);
            else if (typeof(S) == typeof(ushort))
                return bv16<V,S>(src);
            else if (typeof(S) == typeof(uint))
                return bv32<V,S>(src);
            else if (typeof(S) == typeof(ulong))
                return bv64<V,S>(src);
            else
                throw unsupported<S>();
        }

        /// <summary>
        /// Creates a type-parametric fixed-length bitvector from a non-parametric bitvector
        /// </summary>
        /// <param name="s">The scalar value</param>
        /// <typeparam name="V">The nonparametric vector of fixed size</typeparam>
        /// <typeparam name="S">A supported scalar type</typeparam>
        internal static PrimalBits<V,S> bits<V,S>(in V v, S rep = default)
            where V : unmanaged, IPrimalBitVector<V,S>
            where S : unmanaged
        {
            if(typeof(V) == typeof(BitVector8))
                return new PrimalBits<V,S>(Unsafe.As<V,BitVector8>(ref asRef(in v)));
            else if(typeof(V) == typeof(BitVector16))
                return new PrimalBits<V,S>(Unsafe.As<V,BitVector16>(ref asRef(in v)));
            else if(typeof(V) == typeof(BitVector32))
                return new PrimalBits<V,S>(Unsafe.As<V,BitVector32>(ref asRef(in v)));
            else if(typeof(V) == typeof(BitVector64))
                return new PrimalBits<V,S>(Unsafe.As<V,BitVector64>(ref asRef(in v)));
            else
                throw unsupported<S>();
        }

        [MethodImpl(Inline)]
        static S scalar8<V,S>(in PrimalBits<V,S> src)
            where V : unmanaged, IPrimalBitVector<V,S>
            where S : unmanaged
        {                
            var s = src.bv8.Scalar;
            return Unsafe.As<byte,S>(ref s);
        }

        [MethodImpl(Inline)]
        static S scalar16<V,S>(in PrimalBits<V,S> src)
            where V : unmanaged, IPrimalBitVector<V,S>
            where S : unmanaged
        {                
            var s = src.bv16.Scalar;
            return Unsafe.As<ushort,S>(ref s);
        }

        [MethodImpl(Inline)]
        static S scalar32<V,S>(in PrimalBits<V,S> src)
            where V : unmanaged, IPrimalBitVector<V,S>
            where S : unmanaged
        {                
            var s = src.bv32.Scalar;                
            return Unsafe.As<uint,S>(ref s);
        }

        [MethodImpl(Inline)]
        static S scalar64<V,S>(in PrimalBits<V,S> src)
            where V : unmanaged, IPrimalBitVector<V,S>
            where S : unmanaged
        {                
            var s = src.bv64.Scalar;                
            return Unsafe.As<ulong,S>(ref s);
        }


        [MethodImpl(Inline)]
        static V bv8<V,S>(in S src)
            where V : unmanaged, IPrimalBitVector<V,S>
            where S : unmanaged
        {
            var bv = BitVector8.FromScalar(uint8(in src));
            return Unsafe.As<BitVector8,V>(ref bv);
        }

        [MethodImpl(Inline)]
        static V bv16<V,S>(in S src)
            where V : unmanaged, IPrimalBitVector<V,S>
            where S : unmanaged
        {
            var bv = BitVector16.FromScalar(uint16(in src));
            return Unsafe.As<BitVector16,V>(ref bv);
        }

        [MethodImpl(Inline)]
        static V bv32<V,S>(in S src)
            where V : unmanaged, IPrimalBitVector<V,S>
            where S : unmanaged
        {
            var bv = BitVector32.FromScalar(uint32(in src));
            return Unsafe.As<BitVector32,V>(ref bv);
        }

        [MethodImpl(Inline)]
        static V bv64<V,S>(in S src)
            where V : unmanaged, IPrimalBitVector<V,S>
            where S : unmanaged
        {
            var bv = BitVector64.FromScalar(uint64(in src));
            return Unsafe.As<BitVector64,V>(ref bv);
        }

        [MethodImpl(Inline)]
        static ref V generic<V>(in BitVector4 bv)
            => ref Unsafe.As<BitVector4,V>(ref asRef(in bv));


        [MethodImpl(Inline)]
        static ref PrimalBits<V,S> generic<V,S>(in BitVector4 bv)
            where V : unmanaged, IPrimalBitVector<V,S>
            where S : unmanaged
                => ref Unsafe.As<BitVector4,PrimalBits<V,S>>(ref asRef(in bv));


        [MethodImpl(Inline)]
        static ref PrimalBits<V,S> generic<V,S>(in BitVector8 bv)
            where V : unmanaged, IPrimalBitVector<V,S>
            where S : unmanaged
                => ref Unsafe.As<BitVector8,PrimalBits<V,S>>(ref asRef(in bv));

        [MethodImpl(Inline)]
        static ref PrimalBits<V,S> generic<V,S>(in BitVector16 bv)
            where V : unmanaged, IPrimalBitVector<V,S>
            where S : unmanaged
                => ref Unsafe.As<BitVector16,PrimalBits<V,S>>(ref asRef(in bv));

        [MethodImpl(Inline)]
        static ref PrimalBits<V,S> generic<V,S>(in BitVector32 bv)
            where V : unmanaged, IPrimalBitVector<V,S>
            where S : unmanaged
                => ref Unsafe.As<BitVector32,PrimalBits<V,S>>(ref asRef(in bv));

        [MethodImpl(Inline)]
        static ref PrimalBits<V,S> generic<V,S>(in BitVector64 bv)
            where V : unmanaged, IPrimalBitVector<V,S>
            where S : unmanaged
                => ref Unsafe.As<BitVector64,PrimalBits<V,S>>(ref asRef(in bv));

    }
}