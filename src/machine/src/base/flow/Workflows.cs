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
        public static Workflow<T> create<T>(IAppContext context, EventReceiver receiver, Action runner)
            where T : struct
                => new Workflow<T>(context, receiver, runner);                           
    }
}