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
        public void RenderListEntry(in NasmListEntry src, ITextBuffer dst)
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
    }
}