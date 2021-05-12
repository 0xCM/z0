//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes a text serializer
    /// </summary>
    public interface IFormatter : ITransformer
    {
        object Format(object src);
    }

    public interface IFormatter<S,T> : IFormatter, ITransformer<S,T>
    {
        T Format(S src);

        bool ITransformer<S,T>.Transform(in S src, out T dst)
        {
            dst = Format(src);
            return true;
        }

        object IFormatter.Format(object src)
            => ((S)src);
    }
}