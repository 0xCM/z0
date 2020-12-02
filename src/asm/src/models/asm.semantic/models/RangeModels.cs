//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly struct RangeModels
    {
        [MethodImpl(Inline), Op]
        public static RangeModel<StringRef,byte> seg(string id, byte min, byte max)
            => content(MemRefs.@string(id), min, max);

        [MethodImpl(Inline), Op]
        public static RangeModel<StringRef,uint> seg(string id, uint min, uint max)
            => content(MemRefs.@string(id), min, max);

        [MethodImpl(Inline), Op]
        public static RangeModel<StringRef,ulong> seg(string id, ulong min, ulong max)
            => content(MemRefs.@string(id), min, max);

        [MethodImpl(Inline), Op]
        public static RangeModel<char,uint> seg(char id, uint min, uint max)
            => content(id,min,max);

        [MethodImpl(Inline), Op]
        public static RangeModel<ulong,uint> seg(ulong id, uint min, uint max)
            => content(id,min,max);

        [MethodImpl(Inline), Op]
        public static RangeModel<sbyte,sbyte> seg(sbyte id, sbyte min, sbyte max)
            => content(id,min,max);

        [MethodImpl(Inline), Op]
        public static RangeModel<byte,byte> seg(byte id, byte min, byte max)
            => content(id,min,max);

        [MethodImpl(Inline), Op]
        public static RangeModel<char,byte> seg(char id, byte min, byte max)
            => content(id,min,max);

        [MethodImpl(Inline)]
        public static RangeModel<T,W> content<T,W>(T id, W min, W max)
            where W : unmanaged
                => new RangeModel<T,W>(id, (min, max));
    }
}