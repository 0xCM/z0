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
        [MethodImpl(Inline), Op]
        public ref readonly WorkflowIdentity identify(byte id)
            => ref Known[id];

        [MethodImpl(Inline), Op]
        public WorkflowIdentity[] identify()
            => Known;
    }
}