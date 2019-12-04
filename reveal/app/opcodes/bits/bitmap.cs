//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static As;
    using static AsIn;

    partial class bvoc
    {            
        public static ulong clear_64(ulong src, int p0, int p1)
          => Bits.clear(src,p0,p1);

        public static ulong inject_64(ulong src, ulong dst, byte index, byte length)
              => Bits.inject(src,dst,index,length);


    }
}