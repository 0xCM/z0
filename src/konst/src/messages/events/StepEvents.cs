//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    public static class StepEvents
    {
        public static StepStart<T> Started<T>(T data, CorrelationToken? ct = null, [Caller] string caller = null, DateTime? timestamp = null)
            => new StepStart<T>(caller, data, ct ?? CorrelationToken.create(), timestamp ?? Time.now());

        public static StepEnd<T> Ended<T>(T data, CorrelationToken? ct = null,  [Caller] string caller = null, DateTime? timestamp = null)
            => new StepEnd<T>(caller, data, ct ?? CorrelationToken.Empty, timestamp ?? Time.now());

        public static StepStart<T> Redefine<T>(this StepStart<T> src, T data, CorrelationToken? ct = null, [Caller] string caller = null, DateTime? timestamp = null)
            => StepEvents.Started(data,ct,caller,timestamp);

        public static StepEnd<T> Redefine<T>(this StepEnd<T> src, T data, CorrelationToken? ct = null, [Caller] string caller = null,  DateTime? timestamp = null)
            => StepEvents.Ended(data,ct,caller,timestamp);             
    }
}