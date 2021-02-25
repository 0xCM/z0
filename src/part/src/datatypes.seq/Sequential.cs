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

    [ApiHost]
    public readonly partial struct Sequential
    {
       const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static Seq16x2 create(ushort lo, ushort hi)
            => new Seq16x2(lo, hi);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Sequential<T> next<T>(in Sequential<T> src)
            where T : unmanaged
        {
            ref var dst = ref @edit(src);
            ref var value = ref dst.Lo;

            if(size<T>() == 1)
                uint8(ref value) = (byte)(uint8(value) + 1);
            else if(size<T>() == 2)
                uint16(ref value) = (ushort)(uint16(value) + 1);
            else if(size<T>() == 4)
                uint32(ref value) = uint32(value) + 1u;
            else if(size<T>() == 8)
                uint64(ref value) = uint64(value) + 1ul;
            else
                throw no<T>();

            return ref dst;
        }
    }
}