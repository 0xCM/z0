//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public interface ISequenceRule<T> : IRule<IndexedView<T>>
        where T : IRule<T>
    {
        IndexedView<T> Terms
            => Content;

        Multiplicity Multiplicity
            => 0;
    }

    public interface ISingletonSeq<T> : ISequenceRule<T>
        where T : IRule<T>
    {
        T Term => Terms[0];

        Multiplicity ISequenceRule<T>.Multiplicity
            => Multiplicity.One;
    }
}