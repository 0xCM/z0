//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    partial class Symbolic
    {
        [MethodImpl(Inline), Op]
        public static int first(in AsciCode4 src, byte match)
            => first(bytes(src), match);

        [MethodImpl(Inline), Op]
        public static int first(in AsciCode5 src, byte match)
            => first(bytes(src), match);

        [MethodImpl(Inline), Op]
        public static int first(in AsciCode8 src, byte match)
            => first(bytes(src), match);

        [MethodImpl(Inline), Op]
        public static int first(in AsciCode16 src, byte match)
            => first(bytes(src), match);

        [MethodImpl(Inline), Op]
        public static int first(in AsciCode32 src, byte match)
            => first(bytes(src), match);

        [MethodImpl(Inline), Op]
        public static int first(in AsciCode64 src, byte match)
            => first(bytes(src), match); 
    }
}