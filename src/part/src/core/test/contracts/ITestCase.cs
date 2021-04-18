//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface ITestCase
    {
        Name CaseName {get;}
    }

    public interface ITestCase<T> : ITestCase
        where T : struct
    {
        Index<T> CaseData {get;}
    }
}