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

    class ConsoleControl : ConsoleApp<ConsoleControl,IAsmContext>
    {
        static IAsmContext CreateContext()
        {
            var composition = Designators.Control.Resolution.Designates.Assemble();
            return AsmContext.New(composition);
        }

        public ConsoleControl()
            : base(CreateContext(), Log.Get(LogTarget.Define(LogArea.App)))
        {

        }

        protected override void Execute(params string[] args)
            => Context.Archiver().Execute();

        public override IAssemblyResolution[] Resolved{get;}

        static void Main(params string[] args)
            => Run(args);
    }
}