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

    using C = AsciCode;

    partial class AsciCodes     
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<C> codes(AsciCode2 src)
            => cast<C>(bytespan(src));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<C> codes(AsciCode4 src)
            => cast<C>(bytespan(src));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<C> codes(AsciCode8 src)
            => cast<C>(bytespan(src));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<C> codes(AsciCode16 src)
            => cast<C>(bytespan(src)); 
    }
}