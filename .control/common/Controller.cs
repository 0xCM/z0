//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    abstract class Controller<C> : RngContext<C>, IExecutable
        where C : Controller<C>
    {        
        protected Controller(IPolyrand random)
            : base(random)
        {

        }

        protected Controller()
            : base(Rng.WyHash64(Seed64.Seed00))
        {

        }

        public abstract void Execute();       
    }
}