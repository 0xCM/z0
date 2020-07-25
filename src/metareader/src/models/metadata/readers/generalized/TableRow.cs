//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct TableRow
    {
        readonly BinaryCode Data;
        
        public TableRow(BinaryCode data)
        {
            Data = data;
        }
        
        public ReadOnlySpan<byte> Content
            => Data.Data;
    }

    public readonly struct TableRow<T> : ITableRow<T>
        where T : struct
    {
        public TableRow(T data)
        {
            Content = data;
        }
        
        public T Content {get;}

        public ReadOnlySpan<byte> Bytes 
            => z.bytes(Content);
    }
}