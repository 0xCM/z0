//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct HexLineConfig
    {
        /// <summary>
        /// The maximum byte-count per line
        /// </summary>
        public ushort BytesPerLine {get;}

        /// <summary>
        /// Specifies whether offset labels should be emitted
        /// </summary>
        public bool LineLabels {get;}

        /// <summary>
        /// If offset lables are emitted, the separator between the label and the data
        /// </summary>
        public char Delimiter {get;}

        [MethodImpl(Inline)]
        public HexLineConfig(ushort linebytes, bool linelabels, char delimiter = Chars.Space)
        {
            BytesPerLine = linebytes;
            LineLabels = linelabels;
            Delimiter = delimiter;
        }
    }
}