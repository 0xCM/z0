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
    using static z;
    using static Typed;

    public static class SpanTake
    {
        /// <summary>
        /// Reads a partial value if there aren't a sufficient number of bytes to comprise a target value
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target type</typeparam>
        public static T Take<T>(this Span<byte> src)
            where T : struct
        {
            if(src.Length == 0)
                return default;

            var tsize = z.size<T>();
            var srclen = src.Length;
            if(srclen >= tsize)
                return read<T>(src);
            else
            {
                var remaining = tsize - src.Length;
                var storage = default(T);
                ref var dst = ref z.@as<T,byte>(storage);
                for(var i=0u; i<src.Length; i++)
                    z.seek(dst,i) = z.skip(src,i);
                return storage;
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
                => first(w8, src);

        [MethodImpl(Inline)]
        public static byte TakeUInt8<T>(this Span<T> src)
            where T : unmanaged        
                => first(w8, src);

        [MethodImpl(Inline)]
        public static ushort TakeUInt16<T>(this Span<T> src)
            where T : unmanaged        
                => first(w16, src);

        [MethodImpl(Inline)]
        public static uint TakeUInt32<T>(this ReadOnlySpan<T> src)
            where T : unmanaged
                => first(w32, src);

        [MethodImpl(Inline)]
        public static uint TakeUInt24<T>(this ReadOnlySpan<T> src)
            where T : unmanaged
        {
            var storage = 0u;
            ref var dst = ref z.@as<uint,byte>(storage);
            ref readonly var src8 = ref z.first(w8, src);
            seek(dst,0) = skip(src8,0);
            seek(dst,1) = skip(src8,1);
            seek(dst,2) = skip(src8,2);
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
                => first(w32, src);

        [MethodImpl(Inline)]
        public static ulong TakeUInt64<T>(this ReadOnlySpan<T> src)
            where T : unmanaged
                => first(w64, src);

        [MethodImpl(Inline)]
        public static ulong TakeUInt64<T>(this Span<T> src)
            where T : unmanaged        
                => first(w64, src);
    }
}