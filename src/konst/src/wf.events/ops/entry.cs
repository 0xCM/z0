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
        [Op, Closures(Closure)]
        public static EventLogEntry entry<T>(ErrorEvent<T> src)
        {
            var dst = new EventLogEntry();
            dst.Identifier = src.EventId.Format();
            dst.Time = src.EventId.Ts;
            dst.EventName = src.EventId.Name;
            dst.Level = LogLevel.Error;
            dst.Source = src.Source.Format();
            dst.Message = src.Summary;
            return dst;
        }

        public static EventLogEntry entry<H>(IWfEvent<H> src)
            where H : struct, IWfEvent<H>
        {
            var dst = new EventLogEntry();
            dst.Identifier = src.EventId.Format();
            dst.Time = src.EventId.Ts;
            dst.EventName = src.EventId.Name;
            dst.Level = LogLevel.Error;
            return dst;
        }

        public static EventLogEntry entry<H,T>(IWfEvent<H,T> src)
            where T : struct, IWfEvent<T>
            where H : struct, IWfEvent<H,T>
        {
            var dst = new EventLogEntry();
            dst.Identifier = src.EventId.Format();
            dst.Time = src.EventId.Ts;
            dst.EventName = src.EventId.Name;
            dst.Level = LogLevel.Error;
            dst.Message = src.Payload.Format();
            return dst;
        }
    }
}