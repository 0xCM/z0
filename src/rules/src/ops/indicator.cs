//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct Rules
    {
        [MethodImpl(Inline), Op]
        public static char indicator(BasicTypeKind src)
            => src switch {
                BasicTypeKind.Float => 'f',
                BasicTypeKind.Signed => 'i',
                BasicTypeKind.Unsigned => 'u',
                _ => Chars.Null,
            };
    }
}