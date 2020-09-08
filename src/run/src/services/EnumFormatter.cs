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

    public readonly struct EnumFormatter<E> : IFormatter<E>
        where E : unmanaged, Enum
    {
        [MethodImpl(Inline)]
        public string Format(E src)
            => src.ToString();
    }
}