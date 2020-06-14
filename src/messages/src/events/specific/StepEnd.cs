//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
            
    public readonly struct StepEnd<T> : ITimeStamped, IAppEvent<StepEnd<T>>
    {        
        public string StepName {get;}
        
        public T Payload {get;}

        public CorrelationToken Correlation {get;}

        public DateTime Timestamp {get;}

        public static StepEnd<T> Empty => new StepEnd<T>(string.Empty, default, CorrelationToken.Empty, null);
        
        [MethodImpl(Inline)]
        internal StepEnd(string caller, T data, CorrelationToken ct, DateTime? timestamp)
        {
            this.StepName = text.concat(caller, "End");
            this.Payload = data;
            this.Timestamp = timestamp ?? DateTime.MinValue;
            this.Correlation = ct;
        }        
         
        public bool IsEmpty 
            => text.empty(StepName) && Timestamp == DateTime.MinValue && Correlation.IsEmpty;        

        public string Description
            => StepName;

        public StepEnd<T> Zero => Empty;

        public AppMsgColor Flair => AppMsgColor.Green;
    }
}