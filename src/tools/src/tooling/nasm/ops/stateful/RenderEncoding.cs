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
        public void RenderEncoding(in NasmEncoding src, ITextBuffer dst)
        {
            dst.AppendFormat("{0,-8}", src.LineNumber);
            dst.AppendFormat("{0}{1,-16}", RenderDelimiter, src.Offset);
            dst.AppendFormat("{0}{1,-24}", RenderDelimiter, src.Code);
            RenderEncoding(src.Code, dst);
        }

        [Op]
        public void RenderEncoding(in BinaryCode src, ITextBuffer dst)
        {
            var bitstring = BitFormat.Format(src.Storage.Reverse());
            dst.AppendFormat("{0}{1,-48}", RenderDelimiter, bitstring);
        }
    }
}