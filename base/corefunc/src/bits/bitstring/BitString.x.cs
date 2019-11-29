//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public static class BitStringX
    {
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
        /// Converts the source value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this sbyte src, int? maxbits = null)
            => BitString.scalar(src);

        /// <summary>
        /// Converts the source value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this byte src, int? maxbits = null)
            => BitString.scalar(src);

        /// <summary>
        /// Converts the source value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this short src, int? maxbits = null)
            => BitString.scalar(src);

        /// <summary>
        /// Converts the source value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this ushort src, int? maxbits = null)
            => BitString.scalar(src);

        /// <summary>
        /// Converts the source value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this int src, int? maxbits = null)
            => BitString.scalar(src);

        /// <summary>
        /// Converts the source value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this uint src, int? maxbits = null)
            => BitString.scalar(src);

        /// <summary>
        /// Converts the source value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this long src, int? maxbits = null)
            => BitString.scalar(src);

        /// <summary>
        /// Converts the source value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this ulong src, int? maxbits = null)
            => BitString.scalar(src);

        /// <summary>
        /// Converts the source value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this float src, int? maxbits = null)
            => BitString.scalar(src);

        /// <summary>
        /// Converts the source value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this double src, int? maxbits = null)
            => BitString.scalar(src);

        /// <summary>
        /// Converts a bitspan to a to a bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]        
        public static BitString ToBitString(this Span<bit> src)
            => BitString.from((ReadOnlySpan<bit>)src); 

        /// <summary>
        /// Converts a readonly bitspan to a bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]        
        public static BitString ToBitString(this ReadOnlySpan<bit> src)
            => BitString.from(src);

        /// <summary>
        /// Converts a readonly bitspan to a bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]        
        public static BitString ToBitString(this bit[] src)
            => BitString.from(src);

        /// <summary>
        /// Converts span content to a to a bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]        
        public static BitString ToBitString<T>(this Span<T> src, int? maxbits = null)
            where T : unmanaged
                => BitString.from(src, maxbits); 

        /// <summary>
        /// Converts datablock content to a bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]        
        public static BitString ToBitString<T>(this Block64<T> src)
            where T : unmanaged
                => BitString.from(src.Data);

        /// <summary>
        /// Converts datablock content to a bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]        
        public static BitString ToBitString<T>(this Block64<T> src, int? maxbits = null)
            where T : unmanaged
                => BitString.from(src.Data, maxbits ?? Block64<T>.N);

        /// <summary>
        /// Converts datablock content to a bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]        
        public static BitString ToBitString<T>(this Block128<T> src, int? maxbits = null)
            where T : unmanaged
                => BitString.from(src.Data, maxbits ?? Block128<T>.N);

        /// <summary>
        /// Converts datablock content to a bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]        
        public static BitString ToBitString<T>(this Block256<T> src, int? maxbits = null)
            where T : unmanaged
                => BitString.from(src.Data, maxbits ?? Block256<T>.N);

        /// <summary>
        /// Converts datablock content to a bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]        
        public static BitString ToBitString<T>(this ConstBlock64<T> src, int? maxbits = null)
            where T : unmanaged
                => BitString.from(src.Data, maxbits ?? ConstBlock64<T>.N);

        /// <summary>
        /// Converts datablock content to a bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]        
        public static BitString ToBitString<T>(this ConstBlock128<T> src, int? maxbits = null)
            where T : unmanaged
                => BitString.from(src.Data, maxbits ?? ConstBlock128<T>.N);

        /// <summary>
        /// Converts datablock content to a bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]        
        public static BitString ToBitString<T>(this ConstBlock256<T> src, int? maxbits = null)
            where T : unmanaged
                => BitString.from(src.Data, maxbits ?? ConstBlock256<T>.N);

        /// <summary>
        /// Converts a bitview to a bitstring
        /// </summary>
        /// <param name="src">The view source</param>
        /// <typeparam name="T">The data type on which the view is predicated</typeparam>
        [MethodImpl(Inline)]   
        public static BitString ToBitString<T>(this BitView<T> src)
            where T : unmanaged
                => src.Bytes.ToBitString();
    
        /// <summary>
        /// Converts a 128-bit unsigned integer to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this UInt128 src)
            => BitString.scalar(src.hi) + BitString.scalar(src.lo);
 
        /// <summary>
        /// Converts an 128-bit intrinsic vector representation to a bistring
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The underlying primal type</typeparam>
        [MethodImpl(Inline)]   
        public static BitString ToBitString<T>(this Vector128<T> src, int? maxbits = null)
            where T : unmanaged        
                => BitString.from(src.ToSpan(), maxbits);
        
        /// <summary>
        /// Converts an 256-bit intrinsic vector representation to a bistring
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The underlying primal type</typeparam>
        [MethodImpl(Inline)]   
        public static BitString ToBitString<T>(this Vector256<T> src, int? maxbits = null)
            where T : unmanaged        
                => BitString.from(src.ToSpan(), maxbits);        

        /// <summary>
        /// Extracts the even bits
        /// </summary>
        public static BitString Even(this BitString src)
            => BitString.even(src);

        /// <summary>
        /// Extracts the odd bits
        /// </summary>
        public static BitString Odd(this BitString src)
            => BitString.odd(src);

        public static BitString Intersperse(this BitString lhs, BitString rhs)
        {
            var len = Math.Min(lhs.Length, rhs.Length);            
            var dst = BitString.alloc(len*2);
            for(int i=0, j=0; i< dst.Length; i+=2, j++)
            {
                dst[i] = lhs[j];

                if(i+1 < dst.Length)
                    dst[i+1] = rhs[j];
            }
            return dst;
        }
        
        public static BitString Clear(this BitString src, int i0, int i1)
        {
            for(var i=i0; i<=i1; i++)
                src[i] = off;
            return src;
        }

        public static BitString Inject(this BitString dst, BitString src, int start, int len)
        {
            for(int i=start, j=0; i< start + len; i++, j++)
                dst[i] = src[j];
            return dst;
        }

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

        public static BitString Transpose<M,N>(this BitString bs, M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => BitString.transpose(bs,m,n);
        
        public static BitString Transpose(this BitString bs, int m, int n)        
            => BitString.transpose(bs,m,n);                    
    }
}