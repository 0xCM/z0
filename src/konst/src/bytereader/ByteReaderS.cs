//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost]
    readonly struct ByteReaderS
    {
        [MethodImpl(Inline)]
        public static T read<T>(ReadOnlySpan<byte> src)
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(read(src, n1));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(read(src, n2));
            else if(typeof(T) == typeof(uint))
                return generic<T>(read(src, n4));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(read(src, n8));
            else
                return default;
        }
        
        [MethodImpl(Inline), Op]
        public static ulong read(ReadOnlySpan<byte> src, N1 n)
            => first(src);

        [MethodImpl(Inline), Op]
        public static ulong read(ReadOnlySpan<byte> src, N2 n)
            => first(recover<byte,ushort>(slice(src,2)));

        [MethodImpl(Inline), Op]
        public static ulong read(ReadOnlySpan<byte> src, N3 n)
            => first(recover<byte,uint24>(slice(src,3)));

        [MethodImpl(Inline), Op]
        public static ulong read(ReadOnlySpan<byte> src, N4 n)
            => first(recover<byte,uint>(slice(src,4)));

        [MethodImpl(Inline), Op]
        public static ulong read(ReadOnlySpan<byte> src, N5 n)
        {
            var dst = 0ul;
            seek32(dst, 0) = (uint)read(src,n4);
            seek32(dst, 1) = skip(src, 4);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static ulong read(ReadOnlySpan<byte> src, N6 n)
        {
            var dst = 0ul;
            seek32(dst, 0) = (uint)read(src, n4);
            seek32(dst, 1) = (uint)read(src, n2);
            return dst;        
        }

        [MethodImpl(Inline), Op]
        public static ulong read(ReadOnlySpan<byte> src, N7 n)
        {
            var dst = 0ul;
            seek32(dst, 0) = (uint)read(src, n4);
            seek32(dst, 1) = (uint)read(src, n3);
            return dst;        
        }

        [MethodImpl(Inline), Op]
        public static ulong read(ReadOnlySpan<byte> src, N8 n)
            => first(recover<byte,ulong>(src));
    }
}