//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Arrays
    {
        [MethodImpl(Inline), Op]
        public static void copy(in byte src, uint count, ref byte dst, ref uint index)
        {
            for(var j=0u; j<count; j++)
                z.seek(dst, index++) = z.skip(src, j);
        }


    }
}