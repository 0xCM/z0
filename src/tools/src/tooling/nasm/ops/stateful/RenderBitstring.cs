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
        public void RenderBitstring(in BinaryCode src, ITextBuffer dst)
            => dst.Append(FormatBitstring(src));

        public string FormatBitstring(in BinaryCode src)
        {
            var bitstring = BitFormat.Format(src.Storage.Reverse());
            return string.Format("{0}{1,-48}", RenderDelimiter, bitstring);
        }
    }
}