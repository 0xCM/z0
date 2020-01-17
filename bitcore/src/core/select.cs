//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static zfunc;

    partial class Bits
    {        
        [MethodImpl(Inline), Op]
        public static uint project(uint src, uint spec)
            => scatter(src, spec);

        [MethodImpl(Inline), Op]
        public static uint select(uint src, uint spec)
            => gather(src, spec);

        [MethodImpl(Inline), Op]
        public static ulong project(ulong src, ulong spec)
            => scatter(src, spec);

        [MethodImpl(Inline), Op]
        public static ulong select(ulong src, ulong spec)
            => gather(src, spec);
    }
}