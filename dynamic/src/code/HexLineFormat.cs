//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct HexLineFormat
    {
        public static HexLineFormat Default => new HexLineFormat(4,true);
        
        public HexLineFormat(int linebytes, bool linelabels)
        {
            this.BytesPerLine = linebytes;
            this.LineLabels = linelabels;
        }

        public readonly int BytesPerLine;

        public readonly bool LineLabels;

        public HexLineFormat WithBytesPerLine(int count)
            => new HexLineFormat(count,LineLabels);

        public HexLineFormat WithLineLabels(bool labels)
            => new HexLineFormat(BytesPerLine,labels);
    }
}