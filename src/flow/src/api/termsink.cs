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
        [MethodImpl(Inline), Op]
        public static WfTermEventSink termsink(IWfEventLog log, CorrelationToken ct)
            => WfTermEventSink.create(log, ct);       
    }
}