//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    
    using static Root;
    

    public class AsmCheckCountrol
    {
        IAsmContext Context {get;}

        AsmChecks Checks {get;}
        
        public static AsmCheckCountrol Create(IAsmContext context)
            => new AsmCheckCountrol(context.RootedComposition());

        AsmCheckCountrol(IAsmContext context)
        {
        
            
            this.Context = context;
            this.Checks = AsmChecks.Create(context, Rng.Pcg64(Seed64.Seed08));
        }

    }
}