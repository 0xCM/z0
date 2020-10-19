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

    partial struct Symbolic
    {
        [MethodImpl(Inline)]
        public static TokenInfo token<T>(T index, string id, string value, string description)
            where T : unmanaged, Enum
                => new TokenInfo(EnumValue.e32u(index), id, value, description);
    }
}