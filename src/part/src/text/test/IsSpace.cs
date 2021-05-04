//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct SymbolicTests
    {
        public readonly struct IsSpace : ISymbolicTest<IsSpace,char>
        {
            [MethodImpl(Inline)]
            public static bool check(char c)
                => (ushort)AsciCharCode.Space == (ushort)c;

            [MethodImpl(Inline)]
            public bit Check(char c)
                => space(c);
        }

        [MethodImpl(Inline), Op]
        public static bool space(char c)
            => (ushort)AsciCharCode.Space == (ushort)c;
    }
}