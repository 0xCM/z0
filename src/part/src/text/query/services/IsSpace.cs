//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    using T = TextQuery;

    partial struct SymbolicTests
    {
        [MethodImpl(Inline), Op]
        public static IsSpace SpaceRule()
            => default;

        public readonly struct IsSpace : ISymbolicQuery<IsSpace,char>
        {
            [MethodImpl(Inline)]
            public bit Check(char c)
                => T.space(c);
        }
    }
}