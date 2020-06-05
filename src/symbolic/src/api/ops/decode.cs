//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Control;

    partial class Symbolic     
    {
        [MethodImpl(Inline), Op]
        public static int decode(in AsciCode4 src, Span<char> dst)
            => AC4.decode(src,dst);

        [MethodImpl(Inline), Op]
        public static int decode(in AsciCode8 src, Span<char> dst)
            => AC8.decode(src,dst);

        [MethodImpl(Inline), Op]
        public static int decode(in AsciCode16 src, Span<char> dst)
            => AC16.decode(src,dst);
    }
}