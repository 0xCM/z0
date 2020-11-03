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

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    partial struct WfEvents
    {
        [MethodImpl(Inline), Op]
        public static WfEventOrigin origin(WfStepId step, WfEventId @event, [Caller]string caller = null, [File] string file = null, [Line]int? line = null)
            => new WfEventOrigin(step, @event, z.caller(caller, file, line));
    }
}