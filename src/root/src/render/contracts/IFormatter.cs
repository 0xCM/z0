//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes a text serializer
    /// </summary>
    public interface IFormatter : ITransformer2
    {
        object Format(object src);
    }

    public interface IFormatter<S,T> : IFormatter, ITransformer2<S,T>
    {
        T Format(S src);

        bool ITransformer2<S,T>.Transform(in S src, out T dst)
        {
            dst = Format(src);
            return true;
        }

        object IFormatter.Format(object src)
            => ((S)src);
    }
}