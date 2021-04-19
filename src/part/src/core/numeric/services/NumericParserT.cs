//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct NumericParser<T> : ITextParser<T>
    {
        public ParseResult<T> Parse(string src)
            => Numeric.parse<T>(src);

        public Outcome Parse(string src, out T dst)
            => Numeric.parse<T>(src, out dst);
    }
}