//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    
    using static zfunc;    

    public class Context : IContext
    {

    }

    public class Context<S> : Context, IContext<S>
    {
        public Context(S state)
        {
            this.State = state;
        }

        public S State {get;}
    }
}