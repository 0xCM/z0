//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
            
    public readonly struct StepStart<T> : ITimeStamped, IAppEvent<StepStart<T>, T>
    {        
        public static StepStart<T> Empty => new StepStart<T>(string.Empty, default, CorrelationToken.Empty, null);

        public string StepName {get;}
        
        public T Payload {get;}

        public CorrelationToken Correlation {get;}

        public DateTime Timestamp {get;}
        
        [MethodImpl(Inline)]
        internal StepStart(string name, T data, CorrelationToken ct, DateTime? timestamp)
        {
            this.StepName = text.concat(name, "Start");
            this.Payload = data;
            this.Correlation = ct;
            this.Timestamp = timestamp ?? DateTime.MinValue;
        }
                   
        public bool IsEmpty 
            => text.empty(StepName) && Timestamp == DateTime.MinValue && Correlation.IsEmpty;        

        public string Description => StepName;
        
        public StepStart<T> Zero => Empty;        
 
    }
}