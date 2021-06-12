//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IParser2 : ITransformer2
    {
        ParseResult Parse(object src);
    }

    public interface IParser2<S,T> : IParser2, ITransformer2<S,T>
    {
        ParseResult<S,T> Parse(S src);

        ParseResult IParser2.Parse(object src)
            => Parse((S)src);

        bool ITransformer2<S,T>.Transform(in S src, out T dst)
            => Parse(src, out dst);

        bool Parse(in S src, out T dst)
        {
            var adapter = new ParseAdapter2<S,T>(this);
            return adapter.Parse(src, out dst);
        }

        bool Parse(in S src, out T dst, out string message)
        {
            var adapter = new ParseAdapter2<S,T>(this);
            return adapter.Parse(src, out dst, out message);
        }

        T Succeed(in S src, T @default)
            => new ParseAdapter2<S,T>(this).Succeed(src, @default);
    }
}