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
            => Description = description;

        [MethodImpl(Inline)]
        public WorkflowError(string description, Exception e)
            => Description = text.concat(description, Eol, e);

        [MethodImpl(Inline)]
        public WorkflowError(Exception e)
            => Description = e.ToString();

        public string Format()
            => Description;
        
        public E Zero 
            => Empty;

        public static WorkflowError Empty 
            => new WorkflowError(EmptyString);   
    }
}