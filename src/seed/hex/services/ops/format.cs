//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Typed;
 
    partial class Hex
    {
        [MethodImpl(Inline), Op]
        public static string format(in HexText<Hex1Kind> src, Hex1Kind kind)
            => src.String((uint)kind);        

        [MethodImpl(Inline), Op]
        public static string format(in HexText<Hex2Kind> src,  Hex2Kind kind)
            => src.String((uint)kind);        

        [MethodImpl(Inline), Op]
        public static string format(in HexText<Hex3Kind> src, Hex3Kind kind)
            => src.String((uint)kind);
        
        [MethodImpl(Inline), Op]
        public static string format(in HexText<Hex4Kind> src, Hex4Kind kind)        
            => src.String((uint)kind);

        [MethodImpl(Inline), Op]
        public static string format(Hex1Kind kind)
            => format(text(n1), kind);        

        [MethodImpl(Inline), Op]
        public static string format(Hex2Kind kind)
            => format(text(n2), kind);        

        [MethodImpl(Inline), Op]
        public static string format(Hex3Kind kind)
            => format(text(n3), kind);        
        
        [MethodImpl(Inline), Op]
        public static string format(Hex4Kind kind)        
            => format(text(n4), kind);        
    }
}