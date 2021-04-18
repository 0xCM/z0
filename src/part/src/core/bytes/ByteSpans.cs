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
    public readonly struct ByteSpans
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static ByteSpanProp prop(MemberInfo member, BinaryCode code, MemoryAddress location, ByteSize size)
            => new ByteSpanProp(member,code,location,size);

        [MethodImpl(Inline), Op]
        public static ByteSize size(Index<ByteSpanSpec> src)
        {
            var size = ByteSize.Zero;
            var count = src.Count;
            for(var i=0; i<count; i++)
                size += src[i].DataSize;
            return size;
        }

        [MethodImpl(Inline), Op]
        public static ByteSpanSpec spec(Identifier name, BinaryCode data, bool @static = true)
            => new ByteSpanSpec(name, data, @static);

        [Op]
        public static ByteSpanSpec merge(Identifier name, ByteSpanSpecs props)
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
            return spec(name, buffer, props.First.IsStatic);
        }

        [MethodImpl(Inline), Op]
        public static string property(CodeBlock src, OpIdentity id)
            => comment(new ByteSpanSpec(LegalIdentityBuilder.code(id), src).Format());

        [MethodImpl(Inline), Op]
        public static string comment(string text)
            =>  $"; {text}";

        [Op]
        public static string format(ByteSpanSpec src)
        {
            var dst = text.build();
            dst.Append("public");
            dst.Append(Chars.Space);
            dst.Append(src.IsStatic ? text.rspace("static") : EmptyString);
            dst.Append("ReadOnlySpan<byte>");
            dst.Append(Chars.Space);
            dst.Append(src.Name);
            dst.Append(" => ");
            dst.Append(string.Concat("new byte", text.bracket(src.Data.Length), text.embrace(HexFormats.array<byte>(src.Data))));
            dst.Append(Chars.Semicolon);
            return dst.ToString();
        }
    }
}