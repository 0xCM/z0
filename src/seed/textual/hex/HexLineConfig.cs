//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct HexLineConfig
    {
        public readonly int BytesPerLine;

        public readonly bool LineLabels;

        public static HexLineConfig Default => new HexLineConfig(4,true);
            
        [MethodImpl(Inline)]
        public HexLineConfig(int linebytes, bool linelabels)
        {
            this.BytesPerLine = linebytes;
            this.LineLabels = linelabels;
        }

        public HexLineConfig WithBytesPerLine(int count)
            => new HexLineConfig(count,LineLabels);

        public HexLineConfig WithLineLabels(bool labels)
            => new HexLineConfig(BytesPerLine,labels);
    }
}