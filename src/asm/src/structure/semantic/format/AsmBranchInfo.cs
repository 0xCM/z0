//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    partial struct AsmFormatServices
    {
        public static string Format(IAsmBranch src)
        {            
            if(src.IsNonEmpty)
            {

                return text.concat(src.IP - src.Base, " -> ", src.Target);

                // if(src.IsNear)
                //     return text.concat(src.IP - src.Base, " -> ", src.Target);
                // else
                //     return text.concat(src.IP - src.Base, " -> ", src.Target);
            }
            else
                return string.Empty;
        }        

    }
}