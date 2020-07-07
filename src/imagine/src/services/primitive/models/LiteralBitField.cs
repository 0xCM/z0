//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct LiteralBitField<T,I,P,W,M>
        where T : unmanaged
        where I : unmanaged, Enum
        where P : unmanaged, Enum
        where W : unmanaged, Enum
        where M : unmanaged, Enum
    {
        
    }

    public readonly struct LiteralBitFields
    {        
        public static LiteralBitField<T,I,P,W,M> specify<T,I,P,W,M>(T t = default, I id = default, P pos = default, W width = default, M mask = default)
            where T : unmanaged
            where I : unmanaged, Enum
            where P : unmanaged, Enum
            where W : unmanaged, Enum
            where M : unmanaged, Enum
                => default;
    }
}