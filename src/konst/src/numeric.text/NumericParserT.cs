//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct NumericParser<T> : ITextParser<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public ParseResult<T> Parse(string src)
            => NumericParser.parse<T>(src);
    }

    public readonly struct InfallibleNumericParser<T> : ITextParser<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public ParseResult<T> Parse(string src)
            => NumericParser.parse<T>(src);

        public T Zero => default;
    }
}