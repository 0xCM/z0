//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static zfunc;
    using static BitParts;
    using static dinx;

    partial class Bits
    {        
        [MethodImpl(Inline)]
        public static uint project(uint src, uint spec)
            => scatter(src, spec);

        [MethodImpl(Inline)]
        public static uint select(uint src, uint spec)
            => gather(src, spec);

        [MethodImpl(Inline)]
        public static ulong project(ulong src, ulong spec)
            => scatter(src, spec);

        [MethodImpl(Inline)]
        public static ulong select(ulong src, ulong spec)
            => gather(src, spec);



    }

}