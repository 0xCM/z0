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

    [ApiHost]
    public readonly struct ByteSpans
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static ByteSpanSpec specify(Identifier name, BinaryCode data, bool @static = true)
            => new ByteSpanSpec(name, data, @static);

        [Op]
        public static ByteSpanSpec specify(OpUri uri, BinaryCode data, bool @static = true)
            => new ByteSpanSpec(LegalIdentityBuilder.code(uri.OpId), data, @static);

        [Op]
        public static string asmcomment(OpUri uri, BinaryCode src)
            => string.Format("; {0}", format(specify(uri, src)));

        [MethodImpl(Inline), Op]
        public static ByteSize size(Index<ByteSpanSpec> src)
        {
            var size = ByteSize.Zero;
            var count = src.Count;
            for(var i=0; i<count; i++)
                size += src[i].DataSize;
            return size;
        }

        [Op]
        public static string format(ByteSpanSpec src)
        {
            var dst = text.buffer();
            render(src,dst);
            return dst.Emit();
        }

        [Op]
        public static void render(ByteSpanSpec src, ITextBuffer dst)
        {
            dst.Append("public");
            dst.Append(Chars.Space);
            dst.Append(src.IsStatic ? text.rspace("static") : EmptyString);
            dst.Append("ReadOnlySpan<byte>");
            dst.Append(Chars.Space);
            dst.Append(src.Name);
            dst.Append(" => ");
            dst.Append(string.Concat("new byte", text.bracket(src.Data.Length), text.embrace(HexFormatter.array<byte>(src.Data))));
            dst.Append(Chars.Semicolon);
        }

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
            return specify(name, buffer, props.First.IsStatic);
        }
    }
}