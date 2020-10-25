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

    using AC = AsciCharCode;

    [ApiHost(ApiNames.SymbolicTest, true)]
    public readonly struct SymbolicTest
    {
        [MethodImpl(Inline)]
        public static bool test<T,S>(S symbol, T test = default)
            where S : unmanaged
            where T : unmanaged, ISymbolicTest<T,S>
                => test.Check(symbol);

        [MethodImpl(Inline), Op]
        public static bool whitespace(char c)
            => test(c, IsWhitespace.Service);
    }

    public readonly partial struct SymbolicTests
    {
        public readonly struct IsWhitespace : ISymbolicTest<IsWhitespace, char>
        {
            public static IsWhitespace Service => default;

            public static bool check(char c)
                => IsSpace.check(c) || IsTab.check(c) || IsNewLine.check(c);

            [MethodImpl(Inline)]
            public bool Check(char c)
                => check(c);
        }

        public readonly struct IsTab : ISymbolicTest<IsTab, char>
        {
            [MethodImpl(Inline)]
            public static bool check(char c)
                => (ushort)AC.Tab == (ushort)c;

            [MethodImpl(Inline)]
            public bool Check(char c)
                => check(c);
        }

        public readonly struct IsSpace : ISymbolicTest<IsSpace, char>
        {
            [MethodImpl(Inline)]
            public static bool check(char c)
                => (ushort)AC.Space == (ushort)c;

            [MethodImpl(Inline)]
            public bool Check(char c)
                => check(c);
        }

        public readonly struct IsNewLine : ISymbolicTest<IsWhitespace, char>
        {
            [MethodImpl(Inline)]
            public static bool check(char c)
                => (ushort)AC.NL == (ushort)c || (ushort)AC.CR == (ushort)c;

            [MethodImpl(Inline)]
            public bool Check(char c)
                => check(c);
        }
    }
}