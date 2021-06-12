//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct SymbolicRules
    {
        [MethodImpl(Inline), Op]
        public static IsSpace SpaceRule()
            => default;

        public readonly struct IsSpace : ISymbolQuery<IsSpace,char>
        {
            [MethodImpl(Inline)]
            public bit Test(char c)
                => SymbolicQuery.space(c);
        }
    }
}