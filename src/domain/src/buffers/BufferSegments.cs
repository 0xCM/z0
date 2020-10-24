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

    [ApiHost(ApiNames.BufferSegments)]
    public readonly struct BufferSegments
    {
        public static string format<T>(BufferSegments<T> src)
            where T : unmanaged
        {
            var dst = Buffers.text();
            dst.Append("<<");
            for(var i=0u; i<src.SegCount; i++)
                dst.Append(src.Range(i).Format());
            dst.Append(">>");
            return dst.Emit();
        }

        [MethodImpl(Inline)]
        public static BufferSegment<K,T> segment<K,T>(K i0, K i1, T t = default)
            where K : unmanaged
            where T : unmanaged
                => new BufferSegment<K,T>(i0,i1);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BufferSegment<T> segment<T>(uint i0, uint i1, T t = default)
            where T : unmanaged
                => segment<uint,T>(i0,i1);

        [MethodImpl(Inline), Op]
        public static BufferSegment segment(uint i0, uint i1)
            => segment<uint,byte>(i0,i1);
    }
}