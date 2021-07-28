//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Blit
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public struct SmallName
    {
        ulong Data;

        [MethodImpl(Inline)]
        internal SmallName(ulong data)
        {
            Data = data;
        }
    }
}