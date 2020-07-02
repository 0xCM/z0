//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    using E = WorkflowError;

    public readonly struct WorkflowError : IAppError<E>
    {
        public string Description {get;}        

        [MethodImpl(Inline)]
        public WorkflowError(string description)
            => Description= description;
                        
        public E Zero 
            => Empty;

        public static WorkflowError Empty 
            => new WorkflowError(EmptyString);   
    }
}