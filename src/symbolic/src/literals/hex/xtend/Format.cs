//-----------------------------------------------------------------------------
// copyright   :  (c) chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    partial class XTend
    {
        public static string Format(this HexKind src)
            => ((byte)src).FormatHex(true,false);
    }
}