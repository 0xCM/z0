//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
            
    public readonly struct WorkflowError : IAppEvent<WorkflowError, Exception>
    {        
        public static WorkflowError Empty => new WorkflowError(new Exception("empty"));
        
        public Exception Payload {get;}
        
        [MethodImpl(Inline)]
        public static implicit operator WorkflowError(Exception e)
            => Define(e);
         
        [MethodImpl(Inline)]
        public static WorkflowError Define(Exception e)
            => new WorkflowError(e);         

        [MethodImpl(Inline)]
        internal WorkflowError(Exception error)
        {
            this.Payload = error;
        }
                   
        public bool IsEmpty  => Payload == null || Payload.Message == Empty.Payload.Message;

        public string Description => IsEmpty ? string.Empty : Payload.Message;

        public WorkflowError Zero => Empty;        
    }
}