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

    using Z0.Lang;

    using static CsPatterns;
    using CsP = CsPatterns;

    public class IndexRender : Service<IndexRender>
    {
        public void RenderIndex<E>(Identifier container, ITextBuffer dst)
            where E : unmanaged, Enum
        {
            var n = 0u;
            var type = typeof(E);
            var IndexName = "Index";
            dst.IndentLineFormat(n, "{0} {1}", @namespace, "Z0");
            dst.IndentLine(n, Open());
            n+= 4;
            dst.IndentLineFormat(n, "{0} {1}{2}", @using, nameof(System), Term());
            if(type.IsNested)
                dst.IndentLineFormat(n, "{0} {1} {2}{3}", @using, @static, type.DeclaringType.DottedName(), Term());
            dst.IndentLineFormat(n, "{0} {1} {2}{3}", @using, @static, type.DottedName(), Term());

            dst.AppendLine();
            dst.IndentLineFormat(n, "{0} {1} {2} {3}", @public, CsP.@readonly, @struct, container);
            dst.IndentLine(n, Open());
            n+=4;

            var spec = ByteSpans.specify<E>(IndexName);
            RenderIndex(n, spec, dst, false);
            dst.IndentLine(n, Close());
            n-=4;
            dst.IndentLine(n, Close());
        }

        [Op]
        public void RenderIndex<T>(uint indent, ByteSpanSpec<T> spec, ITextBuffer dst, bool compact)
            where T : unmanaged, Enum
        {
            var payload = TextTools.buffer();
            RenderPayload(indent, spec, payload, compact);
            var left = TextTools.buffer();
            var modifiers = spec.IsStatic ? string.Format("{0} {1}", @public, @static) : @public;
            left.Append(modifiers);
            left.Append(Chars.Space);
            left.Append(ReadOnlySpanTypePattern.Format(spec.CellType));
            left.Append(Chars.Space);
            left.Append(spec.Name);

            var right = TextTools.buffer();
            right.Append(string.Concat(string.Format("new {0}", spec.CellType), RP.bracket(spec.Data.Length), payload.Emit()));

            var assignment = ExpressionBody.Format(left.Emit(), right.Emit());
            dst.IndentLine(indent, assignment);
        }

        public void RenderPayload<T>(uint indent, in ByteSpanSpec<T> spec, ITextBuffer dst, bool compact)
            where T : unmanaged, Enum
        {
            dst.Append(Open());
            if(compact)
            {
                RenderLiteralList(spec.Data, dst);
                dst.AppendFormat("{0}{1}", Close(), Term());
            }
            else
            {
                RenderLiteralLines(indent + 4, spec.Data, dst);
                dst.IndentLineFormat(indent + 4, "{0}{1}", Close(), Term());
            }
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
    }
}