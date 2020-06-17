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

    public readonly struct XOrGate : IBinaryLogicGate
    {
        internal static readonly XOrGate Gate = default;        
        
        [MethodImpl(Inline)]
        public bit Invoke(bit x, bit y)
            => (x ^ y);
    }
}