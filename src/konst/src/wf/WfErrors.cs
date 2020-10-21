//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Workflow;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public readonly struct WfErrors
    {
        const string MissingPattern = "Implementation amiss | {0} | {1} | {2}";

        const string LengthMismatch = "Length mismatch: {0} != {1}";

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static ErrorEvent<Pair<T>> neq<T>(WfStepId step, Pair<T> data, CorrelationToken ct, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
             => neq(step, data, ct, Workflow.source(caller,file,line));

        [MethodImpl(Inline), Op]
        public static ErrorEvent<string> missing(WfStepId step, string caller, string file, int? line, CorrelationToken? ct = null)
            => error(step, text.format(MissingPattern, caller, file, line), ct ?? CorrelationToken.Empty, Workflow.source(caller,file,line));

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static ErrorEvent<Pair<T>> length<T>(WfStepId step, T a, T b, CorrelationToken ct, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new ErrorEvent<Pair<T>>(step, z.pair(a,b), ct, Workflow.source(caller,file,line));

        public static AppException length(WfStepId step, int a, int b, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(AppErrorMsg.LengthMismatch(a,b,caller,file,line));

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static ErrorEvent<Pair<T>> neq<T>(WfStepId step, Pair<T> data, CorrelationToken ct, AppMsgSource source)
             => new ErrorEvent<Pair<T>>(step, data, ct, source);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static ErrorEvent<T> error<T>(string actor, T content, CorrelationToken ct, [Caller] string caller  = null, [File] string file = null, [Line] int? line = null)
            => new ErrorEvent<T>(actor, content, ct, source(caller,file,line));

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static ErrorEvent<T> error<T>(WfStepId step, T content, CorrelationToken ct, [Caller] string caller  = null, [File] string file = null, [Line] int? line = null)
                => new ErrorEvent<T>(step, content, ct, source(caller,file,line));

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static ErrorEvent<T> error<T>(WfStepId step, T content, CorrelationToken ct, AppMsgSource origin)
            => new ErrorEvent<T>(step, content, ct, origin);

        [Op]
        public static ErrorEvent<string> error(Exception e, CorrelationToken ct, [Caller] string caller  = null, [File] string file = null, [Line] int? line = null)
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