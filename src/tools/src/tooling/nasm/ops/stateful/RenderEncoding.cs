//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using System;

    partial class Nasm
    {
        [Op]
        public void RenderEncoding(in NasmEncoding src, ITextBuffer dst)
        {
            dst.AppendFormat("{0,-8}", src.LineNumber);
            dst.AppendFormat("{0}{1,-16}", RenderDelimiter, src.Offset);
            dst.AppendFormat("{0}{1,-24}", RenderDelimiter, src.Code);
            RenderBitstring(src.Code, dst);
        }
    }
}