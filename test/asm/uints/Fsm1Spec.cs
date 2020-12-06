//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;


    public abstract class FsmSpec<E,S,O>
    {
        public virtual IEnumerable<TransitionRule<E,S>> TransRules {get;}
        public virtual IEnumerable<OutputRule<E,S,O>> OutputRules{get;}

        public MachineTransition<E,S> TransFunc
            => TransRules.ToFunction();
    }
}