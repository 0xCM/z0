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
    using static SymbolicTests;

    [ApiHost(ApiNames.SymbolicTest, true)]
    public readonly struct SymbolicTest
    {
        [MethodImpl(Inline)]
        public static bool test<T,S>(S symbol, T test = default)
            where S : unmanaged
            where T : unmanaged, ISymbolicTest<T,S>
                => test.Check(symbol);

        [MethodImpl(Inline), Op]
        public static bit whitespace(char c)
            => test(c, default(IsWhitespace));
    }

    public readonly partial struct SymbolicTests
    {
    }
}