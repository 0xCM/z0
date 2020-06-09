//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    
    readonly struct BitStream<T> : IStreamSource<bit>
        where T : struct
    {
        readonly IEnumerable<T> Source;

        [MethodImpl(Inline)]
        public BitStream(IEnumerable<T> source)
        {
            Source = source;
        }

        [MethodImpl(Inline)]
        public IEnumerable<bit> Next()
            => BitStream.from(Source);
    }
}