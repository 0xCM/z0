//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct LiteralBitField<I,P,W,M>
        where I : unmanaged, Enum
        where P : unmanaged, Enum
        where W : unmanaged, Enum
        where M : unmanaged, Enum
    {
        
    }

    public readonly struct LiteralBitFields
    {        
        public static LiteralBitField<I,P,W,M> specify<I,P,W,M>(I id = default, P pos = default, W width = default, M mask = default)
            where I : unmanaged, Enum
            where P : unmanaged, Enum
            where W : unmanaged, Enum
            where M : unmanaged, Enum
                => default;
    }
}