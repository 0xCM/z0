//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public interface ITestCaseResult
    {
        ulong Id {get;}

        bool Passed {get;}
    }

    public interface ITestCaseResult<T> : ITestCaseResult
        where T : struct, ITestCase<T>
    {
        T Case {get;}
    }
}