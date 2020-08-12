//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Data;
    
    using static Konst;
    using static z;

    public readonly struct Selector<D,S>
        where D : unmanaged, Enum      
        where S : unmanaged  
    {
        public readonly D Id;

        public readonly S Position;

        [MethodImpl(Inline)]        
        public Selector(D id)
        {
            Id = id;
            Position = Enums.scalar<D,S>(Id);
        }
    }
}