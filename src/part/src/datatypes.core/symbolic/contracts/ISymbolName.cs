//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ISymbolName : ITextual
    {
        Identifier Identifier {get;}

        TextBlock SymbolText {get;}

        string ITextual.Format()
            => SymbolText;
    }

    [Free]
    public interface ISymbolName<K> : ISymbolName
        where K : unmanaged
    {

    }
}