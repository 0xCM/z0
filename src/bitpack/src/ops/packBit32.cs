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

    partial class BitPack
    {

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T pack<T>(Span<Bit32> src, T t = default)
            where T : unmanaged
                => pack_u<T>(src);

        [MethodImpl(Inline)]
        static T pack_u<T>(Span<Bit32> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(pack(src, n8));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(pack(src, n16));
            else if(typeof(T) == typeof(uint))
                return generic<T>(pack(src, n32));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(pack(src, n64));
            else
                return pack_i<T>(src);
        }

        [MethodImpl(Inline)]
        static T pack_i<T>(Span<Bit32> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return force<T>(pack(src, n8));
            else if(typeof(T) == typeof(short))
                return force<T>(pack(src, n16));
            else if(typeof(T) == typeof(int))
                return force<T>(pack(src, n32));
            else if(typeof(T) == typeof(long))
                return force<T>(pack(src, n64));
            else
                throw no<T>();
        }
    }
}