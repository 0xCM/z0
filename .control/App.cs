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

    class ConsoleControl : ConsoleApp<ConsoleControl>
    {
        public ConsoleControl()
            : base(Rng.WyHash64(Seed64.Seed00))
        {
            Resolved = Designators.Control.Designated.Designates.ToArray();
            AsmCtx = AsmContext.New(AssemblyComposition.Define(Resolved));
        }

        readonly IAsmContext AsmCtx;

        protected override void Execute(params string[] args)
            => AsmArchiveControl.Create(AsmCtx).Execute();            

        public override IAssemblyDesignator[] Resolved{get;}

        static void Main(params string[] args)
            => Run(args);
    }
}