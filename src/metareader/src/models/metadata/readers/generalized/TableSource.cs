//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public readonly struct TableSource : ITableSource<BinaryCode>
    {
        public TableSource(BinaryCode data, uint count, uint size)
        {
            RowCount = count;
            RowSize = size;
            RowSource = data;
        }

        public uint RowSize {get;}

        public uint RowCount {get;}

        public BinaryCode RowSource {get;}
    }

    public readonly struct TableSource<T> : ITableSource<T>
        where T : IByteSpanProvider
    {
        public uint RowCount {get;}

        public uint RowSize {get;}

        public T RowSource {get;}
        
        public TableSource(T data,  uint count, uint size)
        {
            RowCount = count;            
            RowSize = size;
            RowSource = data;            
        }

        public ReadOnlySpan<byte> Data
        {
            get => RowSource.Bytes;
        }
    }
}