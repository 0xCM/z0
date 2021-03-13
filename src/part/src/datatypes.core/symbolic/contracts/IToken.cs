//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IToken : ITextual, INullity
    {
        uint Index {get;}

        Identifier Identifier {get;}

        TextBlock SymbolText {get;}

        SymbolName SymbolName
            => new SymbolName(this);

        string ITextual.Format()
            => string.Format("{0,-8} | {1,-12} | {2}", Index, text.ifempty(Identifier, RP.EmptySymbol), text.ifempty(SymbolText, RP.EmptySymbol));
    }

    [Free]
    public interface IToken<K> : IToken
        where K : unmanaged
    {
        K Kind {get;}

        SymbolName IToken.SymbolName
            => new SymbolName(this);
        new SymbolName<K> SymbolName
            => new SymbolName<K>(this);
    }
}