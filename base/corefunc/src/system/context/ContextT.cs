//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public abstract class Context<T> : Context
        where T : Context<T>
    {                
        protected Context(IPolyrand randomizer)
            : base(randomizer)            
        {

        }
    }   
}