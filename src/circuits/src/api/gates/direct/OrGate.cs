//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct OrGate : IBinaryGate
    {
        [MethodImpl(Inline)]
        public bit Invoke(bit x, bit y)
            => (x | y);
    }
}