//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Check
{
    using System;

    static class AsmValidationMessages
    {
        public static void ValidatingOperator(this IAppMsgSink dst, OpUri uri, OperatorClass opclass)
            => dst.NotifyConsole(AppMsg.NoCaller($"Validating execution of the {opclass} operator {uri}"));

        public static void EvaluatedPoint<T>(this IAppMsgSink dst, string opname, T a, T b, T result)
            => dst.NotifyConsole(AppMsg.NoCaller($"{opname}({a}, {b}) = {result}"));

        public static void AnalyzingEvaluation(this IAppMsgSink dst, in ApiMemberCode api)
            => dst.NotifyConsole(AppMsg.NoCaller($"Analyzing evaluation of {api.Uri.WithScheme(OpUriScheme.Located)}", AppMsgKind.Babble));
    }

}