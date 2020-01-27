//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using Z0.Designators;

    using static zfunc;

    abstract class Controller<C> : Context<C>
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

        protected Option<IOperationCatalog> FindCatalog(AssemblyId id)
            =>  Designators.Control.Designated.FindCatalog(id);
            


    }
}