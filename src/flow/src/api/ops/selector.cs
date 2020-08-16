//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct OldFlow    
    {
        [MethodImpl(Inline)]
        public static TableSelector<D,S> selector<D,S>(D id, S s = default)
            where D : unmanaged, Enum        
            where S : unmanaged
                => new TableSelector<D,S>(id);
    }
}