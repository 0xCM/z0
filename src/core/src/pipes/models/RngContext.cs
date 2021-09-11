//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct RngContext : IRngContext<RngContext>
    {
        public IPolyrand Random {get;}

        [MethodImpl(Inline)]
        public RngContext(IPolyrand random)
        {
            Random = random;
        }
    }
}