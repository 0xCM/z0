//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Konst;

    using AC = AsciCharCode;

    partial struct SymbolicTests
    {
        public readonly struct IsSpace : ISymbolicTest<IsSpace, char>
        {
            [MethodImpl(Inline)]
            public static bool check(char c)
                => (ushort)AC.Space == (ushort)c;

            [MethodImpl(Inline)]
            public bit Check(char c)
                => check(c);
        }
    }
}