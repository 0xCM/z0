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

    public interface ILegacySymbol<A> : ISymbolic
        where A : struct, ILegacyAlphabet<A>
    {
        ReadOnlySpan<char> Content {get;}
    }
}