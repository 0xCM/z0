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
        public int BytesPerLine {get;}

        /// <summary>
        /// Specifies whether offset labels should be emitted
        /// </summary>
        public bool LineLabels {get;}

        [MethodImpl(Inline)]
        public HexLineConfig(int linebytes, bool linelabels)
        {
            BytesPerLine = linebytes;
            LineLabels = linelabels;
        }
    }
}