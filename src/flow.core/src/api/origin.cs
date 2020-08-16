//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct FLow    
    {
        [Op]
        public static WfEventOrigin origin(in WfEventId id, string actor, in WfCaller call)
            => new WfEventOrigin(id,actor, call);

        [Op]
        public static WfEventOrigin origin(in WfEventId id, PartId part, string actor, [CallerMemberName] string caller = null, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => new WfEventOrigin(id,actor, Flow.caller(part, caller,file,line));
    }
}