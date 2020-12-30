//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static SymbolicTests;

    [ApiHost(ApiNames.Rules, true)]
    public readonly partial struct SymbolicRules
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static IsOneOf oneOf(params char[] src)
            => new IsOneOf(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolRange<T> range<T>(T min, T max)
            where T : unmanaged
                => new SymbolRange<T>(min,max);

        [MethodImpl(Inline), Op]
        public static IsInRange inRange(char min, char max)
            => new IsInRange(range(min,max));

        [MethodImpl(Inline), Op]
        public static IsSpace space()
            => default;

        [MethodImpl(Inline), Op]
        public static IsTab tab()
            => default;

        [MethodImpl(Inline), Op]
        public static IsNewLine newLine()
            => default;

        [MethodImpl(Inline), Op]
        public static IsWhitespace whitespace()
            => default;

        [MethodImpl(Inline), Op]
        public static IsHexDigit hexDigit()
            => default;
    }
}