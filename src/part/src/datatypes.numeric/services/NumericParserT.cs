//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct NumericParser<T> : ITextParser<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public ParseResult<T> Parse(string src)
            => Numeric.parse<T>(src);
    }
}