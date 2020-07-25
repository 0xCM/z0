//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public readonly struct TableReader<S,T> : ITableReader<TableReader<S,T>, ReaderState<S>, T>
        where T : struct
        where S : struct, ISourceFacets
    {
        public TableReader(in ReaderState<S> state)
        {
            State = state;
        }
        
        public readonly ReaderState<S> State;

        public TableReader<S,T> Init(ReaderState<S> state)
            => new TableReader<S,T>(state);
        
        public ReadOnlySpan<T> Read()
        {
            var data = State.Source;
            return z.cover<byte,T>(data[0], 0);
        }           
    }    
}