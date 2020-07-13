//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
            
    public readonly struct StepStart<T> : ITimeStamped, IAppEvent<StepStart<T>>
    {        
        public static StepStart<T> Empty => new StepStart<T>(string.Empty, default, CorrelationToken.Empty, null);

        public string StepName {get;}
        
        public T Payload {get;}

        public CorrelationToken Correlation {get;}

        public DateTime Timestamp {get;}
        
        [MethodImpl(Inline)]
        internal StepStart(string name, T data, CorrelationToken ct, DateTime? timestamp)
        {
            StepName = text.concat(name, "Start");
            Payload = data;
            Correlation = ct;
            Timestamp = timestamp ?? DateTime.MinValue;
        }
                   
        public bool IsEmpty 
            => text.blank(StepName) && Timestamp == DateTime.MinValue && Correlation.IsEmpty;        

        public string Description 
            => StepName;
        
        public StepStart<T> Zero 
            => Empty;        

        public AppMsgColor Flair 
            => AppMsgColor.Green;
 
    }
}