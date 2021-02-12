//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct gpack
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T pack32x1<T>(Span<uint> src)
            where T : unmanaged
                => pack32x1_u<T>(src);

        [MethodImpl(Inline)]
        static T pack32x1_u<T>(Span<uint> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(BitPack.pack8x32x1(src));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(BitPack.pack16x32x1(src));
            else if(typeof(T) == typeof(uint))
                return generic<T>(BitPack.pack32x32x1(src));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(BitPack.pack64x32x1(src));
            else
                return pack32x1_i<T>(src);
        }

        [MethodImpl(Inline)]
        static T pack32x1_i<T>(Span<uint> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return Numeric.force<T>(BitPack.pack8x32x1(src));
            else if(typeof(T) == typeof(short))
                return Numeric.force<T>(BitPack.pack16x32x1(src));
            else if(typeof(T) == typeof(int))
                return Numeric.force<T>(BitPack.pack32x32x1(src));
            else if(typeof(T) == typeof(long))
                return Numeric.force<T>(BitPack.pack64x32x1(src));
            else
                throw no<T>();
        }

    }
}