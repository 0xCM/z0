//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    partial class Symbolic
    {
        [MethodImpl(Inline), Op]
        public static int first(in asci4 src, byte match)
            => first(bytes(src), match);

        [MethodImpl(Inline), Op]
        public static int first(in asci5 src, byte match)
            => first(bytes(src), match);

        [MethodImpl(Inline), Op]
        public static int first(in asci8 src, byte match)
            => first(bytes(src), match);

        [MethodImpl(Inline), Op]
        public static int first(in asci16 src, byte match)
            => first(bytes(src), match);

        [MethodImpl(Inline), Op]
        public static int first(in asci32 src, byte match)
            => first(bytes(src), match);

        [MethodImpl(Inline), Op]
        public static int first(in asci64 src, byte match)
            => first(bytes(src), match); 
    }
}