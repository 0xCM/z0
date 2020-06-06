//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public interface ITestCaseResult
    {
        string CaseName {get;}

        bit Success {get;}

        string Description {get;}

    }

    public interface ITestCaseResult<C> : ITestCaseResult
        where C: ITestCase
    {

        C Case {get;}

        string ITestCaseResult.CaseName => Case.CaseName;        
    }    
}