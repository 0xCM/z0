//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
 
    public interface IAsmTrigger
    {
        int Id {get;}
    }

    public interface IAsmTrigger<S> : IAsmTrigger
    {
        bool CanFire(S src);

        void FireOnMatch(S src);
    }
}