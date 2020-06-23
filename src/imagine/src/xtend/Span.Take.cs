//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    
    public static class SpanTake
    {
        /// <summary>
        /// Reads a partial value if there aren't a sufficient number of bytes to comprise a target value
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target type</typeparam>
        public static T TakeScalar<T>(this Span<byte> src)
            where T : unmanaged
        {
            if(src.Length == 0)
                return default;

            var tsize = Unsafe.SizeOf<T>();
            var srclen = src.Length;
            if(srclen >= tsize)
                return MemoryMarshal.Read<T>(src);
            else
            {
                var remaining = tsize - src.Length;
                Span<T> dst = stackalloc T[1];
                src.CopyTo(dst.Bytes());            
                return dst[0];
            }
        }

        /// <summary>
        /// Copies at most n bytes from the source span to the target span where n is the length of the target span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline)]
        public static Span<byte> TakeBytes(this ReadOnlySpan<byte> src, Span<byte> dst)
        {
            if(src.Length > dst.Length)
                src.Slice(0,dst.Length).CopyTo(dst);
            else
                src.CopyTo(dst);
            return dst;
        }

        [MethodImpl(Inline)]
        public static byte TakeUInt8<T>(this ReadOnlySpan<T> src)
            where T : unmanaged        
                => As.first(default(W8),src);

        [MethodImpl(Inline)]
        public static byte TakeUInt8<T>(this Span<T> src)
            where T : unmanaged        
                => As.first(default(W8),src);

        [MethodImpl(Inline)]
        public static ushort TakeUInt16<T>(this Span<T> src)
            where T : unmanaged        
                => As.first(default(W16),src);

        [MethodImpl(Inline)]
        public static uint TakeUInt32<T>(this ReadOnlySpan<T> src)
            where T : unmanaged
                => As.first(default(W32),src);

        [MethodImpl(Inline)]
        public static uint TakeUInt24<T>(this ReadOnlySpan<T> src)
            where T : unmanaged
        {
            var storage = 0u;
            ref var dst = ref As.@as<uint,byte>(ref storage);
            ref readonly var src8 = ref As.first(default(W8),src);
            AsInternal.seek(ref dst,0) = AsInternal.skip(src8,0);
            AsInternal.seek(ref dst,1) = AsInternal.skip(src8,1);
            AsInternal.seek(ref dst,2) = AsInternal.skip(src8,2);
            return storage;
        }
        
        /// <summary>
        /// Converts the leading elements of a primal source span to a 24-bit usigned integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static uint TakeUInt24<T>(this Span<T> src)
            where T : unmanaged        
                => src.ReadOnly().TakeUInt24();

        [MethodImpl(Inline)]
        public static uint TakeUInt32<T>(this Span<T> src)
            where T : unmanaged        
                => As.first(default(W32), src);

        [MethodImpl(Inline)]
        public static ulong TakeUInt64<T>(this ReadOnlySpan<T> src)
            where T : unmanaged
                => As.first(default(W64),src);

        [MethodImpl(Inline)]
        public static ulong TakeUInt64<T>(this Span<T> src)
            where T : unmanaged        
                => As.first(default(W64),src);
    }
}