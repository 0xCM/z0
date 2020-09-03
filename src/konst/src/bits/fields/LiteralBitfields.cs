//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct LiteralBitfields
    {
        [MethodImpl(Inline)]
        public static LiteralBitField<T,I,P,W,M> define<T,I,P,W,M>(T t = default, I id = default, P pos = default, W width = default, M mask = default)
            where T : unmanaged
            where I : unmanaged, Enum
            where P : unmanaged, Enum
            where W : unmanaged, Enum
            where M : unmanaged, Enum
                => default;

    }
}