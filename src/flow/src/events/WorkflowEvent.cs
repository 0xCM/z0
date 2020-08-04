//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly struct WorkflowEvent<E> : IAppEvent<WorkflowEvent<E>>    
        where E : struct, INullary<E>        
    {
        public E Body {get;}
        
        public string Description {get;}

        [MethodImpl(Inline)]
        public WorkflowEvent(E body, string description)
        {
            Body = body;
            Description = description ?? body.ToString();
        }

        public string Format()
            => Description;
    }
}