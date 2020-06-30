//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;

    partial struct Encoding
    {            
        [Op]
        public static string format(in EncodedCommand src)
        {         
            var data = Encoding.encoding(src);
            var size = src.EncodingSize;
            return text.concat($"data", text.bracket(size), Chars.Colon, text.embrace(data.FormatHex()));
        }

        public static string format(in ModRmEncoding src)
        {
            const string Sep = " | ";

            const string Assign = " = ";
            
            var a = src.Rm.Format();
            var b = src.Reg.Format();
            var c = src.Mod.Format();
            var e = src.Encoded.Format();
            return text.concat(a, Sep, b, Sep, c, Assign, e);
        }
    }
}