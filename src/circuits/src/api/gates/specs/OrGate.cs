//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    public readonly struct OrGate : IBinaryLogicGate
    {
        internal static readonly OrGate Gate = default;        
        
        [MethodImpl(Inline)]
        public bit Send(bit x, bit y)
            => (x | y);
    }

}