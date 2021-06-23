//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public class AsciBytes : Service<AsciBytes>
    {
        public ByteSpanSpec DefineAsciBytes(Identifier name, string content)
        {
            var src = span(content);
            var count = src.Length;
            var buffer = alloc<byte>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
                seek(dst, i) = (byte)skip(src,i);
            return new ByteSpanSpec(name, buffer, true);
        }
    }

    partial class XTend
    {
        public static AsciBytes AsciBytes(this IServiceContext context)
            => Z0.AsciBytes.create(context);
    }
}