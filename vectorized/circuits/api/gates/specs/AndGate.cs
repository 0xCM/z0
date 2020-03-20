//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public readonly struct AndGate : IBinaryLogicGate
    {
        internal static readonly AndGate Gate = default;        
        
        [MethodImpl(Inline)]
        public bit Send(bit x, bit y)
            => (x & y);
    }
}