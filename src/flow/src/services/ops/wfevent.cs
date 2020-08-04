//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Flow    
    {
        [MethodImpl(Inline)]
        public static WorkflowEvent<E> wfevent<E>(E body, string description)
            where E : struct, INullary<E>
                => new WorkflowEvent<E>(body, description);
    }
}