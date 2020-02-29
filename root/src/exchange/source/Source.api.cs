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

    public static class Source
    {
        [MethodImpl(Inline)]
        public static ISource<T> Create<T>(SourceEmitter<T> f)
            => new Source<T>(f);
    }
}