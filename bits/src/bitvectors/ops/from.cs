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

    partial class BitVector
    {
        [MethodImpl(Inline)]
        public static BitVector128<N,T> from<N,T>(BitString src, N128 n = default, T zero = default)
            where T : unmanaged   
            where N : unmanaged, ITypeNat
                => DataBlocks.safeload(n,src.Pack().As<byte, T>()).LoadVector();

        [MethodImpl(Inline)]
        public static BitVector4 from(N4 n, byte src)
            => src;

        [MethodImpl(Inline)]
        public static BitVector4 from(N4 n, ushort src)
            => (byte)src;

        [MethodImpl(Inline)]
        public static BitVector4 from(N4 n, uint src)
            => (byte)src;

        [MethodImpl(Inline)]
        public static BitVector4 from(N4 n, ulong src)
            => (byte)src;

        [MethodImpl(Inline)]
        public static BitVector4 direct(N4 n, ulong src)
            => new BitVector4((byte)src, true);
        
        /// <summary>
        /// Creates a 4-bit bitvector from explicit bitss
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector4 from(N4 n, bit b0, bit b1)
        {
            var data = 0u;
            if(b0) 
                data |= (1 << 0);
            if(b1) 
                data |= (1 << 1);

            return (byte)data;
        }

        [MethodImpl(Inline)]
        public static BitVector4 from(N4 n, BitString src)
            => new BitVector4(src.IsEmpty ? (byte)0 : src.Pack()[0]);            

        /// <summary>
        /// Creates a 4-bit bitvector from explicit bitss
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector4 from(N4 n, bit b0, bit b1, bit b2)
        {
            var data = from(n4,b0,b1);
            if(b2) 
                data |= (1 << 2);
            return (byte)data;
        }

        /// <summary>
        /// Creates a 4-bit bitvector from 4 explicit bits
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector4 from(N4 n, bit b0, bit b1, bit b2, bit b3)
        {
            var data = from(n,b0,b1,b2);
            if(b3) 
                data |= (1 << 3);
            return data;
        }

        /// <summary>
        /// Creates a vector from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector8 from(N8 n, BitString src)
            => src.TakeUInt8();

        /// <summary>
        /// Creates an 8-bit bitvector from 4 explicit bits
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector8 from(N8 n, bit b0, bit b1, bit b2, bit b3)
            => (byte)Bits.pack(b0, b1, b2, b3);

        /// <summary>
        /// Creates an 8-bit bitvector from 8 explicit bits
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector8 from(N8 n, bit b0, bit b1, bit b2, bit b3, bit b4, bit b5, bit b6, bit b7)
            => (byte)Bits.pack(b0, b1, b2, b3, b4, b5, b6, b7);

        /// <summary>
        /// Creates an 8-bit bitvector from 8 explicit bits
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector8 from(N8 n, int b0, int b1, int b2, int b3, int b4, int b5, int b6, int b7)
            => (byte)Bits.pack((bit)b0, (bit)b1, (bit)b2, (bit)b3, (bit)b4, (bit)b5, (bit)b6, (bit)b7);

        /// <summary>
        /// Creates an 8-bit bitvector from a byte
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector8 from(N8 n, byte src)
            => new BitVector8(src);

        /// <summary>
        /// Creates an 8-bit bitvector from the least 4 bits of an integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector8 from(N8 n, int src)
            => new BitVector8((byte)src);

        /// <summary>
        /// Creates an 8-bit bitvector from the least 4 bits of an unsigned integer
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector8 from(N8 n, uint src)
            => new BitVector8((byte)src);

        /// <summary>
        /// Creates a vector from the least 8 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector8 from(N8 n, ulong src)
            => new BitVector8((byte)src);

        /// <summary>
        /// Creates a vector from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector16 from(N16 n, BitString src)
            => src.TakeUInt16();

        [MethodImpl(Inline)]
        public static BitVector16 from(N16 n, byte lo, byte hi)
            => new BitVector16((ushort)((ushort)hi << 8 | (ushort)lo));

        [MethodImpl(Inline)]
        public static BitVector16 from(N16 n, ulong src)
            => new BitVector16((ushort)src);

        [MethodImpl(Inline)]
        public static BitVector32 from(N32 n, uint src)
            => new BitVector32(src);

        [MethodImpl(Inline)]
        public static BitVector32 from(N32 n, int src)
            => new BitVector32((uint)src);

        [MethodImpl(Inline)]
        public static BitVector32 from(N32 n, long src)
            => new BitVector32((uint)src);

        [MethodImpl(Inline)]
        public static BitVector32 from(N32 n, ulong src)
            => new BitVector32((uint)src);

        /// <summary>
        /// Creates a vector from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector32 from(N32 n, BitString src)
            => src.TakeUInt32();

        /// <summary>
        /// Creates a vector from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector32 from(N32 n, byte x0, byte x1, byte x2, byte x3)
            => new BitVector32(Bits.pack(x0,x1,x2,x3));

        /// <summary>
        /// Creates a vector from a bit parameter array
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector32 from(N32 n, params bit[] src)
        {
            var data = 0u;
            return Bits.pack(src, ref data);
        }

        /// <summary>
        /// Creates a vector from two unsigned 16-bit integers
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector32 from(N32 n, ushort lo, ushort hi)
            => from(n, (uint)hi << 16 | (uint)lo);

        /// <summary>
        /// Creates a generic bitvector from 4 explicit bytes
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector64 from(N64 n, ushort x0, ushort x1, ushort x2, ushort x3)
            => Bits.pack(x0,x1,x2,x3);

        /// <summary>
        /// Creates a 64-bit bitvector where the first 8 bits a populated with a specified value and 
        /// all others are zero
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 from(N64 n, byte src)
            => new BitVector64(src);    

        /// <summary>
        /// Creates a vector from a primal source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 from(N64 n, ushort src)
            => new BitVector64(src);    

        /// <summary>
        /// Creates a vector from a primal source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 from(N64 n, uint src)
            => new BitVector64(src);    

        /// <summary>
        /// Creates a vector from a primal source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 from(N64 n, ulong src)
            => new BitVector64(src);    

        /// <summary>
        /// Creates a vector from two unsigned 32-bit integers
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector64 from(N64 n, uint lo, uint hi)
            => from(n,(ulong)hi << 32 | (ulong)lo);

        /// <summary>
        /// Creates a vector from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector64 from(N64 n, BitString src)
            => src.TakeUInt64();

        /// <summary>
        /// Creates a vector from a primal source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector128 from(N128 n, byte src)
            => from(n,(ulong)src);

        /// <summary>
        /// Creates a vector from a primal source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector128 from(N128 n, ushort src)
            => from(n,(ulong)src);

        /// <summary>
        /// Creates a vector from a primal source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector128 from(N128 n, uint src)
            => from(n,(ulong)src);

        /// <summary>
        /// Creates a vector from a primal source value
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector128 from(N128 n, ulong lo)
            => new BitVector128(lo,0);

        /// <summary>
        /// Creates a vector from two unsigned 64-bit integers
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector128 from(N128 n, uint x0, uint x1, uint x2, uint x3)
            => new BitVector128(x0,x1,x2,x3);

        /// <summary>
        /// Creates a vector from two unsigned 64-bit integers
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector128 from(N128 n, ulong lo, ulong hi)
            => new BitVector128(lo,hi);

        /// <summary>
        /// Creates a vector from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline)]
        public static BitVector128 from(N128 n, BitString src)
        {
            var x0 = src.TakeUInt64(0);            
            var x1 = src.Length > 64 ? src.TakeUInt64(64) : 0ul;
            return from(n,x0, x1);
        }
    }
}