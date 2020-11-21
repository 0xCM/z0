//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    public readonly struct TestCaseIdentity : ITestCaseIdentity
    {
        public static ITestCaseIdentity Service => default(TestCaseIdentity);
    }
}