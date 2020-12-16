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
    public interface IFormatter : ICellMap
    {
        object Format(object src);
    }

    public interface IFormatter<S,T> : IFormatter, ICellMap<S,T>
    {
        T Format(S src);

        bool ICellMap<S,T>.Transform(in S src, out T dst)
        {
            dst = Format(src);
            return true;
        }

        object IFormatter.Format(object src)
            => ((S)src);
    }
}