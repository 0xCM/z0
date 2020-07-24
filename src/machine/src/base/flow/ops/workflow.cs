//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static z;

    partial struct Workflows
    {
        public static Workflow<T> workflow<T>(IAppContext context, EventReceiver receiver, Action connect, Action exec)
            where T : struct
                => new Workflow<T>(context, receiver, connect, exec);                           

        public static Workflow workflow(ulong id, IAppContext context, EventReceiver receiver, Action connect, Action exec)
            => new Workflow(id, context, receiver, connect, exec);                                           
    }
}