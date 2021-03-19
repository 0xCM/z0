//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    public readonly struct AsmChecks
    {
        public static IAsmChecker tester(IAsmContext context)
            => new AsmTester(context);
    }
}