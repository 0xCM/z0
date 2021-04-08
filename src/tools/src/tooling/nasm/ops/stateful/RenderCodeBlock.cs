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
                RenderEncoding(encoding, dst);
                RenderSource(encoding.SourceText, dst);
                dst.AppendLine();
            }
        }
    }
}