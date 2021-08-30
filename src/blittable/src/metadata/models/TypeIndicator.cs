//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct Blit
    {
        public readonly struct TypeIndicator
        {
            public ushort Data {get;}

            [MethodImpl(Inline)]
            internal TypeIndicator(ushort symbol)
            {
                Data = symbol;
            }

            [MethodImpl(Inline)]
            public static implicit operator char(TypeIndicator src)
                => (char)src.Data;

            public string Format()
                => Types.format(this);

            public override string ToString()
                => Format();
        }
    }
}