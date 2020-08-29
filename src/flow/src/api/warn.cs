//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Flow
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static WfWarn<T> warn<T>(WfStepId step, T body, CorrelationToken ct)
            => new WfWarn<T>(step, body, ct);
    }
}