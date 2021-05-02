//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using static memory;

    partial class Nasm
    {
        [Op]
        public void RenderCodeBlock(in NasmCodeBlock src, ITextBuffer dst)
        {
            if(src.Label.IsNonEmpty)
            {
                RenderLabel(src.Label, dst);
                dst.AppendLine();
            }

            var encodings = src.Code.View;
            var count = encodings.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var encoding = ref skip(encodings,i);
                dst.AppendFormat("{0,-8}", encoding.LineNumber);
                dst.AppendFormat("{0}{1,-16}", RenderDelimiter, encoding.Offset);
                dst.AppendFormat("{0}{1,-46}", RenderDelimiter, encoding.SourceText);
                dst.AppendFormat("{0}{1,-24}", RenderDelimiter, encoding.Encoded);
                dst.AppendFormat("{0}{1,-48}", RenderDelimiter, FormatBitstring(encoding.Encoded));
                dst.AppendLine();
            }
        }
    }
}