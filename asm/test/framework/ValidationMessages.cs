//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Validation
{        
    using System;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public static class ValidationMessages
    {
        public static void ValidatingOperator(this IAppMsgSink dst, OpUri uri, OperatorClass opclass)
            => dst.NotifyConsole(AppMsg.NoCaller($"Validating execution of the {opclass} operator {uri}"));

        public static void EvaluatedPoint<T>(this IAppMsgSink dst, string opname, T a, T b, T result)
            => dst.NotifyConsole(AppMsg.NoCaller($"{opname}({a}, {b}) = {result}"));

    }

}
