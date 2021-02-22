//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using System;

    partial struct Llvm
    {
        public readonly struct TestSubjects
        {
            public const string AliasSet = nameof(AliasSet);

            public const string AssumptionCache = nameof(AssumptionCache);
        }
    }
}