//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct XedModels
    {
        public readonly struct Attributes
        {
            public ulong Lo {get;}

            public ulong Hi {get;}

            [MethodImpl(Inline)]
            public Attributes(ulong lo, ulong hi)
            {
                Lo = lo;
                Hi = hi;
            }
        }

    }
}