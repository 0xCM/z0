//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;
    using static Root;
    using static IntelSdm;

    using Markers = IntelSdmMarkers;

    partial class IntelSdmProcessor
    {
        /// <summary>
        /// Attempts to parse a <see cref='Page'/>
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target, if successful; otherwise empty</param>
        public static Outcome parse(ReadOnlySpan<char> src, out Page dst)
        {
            dst = Page.Empty;
            if(ushort.TryParse(src, out var number))
            {
                dst = number;
                return true;
            }
            return false;
        }
    }
}