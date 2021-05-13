//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Microsoft.CodeAnalysis;

    public interface ICodeSymbol
    {
        ISymbol Symbol {get;}
    }

    public interface ICodeSymbol<T> : ICodeSymbol
        where T : ICodeSymbol
    {
        new T Symbol {get;}
    }

    public interface ICodeSymbol<H,T> : ICodeSymbol<T>
        where T : ICodeSymbol
        where H : ICodeSymbols<H,T>, new()
    {

    }
}