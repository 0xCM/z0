//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Reflection.Metadata.Ecma335;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IRowKind : ITypedLiteral<TableIndex,byte>, ITextual
    {
        TableIndex Index {get;}

        TableIndex ITypedLiteral<TableIndex>.Class
            => Index;

        byte ITypedLiteral<TableIndex,byte>.Value
            => (byte)Index;

        string ITextual.Format()
            => Index.ToString();
    }

    [Free]
    public interface IRowKind<K> : IRowKind
        where K : unmanaged, IRowKind<K>
    {

    }
}