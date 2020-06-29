//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static V0;
    using static Root;

    partial struct Encoding
    {            
        [Op]
        public static string format(in EncodedCommand src)
        {         
            var data = Encoding.encoding(src);
            var size = src.EncodingSize;
            return text.concat($"data", text.bracket(size), Chars.Colon, text.embrace(data.FormatHex()));
        }
    }
}