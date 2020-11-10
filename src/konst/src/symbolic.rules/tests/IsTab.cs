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
        public readonly struct IsTab : ISymbolicTest<IsTab, char>
        {
            [MethodImpl(Inline)]
            public static bit check(char c)
                => (ushort)AC.Tab == (ushort)c;

            [MethodImpl(Inline)]
            public bit Check(char c)
                => check(c);
        }
    }
}