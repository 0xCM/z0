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
        public static TokenModel token<T>(T index, string id, string value, string description)
            where T : unmanaged, Enum
                => new TokenModel(EnumValue.e32i(index), id, value, description);
    }
}