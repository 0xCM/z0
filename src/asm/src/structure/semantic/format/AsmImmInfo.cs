//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial struct AsmFormatServices
    {

       public static string Format(AsmImmInfo src)
            => text.concat(src.Value.FormatHex(zpad:false, prespec:false));
    
        public static string FormatKind(AsmImmInfo src)
        {
            if(src.Signed)
                return text.concat("imm", src.Width.FormatValue(), IDI.Signed);
            else
                return text.concat("imm", src.Width.FormatValue(), IDI.Unsigned);
        }
    }
}