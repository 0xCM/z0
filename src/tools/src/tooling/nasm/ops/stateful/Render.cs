//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static memory;

    partial class Nasm
    {
        const string RenderDelimiter = RP.SpacedPipe;

        [Op]
        public void RenderEntry(in NasmListEntry src, ITextBuffer dst)
        {
            dst.AppendFormat("{0,-8}", src.LineNumber);
            var kind = Nasm.kind(src);

            if(kind == NasmListLineKind.Label)
                RenderLabel(src.Label, dst);
            else
            {
                dst.AppendFormat("{0}{1,-16}", RenderDelimiter, src.Offset);
                dst.AppendFormat("{0}{1,-24}", RenderDelimiter, src.Encoding);

                if(kind == NasmListLineKind.Encoding)
                    RenderEncoding(src.Encoding, dst);
                else
                    dst.AppendFormat("{0}{1,-48}", RenderDelimiter, EmptyString);

                RenderSource(src.SourceText, dst);
            }
        }

        [Op]
        public void RenderBlock(in NasmCodeBlock src, ITextBuffer dst)
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
                RenderEncoding(encoding, dst);
                RenderSource(encoding.SourceText, dst);
                dst.AppendLine();
            }
        }

        [Op]
        public void RenderEncoding(in NasmEncoding src, ITextBuffer dst)
        {
            dst.AppendFormat("{0,-8}", src.LineNumber);
            dst.AppendFormat("{0}{1,-16}", RenderDelimiter, src.Offset);
            dst.AppendFormat("{0}{1,-24}", RenderDelimiter, src.Code);
            RenderEncoding(src.Code, dst);
        }

        [Op]
        public void RenderLabel(in NasmLabel src, ITextBuffer dst)
        {
            dst.AppendFormat("{0,-8}", src.LineNumber);
            dst.AppendFormat("{0}{1}", RenderDelimiter, src.Name);
        }

        [Op]
        public void RenderLabel(in Identifier src, ITextBuffer dst)
        {
            dst.AppendFormat("{0}{1,-16}", RenderDelimiter, EmptyString);
            dst.AppendFormat("{0}{1,-24}", RenderDelimiter, EmptyString);
            dst.AppendFormat("{0}{1,-48}", RenderDelimiter, EmptyString);
            dst.AppendFormat("{0}{1}", RenderDelimiter, src);
        }

        [Op]
        public void RenderSource(in TextBlock src, ITextBuffer dst)
        {
            dst.AppendFormat("{0}{1}", RenderDelimiter, src);
        }

        [Op]
        public void RenderEncoding(in BinaryCode src, ITextBuffer dst)
        {
            var bitstring = BitFormat.Format(src.Storage.Reverse());
            dst.AppendFormat("{0}{1,-48}", RenderDelimiter, bitstring);
        }
    }
}