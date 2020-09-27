//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct OrGate : IBinaryLogicGate
    {
        [MethodImpl(Inline)]
        public Bit32 Invoke(Bit32 x, Bit32 y)
            => (x | y);
    }

}