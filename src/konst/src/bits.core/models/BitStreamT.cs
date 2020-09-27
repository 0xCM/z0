//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    public readonly struct BitStream<T> : IStreamSource<BitState>
        where T : struct
    {
        readonly IEnumerable<T> Source;

        readonly BitState[] Buffer;

        [MethodImpl(Inline)]
        public BitStream(IEnumerable<T> source)
        {
            Source = source;
            Buffer = sys.alloc<BitState>(size<T>()*8);
        }

        public IEnumerable<BitState> Next()
        {
            foreach(var cell in Source)
            foreach(var state in bitstates(cell, Buffer))
                yield return state;
        }
    }
}