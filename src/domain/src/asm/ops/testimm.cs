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
   
    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static bool testimmSigned(OpKind src)
            => src == Immediate8to16  
            || src == Immediate8to32  
            || src == Immediate8to64  
            || src == Immediate32to64;

        [MethodImpl(Inline), Op]
        public static bool testimmDirect(OpKind src)
            => src == Immediate8
            || src == Immediate16
            || src == Immediate32
            || src == Immediate64;

        [MethodImpl(Inline), Op]
        public static bool testimmSpecial(OpKind src)
            => src == Immediate8_2nd;

        [MethodImpl(Inline), Op]
        public static bool testimm(OpKind src)
            => testimmSigned(src) || testimmDirect(src) || testimmSpecial(src);
    }
}