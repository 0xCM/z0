//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ITestCaseResult
    {
        string CaseName {get;}

        Bit32 Success {get;}

        string Description {get;}

    }

    public interface ITestCaseResult<C> : ITestCaseResult
        where C: ITestCase
    {

        C Case {get;}

        string ITestCaseResult.CaseName
            => Case.CaseName;
    }
}