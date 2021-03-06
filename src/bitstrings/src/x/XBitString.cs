//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Linq;

    using static Part;
    using static memory;

    public static class XBitString
    {
        /// <summary>
        /// Shuffles bitstring content as determined by a permutation
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="p">The permutation to apply</param>
        public static BitString Permute(this BitString src, Permute p)
        {
            var dst = BitString.alloc(p.Length);
            for(var i = 0; i<p.Length; i++)
                dst[i] = src[p[i]];
            return dst;
        }

        /// <summary>
        /// Pretends the source bitstring is an mxn matrix and computes the transposition matrix of dimension nxm encoded as a bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="m">The source row count</param>
        /// <param name="n">The source column count</param>
        public static BitString Transpose<M,N>(this BitString src, M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => BitString.transpose(src, nat64u(m), nat64u(n));

        public static BitString Transpose(this BitString bs, int m, int n)
            => BitString.transpose(bs,m,n);

        public static BitString ToBitString(this string src)
            => BitString.parse(src);

        public static string Format(this Utf8Point src)
        {
            var bits = src.Code.FormatBits();
            var num = src.Code.FormatHex();
            var str = src.IsControl ? "___"  : $"'{src.ToChar()}'";
            return $"{num} {bits} {str}";
        }

        /// <summary>
        /// Converts the source value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this sbyte src, uint? maxbits = null)
            => BitString.scalar(src, maxbits == null ? (int?)null : (int)maxbits.Value);

        /// <summary>
        /// Converts the source value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this byte src, uint? maxbits = null)
            => BitString.scalar(src, maxbits == null ? (int?)null : (int)maxbits.Value);

        /// <summary>
        /// Converts the source value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this short src, uint? maxbits = null)
            => BitString.scalar(src, maxbits == null ? (int?)null : (int)maxbits.Value);

        /// <summary>
        /// Converts the source value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this ushort src, uint? maxbits = null)
            => BitString.scalar(src, maxbits == null ? (int?)null : (int)maxbits.Value);

        /// <summary>
        /// Converts the source value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this int src, uint? maxbits = null)
            => BitString.scalar(src, maxbits == null ? (int?)null : (int)maxbits.Value);

        /// <summary>
        /// Converts the source value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this uint src, uint? maxbits = null)
            => BitString.scalar(src, maxbits == null ? (int?)null : (int)maxbits.Value);

        /// <summary>
        /// Converts the source value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this long src, uint? maxbits = null)
            => BitString.scalar(src, maxbits == null ? (int?)null : (int)maxbits.Value);

        /// <summary>
        /// Converts the source value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this ulong src, uint? maxbits = null)
            => BitString.scalar(src, maxbits == null ? (int?)null : (int)maxbits.Value);

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
        public static BitString ToBitString(this double src, uint? maxbits = null)
            => BitString.scalar(src, maxbits == null ? (int?)null : (int)maxbits.Value);

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
        public static BitString ToBitString<T>(this SpanBlock64<T> src, int? maxbits = null)
            where T : unmanaged
                => BitString.scalars(src.Storage, maxbits ?? w64);

        /// <summary>
        /// Converts blocked content to a bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString<T>(this SpanBlock128<T> src, int? maxbits = null)
            where T : unmanaged
                => BitString.scalars(src.Storage, maxbits ?? w128);

        /// <summary>
        /// Converts datablock content to a bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString<T>(this SpanBlock256<T> src, int? maxbits = null)
            where T : unmanaged
                => BitString.scalars(src.Storage, maxbits ?? w256);

        /// <summary>
        /// Converts an 128-bit intrinsic vector representation to a bitstring
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The underlying primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitString ToBitString<T>(this Vector128<T> src, int? maxbits = null)
            where T : unmanaged
                => BitString.load(src, maxbits);

        /// <summary>
        /// Converts an 256-bit vector representation to a bitstring
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The underlying primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitString ToBitString<T>(this Vector256<T> src, int? maxbits = null)
            where T : unmanaged
                => BitString.load(src, maxbits);

        /// <summary>
        /// Converts a 512-bit vector representation to a bitstring
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
        public static BitString RotL(this BitString bs, uint offset)
            => BitString.rotl(bs, offset);
    }
}