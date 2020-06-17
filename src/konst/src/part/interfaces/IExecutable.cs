//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IExecutable<A>
    {
        void Execute(params A[] args);
    }


    /// <summary>
    /// Characterizes a thread of execution control that has whatever context it needs, if any, to do something of use
    /// </summary>
    public interface IExecutable : IExecutable<string>
    {

    }
}