//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Root;

    readonly struct ValueSource<T> : IValueSource<T>
        where T : struct
    {
        [MethodImpl(Inline)]
        public ValueSource(ValueEmitter<T> emitter)
            => Emitter = emitter;

        [MethodImpl(Inline)]
        public ValueSource(IEnumerable<T> stream)
            => Emitter = () => stream;

        public ValueEmitter<T> Emitter {get;}
    }
}