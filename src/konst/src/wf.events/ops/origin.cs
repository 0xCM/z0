//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct WfEvents
    {
        [MethodImpl(Inline)]
        public static WfEventPair<S,T> pair<S,T>(in S a, in T b)
            where S : struct, IWfEvent<S>
            where T : struct, IWfEvent<T>
                => new WfEventPair<S,T>(a,b);

        [MethodImpl(Inline), Op]
        public static EventOrigin origin(in WfEventId id, string actor, in WfCaller call)
            => new EventOrigin(id,actor, call);

        [MethodImpl(Inline), Op]
        public static EventOrigin origin(in WfEventId id, PartId part, string actor,
            [CallerMemberName] string caller = null,
            [CallerFilePath] string file = null,
            [CallerLineNumber] int? line = null)
                    => new EventOrigin(id,actor, WfCore.caller(part, caller,file,line));
    }
}