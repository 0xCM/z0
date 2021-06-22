//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static core;

    using static CsPatterns;

    public class AsciByteSpans : Service<AsciByteSpans>
    {
        const char semi = Chars.Semicolon;

        const char lbrace = Chars.LBrace;

        const char rbrace = Chars.RBrace;

        public static RenderPattern<string> ReadOnlySpanTypeName => "ReadOnlySpan<{0}>";

        public static RenderPattern<string,string> Assign => "{0} => {1}";

        public ByteSpanSpec Render(uint indent, Identifier name, string data, ITextBuffer dst)
        {
            var payload = text.buffer();
            var src = span(data);
            var count = src.Length;
            var buffer = alloc<byte>(count);
            ref var target = ref first(buffer);
            for(var i=0; i<count; i++)
                seek(target, i) = (byte)skip(src,i);
            var spec = ByteSpans.specify(name, buffer, true);
            Render(indent, spec, dst);
            return spec;
        }

        [Op]
        public void Render(uint indent, ByteSpanSpec spec, ITextBuffer dst)
        {
            var data = spec.Data.View;
            var size = spec.DataSize;
            var left = TextTools.buffer();
            var modifiers = spec.IsStatic ? string.Format("{0} {1}", @public, @static) : @public;
            left.Append(modifiers);
            left.Append(Chars.Space);
            left.Append(ReadOnlySpanTypeName.Format(spec.CellType));
            left.Append(Chars.Space);
            left.Append(spec.Name);

            var content = TextTools.buffer();
            content.Append(lbrace);

            for(var i=0; i<size; i++)
            {
                ref readonly var cell = ref skip(data,i);
                if(i != size - 1)
                    content.Append(string.Format("{0}, ", cell));
                else
                    content.Append(string.Format("{0}", cell));
            }

            content.AppendFormat("{0}{1}", rbrace, semi);

            var right = TextTools.buffer();
            right.Append(string.Concat(string.Format("new {0}", spec.CellType), RP.bracket(size), content.Emit()));

            dst.IndentLine(indent, Assign.Format(left.Emit(), right.Emit()));
        }
    }
}