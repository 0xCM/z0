//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    using static root;

    public static class WorkflowStep
    {
        public static StepStart<T> Started<T>(T data, CorrelationToken? ct = null, [Caller] string caller = null, DateTime? timestamp = null)
            => new StepStart<T>(caller, data, ct ?? CorrelationToken.New(), timestamp ?? time.now());

        public static StepEnd<T> Ended<T>(T data, CorrelationToken? ct = null,  [Caller] string caller = null, DateTime? timestamp = null)
            => new StepEnd<T>(caller, data, ct ?? CorrelationToken.Empty, timestamp ?? time.now());

        public static StepStart<T> Redefine<T>(this StepStart<T> src, T data, CorrelationToken? ct = null, [Caller] string caller = null, DateTime? timestamp = null)
            => WorkflowStep.Started(data,ct,caller,timestamp);

        public static StepEnd<T> Redefine<T>(this StepEnd<T> src, T data, CorrelationToken? ct = null, [Caller] string caller = null,  DateTime? timestamp = null)
            => WorkflowStep.Ended(data,ct,caller,timestamp);             
    }
}