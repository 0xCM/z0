//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Collections.Generic;
    using System.Linq;
    
    using static Konst;
    using static Typed;

    public static class BitStringX
    {
        public static BitString ToBitString(this string src)
            => BitString.parse(src);
            
        public static string Format(this Utf8AsciPoint src)
        {
            var bits = src.Code.FormatBits();
            var num = src.Code.FormatHex();
            var str = src.IsControl ? "___"  : $"'{src.ToChar()}'";
            return $"{num} {bits} {str}";
        }        
                
        /// <summary>
        /// Transforms an primal enumerator into a bitstream
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static IEnumerable<bit> ToBitStream<T>(this IEnumerator<T> src)
            where T : unmanaged
        {
            while(src.MoveNext())
            {
                var bs = BitString.scalar(src.Current);
                for(var i = 0; i< 64; i++)
                    yield return bs[i];                                    
            }
        }

        /// <summary>
        /// Transforms an primal source stream into a bitstream
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<bit> ToBitStream<T>(this IEnumerable<T> src)
            where T : unmanaged
                => src.GetEnumerator().ToBitStream();

        /// <summary>
        /// Converts the source value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this sbyte src, int? maxbits = null)
            => BitString.scalar(src, maxbits);

        /// <summary>
        /// Converts the source value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this byte src, int? maxbits = null)
            => BitString.scalar(src, maxbits);

        /// <summary>
        /// Converts the source value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this short src, int? maxbits = null)
            => BitString.scalar(src, maxbits);

        /// <summary>
        /// Converts the source value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this ushort src, int? maxbits = null)
            => BitString.scalar(src, maxbits);

        /// <summary>
        /// Converts the source value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this int src, int? maxbits = null)
            => BitString.scalar(src, maxbits);

        /// <summary>
        /// Converts the source value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this uint src, int? maxbits = null)
            => BitString.scalar(src, maxbits);

        /// <summary>
        /// Converts the source value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this long src, int? maxbits = null)
            => BitString.scalar(src, maxbits);

        /// <summary>
        /// Converts the source value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this ulong src, int? maxbits = null)
            => BitString.scalar(src, maxbits);

        /// <summary>
        /// Converts the source value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this float src, int? maxbits = null)
            => BitString.scalar(src, maxbits);

        /// <summary>
        /// Converts the source value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this double src, int? maxbits = null)
            => BitString.scalar(src, maxbits);

        /// <summary>
        /// Converts a span of bits to a to a bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]        
        public static BitString ToBitString(this Span<bit> src)
            => BitString.load((ReadOnlySpan<bit>)src); 

        /// <summary>
        /// Converts a readonly span of bits to a bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]        
        public static BitString ToBitString(this ReadOnlySpan<bit> src)
            => BitString.load(src);

        /// <summary>
        /// Converts span content to a to a bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]        
        public static BitString ToBitString<T>(this Span<T> src, int? maxbits = null)
            where T : unmanaged
                => BitString.scalars(src, maxbits); 

        /// <summary>
        /// Converts blocked content to a bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]        
        public static BitString ToBitString<T>(this Block64<T> src, int? maxbits = null)
            where T : unmanaged
                => BitString.scalars(src.Data, maxbits ?? w64);

        /// <summary>
        /// Converts blocked content to a bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]        
        public static BitString ToBitString<T>(this Block128<T> src, int? maxbits = null)
            where T : unmanaged
                => BitString.scalars(src.Data, maxbits ?? w128);

        /// <summary>
        /// Converts datablock content to a bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]        
        public static BitString ToBitString<T>(this Block256<T> src, int? maxbits = null)
            where T : unmanaged
                => BitString.scalars(src.Data, maxbits ?? w256);    
 
        /// <summary>
        /// Converts an 128-bit intrinsic vector representation to a bistring
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The underlying primal type</typeparam>
        [MethodImpl(Inline)]   
        public static BitString ToBitString<T>(this Vector128<T> src, int? maxbits = null)
            where T : unmanaged 
                => BitString.load(src, maxbits);
        
        /// <summary>
        /// Converts an 256-bit vector representation to a bistring
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The underlying primal type</typeparam>
        [MethodImpl(Inline)]   
        public static BitString ToBitString<T>(this Vector256<T> src, int? maxbits = null)
            where T : unmanaged        
                => BitString.load(src, maxbits);

        /// <summary>
        /// Converts a 512-bit vector representation to a bistring
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The underlying primal type</typeparam>
        [MethodImpl(Inline)]   
        public static BitString ToBitString<T>(this Vector512<T> src, int? maxbits = null)
            where T : unmanaged        
                => BitString.load(src, maxbits);

        /// <summary>
        /// Converts an enumeration value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The enumeration type</typeparam>
        [MethodImpl(Inline)]   
        public static BitString ToBitString<T>(this T src, int? maxbits = null)
            where T : unmanaged, Enum
                => BitString.@enum(src, maxbits);

        /// <summary>
        /// Reverses the order of the source bits
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]   
        public static BitString Reverse(this BitString src)
        {
            src.BitSeq.Reverse();
            return src;
        }

        /// <summary>
        /// Extracts the even bits
        /// </summary>
        [MethodImpl(Inline)]
        public static BitString Even(this BitString src)
            => BitString.even(src);

        /// <summary>
        /// Extracts the odd bits
        /// </summary>
        [MethodImpl(Inline)]
        public static BitString Odd(this BitString src)
            => BitString.odd(src);

        [MethodImpl(Inline)]
        public static BitString Intersperse(this BitString src, BitString value)
            => BitString.intersperse(src,value);
        
        [MethodImpl(Inline)]
        public static BitString Clear(this BitString src, int i0, int i1)
            => BitString.clear(src,i0,i1);

        [MethodImpl(Inline)]
        public static BitString BitMap(this BitString dst, BitString src, int start, int len)
            => BitString.inject(src,dst,start,len);

        [MethodImpl(Inline)]
        public static BitString Not(this BitString bs)
            => BitString.not(bs);

        [MethodImpl(Inline)]
        public static BitString And(this BitString xbs, BitString ybs)
            => BitString.and(xbs,ybs);

        [MethodImpl(Inline)]
        public static BitString Or(this BitString xbs, BitString ybs)
            => BitString.or(xbs,ybs);

        [MethodImpl(Inline)]
        public static BitString Xor(this BitString xbs, BitString ybs)
            => BitString.xor(xbs,ybs);
        
        [MethodImpl(Inline)]
        public static BitString Srl(this BitString bs, int shift)
            => BitString.srl(bs,shift);

        [MethodImpl(Inline)]
        public static BitString Sll(this BitString bs, int shift) 
            => BitString.sll(bs,shift);

        /// <summary>
        /// Rotates the bits leftwards by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        public static BitString RotL(this BitString bs, int offset)
            => BitString.rotl(bs, offset);
    }
}