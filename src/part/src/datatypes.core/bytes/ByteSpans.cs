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
    public readonly struct ByteSpans
    {
        [MethodImpl(Inline), Op]
        public static ByteSize size(Index<ByteSpanProp> src)
        {
            var size = ByteSize.Zero;
            var count = src.Count;
            for(var i=0; i<count; i++)
                size += src[i].DataSize;
            return size;
        }

        [Op]
        public static ByteSpanProp merge(ByteSpanProps props, Identifier name)
        {
            var buffer = alloc<byte>(props.TotalSize);
            var c0 = props.Count;
            ref var dst = ref first(buffer);
            var view = props.View;
            var k=0;
            for(var i=0; i<c0; i++)
            {
                ref readonly var prop = ref skip(view,i);
                ref readonly var src = ref prop.FirstByte;
                var c1 = prop.Data.Count;
                for(var j=0; j<c1; j++, k++)
                    seek(dst,k) = skip(src,j);
            }
            return property(name, buffer, props.First.IsStatic);
        }

        [MethodImpl(Inline), Op]
        public static ByteSpanProp property(Identifier name, BinaryCode data, bool @static = true)
            => new ByteSpanProp(name, data, @static);

        [MethodImpl(Inline), Op]
        public static string property(CodeBlock src, OpIdentity id)
            => comment(new ByteSpanProp(LegalIdentityBuilder.code(id), src).Format());

        [MethodImpl(Inline), Op]
        public static string comment(string text)
            =>  $"; {text}";
    }
}