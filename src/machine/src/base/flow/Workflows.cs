//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct Workflows
    {
        [MethodImpl(Inline)]
        public static WorkflowIdentity identify<T>()
            where T : struct
                => WorkflowIdentity.define<T>();

        [MethodImpl(Inline)]
        public static WorkflowIdentity identify(PartId part, string host)
            => WorkflowIdentity.define(part,host);

        [MethodImpl(Inline)]
        public static Workflow<T> create<T>(IAppContext context, EventReceiver receiver, Action connect, Action exec)
            where T : struct
                => new Workflow<T>(context, receiver, connect, exec);                           
    }
}