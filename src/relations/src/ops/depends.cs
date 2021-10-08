//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Relations
    {
        [MethodImpl(Inline)]
        public static Dependency<S,T> depends<S,T>(uint key, S src, T dst)
            => new Dependency<S,T>(key, src,dst);
    }
}