//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Lang;

    using static Root;
    using static core;

    using C = Chars;

    using static Z0.Lang.CSharpModels.KewordLiterals;
    using KW = Z0.Lang.CSharpModels.KewordLiterals;

    public class AsciLookups : Service<AsciLookups>
    {
        const char semi = Chars.Semicolon;

        const char lbrace = Chars.LBrace;

        const char rbrace = Chars.RBrace;

        const char lbracket = Chars.LBracket;

        const char rbracket = Chars.RBracket;

        const char space = ' ';

        public static RenderPattern<string> ReadOnlySpanTypeName => "ReadOnlySpan<{0}>";

        public static RenderPattern<string,string> Assign => "{0} => {1}";

        public void Emit<E>(ITextBuffer dst)
            where E : unmanaged, Enum
        {
            var n = 0u;
            var BaseName = typeof(E).Name;
            var LookupName = string.Format("{0}Lookups", BaseName);
            var IndexName = "Index";
            dst.IndentLineFormat(n, "{0} {1}", @namespace, "Z0");
            dst.IndentLine(n, lbrace);
            n+= 4;
            dst.IndentLineFormat(n, "{0} {1}{2}", @using, nameof(System), semi);
            dst.IndentLineFormat(n, "{0} {1} {2}{3}", @using, @static, nameof(AsciCode), semi);
            dst.AppendLine();
            dst.IndentLineFormat(n, "{0} {1} {2} {3}", @public, KW.@readonly, @struct, LookupName);
            dst.IndentLine(n, lbrace);
            n+=4;

            var symbols = Symbols.index<E>();
            var spec = ByteSpans.specify<E>(IndexName, symbols.View);
            Render(n, spec, dst, false);
            dst.IndentLine(n, rbrace);
            n-=4;
            dst.IndentLine(n, rbrace);

        }

        public void AsciCodeSpan(uint indent, Identifier name, string data, ITextBuffer dst)
        {
            var payload = text.buffer();
            var src = span(data);
            var count = src.Length;
            var symbols = Symbols.index<AsciCode>().View;
            var buffer = alloc<Sym<AsciCode>>(count);
            ref var target = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var c = ref skip(src,i);
                var j = (byte)c;

                seek(target, i) = skip(symbols, j);
            }

            var spec = new ByteSpanSpec<AsciCode>(name, buffer, true, nameof(AsciCode));
            Render(indent, spec, dst, true);
        }

        public void AsciByteSpan(uint indent, Identifier name, string data, ITextBuffer dst)
        {
            var payload = text.buffer();
            var src = span(data);
            var count = src.Length;
            var symbols = Symbols.index<AsciCode>().View;
            var buffer = alloc<byte>(count);
            ref var target = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var c = ref skip(src,i);
                var j = (byte)c;

                seek(target, i) = (byte)c;
            }

            var spec = new ByteSpanSpec(name, buffer, true);
            Render(indent, spec, dst);
        }

        public void RenderLiteral<T>(uint indent, in Sym<T> src, ITextBuffer dst)
            where T : unmanaged
        {
            if(src.Description.IsNonEmpty)
                CSharp.comment(src.Description).Render(indent, dst);
            dst.IndentLineFormat(indent, "{0},", src.Name);
        }

        public void RenderLiteralLines<T>(uint indent, ReadOnlySpan<Sym<T>> src, ITextBuffer dst)
            where T : unmanaged
        {
            var count = src.Length;
            dst.AppendLine();
            for(var i=0; i<count; i++)
                RenderLiteral(indent, skip(src,i), dst);
            dst.AppendLine();
        }

        public void RenderLiteralList<T>(ReadOnlySpan<Sym<T>> src, ITextBuffer dst)
            where T : unmanaged
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var cell = ref skip(src,i);
                if(i != count - 1)
                    dst.Append(string.Format("{0}, ", cell.Name));
                else
                    dst.Append(cell.Name);
            }
        }

        public void RenderList(ReadOnlySpan<byte> src, ITextBuffer dst)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var cell = ref skip(src,i);
                if(i != count - 1)
                    dst.Append(string.Format("{0}, ", cell));
                else
                    dst.Append(string.Format("{0}", cell));
            }
        }

        public void RenderPayload<T>(uint indent, in ByteSpanSpec<T> spec, ITextBuffer dst, bool compact)
            where T : unmanaged, Enum
        {
            dst.Append(lbrace);
            if(compact)
            {
                RenderLiteralList(spec.Data, dst);
                dst.AppendFormat("{0}{1}", rbrace, semi);
            }
            else
            {
                RenderLiteralLines(indent + 4, spec.Data, dst);
                dst.IndentLineFormat(indent + 4, "{0}{1}", rbrace, semi);
            }
        }

        public void RenderPayload(uint indent, in ByteSpanSpec spec, ITextBuffer dst)
        {
            dst.Append(lbrace);
            RenderList(spec.Data, dst);
            dst.AppendFormat("{0}{1}", rbrace, semi);
        }

        [Op]
        public void Render<T>(uint indent, ByteSpanSpec<T> spec, ITextBuffer dst, bool compact)
            where T : unmanaged, Enum
        {
            var payload = text.buffer();
            RenderPayload(indent, spec, payload, compact);
            var left = text.buffer();
            var modifiers = spec.IsStatic ? string.Format("{0} {1}", @public, @static) : @public;
            left.Append(modifiers);
            left.Append(Chars.Space);
            left.Append(ReadOnlySpanTypeName.Format(spec.CellType));
            left.Append(Chars.Space);
            left.Append(spec.Name);

            var right = text.buffer();
            right.Append(string.Concat(string.Format("new {0}", spec.CellType), RP.bracket(spec.Data.Length), payload.Emit()));

            var assignment = Assign.Format(left.Emit(), right.Emit());
            dst.IndentLine(indent, assignment);
        }

        [Op]
        public void Render(uint indent, ByteSpanSpec spec, ITextBuffer dst)
        {
            var payload = text.buffer();
            RenderPayload(indent, spec, payload);
            var left = text.buffer();
            var modifiers = spec.IsStatic ? string.Format("{0} {1}", @public, @static) : @public;
            left.Append(modifiers);
            left.Append(Chars.Space);
            left.Append(ReadOnlySpanTypeName.Format(spec.CellType));
            left.Append(Chars.Space);
            left.Append(spec.Name);

            var right = text.buffer();
            right.Append(string.Concat(string.Format("new {0}", spec.CellType), RP.bracket(spec.Data.Length), payload.Emit()));

            var assignment = Assign.Format(left.Emit(), right.Emit());
            dst.IndentLine(indent, assignment);
        }

        public static void Emit(FS.FolderPath root)
        {
            var dst = root + FS.file("asci", FS.Txt);
            using var writer = dst.Writer();
            writer.Write(BuildAsciData(false));
            writer.Write(BuildAsciData(true));
            writer.Write(BuildAsciByteSpan(256));
        }

        const char BS = '\\';

        const char SQ = '\'';

        const char QU = '\"';

        static string BuildAsciData(bool span)
        {
            var sb = text.build();

            var count = 128;
            var name = span ? "AsciData" : "AsciDataString";
            var access = "public";
            var spanPropDecl = $"{access} static ReadOnlySpan<char> {name} => new " + $"char[{count}]" +"{";
            var constPropDecl = $"{access} const string {name} = \"";
            var propDecl = span ? spanPropDecl : constPropDecl;
            var charFence = span ? "'" : "";
            var spanPropClose = "};";
            var constPropClose = "\";";
            var propClose = span ? spanPropClose : constPropClose;

            sb.Append(propDecl);
            if(span)
                sb.AppendLine();

            for(var i=0; i<count; i++)
            {
                var c = (char)i;
                sb.Append(charFence);

                if(c == 0)
                    sb.Append(C.D0);
                else if(c == 10 || c == 13)
                    sb.Append(C.D0);
                else if(c == QU)
                    sb.Append($"\\{c}");
                else if(Char.IsControl(c) || c == BS || c == SQ)
                    sb.Append($"0");
                else
                    sb.Append(c);
                sb.Append(charFence);

                if(span)
                {
                    sb.Append(", ");
                    if(i % 8 == 0 && i != 0)
                        sb.AppendLine();
                }
            }

            sb.AppendLine(propClose);

            return sb.ToString();
        }

        static string BuildAsciByteSpan(uint size, string name = "AsciBytes")
        {
            var sb = text.build();

            var propDecl = $"publid static ReadOnlySpan<byte> {name} => new " + $"byte[{size}]" +"{";
            var propClose = "};";

            sb.Append(propDecl);
            sb.AppendLine();

            var j =0;
            for(int i=0; i<size; i++)
            {
                if(i % 2 == 0)
                    sb.Append($"{j++},");
                else
                    sb.Append("0,".PadRight(6));

                if((i + 1) % 16 == 0 && i != 0)
                    sb.AppendLine();
            }

            sb.AppendLine(propClose);

            return sb.ToString();
        }
    }

    partial class XTend
    {
        public static AsciLookups AsciLookups(this IServiceContext context)
            => Z0.AsciLookups.create(context);
    }
}