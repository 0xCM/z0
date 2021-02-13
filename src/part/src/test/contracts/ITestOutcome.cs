//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ITestOutcome
    {
        ulong Id {get;}

        bool Passed {get;}
    }

    public interface ITestOutcome<T> : ITestOutcome
        where T : struct
    {
        Index<T> CaseData {get;}
    }

    public interface ITestOutcome<C,T,R> : ITestOutcome<C>
        where C : struct
        where T : struct
        where R : struct
    {
        Index<T> Input {get;}

        Index<R> Output {get;}
    }
}