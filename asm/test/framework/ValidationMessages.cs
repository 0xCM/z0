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
        public static void ValidatingExecution(this IAppMsgSink dst, OpUri uri)
            => dst.NotifyConsole(AppMsg.NoCaller($"Validating execution of {uri}"));
    }

}
