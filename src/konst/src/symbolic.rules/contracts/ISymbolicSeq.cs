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

    public interface ISymbolicSeq<T> : IRule<IndexedView<T>>
        where T : unmanaged, ISymbolicRule<T>
    {
        IndexedView<T> Terms {get;}

        MultiplicityKind Multiplicity
            => 0;
    }

    public interface ISingletonSeq<T> : ISymbolicSeq<T>
        where T : unmanaged, ISymbolicRule<T>
    {
        T Term => Terms[0];

        MultiplicityKind ISymbolicSeq<T>.Multiplicity
            => MultiplicityKind.One;
    }
}