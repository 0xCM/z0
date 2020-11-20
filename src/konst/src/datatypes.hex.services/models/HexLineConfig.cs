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
        /// <summary>
        /// The maximum byte-count per line
        /// </summary>
        public readonly int BytesPerLine;

        /// <summary>
        /// Specifies whether offset labels should be emitted
        /// </summary>
        public readonly bool LineLabels;
            
        [MethodImpl(Inline)]
        public HexLineConfig(int linebytes, bool linelabels)
        {
            BytesPerLine = linebytes;
            LineLabels = linelabels;
        } 
    }
}