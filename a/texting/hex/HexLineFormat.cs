//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Textual;

    public readonly struct HexLineFormat
    {
        public readonly int BytesPerLine;

        public readonly bool LineLabels;

        public static HexLineFormat Default => new HexLineFormat(4,true);
            
        [MethodImpl(Inline)]
        public HexLineFormat(int linebytes, bool linelabels)
        {
            this.BytesPerLine = linebytes;
            this.LineLabels = linelabels;
        }

        public HexLineFormat WithBytesPerLine(int count)
            => new HexLineFormat(count,LineLabels);

        public HexLineFormat WithLineLabels(bool labels)
            => new HexLineFormat(BytesPerLine,labels);
    }
}