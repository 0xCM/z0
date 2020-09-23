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

    public readonly struct WfRunSpec<C,S,T>
    {
        public readonly C Config;

        public readonly S Source;

        public readonly T Target;

        [MethodImpl(Inline)]
        public WfRunSpec(in C config, in S source, in T target)
        {
            Config = config;
            Source = source;
            Target = target;
        }
    }
}