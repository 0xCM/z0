//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct NumericParser<T>
    {
        public Outcome Parse(string src, out T dst)
            => Numeric.parse<T>(src, out dst);
    }
}