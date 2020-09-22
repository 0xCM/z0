//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using K = Kinds;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    static class EvalMessages
    {
        public static void EvaluatedPoint<T>(this IAppMsgSink dst, string opname, T a, T b, T result)
            => dst.NotifyConsole(AppMsg.info($"{opname}({a}, {b}) = {result}"));

        public static void AnalyzingEvaluation(this IAppMsgSink dst, in ApiMemberHex api)
            => dst.NotifyConsole(AppMsg.define($"Analyzing evaluation of {api.Uri.WithScheme(ApiUriScheme.Located)}", MessageKind.Babble));

        public static void RuntimeEvalFailure(this IAppMsgSink dst, in ApiMemberHex api, Exception e, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        {
            dst.NotifyConsole(AppMsg.error($"Runtime evaluation error occurred duing execution of {api.Id}", caller, file, line));
            dst.NotifyConsole(AppMsg.define(e, MessageKind.Error));
        }

        public static AppMsg BufferSizeError(ApiMemberHex code, BufferToken buffer)
            => AppMsg.info($"There are {buffer.BufferSize} available buffer bytes but at least {code.Length} is required by {code.Member.Id}");
    }
}