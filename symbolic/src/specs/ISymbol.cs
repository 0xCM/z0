//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ISymbolic
    {
        string Format();
    }        

    public interface ISymbol<A> : ISymbolic
        where A : struct, IAlphabet<A>
    {
        ReadOnlySpan<char> Content {get;}
    }
}