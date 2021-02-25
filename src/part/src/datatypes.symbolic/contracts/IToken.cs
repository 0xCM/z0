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

        Identifier Name {get;}

        Name Symbol {get;}

        string ITextual.Format()
            => string.Format("{0,-8} | {1,-12} | {2}", Index, text.ifempty(Name, RP.EmptySymbol), text.ifempty(Symbol, RP.EmptySymbol));
    }

    [Free]
    public interface IToken<K> : IToken
        where K : unmanaged
    {
        K Kind {get;}
    }
}