//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static memory;

    partial class Nasm
    {
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
    }
}