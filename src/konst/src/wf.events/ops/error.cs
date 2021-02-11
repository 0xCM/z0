//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct WfEvents
    {
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static ErrorEvent<T> error<T>(string cmd, T data,  EventOrigin source)
            => new ErrorEvent<T>(cmd, data, source);

        [Op, Closures(UInt64k)]
        public static ErrorEvent<T> error<T>(WfStepId step, T data, EventOrigin source)
            => new ErrorEvent<T>(step, data, source);

        [Op]
        public static ErrorEvent<WfHost> error(WfHost host, Exception e, EventOrigin source)
            => new ErrorEvent<WfHost>(e, host, source);

        [Op]
        public static ErrorEvent<string> missing(CmdId cmd, EventOrigin source)
            => new ErrorEvent<string>(cmd, string.Format(HandlerNotFound, cmd), source);
    }
}