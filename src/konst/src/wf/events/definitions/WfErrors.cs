//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    [ApiHost]
    public readonly struct WfErrors
    {
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static WfError<Pair<T>> neq<T>(WfStepId step, Pair<T> data, CorrelationToken ct, AppMsgSource source)
             => new WfError<Pair<T>>(step, data, ct, source);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static WfError<Pair<T>> neq<T>(WfStepId step, Pair<T> data, CorrelationToken ct, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
             => neq(step, data, ct, Flow.source(caller,file,line));

        [MethodImpl(Inline), Op]
        public static WfError<string> missing(string caller, string file, int? line, WfStepId? step = null, CorrelationToken? ct = null)
            => WfEvents.error(step ?? WfStepId.Empty, text.format(MissingPattern, caller, file, line), ct ?? CorrelationToken.Empty, Flow.source(caller,file,line));

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static WfError<Pair<T>> length<T>(WfStepId step, T a, T b, CorrelationToken ct, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new WfError<Pair<T>>(step, z.pair(a,b), ct, Flow.source(caller,file,line));

        public static AppException length(int a, int b, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(AppErrorMsg.LengthMismatch(a,b,caller,file,line));

        const string MissingPattern = "Implementation amiss | {0} | {1} | {2}";

        const string LengthMismatch = "Length mismatch: {0} != {1}";
    }
}