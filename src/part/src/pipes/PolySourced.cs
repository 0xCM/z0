//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct PolySourced : IPolySourced
    {
        public IPolySource Source {get;}

        [MethodImpl(Inline)]
        public PolySourced(IPolySource source)
        {
            Source = source;
        }
    }
}