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

    public interface ISymbolicSeq<T> : ISymbolicRule<IndexedView<T>>
        where T : ISymbolicRule<T>
    {
        IndexedView<T> Terms
            => Content;

        Multiplicity Multiplicity
            => 0;
    }

    public interface ISingletonSeq<T> : ISymbolicSeq<T>
        where T : ISymbolicRule<T>
    {
        T Term => Terms[0];

        Multiplicity ISymbolicSeq<T>.Multiplicity
            => Multiplicity.One;
    }
}