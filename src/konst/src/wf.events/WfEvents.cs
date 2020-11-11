//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    [ApiHost(ApiNames.WfEvents, true)]
    public readonly partial struct WfEvents
    {
        const string HandlerNotFound = "Handler for {0} not found";

        const string CallerPattern = "An error was trapped by {0} on line {1} in {2}";

        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// Defines a <see cref='AppMsgSource'/>
        /// </summary>
        /// <param name="caller">The member name</param>
        /// <param name="file">The caller file path</param>
        /// <param name="line">The caller line number</param>
        [MethodImpl(Inline), Op]
        public static AppMsgSource source([Caller]string caller = null, [File] string file = null, [Line]int? line = null)
            => new AppMsgSource(PartId.None, caller, file, line);

        [Op]
        public static ErrorEvent<string> missing(CmdId cmd, [Caller] string caller = null, [File] string file= null, [Line] int? line = null)
            => new ErrorEvent<string>(cmd, string.Format(HandlerNotFound, cmd), CorrelationToken.Empty, source(caller,file,line));

        [Op, Closures(UInt64k)]
        public static ErrorEvent<T> error<T>(WfStepId step, T content, CorrelationToken ct, [Caller] string caller  = null, [File] string file = null, [Line] int? line = null)
            => new ErrorEvent<T>(step, content, ct, source(caller,file,line));

        [Op, Closures(UInt64k)]
        public static ErrorEvent<T> error<T>(WfHost host, Exception e, T content, CorrelationToken ct,  AppMsgSource origin)
            => new ErrorEvent<T>(e, content, ct, origin);

        [Op]
        public static ErrorEvent<Exception> error(WfHost host, Exception e, CorrelationToken ct, [Caller] string caller  = null, [File] string file = null, [Line] int? line = null)
        {
            const string Pattern = "{0}" + Eol + "{1}";
            var where = text.format(CallerPattern, caller, line, file);
            var what = e?.ToString() ?? EmptyString;
            var msg = text.format(Pattern, where, what);
            var origin = source(caller,file,line);
            return new ErrorEvent<Exception>(e, e, ct, origin);
        }
    }
}