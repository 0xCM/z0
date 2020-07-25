//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ITableRow
    {
        ReadOnlySpan<byte> Content {get;}
    }

    public interface ITableRow<T> : ITableRow
        where T : struct
    {
        new T Content {get;}

        ReadOnlySpan<byte> ITableRow.Content
             => z.bytes(Content);
    }
}