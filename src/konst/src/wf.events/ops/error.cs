//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Flow;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    partial struct WfEvents
    {
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static WfError<T> error<T>(string actor, T content, CorrelationToken ct,
            [Caller] string caller  = null, [File] string file = null, [Line] int? line = null)
                => new WfError<T>(actor, content, ct, source(caller,file,line));

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static WfError<T> error<T>(WfStepId step, T content, CorrelationToken ct,
            [Caller] string caller  = null, [File] string file = null, [Line] int? line = null)
                => new WfError<T>(step, content, ct, source(caller,file,line));

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static WfError<T> error<T>(WfStepId step, T content, CorrelationToken ct, AppMsgSource origin)
            => new WfError<T>(step, content, ct, origin);

        [Op]
        public static WfError<string> error(Exception e, CorrelationToken ct,
            [Caller] string caller  = null, [File] string file = null, [Line] int? line = null)
        {
            const string CallerPattern = "An error was trapped by {0} on line {1} in {2}";
            const string Pattern = "{0}" + Eol + "{1}";
            var where = text.format(CallerPattern, caller, line, file);
            var what = e.ToString();
            var msg = text.format(Pattern, where, what);
            return error(caller, msg, ct);
        }
    }
}