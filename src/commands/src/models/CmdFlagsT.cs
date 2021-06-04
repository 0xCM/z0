//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public struct CmdFlags<K>
        where K : unmanaged
    {
        Flags<K> State;

        public bit this[K flag]
        {
            [MethodImpl(Inline)]
            get => State[flag];
        }
    }
}
