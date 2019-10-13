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

    public static class gbv
    {
        /// <summary>
        /// Allocates a new primal bitvector
        /// </summary>
        /// <typeparam name="V">The primal bitvector type</typeparam>
        [MethodImpl(Inline)]
        public static V alloc<V>()
            where V : unmanaged, IBitVector<V>
        {
            if(typeof(V) == typeof(BitVector8))
                return generic<V>(bv8(0));
            else if(typeof(V) == typeof(BitVector16))                
                return generic<V>(bv16(0));
            else if(typeof(V) == typeof(BitVector32))                
                return generic<V>(bv32(0));
            else if(typeof(V) == typeof(BitVector64))                
                return generic<V>(bv64(0));
            else    
                throw unsupported<V>();
        }

        /// <summary>
        /// Initializes a primal bitvector with a scalar value
        /// </summary>
        /// <param name="scalar">The scalar value</param>
        /// <typeparam name="V">The primal bitvector type</typeparam>
        /// <typeparam name="T">The primal scalar type</typeparam>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static V init<V,T>(T scalar)
            where V : unmanaged, IBitVector<V>
            where T : unmanaged
        {
            if(typeof(V) == typeof(BitVector8))
                return generic<V>(bv8(scalar));
            else if(typeof(V) == typeof(BitVector16))                
                return generic<V>(bv16(scalar));
            else if(typeof(V) == typeof(BitVector32))                
                return generic<V>(bv32(scalar));
            else if(typeof(V) == typeof(BitVector64))                
                return generic<V>(bv64(scalar));
            else    
                throw unsupported<V>();
        }

        /// <summary>
        /// Returns the bitvector width
        /// </summary>
        /// <typeparam name="V">The primal bitvector type</typeparam>
        [MethodImpl(Inline)]
        public static BitSize width<V>()
            where V : unmanaged, IBitVector<V>
                => bitsize<V>();    

        [MethodImpl(Inline)]
        public static V and<V>(V x, V y)
            where V : unmanaged, IBitVector<V>
                => x.And(y);

        [MethodImpl(Inline)]
        public static V nand<V>(V x, V y)
            where V : unmanaged, IBitVector<V>
                => x.Nand(y);

        [MethodImpl(Inline)]
        public static V andnot<V>(V x, V y)
            where V : unmanaged, IBitVector<V>
                => x.AndNot(y);

        [MethodImpl(Inline)]
        public static V or<V>(V x, V y)
            where V : unmanaged, IBitVector<V>
                => x.Or(y);

        [MethodImpl(Inline)]
        public static V nor<V>(V x, V y)
            where V : unmanaged, IBitVector<V>
                => x.Nor(y);

        [MethodImpl(Inline)]
        public static V xor<V>(V x, V y)
            where V : unmanaged, IBitVector<V>
                => x.XOr(y);

        [MethodImpl(Inline)]
        public static V xnor<V>(V x, V y)
            where V : unmanaged, IBitVector<V>
                => x.XNor(y);

        [MethodImpl(Inline)]
        public static V select<V>(V x, V y, V z)
            where V : unmanaged, IBitVector<V>
                => x.Select(y,z);

        [MethodImpl(Inline)]
        public static V not<V>(V x)
            where V : unmanaged, IBitVector<V>
                => x.Not();

        [MethodImpl(Inline)]
        public static V negate<V>(V x)
            where V : unmanaged, IBitVector<V>
                => x.Negate();

        [MethodImpl(Inline)]
        public static V inc<V>(V x)
            where V : unmanaged, IBitVector<V>
                => x.Inc();

        [MethodImpl(Inline)]
        public static V dec<V>(V x)
            where V : unmanaged, IBitVector<V>
                => x.Dec();

        [MethodImpl(Inline)]
        public static V sll<V>(V x, int offset)
            where V : unmanaged, IBitVector<V>
                => x.Sll(offset);

        [MethodImpl(Inline)]
        public static V srl<V>(V x, int offset)
            where V : unmanaged, IBitVector<V>
                => x.Srl(offset);

        [MethodImpl(Inline)]
        public static V rotl<V>(V x, int offset)
            where V : unmanaged, IBitVector<V>
                => x.Rotl(offset);

        [MethodImpl(Inline)]
        public static V rotr<V>(V x, int offset)
            where V : unmanaged, IBitVector<V>
                => x.Rotr(offset);

        [MethodImpl(Inline)]
        public static V xor1<V>(V x)
            where V : unmanaged, IBitVector<V>
        {
            if(typeof(V) == typeof(BitVector8))
                return generic<V>(bv(gmath.xor1(sc8(x))));
            else if(typeof(V) == typeof(BitVector16))
                return generic<V>(bv(gmath.xor1(sc16(x))));
            else if(typeof(V) == typeof(BitVector32))
                return generic<V>(bv(gmath.xor1(sc32(x))));
            else if(typeof(V) == typeof(BitVector64))
                return generic<V>(bv(gmath.xor1(sc64(x))));
            else 
                throw unsupported<V>();
        }                

        /// <summary>
        /// Extracts the scalar value over which a primal bitvector is defined
        /// </summary>
        /// <param name="v">The bitvector</param>
        /// <typeparam name="V">The primal bitvector type</typeparam>
        /// <typeparam name="T">The primal scalar type</typeparam>
        [MethodImpl(Inline)]
        static T scalar<V,T>(V v)
            where T : unmanaged
            where V : unmanaged, IBitVector<V>
        {
            if(typeof(V) == typeof(BitVector8))
                return As.generic<T>(sc8(v));
            else if(typeof(V) == typeof(BitVector16))                
                return As.generic<T>(sc16(v));
            else if(typeof(V) == typeof(BitVector32))                
                return As.generic<T>(sc32(v));
            else if(typeof(V) == typeof(BitVector64))                
                return As.generic<T>(sc64(v));
            else    
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        public static ref V generic<V>(in BitVector8 bv)
            => ref Unsafe.As<BitVector8,V>(ref asRef(in bv));

        [MethodImpl(Inline)]
        public static ref V generic<V>(in BitVector16 bv)
            => ref Unsafe.As<BitVector16,V>(ref asRef(in bv));

        [MethodImpl(Inline)]
        public static ref V generic<V>(in BitVector32 bv)
            => ref Unsafe.As<BitVector32,V>(ref asRef(in bv));

        [MethodImpl(Inline)]
        public static ref V generic<V>(in BitVector64 bv)
            => ref Unsafe.As<BitVector64,V>(ref asRef(in bv));

        [MethodImpl(Inline)]
        static ref BitVector8 bv8<V>(in V src)
            where V : unmanaged        
                => ref Unsafe.As<V,BitVector8>(ref asRef(in src));        

        [MethodImpl(Inline)]
        static ref BitVector16 bv16<V>(in V src)
            where V : unmanaged        
                => ref Unsafe.As<V,BitVector16>(ref asRef(in src));
        
        [MethodImpl(Inline)]
        static ref BitVector32 bv32<V>(in V src)
            where V : unmanaged        
                => ref Unsafe.As<V,BitVector32>(ref asRef(in src));

        [MethodImpl(Inline)]
        static ref BitVector64 bv64<V>(in V src)
            where V : unmanaged        
                => ref Unsafe.As<V,BitVector64>(ref asRef(in src));

        [MethodImpl(Inline)]
        static BitVector8 bv(byte src)
            => src;

        [MethodImpl(Inline)]
        static BitVector8 bv8(byte src)
            => src;

        [MethodImpl(Inline)]
        static BitVector8 bv8(int src)
            => (byte)src;

        [MethodImpl(Inline)]
        static BitVector16 bv(ushort src)
            => src;

        [MethodImpl(Inline)]
        static BitVector16 bv16(ushort src)
            => src;

        [MethodImpl(Inline)]
        static BitVector16 b16(int src)
            => (ushort)src;

        [MethodImpl(Inline)]
        static BitVector32 bv(uint src)
            => src;

        [MethodImpl(Inline)]
        static BitVector32 bv32(uint src)
            => src;

        [MethodImpl(Inline)]
        static BitVector64 bv(ulong src)
            => src;

        [MethodImpl(Inline)]
        public static BitVector64 bv64(ulong src)
            => src;

        [MethodImpl(Inline)]
        public static byte sc8<V>(in V src)
            where V : unmanaged        
                => Unsafe.As<V,BitVector8>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ushort sc16<V>(in V src)
            where V : unmanaged        
                => Unsafe.As<V,BitVector16>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static uint sc32<V>(in V src)
            where V : unmanaged        
                => Unsafe.As<V,BitVector32>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ulong sc64<V>(in V src)
            where V : unmanaged        
                => Unsafe.As<V,BitVector64>(ref asRef(in src));
    }
}