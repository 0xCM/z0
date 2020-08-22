//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    public readonly struct AsmTest
    {
        public static IAsmTester checker(IAsmContext context)
            => new AsmChecks(context);

        public static TAsmTester tester(IAsmContext context)
            => new AsmTester(context);

        public static TestDynamicVectors vectors(IAsmContext context,Type host, BufferToken buffer)
            => new TestDynamicVectors(context, host, buffer);
    }
}