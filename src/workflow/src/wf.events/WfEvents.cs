//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Part;

    [ApiHost(ApiNames.WfEvents, true)]
    readonly struct WfEvents
    {
        const string HandlerNotFound = "Handler for {0} not found";

        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        internal static EventSignal signal(IWfRuntime wf)
            => EventSignal.create(wf.EventSink, wf.Host, wf.Ct);

        [Op]
        public static void format(ErrorEvent<Exception> error, StringBuilder dst)
        {
            const string ErrorTrace = "{0} | {1} | {2} | Outer | {3} | {4} | {5}";
            const string InnerTrace = "{0} | {1} | {2} | Inner | {3} | {4} | {5} | {6}";

            var exception = error.Payload;
            var eType = exception.GetType();
            var outer = string.Format(ErrorTrace, error.EventId, error.Summary, error.Source, eType.Name, exception.Data.Message, exception.Data.StackTrace);
            dst.AppendLine(outer);

            int level = 0;

            var e = exception.Data.InnerException;
            while (e != null)
            {
                dst.AppendLine(string.Format(InnerTrace, error.EventId, error.Summary, error.Source, level, eType.Name, e.Message, e.StackTrace));
                e = e.InnerException;
                level += 1;
            }
        }
    }
}