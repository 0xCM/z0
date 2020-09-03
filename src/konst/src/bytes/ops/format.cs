//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Bit
    {        
        static BitFormatConfig FormatConfig2 
            => BitFormatter.limited(uint2.Width, uint2.Width);
        
        [MethodImpl(Inline), Op]
        public static string format(uint2 src)
            => BitFormatter.format(src.data, FormatConfig2);
    }
}