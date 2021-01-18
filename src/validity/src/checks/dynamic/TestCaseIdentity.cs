//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct TestCaseIdentity : ITestCaseIdentity
    {
        public static ITestCaseIdentity Service => default(TestCaseIdentity);
    }
}