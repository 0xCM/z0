//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IToken : ITypedLiteral<TableIndex,byte>, ITextual
    {
        TableIndex Index {get;}

        Token A  => default;

        TableIndex ITypedLiteral<TableIndex>.Class
            => Index;

        byte ITypedLiteral<TableIndex,byte>.Value
            => (byte)Index;

        string ITextual.Format()
            => Index.ToString();
    }

    [Free]
    public interface IToken<K> : IToken
        where K : unmanaged, IToken<K>
    {

    }
}