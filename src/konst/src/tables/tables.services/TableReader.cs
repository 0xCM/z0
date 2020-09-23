//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct TableReader<S,T>
        where T : struct
        where S : struct, ISourceFacets
    {
        public readonly ReaderState<S> State;

        [MethodImpl(Inline)]
        public TableReader(ReaderState<S> state)
            => State = state;

        public ReadOnlySpan<T> Read()
        {
            var data = State.Source;
            return cover<byte,T>(data[0], 0);
        }
    }
}