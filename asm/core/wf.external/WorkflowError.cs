//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static root;
            
    public readonly struct WorkflowError : IAppEvent<WorkflowError, Exception>
    {        
        public static WorkflowError Empty => new WorkflowError(new Exception("empty"));
        
        public Exception EventData {get;}
        
        [MethodImpl(Inline)]
        public static implicit operator WorkflowError(Exception e)
            => Define(e);
         
        [MethodImpl(Inline)]
        public static WorkflowError Define(Exception e)
            => new WorkflowError(e);         

        [MethodImpl(Inline)]
        internal WorkflowError(Exception error)
        {
            this.EventData = error;
        }
                   
        public bool IsEmpty 
            => EventData == null || EventData.Message == Empty.EventData.Message;

        public string Description
            => IsEmpty ? string.Empty : EventData.Message;
        
        public string Format()
            => Description;         
        
        public override string ToString()
            => Format();        
    }
}