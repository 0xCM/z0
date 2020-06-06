//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ILegacySymbol : ITextual
    {

    }
    
    public interface ILegacySymbol<A> : ILegacySymbol
        where A : struct, ILegacyAlphabet<A>
    {        
        ReadOnlySpan<char> Content {get;}
    }
}