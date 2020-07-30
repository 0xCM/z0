//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly struct Arrows
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Arrow<T> link<T>(T src, T dst)
            => new Arrow<T>(src,dst);

        [MethodImpl(Inline)]
        public static Arrow<S,T> connect<S,T>(S src, T dst)
            => new Arrow<S,T>(src, dst);            
    }
}