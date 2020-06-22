//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    static class EvalMessages
    {
        public static void EvaluatedPoint<T>(this IAppMsgSink dst, string opname, T a, T b, T result)
            => dst.NotifyConsole(AppMsg.NoCaller($"{opname}({a}, {b}) = {result}"));

        public static void AnalyzingEvaluation(this IAppMsgSink dst, in ApiCode api)
            => dst.NotifyConsole(AppMsg.NoCaller($"Analyzing evaluation of {api.Uri.WithScheme(OpUriScheme.Located)}", AppMsgKind.Babble));
    }
}