//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct TableSelector<D,S>
        where D : unmanaged, Enum      
        where S : unmanaged  
    {
        public readonly D Id;

        public readonly S Position;

        [MethodImpl(Inline)]        
        public TableSelector(D id)
        {
            Id = id;
            Position = Enums.scalar<D,S>(Id);
        }
    }
}