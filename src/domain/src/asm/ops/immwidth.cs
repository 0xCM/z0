//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using Z0.Asm;
    
    using static Konst;
    using static Asm.OpKind;

    using W = NumericWidth;
   
    partial struct asm
    {
        [Op]
        public static NumericWidth immwidth(OpKind src)
        {
            if(src == Immediate8 || src == Immediate8_2nd)
                return W.W8;
            else if(src == Immediate16 || src == Immediate8to16)
                return W.W16;
            else if(src == Immediate32 || src == Immediate8to32)
                return W.W32;
            else if(src == Immediate64 || src == Immediate8to64 || src == Immediate32to64)
                return W.W64;
            else
                return 0;
        }
    }
}