//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Flow    
    {
        [MethodImpl(Inline)]
        public static Selector<D,S> selector<D,S>(D id, S s = default)
            where D : unmanaged, Enum        
            where S : unmanaged
                => new Selector<D,S>(id);
    }
}