namespace Z0.Asm.Check
{

    using System;

    static class AsmValidationMessages
    {
        public static void ValidatingOperator(this IAppMsgSink dst, OpUri uri, OperatorClass opclass)
            => dst.NotifyConsole(AppMsg.NoCaller($"Validating execution of the {opclass} operator {uri}"));

        public static void EvaluatedPoint<T>(this IAppMsgSink dst, string opname, T a, T b, T result)
            => dst.NotifyConsole(AppMsg.NoCaller($"{opname}({a}, {b}) = {result}"));
    }

}