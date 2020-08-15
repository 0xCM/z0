//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct WfCore
    {
        [MethodImpl(Inline), Op]
        public static WfTermEventSink termsink(CorrelationToken ct)
            => WfTermEventSink.create(ct);       
    }
}