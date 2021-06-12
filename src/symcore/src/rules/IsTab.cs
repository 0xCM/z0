//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    using T = SymbolicQuery;

    partial struct SymbolicRules
    {
        [MethodImpl(Inline), Op]
        public static IsTab TabRule()
            => default;

        public readonly struct IsTab : ISymbolQuery<IsTab,char>
        {
            [MethodImpl(Inline)]
            public bit Test(char c)
                => T.tab(c);
        }
    }
}