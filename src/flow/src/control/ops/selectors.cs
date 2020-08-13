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
        public static Selectors<D,S> selectors<D,S>(Selector<D,S>[] src, S min, S max)
            where D : unmanaged, Enum        
            where S : unmanaged
                => new Selectors<D,S>(src,min,max);
    }
}