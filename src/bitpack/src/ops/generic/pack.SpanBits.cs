//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Konst;
    using static Memories;
    using static Vectors;
    
    partial class BitPack
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T pack<T>(Span<bit> src, T t = default)
            where T : unmanaged
                => pack_u<T>(src);

        [MethodImpl(Inline)]
        static T pack_u<T>(Span<bit> src)
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
        static T pack_i<T>(Span<bit> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return convert<T>(pack(src, n8));
            else if(typeof(T) == typeof(short))
                return convert<T>(pack(src, n16));
            else if(typeof(T) == typeof(int))
                return convert<T>(pack(src, n32));
            else if(typeof(T) == typeof(long))
                return convert<T>(pack(src, n64));
            else
                throw Unsupported.define<T>();            
        }
    }
}