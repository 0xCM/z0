//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Control;

    using C = AsciCharCode;

    partial class AsciCodes     
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<C> kinds(AsciCode2 src)
            => cast<C>(bytespan(src));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<C> kinds(AsciCode4 src)
            => cast<C>(bytespan(src));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<C> kinds(AsciCode8 src)
            => cast<C>(bytespan(src));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<C> kinds(AsciCode16 src)
            => cast<C>(bytespan(src)); 
    }
}