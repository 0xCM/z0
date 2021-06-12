//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;
    using static core;

    partial struct ClrLiterals
    {
        [MethodImpl(Inline), Op]
        public static LiteralProvider provider(Type src, LiteralUsage usage = default)
            => new LiteralProvider(src,usage);

        [Op]
        public static Index<LiteralProvider> providers(Assembly src)
            => providers(src.TaggedTypes<LiteralProviderAttribute>());

        [Op]
        public static Index<LiteralProvider> providers(Assembly[] src)
            => providers(src.TaggedTypes<LiteralProviderAttribute>());

        [MethodImpl(Inline), Op]
        static Index<LiteralProvider> providers(ReadOnlySpan<TaggedType<LiteralProviderAttribute>> types)
        {
            var count = types.Length;
            var buffer = alloc<LiteralProvider>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var type = ref skip(types,i);
                seek(dst,i) = provider(type.Type, type.Tag.Usage);
            }
            return buffer;
        }
    }
}