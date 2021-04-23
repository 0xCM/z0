//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly struct MethodTables
    {
        [Op]
        public static MethodEntryPoint entry(MethodInfo src)
            => new MethodEntryPoint(src.MetadataToken, ApiJit.jit(src));

        [Op, Closures(UInt16k)]
        public static MethodEntryPoint<K> entry<K>(MethodInfo src, K kind)
            where K : unmanaged
                => new MethodEntryPoint<K>(src.MetadataToken, ApiJit.jit(src), kind);

        [Op]
        public static MethodTable create(Identifier name, ReadOnlySpan<MethodInfo> src)
        {
            var count = src.Length;
            var buffer = alloc<MethodEntryPoint>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
                seek(dst,i) = entry(skip(src,i));
            return new MethodTable(name, buffer);
        }

        [Op]
        public static MethodTable<K> create<K>(Identifier name, ReadOnlySpan<K> kinds, ReadOnlySpan<MethodInfo> src)
            where K : unmanaged
        {
            var count = src.Length;
            var buffer = alloc<MethodEntryPoint<K>>(count);
            var index = new Index<K,uint>(alloc<uint>(count));
            ref var dst = ref first(buffer);
            ref var iX = ref index.First;
            for(var i=0u; i<count; i++)
            {
                ref readonly var kind = ref skip(kinds,i);
                seek(dst,i) = entry(skip(src,i), kind);
                index[kind] = i;

            }
            return new MethodTable<K>(name, buffer, index);
        }
    }
}