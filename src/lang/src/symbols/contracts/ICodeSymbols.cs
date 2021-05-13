//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ICodeSymbols<T> : IIndex<T>
        where T : ICodeSymbol
    {
        CodeSymbol<T> Symbol(uint index);
    }

    public interface ICodeSymbols<H,T> : ICodeSymbols<T>
        where T : ICodeSymbol
        where H : ICodeSymbols<H,T>, new()
    {
        new CodeSymbol<H,T> Symbol(uint index);

        CodeSymbol<T> ICodeSymbols<T>.Symbol(uint index)
            => Symbol(index);
    }

}