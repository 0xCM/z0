//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct WfEventBuilder    
    {
        [MethodImpl(Inline)]
        public static Watching<T> watching<T>(string actor, T target, CorrelationToken ct)
            where T : ITextual
                => new Watching<T>(actor, target, ct);
    }
}