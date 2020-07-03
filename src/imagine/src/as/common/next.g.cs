//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct As
    {

        [MethodImpl(Inline), Op]
        static ref  S gNext<S,T>(in S src, ref T dst)
            where S : unmanaged
            where T : unmanaged
        {
            dst = @as<S,T>(ref edit(src));
            dst = add(dst, 1);
            return ref add(src, size<T>());
        }

    }
}