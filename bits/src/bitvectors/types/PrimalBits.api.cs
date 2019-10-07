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
        [MethodImpl(Inline)]
        public static PrimalBits<V,S> define<V,S>(in S src, V rep = default)
            where V : unmanaged, IFixedScalarBits<V,S>
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

        [MethodImpl(Inline)]
        public static ref PrimalBits<V,S> define<V,S>(in S s, ref PrimalBits<V,S> src)
            where V : unmanaged, IFixedScalarBits<V,S>
            where S : unmanaged
        {            
            src = define<V,S>(in s);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static PrimalBits<V,S> and<V,S>(in PrimalBits<V,S> x, in PrimalBits<V,S> y)
            where V : unmanaged, IFixedScalarBits<V,S>
            where S : unmanaged
        {
            if(typeof(V) == typeof(BitVector8))
                return generic<V,S>(x.bv8 & y.bv8);
            else if(typeof(V) == typeof(BitVector16))
                return generic<V,S>(x.bv16 & y.bv16);
            else if(typeof(V) == typeof(BitVector32))
                return generic<V,S>(x.bv32 & y.bv32);
            else if(typeof(V) == typeof(BitVector64))
                return generic<V,S>(x.data & y.data);
            else
                throw unsupported<S>();
        }

        [MethodImpl(Inline)]
        public static PrimalBits<V,S> or<V,S>(in PrimalBits<V,S> x, in PrimalBits<V,S> y)
            where V : unmanaged, IFixedScalarBits<V,S>
            where S : unmanaged
        {
            if(typeof(V) == typeof(BitVector8))
                return generic<V,S>(x.bv8 | y.bv8);
            else if(typeof(V) == typeof(BitVector16))
                return generic<V,S>(x.bv16 | y.bv16);
            else if(typeof(V) == typeof(BitVector32))
                return generic<V,S>(x.bv32 | y.bv32);
            else if(typeof(V) == typeof(BitVector64))
                return generic<V,S>(x.data | y.data);
            else
                throw unsupported<S>();
        }

        [MethodImpl(Inline)]
        public static PrimalBits<V,S> xor<V,S>(in PrimalBits<V,S> x, in PrimalBits<V,S> y)
            where V : unmanaged, IFixedScalarBits<V,S>
            where S : unmanaged
        {
            if(typeof(V) == typeof(BitVector8))
                return generic<V,S>(x.bv8 ^ y.bv8);
            else if(typeof(V) == typeof(BitVector16))
                return generic<V,S>(x.bv16 ^ y.bv16);
            else if(typeof(V) == typeof(BitVector32))
                return generic<V,S>(x.bv32 ^ y.bv32);
            else if(typeof(V) == typeof(BitVector64))
                return generic<V,S>(x.data ^ y.data);
            else
                throw unsupported<S>();
        }

        [MethodImpl(Inline)]
        public static PrimalBits<V,S> sll<V,S>(in PrimalBits<V,S> src, int offset)
            where V : unmanaged, IFixedScalarBits<V,S>
            where S : unmanaged
        {
            if(typeof(V) == typeof(BitVector8))
                return generic<V,S>(src.bv8 << offset);
            else if(typeof(V) == typeof(BitVector16))
                return generic<V,S>(src.bv16 << offset);
            else if(typeof(V) == typeof(BitVector32))
                return generic<V,S>(src.bv32 << offset);
            else if(typeof(V) == typeof(BitVector64))
                return generic<V,S>(src.data << offset);
            else
                throw unsupported<S>();
        }

        [MethodImpl(Inline)]
        public static PrimalBits<V,S> srl<V,S>(in PrimalBits<V,S> src, int offset)
            where V : unmanaged, IFixedScalarBits<V,S>
            where S : unmanaged
        {
            if(typeof(V) == typeof(BitVector8))
                return generic<V,S>(src.bv8 >> offset);
            else if(typeof(V) == typeof(BitVector16))
                return generic<V,S>(src.bv16 >> offset);
            else if(typeof(V) == typeof(BitVector32))
                return generic<V,S>(src.bv32 >> offset);
            else if(typeof(V) == typeof(BitVector64))
                return generic<V,S>(src.data >> offset);
            else
                throw unsupported<S>();
        }

        [MethodImpl(Inline)]
        public static PrimalBits<V,S> flip<V,S>(in PrimalBits<V,S> x)
            where V : unmanaged, IFixedScalarBits<V,S>
            where S : unmanaged
        {
            if(typeof(V) == typeof(BitVector8))
                return generic<V,S>(~x.bv8);
            else if(typeof(V) == typeof(BitVector16))
                return generic<V,S>(~x.bv16);
            else if(typeof(V) == typeof(BitVector32))
                return generic<V,S>(~x.bv32);
            else if(typeof(V) == typeof(BitVector64))
                return generic<V,S>(~x.data);
            else
                throw unsupported<S>();
        }

        [MethodImpl(Inline)]
        internal static ref PrimalBits<V,S> generic<V,S>(in BitVector4 bv)
            where V : unmanaged, IFixedScalarBits<V,S>
            where S : unmanaged
                => ref Unsafe.As<BitVector4,PrimalBits<V,S>>(ref asRef(in bv));

        [MethodImpl(Inline)]
        internal static ref PrimalBits<V,S> generic<V,S>(in BitVector8 bv)
            where V : unmanaged, IFixedScalarBits<V,S>
            where S : unmanaged
                => ref Unsafe.As<BitVector8,PrimalBits<V,S>>(ref asRef(in bv));

        [MethodImpl(Inline)]
        internal static ref PrimalBits<V,S> generic<V,S>(in BitVector16 bv)
            where V : unmanaged, IFixedScalarBits<V,S>
            where S : unmanaged
                => ref Unsafe.As<BitVector16,PrimalBits<V,S>>(ref asRef(in bv));

        [MethodImpl(Inline)]
        internal static ref PrimalBits<V,S> generic<V,S>(in BitVector32 bv)
            where V : unmanaged, IFixedScalarBits<V,S>
            where S : unmanaged
                => ref Unsafe.As<BitVector32,PrimalBits<V,S>>(ref asRef(in bv));

        [MethodImpl(Inline)]
        internal static ref PrimalBits<V,S> generic<V,S>(in BitVector64 bv)
            where V : unmanaged, IFixedScalarBits<V,S>
            where S : unmanaged
                => ref Unsafe.As<BitVector64,PrimalBits<V,S>>(ref asRef(in bv));

        [MethodImpl(Inline)]
        internal static S scalar8<V,S>(in PrimalBits<V,S> src)
            where V : unmanaged, IFixedScalarBits<V,S>
            where S : unmanaged
        {                
            var s = src.bv8.Scalar;
            return Unsafe.As<byte,S>(ref s);
        }

        [MethodImpl(Inline)]
        internal static S scalar16<V,S>(in PrimalBits<V,S> src)
            where V : unmanaged, IFixedScalarBits<V,S>
            where S : unmanaged
        {                
            var s = src.bv16.Scalar;
            return Unsafe.As<ushort,S>(ref s);
        }

        [MethodImpl(Inline)]
        internal static S scalar32<V,S>(in PrimalBits<V,S> src)
            where V : unmanaged, IFixedScalarBits<V,S>
            where S : unmanaged
        {                
            var s = src.bv32.Scalar;                
            return Unsafe.As<uint,S>(ref s);
        }

        [MethodImpl(Inline)]
        internal static S scalar64<V,S>(in PrimalBits<V,S> src)
            where V : unmanaged, IFixedScalarBits<V,S>
            where S : unmanaged
        {                
            var s = src.data.Scalar;                
            return Unsafe.As<ulong,S>(ref s);
        }
    
        [MethodImpl(Inline)]
        internal static S scalar<V,S>(in PrimalBits<V,S> src)
            where V : unmanaged, IFixedScalarBits<V,S>
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

        [MethodImpl(Inline)]
        internal static V vector<V,S>(in PrimalBits<V,S> src)
            where V : unmanaged, IFixedScalarBits<V,S>
            where S : unmanaged
        {
            if(typeof(V) == typeof(BitVector8))
                return Unsafe.As<BitVector8,V>(ref asRef((BitVector8)src.data));
            else if(typeof(V) == typeof(BitVector16))
                return Unsafe.As<BitVector16,V>(ref asRef((BitVector16)src.data));
            else if(typeof(V) == typeof(BitVector32))
                return Unsafe.As<BitVector32,V>(ref asRef((BitVector32)src.data));
            else if(typeof(V) == typeof(BitVector64))
                return Unsafe.As<BitVector64,V>(ref asRef(in src.data));
            else 
                throw unsupported<V>();
        }

        /// <summary>
        /// Creates a type-parametric fixed-length bitvector from a non-parametric bitvector
        /// </summary>
        /// <param name="s">The scalar value</param>
        /// <typeparam name="V">The nonparametric vector of fixed size</typeparam>
        /// <typeparam name="S">A supported scalar type</typeparam>
        static PrimalBits<V,S> FromVector<V,S>(in V v, S rep = default)
            where V : unmanaged, IFixedScalarBits<V,S>
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

        /// <summary>
        /// Creates a type-parametric fixed-length bitvector from a scalar source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="V">The nonparametric vector of fixed size</typeparam>
        /// <typeparam name="S">A supported scalar type</typeparam>
        [MethodImpl(Inline)]
        static V toVector<V,S>(in S src)
            where V : unmanaged, IFixedScalarBits<V,S>
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

        [MethodImpl(Inline)]
        static V bv8<V,S>(in S src)
            where V : unmanaged, IFixedScalarBits<V,S>
            where S : unmanaged
        {
            var bv = BitVector8.FromScalar(uint8(in src));
            return Unsafe.As<BitVector8,V>(ref bv);
        }

        [MethodImpl(Inline)]
        static V bv16<V,S>(in S src)
            where V : unmanaged, IFixedScalarBits<V,S>
            where S : unmanaged
        {
            var bv = BitVector16.FromScalar(uint16(in src));
            return Unsafe.As<BitVector16,V>(ref bv);
        }

        [MethodImpl(Inline)]
        static V bv32<V,S>(in S src)
            where V : unmanaged, IFixedScalarBits<V,S>
            where S : unmanaged
        {
            var bv = BitVector32.FromScalar(uint32(in src));
            return Unsafe.As<BitVector32,V>(ref bv);
        }

        [MethodImpl(Inline)]
        static V bv64<V,S>(in S src)
            where V : unmanaged, IFixedScalarBits<V,S>
            where S : unmanaged
        {
            var bv = BitVector64.FromScalar(uint64(in src));
            return Unsafe.As<BitVector64,V>(ref bv);
        }


        /// <summary>
        /// Creates a type-parametric fixed-length bitvector from a non-parametric bitvector
        /// </summary>
        /// <param name="s">The scalar value</param>
        /// <typeparam name="V">The nonparametric vector of fixed size</typeparam>
        /// <typeparam name="S">A supported scalar type</typeparam>
        [MethodImpl(Inline)]
        static PrimalBits<V,S> fromVector<V,S>(in V v, S rep = default)
            where V : unmanaged, IFixedScalarBits<V,S>
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


    }
}