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
        public void RenderEntry(in NasmListEntry src, ITextBuffer dst)
        {
            const string Delimiter = RP.SpacedPipe;

            dst.AppendFormat("{0,-8}", src.LineNumber);

            if(src.Label.IsNonEmpty)
            {
                dst.AppendFormat("{0}{1,-16}", Delimiter, EmptyString);
                dst.AppendFormat("{0}{1,-24}", Delimiter, EmptyString);
                dst.AppendFormat("{0}{1,-48}", Delimiter, EmptyString);
                dst.AppendFormat("{0}{1}", Delimiter, src.Label);
            }
            else
            {
                dst.AppendFormat("{0}{1,-16}", Delimiter, src.Offset);
                dst.AppendFormat("{0}{1,-24}", Delimiter, src.Encoding);

                if(src.Encoding.IsNonEmpty)
                {

                    var bitstring = BitFormat.Format(src.Encoding.Storage.Reverse());
                    dst.AppendFormat("{0}{1,-48}", Delimiter, bitstring);
                }
                else
                {
                    dst.AppendFormat("{0}{1,-48}", Delimiter, EmptyString);
                }

                dst.AppendFormat("{0}{1}", Delimiter, src.SourceText);
            }
        }
    }
}