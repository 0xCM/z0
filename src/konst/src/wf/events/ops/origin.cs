//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Konst;
    using static Render;
    using static AB;

    partial struct WfEvents
    {
        [MethodImpl(Inline), Op]
        public static WfEventOrigin origin(in WfEventId id, string actor, in WfCaller call)
            => new WfEventOrigin(id,actor, call);

        [MethodImpl(Inline), Op]
        public static WfEventOrigin origin(in WfEventId id, PartId part, string actor,
            [CallerMemberName] string caller = null,
            [CallerFilePath] string file = null,
            [CallerLineNumber] int? line = null)
                    => new WfEventOrigin(id,actor, AB.caller(part, caller,file,line));
    }
}