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
    using static As;
    using static AsIn;

    partial class gbits
    {
        /// <summary>
        /// Constructs a sequence of n characters {ci} := [c_n-1,..., c_0]
        /// over the domain {'0','1'} according to whether the bit in the i'th 
        /// position of the source is respecively disabled/enabled
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> bitchars<T>(in T src)
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return bitchars_u(src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return bitchars_i(src);
            else 
                return bitchars_f(src);            
        }

        [MethodImpl(Inline)]
        static ReadOnlySpan<char> bitchars_u<T>(in T src)
        {
            if(typeof(T) == typeof(byte))
                return BitStore.bitchars(uint8(in src));
            else if(typeof(T) == typeof(ushort))
                return bitchars(uint16(in src));
            else if(typeof(T) == typeof(uint))
                return bitchars(uint32(in src));
            else 
                return bitchars(uint64(in src));
        }

        [MethodImpl(Inline)]
        static ReadOnlySpan<char> bitchars_i<T>(in T src)
        {
            if(typeof(T) == typeof(sbyte))
                return BitStore.bitchars(int8(in src));
            else if(typeof(T) == typeof(short))
                return bitchars(int16(in src));
            else if(typeof(T) == typeof(int))
                return bitchars(int32(in src));
            else 
                return bitchars(int64(in src));
        }

        [MethodImpl(Inline)]
        static ReadOnlySpan<char> bitchars_f<T>(in T src)
        {
            if(typeof(T) == typeof(float))
                return bitchars(float32(in src));
            else if(typeof(T) == typeof(double))
                return bitchars(float64(in src));
            else            
                throw unsupported<T>();            
        }

        /// <summary>
        /// Converts a span of primal values to a span of characters, each of which represent a bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        public static Span<char> bitchars<T>(ReadOnlySpan<T> src, int? maxlen = null)
            where T : unmanaged
        {
            var seglen = Unsafe.SizeOf<T>()*8;
            Span<char> dst = new char[src.Length * seglen];
            for(var i=0; i<src.Length; i++)
                bitchars(src[i]).CopyTo(dst, i*seglen);
            return maxlen != null && dst.Length >= maxlen ?  dst.Slice(0,maxlen.Value) :  dst;
        }
        
        [MethodImpl(Inline)]
        public static Span<char> bitchars<T>(Span<T> src, int? maxlen = null)
            where T : unmanaged
                => bitchars(src.ReadOnly(), maxlen);    
        
        public static ref T parse<T>(ReadOnlySpan<char> src, int offset, out T dst)
            where T : unmanaged
        {            
            var last = Math.Min(Unsafe.SizeOf<T>()*8, src.Length) - 1;                                    
            dst = gmath.zero<T>();
            for(int i=offset, pos = 0; i<= last; i++, pos++)
                if(src[i] == Bit.One)
                    gbits.enable(ref dst, pos);                        
            return ref dst;
        }

        /// <summary>
        /// Constructs a sequence of 16 characters {ci} := [c15,...c0] over the domain {'0','1'} according to whether the
        /// bit in the i'th position of the source is respecively disabled/enabled
        /// </summary>
        /// <param name="value">The source value</param>
        [MethodImpl(Inline)]
        static ReadOnlySpan<char> bitchars(ushort src)
        {
            // const int len = 16;
            // const int midpoint = 8;
            //Bits.split(src, out var lo, out var hi);
            
            // Span<char> dst = new char[len];            
            // BitStore.bitchars(lo).CopyTo(dst,0);
            // BitStore.bitchars(hi).CopyTo(dst,midpoint);
            // return dst;            

            Bits.split(src, out var lo, out var hi);
            return BitStore.bitchars(lo).Concat(BitStore.bitchars(hi));

        }

        /// <summary>
        /// Constructs a sequence of 16 characters {ci} := [c15,...c0] over the domain {'0','1'} according to whether the
        /// bit in the i'th position of the source is respecively disabled/enabled
        /// </summary>
        /// <param name="value">The source value</param>
        [MethodImpl(Inline)]
        static ReadOnlySpan<char> bitchars(short src)
        {
            const int len = 16;
            const int midpoint = 8;
            (var lo, var hi) = Bits.split(src);
            Span<char> dst = new char[len];
            BitStore.bitchars(lo).CopyTo(dst,0);
            BitStore.bitchars(hi).CopyTo(dst,midpoint);
            return dst;            
        }

        [MethodImpl(Inline)]
        static ReadOnlySpan<char> bitchars(uint src)
        {
            // const int len = 32;
            // const int midpoint = 16;
            // Bits.split(src,out var lo, out var hi);
            // Span<char> dst = new char[len];
            // bitchars(lo).CopyTo(dst,0);
            // bitchars(hi).CopyTo(dst,midpoint);
            // return dst;            
            Bits.split(src, out var lo, out var hi);
            return bitchars(lo).Concat(bitchars(hi));

        }

        [MethodImpl(Inline)]
        static ReadOnlySpan<char> bitchars(int src)
        {
            const int len = 32;
            const int midpoint = 16;
            (var lo, var hi) = Bits.split(src);
            Span<char> dst = new char[len];
            bitchars(lo).CopyTo(dst,0);
            bitchars(hi).CopyTo(dst,midpoint);
            return dst;            
        }

        [MethodImpl(Inline)]
        static ReadOnlySpan<char> bitchars(ulong src)
        {
            // const int len = 64;
            // const int midpoint = 32;
            // Bits.split(src, out var lo, out var hi);
            // Span<char> dst = new char[len];
            // bitchars(lo).CopyTo(dst,0);
            // bitchars(hi).CopyTo(dst,midpoint);
            // return dst;            

            Bits.split(src, out var lo, out var hi);
            return bitchars(lo).Concat(bitchars(hi));

        }

        [MethodImpl(Inline)]
        static ReadOnlySpan<char> bitchars(long src)
        {
            const int len = 64;
            const int midpoint = 32;
            Bits.split(src,out var lo, out var hi);
            Span<char> dst = new char[len];
            bitchars(lo).CopyTo(dst,0);
            bitchars(hi).CopyTo(dst,midpoint);
            return dst;            
        }
 
        [MethodImpl(Inline)]
        static ReadOnlySpan<char> bitchars(float src)
            => bitchars(src.ToBits());
 
        [MethodImpl(Inline)]
        static ReadOnlySpan<char> bitchars(double src)
            => bitchars(src.ToBits());

    }
}