//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IWord<W,A> : ISymbolic
        where A : struct, IAlphabet<A>
        where W : struct, IWord<W,A> 
    {

    }

    // public interface IMonoidalWord<W,A> : IFreeMonoid<W>, ISymbolic
    //     where A : struct, IAlphabet<A>
    //     where W : struct, IMonoidalWord<W,A>, IFreeMonoid<W>
    // {

    // }
}
