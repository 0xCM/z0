//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public readonly struct TestCaseIdentity : ITestCaseIdentity
    {
        public static ITestCaseIdentity Service => default(TestCaseIdentity);
    }
}