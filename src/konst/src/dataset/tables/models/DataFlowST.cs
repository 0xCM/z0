//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct DataFlow<S,T>
    {
        public readonly S Source;

        public readonly T Target;

        [MethodImpl(Inline)]
        public DataFlow(S src, T dst)
        {
            Source = src;
            Target = dst;
        }
    }
}