//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    [ApiHost]
    public readonly struct StructuredContent
    {
        [MethodImpl(Inline), Op]
        public static ContentSegment<StringRef,byte> seg(string id, byte min, byte max)
            => gseg(StringRefs.create(id), min, max);

        [MethodImpl(Inline), Op]
        public static ContentSegment<StringRef,uint> seg(string id, uint min, uint max)
            => gseg(StringRefs.create(id), min, max);

        [MethodImpl(Inline), Op]
        public static ContentSegment<StringRef,ulong> seg(string id, ulong min, ulong max)
            => gseg(StringRefs.create(id), min, max);

        [MethodImpl(Inline), Op]
        public static ContentSegment<char,uint> seg(char id, uint min, uint max)
            => gseg(id,min,max);

        [MethodImpl(Inline), Op]
        public static ContentSegment<ulong,uint> seg(ulong id, uint min, uint max)
            => gseg(id,min,max);

        [MethodImpl(Inline), Op]
        public static ContentSegment<byte,byte> seg(byte id, byte min, byte max)
            => gseg(id,min,max);

        [MethodImpl(Inline), Op]
        public static ContentSegment<char,byte> seg(char id, byte min, byte max)
            => gseg(id,min,max);

        // [MethodImpl(Inline), Op]
        // public static ContentSegment seg(string id, uint min, uint max)
        //     => new ContentSegment(id, (min, max));

        [MethodImpl(Inline)]
        public static ContentSegment<T,W> gseg<T,W>(T id, W min, W max)
            where W : unmanaged
                => new ContentSegment<T,W>(id, (min, max));
    }
}