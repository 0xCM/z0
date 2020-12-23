//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    /// <summary>
    /// Represents a bijective correspondence between two sequences of homogenous type
    /// </summary>
    public readonly struct Bijection<T>
    {
        public T[] Source {get;}

        public T[] Target {get;}

        public Bijection(T[] src, T[] dst)
        {
            Demands.insist(src != null && dst != null && src.Length == dst.Length);
            Source = src;
            Target = dst;
        }

        public Pair<T> this[uint i]
        {
            [MethodImpl(Inline)]
            get => pair(skip(Source,i), skip(Target,i));
        }
    }
}