//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IParser2<S,T> : ITransformer2<S,T>
    {
        ParseResult<S,T> Parse(S src);

        bool ITransformer2<S,T>.Transform(in S src, out T dst)
            => Parse(src, out dst);

        bool Parse(in S src, out T dst)
        {
            var adapter = new ParseAdapter2<S,T>(this);
            return adapter.Parse(src, out dst);
        }
    }
}