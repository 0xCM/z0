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

        public static void asci(string data, Identifier name, ITextBuffer dst)
        {
            var payload = text.buffer();
            var src = span(data);
            var count = src.Length;
            var buffer = alloc<AsciCode>(count);
            ref var target = ref first(buffer);
            for(var i=0; i<count; i++)
                seek(target,i) = (AsciCode)skip(src,i);

            var spec = new ByteSpanSpec<AsciCode>(name, buffer, true, nameof(AsciCode));
            render(spec, dst);
        }

        public static uint cilbytes(Type[] types, FS.FilePath dst)
        {
            var counter = 0u;
            var header = text.concat("Type".PadRight(20), "| ", "Property".PadRight(30), "| ", "Cil Bytes");
            using var writer = dst.Writer();
            writer.WriteLine(header);
            var props = types.StaticProperties().Where(p => p.GetGetMethod() != null && p.PropertyType == typeof(ReadOnlySpan<byte>));

            foreach(var p in props)
            {
                var m = p.GetGetMethod();
                var body = m.GetMethodBody();
                var cil = body.GetILAsByteArray();
                var line = string.Concat(m.DeclaringType.Name.PadRight(20), "| ", m.Name.PadRight(30), "| ", cil.FormatHex());
                writer.WriteLine(line);
                counter++;
            }
            return counter;
        }

        [MethodImpl(Inline), Op]
        public static ByteSpanSpec specify(Identifier name, BinaryCode data, bool @static = true)
            => new ByteSpanSpec(name, data, @static);

        [Op]
        public static ByteSpanSpec specify(OpUri uri, BinaryCode data, bool @static = true)
            => new ByteSpanSpec(LegalIdentityBuilder.code(uri.OpId), data, @static);

        [Op]
        public static string asmcomment(OpUri uri, BinaryCode src)
            => string.Format("; {0}", format(specify(uri, src)));

        [Op]
        public static string format(ByteSpanSpec src)
        {
            var dst = text.buffer();
            render(src,dst);
            return dst.Emit();
        }

        [Op]
        public static string format<T>(ByteSpanSpec<T> src)
            where T : unmanaged, Enum
        {
            var dst = text.buffer();
            render(src,dst);
            return dst.Emit();
        }

        [Op]
        public static void render<T>(ByteSpanSpec<T> spec, ITextBuffer dst)
            where T : unmanaged, Enum
        {
            var payload = text.buffer();
            var src = spec.Data.View;
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var cell = ref skip(src,i);
                if(i != count - 1)
                    payload.Append(string.Format("{0}, ", cell));
                else
                    payload.Append(cell.ToString());
            }

            dst.Append("public");
            dst.Append(Chars.Space);
            dst.Append(spec.IsStatic ? RP.rspace("static") : EmptyString);
            dst.Append(string.Format("ReadOnlySpan<{0}>", spec.CellType));
            dst.Append(Chars.Space);
            dst.Append(spec.Name);
            dst.Append(" => ");
            dst.Append(string.Concat(string.Format("new {0}", spec.CellType), RP.bracket(spec.Data.Length), RP.embrace(payload.Emit())));
            dst.Append(Chars.Semicolon);
        }


        [Op]
        public static void render(ByteSpanSpec src, ITextBuffer dst)
        {
            var payload = HexFormatter.array<byte>(src.Data);
            render(src, payload, dst);
        }


        [Op]
        public static void render(ByteSpanSpec src, string payload, ITextBuffer dst)
        {
            dst.Append("public");
            dst.Append(Chars.Space);
            dst.Append(src.IsStatic ? RP.rspace("static") : EmptyString);
            dst.Append(string.Format("ReadOnlySpan<{0}>", src.CellType));
            dst.Append(Chars.Space);
            dst.Append(src.Name);
            dst.Append(" => ");
            dst.Append(string.Concat(string.Format("new {0}", src.CellType), RP.bracket(src.Data.Length), RP.embrace(payload)));
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