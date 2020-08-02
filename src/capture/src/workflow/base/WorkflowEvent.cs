//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct WorkflowEvent
    {
        [MethodImpl(Inline)]
        public static WorkflowEvent<E> create<E>(E body, string description)
            where E : struct, INullary<E>
                => new WorkflowEvent<E>(body, description);
    }
    
    public readonly struct WorkflowEvent<E> : IAppEvent<WorkflowEvent<E>>    
        where E : struct, INullary<E>        
    {
        public E Body {get;}
        
        public string Description {get;}

        [MethodImpl(Inline)]
        public WorkflowEvent(E body, string description = null)
        {
            Body = body;
            Description = description ?? EmptyString;
        }

        public string Format()
            => Description;

        public WorkflowEvent<E> Zero 
            => new WorkflowEvent<E>(default(E).Zero);
    }
}