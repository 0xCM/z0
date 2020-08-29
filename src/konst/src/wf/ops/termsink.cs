//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    partial struct AB
    {
        [MethodImpl(Inline), Op]
        public static WfTermEventSink termsink(IWfEventLog log, CorrelationToken ct)
            => WfTermEventSink.create(log, ct);
    }
}