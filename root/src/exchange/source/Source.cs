//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Root;

    public readonly struct Source<T> : ISource<T>
    {        
        public static Source<T> Empty => new Source<T>(none<T>);
        
        readonly SourceEmitter<T> Emitter;
        
        [MethodImpl(Inline)]
        internal Source(SourceEmitter<T> emitter)
            => Emitter = emitter;
        
        [MethodImpl(Inline)]
        public Option<T> Next()
            => Emitter();
    }
}