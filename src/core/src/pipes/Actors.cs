//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost]
    public readonly struct Actors
    {
        [MethodImpl(Inline), Op]
        public static Actor define(StringAddress name)
            => new Actor(name);

        [MethodImpl(Inline), Op]
        public static Actor<S,T> define<S,T>(StringAddress name, S src, T dst)
            => new Actor<S,T>(name, src, dst);
    }
}